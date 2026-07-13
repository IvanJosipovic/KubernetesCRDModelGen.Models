#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.memorystore.gcp.upbound.io;
/// <summary>InstanceDesiredUserCreatedEndpoints is the Schema for the InstanceDesiredUserCreatedEndpointss API. Manages user created connections for Memorystore instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsList : IKubernetesObject<V1ListMeta>, IItems<V1beta1InstanceDesiredUserCreatedEndpoints>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceDesiredUserCreatedEndpointsList";
    public const string KubeGroup = "memorystore.gcp.upbound.io";
    public const string KubePluralName = "instancedesiredusercreatedendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorystore.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceDesiredUserCreatedEndpointsList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1InstanceDesiredUserCreatedEndpoints objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1InstanceDesiredUserCreatedEndpoints> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecDeletionPolicyEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate forwardingRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate forwardingRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelector
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
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Address in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Address in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelector
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
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelector
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
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate pscConnectionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate pscConnectionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelector
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
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Detailed information of a PSC connection that is created by the customer
/// who owns the cluster.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnection
{
    /// <summary>
    /// The URI of the consumer side forwarding rule.
    /// Format:
    /// projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}
    /// </summary>
    [JsonPropertyName("forwardingRule")]
    public string? ForwardingRule { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate forwardingRule.</summary>
    [JsonPropertyName("forwardingRuleRef")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRef? ForwardingRuleRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate forwardingRule.</summary>
    [JsonPropertyName("forwardingRuleSelector")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelector? ForwardingRuleSelector { get; set; }

    /// <summary>The IP allocated on the consumer network for the PSC forwarding rule.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Reference to a Address in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressRef")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRef? IpAddressRef { get; set; }

    /// <summary>Selector for a Address in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressSelector")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelector? IpAddressSelector { get; set; }

    /// <summary>
    /// The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The consumer project_id where the forwarding rule is created from.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The PSC connection id of the forwarding rule connected to the
    /// service attachment.
    /// </summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate pscConnectionId.</summary>
    [JsonPropertyName("pscConnectionIdRef")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRef? PscConnectionIdRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate pscConnectionId.</summary>
    [JsonPropertyName("pscConnectionIdSelector")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelector? PscConnectionIdSelector { get; set; }

    /// <summary>The service attachment which is the target of the PSC connection, in the form of projects/{project-id}/regions/{region}/serviceAttachments/{service-attachment-id}.</summary>
    [JsonPropertyName("serviceAttachment")]
    public string? ServiceAttachment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnections
{
    /// <summary>
    /// Detailed information of a PSC connection that is created by the customer
    /// who owns the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscConnection")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnectionsPscConnection? PscConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpoints
{
    /// <summary>Structure is documented below.</summary>
    [JsonPropertyName("connections")]
    public IList<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpointsConnections>? Connections { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecForProvider
{
    /// <summary>
    /// A list of desired user endpoints
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("desiredUserCreatedEndpoints")]
    public IList<V1beta1InstanceDesiredUserCreatedEndpointsSpecForProviderDesiredUserCreatedEndpoints>? DesiredUserCreatedEndpoints { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The name of the region of the Memorystore instance these endpoints should be added to.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate forwardingRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate forwardingRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelector
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
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Address in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Address in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelector
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
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelector
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
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate pscConnectionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate pscConnectionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelector
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
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Detailed information of a PSC connection that is created by the customer
/// who owns the cluster.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnection
{
    /// <summary>
    /// The URI of the consumer side forwarding rule.
    /// Format:
    /// projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}
    /// </summary>
    [JsonPropertyName("forwardingRule")]
    public string? ForwardingRule { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate forwardingRule.</summary>
    [JsonPropertyName("forwardingRuleRef")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleRef? ForwardingRuleRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate forwardingRule.</summary>
    [JsonPropertyName("forwardingRuleSelector")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionForwardingRuleSelector? ForwardingRuleSelector { get; set; }

    /// <summary>The IP allocated on the consumer network for the PSC forwarding rule.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Reference to a Address in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressRef")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressRef? IpAddressRef { get; set; }

    /// <summary>Selector for a Address in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressSelector")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionIpAddressSelector? IpAddressSelector { get; set; }

    /// <summary>
    /// The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The consumer project_id where the forwarding rule is created from.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The PSC connection id of the forwarding rule connected to the
    /// service attachment.
    /// </summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate pscConnectionId.</summary>
    [JsonPropertyName("pscConnectionIdRef")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdRef? PscConnectionIdRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate pscConnectionId.</summary>
    [JsonPropertyName("pscConnectionIdSelector")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnectionPscConnectionIdSelector? PscConnectionIdSelector { get; set; }

    /// <summary>The service attachment which is the target of the PSC connection, in the form of projects/{project-id}/regions/{region}/serviceAttachments/{service-attachment-id}.</summary>
    [JsonPropertyName("serviceAttachment")]
    public string? ServiceAttachment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnections
{
    /// <summary>
    /// Detailed information of a PSC connection that is created by the customer
    /// who owns the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscConnection")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnectionsPscConnection? PscConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpoints
{
    /// <summary>Structure is documented below.</summary>
    [JsonPropertyName("connections")]
    public IList<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpointsConnections>? Connections { get; set; }
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
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProvider
{
    /// <summary>
    /// A list of desired user endpoints
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("desiredUserCreatedEndpoints")]
    public IList<V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProviderDesiredUserCreatedEndpoints>? DesiredUserCreatedEndpoints { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecManagementPoliciesEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceDesiredUserCreatedEndpointsSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1InstanceDesiredUserCreatedEndpointsSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>InstanceDesiredUserCreatedEndpointsSpec defines the desired state of InstanceDesiredUserCreatedEndpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsSpec
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
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1InstanceDesiredUserCreatedEndpointsSpecForProvider ForProvider { get; set; }

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
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1InstanceDesiredUserCreatedEndpointsSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceDesiredUserCreatedEndpointsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Detailed information of a PSC connection that is created by the customer
/// who owns the cluster.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsStatusAtProviderDesiredUserCreatedEndpointsConnectionsPscConnection
{
    /// <summary>
    /// (Output)
    /// Output Only. Type of a PSC Connection.
    /// Possible values:
    /// CONNECTION_TYPE_DISCOVERY
    /// CONNECTION_TYPE_PRIMARY
    /// CONNECTION_TYPE_READER
    /// </summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>
    /// The URI of the consumer side forwarding rule.
    /// Format:
    /// projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}
    /// </summary>
    [JsonPropertyName("forwardingRule")]
    public string? ForwardingRule { get; set; }

    /// <summary>The IP allocated on the consumer network for the PSC forwarding rule.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The consumer project_id where the forwarding rule is created from.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The PSC connection id of the forwarding rule connected to the
    /// service attachment.
    /// </summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }

    /// <summary>
    /// (Output)
    /// Output Only. The status of the PSC connection: whether a connection exists and ACTIVE or it no longer exists.
    /// Possible values:
    /// ACTIVE
    /// NOT_FOUND
    /// </summary>
    [JsonPropertyName("pscConnectionStatus")]
    public string? PscConnectionStatus { get; set; }

    /// <summary>The service attachment which is the target of the PSC connection, in the form of projects/{project-id}/regions/{region}/serviceAttachments/{service-attachment-id}.</summary>
    [JsonPropertyName("serviceAttachment")]
    public string? ServiceAttachment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsStatusAtProviderDesiredUserCreatedEndpointsConnections
{
    /// <summary>
    /// Detailed information of a PSC connection that is created by the customer
    /// who owns the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscConnection")]
    public V1beta1InstanceDesiredUserCreatedEndpointsStatusAtProviderDesiredUserCreatedEndpointsConnectionsPscConnection? PscConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsStatusAtProviderDesiredUserCreatedEndpoints
{
    /// <summary>Structure is documented below.</summary>
    [JsonPropertyName("connections")]
    public IList<V1beta1InstanceDesiredUserCreatedEndpointsStatusAtProviderDesiredUserCreatedEndpointsConnections>? Connections { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsStatusAtProvider
{
    /// <summary>
    /// A list of desired user endpoints
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("desiredUserCreatedEndpoints")]
    public IList<V1beta1InstanceDesiredUserCreatedEndpointsStatusAtProviderDesiredUserCreatedEndpoints>? DesiredUserCreatedEndpoints { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{region}}/instances/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The name of the region of the Memorystore instance these endpoints should be added to.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsStatusConditions
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

/// <summary>InstanceDesiredUserCreatedEndpointsStatus defines the observed state of InstanceDesiredUserCreatedEndpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceDesiredUserCreatedEndpointsStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceDesiredUserCreatedEndpointsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceDesiredUserCreatedEndpointsStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>InstanceDesiredUserCreatedEndpoints is the Schema for the InstanceDesiredUserCreatedEndpointss API. Manages user created connections for Memorystore instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceDesiredUserCreatedEndpoints : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceDesiredUserCreatedEndpointsSpec>, IStatus<V1beta1InstanceDesiredUserCreatedEndpointsStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceDesiredUserCreatedEndpoints";
    public const string KubeGroup = "memorystore.gcp.upbound.io";
    public const string KubePluralName = "instancedesiredusercreatedendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorystore.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceDesiredUserCreatedEndpoints";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceDesiredUserCreatedEndpointsSpec defines the desired state of InstanceDesiredUserCreatedEndpoints</summary>
    [JsonPropertyName("spec")]
    public required V1beta1InstanceDesiredUserCreatedEndpointsSpec Spec { get; set; }

    /// <summary>InstanceDesiredUserCreatedEndpointsStatus defines the observed state of InstanceDesiredUserCreatedEndpoints.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceDesiredUserCreatedEndpointsStatus? Status { get; set; }
}