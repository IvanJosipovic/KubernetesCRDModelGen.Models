#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appsync.aws.upbound.io;
/// <summary>Resolver is the Schema for the Resolvers API. Provides an AppSync Resolver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ResolverList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Resolver>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ResolverList";
    public const string KubeGroup = "appsync.aws.upbound.io";
    public const string KubePluralName = "resolvers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appsync.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResolverList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Resolver objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Resolver> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecDeletionPolicyEnum>))]
public enum V1beta2ResolverSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecForProviderApiIdRefPolicyResolutionEnum>))]
public enum V1beta2ResolverSpecForProviderApiIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecForProviderApiIdRefPolicyResolveEnum>))]
public enum V1beta2ResolverSpecForProviderApiIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderApiIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResolverSpecForProviderApiIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResolverSpecForProviderApiIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a GraphQLAPI in appsync to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResolverSpecForProviderApiIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecForProviderApiIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ResolverSpecForProviderApiIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecForProviderApiIdSelectorPolicyResolveEnum>))]
public enum V1beta2ResolverSpecForProviderApiIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderApiIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResolverSpecForProviderApiIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResolverSpecForProviderApiIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a GraphQLAPI in appsync to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderApiIdSelector
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
    public V1beta2ResolverSpecForProviderApiIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The Caching Config. See Caching Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderCachingConfig
{
    /// <summary>The caching keys for a resolver that has caching activated. Valid values are entries from the $context.arguments, $context.source, and $context.identity maps.</summary>
    [JsonPropertyName("cachingKeys")]
    public IList<string>? CachingKeys { get; set; }

    /// <summary>The TTL in seconds for a resolver that has caching activated. Valid values are between 1 and 3600 seconds.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecForProviderDataSourceRefPolicyResolutionEnum>))]
public enum V1beta2ResolverSpecForProviderDataSourceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecForProviderDataSourceRefPolicyResolveEnum>))]
public enum V1beta2ResolverSpecForProviderDataSourceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderDataSourceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResolverSpecForProviderDataSourceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResolverSpecForProviderDataSourceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Datasource in appsync to populate dataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderDataSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResolverSpecForProviderDataSourceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecForProviderDataSourceSelectorPolicyResolutionEnum>))]
public enum V1beta2ResolverSpecForProviderDataSourceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecForProviderDataSourceSelectorPolicyResolveEnum>))]
public enum V1beta2ResolverSpecForProviderDataSourceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderDataSourceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResolverSpecForProviderDataSourceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResolverSpecForProviderDataSourceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Datasource in appsync to populate dataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderDataSourceSelector
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
    public V1beta2ResolverSpecForProviderDataSourceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecForProviderPipelineConfigFunctionsRefsPolicyResolutionEnum>))]
public enum V1beta2ResolverSpecForProviderPipelineConfigFunctionsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecForProviderPipelineConfigFunctionsRefsPolicyResolveEnum>))]
public enum V1beta2ResolverSpecForProviderPipelineConfigFunctionsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderPipelineConfigFunctionsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResolverSpecForProviderPipelineConfigFunctionsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResolverSpecForProviderPipelineConfigFunctionsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderPipelineConfigFunctionsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResolverSpecForProviderPipelineConfigFunctionsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecForProviderPipelineConfigFunctionsSelectorPolicyResolutionEnum>))]
public enum V1beta2ResolverSpecForProviderPipelineConfigFunctionsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecForProviderPipelineConfigFunctionsSelectorPolicyResolveEnum>))]
public enum V1beta2ResolverSpecForProviderPipelineConfigFunctionsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderPipelineConfigFunctionsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResolverSpecForProviderPipelineConfigFunctionsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResolverSpecForProviderPipelineConfigFunctionsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Function in appsync to populate functions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderPipelineConfigFunctionsSelector
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
    public V1beta2ResolverSpecForProviderPipelineConfigFunctionsSelectorPolicy? Policy { get; set; }
}

/// <summary>The caching configuration for the resolver. See Pipeline Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderPipelineConfig
{
    /// <summary>A list of Function objects.</summary>
    [JsonPropertyName("functions")]
    public IList<string>? Functions { get; set; }

    /// <summary>References to Function in appsync to populate functions.</summary>
    [JsonPropertyName("functionsRefs")]
    public IList<V1beta2ResolverSpecForProviderPipelineConfigFunctionsRefs>? FunctionsRefs { get; set; }

    /// <summary>Selector for a list of Function in appsync to populate functions.</summary>
    [JsonPropertyName("functionsSelector")]
    public V1beta2ResolverSpecForProviderPipelineConfigFunctionsSelector? FunctionsSelector { get; set; }
}

