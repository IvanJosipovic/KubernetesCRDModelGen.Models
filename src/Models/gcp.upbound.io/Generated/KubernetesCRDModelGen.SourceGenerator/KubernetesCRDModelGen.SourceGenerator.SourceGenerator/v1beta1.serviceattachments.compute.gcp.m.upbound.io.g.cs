#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
/// <summary>ServiceAttachment is the Schema for the ServiceAttachments API. Represents a ServiceAttachment resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceAttachmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ServiceAttachment>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceAttachmentList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "serviceattachments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceAttachmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ServiceAttachment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ServiceAttachment> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlRefPolicyResolutionEnum>))]
public enum V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlRefPolicyResolveEnum>))]
public enum V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlSelectorPolicyResolutionEnum>))]
public enum V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlSelectorPolicyResolveEnum>))]
public enum V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderConsumerAcceptLists
{
    /// <summary>
    /// The number of consumer forwarding rules the consumer project can
    /// create.
    /// </summary>
    [JsonPropertyName("connectionLimit")]
    public double? ConnectionLimit { get; set; }

    /// <summary>
    /// The network that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta1ServiceAttachmentSpecForProviderConsumerAcceptListsNetworkUrlSelector? NetworkUrlSelector { get; set; }

    /// <summary>
    /// A project that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    [JsonPropertyName("projectIdOrNum")]
    public string? ProjectIdOrNum { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecForProviderNatSubnetsRefsPolicyResolutionEnum>))]
public enum V1beta1ServiceAttachmentSpecForProviderNatSubnetsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecForProviderNatSubnetsRefsPolicyResolveEnum>))]
public enum V1beta1ServiceAttachmentSpecForProviderNatSubnetsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderNatSubnetsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServiceAttachmentSpecForProviderNatSubnetsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServiceAttachmentSpecForProviderNatSubnetsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderNatSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceAttachmentSpecForProviderNatSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecForProviderNatSubnetsSelectorPolicyResolutionEnum>))]
public enum V1beta1ServiceAttachmentSpecForProviderNatSubnetsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecForProviderNatSubnetsSelectorPolicyResolveEnum>))]
public enum V1beta1ServiceAttachmentSpecForProviderNatSubnetsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderNatSubnetsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServiceAttachmentSpecForProviderNatSubnetsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServiceAttachmentSpecForProviderNatSubnetsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnetwork in compute to populate natSubnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderNatSubnetsSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceAttachmentSpecForProviderNatSubnetsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecForProviderTargetServiceRefPolicyResolutionEnum>))]
public enum V1beta1ServiceAttachmentSpecForProviderTargetServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecForProviderTargetServiceRefPolicyResolveEnum>))]
public enum V1beta1ServiceAttachmentSpecForProviderTargetServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderTargetServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServiceAttachmentSpecForProviderTargetServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServiceAttachmentSpecForProviderTargetServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate targetService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderTargetServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceAttachmentSpecForProviderTargetServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecForProviderTargetServiceSelectorPolicyResolutionEnum>))]
public enum V1beta1ServiceAttachmentSpecForProviderTargetServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecForProviderTargetServiceSelectorPolicyResolveEnum>))]
public enum V1beta1ServiceAttachmentSpecForProviderTargetServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderTargetServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServiceAttachmentSpecForProviderTargetServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServiceAttachmentSpecForProviderTargetServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate targetService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProviderTargetServiceSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceAttachmentSpecForProviderTargetServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecForProvider
{
    /// <summary>
    /// The connection preference to use for this service attachment. Valid
    /// values include &quot;ACCEPT_AUTOMATIC&quot;, &quot;ACCEPT_MANUAL&quot;.
    /// </summary>
    [JsonPropertyName("connectionPreference")]
    public string? ConnectionPreference { get; set; }

    /// <summary>
    /// An array of projects that are allowed to connect to this service
    /// attachment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("consumerAcceptLists")]
    public IList<V1beta1ServiceAttachmentSpecForProviderConsumerAcceptLists>? ConsumerAcceptLists { get; set; }

