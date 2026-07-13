#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerapp.azure.m.upbound.io;
/// <summary>Environment is the Schema for the Environments API. Manages a Container App Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EnvironmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Environment>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EnvironmentList";
    public const string KubeGroup = "containerapp.azure.m.upbound.io";
    public const string KubePluralName = "environments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerapp.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EnvironmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Environment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Environment> Items { get; set; }
}

/// <summary>
/// Application Insights connection string used by Dapr to export Service to Service communication telemetry. Changing this forces a new resource to be created.
/// Application Insights connection string used by Dapr to export Service to Service communication telemetry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderDaprApplicationInsightsConnectionStringSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderIdentity
{
    /// <summary>- A list of one or more Resource IDs for User Assigned Managed identities to assign. Required when type is set to UserAssigned or SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of managed identity to assign. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelector
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
    public V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate infrastructureSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate infrastructureSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelector
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
    public V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelector
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
    public V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderResourceGroupNameSelector
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
    public V1beta1EnvironmentSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProviderWorkloadProfile
{
    /// <summary>The maximum number of instances of workload profile that can be deployed in the Container App Environment.</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of instances of workload profile that can be deployed in the Container App Environment.</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }

    /// <summary>The name of the workload profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Workload profile type for the workloads to run on. Possible values include Consumption, D4, D8, D16, D32, E4, E8, E16 and E32.</summary>
    [JsonPropertyName("workloadProfileType")]
    public string? WorkloadProfileType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecForProvider
{
    /// <summary>
    /// Application Insights connection string used by Dapr to export Service to Service communication telemetry. Changing this forces a new resource to be created.
    /// Application Insights connection string used by Dapr to export Service to Service communication telemetry.
    /// </summary>
    [JsonPropertyName("daprApplicationInsightsConnectionStringSecretRef")]
    public V1beta1EnvironmentSpecForProviderDaprApplicationInsightsConnectionStringSecretRef? DaprApplicationInsightsConnectionStringSecretRef { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1EnvironmentSpecForProviderIdentity? Identity { get; set; }

    /// <summary>
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. Changing this forces a new resource to be created.
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.
    /// </summary>
    [JsonPropertyName("infrastructureResourceGroupName")]
    public string? InfrastructureResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
    [JsonPropertyName("infrastructureResourceGroupNameRef")]
    public V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameRef? InfrastructureResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
    [JsonPropertyName("infrastructureResourceGroupNameSelector")]
    public V1beta1EnvironmentSpecForProviderInfrastructureResourceGroupNameSelector? InfrastructureResourceGroupNameSelector { get; set; }

    /// <summary>
    /// The existing Subnet to use for the Container Apps Control Plane. Changing this forces a new resource to be created.
    /// The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.
    /// </summary>
    [JsonPropertyName("infrastructureSubnetId")]
    public string? InfrastructureSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate infrastructureSubnetId.</summary>
    [JsonPropertyName("infrastructureSubnetIdRef")]
    public V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdRef? InfrastructureSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate infrastructureSubnetId.</summary>
    [JsonPropertyName("infrastructureSubnetIdSelector")]
    public V1beta1EnvironmentSpecForProviderInfrastructureSubnetIdSelector? InfrastructureSubnetIdSelector { get; set; }

    /// <summary>
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to false. Changing this forces a new resource to be created.
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.
    /// </summary>
    [JsonPropertyName("internalLoadBalancerEnabled")]
    public bool? InternalLoadBalancerEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the Container App Environment is to exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// </summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdRef")]
    public V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdRef? LogAnalyticsWorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdSelector")]
    public V1beta1EnvironmentSpecForProviderLogAnalyticsWorkspaceIdSelector? LogAnalyticsWorkspaceIdSelector { get; set; }

    /// <summary>Where the application logs will be saved for this Container Apps Managed Environment. Possible values include log-analytics and azure-monitor. Omitting this value will result in logs being streamed only.</summary>
    [JsonPropertyName("logsDestination")]
    public string? LogsDestination { get; set; }

    /// <summary>
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to false.
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.
    /// </summary>
    [JsonPropertyName("mutualTlsEnabled")]
    public bool? MutualTlsEnabled { get; set; }

    /// <summary>
    /// The public network access setting for the Container App Environment. Possible values are Enabled and Disabled.
    /// The public network access setting for the Container App Environment.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>The name of the resource group in which the Container App Environment is to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1EnvironmentSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1EnvironmentSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more workload_profile blocks as defined below.</summary>
    [JsonPropertyName("workloadProfile")]
    public IList<V1beta1EnvironmentSpecForProviderWorkloadProfile>? WorkloadProfile { get; set; }

    /// <summary>Should the Container App Environment be created with Zone Redundancy enabled? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneRedundancyEnabled")]
    public bool? ZoneRedundancyEnabled { get; set; }
}

/// <summary>
/// Application Insights connection string used by Dapr to export Service to Service communication telemetry. Changing this forces a new resource to be created.
/// Application Insights connection string used by Dapr to export Service to Service communication telemetry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderDaprApplicationInsightsConnectionStringSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderIdentity
{
    /// <summary>- A list of one or more Resource IDs for User Assigned Managed identities to assign. Required when type is set to UserAssigned or SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of managed identity to assign. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelector
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
    public V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate infrastructureSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate infrastructureSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelector
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
    public V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum>))]
public enum V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelector
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
    public V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpecInitProviderWorkloadProfile
{
    /// <summary>The maximum number of instances of workload profile that can be deployed in the Container App Environment.</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of instances of workload profile that can be deployed in the Container App Environment.</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }

    /// <summary>The name of the workload profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Workload profile type for the workloads to run on. Possible values include Consumption, D4, D8, D16, D32, E4, E8, E16 and E32.</summary>
    [JsonPropertyName("workloadProfileType")]
    public string? WorkloadProfileType { get; set; }
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
public partial class V1beta1EnvironmentSpecInitProvider
{
    /// <summary>
    /// Application Insights connection string used by Dapr to export Service to Service communication telemetry. Changing this forces a new resource to be created.
    /// Application Insights connection string used by Dapr to export Service to Service communication telemetry.
    /// </summary>
    [JsonPropertyName("daprApplicationInsightsConnectionStringSecretRef")]
    public V1beta1EnvironmentSpecInitProviderDaprApplicationInsightsConnectionStringSecretRef? DaprApplicationInsightsConnectionStringSecretRef { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1EnvironmentSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. Changing this forces a new resource to be created.
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.
    /// </summary>
    [JsonPropertyName("infrastructureResourceGroupName")]
    public string? InfrastructureResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
    [JsonPropertyName("infrastructureResourceGroupNameRef")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameRef? InfrastructureResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate infrastructureResourceGroupName.</summary>
    [JsonPropertyName("infrastructureResourceGroupNameSelector")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureResourceGroupNameSelector? InfrastructureResourceGroupNameSelector { get; set; }

    /// <summary>
    /// The existing Subnet to use for the Container Apps Control Plane. Changing this forces a new resource to be created.
    /// The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.
    /// </summary>
    [JsonPropertyName("infrastructureSubnetId")]
    public string? InfrastructureSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate infrastructureSubnetId.</summary>
    [JsonPropertyName("infrastructureSubnetIdRef")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdRef? InfrastructureSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate infrastructureSubnetId.</summary>
    [JsonPropertyName("infrastructureSubnetIdSelector")]
    public V1beta1EnvironmentSpecInitProviderInfrastructureSubnetIdSelector? InfrastructureSubnetIdSelector { get; set; }

    /// <summary>
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to false. Changing this forces a new resource to be created.
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.
    /// </summary>
    [JsonPropertyName("internalLoadBalancerEnabled")]
    public bool? InternalLoadBalancerEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the Container App Environment is to exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// </summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdRef")]
    public V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdRef? LogAnalyticsWorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in operationalinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdSelector")]
    public V1beta1EnvironmentSpecInitProviderLogAnalyticsWorkspaceIdSelector? LogAnalyticsWorkspaceIdSelector { get; set; }

    /// <summary>Where the application logs will be saved for this Container Apps Managed Environment. Possible values include log-analytics and azure-monitor. Omitting this value will result in logs being streamed only.</summary>
    [JsonPropertyName("logsDestination")]
    public string? LogsDestination { get; set; }

    /// <summary>
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to false.
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.
    /// </summary>
    [JsonPropertyName("mutualTlsEnabled")]
    public bool? MutualTlsEnabled { get; set; }

    /// <summary>
    /// The public network access setting for the Container App Environment. Possible values are Enabled and Disabled.
    /// The public network access setting for the Container App Environment.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more workload_profile blocks as defined below.</summary>
    [JsonPropertyName("workloadProfile")]
    public IList<V1beta1EnvironmentSpecInitProviderWorkloadProfile>? WorkloadProfile { get; set; }

    /// <summary>Should the Container App Environment be created with Zone Redundancy enabled? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneRedundancyEnabled")]
    public bool? ZoneRedundancyEnabled { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecManagementPoliciesEnum>))]
public enum V1beta1EnvironmentSpecManagementPoliciesEnum
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
public partial class V1beta1EnvironmentSpecProviderConfigRef
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
public partial class V1beta1EnvironmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>EnvironmentSpec defines the desired state of Environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1EnvironmentSpecForProvider ForProvider { get; set; }

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
    public V1beta1EnvironmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EnvironmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EnvironmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EnvironmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentStatusAtProviderIdentity
{
    /// <summary>- A list of one or more Resource IDs for User Assigned Managed identities to assign. Required when type is set to UserAssigned or SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The ID of the Container App Environment</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The ID of the Container App Environment</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The type of managed identity to assign. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentStatusAtProviderWorkloadProfile
{
    /// <summary>The maximum number of instances of workload profile that can be deployed in the Container App Environment.</summary>
    [JsonPropertyName("maximumCount")]
    public double? MaximumCount { get; set; }

    /// <summary>The minimum number of instances of workload profile that can be deployed in the Container App Environment.</summary>
    [JsonPropertyName("minimumCount")]
    public double? MinimumCount { get; set; }

    /// <summary>The name of the workload profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Workload profile type for the workloads to run on. Possible values include Consumption, D4, D8, D16, D32, E4, E8, E16 and E32.</summary>
    [JsonPropertyName("workloadProfileType")]
    public string? WorkloadProfileType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentStatusAtProvider
{
    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App Environment.
    /// The ID of the Custom Domain Verification for this Container App Environment.
    /// </summary>
    [JsonPropertyName("customDomainVerificationId")]
    public string? CustomDomainVerificationId { get; set; }

    /// <summary>
    /// The default, publicly resolvable, name of this Container App Environment.
    /// The default publicly resolvable name of this Container App Environment
    /// </summary>
    [JsonPropertyName("defaultDomain")]
    public string? DefaultDomain { get; set; }

    /// <summary>
    /// The network addressing in which the Container Apps in this Container App Environment will reside in CIDR notation.
    /// The network addressing in which the Container Apps in this Container App Environment will reside in CIDR notation.
    /// </summary>
    [JsonPropertyName("dockerBridgeCidr")]
    public string? DockerBridgeCidr { get; set; }

    /// <summary>The ID of the Container App Environment</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1EnvironmentStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. Changing this forces a new resource to be created.
    /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`.
    /// </summary>
    [JsonPropertyName("infrastructureResourceGroupName")]
    public string? InfrastructureResourceGroupName { get; set; }

    /// <summary>
    /// The existing Subnet to use for the Container Apps Control Plane. Changing this forces a new resource to be created.
    /// The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space.
    /// </summary>
    [JsonPropertyName("infrastructureSubnetId")]
    public string? InfrastructureSubnetId { get; set; }

    /// <summary>
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to false. Changing this forces a new resource to be created.
    /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified.
    /// </summary>
    [JsonPropertyName("internalLoadBalancerEnabled")]
    public bool? InternalLoadBalancerEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the Container App Environment is to exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to.
    /// </summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Where the application logs will be saved for this Container Apps Managed Environment. Possible values include log-analytics and azure-monitor. Omitting this value will result in logs being streamed only.</summary>
    [JsonPropertyName("logsDestination")]
    public string? LogsDestination { get; set; }

    /// <summary>
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to false.
    /// Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios.
    /// </summary>
    [JsonPropertyName("mutualTlsEnabled")]
    public bool? MutualTlsEnabled { get; set; }

    /// <summary>
    /// The IP range, in CIDR notation, that is reserved for environment infrastructure IP addresses.
    /// The IP range, in CIDR notation, that is reserved for environment infrastructure IP addresses.
    /// </summary>
    [JsonPropertyName("platformReservedCidr")]
    public string? PlatformReservedCidr { get; set; }

    /// <summary>
    /// The IP address from the IP range defined by platform_reserved_cidr that is reserved for the internal DNS server.
    /// The IP address from the IP range defined by `platform_reserved_cidr` that is reserved for the internal DNS server.
    /// </summary>
    [JsonPropertyName("platformReservedDnsIpAddress")]
    public string? PlatformReservedDnsIpAddress { get; set; }

    /// <summary>
    /// The public network access setting for the Container App Environment. Possible values are Enabled and Disabled.
    /// The public network access setting for the Container App Environment.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>The name of the resource group in which the Container App Environment is to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>
    /// The Static IP address of the Environment.
    /// The Static IP Address of the Environment.
    /// </summary>
    [JsonPropertyName("staticIpAddress")]
    public string? StaticIpAddress { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more workload_profile blocks as defined below.</summary>
    [JsonPropertyName("workloadProfile")]
    public IList<V1beta1EnvironmentStatusAtProviderWorkloadProfile>? WorkloadProfile { get; set; }

    /// <summary>Should the Container App Environment be created with Zone Redundancy enabled? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneRedundancyEnabled")]
    public bool? ZoneRedundancyEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentStatusConditions
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

/// <summary>EnvironmentStatus defines the observed state of Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EnvironmentStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1EnvironmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EnvironmentStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Environment is the Schema for the Environments API. Manages a Container App Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Environment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EnvironmentSpec>, IStatus<V1beta1EnvironmentStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Environment";
    public const string KubeGroup = "containerapp.azure.m.upbound.io";
    public const string KubePluralName = "environments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerapp.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Environment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EnvironmentSpec defines the desired state of Environment</summary>
    [JsonPropertyName("spec")]
    public required V1beta1EnvironmentSpec Spec { get; set; }

    /// <summary>EnvironmentStatus defines the observed state of Environment.</summary>
    [JsonPropertyName("status")]
    public V1beta1EnvironmentStatus? Status { get; set; }
}