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
/// <summary>NetworkFirewallPolicyRule is the Schema for the NetworkFirewallPolicyRules API. Represents a rule that describes one or more match conditions along with the action to be taken when traffic matches this condition (allow or deny).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkFirewallPolicyRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NetworkFirewallPolicyRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkFirewallPolicyRuleList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "networkfirewallpolicyrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkFirewallPolicyRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1NetworkFirewallPolicyRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1NetworkFirewallPolicyRule> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecDeletionPolicyEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicyResolutionEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicyResolveEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkFirewallPolicy in compute to populate firewallPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicyResolutionEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicyResolveEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkFirewallPolicy in compute to populate firewallPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicySelector
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
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicySelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchLayer4Configs
{
    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is required when creating a firewall rule.
    /// This value can either be one of the following well known protocol strings (tcp, udp, icmp, esp, ah, ipip, sctp), or the IP protocol number.
    /// </summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>
    /// An optional list of ports to which this rule applies. This field is only applicable for UDP or TCP protocol. Each entry must be either an integer or a range. If not specified, this rule applies to connections through any port.
    /// Example inputs include: [&quot;22&quot;], [&quot;80&quot;,&quot;443&quot;], and [&quot;12345-12349&quot;].
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsRefsPolicyResolutionEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsRefsPolicyResolveEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsSelectorPolicyResolutionEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsSelectorPolicyResolveEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of AddressGroup in networksecurity to populate srcAddressGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsSelector
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
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameRefPolicyResolutionEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameRefPolicyResolveEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a TagValue in tags to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameSelectorPolicyResolutionEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameSelectorPolicyResolveEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a TagValue in tags to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameSelector
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
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTags
{
    /// <summary>Name of the secure tag, created with TagManager&apos;s TagValue API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a TagValue in tags to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameRef? NameRef { get; set; }

    /// <summary>Selector for a TagValue in tags to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTagsNameSelector? NameSelector { get; set; }
}

/// <summary>
/// A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding &apos;action&apos; is enforced.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderMatch
{
    /// <summary>Address groups which should be matched against the traffic destination. Maximum number of destination address groups is 10.</summary>
    [JsonPropertyName("destAddressGroups")]
    public IList<string>? DestAddressGroups { get; set; }

    /// <summary>Fully Qualified Domain Name (FQDN) which should be matched against traffic destination. Maximum number of destination fqdn allowed is 100.</summary>
    [JsonPropertyName("destFqdns")]
    public IList<string>? DestFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of destination CIDR IP ranges allowed is 5000.</summary>
    [JsonPropertyName("destIpRanges")]
    public IList<string>? DestIpRanges { get; set; }

    /// <summary>Region codes whose IP addresses will be used to match for destination of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&quot;US&quot; Maximum number of dest region codes allowed is 5000.</summary>
    [JsonPropertyName("destRegionCodes")]
    public IList<string>? DestRegionCodes { get; set; }

    /// <summary>Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic destination.</summary>
    [JsonPropertyName("destThreatIntelligences")]
    public IList<string>? DestThreatIntelligences { get; set; }

    /// <summary>
    /// Pairs of IP protocols and ports that the rule should match.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("layer4Configs")]
    public IList<V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchLayer4Configs>? Layer4Configs { get; set; }

    /// <summary>Address groups which should be matched against the traffic source. Maximum number of source address groups is 10.</summary>
    [JsonPropertyName("srcAddressGroups")]
    public IList<string>? SrcAddressGroups { get; set; }

    /// <summary>References to AddressGroup in networksecurity to populate srcAddressGroups.</summary>
    [JsonPropertyName("srcAddressGroupsRefs")]
    public IList<V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsRefs>? SrcAddressGroupsRefs { get; set; }

    /// <summary>Selector for a list of AddressGroup in networksecurity to populate srcAddressGroups.</summary>
    [JsonPropertyName("srcAddressGroupsSelector")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcAddressGroupsSelector? SrcAddressGroupsSelector { get; set; }

    /// <summary>Fully Qualified Domain Name (FQDN) which should be matched against traffic source. Maximum number of source fqdn allowed is 100.</summary>
    [JsonPropertyName("srcFqdns")]
    public IList<string>? SrcFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of source CIDR IP ranges allowed is 5000.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }

    /// <summary>Region codes whose IP addresses will be used to match for source of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&quot;US&quot; Maximum number of source region codes allowed is 5000.</summary>
    [JsonPropertyName("srcRegionCodes")]
    public IList<string>? SrcRegionCodes { get; set; }

    /// <summary>
    /// List of secure tag values, which should be matched at the source of the traffic. For INGRESS rule, if all the srcSecureTag are INEFFECTIVE, and there is no srcIpRange, this rule will be ignored. Maximum number of source tag values allowed is 256.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("srcSecureTags")]
    public IList<V1beta1NetworkFirewallPolicyRuleSpecForProviderMatchSrcSecureTags>? SrcSecureTags { get; set; }

    /// <summary>Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic source.</summary>
    [JsonPropertyName("srcThreatIntelligences")]
    public IList<string>? SrcThreatIntelligences { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProviderTargetSecureTags
{
    /// <summary>Name of the secure tag, created with TagManager&apos;s TagValue API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecForProvider
{
    /// <summary>The Action to perform when the client connection triggers the rule. Valid actions are &quot;allow&quot;, &quot;deny&quot;, &quot;goto_next&quot; and &quot;apply_security_profile_group&quot;.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>An optional description for this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The direction in which this rule applies.
    /// Possible values are: INGRESS, EGRESS.
    /// </summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled.
    /// When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist.
    /// If this is unspecified, the firewall policy rule will be enabled.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the configured export destination in Stackdriver.
    /// Logs may be exported to BigQuery or Pub/Sub.
    /// Note: you cannot enable logging on &quot;goto_next&quot; rules.
    /// </summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>The firewall policy of the resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public string? FirewallPolicy { get; set; }

    /// <summary>Reference to a NetworkFirewallPolicy in compute to populate firewallPolicy.</summary>
    [JsonPropertyName("firewallPolicyRef")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicyRef? FirewallPolicyRef { get; set; }

    /// <summary>Selector for a NetworkFirewallPolicy in compute to populate firewallPolicy.</summary>
    [JsonPropertyName("firewallPolicySelector")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderFirewallPolicySelector? FirewallPolicySelector { get; set; }

    /// <summary>
    /// A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding &apos;action&apos; is enforced.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1NetworkFirewallPolicyRuleSpecForProviderMatch? Match { get; set; }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest prority.
    /// </summary>
    [JsonPropertyName("priority")]
    public required double Priority { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>An optional name for the rule. This field is not a unique identifier and can be updated.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example: https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action = &apos;apply_security_profile_group&apos; and cannot be specified for other actions.
    /// </summary>
    [JsonPropertyName("securityProfileGroup")]
    public string? SecurityProfileGroup { get; set; }

    /// <summary>
    /// A list of secure tags that controls which instances the firewall rule applies to.
    /// If targetSecureTag are specified, then the firewall rule applies only to instances in the VPC network that have one of those EFFECTIVE secure tags, if all the targetSecureTag are in INEFFECTIVE state, then this rule will be ignored.
    /// targetSecureTag may not be set at the same time as targetServiceAccounts. If neither targetServiceAccounts nor targetSecureTag are specified, the firewall rule applies to all instances on the specified network. Maximum number of target label tags allowed is 256.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("targetSecureTags")]
    public IList<V1beta1NetworkFirewallPolicyRuleSpecForProviderTargetSecureTags>? TargetSecureTags { get; set; }

    /// <summary>A list of service accounts indicating the sets of instances that are applied with this rule.</summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<string>? TargetServiceAccounts { get; set; }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// Can be set only if action = &apos;apply_security_profile_group&apos; and cannot be set for other actions.
    /// </summary>
    [JsonPropertyName("tlsInspect")]
    public bool? TlsInspect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchLayer4Configs
{
    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is required when creating a firewall rule.
    /// This value can either be one of the following well known protocol strings (tcp, udp, icmp, esp, ah, ipip, sctp), or the IP protocol number.
    /// </summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>
    /// An optional list of ports to which this rule applies. This field is only applicable for UDP or TCP protocol. Each entry must be either an integer or a range. If not specified, this rule applies to connections through any port.
    /// Example inputs include: [&quot;22&quot;], [&quot;80&quot;,&quot;443&quot;], and [&quot;12345-12349&quot;].
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsRefsPolicyResolutionEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsRefsPolicyResolveEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsSelectorPolicyResolutionEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsSelectorPolicyResolveEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of AddressGroup in networksecurity to populate srcAddressGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsSelector
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
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameRefPolicyResolutionEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameRefPolicyResolveEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a TagValue in tags to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameSelectorPolicyResolutionEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameSelectorPolicyResolveEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a TagValue in tags to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameSelector
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
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTags
{
    /// <summary>Name of the secure tag, created with TagManager&apos;s TagValue API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a TagValue in tags to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameRef? NameRef { get; set; }

    /// <summary>Selector for a TagValue in tags to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTagsNameSelector? NameSelector { get; set; }
}

/// <summary>
/// A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding &apos;action&apos; is enforced.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatch
{
    /// <summary>Address groups which should be matched against the traffic destination. Maximum number of destination address groups is 10.</summary>
    [JsonPropertyName("destAddressGroups")]
    public IList<string>? DestAddressGroups { get; set; }

    /// <summary>Fully Qualified Domain Name (FQDN) which should be matched against traffic destination. Maximum number of destination fqdn allowed is 100.</summary>
    [JsonPropertyName("destFqdns")]
    public IList<string>? DestFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of destination CIDR IP ranges allowed is 5000.</summary>
    [JsonPropertyName("destIpRanges")]
    public IList<string>? DestIpRanges { get; set; }

    /// <summary>Region codes whose IP addresses will be used to match for destination of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&quot;US&quot; Maximum number of dest region codes allowed is 5000.</summary>
    [JsonPropertyName("destRegionCodes")]
    public IList<string>? DestRegionCodes { get; set; }

    /// <summary>Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic destination.</summary>
    [JsonPropertyName("destThreatIntelligences")]
    public IList<string>? DestThreatIntelligences { get; set; }

    /// <summary>
    /// Pairs of IP protocols and ports that the rule should match.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("layer4Configs")]
    public IList<V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchLayer4Configs>? Layer4Configs { get; set; }

    /// <summary>Address groups which should be matched against the traffic source. Maximum number of source address groups is 10.</summary>
    [JsonPropertyName("srcAddressGroups")]
    public IList<string>? SrcAddressGroups { get; set; }

    /// <summary>References to AddressGroup in networksecurity to populate srcAddressGroups.</summary>
    [JsonPropertyName("srcAddressGroupsRefs")]
    public IList<V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsRefs>? SrcAddressGroupsRefs { get; set; }

    /// <summary>Selector for a list of AddressGroup in networksecurity to populate srcAddressGroups.</summary>
    [JsonPropertyName("srcAddressGroupsSelector")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcAddressGroupsSelector? SrcAddressGroupsSelector { get; set; }

    /// <summary>Fully Qualified Domain Name (FQDN) which should be matched against traffic source. Maximum number of source fqdn allowed is 100.</summary>
    [JsonPropertyName("srcFqdns")]
    public IList<string>? SrcFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of source CIDR IP ranges allowed is 5000.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }

    /// <summary>Region codes whose IP addresses will be used to match for source of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&quot;US&quot; Maximum number of source region codes allowed is 5000.</summary>
    [JsonPropertyName("srcRegionCodes")]
    public IList<string>? SrcRegionCodes { get; set; }

    /// <summary>
    /// List of secure tag values, which should be matched at the source of the traffic. For INGRESS rule, if all the srcSecureTag are INEFFECTIVE, and there is no srcIpRange, this rule will be ignored. Maximum number of source tag values allowed is 256.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("srcSecureTags")]
    public IList<V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatchSrcSecureTags>? SrcSecureTags { get; set; }

    /// <summary>Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic source.</summary>
    [JsonPropertyName("srcThreatIntelligences")]
    public IList<string>? SrcThreatIntelligences { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProviderTargetSecureTags
{
    /// <summary>Name of the secure tag, created with TagManager&apos;s TagValue API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
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
public partial class V1beta1NetworkFirewallPolicyRuleSpecInitProvider
{
    /// <summary>The Action to perform when the client connection triggers the rule. Valid actions are &quot;allow&quot;, &quot;deny&quot;, &quot;goto_next&quot; and &quot;apply_security_profile_group&quot;.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>An optional description for this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The direction in which this rule applies.
    /// Possible values are: INGRESS, EGRESS.
    /// </summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled.
    /// When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist.
    /// If this is unspecified, the firewall policy rule will be enabled.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the configured export destination in Stackdriver.
    /// Logs may be exported to BigQuery or Pub/Sub.
    /// Note: you cannot enable logging on &quot;goto_next&quot; rules.
    /// </summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>
    /// A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding &apos;action&apos; is enforced.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1NetworkFirewallPolicyRuleSpecInitProviderMatch? Match { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>An optional name for the rule. This field is not a unique identifier and can be updated.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example: https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action = &apos;apply_security_profile_group&apos; and cannot be specified for other actions.
    /// </summary>
    [JsonPropertyName("securityProfileGroup")]
    public string? SecurityProfileGroup { get; set; }

    /// <summary>
    /// A list of secure tags that controls which instances the firewall rule applies to.
    /// If targetSecureTag are specified, then the firewall rule applies only to instances in the VPC network that have one of those EFFECTIVE secure tags, if all the targetSecureTag are in INEFFECTIVE state, then this rule will be ignored.
    /// targetSecureTag may not be set at the same time as targetServiceAccounts. If neither targetServiceAccounts nor targetSecureTag are specified, the firewall rule applies to all instances on the specified network. Maximum number of target label tags allowed is 256.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("targetSecureTags")]
    public IList<V1beta1NetworkFirewallPolicyRuleSpecInitProviderTargetSecureTags>? TargetSecureTags { get; set; }

    /// <summary>A list of service accounts indicating the sets of instances that are applied with this rule.</summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<string>? TargetServiceAccounts { get; set; }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// Can be set only if action = &apos;apply_security_profile_group&apos; and cannot be set for other actions.
    /// </summary>
    [JsonPropertyName("tlsInspect")]
    public bool? TlsInspect { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecManagementPoliciesEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkFirewallPolicyRuleSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1NetworkFirewallPolicyRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkFirewallPolicyRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkFirewallPolicyRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkFirewallPolicyRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>NetworkFirewallPolicyRuleSpec defines the desired state of NetworkFirewallPolicyRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleSpec
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
    public V1beta1NetworkFirewallPolicyRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1NetworkFirewallPolicyRuleSpecForProvider ForProvider { get; set; }

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
    public V1beta1NetworkFirewallPolicyRuleSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1NetworkFirewallPolicyRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NetworkFirewallPolicyRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NetworkFirewallPolicyRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleStatusAtProviderMatchLayer4Configs
{
    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is required when creating a firewall rule.
    /// This value can either be one of the following well known protocol strings (tcp, udp, icmp, esp, ah, ipip, sctp), or the IP protocol number.
    /// </summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>
    /// An optional list of ports to which this rule applies. This field is only applicable for UDP or TCP protocol. Each entry must be either an integer or a range. If not specified, this rule applies to connections through any port.
    /// Example inputs include: [&quot;22&quot;], [&quot;80&quot;,&quot;443&quot;], and [&quot;12345-12349&quot;].
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleStatusAtProviderMatchSrcSecureTags
{
    /// <summary>Name of the secure tag, created with TagManager&apos;s TagValue API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Output)
    /// State of the secure tag, either EFFECTIVE or INEFFECTIVE. A secure tag is INEFFECTIVE when it is deleted or its network is deleted.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding &apos;action&apos; is enforced.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleStatusAtProviderMatch
{
    /// <summary>Address groups which should be matched against the traffic destination. Maximum number of destination address groups is 10.</summary>
    [JsonPropertyName("destAddressGroups")]
    public IList<string>? DestAddressGroups { get; set; }

    /// <summary>Fully Qualified Domain Name (FQDN) which should be matched against traffic destination. Maximum number of destination fqdn allowed is 100.</summary>
    [JsonPropertyName("destFqdns")]
    public IList<string>? DestFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of destination CIDR IP ranges allowed is 5000.</summary>
    [JsonPropertyName("destIpRanges")]
    public IList<string>? DestIpRanges { get; set; }

    /// <summary>Region codes whose IP addresses will be used to match for destination of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&quot;US&quot; Maximum number of dest region codes allowed is 5000.</summary>
    [JsonPropertyName("destRegionCodes")]
    public IList<string>? DestRegionCodes { get; set; }

    /// <summary>Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic destination.</summary>
    [JsonPropertyName("destThreatIntelligences")]
    public IList<string>? DestThreatIntelligences { get; set; }

    /// <summary>
    /// Pairs of IP protocols and ports that the rule should match.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("layer4Configs")]
    public IList<V1beta1NetworkFirewallPolicyRuleStatusAtProviderMatchLayer4Configs>? Layer4Configs { get; set; }

    /// <summary>Address groups which should be matched against the traffic source. Maximum number of source address groups is 10.</summary>
    [JsonPropertyName("srcAddressGroups")]
    public IList<string>? SrcAddressGroups { get; set; }

    /// <summary>Fully Qualified Domain Name (FQDN) which should be matched against traffic source. Maximum number of source fqdn allowed is 100.</summary>
    [JsonPropertyName("srcFqdns")]
    public IList<string>? SrcFqdns { get; set; }

    /// <summary>CIDR IP address range. Maximum number of source CIDR IP ranges allowed is 5000.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }

    /// <summary>Region codes whose IP addresses will be used to match for source of traffic. Should be specified as 2 letter country code defined as per ISO 3166 alpha-2 country codes. ex.&quot;US&quot; Maximum number of source region codes allowed is 5000.</summary>
    [JsonPropertyName("srcRegionCodes")]
    public IList<string>? SrcRegionCodes { get; set; }

    /// <summary>
    /// List of secure tag values, which should be matched at the source of the traffic. For INGRESS rule, if all the srcSecureTag are INEFFECTIVE, and there is no srcIpRange, this rule will be ignored. Maximum number of source tag values allowed is 256.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("srcSecureTags")]
    public IList<V1beta1NetworkFirewallPolicyRuleStatusAtProviderMatchSrcSecureTags>? SrcSecureTags { get; set; }

    /// <summary>Names of Network Threat Intelligence lists. The IPs in these lists will be matched against traffic source.</summary>
    [JsonPropertyName("srcThreatIntelligences")]
    public IList<string>? SrcThreatIntelligences { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleStatusAtProviderTargetSecureTags
{
    /// <summary>Name of the secure tag, created with TagManager&apos;s TagValue API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Output)
    /// State of the secure tag, either EFFECTIVE or INEFFECTIVE. A secure tag is INEFFECTIVE when it is deleted or its network is deleted.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleStatusAtProvider
{
    /// <summary>The Action to perform when the client connection triggers the rule. Valid actions are &quot;allow&quot;, &quot;deny&quot;, &quot;goto_next&quot; and &quot;apply_security_profile_group&quot;.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional description for this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The direction in which this rule applies.
    /// Possible values are: INGRESS, EGRESS.
    /// </summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled.
    /// When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist.
    /// If this is unspecified, the firewall policy rule will be enabled.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the configured export destination in Stackdriver.
    /// Logs may be exported to BigQuery or Pub/Sub.
    /// Note: you cannot enable logging on &quot;goto_next&quot; rules.
    /// </summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>The firewall policy of the resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public string? FirewallPolicy { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/firewallPolicies/{{firewall_policy}}/rules/{{priority}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of the resource. Always compute#firewallPolicyRule for firewall policy rules</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding &apos;action&apos; is enforced.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1NetworkFirewallPolicyRuleStatusAtProviderMatch? Match { get; set; }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest prority.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>An optional name for the rule. This field is not a unique identifier and can be updated.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>Calculation of the complexity of a single firewall policy rule.</summary>
    [JsonPropertyName("ruleTupleCount")]
    public double? RuleTupleCount { get; set; }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example: https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action = &apos;apply_security_profile_group&apos; and cannot be specified for other actions.
    /// </summary>
    [JsonPropertyName("securityProfileGroup")]
    public string? SecurityProfileGroup { get; set; }

    /// <summary>
    /// A list of secure tags that controls which instances the firewall rule applies to.
    /// If targetSecureTag are specified, then the firewall rule applies only to instances in the VPC network that have one of those EFFECTIVE secure tags, if all the targetSecureTag are in INEFFECTIVE state, then this rule will be ignored.
    /// targetSecureTag may not be set at the same time as targetServiceAccounts. If neither targetServiceAccounts nor targetSecureTag are specified, the firewall rule applies to all instances on the specified network. Maximum number of target label tags allowed is 256.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("targetSecureTags")]
    public IList<V1beta1NetworkFirewallPolicyRuleStatusAtProviderTargetSecureTags>? TargetSecureTags { get; set; }

    /// <summary>A list of service accounts indicating the sets of instances that are applied with this rule.</summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<string>? TargetServiceAccounts { get; set; }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// Can be set only if action = &apos;apply_security_profile_group&apos; and cannot be set for other actions.
    /// </summary>
    [JsonPropertyName("tlsInspect")]
    public bool? TlsInspect { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleStatusConditions
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

/// <summary>NetworkFirewallPolicyRuleStatus defines the observed state of NetworkFirewallPolicyRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkFirewallPolicyRuleStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1NetworkFirewallPolicyRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NetworkFirewallPolicyRuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NetworkFirewallPolicyRule is the Schema for the NetworkFirewallPolicyRules API. Represents a rule that describes one or more match conditions along with the action to be taken when traffic matches this condition (allow or deny).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkFirewallPolicyRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NetworkFirewallPolicyRuleSpec>, IStatus<V1beta1NetworkFirewallPolicyRuleStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkFirewallPolicyRule";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "networkfirewallpolicyrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkFirewallPolicyRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkFirewallPolicyRuleSpec defines the desired state of NetworkFirewallPolicyRule</summary>
    [JsonPropertyName("spec")]
    public required V1beta1NetworkFirewallPolicyRuleSpec Spec { get; set; }

    /// <summary>NetworkFirewallPolicyRuleStatus defines the observed state of NetworkFirewallPolicyRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1NetworkFirewallPolicyRuleStatus? Status { get; set; }
}