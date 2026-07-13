#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>NetworkInsightsAnalysis is the Schema for the NetworkInsightsAnalysiss API. Provides a Network Insights Analysis resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkInsightsAnalysisList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NetworkInsightsAnalysis>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkInsightsAnalysisList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "networkinsightsanalyses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkInsightsAnalysisList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1NetworkInsightsAnalysis objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1NetworkInsightsAnalysis> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdRefPolicyResolutionEnum>))]
public enum V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdRefPolicyResolveEnum>))]
public enum V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInsightsPath in ec2 to populate networkInsightsPathId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdSelectorPolicyResolutionEnum>))]
public enum V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdSelectorPolicyResolveEnum>))]
public enum V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInsightsPath in ec2 to populate networkInsightsPathId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdSelector
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
    public V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisSpecForProvider
{
    /// <summary>A list of ARNs for resources the path must traverse.</summary>
    [JsonPropertyName("filterInArns")]
    public IList<string>? FilterInArns { get; set; }

    /// <summary>ID of the Network Insights Path to run an analysis on.</summary>
    [JsonPropertyName("networkInsightsPathId")]
    public string? NetworkInsightsPathId { get; set; }

    /// <summary>Reference to a NetworkInsightsPath in ec2 to populate networkInsightsPathId.</summary>
    [JsonPropertyName("networkInsightsPathIdRef")]
    public V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdRef? NetworkInsightsPathIdRef { get; set; }

    /// <summary>Selector for a NetworkInsightsPath in ec2 to populate networkInsightsPathId.</summary>
    [JsonPropertyName("networkInsightsPathIdSelector")]
    public V1beta1NetworkInsightsAnalysisSpecForProviderNetworkInsightsPathIdSelector? NetworkInsightsPathIdSelector { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>If enabled, the resource will wait for the Network Insights Analysis status to change to succeeded or failed. Setting this to false will skip the process. Default: true.</summary>
    [JsonPropertyName("waitForCompletion")]
    public bool? WaitForCompletion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdRefPolicyResolutionEnum>))]
public enum V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdRefPolicyResolveEnum>))]
public enum V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInsightsPath in ec2 to populate networkInsightsPathId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdSelectorPolicyResolutionEnum>))]
public enum V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdSelectorPolicyResolveEnum>))]
public enum V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInsightsPath in ec2 to populate networkInsightsPathId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdSelector
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
    public V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1NetworkInsightsAnalysisSpecInitProvider
{
    /// <summary>A list of ARNs for resources the path must traverse.</summary>
    [JsonPropertyName("filterInArns")]
    public IList<string>? FilterInArns { get; set; }

    /// <summary>ID of the Network Insights Path to run an analysis on.</summary>
    [JsonPropertyName("networkInsightsPathId")]
    public string? NetworkInsightsPathId { get; set; }

    /// <summary>Reference to a NetworkInsightsPath in ec2 to populate networkInsightsPathId.</summary>
    [JsonPropertyName("networkInsightsPathIdRef")]
    public V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdRef? NetworkInsightsPathIdRef { get; set; }

    /// <summary>Selector for a NetworkInsightsPath in ec2 to populate networkInsightsPathId.</summary>
    [JsonPropertyName("networkInsightsPathIdSelector")]
    public V1beta1NetworkInsightsAnalysisSpecInitProviderNetworkInsightsPathIdSelector? NetworkInsightsPathIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>If enabled, the resource will wait for the Network Insights Analysis status to change to succeeded or failed. Setting this to false will skip the process. Default: true.</summary>
    [JsonPropertyName("waitForCompletion")]
    public bool? WaitForCompletion { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NetworkInsightsAnalysisSpecManagementPoliciesEnum>))]
