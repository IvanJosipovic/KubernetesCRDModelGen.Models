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
/// <summary>RouterNAT is the Schema for the RouterNATs API. A NAT service created in a router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RouterNATList : IKubernetesObject<V1ListMeta>, IItems<V1beta2RouterNAT>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RouterNATList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "routernats";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RouterNATList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2RouterNAT objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2RouterNAT> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecDeletionPolicyEnum>))]
public enum V1beta2RouterNATSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Configuration for logging on NAT
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderLogConfig
{
    /// <summary>Indicates whether or not to export logs.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>
    /// Specifies the desired filtering of logs on this NAT.
    /// Possible values are: ERRORS_ONLY, TRANSLATIONS_ONLY, ALL.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderNat64Subnetwork
{
    /// <summary>Self-link of the subnetwork resource that will use NAT64</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderNatIpsRefsPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecForProviderNatIpsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderNatIpsRefsPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecForProviderNatIpsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderNatIpsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecForProviderNatIpsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecForProviderNatIpsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderNatIpsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouterNATSpecForProviderNatIpsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderNatIpsSelectorPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecForProviderNatIpsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderNatIpsSelectorPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecForProviderNatIpsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderNatIpsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecForProviderNatIpsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecForProviderNatIpsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Address in compute to populate natIps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderNatIpsSelector
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
    public V1beta2RouterNATSpecForProviderNatIpsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderRouterRefPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecForProviderRouterRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderRouterRefPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecForProviderRouterRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRouterRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecForProviderRouterRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecForProviderRouterRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Router in compute to populate router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRouterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouterNATSpecForProviderRouterRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderRouterSelectorPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecForProviderRouterSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderRouterSelectorPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecForProviderRouterSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRouterSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecForProviderRouterSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecForProviderRouterSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Router in compute to populate router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRouterSelector
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
    public V1beta2RouterNATSpecForProviderRouterSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsRefsPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsRefsPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsSelectorPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsSelectorPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Address in compute to populate sourceNatActiveIps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsSelector
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
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesRefsPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesRefsPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesSelectorPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesSelectorPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnetwork in compute to populate sourceNatActiveRanges.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesSelector
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
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The action to be enforced for traffic that matches this rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRulesAction
{
    /// <summary>
    /// A list of URLs of the IP resources used for this NAT rule.
    /// These IP addresses must be valid static external IP addresses assigned to the project.
    /// This field is used for public NAT.
    /// </summary>
    [JsonPropertyName("sourceNatActiveIps")]
    public IList<string>? SourceNatActiveIps { get; set; }

    /// <summary>References to Address in compute to populate sourceNatActiveIps.</summary>
    [JsonPropertyName("sourceNatActiveIpsRefs")]
    public IList<V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsRefs>? SourceNatActiveIpsRefs { get; set; }

    /// <summary>Selector for a list of Address in compute to populate sourceNatActiveIps.</summary>
    [JsonPropertyName("sourceNatActiveIpsSelector")]
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveIpsSelector? SourceNatActiveIpsSelector { get; set; }

    /// <summary>
    /// A list of URLs of the subnetworks used as source ranges for this NAT Rule.
    /// These subnetworks must have purpose set to PRIVATE_NAT.
    /// This field is used for private NAT.
    /// </summary>
    [JsonPropertyName("sourceNatActiveRanges")]
    public IList<string>? SourceNatActiveRanges { get; set; }

    /// <summary>References to Subnetwork in compute to populate sourceNatActiveRanges.</summary>
    [JsonPropertyName("sourceNatActiveRangesRefs")]
    public IList<V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesRefs>? SourceNatActiveRangesRefs { get; set; }

    /// <summary>Selector for a list of Subnetwork in compute to populate sourceNatActiveRanges.</summary>
    [JsonPropertyName("sourceNatActiveRangesSelector")]
    public V1beta2RouterNATSpecForProviderRulesActionSourceNatActiveRangesSelector? SourceNatActiveRangesSelector { get; set; }

    /// <summary>
    /// A list of URLs of the IP resources to be drained.
    /// These IPs must be valid static external IPs that have been assigned to the NAT.
    /// These IPs should be used for updating/patching a NAT rule only.
    /// This field is used for public NAT.
    /// </summary>
    [JsonPropertyName("sourceNatDrainIps")]
    public IList<string>? SourceNatDrainIps { get; set; }

    /// <summary>
    /// A list of URLs of subnetworks representing source ranges to be drained.
    /// This is only supported on patch/update, and these subnetworks must have previously been used as active ranges in this NAT Rule.
    /// This field is used for private NAT.
    /// </summary>
    [JsonPropertyName("sourceNatDrainRanges")]
    public IList<string>? SourceNatDrainRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderRules
{
    /// <summary>
    /// The action to be enforced for traffic that matches this rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("action")]
    public V1beta2RouterNATSpecForProviderRulesAction? Action { get; set; }

    /// <summary>An optional description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// CEL expression that specifies the match condition that egress traffic from a VM is evaluated against.
    /// If it evaluates to true, the corresponding action is enforced.
    /// The following examples are valid match expressions for public NAT:
    /// &quot;inIpRange(destination.ip, &apos;1.1.0.0/16&apos;) || inIpRange(destination.ip, &apos;2.2.0.0/16&apos;)&quot;
    /// &quot;destination.ip == &apos;1.1.0.1&apos; || destination.ip == &apos;8.8.8.8&apos; &quot;
    /// The following example is a valid match expression for private NAT:
    /// &quot;nexthop.hub == &apos;https://networkconnectivity.googleapis.com/v1alpha1/projects/my-project/global/hub/hub-1&apos; &quot;
    /// </summary>
    [JsonPropertyName("match")]
    public string? Match { get; set; }

    /// <summary>
    /// An integer uniquely identifying a rule in the list.
    /// The rule number must be a positive value between 0 and 65000, and must be unique among rules within a NAT.
    /// </summary>
    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderSubnetworkNameRefPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecForProviderSubnetworkNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderSubnetworkNameRefPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecForProviderSubnetworkNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderSubnetworkNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecForProviderSubnetworkNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecForProviderSubnetworkNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderSubnetworkNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouterNATSpecForProviderSubnetworkNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderSubnetworkNameSelectorPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecForProviderSubnetworkNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecForProviderSubnetworkNameSelectorPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecForProviderSubnetworkNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderSubnetworkNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecForProviderSubnetworkNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecForProviderSubnetworkNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderSubnetworkNameSelector
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
    public V1beta2RouterNATSpecForProviderSubnetworkNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProviderSubnetwork
{
    /// <summary>Self-link of subnetwork to NAT</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2RouterNATSpecForProviderSubnetworkNameRef? NameRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2RouterNATSpecForProviderSubnetworkNameSelector? NameSelector { get; set; }

    /// <summary>
    /// List of the secondary ranges of the subnetwork that are allowed
    /// to use NAT. This can be populated only if
    /// LIST_OF_SECONDARY_IP_RANGES is one of the values in
    /// sourceIpRangesToNat
    /// </summary>
    [JsonPropertyName("secondaryIpRangeNames")]
    public IList<string>? SecondaryIpRangeNames { get; set; }

    /// <summary>
    /// List of options for which source IPs in the subnetwork
    /// should have NAT enabled. Supported values include:
    /// ALL_IP_RANGES, LIST_OF_SECONDARY_IP_RANGES,
    /// PRIMARY_IP_RANGE.
    /// </summary>
    [JsonPropertyName("sourceIpRangesToNat")]
    public IList<string>? SourceIpRangesToNat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecForProvider
{
    /// <summary>
    /// The network tier to use when automatically reserving NAT IP addresses.
    /// Must be one of: PREMIUM, STANDARD. If not specified, then the current
    /// project-level default tier is used.
    /// Possible values are: PREMIUM, STANDARD.
    /// </summary>
    [JsonPropertyName("autoNetworkTier")]
    public string? AutoNetworkTier { get; set; }

    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    [JsonPropertyName("drainNatIps")]
    public IList<string>? DrainNatIps { get; set; }

    /// <summary>
    /// Enable Dynamic Port Allocation.
    /// If minPortsPerVm is set, minPortsPerVm must be set to a power of two greater than or equal to 32.
    /// If minPortsPerVm is not set, a minimum of 32 ports will be allocated to a VM from this NAT config.
    /// If maxPortsPerVm is set, maxPortsPerVm must be set to a power of two greater than minPortsPerVm.
    /// If maxPortsPerVm is not set, a maximum of 65536 ports will be allocated to a VM from this NAT config.
    /// Mutually exclusive with enableEndpointIndependentMapping.
    /// </summary>
    [JsonPropertyName("enableDynamicPortAllocation")]
    public bool? EnableDynamicPortAllocation { get; set; }

    /// <summary>
    /// Enable endpoint independent mapping.
    /// For more information see the official documentation.
    /// </summary>
    [JsonPropertyName("enableEndpointIndependentMapping")]
    public bool? EnableEndpointIndependentMapping { get; set; }

    /// <summary>
    /// Specifies the endpoint Types supported by the NAT Gateway.
    /// Supported values include:
    /// ENDPOINT_TYPE_VM, ENDPOINT_TYPE_SWG,
    /// ENDPOINT_TYPE_MANAGED_PROXY_LB.
    /// </summary>
    [JsonPropertyName("endpointTypes")]
    public IList<string>? EndpointTypes { get; set; }

    /// <summary>Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("icmpIdleTimeoutSec")]
    public double? IcmpIdleTimeoutSec { get; set; }

    /// <summary>
    /// Self-links of NAT IPs to be used as initial value for creation alongside a RouterNatAddress resource.
    /// Conflicts with natIps and drainNatIps. Only valid if natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    [JsonPropertyName("initialNatIps")]
    public IList<string>? InitialNatIps { get; set; }

    /// <summary>
    /// Configuration for logging on NAT
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2RouterNATSpecForProviderLogConfig? LogConfig { get; set; }

    /// <summary>
    /// Maximum number of ports allocated to a VM from this NAT.
    /// This field can only be set when enableDynamicPortAllocation is enabled.
    /// </summary>
    [JsonPropertyName("maxPortsPerVm")]
    public double? MaxPortsPerVm { get; set; }

    /// <summary>Minimum number of ports allocated to a VM from this NAT. Defaults to 64 for static port allocation and 32 dynamic port allocation if not set.</summary>
    [JsonPropertyName("minPortsPerVm")]
    public double? MinPortsPerVm { get; set; }

    /// <summary>
    /// One or more subnetwork NAT configurations whose traffic should be translated by NAT64 Gateway.
    /// Only used if source_subnetwork_ip_ranges_to_nat64 is set to LIST_OF_IPV6_SUBNETWORKS
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nat64Subnetwork")]
    public IList<V1beta2RouterNATSpecForProviderNat64Subnetwork>? Nat64Subnetwork { get; set; }

    /// <summary>
    /// How external IPs should be allocated for this NAT. Valid values are
    /// AUTO_ONLY for only allowing NAT IPs allocated by Google Cloud
    /// Platform, or MANUAL_ONLY for only user-allocated NAT IP addresses.
    /// Possible values are: MANUAL_ONLY, AUTO_ONLY.
    /// </summary>
    [JsonPropertyName("natIpAllocateOption")]
    public string? NatIpAllocateOption { get; set; }

    /// <summary>
    /// Self-links of NAT IPs. Only valid if natIpAllocateOption
    /// is set to MANUAL_ONLY.
    /// If this field is used alongside with a count created list of address resources google_compute_address.foobar.*.self_link,
    /// the access level resource for the address resource must have a lifecycle block with create_before_destroy = true so
    /// the number of resources can be increased/decreased without triggering the resourceInUseByAnotherResource error.
    /// </summary>
    [JsonPropertyName("natIps")]
    public IList<string>? NatIps { get; set; }

    /// <summary>References to Address in compute to populate natIps.</summary>
    [JsonPropertyName("natIpsRefs")]
    public IList<V1beta2RouterNATSpecForProviderNatIpsRefs>? NatIpsRefs { get; set; }

    /// <summary>Selector for a list of Address in compute to populate natIps.</summary>
    [JsonPropertyName("natIpsSelector")]
    public V1beta2RouterNATSpecForProviderNatIpsSelector? NatIpsSelector { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where the router and NAT reside.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The name of the Cloud Router in which this NAT will be configured.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>Reference to a Router in compute to populate router.</summary>
    [JsonPropertyName("routerRef")]
    public V1beta2RouterNATSpecForProviderRouterRef? RouterRef { get; set; }

    /// <summary>Selector for a Router in compute to populate router.</summary>
    [JsonPropertyName("routerSelector")]
    public V1beta2RouterNATSpecForProviderRouterSelector? RouterSelector { get; set; }

    /// <summary>
    /// A list of rules associated with this NAT.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta2RouterNATSpecForProviderRules>? Rules { get; set; }

    /// <summary>
    /// How NAT should be configured per Subnetwork.
    /// If ALL_SUBNETWORKS_ALL_IP_RANGES, all of the
    /// IP ranges in every Subnetwork are allowed to Nat.
    /// If ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, all of the primary IP
    /// ranges in every Subnetwork are allowed to Nat.
    /// LIST_OF_SUBNETWORKS: A list of Subnetworks are allowed to Nat
    /// (specified in the field subnetwork below). Note that if this field
    /// contains ALL_SUBNETWORKS_ALL_IP_RANGES or
    /// ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, then there should not be any
    /// other RouterNat section in any Router for this network in this region.
    /// Possible values are: ALL_SUBNETWORKS_ALL_IP_RANGES, ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, LIST_OF_SUBNETWORKS.
    /// </summary>
    [JsonPropertyName("sourceSubnetworkIpRangesToNat")]
    public string? SourceSubnetworkIpRangesToNat { get; set; }

    /// <summary>
    /// Specify the Nat option for NAT64, which can take one of the following values:
    /// ALL_IPV6_SUBNETWORKS: All of the IP ranges in every Subnetwork are allowed to Nat.
    /// LIST_OF_IPV6_SUBNETWORKS: A list of Subnetworks are allowed to Nat (specified in the field nat64Subnetwork below).
    /// Note that if this field contains NAT64_ALL_V6_SUBNETWORKS no other Router.Nat section in this region can also enable NAT64 for any Subnetworks in this network.
    /// Other Router.Nat sections can still be present to enable NAT44 only.
    /// Possible values are: ALL_IPV6_SUBNETWORKS, LIST_OF_IPV6_SUBNETWORKS.
    /// </summary>
    [JsonPropertyName("sourceSubnetworkIpRangesToNat64")]
    public string? SourceSubnetworkIpRangesToNat64 { get; set; }

    /// <summary>
    /// One or more subnetwork NAT configurations. Only used if
    /// source_subnetwork_ip_ranges_to_nat is set to LIST_OF_SUBNETWORKS
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public IList<V1beta2RouterNATSpecForProviderSubnetwork>? Subnetwork { get; set; }

    /// <summary>
    /// Timeout (in seconds) for TCP established connections.
    /// Defaults to 1200s if not set.
    /// </summary>
    [JsonPropertyName("tcpEstablishedIdleTimeoutSec")]
    public double? TcpEstablishedIdleTimeoutSec { get; set; }

    /// <summary>
    /// Timeout (in seconds) for TCP connections that are in TIME_WAIT state.
    /// Defaults to 120s if not set.
    /// </summary>
    [JsonPropertyName("tcpTimeWaitTimeoutSec")]
    public double? TcpTimeWaitTimeoutSec { get; set; }

    /// <summary>
    /// Timeout (in seconds) for TCP transitory connections.
    /// Defaults to 30s if not set.
    /// </summary>
    [JsonPropertyName("tcpTransitoryIdleTimeoutSec")]
    public double? TcpTransitoryIdleTimeoutSec { get; set; }

    /// <summary>
    /// Indicates whether this NAT is used for public or private IP translation.
    /// If unspecified, it defaults to PUBLIC.
    /// If PUBLIC NAT used for public IP translation.
    /// If PRIVATE NAT used for private IP translation.
    /// Default value is PUBLIC.
    /// Possible values are: PUBLIC, PRIVATE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Timeout (in seconds) for UDP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("udpIdleTimeoutSec")]
    public double? UdpIdleTimeoutSec { get; set; }
}

/// <summary>
/// Configuration for logging on NAT
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderLogConfig
{
    /// <summary>Indicates whether or not to export logs.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>
    /// Specifies the desired filtering of logs on this NAT.
    /// Possible values are: ERRORS_ONLY, TRANSLATIONS_ONLY, ALL.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderNat64Subnetwork
{
    /// <summary>Self-link of the subnetwork resource that will use NAT64</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderNatIpsRefsPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecInitProviderNatIpsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderNatIpsRefsPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecInitProviderNatIpsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderNatIpsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecInitProviderNatIpsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecInitProviderNatIpsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderNatIpsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouterNATSpecInitProviderNatIpsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderNatIpsSelectorPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecInitProviderNatIpsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderNatIpsSelectorPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecInitProviderNatIpsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderNatIpsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecInitProviderNatIpsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecInitProviderNatIpsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Address in compute to populate natIps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderNatIpsSelector
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
    public V1beta2RouterNATSpecInitProviderNatIpsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsRefsPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsRefsPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsSelectorPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsSelectorPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Address in compute to populate sourceNatActiveIps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsSelector
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
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesRefsPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesRefsPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesSelectorPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesSelectorPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnetwork in compute to populate sourceNatActiveRanges.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesSelector
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
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The action to be enforced for traffic that matches this rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderRulesAction
{
    /// <summary>
    /// A list of URLs of the IP resources used for this NAT rule.
    /// These IP addresses must be valid static external IP addresses assigned to the project.
    /// This field is used for public NAT.
    /// </summary>
    [JsonPropertyName("sourceNatActiveIps")]
    public IList<string>? SourceNatActiveIps { get; set; }

    /// <summary>References to Address in compute to populate sourceNatActiveIps.</summary>
    [JsonPropertyName("sourceNatActiveIpsRefs")]
    public IList<V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsRefs>? SourceNatActiveIpsRefs { get; set; }

    /// <summary>Selector for a list of Address in compute to populate sourceNatActiveIps.</summary>
    [JsonPropertyName("sourceNatActiveIpsSelector")]
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveIpsSelector? SourceNatActiveIpsSelector { get; set; }

    /// <summary>
    /// A list of URLs of the subnetworks used as source ranges for this NAT Rule.
    /// These subnetworks must have purpose set to PRIVATE_NAT.
    /// This field is used for private NAT.
    /// </summary>
    [JsonPropertyName("sourceNatActiveRanges")]
    public IList<string>? SourceNatActiveRanges { get; set; }

    /// <summary>References to Subnetwork in compute to populate sourceNatActiveRanges.</summary>
    [JsonPropertyName("sourceNatActiveRangesRefs")]
    public IList<V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesRefs>? SourceNatActiveRangesRefs { get; set; }

    /// <summary>Selector for a list of Subnetwork in compute to populate sourceNatActiveRanges.</summary>
    [JsonPropertyName("sourceNatActiveRangesSelector")]
    public V1beta2RouterNATSpecInitProviderRulesActionSourceNatActiveRangesSelector? SourceNatActiveRangesSelector { get; set; }

    /// <summary>
    /// A list of URLs of the IP resources to be drained.
    /// These IPs must be valid static external IPs that have been assigned to the NAT.
    /// These IPs should be used for updating/patching a NAT rule only.
    /// This field is used for public NAT.
    /// </summary>
    [JsonPropertyName("sourceNatDrainIps")]
    public IList<string>? SourceNatDrainIps { get; set; }

    /// <summary>
    /// A list of URLs of subnetworks representing source ranges to be drained.
    /// This is only supported on patch/update, and these subnetworks must have previously been used as active ranges in this NAT Rule.
    /// This field is used for private NAT.
    /// </summary>
    [JsonPropertyName("sourceNatDrainRanges")]
    public IList<string>? SourceNatDrainRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderRules
{
    /// <summary>
    /// The action to be enforced for traffic that matches this rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("action")]
    public V1beta2RouterNATSpecInitProviderRulesAction? Action { get; set; }

    /// <summary>An optional description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// CEL expression that specifies the match condition that egress traffic from a VM is evaluated against.
    /// If it evaluates to true, the corresponding action is enforced.
    /// The following examples are valid match expressions for public NAT:
    /// &quot;inIpRange(destination.ip, &apos;1.1.0.0/16&apos;) || inIpRange(destination.ip, &apos;2.2.0.0/16&apos;)&quot;
    /// &quot;destination.ip == &apos;1.1.0.1&apos; || destination.ip == &apos;8.8.8.8&apos; &quot;
    /// The following example is a valid match expression for private NAT:
    /// &quot;nexthop.hub == &apos;https://networkconnectivity.googleapis.com/v1alpha1/projects/my-project/global/hub/hub-1&apos; &quot;
    /// </summary>
    [JsonPropertyName("match")]
    public string? Match { get; set; }

    /// <summary>
    /// An integer uniquely identifying a rule in the list.
    /// The rule number must be a positive value between 0 and 65000, and must be unique among rules within a NAT.
    /// </summary>
    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderSubnetworkNameRefPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecInitProviderSubnetworkNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderSubnetworkNameRefPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecInitProviderSubnetworkNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderSubnetworkNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecInitProviderSubnetworkNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecInitProviderSubnetworkNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderSubnetworkNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouterNATSpecInitProviderSubnetworkNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderSubnetworkNameSelectorPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecInitProviderSubnetworkNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecInitProviderSubnetworkNameSelectorPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecInitProviderSubnetworkNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderSubnetworkNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecInitProviderSubnetworkNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecInitProviderSubnetworkNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderSubnetworkNameSelector
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
    public V1beta2RouterNATSpecInitProviderSubnetworkNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecInitProviderSubnetwork
{
    /// <summary>Self-link of subnetwork to NAT</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2RouterNATSpecInitProviderSubnetworkNameRef? NameRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2RouterNATSpecInitProviderSubnetworkNameSelector? NameSelector { get; set; }

    /// <summary>
    /// List of the secondary ranges of the subnetwork that are allowed
    /// to use NAT. This can be populated only if
    /// LIST_OF_SECONDARY_IP_RANGES is one of the values in
    /// sourceIpRangesToNat
    /// </summary>
    [JsonPropertyName("secondaryIpRangeNames")]
    public IList<string>? SecondaryIpRangeNames { get; set; }

    /// <summary>
    /// List of options for which source IPs in the subnetwork
    /// should have NAT enabled. Supported values include:
    /// ALL_IP_RANGES, LIST_OF_SECONDARY_IP_RANGES,
    /// PRIMARY_IP_RANGE.
    /// </summary>
    [JsonPropertyName("sourceIpRangesToNat")]
    public IList<string>? SourceIpRangesToNat { get; set; }
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
public partial class V1beta2RouterNATSpecInitProvider
{
    /// <summary>
    /// The network tier to use when automatically reserving NAT IP addresses.
    /// Must be one of: PREMIUM, STANDARD. If not specified, then the current
    /// project-level default tier is used.
    /// Possible values are: PREMIUM, STANDARD.
    /// </summary>
    [JsonPropertyName("autoNetworkTier")]
    public string? AutoNetworkTier { get; set; }

    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    [JsonPropertyName("drainNatIps")]
    public IList<string>? DrainNatIps { get; set; }

    /// <summary>
    /// Enable Dynamic Port Allocation.
    /// If minPortsPerVm is set, minPortsPerVm must be set to a power of two greater than or equal to 32.
    /// If minPortsPerVm is not set, a minimum of 32 ports will be allocated to a VM from this NAT config.
    /// If maxPortsPerVm is set, maxPortsPerVm must be set to a power of two greater than minPortsPerVm.
    /// If maxPortsPerVm is not set, a maximum of 65536 ports will be allocated to a VM from this NAT config.
    /// Mutually exclusive with enableEndpointIndependentMapping.
    /// </summary>
    [JsonPropertyName("enableDynamicPortAllocation")]
    public bool? EnableDynamicPortAllocation { get; set; }

    /// <summary>
    /// Enable endpoint independent mapping.
    /// For more information see the official documentation.
    /// </summary>
    [JsonPropertyName("enableEndpointIndependentMapping")]
    public bool? EnableEndpointIndependentMapping { get; set; }

    /// <summary>
    /// Specifies the endpoint Types supported by the NAT Gateway.
    /// Supported values include:
    /// ENDPOINT_TYPE_VM, ENDPOINT_TYPE_SWG,
    /// ENDPOINT_TYPE_MANAGED_PROXY_LB.
    /// </summary>
    [JsonPropertyName("endpointTypes")]
    public IList<string>? EndpointTypes { get; set; }

    /// <summary>Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("icmpIdleTimeoutSec")]
    public double? IcmpIdleTimeoutSec { get; set; }

    /// <summary>
    /// Self-links of NAT IPs to be used as initial value for creation alongside a RouterNatAddress resource.
    /// Conflicts with natIps and drainNatIps. Only valid if natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    [JsonPropertyName("initialNatIps")]
    public IList<string>? InitialNatIps { get; set; }

    /// <summary>
    /// Configuration for logging on NAT
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2RouterNATSpecInitProviderLogConfig? LogConfig { get; set; }

    /// <summary>
    /// Maximum number of ports allocated to a VM from this NAT.
    /// This field can only be set when enableDynamicPortAllocation is enabled.
    /// </summary>
    [JsonPropertyName("maxPortsPerVm")]
    public double? MaxPortsPerVm { get; set; }

    /// <summary>Minimum number of ports allocated to a VM from this NAT. Defaults to 64 for static port allocation and 32 dynamic port allocation if not set.</summary>
    [JsonPropertyName("minPortsPerVm")]
    public double? MinPortsPerVm { get; set; }

    /// <summary>
    /// One or more subnetwork NAT configurations whose traffic should be translated by NAT64 Gateway.
    /// Only used if source_subnetwork_ip_ranges_to_nat64 is set to LIST_OF_IPV6_SUBNETWORKS
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nat64Subnetwork")]
    public IList<V1beta2RouterNATSpecInitProviderNat64Subnetwork>? Nat64Subnetwork { get; set; }

    /// <summary>
    /// How external IPs should be allocated for this NAT. Valid values are
    /// AUTO_ONLY for only allowing NAT IPs allocated by Google Cloud
    /// Platform, or MANUAL_ONLY for only user-allocated NAT IP addresses.
    /// Possible values are: MANUAL_ONLY, AUTO_ONLY.
    /// </summary>
    [JsonPropertyName("natIpAllocateOption")]
    public string? NatIpAllocateOption { get; set; }

    /// <summary>
    /// Self-links of NAT IPs. Only valid if natIpAllocateOption
    /// is set to MANUAL_ONLY.
    /// If this field is used alongside with a count created list of address resources google_compute_address.foobar.*.self_link,
    /// the access level resource for the address resource must have a lifecycle block with create_before_destroy = true so
    /// the number of resources can be increased/decreased without triggering the resourceInUseByAnotherResource error.
    /// </summary>
    [JsonPropertyName("natIps")]
    public IList<string>? NatIps { get; set; }

    /// <summary>References to Address in compute to populate natIps.</summary>
    [JsonPropertyName("natIpsRefs")]
    public IList<V1beta2RouterNATSpecInitProviderNatIpsRefs>? NatIpsRefs { get; set; }

    /// <summary>Selector for a list of Address in compute to populate natIps.</summary>
    [JsonPropertyName("natIpsSelector")]
    public V1beta2RouterNATSpecInitProviderNatIpsSelector? NatIpsSelector { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// A list of rules associated with this NAT.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta2RouterNATSpecInitProviderRules>? Rules { get; set; }

    /// <summary>
    /// How NAT should be configured per Subnetwork.
    /// If ALL_SUBNETWORKS_ALL_IP_RANGES, all of the
    /// IP ranges in every Subnetwork are allowed to Nat.
    /// If ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, all of the primary IP
    /// ranges in every Subnetwork are allowed to Nat.
    /// LIST_OF_SUBNETWORKS: A list of Subnetworks are allowed to Nat
    /// (specified in the field subnetwork below). Note that if this field
    /// contains ALL_SUBNETWORKS_ALL_IP_RANGES or
    /// ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, then there should not be any
    /// other RouterNat section in any Router for this network in this region.
    /// Possible values are: ALL_SUBNETWORKS_ALL_IP_RANGES, ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, LIST_OF_SUBNETWORKS.
    /// </summary>
    [JsonPropertyName("sourceSubnetworkIpRangesToNat")]
    public string? SourceSubnetworkIpRangesToNat { get; set; }

    /// <summary>
    /// Specify the Nat option for NAT64, which can take one of the following values:
    /// ALL_IPV6_SUBNETWORKS: All of the IP ranges in every Subnetwork are allowed to Nat.
    /// LIST_OF_IPV6_SUBNETWORKS: A list of Subnetworks are allowed to Nat (specified in the field nat64Subnetwork below).
    /// Note that if this field contains NAT64_ALL_V6_SUBNETWORKS no other Router.Nat section in this region can also enable NAT64 for any Subnetworks in this network.
    /// Other Router.Nat sections can still be present to enable NAT44 only.
    /// Possible values are: ALL_IPV6_SUBNETWORKS, LIST_OF_IPV6_SUBNETWORKS.
    /// </summary>
    [JsonPropertyName("sourceSubnetworkIpRangesToNat64")]
    public string? SourceSubnetworkIpRangesToNat64 { get; set; }

    /// <summary>
    /// One or more subnetwork NAT configurations. Only used if
    /// source_subnetwork_ip_ranges_to_nat is set to LIST_OF_SUBNETWORKS
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public IList<V1beta2RouterNATSpecInitProviderSubnetwork>? Subnetwork { get; set; }

    /// <summary>
    /// Timeout (in seconds) for TCP established connections.
    /// Defaults to 1200s if not set.
    /// </summary>
    [JsonPropertyName("tcpEstablishedIdleTimeoutSec")]
    public double? TcpEstablishedIdleTimeoutSec { get; set; }

    /// <summary>
    /// Timeout (in seconds) for TCP connections that are in TIME_WAIT state.
    /// Defaults to 120s if not set.
    /// </summary>
    [JsonPropertyName("tcpTimeWaitTimeoutSec")]
    public double? TcpTimeWaitTimeoutSec { get; set; }

    /// <summary>
    /// Timeout (in seconds) for TCP transitory connections.
    /// Defaults to 30s if not set.
    /// </summary>
    [JsonPropertyName("tcpTransitoryIdleTimeoutSec")]
    public double? TcpTransitoryIdleTimeoutSec { get; set; }

    /// <summary>
    /// Indicates whether this NAT is used for public or private IP translation.
    /// If unspecified, it defaults to PUBLIC.
    /// If PUBLIC NAT used for public IP translation.
    /// If PRIVATE NAT used for private IP translation.
    /// Default value is PUBLIC.
    /// Possible values are: PUBLIC, PRIVATE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Timeout (in seconds) for UDP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("udpIdleTimeoutSec")]
    public double? UdpIdleTimeoutSec { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecManagementPoliciesEnum>))]
public enum V1beta2RouterNATSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2RouterNATSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouterNATSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2RouterNATSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouterNATSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouterNATSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouterNATSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RouterNATSpec defines the desired state of RouterNAT</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATSpec
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
    public V1beta2RouterNATSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2RouterNATSpecForProvider ForProvider { get; set; }

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
    public V1beta2RouterNATSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2RouterNATSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RouterNATSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RouterNATSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Configuration for logging on NAT
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATStatusAtProviderLogConfig
{
    /// <summary>Indicates whether or not to export logs.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>
    /// Specifies the desired filtering of logs on this NAT.
    /// Possible values are: ERRORS_ONLY, TRANSLATIONS_ONLY, ALL.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATStatusAtProviderNat64Subnetwork
{
    /// <summary>Self-link of the subnetwork resource that will use NAT64</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The action to be enforced for traffic that matches this rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATStatusAtProviderRulesAction
{
    /// <summary>
    /// A list of URLs of the IP resources used for this NAT rule.
    /// These IP addresses must be valid static external IP addresses assigned to the project.
    /// This field is used for public NAT.
    /// </summary>
    [JsonPropertyName("sourceNatActiveIps")]
    public IList<string>? SourceNatActiveIps { get; set; }

    /// <summary>
    /// A list of URLs of the subnetworks used as source ranges for this NAT Rule.
    /// These subnetworks must have purpose set to PRIVATE_NAT.
    /// This field is used for private NAT.
    /// </summary>
    [JsonPropertyName("sourceNatActiveRanges")]
    public IList<string>? SourceNatActiveRanges { get; set; }

    /// <summary>
    /// A list of URLs of the IP resources to be drained.
    /// These IPs must be valid static external IPs that have been assigned to the NAT.
    /// These IPs should be used for updating/patching a NAT rule only.
    /// This field is used for public NAT.
    /// </summary>
    [JsonPropertyName("sourceNatDrainIps")]
    public IList<string>? SourceNatDrainIps { get; set; }

    /// <summary>
    /// A list of URLs of subnetworks representing source ranges to be drained.
    /// This is only supported on patch/update, and these subnetworks must have previously been used as active ranges in this NAT Rule.
    /// This field is used for private NAT.
    /// </summary>
    [JsonPropertyName("sourceNatDrainRanges")]
    public IList<string>? SourceNatDrainRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATStatusAtProviderRules
{
    /// <summary>
    /// The action to be enforced for traffic that matches this rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("action")]
    public V1beta2RouterNATStatusAtProviderRulesAction? Action { get; set; }

    /// <summary>An optional description of this rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// CEL expression that specifies the match condition that egress traffic from a VM is evaluated against.
    /// If it evaluates to true, the corresponding action is enforced.
    /// The following examples are valid match expressions for public NAT:
    /// &quot;inIpRange(destination.ip, &apos;1.1.0.0/16&apos;) || inIpRange(destination.ip, &apos;2.2.0.0/16&apos;)&quot;
    /// &quot;destination.ip == &apos;1.1.0.1&apos; || destination.ip == &apos;8.8.8.8&apos; &quot;
    /// The following example is a valid match expression for private NAT:
    /// &quot;nexthop.hub == &apos;https://networkconnectivity.googleapis.com/v1alpha1/projects/my-project/global/hub/hub-1&apos; &quot;
    /// </summary>
    [JsonPropertyName("match")]
    public string? Match { get; set; }

    /// <summary>
    /// An integer uniquely identifying a rule in the list.
    /// The rule number must be a positive value between 0 and 65000, and must be unique among rules within a NAT.
    /// </summary>
    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATStatusAtProviderSubnetwork
{
    /// <summary>Self-link of subnetwork to NAT</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// List of the secondary ranges of the subnetwork that are allowed
    /// to use NAT. This can be populated only if
    /// LIST_OF_SECONDARY_IP_RANGES is one of the values in
    /// sourceIpRangesToNat
    /// </summary>
    [JsonPropertyName("secondaryIpRangeNames")]
    public IList<string>? SecondaryIpRangeNames { get; set; }

    /// <summary>
    /// List of options for which source IPs in the subnetwork
    /// should have NAT enabled. Supported values include:
    /// ALL_IP_RANGES, LIST_OF_SECONDARY_IP_RANGES,
    /// PRIMARY_IP_RANGE.
    /// </summary>
    [JsonPropertyName("sourceIpRangesToNat")]
    public IList<string>? SourceIpRangesToNat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATStatusAtProvider
{
    /// <summary>
    /// The network tier to use when automatically reserving NAT IP addresses.
    /// Must be one of: PREMIUM, STANDARD. If not specified, then the current
    /// project-level default tier is used.
    /// Possible values are: PREMIUM, STANDARD.
    /// </summary>
    [JsonPropertyName("autoNetworkTier")]
    public string? AutoNetworkTier { get; set; }

    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    [JsonPropertyName("drainNatIps")]
    public IList<string>? DrainNatIps { get; set; }

    /// <summary>
    /// Enable Dynamic Port Allocation.
    /// If minPortsPerVm is set, minPortsPerVm must be set to a power of two greater than or equal to 32.
    /// If minPortsPerVm is not set, a minimum of 32 ports will be allocated to a VM from this NAT config.
    /// If maxPortsPerVm is set, maxPortsPerVm must be set to a power of two greater than minPortsPerVm.
    /// If maxPortsPerVm is not set, a maximum of 65536 ports will be allocated to a VM from this NAT config.
    /// Mutually exclusive with enableEndpointIndependentMapping.
    /// </summary>
    [JsonPropertyName("enableDynamicPortAllocation")]
    public bool? EnableDynamicPortAllocation { get; set; }

    /// <summary>
    /// Enable endpoint independent mapping.
    /// For more information see the official documentation.
    /// </summary>
    [JsonPropertyName("enableEndpointIndependentMapping")]
    public bool? EnableEndpointIndependentMapping { get; set; }

    /// <summary>
    /// Specifies the endpoint Types supported by the NAT Gateway.
    /// Supported values include:
    /// ENDPOINT_TYPE_VM, ENDPOINT_TYPE_SWG,
    /// ENDPOINT_TYPE_MANAGED_PROXY_LB.
    /// </summary>
    [JsonPropertyName("endpointTypes")]
    public IList<string>? EndpointTypes { get; set; }

    /// <summary>Timeout (in seconds) for ICMP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("icmpIdleTimeoutSec")]
    public double? IcmpIdleTimeoutSec { get; set; }

    /// <summary>an identifier for the resource with format {{project}}/{{region}}/{{router}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Self-links of NAT IPs to be used as initial value for creation alongside a RouterNatAddress resource.
    /// Conflicts with natIps and drainNatIps. Only valid if natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    [JsonPropertyName("initialNatIps")]
    public IList<string>? InitialNatIps { get; set; }

    /// <summary>
    /// Configuration for logging on NAT
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2RouterNATStatusAtProviderLogConfig? LogConfig { get; set; }

    /// <summary>
    /// Maximum number of ports allocated to a VM from this NAT.
    /// This field can only be set when enableDynamicPortAllocation is enabled.
    /// </summary>
    [JsonPropertyName("maxPortsPerVm")]
    public double? MaxPortsPerVm { get; set; }

    /// <summary>Minimum number of ports allocated to a VM from this NAT. Defaults to 64 for static port allocation and 32 dynamic port allocation if not set.</summary>
    [JsonPropertyName("minPortsPerVm")]
    public double? MinPortsPerVm { get; set; }

    /// <summary>
    /// One or more subnetwork NAT configurations whose traffic should be translated by NAT64 Gateway.
    /// Only used if source_subnetwork_ip_ranges_to_nat64 is set to LIST_OF_IPV6_SUBNETWORKS
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nat64Subnetwork")]
    public IList<V1beta2RouterNATStatusAtProviderNat64Subnetwork>? Nat64Subnetwork { get; set; }

    /// <summary>
    /// How external IPs should be allocated for this NAT. Valid values are
    /// AUTO_ONLY for only allowing NAT IPs allocated by Google Cloud
    /// Platform, or MANUAL_ONLY for only user-allocated NAT IP addresses.
    /// Possible values are: MANUAL_ONLY, AUTO_ONLY.
    /// </summary>
    [JsonPropertyName("natIpAllocateOption")]
    public string? NatIpAllocateOption { get; set; }

    /// <summary>
    /// Self-links of NAT IPs. Only valid if natIpAllocateOption
    /// is set to MANUAL_ONLY.
    /// If this field is used alongside with a count created list of address resources google_compute_address.foobar.*.self_link,
    /// the access level resource for the address resource must have a lifecycle block with create_before_destroy = true so
    /// the number of resources can be increased/decreased without triggering the resourceInUseByAnotherResource error.
    /// </summary>
    [JsonPropertyName("natIps")]
    public IList<string>? NatIps { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where the router and NAT reside.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The name of the Cloud Router in which this NAT will be configured.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>
    /// A list of rules associated with this NAT.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta2RouterNATStatusAtProviderRules>? Rules { get; set; }

    /// <summary>
    /// How NAT should be configured per Subnetwork.
    /// If ALL_SUBNETWORKS_ALL_IP_RANGES, all of the
    /// IP ranges in every Subnetwork are allowed to Nat.
    /// If ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, all of the primary IP
    /// ranges in every Subnetwork are allowed to Nat.
    /// LIST_OF_SUBNETWORKS: A list of Subnetworks are allowed to Nat
    /// (specified in the field subnetwork below). Note that if this field
    /// contains ALL_SUBNETWORKS_ALL_IP_RANGES or
    /// ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, then there should not be any
    /// other RouterNat section in any Router for this network in this region.
    /// Possible values are: ALL_SUBNETWORKS_ALL_IP_RANGES, ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES, LIST_OF_SUBNETWORKS.
    /// </summary>
    [JsonPropertyName("sourceSubnetworkIpRangesToNat")]
    public string? SourceSubnetworkIpRangesToNat { get; set; }

    /// <summary>
    /// Specify the Nat option for NAT64, which can take one of the following values:
    /// ALL_IPV6_SUBNETWORKS: All of the IP ranges in every Subnetwork are allowed to Nat.
    /// LIST_OF_IPV6_SUBNETWORKS: A list of Subnetworks are allowed to Nat (specified in the field nat64Subnetwork below).
    /// Note that if this field contains NAT64_ALL_V6_SUBNETWORKS no other Router.Nat section in this region can also enable NAT64 for any Subnetworks in this network.
    /// Other Router.Nat sections can still be present to enable NAT44 only.
    /// Possible values are: ALL_IPV6_SUBNETWORKS, LIST_OF_IPV6_SUBNETWORKS.
    /// </summary>
    [JsonPropertyName("sourceSubnetworkIpRangesToNat64")]
    public string? SourceSubnetworkIpRangesToNat64 { get; set; }

    /// <summary>
    /// One or more subnetwork NAT configurations. Only used if
    /// source_subnetwork_ip_ranges_to_nat is set to LIST_OF_SUBNETWORKS
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public IList<V1beta2RouterNATStatusAtProviderSubnetwork>? Subnetwork { get; set; }

    /// <summary>
    /// Timeout (in seconds) for TCP established connections.
    /// Defaults to 1200s if not set.
    /// </summary>
    [JsonPropertyName("tcpEstablishedIdleTimeoutSec")]
    public double? TcpEstablishedIdleTimeoutSec { get; set; }

    /// <summary>
    /// Timeout (in seconds) for TCP connections that are in TIME_WAIT state.
    /// Defaults to 120s if not set.
    /// </summary>
    [JsonPropertyName("tcpTimeWaitTimeoutSec")]
    public double? TcpTimeWaitTimeoutSec { get; set; }

    /// <summary>
    /// Timeout (in seconds) for TCP transitory connections.
    /// Defaults to 30s if not set.
    /// </summary>
    [JsonPropertyName("tcpTransitoryIdleTimeoutSec")]
    public double? TcpTransitoryIdleTimeoutSec { get; set; }

    /// <summary>
    /// Indicates whether this NAT is used for public or private IP translation.
    /// If unspecified, it defaults to PUBLIC.
    /// If PUBLIC NAT used for public IP translation.
    /// If PRIVATE NAT used for private IP translation.
    /// Default value is PUBLIC.
    /// Possible values are: PUBLIC, PRIVATE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Timeout (in seconds) for UDP connections. Defaults to 30s if not set.</summary>
    [JsonPropertyName("udpIdleTimeoutSec")]
    public double? UdpIdleTimeoutSec { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATStatusConditions
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

/// <summary>RouterNATStatus defines the observed state of RouterNAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouterNATStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2RouterNATStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RouterNATStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RouterNAT is the Schema for the RouterNATs API. A NAT service created in a router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RouterNAT : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RouterNATSpec>, IStatus<V1beta2RouterNATStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RouterNAT";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "routernats";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RouterNAT";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RouterNATSpec defines the desired state of RouterNAT</summary>
    [JsonPropertyName("spec")]
    public required V1beta2RouterNATSpec Spec { get; set; }

    /// <summary>RouterNATStatus defines the observed state of RouterNAT.</summary>
    [JsonPropertyName("status")]
    public V1beta2RouterNATStatus? Status { get; set; }
}