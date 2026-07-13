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
/// <summary>API is the Schema for the APIs API. Manages an API within an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2APIList : IKubernetesObject<V1ListMeta>, IItems<V1beta2API>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "APIList";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "apis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2API objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2API> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APISpecDeletionPolicyEnum>))]
public enum V1beta2APISpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APISpecForProviderApiManagementNameRefPolicyResolutionEnum>))]
public enum V1beta2APISpecForProviderApiManagementNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APISpecForProviderApiManagementNameRefPolicyResolveEnum>))]
public enum V1beta2APISpecForProviderApiManagementNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderApiManagementNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APISpecForProviderApiManagementNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APISpecForProviderApiManagementNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderApiManagementNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APISpecForProviderApiManagementNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APISpecForProviderApiManagementNameSelectorPolicyResolutionEnum>))]
public enum V1beta2APISpecForProviderApiManagementNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APISpecForProviderApiManagementNameSelectorPolicyResolveEnum>))]
public enum V1beta2APISpecForProviderApiManagementNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderApiManagementNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APISpecForProviderApiManagementNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APISpecForProviderApiManagementNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderApiManagementNameSelector
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
    public V1beta2APISpecForProviderApiManagementNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A contact block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderContact
{
    /// <summary>The email address of the contact person/organization.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>The name of the contact person/organization.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Absolute URL of the contact information.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A wsdl_selector block as defined below, which allows you to limit the import of a WSDL to only a subset of the document. This can only be specified when content_format is wsdl or wsdl-link.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderImportWsdlSelector
{
    /// <summary>The name of endpoint (port) to import from WSDL.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>The name of service to import from WSDL.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>A import block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderImport
{
    /// <summary>The format of the content from which the API Definition should be imported. Possible values are: openapi, openapi+json, openapi+json-link, openapi-link, swagger-json, swagger-link-json, wadl-link-json, wadl-xml, wsdl and wsdl-link.</summary>
    [JsonPropertyName("contentFormat")]
    public string? ContentFormat { get; set; }

    /// <summary>The Content from which the API Definition should be imported. When a content_format of *-link-* is specified this must be a URL, otherwise this must be defined inline. The URL must be accessible and return a valid document; otherwise, deployment may fail.</summary>
    [JsonPropertyName("contentValue")]
    public string? ContentValue { get; set; }

    /// <summary>A wsdl_selector block as defined below, which allows you to limit the import of a WSDL to only a subset of the document. This can only be specified when content_format is wsdl or wsdl-link.</summary>
    [JsonPropertyName("wsdlSelector")]
    public V1beta2APISpecForProviderImportWsdlSelector? WsdlSelector { get; set; }
}

/// <summary>A license block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderLicense
{
    /// <summary>The name of the license .</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Absolute URL of the license.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>An oauth2_authorization block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderOauth2Authorization
{
    /// <summary>OAuth authorization server identifier. The name of an OAuth2 Authorization Server.</summary>
    [JsonPropertyName("authorizationServerName")]
    public string? AuthorizationServerName { get; set; }

    /// <summary>Operations scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>An openid_authentication block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderOpenidAuthentication
{
    /// <summary>How to send token to the server. A list of zero or more methods. Valid values are authorizationHeader and query.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>OpenID Connect provider identifier. The name of an OpenID Connect Provider.</summary>
    [JsonPropertyName("openidProviderName")]
    public string? OpenidProviderName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APISpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2APISpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APISpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2APISpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APISpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APISpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APISpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APISpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2APISpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APISpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2APISpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APISpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APISpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderResourceGroupNameSelector
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
    public V1beta2APISpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A subscription_key_parameter_names block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProviderSubscriptionKeyParameterNames
{
    /// <summary>The name of the HTTP Header which should be used for the Subscription Key.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>The name of the QueryString parameter which should be used for the Subscription Key.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecForProvider
{
    /// <summary>The Name of the API Management Service where this API should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameRef")]
    public V1beta2APISpecForProviderApiManagementNameRef? ApiManagementNameRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameSelector")]
    public V1beta2APISpecForProviderApiManagementNameSelector? ApiManagementNameSelector { get; set; }

    /// <summary>Type of API. Possible values are graphql, http, soap, and websocket. Defaults to http.</summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary>A contact block as documented below.</summary>
    [JsonPropertyName("contact")]
    public V1beta2APISpecForProviderContact? Contact { get; set; }

    /// <summary>A description of the API Management API, which may include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the API.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A import block as documented below.</summary>
    [JsonPropertyName("import")]
    public V1beta2APISpecForProviderImport? Import { get; set; }

    /// <summary>A license block as documented below.</summary>
    [JsonPropertyName("license")]
    public V1beta2APISpecForProviderLicense? License { get; set; }

    /// <summary>An oauth2_authorization block as documented below.</summary>
    [JsonPropertyName("oauth2Authorization")]
    public V1beta2APISpecForProviderOauth2Authorization? Oauth2Authorization { get; set; }

    /// <summary>An openid_authentication block as documented below.</summary>
    [JsonPropertyName("openidAuthentication")]
    public V1beta2APISpecForProviderOpenidAuthentication? OpenidAuthentication { get; set; }

    /// <summary>The Path for this API Management API, which is a relative URL which uniquely identifies this API and all of its resource paths within the API Management Service.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A list of protocols the operations in this API can be invoked. Possible values are http, https, ws, and wss.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>The Name of the Resource Group where the API Management API exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2APISpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2APISpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The Revision which used for this API. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("revision")]
    public required string Revision { get; set; }

    /// <summary>The description of the API Revision of the API Management API.</summary>
    [JsonPropertyName("revisionDescription")]
    public string? RevisionDescription { get; set; }

    /// <summary>Absolute URL of the backend service implementing this API.</summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>The API id of the source API, which could be in format azurerm_api_management_api.example.id or in format azurerm_api_management_api.example.id;rev=1</summary>
    [JsonPropertyName("sourceApiId")]
    public string? SourceApiId { get; set; }

    /// <summary>A subscription_key_parameter_names block as documented below.</summary>
    [JsonPropertyName("subscriptionKeyParameterNames")]
    public V1beta2APISpecForProviderSubscriptionKeyParameterNames? SubscriptionKeyParameterNames { get; set; }

    /// <summary>Should this API require a subscription key? Defaults to true.</summary>
    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    /// <summary>Absolute URL of the Terms of Service for the API.</summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary>The Version number of this API, if this API is versioned.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The description of the API Version of the API Management API.</summary>
    [JsonPropertyName("versionDescription")]
    public string? VersionDescription { get; set; }

    /// <summary>The ID of the Version Set which this API is associated with.</summary>
    [JsonPropertyName("versionSetId")]
    public string? VersionSetId { get; set; }
}

/// <summary>A contact block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecInitProviderContact
{
    /// <summary>The email address of the contact person/organization.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>The name of the contact person/organization.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Absolute URL of the contact information.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A wsdl_selector block as defined below, which allows you to limit the import of a WSDL to only a subset of the document. This can only be specified when content_format is wsdl or wsdl-link.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecInitProviderImportWsdlSelector
{
    /// <summary>The name of endpoint (port) to import from WSDL.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>The name of service to import from WSDL.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>A import block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecInitProviderImport
{
    /// <summary>The format of the content from which the API Definition should be imported. Possible values are: openapi, openapi+json, openapi+json-link, openapi-link, swagger-json, swagger-link-json, wadl-link-json, wadl-xml, wsdl and wsdl-link.</summary>
    [JsonPropertyName("contentFormat")]
    public string? ContentFormat { get; set; }

    /// <summary>The Content from which the API Definition should be imported. When a content_format of *-link-* is specified this must be a URL, otherwise this must be defined inline. The URL must be accessible and return a valid document; otherwise, deployment may fail.</summary>
    [JsonPropertyName("contentValue")]
    public string? ContentValue { get; set; }

    /// <summary>A wsdl_selector block as defined below, which allows you to limit the import of a WSDL to only a subset of the document. This can only be specified when content_format is wsdl or wsdl-link.</summary>
    [JsonPropertyName("wsdlSelector")]
    public V1beta2APISpecInitProviderImportWsdlSelector? WsdlSelector { get; set; }
}

/// <summary>A license block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecInitProviderLicense
{
    /// <summary>The name of the license .</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Absolute URL of the license.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>An oauth2_authorization block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecInitProviderOauth2Authorization
{
    /// <summary>OAuth authorization server identifier. The name of an OAuth2 Authorization Server.</summary>
    [JsonPropertyName("authorizationServerName")]
    public string? AuthorizationServerName { get; set; }

    /// <summary>Operations scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>An openid_authentication block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecInitProviderOpenidAuthentication
{
    /// <summary>How to send token to the server. A list of zero or more methods. Valid values are authorizationHeader and query.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>OpenID Connect provider identifier. The name of an OpenID Connect Provider.</summary>
    [JsonPropertyName("openidProviderName")]
    public string? OpenidProviderName { get; set; }
}

/// <summary>A subscription_key_parameter_names block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecInitProviderSubscriptionKeyParameterNames
{
    /// <summary>The name of the HTTP Header which should be used for the Subscription Key.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>The name of the QueryString parameter which should be used for the Subscription Key.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
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
public partial class V1beta2APISpecInitProvider
{
    /// <summary>Type of API. Possible values are graphql, http, soap, and websocket. Defaults to http.</summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary>A contact block as documented below.</summary>
    [JsonPropertyName("contact")]
    public V1beta2APISpecInitProviderContact? Contact { get; set; }

    /// <summary>A description of the API Management API, which may include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the API.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A import block as documented below.</summary>
    [JsonPropertyName("import")]
    public V1beta2APISpecInitProviderImport? Import { get; set; }

    /// <summary>A license block as documented below.</summary>
    [JsonPropertyName("license")]
    public V1beta2APISpecInitProviderLicense? License { get; set; }

    /// <summary>An oauth2_authorization block as documented below.</summary>
    [JsonPropertyName("oauth2Authorization")]
    public V1beta2APISpecInitProviderOauth2Authorization? Oauth2Authorization { get; set; }

    /// <summary>An openid_authentication block as documented below.</summary>
    [JsonPropertyName("openidAuthentication")]
    public V1beta2APISpecInitProviderOpenidAuthentication? OpenidAuthentication { get; set; }

    /// <summary>The Path for this API Management API, which is a relative URL which uniquely identifies this API and all of its resource paths within the API Management Service.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A list of protocols the operations in this API can be invoked. Possible values are http, https, ws, and wss.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>The description of the API Revision of the API Management API.</summary>
    [JsonPropertyName("revisionDescription")]
    public string? RevisionDescription { get; set; }

    /// <summary>Absolute URL of the backend service implementing this API.</summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>The API id of the source API, which could be in format azurerm_api_management_api.example.id or in format azurerm_api_management_api.example.id;rev=1</summary>
    [JsonPropertyName("sourceApiId")]
    public string? SourceApiId { get; set; }

    /// <summary>A subscription_key_parameter_names block as documented below.</summary>
    [JsonPropertyName("subscriptionKeyParameterNames")]
    public V1beta2APISpecInitProviderSubscriptionKeyParameterNames? SubscriptionKeyParameterNames { get; set; }

    /// <summary>Should this API require a subscription key? Defaults to true.</summary>
    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    /// <summary>Absolute URL of the Terms of Service for the API.</summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary>The Version number of this API, if this API is versioned.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The description of the API Version of the API Management API.</summary>
    [JsonPropertyName("versionDescription")]
    public string? VersionDescription { get; set; }

    /// <summary>The ID of the Version Set which this API is associated with.</summary>
    [JsonPropertyName("versionSetId")]
    public string? VersionSetId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APISpecManagementPoliciesEnum>))]
public enum V1beta2APISpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APISpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2APISpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2APISpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2APISpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2APISpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2APISpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2APISpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>APISpec defines the desired state of API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APISpec
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
    public V1beta2APISpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2APISpecForProvider ForProvider { get; set; }

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
    public V1beta2APISpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2APISpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2APISpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2APISpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A contact block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIStatusAtProviderContact
{
    /// <summary>The email address of the contact person/organization.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>The name of the contact person/organization.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Absolute URL of the contact information.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A wsdl_selector block as defined below, which allows you to limit the import of a WSDL to only a subset of the document. This can only be specified when content_format is wsdl or wsdl-link.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIStatusAtProviderImportWsdlSelector
{
    /// <summary>The name of endpoint (port) to import from WSDL.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>The name of service to import from WSDL.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>A import block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIStatusAtProviderImport
{
    /// <summary>The format of the content from which the API Definition should be imported. Possible values are: openapi, openapi+json, openapi+json-link, openapi-link, swagger-json, swagger-link-json, wadl-link-json, wadl-xml, wsdl and wsdl-link.</summary>
    [JsonPropertyName("contentFormat")]
    public string? ContentFormat { get; set; }

    /// <summary>The Content from which the API Definition should be imported. When a content_format of *-link-* is specified this must be a URL, otherwise this must be defined inline. The URL must be accessible and return a valid document; otherwise, deployment may fail.</summary>
    [JsonPropertyName("contentValue")]
    public string? ContentValue { get; set; }

    /// <summary>A wsdl_selector block as defined below, which allows you to limit the import of a WSDL to only a subset of the document. This can only be specified when content_format is wsdl or wsdl-link.</summary>
    [JsonPropertyName("wsdlSelector")]
    public V1beta2APIStatusAtProviderImportWsdlSelector? WsdlSelector { get; set; }
}

/// <summary>A license block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIStatusAtProviderLicense
{
    /// <summary>The name of the license .</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Absolute URL of the license.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>An oauth2_authorization block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIStatusAtProviderOauth2Authorization
{
    /// <summary>OAuth authorization server identifier. The name of an OAuth2 Authorization Server.</summary>
    [JsonPropertyName("authorizationServerName")]
    public string? AuthorizationServerName { get; set; }

    /// <summary>Operations scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>An openid_authentication block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIStatusAtProviderOpenidAuthentication
{
    /// <summary>How to send token to the server. A list of zero or more methods. Valid values are authorizationHeader and query.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>OpenID Connect provider identifier. The name of an OpenID Connect Provider.</summary>
    [JsonPropertyName("openidProviderName")]
    public string? OpenidProviderName { get; set; }
}

/// <summary>A subscription_key_parameter_names block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIStatusAtProviderSubscriptionKeyParameterNames
{
    /// <summary>The name of the HTTP Header which should be used for the Subscription Key.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>The name of the QueryString parameter which should be used for the Subscription Key.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIStatusAtProvider
{
    /// <summary>The Name of the API Management Service where this API should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Type of API. Possible values are graphql, http, soap, and websocket. Defaults to http.</summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary>A contact block as documented below.</summary>
    [JsonPropertyName("contact")]
    public V1beta2APIStatusAtProviderContact? Contact { get; set; }

    /// <summary>A description of the API Management API, which may include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the API.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the API Management API.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A import block as documented below.</summary>
    [JsonPropertyName("import")]
    public V1beta2APIStatusAtProviderImport? Import { get; set; }

    /// <summary>Is this the current API Revision?</summary>
    [JsonPropertyName("isCurrent")]
    public bool? IsCurrent { get; set; }

    /// <summary>Is this API Revision online/accessible via the Gateway?</summary>
    [JsonPropertyName("isOnline")]
    public bool? IsOnline { get; set; }

    /// <summary>A license block as documented below.</summary>
    [JsonPropertyName("license")]
    public V1beta2APIStatusAtProviderLicense? License { get; set; }

    /// <summary>An oauth2_authorization block as documented below.</summary>
    [JsonPropertyName("oauth2Authorization")]
    public V1beta2APIStatusAtProviderOauth2Authorization? Oauth2Authorization { get; set; }

    /// <summary>An openid_authentication block as documented below.</summary>
    [JsonPropertyName("openidAuthentication")]
    public V1beta2APIStatusAtProviderOpenidAuthentication? OpenidAuthentication { get; set; }

    /// <summary>The Path for this API Management API, which is a relative URL which uniquely identifies this API and all of its resource paths within the API Management Service.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A list of protocols the operations in this API can be invoked. Possible values are http, https, ws, and wss.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>The Name of the Resource Group where the API Management API exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The Revision which used for this API. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>The description of the API Revision of the API Management API.</summary>
    [JsonPropertyName("revisionDescription")]
    public string? RevisionDescription { get; set; }

    /// <summary>Absolute URL of the backend service implementing this API.</summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>The API id of the source API, which could be in format azurerm_api_management_api.example.id or in format azurerm_api_management_api.example.id;rev=1</summary>
    [JsonPropertyName("sourceApiId")]
    public string? SourceApiId { get; set; }

    /// <summary>A subscription_key_parameter_names block as documented below.</summary>
    [JsonPropertyName("subscriptionKeyParameterNames")]
    public V1beta2APIStatusAtProviderSubscriptionKeyParameterNames? SubscriptionKeyParameterNames { get; set; }

    /// <summary>Should this API require a subscription key? Defaults to true.</summary>
    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    /// <summary>Absolute URL of the Terms of Service for the API.</summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary>The Version number of this API, if this API is versioned.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The description of the API Version of the API Management API.</summary>
    [JsonPropertyName("versionDescription")]
    public string? VersionDescription { get; set; }

    /// <summary>The ID of the Version Set which this API is associated with.</summary>
    [JsonPropertyName("versionSetId")]
    public string? VersionSetId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIStatusConditions
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

/// <summary>APIStatus defines the observed state of API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2APIStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2APIStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2APIStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>API is the Schema for the APIs API. Manages an API within an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2API : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2APISpec>, IStatus<V1beta2APIStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "API";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "apis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "API";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APISpec defines the desired state of API</summary>
    [JsonPropertyName("spec")]
    public required V1beta2APISpec Spec { get; set; }

    /// <summary>APIStatus defines the observed state of API.</summary>
    [JsonPropertyName("status")]
    public V1beta2APIStatus? Status { get; set; }
}