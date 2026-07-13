#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /cdn/resource-manager/Microsoft.Cdn/Cdn/stable/2023-05-01/afdx.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets/{ruleSetName}/rules/{ruleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501RuleList : IKubernetesObject<V1ListMeta>, IItems<V1api20230501Rule>
{
    public const string KubeApiVersion = "v1api20230501";
    public const string KubeKind = "RuleList";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "rules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.com/v1api20230501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230501Rule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230501Rule> Items { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsCacheExpirationNameEnum>))]
public enum V1api20230501RuleSpecActionsCacheExpirationNameEnum
{
    [EnumMember(Value = "CacheExpiration"), JsonStringEnumMemberName("CacheExpiration")]
    CacheExpiration
}

/// <summary>CacheBehavior: Caching behavior for the requests</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsCacheExpirationParametersCacheBehaviorEnum>))]
public enum V1api20230501RuleSpecActionsCacheExpirationParametersCacheBehaviorEnum
{
    [EnumMember(Value = "BypassCache"), JsonStringEnumMemberName("BypassCache")]
    BypassCache,
    [EnumMember(Value = "Override"), JsonStringEnumMemberName("Override")]
    Override,
    [EnumMember(Value = "SetIfMissing"), JsonStringEnumMemberName("SetIfMissing")]
    SetIfMissing
}

/// <summary>CacheType: The level at which the content needs to be cached.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsCacheExpirationParametersCacheTypeEnum>))]
public enum V1api20230501RuleSpecActionsCacheExpirationParametersCacheTypeEnum
{
    [EnumMember(Value = "All"), JsonStringEnumMemberName("All")]
    All
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsCacheExpirationParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecActionsCacheExpirationParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleCacheExpirationActionParameters"), JsonStringEnumMemberName("DeliveryRuleCacheExpirationActionParameters")]
    DeliveryRuleCacheExpirationActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsCacheExpirationParameters
{
    /// <summary>CacheBehavior: Caching behavior for the requests</summary>
    [JsonPropertyName("cacheBehavior")]
    public required V1api20230501RuleSpecActionsCacheExpirationParametersCacheBehaviorEnum CacheBehavior { get; set; }

    /// <summary>CacheDuration: The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>CacheType: The level at which the content needs to be cached.</summary>
    [JsonPropertyName("cacheType")]
    public required V1api20230501RuleSpecActionsCacheExpirationParametersCacheTypeEnum CacheType { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecActionsCacheExpirationParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>CacheExpiration: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsCacheExpiration
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecActionsCacheExpirationNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecActionsCacheExpirationParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsCacheKeyQueryStringNameEnum>))]
public enum V1api20230501RuleSpecActionsCacheKeyQueryStringNameEnum
{
    [EnumMember(Value = "CacheKeyQueryString"), JsonStringEnumMemberName("CacheKeyQueryString")]
    CacheKeyQueryString
}

/// <summary>QueryStringBehavior: Caching behavior for the requests</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsCacheKeyQueryStringParametersQueryStringBehaviorEnum>))]
public enum V1api20230501RuleSpecActionsCacheKeyQueryStringParametersQueryStringBehaviorEnum
{
    [EnumMember(Value = "Exclude"), JsonStringEnumMemberName("Exclude")]
    Exclude,
    [EnumMember(Value = "ExcludeAll"), JsonStringEnumMemberName("ExcludeAll")]
    ExcludeAll,
    [EnumMember(Value = "Include"), JsonStringEnumMemberName("Include")]
    Include,
    [EnumMember(Value = "IncludeAll"), JsonStringEnumMemberName("IncludeAll")]
    IncludeAll
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsCacheKeyQueryStringParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecActionsCacheKeyQueryStringParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleCacheKeyQueryStringBehaviorActionParameters"), JsonStringEnumMemberName("DeliveryRuleCacheKeyQueryStringBehaviorActionParameters")]
    DeliveryRuleCacheKeyQueryStringBehaviorActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsCacheKeyQueryStringParameters
{
    /// <summary>QueryParameters: query parameters to include or exclude (comma separated).</summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary>QueryStringBehavior: Caching behavior for the requests</summary>
    [JsonPropertyName("queryStringBehavior")]
    public required V1api20230501RuleSpecActionsCacheKeyQueryStringParametersQueryStringBehaviorEnum QueryStringBehavior { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecActionsCacheKeyQueryStringParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>CacheKeyQueryString: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsCacheKeyQueryString
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecActionsCacheKeyQueryStringNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecActionsCacheKeyQueryStringParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsModifyRequestHeaderNameEnum>))]
public enum V1api20230501RuleSpecActionsModifyRequestHeaderNameEnum
{
    [EnumMember(Value = "ModifyRequestHeader"), JsonStringEnumMemberName("ModifyRequestHeader")]
    ModifyRequestHeader
}

/// <summary>HeaderAction: Action to perform</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsModifyRequestHeaderParametersHeaderActionEnum>))]
public enum V1api20230501RuleSpecActionsModifyRequestHeaderParametersHeaderActionEnum
{
    [EnumMember(Value = "Append"), JsonStringEnumMemberName("Append")]
    Append,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Overwrite"), JsonStringEnumMemberName("Overwrite")]
    Overwrite
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsModifyRequestHeaderParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecActionsModifyRequestHeaderParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleHeaderActionParameters"), JsonStringEnumMemberName("DeliveryRuleHeaderActionParameters")]
    DeliveryRuleHeaderActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsModifyRequestHeaderParameters
{
    /// <summary>HeaderAction: Action to perform</summary>
    [JsonPropertyName("headerAction")]
    public required V1api20230501RuleSpecActionsModifyRequestHeaderParametersHeaderActionEnum HeaderAction { get; set; }

    /// <summary>HeaderName: Name of the header to modify</summary>
    [JsonPropertyName("headerName")]
    public required string HeaderName { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecActionsModifyRequestHeaderParametersTypeNameEnum TypeName { get; set; }

    /// <summary>Value: Value for the specified action</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ModifyRequestHeader: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsModifyRequestHeader
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecActionsModifyRequestHeaderNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecActionsModifyRequestHeaderParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsModifyResponseHeaderNameEnum>))]
public enum V1api20230501RuleSpecActionsModifyResponseHeaderNameEnum
{
    [EnumMember(Value = "ModifyResponseHeader"), JsonStringEnumMemberName("ModifyResponseHeader")]
    ModifyResponseHeader
}

/// <summary>HeaderAction: Action to perform</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsModifyResponseHeaderParametersHeaderActionEnum>))]
public enum V1api20230501RuleSpecActionsModifyResponseHeaderParametersHeaderActionEnum
{
    [EnumMember(Value = "Append"), JsonStringEnumMemberName("Append")]
    Append,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Overwrite"), JsonStringEnumMemberName("Overwrite")]
    Overwrite
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsModifyResponseHeaderParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecActionsModifyResponseHeaderParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleHeaderActionParameters"), JsonStringEnumMemberName("DeliveryRuleHeaderActionParameters")]
    DeliveryRuleHeaderActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsModifyResponseHeaderParameters
{
    /// <summary>HeaderAction: Action to perform</summary>
    [JsonPropertyName("headerAction")]
    public required V1api20230501RuleSpecActionsModifyResponseHeaderParametersHeaderActionEnum HeaderAction { get; set; }

    /// <summary>HeaderName: Name of the header to modify</summary>
    [JsonPropertyName("headerName")]
    public required string HeaderName { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecActionsModifyResponseHeaderParametersTypeNameEnum TypeName { get; set; }

    /// <summary>Value: Value for the specified action</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ModifyResponseHeader: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsModifyResponseHeader
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecActionsModifyResponseHeaderNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecActionsModifyResponseHeaderParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsOriginGroupOverrideNameEnum>))]
public enum V1api20230501RuleSpecActionsOriginGroupOverrideNameEnum
{
    [EnumMember(Value = "OriginGroupOverride"), JsonStringEnumMemberName("OriginGroupOverride")]
    OriginGroupOverride
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsOriginGroupOverrideParametersOriginGroupReference
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

/// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsOriginGroupOverrideParametersOriginGroup
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501RuleSpecActionsOriginGroupOverrideParametersOriginGroupReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsOriginGroupOverrideParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecActionsOriginGroupOverrideParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleOriginGroupOverrideActionParameters"), JsonStringEnumMemberName("DeliveryRuleOriginGroupOverrideActionParameters")]
    DeliveryRuleOriginGroupOverrideActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsOriginGroupOverrideParameters
{
    /// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup.</summary>
    [JsonPropertyName("originGroup")]
    public required V1api20230501RuleSpecActionsOriginGroupOverrideParametersOriginGroup OriginGroup { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecActionsOriginGroupOverrideParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>OriginGroupOverride: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsOriginGroupOverride
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecActionsOriginGroupOverrideNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecActionsOriginGroupOverrideParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsRouteConfigurationOverrideNameEnum>))]
public enum V1api20230501RuleSpecActionsRouteConfigurationOverrideNameEnum
{
    [EnumMember(Value = "RouteConfigurationOverride"), JsonStringEnumMemberName("RouteConfigurationOverride")]
    RouteConfigurationOverride
}

/// <summary>CacheBehavior: Caching behavior for the requests</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersCacheConfigurationCacheBehaviorEnum>))]
public enum V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersCacheConfigurationCacheBehaviorEnum
{
    [EnumMember(Value = "HonorOrigin"), JsonStringEnumMemberName("HonorOrigin")]
    HonorOrigin,
    [EnumMember(Value = "OverrideAlways"), JsonStringEnumMemberName("OverrideAlways")]
    OverrideAlways,
    [EnumMember(Value = "OverrideIfOriginMissing"), JsonStringEnumMemberName("OverrideIfOriginMissing")]
    OverrideIfOriginMissing
}

/// <summary>
/// IsCompressionEnabled: Indicates whether content compression is enabled. If compression is enabled, content will be
/// served as compressed if user requests for a compressed version. Content won&apos;t be compressed on AzureFrontDoor when
/// requested content is smaller than 1 byte or larger than 1 MB.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersCacheConfigurationIsCompressionEnabledEnum>))]
public enum V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersCacheConfigurationIsCompressionEnabledEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// QueryStringCachingBehavior: Defines how Frontdoor caches requests that include query strings. You can ignore any query
/// strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query
/// strings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersCacheConfigurationQueryStringCachingBehaviorEnum>))]
public enum V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersCacheConfigurationQueryStringCachingBehaviorEnum
{
    [EnumMember(Value = "IgnoreQueryString"), JsonStringEnumMemberName("IgnoreQueryString")]
    IgnoreQueryString,
    [EnumMember(Value = "IgnoreSpecifiedQueryStrings"), JsonStringEnumMemberName("IgnoreSpecifiedQueryStrings")]
    IgnoreSpecifiedQueryStrings,
    [EnumMember(Value = "IncludeSpecifiedQueryStrings"), JsonStringEnumMemberName("IncludeSpecifiedQueryStrings")]
    IncludeSpecifiedQueryStrings,
    [EnumMember(Value = "UseQueryString"), JsonStringEnumMemberName("UseQueryString")]
    UseQueryString
}

/// <summary>
/// CacheConfiguration: The caching configuration associated with this rule. To disable caching, do not provide a
/// cacheConfiguration object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersCacheConfiguration
{
    /// <summary>CacheBehavior: Caching behavior for the requests</summary>
    [JsonPropertyName("cacheBehavior")]
    public V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersCacheConfigurationCacheBehaviorEnum? CacheBehavior { get; set; }

    /// <summary>CacheDuration: The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>
    /// IsCompressionEnabled: Indicates whether content compression is enabled. If compression is enabled, content will be
    /// served as compressed if user requests for a compressed version. Content won&apos;t be compressed on AzureFrontDoor when
    /// requested content is smaller than 1 byte or larger than 1 MB.
    /// </summary>
    [JsonPropertyName("isCompressionEnabled")]
    public V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersCacheConfigurationIsCompressionEnabledEnum? IsCompressionEnabled { get; set; }

    /// <summary>QueryParameters: query parameters to include or exclude (comma separated).</summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary>
    /// QueryStringCachingBehavior: Defines how Frontdoor caches requests that include query strings. You can ignore any query
    /// strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query
    /// strings.
    /// </summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersCacheConfigurationQueryStringCachingBehaviorEnum? QueryStringCachingBehavior { get; set; }
}

/// <summary>ForwardingProtocol: Protocol this rule will use when forwarding traffic to backends.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverrideForwardingProtocolEnum>))]
public enum V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverrideForwardingProtocolEnum
{
    [EnumMember(Value = "HttpOnly"), JsonStringEnumMemberName("HttpOnly")]
    HttpOnly,
    [EnumMember(Value = "HttpsOnly"), JsonStringEnumMemberName("HttpsOnly")]
    HttpsOnly,
    [EnumMember(Value = "MatchRequest"), JsonStringEnumMemberName("MatchRequest")]
    MatchRequest
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroupReference
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

/// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup on route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroupReference? Reference { get; set; }
}

/// <summary>
/// OriginGroupOverride: A reference to the origin group override configuration. Leave empty to use the default origin group
/// on route.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverride
{
    /// <summary>ForwardingProtocol: Protocol this rule will use when forwarding traffic to backends.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverrideForwardingProtocolEnum? ForwardingProtocol { get; set; }

    /// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup on route.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup? OriginGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRouteConfigurationOverrideActionParameters"), JsonStringEnumMemberName("DeliveryRuleRouteConfigurationOverrideActionParameters")]
    DeliveryRuleRouteConfigurationOverrideActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsRouteConfigurationOverrideParameters
{
    /// <summary>
    /// CacheConfiguration: The caching configuration associated with this rule. To disable caching, do not provide a
    /// cacheConfiguration object.
    /// </summary>
    [JsonPropertyName("cacheConfiguration")]
    public V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersCacheConfiguration? CacheConfiguration { get; set; }

    /// <summary>
    /// OriginGroupOverride: A reference to the origin group override configuration. Leave empty to use the default origin group
    /// on route.
    /// </summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverride? OriginGroupOverride { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecActionsRouteConfigurationOverrideParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RouteConfigurationOverride: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsRouteConfigurationOverride
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecActionsRouteConfigurationOverrideNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecActionsRouteConfigurationOverrideParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsUrlRedirectNameEnum>))]
public enum V1api20230501RuleSpecActionsUrlRedirectNameEnum
{
    [EnumMember(Value = "UrlRedirect"), JsonStringEnumMemberName("UrlRedirect")]
    UrlRedirect
}

