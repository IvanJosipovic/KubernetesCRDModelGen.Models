#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.resources.azapi.upbound.io;
/// <summary>
/// Resource is the Schema for the Resources API. Manages a Azure resource
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.1.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResourceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Resource>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourceList";
    public const string KubeGroup = "resources.azapi.upbound.io";
    public const string KubePluralName = "resources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "resources.azapi.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Resource objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Resource> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public enum V1beta1ResourceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceSpecForProviderIdentity
{
    /// <summary>A list of User Managed Identity ID&apos;s which should be assigned to the azure resource.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Type of Identity which should be used for this azure resource. Possible values are SystemAssigned, UserAssigned and SystemAssigned,UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>(Attributes) The retry object supports the following attributes: (see below for nested schema)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceSpecForProviderRetry
{
    /// <summary>
    /// (List of String) A list of regular expressions to match against error messages. If any of the regular expressions match, the request will be retried.
    /// A list of regular expressions to match against error messages. If any of the regular expressions match, the request will be retried.
    /// </summary>
    [JsonPropertyName("errorMessageRegex")]
    public IList<string>? ErrorMessageRegex { get; set; }

    /// <summary>
    /// (Number) The base number of seconds to wait between retries. Default is 10.
    /// The base number of seconds to wait between retries. Default is `10`.
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// (Number) The maximum number of seconds to wait between retries. Default is 180.
    /// The maximum number of seconds to wait between retries. Default is `180`.
    /// </summary>
    [JsonPropertyName("maxIntervalSeconds")]
    public double? MaxIntervalSeconds { get; set; }

    /// <summary>
    /// (Number, Deprecated) The multiplier to apply to the interval between retries. Default is 1.5.
    /// The multiplier to apply to the interval between retries. Default is `1.5`.
    /// </summary>
    [JsonPropertyName("multiplier")]
    public double? Multiplier { get; set; }

    /// <summary>
    /// RandomizationFactor, 1 + RandomizationFactor]). Therefore set to zero 0.0 for no randomization. Default is 0.5.
    /// The randomization factor to apply to the interval between retries. The formula for the randomized interval is: `RetryInterval * (random value in range [1 - RandomizationFactor, 1 + RandomizationFactor])`. Therefore set to zero `0.0` for no randomization. Default is `0.5`.
    /// </summary>
    [JsonPropertyName("randomizationFactor")]
    public double? RandomizationFactor { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceSpecForProvider
{
    /// <summary>A JSON object that contains the request body used to create and update azure resource.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// (Map of String) A mapping of headers to be sent with the create request.
    /// A mapping of headers to be sent with the create request.
    /// </summary>
    [JsonPropertyName("createHeaders")]
    public IDictionary<string, string>? CreateHeaders { get; set; }

    /// <summary>
    /// (Map of List of String) A mapping of query parameters to be sent with the create request.
    /// A mapping of query parameters to be sent with the create request.
    /// </summary>
    [JsonPropertyName("createQueryParameters")]
    public IDictionary<string, IList<string>>? CreateQueryParameters { get; set; }

    /// <summary>
    /// (Map of String) A mapping of headers to be sent with the delete request.
    /// A mapping of headers to be sent with the delete request.
    /// </summary>
    [JsonPropertyName("deleteHeaders")]
    public IDictionary<string, string>? DeleteHeaders { get; set; }

    /// <summary>
    /// (Map of List of String) A mapping of query parameters to be sent with the delete request.
    /// A mapping of query parameters to be sent with the delete request.
    /// </summary>
    [JsonPropertyName("deleteQueryParameters")]
    public IDictionary<string, IList<string>>? DeleteQueryParameters { get; set; }

    /// <summary>A identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ResourceSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>Whether ignore incorrect casing returned in body to suppress plan-diff. Defaults to false.</summary>
    [JsonPropertyName("ignoreCasing")]
    public bool? IgnoreCasing { get; set; }

    /// <summary>Whether ignore not returned properties like credentials in body to suppress plan-diff. Defaults to true.</summary>
    [JsonPropertyName("ignoreMissingProperty")]
    public bool? IgnoreMissingProperty { get; set; }

    /// <summary>
    /// (Boolean) When set to true, the provider will ignore properties whose values are null in the body.
    /// These properties will not be included in the request body sent to the API, and the difference will not be shown in the plan output. Defaults to false.
    /// When set to `true`, the provider will ignore properties whose values are `null` in the `body`.
    /// These properties will not be included in the request body sent to the API, and the difference will not be shown in the plan output. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("ignoreNullProperty")]
    public bool? IgnoreNullProperty { get; set; }

    /// <summary>A list of list property paths where items not specified in configuration should be ignored. This is intended for partial list management when combined with `list_unique_id_property` (for example, to avoid perpetual drift from server-side ordering).</summary>
    [JsonPropertyName("ignoreOtherItemsInList")]
    public IList<string>? IgnoreOtherItemsInList { get; set; }

    /// <summary>A mapping of list property paths to the field name used as a unique identifier when comparing and merging list items. When not set, list items are matched by a `name` property (if present) or by list ordering. To match using multiple fields, specify a comma-separated list of field names (e.g., `&quot;category, categoryGroup&quot;`).</summary>
    [JsonPropertyName("listUniqueIdProperty")]
    public IDictionary<string, string>? ListUniqueIdProperty { get; set; }

    /// <summary>The Azure Region where the azure resource should exist.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of ARM resource IDs which are used to avoid create/modify/delete azapi resources at the same time.</summary>
    [JsonPropertyName("locks")]
    public IList<string>? Locks { get; set; }

    /// <summary>Specifies the name of the azure resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the azure resource in which this resource is created. Changing this forces a new resource to be created. It supports different kinds of deployment scope for top level resources:</summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <summary>
    /// (Map of String) A mapping of headers to be sent with the read request.
    /// A mapping of headers to be sent with the read request.
    /// </summary>
    [JsonPropertyName("readHeaders")]
    public IDictionary<string, string>? ReadHeaders { get; set; }

    /// <summary>
    /// (Map of List of String) A mapping of query parameters to be sent with the read request.
    /// A mapping of query parameters to be sent with the read request.
    /// </summary>
    [JsonPropertyName("readQueryParameters")]
    public IDictionary<string, IList<string>>? ReadQueryParameters { get; set; }

    /// <summary>
    /// A list of path that needs to be exported from response body.
    /// Setting it to [&quot;*&quot;] will export the full response body.
    /// Here&apos;s an example. If it sets to [&quot;properties.loginServer&quot;, &quot;properties.policies.quarantinePolicy.status&quot;], it will set the following json to computed property output.
    /// </summary>
    [JsonPropertyName("responseExportValues")]
    public IList<string>? ResponseExportValues { get; set; }

    /// <summary>(Attributes) The retry object supports the following attributes: (see below for nested schema)</summary>
    [JsonPropertyName("retry")]
    public V1beta1ResourceSpecForProviderRetry? Retry { get; set; }

    /// <summary>Whether enabled the validation on type and body with embedded schema. Defaults to true.</summary>
    [JsonPropertyName("schemaValidationEnabled")]
    public bool? SchemaValidationEnabled { get; set; }

    /// <summary>
    /// only properties of the request body. This will be merge-patched to the body to construct the actual request body.
    /// A dynamic attribute that contains the write-only properties of the request body. This will be merge-patched to the body to construct the actual request body.
    /// </summary>
    [JsonPropertyName("sensitiveBody")]
    public JsonNode? SensitiveBody { get; set; }

    /// <summary>
    /// (Map of String) A map where the key is the path to the property in sensitive_body and the value is the version of the property. The key is a string in the format of path.to.property[index].subproperty, where index is the index of the item in an array. When the version is changed, the property will be included in the request body, otherwise it will be omitted from the request body.
    /// A map where the key is the path to the property in `sensitive_body` and the value is the version of the property. The key is a string in the format of `path.to.property[index].subproperty`, where `index` is the index of the item in an array. When the version is changed, the property will be included in the request body, otherwise it will be omitted from the request body.
    /// </summary>
    [JsonPropertyName("sensitiveBodyVersion")]
    public IDictionary<string, string>? SensitiveBodyVersion { get; set; }

    /// <summary>A mapping of tags which should be assigned to the azure resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// It is in a format like &lt;resource-type&gt;@&lt;api-version&gt;. &lt;resource-type&gt; is the Azure resource type, for example, Microsoft.Storage/storageAccounts.
    /// &lt;api-version&gt; is version of the API used to manage this azure resource.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// (Map of String) A mapping of headers to be sent with the update request.
    /// A mapping of headers to be sent with the update request.
    /// </summary>
    [JsonPropertyName("updateHeaders")]
    public IDictionary<string, string>? UpdateHeaders { get; set; }

    /// <summary>
    /// (Map of List of String) A mapping of query parameters to be sent with the update request.
    /// A mapping of query parameters to be sent with the update request.
    /// </summary>
    [JsonPropertyName("updateQueryParameters")]
    public IDictionary<string, IList<string>>? UpdateQueryParameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceSpecInitProviderIdentity
{
    /// <summary>A list of User Managed Identity ID&apos;s which should be assigned to the azure resource.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Type of Identity which should be used for this azure resource. Possible values are SystemAssigned, UserAssigned and SystemAssigned,UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>(Attributes) The retry object supports the following attributes: (see below for nested schema)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceSpecInitProviderRetry
{
    /// <summary>
    /// (List of String) A list of regular expressions to match against error messages. If any of the regular expressions match, the request will be retried.
    /// A list of regular expressions to match against error messages. If any of the regular expressions match, the request will be retried.
    /// </summary>
    [JsonPropertyName("errorMessageRegex")]
    public IList<string>? ErrorMessageRegex { get; set; }

    /// <summary>
    /// (Number) The base number of seconds to wait between retries. Default is 10.
    /// The base number of seconds to wait between retries. Default is `10`.
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// (Number) The maximum number of seconds to wait between retries. Default is 180.
    /// The maximum number of seconds to wait between retries. Default is `180`.
    /// </summary>
    [JsonPropertyName("maxIntervalSeconds")]
    public double? MaxIntervalSeconds { get; set; }

    /// <summary>
    /// (Number, Deprecated) The multiplier to apply to the interval between retries. Default is 1.5.
    /// The multiplier to apply to the interval between retries. Default is `1.5`.
    /// </summary>
    [JsonPropertyName("multiplier")]
    public double? Multiplier { get; set; }

    /// <summary>
    /// RandomizationFactor, 1 + RandomizationFactor]). Therefore set to zero 0.0 for no randomization. Default is 0.5.
    /// The randomization factor to apply to the interval between retries. The formula for the randomized interval is: `RetryInterval * (random value in range [1 - RandomizationFactor, 1 + RandomizationFactor])`. Therefore set to zero `0.0` for no randomization. Default is `0.5`.
    /// </summary>
    [JsonPropertyName("randomizationFactor")]
    public double? RandomizationFactor { get; set; }
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceSpecInitProvider
{
    /// <summary>A JSON object that contains the request body used to create and update azure resource.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// (Map of String) A mapping of headers to be sent with the create request.
    /// A mapping of headers to be sent with the create request.
    /// </summary>
    [JsonPropertyName("createHeaders")]
    public IDictionary<string, string>? CreateHeaders { get; set; }

    /// <summary>
    /// (Map of List of String) A mapping of query parameters to be sent with the create request.
    /// A mapping of query parameters to be sent with the create request.
    /// </summary>
    [JsonPropertyName("createQueryParameters")]
    public IDictionary<string, IList<string>>? CreateQueryParameters { get; set; }

    /// <summary>
    /// (Map of String) A mapping of headers to be sent with the delete request.
    /// A mapping of headers to be sent with the delete request.
    /// </summary>
    [JsonPropertyName("deleteHeaders")]
    public IDictionary<string, string>? DeleteHeaders { get; set; }

    /// <summary>
    /// (Map of List of String) A mapping of query parameters to be sent with the delete request.
    /// A mapping of query parameters to be sent with the delete request.
    /// </summary>
    [JsonPropertyName("deleteQueryParameters")]
    public IDictionary<string, IList<string>>? DeleteQueryParameters { get; set; }

    /// <summary>A identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ResourceSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>Whether ignore incorrect casing returned in body to suppress plan-diff. Defaults to false.</summary>
    [JsonPropertyName("ignoreCasing")]
    public bool? IgnoreCasing { get; set; }

    /// <summary>Whether ignore not returned properties like credentials in body to suppress plan-diff. Defaults to true.</summary>
    [JsonPropertyName("ignoreMissingProperty")]
    public bool? IgnoreMissingProperty { get; set; }

    /// <summary>
    /// (Boolean) When set to true, the provider will ignore properties whose values are null in the body.
    /// These properties will not be included in the request body sent to the API, and the difference will not be shown in the plan output. Defaults to false.
    /// When set to `true`, the provider will ignore properties whose values are `null` in the `body`.
    /// These properties will not be included in the request body sent to the API, and the difference will not be shown in the plan output. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("ignoreNullProperty")]
    public bool? IgnoreNullProperty { get; set; }

    /// <summary>A list of list property paths where items not specified in configuration should be ignored. This is intended for partial list management when combined with `list_unique_id_property` (for example, to avoid perpetual drift from server-side ordering).</summary>
    [JsonPropertyName("ignoreOtherItemsInList")]
    public IList<string>? IgnoreOtherItemsInList { get; set; }

    /// <summary>A mapping of list property paths to the field name used as a unique identifier when comparing and merging list items. When not set, list items are matched by a `name` property (if present) or by list ordering. To match using multiple fields, specify a comma-separated list of field names (e.g., `&quot;category, categoryGroup&quot;`).</summary>
    [JsonPropertyName("listUniqueIdProperty")]
    public IDictionary<string, string>? ListUniqueIdProperty { get; set; }

    /// <summary>The Azure Region where the azure resource should exist.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of ARM resource IDs which are used to avoid create/modify/delete azapi resources at the same time.</summary>
    [JsonPropertyName("locks")]
    public IList<string>? Locks { get; set; }

    /// <summary>Specifies the name of the azure resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the azure resource in which this resource is created. Changing this forces a new resource to be created. It supports different kinds of deployment scope for top level resources:</summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <summary>
    /// (Map of String) A mapping of headers to be sent with the read request.
    /// A mapping of headers to be sent with the read request.
    /// </summary>
    [JsonPropertyName("readHeaders")]
    public IDictionary<string, string>? ReadHeaders { get; set; }

    /// <summary>
    /// (Map of List of String) A mapping of query parameters to be sent with the read request.
    /// A mapping of query parameters to be sent with the read request.
    /// </summary>
    [JsonPropertyName("readQueryParameters")]
    public IDictionary<string, IList<string>>? ReadQueryParameters { get; set; }

    /// <summary>
    /// A list of path that needs to be exported from response body.
    /// Setting it to [&quot;*&quot;] will export the full response body.
    /// Here&apos;s an example. If it sets to [&quot;properties.loginServer&quot;, &quot;properties.policies.quarantinePolicy.status&quot;], it will set the following json to computed property output.
    /// </summary>
    [JsonPropertyName("responseExportValues")]
    public IList<string>? ResponseExportValues { get; set; }

    /// <summary>(Attributes) The retry object supports the following attributes: (see below for nested schema)</summary>
    [JsonPropertyName("retry")]
    public V1beta1ResourceSpecInitProviderRetry? Retry { get; set; }

    /// <summary>Whether enabled the validation on type and body with embedded schema. Defaults to true.</summary>
    [JsonPropertyName("schemaValidationEnabled")]
    public bool? SchemaValidationEnabled { get; set; }

    /// <summary>
    /// only properties of the request body. This will be merge-patched to the body to construct the actual request body.
    /// A dynamic attribute that contains the write-only properties of the request body. This will be merge-patched to the body to construct the actual request body.
    /// </summary>
    [JsonPropertyName("sensitiveBody")]
    public JsonNode? SensitiveBody { get; set; }

    /// <summary>
    /// (Map of String) A map where the key is the path to the property in sensitive_body and the value is the version of the property. The key is a string in the format of path.to.property[index].subproperty, where index is the index of the item in an array. When the version is changed, the property will be included in the request body, otherwise it will be omitted from the request body.
    /// A map where the key is the path to the property in `sensitive_body` and the value is the version of the property. The key is a string in the format of `path.to.property[index].subproperty`, where `index` is the index of the item in an array. When the version is changed, the property will be included in the request body, otherwise it will be omitted from the request body.
    /// </summary>
    [JsonPropertyName("sensitiveBodyVersion")]
    public IDictionary<string, string>? SensitiveBodyVersion { get; set; }

    /// <summary>A mapping of tags which should be assigned to the azure resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// It is in a format like &lt;resource-type&gt;@&lt;api-version&gt;. &lt;resource-type&gt; is the Azure resource type, for example, Microsoft.Storage/storageAccounts.
    /// &lt;api-version&gt; is version of the API used to manage this azure resource.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// (Map of String) A mapping of headers to be sent with the update request.
    /// A mapping of headers to be sent with the update request.
    /// </summary>
    [JsonPropertyName("updateHeaders")]
    public IDictionary<string, string>? UpdateHeaders { get; set; }

    /// <summary>
    /// (Map of List of String) A mapping of query parameters to be sent with the update request.
    /// A mapping of query parameters to be sent with the update request.
    /// </summary>
    [JsonPropertyName("updateQueryParameters")]
    public IDictionary<string, IList<string>>? UpdateQueryParameters { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public enum V1beta1ResourceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public enum V1beta1ResourceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public enum V1beta1ResourceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ResourceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ResourceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ResourceSpec defines the desired state of Resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceSpec
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
    public V1beta1ResourceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1ResourceSpecForProvider ForProvider { get; set; }

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
    public V1beta1ResourceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1ResourceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ResourceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ResourceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceStatusAtProviderIdentity
{
    /// <summary>A list of User Managed Identity ID&apos;s which should be assigned to the azure resource.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID for the Service Principal associated with the Managed Service Identity of this azure resource.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID for the Service Principal associated with the Managed Service Identity of this azure resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The Type of Identity which should be used for this azure resource. Possible values are SystemAssigned, UserAssigned and SystemAssigned,UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>(Attributes) The retry object supports the following attributes: (see below for nested schema)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceStatusAtProviderRetry
{
    /// <summary>
    /// (List of String) A list of regular expressions to match against error messages. If any of the regular expressions match, the request will be retried.
    /// A list of regular expressions to match against error messages. If any of the regular expressions match, the request will be retried.
    /// </summary>
    [JsonPropertyName("errorMessageRegex")]
    public IList<string>? ErrorMessageRegex { get; set; }

    /// <summary>
    /// (Number) The base number of seconds to wait between retries. Default is 10.
    /// The base number of seconds to wait between retries. Default is `10`.
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// (Number) The maximum number of seconds to wait between retries. Default is 180.
    /// The maximum number of seconds to wait between retries. Default is `180`.
    /// </summary>
    [JsonPropertyName("maxIntervalSeconds")]
    public double? MaxIntervalSeconds { get; set; }

    /// <summary>
    /// (Number, Deprecated) The multiplier to apply to the interval between retries. Default is 1.5.
    /// The multiplier to apply to the interval between retries. Default is `1.5`.
    /// </summary>
    [JsonPropertyName("multiplier")]
    public double? Multiplier { get; set; }

    /// <summary>
    /// RandomizationFactor, 1 + RandomizationFactor]). Therefore set to zero 0.0 for no randomization. Default is 0.5.
    /// The randomization factor to apply to the interval between retries. The formula for the randomized interval is: `RetryInterval * (random value in range [1 - RandomizationFactor, 1 + RandomizationFactor])`. Therefore set to zero `0.0` for no randomization. Default is `0.5`.
    /// </summary>
    [JsonPropertyName("randomizationFactor")]
    public double? RandomizationFactor { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceStatusAtProvider
{
    /// <summary>A JSON object that contains the request body used to create and update azure resource.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// (Map of String) A mapping of headers to be sent with the create request.
    /// A mapping of headers to be sent with the create request.
    /// </summary>
    [JsonPropertyName("createHeaders")]
    public IDictionary<string, string>? CreateHeaders { get; set; }

    /// <summary>
    /// (Map of List of String) A mapping of query parameters to be sent with the create request.
    /// A mapping of query parameters to be sent with the create request.
    /// </summary>
    [JsonPropertyName("createQueryParameters")]
    public IDictionary<string, IList<string>>? CreateQueryParameters { get; set; }

    /// <summary>
    /// (Map of String) A mapping of headers to be sent with the delete request.
    /// A mapping of headers to be sent with the delete request.
    /// </summary>
    [JsonPropertyName("deleteHeaders")]
    public IDictionary<string, string>? DeleteHeaders { get; set; }

    /// <summary>
    /// (Map of List of String) A mapping of query parameters to be sent with the delete request.
    /// A mapping of query parameters to be sent with the delete request.
    /// </summary>
    [JsonPropertyName("deleteQueryParameters")]
    public IDictionary<string, IList<string>>? DeleteQueryParameters { get; set; }

    /// <summary>The ID of the azure resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ResourceStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>Whether ignore incorrect casing returned in body to suppress plan-diff. Defaults to false.</summary>
    [JsonPropertyName("ignoreCasing")]
    public bool? IgnoreCasing { get; set; }

    /// <summary>Whether ignore not returned properties like credentials in body to suppress plan-diff. Defaults to true.</summary>
    [JsonPropertyName("ignoreMissingProperty")]
    public bool? IgnoreMissingProperty { get; set; }

    /// <summary>
    /// (Boolean) When set to true, the provider will ignore properties whose values are null in the body.
    /// These properties will not be included in the request body sent to the API, and the difference will not be shown in the plan output. Defaults to false.
    /// When set to `true`, the provider will ignore properties whose values are `null` in the `body`.
    /// These properties will not be included in the request body sent to the API, and the difference will not be shown in the plan output. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("ignoreNullProperty")]
    public bool? IgnoreNullProperty { get; set; }

    /// <summary>A list of list property paths where items not specified in configuration should be ignored. This is intended for partial list management when combined with `list_unique_id_property` (for example, to avoid perpetual drift from server-side ordering).</summary>
    [JsonPropertyName("ignoreOtherItemsInList")]
    public IList<string>? IgnoreOtherItemsInList { get; set; }

    /// <summary>A mapping of list property paths to the field name used as a unique identifier when comparing and merging list items. When not set, list items are matched by a `name` property (if present) or by list ordering. To match using multiple fields, specify a comma-separated list of field names (e.g., `&quot;category, categoryGroup&quot;`).</summary>
    [JsonPropertyName("listUniqueIdProperty")]
    public IDictionary<string, string>? ListUniqueIdProperty { get; set; }

    /// <summary>The Azure Region where the azure resource should exist.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of ARM resource IDs which are used to avoid create/modify/delete azapi resources at the same time.</summary>
    [JsonPropertyName("locks")]
    public IList<string>? Locks { get; set; }

    /// <summary>Specifies the name of the azure resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The output json containing the properties specified in response_export_values. Here&apos;re some examples to decode json and extract the value.</summary>
    [JsonPropertyName("output")]
    public string? Output { get; set; }

    /// <summary>The ID of the azure resource in which this resource is created. Changing this forces a new resource to be created. It supports different kinds of deployment scope for top level resources:</summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <summary>
    /// (Map of String) A mapping of headers to be sent with the read request.
    /// A mapping of headers to be sent with the read request.
    /// </summary>
    [JsonPropertyName("readHeaders")]
    public IDictionary<string, string>? ReadHeaders { get; set; }

    /// <summary>
    /// (Map of List of String) A mapping of query parameters to be sent with the read request.
    /// A mapping of query parameters to be sent with the read request.
    /// </summary>
    [JsonPropertyName("readQueryParameters")]
    public IDictionary<string, IList<string>>? ReadQueryParameters { get; set; }

    /// <summary>
    /// A list of path that needs to be exported from response body.
    /// Setting it to [&quot;*&quot;] will export the full response body.
    /// Here&apos;s an example. If it sets to [&quot;properties.loginServer&quot;, &quot;properties.policies.quarantinePolicy.status&quot;], it will set the following json to computed property output.
    /// </summary>
    [JsonPropertyName("responseExportValues")]
    public IList<string>? ResponseExportValues { get; set; }

    /// <summary>(Attributes) The retry object supports the following attributes: (see below for nested schema)</summary>
    [JsonPropertyName("retry")]
    public V1beta1ResourceStatusAtProviderRetry? Retry { get; set; }

    /// <summary>Whether enabled the validation on type and body with embedded schema. Defaults to true.</summary>
    [JsonPropertyName("schemaValidationEnabled")]
    public bool? SchemaValidationEnabled { get; set; }

    /// <summary>
    /// only properties of the request body. This will be merge-patched to the body to construct the actual request body.
    /// A dynamic attribute that contains the write-only properties of the request body. This will be merge-patched to the body to construct the actual request body.
    /// </summary>
    [JsonPropertyName("sensitiveBody")]
    public JsonNode? SensitiveBody { get; set; }

    /// <summary>
    /// (Map of String) A map where the key is the path to the property in sensitive_body and the value is the version of the property. The key is a string in the format of path.to.property[index].subproperty, where index is the index of the item in an array. When the version is changed, the property will be included in the request body, otherwise it will be omitted from the request body.
    /// A map where the key is the path to the property in `sensitive_body` and the value is the version of the property. The key is a string in the format of `path.to.property[index].subproperty`, where `index` is the index of the item in an array. When the version is changed, the property will be included in the request body, otherwise it will be omitted from the request body.
    /// </summary>
    [JsonPropertyName("sensitiveBodyVersion")]
    public IDictionary<string, string>? SensitiveBodyVersion { get; set; }

    /// <summary>A mapping of tags which should be assigned to the azure resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// It is in a format like &lt;resource-type&gt;@&lt;api-version&gt;. &lt;resource-type&gt; is the Azure resource type, for example, Microsoft.Storage/storageAccounts.
    /// &lt;api-version&gt; is version of the API used to manage this azure resource.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// (Map of String) A mapping of headers to be sent with the update request.
    /// A mapping of headers to be sent with the update request.
    /// </summary>
    [JsonPropertyName("updateHeaders")]
    public IDictionary<string, string>? UpdateHeaders { get; set; }

    /// <summary>
    /// (Map of List of String) A mapping of query parameters to be sent with the update request.
    /// A mapping of query parameters to be sent with the update request.
    /// </summary>
    [JsonPropertyName("updateQueryParameters")]
    public IDictionary<string, IList<string>>? UpdateQueryParameters { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceStatusConditions
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

/// <summary>ResourceStatus defines the observed state of Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ResourceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ResourceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// Resource is the Schema for the Resources API. Manages a Azure resource
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.1.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Resource : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ResourceSpec>, IStatus<V1beta1ResourceStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Resource";
    public const string KubeGroup = "resources.azapi.upbound.io";
    public const string KubePluralName = "resources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "resources.azapi.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Resource";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourceSpec defines the desired state of Resource</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ResourceSpec Spec { get; set; }

    /// <summary>ResourceStatus defines the observed state of Resource.</summary>
    [JsonPropertyName("status")]
    public V1beta1ResourceStatus? Status { get; set; }
}