/// <summary>Describes a runtime used by an AWS AppSync pipeline resolver or AWS AppSync function. Specifies the name and version of the runtime to use. Note that if a runtime is specified, code must also be specified. See Runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderRuntime
{
    /// <summary>The name of the runtime to use. Currently, the only allowed value is APPSYNC_JS.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The version of the runtime to use. Currently, the only allowed version is 1.0.0.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>Lambda Conflict Handler Config when configuring LAMBDA as the Conflict Handler. See Lambda Conflict Handler Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderSyncConfigLambdaConflictHandlerConfig
{
    /// <summary>ARN for the Lambda function to use as the Conflict Handler.</summary>
    [JsonPropertyName("lambdaConflictHandlerArn")]
    public string? LambdaConflictHandlerArn { get; set; }
}

/// <summary>Describes a Sync configuration for a resolver. See Sync Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProviderSyncConfig
{
    /// <summary>Conflict Detection strategy to use. Valid values are NONE and VERSION.</summary>
    [JsonPropertyName("conflictDetection")]
    public string? ConflictDetection { get; set; }

    /// <summary>Conflict Resolution strategy to perform in the event of a conflict. Valid values are NONE, OPTIMISTIC_CONCURRENCY, AUTOMERGE, and LAMBDA.</summary>
    [JsonPropertyName("conflictHandler")]
    public string? ConflictHandler { get; set; }

    /// <summary>Lambda Conflict Handler Config when configuring LAMBDA as the Conflict Handler. See Lambda Conflict Handler Config.</summary>
    [JsonPropertyName("lambdaConflictHandlerConfig")]
    public V1beta2ResolverSpecForProviderSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecForProvider
{
    /// <summary>API ID for the GraphQL API.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>Reference to a GraphQLAPI in appsync to populate apiId.</summary>
    [JsonPropertyName("apiIdRef")]
    public V1beta2ResolverSpecForProviderApiIdRef? ApiIdRef { get; set; }

    /// <summary>Selector for a GraphQLAPI in appsync to populate apiId.</summary>
    [JsonPropertyName("apiIdSelector")]
    public V1beta2ResolverSpecForProviderApiIdSelector? ApiIdSelector { get; set; }

    /// <summary>The Caching Config. See Caching Config.</summary>
    [JsonPropertyName("cachingConfig")]
    public V1beta2ResolverSpecForProviderCachingConfig? CachingConfig { get; set; }

    /// <summary>The function code that contains the request and response functions. When code is used, the runtime is required. The runtime value must be APPSYNC_JS.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Data source name.</summary>
    [JsonPropertyName("dataSource")]
    public string? DataSource { get; set; }

    /// <summary>Reference to a Datasource in appsync to populate dataSource.</summary>
    [JsonPropertyName("dataSourceRef")]
    public V1beta2ResolverSpecForProviderDataSourceRef? DataSourceRef { get; set; }

    /// <summary>Selector for a Datasource in appsync to populate dataSource.</summary>
    [JsonPropertyName("dataSourceSelector")]
    public V1beta2ResolverSpecForProviderDataSourceSelector? DataSourceSelector { get; set; }

    /// <summary>Field name from the schema defined in the GraphQL API.</summary>
    [JsonPropertyName("field")]
    public required string Field { get; set; }

    /// <summary>Resolver type. Valid values are UNIT and PIPELINE.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Maximum batching size for a resolver. Valid values are between 0 and 2000.</summary>
    [JsonPropertyName("maxBatchSize")]
    public double? MaxBatchSize { get; set; }

    /// <summary>The caching configuration for the resolver. See Pipeline Config.</summary>
    [JsonPropertyName("pipelineConfig")]
    public V1beta2ResolverSpecForProviderPipelineConfig? PipelineConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Request mapping template for UNIT resolver or &apos;before mapping template&apos; for PIPELINE resolver. Required for non-Lambda resolvers.</summary>
    [JsonPropertyName("requestTemplate")]
    public string? RequestTemplate { get; set; }

    /// <summary>Response mapping template for UNIT resolver or &apos;after mapping template&apos; for PIPELINE resolver. Required for non-Lambda resolvers.</summary>
    [JsonPropertyName("responseTemplate")]
    public string? ResponseTemplate { get; set; }

    /// <summary>Describes a runtime used by an AWS AppSync pipeline resolver or AWS AppSync function. Specifies the name and version of the runtime to use. Note that if a runtime is specified, code must also be specified. See Runtime.</summary>
    [JsonPropertyName("runtime")]
    public V1beta2ResolverSpecForProviderRuntime? Runtime { get; set; }

    /// <summary>Describes a Sync configuration for a resolver. See Sync Config.</summary>
    [JsonPropertyName("syncConfig")]
    public V1beta2ResolverSpecForProviderSyncConfig? SyncConfig { get; set; }

    /// <summary>Type name from the schema defined in the GraphQL API.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>The Caching Config. See Caching Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderCachingConfig
{
    /// <summary>The caching keys for a resolver that has caching activated. Valid values are entries from the $context.arguments, $context.source, and $context.identity maps.</summary>
    [JsonPropertyName("cachingKeys")]
    public IList<string>? CachingKeys { get; set; }

    /// <summary>The TTL in seconds for a resolver that has caching activated. Valid values are between 1 and 3600 seconds.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecInitProviderDataSourceRefPolicyResolutionEnum>))]
public enum V1beta2ResolverSpecInitProviderDataSourceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecInitProviderDataSourceRefPolicyResolveEnum>))]
public enum V1beta2ResolverSpecInitProviderDataSourceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderDataSourceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResolverSpecInitProviderDataSourceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResolverSpecInitProviderDataSourceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Datasource in appsync to populate dataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderDataSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResolverSpecInitProviderDataSourceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecInitProviderDataSourceSelectorPolicyResolutionEnum>))]
public enum V1beta2ResolverSpecInitProviderDataSourceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecInitProviderDataSourceSelectorPolicyResolveEnum>))]
public enum V1beta2ResolverSpecInitProviderDataSourceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderDataSourceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResolverSpecInitProviderDataSourceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResolverSpecInitProviderDataSourceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Datasource in appsync to populate dataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderDataSourceSelector
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
    public V1beta2ResolverSpecInitProviderDataSourceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecInitProviderPipelineConfigFunctionsRefsPolicyResolutionEnum>))]
