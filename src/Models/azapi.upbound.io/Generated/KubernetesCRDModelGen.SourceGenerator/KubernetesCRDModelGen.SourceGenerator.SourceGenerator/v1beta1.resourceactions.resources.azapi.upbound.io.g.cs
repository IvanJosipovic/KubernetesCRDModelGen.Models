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
/// ResourceAction is the Schema for the ResourceActions API. Perform resource action which changes an existing resource&apos;s state
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.1.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResourceActionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ResourceAction>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourceActionList";
    public const string KubeGroup = "resources.azapi.upbound.io";
    public const string KubePluralName = "resourceactions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "resources.azapi.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceActionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ResourceAction objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ResourceAction> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceActionSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public enum V1beta1ResourceActionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>(Attributes) The retry object supports the following attributes: (see below for nested schema)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceActionSpecForProviderRetry
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
public partial class V1beta1ResourceActionSpecForProvider
{
    /// <summary>The name of the resource action. It&apos;s also possible to make Http requests towards the resource ID if leave this field empty.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A JSON object that contains the request body.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// (Map of String) A map of headers to include in the request
    /// A map of headers to include in the request
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>If set to `true`, the resource action will ignore `Not Found` errors returned from the Azure API. Default is `false`.</summary>
    [JsonPropertyName("ignoreNotFound")]
    public bool? IgnoreNotFound { get; set; }

    /// <summary>A list of ARM resource IDs which are used to avoid modify azapi resources at the same time.</summary>
    [JsonPropertyName("locks")]
    public IList<string>? Locks { get; set; }

    /// <summary>Specifies the Http method of the azure resource action. Allowed values are POST, PATCH, PUT and DELETE. Defaults to POST.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// (Map of List of String) A map of query parameters to include in the request
    /// A map of query parameters to include in the request
    /// </summary>
    [JsonPropertyName("queryParameters")]
    public IDictionary<string, IList<string>>? QueryParameters { get; set; }

    /// <summary>The ID of an existing azure source.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>
    /// A list of path that needs to be exported from response body.
    /// Setting it to [&quot;*&quot;] will export the full response body.
    /// Here&apos;s an example. If it sets to [&quot;keys&quot;], it will set the following json to computed property output.
    /// </summary>
    [JsonPropertyName("responseExportValues")]
    public IList<string>? ResponseExportValues { get; set; }

    /// <summary>(Attributes) The retry object supports the following attributes: (see below for nested schema)</summary>
    [JsonPropertyName("retry")]
    public V1beta1ResourceActionSpecForProviderRetry? Retry { get; set; }

    /// <summary>
    /// (Dynamic) The attribute can accept either a list or a map.
    /// The attribute can accept either a list or a map.
    /// 
    /// - **List**: A list of paths that need to be exported from the response body. Setting it to `[&quot;*&quot;]` will export the full response body. Here&apos;s an example. If it sets to `[&quot;properties.loginServer&quot;, &quot;properties.policies.quarantinePolicy.status&quot;]`, it will set the following HCL object to the computed property output.
    /// 
    /// ```text
    /// {
    /// properties = {
    /// loginServer = &quot;registry1.azurecr.io&quot;
    /// policies = {
    /// quarantinePolicy = {
    /// status = &quot;disabled&quot;
    /// }
    /// }
    /// }
    /// }
    /// ```
    /// 
    /// - **Map**: A map where the key is the name for the result and the value is a JMESPath query string to filter the response. Here&apos;s an example. If it sets to `{&quot;login_server&quot;: &quot;properties.loginServer&quot;, &quot;quarantine_status&quot;: &quot;properties.policies.quarantinePolicy.status&quot;}`, it will set the following HCL object to the computed property output.
    /// 
    /// ```text
    /// {
    /// &quot;login_server&quot; = &quot;registry1.azurecr.io&quot;
    /// &quot;quarantine_status&quot; = &quot;disabled&quot;
    /// }
    /// ```
    /// 
    /// To learn more about JMESPath, visit [JMESPath](https://jmespath.org/).
    /// </summary>
    [JsonPropertyName("sensitiveResponseExportValues")]
    public JsonNode? SensitiveResponseExportValues { get; set; }

    /// <summary>
    /// It is in a format like &lt;resource-type&gt;@&lt;api-version&gt;. &lt;resource-type&gt; is the Azure resource type, for example, Microsoft.Storage/storageAccounts.
    /// &lt;api-version&gt; is version of the API used to manage this azure resource.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// When to perform the action, value must be one of: apply, destroy. Default is apply.
    /// When to perform the action, value must be one of: &apos;apply&apos;, &apos;destroy&apos;. Default is &apos;apply&apos;.
    /// </summary>
    [JsonPropertyName("when")]
    public string? When { get; set; }
}

