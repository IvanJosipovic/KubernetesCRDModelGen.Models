#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kusto.azure.m.upbound.io;
/// <summary>Cluster is the Schema for the Clusters API. Manages Kusto (also known as Azure Data Explorer) Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Cluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "kusto.azure.m.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kusto.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Cluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Cluster> Items { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Kusto Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that is configured on this Kusto Cluster. Possible values are: SystemAssigned, UserAssigned and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLanguageExtension
{
    /// <summary>The language extension image. Possible values are Python3_11_7, Python3_11_7_DL, Python3_10_8, Python3_10_8_DL, Python3_6_5, PythonCustomImage, and R.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The name of the language extension. Possible values are PYTHON and R.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLanguageExtensions
{
    /// <summary>The language extension image. Possible values are Python3_11_7, Python3_11_7_DL, Python3_10_8, Python3_10_8_DL, Python3_6_5, PythonCustomImage, and R.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The name of the SKU. Possible values are Dev(No SLA)_Standard_D11_v2, Dev(No SLA)_Standard_E2a_v4, Standard_D14_v2, Standard_D11_v2, Standard_D16d_v5, Standard_D13_v2, Standard_D12_v2, Standard_DS14_v2+4TB_PS, Standard_DS14_v2+3TB_PS, Standard_DS13_v2+1TB_PS, Standard_DS13_v2+2TB_PS, Standard_D32d_v5, Standard_D32d_v4, Standard_EC8ads_v5, Standard_EC8as_v5+1TB_PS, Standard_EC8as_v5+2TB_PS, Standard_EC16ads_v5, Standard_EC16as_v5+4TB_PS, Standard_EC16as_v5+3TB_PS, Standard_E80ids_v4, Standard_E8a_v4, Standard_E8ads_v5, Standard_E8as_v5+1TB_PS, Standard_E8as_v5+2TB_PS, Standard_E8as_v4+1TB_PS, Standard_E8as_v4+2TB_PS, Standard_E8d_v5, Standard_E8d_v4, Standard_E8s_v5+1TB_PS, Standard_E8s_v5+2TB_PS, Standard_E8s_v4+1TB_PS, Standard_E8s_v4+2TB_PS, Standard_E4a_v4, Standard_E4ads_v5, Standard_E4d_v5, Standard_E4d_v4, Standard_E16a_v4, Standard_E16ads_v5, Standard_E16as_v5+4TB_PS, Standard_E16as_v5+3TB_PS, Standard_E16as_v4+4TB_PS, Standard_E16as_v4+3TB_PS, Standard_E16d_v5, Standard_E16d_v4, Standard_E16s_v5+4TB_PS, Standard_E16s_v5+3TB_PS, Standard_E16s_v4+4TB_PS, Standard_E16s_v4+3TB_PS, Standard_E64i_v3, Standard_E2a_v4, Standard_E2ads_v5, Standard_E2d_v5, Standard_E2d_v4, Standard_L8as_v3, Standard_L8s, Standard_L8s_v3, Standard_L8s_v2, Standard_L4s, Standard_L16as_v3, Standard_L16s, Standard_L16s_v3, Standard_L16s_v2, Standard_L32as_v3 and Standard_L32s_v3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An optimized_auto_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderOptimizedAutoScale
{
    /// <summary>The maximum number of allowed instances. Possible values range between 0 and 1000.</summary>
    [JsonPropertyName("maximumInstances")]
    public double? MaximumInstances { get; set; }

    /// <summary>The minimum number of allowed instances. Possible values range between 0 and 1000.</summary>
    [JsonPropertyName("minimumInstances")]
    public double? MinimumInstances { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1ClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1ClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ClusterSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ClusterSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1ClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1ClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ClusterSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ClusterSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderResourceGroupNameSelector
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
    public V1beta1ClusterSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A sku block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSku
{
    /// <summary>Specifies the node count for the cluster. Boundaries depend on the SKU name.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the SKU. Possible values are Dev(No SLA)_Standard_D11_v2, Dev(No SLA)_Standard_E2a_v4, Standard_D14_v2, Standard_D11_v2, Standard_D16d_v5, Standard_D13_v2, Standard_D12_v2, Standard_DS14_v2+4TB_PS, Standard_DS14_v2+3TB_PS, Standard_DS13_v2+1TB_PS, Standard_DS13_v2+2TB_PS, Standard_D32d_v5, Standard_D32d_v4, Standard_EC8ads_v5, Standard_EC8as_v5+1TB_PS, Standard_EC8as_v5+2TB_PS, Standard_EC16ads_v5, Standard_EC16as_v5+4TB_PS, Standard_EC16as_v5+3TB_PS, Standard_E80ids_v4, Standard_E8a_v4, Standard_E8ads_v5, Standard_E8as_v5+1TB_PS, Standard_E8as_v5+2TB_PS, Standard_E8as_v4+1TB_PS, Standard_E8as_v4+2TB_PS, Standard_E8d_v5, Standard_E8d_v4, Standard_E8s_v5+1TB_PS, Standard_E8s_v5+2TB_PS, Standard_E8s_v4+1TB_PS, Standard_E8s_v4+2TB_PS, Standard_E4a_v4, Standard_E4ads_v5, Standard_E4d_v5, Standard_E4d_v4, Standard_E16a_v4, Standard_E16ads_v5, Standard_E16as_v5+4TB_PS, Standard_E16as_v5+3TB_PS, Standard_E16as_v4+4TB_PS, Standard_E16as_v4+3TB_PS, Standard_E16d_v5, Standard_E16d_v4, Standard_E16s_v5+4TB_PS, Standard_E16s_v5+3TB_PS, Standard_E16s_v4+4TB_PS, Standard_E16s_v4+3TB_PS, Standard_E64i_v3, Standard_E2a_v4, Standard_E2ads_v5, Standard_E2d_v5, Standard_E2d_v4, Standard_L8as_v3, Standard_L8s, Standard_L8s_v3, Standard_L8s_v2, Standard_L4s, Standard_L16as_v3, Standard_L16s, Standard_L16s_v3, Standard_L16s_v2, Standard_L32as_v3 and Standard_L32s_v3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelector
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
    public V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVirtualNetworkConfiguration
{
    /// <summary>The Kusto Cluster ID.</summary>
    [JsonPropertyName("dataManagementPublicIpId")]
    public string? DataManagementPublicIpId { get; set; }

    /// <summary>The Kusto Cluster ID.</summary>
    [JsonPropertyName("enginePublicIpId")]
    public string? EnginePublicIpId { get; set; }

    /// <summary>The Kusto Cluster ID.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ClusterSpecForProviderVirtualNetworkConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>List of allowed FQDNs (Fully Qualified Domain Name) for egress from Cluster.</summary>
    [JsonPropertyName("allowedFqdns")]
    public IList<string>? AllowedFqdns { get; set; }

    /// <summary>The list of ips in the format of CIDR allowed to connect to the cluster.</summary>
    [JsonPropertyName("allowedIpRanges")]
    public IList<string>? AllowedIpRanges { get; set; }

    /// <summary>Specifies if the cluster could be automatically stopped (due to lack of data or no activity for many days). Defaults to true.</summary>
    [JsonPropertyName("autoStopEnabled")]
    public bool? AutoStopEnabled { get; set; }

    /// <summary>Specifies if the cluster&apos;s disks are encrypted. Defaults to false.</summary>
    [JsonPropertyName("diskEncryptionEnabled")]
    public bool? DiskEncryptionEnabled { get; set; }

    /// <summary>Is the cluster&apos;s double encryption enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("doubleEncryptionEnabled")]
    public bool? DoubleEncryptionEnabled { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ClusterSpecForProviderIdentity? Identity { get; set; }

    /// <summary>A language_extension block as defined below.</summary>
    [JsonPropertyName("languageExtension")]
    public IList<V1beta1ClusterSpecForProviderLanguageExtension>? LanguageExtension { get; set; }

    [JsonPropertyName("languageExtensions")]
    public IList<V1beta1ClusterSpecForProviderLanguageExtensions>? LanguageExtensions { get; set; }

    /// <summary>The location where the Kusto Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An optimized_auto_scale block as defined below.</summary>
    [JsonPropertyName("optimizedAutoScale")]
    public V1beta1ClusterSpecForProviderOptimizedAutoScale? OptimizedAutoScale { get; set; }

    /// <summary>Whether to restrict outbound network access. Defaults to false.</summary>
    [JsonPropertyName("outboundNetworkAccessRestricted")]
    public bool? OutboundNetworkAccessRestricted { get; set; }

    /// <summary>Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6). Defaults to IPv4.</summary>
    [JsonPropertyName("publicIpType")]
    public string? PublicIpType { get; set; }

    /// <summary>Is the public network access enabled? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Specifies if the purge operations are enabled. Defaults to false.</summary>
    [JsonPropertyName("purgeEnabled")]
    public bool? PurgeEnabled { get; set; }

    /// <summary>Specifies the Resource Group where the Kusto Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public V1beta1ClusterSpecForProviderSku? Sku { get; set; }

    /// <summary>Specifies if the streaming ingest is enabled. Defaults to false.</summary>
    [JsonPropertyName("streamingIngestionEnabled")]
    public bool? StreamingIngestionEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a list of tenant IDs that are trusted by the cluster. Default setting trusts all other tenants. Use trusted_external_tenants = [&quot;*&quot;] to explicitly allow all other tenants, trusted_external_tenants = [&quot;MyTenantOnly&quot;] for only your tenant or trusted_external_tenants = [&quot; &lt;tenantId1&gt; &quot;, &quot; &lt;tenantIdx&gt; &quot;] to allow specific other tenants.</summary>
    [JsonPropertyName("trustedExternalTenants")]
    public IList<string>? TrustedExternalTenants { get; set; }

    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta1ClusterSpecForProviderVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kusto Cluster should be located. Changing this forces a new Kusto Cluster to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Kusto Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that is configured on this Kusto Cluster. Possible values are: SystemAssigned, UserAssigned and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLanguageExtension
{
    /// <summary>The language extension image. Possible values are Python3_11_7, Python3_11_7_DL, Python3_10_8, Python3_10_8_DL, Python3_6_5, PythonCustomImage, and R.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The name of the language extension. Possible values are PYTHON and R.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLanguageExtensions
{
    /// <summary>The language extension image. Possible values are Python3_11_7, Python3_11_7_DL, Python3_10_8, Python3_10_8_DL, Python3_6_5, PythonCustomImage, and R.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The name of the SKU. Possible values are Dev(No SLA)_Standard_D11_v2, Dev(No SLA)_Standard_E2a_v4, Standard_D14_v2, Standard_D11_v2, Standard_D16d_v5, Standard_D13_v2, Standard_D12_v2, Standard_DS14_v2+4TB_PS, Standard_DS14_v2+3TB_PS, Standard_DS13_v2+1TB_PS, Standard_DS13_v2+2TB_PS, Standard_D32d_v5, Standard_D32d_v4, Standard_EC8ads_v5, Standard_EC8as_v5+1TB_PS, Standard_EC8as_v5+2TB_PS, Standard_EC16ads_v5, Standard_EC16as_v5+4TB_PS, Standard_EC16as_v5+3TB_PS, Standard_E80ids_v4, Standard_E8a_v4, Standard_E8ads_v5, Standard_E8as_v5+1TB_PS, Standard_E8as_v5+2TB_PS, Standard_E8as_v4+1TB_PS, Standard_E8as_v4+2TB_PS, Standard_E8d_v5, Standard_E8d_v4, Standard_E8s_v5+1TB_PS, Standard_E8s_v5+2TB_PS, Standard_E8s_v4+1TB_PS, Standard_E8s_v4+2TB_PS, Standard_E4a_v4, Standard_E4ads_v5, Standard_E4d_v5, Standard_E4d_v4, Standard_E16a_v4, Standard_E16ads_v5, Standard_E16as_v5+4TB_PS, Standard_E16as_v5+3TB_PS, Standard_E16as_v4+4TB_PS, Standard_E16as_v4+3TB_PS, Standard_E16d_v5, Standard_E16d_v4, Standard_E16s_v5+4TB_PS, Standard_E16s_v5+3TB_PS, Standard_E16s_v4+4TB_PS, Standard_E16s_v4+3TB_PS, Standard_E64i_v3, Standard_E2a_v4, Standard_E2ads_v5, Standard_E2d_v5, Standard_E2d_v4, Standard_L8as_v3, Standard_L8s, Standard_L8s_v3, Standard_L8s_v2, Standard_L4s, Standard_L16as_v3, Standard_L16s, Standard_L16s_v3, Standard_L16s_v2, Standard_L32as_v3 and Standard_L32s_v3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An optimized_auto_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderOptimizedAutoScale
{
    /// <summary>The maximum number of allowed instances. Possible values range between 0 and 1000.</summary>
    [JsonPropertyName("maximumInstances")]
    public double? MaximumInstances { get; set; }

    /// <summary>The minimum number of allowed instances. Possible values range between 0 and 1000.</summary>
    [JsonPropertyName("minimumInstances")]
    public double? MinimumInstances { get; set; }
}

/// <summary>A sku block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSku
{
    /// <summary>Specifies the node count for the cluster. Boundaries depend on the SKU name.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the SKU. Possible values are Dev(No SLA)_Standard_D11_v2, Dev(No SLA)_Standard_E2a_v4, Standard_D14_v2, Standard_D11_v2, Standard_D16d_v5, Standard_D13_v2, Standard_D12_v2, Standard_DS14_v2+4TB_PS, Standard_DS14_v2+3TB_PS, Standard_DS13_v2+1TB_PS, Standard_DS13_v2+2TB_PS, Standard_D32d_v5, Standard_D32d_v4, Standard_EC8ads_v5, Standard_EC8as_v5+1TB_PS, Standard_EC8as_v5+2TB_PS, Standard_EC16ads_v5, Standard_EC16as_v5+4TB_PS, Standard_EC16as_v5+3TB_PS, Standard_E80ids_v4, Standard_E8a_v4, Standard_E8ads_v5, Standard_E8as_v5+1TB_PS, Standard_E8as_v5+2TB_PS, Standard_E8as_v4+1TB_PS, Standard_E8as_v4+2TB_PS, Standard_E8d_v5, Standard_E8d_v4, Standard_E8s_v5+1TB_PS, Standard_E8s_v5+2TB_PS, Standard_E8s_v4+1TB_PS, Standard_E8s_v4+2TB_PS, Standard_E4a_v4, Standard_E4ads_v5, Standard_E4d_v5, Standard_E4d_v4, Standard_E16a_v4, Standard_E16ads_v5, Standard_E16as_v5+4TB_PS, Standard_E16as_v5+3TB_PS, Standard_E16as_v4+4TB_PS, Standard_E16as_v4+3TB_PS, Standard_E16d_v5, Standard_E16d_v4, Standard_E16s_v5+4TB_PS, Standard_E16s_v5+3TB_PS, Standard_E16s_v4+4TB_PS, Standard_E16s_v4+3TB_PS, Standard_E64i_v3, Standard_E2a_v4, Standard_E2ads_v5, Standard_E2d_v5, Standard_E2d_v4, Standard_L8as_v3, Standard_L8s, Standard_L8s_v3, Standard_L8s_v2, Standard_L4s, Standard_L16as_v3, Standard_L16s, Standard_L16s_v3, Standard_L16s_v2, Standard_L32as_v3 and Standard_L32s_v3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelector
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
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVirtualNetworkConfiguration
{
    /// <summary>The Kusto Cluster ID.</summary>
    [JsonPropertyName("dataManagementPublicIpId")]
    public string? DataManagementPublicIpId { get; set; }

    /// <summary>The Kusto Cluster ID.</summary>
    [JsonPropertyName("enginePublicIpId")]
    public string? EnginePublicIpId { get; set; }

    /// <summary>The Kusto Cluster ID.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>List of allowed FQDNs (Fully Qualified Domain Name) for egress from Cluster.</summary>
    [JsonPropertyName("allowedFqdns")]
    public IList<string>? AllowedFqdns { get; set; }

    /// <summary>The list of ips in the format of CIDR allowed to connect to the cluster.</summary>
    [JsonPropertyName("allowedIpRanges")]
    public IList<string>? AllowedIpRanges { get; set; }

    /// <summary>Specifies if the cluster could be automatically stopped (due to lack of data or no activity for many days). Defaults to true.</summary>
    [JsonPropertyName("autoStopEnabled")]
    public bool? AutoStopEnabled { get; set; }

    /// <summary>Specifies if the cluster&apos;s disks are encrypted. Defaults to false.</summary>
    [JsonPropertyName("diskEncryptionEnabled")]
    public bool? DiskEncryptionEnabled { get; set; }

    /// <summary>Is the cluster&apos;s double encryption enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("doubleEncryptionEnabled")]
    public bool? DoubleEncryptionEnabled { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ClusterSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>A language_extension block as defined below.</summary>
    [JsonPropertyName("languageExtension")]
    public IList<V1beta1ClusterSpecInitProviderLanguageExtension>? LanguageExtension { get; set; }

    [JsonPropertyName("languageExtensions")]
    public IList<V1beta1ClusterSpecInitProviderLanguageExtensions>? LanguageExtensions { get; set; }

    /// <summary>The location where the Kusto Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An optimized_auto_scale block as defined below.</summary>
    [JsonPropertyName("optimizedAutoScale")]
    public V1beta1ClusterSpecInitProviderOptimizedAutoScale? OptimizedAutoScale { get; set; }

    /// <summary>Whether to restrict outbound network access. Defaults to false.</summary>
    [JsonPropertyName("outboundNetworkAccessRestricted")]
    public bool? OutboundNetworkAccessRestricted { get; set; }

    /// <summary>Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6). Defaults to IPv4.</summary>
    [JsonPropertyName("publicIpType")]
    public string? PublicIpType { get; set; }

    /// <summary>Is the public network access enabled? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Specifies if the purge operations are enabled. Defaults to false.</summary>
    [JsonPropertyName("purgeEnabled")]
    public bool? PurgeEnabled { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public V1beta1ClusterSpecInitProviderSku? Sku { get; set; }

    /// <summary>Specifies if the streaming ingest is enabled. Defaults to false.</summary>
    [JsonPropertyName("streamingIngestionEnabled")]
    public bool? StreamingIngestionEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a list of tenant IDs that are trusted by the cluster. Default setting trusts all other tenants. Use trusted_external_tenants = [&quot;*&quot;] to explicitly allow all other tenants, trusted_external_tenants = [&quot;MyTenantOnly&quot;] for only your tenant or trusted_external_tenants = [&quot; &lt;tenantId1&gt; &quot;, &quot; &lt;tenantIdx&gt; &quot;] to allow specific other tenants.</summary>
    [JsonPropertyName("trustedExternalTenants")]
    public IList<string>? TrustedExternalTenants { get; set; }

    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta1ClusterSpecInitProviderVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kusto Cluster should be located. Changing this forces a new Kusto Cluster to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecManagementPoliciesEnum>))]
public enum V1beta1ClusterSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ClusterSpecForProvider ForProvider { get; set; }

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
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Kusto Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this System Assigned Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this System Assigned Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that is configured on this Kusto Cluster. Possible values are: SystemAssigned, UserAssigned and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLanguageExtension
{
    /// <summary>The language extension image. Possible values are Python3_11_7, Python3_11_7_DL, Python3_10_8, Python3_10_8_DL, Python3_6_5, PythonCustomImage, and R.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The name of the language extension. Possible values are PYTHON and R.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLanguageExtensions
{
    /// <summary>The language extension image. Possible values are Python3_11_7, Python3_11_7_DL, Python3_10_8, Python3_10_8_DL, Python3_6_5, PythonCustomImage, and R.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The name of the SKU. Possible values are Dev(No SLA)_Standard_D11_v2, Dev(No SLA)_Standard_E2a_v4, Standard_D14_v2, Standard_D11_v2, Standard_D16d_v5, Standard_D13_v2, Standard_D12_v2, Standard_DS14_v2+4TB_PS, Standard_DS14_v2+3TB_PS, Standard_DS13_v2+1TB_PS, Standard_DS13_v2+2TB_PS, Standard_D32d_v5, Standard_D32d_v4, Standard_EC8ads_v5, Standard_EC8as_v5+1TB_PS, Standard_EC8as_v5+2TB_PS, Standard_EC16ads_v5, Standard_EC16as_v5+4TB_PS, Standard_EC16as_v5+3TB_PS, Standard_E80ids_v4, Standard_E8a_v4, Standard_E8ads_v5, Standard_E8as_v5+1TB_PS, Standard_E8as_v5+2TB_PS, Standard_E8as_v4+1TB_PS, Standard_E8as_v4+2TB_PS, Standard_E8d_v5, Standard_E8d_v4, Standard_E8s_v5+1TB_PS, Standard_E8s_v5+2TB_PS, Standard_E8s_v4+1TB_PS, Standard_E8s_v4+2TB_PS, Standard_E4a_v4, Standard_E4ads_v5, Standard_E4d_v5, Standard_E4d_v4, Standard_E16a_v4, Standard_E16ads_v5, Standard_E16as_v5+4TB_PS, Standard_E16as_v5+3TB_PS, Standard_E16as_v4+4TB_PS, Standard_E16as_v4+3TB_PS, Standard_E16d_v5, Standard_E16d_v4, Standard_E16s_v5+4TB_PS, Standard_E16s_v5+3TB_PS, Standard_E16s_v4+4TB_PS, Standard_E16s_v4+3TB_PS, Standard_E64i_v3, Standard_E2a_v4, Standard_E2ads_v5, Standard_E2d_v5, Standard_E2d_v4, Standard_L8as_v3, Standard_L8s, Standard_L8s_v3, Standard_L8s_v2, Standard_L4s, Standard_L16as_v3, Standard_L16s, Standard_L16s_v3, Standard_L16s_v2, Standard_L32as_v3 and Standard_L32s_v3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An optimized_auto_scale block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderOptimizedAutoScale
{
    /// <summary>The maximum number of allowed instances. Possible values range between 0 and 1000.</summary>
    [JsonPropertyName("maximumInstances")]
    public double? MaximumInstances { get; set; }

    /// <summary>The minimum number of allowed instances. Possible values range between 0 and 1000.</summary>
    [JsonPropertyName("minimumInstances")]
    public double? MinimumInstances { get; set; }
}

/// <summary>A sku block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderSku
{
    /// <summary>Specifies the node count for the cluster. Boundaries depend on the SKU name.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the SKU. Possible values are Dev(No SLA)_Standard_D11_v2, Dev(No SLA)_Standard_E2a_v4, Standard_D14_v2, Standard_D11_v2, Standard_D16d_v5, Standard_D13_v2, Standard_D12_v2, Standard_DS14_v2+4TB_PS, Standard_DS14_v2+3TB_PS, Standard_DS13_v2+1TB_PS, Standard_DS13_v2+2TB_PS, Standard_D32d_v5, Standard_D32d_v4, Standard_EC8ads_v5, Standard_EC8as_v5+1TB_PS, Standard_EC8as_v5+2TB_PS, Standard_EC16ads_v5, Standard_EC16as_v5+4TB_PS, Standard_EC16as_v5+3TB_PS, Standard_E80ids_v4, Standard_E8a_v4, Standard_E8ads_v5, Standard_E8as_v5+1TB_PS, Standard_E8as_v5+2TB_PS, Standard_E8as_v4+1TB_PS, Standard_E8as_v4+2TB_PS, Standard_E8d_v5, Standard_E8d_v4, Standard_E8s_v5+1TB_PS, Standard_E8s_v5+2TB_PS, Standard_E8s_v4+1TB_PS, Standard_E8s_v4+2TB_PS, Standard_E4a_v4, Standard_E4ads_v5, Standard_E4d_v5, Standard_E4d_v4, Standard_E16a_v4, Standard_E16ads_v5, Standard_E16as_v5+4TB_PS, Standard_E16as_v5+3TB_PS, Standard_E16as_v4+4TB_PS, Standard_E16as_v4+3TB_PS, Standard_E16d_v5, Standard_E16d_v4, Standard_E16s_v5+4TB_PS, Standard_E16s_v5+3TB_PS, Standard_E16s_v4+4TB_PS, Standard_E16s_v4+3TB_PS, Standard_E64i_v3, Standard_E2a_v4, Standard_E2ads_v5, Standard_E2d_v5, Standard_E2d_v4, Standard_L8as_v3, Standard_L8s, Standard_L8s_v3, Standard_L8s_v2, Standard_L4s, Standard_L16as_v3, Standard_L16s, Standard_L16s_v3, Standard_L16s_v2, Standard_L32as_v3 and Standard_L32s_v3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVirtualNetworkConfiguration
{
    /// <summary>The Kusto Cluster ID.</summary>
    [JsonPropertyName("dataManagementPublicIpId")]
    public string? DataManagementPublicIpId { get; set; }

    /// <summary>The Kusto Cluster ID.</summary>
    [JsonPropertyName("enginePublicIpId")]
    public string? EnginePublicIpId { get; set; }

    /// <summary>The Kusto Cluster ID.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>List of allowed FQDNs (Fully Qualified Domain Name) for egress from Cluster.</summary>
    [JsonPropertyName("allowedFqdns")]
    public IList<string>? AllowedFqdns { get; set; }

    /// <summary>The list of ips in the format of CIDR allowed to connect to the cluster.</summary>
    [JsonPropertyName("allowedIpRanges")]
    public IList<string>? AllowedIpRanges { get; set; }

    /// <summary>Specifies if the cluster could be automatically stopped (due to lack of data or no activity for many days). Defaults to true.</summary>
    [JsonPropertyName("autoStopEnabled")]
    public bool? AutoStopEnabled { get; set; }

    /// <summary>The Kusto Cluster URI to be used for data ingestion.</summary>
    [JsonPropertyName("dataIngestionUri")]
    public string? DataIngestionUri { get; set; }

    /// <summary>Specifies if the cluster&apos;s disks are encrypted. Defaults to false.</summary>
    [JsonPropertyName("diskEncryptionEnabled")]
    public bool? DiskEncryptionEnabled { get; set; }

    /// <summary>Is the cluster&apos;s double encryption enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("doubleEncryptionEnabled")]
    public bool? DoubleEncryptionEnabled { get; set; }

    /// <summary>The Kusto Cluster ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ClusterStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>A language_extension block as defined below.</summary>
    [JsonPropertyName("languageExtension")]
    public IList<V1beta1ClusterStatusAtProviderLanguageExtension>? LanguageExtension { get; set; }

    [JsonPropertyName("languageExtensions")]
    public IList<V1beta1ClusterStatusAtProviderLanguageExtensions>? LanguageExtensions { get; set; }

    /// <summary>The location where the Kusto Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An optimized_auto_scale block as defined below.</summary>
    [JsonPropertyName("optimizedAutoScale")]
    public V1beta1ClusterStatusAtProviderOptimizedAutoScale? OptimizedAutoScale { get; set; }

    /// <summary>Whether to restrict outbound network access. Defaults to false.</summary>
    [JsonPropertyName("outboundNetworkAccessRestricted")]
    public bool? OutboundNetworkAccessRestricted { get; set; }

    /// <summary>Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6). Defaults to IPv4.</summary>
    [JsonPropertyName("publicIpType")]
    public string? PublicIpType { get; set; }

    /// <summary>Is the public network access enabled? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>Specifies if the purge operations are enabled. Defaults to false.</summary>
    [JsonPropertyName("purgeEnabled")]
    public bool? PurgeEnabled { get; set; }

    /// <summary>Specifies the Resource Group where the Kusto Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public V1beta1ClusterStatusAtProviderSku? Sku { get; set; }

    /// <summary>Specifies if the streaming ingest is enabled. Defaults to false.</summary>
    [JsonPropertyName("streamingIngestionEnabled")]
    public bool? StreamingIngestionEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a list of tenant IDs that are trusted by the cluster. Default setting trusts all other tenants. Use trusted_external_tenants = [&quot;*&quot;] to explicitly allow all other tenants, trusted_external_tenants = [&quot;MyTenantOnly&quot;] for only your tenant or trusted_external_tenants = [&quot; &lt;tenantId1&gt; &quot;, &quot; &lt;tenantIdx&gt; &quot;] to allow specific other tenants.</summary>
    [JsonPropertyName("trustedExternalTenants")]
    public IList<string>? TrustedExternalTenants { get; set; }

    /// <summary>The FQDN of the Azure Kusto Cluster.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta1ClusterStatusAtProviderVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kusto Cluster should be located. Changing this forces a new Kusto Cluster to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusConditions
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

/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API. Manages Kusto (also known as Azure Data Explorer) Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "kusto.azure.m.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kusto.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Cluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterStatus? Status { get; set; }
}