public enum V1beta2ResolverSpecInitProviderPipelineConfigFunctionsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecInitProviderPipelineConfigFunctionsRefsPolicyResolveEnum>))]
public enum V1beta2ResolverSpecInitProviderPipelineConfigFunctionsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderPipelineConfigFunctionsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResolverSpecInitProviderPipelineConfigFunctionsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResolverSpecInitProviderPipelineConfigFunctionsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderPipelineConfigFunctionsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResolverSpecInitProviderPipelineConfigFunctionsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecInitProviderPipelineConfigFunctionsSelectorPolicyResolutionEnum>))]
public enum V1beta2ResolverSpecInitProviderPipelineConfigFunctionsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecInitProviderPipelineConfigFunctionsSelectorPolicyResolveEnum>))]
public enum V1beta2ResolverSpecInitProviderPipelineConfigFunctionsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderPipelineConfigFunctionsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResolverSpecInitProviderPipelineConfigFunctionsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResolverSpecInitProviderPipelineConfigFunctionsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Function in appsync to populate functions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderPipelineConfigFunctionsSelector
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
    public V1beta2ResolverSpecInitProviderPipelineConfigFunctionsSelectorPolicy? Policy { get; set; }
}

/// <summary>The caching configuration for the resolver. See Pipeline Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderPipelineConfig
{
    /// <summary>A list of Function objects.</summary>
    [JsonPropertyName("functions")]
    public IList<string>? Functions { get; set; }

    /// <summary>References to Function in appsync to populate functions.</summary>
    [JsonPropertyName("functionsRefs")]
    public IList<V1beta2ResolverSpecInitProviderPipelineConfigFunctionsRefs>? FunctionsRefs { get; set; }

    /// <summary>Selector for a list of Function in appsync to populate functions.</summary>
    [JsonPropertyName("functionsSelector")]
    public V1beta2ResolverSpecInitProviderPipelineConfigFunctionsSelector? FunctionsSelector { get; set; }
}