/// <summary>(Attributes) The retry object supports the following attributes: (see below for nested schema)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceActionSpecInitProviderRetry
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
public partial class V1beta1ResourceActionSpecInitProvider
{
    /// <summary>The name of the resource action. It&apos;s also possible to make Http requests towards the resource ID if leave this field empty.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A JSON object that contains the request body.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// (Map of String) A map of headers to include in the request
    /// A map of headers to include in the request
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>If set to `true`, the resource action will ignore `Not Found` errors returned from the Azure API. Default is `false`.</summary>
    [JsonPropertyName("ignoreNotFound")]
    public bool? IgnoreNotFound { get; set; }

    /// <summary>A list of ARM resource IDs which are used to avoid modify azapi resources at the same time.</summary>
    [JsonPropertyName("locks")]
    public IList<string>? Locks { get; set; }

    /// <summary>Specifies the Http method of the azure resource action. Allowed values are POST, PATCH, PUT and DELETE. Defaults to POST.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// (Map of List of String) A map of query parameters to include in the request
    /// A map of query parameters to include in the request
    /// </summary>
    [JsonPropertyName("queryParameters")]
    public IDictionary<string, IList<string>>? QueryParameters { get; set; }

    /// <summary>The ID of an existing azure source.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>
    /// A list of path that needs to be exported from response body.
    /// Setting it to [&quot;*&quot;] will export the full response body.
    /// Here&apos;s an example. If it sets to [&quot;keys&quot;], it will set the following json to computed property output.
    /// </summary>
    [JsonPropertyName("responseExportValues")]
    public IList<string>? ResponseExportValues { get; set; }

    /// <summary>(Attributes) The retry object supports the following attributes: (see below for nested schema)</summary>
    [JsonPropertyName("retry")]
    public V1beta1ResourceActionSpecInitProviderRetry? Retry { get; set; }

    /// <summary>
    /// (Dynamic) The attribute can accept either a list or a map.
    /// The attribute can accept either a list or a map.
    /// 
    /// - **List**: A list of paths that need to be exported from the response body. Setting it to `[&quot;*&quot;]` will export the full response body. Here&apos;s an example. If it sets to `[&quot;properties.loginServer&quot;, &quot;properties.policies.quarantinePolicy.status&quot;]`, it will set the following HCL object to the computed property output.
    /// 
    /// ```text
    /// {
    /// properties = {
    /// loginServer = &quot;registry1.azurecr.io&quot;
    /// policies = {
    /// quarantinePolicy = {
    /// status = &quot;disabled&quot;
    /// }
    /// }
    /// }
    /// }
    /// ```
    /// 
    /// - **Map**: A map where the key is the name for the result and the value is a JMESPath query string to filter the response. Here&apos;s an example. If it sets to `{&quot;login_server&quot;: &quot;properties.loginServer&quot;, &quot;quarantine_status&quot;: &quot;properties.policies.quarantinePolicy.status&quot;}`, it will set the following HCL object to the computed property output.
    /// 
    /// ```text
    /// {
    /// &quot;login_server&quot; = &quot;registry1.azurecr.io&quot;
    /// &quot;quarantine_status&quot; = &quot;disabled&quot;
    /// }
    /// ```
    /// 
    /// To learn more about JMESPath, visit [JMESPath](https://jmespath.org/).
    /// </summary>
    [JsonPropertyName("sensitiveResponseExportValues")]
    public JsonNode? SensitiveResponseExportValues { get; set; }