/// <summary>DestinationProtocol: Protocol to use for the redirect. The default value is MatchRequest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsUrlRedirectParametersDestinationProtocolEnum>))]
public enum V1api20230501RuleSpecActionsUrlRedirectParametersDestinationProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https,
    [EnumMember(Value = "MatchRequest"), JsonStringEnumMemberName("MatchRequest")]
    MatchRequest
}

/// <summary>RedirectType: The redirect type the rule will use when redirecting traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsUrlRedirectParametersRedirectTypeEnum>))]
public enum V1api20230501RuleSpecActionsUrlRedirectParametersRedirectTypeEnum
{
    [EnumMember(Value = "Found"), JsonStringEnumMemberName("Found")]
    Found,
    [EnumMember(Value = "Moved"), JsonStringEnumMemberName("Moved")]
    Moved,
    [EnumMember(Value = "PermanentRedirect"), JsonStringEnumMemberName("PermanentRedirect")]
    PermanentRedirect,
    [EnumMember(Value = "TemporaryRedirect"), JsonStringEnumMemberName("TemporaryRedirect")]
    TemporaryRedirect
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsUrlRedirectParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecActionsUrlRedirectParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleUrlRedirectActionParameters"), JsonStringEnumMemberName("DeliveryRuleUrlRedirectActionParameters")]
    DeliveryRuleUrlRedirectActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsUrlRedirectParameters
{
    /// <summary>
    /// CustomFragment: Fragment to add to the redirect URL. Fragment is the part of the URL that comes after #. Do not include
    /// the #.
    /// </summary>
    [JsonPropertyName("customFragment")]
    public string? CustomFragment { get; set; }

    /// <summary>CustomHostname: Host to redirect. Leave empty to use the incoming host as the destination host.</summary>
    [JsonPropertyName("customHostname")]
    public string? CustomHostname { get; set; }

    /// <summary>
    /// CustomPath: The full path to redirect. Path cannot be empty and must start with /. Leave empty to use the incoming path
    /// as destination path.
    /// </summary>
    [JsonPropertyName("customPath")]
    public string? CustomPath { get; set; }

    /// <summary>
    /// CustomQueryString: The set of query strings to be placed in the redirect URL. Setting this value would replace any
    /// existing query string; leave empty to preserve the incoming query string. Query string must be in &lt;key&gt;=&lt;value&gt; format.
    /// ? and &amp; will be added automatically so do not include them.
    /// </summary>
    [JsonPropertyName("customQueryString")]
    public string? CustomQueryString { get; set; }

    /// <summary>DestinationProtocol: Protocol to use for the redirect. The default value is MatchRequest</summary>
    [JsonPropertyName("destinationProtocol")]
    public V1api20230501RuleSpecActionsUrlRedirectParametersDestinationProtocolEnum? DestinationProtocol { get; set; }

    /// <summary>RedirectType: The redirect type the rule will use when redirecting traffic.</summary>
    [JsonPropertyName("redirectType")]
    public required V1api20230501RuleSpecActionsUrlRedirectParametersRedirectTypeEnum RedirectType { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecActionsUrlRedirectParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>UrlRedirect: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsUrlRedirect
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecActionsUrlRedirectNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecActionsUrlRedirectParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsUrlRewriteNameEnum>))]
public enum V1api20230501RuleSpecActionsUrlRewriteNameEnum
{
    [EnumMember(Value = "UrlRewrite"), JsonStringEnumMemberName("UrlRewrite")]
    UrlRewrite
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsUrlRewriteParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecActionsUrlRewriteParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleUrlRewriteActionParameters"), JsonStringEnumMemberName("DeliveryRuleUrlRewriteActionParameters")]
    DeliveryRuleUrlRewriteActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsUrlRewriteParameters
{
    /// <summary>Destination: Define the relative URL to which the above requests will be rewritten by.</summary>
    [JsonPropertyName("destination")]
    public required string Destination { get; set; }

    /// <summary>PreserveUnmatchedPath: Whether to preserve unmatched path. Default value is true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>
    /// SourcePattern: define a request URI pattern that identifies the type of requests that may be rewritten. If value is
    /// blank, all strings are matched.
    /// </summary>
    [JsonPropertyName("sourcePattern")]
    public required string SourcePattern { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecActionsUrlRewriteParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>UrlRewrite: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsUrlRewrite
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecActionsUrlRewriteNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecActionsUrlRewriteParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsUrlSigningNameEnum>))]
public enum V1api20230501RuleSpecActionsUrlSigningNameEnum
{
    [EnumMember(Value = "UrlSigning"), JsonStringEnumMemberName("UrlSigning")]
    UrlSigning
}