public enum V1beta1NetworkInsightsAnalysisSpecManagementPoliciesEnum
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
public partial class V1beta1NetworkInsightsAnalysisSpecProviderConfigRef
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
public partial class V1beta1NetworkInsightsAnalysisSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>NetworkInsightsAnalysisSpec defines the desired state of NetworkInsightsAnalysis</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1NetworkInsightsAnalysisSpecForProvider ForProvider { get; set; }

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
    public V1beta1NetworkInsightsAnalysisSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1NetworkInsightsAnalysisSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NetworkInsightsAnalysisSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NetworkInsightsAnalysisSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderAlternatePathHints
{
    /// <summary>The Amazon Resource Name (ARN) of the component.</summary>
    [JsonPropertyName("componentArn")]
    public string? ComponentArn { get; set; }

    /// <summary>The ID of the component.</summary>
    [JsonPropertyName("componentId")]
    public string? ComponentId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsAcl
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsAclRulePortRange
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsAclRule
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    [JsonPropertyName("egress")]
    public bool? Egress { get; set; }

    [JsonPropertyName("portRange")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsAclRulePortRange>? PortRange { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("ruleAction")]
    public string? RuleAction { get; set; }

    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsAttachedTo
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsClassicLoadBalancerListener
{
    [JsonPropertyName("instancePort")]
    public double? InstancePort { get; set; }

    [JsonPropertyName("loadBalancerPort")]
    public double? LoadBalancerPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsComponent
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsCustomerGateway
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsDestination
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsDestinationVpc
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsElasticLoadBalancerListener
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsIngressRouteTable
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsInternetGateway
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsLoadBalancerTargetGroup
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsLoadBalancerTargetGroups
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsNatGateway
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsNetworkInterface
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsPortRanges
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsPrefixList
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsRouteTable
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsRouteTableRoute
{
    [JsonPropertyName("destinationCidr")]
    public string? DestinationCidr { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("destinationPrefixListId")]
    public string? DestinationPrefixListId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("egressOnlyInternetGatewayId")]
    public string? EgressOnlyInternetGatewayId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("gatewayId")]
    public string? GatewayId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("natGatewayId")]
    public string? NatGatewayId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    [JsonPropertyName("origin")]
    public string? Origin { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("vpcPeeringConnectionId")]
    public string? VpcPeeringConnectionId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSecurityGroup
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSecurityGroupRulePortRange
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSecurityGroupRule
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    [JsonPropertyName("portRange")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSecurityGroupRulePortRange>? PortRange { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("prefixListId")]
    public string? PrefixListId { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSecurityGroups
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSourceVpc
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSubnet
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSubnetRouteTable
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsTransitGateway
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsTransitGatewayAttachment
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsTransitGatewayRouteTable
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsTransitGatewayRouteTableRoute
{
    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("attachmentId")]
    public string? AttachmentId { get; set; }

    [JsonPropertyName("destinationCidr")]
    public string? DestinationCidr { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("prefixListId")]
    public string? PrefixListId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    [JsonPropertyName("routeOrigin")]
    public string? RouteOrigin { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsVpc
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsVpcEndpoint
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsVpcPeeringConnection
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsVpnConnection
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsVpnGateway
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderExplanations
{
    [JsonPropertyName("acl")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsAcl>? Acl { get; set; }

    [JsonPropertyName("aclRule")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsAclRule>? AclRule { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    [JsonPropertyName("attachedTo")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsAttachedTo>? AttachedTo { get; set; }

    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    [JsonPropertyName("cidrs")]
    public IList<string>? Cidrs { get; set; }

    [JsonPropertyName("classicLoadBalancerListener")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsClassicLoadBalancerListener>? ClassicLoadBalancerListener { get; set; }

    [JsonPropertyName("component")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsComponent>? Component { get; set; }

    [JsonPropertyName("customerGateway")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsCustomerGateway>? CustomerGateway { get; set; }

    [JsonPropertyName("destination")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsDestination>? Destination { get; set; }

    [JsonPropertyName("destinationVpc")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsDestinationVpc>? DestinationVpc { get; set; }

    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    [JsonPropertyName("elasticLoadBalancerListener")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsElasticLoadBalancerListener>? ElasticLoadBalancerListener { get; set; }

    [JsonPropertyName("explanationCode")]
    public string? ExplanationCode { get; set; }

    [JsonPropertyName("ingressRouteTable")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsIngressRouteTable>? IngressRouteTable { get; set; }

    [JsonPropertyName("internetGateway")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsInternetGateway>? InternetGateway { get; set; }

    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("loadBalancerArn")]
    public string? LoadBalancerArn { get; set; }

    [JsonPropertyName("loadBalancerListenerPort")]
    public double? LoadBalancerListenerPort { get; set; }

    [JsonPropertyName("loadBalancerTargetGroup")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsLoadBalancerTargetGroup>? LoadBalancerTargetGroup { get; set; }

    [JsonPropertyName("loadBalancerTargetGroups")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsLoadBalancerTargetGroups>? LoadBalancerTargetGroups { get; set; }

    [JsonPropertyName("loadBalancerTargetPort")]
    public double? LoadBalancerTargetPort { get; set; }

    [JsonPropertyName("missingComponent")]
    public string? MissingComponent { get; set; }

    [JsonPropertyName("natGateway")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsNatGateway>? NatGateway { get; set; }

    [JsonPropertyName("networkInterface")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsNetworkInterface>? NetworkInterface { get; set; }

    [JsonPropertyName("packetField")]
    public string? PacketField { get; set; }

    [JsonPropertyName("port")]
    public double? Port { get; set; }

    [JsonPropertyName("portRanges")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsPortRanges>? PortRanges { get; set; }

    [JsonPropertyName("prefixList")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsPrefixList>? PrefixList { get; set; }

    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    [JsonPropertyName("routeTable")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsRouteTable>? RouteTable { get; set; }

    [JsonPropertyName("routeTableRoute")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsRouteTableRoute>? RouteTableRoute { get; set; }

    [JsonPropertyName("securityGroup")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSecurityGroup>? SecurityGroup { get; set; }

    [JsonPropertyName("securityGroupRule")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSecurityGroupRule>? SecurityGroupRule { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSecurityGroups>? SecurityGroups { get; set; }

    [JsonPropertyName("sourceVpc")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSourceVpc>? SourceVpc { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("subnet")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSubnet>? Subnet { get; set; }

    [JsonPropertyName("subnetRouteTable")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsSubnetRouteTable>? SubnetRouteTable { get; set; }

    [JsonPropertyName("transitGateway")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsTransitGateway>? TransitGateway { get; set; }

    [JsonPropertyName("transitGatewayAttachment")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsTransitGatewayAttachment>? TransitGatewayAttachment { get; set; }

    [JsonPropertyName("transitGatewayRouteTable")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsTransitGatewayRouteTable>? TransitGatewayRouteTable { get; set; }

    [JsonPropertyName("transitGatewayRouteTableRoute")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsTransitGatewayRouteTableRoute>? TransitGatewayRouteTableRoute { get; set; }

    [JsonPropertyName("vpc")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsVpc>? Vpc { get; set; }

    [JsonPropertyName("vpcEndpoint")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsVpcEndpoint>? VpcEndpoint { get; set; }

    [JsonPropertyName("vpcPeeringConnection")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsVpcPeeringConnection>? VpcPeeringConnection { get; set; }

    [JsonPropertyName("vpnConnection")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsVpnConnection>? VpnConnection { get; set; }

    [JsonPropertyName("vpnGateway")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanationsVpnGateway>? VpnGateway { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsAclRulePortRange
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsAclRule
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    [JsonPropertyName("egress")]
    public bool? Egress { get; set; }

    [JsonPropertyName("portRange")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsAclRulePortRange>? PortRange { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("ruleAction")]
    public string? RuleAction { get; set; }

    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsAdditionalDetailsComponent
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsAdditionalDetails
{
    [JsonPropertyName("additionalDetailType")]
    public string? AdditionalDetailType { get; set; }

    [JsonPropertyName("component")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsAdditionalDetailsComponent>? Component { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsAttachedTo
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsComponent
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsDestinationVpc
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsInboundHeaderDestinationPortRanges
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsInboundHeaderSourcePortRanges
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsInboundHeader
{
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationPortRanges")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsInboundHeaderDestinationPortRanges>? DestinationPortRanges { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourcePortRanges")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsInboundHeaderSourcePortRanges>? SourcePortRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsOutboundHeaderDestinationPortRanges
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsOutboundHeaderSourcePortRanges
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsOutboundHeader
{
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationPortRanges")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsOutboundHeaderDestinationPortRanges>? DestinationPortRanges { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourcePortRanges")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsOutboundHeaderSourcePortRanges>? SourcePortRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsRouteTableRoute
{
    [JsonPropertyName("destinationCidr")]
    public string? DestinationCidr { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("destinationPrefixListId")]
    public string? DestinationPrefixListId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("egressOnlyInternetGatewayId")]
    public string? EgressOnlyInternetGatewayId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("gatewayId")]
    public string? GatewayId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("natGatewayId")]
    public string? NatGatewayId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    [JsonPropertyName("origin")]
    public string? Origin { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("vpcPeeringConnectionId")]
    public string? VpcPeeringConnectionId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsSecurityGroupRulePortRange
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsSecurityGroupRule
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    [JsonPropertyName("portRange")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsSecurityGroupRulePortRange>? PortRange { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("prefixListId")]
    public string? PrefixListId { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsSourceVpc
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsSubnet
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsTransitGateway
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsTransitGatewayRouteTableRoute
{
    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("attachmentId")]
    public string? AttachmentId { get; set; }

    [JsonPropertyName("destinationCidr")]
    public string? DestinationCidr { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("prefixListId")]
    public string? PrefixListId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    [JsonPropertyName("routeOrigin")]
    public string? RouteOrigin { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsVpc
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponents
{
    [JsonPropertyName("aclRule")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsAclRule>? AclRule { get; set; }

    [JsonPropertyName("additionalDetails")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsAdditionalDetails>? AdditionalDetails { get; set; }

    [JsonPropertyName("attachedTo")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsAttachedTo>? AttachedTo { get; set; }

    [JsonPropertyName("component")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsComponent>? Component { get; set; }

    [JsonPropertyName("destinationVpc")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsDestinationVpc>? DestinationVpc { get; set; }

    [JsonPropertyName("inboundHeader")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsInboundHeader>? InboundHeader { get; set; }

    [JsonPropertyName("outboundHeader")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsOutboundHeader>? OutboundHeader { get; set; }

    [JsonPropertyName("routeTableRoute")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsRouteTableRoute>? RouteTableRoute { get; set; }

    [JsonPropertyName("securityGroupRule")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsSecurityGroupRule>? SecurityGroupRule { get; set; }

    [JsonPropertyName("sequenceNumber")]
    public double? SequenceNumber { get; set; }

    [JsonPropertyName("sourceVpc")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsSourceVpc>? SourceVpc { get; set; }

    [JsonPropertyName("subnet")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsSubnet>? Subnet { get; set; }

    [JsonPropertyName("transitGateway")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsTransitGateway>? TransitGateway { get; set; }

    [JsonPropertyName("transitGatewayRouteTableRoute")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsTransitGatewayRouteTableRoute>? TransitGatewayRouteTableRoute { get; set; }

    [JsonPropertyName("vpc")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponentsVpc>? Vpc { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsAclRulePortRange
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsAclRule
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    [JsonPropertyName("egress")]
    public bool? Egress { get; set; }

    [JsonPropertyName("portRange")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsAclRulePortRange>? PortRange { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("ruleAction")]
    public string? RuleAction { get; set; }

    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsAdditionalDetailsComponent
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsAdditionalDetails
{
    [JsonPropertyName("additionalDetailType")]
    public string? AdditionalDetailType { get; set; }

    [JsonPropertyName("component")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsAdditionalDetailsComponent>? Component { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsAttachedTo
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsComponent
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsDestinationVpc
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsInboundHeaderDestinationPortRanges
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsInboundHeaderSourcePortRanges
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsInboundHeader
{
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationPortRanges")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsInboundHeaderDestinationPortRanges>? DestinationPortRanges { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourcePortRanges")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsInboundHeaderSourcePortRanges>? SourcePortRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsOutboundHeaderDestinationPortRanges
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsOutboundHeaderSourcePortRanges
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsOutboundHeader
{
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationPortRanges")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsOutboundHeaderDestinationPortRanges>? DestinationPortRanges { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourcePortRanges")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsOutboundHeaderSourcePortRanges>? SourcePortRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsRouteTableRoute
{
    [JsonPropertyName("destinationCidr")]
    public string? DestinationCidr { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("destinationPrefixListId")]
    public string? DestinationPrefixListId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("egressOnlyInternetGatewayId")]
    public string? EgressOnlyInternetGatewayId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("gatewayId")]
    public string? GatewayId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("natGatewayId")]
    public string? NatGatewayId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    [JsonPropertyName("origin")]
    public string? Origin { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("transitGatewayId")]
    public string? TransitGatewayId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("vpcPeeringConnectionId")]
    public string? VpcPeeringConnectionId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsSecurityGroupRulePortRange
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsSecurityGroupRule
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    [JsonPropertyName("portRange")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsSecurityGroupRulePortRange>? PortRange { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("prefixListId")]
    public string? PrefixListId { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("securityGroupId")]
    public string? SecurityGroupId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsSourceVpc
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsSubnet
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsTransitGateway
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsTransitGatewayRouteTableRoute
{
    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("attachmentId")]
    public string? AttachmentId { get; set; }

    [JsonPropertyName("destinationCidr")]
    public string? DestinationCidr { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("prefixListId")]
    public string? PrefixListId { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    [JsonPropertyName("routeOrigin")]
    public string? RouteOrigin { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsVpc
{
    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponents
{
    [JsonPropertyName("aclRule")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsAclRule>? AclRule { get; set; }

    [JsonPropertyName("additionalDetails")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsAdditionalDetails>? AdditionalDetails { get; set; }

    [JsonPropertyName("attachedTo")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsAttachedTo>? AttachedTo { get; set; }

    [JsonPropertyName("component")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsComponent>? Component { get; set; }

    [JsonPropertyName("destinationVpc")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsDestinationVpc>? DestinationVpc { get; set; }

    [JsonPropertyName("inboundHeader")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsInboundHeader>? InboundHeader { get; set; }

    [JsonPropertyName("outboundHeader")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsOutboundHeader>? OutboundHeader { get; set; }

    [JsonPropertyName("routeTableRoute")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsRouteTableRoute>? RouteTableRoute { get; set; }

    [JsonPropertyName("securityGroupRule")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsSecurityGroupRule>? SecurityGroupRule { get; set; }

    [JsonPropertyName("sequenceNumber")]
    public double? SequenceNumber { get; set; }

    [JsonPropertyName("sourceVpc")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsSourceVpc>? SourceVpc { get; set; }

    [JsonPropertyName("subnet")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsSubnet>? Subnet { get; set; }

    [JsonPropertyName("transitGateway")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsTransitGateway>? TransitGateway { get; set; }

    [JsonPropertyName("transitGatewayRouteTableRoute")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsTransitGatewayRouteTableRoute>? TransitGatewayRouteTableRoute { get; set; }

    [JsonPropertyName("vpc")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponentsVpc>? Vpc { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusAtProvider
{
    /// <summary>Potential intermediate components of a feasible path. Described below.</summary>
    [JsonPropertyName("alternatePathHints")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderAlternatePathHints>? AlternatePathHints { get; set; }

    /// <summary>ARN of the Network Insights Analysis.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Explanation codes for an unreachable path. See the AWS documentation for details.</summary>
    [JsonPropertyName("explanations")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderExplanations>? Explanations { get; set; }

    /// <summary>A list of ARNs for resources the path must traverse.</summary>
    [JsonPropertyName("filterInArns")]
    public IList<string>? FilterInArns { get; set; }

    /// <summary>The components in the path from source to destination. See the AWS documentation for details.</summary>
    [JsonPropertyName("forwardPathComponents")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderForwardPathComponents>? ForwardPathComponents { get; set; }

    /// <summary>ID of the Network Insights Analysis.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ID of the Network Insights Path to run an analysis on.</summary>
    [JsonPropertyName("networkInsightsPathId")]
    public string? NetworkInsightsPathId { get; set; }

    /// <summary>Set to true if the destination was reachable.</summary>
    [JsonPropertyName("pathFound")]
    public bool? PathFound { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The components in the path from destination to source. See the AWS documentation for details.</summary>
    [JsonPropertyName("returnPathComponents")]
    public IList<V1beta1NetworkInsightsAnalysisStatusAtProviderReturnPathComponents>? ReturnPathComponents { get; set; }

    /// <summary>The date/time the analysis was started.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>The status of the analysis. succeeded means the analysis was completed, not that a path was found, for that see path_found.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A message to provide more context when the status is failed.</summary>
    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>If enabled, the resource will wait for the Network Insights Analysis status to change to succeeded or failed. Setting this to false will skip the process. Default: true.</summary>
    [JsonPropertyName("waitForCompletion")]
    public bool? WaitForCompletion { get; set; }

    /// <summary>The warning message.</summary>
    [JsonPropertyName("warningMessage")]
    public string? WarningMessage { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatusConditions
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

/// <summary>NetworkInsightsAnalysisStatus defines the observed state of NetworkInsightsAnalysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsAnalysisStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1NetworkInsightsAnalysisStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NetworkInsightsAnalysisStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NetworkInsightsAnalysis is the Schema for the NetworkInsightsAnalysiss API. Provides a Network Insights Analysis resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkInsightsAnalysis : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NetworkInsightsAnalysisSpec>, IStatus<V1beta1NetworkInsightsAnalysisStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkInsightsAnalysis";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "networkinsightsanalyses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkInsightsAnalysis";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkInsightsAnalysisSpec defines the desired state of NetworkInsightsAnalysis</summary>
    [JsonPropertyName("spec")]
    public required V1beta1NetworkInsightsAnalysisSpec Spec { get; set; }

    /// <summary>NetworkInsightsAnalysisStatus defines the observed state of NetworkInsightsAnalysis.</summary>
    [JsonPropertyName("status")]
    public V1beta1NetworkInsightsAnalysisStatus? Status { get; set; }
}