    /// <summary>
    /// An array of projects that are not allowed to connect to this service
    /// attachment.
    /// </summary>
    [JsonPropertyName("consumerRejectLists")]
    public IList<string>? ConsumerRejectLists { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If specified, the domain name will be used during the integration between
    /// the PSC connected endpoints and the Cloud DNS. For example, this is a
    /// valid domain name: &quot;p.mycompany.com.&quot;. Current max number of domain names
    /// supported is 1.
    /// </summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary>
    /// If true, enable the proxy protocol which is for supplying client TCP/IP
    /// address data in TCP connections that traverse proxies on their way to
    /// destination servers.
    /// </summary>
    [JsonPropertyName("enableProxyProtocol")]
    public bool? EnableProxyProtocol { get; set; }

    /// <summary>An array of subnets that is provided for NAT in this service attachment.</summary>
    [JsonPropertyName("natSubnets")]
    public IList<string>? NatSubnets { get; set; }

    /// <summary>References to Subnetwork in compute to populate natSubnets.</summary>
    [JsonPropertyName("natSubnetsRefs")]
    public IList<V1beta1ServiceAttachmentSpecForProviderNatSubnetsRefs>? NatSubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnetwork in compute to populate natSubnets.</summary>
    [JsonPropertyName("natSubnetsSelector")]
    public V1beta1ServiceAttachmentSpecForProviderNatSubnetsSelector? NatSubnetsSelector { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The number of consumer spokes that connected Private Service Connect endpoints can be propagated to through Network Connectivity Center.
    /// This limit lets the service producer limit how many propagated Private Service Connect connections can be established to this service attachment from a single consumer.
    /// If the connection preference of the service attachment is ACCEPT_MANUAL, the limit applies to each project or network that is listed in the consumer accept list.
    /// If the connection preference of the service attachment is ACCEPT_AUTOMATIC, the limit applies to each project that contains a connected endpoint.
    /// If unspecified, the default propagated connection limit is 250. To explicitly send a zero value, set send_propagated_connection_limit_if_zero = true.
    /// </summary>
    [JsonPropertyName("propagatedConnectionLimit")]
    public double? PropagatedConnectionLimit { get; set; }

    /// <summary>
    /// This flag determines whether a consumer accept/reject list change can reconcile the statuses of existing ACCEPTED or REJECTED PSC endpoints.
    /// If false, connection policy update will only affect existing PENDING PSC endpoints. Existing ACCEPTED/REJECTED endpoints will remain untouched regardless how the connection policy is modified .
    /// If true, update will affect both PENDING and ACCEPTED/REJECTED PSC endpoints. For example, an ACCEPTED PSC endpoint will be moved to REJECTED if its project is added to the reject list.
    /// </summary>
    [JsonPropertyName("reconcileConnections")]
    public bool? ReconcileConnections { get; set; }

    /// <summary>URL of the region where the resource resides.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// Controls the behavior of propagated_connection_limit.
    /// When false, setting propagated_connection_limit to zero causes the provider to use to the API&apos;s default value.
    /// When true, the provider will set propagated_connection_limit to zero.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("sendPropagatedConnectionLimitIfZero")]
    public bool? SendPropagatedConnectionLimitIfZero { get; set; }

    /// <summary>The URL of a service serving the endpoint identified by this service attachment.</summary>
    [JsonPropertyName("targetService")]
    public string? TargetService { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate targetService.</summary>
    [JsonPropertyName("targetServiceRef")]
    public V1beta1ServiceAttachmentSpecForProviderTargetServiceRef? TargetServiceRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate targetService.</summary>
    [JsonPropertyName("targetServiceSelector")]
    public V1beta1ServiceAttachmentSpecForProviderTargetServiceSelector? TargetServiceSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlRefPolicyResolutionEnum>))]
public enum V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlRefPolicyResolveEnum>))]
public enum V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlSelectorPolicyResolutionEnum>))]
public enum V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlSelectorPolicyResolveEnum>))]
public enum V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptLists
{
    /// <summary>
    /// The number of consumer forwarding rules the consumer project can
    /// create.
    /// </summary>
    [JsonPropertyName("connectionLimit")]
    public double? ConnectionLimit { get; set; }

    /// <summary>
    /// The network that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptListsNetworkUrlSelector? NetworkUrlSelector { get; set; }

