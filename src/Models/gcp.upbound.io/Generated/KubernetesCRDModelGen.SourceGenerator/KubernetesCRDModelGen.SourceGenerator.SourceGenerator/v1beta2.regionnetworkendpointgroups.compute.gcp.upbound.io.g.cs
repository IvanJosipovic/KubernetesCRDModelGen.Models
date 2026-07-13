#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>RegionNetworkEndpointGroup is the Schema for the RegionNetworkEndpointGroups API. A regional NEG that can support Serverless Products, proxying traffic to external backends and providing traffic to the PSC port mapping endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RegionNetworkEndpointGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta2RegionNetworkEndpointGroup>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RegionNetworkEndpointGroupList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regionnetworkendpointgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegionNetworkEndpointGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2RegionNetworkEndpointGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2RegionNetworkEndpointGroup> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecDeletionPolicyEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// This field is only used for SERVERLESS NEGs.
/// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderAppEngine
{
    /// <summary>
    /// Optional serving service.
    /// The service name must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &quot;default&quot;, &quot;my-service&quot;.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// A template to parse service and version fields from a request URL.
    /// URL mask allows for routing to multiple App Engine services without
    /// having to create multiple Network Endpoint Groups and backend services.
    /// For example, the request URLs &quot;foo1-dot-appname.appspot.com/v1&quot; and
    /// &quot;foo1-dot-appname.appspot.com/v2&quot; can be backed by the same Serverless NEG with
    /// URL mask &quot;-dot-appname.appspot.com/&quot;. The URL mask will parse
    /// them to { service = &quot;foo1&quot;, version = &quot;v1&quot; } and { service = &quot;foo1&quot;, version = &quot;v2&quot; } respectively.
    /// </summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }

    /// <summary>
    /// Optional serving version.
    /// The version must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &quot;v1&quot;, &quot;v2&quot;.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in cloudfunctions to populate function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in cloudfunctions to populate function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelector
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
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// This field is only used for SERVERLESS NEGs.
/// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunction
{
    /// <summary>
    /// A user-defined name of the Cloud Function.
    /// The function name is case-sensitive and must be 1-63 characters long.
    /// Example value: &quot;func1&quot;.
    /// </summary>
    [JsonPropertyName("function")]
    public string? Function { get; set; }

    /// <summary>Reference to a Function in cloudfunctions to populate function.</summary>
    [JsonPropertyName("functionRef")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRef? FunctionRef { get; set; }

    /// <summary>Selector for a Function in cloudfunctions to populate function.</summary>
    [JsonPropertyName("functionSelector")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelector? FunctionSelector { get; set; }

    /// <summary>
    /// A template to parse function field from a request URL. URL mask allows
    /// for routing to multiple Cloud Functions without having to create
    /// multiple Network Endpoint Groups and backend services.
    /// For example, request URLs &quot;mydomain.com/function1&quot; and &quot;mydomain.com/function2&quot;
    /// can be backed by the same Serverless NEG with URL mask &quot;/&quot;. The URL mask
    /// will parse them to { function = &quot;function1&quot; } and { function = &quot;function2&quot; } respectively.
    /// </summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Service in cloudrun to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Service in cloudrun to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelector
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
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// This field is only used for SERVERLESS NEGs.
/// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRun
{
    /// <summary>
    /// Cloud Run service is the main resource of Cloud Run.
    /// The service must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &quot;run-service&quot;.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a Service in cloudrun to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a Service in cloudrun to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelector? ServiceSelector { get; set; }

    /// <summary>
    /// Cloud Run tag represents the &quot;named-revision&quot; to provide
    /// additional fine-grained traffic routing information.
    /// The tag must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &quot;revision-0010&quot;.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>
    /// A template to parse service and tag fields from a request URL.
    /// URL mask allows for routing to multiple Run services without having
    /// to create multiple network endpoint groups and backend services.
    /// For example, request URLs &quot;foo1.domain.com/bar1&quot; and &quot;foo1.domain.com/bar2&quot;
    /// an be backed by the same Serverless Network Endpoint Group (NEG) with
    /// URL mask &quot;.domain.com/&quot;. The URL mask will parse them to { service=&quot;bar1&quot;, tag=&quot;foo1&quot; }
    /// and { service=&quot;bar2&quot;, tag=&quot;foo2&quot; } respectively.
    /// </summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkSelector
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
    public V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// This field is only used for PSC NEGs.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderPscData
{
    /// <summary>
    /// The PSC producer port to use when consumer PSC NEG connects to a producer. If
    /// this flag isn&apos;t specified for a PSC NEG with endpoint type
    /// private-service-connect, then PSC NEG will be connected to a first port in the
    /// available PSC producer port range.
    /// </summary>
    [JsonPropertyName("producerPort")]
    public string? ProducerPort { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAttachment in compute to populate pscTargetService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAttachment in compute to populate pscTargetService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelector
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
    public V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkSelector
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
    public V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecForProvider
{
    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("appEngine")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderAppEngine? AppEngine { get; set; }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudFunction")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudFunction? CloudFunction { get; set; }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudRun")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderCloudRun? CloudRun { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// The URL of the network to which all network endpoints in the NEG belong. Uses
    /// &quot;default&quot; project network if unspecified.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// Type of network endpoints in this network endpoint group. Defaults to SERVERLESS.
    /// Default value is SERVERLESS.
    /// Possible values are: SERVERLESS, PRIVATE_SERVICE_CONNECT, INTERNET_IP_PORT, INTERNET_FQDN_PORT, GCE_VM_IP_PORTMAP.
    /// </summary>
    [JsonPropertyName("networkEndpointType")]
    public string? NetworkEndpointType { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscData")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderPscData? PscData { get; set; }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// The target service url used to set up private service connection to
    /// a Google API or a PSC Producer Service Attachment.
    /// </summary>
    [JsonPropertyName("pscTargetService")]
    public string? PscTargetService { get; set; }

    /// <summary>Reference to a ServiceAttachment in compute to populate pscTargetService.</summary>
    [JsonPropertyName("pscTargetServiceRef")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRef? PscTargetServiceRef { get; set; }

    /// <summary>Selector for a ServiceAttachment in compute to populate pscTargetService.</summary>
    [JsonPropertyName("pscTargetServiceSelector")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelector? PscTargetServiceSelector { get; set; }

    /// <summary>A reference to the region where the regional NEGs reside.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// Optional URL of the subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta2RegionNetworkEndpointGroupSpecForProviderSubnetworkSelector? SubnetworkSelector { get; set; }
}

/// <summary>
/// This field is only used for SERVERLESS NEGs.
/// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderAppEngine
{
    /// <summary>
    /// Optional serving service.
    /// The service name must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &quot;default&quot;, &quot;my-service&quot;.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// A template to parse service and version fields from a request URL.
    /// URL mask allows for routing to multiple App Engine services without
    /// having to create multiple Network Endpoint Groups and backend services.
    /// For example, the request URLs &quot;foo1-dot-appname.appspot.com/v1&quot; and
    /// &quot;foo1-dot-appname.appspot.com/v2&quot; can be backed by the same Serverless NEG with
    /// URL mask &quot;-dot-appname.appspot.com/&quot;. The URL mask will parse
    /// them to { service = &quot;foo1&quot;, version = &quot;v1&quot; } and { service = &quot;foo1&quot;, version = &quot;v2&quot; } respectively.
    /// </summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }

    /// <summary>
    /// Optional serving version.
    /// The version must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &quot;v1&quot;, &quot;v2&quot;.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in cloudfunctions to populate function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in cloudfunctions to populate function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelector
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
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// This field is only used for SERVERLESS NEGs.
/// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunction
{
    /// <summary>
    /// A user-defined name of the Cloud Function.
    /// The function name is case-sensitive and must be 1-63 characters long.
    /// Example value: &quot;func1&quot;.
    /// </summary>
    [JsonPropertyName("function")]
    public string? Function { get; set; }

    /// <summary>Reference to a Function in cloudfunctions to populate function.</summary>
    [JsonPropertyName("functionRef")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRef? FunctionRef { get; set; }

    /// <summary>Selector for a Function in cloudfunctions to populate function.</summary>
    [JsonPropertyName("functionSelector")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelector? FunctionSelector { get; set; }

    /// <summary>
    /// A template to parse function field from a request URL. URL mask allows
    /// for routing to multiple Cloud Functions without having to create
    /// multiple Network Endpoint Groups and backend services.
    /// For example, request URLs &quot;mydomain.com/function1&quot; and &quot;mydomain.com/function2&quot;
    /// can be backed by the same Serverless NEG with URL mask &quot;/&quot;. The URL mask
    /// will parse them to { function = &quot;function1&quot; } and { function = &quot;function2&quot; } respectively.
    /// </summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Service in cloudrun to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Service in cloudrun to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelector
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
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// This field is only used for SERVERLESS NEGs.
/// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRun
{
    /// <summary>
    /// Cloud Run service is the main resource of Cloud Run.
    /// The service must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &quot;run-service&quot;.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a Service in cloudrun to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a Service in cloudrun to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelector? ServiceSelector { get; set; }

    /// <summary>
    /// Cloud Run tag represents the &quot;named-revision&quot; to provide
    /// additional fine-grained traffic routing information.
    /// The tag must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &quot;revision-0010&quot;.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>
    /// A template to parse service and tag fields from a request URL.
    /// URL mask allows for routing to multiple Run services without having
    /// to create multiple network endpoint groups and backend services.
    /// For example, request URLs &quot;foo1.domain.com/bar1&quot; and &quot;foo1.domain.com/bar2&quot;
    /// an be backed by the same Serverless Network Endpoint Group (NEG) with
    /// URL mask &quot;.domain.com/&quot;. The URL mask will parse them to { service=&quot;bar1&quot;, tag=&quot;foo1&quot; }
    /// and { service=&quot;bar2&quot;, tag=&quot;foo2&quot; } respectively.
    /// </summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkSelector
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
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// This field is only used for PSC NEGs.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderPscData
{
    /// <summary>
    /// The PSC producer port to use when consumer PSC NEG connects to a producer. If
    /// this flag isn&apos;t specified for a PSC NEG with endpoint type
    /// private-service-connect, then PSC NEG will be connected to a first port in the
    /// available PSC producer port range.
    /// </summary>
    [JsonPropertyName("producerPort")]
    public string? ProducerPort { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAttachment in compute to populate pscTargetService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAttachment in compute to populate pscTargetService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelector
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
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelector
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
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2RegionNetworkEndpointGroupSpecInitProvider
{
    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("appEngine")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderAppEngine? AppEngine { get; set; }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudFunction")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudFunction? CloudFunction { get; set; }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudRun")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderCloudRun? CloudRun { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// The URL of the network to which all network endpoints in the NEG belong. Uses
    /// &quot;default&quot; project network if unspecified.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// Type of network endpoints in this network endpoint group. Defaults to SERVERLESS.
    /// Default value is SERVERLESS.
    /// Possible values are: SERVERLESS, PRIVATE_SERVICE_CONNECT, INTERNET_IP_PORT, INTERNET_FQDN_PORT, GCE_VM_IP_PORTMAP.
    /// </summary>
    [JsonPropertyName("networkEndpointType")]
    public string? NetworkEndpointType { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscData")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderPscData? PscData { get; set; }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// The target service url used to set up private service connection to
    /// a Google API or a PSC Producer Service Attachment.
    /// </summary>
    [JsonPropertyName("pscTargetService")]
    public string? PscTargetService { get; set; }

    /// <summary>Reference to a ServiceAttachment in compute to populate pscTargetService.</summary>
    [JsonPropertyName("pscTargetServiceRef")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRef? PscTargetServiceRef { get; set; }

    /// <summary>Selector for a ServiceAttachment in compute to populate pscTargetService.</summary>
    [JsonPropertyName("pscTargetServiceSelector")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelector? PscTargetServiceSelector { get; set; }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// Optional URL of the subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta2RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelector? SubnetworkSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecManagementPoliciesEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionNetworkEndpointGroupSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2RegionNetworkEndpointGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionNetworkEndpointGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionNetworkEndpointGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionNetworkEndpointGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RegionNetworkEndpointGroupSpec defines the desired state of RegionNetworkEndpointGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupSpec
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
    public V1beta2RegionNetworkEndpointGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2RegionNetworkEndpointGroupSpecForProvider ForProvider { get; set; }

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
    public V1beta2RegionNetworkEndpointGroupSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2RegionNetworkEndpointGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RegionNetworkEndpointGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RegionNetworkEndpointGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// This field is only used for SERVERLESS NEGs.
/// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupStatusAtProviderAppEngine
{
    /// <summary>
    /// Optional serving service.
    /// The service name must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &quot;default&quot;, &quot;my-service&quot;.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// A template to parse service and version fields from a request URL.
    /// URL mask allows for routing to multiple App Engine services without
    /// having to create multiple Network Endpoint Groups and backend services.
    /// For example, the request URLs &quot;foo1-dot-appname.appspot.com/v1&quot; and
    /// &quot;foo1-dot-appname.appspot.com/v2&quot; can be backed by the same Serverless NEG with
    /// URL mask &quot;-dot-appname.appspot.com/&quot;. The URL mask will parse
    /// them to { service = &quot;foo1&quot;, version = &quot;v1&quot; } and { service = &quot;foo1&quot;, version = &quot;v2&quot; } respectively.
    /// </summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }

    /// <summary>
    /// Optional serving version.
    /// The version must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &quot;v1&quot;, &quot;v2&quot;.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// This field is only used for SERVERLESS NEGs.
/// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupStatusAtProviderCloudFunction
{
    /// <summary>
    /// A user-defined name of the Cloud Function.
    /// The function name is case-sensitive and must be 1-63 characters long.
    /// Example value: &quot;func1&quot;.
    /// </summary>
    [JsonPropertyName("function")]
    public string? Function { get; set; }

    /// <summary>
    /// A template to parse function field from a request URL. URL mask allows
    /// for routing to multiple Cloud Functions without having to create
    /// multiple Network Endpoint Groups and backend services.
    /// For example, request URLs &quot;mydomain.com/function1&quot; and &quot;mydomain.com/function2&quot;
    /// can be backed by the same Serverless NEG with URL mask &quot;/&quot;. The URL mask
    /// will parse them to { function = &quot;function1&quot; } and { function = &quot;function2&quot; } respectively.
    /// </summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

/// <summary>
/// This field is only used for SERVERLESS NEGs.
/// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupStatusAtProviderCloudRun
{
    /// <summary>
    /// Cloud Run service is the main resource of Cloud Run.
    /// The service must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &quot;run-service&quot;.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// Cloud Run tag represents the &quot;named-revision&quot; to provide
    /// additional fine-grained traffic routing information.
    /// The tag must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &quot;revision-0010&quot;.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>
    /// A template to parse service and tag fields from a request URL.
    /// URL mask allows for routing to multiple Run services without having
    /// to create multiple network endpoint groups and backend services.
    /// For example, request URLs &quot;foo1.domain.com/bar1&quot; and &quot;foo1.domain.com/bar2&quot;
    /// an be backed by the same Serverless Network Endpoint Group (NEG) with
    /// URL mask &quot;.domain.com/&quot;. The URL mask will parse them to { service=&quot;bar1&quot;, tag=&quot;foo1&quot; }
    /// and { service=&quot;bar2&quot;, tag=&quot;foo2&quot; } respectively.
    /// </summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

/// <summary>
/// This field is only used for PSC NEGs.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupStatusAtProviderPscData
{
    /// <summary>
    /// The PSC producer port to use when consumer PSC NEG connects to a producer. If
    /// this flag isn&apos;t specified for a PSC NEG with endpoint type
    /// private-service-connect, then PSC NEG will be connected to a first port in the
    /// available PSC producer port range.
    /// </summary>
    [JsonPropertyName("producerPort")]
    public string? ProducerPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupStatusAtProvider
{
    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("appEngine")]
    public V1beta2RegionNetworkEndpointGroupStatusAtProviderAppEngine? AppEngine { get; set; }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudFunction")]
    public V1beta2RegionNetworkEndpointGroupStatusAtProviderCloudFunction? CloudFunction { get; set; }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudRun")]
    public V1beta2RegionNetworkEndpointGroupStatusAtProviderCloudRun? CloudRun { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/networkEndpointGroups/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// The URL of the network to which all network endpoints in the NEG belong. Uses
    /// &quot;default&quot; project network if unspecified.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// Type of network endpoints in this network endpoint group. Defaults to SERVERLESS.
    /// Default value is SERVERLESS.
    /// Possible values are: SERVERLESS, PRIVATE_SERVICE_CONNECT, INTERNET_IP_PORT, INTERNET_FQDN_PORT, GCE_VM_IP_PORTMAP.
    /// </summary>
    [JsonPropertyName("networkEndpointType")]
    public string? NetworkEndpointType { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscData")]
    public V1beta2RegionNetworkEndpointGroupStatusAtProviderPscData? PscData { get; set; }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// The target service url used to set up private service connection to
    /// a Google API or a PSC Producer Service Attachment.
    /// </summary>
    [JsonPropertyName("pscTargetService")]
    public string? PscTargetService { get; set; }

    /// <summary>A reference to the region where the regional NEGs reside.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// Optional URL of the subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupStatusConditions
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

/// <summary>RegionNetworkEndpointGroupStatus defines the observed state of RegionNetworkEndpointGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionNetworkEndpointGroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2RegionNetworkEndpointGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RegionNetworkEndpointGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegionNetworkEndpointGroup is the Schema for the RegionNetworkEndpointGroups API. A regional NEG that can support Serverless Products, proxying traffic to external backends and providing traffic to the PSC port mapping endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RegionNetworkEndpointGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RegionNetworkEndpointGroupSpec>, IStatus<V1beta2RegionNetworkEndpointGroupStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RegionNetworkEndpointGroup";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regionnetworkendpointgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegionNetworkEndpointGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionNetworkEndpointGroupSpec defines the desired state of RegionNetworkEndpointGroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta2RegionNetworkEndpointGroupSpec Spec { get; set; }

    /// <summary>RegionNetworkEndpointGroupStatus defines the observed state of RegionNetworkEndpointGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta2RegionNetworkEndpointGroupStatus? Status { get; set; }
}