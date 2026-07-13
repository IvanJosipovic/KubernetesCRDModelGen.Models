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
/// <summary>ResourceAction is the Schema for the ResourceActions API. This resource allows you to perform an action on an existing Azure resource.g., starting or stopping an Azure Virtual Machine.	Please note that when deleting this resource, no action will be performed on the Azure resource unless the when argument is set to destroy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ResourceActionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ResourceAction>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ResourceActionList";
    public const string KubeGroup = "resources.azapi.upbound.io";
    public const string KubePluralName = "resourceactions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "resources.azapi.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceActionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ResourceAction objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ResourceAction> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceActionSpecDeletionPolicyEnum>))]
public enum V1beta2ResourceActionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceActionSpecForProviderRetry
{
    /// <summary>A list of regular expressions to match against error messages. If any of the regular expressions match, the request will be retried.</summary>
    [JsonPropertyName("errorMessageRegex")]
    public IList<string>? ErrorMessageRegex { get; set; }

    /// <summary>The base number of seconds to wait between retries. Default is `10`.</summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>The maximum number of seconds to wait between retries. Default is `180`.</summary>
    [JsonPropertyName("maxIntervalSeconds")]
    public double? MaxIntervalSeconds { get; set; }

    /// <summary>The multiplier to apply to the interval between retries. Default is `1.5`.</summary>
    [JsonPropertyName("multiplier")]
    public double? Multiplier { get; set; }