/// <summary>Describes a runtime used by an AWS AppSync pipeline resolver or AWS AppSync function. Specifies the name and version of the runtime to use. Note that if a runtime is specified, code must also be specified. See Runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderRuntime
{
    /// <summary>The name of the runtime to use. Currently, the only allowed value is APPSYNC_JS.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The version of the runtime to use. Currently, the only allowed version is 1.0.0.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>Lambda Conflict Handler Config when configuring LAMBDA as the Conflict Handler. See Lambda Conflict Handler Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderSyncConfigLambdaConflictHandlerConfig
{
    /// <summary>ARN for the Lambda function to use as the Conflict Handler.</summary>
    [JsonPropertyName("lambdaConflictHandlerArn")]
    public string? LambdaConflictHandlerArn { get; set; }
}

/// <summary>Describes a Sync configuration for a resolver. See Sync Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecInitProviderSyncConfig
{
    /// <summary>Conflict Detection strategy to use. Valid values are NONE and VERSION.</summary>
    [JsonPropertyName("conflictDetection")]
    public string? ConflictDetection { get; set; }

    /// <summary>Conflict Resolution strategy to perform in the event of a conflict. Valid values are NONE, OPTIMISTIC_CONCURRENCY, AUTOMERGE, and LAMBDA.</summary>
    [JsonPropertyName("conflictHandler")]
    public string? ConflictHandler { get; set; }

    /// <summary>Lambda Conflict Handler Config when configuring LAMBDA as the Conflict Handler. See Lambda Conflict Handler Config.</summary>
    [JsonPropertyName("lambdaConflictHandlerConfig")]
    public V1beta2ResolverSpecInitProviderSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfig { get; set; }
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
public partial class V1beta2ResolverSpecInitProvider
{
    /// <summary>The Caching Config. See Caching Config.</summary>
    [JsonPropertyName("cachingConfig")]
    public V1beta2ResolverSpecInitProviderCachingConfig? CachingConfig { get; set; }

    /// <summary>The function code that contains the request and response functions. When code is used, the runtime is required. The runtime value must be APPSYNC_JS.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Data source name.</summary>
    [JsonPropertyName("dataSource")]
    public string? DataSource { get; set; }

    /// <summary>Reference to a Datasource in appsync to populate dataSource.</summary>
    [JsonPropertyName("dataSourceRef")]
    public V1beta2ResolverSpecInitProviderDataSourceRef? DataSourceRef { get; set; }

    /// <summary>Selector for a Datasource in appsync to populate dataSource.</summary>
    [JsonPropertyName("dataSourceSelector")]
    public V1beta2ResolverSpecInitProviderDataSourceSelector? DataSourceSelector { get; set; }

    /// <summary>Resolver type. Valid values are UNIT and PIPELINE.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Maximum batching size for a resolver. Valid values are between 0 and 2000.</summary>
    [JsonPropertyName("maxBatchSize")]
    public double? MaxBatchSize { get; set; }

    /// <summary>The caching configuration for the resolver. See Pipeline Config.</summary>
    [JsonPropertyName("pipelineConfig")]
    public V1beta2ResolverSpecInitProviderPipelineConfig? PipelineConfig { get; set; }

    /// <summary>Request mapping template for UNIT resolver or &apos;before mapping template&apos; for PIPELINE resolver. Required for non-Lambda resolvers.</summary>
    [JsonPropertyName("requestTemplate")]
    public string? RequestTemplate { get; set; }

    /// <summary>Response mapping template for UNIT resolver or &apos;after mapping template&apos; for PIPELINE resolver. Required for non-Lambda resolvers.</summary>
    [JsonPropertyName("responseTemplate")]
    public string? ResponseTemplate { get; set; }

    /// <summary>Describes a runtime used by an AWS AppSync pipeline resolver or AWS AppSync function. Specifies the name and version of the runtime to use. Note that if a runtime is specified, code must also be specified. See Runtime.</summary>
    [JsonPropertyName("runtime")]
    public V1beta2ResolverSpecInitProviderRuntime? Runtime { get; set; }

    /// <summary>Describes a Sync configuration for a resolver. See Sync Config.</summary>
    [JsonPropertyName("syncConfig")]
    public V1beta2ResolverSpecInitProviderSyncConfig? SyncConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecManagementPoliciesEnum>))]
public enum V1beta2ResolverSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ResolverSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResolverSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ResolverSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResolverSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResolverSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResolverSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ResolverSpec defines the desired state of Resolver</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverSpec
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
    public V1beta2ResolverSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ResolverSpecForProvider ForProvider { get; set; }

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
    public V1beta2ResolverSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ResolverSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ResolverSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ResolverSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The Caching Config. See Caching Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverStatusAtProviderCachingConfig
{
    /// <summary>The caching keys for a resolver that has caching activated. Valid values are entries from the $context.arguments, $context.source, and $context.identity maps.</summary>
    [JsonPropertyName("cachingKeys")]
    public IList<string>? CachingKeys { get; set; }

    /// <summary>The TTL in seconds for a resolver that has caching activated. Valid values are between 1 and 3600 seconds.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }
}

/// <summary>The caching configuration for the resolver. See Pipeline Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverStatusAtProviderPipelineConfig
{
    /// <summary>A list of Function objects.</summary>
    [JsonPropertyName("functions")]
    public IList<string>? Functions { get; set; }
}

