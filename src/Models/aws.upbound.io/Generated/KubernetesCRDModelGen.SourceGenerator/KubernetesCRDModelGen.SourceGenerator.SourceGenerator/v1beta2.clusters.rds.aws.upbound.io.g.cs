#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.rds.aws.upbound.io;
/// <summary>Cluster is the Schema for the Clusters API. Manages an RDS Aurora Cluster or a RDS Multi-AZ DB Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Cluster>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "rds.aws.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Cluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Cluster> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecDeletionPolicyEnum>))]
public enum V1beta2ClusterSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderDbClusterParameterGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderDbClusterParameterGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderDbClusterParameterGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderDbClusterParameterGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDbClusterParameterGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderDbClusterParameterGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderDbClusterParameterGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ClusterParameterGroup in rds to populate dbClusterParameterGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDbClusterParameterGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderDbClusterParameterGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ClusterParameterGroup in rds to populate dbClusterParameterGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDbClusterParameterGroupNameSelector
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
    public V1beta2ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ParameterGroup in rds to populate dbInstanceParameterGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ParameterGroup in rds to populate dbInstanceParameterGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameSelector
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
    public V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderDbSubnetGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderDbSubnetGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderDbSubnetGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderDbSubnetGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDbSubnetGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderDbSubnetGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderDbSubnetGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDbSubnetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderDbSubnetGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderDbSubnetGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderDbSubnetGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderDbSubnetGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderDbSubnetGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDbSubnetGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderDbSubnetGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderDbSubnetGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderDbSubnetGroupNameSelector
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
    public V1beta2ClusterSpecForProviderDbSubnetGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderKmsKeyIdSelector
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
    public V1beta2ClusterSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Please refer to the RDS Naming Constraints. Cannot be set if manage_master_user_password is set to true.
/// Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderMasterPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Only required unless manage_master_user_password is set to true, a snapshot_identifier, replication_source_identifier, or master_password is provided or unless a global_cluster_identifier is provided when the cluster is the &quot;secondary&quot; cluster of a global database) Password for the master DB user. Note that this may show up in logs. Please refer to the RDS Naming Constraints. Cannot be set if manage_master_user_password is set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderMasterPasswordWoSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate masterUserSecretKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate masterUserSecretKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdSelector
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
    public V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderMonitoringRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderMonitoringRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderMonitoringRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderMonitoringRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderMonitoringRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderMonitoringRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderMonitoringRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate monitoringRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderMonitoringRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderMonitoringRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderMonitoringRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderMonitoringRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderMonitoringRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderMonitoringRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderMonitoringRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderMonitoringRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderMonitoringRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate monitoringRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderMonitoringRoleArnSelector
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
    public V1beta2ClusterSpecForProviderMonitoringRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in rds to populate sourceClusterIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in rds to populate sourceClusterIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierSelector
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
    public V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested attribute for point in time restore. More details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderRestoreToPointInTime
{
    /// <summary>Date and time in UTC format to restore the database cluster to. Conflicts with use_latest_restorable_time.</summary>
    [JsonPropertyName("restoreToTime")]
    public string? RestoreToTime { get; set; }

    /// <summary>
    /// Type of restore to be performed.
    /// Valid options are full-copy (default) and copy-on-write.
    /// </summary>
    [JsonPropertyName("restoreType")]
    public string? RestoreType { get; set; }

    /// <summary>Identifier of the source database cluster from which to restore. When restoring from a cluster in another AWS account, the identifier is the ARN of that cluster.</summary>
    [JsonPropertyName("sourceClusterIdentifier")]
    public string? SourceClusterIdentifier { get; set; }

    /// <summary>Reference to a Cluster in rds to populate sourceClusterIdentifier.</summary>
    [JsonPropertyName("sourceClusterIdentifierRef")]
    public V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierRef? SourceClusterIdentifierRef { get; set; }

    /// <summary>Selector for a Cluster in rds to populate sourceClusterIdentifier.</summary>
    [JsonPropertyName("sourceClusterIdentifierSelector")]
    public V1beta2ClusterSpecForProviderRestoreToPointInTimeSourceClusterIdentifierSelector? SourceClusterIdentifierSelector { get; set; }

    /// <summary>Cluster resource ID of the source database cluster from which to restore. To be used for restoring a deleted cluster in the same account which still has a retained automatic backup available.</summary>
    [JsonPropertyName("sourceClusterResourceId")]
    public string? SourceClusterResourceId { get; set; }

    /// <summary>Set to true to restore the database cluster to the latest restorable backup time. Defaults to false. Conflicts with restore_to_time.</summary>
    [JsonPropertyName("useLatestRestorableTime")]
    public bool? UseLatestRestorableTime { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderS3ImportBucketNameRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderS3ImportBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderS3ImportBucketNameRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderS3ImportBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderS3ImportBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderS3ImportBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderS3ImportBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderS3ImportBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderS3ImportBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderS3ImportBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderS3ImportBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderS3ImportBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderS3ImportBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderS3ImportBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderS3ImportBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderS3ImportBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderS3ImportBucketNameSelector
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
    public V1beta2ClusterSpecForProviderS3ImportBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Port on which the DB accepts connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderS3Import
{
    /// <summary>Bucket name where your backup is stored</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta2ClusterSpecForProviderS3ImportBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta2ClusterSpecForProviderS3ImportBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Can be blank, but is the path to your backup</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Role applied to load the data.</summary>
    [JsonPropertyName("ingestionRole")]
    public string? IngestionRole { get; set; }

    /// <summary>Source engine for the backup</summary>
    [JsonPropertyName("sourceEngine")]
    public string? SourceEngine { get; set; }

    /// <summary>Version of the source engine used to make the backup</summary>
    [JsonPropertyName("sourceEngineVersion")]
    public string? SourceEngineVersion { get; set; }
}

/// <summary>Nested attribute with scaling properties. Only valid when engine_mode is set to serverless. More details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderScalingConfiguration
{
    /// <summary>Whether to enable automatic pause. A DB cluster can be paused only when it&apos;s idle (it has no connections). If a DB cluster is paused for more than seven days, the DB cluster might be backed up with a snapshot. In this case, the DB cluster is restored when there is a request to connect to it. Defaults to true.</summary>
    [JsonPropertyName("autoPause")]
    public bool? AutoPause { get; set; }

    /// <summary>Maximum capacity for an Aurora DB cluster in serverless DB engine mode. The maximum capacity must be greater than or equal to the minimum capacity. Valid Aurora MySQL capacity values are 1, 2, 4, 8, 16, 32, 64, 128, 256. Valid Aurora PostgreSQL capacity values are (2, 4, 8, 16, 32, 64, 192, and 384). Defaults to 16.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity for an Aurora DB cluster in serverless DB engine mode. The minimum capacity must be lesser than or equal to the maximum capacity. Valid Aurora MySQL capacity values are 1, 2, 4, 8, 16, 32, 64, 128, 256. Valid Aurora PostgreSQL capacity values are (2, 4, 8, 16, 32, 64, 192, and 384). Defaults to 1.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>Amount of time, in seconds, that Aurora Serverless v1 tries to find a scaling point to perform seamless scaling before enforcing the timeout action. Valid values are 60 through 600. Defaults to 300.</summary>
    [JsonPropertyName("secondsBeforeTimeout")]
    public double? SecondsBeforeTimeout { get; set; }

    /// <summary>Time, in seconds, before an Aurora DB cluster in serverless mode is paused. Valid values are 300 through 86400. Defaults to 300.</summary>
    [JsonPropertyName("secondsUntilAutoPause")]
    public double? SecondsUntilAutoPause { get; set; }

    /// <summary>Action to take when the timeout is reached. Valid values: ForceApplyCapacityChange, RollbackCapacityChange. Defaults to RollbackCapacityChange. See documentation.</summary>
    [JsonPropertyName("timeoutAction")]
    public string? TimeoutAction { get; set; }
}

/// <summary>Nested attribute with scaling properties for ServerlessV2. Only valid when engine_mode is set to provisioned. More details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderServerlessv2ScalingConfiguration
{
    /// <summary>Maximum capacity for an Aurora DB cluster in serverless DB engine mode. The maximum capacity must be greater than or equal to the minimum capacity. Valid Aurora MySQL capacity values are 1, 2, 4, 8, 16, 32, 64, 128, 256. Valid Aurora PostgreSQL capacity values are (2, 4, 8, 16, 32, 64, 192, and 384). Defaults to 16.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity for an Aurora DB cluster in serverless DB engine mode. The minimum capacity must be lesser than or equal to the maximum capacity. Valid Aurora MySQL capacity values are 1, 2, 4, 8, 16, 32, 64, 128, 256. Valid Aurora PostgreSQL capacity values are (2, 4, 8, 16, 32, 64, 192, and 384). Defaults to 1.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>Time, in seconds, before an Aurora DB cluster in serverless mode is paused. Valid values are 300 through 86400. Defaults to 300.</summary>
    [JsonPropertyName("secondsUntilAutoPause")]
    public double? SecondsUntilAutoPause { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVpcSecurityGroupIdSelector
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
    public V1beta2ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProvider
{
    /// <summary>The amount of storage in gibibytes (GiB) to allocate to each DB instance in the Multi-AZ DB cluster.</summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>Enable to allow major engine version upgrades when changing engine versions. Defaults to false.</summary>
    [JsonPropertyName("allowMajorVersionUpgrade")]
    public bool? AllowMajorVersionUpgrade { get; set; }

    /// <summary>Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is false. See Amazon RDS Documentation for more information.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>If true, the password will be auto-generated and stored in the Secret referenced by the masterPasswordSecretRef field.</summary>
    [JsonPropertyName("autoGeneratePassword")]
    public bool? AutoGeneratePassword { get; set; }

    /// <summary>
    /// List of EC2 Availability Zones for the DB cluster storage where DB cluster instances can be created.
    /// We recommend specifying 3 AZs or using the  if necessary.
    /// A maximum of 3 AZs can be configured.
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Target backtrack window, in seconds. Only available for aurora and aurora-mysql engines currently. To disable backtracking, set this value to 0. Defaults to 0. Must be between 0 and 259200 (72 hours)</summary>
    [JsonPropertyName("backtrackWindow")]
    public double? BacktrackWindow { get; set; }

    /// <summary>Days to retain backups for. Default 1</summary>
    [JsonPropertyName("backupRetentionPeriod")]
    public double? BackupRetentionPeriod { get; set; }

    /// <summary>The CA certificate identifier to use for the DB cluster&apos;s server certificate.</summary>
    [JsonPropertyName("caCertificateIdentifier")]
    public string? CaCertificateIdentifier { get; set; }

    /// <summary>List of RDS Instances that are a part of this cluster</summary>
    [JsonPropertyName("clusterMembers")]
    public IList<string>? ClusterMembers { get; set; }

    /// <summary>Specifies the scalability mode of the Aurora DB cluster. When set to limitless, the cluster operates as an Aurora Limitless Database. When set to standard (the default), the cluster uses normal DB instance creation. Valid values: limitless, standard.</summary>
    [JsonPropertyName("clusterScalabilityType")]
    public string? ClusterScalabilityType { get; set; }

    /// <summary>Copy all Cluster tags to snapshots. Default is false.</summary>
    [JsonPropertyName("copyTagsToSnapshot")]
    public bool? CopyTagsToSnapshot { get; set; }

    /// <summary>The mode of Database Insights to enable for the DB cluster. Valid values: standard, advanced.</summary>
    [JsonPropertyName("databaseInsightsMode")]
    public string? DatabaseInsightsMode { get; set; }

    /// <summary>Name for an automatically created database on cluster creation. There are different naming restrictions per database engine: RDS Naming Constraints</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The compute and memory capacity of each DB instance in the Multi-AZ DB cluster, for example db.m6g.xlarge. Not all DB instance classes are available in all AWS Regions, or for all database engines. For the full list of DB instance classes and availability for your engine, see DB instance class in the Amazon RDS User Guide.</summary>
    [JsonPropertyName("dbClusterInstanceClass")]
    public string? DbClusterInstanceClass { get; set; }

    /// <summary>A cluster parameter group to associate with the cluster.</summary>
    [JsonPropertyName("dbClusterParameterGroupName")]
    public string? DbClusterParameterGroupName { get; set; }

    /// <summary>Reference to a ClusterParameterGroup in rds to populate dbClusterParameterGroupName.</summary>
    [JsonPropertyName("dbClusterParameterGroupNameRef")]
    public V1beta2ClusterSpecForProviderDbClusterParameterGroupNameRef? DbClusterParameterGroupNameRef { get; set; }

    /// <summary>Selector for a ClusterParameterGroup in rds to populate dbClusterParameterGroupName.</summary>
    [JsonPropertyName("dbClusterParameterGroupNameSelector")]
    public V1beta2ClusterSpecForProviderDbClusterParameterGroupNameSelector? DbClusterParameterGroupNameSelector { get; set; }

    /// <summary>Instance parameter group to associate with all instances of the DB cluster. The db_instance_parameter_group_name parameter is only valid in combination with the allow_major_version_upgrade parameter.</summary>
    [JsonPropertyName("dbInstanceParameterGroupName")]
    public string? DbInstanceParameterGroupName { get; set; }

    /// <summary>Reference to a ParameterGroup in rds to populate dbInstanceParameterGroupName.</summary>
    [JsonPropertyName("dbInstanceParameterGroupNameRef")]
    public V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameRef? DbInstanceParameterGroupNameRef { get; set; }

    /// <summary>Selector for a ParameterGroup in rds to populate dbInstanceParameterGroupName.</summary>
    [JsonPropertyName("dbInstanceParameterGroupNameSelector")]
    public V1beta2ClusterSpecForProviderDbInstanceParameterGroupNameSelector? DbInstanceParameterGroupNameSelector { get; set; }

    /// <summary>
    /// DB subnet group to associate with this DB cluster.
    /// NOTE: This must match the db_subnet_group_name specified on every aws_rds_cluster_instance in the cluster.
    /// </summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>Reference to a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
    [JsonPropertyName("dbSubnetGroupNameRef")]
    public V1beta2ClusterSpecForProviderDbSubnetGroupNameRef? DbSubnetGroupNameRef { get; set; }

    /// <summary>Selector for a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
    [JsonPropertyName("dbSubnetGroupNameSelector")]
    public V1beta2ClusterSpecForProviderDbSubnetGroupNameSelector? DbSubnetGroupNameSelector { get; set; }

    /// <summary>For use with RDS Custom.</summary>
    [JsonPropertyName("dbSystemId")]
    public string? DbSystemId { get; set; }

    /// <summary>Specifies whether to remove automated backups immediately after the DB cluster is deleted. Default is true.</summary>
    [JsonPropertyName("deleteAutomatedBackups")]
    public bool? DeleteAutomatedBackups { get; set; }

    /// <summary>
    /// If the DB cluster should have deletion protection enabled.
    /// The database can&apos;t be deleted when this value is set to true.
    /// The default is false.
    /// </summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The ID of the Directory Service Active Directory domain to create the cluster in.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The name of the IAM role to be used when making API calls to the Directory Service.</summary>
    [JsonPropertyName("domainIamRoleName")]
    public string? DomainIamRoleName { get; set; }

    /// <summary>Whether cluster should forward writes to an associated global cluster. Applied to secondary clusters to enable them to forward writes to an aws_rds_global_cluster&apos;s primary cluster. See the User Guide for Aurora for more information.</summary>
    [JsonPropertyName("enableGlobalWriteForwarding")]
    public bool? EnableGlobalWriteForwarding { get; set; }

    /// <summary>Enable HTTP endpoint (data API). Only valid for some combinations of engine_mode, engine and engine_version and only available in some regions. See the Region and version availability section of the documentation. This option also does not work with any of these options specified: snapshot_identifier, replication_source_identifier, s3_import.</summary>
    [JsonPropertyName("enableHttpEndpoint")]
    public bool? EnableHttpEndpoint { get; set; }

    /// <summary>Whether read replicas can forward write operations to the writer DB instance in the DB cluster. By default, write operations aren&apos;t allowed on reader DB instances. See the User Guide for Aurora for more information. NOTE: Local write forwarding requires Aurora MySQL version 3.04 or higher.</summary>
    [JsonPropertyName("enableLocalWriteForwarding")]
    public bool? EnableLocalWriteForwarding { get; set; }

    /// <summary>Set of log types to export to cloudwatch. If omitted, no logs will be exported. The following log types are supported: audit, error, general, iam-db-auth-error, instance, postgresql (PostgreSQL), slowquery.</summary>
    [JsonPropertyName("enabledCloudwatchLogsExports")]
    public IList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>Name of the database engine to be used for this DB cluster. Valid Values: aurora-mysql, aurora-postgresql, mysql, postgres. (Note that mysql and postgres are Multi-AZ RDS clusters).</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The life cycle type for this DB instance. This setting is valid for cluster types Aurora DB clusters and Multi-AZ DB clusters. Valid values are open-source-rds-extended-support, open-source-rds-extended-support-disabled. Default value is open-source-rds-extended-support. [Using Amazon RDS Extended Support]: https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/extended-support.html</summary>
    [JsonPropertyName("engineLifecycleSupport")]
    public string? EngineLifecycleSupport { get; set; }

    /// <summary>Database engine mode. Valid values: global (only valid for Aurora MySQL 1.21 and earlier), parallelquery, provisioned, serverless. Defaults to: provisioned. Specify an empty value (&quot; &quot;) for no engine mode. See the RDS User Guide for limitations when using serverless.</summary>
    [JsonPropertyName("engineMode")]
    public string? EngineMode { get; set; }

    /// <summary>Database engine version. Updating this argument results in an outage. See the Aurora MySQL and Aurora Postgres documentation for your configured engine to determine this value, or by running aws rds describe-db-engine-versions. For example with Aurora MySQL 2, a potential value for this argument is 5.7.mysql_aurora.2.03.2. The value can contain a partial version where supported by the API. The actual engine version used is returned in the attribute engine_version_actual, see Attribute Reference below.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Name of your final DB snapshot when this DB cluster is deleted. If omitted, no final snapshot will be made.</summary>
    [JsonPropertyName("finalSnapshotIdentifier")]
    public string? FinalSnapshotIdentifier { get; set; }

    /// <summary>Global cluster identifier specified on aws_rds_global_cluster.</summary>
    [JsonPropertyName("globalClusterIdentifier")]
    public string? GlobalClusterIdentifier { get; set; }

    /// <summary>Specifies whether or not mappings of AWS Identity and Access Management (IAM) accounts to database accounts is enabled. Please see AWS Documentation for availability and limitations.</summary>
    [JsonPropertyName("iamDatabaseAuthenticationEnabled")]
    public bool? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>Amount of Provisioned IOPS (input/output operations per second) to be initially allocated for each DB instance in the Multi-AZ DB cluster. For information about valid Iops values, see Amazon RDS Provisioned IOPS storage to improve performance in the Amazon RDS User Guide. (This setting is required to create a Multi-AZ DB cluster). Must be a multiple between .5 and 50 of the storage amount for the DB cluster.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>ARN for the KMS encryption key. When specifying kms_key_id, storage_encrypted needs to be set to true.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2ClusterSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2ClusterSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Set to true to allow RDS to manage the master user password in Secrets Manager. Cannot be set if master_password is provided.</summary>
    [JsonPropertyName("manageMasterUserPassword")]
    public bool? ManageMasterUserPassword { get; set; }

    /// <summary>
    /// Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Please refer to the RDS Naming Constraints. Cannot be set if manage_master_user_password is set to true.
    /// Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.
    /// </summary>
    [JsonPropertyName("masterPasswordSecretRef")]
    public V1beta2ClusterSpecForProviderMasterPasswordSecretRef? MasterPasswordSecretRef { get; set; }

    /// <summary>Only required unless manage_master_user_password is set to true, a snapshot_identifier, replication_source_identifier, or master_password is provided or unless a global_cluster_identifier is provided when the cluster is the &quot;secondary&quot; cluster of a global database) Password for the master DB user. Note that this may show up in logs. Please refer to the RDS Naming Constraints. Cannot be set if manage_master_user_password is set to true.</summary>
    [JsonPropertyName("masterPasswordWoSecretRef")]
    public V1beta2ClusterSpecForProviderMasterPasswordWoSecretRef? MasterPasswordWoSecretRef { get; set; }

    /// <summary>Used together with master_password_wo to trigger an update. Increment this value when an update to the master_password_wo is required.</summary>
    [JsonPropertyName("masterPasswordWoVersion")]
    public double? MasterPasswordWoVersion { get; set; }

    /// <summary>Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the KMS key. To use a KMS key in a different Amazon Web Services account, specify the key ARN or alias ARN. If not specified, the default KMS key for your Amazon Web Services account is used.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyId")]
    public string? MasterUserSecretKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate masterUserSecretKmsKeyId.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyIdRef")]
    public V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdRef? MasterUserSecretKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate masterUserSecretKmsKeyId.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyIdSelector")]
    public V1beta2ClusterSpecForProviderMasterUserSecretKmsKeyIdSelector? MasterUserSecretKmsKeyIdSelector { get; set; }

    /// <summary>Username for the master DB user. Please refer to the RDS Naming Constraints. This argument does not support in-place updates and cannot be changed during a restore from snapshot.</summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>Interval, in seconds, between points when Enhanced Monitoring metrics are collected for the DB cluster. To turn off collecting Enhanced Monitoring metrics, specify 0. The default is 0. Valid Values: 0, 1, 5, 10, 15, 30, 60.</summary>
    [JsonPropertyName("monitoringInterval")]
    public double? MonitoringInterval { get; set; }

    /// <summary>ARN for the IAM role that permits RDS to send enhanced monitoring metrics to CloudWatch Logs. You can find more information on the AWS Documentation what IAM permissions are needed to allow Enhanced Monitoring for RDS Clusters.</summary>
    [JsonPropertyName("monitoringRoleArn")]
    public string? MonitoringRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate monitoringRoleArn.</summary>
    [JsonPropertyName("monitoringRoleArnRef")]
    public V1beta2ClusterSpecForProviderMonitoringRoleArnRef? MonitoringRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate monitoringRoleArn.</summary>
    [JsonPropertyName("monitoringRoleArnSelector")]
    public V1beta2ClusterSpecForProviderMonitoringRoleArnSelector? MonitoringRoleArnSelector { get; set; }

    /// <summary>Network type of the cluster. Valid values: IPV4, DUAL.</summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>Enables Performance Insights.</summary>
    [JsonPropertyName("performanceInsightsEnabled")]
    public bool? PerformanceInsightsEnabled { get; set; }

    /// <summary>Specifies the KMS Key ID to encrypt Performance Insights data. If not specified, the default RDS KMS key will be used (aws/rds).</summary>
    [JsonPropertyName("performanceInsightsKmsKeyId")]
    public string? PerformanceInsightsKmsKeyId { get; set; }

    /// <summary>Specifies the amount of time to retain performance insights data for. Defaults to 7 days if Performance Insights are enabled. Valid values are 7, month * 31 (where month is a number of months from 1-23), and 731. See here for more information on retention periods.</summary>
    [JsonPropertyName("performanceInsightsRetentionPeriod")]
    public double? PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>Port on which the DB accepts connections.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Daily time range during which automated backups are created if automated backups are enabled using the BackupRetentionPeriod parameter.Time in UTC. Default: A 30-minute window selected at random from an 8-hour block of time per region, e.g. 04:00-09:00.</summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>Weekly time range during which system maintenance can occur, in (UTC) e.g., wed:04:00-wed:04:30</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>ARN of a source DB cluster or DB instance if this DB cluster is to be created as a Read Replica. Note: Removing this attribute after creation will promote the read replica to a standalone cluster.</summary>
    [JsonPropertyName("replicationSourceIdentifier")]
    public string? ReplicationSourceIdentifier { get; set; }

    /// <summary>Nested attribute for point in time restore. More details below.</summary>
    [JsonPropertyName("restoreToPointInTime")]
    public V1beta2ClusterSpecForProviderRestoreToPointInTime? RestoreToPointInTime { get; set; }

    /// <summary>Port on which the DB accepts connections.</summary>
    [JsonPropertyName("s3Import")]
    public V1beta2ClusterSpecForProviderS3Import? S3Import { get; set; }

    /// <summary>Nested attribute with scaling properties. Only valid when engine_mode is set to serverless. More details below.</summary>
    [JsonPropertyName("scalingConfiguration")]
    public V1beta2ClusterSpecForProviderScalingConfiguration? ScalingConfiguration { get; set; }

    /// <summary>Nested attribute with scaling properties for ServerlessV2. Only valid when engine_mode is set to provisioned. More details below.</summary>
    [JsonPropertyName("serverlessv2ScalingConfiguration")]
    public V1beta2ClusterSpecForProviderServerlessv2ScalingConfiguration? Serverlessv2ScalingConfiguration { get; set; }

    /// <summary>Determines whether a final DB snapshot is created before the DB cluster is deleted. If true is specified, no DB snapshot is created. If false is specified, a DB snapshot is created before the DB cluster is deleted, using the value from final_snapshot_identifier. Default is false.</summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>Specifies whether or not to create this cluster from a snapshot. You can use either the name or ARN when specifying a DB cluster snapshot, or the ARN when specifying a DB snapshot. Conflicts with global_cluster_identifier. Clusters cannot be restored from snapshot and joined to an existing global cluster in a single operation. See the AWS documentation or the Global Cluster Restored From Snapshot example for instructions on building a global cluster starting with a snapshot.</summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>The source region for an encrypted replica DB cluster.</summary>
    [JsonPropertyName("sourceRegion")]
    public string? SourceRegion { get; set; }

    /// <summary>Specifies whether the DB cluster is encrypted. The default is false for provisioned engine_mode and true for serverless engine_mode. When restoring an unencrypted snapshot_identifier, the kms_key_id argument must be provided to encrypt the restored cluster.</summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>(Forces new for Multi-AZ DB clusters) Specifies the storage type to be associated with the DB cluster. For Aurora DB clusters, storage_type modifications can be done in-place. For Multi-AZ DB Clusters, the iops argument must also be set. Valid values are: &quot; &quot;, aurora-iopt1 (Aurora DB Clusters); io1, io2 (Multi-AZ DB Clusters). Default: &quot; &quot; (Aurora DB Clusters); io1 (Multi-AZ DB Clusters).</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta2ClusterSpecForProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta2ClusterSpecForProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>List of VPC security groups to associate with the Cluster</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ClusterParameterGroup in rds to populate dbClusterParameterGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ClusterParameterGroup in rds to populate dbClusterParameterGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameSelector
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
    public V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ParameterGroup in rds to populate dbInstanceParameterGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ParameterGroup in rds to populate dbInstanceParameterGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameSelector
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
    public V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderDbSubnetGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderDbSubnetGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderDbSubnetGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderDbSubnetGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDbSubnetGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderDbSubnetGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderDbSubnetGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDbSubnetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderDbSubnetGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderDbSubnetGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderDbSubnetGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderDbSubnetGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderDbSubnetGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDbSubnetGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderDbSubnetGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderDbSubnetGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderDbSubnetGroupNameSelector
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
    public V1beta2ClusterSpecInitProviderDbSubnetGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderKmsKeyIdSelector
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
    public V1beta2ClusterSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Please refer to the RDS Naming Constraints. Cannot be set if manage_master_user_password is set to true.
/// Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderMasterPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Only required unless manage_master_user_password is set to true, a snapshot_identifier, replication_source_identifier, or master_password is provided or unless a global_cluster_identifier is provided when the cluster is the &quot;secondary&quot; cluster of a global database) Password for the master DB user. Note that this may show up in logs. Please refer to the RDS Naming Constraints. Cannot be set if manage_master_user_password is set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderMasterPasswordWoSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate masterUserSecretKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate masterUserSecretKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdSelector
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
    public V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderMonitoringRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderMonitoringRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderMonitoringRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderMonitoringRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderMonitoringRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderMonitoringRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderMonitoringRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate monitoringRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderMonitoringRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderMonitoringRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderMonitoringRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderMonitoringRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderMonitoringRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderMonitoringRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderMonitoringRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderMonitoringRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderMonitoringRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate monitoringRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderMonitoringRoleArnSelector
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
    public V1beta2ClusterSpecInitProviderMonitoringRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in rds to populate sourceClusterIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in rds to populate sourceClusterIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierSelector
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
    public V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested attribute for point in time restore. More details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderRestoreToPointInTime
{
    /// <summary>Date and time in UTC format to restore the database cluster to. Conflicts with use_latest_restorable_time.</summary>
    [JsonPropertyName("restoreToTime")]
    public string? RestoreToTime { get; set; }

    /// <summary>
    /// Type of restore to be performed.
    /// Valid options are full-copy (default) and copy-on-write.
    /// </summary>
    [JsonPropertyName("restoreType")]
    public string? RestoreType { get; set; }

    /// <summary>Identifier of the source database cluster from which to restore. When restoring from a cluster in another AWS account, the identifier is the ARN of that cluster.</summary>
    [JsonPropertyName("sourceClusterIdentifier")]
    public string? SourceClusterIdentifier { get; set; }

    /// <summary>Reference to a Cluster in rds to populate sourceClusterIdentifier.</summary>
    [JsonPropertyName("sourceClusterIdentifierRef")]
    public V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierRef? SourceClusterIdentifierRef { get; set; }

    /// <summary>Selector for a Cluster in rds to populate sourceClusterIdentifier.</summary>
    [JsonPropertyName("sourceClusterIdentifierSelector")]
    public V1beta2ClusterSpecInitProviderRestoreToPointInTimeSourceClusterIdentifierSelector? SourceClusterIdentifierSelector { get; set; }

    /// <summary>Cluster resource ID of the source database cluster from which to restore. To be used for restoring a deleted cluster in the same account which still has a retained automatic backup available.</summary>
    [JsonPropertyName("sourceClusterResourceId")]
    public string? SourceClusterResourceId { get; set; }

    /// <summary>Set to true to restore the database cluster to the latest restorable backup time. Defaults to false. Conflicts with restore_to_time.</summary>
    [JsonPropertyName("useLatestRestorableTime")]
    public bool? UseLatestRestorableTime { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderS3ImportBucketNameRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderS3ImportBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderS3ImportBucketNameRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderS3ImportBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderS3ImportBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderS3ImportBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderS3ImportBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderS3ImportBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderS3ImportBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderS3ImportBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderS3ImportBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderS3ImportBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderS3ImportBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderS3ImportBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderS3ImportBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderS3ImportBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderS3ImportBucketNameSelector
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
    public V1beta2ClusterSpecInitProviderS3ImportBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Port on which the DB accepts connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderS3Import
{
    /// <summary>Bucket name where your backup is stored</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta2ClusterSpecInitProviderS3ImportBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta2ClusterSpecInitProviderS3ImportBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Can be blank, but is the path to your backup</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Role applied to load the data.</summary>
    [JsonPropertyName("ingestionRole")]
    public string? IngestionRole { get; set; }

    /// <summary>Source engine for the backup</summary>
    [JsonPropertyName("sourceEngine")]
    public string? SourceEngine { get; set; }

    /// <summary>Version of the source engine used to make the backup</summary>
    [JsonPropertyName("sourceEngineVersion")]
    public string? SourceEngineVersion { get; set; }
}

/// <summary>Nested attribute with scaling properties. Only valid when engine_mode is set to serverless. More details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderScalingConfiguration
{
    /// <summary>Whether to enable automatic pause. A DB cluster can be paused only when it&apos;s idle (it has no connections). If a DB cluster is paused for more than seven days, the DB cluster might be backed up with a snapshot. In this case, the DB cluster is restored when there is a request to connect to it. Defaults to true.</summary>
    [JsonPropertyName("autoPause")]
    public bool? AutoPause { get; set; }

    /// <summary>Maximum capacity for an Aurora DB cluster in serverless DB engine mode. The maximum capacity must be greater than or equal to the minimum capacity. Valid Aurora MySQL capacity values are 1, 2, 4, 8, 16, 32, 64, 128, 256. Valid Aurora PostgreSQL capacity values are (2, 4, 8, 16, 32, 64, 192, and 384). Defaults to 16.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity for an Aurora DB cluster in serverless DB engine mode. The minimum capacity must be lesser than or equal to the maximum capacity. Valid Aurora MySQL capacity values are 1, 2, 4, 8, 16, 32, 64, 128, 256. Valid Aurora PostgreSQL capacity values are (2, 4, 8, 16, 32, 64, 192, and 384). Defaults to 1.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>Amount of time, in seconds, that Aurora Serverless v1 tries to find a scaling point to perform seamless scaling before enforcing the timeout action. Valid values are 60 through 600. Defaults to 300.</summary>
    [JsonPropertyName("secondsBeforeTimeout")]
    public double? SecondsBeforeTimeout { get; set; }

    /// <summary>Time, in seconds, before an Aurora DB cluster in serverless mode is paused. Valid values are 300 through 86400. Defaults to 300.</summary>
    [JsonPropertyName("secondsUntilAutoPause")]
    public double? SecondsUntilAutoPause { get; set; }

    /// <summary>Action to take when the timeout is reached. Valid values: ForceApplyCapacityChange, RollbackCapacityChange. Defaults to RollbackCapacityChange. See documentation.</summary>
    [JsonPropertyName("timeoutAction")]
    public string? TimeoutAction { get; set; }
}

/// <summary>Nested attribute with scaling properties for ServerlessV2. Only valid when engine_mode is set to provisioned. More details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderServerlessv2ScalingConfiguration
{
    /// <summary>Maximum capacity for an Aurora DB cluster in serverless DB engine mode. The maximum capacity must be greater than or equal to the minimum capacity. Valid Aurora MySQL capacity values are 1, 2, 4, 8, 16, 32, 64, 128, 256. Valid Aurora PostgreSQL capacity values are (2, 4, 8, 16, 32, 64, 192, and 384). Defaults to 16.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity for an Aurora DB cluster in serverless DB engine mode. The minimum capacity must be lesser than or equal to the maximum capacity. Valid Aurora MySQL capacity values are 1, 2, 4, 8, 16, 32, 64, 128, 256. Valid Aurora PostgreSQL capacity values are (2, 4, 8, 16, 32, 64, 192, and 384). Defaults to 1.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>Time, in seconds, before an Aurora DB cluster in serverless mode is paused. Valid values are 300 through 86400. Defaults to 300.</summary>
    [JsonPropertyName("secondsUntilAutoPause")]
    public double? SecondsUntilAutoPause { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVpcSecurityGroupIdSelector
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
    public V1beta2ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2ClusterSpecInitProvider
{
    /// <summary>The amount of storage in gibibytes (GiB) to allocate to each DB instance in the Multi-AZ DB cluster.</summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>Enable to allow major engine version upgrades when changing engine versions. Defaults to false.</summary>
    [JsonPropertyName("allowMajorVersionUpgrade")]
    public bool? AllowMajorVersionUpgrade { get; set; }

    /// <summary>Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is false. See Amazon RDS Documentation for more information.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>
    /// List of EC2 Availability Zones for the DB cluster storage where DB cluster instances can be created.
    /// We recommend specifying 3 AZs or using the  if necessary.
    /// A maximum of 3 AZs can be configured.
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Target backtrack window, in seconds. Only available for aurora and aurora-mysql engines currently. To disable backtracking, set this value to 0. Defaults to 0. Must be between 0 and 259200 (72 hours)</summary>
    [JsonPropertyName("backtrackWindow")]
    public double? BacktrackWindow { get; set; }

    /// <summary>Days to retain backups for. Default 1</summary>
    [JsonPropertyName("backupRetentionPeriod")]
    public double? BackupRetentionPeriod { get; set; }

    /// <summary>The CA certificate identifier to use for the DB cluster&apos;s server certificate.</summary>
    [JsonPropertyName("caCertificateIdentifier")]
    public string? CaCertificateIdentifier { get; set; }

    /// <summary>List of RDS Instances that are a part of this cluster</summary>
    [JsonPropertyName("clusterMembers")]
    public IList<string>? ClusterMembers { get; set; }

    /// <summary>Specifies the scalability mode of the Aurora DB cluster. When set to limitless, the cluster operates as an Aurora Limitless Database. When set to standard (the default), the cluster uses normal DB instance creation. Valid values: limitless, standard.</summary>
    [JsonPropertyName("clusterScalabilityType")]
    public string? ClusterScalabilityType { get; set; }

    /// <summary>Copy all Cluster tags to snapshots. Default is false.</summary>
    [JsonPropertyName("copyTagsToSnapshot")]
    public bool? CopyTagsToSnapshot { get; set; }

    /// <summary>The mode of Database Insights to enable for the DB cluster. Valid values: standard, advanced.</summary>
    [JsonPropertyName("databaseInsightsMode")]
    public string? DatabaseInsightsMode { get; set; }

    /// <summary>Name for an automatically created database on cluster creation. There are different naming restrictions per database engine: RDS Naming Constraints</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The compute and memory capacity of each DB instance in the Multi-AZ DB cluster, for example db.m6g.xlarge. Not all DB instance classes are available in all AWS Regions, or for all database engines. For the full list of DB instance classes and availability for your engine, see DB instance class in the Amazon RDS User Guide.</summary>
    [JsonPropertyName("dbClusterInstanceClass")]
    public string? DbClusterInstanceClass { get; set; }

    /// <summary>A cluster parameter group to associate with the cluster.</summary>
    [JsonPropertyName("dbClusterParameterGroupName")]
    public string? DbClusterParameterGroupName { get; set; }

    /// <summary>Reference to a ClusterParameterGroup in rds to populate dbClusterParameterGroupName.</summary>
    [JsonPropertyName("dbClusterParameterGroupNameRef")]
    public V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameRef? DbClusterParameterGroupNameRef { get; set; }

    /// <summary>Selector for a ClusterParameterGroup in rds to populate dbClusterParameterGroupName.</summary>
    [JsonPropertyName("dbClusterParameterGroupNameSelector")]
    public V1beta2ClusterSpecInitProviderDbClusterParameterGroupNameSelector? DbClusterParameterGroupNameSelector { get; set; }

    /// <summary>Instance parameter group to associate with all instances of the DB cluster. The db_instance_parameter_group_name parameter is only valid in combination with the allow_major_version_upgrade parameter.</summary>
    [JsonPropertyName("dbInstanceParameterGroupName")]
    public string? DbInstanceParameterGroupName { get; set; }

    /// <summary>Reference to a ParameterGroup in rds to populate dbInstanceParameterGroupName.</summary>
    [JsonPropertyName("dbInstanceParameterGroupNameRef")]
    public V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameRef? DbInstanceParameterGroupNameRef { get; set; }

    /// <summary>Selector for a ParameterGroup in rds to populate dbInstanceParameterGroupName.</summary>
    [JsonPropertyName("dbInstanceParameterGroupNameSelector")]
    public V1beta2ClusterSpecInitProviderDbInstanceParameterGroupNameSelector? DbInstanceParameterGroupNameSelector { get; set; }

    /// <summary>
    /// DB subnet group to associate with this DB cluster.
    /// NOTE: This must match the db_subnet_group_name specified on every aws_rds_cluster_instance in the cluster.
    /// </summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>Reference to a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
    [JsonPropertyName("dbSubnetGroupNameRef")]
    public V1beta2ClusterSpecInitProviderDbSubnetGroupNameRef? DbSubnetGroupNameRef { get; set; }

    /// <summary>Selector for a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
    [JsonPropertyName("dbSubnetGroupNameSelector")]
    public V1beta2ClusterSpecInitProviderDbSubnetGroupNameSelector? DbSubnetGroupNameSelector { get; set; }

    /// <summary>For use with RDS Custom.</summary>
    [JsonPropertyName("dbSystemId")]
    public string? DbSystemId { get; set; }

    /// <summary>Specifies whether to remove automated backups immediately after the DB cluster is deleted. Default is true.</summary>
    [JsonPropertyName("deleteAutomatedBackups")]
    public bool? DeleteAutomatedBackups { get; set; }

    /// <summary>
    /// If the DB cluster should have deletion protection enabled.
    /// The database can&apos;t be deleted when this value is set to true.
    /// The default is false.
    /// </summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The ID of the Directory Service Active Directory domain to create the cluster in.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The name of the IAM role to be used when making API calls to the Directory Service.</summary>
    [JsonPropertyName("domainIamRoleName")]
    public string? DomainIamRoleName { get; set; }

    /// <summary>Whether cluster should forward writes to an associated global cluster. Applied to secondary clusters to enable them to forward writes to an aws_rds_global_cluster&apos;s primary cluster. See the User Guide for Aurora for more information.</summary>
    [JsonPropertyName("enableGlobalWriteForwarding")]
    public bool? EnableGlobalWriteForwarding { get; set; }

    /// <summary>Enable HTTP endpoint (data API). Only valid for some combinations of engine_mode, engine and engine_version and only available in some regions. See the Region and version availability section of the documentation. This option also does not work with any of these options specified: snapshot_identifier, replication_source_identifier, s3_import.</summary>
    [JsonPropertyName("enableHttpEndpoint")]
    public bool? EnableHttpEndpoint { get; set; }

    /// <summary>Whether read replicas can forward write operations to the writer DB instance in the DB cluster. By default, write operations aren&apos;t allowed on reader DB instances. See the User Guide for Aurora for more information. NOTE: Local write forwarding requires Aurora MySQL version 3.04 or higher.</summary>
    [JsonPropertyName("enableLocalWriteForwarding")]
    public bool? EnableLocalWriteForwarding { get; set; }

    /// <summary>Set of log types to export to cloudwatch. If omitted, no logs will be exported. The following log types are supported: audit, error, general, iam-db-auth-error, instance, postgresql (PostgreSQL), slowquery.</summary>
    [JsonPropertyName("enabledCloudwatchLogsExports")]
    public IList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>Name of the database engine to be used for this DB cluster. Valid Values: aurora-mysql, aurora-postgresql, mysql, postgres. (Note that mysql and postgres are Multi-AZ RDS clusters).</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The life cycle type for this DB instance. This setting is valid for cluster types Aurora DB clusters and Multi-AZ DB clusters. Valid values are open-source-rds-extended-support, open-source-rds-extended-support-disabled. Default value is open-source-rds-extended-support. [Using Amazon RDS Extended Support]: https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/extended-support.html</summary>
    [JsonPropertyName("engineLifecycleSupport")]
    public string? EngineLifecycleSupport { get; set; }

    /// <summary>Database engine mode. Valid values: global (only valid for Aurora MySQL 1.21 and earlier), parallelquery, provisioned, serverless. Defaults to: provisioned. Specify an empty value (&quot; &quot;) for no engine mode. See the RDS User Guide for limitations when using serverless.</summary>
    [JsonPropertyName("engineMode")]
    public string? EngineMode { get; set; }

    /// <summary>Database engine version. Updating this argument results in an outage. See the Aurora MySQL and Aurora Postgres documentation for your configured engine to determine this value, or by running aws rds describe-db-engine-versions. For example with Aurora MySQL 2, a potential value for this argument is 5.7.mysql_aurora.2.03.2. The value can contain a partial version where supported by the API. The actual engine version used is returned in the attribute engine_version_actual, see Attribute Reference below.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Name of your final DB snapshot when this DB cluster is deleted. If omitted, no final snapshot will be made.</summary>
    [JsonPropertyName("finalSnapshotIdentifier")]
    public string? FinalSnapshotIdentifier { get; set; }

    /// <summary>Global cluster identifier specified on aws_rds_global_cluster.</summary>
    [JsonPropertyName("globalClusterIdentifier")]
    public string? GlobalClusterIdentifier { get; set; }

    /// <summary>Specifies whether or not mappings of AWS Identity and Access Management (IAM) accounts to database accounts is enabled. Please see AWS Documentation for availability and limitations.</summary>
    [JsonPropertyName("iamDatabaseAuthenticationEnabled")]
    public bool? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>Amount of Provisioned IOPS (input/output operations per second) to be initially allocated for each DB instance in the Multi-AZ DB cluster. For information about valid Iops values, see Amazon RDS Provisioned IOPS storage to improve performance in the Amazon RDS User Guide. (This setting is required to create a Multi-AZ DB cluster). Must be a multiple between .5 and 50 of the storage amount for the DB cluster.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>ARN for the KMS encryption key. When specifying kms_key_id, storage_encrypted needs to be set to true.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2ClusterSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2ClusterSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Set to true to allow RDS to manage the master user password in Secrets Manager. Cannot be set if master_password is provided.</summary>
    [JsonPropertyName("manageMasterUserPassword")]
    public bool? ManageMasterUserPassword { get; set; }

    /// <summary>
    /// Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Please refer to the RDS Naming Constraints. Cannot be set if manage_master_user_password is set to true.
    /// Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.
    /// </summary>
    [JsonPropertyName("masterPasswordSecretRef")]
    public V1beta2ClusterSpecInitProviderMasterPasswordSecretRef? MasterPasswordSecretRef { get; set; }

    /// <summary>Only required unless manage_master_user_password is set to true, a snapshot_identifier, replication_source_identifier, or master_password is provided or unless a global_cluster_identifier is provided when the cluster is the &quot;secondary&quot; cluster of a global database) Password for the master DB user. Note that this may show up in logs. Please refer to the RDS Naming Constraints. Cannot be set if manage_master_user_password is set to true.</summary>
    [JsonPropertyName("masterPasswordWoSecretRef")]
    public V1beta2ClusterSpecInitProviderMasterPasswordWoSecretRef? MasterPasswordWoSecretRef { get; set; }

    /// <summary>Used together with master_password_wo to trigger an update. Increment this value when an update to the master_password_wo is required.</summary>
    [JsonPropertyName("masterPasswordWoVersion")]
    public double? MasterPasswordWoVersion { get; set; }

    /// <summary>Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the KMS key. To use a KMS key in a different Amazon Web Services account, specify the key ARN or alias ARN. If not specified, the default KMS key for your Amazon Web Services account is used.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyId")]
    public string? MasterUserSecretKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate masterUserSecretKmsKeyId.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyIdRef")]
    public V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdRef? MasterUserSecretKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate masterUserSecretKmsKeyId.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyIdSelector")]
    public V1beta2ClusterSpecInitProviderMasterUserSecretKmsKeyIdSelector? MasterUserSecretKmsKeyIdSelector { get; set; }

    /// <summary>Username for the master DB user. Please refer to the RDS Naming Constraints. This argument does not support in-place updates and cannot be changed during a restore from snapshot.</summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>Interval, in seconds, between points when Enhanced Monitoring metrics are collected for the DB cluster. To turn off collecting Enhanced Monitoring metrics, specify 0. The default is 0. Valid Values: 0, 1, 5, 10, 15, 30, 60.</summary>
    [JsonPropertyName("monitoringInterval")]
    public double? MonitoringInterval { get; set; }

    /// <summary>ARN for the IAM role that permits RDS to send enhanced monitoring metrics to CloudWatch Logs. You can find more information on the AWS Documentation what IAM permissions are needed to allow Enhanced Monitoring for RDS Clusters.</summary>
    [JsonPropertyName("monitoringRoleArn")]
    public string? MonitoringRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate monitoringRoleArn.</summary>
    [JsonPropertyName("monitoringRoleArnRef")]
    public V1beta2ClusterSpecInitProviderMonitoringRoleArnRef? MonitoringRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate monitoringRoleArn.</summary>
    [JsonPropertyName("monitoringRoleArnSelector")]
    public V1beta2ClusterSpecInitProviderMonitoringRoleArnSelector? MonitoringRoleArnSelector { get; set; }

    /// <summary>Network type of the cluster. Valid values: IPV4, DUAL.</summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>Enables Performance Insights.</summary>
    [JsonPropertyName("performanceInsightsEnabled")]
    public bool? PerformanceInsightsEnabled { get; set; }

    /// <summary>Specifies the KMS Key ID to encrypt Performance Insights data. If not specified, the default RDS KMS key will be used (aws/rds).</summary>
    [JsonPropertyName("performanceInsightsKmsKeyId")]
    public string? PerformanceInsightsKmsKeyId { get; set; }

    /// <summary>Specifies the amount of time to retain performance insights data for. Defaults to 7 days if Performance Insights are enabled. Valid values are 7, month * 31 (where month is a number of months from 1-23), and 731. See here for more information on retention periods.</summary>
    [JsonPropertyName("performanceInsightsRetentionPeriod")]
    public double? PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>Port on which the DB accepts connections.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Daily time range during which automated backups are created if automated backups are enabled using the BackupRetentionPeriod parameter.Time in UTC. Default: A 30-minute window selected at random from an 8-hour block of time per region, e.g. 04:00-09:00.</summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>Weekly time range during which system maintenance can occur, in (UTC) e.g., wed:04:00-wed:04:30</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>ARN of a source DB cluster or DB instance if this DB cluster is to be created as a Read Replica. Note: Removing this attribute after creation will promote the read replica to a standalone cluster.</summary>
    [JsonPropertyName("replicationSourceIdentifier")]
    public string? ReplicationSourceIdentifier { get; set; }

    /// <summary>Nested attribute for point in time restore. More details below.</summary>
    [JsonPropertyName("restoreToPointInTime")]
    public V1beta2ClusterSpecInitProviderRestoreToPointInTime? RestoreToPointInTime { get; set; }

    /// <summary>Port on which the DB accepts connections.</summary>
    [JsonPropertyName("s3Import")]
    public V1beta2ClusterSpecInitProviderS3Import? S3Import { get; set; }

    /// <summary>Nested attribute with scaling properties. Only valid when engine_mode is set to serverless. More details below.</summary>
    [JsonPropertyName("scalingConfiguration")]
    public V1beta2ClusterSpecInitProviderScalingConfiguration? ScalingConfiguration { get; set; }

    /// <summary>Nested attribute with scaling properties for ServerlessV2. Only valid when engine_mode is set to provisioned. More details below.</summary>
    [JsonPropertyName("serverlessv2ScalingConfiguration")]
    public V1beta2ClusterSpecInitProviderServerlessv2ScalingConfiguration? Serverlessv2ScalingConfiguration { get; set; }

    /// <summary>Determines whether a final DB snapshot is created before the DB cluster is deleted. If true is specified, no DB snapshot is created. If false is specified, a DB snapshot is created before the DB cluster is deleted, using the value from final_snapshot_identifier. Default is false.</summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>Specifies whether or not to create this cluster from a snapshot. You can use either the name or ARN when specifying a DB cluster snapshot, or the ARN when specifying a DB snapshot. Conflicts with global_cluster_identifier. Clusters cannot be restored from snapshot and joined to an existing global cluster in a single operation. See the AWS documentation or the Global Cluster Restored From Snapshot example for instructions on building a global cluster starting with a snapshot.</summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>The source region for an encrypted replica DB cluster.</summary>
    [JsonPropertyName("sourceRegion")]
    public string? SourceRegion { get; set; }

    /// <summary>Specifies whether the DB cluster is encrypted. The default is false for provisioned engine_mode and true for serverless engine_mode. When restoring an unencrypted snapshot_identifier, the kms_key_id argument must be provided to encrypt the restored cluster.</summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>(Forces new for Multi-AZ DB clusters) Specifies the storage type to be associated with the DB cluster. For Aurora DB clusters, storage_type modifications can be done in-place. For Multi-AZ DB Clusters, the iops argument must also be set. Valid values are: &quot; &quot;, aurora-iopt1 (Aurora DB Clusters); io1, io2 (Multi-AZ DB Clusters). Default: &quot; &quot; (Aurora DB Clusters); io1 (Multi-AZ DB Clusters).</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta2ClusterSpecInitProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta2ClusterSpecInitProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>List of VPC security groups to associate with the Cluster</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecManagementPoliciesEnum>))]
public enum V1beta2ClusterSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpec
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
    public V1beta2ClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ClusterSpecForProvider ForProvider { get; set; }

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
    public V1beta2ClusterSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderMasterUserSecret
{
    /// <summary>Amazon Web Services KMS key identifier that is used to encrypt the secret.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the secret.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Status of the secret. Valid Values: creating | active | rotating | impaired.</summary>
    [JsonPropertyName("secretStatus")]
    public string? SecretStatus { get; set; }
}

/// <summary>Nested attribute for point in time restore. More details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderRestoreToPointInTime
{
    /// <summary>Date and time in UTC format to restore the database cluster to. Conflicts with use_latest_restorable_time.</summary>
    [JsonPropertyName("restoreToTime")]
    public string? RestoreToTime { get; set; }

    /// <summary>
    /// Type of restore to be performed.
    /// Valid options are full-copy (default) and copy-on-write.
    /// </summary>
    [JsonPropertyName("restoreType")]
    public string? RestoreType { get; set; }

    /// <summary>Identifier of the source database cluster from which to restore. When restoring from a cluster in another AWS account, the identifier is the ARN of that cluster.</summary>
    [JsonPropertyName("sourceClusterIdentifier")]
    public string? SourceClusterIdentifier { get; set; }

    /// <summary>Cluster resource ID of the source database cluster from which to restore. To be used for restoring a deleted cluster in the same account which still has a retained automatic backup available.</summary>
    [JsonPropertyName("sourceClusterResourceId")]
    public string? SourceClusterResourceId { get; set; }

    /// <summary>Set to true to restore the database cluster to the latest restorable backup time. Defaults to false. Conflicts with restore_to_time.</summary>
    [JsonPropertyName("useLatestRestorableTime")]
    public bool? UseLatestRestorableTime { get; set; }
}

/// <summary>Port on which the DB accepts connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderS3Import
{
    /// <summary>Bucket name where your backup is stored</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Can be blank, but is the path to your backup</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Role applied to load the data.</summary>
    [JsonPropertyName("ingestionRole")]
    public string? IngestionRole { get; set; }

    /// <summary>Source engine for the backup</summary>
    [JsonPropertyName("sourceEngine")]
    public string? SourceEngine { get; set; }

    /// <summary>Version of the source engine used to make the backup</summary>
    [JsonPropertyName("sourceEngineVersion")]
    public string? SourceEngineVersion { get; set; }
}

/// <summary>Nested attribute with scaling properties. Only valid when engine_mode is set to serverless. More details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderScalingConfiguration
{
    /// <summary>Whether to enable automatic pause. A DB cluster can be paused only when it&apos;s idle (it has no connections). If a DB cluster is paused for more than seven days, the DB cluster might be backed up with a snapshot. In this case, the DB cluster is restored when there is a request to connect to it. Defaults to true.</summary>
    [JsonPropertyName("autoPause")]
    public bool? AutoPause { get; set; }

    /// <summary>Maximum capacity for an Aurora DB cluster in serverless DB engine mode. The maximum capacity must be greater than or equal to the minimum capacity. Valid Aurora MySQL capacity values are 1, 2, 4, 8, 16, 32, 64, 128, 256. Valid Aurora PostgreSQL capacity values are (2, 4, 8, 16, 32, 64, 192, and 384). Defaults to 16.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity for an Aurora DB cluster in serverless DB engine mode. The minimum capacity must be lesser than or equal to the maximum capacity. Valid Aurora MySQL capacity values are 1, 2, 4, 8, 16, 32, 64, 128, 256. Valid Aurora PostgreSQL capacity values are (2, 4, 8, 16, 32, 64, 192, and 384). Defaults to 1.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>Amount of time, in seconds, that Aurora Serverless v1 tries to find a scaling point to perform seamless scaling before enforcing the timeout action. Valid values are 60 through 600. Defaults to 300.</summary>
    [JsonPropertyName("secondsBeforeTimeout")]
    public double? SecondsBeforeTimeout { get; set; }

    /// <summary>Time, in seconds, before an Aurora DB cluster in serverless mode is paused. Valid values are 300 through 86400. Defaults to 300.</summary>
    [JsonPropertyName("secondsUntilAutoPause")]
    public double? SecondsUntilAutoPause { get; set; }

    /// <summary>Action to take when the timeout is reached. Valid values: ForceApplyCapacityChange, RollbackCapacityChange. Defaults to RollbackCapacityChange. See documentation.</summary>
    [JsonPropertyName("timeoutAction")]
    public string? TimeoutAction { get; set; }
}

/// <summary>Nested attribute with scaling properties for ServerlessV2. Only valid when engine_mode is set to provisioned. More details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderServerlessv2ScalingConfiguration
{
    /// <summary>Maximum capacity for an Aurora DB cluster in serverless DB engine mode. The maximum capacity must be greater than or equal to the minimum capacity. Valid Aurora MySQL capacity values are 1, 2, 4, 8, 16, 32, 64, 128, 256. Valid Aurora PostgreSQL capacity values are (2, 4, 8, 16, 32, 64, 192, and 384). Defaults to 16.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity for an Aurora DB cluster in serverless DB engine mode. The minimum capacity must be lesser than or equal to the maximum capacity. Valid Aurora MySQL capacity values are 1, 2, 4, 8, 16, 32, 64, 128, 256. Valid Aurora PostgreSQL capacity values are (2, 4, 8, 16, 32, 64, 192, and 384). Defaults to 1.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>Time, in seconds, before an Aurora DB cluster in serverless mode is paused. Valid values are 300 through 86400. Defaults to 300.</summary>
    [JsonPropertyName("secondsUntilAutoPause")]
    public double? SecondsUntilAutoPause { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProvider
{
    /// <summary>The amount of storage in gibibytes (GiB) to allocate to each DB instance in the Multi-AZ DB cluster.</summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>Enable to allow major engine version upgrades when changing engine versions. Defaults to false.</summary>
    [JsonPropertyName("allowMajorVersionUpgrade")]
    public bool? AllowMajorVersionUpgrade { get; set; }

    /// <summary>Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is false. See Amazon RDS Documentation for more information.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>Amazon Resource Name (ARN) of cluster</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// List of EC2 Availability Zones for the DB cluster storage where DB cluster instances can be created.
    /// We recommend specifying 3 AZs or using the  if necessary.
    /// A maximum of 3 AZs can be configured.
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Target backtrack window, in seconds. Only available for aurora and aurora-mysql engines currently. To disable backtracking, set this value to 0. Defaults to 0. Must be between 0 and 259200 (72 hours)</summary>
    [JsonPropertyName("backtrackWindow")]
    public double? BacktrackWindow { get; set; }

    /// <summary>Days to retain backups for. Default 1</summary>
    [JsonPropertyName("backupRetentionPeriod")]
    public double? BackupRetentionPeriod { get; set; }

    /// <summary>The CA certificate identifier to use for the DB cluster&apos;s server certificate.</summary>
    [JsonPropertyName("caCertificateIdentifier")]
    public string? CaCertificateIdentifier { get; set; }

    /// <summary>Expiration date of the DB instance’s server certificate</summary>
    [JsonPropertyName("caCertificateValidTill")]
    public string? CaCertificateValidTill { get; set; }

    /// <summary>List of RDS Instances that are a part of this cluster</summary>
    [JsonPropertyName("clusterMembers")]
    public IList<string>? ClusterMembers { get; set; }

    /// <summary>RDS Cluster Resource ID</summary>
    [JsonPropertyName("clusterResourceId")]
    public string? ClusterResourceId { get; set; }

    /// <summary>Specifies the scalability mode of the Aurora DB cluster. When set to limitless, the cluster operates as an Aurora Limitless Database. When set to standard (the default), the cluster uses normal DB instance creation. Valid values: limitless, standard.</summary>
    [JsonPropertyName("clusterScalabilityType")]
    public string? ClusterScalabilityType { get; set; }

    /// <summary>Copy all Cluster tags to snapshots. Default is false.</summary>
    [JsonPropertyName("copyTagsToSnapshot")]
    public bool? CopyTagsToSnapshot { get; set; }

    /// <summary>The mode of Database Insights to enable for the DB cluster. Valid values: standard, advanced.</summary>
    [JsonPropertyName("databaseInsightsMode")]
    public string? DatabaseInsightsMode { get; set; }

    /// <summary>Name for an automatically created database on cluster creation. There are different naming restrictions per database engine: RDS Naming Constraints</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The compute and memory capacity of each DB instance in the Multi-AZ DB cluster, for example db.m6g.xlarge. Not all DB instance classes are available in all AWS Regions, or for all database engines. For the full list of DB instance classes and availability for your engine, see DB instance class in the Amazon RDS User Guide.</summary>
    [JsonPropertyName("dbClusterInstanceClass")]
    public string? DbClusterInstanceClass { get; set; }

    /// <summary>A cluster parameter group to associate with the cluster.</summary>
    [JsonPropertyName("dbClusterParameterGroupName")]
    public string? DbClusterParameterGroupName { get; set; }

    /// <summary>Instance parameter group to associate with all instances of the DB cluster. The db_instance_parameter_group_name parameter is only valid in combination with the allow_major_version_upgrade parameter.</summary>
    [JsonPropertyName("dbInstanceParameterGroupName")]
    public string? DbInstanceParameterGroupName { get; set; }

    /// <summary>
    /// DB subnet group to associate with this DB cluster.
    /// NOTE: This must match the db_subnet_group_name specified on every aws_rds_cluster_instance in the cluster.
    /// </summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>For use with RDS Custom.</summary>
    [JsonPropertyName("dbSystemId")]
    public string? DbSystemId { get; set; }

    /// <summary>Specifies whether to remove automated backups immediately after the DB cluster is deleted. Default is true.</summary>
    [JsonPropertyName("deleteAutomatedBackups")]
    public bool? DeleteAutomatedBackups { get; set; }

    /// <summary>
    /// If the DB cluster should have deletion protection enabled.
    /// The database can&apos;t be deleted when this value is set to true.
    /// The default is false.
    /// </summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The ID of the Directory Service Active Directory domain to create the cluster in.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The name of the IAM role to be used when making API calls to the Directory Service.</summary>
    [JsonPropertyName("domainIamRoleName")]
    public string? DomainIamRoleName { get; set; }

    /// <summary>Whether cluster should forward writes to an associated global cluster. Applied to secondary clusters to enable them to forward writes to an aws_rds_global_cluster&apos;s primary cluster. See the User Guide for Aurora for more information.</summary>
    [JsonPropertyName("enableGlobalWriteForwarding")]
    public bool? EnableGlobalWriteForwarding { get; set; }

    /// <summary>Enable HTTP endpoint (data API). Only valid for some combinations of engine_mode, engine and engine_version and only available in some regions. See the Region and version availability section of the documentation. This option also does not work with any of these options specified: snapshot_identifier, replication_source_identifier, s3_import.</summary>
    [JsonPropertyName("enableHttpEndpoint")]
    public bool? EnableHttpEndpoint { get; set; }

    /// <summary>Whether read replicas can forward write operations to the writer DB instance in the DB cluster. By default, write operations aren&apos;t allowed on reader DB instances. See the User Guide for Aurora for more information. NOTE: Local write forwarding requires Aurora MySQL version 3.04 or higher.</summary>
    [JsonPropertyName("enableLocalWriteForwarding")]
    public bool? EnableLocalWriteForwarding { get; set; }

    /// <summary>Set of log types to export to cloudwatch. If omitted, no logs will be exported. The following log types are supported: audit, error, general, iam-db-auth-error, instance, postgresql (PostgreSQL), slowquery.</summary>
    [JsonPropertyName("enabledCloudwatchLogsExports")]
    public IList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>DNS address of the RDS instance</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Name of the database engine to be used for this DB cluster. Valid Values: aurora-mysql, aurora-postgresql, mysql, postgres. (Note that mysql and postgres are Multi-AZ RDS clusters).</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The life cycle type for this DB instance. This setting is valid for cluster types Aurora DB clusters and Multi-AZ DB clusters. Valid values are open-source-rds-extended-support, open-source-rds-extended-support-disabled. Default value is open-source-rds-extended-support. [Using Amazon RDS Extended Support]: https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/extended-support.html</summary>
    [JsonPropertyName("engineLifecycleSupport")]
    public string? EngineLifecycleSupport { get; set; }

    /// <summary>Database engine mode. Valid values: global (only valid for Aurora MySQL 1.21 and earlier), parallelquery, provisioned, serverless. Defaults to: provisioned. Specify an empty value (&quot; &quot;) for no engine mode. See the RDS User Guide for limitations when using serverless.</summary>
    [JsonPropertyName("engineMode")]
    public string? EngineMode { get; set; }

    /// <summary>Database engine version. Updating this argument results in an outage. See the Aurora MySQL and Aurora Postgres documentation for your configured engine to determine this value, or by running aws rds describe-db-engine-versions. For example with Aurora MySQL 2, a potential value for this argument is 5.7.mysql_aurora.2.03.2. The value can contain a partial version where supported by the API. The actual engine version used is returned in the attribute engine_version_actual, see Attribute Reference below.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Running version of the database.</summary>
    [JsonPropertyName("engineVersionActual")]
    public string? EngineVersionActual { get; set; }

    /// <summary>Name of your final DB snapshot when this DB cluster is deleted. If omitted, no final snapshot will be made.</summary>
    [JsonPropertyName("finalSnapshotIdentifier")]
    public string? FinalSnapshotIdentifier { get; set; }

    /// <summary>Global cluster identifier specified on aws_rds_global_cluster.</summary>
    [JsonPropertyName("globalClusterIdentifier")]
    public string? GlobalClusterIdentifier { get; set; }

    /// <summary>Route53 Hosted Zone ID of the endpoint</summary>
    [JsonPropertyName("hostedZoneId")]
    public string? HostedZoneId { get; set; }

    /// <summary>Specifies whether or not mappings of AWS Identity and Access Management (IAM) accounts to database accounts is enabled. Please see AWS Documentation for availability and limitations.</summary>
    [JsonPropertyName("iamDatabaseAuthenticationEnabled")]
    public bool? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>List of ARNs for the IAM roles to associate to the RDS Cluster.</summary>
    [JsonPropertyName("iamRoles")]
    public IList<string>? IamRoles { get; set; }

    /// <summary>RDS Cluster Identifier</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Amount of Provisioned IOPS (input/output operations per second) to be initially allocated for each DB instance in the Multi-AZ DB cluster. For information about valid Iops values, see Amazon RDS Provisioned IOPS storage to improve performance in the Amazon RDS User Guide. (This setting is required to create a Multi-AZ DB cluster). Must be a multiple between .5 and 50 of the storage amount for the DB cluster.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>ARN for the KMS encryption key. When specifying kms_key_id, storage_encrypted needs to be set to true.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Set to true to allow RDS to manage the master user password in Secrets Manager. Cannot be set if master_password is provided.</summary>
    [JsonPropertyName("manageMasterUserPassword")]
    public bool? ManageMasterUserPassword { get; set; }

    /// <summary>Used together with master_password_wo to trigger an update. Increment this value when an update to the master_password_wo is required.</summary>
    [JsonPropertyName("masterPasswordWoVersion")]
    public double? MasterPasswordWoVersion { get; set; }

    /// <summary>Block that specifies the master user secret. Only available when manage_master_user_password is set to true. Documented below.</summary>
    [JsonPropertyName("masterUserSecret")]
    public IList<V1beta2ClusterStatusAtProviderMasterUserSecret>? MasterUserSecret { get; set; }

    /// <summary>Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the KMS key. To use a KMS key in a different Amazon Web Services account, specify the key ARN or alias ARN. If not specified, the default KMS key for your Amazon Web Services account is used.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyId")]
    public string? MasterUserSecretKmsKeyId { get; set; }

    /// <summary>Username for the master DB user. Please refer to the RDS Naming Constraints. This argument does not support in-place updates and cannot be changed during a restore from snapshot.</summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>Interval, in seconds, between points when Enhanced Monitoring metrics are collected for the DB cluster. To turn off collecting Enhanced Monitoring metrics, specify 0. The default is 0. Valid Values: 0, 1, 5, 10, 15, 30, 60.</summary>
    [JsonPropertyName("monitoringInterval")]
    public double? MonitoringInterval { get; set; }

    /// <summary>ARN for the IAM role that permits RDS to send enhanced monitoring metrics to CloudWatch Logs. You can find more information on the AWS Documentation what IAM permissions are needed to allow Enhanced Monitoring for RDS Clusters.</summary>
    [JsonPropertyName("monitoringRoleArn")]
    public string? MonitoringRoleArn { get; set; }

    /// <summary>Network type of the cluster. Valid values: IPV4, DUAL.</summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>Enables Performance Insights.</summary>
    [JsonPropertyName("performanceInsightsEnabled")]
    public bool? PerformanceInsightsEnabled { get; set; }

    /// <summary>Specifies the KMS Key ID to encrypt Performance Insights data. If not specified, the default RDS KMS key will be used (aws/rds).</summary>
    [JsonPropertyName("performanceInsightsKmsKeyId")]
    public string? PerformanceInsightsKmsKeyId { get; set; }

    /// <summary>Specifies the amount of time to retain performance insights data for. Defaults to 7 days if Performance Insights are enabled. Valid values are 7, month * 31 (where month is a number of months from 1-23), and 731. See here for more information on retention periods.</summary>
    [JsonPropertyName("performanceInsightsRetentionPeriod")]
    public double? PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>Port on which the DB accepts connections.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Daily time range during which automated backups are created if automated backups are enabled using the BackupRetentionPeriod parameter.Time in UTC. Default: A 30-minute window selected at random from an 8-hour block of time per region, e.g. 04:00-09:00.</summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>Weekly time range during which system maintenance can occur, in (UTC) e.g., wed:04:00-wed:04:30</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>
    /// Read-only endpoint for the Aurora cluster, automatically
    /// load-balanced across replicas
    /// </summary>
    [JsonPropertyName("readerEndpoint")]
    public string? ReaderEndpoint { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ARN of a source DB cluster or DB instance if this DB cluster is to be created as a Read Replica. Note: Removing this attribute after creation will promote the read replica to a standalone cluster.</summary>
    [JsonPropertyName("replicationSourceIdentifier")]
    public string? ReplicationSourceIdentifier { get; set; }

    /// <summary>Nested attribute for point in time restore. More details below.</summary>
    [JsonPropertyName("restoreToPointInTime")]
    public V1beta2ClusterStatusAtProviderRestoreToPointInTime? RestoreToPointInTime { get; set; }

    /// <summary>Port on which the DB accepts connections.</summary>
    [JsonPropertyName("s3Import")]
    public V1beta2ClusterStatusAtProviderS3Import? S3Import { get; set; }

    /// <summary>Nested attribute with scaling properties. Only valid when engine_mode is set to serverless. More details below.</summary>
    [JsonPropertyName("scalingConfiguration")]
    public V1beta2ClusterStatusAtProviderScalingConfiguration? ScalingConfiguration { get; set; }

    /// <summary>Nested attribute with scaling properties for ServerlessV2. Only valid when engine_mode is set to provisioned. More details below.</summary>
    [JsonPropertyName("serverlessv2ScalingConfiguration")]
    public V1beta2ClusterStatusAtProviderServerlessv2ScalingConfiguration? Serverlessv2ScalingConfiguration { get; set; }

    /// <summary>Determines whether a final DB snapshot is created before the DB cluster is deleted. If true is specified, no DB snapshot is created. If false is specified, a DB snapshot is created before the DB cluster is deleted, using the value from final_snapshot_identifier. Default is false.</summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>Specifies whether or not to create this cluster from a snapshot. You can use either the name or ARN when specifying a DB cluster snapshot, or the ARN when specifying a DB snapshot. Conflicts with global_cluster_identifier. Clusters cannot be restored from snapshot and joined to an existing global cluster in a single operation. See the AWS documentation or the Global Cluster Restored From Snapshot example for instructions on building a global cluster starting with a snapshot.</summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>The source region for an encrypted replica DB cluster.</summary>
    [JsonPropertyName("sourceRegion")]
    public string? SourceRegion { get; set; }

    /// <summary>Specifies whether the DB cluster is encrypted. The default is false for provisioned engine_mode and true for serverless engine_mode. When restoring an unencrypted snapshot_identifier, the kms_key_id argument must be provided to encrypt the restored cluster.</summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>(Forces new for Multi-AZ DB clusters) Specifies the storage type to be associated with the DB cluster. For Aurora DB clusters, storage_type modifications can be done in-place. For Multi-AZ DB Clusters, the iops argument must also be set. Valid values are: &quot; &quot;, aurora-iopt1 (Aurora DB Clusters); io1, io2 (Multi-AZ DB Clusters). Default: &quot; &quot; (Aurora DB Clusters); io1 (Multi-AZ DB Clusters).</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Order in which the clusters are upgraded (first, second, last). See the AWS documentation for details.</summary>
    [JsonPropertyName("upgradeRolloutOrder")]
    public string? UpgradeRolloutOrder { get; set; }

    /// <summary>List of VPC security groups to associate with the Cluster</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API. Manages an RDS Aurora Cluster or a RDS Multi-AZ DB Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ClusterSpec>, IStatus<V1beta2ClusterStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "rds.aws.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Cluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta2ClusterStatus? Status { get; set; }
}