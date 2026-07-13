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
/// - Generated from: /cdn/resource-manager/Microsoft.Cdn/Cdn/stable/2021-06-01/cdn.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601ProfilesEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1api20210601ProfilesEndpoint>
{
    public const string KubeApiVersion = "v1api20210601";
    public const string KubeKind = "ProfilesEndpointList";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "profilesendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.com/v1api20210601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProfilesEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210601ProfilesEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210601ProfilesEndpoint> Items { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDefaultOriginGroupReference
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

/// <summary>DefaultOriginGroup: A reference to the origin group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDefaultOriginGroup
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20210601ProfilesEndpointSpecDefaultOriginGroupReference? Reference { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationNameEnum
{
    [EnumMember(Value = "CacheExpiration"), JsonStringEnumMemberName("CacheExpiration")]
    CacheExpiration
}

/// <summary>CacheBehavior: Caching behavior for the requests</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParametersCacheBehaviorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParametersCacheBehaviorEnum
{
    [EnumMember(Value = "BypassCache"), JsonStringEnumMemberName("BypassCache")]
    BypassCache,
    [EnumMember(Value = "Override"), JsonStringEnumMemberName("Override")]
    Override,
    [EnumMember(Value = "SetIfMissing"), JsonStringEnumMemberName("SetIfMissing")]
    SetIfMissing
}

/// <summary>CacheType: The level at which the content needs to be cached.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParametersCacheTypeEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParametersCacheTypeEnum
{
    [EnumMember(Value = "All"), JsonStringEnumMemberName("All")]
    All
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleCacheExpirationActionParameters"), JsonStringEnumMemberName("DeliveryRuleCacheExpirationActionParameters")]
    DeliveryRuleCacheExpirationActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParameters
{
    /// <summary>CacheBehavior: Caching behavior for the requests</summary>
    [JsonPropertyName("cacheBehavior")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParametersCacheBehaviorEnum CacheBehavior { get; set; }

    /// <summary>CacheDuration: The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>CacheType: The level at which the content needs to be cached.</summary>
    [JsonPropertyName("cacheType")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParametersCacheTypeEnum CacheType { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>CacheExpiration: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpiration
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringNameEnum
{
    [EnumMember(Value = "CacheKeyQueryString"), JsonStringEnumMemberName("CacheKeyQueryString")]
    CacheKeyQueryString
}

/// <summary>QueryStringBehavior: Caching behavior for the requests</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringParametersQueryStringBehaviorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringParametersQueryStringBehaviorEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleCacheKeyQueryStringBehaviorActionParameters"), JsonStringEnumMemberName("DeliveryRuleCacheKeyQueryStringBehaviorActionParameters")]
    DeliveryRuleCacheKeyQueryStringBehaviorActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringParameters
{
    /// <summary>QueryParameters: query parameters to include or exclude (comma separated).</summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary>QueryStringBehavior: Caching behavior for the requests</summary>
    [JsonPropertyName("queryStringBehavior")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringParametersQueryStringBehaviorEnum QueryStringBehavior { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>CacheKeyQueryString: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryString
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderNameEnum
{
    [EnumMember(Value = "ModifyRequestHeader"), JsonStringEnumMemberName("ModifyRequestHeader")]
    ModifyRequestHeader
}

/// <summary>HeaderAction: Action to perform</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderParametersHeaderActionEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderParametersHeaderActionEnum
{
    [EnumMember(Value = "Append"), JsonStringEnumMemberName("Append")]
    Append,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Overwrite"), JsonStringEnumMemberName("Overwrite")]
    Overwrite
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleHeaderActionParameters"), JsonStringEnumMemberName("DeliveryRuleHeaderActionParameters")]
    DeliveryRuleHeaderActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderParameters
{
    /// <summary>HeaderAction: Action to perform</summary>
    [JsonPropertyName("headerAction")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderParametersHeaderActionEnum HeaderAction { get; set; }

    /// <summary>HeaderName: Name of the header to modify</summary>
    [JsonPropertyName("headerName")]
    public required string HeaderName { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderParametersTypeNameEnum TypeName { get; set; }

    /// <summary>Value: Value for the specified action</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ModifyRequestHeader: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeader
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderNameEnum
{
    [EnumMember(Value = "ModifyResponseHeader"), JsonStringEnumMemberName("ModifyResponseHeader")]
    ModifyResponseHeader
}

/// <summary>HeaderAction: Action to perform</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderParametersHeaderActionEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderParametersHeaderActionEnum
{
    [EnumMember(Value = "Append"), JsonStringEnumMemberName("Append")]
    Append,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Overwrite"), JsonStringEnumMemberName("Overwrite")]
    Overwrite
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleHeaderActionParameters"), JsonStringEnumMemberName("DeliveryRuleHeaderActionParameters")]
    DeliveryRuleHeaderActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderParameters
{
    /// <summary>HeaderAction: Action to perform</summary>
    [JsonPropertyName("headerAction")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderParametersHeaderActionEnum HeaderAction { get; set; }

    /// <summary>HeaderName: Name of the header to modify</summary>
    [JsonPropertyName("headerName")]
    public required string HeaderName { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderParametersTypeNameEnum TypeName { get; set; }

    /// <summary>Value: Value for the specified action</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ModifyResponseHeader: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeader
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideNameEnum
{
    [EnumMember(Value = "OriginGroupOverride"), JsonStringEnumMemberName("OriginGroupOverride")]
    OriginGroupOverride
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParametersOriginGroupReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParametersOriginGroup
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParametersOriginGroupReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleOriginGroupOverrideActionParameters"), JsonStringEnumMemberName("DeliveryRuleOriginGroupOverrideActionParameters")]
    DeliveryRuleOriginGroupOverrideActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParameters
{
    /// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup.</summary>
    [JsonPropertyName("originGroup")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParametersOriginGroup OriginGroup { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>OriginGroupOverride: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverride
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideNameEnum
{
    [EnumMember(Value = "RouteConfigurationOverride"), JsonStringEnumMemberName("RouteConfigurationOverride")]
    RouteConfigurationOverride
}

/// <summary>CacheBehavior: Caching behavior for the requests</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfigurationCacheBehaviorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfigurationCacheBehaviorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfigurationIsCompressionEnabledEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfigurationIsCompressionEnabledEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfigurationQueryStringCachingBehaviorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfigurationQueryStringCachingBehaviorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfiguration
{
    /// <summary>CacheBehavior: Caching behavior for the requests</summary>
    [JsonPropertyName("cacheBehavior")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfigurationCacheBehaviorEnum? CacheBehavior { get; set; }

    /// <summary>CacheDuration: The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>
    /// IsCompressionEnabled: Indicates whether content compression is enabled. If compression is enabled, content will be
    /// served as compressed if user requests for a compressed version. Content won&apos;t be compressed on AzureFrontDoor when
    /// requested content is smaller than 1 byte or larger than 1 MB.
    /// </summary>
    [JsonPropertyName("isCompressionEnabled")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfigurationIsCompressionEnabledEnum? IsCompressionEnabled { get; set; }

    /// <summary>QueryParameters: query parameters to include or exclude (comma separated).</summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary>
    /// QueryStringCachingBehavior: Defines how Frontdoor caches requests that include query strings. You can ignore any query
    /// strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query
    /// strings.
    /// </summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfigurationQueryStringCachingBehaviorEnum? QueryStringCachingBehavior { get; set; }
}

/// <summary>ForwardingProtocol: Protocol this rule will use when forwarding traffic to backends.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideForwardingProtocolEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideForwardingProtocolEnum
{
    [EnumMember(Value = "HttpOnly"), JsonStringEnumMemberName("HttpOnly")]
    HttpOnly,
    [EnumMember(Value = "HttpsOnly"), JsonStringEnumMemberName("HttpsOnly")]
    HttpsOnly,
    [EnumMember(Value = "MatchRequest"), JsonStringEnumMemberName("MatchRequest")]
    MatchRequest
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroupReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroupReference? Reference { get; set; }
}

/// <summary>
/// OriginGroupOverride: A reference to the origin group override configuration. Leave empty to use the default origin group
/// on route.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverride
{
    /// <summary>ForwardingProtocol: Protocol this rule will use when forwarding traffic to backends.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideForwardingProtocolEnum? ForwardingProtocol { get; set; }

    /// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup on route.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup? OriginGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRouteConfigurationOverrideActionParameters"), JsonStringEnumMemberName("DeliveryRuleRouteConfigurationOverrideActionParameters")]
    DeliveryRuleRouteConfigurationOverrideActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParameters
{
    /// <summary>
    /// CacheConfiguration: The caching configuration associated with this rule. To disable caching, do not provide a
    /// cacheConfiguration object.
    /// </summary>
    [JsonPropertyName("cacheConfiguration")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfiguration? CacheConfiguration { get; set; }

    /// <summary>
    /// OriginGroupOverride: A reference to the origin group override configuration. Leave empty to use the default origin group
    /// on route.
    /// </summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverride? OriginGroupOverride { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RouteConfigurationOverride: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverride
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectNameEnum
{
    [EnumMember(Value = "UrlRedirect"), JsonStringEnumMemberName("UrlRedirect")]
    UrlRedirect
}

/// <summary>DestinationProtocol: Protocol to use for the redirect. The default value is MatchRequest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParametersDestinationProtocolEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParametersDestinationProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https,
    [EnumMember(Value = "MatchRequest"), JsonStringEnumMemberName("MatchRequest")]
    MatchRequest
}

/// <summary>RedirectType: The redirect type the rule will use when redirecting traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParametersRedirectTypeEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParametersRedirectTypeEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleUrlRedirectActionParameters"), JsonStringEnumMemberName("DeliveryRuleUrlRedirectActionParameters")]
    DeliveryRuleUrlRedirectActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParameters
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
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParametersDestinationProtocolEnum? DestinationProtocol { get; set; }

    /// <summary>RedirectType: The redirect type the rule will use when redirecting traffic.</summary>
    [JsonPropertyName("redirectType")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParametersRedirectTypeEnum RedirectType { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>UrlRedirect: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirect
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewriteNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewriteNameEnum
{
    [EnumMember(Value = "UrlRewrite"), JsonStringEnumMemberName("UrlRewrite")]
    UrlRewrite
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewriteParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewriteParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleUrlRewriteActionParameters"), JsonStringEnumMemberName("DeliveryRuleUrlRewriteActionParameters")]
    DeliveryRuleUrlRewriteActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewriteParameters
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
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewriteParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>UrlRewrite: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewrite
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewriteNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewriteParameters Parameters { get; set; }
}

/// <summary>Name: The name of the action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningNameEnum
{
    [EnumMember(Value = "UrlSigning"), JsonStringEnumMemberName("UrlSigning")]
    UrlSigning
}

/// <summary>Algorithm: Algorithm to use for URL signing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersAlgorithmEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersAlgorithmEnum
{
    [EnumMember(Value = "SHA256"), JsonStringEnumMemberName("SHA256")]
    SHA256
}

/// <summary>ParamIndicator: Indicates the purpose of the parameter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersParameterNameOverrideParamIndicatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersParameterNameOverrideParamIndicatorEnum
{
    [EnumMember(Value = "Expires"), JsonStringEnumMemberName("Expires")]
    Expires,
    [EnumMember(Value = "KeyId"), JsonStringEnumMemberName("KeyId")]
    KeyId,
    [EnumMember(Value = "Signature"), JsonStringEnumMemberName("Signature")]
    Signature
}

/// <summary>Defines how to identify a parameter for a specific purpose e.g. expires</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersParameterNameOverride
{
    /// <summary>ParamIndicator: Indicates the purpose of the parameter</summary>
    [JsonPropertyName("paramIndicator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersParameterNameOverrideParamIndicatorEnum ParamIndicator { get; set; }

    /// <summary>ParamName: Parameter name</summary>
    [JsonPropertyName("paramName")]
    public required string ParamName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleUrlSigningActionParameters"), JsonStringEnumMemberName("DeliveryRuleUrlSigningActionParameters")]
    DeliveryRuleUrlSigningActionParameters
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParameters
{
    /// <summary>Algorithm: Algorithm to use for URL signing</summary>
    [JsonPropertyName("algorithm")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersAlgorithmEnum? Algorithm { get; set; }

    /// <summary>ParameterNameOverride: Defines which query string parameters in the url to be considered for expires, key id etc.</summary>
    [JsonPropertyName("parameterNameOverride")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersParameterNameOverride>? ParameterNameOverride { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>UrlSigning: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigning
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParameters Parameters { get; set; }
}

/// <summary>An action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActions
{
    /// <summary>CacheExpiration: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cacheExpiration")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpiration? CacheExpiration { get; set; }

    /// <summary>CacheKeyQueryString: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cacheKeyQueryString")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryString? CacheKeyQueryString { get; set; }

    /// <summary>ModifyRequestHeader: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("modifyRequestHeader")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeader? ModifyRequestHeader { get; set; }

    /// <summary>ModifyResponseHeader: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("modifyResponseHeader")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeader? ModifyResponseHeader { get; set; }

    /// <summary>OriginGroupOverride: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverride? OriginGroupOverride { get; set; }

    /// <summary>RouteConfigurationOverride: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("routeConfigurationOverride")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverride? RouteConfigurationOverride { get; set; }

    /// <summary>UrlRedirect: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlRedirect")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirect? UrlRedirect { get; set; }

    /// <summary>UrlRewrite: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlRewrite")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewrite? UrlRewrite { get; set; }

    /// <summary>UrlSigning: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlSigning")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigning? UrlSigning { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortNameEnum
{
    [EnumMember(Value = "ClientPort"), JsonStringEnumMemberName("ClientPort")]
    ClientPort
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParametersOperatorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleClientPortConditionParameters"), JsonStringEnumMemberName("DeliveryRuleClientPortConditionParameters")]
    DeliveryRuleClientPortConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>ClientPort: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPort
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesNameEnum
{
    [EnumMember(Value = "Cookies"), JsonStringEnumMemberName("Cookies")]
    Cookies
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParametersOperatorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleCookiesConditionParameters"), JsonStringEnumMemberName("DeliveryRuleCookiesConditionParameters")]
    DeliveryRuleCookiesConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParametersOperatorEnum Operator { get; set; }

    /// <summary>Selector: Name of Cookies to be matched</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>Cookies: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookies
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameNameEnum
{
    [EnumMember(Value = "HostName"), JsonStringEnumMemberName("HostName")]
    HostName
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParametersOperatorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleHostNameConditionParameters"), JsonStringEnumMemberName("DeliveryRuleHostNameConditionParameters")]
    DeliveryRuleHostNameConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>HostName: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostName
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionNameEnum
{
    [EnumMember(Value = "HttpVersion"), JsonStringEnumMemberName("HttpVersion")]
    HttpVersion
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParametersOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleHttpVersionConditionParameters"), JsonStringEnumMemberName("DeliveryRuleHttpVersionConditionParameters")]
    DeliveryRuleHttpVersionConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>HttpVersion: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersion
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceNameEnum
{
    [EnumMember(Value = "IsDevice"), JsonStringEnumMemberName("IsDevice")]
    IsDevice
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParametersMatchValuesEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParametersMatchValuesEnum
{
    [EnumMember(Value = "Desktop"), JsonStringEnumMemberName("Desktop")]
    Desktop,
    [EnumMember(Value = "Mobile"), JsonStringEnumMemberName("Mobile")]
    Mobile
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParametersOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleIsDeviceConditionParameters"), JsonStringEnumMemberName("DeliveryRuleIsDeviceConditionParameters")]
    DeliveryRuleIsDeviceConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParametersMatchValuesEnum>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>IsDevice: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDevice
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsNameEnum
{
    [EnumMember(Value = "PostArgs"), JsonStringEnumMemberName("PostArgs")]
    PostArgs
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParametersOperatorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRulePostArgsConditionParameters"), JsonStringEnumMemberName("DeliveryRulePostArgsConditionParameters")]
    DeliveryRulePostArgsConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParametersOperatorEnum Operator { get; set; }

    /// <summary>Selector: Name of PostArg to be matched</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>PostArgs: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgs
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringNameEnum
{
    [EnumMember(Value = "QueryString"), JsonStringEnumMemberName("QueryString")]
    QueryString
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParametersOperatorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleQueryStringConditionParameters"), JsonStringEnumMemberName("DeliveryRuleQueryStringConditionParameters")]
    DeliveryRuleQueryStringConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>QueryString: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryString
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressNameEnum
{
    [EnumMember(Value = "RemoteAddress"), JsonStringEnumMemberName("RemoteAddress")]
    RemoteAddress
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "GeoMatch"), JsonStringEnumMemberName("GeoMatch")]
    GeoMatch,
    [EnumMember(Value = "IPMatch"), JsonStringEnumMemberName("IPMatch")]
    IPMatch
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRemoteAddressConditionParameters"), JsonStringEnumMemberName("DeliveryRuleRemoteAddressConditionParameters")]
    DeliveryRuleRemoteAddressConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParameters
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
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RemoteAddress: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddress
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyNameEnum
{
    [EnumMember(Value = "RequestBody"), JsonStringEnumMemberName("RequestBody")]
    RequestBody
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParametersOperatorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRequestBodyConditionParameters"), JsonStringEnumMemberName("DeliveryRuleRequestBodyConditionParameters")]
    DeliveryRuleRequestBodyConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RequestBody: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBody
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderNameEnum
{
    [EnumMember(Value = "RequestHeader"), JsonStringEnumMemberName("RequestHeader")]
    RequestHeader
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParametersOperatorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRequestHeaderConditionParameters"), JsonStringEnumMemberName("DeliveryRuleRequestHeaderConditionParameters")]
    DeliveryRuleRequestHeaderConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParametersOperatorEnum Operator { get; set; }

    /// <summary>Selector: Name of Header to be matched</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RequestHeader: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeader
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodNameEnum
{
    [EnumMember(Value = "RequestMethod"), JsonStringEnumMemberName("RequestMethod")]
    RequestMethod
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParametersMatchValuesEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParametersMatchValuesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParametersOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRequestMethodConditionParameters"), JsonStringEnumMemberName("DeliveryRuleRequestMethodConditionParameters")]
    DeliveryRuleRequestMethodConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParametersMatchValuesEnum>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RequestMethod: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethod
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeNameEnum
{
    [EnumMember(Value = "RequestScheme"), JsonStringEnumMemberName("RequestScheme")]
    RequestScheme
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParametersMatchValuesEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParametersMatchValuesEnum
{
    [EnumMember(Value = "HTTP"), JsonStringEnumMemberName("HTTP")]
    HTTP,
    [EnumMember(Value = "HTTPS"), JsonStringEnumMemberName("HTTPS")]
    HTTPS
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParametersOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRequestSchemeConditionParameters"), JsonStringEnumMemberName("DeliveryRuleRequestSchemeConditionParameters")]
    DeliveryRuleRequestSchemeConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParametersMatchValuesEnum>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RequestScheme: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestScheme
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriNameEnum
{
    [EnumMember(Value = "RequestUri"), JsonStringEnumMemberName("RequestUri")]
    RequestUri
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParametersOperatorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleRequestUriConditionParameters"), JsonStringEnumMemberName("DeliveryRuleRequestUriConditionParameters")]
    DeliveryRuleRequestUriConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>RequestUri: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUri
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortNameEnum
{
    [EnumMember(Value = "ServerPort"), JsonStringEnumMemberName("ServerPort")]
    ServerPort
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParametersOperatorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleServerPortConditionParameters"), JsonStringEnumMemberName("DeliveryRuleServerPortConditionParameters")]
    DeliveryRuleServerPortConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>ServerPort: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPort
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrNameEnum
{
    [EnumMember(Value = "SocketAddr"), JsonStringEnumMemberName("SocketAddr")]
    SocketAddr
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParametersOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "IPMatch"), JsonStringEnumMemberName("IPMatch")]
    IPMatch
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleSocketAddrConditionParameters"), JsonStringEnumMemberName("DeliveryRuleSocketAddrConditionParameters")]
    DeliveryRuleSocketAddrConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>SocketAddr: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddr
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolNameEnum
{
    [EnumMember(Value = "SslProtocol"), JsonStringEnumMemberName("SslProtocol")]
    SslProtocol
}

/// <summary>The protocol of an established TLS connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParametersMatchValuesEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParametersMatchValuesEnum
{
    [EnumMember(Value = "TLSv1"), JsonStringEnumMemberName("TLSv1")]
    TLSv1,
    [EnumMember(Value = "TLSv1.1"), JsonStringEnumMemberName("TLSv1.1")]
    TLSv11,
    [EnumMember(Value = "TLSv1.2"), JsonStringEnumMemberName("TLSv1.2")]
    TLSv12
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParametersOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal
}

/// <summary>Describes what transforms are applied before matching</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleSslProtocolConditionParameters"), JsonStringEnumMemberName("DeliveryRuleSslProtocolConditionParameters")]
    DeliveryRuleSslProtocolConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParametersMatchValuesEnum>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>SslProtocol: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocol
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionNameEnum
{
    [EnumMember(Value = "UrlFileExtension"), JsonStringEnumMemberName("UrlFileExtension")]
    UrlFileExtension
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParametersOperatorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleUrlFileExtensionMatchConditionParameters"), JsonStringEnumMemberName("DeliveryRuleUrlFileExtensionMatchConditionParameters")]
    DeliveryRuleUrlFileExtensionMatchConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>UrlFileExtension: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtension
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameNameEnum
{
    [EnumMember(Value = "UrlFileName"), JsonStringEnumMemberName("UrlFileName")]
    UrlFileName
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParametersOperatorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleUrlFilenameConditionParameters"), JsonStringEnumMemberName("DeliveryRuleUrlFilenameConditionParameters")]
    DeliveryRuleUrlFilenameConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>UrlFileName: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileName
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParameters Parameters { get; set; }
}

/// <summary>Name: The name of the condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathNameEnum
{
    [EnumMember(Value = "UrlPath"), JsonStringEnumMemberName("UrlPath")]
    UrlPath
}

/// <summary>Operator: Describes operator to be matched</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParametersOperatorEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParametersOperatorEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParametersTransformsEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParametersTransformsEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParametersTypeNameEnum
{
    [EnumMember(Value = "DeliveryRuleUrlPathMatchConditionParameters"), JsonStringEnumMemberName("DeliveryRuleUrlPathMatchConditionParameters")]
    DeliveryRuleUrlPathMatchConditionParameters
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParameters
{
    /// <summary>MatchValues: The match value for the condition of the delivery rule</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>NegateCondition: Describes if this is negate condition or not</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Describes operator to be matched</summary>
    [JsonPropertyName("operator")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParametersOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParametersTransformsEnum>? Transforms { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParametersTypeNameEnum TypeName { get; set; }
}

/// <summary>UrlPath: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPath
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathNameEnum Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public required V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParameters Parameters { get; set; }
}

/// <summary>A condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditions
{
    /// <summary>ClientPort: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("clientPort")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPort? ClientPort { get; set; }

    /// <summary>Cookies: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cookies")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsCookies? Cookies { get; set; }

    /// <summary>HostName: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hostName")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHostName? HostName { get; set; }

    /// <summary>HttpVersion: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("httpVersion")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersion? HttpVersion { get; set; }

    /// <summary>IsDevice: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("isDevice")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDevice? IsDevice { get; set; }

    /// <summary>PostArgs: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("postArgs")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgs? PostArgs { get; set; }

    /// <summary>QueryString: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("queryString")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryString? QueryString { get; set; }

    /// <summary>RemoteAddress: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("remoteAddress")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddress? RemoteAddress { get; set; }

    /// <summary>RequestBody: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestBody")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBody? RequestBody { get; set; }

    /// <summary>RequestHeader: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestHeader")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeader? RequestHeader { get; set; }

    /// <summary>RequestMethod: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestMethod")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethod? RequestMethod { get; set; }

    /// <summary>RequestScheme: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestScheme")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestScheme? RequestScheme { get; set; }

    /// <summary>RequestUri: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestUri")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUri? RequestUri { get; set; }

    /// <summary>ServerPort: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serverPort")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPort? ServerPort { get; set; }

    /// <summary>SocketAddr: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("socketAddr")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddr? SocketAddr { get; set; }

    /// <summary>SslProtocol: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sslProtocol")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocol? SslProtocol { get; set; }

    /// <summary>UrlFileExtension: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlFileExtension")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtension? UrlFileExtension { get; set; }

    /// <summary>UrlFileName: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlFileName")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileName? UrlFileName { get; set; }

    /// <summary>UrlPath: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlPath")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPath? UrlPath { get; set; }
}

/// <summary>A rule that specifies a set of actions and conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicyRules
{
    /// <summary>Actions: A list of actions that are executed when all the conditions of a rule are satisfied.</summary>
    [JsonPropertyName("actions")]
    public required IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesActions> Actions { get; set; }

    /// <summary>Conditions: A list of conditions that must be matched for the actions to be executed</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRulesConditions>? Conditions { get; set; }

    /// <summary>Name: Name of the rule</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Order: The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a
    /// lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not
    /// require any condition and actions listed in it will always be applied.
    /// </summary>
    [JsonPropertyName("order")]
    public required int Order { get; set; }
}

/// <summary>DeliveryPolicy: A policy that specifies the delivery rules to be used for an endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecDeliveryPolicy
{
    /// <summary>Description: User-friendly description of the policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Rules: A list of the delivery rules.</summary>
    [JsonPropertyName("rules")]
    public required IList<V1api20210601ProfilesEndpointSpecDeliveryPolicyRules> Rules { get; set; }
}

/// <summary>Action: Action of the geo filter, i.e. allow or block access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecGeoFiltersActionEnum>))]
public enum V1api20210601ProfilesEndpointSpecGeoFiltersActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Block"), JsonStringEnumMemberName("Block")]
    Block
}

/// <summary>Rules defining user&apos;s geo access within a CDN endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecGeoFilters
{
    /// <summary>Action: Action of the geo filter, i.e. allow or block access.</summary>
    [JsonPropertyName("action")]
    public required V1api20210601ProfilesEndpointSpecGeoFiltersActionEnum Action { get; set; }

    /// <summary>CountryCodes: Two letter country or region codes defining user country or region access in a geo filter, e.g. AU, MX, US.</summary>
    [JsonPropertyName("countryCodes")]
    public required IList<string> CountryCodes { get; set; }

    /// <summary>RelativePath: Relative path applicable to geo filter. (e.g. &apos;/mypictures&apos;, &apos;/mypicture/kitty.jpg&apos;, and etc.)</summary>
    [JsonPropertyName("relativePath")]
    public required string RelativePath { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210601ProfilesEndpointSpecOperatorSpecSecretExpressions
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
public partial class V1api20210601ProfilesEndpointSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210601ProfilesEndpointSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210601ProfilesEndpointSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// OptimizationType: Specifies what scenario the customer wants this CDN endpoint to optimize for, e.g. Download, Media
/// services. With this information, CDN can apply scenario driven optimization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecOptimizationTypeEnum>))]
public enum V1api20210601ProfilesEndpointSpecOptimizationTypeEnum
{
    [EnumMember(Value = "DynamicSiteAcceleration"), JsonStringEnumMemberName("DynamicSiteAcceleration")]
    DynamicSiteAcceleration,
    [EnumMember(Value = "GeneralMediaStreaming"), JsonStringEnumMemberName("GeneralMediaStreaming")]
    GeneralMediaStreaming,
    [EnumMember(Value = "GeneralWebDelivery"), JsonStringEnumMemberName("GeneralWebDelivery")]
    GeneralWebDelivery,
    [EnumMember(Value = "LargeFileDownload"), JsonStringEnumMemberName("LargeFileDownload")]
    LargeFileDownload,
    [EnumMember(Value = "VideoOnDemandMediaStreaming"), JsonStringEnumMemberName("VideoOnDemandMediaStreaming")]
    VideoOnDemandMediaStreaming
}

/// <summary>ProbeProtocol: Protocol to use for health probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecOriginGroupsHealthProbeSettingsProbeProtocolEnum>))]
public enum V1api20210601ProfilesEndpointSpecOriginGroupsHealthProbeSettingsProbeProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https,
    [EnumMember(Value = "NotSet"), JsonStringEnumMemberName("NotSet")]
    NotSet
}

/// <summary>ProbeRequestType: The type of health probe request that is made.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecOriginGroupsHealthProbeSettingsProbeRequestTypeEnum>))]
public enum V1api20210601ProfilesEndpointSpecOriginGroupsHealthProbeSettingsProbeRequestTypeEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "HEAD"), JsonStringEnumMemberName("HEAD")]
    HEAD,
    [EnumMember(Value = "NotSet"), JsonStringEnumMemberName("NotSet")]
    NotSet
}

/// <summary>HealthProbeSettings: Health probe settings to the origin that is used to determine the health of the origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecOriginGroupsHealthProbeSettings
{
    /// <summary>ProbeIntervalInSeconds: The number of seconds between health probes.Default is 240sec.</summary>
    [JsonPropertyName("probeIntervalInSeconds")]
    public int? ProbeIntervalInSeconds { get; set; }

    /// <summary>ProbePath: The path relative to the origin that is used to determine the health of the origin.</summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary>ProbeProtocol: Protocol to use for health probe.</summary>
    [JsonPropertyName("probeProtocol")]
    public V1api20210601ProfilesEndpointSpecOriginGroupsHealthProbeSettingsProbeProtocolEnum? ProbeProtocol { get; set; }

    /// <summary>ProbeRequestType: The type of health probe request that is made.</summary>
    [JsonPropertyName("probeRequestType")]
    public V1api20210601ProfilesEndpointSpecOriginGroupsHealthProbeSettingsProbeRequestTypeEnum? ProbeRequestType { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecOriginGroupsOriginsReference
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

/// <summary>Reference to another resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecOriginGroupsOrigins
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20210601ProfilesEndpointSpecOriginGroupsOriginsReference? Reference { get; set; }
}

/// <summary>The JSON object that represents the range for http status codes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecOriginGroupsResponseBasedOriginErrorDetectionSettingsHttpErrorRanges
{
    /// <summary>Begin: The inclusive start of the http status code range.</summary>
    [JsonPropertyName("begin")]
    public int? Begin { get; set; }

    /// <summary>End: The inclusive end of the http status code range.</summary>
    [JsonPropertyName("end")]
    public int? End { get; set; }
}

/// <summary>ResponseBasedDetectedErrorTypes: Type of response errors for real user requests for which origin will be deemed unhealthy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecOriginGroupsResponseBasedOriginErrorDetectionSettingsResponseBasedDetectedErrorTypesEnum>))]
public enum V1api20210601ProfilesEndpointSpecOriginGroupsResponseBasedOriginErrorDetectionSettingsResponseBasedDetectedErrorTypesEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "TcpAndHttpErrors"), JsonStringEnumMemberName("TcpAndHttpErrors")]
    TcpAndHttpErrors,
    [EnumMember(Value = "TcpErrorsOnly"), JsonStringEnumMemberName("TcpErrorsOnly")]
    TcpErrorsOnly
}

/// <summary>
/// ResponseBasedOriginErrorDetectionSettings: The JSON object that contains the properties to determine origin health using
/// real requests/responses.This property is currently not supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecOriginGroupsResponseBasedOriginErrorDetectionSettings
{
    /// <summary>
    /// HttpErrorRanges: The list of Http status code ranges that are considered as server errors for origin and it is marked as
    /// unhealthy.
    /// </summary>
    [JsonPropertyName("httpErrorRanges")]
    public IList<V1api20210601ProfilesEndpointSpecOriginGroupsResponseBasedOriginErrorDetectionSettingsHttpErrorRanges>? HttpErrorRanges { get; set; }

    /// <summary>ResponseBasedDetectedErrorTypes: Type of response errors for real user requests for which origin will be deemed unhealthy</summary>
    [JsonPropertyName("responseBasedDetectedErrorTypes")]
    public V1api20210601ProfilesEndpointSpecOriginGroupsResponseBasedOriginErrorDetectionSettingsResponseBasedDetectedErrorTypesEnum? ResponseBasedDetectedErrorTypes { get; set; }

    /// <summary>ResponseBasedFailoverThresholdPercentage: The percentage of failed requests in the sample where failover should trigger.</summary>
    [JsonPropertyName("responseBasedFailoverThresholdPercentage")]
    public int? ResponseBasedFailoverThresholdPercentage { get; set; }
}

/// <summary>
/// The origin group for CDN content which is added when creating a CDN endpoint. Traffic is sent to the origins within the
/// origin group based on origin health.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecOriginGroups
{
    /// <summary>HealthProbeSettings: Health probe settings to the origin that is used to determine the health of the origin.</summary>
    [JsonPropertyName("healthProbeSettings")]
    public V1api20210601ProfilesEndpointSpecOriginGroupsHealthProbeSettings? HealthProbeSettings { get; set; }

    /// <summary>Name: Origin group name which must be unique within the endpoint.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Origins: The source of the content being delivered via CDN within given origin group.</summary>
    [JsonPropertyName("origins")]
    public required IList<V1api20210601ProfilesEndpointSpecOriginGroupsOrigins> Origins { get; set; }

    /// <summary>
    /// ResponseBasedOriginErrorDetectionSettings: The JSON object that contains the properties to determine origin health using
    /// real requests/responses.This property is currently not supported.
    /// </summary>
    [JsonPropertyName("responseBasedOriginErrorDetectionSettings")]
    public V1api20210601ProfilesEndpointSpecOriginGroupsResponseBasedOriginErrorDetectionSettings? ResponseBasedOriginErrorDetectionSettings { get; set; }

    /// <summary>
    /// TrafficRestorationTimeToHealedOrNewEndpointsInMinutes: Time in minutes to shift the traffic to the endpoint gradually
    /// when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not
    /// supported.
    /// </summary>
    [JsonPropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes")]
    public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }
}

/// <summary>
/// PrivateLinkLocationReference: The location of the Private Link resource. Required only if &apos;privateLinkResourceId&apos; is
/// populated
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecOriginsPrivateLinkLocationReference
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
/// PrivateLinkResourceReference: The Resource Id of the Private Link resource. Populating this optional field indicates
/// that this backend is &apos;Private&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecOriginsPrivateLinkResourceReference
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

/// <summary>The main origin of CDN content which is added when creating a CDN endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecOrigins
{
    /// <summary>Enabled: Origin is enabled for load balancing or not. By default, origin is always enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// HostName: The address of the origin. It can be a domain name, IPv4 address, or IPv6 address. This should be unique
    /// across all origins in an endpoint.
    /// </summary>
    [JsonPropertyName("hostName")]
    public required string HostName { get; set; }

    /// <summary>HttpPort: The value of the HTTP port. Must be between 1 and 65535.</summary>
    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    /// <summary>HttpsPort: The value of the HTTPS port. Must be between 1 and 65535.</summary>
    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    /// <summary>Name: Origin name which must be unique within the endpoint.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// OriginHostHeader: The host header value sent to the origin with each request. If you leave this blank, the request
    /// hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host
    /// header value to match the origin hostname by default.
    /// </summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary>
    /// Priority: Priority of origin in given origin group for load balancing. Higher priorities will not be used for load
    /// balancing if any lower priority origin is healthy.Must be between 1 and 5.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// PrivateLinkAlias: The Alias of the Private Link resource. Populating this optional field indicates that this origin is
    /// &apos;Private&apos;
    /// </summary>
    [JsonPropertyName("privateLinkAlias")]
    public string? PrivateLinkAlias { get; set; }

    /// <summary>PrivateLinkApprovalMessage: A custom message to be included in the approval request to connect to the Private Link.</summary>
    [JsonPropertyName("privateLinkApprovalMessage")]
    public string? PrivateLinkApprovalMessage { get; set; }

    /// <summary>
    /// PrivateLinkLocationReference: The location of the Private Link resource. Required only if &apos;privateLinkResourceId&apos; is
    /// populated
    /// </summary>
    [JsonPropertyName("privateLinkLocationReference")]
    public V1api20210601ProfilesEndpointSpecOriginsPrivateLinkLocationReference? PrivateLinkLocationReference { get; set; }

    /// <summary>
    /// PrivateLinkResourceReference: The Resource Id of the Private Link resource. Populating this optional field indicates
    /// that this backend is &apos;Private&apos;
    /// </summary>
    [JsonPropertyName("privateLinkResourceReference")]
    public V1api20210601ProfilesEndpointSpecOriginsPrivateLinkResourceReference? PrivateLinkResourceReference { get; set; }

    /// <summary>Weight: Weight of the origin in given origin group for load balancing. Must be between 1 and 1000</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a cdn.azure.com/Profile resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// QueryStringCachingBehavior: Defines how CDN caches requests that include query strings. You can ignore any query strings
/// when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request
/// with a unique URL.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecQueryStringCachingBehaviorEnum>))]
public enum V1api20210601ProfilesEndpointSpecQueryStringCachingBehaviorEnum
{
    [EnumMember(Value = "BypassCaching"), JsonStringEnumMemberName("BypassCaching")]
    BypassCaching,
    [EnumMember(Value = "IgnoreQueryString"), JsonStringEnumMemberName("IgnoreQueryString")]
    IgnoreQueryString,
    [EnumMember(Value = "NotSet"), JsonStringEnumMemberName("NotSet")]
    NotSet,
    [EnumMember(Value = "UseQueryString"), JsonStringEnumMemberName("UseQueryString")]
    UseQueryString
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601ProfilesEndpointSpecUrlSigningKeysKeySourceParametersTypeNameEnum>))]
public enum V1api20210601ProfilesEndpointSpecUrlSigningKeysKeySourceParametersTypeNameEnum
{
    [EnumMember(Value = "KeyVaultSigningKeyParameters"), JsonStringEnumMemberName("KeyVaultSigningKeyParameters")]
    KeyVaultSigningKeyParameters
}

/// <summary>KeySourceParameters: Defines the parameters for using customer key vault for Url Signing Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecUrlSigningKeysKeySourceParameters
{
    /// <summary>ResourceGroupName: Resource group of the user&apos;s Key Vault containing the secret</summary>
    [JsonPropertyName("resourceGroupName")]
    public required string ResourceGroupName { get; set; }

    /// <summary>SecretName: The name of secret in Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    /// <summary>SecretVersion: The version(GUID) of secret in Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public required string SecretVersion { get; set; }

    /// <summary>SubscriptionId: Subscription Id of the user&apos;s Key Vault containing the secret</summary>
    [JsonPropertyName("subscriptionId")]
    public required string SubscriptionId { get; set; }

    [JsonPropertyName("typeName")]
    public required V1api20210601ProfilesEndpointSpecUrlSigningKeysKeySourceParametersTypeNameEnum TypeName { get; set; }

    /// <summary>VaultName: The name of the user&apos;s Key Vault containing the secret</summary>
    [JsonPropertyName("vaultName")]
    public required string VaultName { get; set; }
}

/// <summary>Url signing key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecUrlSigningKeys
{
    /// <summary>
    /// KeyId: Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form
    /// the hash.
    /// </summary>
    [JsonPropertyName("keyId")]
    public required string KeyId { get; set; }

    /// <summary>KeySourceParameters: Defines the parameters for using customer key vault for Url Signing Key.</summary>
    [JsonPropertyName("keySourceParameters")]
    public required V1api20210601ProfilesEndpointSpecUrlSigningKeysKeySourceParameters KeySourceParameters { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecWebApplicationFirewallPolicyLinkReference
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

/// <summary>WebApplicationFirewallPolicyLink: Defines the Web Application Firewall policy for the endpoint (if applicable)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpecWebApplicationFirewallPolicyLink
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20210601ProfilesEndpointSpecWebApplicationFirewallPolicyLinkReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>ContentTypesToCompress: List of content types on which compression applies. The value should be a valid MIME type.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>DefaultOriginGroup: A reference to the origin group.</summary>
    [JsonPropertyName("defaultOriginGroup")]
    public V1api20210601ProfilesEndpointSpecDefaultOriginGroup? DefaultOriginGroup { get; set; }

    /// <summary>DeliveryPolicy: A policy that specifies the delivery rules to be used for an endpoint.</summary>
    [JsonPropertyName("deliveryPolicy")]
    public V1api20210601ProfilesEndpointSpecDeliveryPolicy? DeliveryPolicy { get; set; }

    /// <summary>
    /// GeoFilters: List of rules defining the user&apos;s geo access within a CDN endpoint. Each geo filter defines an access rule
    /// to a specified path or content, e.g. block APAC for path /pictures/
    /// </summary>
    [JsonPropertyName("geoFilters")]
    public IList<V1api20210601ProfilesEndpointSpecGeoFilters>? GeoFilters { get; set; }

    /// <summary>
    /// IsCompressionEnabled: Indicates whether content compression is enabled on CDN. Default value is false. If compression is
    /// enabled, content will be served as compressed if user requests for a compressed version. Content won&apos;t be compressed on
    /// CDN when requested content is smaller than 1 byte or larger than 1 MB.
    /// </summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }

    /// <summary>
    /// IsHttpAllowed: Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol
    /// (HTTP or HTTPS) must be allowed.
    /// </summary>
    [JsonPropertyName("isHttpAllowed")]
    public bool? IsHttpAllowed { get; set; }

    /// <summary>
    /// IsHttpsAllowed: Indicates whether HTTPS traffic is allowed on the endpoint. Default value is true. At least one protocol
    /// (HTTP or HTTPS) must be allowed.
    /// </summary>
    [JsonPropertyName("isHttpsAllowed")]
    public bool? IsHttpsAllowed { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210601ProfilesEndpointSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// OptimizationType: Specifies what scenario the customer wants this CDN endpoint to optimize for, e.g. Download, Media
    /// services. With this information, CDN can apply scenario driven optimization.
    /// </summary>
    [JsonPropertyName("optimizationType")]
    public V1api20210601ProfilesEndpointSpecOptimizationTypeEnum? OptimizationType { get; set; }

    /// <summary>OriginGroups: The origin groups comprising of origins that are used for load balancing the traffic based on availability.</summary>
    [JsonPropertyName("originGroups")]
    public IList<V1api20210601ProfilesEndpointSpecOriginGroups>? OriginGroups { get; set; }

    /// <summary>
    /// OriginHostHeader: The host header value sent to the origin with each request. This property at Endpoint is only allowed
    /// when endpoint uses single origin and can be overridden by the same property specified at origin.If you leave this blank,
    /// the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services
    /// require this host header value to match the origin hostname by default.
    /// </summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary>
    /// OriginPath: A directory path on the origin that CDN can use to retrieve content from, e.g.
    /// contoso.cloudapp.net/originpath.
    /// </summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>Origins: The source of the content being delivered via CDN.</summary>
    [JsonPropertyName("origins")]
    public required IList<V1api20210601ProfilesEndpointSpecOrigins> Origins { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a cdn.azure.com/Profile resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210601ProfilesEndpointSpecOwner Owner { get; set; }

    /// <summary>
    /// ProbePath: Path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the
    /// most optimal routes for the CDN. This is relative to the origin path. This property is only relevant when using a single
    /// origin.
    /// </summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary>
    /// QueryStringCachingBehavior: Defines how CDN caches requests that include query strings. You can ignore any query strings
    /// when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request
    /// with a unique URL.
    /// </summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public V1api20210601ProfilesEndpointSpecQueryStringCachingBehaviorEnum? QueryStringCachingBehavior { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>UrlSigningKeys: List of keys used to validate the signed URL hashes.</summary>
    [JsonPropertyName("urlSigningKeys")]
    public IList<V1api20210601ProfilesEndpointSpecUrlSigningKeys>? UrlSigningKeys { get; set; }

    /// <summary>WebApplicationFirewallPolicyLink: Defines the Web Application Firewall policy for the endpoint (if applicable)</summary>
    [JsonPropertyName("webApplicationFirewallPolicyLink")]
    public V1api20210601ProfilesEndpointSpecWebApplicationFirewallPolicyLink? WebApplicationFirewallPolicyLink { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusConditions
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

/// <summary>Custom domains created on the CDN endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusCustomDomains
{
    /// <summary>HostName: The host name of the custom domain. Must be a domain name.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>Name: Custom domain name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ValidationData: Special validation or data may be required when delivering CDN to some regions due to local compliance
    /// reasons. E.g. ICP license number of a custom domain is required to deliver content in China.
    /// </summary>
    [JsonPropertyName("validationData")]
    public string? ValidationData { get; set; }
}

/// <summary>DefaultOriginGroup: A reference to the origin group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDefaultOriginGroup
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsCacheExpirationParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsCacheExpiration
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsCacheExpirationParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsCacheKeyQueryStringParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsCacheKeyQueryString
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsCacheKeyQueryStringParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsModifyRequestHeaderParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsModifyRequestHeader
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsModifyRequestHeaderParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsModifyResponseHeaderParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsModifyResponseHeader
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsModifyResponseHeaderParameters? Parameters { get; set; }
}

/// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsOriginGroupOverrideParametersOriginGroup
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsOriginGroupOverrideParameters
{
    /// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsOriginGroupOverrideParametersOriginGroup? OriginGroup { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>OriginGroupOverride: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsOriginGroupOverride
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsOriginGroupOverrideParameters? Parameters { get; set; }
}

/// <summary>
/// CacheConfiguration: The caching configuration associated with this rule. To disable caching, do not provide a
/// cacheConfiguration object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfiguration
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// OriginGroupOverride: A reference to the origin group override configuration. Leave empty to use the default origin group
/// on route.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverride
{
    /// <summary>ForwardingProtocol: Protocol this rule will use when forwarding traffic to backends.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>OriginGroup: defines the OriginGroup that would override the DefaultOriginGroup on route.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup? OriginGroup { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParameters
{
    /// <summary>
    /// CacheConfiguration: The caching configuration associated with this rule. To disable caching, do not provide a
    /// cacheConfiguration object.
    /// </summary>
    [JsonPropertyName("cacheConfiguration")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfiguration? CacheConfiguration { get; set; }

    /// <summary>
    /// OriginGroupOverride: A reference to the origin group override configuration. Leave empty to use the default origin group
    /// on route.
    /// </summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverride? OriginGroupOverride { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>RouteConfigurationOverride: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverride
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRedirectParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRedirect
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRedirectParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRewriteParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRewrite
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRewriteParameters? Parameters { get; set; }
}

/// <summary>Defines how to identify a parameter for a specific purpose e.g. expires</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlSigningParametersParameterNameOverride
{
    /// <summary>ParamIndicator: Indicates the purpose of the parameter</summary>
    [JsonPropertyName("paramIndicator")]
    public string? ParamIndicator { get; set; }

    /// <summary>ParamName: Parameter name</summary>
    [JsonPropertyName("paramName")]
    public string? ParamName { get; set; }
}

/// <summary>Parameters: Defines the parameters for the action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlSigningParameters
{
    /// <summary>Algorithm: Algorithm to use for URL signing</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>ParameterNameOverride: Defines which query string parameters in the url to be considered for expires, key id etc.</summary>
    [JsonPropertyName("parameterNameOverride")]
    public IList<V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlSigningParametersParameterNameOverride>? ParameterNameOverride { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>UrlSigning: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlSigning
{
    /// <summary>Name: The name of the action for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlSigningParameters? Parameters { get; set; }
}

/// <summary>An action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActions
{
    /// <summary>CacheExpiration: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cacheExpiration")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsCacheExpiration? CacheExpiration { get; set; }

    /// <summary>CacheKeyQueryString: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cacheKeyQueryString")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsCacheKeyQueryString? CacheKeyQueryString { get; set; }

    /// <summary>ModifyRequestHeader: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("modifyRequestHeader")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsModifyRequestHeader? ModifyRequestHeader { get; set; }

    /// <summary>ModifyResponseHeader: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("modifyResponseHeader")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsModifyResponseHeader? ModifyResponseHeader { get; set; }

    /// <summary>OriginGroupOverride: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsOriginGroupOverride? OriginGroupOverride { get; set; }

    /// <summary>RouteConfigurationOverride: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("routeConfigurationOverride")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverride? RouteConfigurationOverride { get; set; }

    /// <summary>UrlRedirect: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlRedirect")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRedirect? UrlRedirect { get; set; }

    /// <summary>UrlRewrite: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlRewrite")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRewrite? UrlRewrite { get; set; }

    /// <summary>UrlSigning: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlSigning")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActionsUrlSigning? UrlSigning { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsClientPortParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsClientPort
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsClientPortParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsCookiesParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsCookies
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsCookiesParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsHostNameParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsHostName
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsHostNameParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsHttpVersionParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsHttpVersion
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsHttpVersionParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsIsDeviceParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsIsDevice
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsIsDeviceParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsPostArgsParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsPostArgs
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsPostArgsParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsQueryStringParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsQueryString
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsQueryStringParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRemoteAddressParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRemoteAddress
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRemoteAddressParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestBodyParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestBody
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestBodyParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestHeaderParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestHeader
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestHeaderParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestMethodParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestMethod
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestMethodParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestSchemeParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestScheme
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestSchemeParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestUriParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestUri
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestUriParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsServerPortParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsServerPort
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsServerPortParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsSocketAddrParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsSocketAddr
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsSocketAddrParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsSslProtocolParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsSslProtocol
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsSslProtocolParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileExtensionParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileExtension
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileExtensionParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileNameParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileName
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileNameParameters? Parameters { get; set; }
}

/// <summary>Parameters: Defines the parameters for the condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlPathParameters
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlPath
{
    /// <summary>Name: The name of the condition for the delivery rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameters: Defines the parameters for the condition.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlPathParameters? Parameters { get; set; }
}

/// <summary>A condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditions
{
    /// <summary>ClientPort: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("clientPort")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsClientPort? ClientPort { get; set; }

    /// <summary>Cookies: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cookies")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsCookies? Cookies { get; set; }

    /// <summary>HostName: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hostName")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsHostName? HostName { get; set; }

    /// <summary>HttpVersion: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("httpVersion")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsHttpVersion? HttpVersion { get; set; }

    /// <summary>IsDevice: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("isDevice")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsIsDevice? IsDevice { get; set; }

    /// <summary>PostArgs: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("postArgs")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsPostArgs? PostArgs { get; set; }

    /// <summary>QueryString: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("queryString")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsQueryString? QueryString { get; set; }

    /// <summary>RemoteAddress: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("remoteAddress")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRemoteAddress? RemoteAddress { get; set; }

    /// <summary>RequestBody: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestBody")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestBody? RequestBody { get; set; }

    /// <summary>RequestHeader: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestHeader")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestHeader? RequestHeader { get; set; }

    /// <summary>RequestMethod: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestMethod")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestMethod? RequestMethod { get; set; }

    /// <summary>RequestScheme: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestScheme")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestScheme? RequestScheme { get; set; }

    /// <summary>RequestUri: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("requestUri")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestUri? RequestUri { get; set; }

    /// <summary>ServerPort: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serverPort")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsServerPort? ServerPort { get; set; }

    /// <summary>SocketAddr: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("socketAddr")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsSocketAddr? SocketAddr { get; set; }

    /// <summary>SslProtocol: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sslProtocol")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsSslProtocol? SslProtocol { get; set; }

    /// <summary>UrlFileExtension: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlFileExtension")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileExtension? UrlFileExtension { get; set; }

    /// <summary>UrlFileName: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlFileName")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileName? UrlFileName { get; set; }

    /// <summary>UrlPath: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("urlPath")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlPath? UrlPath { get; set; }
}

/// <summary>A rule that specifies a set of actions and conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicyRules
{
    /// <summary>Actions: A list of actions that are executed when all the conditions of a rule are satisfied.</summary>
    [JsonPropertyName("actions")]
    public IList<V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesActions>? Actions { get; set; }

    /// <summary>Conditions: A list of conditions that must be matched for the actions to be executed</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210601ProfilesEndpointStatusDeliveryPolicyRulesConditions>? Conditions { get; set; }

    /// <summary>Name: Name of the rule</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Order: The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a
    /// lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not
    /// require any condition and actions listed in it will always be applied.
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }
}

/// <summary>DeliveryPolicy: A policy that specifies the delivery rules to be used for an endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusDeliveryPolicy
{
    /// <summary>Description: User-friendly description of the policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Rules: A list of the delivery rules.</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20210601ProfilesEndpointStatusDeliveryPolicyRules>? Rules { get; set; }
}

/// <summary>Rules defining user&apos;s geo access within a CDN endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusGeoFilters
{
    /// <summary>Action: Action of the geo filter, i.e. allow or block access.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>CountryCodes: Two letter country or region codes defining user country or region access in a geo filter, e.g. AU, MX, US.</summary>
    [JsonPropertyName("countryCodes")]
    public IList<string>? CountryCodes { get; set; }

    /// <summary>RelativePath: Relative path applicable to geo filter. (e.g. &apos;/mypictures&apos;, &apos;/mypicture/kitty.jpg&apos;, and etc.)</summary>
    [JsonPropertyName("relativePath")]
    public string? RelativePath { get; set; }
}

/// <summary>HealthProbeSettings: Health probe settings to the origin that is used to determine the health of the origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusOriginGroupsHealthProbeSettings
{
    /// <summary>ProbeIntervalInSeconds: The number of seconds between health probes.Default is 240sec.</summary>
    [JsonPropertyName("probeIntervalInSeconds")]
    public int? ProbeIntervalInSeconds { get; set; }

    /// <summary>ProbePath: The path relative to the origin that is used to determine the health of the origin.</summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary>ProbeProtocol: Protocol to use for health probe.</summary>
    [JsonPropertyName("probeProtocol")]
    public string? ProbeProtocol { get; set; }

    /// <summary>ProbeRequestType: The type of health probe request that is made.</summary>
    [JsonPropertyName("probeRequestType")]
    public string? ProbeRequestType { get; set; }
}

/// <summary>Reference to another resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusOriginGroupsOrigins
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>The JSON object that represents the range for http status codes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusOriginGroupsResponseBasedOriginErrorDetectionSettingsHttpErrorRanges
{
    /// <summary>Begin: The inclusive start of the http status code range.</summary>
    [JsonPropertyName("begin")]
    public int? Begin { get; set; }

    /// <summary>End: The inclusive end of the http status code range.</summary>
    [JsonPropertyName("end")]
    public int? End { get; set; }
}

/// <summary>
/// ResponseBasedOriginErrorDetectionSettings: The JSON object that contains the properties to determine origin health using
/// real requests/responses.This property is currently not supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusOriginGroupsResponseBasedOriginErrorDetectionSettings
{
    /// <summary>
    /// HttpErrorRanges: The list of Http status code ranges that are considered as server errors for origin and it is marked as
    /// unhealthy.
    /// </summary>
    [JsonPropertyName("httpErrorRanges")]
    public IList<V1api20210601ProfilesEndpointStatusOriginGroupsResponseBasedOriginErrorDetectionSettingsHttpErrorRanges>? HttpErrorRanges { get; set; }

    /// <summary>ResponseBasedDetectedErrorTypes: Type of response errors for real user requests for which origin will be deemed unhealthy</summary>
    [JsonPropertyName("responseBasedDetectedErrorTypes")]
    public string? ResponseBasedDetectedErrorTypes { get; set; }

    /// <summary>ResponseBasedFailoverThresholdPercentage: The percentage of failed requests in the sample where failover should trigger.</summary>
    [JsonPropertyName("responseBasedFailoverThresholdPercentage")]
    public int? ResponseBasedFailoverThresholdPercentage { get; set; }
}

/// <summary>
/// The origin group for CDN content which is added when creating a CDN endpoint. Traffic is sent to the origins within the
/// origin group based on origin health.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusOriginGroups
{
    /// <summary>HealthProbeSettings: Health probe settings to the origin that is used to determine the health of the origin.</summary>
    [JsonPropertyName("healthProbeSettings")]
    public V1api20210601ProfilesEndpointStatusOriginGroupsHealthProbeSettings? HealthProbeSettings { get; set; }

    /// <summary>Name: Origin group name which must be unique within the endpoint.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Origins: The source of the content being delivered via CDN within given origin group.</summary>
    [JsonPropertyName("origins")]
    public IList<V1api20210601ProfilesEndpointStatusOriginGroupsOrigins>? Origins { get; set; }

    /// <summary>
    /// ResponseBasedOriginErrorDetectionSettings: The JSON object that contains the properties to determine origin health using
    /// real requests/responses.This property is currently not supported.
    /// </summary>
    [JsonPropertyName("responseBasedOriginErrorDetectionSettings")]
    public V1api20210601ProfilesEndpointStatusOriginGroupsResponseBasedOriginErrorDetectionSettings? ResponseBasedOriginErrorDetectionSettings { get; set; }

    /// <summary>
    /// TrafficRestorationTimeToHealedOrNewEndpointsInMinutes: Time in minutes to shift the traffic to the endpoint gradually
    /// when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not
    /// supported.
    /// </summary>
    [JsonPropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes")]
    public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }
}

/// <summary>The main origin of CDN content which is added when creating a CDN endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusOrigins
{
    /// <summary>Enabled: Origin is enabled for load balancing or not. By default, origin is always enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// HostName: The address of the origin. It can be a domain name, IPv4 address, or IPv6 address. This should be unique
    /// across all origins in an endpoint.
    /// </summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>HttpPort: The value of the HTTP port. Must be between 1 and 65535.</summary>
    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    /// <summary>HttpsPort: The value of the HTTPS port. Must be between 1 and 65535.</summary>
    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    /// <summary>Name: Origin name which must be unique within the endpoint.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// OriginHostHeader: The host header value sent to the origin with each request. If you leave this blank, the request
    /// hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host
    /// header value to match the origin hostname by default.
    /// </summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary>
    /// Priority: Priority of origin in given origin group for load balancing. Higher priorities will not be used for load
    /// balancing if any lower priority origin is healthy.Must be between 1 and 5.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>PrivateEndpointStatus: The approval status for the connection to the Private Link</summary>
    [JsonPropertyName("privateEndpointStatus")]
    public string? PrivateEndpointStatus { get; set; }

    /// <summary>
    /// PrivateLinkAlias: The Alias of the Private Link resource. Populating this optional field indicates that this origin is
    /// &apos;Private&apos;
    /// </summary>
    [JsonPropertyName("privateLinkAlias")]
    public string? PrivateLinkAlias { get; set; }

    /// <summary>PrivateLinkApprovalMessage: A custom message to be included in the approval request to connect to the Private Link.</summary>
    [JsonPropertyName("privateLinkApprovalMessage")]
    public string? PrivateLinkApprovalMessage { get; set; }

    /// <summary>PrivateLinkLocation: The location of the Private Link resource. Required only if &apos;privateLinkResourceId&apos; is populated</summary>
    [JsonPropertyName("privateLinkLocation")]
    public string? PrivateLinkLocation { get; set; }

    /// <summary>
    /// PrivateLinkResourceId: The Resource Id of the Private Link resource. Populating this optional field indicates that this
    /// backend is &apos;Private&apos;
    /// </summary>
    [JsonPropertyName("privateLinkResourceId")]
    public string? PrivateLinkResourceId { get; set; }

    /// <summary>Weight: Weight of the origin in given origin group for load balancing. Must be between 1 and 1000</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>SystemData: Read only system data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusSystemData
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

/// <summary>KeySourceParameters: Defines the parameters for using customer key vault for Url Signing Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusUrlSigningKeysKeySourceParameters
{
    /// <summary>ResourceGroupName: Resource group of the user&apos;s Key Vault containing the secret</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>SecretName: The name of secret in Key Vault.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>SecretVersion: The version(GUID) of secret in Key Vault.</summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }

    /// <summary>SubscriptionId: Subscription Id of the user&apos;s Key Vault containing the secret</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>VaultName: The name of the user&apos;s Key Vault containing the secret</summary>
    [JsonPropertyName("vaultName")]
    public string? VaultName { get; set; }
}

/// <summary>Url signing key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusUrlSigningKeys
{
    /// <summary>
    /// KeyId: Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form
    /// the hash.
    /// </summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>KeySourceParameters: Defines the parameters for using customer key vault for Url Signing Key.</summary>
    [JsonPropertyName("keySourceParameters")]
    public V1api20210601ProfilesEndpointStatusUrlSigningKeysKeySourceParameters? KeySourceParameters { get; set; }
}

/// <summary>WebApplicationFirewallPolicyLink: Defines the Web Application Firewall policy for the endpoint (if applicable)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatusWebApplicationFirewallPolicyLink
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601ProfilesEndpointStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210601ProfilesEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>ContentTypesToCompress: List of content types on which compression applies. The value should be a valid MIME type.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>CustomDomains: The custom domains under the endpoint.</summary>
    [JsonPropertyName("customDomains")]
    public IList<V1api20210601ProfilesEndpointStatusCustomDomains>? CustomDomains { get; set; }

    /// <summary>DefaultOriginGroup: A reference to the origin group.</summary>
    [JsonPropertyName("defaultOriginGroup")]
    public V1api20210601ProfilesEndpointStatusDefaultOriginGroup? DefaultOriginGroup { get; set; }

    /// <summary>DeliveryPolicy: A policy that specifies the delivery rules to be used for an endpoint.</summary>
    [JsonPropertyName("deliveryPolicy")]
    public V1api20210601ProfilesEndpointStatusDeliveryPolicy? DeliveryPolicy { get; set; }

    /// <summary>
    /// GeoFilters: List of rules defining the user&apos;s geo access within a CDN endpoint. Each geo filter defines an access rule
    /// to a specified path or content, e.g. block APAC for path /pictures/
    /// </summary>
    [JsonPropertyName("geoFilters")]
    public IList<V1api20210601ProfilesEndpointStatusGeoFilters>? GeoFilters { get; set; }

    /// <summary>HostName: The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IsCompressionEnabled: Indicates whether content compression is enabled on CDN. Default value is false. If compression is
    /// enabled, content will be served as compressed if user requests for a compressed version. Content won&apos;t be compressed on
    /// CDN when requested content is smaller than 1 byte or larger than 1 MB.
    /// </summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }

    /// <summary>
    /// IsHttpAllowed: Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol
    /// (HTTP or HTTPS) must be allowed.
    /// </summary>
    [JsonPropertyName("isHttpAllowed")]
    public bool? IsHttpAllowed { get; set; }

    /// <summary>
    /// IsHttpsAllowed: Indicates whether HTTPS traffic is allowed on the endpoint. Default value is true. At least one protocol
    /// (HTTP or HTTPS) must be allowed.
    /// </summary>
    [JsonPropertyName("isHttpsAllowed")]
    public bool? IsHttpsAllowed { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// OptimizationType: Specifies what scenario the customer wants this CDN endpoint to optimize for, e.g. Download, Media
    /// services. With this information, CDN can apply scenario driven optimization.
    /// </summary>
    [JsonPropertyName("optimizationType")]
    public string? OptimizationType { get; set; }

    /// <summary>OriginGroups: The origin groups comprising of origins that are used for load balancing the traffic based on availability.</summary>
    [JsonPropertyName("originGroups")]
    public IList<V1api20210601ProfilesEndpointStatusOriginGroups>? OriginGroups { get; set; }

    /// <summary>
    /// OriginHostHeader: The host header value sent to the origin with each request. This property at Endpoint is only allowed
    /// when endpoint uses single origin and can be overridden by the same property specified at origin.If you leave this blank,
    /// the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services
    /// require this host header value to match the origin hostname by default.
    /// </summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary>
    /// OriginPath: A directory path on the origin that CDN can use to retrieve content from, e.g.
    /// contoso.cloudapp.net/originpath.
    /// </summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>Origins: The source of the content being delivered via CDN.</summary>
    [JsonPropertyName("origins")]
    public IList<V1api20210601ProfilesEndpointStatusOrigins>? Origins { get; set; }

    /// <summary>
    /// ProbePath: Path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the
    /// most optimal routes for the CDN. This is relative to the origin path. This property is only relevant when using a single
    /// origin.
    /// </summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary>ProvisioningState: Provisioning status of the endpoint.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// QueryStringCachingBehavior: Defines how CDN caches requests that include query strings. You can ignore any query strings
    /// when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request
    /// with a unique URL.
    /// </summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>ResourceState: Resource status of the endpoint.</summary>
    [JsonPropertyName("resourceState")]
    public string? ResourceState { get; set; }

    /// <summary>SystemData: Read only system data</summary>
    [JsonPropertyName("systemData")]
    public V1api20210601ProfilesEndpointStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UrlSigningKeys: List of keys used to validate the signed URL hashes.</summary>
    [JsonPropertyName("urlSigningKeys")]
    public IList<V1api20210601ProfilesEndpointStatusUrlSigningKeys>? UrlSigningKeys { get; set; }

    /// <summary>WebApplicationFirewallPolicyLink: Defines the Web Application Firewall policy for the endpoint (if applicable)</summary>
    [JsonPropertyName("webApplicationFirewallPolicyLink")]
    public V1api20210601ProfilesEndpointStatusWebApplicationFirewallPolicyLink? WebApplicationFirewallPolicyLink { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cdn/resource-manager/Microsoft.Cdn/Cdn/stable/2021-06-01/cdn.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601ProfilesEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210601ProfilesEndpointSpec?>, IStatus<V1api20210601ProfilesEndpointStatus?>
{
    public const string KubeApiVersion = "v1api20210601";
    public const string KubeKind = "ProfilesEndpoint";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "profilesendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.com/v1api20210601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProfilesEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210601ProfilesEndpointSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20210601ProfilesEndpointStatus? Status { get; set; }
}