    /// <summary>
    /// A project that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    [JsonPropertyName("projectIdOrNum")]
    public string? ProjectIdOrNum { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecInitProviderNatSubnetsRefsPolicyResolutionEnum>))]
public enum V1beta1ServiceAttachmentSpecInitProviderNatSubnetsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecInitProviderNatSubnetsRefsPolicyResolveEnum>))]
public enum V1beta1ServiceAttachmentSpecInitProviderNatSubnetsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderNatSubnetsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServiceAttachmentSpecInitProviderNatSubnetsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServiceAttachmentSpecInitProviderNatSubnetsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderNatSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceAttachmentSpecInitProviderNatSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecInitProviderNatSubnetsSelectorPolicyResolutionEnum>))]
public enum V1beta1ServiceAttachmentSpecInitProviderNatSubnetsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecInitProviderNatSubnetsSelectorPolicyResolveEnum>))]
public enum V1beta1ServiceAttachmentSpecInitProviderNatSubnetsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderNatSubnetsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServiceAttachmentSpecInitProviderNatSubnetsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServiceAttachmentSpecInitProviderNatSubnetsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnetwork in compute to populate natSubnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderNatSubnetsSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceAttachmentSpecInitProviderNatSubnetsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecInitProviderTargetServiceRefPolicyResolutionEnum>))]
public enum V1beta1ServiceAttachmentSpecInitProviderTargetServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecInitProviderTargetServiceRefPolicyResolveEnum>))]
public enum V1beta1ServiceAttachmentSpecInitProviderTargetServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderTargetServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServiceAttachmentSpecInitProviderTargetServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServiceAttachmentSpecInitProviderTargetServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate targetService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderTargetServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceAttachmentSpecInitProviderTargetServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecInitProviderTargetServiceSelectorPolicyResolutionEnum>))]
public enum V1beta1ServiceAttachmentSpecInitProviderTargetServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecInitProviderTargetServiceSelectorPolicyResolveEnum>))]
public enum V1beta1ServiceAttachmentSpecInitProviderTargetServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderTargetServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServiceAttachmentSpecInitProviderTargetServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServiceAttachmentSpecInitProviderTargetServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate targetService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecInitProviderTargetServiceSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceAttachmentSpecInitProviderTargetServiceSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1ServiceAttachmentSpecInitProvider
{
    /// <summary>
    /// The connection preference to use for this service attachment. Valid
    /// values include &quot;ACCEPT_AUTOMATIC&quot;, &quot;ACCEPT_MANUAL&quot;.
    /// </summary>
    [JsonPropertyName("connectionPreference")]
    public string? ConnectionPreference { get; set; }

    /// <summary>
    /// An array of projects that are allowed to connect to this service
    /// attachment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("consumerAcceptLists")]
    public IList<V1beta1ServiceAttachmentSpecInitProviderConsumerAcceptLists>? ConsumerAcceptLists { get; set; }