    /// <summary>The randomization factor to apply to the interval between retries. The formula for the randomized interval is: `RetryInterval * (random value in range [1 - RandomizationFactor, 1 + RandomizationFactor])`. Therefore set to zero `0.0` for no randomization. Default is `0.5`.</summary>
    [JsonPropertyName("randomizationFactor")]
    public double? RandomizationFactor { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceActionSpecForProvider
{
    /// <summary>The name of the resource action. It&apos;s also possible to make HTTP requests towards the resource ID if leave this field empty.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A dynamic attribute that contains the request body.</summary>
    [JsonPropertyName("body")]
    public JsonNode? Body { get; set; }

    /// <summary>A map of headers to include in the request</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>If set to `true`, the resource action will ignore `Not Found` errors returned from the Azure API. Default is `false`.</summary>
    [JsonPropertyName("ignoreNotFound")]
    public bool? IgnoreNotFound { get; set; }

    /// <summary>A list of ARM resource IDs which are used to avoid create/modify/delete azapi resources at the same time.</summary>
    [JsonPropertyName("locks")]
    public IList<string>? Locks { get; set; }

    /// <summary>Specifies the HTTP method of the azure resource action. Allowed values are `POST`, `PATCH`, `PUT` and `DELETE`. Defaults to `POST`.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>A map of query parameters to include in the request</summary>
    [JsonPropertyName("queryParameters")]
    public IDictionary<string, IList<string>>? QueryParameters { get; set; }

    /// <summary>The ID of an existing Azure source.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>
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
    [JsonPropertyName("responseExportValues")]
    public JsonNode? ResponseExportValues { get; set; }

    [JsonPropertyName("retry")]
    public V1beta2ResourceActionSpecForProviderRetry? Retry { get; set; }

    /// <summary>
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

    /// <summary>In a format like `&lt;resource-type&gt;@&lt;api-version&gt;`. `&lt;resource-type&gt;` is the Azure resource type, for example, `Microsoft.Storage/storageAccounts`. `&lt;api-version&gt;` is version of the API used to manage this azure resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>When to perform the action, value must be one of: `apply`, `destroy`. Default is `apply`.</summary>
    [JsonPropertyName("when")]
    public string? When { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceActionSpecInitProviderRetry
{
    /// <summary>A list of regular expressions to match against error messages. If any of the regular expressions match, the request will be retried.</summary>
    [JsonPropertyName("errorMessageRegex")]
    public IList<string>? ErrorMessageRegex { get; set; }

    /// <summary>The base number of seconds to wait between retries. Default is `10`.</summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>The maximum number of seconds to wait between retries. Default is `180`.</summary>
    [JsonPropertyName("maxIntervalSeconds")]
    public double? MaxIntervalSeconds { get; set; }

    /// <summary>The multiplier to apply to the interval between retries. Default is `1.5`.</summary>
    [JsonPropertyName("multiplier")]
    public double? Multiplier { get; set; }

    /// <summary>The randomization factor to apply to the interval between retries. The formula for the randomized interval is: `RetryInterval * (random value in range [1 - RandomizationFactor, 1 + RandomizationFactor])`. Therefore set to zero `0.0` for no randomization. Default is `0.5`.</summary>
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
public partial class V1beta2ResourceActionSpecInitProvider
{
    /// <summary>The name of the resource action. It&apos;s also possible to make HTTP requests towards the resource ID if leave this field empty.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A dynamic attribute that contains the request body.</summary>
    [JsonPropertyName("body")]
    public JsonNode? Body { get; set; }

    /// <summary>A map of headers to include in the request</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>If set to `true`, the resource action will ignore `Not Found` errors returned from the Azure API. Default is `false`.</summary>
    [JsonPropertyName("ignoreNotFound")]
    public bool? IgnoreNotFound { get; set; }

    /// <summary>A list of ARM resource IDs which are used to avoid create/modify/delete azapi resources at the same time.</summary>
    [JsonPropertyName("locks")]
    public IList<string>? Locks { get; set; }

    /// <summary>Specifies the HTTP method of the azure resource action. Allowed values are `POST`, `PATCH`, `PUT` and `DELETE`. Defaults to `POST`.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>A map of query parameters to include in the request</summary>
    [JsonPropertyName("queryParameters")]
    public IDictionary<string, IList<string>>? QueryParameters { get; set; }

    /// <summary>The ID of an existing Azure source.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>
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
    [JsonPropertyName("responseExportValues")]
    public JsonNode? ResponseExportValues { get; set; }

    [JsonPropertyName("retry")]
    public V1beta2ResourceActionSpecInitProviderRetry? Retry { get; set; }

    /// <summary>
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

    /// <summary>In a format like `&lt;resource-type&gt;@&lt;api-version&gt;`. `&lt;resource-type&gt;` is the Azure resource type, for example, `Microsoft.Storage/storageAccounts`. `&lt;api-version&gt;` is version of the API used to manage this azure resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>When to perform the action, value must be one of: `apply`, `destroy`. Default is `apply`.</summary>
    [JsonPropertyName("when")]
    public string? When { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceActionSpecManagementPoliciesEnum>))]
public enum V1beta2ResourceActionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceActionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ResourceActionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourceActionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ResourceActionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceActionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourceActionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourceActionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceActionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResourceActionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceActionSpecWriteConnectionSecretToRef
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
public partial class V1beta2ResourceActionSpec
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
    public V1beta2ResourceActionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ResourceActionSpecForProvider ForProvider { get; set; }

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
    public V1beta2ResourceActionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ResourceActionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ResourceActionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ResourceActionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceActionStatusAtProviderRetry
{
    /// <summary>A list of regular expressions to match against error messages. If any of the regular expressions match, the request will be retried.</summary>
    [JsonPropertyName("errorMessageRegex")]
    public IList<string>? ErrorMessageRegex { get; set; }

    /// <summary>The base number of seconds to wait between retries. Default is `10`.</summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>The maximum number of seconds to wait between retries. Default is `180`.</summary>
    [JsonPropertyName("maxIntervalSeconds")]
    public double? MaxIntervalSeconds { get; set; }

    /// <summary>The multiplier to apply to the interval between retries. Default is `1.5`.</summary>
    [JsonPropertyName("multiplier")]
    public double? Multiplier { get; set; }

    /// <summary>The randomization factor to apply to the interval between retries. The formula for the randomized interval is: `RetryInterval * (random value in range [1 - RandomizationFactor, 1 + RandomizationFactor])`. Therefore set to zero `0.0` for no randomization. Default is `0.5`.</summary>
    [JsonPropertyName("randomizationFactor")]
    public double? RandomizationFactor { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceActionStatusAtProvider
{
    /// <summary>The name of the resource action. It&apos;s also possible to make HTTP requests towards the resource ID if leave this field empty.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A dynamic attribute that contains the request body.</summary>
    [JsonPropertyName("body")]
    public JsonNode? Body { get; set; }

    /// <summary>Indicates whether the resource action was successfully performed.</summary>
    [JsonPropertyName("exist")]
    public bool? Exist { get; set; }

    /// <summary>A map of headers to include in the request</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>If set to `true`, the resource action will ignore `Not Found` errors returned from the Azure API. Default is `false`.</summary>
    [JsonPropertyName("ignoreNotFound")]
    public bool? IgnoreNotFound { get; set; }

    /// <summary>A list of ARM resource IDs which are used to avoid create/modify/delete azapi resources at the same time.</summary>
    [JsonPropertyName("locks")]
    public IList<string>? Locks { get; set; }

    /// <summary>Specifies the HTTP method of the azure resource action. Allowed values are `POST`, `PATCH`, `PUT` and `DELETE`. Defaults to `POST`.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// The output HCL object containing the properties specified in `response_export_values`. Here are some examples to use the values.azurecr.io&quot;
    /// output &quot;login_server&quot; {
    /// value = azapi_resource_action.example.output.properties.loginServer
    /// }
    /// 
    /// // it will output &quot;disabled&quot;
    /// output &quot;quarantine_policy&quot; {
    /// value = azapi_resource_action.example.output.properties.policies.quarantinePolicy.status
    /// }
    /// ```
    /// </summary>
    [JsonPropertyName("output")]
    public JsonNode? Output { get; set; }

    /// <summary>A map of query parameters to include in the request</summary>
    [JsonPropertyName("queryParameters")]
    public IDictionary<string, IList<string>>? QueryParameters { get; set; }

    /// <summary>The ID of an existing Azure source.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>
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
    [JsonPropertyName("responseExportValues")]
    public JsonNode? ResponseExportValues { get; set; }

    [JsonPropertyName("retry")]
    public V1beta2ResourceActionStatusAtProviderRetry? Retry { get; set; }

    /// <summary>
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

    /// <summary>In a format like `&lt;resource-type&gt;@&lt;api-version&gt;`. `&lt;resource-type&gt;` is the Azure resource type, for example, `Microsoft.Storage/storageAccounts`. `&lt;api-version&gt;` is version of the API used to manage this azure resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>When to perform the action, value must be one of: `apply`, `destroy`. Default is `apply`.</summary>
    [JsonPropertyName("when")]
    public string? When { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourceActionStatusConditions
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
public partial class V1beta2ResourceActionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ResourceActionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ResourceActionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ResourceAction is the Schema for the ResourceActions API. This resource allows you to perform an action on an existing Azure resource.g., starting or stopping an Azure Virtual Machine.	Please note that when deleting this resource, no action will be performed on the Azure resource unless the when argument is set to destroy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ResourceAction : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ResourceActionSpec>, IStatus<V1beta2ResourceActionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ResourceAction";
    public const string KubeGroup = "resources.azapi.upbound.io";
    public const string KubePluralName = "resourceactions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "resources.azapi.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceAction";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourceActionSpec defines the desired state of ResourceAction</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ResourceActionSpec Spec { get; set; }

    /// <summary>ResourceActionStatus defines the observed state of ResourceAction.</summary>
    [JsonPropertyName("status")]
    public V1beta2ResourceActionStatus? Status { get; set; }
}