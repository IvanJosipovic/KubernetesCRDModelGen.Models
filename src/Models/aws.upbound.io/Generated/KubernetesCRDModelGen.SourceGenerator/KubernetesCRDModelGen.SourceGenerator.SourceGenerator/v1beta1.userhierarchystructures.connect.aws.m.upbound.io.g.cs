#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.connect.aws.m.upbound.io;
/// <summary>UserHierarchyStructure is the Schema for the UserHierarchyStructures API. Provides details about a specific Amazon Connect User Hierarchy Structure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1UserHierarchyStructureList : IKubernetesObject<V1ListMeta>, IItems<V1beta1UserHierarchyStructure>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "UserHierarchyStructureList";
    public const string KubeGroup = "connect.aws.m.upbound.io";
    public const string KubePluralName = "userhierarchystructures";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "connect.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserHierarchyStructureList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1UserHierarchyStructure objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1UserHierarchyStructure> Items { get; set; }
}

/// <summary>A block that defines the details of level five. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecForProviderHierarchyStructureLevelFive
{
    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the details of level four. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecForProviderHierarchyStructureLevelFour
{
    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the details of level one. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecForProviderHierarchyStructureLevelOne
{
    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the details of level three. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecForProviderHierarchyStructureLevelThree
{
    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the details of level two. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecForProviderHierarchyStructureLevelTwo
{
    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the hierarchy structure&apos;s levels. The hierarchy_structure block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecForProviderHierarchyStructure
{
    /// <summary>A block that defines the details of level five. The level block is documented below.</summary>
    [JsonPropertyName("levelFive")]
    public V1beta1UserHierarchyStructureSpecForProviderHierarchyStructureLevelFive? LevelFive { get; set; }

    /// <summary>A block that defines the details of level four. The level block is documented below.</summary>
    [JsonPropertyName("levelFour")]
    public V1beta1UserHierarchyStructureSpecForProviderHierarchyStructureLevelFour? LevelFour { get; set; }

    /// <summary>A block that defines the details of level one. The level block is documented below.</summary>
    [JsonPropertyName("levelOne")]
    public V1beta1UserHierarchyStructureSpecForProviderHierarchyStructureLevelOne? LevelOne { get; set; }

    /// <summary>A block that defines the details of level three. The level block is documented below.</summary>
    [JsonPropertyName("levelThree")]
    public V1beta1UserHierarchyStructureSpecForProviderHierarchyStructureLevelThree? LevelThree { get; set; }

    /// <summary>A block that defines the details of level two. The level block is documented below.</summary>
    [JsonPropertyName("levelTwo")]
    public V1beta1UserHierarchyStructureSpecForProviderHierarchyStructureLevelTwo? LevelTwo { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserHierarchyStructureSpecForProviderInstanceIdRefPolicyResolutionEnum>))]
public enum V1beta1UserHierarchyStructureSpecForProviderInstanceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserHierarchyStructureSpecForProviderInstanceIdRefPolicyResolveEnum>))]
public enum V1beta1UserHierarchyStructureSpecForProviderInstanceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecForProviderInstanceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1UserHierarchyStructureSpecForProviderInstanceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1UserHierarchyStructureSpecForProviderInstanceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in connect to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecForProviderInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserHierarchyStructureSpecForProviderInstanceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserHierarchyStructureSpecForProviderInstanceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1UserHierarchyStructureSpecForProviderInstanceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserHierarchyStructureSpecForProviderInstanceIdSelectorPolicyResolveEnum>))]
public enum V1beta1UserHierarchyStructureSpecForProviderInstanceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecForProviderInstanceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1UserHierarchyStructureSpecForProviderInstanceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1UserHierarchyStructureSpecForProviderInstanceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in connect to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecForProviderInstanceIdSelector
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
    public V1beta1UserHierarchyStructureSpecForProviderInstanceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecForProvider
{
    /// <summary>A block that defines the hierarchy structure&apos;s levels. The hierarchy_structure block is documented below.</summary>
    [JsonPropertyName("hierarchyStructure")]
    public V1beta1UserHierarchyStructureSpecForProviderHierarchyStructure? HierarchyStructure { get; set; }

    /// <summary>Specifies the identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Reference to a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdRef")]
    public V1beta1UserHierarchyStructureSpecForProviderInstanceIdRef? InstanceIdRef { get; set; }

    /// <summary>Selector for a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdSelector")]
    public V1beta1UserHierarchyStructureSpecForProviderInstanceIdSelector? InstanceIdSelector { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>A block that defines the details of level five. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecInitProviderHierarchyStructureLevelFive
{
    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the details of level four. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecInitProviderHierarchyStructureLevelFour
{
    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the details of level one. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecInitProviderHierarchyStructureLevelOne
{
    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the details of level three. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecInitProviderHierarchyStructureLevelThree
{
    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the details of level two. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecInitProviderHierarchyStructureLevelTwo
{
    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the hierarchy structure&apos;s levels. The hierarchy_structure block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecInitProviderHierarchyStructure
{
    /// <summary>A block that defines the details of level five. The level block is documented below.</summary>
    [JsonPropertyName("levelFive")]
    public V1beta1UserHierarchyStructureSpecInitProviderHierarchyStructureLevelFive? LevelFive { get; set; }

    /// <summary>A block that defines the details of level four. The level block is documented below.</summary>
    [JsonPropertyName("levelFour")]
    public V1beta1UserHierarchyStructureSpecInitProviderHierarchyStructureLevelFour? LevelFour { get; set; }

    /// <summary>A block that defines the details of level one. The level block is documented below.</summary>
    [JsonPropertyName("levelOne")]
    public V1beta1UserHierarchyStructureSpecInitProviderHierarchyStructureLevelOne? LevelOne { get; set; }

    /// <summary>A block that defines the details of level three. The level block is documented below.</summary>
    [JsonPropertyName("levelThree")]
    public V1beta1UserHierarchyStructureSpecInitProviderHierarchyStructureLevelThree? LevelThree { get; set; }

    /// <summary>A block that defines the details of level two. The level block is documented below.</summary>
    [JsonPropertyName("levelTwo")]
    public V1beta1UserHierarchyStructureSpecInitProviderHierarchyStructureLevelTwo? LevelTwo { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserHierarchyStructureSpecInitProviderInstanceIdRefPolicyResolutionEnum>))]
public enum V1beta1UserHierarchyStructureSpecInitProviderInstanceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserHierarchyStructureSpecInitProviderInstanceIdRefPolicyResolveEnum>))]
public enum V1beta1UserHierarchyStructureSpecInitProviderInstanceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecInitProviderInstanceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1UserHierarchyStructureSpecInitProviderInstanceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1UserHierarchyStructureSpecInitProviderInstanceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in connect to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecInitProviderInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserHierarchyStructureSpecInitProviderInstanceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserHierarchyStructureSpecInitProviderInstanceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1UserHierarchyStructureSpecInitProviderInstanceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserHierarchyStructureSpecInitProviderInstanceIdSelectorPolicyResolveEnum>))]
public enum V1beta1UserHierarchyStructureSpecInitProviderInstanceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecInitProviderInstanceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1UserHierarchyStructureSpecInitProviderInstanceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1UserHierarchyStructureSpecInitProviderInstanceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in connect to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpecInitProviderInstanceIdSelector
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
    public V1beta1UserHierarchyStructureSpecInitProviderInstanceIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1UserHierarchyStructureSpecInitProvider
{
    /// <summary>A block that defines the hierarchy structure&apos;s levels. The hierarchy_structure block is documented below.</summary>
    [JsonPropertyName("hierarchyStructure")]
    public V1beta1UserHierarchyStructureSpecInitProviderHierarchyStructure? HierarchyStructure { get; set; }

    /// <summary>Specifies the identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Reference to a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdRef")]
    public V1beta1UserHierarchyStructureSpecInitProviderInstanceIdRef? InstanceIdRef { get; set; }

    /// <summary>Selector for a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdSelector")]
    public V1beta1UserHierarchyStructureSpecInitProviderInstanceIdSelector? InstanceIdSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserHierarchyStructureSpecManagementPoliciesEnum>))]