    /// <summary>
    /// An array of projects that are not allowed to connect to this service
    /// attachment.
    /// </summary>
    [JsonPropertyName("consumerRejectLists")]
    public IList<string>? ConsumerRejectLists { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If specified, the domain name will be used during the integration between
    /// the PSC connected endpoints and the Cloud DNS. For example, this is a
    /// valid domain name: &quot;p.mycompany.com.&quot;. Current max number of domain names
    /// supported is 1.
    /// </summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary>
    /// If true, enable the proxy protocol which is for supplying client TCP/IP
    /// address data in TCP connections that traverse proxies on their way to
    /// destination servers.
    /// </summary>
    [JsonPropertyName("enableProxyProtocol")]
    public bool? EnableProxyProtocol { get; set; }

    /// <summary>An array of subnets that is provided for NAT in this service attachment.</summary>
    [JsonPropertyName("natSubnets")]
    public IList<string>? NatSubnets { get; set; }

    /// <summary>References to Subnetwork in compute to populate natSubnets.</summary>
    [JsonPropertyName("natSubnetsRefs")]
    public IList<V1beta1ServiceAttachmentSpecInitProviderNatSubnetsRefs>? NatSubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnetwork in compute to populate natSubnets.</summary>
    [JsonPropertyName("natSubnetsSelector")]
    public V1beta1ServiceAttachmentSpecInitProviderNatSubnetsSelector? NatSubnetsSelector { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The number of consumer spokes that connected Private Service Connect endpoints can be propagated to through Network Connectivity Center.
    /// This limit lets the service producer limit how many propagated Private Service Connect connections can be established to this service attachment from a single consumer.
    /// If the connection preference of the service attachment is ACCEPT_MANUAL, the limit applies to each project or network that is listed in the consumer accept list.
    /// If the connection preference of the service attachment is ACCEPT_AUTOMATIC, the limit applies to each project that contains a connected endpoint.
    /// If unspecified, the default propagated connection limit is 250. To explicitly send a zero value, set send_propagated_connection_limit_if_zero = true.
    /// </summary>
    [JsonPropertyName("propagatedConnectionLimit")]
    public double? PropagatedConnectionLimit { get; set; }

    /// <summary>
    /// This flag determines whether a consumer accept/reject list change can reconcile the statuses of existing ACCEPTED or REJECTED PSC endpoints.
    /// If false, connection policy update will only affect existing PENDING PSC endpoints. Existing ACCEPTED/REJECTED endpoints will remain untouched regardless how the connection policy is modified .
    /// If true, update will affect both PENDING and ACCEPTED/REJECTED PSC endpoints. For example, an ACCEPTED PSC endpoint will be moved to REJECTED if its project is added to the reject list.
    /// </summary>
    [JsonPropertyName("reconcileConnections")]
    public bool? ReconcileConnections { get; set; }

    /// <summary>
    /// Controls the behavior of propagated_connection_limit.
    /// When false, setting propagated_connection_limit to zero causes the provider to use to the API&apos;s default value.
    /// When true, the provider will set propagated_connection_limit to zero.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("sendPropagatedConnectionLimitIfZero")]
    public bool? SendPropagatedConnectionLimitIfZero { get; set; }

    /// <summary>The URL of a service serving the endpoint identified by this service attachment.</summary>
    [JsonPropertyName("targetService")]
    public string? TargetService { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate targetService.</summary>
    [JsonPropertyName("targetServiceRef")]
    public V1beta1ServiceAttachmentSpecInitProviderTargetServiceRef? TargetServiceRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate targetService.</summary>
    [JsonPropertyName("targetServiceSelector")]
    public V1beta1ServiceAttachmentSpecInitProviderTargetServiceSelector? TargetServiceSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceAttachmentSpecManagementPoliciesEnum>))]
public enum V1beta1ServiceAttachmentSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ServiceAttachmentSpec defines the desired state of ServiceAttachment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ServiceAttachmentSpecForProvider ForProvider { get; set; }

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
    public V1beta1ServiceAttachmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ServiceAttachmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ServiceAttachmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ServiceAttachmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentStatusAtProviderConnectedEndpoints
{
    /// <summary>
    /// (Output)
    /// The url of the consumer network.
    /// </summary>
    [JsonPropertyName("consumerNetwork")]
    public string? ConsumerNetwork { get; set; }

    /// <summary>
    /// (Output)
    /// The URL of the consumer forwarding rule.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// (Output)
    /// The number of consumer Network Connectivity Center spokes that the connected Private Service Connect endpoint has propagated to.
    /// </summary>
    [JsonPropertyName("propagatedConnectionCount")]
    public double? PropagatedConnectionCount { get; set; }

    /// <summary>
    /// (Output)
    /// The PSC connection id of the connected endpoint.
    /// </summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }

    /// <summary>
    /// (Output)
    /// The status of the connection from the consumer forwarding rule to
    /// this service attachment.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentStatusAtProviderConsumerAcceptLists
{
    /// <summary>
    /// The number of consumer forwarding rules the consumer project can
    /// create.
    /// </summary>
    [JsonPropertyName("connectionLimit")]
    public double? ConnectionLimit { get; set; }

    /// <summary>
    /// The network that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>
    /// A project that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    [JsonPropertyName("projectIdOrNum")]
    public string? ProjectIdOrNum { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentStatusAtProvider
{
    /// <summary>
    /// An array of the consumer forwarding rules connected to this service
    /// attachment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("connectedEndpoints")]
    public IList<V1beta1ServiceAttachmentStatusAtProviderConnectedEndpoints>? ConnectedEndpoints { get; set; }

    /// <summary>
    /// The connection preference to use for this service attachment. Valid
    /// values include &quot;ACCEPT_AUTOMATIC&quot;, &quot;ACCEPT_MANUAL&quot;.
    /// </summary>
    [JsonPropertyName("connectionPreference")]
    public string? ConnectionPreference { get; set; }

    /// <summary>
    /// An array of projects that are allowed to connect to this service
    /// attachment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("consumerAcceptLists")]
    public IList<V1beta1ServiceAttachmentStatusAtProviderConsumerAcceptLists>? ConsumerAcceptLists { get; set; }

    /// <summary>
    /// An array of projects that are not allowed to connect to this service
    /// attachment.
    /// </summary>
    [JsonPropertyName("consumerRejectLists")]
    public IList<string>? ConsumerRejectLists { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If specified, the domain name will be used during the integration between
    /// the PSC connected endpoints and the Cloud DNS. For example, this is a
    /// valid domain name: &quot;p.mycompany.com.&quot;. Current max number of domain names
    /// supported is 1.
    /// </summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary>
    /// If true, enable the proxy protocol which is for supplying client TCP/IP
    /// address data in TCP connections that traverse proxies on their way to
    /// destination servers.
    /// </summary>
    [JsonPropertyName("enableProxyProtocol")]
    public bool? EnableProxyProtocol { get; set; }

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/serviceAttachments/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An array of subnets that is provided for NAT in this service attachment.</summary>
    [JsonPropertyName("natSubnets")]
    public IList<string>? NatSubnets { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The number of consumer spokes that connected Private Service Connect endpoints can be propagated to through Network Connectivity Center.
    /// This limit lets the service producer limit how many propagated Private Service Connect connections can be established to this service attachment from a single consumer.
    /// If the connection preference of the service attachment is ACCEPT_MANUAL, the limit applies to each project or network that is listed in the consumer accept list.
    /// If the connection preference of the service attachment is ACCEPT_AUTOMATIC, the limit applies to each project that contains a connected endpoint.
    /// If unspecified, the default propagated connection limit is 250. To explicitly send a zero value, set send_propagated_connection_limit_if_zero = true.
    /// </summary>
    [JsonPropertyName("propagatedConnectionLimit")]
    public double? PropagatedConnectionLimit { get; set; }

    /// <summary>
    /// This flag determines whether a consumer accept/reject list change can reconcile the statuses of existing ACCEPTED or REJECTED PSC endpoints.
    /// If false, connection policy update will only affect existing PENDING PSC endpoints. Existing ACCEPTED/REJECTED endpoints will remain untouched regardless how the connection policy is modified .
    /// If true, update will affect both PENDING and ACCEPTED/REJECTED PSC endpoints. For example, an ACCEPTED PSC endpoint will be moved to REJECTED if its project is added to the reject list.
    /// </summary>
    [JsonPropertyName("reconcileConnections")]
    public bool? ReconcileConnections { get; set; }

    /// <summary>URL of the region where the resource resides.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// Controls the behavior of propagated_connection_limit.
    /// When false, setting propagated_connection_limit to zero causes the provider to use to the API&apos;s default value.
    /// When true, the provider will set propagated_connection_limit to zero.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("sendPropagatedConnectionLimitIfZero")]
    public bool? SendPropagatedConnectionLimitIfZero { get; set; }

    /// <summary>The URL of a service serving the endpoint identified by this service attachment.</summary>
    [JsonPropertyName("targetService")]
    public string? TargetService { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentStatusConditions
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

/// <summary>ServiceAttachmentStatus defines the observed state of ServiceAttachment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceAttachmentStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ServiceAttachmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServiceAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ServiceAttachment is the Schema for the ServiceAttachments API. Represents a ServiceAttachment resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServiceAttachmentSpec>, IStatus<V1beta1ServiceAttachmentStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceAttachment";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "serviceattachments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceAttachment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceAttachmentSpec defines the desired state of ServiceAttachment</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ServiceAttachmentSpec Spec { get; set; }

    /// <summary>ServiceAttachmentStatus defines the observed state of ServiceAttachment.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServiceAttachmentStatus? Status { get; set; }
}