/// <summary>Algorithm: Algorithm to use for URL signing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsUrlSigningParametersAlgorithmEnum>))]
public enum V1api20230501RuleSpecActionsUrlSigningParametersAlgorithmEnum
{
    [EnumMember(Value = "SHA256"), JsonStringEnumMemberName("SHA256")]
    SHA256
}

/// <summary>ParamIndicator: Indicates the purpose of the parameter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsUrlSigningParametersParameterNameOverrideParamIndicatorEnum>))]
public enum V1api20230501RuleSpecActionsUrlSigningParametersParameterNameOverrideParamIndicatorEnum
{
    [EnumMember(Value = "Expires"), JsonStringEnumMemberName("Expires")]
    Expires,
    [EnumMember(Value = "KeyId"), JsonStringEnumMemberName("KeyId")]
    KeyId,
    [EnumMember(Value = "Signature"), JsonStringEnumMemberName("Signature")]
    Signature
}

/// <summary>Defines how to identify a parameter for a specific purpose e.g. expires</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsUrlSigningParametersParameterNameOverride
{
    /// <summary>ParamIndicator: Indicates the purpose of the parameter</summary>
    [JsonPropertyName("paramIndicator")]
    public required V1api20230501RuleSpecActionsUrlSigningParametersParameterNameOverrideParamIndicatorEnum ParamIndicator { get; set; }

    /// <summary>ParamName: Parameter name</summary>
    [JsonPropertyName("paramName")]
    public required string ParamName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecActionsUrlSigningParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecActionsUrlSigningParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleUrlSigningActionParameters"), JsonStringEnumMemberName("DeliveryRuleUrlSigningActionParameters")]
    DeliveryRuleUrlSigningActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsUrlSigningParameters
{
    /// <summary>Algorithm: Algorithm to use for URL signing</summary>
    [JsonPropertyName("algorithm")]
    public V1api20230501RuleSpecActionsUrlSigningParametersAlgorithmEnum? Algorithm { get; set; }

    /// <summary>ParameterNameOverride: Defines which query string parameters in the url to be considered for expires, key id etc.</summary>
    [JsonPropertyName("parameterNameOverride")]
    public IList<V1api20230501RuleSpecActionsUrlSigningParametersParameterNameOverride>? ParameterNameOverride { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecActionsUrlSigningParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>UrlSigning: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActionsUrlSigning
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecActionsUrlSigningNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecActionsUrlSigningParameters Parameters { get; set; }
}

/// <summary>An action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecActions
{
    /// <summary>CacheExpiration: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cacheExpiration")]
    public V1api20230501RuleSpecActionsCacheExpiration? CacheExpiration { get; set; }

    /// <summary>CacheKeyQueryString: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cacheKeyQueryString")]
    public V1api20230501RuleSpecActionsCacheKeyQueryString? CacheKeyQueryString { get; set; }

    /// <summary>ModifyRequestHeader: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("modifyRequestHeader")]
    public V1api20230501RuleSpecActionsModifyRequestHeader? ModifyRequestHeader { get; set; }

    /// <summary>ModifyResponseHeader: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("modifyResponseHeader")]
    public V1api20230501RuleSpecActionsModifyResponseHeader? ModifyResponseHeader { get; set; }

    /// <summary>OriginGroupOverride: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20230501RuleSpecActionsOriginGroupOverride? OriginGroupOverride { get; set; }

    /// <summary>RouteConfigurationOverride: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("routeConfigurationOverride")]
    public V1api20230501RuleSpecActionsRouteConfigurationOverride? RouteConfigurationOverride { get; set; }

    /// <summary>UrlRedirect: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlRedirect")]
    public V1api20230501RuleSpecActionsUrlRedirect? UrlRedirect { get; set; }

    /// <summary>UrlRewrite: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlRewrite")]
    public V1api20230501RuleSpecActionsUrlRewrite? UrlRewrite { get; set; }

    /// <summary>UrlSigning: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlSigning")]
    public V1api20230501RuleSpecActionsUrlSigning? UrlSigning { get; set; }
}

/// <summary>
/// MatchProcessingBehavior: If this rule is a match should the rules engine continue running the remaining rules or stop.
/// If not present, defaults to Continue.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecMatchProcessingBehaviorEnum>))]
public enum V1api20230501RuleSpecMatchProcessingBehaviorEnum
{
    [EnumMember(Value = "Continue"), JsonStringEnumMemberName("Continue")]
    Continue,
    [EnumMember(Value = "Stop"), JsonStringEnumMemberName("Stop")]
    Stop
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230501RuleSpecOperatorSpecSecretExpressions
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
public partial class V1api20230501RuleSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230501RuleSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230501RuleSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a cdn.azure.com/RuleSet resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsClientPortNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsClientPortNameEnum
{
    [EnumMember(Value = "ClientPort"), JsonStringEnumMemberName("ClientPort")]
    ClientPort
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsClientPortParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsClientPortParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsClientPortParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsClientPortParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsClientPortParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsClientPortParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleClientPortConditionParameters"), JsonStringEnumMemberName("DeliveryRuleClientPortConditionParameters")]
    DeliveryRuleClientPortConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsClientPortParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsClientPortParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsClientPortParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsClientPortParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>ClientPort: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsClientPort
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsClientPortNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsClientPortParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsCookiesNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsCookiesNameEnum
{
    [EnumMember(Value = "Cookies"), JsonStringEnumMemberName("Cookies")]
    Cookies
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsCookiesParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsCookiesParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsCookiesParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsCookiesParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsCookiesParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsCookiesParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleCookiesConditionParameters"), JsonStringEnumMemberName("DeliveryRuleCookiesConditionParameters")]
    DeliveryRuleCookiesConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsCookiesParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsCookiesParametersOperatorEnum Operator { get; set; }

    /// <summary>Selector: Name of Cookies to be matched</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsCookiesParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsCookiesParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>Cookies: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsCookies
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsCookiesNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsCookiesParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsHostNameNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsHostNameNameEnum
{
    [EnumMember(Value = "HostName"), JsonStringEnumMemberName("HostName")]
    HostName
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsHostNameParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsHostNameParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsHostNameParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsHostNameParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsHostNameParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsHostNameParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleHostNameConditionParameters"), JsonStringEnumMemberName("DeliveryRuleHostNameConditionParameters")]
    DeliveryRuleHostNameConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsHostNameParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsHostNameParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsHostNameParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsHostNameParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>HostName: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsHostName
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsHostNameNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsHostNameParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsHttpVersionNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsHttpVersionNameEnum
{
    [EnumMember(Value = "HttpVersion"), JsonStringEnumMemberName("HttpVersion")]
    HttpVersion
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsHttpVersionParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsHttpVersionParametersOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsHttpVersionParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsHttpVersionParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsHttpVersionParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsHttpVersionParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleHttpVersionConditionParameters"), JsonStringEnumMemberName("DeliveryRuleHttpVersionConditionParameters")]
    DeliveryRuleHttpVersionConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsHttpVersionParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsHttpVersionParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsHttpVersionParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsHttpVersionParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>HttpVersion: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsHttpVersion
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsHttpVersionNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsHttpVersionParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsIsDeviceNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsIsDeviceNameEnum
{
    [EnumMember(Value = "IsDevice"), JsonStringEnumMemberName("IsDevice")]
    IsDevice
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsIsDeviceParametersMatchValuesEnum>))]
public enum V1api20230501RuleSpecRuleconditionsIsDeviceParametersMatchValuesEnum
{
    [EnumMember(Value = "Desktop"), JsonStringEnumMemberName("Desktop")]
    Desktop,
    [EnumMember(Value = "Mobile"), JsonStringEnumMemberName("Mobile")]
    Mobile
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsIsDeviceParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsIsDeviceParametersOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsIsDeviceParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsIsDeviceParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsIsDeviceParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsIsDeviceParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleIsDeviceConditionParameters"), JsonStringEnumMemberName("DeliveryRuleIsDeviceConditionParameters")]
    DeliveryRuleIsDeviceConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsIsDeviceParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<V1api20230501RuleSpecRuleconditionsIsDeviceParametersMatchValuesEnum>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsIsDeviceParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsIsDeviceParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsIsDeviceParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>IsDevice: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsIsDevice
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsIsDeviceNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsIsDeviceParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsPostArgsNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsPostArgsNameEnum
{
    [EnumMember(Value = "PostArgs"), JsonStringEnumMemberName("PostArgs")]
    PostArgs
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsPostArgsParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsPostArgsParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsPostArgsParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsPostArgsParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsPostArgsParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsPostArgsParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRulePostArgsConditionParameters"), JsonStringEnumMemberName("DeliveryRulePostArgsConditionParameters")]
    DeliveryRulePostArgsConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsPostArgsParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsPostArgsParametersOperatorEnum Operator { get; set; }

    /// <summary>Selector: Name of PostArg to be matched</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsPostArgsParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsPostArgsParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>PostArgs: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsPostArgs
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsPostArgsNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsPostArgsParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsQueryStringNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsQueryStringNameEnum
{
    [EnumMember(Value = "QueryString"), JsonStringEnumMemberName("QueryString")]
    QueryString
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsQueryStringParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsQueryStringParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsQueryStringParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsQueryStringParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsQueryStringParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsQueryStringParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleQueryStringConditionParameters"), JsonStringEnumMemberName("DeliveryRuleQueryStringConditionParameters")]
    DeliveryRuleQueryStringConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsQueryStringParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsQueryStringParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsQueryStringParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsQueryStringParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>QueryString: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsQueryString
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsQueryStringNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsQueryStringParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRemoteAddressNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRemoteAddressNameEnum
{
    [EnumMember(Value = "RemoteAddress"), JsonStringEnumMemberName("RemoteAddress")]
    RemoteAddress
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRemoteAddressParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRemoteAddressParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "GeoMatch"), JsonStringEnumMemberName("GeoMatch")]
    GeoMatch,
    [EnumMember(Value = "IPMatch"), JsonStringEnumMemberName("IPMatch")]
    IPMatch
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRemoteAddressParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRemoteAddressParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRemoteAddressParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRemoteAddressParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRemoteAddressConditionParameters"), JsonStringEnumMemberName("DeliveryRuleRemoteAddressConditionParameters")]
    DeliveryRuleRemoteAddressConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsRemoteAddressParameters
{
    /// <summary>
    /// MatchValues: Match values to match against. The operator will apply to each value in here with OR semantics. If any of
    /// them match the variable with the given operator this match condition is considered a match.
    /// </summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsRemoteAddressParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsRemoteAddressParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsRemoteAddressParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RemoteAddress: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsRemoteAddress
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsRemoteAddressNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsRemoteAddressParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestBodyNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestBodyNameEnum
{
    [EnumMember(Value = "RequestBody"), JsonStringEnumMemberName("RequestBody")]
    RequestBody
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestBodyParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestBodyParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestBodyParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestBodyParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestBodyParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestBodyParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRequestBodyConditionParameters"), JsonStringEnumMemberName("DeliveryRuleRequestBodyConditionParameters")]
    DeliveryRuleRequestBodyConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsRequestBodyParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsRequestBodyParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsRequestBodyParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsRequestBodyParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RequestBody: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsRequestBody
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsRequestBodyNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsRequestBodyParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestHeaderNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestHeaderNameEnum
{
    [EnumMember(Value = "RequestHeader"), JsonStringEnumMemberName("RequestHeader")]
    RequestHeader
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestHeaderParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestHeaderParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestHeaderParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestHeaderParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestHeaderParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestHeaderParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRequestHeaderConditionParameters"), JsonStringEnumMemberName("DeliveryRuleRequestHeaderConditionParameters")]
    DeliveryRuleRequestHeaderConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsRequestHeaderParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsRequestHeaderParametersOperatorEnum Operator { get; set; }

    /// <summary>Selector: Name of Header to be matched</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsRequestHeaderParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsRequestHeaderParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RequestHeader: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsRequestHeader
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsRequestHeaderNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsRequestHeaderParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestMethodNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestMethodNameEnum
{
    [EnumMember(Value = "RequestMethod"), JsonStringEnumMemberName("RequestMethod")]
    RequestMethod
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestMethodParametersMatchValuesEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestMethodParametersMatchValuesEnum
{
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE,
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "HEAD"), JsonStringEnumMemberName("HEAD")]
    HEAD,
    [EnumMember(Value = "OPTIONS"), JsonStringEnumMemberName("OPTIONS")]
    OPTIONS,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST,
    [EnumMember(Value = "PUT"), JsonStringEnumMemberName("PUT")]
    PUT,
    [EnumMember(Value = "TRACE"), JsonStringEnumMemberName("TRACE")]
    TRACE
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestMethodParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestMethodParametersOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestMethodParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestMethodParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestMethodParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestMethodParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRequestMethodConditionParameters"), JsonStringEnumMemberName("DeliveryRuleRequestMethodConditionParameters")]
    DeliveryRuleRequestMethodConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsRequestMethodParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<V1api20230501RuleSpecRuleconditionsRequestMethodParametersMatchValuesEnum>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsRequestMethodParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsRequestMethodParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsRequestMethodParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RequestMethod: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsRequestMethod
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsRequestMethodNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsRequestMethodParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestSchemeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestSchemeNameEnum
{
    [EnumMember(Value = "RequestScheme"), JsonStringEnumMemberName("RequestScheme")]
    RequestScheme
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestSchemeParametersMatchValuesEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestSchemeParametersMatchValuesEnum
{
    [EnumMember(Value = "HTTP"), JsonStringEnumMemberName("HTTP")]
    HTTP,
    [EnumMember(Value = "HTTPS"), JsonStringEnumMemberName("HTTPS")]
    HTTPS
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestSchemeParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestSchemeParametersOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestSchemeParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestSchemeParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestSchemeParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestSchemeParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRequestSchemeConditionParameters"), JsonStringEnumMemberName("DeliveryRuleRequestSchemeConditionParameters")]
    DeliveryRuleRequestSchemeConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsRequestSchemeParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<V1api20230501RuleSpecRuleconditionsRequestSchemeParametersMatchValuesEnum>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsRequestSchemeParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsRequestSchemeParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsRequestSchemeParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RequestScheme: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsRequestScheme
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsRequestSchemeNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsRequestSchemeParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestUriNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestUriNameEnum
{
    [EnumMember(Value = "RequestUri"), JsonStringEnumMemberName("RequestUri")]
    RequestUri
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestUriParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestUriParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestUriParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestUriParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsRequestUriParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsRequestUriParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRequestUriConditionParameters"), JsonStringEnumMemberName("DeliveryRuleRequestUriConditionParameters")]
    DeliveryRuleRequestUriConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsRequestUriParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsRequestUriParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsRequestUriParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsRequestUriParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RequestUri: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsRequestUri
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsRequestUriNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsRequestUriParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsServerPortNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsServerPortNameEnum
{
    [EnumMember(Value = "ServerPort"), JsonStringEnumMemberName("ServerPort")]
    ServerPort
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsServerPortParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsServerPortParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsServerPortParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsServerPortParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsServerPortParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsServerPortParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleServerPortConditionParameters"), JsonStringEnumMemberName("DeliveryRuleServerPortConditionParameters")]
    DeliveryRuleServerPortConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsServerPortParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsServerPortParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsServerPortParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsServerPortParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>ServerPort: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsServerPort
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsServerPortNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsServerPortParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsSocketAddrNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsSocketAddrNameEnum
{
    [EnumMember(Value = "SocketAddr"), JsonStringEnumMemberName("SocketAddr")]
    SocketAddr
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsSocketAddrParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsSocketAddrParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "IPMatch"), JsonStringEnumMemberName("IPMatch")]
    IPMatch
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsSocketAddrParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsSocketAddrParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsSocketAddrParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsSocketAddrParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleSocketAddrConditionParameters"), JsonStringEnumMemberName("DeliveryRuleSocketAddrConditionParameters")]
    DeliveryRuleSocketAddrConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsSocketAddrParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsSocketAddrParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsSocketAddrParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsSocketAddrParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>SocketAddr: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsSocketAddr
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsSocketAddrNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsSocketAddrParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsSslProtocolNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsSslProtocolNameEnum
{
    [EnumMember(Value = "SslProtocol"), JsonStringEnumMemberName("SslProtocol")]
    SslProtocol
}

/// <summary>The protocol of an established TLS connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsSslProtocolParametersMatchValuesEnum>))]
public enum V1api20230501RuleSpecRuleconditionsSslProtocolParametersMatchValuesEnum
{
    [EnumMember(Value = "TLSv1"), JsonStringEnumMemberName("TLSv1")]
    TLSv1,
    [EnumMember(Value = "TLSv1.1"), JsonStringEnumMemberName("TLSv1.1")]
    TLSv11,
    [EnumMember(Value = "TLSv1.2"), JsonStringEnumMemberName("TLSv1.2")]
    TLSv12
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsSslProtocolParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsSslProtocolParametersOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsSslProtocolParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsSslProtocolParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsSslProtocolParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsSslProtocolParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleSslProtocolConditionParameters"), JsonStringEnumMemberName("DeliveryRuleSslProtocolConditionParameters")]
    DeliveryRuleSslProtocolConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsSslProtocolParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<V1api20230501RuleSpecRuleconditionsSslProtocolParametersMatchValuesEnum>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsSslProtocolParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsSslProtocolParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsSslProtocolParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>SslProtocol: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsSslProtocol
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsSslProtocolNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsSslProtocolParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsUrlFileExtensionNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsUrlFileExtensionNameEnum
{
    [EnumMember(Value = "UrlFileExtension"), JsonStringEnumMemberName("UrlFileExtension")]
    UrlFileExtension
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsUrlFileExtensionParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsUrlFileExtensionParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsUrlFileExtensionParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsUrlFileExtensionParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsUrlFileExtensionParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsUrlFileExtensionParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleUrlFileExtensionMatchConditionParameters"), JsonStringEnumMemberName("DeliveryRuleUrlFileExtensionMatchConditionParameters")]
    DeliveryRuleUrlFileExtensionMatchConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsUrlFileExtensionParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsUrlFileExtensionParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsUrlFileExtensionParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsUrlFileExtensionParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>UrlFileExtension: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsUrlFileExtension
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsUrlFileExtensionNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsUrlFileExtensionParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsUrlFileNameNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsUrlFileNameNameEnum
{
    [EnumMember(Value = "UrlFileName"), JsonStringEnumMemberName("UrlFileName")]
    UrlFileName
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsUrlFileNameParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsUrlFileNameParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsUrlFileNameParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsUrlFileNameParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsUrlFileNameParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsUrlFileNameParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleUrlFilenameConditionParameters"), JsonStringEnumMemberName("DeliveryRuleUrlFilenameConditionParameters")]
    DeliveryRuleUrlFilenameConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsUrlFileNameParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsUrlFileNameParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsUrlFileNameParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsUrlFileNameParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>UrlFileName: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsUrlFileName
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsUrlFileNameNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsUrlFileNameParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsUrlPathNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsUrlPathNameEnum
{
    [EnumMember(Value = "UrlPath"), JsonStringEnumMemberName("UrlPath")]
    UrlPath
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsUrlPathParametersOperatorEnum>))]
public enum V1api20230501RuleSpecRuleconditionsUrlPathParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx,
    [EnumMember(Value = "Wildcard"), JsonStringEnumMemberName("Wildcard")]
    Wildcard
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsUrlPathParametersTransformsEnum>))]
public enum V1api20230501RuleSpecRuleconditionsUrlPathParametersTransformsEnum
{
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RuleSpecRuleconditionsUrlPathParametersTypeNameEnum>))]
public enum V1api20230501RuleSpecRuleconditionsUrlPathParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleUrlPathMatchConditionParameters"), JsonStringEnumMemberName("DeliveryRuleUrlPathMatchConditionParameters")]
    DeliveryRuleUrlPathMatchConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsUrlPathParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20230501RuleSpecRuleconditionsUrlPathParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20230501RuleSpecRuleconditionsUrlPathParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20230501RuleSpecRuleconditionsUrlPathParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>UrlPath: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditionsUrlPath
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501RuleSpecRuleconditionsUrlPathNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20230501RuleSpecRuleconditionsUrlPathParameters Parameters { get; set; }
}

/// <summary>A condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpecRuleconditions
{
    /// <summary>ClientPort: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("clientPort")]
    public V1api20230501RuleSpecRuleconditionsClientPort? ClientPort { get; set; }

    /// <summary>Cookies: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cookies")]
    public V1api20230501RuleSpecRuleconditionsCookies? Cookies { get; set; }

    /// <summary>HostName: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hostName")]
    public V1api20230501RuleSpecRuleconditionsHostName? HostName { get; set; }

    /// <summary>HttpVersion: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("httpVersion")]
    public V1api20230501RuleSpecRuleconditionsHttpVersion? HttpVersion { get; set; }

    /// <summary>IsDevice: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("isDevice")]
    public V1api20230501RuleSpecRuleconditionsIsDevice? IsDevice { get; set; }

    /// <summary>PostArgs: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("postArgs")]
    public V1api20230501RuleSpecRuleconditionsPostArgs? PostArgs { get; set; }

    /// <summary>QueryString: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("queryString")]
    public V1api20230501RuleSpecRuleconditionsQueryString? QueryString { get; set; }

    /// <summary>RemoteAddress: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("remoteAddress")]
    public V1api20230501RuleSpecRuleconditionsRemoteAddress? RemoteAddress { get; set; }

    /// <summary>RequestBody: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestBody")]
    public V1api20230501RuleSpecRuleconditionsRequestBody? RequestBody { get; set; }

    /// <summary>RequestHeader: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestHeader")]
    public V1api20230501RuleSpecRuleconditionsRequestHeader? RequestHeader { get; set; }

    /// <summary>RequestMethod: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestMethod")]
    public V1api20230501RuleSpecRuleconditionsRequestMethod? RequestMethod { get; set; }

    /// <summary>RequestScheme: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestScheme")]
    public V1api20230501RuleSpecRuleconditionsRequestScheme? RequestScheme { get; set; }

    /// <summary>RequestUri: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestUri")]
    public V1api20230501RuleSpecRuleconditionsRequestUri? RequestUri { get; set; }

    /// <summary>ServerPort: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serverPort")]
    public V1api20230501RuleSpecRuleconditionsServerPort? ServerPort { get; set; }

    /// <summary>SocketAddr: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("socketAddr")]
    public V1api20230501RuleSpecRuleconditionsSocketAddr? SocketAddr { get; set; }

    /// <summary>SslProtocol: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sslProtocol")]
    public V1api20230501RuleSpecRuleconditionsSslProtocol? SslProtocol { get; set; }

    /// <summary>UrlFileExtension: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlFileExtension")]
    public V1api20230501RuleSpecRuleconditionsUrlFileExtension? UrlFileExtension { get; set; }

    /// <summary>UrlFileName: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlFileName")]
    public V1api20230501RuleSpecRuleconditionsUrlFileName? UrlFileName { get; set; }

    /// <summary>UrlPath: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlPath")]
    public V1api20230501RuleSpecRuleconditionsUrlPath? UrlPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleSpec
{
    /// <summary>Actions: A list of actions that are executed when all the conditions of a rule are satisfied.</summary>
    [JsonPropertyName("actions")]
    public IList<V1api20230501RuleSpecActions>? Actions { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// MatchProcessingBehavior: If this rule is a match should the rules engine continue running the remaining rules or stop.
    /// If not present, defaults to Continue.
    /// </summary>
    [JsonPropertyName("matchProcessingBehavior")]
    public V1api20230501RuleSpecMatchProcessingBehaviorEnum? MatchProcessingBehavior { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230501RuleSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Order: The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a
    /// lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not
    /// require any condition and actions listed in it will always be applied.
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a cdn.azure.com/RuleSet resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230501RuleSpecOwner Owner { get; set; }

    /// <summary>RuleConditions: A list of conditions that must be matched for the actions to be executed</summary>
    [JsonPropertyName("ruleconditions")]
    public IList<V1api20230501RuleSpecRuleconditions>? Ruleconditions { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsCacheExpirationParameters
{
    /// <summary>CacheBehavior: Caching behavior for the requests</summary>
    [JsonPropertyName("cacheBehavior")]
    public string? CacheBehavior { get; set; }

    /// <summary>CacheDuration: The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>CacheType: The level at which the content needs to be cached.</summary>
    [JsonPropertyName("cacheType")]
    public string? CacheType { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>CacheExpiration: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsCacheExpiration
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusActionsCacheExpirationParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsCacheKeyQueryStringParameters
{
    /// <summary>QueryParameters: query parameters to include or exclude (comma separated).</summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary>QueryStringBehavior: Caching behavior for the requests</summary>
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>CacheKeyQueryString: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsCacheKeyQueryString
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusActionsCacheKeyQueryStringParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsModifyRequestHeaderParameters
{
    /// <summary>HeaderAction: Action to perform</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>HeaderName: Name of the header to modify</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>Value: Value for the specified action</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ModifyRequestHeader: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsModifyRequestHeader
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusActionsModifyRequestHeaderParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsModifyResponseHeaderParameters
{
    /// <summary>HeaderAction: Action to perform</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>HeaderName: Name of the header to modify</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>Value: Value for the specified action</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ModifyResponseHeader: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsModifyResponseHeader
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusActionsModifyResponseHeaderParameters? Parameters { get; set; }
}

/// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsOriginGroupOverrideParametersOriginGroup
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsOriginGroupOverrideParameters
{
    /// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20230501RuleStatusActionsOriginGroupOverrideParametersOriginGroup? OriginGroup { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>OriginGroupOverride: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsOriginGroupOverride
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusActionsOriginGroupOverrideParameters? Parameters { get; set; }
}

/// <summary>
/// CacheConfiguration: The caching configuration associated with this rule. To disable caching, do not provide a
/// cacheConfiguration object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsRouteConfigurationOverrideParametersCacheConfiguration
{
    /// <summary>CacheBehavior: Caching behavior for the requests</summary>
    [JsonPropertyName("cacheBehavior")]
    public string? CacheBehavior { get; set; }

    /// <summary>CacheDuration: The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>
    /// IsCompressionEnabled: Indicates whether content compression is enabled. If compression is enabled, content will be
    /// served as compressed if user requests for a compressed version. Content won&apos;t be compressed on AzureFrontDoor when
    /// requested content is smaller than 1 byte or larger than 1 MB.
    /// </summary>
    [JsonPropertyName("isCompressionEnabled")]
    public string? IsCompressionEnabled { get; set; }

    /// <summary>QueryParameters: query parameters to include or exclude (comma separated).</summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary>
    /// QueryStringCachingBehavior: Defines how Frontdoor caches requests that include query strings. You can ignore any query
    /// strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query
    /// strings.
    /// </summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }
}

/// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup on route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// OriginGroupOverride: A reference to the origin group override configuration. Leave empty to use the default origin group
/// on route.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsRouteConfigurationOverrideParametersOriginGroupOverride
{
    /// <summary>ForwardingProtocol: Protocol this rule will use when forwarding traffic to backends.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup on route.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20230501RuleStatusActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup? OriginGroup { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsRouteConfigurationOverrideParameters
{
    /// <summary>
    /// CacheConfiguration: The caching configuration associated with this rule. To disable caching, do not provide a
    /// cacheConfiguration object.
    /// </summary>
    [JsonPropertyName("cacheConfiguration")]
    public V1api20230501RuleStatusActionsRouteConfigurationOverrideParametersCacheConfiguration? CacheConfiguration { get; set; }

    /// <summary>
    /// OriginGroupOverride: A reference to the origin group override configuration. Leave empty to use the default origin group
    /// on route.
    /// </summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20230501RuleStatusActionsRouteConfigurationOverrideParametersOriginGroupOverride? OriginGroupOverride { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>RouteConfigurationOverride: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsRouteConfigurationOverride
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusActionsRouteConfigurationOverrideParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsUrlRedirectParameters
{
    /// <summary>
    /// CustomFragment: Fragment to add to the redirect URL. Fragment is the part of the URL that comes after #. Do not include
    /// the #.
    /// </summary>
    [JsonPropertyName("customFragment")]
    public string? CustomFragment { get; set; }

    /// <summary>CustomHostname: Host to redirect. Leave empty to use the incoming host as the destination host.</summary>
    [JsonPropertyName("customHostname")]
    public string? CustomHostname { get; set; }

    /// <summary>
    /// CustomPath: The full path to redirect. Path cannot be empty and must start with /. Leave empty to use the incoming path
    /// as destination path.
    /// </summary>
    [JsonPropertyName("customPath")]
    public string? CustomPath { get; set; }

    /// <summary>
    /// CustomQueryString: The set of query strings to be placed in the redirect URL. Setting this value would replace any
    /// existing query string; leave empty to preserve the incoming query string. Query string must be in &lt;key&gt;=&lt;value&gt; format.
    /// ? and &amp; will be added automatically so do not include them.
    /// </summary>
    [JsonPropertyName("customQueryString")]
    public string? CustomQueryString { get; set; }

    /// <summary>DestinationProtocol: Protocol to use for the redirect. The default value is MatchRequest</summary>
    [JsonPropertyName("destinationProtocol")]
    public string? DestinationProtocol { get; set; }

    /// <summary>RedirectType: The redirect type the rule will use when redirecting traffic.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>UrlRedirect: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsUrlRedirect
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusActionsUrlRedirectParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsUrlRewriteParameters
{
    /// <summary>Destination: Define the relative URL to which the above requests will be rewritten by.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>PreserveUnmatchedPath: Whether to preserve unmatched path. Default value is true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>
    /// SourcePattern: define a request URI pattern that identifies the type of requests that may be rewritten. If value is
    /// blank, all strings are matched.
    /// </summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>UrlRewrite: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsUrlRewrite
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusActionsUrlRewriteParameters? Parameters { get; set; }
}

/// <summary>Defines how to identify a parameter for a specific purpose e.g. expires</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsUrlSigningParametersParameterNameOverride
{
    /// <summary>ParamIndicator: Indicates the purpose of the parameter</summary>
    [JsonPropertyName("paramIndicator")]
    public string? ParamIndicator { get; set; }

    /// <summary>ParamName: Parameter name</summary>
    [JsonPropertyName("paramName")]
    public string? ParamName { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsUrlSigningParameters
{
    /// <summary>Algorithm: Algorithm to use for URL signing</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>ParameterNameOverride: Defines which query string parameters in the url to be considered for expires, key id etc.</summary>
    [JsonPropertyName("parameterNameOverride")]
    public IList<V1api20230501RuleStatusActionsUrlSigningParametersParameterNameOverride>? ParameterNameOverride { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>UrlSigning: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActionsUrlSigning
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusActionsUrlSigningParameters? Parameters { get; set; }
}

/// <summary>An action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusActions
{
    /// <summary>CacheExpiration: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cacheExpiration")]
    public V1api20230501RuleStatusActionsCacheExpiration? CacheExpiration { get; set; }

    /// <summary>CacheKeyQueryString: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cacheKeyQueryString")]
    public V1api20230501RuleStatusActionsCacheKeyQueryString? CacheKeyQueryString { get; set; }

    /// <summary>ModifyRequestHeader: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("modifyRequestHeader")]
    public V1api20230501RuleStatusActionsModifyRequestHeader? ModifyRequestHeader { get; set; }

    /// <summary>ModifyResponseHeader: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("modifyResponseHeader")]
    public V1api20230501RuleStatusActionsModifyResponseHeader? ModifyResponseHeader { get; set; }

    /// <summary>OriginGroupOverride: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20230501RuleStatusActionsOriginGroupOverride? OriginGroupOverride { get; set; }

    /// <summary>RouteConfigurationOverride: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("routeConfigurationOverride")]
    public V1api20230501RuleStatusActionsRouteConfigurationOverride? RouteConfigurationOverride { get; set; }

    /// <summary>UrlRedirect: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlRedirect")]
    public V1api20230501RuleStatusActionsUrlRedirect? UrlRedirect { get; set; }

    /// <summary>UrlRewrite: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlRewrite")]
    public V1api20230501RuleStatusActionsUrlRewrite? UrlRewrite { get; set; }

    /// <summary>UrlSigning: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlSigning")]
    public V1api20230501RuleStatusActionsUrlSigning? UrlSigning { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusConditions
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

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsClientPortParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>ClientPort: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsClientPort
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsClientPortParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsCookiesParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Selector: Name of Cookies to be matched</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>Cookies: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsCookies
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsCookiesParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsHostNameParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>HostName: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsHostName
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsHostNameParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsHttpVersionParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>HttpVersion: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsHttpVersion
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsHttpVersionParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsIsDeviceParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>IsDevice: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsIsDevice
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsIsDeviceParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsPostArgsParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Selector: Name of PostArg to be matched</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>PostArgs: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsPostArgs
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsPostArgsParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsQueryStringParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>QueryString: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsQueryString
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsQueryStringParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsRemoteAddressParameters
{
    /// <summary>
    /// MatchValues: Match values to match against. The operator will apply to each value in here with OR semantics. If any of
    /// them match the variable with the given operator this match condition is considered a match.
    /// </summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>RemoteAddress: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsRemoteAddress
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsRemoteAddressParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsRequestBodyParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>RequestBody: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsRequestBody
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsRequestBodyParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsRequestHeaderParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Selector: Name of Header to be matched</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>RequestHeader: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsRequestHeader
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsRequestHeaderParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsRequestMethodParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>RequestMethod: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsRequestMethod
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsRequestMethodParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsRequestSchemeParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>RequestScheme: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsRequestScheme
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsRequestSchemeParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsRequestUriParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>RequestUri: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsRequestUri
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsRequestUriParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsServerPortParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>ServerPort: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsServerPort
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsServerPortParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsSocketAddrParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>SocketAddr: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsSocketAddr
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsSocketAddrParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsSslProtocolParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>SslProtocol: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsSslProtocol
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsSslProtocolParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsUrlFileExtensionParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>UrlFileExtension: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsUrlFileExtension
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsUrlFileExtensionParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsUrlFileNameParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>UrlFileName: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsUrlFileName
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsUrlFileNameParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsUrlPathParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>UrlPath: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditionsUrlPath
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501RuleStatusRuleconditionsUrlPathParameters? Parameters { get; set; }
}

/// <summary>A condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusRuleconditions
{
    /// <summary>ClientPort: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("clientPort")]
    public V1api20230501RuleStatusRuleconditionsClientPort? ClientPort { get; set; }

    /// <summary>Cookies: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cookies")]
    public V1api20230501RuleStatusRuleconditionsCookies? Cookies { get; set; }

    /// <summary>HostName: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hostName")]
    public V1api20230501RuleStatusRuleconditionsHostName? HostName { get; set; }

    /// <summary>HttpVersion: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("httpVersion")]
    public V1api20230501RuleStatusRuleconditionsHttpVersion? HttpVersion { get; set; }

    /// <summary>IsDevice: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("isDevice")]
    public V1api20230501RuleStatusRuleconditionsIsDevice? IsDevice { get; set; }

    /// <summary>PostArgs: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("postArgs")]
    public V1api20230501RuleStatusRuleconditionsPostArgs? PostArgs { get; set; }

    /// <summary>QueryString: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("queryString")]
    public V1api20230501RuleStatusRuleconditionsQueryString? QueryString { get; set; }

    /// <summary>RemoteAddress: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("remoteAddress")]
    public V1api20230501RuleStatusRuleconditionsRemoteAddress? RemoteAddress { get; set; }

    /// <summary>RequestBody: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestBody")]
    public V1api20230501RuleStatusRuleconditionsRequestBody? RequestBody { get; set; }

    /// <summary>RequestHeader: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestHeader")]
    public V1api20230501RuleStatusRuleconditionsRequestHeader? RequestHeader { get; set; }

    /// <summary>RequestMethod: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestMethod")]
    public V1api20230501RuleStatusRuleconditionsRequestMethod? RequestMethod { get; set; }

    /// <summary>RequestScheme: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestScheme")]
    public V1api20230501RuleStatusRuleconditionsRequestScheme? RequestScheme { get; set; }

    /// <summary>RequestUri: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestUri")]
    public V1api20230501RuleStatusRuleconditionsRequestUri? RequestUri { get; set; }

    /// <summary>ServerPort: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serverPort")]
    public V1api20230501RuleStatusRuleconditionsServerPort? ServerPort { get; set; }

    /// <summary>SocketAddr: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("socketAddr")]
    public V1api20230501RuleStatusRuleconditionsSocketAddr? SocketAddr { get; set; }

    /// <summary>SslProtocol: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sslProtocol")]
    public V1api20230501RuleStatusRuleconditionsSslProtocol? SslProtocol { get; set; }

    /// <summary>UrlFileExtension: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlFileExtension")]
    public V1api20230501RuleStatusRuleconditionsUrlFileExtension? UrlFileExtension { get; set; }

    /// <summary>UrlFileName: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlFileName")]
    public V1api20230501RuleStatusRuleconditionsUrlFileName? UrlFileName { get; set; }

    /// <summary>UrlPath: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlPath")]
    public V1api20230501RuleStatusRuleconditionsUrlPath? UrlPath { get; set; }
}

/// <summary>SystemData: Read only system data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC)</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: An identifier for the identity that created the resource</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: An identifier for the identity that last modified the resource</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RuleStatus
{
    /// <summary>Actions: A list of actions that are executed when all the conditions of a rule are satisfied.</summary>
    [JsonPropertyName("actions")]
    public IList<V1api20230501RuleStatusActions>? Actions { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230501RuleStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("deploymentStatus")]
    public string? DeploymentStatus { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// MatchProcessingBehavior: If this rule is a match should the rules engine continue running the remaining rules or stop.
    /// If not present, defaults to Continue.
    /// </summary>
    [JsonPropertyName("matchProcessingBehavior")]
    public string? MatchProcessingBehavior { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Order: The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a
    /// lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not
    /// require any condition and actions listed in it will always be applied.
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>ProvisioningState: Provisioning status</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>RuleSetName: The name of the rule set containing the rule.</summary>
    [JsonPropertyName("ruleSetName")]
    public string? RuleSetName { get; set; }

    /// <summary>RuleConditions: A list of conditions that must be matched for the actions to be executed</summary>
    [JsonPropertyName("ruleconditions")]
    public IList<V1api20230501RuleStatusRuleconditions>? Ruleconditions { get; set; }

    /// <summary>SystemData: Read only system data</summary>
    [JsonPropertyName("systemData")]
    public V1api20230501RuleStatusSystemData? SystemData { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cdn/resource-manager/Microsoft.Cdn/Cdn/stable/2023-05-01/afdx.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets/{ruleSetName}/rules/{ruleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501Rule : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230501RuleSpec?>, IStatus<V1api20230501RuleStatus?>
{
    public const string KubeApiVersion = "v1api20230501";
    public const string KubeKind = "Rule";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "rules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.com/v1api20230501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Rule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230501RuleSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20230501RuleStatus? Status { get; set; }
}