/// <summary>Describes a runtime used by an AWS AppSync pipeline resolver or AWS AppSync function. Specifies the name and version of the runtime to use. Note that if a runtime is specified, code must also be specified. See Runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverStatusAtProviderRuntime
{
    /// <summary>The name of the runtime to use. Currently, the only allowed value is APPSYNC_JS.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The version of the runtime to use. Currently, the only allowed version is 1.0.0.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>Lambda Conflict Handler Config when configuring LAMBDA as the Conflict Handler. See Lambda Conflict Handler Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverStatusAtProviderSyncConfigLambdaConflictHandlerConfig
{
    /// <summary>ARN for the Lambda function to use as the Conflict Handler.</summary>
    [JsonPropertyName("lambdaConflictHandlerArn")]
    public string? LambdaConflictHandlerArn { get; set; }
}

/// <summary>Describes a Sync configuration for a resolver. See Sync Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverStatusAtProviderSyncConfig
{
    /// <summary>Conflict Detection strategy to use. Valid values are NONE and VERSION.</summary>
    [JsonPropertyName("conflictDetection")]
    public string? ConflictDetection { get; set; }

    /// <summary>Conflict Resolution strategy to perform in the event of a conflict. Valid values are NONE, OPTIMISTIC_CONCURRENCY, AUTOMERGE, and LAMBDA.</summary>
    [JsonPropertyName("conflictHandler")]
    public string? ConflictHandler { get; set; }

    /// <summary>Lambda Conflict Handler Config when configuring LAMBDA as the Conflict Handler. See Lambda Conflict Handler Config.</summary>
    [JsonPropertyName("lambdaConflictHandlerConfig")]
    public V1beta2ResolverStatusAtProviderSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverStatusAtProvider
{
    /// <summary>API ID for the GraphQL API.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>ARN</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The Caching Config. See Caching Config.</summary>
    [JsonPropertyName("cachingConfig")]
    public V1beta2ResolverStatusAtProviderCachingConfig? CachingConfig { get; set; }

    /// <summary>The function code that contains the request and response functions. When code is used, the runtime is required. The runtime value must be APPSYNC_JS.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Data source name.</summary>
    [JsonPropertyName("dataSource")]
    public string? DataSource { get; set; }

    /// <summary>Field name from the schema defined in the GraphQL API.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Resolver type. Valid values are UNIT and PIPELINE.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Maximum batching size for a resolver. Valid values are between 0 and 2000.</summary>
    [JsonPropertyName("maxBatchSize")]
    public double? MaxBatchSize { get; set; }

    /// <summary>The caching configuration for the resolver. See Pipeline Config.</summary>
    [JsonPropertyName("pipelineConfig")]
    public V1beta2ResolverStatusAtProviderPipelineConfig? PipelineConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Request mapping template for UNIT resolver or &apos;before mapping template&apos; for PIPELINE resolver. Required for non-Lambda resolvers.</summary>
    [JsonPropertyName("requestTemplate")]
    public string? RequestTemplate { get; set; }

    /// <summary>Response mapping template for UNIT resolver or &apos;after mapping template&apos; for PIPELINE resolver. Required for non-Lambda resolvers.</summary>
    [JsonPropertyName("responseTemplate")]
    public string? ResponseTemplate { get; set; }

    /// <summary>Describes a runtime used by an AWS AppSync pipeline resolver or AWS AppSync function. Specifies the name and version of the runtime to use. Note that if a runtime is specified, code must also be specified. See Runtime.</summary>
    [JsonPropertyName("runtime")]
    public V1beta2ResolverStatusAtProviderRuntime? Runtime { get; set; }

    /// <summary>Describes a Sync configuration for a resolver. See Sync Config.</summary>
    [JsonPropertyName("syncConfig")]
    public V1beta2ResolverStatusAtProviderSyncConfig? SyncConfig { get; set; }

    /// <summary>Type name from the schema defined in the GraphQL API.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverStatusConditions
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

/// <summary>ResolverStatus defines the observed state of Resolver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResolverStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ResolverStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ResolverStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Resolver is the Schema for the Resolvers API. Provides an AppSync Resolver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Resolver : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ResolverSpec>, IStatus<V1beta2ResolverStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Resolver";
    public const string KubeGroup = "appsync.aws.upbound.io";
    public const string KubePluralName = "resolvers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appsync.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Resolver";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResolverSpec defines the desired state of Resolver</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ResolverSpec Spec { get; set; }

    /// <summary>ResolverStatus defines the observed state of Resolver.</summary>
    [JsonPropertyName("status")]
    public V1beta2ResolverStatus? Status { get; set; }
}