public enum V1beta1UserHierarchyStructureSpecManagementPoliciesEnum
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
public partial class V1beta1UserHierarchyStructureSpecProviderConfigRef
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
public partial class V1beta1UserHierarchyStructureSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>UserHierarchyStructureSpec defines the desired state of UserHierarchyStructure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1UserHierarchyStructureSpecForProvider ForProvider { get; set; }

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
    public V1beta1UserHierarchyStructureSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1UserHierarchyStructureSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1UserHierarchyStructureSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1UserHierarchyStructureSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A block that defines the details of level five. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureStatusAtProviderHierarchyStructureLevelFive
{
    /// <summary>The Amazon Resource Name (ARN) of the hierarchy level.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the details of level four. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureStatusAtProviderHierarchyStructureLevelFour
{
    /// <summary>The Amazon Resource Name (ARN) of the hierarchy level.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the details of level one. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureStatusAtProviderHierarchyStructureLevelOne
{
    /// <summary>The Amazon Resource Name (ARN) of the hierarchy level.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the details of level three. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureStatusAtProviderHierarchyStructureLevelThree
{
    /// <summary>The Amazon Resource Name (ARN) of the hierarchy level.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the details of level two. The level block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureStatusAtProviderHierarchyStructureLevelTwo
{
    /// <summary>The Amazon Resource Name (ARN) of the hierarchy level.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the user hierarchy level. Must not be more than 50 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A block that defines the hierarchy structure&apos;s levels. The hierarchy_structure block is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureStatusAtProviderHierarchyStructure
{
    /// <summary>A block that defines the details of level five. The level block is documented below.</summary>
    [JsonPropertyName("levelFive")]
    public V1beta1UserHierarchyStructureStatusAtProviderHierarchyStructureLevelFive? LevelFive { get; set; }

    /// <summary>A block that defines the details of level four. The level block is documented below.</summary>
    [JsonPropertyName("levelFour")]
    public V1beta1UserHierarchyStructureStatusAtProviderHierarchyStructureLevelFour? LevelFour { get; set; }

    /// <summary>A block that defines the details of level one. The level block is documented below.</summary>
    [JsonPropertyName("levelOne")]
    public V1beta1UserHierarchyStructureStatusAtProviderHierarchyStructureLevelOne? LevelOne { get; set; }

    /// <summary>A block that defines the details of level three. The level block is documented below.</summary>
    [JsonPropertyName("levelThree")]
    public V1beta1UserHierarchyStructureStatusAtProviderHierarchyStructureLevelThree? LevelThree { get; set; }

    /// <summary>A block that defines the details of level two. The level block is documented below.</summary>
    [JsonPropertyName("levelTwo")]
    public V1beta1UserHierarchyStructureStatusAtProviderHierarchyStructureLevelTwo? LevelTwo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureStatusAtProvider
{
    /// <summary>A block that defines the hierarchy structure&apos;s levels. The hierarchy_structure block is documented below.</summary>
    [JsonPropertyName("hierarchyStructure")]
    public V1beta1UserHierarchyStructureStatusAtProviderHierarchyStructure? HierarchyStructure { get; set; }

    /// <summary>The identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureStatusConditions
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

/// <summary>UserHierarchyStructureStatus defines the observed state of UserHierarchyStructure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserHierarchyStructureStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1UserHierarchyStructureStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1UserHierarchyStructureStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>UserHierarchyStructure is the Schema for the UserHierarchyStructures API. Provides details about a specific Amazon Connect User Hierarchy Structure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1UserHierarchyStructure : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1UserHierarchyStructureSpec>, IStatus<V1beta1UserHierarchyStructureStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "UserHierarchyStructure";
    public const string KubeGroup = "connect.aws.m.upbound.io";
    public const string KubePluralName = "userhierarchystructures";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "connect.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserHierarchyStructure";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserHierarchyStructureSpec defines the desired state of UserHierarchyStructure</summary>
    [JsonPropertyName("spec")]
    public required V1beta1UserHierarchyStructureSpec Spec { get; set; }

    /// <summary>UserHierarchyStructureStatus defines the observed state of UserHierarchyStructure.</summary>
    [JsonPropertyName("status")]
    public V1beta1UserHierarchyStructureStatus? Status { get; set; }
}