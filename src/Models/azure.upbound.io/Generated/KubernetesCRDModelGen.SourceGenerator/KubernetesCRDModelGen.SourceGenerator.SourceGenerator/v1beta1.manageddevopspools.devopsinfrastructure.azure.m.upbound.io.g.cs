#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.devopsinfrastructure.azure.m.upbound.io;
/// <summary>ManagedDevopsPool is the Schema for the ManagedDevopsPools API. Manages a Managed DevOps Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagedDevopsPoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ManagedDevopsPool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagedDevopsPoolList";
    public const string KubeGroup = "devopsinfrastructure.azure.m.upbound.io";
    public const string KubePluralName = "manageddevopspools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "devopsinfrastructure.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedDevopsPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ManagedDevopsPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ManagedDevopsPool> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderAzureDevopsOrganizationOrganization
{
    /// <summary>Specifies how many machines can be created at maximum in this organization out of the maximum_concurrency of the pool. Possible values range between 1 and 10000.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>List of projects in which the pool should be created.</summary>
    [JsonPropertyName("projects")]
    public IList<string>? Projects { get; set; }

    /// <summary>The Azure DevOps organization URL in which the pool should be created. It must end with a letter or number.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>An administrator_account block as defined below. This block is only valid when kind is set to SpecificAccounts. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderAzureDevopsOrganizationPermissionAdministratorAccount
{
    /// <summary>Specifies a list of group email addresses. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>Specifies a list of user email addresses. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary>A permission block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderAzureDevopsOrganizationPermission
{
    /// <summary>An administrator_account block as defined below. This block is only valid when kind is set to SpecificAccounts. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("administratorAccount")]
    public V1beta1ManagedDevopsPoolSpecForProviderAzureDevopsOrganizationPermissionAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary>Determines who has admin permissions to the Azure DevOps pool. Possible values are Inherit and SpecificAccounts. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>An azure_devops_organization block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderAzureDevopsOrganization
{
    /// <summary>One or more organization blocks as defined below.</summary>
    [JsonPropertyName("organization")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderAzureDevopsOrganizationOrganization>? Organization { get; set; }

    /// <summary>A permission block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("permission")]
    public V1beta1ManagedDevopsPoolSpecForProviderAzureDevopsOrganizationPermission? Permission { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdRefPolicyResolutionEnum>))]
public enum V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdRefPolicyResolveEnum>))]
public enum V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in devcenter to populate devCenterProjectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdSelectorPolicyResolveEnum>))]
public enum V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in devcenter to populate devCenterProjectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdSelector
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
    public V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of managed service identity. The only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameSelector
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
    public V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>An automatic_resource_prediction block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentAutomaticResourcePrediction
{
    /// <summary>Specifies the desired balance between cost and performance. Possible values are MostCostEffective, MoreCostEffective, Balanced, MorePerformance, and BestPerformance. Defaults to Balanced.</summary>
    [JsonPropertyName("predictionPreference")]
    public string? PredictionPreference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionFridaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionMondaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionSaturdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionSundaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionThursdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionTuesdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionWednesdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>A manual_resource_prediction block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePrediction
{
    /// <summary>A number of agents available 24/7 all week. Possible values range between 1 and maximum_concurrency.</summary>
    [JsonPropertyName("allWeekSchedule")]
    public double? AllWeekSchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("fridaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionFridaySchedule>? FridaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("mondaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionMondaySchedule>? MondaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("saturdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionSaturdaySchedule>? SaturdaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("sundaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionSundaySchedule>? SundaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("thursdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionThursdaySchedule>? ThursdaySchedule { get; set; }

    /// <summary>Specifies the time zone for the predictions data to be provisioned at. Defaults to UTC.</summary>
    [JsonPropertyName("timeZoneName")]
    public string? TimeZoneName { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("tuesdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionTuesdaySchedule>? TuesdaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("wednesdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePredictionWednesdaySchedule>? WednesdaySchedule { get; set; }
}

/// <summary>A stateful_agent block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatefulAgent
{
    /// <summary>An automatic_resource_prediction block as defined below.</summary>
    [JsonPropertyName("automaticResourcePrediction")]
    public V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentAutomaticResourcePrediction? AutomaticResourcePrediction { get; set; }

    /// <summary>Configures the amount of time an agent in a stateful pool waits for new jobs before shutting down after all current and queued jobs are complete. The format for Grace Period is dd.hh:mm:ss or hh:mm:ss. Defaults to 00:00:00.</summary>
    [JsonPropertyName("gracePeriodTimeSpan")]
    public string? GracePeriodTimeSpan { get; set; }

    /// <summary>A manual_resource_prediction block as defined below.</summary>
    [JsonPropertyName("manualResourcePrediction")]
    public V1beta1ManagedDevopsPoolSpecForProviderStatefulAgentManualResourcePrediction? ManualResourcePrediction { get; set; }

    /// <summary>Configures the maximum duration an agent in a stateful pool can run before it is shut down and discarded. The format for Max time to live for standby agents is dd.hh:mm:ss or hh:mm:ss. Defaults to 7.00:00:00.</summary>
    [JsonPropertyName("maximumAgentLifetime")]
    public string? MaximumAgentLifetime { get; set; }
}

/// <summary>An automatic_resource_prediction block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentAutomaticResourcePrediction
{
    /// <summary>Specifies the desired balance between cost and performance. Possible values are MostCostEffective, MoreCostEffective, Balanced, MorePerformance, and BestPerformance. Defaults to Balanced.</summary>
    [JsonPropertyName("predictionPreference")]
    public string? PredictionPreference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionFridaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionMondaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionSaturdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionSundaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionThursdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionTuesdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionWednesdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>A manual_resource_prediction block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePrediction
{
    /// <summary>A number of agents available 24/7 all week. Possible values range between 1 and maximum_concurrency.</summary>
    [JsonPropertyName("allWeekSchedule")]
    public double? AllWeekSchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("fridaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionFridaySchedule>? FridaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("mondaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionMondaySchedule>? MondaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("saturdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionSaturdaySchedule>? SaturdaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("sundaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionSundaySchedule>? SundaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("thursdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionThursdaySchedule>? ThursdaySchedule { get; set; }

    /// <summary>Specifies the time zone for the predictions data to be provisioned at. Defaults to UTC.</summary>
    [JsonPropertyName("timeZoneName")]
    public string? TimeZoneName { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("tuesdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionTuesdaySchedule>? TuesdaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("wednesdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePredictionWednesdaySchedule>? WednesdaySchedule { get; set; }
}

/// <summary>A stateless_agent block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderStatelessAgent
{
    /// <summary>An automatic_resource_prediction block as defined below.</summary>
    [JsonPropertyName("automaticResourcePrediction")]
    public V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentAutomaticResourcePrediction? AutomaticResourcePrediction { get; set; }

    /// <summary>A manual_resource_prediction block as defined below.</summary>
    [JsonPropertyName("manualResourcePrediction")]
    public V1beta1ManagedDevopsPoolSpecForProviderStatelessAgentManualResourcePrediction? ManualResourcePrediction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricImage
{
    /// <summary>List of aliases to reference the image by.</summary>
    [JsonPropertyName("aliases")]
    public IList<string>? Aliases { get; set; }

    /// <summary>The percentage of the buffer to be allocated to this image. Possible values are * or between 0 and 100. Defaults to *.</summary>
    [JsonPropertyName("buffer")]
    public string? Buffer { get; set; }

    /// <summary>The resource id of the image.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The image to use from a well-known set of images made available to customers.</summary>
    [JsonPropertyName("wellKnownImageName")]
    public string? WellKnownImageName { get; set; }
}

/// <summary>A key_vault_management block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSecurityKeyVaultManagement
{
    /// <summary>Specifies where to store certificates on the machine.</summary>
    [JsonPropertyName("certificateStoreLocation")]
    public string? CertificateStoreLocation { get; set; }

    /// <summary>Name of the certificate store to use on the machine. Possible values are My and Root.</summary>
    [JsonPropertyName("certificateStoreName")]
    public string? CertificateStoreName { get; set; }

    /// <summary>Defines if the key of the certificates should be exportable. Defaults to false.</summary>
    [JsonPropertyName("keyExportEnabled")]
    public bool? KeyExportEnabled { get; set; }

    /// <summary>A list of versionless_id from Azure Key vault certificates to install on all machines in the pool.</summary>
    [JsonPropertyName("keyVaultCertificateIds")]
    public IList<string>? KeyVaultCertificateIds { get; set; }
}

/// <summary>A security block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSecurity
{
    /// <summary>Specifies whether the agent should run in interactive mode. Defaults to false.</summary>
    [JsonPropertyName("interactiveLogonEnabled")]
    public bool? InteractiveLogonEnabled { get; set; }

    /// <summary>A key_vault_management block as defined below.</summary>
    [JsonPropertyName("keyVaultManagement")]
    public V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSecurityKeyVaultManagement? KeyVaultManagement { get; set; }
}

/// <summary>A storage block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricStorage
{
    /// <summary>The type of caching for the data disk. Possible values are ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The initial disk size in gigabytes. Possible values range between 1 and 32767.</summary>
    [JsonPropertyName("diskSizeInGb")]
    public double? DiskSizeInGb { get; set; }

    /// <summary>The drive letter for the data disk.</summary>
    [JsonPropertyName("driveLetter")]
    public string? DriveLetter { get; set; }

    /// <summary>The storage account type of the data disk. Possible values are Premium_LRS, Premium_ZRS, Standard_LRS, StandardSSD_LRS, and StandardSSD_ZRS. Defaults to Standard_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdSelector
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
    public V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A virtual_machine_scale_set_fabric block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabric
{
    /// <summary>One or more image blocks as defined below.</summary>
    [JsonPropertyName("image")]
    public IList<V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricImage>? Image { get; set; }

    /// <summary>The storage account type for the OS disk. Possible values are Premium, Standard, and StandardSSD. Defaults to Standard.</summary>
    [JsonPropertyName("osDiskStorageAccountType")]
    public string? OsDiskStorageAccountType { get; set; }

    /// <summary>A security block as defined below.</summary>
    [JsonPropertyName("security")]
    public V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSecurity? Security { get; set; }

    /// <summary>The Azure SKU name of the machines in the pool.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A storage block as defined below.</summary>
    [JsonPropertyName("storage")]
    public V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricStorage? Storage { get; set; }

    /// <summary>The subnet ID on which to put all machines created in the pool.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabricSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecForProvider
{
    /// <summary>An azure_devops_organization block as defined below.</summary>
    [JsonPropertyName("azureDevopsOrganization")]
    public V1beta1ManagedDevopsPoolSpecForProviderAzureDevopsOrganization? AzureDevopsOrganization { get; set; }

    /// <summary>The ID of the Dev Center project.</summary>
    [JsonPropertyName("devCenterProjectId")]
    public string? DevCenterProjectId { get; set; }

    /// <summary>Reference to a Project in devcenter to populate devCenterProjectId.</summary>
    [JsonPropertyName("devCenterProjectIdRef")]
    public V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdRef? DevCenterProjectIdRef { get; set; }

    /// <summary>Selector for a Project in devcenter to populate devCenterProjectId.</summary>
    [JsonPropertyName("devCenterProjectIdSelector")]
    public V1beta1ManagedDevopsPoolSpecForProviderDevCenterProjectIdSelector? DevCenterProjectIdSelector { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ManagedDevopsPoolSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the Managed DevOps Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines how many resources can there be created at any given time. Possible values range between 1 and 10000.</summary>
    [JsonPropertyName("maximumConcurrency")]
    public double? MaximumConcurrency { get; set; }

    /// <summary>The name of the Resource Group where the Managed DevOps Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ManagedDevopsPoolSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A stateful_agent block as defined below.</summary>
    [JsonPropertyName("statefulAgent")]
    public V1beta1ManagedDevopsPoolSpecForProviderStatefulAgent? StatefulAgent { get; set; }

    /// <summary>A stateless_agent block as defined below.</summary>
    [JsonPropertyName("statelessAgent")]
    public V1beta1ManagedDevopsPoolSpecForProviderStatelessAgent? StatelessAgent { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Managed DevOps Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A virtual_machine_scale_set_fabric block as defined below.</summary>
    [JsonPropertyName("virtualMachineScaleSetFabric")]
    public V1beta1ManagedDevopsPoolSpecForProviderVirtualMachineScaleSetFabric? VirtualMachineScaleSetFabric { get; set; }

    /// <summary>Specifies the work folder for every agent in the pool.</summary>
    [JsonPropertyName("workFolder")]
    public string? WorkFolder { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderAzureDevopsOrganizationOrganization
{
    /// <summary>Specifies how many machines can be created at maximum in this organization out of the maximum_concurrency of the pool. Possible values range between 1 and 10000.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>List of projects in which the pool should be created.</summary>
    [JsonPropertyName("projects")]
    public IList<string>? Projects { get; set; }

    /// <summary>The Azure DevOps organization URL in which the pool should be created. It must end with a letter or number.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>An administrator_account block as defined below. This block is only valid when kind is set to SpecificAccounts. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderAzureDevopsOrganizationPermissionAdministratorAccount
{
    /// <summary>Specifies a list of group email addresses. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>Specifies a list of user email addresses. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary>A permission block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderAzureDevopsOrganizationPermission
{
    /// <summary>An administrator_account block as defined below. This block is only valid when kind is set to SpecificAccounts. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("administratorAccount")]
    public V1beta1ManagedDevopsPoolSpecInitProviderAzureDevopsOrganizationPermissionAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary>Determines who has admin permissions to the Azure DevOps pool. Possible values are Inherit and SpecificAccounts. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>An azure_devops_organization block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderAzureDevopsOrganization
{
    /// <summary>One or more organization blocks as defined below.</summary>
    [JsonPropertyName("organization")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderAzureDevopsOrganizationOrganization>? Organization { get; set; }

    /// <summary>A permission block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("permission")]
    public V1beta1ManagedDevopsPoolSpecInitProviderAzureDevopsOrganizationPermission? Permission { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdRefPolicyResolutionEnum>))]
public enum V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdRefPolicyResolveEnum>))]
public enum V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in devcenter to populate devCenterProjectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdSelectorPolicyResolveEnum>))]
public enum V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in devcenter to populate devCenterProjectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdSelector
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
    public V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of managed service identity. The only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>An automatic_resource_prediction block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentAutomaticResourcePrediction
{
    /// <summary>Specifies the desired balance between cost and performance. Possible values are MostCostEffective, MoreCostEffective, Balanced, MorePerformance, and BestPerformance. Defaults to Balanced.</summary>
    [JsonPropertyName("predictionPreference")]
    public string? PredictionPreference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionFridaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionMondaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionSaturdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionSundaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionThursdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionTuesdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionWednesdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>A manual_resource_prediction block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePrediction
{
    /// <summary>A number of agents available 24/7 all week. Possible values range between 1 and maximum_concurrency.</summary>
    [JsonPropertyName("allWeekSchedule")]
    public double? AllWeekSchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("fridaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionFridaySchedule>? FridaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("mondaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionMondaySchedule>? MondaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("saturdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionSaturdaySchedule>? SaturdaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("sundaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionSundaySchedule>? SundaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("thursdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionThursdaySchedule>? ThursdaySchedule { get; set; }

    /// <summary>Specifies the time zone for the predictions data to be provisioned at. Defaults to UTC.</summary>
    [JsonPropertyName("timeZoneName")]
    public string? TimeZoneName { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("tuesdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionTuesdaySchedule>? TuesdaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("wednesdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePredictionWednesdaySchedule>? WednesdaySchedule { get; set; }
}

/// <summary>A stateful_agent block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgent
{
    /// <summary>An automatic_resource_prediction block as defined below.</summary>
    [JsonPropertyName("automaticResourcePrediction")]
    public V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentAutomaticResourcePrediction? AutomaticResourcePrediction { get; set; }

    /// <summary>Configures the amount of time an agent in a stateful pool waits for new jobs before shutting down after all current and queued jobs are complete. The format for Grace Period is dd.hh:mm:ss or hh:mm:ss. Defaults to 00:00:00.</summary>
    [JsonPropertyName("gracePeriodTimeSpan")]
    public string? GracePeriodTimeSpan { get; set; }

    /// <summary>A manual_resource_prediction block as defined below.</summary>
    [JsonPropertyName("manualResourcePrediction")]
    public V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgentManualResourcePrediction? ManualResourcePrediction { get; set; }

    /// <summary>Configures the maximum duration an agent in a stateful pool can run before it is shut down and discarded. The format for Max time to live for standby agents is dd.hh:mm:ss or hh:mm:ss. Defaults to 7.00:00:00.</summary>
    [JsonPropertyName("maximumAgentLifetime")]
    public string? MaximumAgentLifetime { get; set; }
}

/// <summary>An automatic_resource_prediction block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentAutomaticResourcePrediction
{
    /// <summary>Specifies the desired balance between cost and performance. Possible values are MostCostEffective, MoreCostEffective, Balanced, MorePerformance, and BestPerformance. Defaults to Balanced.</summary>
    [JsonPropertyName("predictionPreference")]
    public string? PredictionPreference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionFridaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionMondaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionSaturdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionSundaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionThursdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionTuesdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionWednesdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>A manual_resource_prediction block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePrediction
{
    /// <summary>A number of agents available 24/7 all week. Possible values range between 1 and maximum_concurrency.</summary>
    [JsonPropertyName("allWeekSchedule")]
    public double? AllWeekSchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("fridaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionFridaySchedule>? FridaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("mondaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionMondaySchedule>? MondaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("saturdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionSaturdaySchedule>? SaturdaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("sundaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionSundaySchedule>? SundaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("thursdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionThursdaySchedule>? ThursdaySchedule { get; set; }

    /// <summary>Specifies the time zone for the predictions data to be provisioned at. Defaults to UTC.</summary>
    [JsonPropertyName("timeZoneName")]
    public string? TimeZoneName { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("tuesdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionTuesdaySchedule>? TuesdaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("wednesdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePredictionWednesdaySchedule>? WednesdaySchedule { get; set; }
}

/// <summary>A stateless_agent block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgent
{
    /// <summary>An automatic_resource_prediction block as defined below.</summary>
    [JsonPropertyName("automaticResourcePrediction")]
    public V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentAutomaticResourcePrediction? AutomaticResourcePrediction { get; set; }

    /// <summary>A manual_resource_prediction block as defined below.</summary>
    [JsonPropertyName("manualResourcePrediction")]
    public V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgentManualResourcePrediction? ManualResourcePrediction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricImage
{
    /// <summary>List of aliases to reference the image by.</summary>
    [JsonPropertyName("aliases")]
    public IList<string>? Aliases { get; set; }

    /// <summary>The percentage of the buffer to be allocated to this image. Possible values are * or between 0 and 100. Defaults to *.</summary>
    [JsonPropertyName("buffer")]
    public string? Buffer { get; set; }

    /// <summary>The resource id of the image.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The image to use from a well-known set of images made available to customers.</summary>
    [JsonPropertyName("wellKnownImageName")]
    public string? WellKnownImageName { get; set; }
}

/// <summary>A key_vault_management block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSecurityKeyVaultManagement
{
    /// <summary>Specifies where to store certificates on the machine.</summary>
    [JsonPropertyName("certificateStoreLocation")]
    public string? CertificateStoreLocation { get; set; }

    /// <summary>Name of the certificate store to use on the machine. Possible values are My and Root.</summary>
    [JsonPropertyName("certificateStoreName")]
    public string? CertificateStoreName { get; set; }

    /// <summary>Defines if the key of the certificates should be exportable. Defaults to false.</summary>
    [JsonPropertyName("keyExportEnabled")]
    public bool? KeyExportEnabled { get; set; }

    /// <summary>A list of versionless_id from Azure Key vault certificates to install on all machines in the pool.</summary>
    [JsonPropertyName("keyVaultCertificateIds")]
    public IList<string>? KeyVaultCertificateIds { get; set; }
}

/// <summary>A security block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSecurity
{
    /// <summary>Specifies whether the agent should run in interactive mode. Defaults to false.</summary>
    [JsonPropertyName("interactiveLogonEnabled")]
    public bool? InteractiveLogonEnabled { get; set; }

    /// <summary>A key_vault_management block as defined below.</summary>
    [JsonPropertyName("keyVaultManagement")]
    public V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSecurityKeyVaultManagement? KeyVaultManagement { get; set; }
}

/// <summary>A storage block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricStorage
{
    /// <summary>The type of caching for the data disk. Possible values are ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The initial disk size in gigabytes. Possible values range between 1 and 32767.</summary>
    [JsonPropertyName("diskSizeInGb")]
    public double? DiskSizeInGb { get; set; }

    /// <summary>The drive letter for the data disk.</summary>
    [JsonPropertyName("driveLetter")]
    public string? DriveLetter { get; set; }

    /// <summary>The storage account type of the data disk. Possible values are Premium_LRS, Premium_ZRS, Standard_LRS, StandardSSD_LRS, and StandardSSD_ZRS. Defaults to Standard_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdSelector
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
    public V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A virtual_machine_scale_set_fabric block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabric
{
    /// <summary>One or more image blocks as defined below.</summary>
    [JsonPropertyName("image")]
    public IList<V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricImage>? Image { get; set; }

    /// <summary>The storage account type for the OS disk. Possible values are Premium, Standard, and StandardSSD. Defaults to Standard.</summary>
    [JsonPropertyName("osDiskStorageAccountType")]
    public string? OsDiskStorageAccountType { get; set; }

    /// <summary>A security block as defined below.</summary>
    [JsonPropertyName("security")]
    public V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSecurity? Security { get; set; }

    /// <summary>The Azure SKU name of the machines in the pool.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A storage block as defined below.</summary>
    [JsonPropertyName("storage")]
    public V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricStorage? Storage { get; set; }

    /// <summary>The subnet ID on which to put all machines created in the pool.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabricSubnetIdSelector? SubnetIdSelector { get; set; }
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
public partial class V1beta1ManagedDevopsPoolSpecInitProvider
{
    /// <summary>An azure_devops_organization block as defined below.</summary>
    [JsonPropertyName("azureDevopsOrganization")]
    public V1beta1ManagedDevopsPoolSpecInitProviderAzureDevopsOrganization? AzureDevopsOrganization { get; set; }

    /// <summary>The ID of the Dev Center project.</summary>
    [JsonPropertyName("devCenterProjectId")]
    public string? DevCenterProjectId { get; set; }

    /// <summary>Reference to a Project in devcenter to populate devCenterProjectId.</summary>
    [JsonPropertyName("devCenterProjectIdRef")]
    public V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdRef? DevCenterProjectIdRef { get; set; }

    /// <summary>Selector for a Project in devcenter to populate devCenterProjectId.</summary>
    [JsonPropertyName("devCenterProjectIdSelector")]
    public V1beta1ManagedDevopsPoolSpecInitProviderDevCenterProjectIdSelector? DevCenterProjectIdSelector { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ManagedDevopsPoolSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the Managed DevOps Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines how many resources can there be created at any given time. Possible values range between 1 and 10000.</summary>
    [JsonPropertyName("maximumConcurrency")]
    public double? MaximumConcurrency { get; set; }

    /// <summary>A stateful_agent block as defined below.</summary>
    [JsonPropertyName("statefulAgent")]
    public V1beta1ManagedDevopsPoolSpecInitProviderStatefulAgent? StatefulAgent { get; set; }

    /// <summary>A stateless_agent block as defined below.</summary>
    [JsonPropertyName("statelessAgent")]
    public V1beta1ManagedDevopsPoolSpecInitProviderStatelessAgent? StatelessAgent { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Managed DevOps Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A virtual_machine_scale_set_fabric block as defined below.</summary>
    [JsonPropertyName("virtualMachineScaleSetFabric")]
    public V1beta1ManagedDevopsPoolSpecInitProviderVirtualMachineScaleSetFabric? VirtualMachineScaleSetFabric { get; set; }

    /// <summary>Specifies the work folder for every agent in the pool.</summary>
    [JsonPropertyName("workFolder")]
    public string? WorkFolder { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ManagedDevopsPoolSpecManagementPoliciesEnum>))]
public enum V1beta1ManagedDevopsPoolSpecManagementPoliciesEnum
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
public partial class V1beta1ManagedDevopsPoolSpecProviderConfigRef
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
public partial class V1beta1ManagedDevopsPoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ManagedDevopsPoolSpec defines the desired state of ManagedDevopsPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ManagedDevopsPoolSpecForProvider ForProvider { get; set; }

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
    public V1beta1ManagedDevopsPoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ManagedDevopsPoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ManagedDevopsPoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ManagedDevopsPoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderAzureDevopsOrganizationOrganization
{
    /// <summary>Specifies how many machines can be created at maximum in this organization out of the maximum_concurrency of the pool. Possible values range between 1 and 10000.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>List of projects in which the pool should be created.</summary>
    [JsonPropertyName("projects")]
    public IList<string>? Projects { get; set; }

    /// <summary>The Azure DevOps organization URL in which the pool should be created. It must end with a letter or number.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>An administrator_account block as defined below. This block is only valid when kind is set to SpecificAccounts. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderAzureDevopsOrganizationPermissionAdministratorAccount
{
    /// <summary>Specifies a list of group email addresses. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>Specifies a list of user email addresses. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary>A permission block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderAzureDevopsOrganizationPermission
{
    /// <summary>An administrator_account block as defined below. This block is only valid when kind is set to SpecificAccounts. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("administratorAccount")]
    public V1beta1ManagedDevopsPoolStatusAtProviderAzureDevopsOrganizationPermissionAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary>Determines who has admin permissions to the Azure DevOps pool. Possible values are Inherit and SpecificAccounts. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>An azure_devops_organization block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderAzureDevopsOrganization
{
    /// <summary>One or more organization blocks as defined below.</summary>
    [JsonPropertyName("organization")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderAzureDevopsOrganizationOrganization>? Organization { get; set; }

    /// <summary>A permission block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("permission")]
    public V1beta1ManagedDevopsPoolStatusAtProviderAzureDevopsOrganizationPermission? Permission { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of managed service identity. The only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>An automatic_resource_prediction block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentAutomaticResourcePrediction
{
    /// <summary>Specifies the desired balance between cost and performance. Possible values are MostCostEffective, MoreCostEffective, Balanced, MorePerformance, and BestPerformance. Defaults to Balanced.</summary>
    [JsonPropertyName("predictionPreference")]
    public string? PredictionPreference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionFridaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionMondaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionSaturdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionSundaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionThursdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionTuesdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionWednesdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>A manual_resource_prediction block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePrediction
{
    /// <summary>A number of agents available 24/7 all week. Possible values range between 1 and maximum_concurrency.</summary>
    [JsonPropertyName("allWeekSchedule")]
    public double? AllWeekSchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("fridaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionFridaySchedule>? FridaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("mondaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionMondaySchedule>? MondaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("saturdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionSaturdaySchedule>? SaturdaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("sundaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionSundaySchedule>? SundaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("thursdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionThursdaySchedule>? ThursdaySchedule { get; set; }

    /// <summary>Specifies the time zone for the predictions data to be provisioned at. Defaults to UTC.</summary>
    [JsonPropertyName("timeZoneName")]
    public string? TimeZoneName { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("tuesdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionTuesdaySchedule>? TuesdaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("wednesdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePredictionWednesdaySchedule>? WednesdaySchedule { get; set; }
}

/// <summary>A stateful_agent block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgent
{
    /// <summary>An automatic_resource_prediction block as defined below.</summary>
    [JsonPropertyName("automaticResourcePrediction")]
    public V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentAutomaticResourcePrediction? AutomaticResourcePrediction { get; set; }

    /// <summary>Configures the amount of time an agent in a stateful pool waits for new jobs before shutting down after all current and queued jobs are complete. The format for Grace Period is dd.hh:mm:ss or hh:mm:ss. Defaults to 00:00:00.</summary>
    [JsonPropertyName("gracePeriodTimeSpan")]
    public string? GracePeriodTimeSpan { get; set; }

    /// <summary>A manual_resource_prediction block as defined below.</summary>
    [JsonPropertyName("manualResourcePrediction")]
    public V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgentManualResourcePrediction? ManualResourcePrediction { get; set; }

    /// <summary>Configures the maximum duration an agent in a stateful pool can run before it is shut down and discarded. The format for Max time to live for standby agents is dd.hh:mm:ss or hh:mm:ss. Defaults to 7.00:00:00.</summary>
    [JsonPropertyName("maximumAgentLifetime")]
    public string? MaximumAgentLifetime { get; set; }
}

/// <summary>An automatic_resource_prediction block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentAutomaticResourcePrediction
{
    /// <summary>Specifies the desired balance between cost and performance. Possible values are MostCostEffective, MoreCostEffective, Balanced, MorePerformance, and BestPerformance. Defaults to Balanced.</summary>
    [JsonPropertyName("predictionPreference")]
    public string? PredictionPreference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionFridaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionMondaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionSaturdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionSundaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionThursdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionTuesdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionWednesdaySchedule
{
    /// <summary>The number of standby agents to provision at this time. Possible values range between 0 and maximum_concurrency.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time of day at which the agent count changes, in 24-hour format HH:MM:SS.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>A manual_resource_prediction block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePrediction
{
    /// <summary>A number of agents available 24/7 all week. Possible values range between 1 and maximum_concurrency.</summary>
    [JsonPropertyName("allWeekSchedule")]
    public double? AllWeekSchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("fridaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionFridaySchedule>? FridaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("mondaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionMondaySchedule>? MondaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("saturdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionSaturdaySchedule>? SaturdaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("sundaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionSundaySchedule>? SundaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("thursdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionThursdaySchedule>? ThursdaySchedule { get; set; }

    /// <summary>Specifies the time zone for the predictions data to be provisioned at. Defaults to UTC.</summary>
    [JsonPropertyName("timeZoneName")]
    public string? TimeZoneName { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("tuesdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionTuesdaySchedule>? TuesdaySchedule { get; set; }

    /// <summary>One or more daily_schedule blocks as defined below.</summary>
    [JsonPropertyName("wednesdaySchedule")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePredictionWednesdaySchedule>? WednesdaySchedule { get; set; }
}

/// <summary>A stateless_agent block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgent
{
    /// <summary>An automatic_resource_prediction block as defined below.</summary>
    [JsonPropertyName("automaticResourcePrediction")]
    public V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentAutomaticResourcePrediction? AutomaticResourcePrediction { get; set; }

    /// <summary>A manual_resource_prediction block as defined below.</summary>
    [JsonPropertyName("manualResourcePrediction")]
    public V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgentManualResourcePrediction? ManualResourcePrediction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderVirtualMachineScaleSetFabricImage
{
    /// <summary>List of aliases to reference the image by.</summary>
    [JsonPropertyName("aliases")]
    public IList<string>? Aliases { get; set; }

    /// <summary>The percentage of the buffer to be allocated to this image. Possible values are * or between 0 and 100. Defaults to *.</summary>
    [JsonPropertyName("buffer")]
    public string? Buffer { get; set; }

    /// <summary>The resource id of the image.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The image to use from a well-known set of images made available to customers.</summary>
    [JsonPropertyName("wellKnownImageName")]
    public string? WellKnownImageName { get; set; }
}

/// <summary>A key_vault_management block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderVirtualMachineScaleSetFabricSecurityKeyVaultManagement
{
    /// <summary>Specifies where to store certificates on the machine.</summary>
    [JsonPropertyName("certificateStoreLocation")]
    public string? CertificateStoreLocation { get; set; }

    /// <summary>Name of the certificate store to use on the machine. Possible values are My and Root.</summary>
    [JsonPropertyName("certificateStoreName")]
    public string? CertificateStoreName { get; set; }

    /// <summary>Defines if the key of the certificates should be exportable. Defaults to false.</summary>
    [JsonPropertyName("keyExportEnabled")]
    public bool? KeyExportEnabled { get; set; }

    /// <summary>A list of versionless_id from Azure Key vault certificates to install on all machines in the pool.</summary>
    [JsonPropertyName("keyVaultCertificateIds")]
    public IList<string>? KeyVaultCertificateIds { get; set; }
}

/// <summary>A security block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderVirtualMachineScaleSetFabricSecurity
{
    /// <summary>Specifies whether the agent should run in interactive mode. Defaults to false.</summary>
    [JsonPropertyName("interactiveLogonEnabled")]
    public bool? InteractiveLogonEnabled { get; set; }

    /// <summary>A key_vault_management block as defined below.</summary>
    [JsonPropertyName("keyVaultManagement")]
    public V1beta1ManagedDevopsPoolStatusAtProviderVirtualMachineScaleSetFabricSecurityKeyVaultManagement? KeyVaultManagement { get; set; }
}

/// <summary>A storage block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderVirtualMachineScaleSetFabricStorage
{
    /// <summary>The type of caching for the data disk. Possible values are ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The initial disk size in gigabytes. Possible values range between 1 and 32767.</summary>
    [JsonPropertyName("diskSizeInGb")]
    public double? DiskSizeInGb { get; set; }

    /// <summary>The drive letter for the data disk.</summary>
    [JsonPropertyName("driveLetter")]
    public string? DriveLetter { get; set; }

    /// <summary>The storage account type of the data disk. Possible values are Premium_LRS, Premium_ZRS, Standard_LRS, StandardSSD_LRS, and StandardSSD_ZRS. Defaults to Standard_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>A virtual_machine_scale_set_fabric block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProviderVirtualMachineScaleSetFabric
{
    /// <summary>One or more image blocks as defined below.</summary>
    [JsonPropertyName("image")]
    public IList<V1beta1ManagedDevopsPoolStatusAtProviderVirtualMachineScaleSetFabricImage>? Image { get; set; }

    /// <summary>The storage account type for the OS disk. Possible values are Premium, Standard, and StandardSSD. Defaults to Standard.</summary>
    [JsonPropertyName("osDiskStorageAccountType")]
    public string? OsDiskStorageAccountType { get; set; }

    /// <summary>A security block as defined below.</summary>
    [JsonPropertyName("security")]
    public V1beta1ManagedDevopsPoolStatusAtProviderVirtualMachineScaleSetFabricSecurity? Security { get; set; }

    /// <summary>The Azure SKU name of the machines in the pool.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A storage block as defined below.</summary>
    [JsonPropertyName("storage")]
    public V1beta1ManagedDevopsPoolStatusAtProviderVirtualMachineScaleSetFabricStorage? Storage { get; set; }

    /// <summary>The subnet ID on which to put all machines created in the pool.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusAtProvider
{
    /// <summary>An azure_devops_organization block as defined below.</summary>
    [JsonPropertyName("azureDevopsOrganization")]
    public V1beta1ManagedDevopsPoolStatusAtProviderAzureDevopsOrganization? AzureDevopsOrganization { get; set; }

    /// <summary>The ID of the Dev Center project.</summary>
    [JsonPropertyName("devCenterProjectId")]
    public string? DevCenterProjectId { get; set; }

    /// <summary>The ID of the Managed DevOps Pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ManagedDevopsPoolStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the Managed DevOps Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Defines how many resources can there be created at any given time. Possible values range between 1 and 10000.</summary>
    [JsonPropertyName("maximumConcurrency")]
    public double? MaximumConcurrency { get; set; }

    /// <summary>The name of the Resource Group where the Managed DevOps Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A stateful_agent block as defined below.</summary>
    [JsonPropertyName("statefulAgent")]
    public V1beta1ManagedDevopsPoolStatusAtProviderStatefulAgent? StatefulAgent { get; set; }

    /// <summary>A stateless_agent block as defined below.</summary>
    [JsonPropertyName("statelessAgent")]
    public V1beta1ManagedDevopsPoolStatusAtProviderStatelessAgent? StatelessAgent { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Managed DevOps Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A virtual_machine_scale_set_fabric block as defined below.</summary>
    [JsonPropertyName("virtualMachineScaleSetFabric")]
    public V1beta1ManagedDevopsPoolStatusAtProviderVirtualMachineScaleSetFabric? VirtualMachineScaleSetFabric { get; set; }

    /// <summary>Specifies the work folder for every agent in the pool.</summary>
    [JsonPropertyName("workFolder")]
    public string? WorkFolder { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatusConditions
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

/// <summary>ManagedDevopsPoolStatus defines the observed state of ManagedDevopsPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedDevopsPoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ManagedDevopsPoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ManagedDevopsPoolStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ManagedDevopsPool is the Schema for the ManagedDevopsPools API. Manages a Managed DevOps Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagedDevopsPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ManagedDevopsPoolSpec>, IStatus<V1beta1ManagedDevopsPoolStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagedDevopsPool";
    public const string KubeGroup = "devopsinfrastructure.azure.m.upbound.io";
    public const string KubePluralName = "manageddevopspools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "devopsinfrastructure.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedDevopsPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedDevopsPoolSpec defines the desired state of ManagedDevopsPool</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ManagedDevopsPoolSpec Spec { get; set; }

    /// <summary>ManagedDevopsPoolStatus defines the observed state of ManagedDevopsPool.</summary>
    [JsonPropertyName("status")]
    public V1beta1ManagedDevopsPoolStatus? Status { get; set; }
}