    /// <summary>
    /// It is in a format like &lt;resource-type&gt;@&lt;api-version&gt;. &lt;resource-type&gt; is the Azure resource type, for example, Microsoft.Storage/storageAccounts.
    /// &lt;api-version&gt; is version of the API used to manage this azure resource.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// When to perform the action, value must be one of: apply, destroy. Default is apply.
    /// When to perform the action, value must be one of: &apos;apply&apos;, &apos;destroy&apos;. Default is &apos;apply&apos;.
    /// </summary>
    [JsonPropertyName("when")]
    public string? When { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceActionSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public enum V1beta1ResourceActionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceActionSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public enum V1beta1ResourceActionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceActionSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public enum V1beta1ResourceActionSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1ResourceActionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ResourceActionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ResourceActionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceActionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceActionSpecProviderConfigRefPolicy? Policy { get; set; }
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
public partial class V1beta1ResourceActionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ResourceActionSpec defines the desired state of ResourceAction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceActionSpec
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
    public V1beta1ResourceActionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1ResourceActionSpecForProvider ForProvider { get; set; }

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
    public V1beta1ResourceActionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1ResourceActionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ResourceActionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ResourceActionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>(Attributes) The retry object supports the following attributes: (see below for nested schema)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceActionStatusAtProviderRetry
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
public partial class V1beta1ResourceActionStatusAtProvider
{
    /// <summary>The name of the resource action. It&apos;s also possible to make Http requests towards the resource ID if leave this field empty.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A JSON object that contains the request body.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Indicates whether the resource action was successfully performed.</summary>
    [JsonPropertyName("exist")]
    public bool? Exist { get; set; }

    /// <summary>
    /// (Map of String) A map of headers to include in the request
    /// A map of headers to include in the request
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>The ID of the azure resource action.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>If set to `true`, the resource action will ignore `Not Found` errors returned from the Azure API. Default is `false`.</summary>
    [JsonPropertyName("ignoreNotFound")]
    public bool? IgnoreNotFound { get; set; }

    /// <summary>A list of ARM resource IDs which are used to avoid modify azapi resources at the same time.</summary>
    [JsonPropertyName("locks")]
    public IList<string>? Locks { get; set; }

    /// <summary>Specifies the Http method of the azure resource action. Allowed values are POST, PATCH, PUT and DELETE. Defaults to POST.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>The output json containing the properties specified in response_export_values. Here are some examples to decode json and extract the value.</summary>
    [JsonPropertyName("output")]
    public string? Output { get; set; }

    /// <summary>
    /// (Map of List of String) A map of query parameters to include in the request
    /// A map of query parameters to include in the request
    /// </summary>
    [JsonPropertyName("queryParameters")]
    public IDictionary<string, IList<string>>? QueryParameters { get; set; }

    /// <summary>The ID of an existing azure source.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>
    /// A list of path that needs to be exported from response body.
    /// Setting it to [&quot;*&quot;] will export the full response body.
    /// Here&apos;s an example. If it sets to [&quot;keys&quot;], it will set the following json to computed property output.
    /// </summary>
    [JsonPropertyName("responseExportValues")]
    public IList<string>? ResponseExportValues { get; set; }

    /// <summary>(Attributes) The retry object supports the following attributes: (see below for nested schema)</summary>
    [JsonPropertyName("retry")]
    public V1beta1ResourceActionStatusAtProviderRetry? Retry { get; set; }

    /// <summary>
    /// (Dynamic) The attribute can accept either a list or a map.
    /// The attribute can accept either a list or a map.
    /// 
    /// - **List**: A list of paths that need to be exported from the response body. Setting it to `[&quot;*&quot;]` will export the full response body. Here&apos;s an example. If it sets to `[&quot;properties.loginServer&quot;, &quot;properties.policies.quarantinePolicy.status&quot;]`, it will set the following HCL object to the computed property output.
    /// 
    /// ```text
    /// {
    /// properties = {
    /// loginServer = &quot;registry1.azurecr.io&quot;
    /// policies = {
    /// quarantinePolicy = {
    /// status = &quot;disabled&quot;
    /// }
    /// }
    /// }
    /// }
    /// ```
    /// 
    /// - **Map**: A map where the key is the name for the result and the value is a JMESPath query string to filter the response. Here&apos;s an example. If it sets to `{&quot;login_server&quot;: &quot;properties.loginServer&quot;, &quot;quarantine_status&quot;: &quot;properties.policies.quarantinePolicy.status&quot;}`, it will set the following HCL object to the computed property output.
    /// 
    /// ```text
    /// {
    /// &quot;login_server&quot; = &quot;registry1.azurecr.io&quot;
    /// &quot;quarantine_status&quot; = &quot;disabled&quot;
    /// }
    /// ```
    /// 
    /// To learn more about JMESPath, visit [JMESPath](https://jmespath.org/).
    /// </summary>
    [JsonPropertyName("sensitiveResponseExportValues")]
    public JsonNode? SensitiveResponseExportValues { get; set; }

    /// <summary>
    /// It is in a format like &lt;resource-type&gt;@&lt;api-version&gt;. &lt;resource-type&gt; is the Azure resource type, for example, Microsoft.Storage/storageAccounts.
    /// &lt;api-version&gt; is version of the API used to manage this azure resource.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// When to perform the action, value must be one of: apply, destroy. Default is apply.
    /// When to perform the action, value must be one of: &apos;apply&apos;, &apos;destroy&apos;. Default is &apos;apply&apos;.
    /// </summary>
    [JsonPropertyName("when")]
    public string? When { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceActionStatusConditions
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

/// <summary>ResourceActionStatus defines the observed state of ResourceAction.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
public partial class V1beta1ResourceActionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ResourceActionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ResourceActionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// ResourceAction is the Schema for the ResourceActions API. Perform resource action which changes an existing resource&apos;s state
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.1.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.1.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResourceAction : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ResourceActionSpec>, IStatus<V1beta1ResourceActionStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourceAction";
    public const string KubeGroup = "resources.azapi.upbound.io";
    public const string KubePluralName = "resourceactions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "resources.azapi.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceAction";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourceActionSpec defines the desired state of ResourceAction</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ResourceActionSpec Spec { get; set; }

    /// <summary>ResourceActionStatus defines the observed state of ResourceAction.</summary>
    [JsonPropertyName("status")]
    public V1beta1ResourceActionStatus? Status { get; set; }
}