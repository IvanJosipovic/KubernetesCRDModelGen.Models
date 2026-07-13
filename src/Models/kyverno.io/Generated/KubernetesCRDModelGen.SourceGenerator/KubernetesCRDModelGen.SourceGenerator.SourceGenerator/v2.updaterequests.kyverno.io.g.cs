#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kyverno.io;
/// <summary>UpdateRequest is a request to process mutate and generate rules in background.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2UpdateRequestList : IKubernetesObject<V1ListMeta>, IItems<V2UpdateRequest>
{
    public const string KubeApiVersion = "v2";
    public const string KubeKind = "UpdateRequestList";
    public const string KubeGroup = "kyverno.io";
    public const string KubePluralName = "updaterequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kyverno.io/v2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UpdateRequestList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V2UpdateRequest objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V2UpdateRequest> Items { get; set; }
}

/// <summary>kind is the fully-qualified type of object being submitted (for example, v1.Pod or autoscaling.v1.Scale)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecContextAdmissionRequestInfoAdmissionRequestKind
{
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>
/// requestKind is the fully-qualified type of the original API request (for example, v1.Pod or autoscaling.v1.Scale).
/// If this is specified and differs from the value in &quot;kind&quot;, an equivalent match and conversion was performed.
/// 
/// For example, if deployments can be modified via apps/v1 and apps/v1beta1, and a webhook registered a rule of
/// `apiGroups:[&quot;apps&quot;], apiVersions:[&quot;v1&quot;], resources: [&quot;deployments&quot;]` and `matchPolicy: Equivalent`,
/// an API request to apps/v1beta1 deployments would be converted and sent to the webhook
/// with `kind: {group:&quot;apps&quot;, version:&quot;v1&quot;, kind:&quot;Deployment&quot;}` (matching the rule the webhook registered for),
/// and `requestKind: {group:&quot;apps&quot;, version:&quot;v1beta1&quot;, kind:&quot;Deployment&quot;}` (indicating the kind of the original API request).
/// 
/// See documentation for the &quot;matchPolicy&quot; field in the webhook configuration type for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecContextAdmissionRequestInfoAdmissionRequestRequestKind
{
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>
/// requestResource is the fully-qualified resource of the original API request (for example, v1.pods).
/// If this is specified and differs from the value in &quot;resource&quot;, an equivalent match and conversion was performed.
/// 
/// For example, if deployments can be modified via apps/v1 and apps/v1beta1, and a webhook registered a rule of
/// `apiGroups:[&quot;apps&quot;], apiVersions:[&quot;v1&quot;], resources: [&quot;deployments&quot;]` and `matchPolicy: Equivalent`,
/// an API request to apps/v1beta1 deployments would be converted and sent to the webhook
/// with `resource: {group:&quot;apps&quot;, version:&quot;v1&quot;, resource:&quot;deployments&quot;}` (matching the resource the webhook registered for),
/// and `requestResource: {group:&quot;apps&quot;, version:&quot;v1beta1&quot;, resource:&quot;deployments&quot;}` (indicating the resource of the original API request).
/// 
/// See documentation for the &quot;matchPolicy&quot; field in the webhook configuration type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecContextAdmissionRequestInfoAdmissionRequestRequestResource
{
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }

    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>resource is the fully-qualified resource being requested (for example, v1.pods)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecContextAdmissionRequestInfoAdmissionRequestResource
{
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }

    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>userInfo is information about the requesting user</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecContextAdmissionRequestInfoAdmissionRequestUserInfo
{
    /// <summary>Any additional information provided by the authenticator.</summary>
    [JsonPropertyName("extra")]
    public IDictionary<string, IList<string>>? Extra { get; set; }

    /// <summary>The names of groups this user is a part of.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>
    /// A unique value that identifies this user across time. If this user is
    /// deleted and another user by the same name is added, they will have
    /// different UIDs.
    /// </summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>The name that uniquely identifies this user among all active users.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>AdmissionRequest describes the admission.Attributes for the admission request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecContextAdmissionRequestInfoAdmissionRequest
{
    /// <summary>
    /// dryRun indicates that modifications will definitely not be persisted for this request.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>kind is the fully-qualified type of object being submitted (for example, v1.Pod or autoscaling.v1.Scale)</summary>
    [JsonPropertyName("kind")]
    public required V2UpdateRequestSpecContextAdmissionRequestInfoAdmissionRequestKind Kind { get; set; }

    /// <summary>
    /// name is the name of the object as presented in the request.  On a CREATE operation, the client may omit name and
    /// rely on the server to generate the name.  If that is the case, this field will contain an empty string.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>namespace is the namespace associated with the request (if any).</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>object is the object from the incoming request.</summary>
    [JsonPropertyName("object")]
    public JsonNode? Object { get; set; }

    /// <summary>oldObject is the existing object. Only populated for DELETE and UPDATE requests.</summary>
    [JsonPropertyName("oldObject")]
    public JsonNode? OldObject { get; set; }

    /// <summary>
    /// operation is the operation being performed. This may be different than the operation
    /// requested. e.g. a patch can result in either a CREATE or UPDATE Operation.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; set; }

    /// <summary>
    /// options is the operation option structure of the operation being performed.
    /// e.g. `meta.k8s.io/v1.DeleteOptions` or `meta.k8s.io/v1.CreateOptions`. This may be
    /// different than the options the caller provided. e.g. for a patch request the performed
    /// Operation might be a CREATE, in which case the Options will a
    /// `meta.k8s.io/v1.CreateOptions` even though the caller provided `meta.k8s.io/v1.PatchOptions`.
    /// </summary>
    [JsonPropertyName("options")]
    public JsonNode? Options { get; set; }

    /// <summary>
    /// requestKind is the fully-qualified type of the original API request (for example, v1.Pod or autoscaling.v1.Scale).
    /// If this is specified and differs from the value in &quot;kind&quot;, an equivalent match and conversion was performed.
    /// 
    /// For example, if deployments can be modified via apps/v1 and apps/v1beta1, and a webhook registered a rule of
    /// `apiGroups:[&quot;apps&quot;], apiVersions:[&quot;v1&quot;], resources: [&quot;deployments&quot;]` and `matchPolicy: Equivalent`,
    /// an API request to apps/v1beta1 deployments would be converted and sent to the webhook
    /// with `kind: {group:&quot;apps&quot;, version:&quot;v1&quot;, kind:&quot;Deployment&quot;}` (matching the rule the webhook registered for),
    /// and `requestKind: {group:&quot;apps&quot;, version:&quot;v1beta1&quot;, kind:&quot;Deployment&quot;}` (indicating the kind of the original API request).
    /// 
    /// See documentation for the &quot;matchPolicy&quot; field in the webhook configuration type for more details.
    /// </summary>
    [JsonPropertyName("requestKind")]
    public V2UpdateRequestSpecContextAdmissionRequestInfoAdmissionRequestRequestKind? RequestKind { get; set; }

    /// <summary>
    /// requestResource is the fully-qualified resource of the original API request (for example, v1.pods).
    /// If this is specified and differs from the value in &quot;resource&quot;, an equivalent match and conversion was performed.
    /// 
    /// For example, if deployments can be modified via apps/v1 and apps/v1beta1, and a webhook registered a rule of
    /// `apiGroups:[&quot;apps&quot;], apiVersions:[&quot;v1&quot;], resources: [&quot;deployments&quot;]` and `matchPolicy: Equivalent`,
    /// an API request to apps/v1beta1 deployments would be converted and sent to the webhook
    /// with `resource: {group:&quot;apps&quot;, version:&quot;v1&quot;, resource:&quot;deployments&quot;}` (matching the resource the webhook registered for),
    /// and `requestResource: {group:&quot;apps&quot;, version:&quot;v1beta1&quot;, resource:&quot;deployments&quot;}` (indicating the resource of the original API request).
    /// 
    /// See documentation for the &quot;matchPolicy&quot; field in the webhook configuration type.
    /// </summary>
    [JsonPropertyName("requestResource")]
    public V2UpdateRequestSpecContextAdmissionRequestInfoAdmissionRequestRequestResource? RequestResource { get; set; }

    /// <summary>
    /// requestSubResource is the name of the subresource of the original API request, if any (for example, &quot;status&quot; or &quot;scale&quot;)
    /// If this is specified and differs from the value in &quot;subResource&quot;, an equivalent match and conversion was performed.
    /// See documentation for the &quot;matchPolicy&quot; field in the webhook configuration type.
    /// </summary>
    [JsonPropertyName("requestSubResource")]
    public string? RequestSubResource { get; set; }

    /// <summary>resource is the fully-qualified resource being requested (for example, v1.pods)</summary>
    [JsonPropertyName("resource")]
    public required V2UpdateRequestSpecContextAdmissionRequestInfoAdmissionRequestResource Resource { get; set; }

    /// <summary>subResource is the subresource being requested, if any (for example, &quot;status&quot; or &quot;scale&quot;)</summary>
    [JsonPropertyName("subResource")]
    public string? SubResource { get; set; }

    /// <summary>
    /// uid is an identifier for the individual request/response. It allows us to distinguish instances of requests which are
    /// otherwise identical (parallel requests, requests when earlier requests did not modify etc)
    /// The UID is meant to track the round trip (request/response) between the KAS and the WebHook, not the user request.
    /// It is suitable for correlating log entries between the webhook and apiserver, for either auditing or debugging.
    /// </summary>
    [JsonPropertyName("uid")]
    public required string Uid { get; set; }

    /// <summary>userInfo is information about the requesting user</summary>
    [JsonPropertyName("userInfo")]
    public required V2UpdateRequestSpecContextAdmissionRequestInfoAdmissionRequestUserInfo UserInfo { get; set; }
}

/// <summary>AdmissionRequestInfoObject stores the admission request and operation details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecContextAdmissionRequestInfo
{
    /// <summary>AdmissionRequest describes the admission.Attributes for the admission request.</summary>
    [JsonPropertyName("admissionRequest")]
    public V2UpdateRequestSpecContextAdmissionRequestInfoAdmissionRequest? AdmissionRequest { get; set; }

    /// <summary>Operation is the type of resource operation being checked for admission control</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }
}

/// <summary>UserInfo is the userInfo carried in the admission request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecContextUserInfoUserInfo
{
    /// <summary>Any additional information provided by the authenticator.</summary>
    [JsonPropertyName("extra")]
    public IDictionary<string, IList<string>>? Extra { get; set; }

    /// <summary>The names of groups this user is a part of.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>
    /// A unique value that identifies this user across time. If this user is
    /// deleted and another user by the same name is added, they will have
    /// different UIDs.
    /// </summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>The name that uniquely identifies this user among all active users.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>RequestInfo contains permission info carried in an admission request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecContextUserInfo
{
    /// <summary>ClusterRoles is a list of possible clusterRoles send the request.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>Roles is a list of possible role send the request.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>
    /// DryRun indicates that modifications will definitely not be persisted for this request.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("synchronize")]
    public bool? Synchronize { get; set; }

    /// <summary>UserInfo is the userInfo carried in the admission request.</summary>
    [JsonPropertyName("userInfo")]
    public V2UpdateRequestSpecContextUserInfoUserInfo? UserInfo { get; set; }
}

/// <summary>
/// Context represents admission request context.
/// It is used upon admission review only and is shared across rules within the same UR.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecContext
{
    /// <summary>AdmissionRequestInfoObject stores the admission request and operation details</summary>
    [JsonPropertyName("admissionRequestInfo")]
    public V2UpdateRequestSpecContextAdmissionRequestInfo? AdmissionRequestInfo { get; set; }

    /// <summary>RequestInfo contains permission info carried in an admission request.</summary>
    [JsonPropertyName("userInfo")]
    public V2UpdateRequestSpecContextUserInfo? UserInfo { get; set; }
}

/// <summary>Type represents request type for background processing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2UpdateRequestSpecRequestTypeEnum>))]
public enum V2UpdateRequestSpecRequestTypeEnum
{
    [EnumMember(Value = "mutate"), JsonStringEnumMemberName("mutate")]
    Mutate,
    [EnumMember(Value = "generate"), JsonStringEnumMemberName("generate")]
    Generate,
    [EnumMember(Value = "cel-generate"), JsonStringEnumMemberName("cel-generate")]
    CelGenerate,
    [EnumMember(Value = "cel-mutate"), JsonStringEnumMemberName("cel-mutate")]
    CelMutate
}

/// <summary>ResourceSpec is the information to identify the trigger resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecResource
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind specifies resource kind.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name specifies the resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>ResourceSpec is the information to identify the trigger resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecRuleContextTrigger
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind specifies resource kind.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name specifies the resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpecRuleContext
{
    /// <summary>CacheRestore indicates whether the cache should be restored.</summary>
    [JsonPropertyName("cacheRestore")]
    public bool? CacheRestore { get; set; }

    /// <summary>DeleteDownstream represents whether the downstream needs to be deleted.</summary>
    [JsonPropertyName("deleteDownstream")]
    public required bool DeleteDownstream { get; set; }

    /// <summary>Rule is the associate rule name of the current UR.</summary>
    [JsonPropertyName("rule")]
    public required string Rule { get; set; }

    /// <summary>
    /// Synchronize represents the sync behavior of the corresponding rule
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("synchronize")]
    public bool? Synchronize { get; set; }

    /// <summary>ResourceSpec is the information to identify the trigger resource.</summary>
    [JsonPropertyName("trigger")]
    public required V2UpdateRequestSpecRuleContextTrigger Trigger { get; set; }
}

/// <summary>ResourceSpec is the information to identify the trigger resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestSpec
{
    /// <summary>
    /// Context represents admission request context.
    /// It is used upon admission review only and is shared across rules within the same UR.
    /// </summary>
    [JsonPropertyName("context")]
    public required V2UpdateRequestSpecContext Context { get; set; }

    /// <summary>
    /// DeleteDownstream represents whether the downstream needs to be deleted.
    /// Deprecated
    /// </summary>
    [JsonPropertyName("deleteDownstream")]
    public required bool DeleteDownstream { get; set; }

    /// <summary>Specifies the name of the policy.</summary>
    [JsonPropertyName("policy")]
    public required string Policy { get; set; }

    /// <summary>Type represents request type for background processing</summary>
    [JsonPropertyName("requestType")]
    public V2UpdateRequestSpecRequestTypeEnum? RequestType { get; set; }

    /// <summary>ResourceSpec is the information to identify the trigger resource.</summary>
    [JsonPropertyName("resource")]
    public required V2UpdateRequestSpecResource Resource { get; set; }

    /// <summary>Rule is the associate rule name of the current UR.</summary>
    [JsonPropertyName("rule")]
    public required string Rule { get; set; }

    /// <summary>
    /// RuleContext is the associate context to apply rules.
    /// optional
    /// </summary>
    [JsonPropertyName("ruleContext")]
    public IList<V2UpdateRequestSpecRuleContext>? RuleContext { get; set; }

    /// <summary>
    /// Synchronize represents the sync behavior of the corresponding rule
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// Deprecated, will be removed in 1.14.
    /// </summary>
    [JsonPropertyName("synchronize")]
    public bool? Synchronize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestStatusGeneratedResources
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind specifies resource kind.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name specifies the resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Status contains statistics related to update request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2UpdateRequestStatus
{
    /// <summary>
    /// This will track the resources that are updated by the generate Policy.
    /// Will be used during clean up resources.
    /// </summary>
    [JsonPropertyName("generatedResources")]
    public IList<V2UpdateRequestStatusGeneratedResources>? GeneratedResources { get; set; }

    /// <summary>Specifies request status message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("retryCount")]
    public int? RetryCount { get; set; }

    /// <summary>State represents state of the update request.</summary>
    [JsonPropertyName("state")]
    public required string State { get; set; }
}

/// <summary>UpdateRequest is a request to process mutate and generate rules in background.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2UpdateRequest : IKubernetesObject<V1ObjectMeta>, ISpec<V2UpdateRequestSpec?>, IStatus<V2UpdateRequestStatus?>
{
    public const string KubeApiVersion = "v2";
    public const string KubeKind = "UpdateRequest";
    public const string KubeGroup = "kyverno.io";
    public const string KubePluralName = "updaterequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kyverno.io/v2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UpdateRequest";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourceSpec is the information to identify the trigger resource.</summary>
    [JsonPropertyName("spec")]
    public V2UpdateRequestSpec? Spec { get; set; }

    /// <summary>Status contains statistics related to update request.</summary>
    [JsonPropertyName("status")]
    public V2UpdateRequestStatus? Status { get; set; }
}