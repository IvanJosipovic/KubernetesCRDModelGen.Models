#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.desktopvirtualization.azure.m.upbound.io;
/// <summary>VirtualDesktopHostPool is the Schema for the VirtualDesktopHostPools API. Manages a Virtual Desktop Host Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualDesktopHostPoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VirtualDesktopHostPool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualDesktopHostPoolList";
    public const string KubeGroup = "desktopvirtualization.azure.m.upbound.io";
    public const string KubePluralName = "virtualdesktophostpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "desktopvirtualization.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualDesktopHostPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1VirtualDesktopHostPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1VirtualDesktopHostPool> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameSelector
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
    public V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolSpecForProviderScheduledAgentUpdatesSchedule
{
    /// <summary>The day of the week on which agent updates should be performed. Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The hour of day the update window should start. The update is a 2 hour period following the hour provided. The value should be provided as a number between 0 and 23, with 0 being midnight and 23 being 11pm. A leading zero should not be used.</summary>
    [JsonPropertyName("hourOfDay")]
    public double? HourOfDay { get; set; }
}

/// <summary>A scheduled_agent_updates block as defined below. This enables control of when Agent Updates will be applied to Session Hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolSpecForProviderScheduledAgentUpdates
{
    /// <summary>Enables or disables scheduled updates of the AVD agent components (RDAgent, Geneva Monitoring agent, and side-by-side stack) on session hosts. If this is enabled then up to two schedule blocks must be defined. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A schedule block as defined below. A maximum of two blocks can be added.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1VirtualDesktopHostPoolSpecForProviderScheduledAgentUpdatesSchedule>? Schedule { get; set; }

    /// <summary>Specifies the time zone in which the agent update schedule will apply, the possible values are defined here. If use_session_host_timezone is enabled then it will override this setting. Default is UTC</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>Specifies whether scheduled agent updates should be applied based on the timezone of the affected session host. If configured then this setting overrides timezone. Default is false.</summary>
    [JsonPropertyName("useSessionHostTimezone")]
    public bool? UseSessionHostTimezone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolSpecForProvider
{
    /// <summary>A valid custom RDP properties string for the Virtual Desktop Host Pool, available properties can be found in this article.</summary>
    [JsonPropertyName("customRdpProperties")]
    public string? CustomRdpProperties { get; set; }

    /// <summary>A description for the Virtual Desktop Host Pool.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A friendly name for the Virtual Desktop Host Pool.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>
    /// BreadthFirst load balancing distributes new user sessions across all available session hosts in the host pool. Possible values are BreadthFirst, DepthFirst and Persistent.
    /// DepthFirst load balancing distributes new user sessions to an available session host with the highest number of connections but has not reached its maximum session limit threshold.
    /// Persistent should be used if the host pool type is Personal
    /// </summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The location/region where the Virtual Desktop Host Pool is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// A valid integer value from 0 to 999999 for the maximum number of users that have concurrent sessions on a session host.
    /// Should only be set if the type of your Virtual Desktop Host Pool is Pooled.
    /// </summary>
    [JsonPropertyName("maximumSessionsAllowed")]
    public double? MaximumSessionsAllowed { get; set; }

    /// <summary>Automatic assignment – The service will select an available host and assign it to an user. Possible values are Automatic and Direct. Direct Assignment – Admin selects a specific host to assign to an user. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("personalDesktopAssignmentType")]
    public string? PersonalDesktopAssignmentType { get; set; }

    /// <summary>
    /// Option to specify the preferred Application Group type for the Virtual Desktop Host Pool. Valid options are None, Desktop or RailApplications. Default is Desktop.
    /// Preferred App Group type to display
    /// </summary>
    [JsonPropertyName("preferredAppGroupType")]
    public string? PreferredAppGroupType { get; set; }

    /// <summary>Whether public network access is allowed for the Virtual Desktop Host Pool. Possible values are Enabled, Disabled, EnabledForClientsOnly and EnabledForSessionHostsOnly. Defaults to Enabled.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>The name of the resource group in which to create the Virtual Desktop Host Pool. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1VirtualDesktopHostPoolSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A scheduled_agent_updates block as defined below. This enables control of when Agent Updates will be applied to Session Hosts.</summary>
    [JsonPropertyName("scheduledAgentUpdates")]
    public V1beta1VirtualDesktopHostPoolSpecForProviderScheduledAgentUpdates? ScheduledAgentUpdates { get; set; }

    /// <summary>Enables or disables the Start VM on Connection Feature. Defaults to false.</summary>
    [JsonPropertyName("startVmOnConnect")]
    public bool? StartVmOnConnect { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of the Virtual Desktop Host Pool. Valid options are Personal or Pooled. Changing the type forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Allows you to test service changes before they are deployed to production. Defaults to false.</summary>
    [JsonPropertyName("validateEnvironment")]
    public bool? ValidateEnvironment { get; set; }

    /// <summary>A VM template for session hosts configuration within hostpool. This is a JSON string.</summary>
    [JsonPropertyName("vmTemplate")]
    public string? VmTemplate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolSpecInitProviderScheduledAgentUpdatesSchedule
{
    /// <summary>The day of the week on which agent updates should be performed. Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The hour of day the update window should start. The update is a 2 hour period following the hour provided. The value should be provided as a number between 0 and 23, with 0 being midnight and 23 being 11pm. A leading zero should not be used.</summary>
    [JsonPropertyName("hourOfDay")]
    public double? HourOfDay { get; set; }
}

/// <summary>A scheduled_agent_updates block as defined below. This enables control of when Agent Updates will be applied to Session Hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolSpecInitProviderScheduledAgentUpdates
{
    /// <summary>Enables or disables scheduled updates of the AVD agent components (RDAgent, Geneva Monitoring agent, and side-by-side stack) on session hosts. If this is enabled then up to two schedule blocks must be defined. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A schedule block as defined below. A maximum of two blocks can be added.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1VirtualDesktopHostPoolSpecInitProviderScheduledAgentUpdatesSchedule>? Schedule { get; set; }

    /// <summary>Specifies the time zone in which the agent update schedule will apply, the possible values are defined here. If use_session_host_timezone is enabled then it will override this setting. Default is UTC</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>Specifies whether scheduled agent updates should be applied based on the timezone of the affected session host. If configured then this setting overrides timezone. Default is false.</summary>
    [JsonPropertyName("useSessionHostTimezone")]
    public bool? UseSessionHostTimezone { get; set; }
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
public partial class V1beta1VirtualDesktopHostPoolSpecInitProvider
{
    /// <summary>A valid custom RDP properties string for the Virtual Desktop Host Pool, available properties can be found in this article.</summary>
    [JsonPropertyName("customRdpProperties")]
    public string? CustomRdpProperties { get; set; }

    /// <summary>A description for the Virtual Desktop Host Pool.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A friendly name for the Virtual Desktop Host Pool.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>
    /// BreadthFirst load balancing distributes new user sessions across all available session hosts in the host pool. Possible values are BreadthFirst, DepthFirst and Persistent.
    /// DepthFirst load balancing distributes new user sessions to an available session host with the highest number of connections but has not reached its maximum session limit threshold.
    /// Persistent should be used if the host pool type is Personal
    /// </summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The location/region where the Virtual Desktop Host Pool is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// A valid integer value from 0 to 999999 for the maximum number of users that have concurrent sessions on a session host.
    /// Should only be set if the type of your Virtual Desktop Host Pool is Pooled.
    /// </summary>
    [JsonPropertyName("maximumSessionsAllowed")]
    public double? MaximumSessionsAllowed { get; set; }

    /// <summary>Automatic assignment – The service will select an available host and assign it to an user. Possible values are Automatic and Direct. Direct Assignment – Admin selects a specific host to assign to an user. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("personalDesktopAssignmentType")]
    public string? PersonalDesktopAssignmentType { get; set; }

    /// <summary>
    /// Option to specify the preferred Application Group type for the Virtual Desktop Host Pool. Valid options are None, Desktop or RailApplications. Default is Desktop.
    /// Preferred App Group type to display
    /// </summary>
    [JsonPropertyName("preferredAppGroupType")]
    public string? PreferredAppGroupType { get; set; }

    /// <summary>Whether public network access is allowed for the Virtual Desktop Host Pool. Possible values are Enabled, Disabled, EnabledForClientsOnly and EnabledForSessionHostsOnly. Defaults to Enabled.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>A scheduled_agent_updates block as defined below. This enables control of when Agent Updates will be applied to Session Hosts.</summary>
    [JsonPropertyName("scheduledAgentUpdates")]
    public V1beta1VirtualDesktopHostPoolSpecInitProviderScheduledAgentUpdates? ScheduledAgentUpdates { get; set; }

    /// <summary>Enables or disables the Start VM on Connection Feature. Defaults to false.</summary>
    [JsonPropertyName("startVmOnConnect")]
    public bool? StartVmOnConnect { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of the Virtual Desktop Host Pool. Valid options are Personal or Pooled. Changing the type forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Allows you to test service changes before they are deployed to production. Defaults to false.</summary>
    [JsonPropertyName("validateEnvironment")]
    public bool? ValidateEnvironment { get; set; }

    /// <summary>A VM template for session hosts configuration within hostpool. This is a JSON string.</summary>
    [JsonPropertyName("vmTemplate")]
    public string? VmTemplate { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualDesktopHostPoolSpecManagementPoliciesEnum>))]
public enum V1beta1VirtualDesktopHostPoolSpecManagementPoliciesEnum
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
public partial class V1beta1VirtualDesktopHostPoolSpecProviderConfigRef
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
public partial class V1beta1VirtualDesktopHostPoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>VirtualDesktopHostPoolSpec defines the desired state of VirtualDesktopHostPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1VirtualDesktopHostPoolSpecForProvider ForProvider { get; set; }

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
    public V1beta1VirtualDesktopHostPoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VirtualDesktopHostPoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VirtualDesktopHostPoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VirtualDesktopHostPoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolStatusAtProviderScheduledAgentUpdatesSchedule
{
    /// <summary>The day of the week on which agent updates should be performed. Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The hour of day the update window should start. The update is a 2 hour period following the hour provided. The value should be provided as a number between 0 and 23, with 0 being midnight and 23 being 11pm. A leading zero should not be used.</summary>
    [JsonPropertyName("hourOfDay")]
    public double? HourOfDay { get; set; }
}

/// <summary>A scheduled_agent_updates block as defined below. This enables control of when Agent Updates will be applied to Session Hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolStatusAtProviderScheduledAgentUpdates
{
    /// <summary>Enables or disables scheduled updates of the AVD agent components (RDAgent, Geneva Monitoring agent, and side-by-side stack) on session hosts. If this is enabled then up to two schedule blocks must be defined. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A schedule block as defined below. A maximum of two blocks can be added.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1VirtualDesktopHostPoolStatusAtProviderScheduledAgentUpdatesSchedule>? Schedule { get; set; }

    /// <summary>Specifies the time zone in which the agent update schedule will apply, the possible values are defined here. If use_session_host_timezone is enabled then it will override this setting. Default is UTC</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>Specifies whether scheduled agent updates should be applied based on the timezone of the affected session host. If configured then this setting overrides timezone. Default is false.</summary>
    [JsonPropertyName("useSessionHostTimezone")]
    public bool? UseSessionHostTimezone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolStatusAtProvider
{
    /// <summary>A valid custom RDP properties string for the Virtual Desktop Host Pool, available properties can be found in this article.</summary>
    [JsonPropertyName("customRdpProperties")]
    public string? CustomRdpProperties { get; set; }

    /// <summary>A description for the Virtual Desktop Host Pool.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A friendly name for the Virtual Desktop Host Pool.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>The ID of the Virtual Desktop Host Pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// BreadthFirst load balancing distributes new user sessions across all available session hosts in the host pool. Possible values are BreadthFirst, DepthFirst and Persistent.
    /// DepthFirst load balancing distributes new user sessions to an available session host with the highest number of connections but has not reached its maximum session limit threshold.
    /// Persistent should be used if the host pool type is Personal
    /// </summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The location/region where the Virtual Desktop Host Pool is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// A valid integer value from 0 to 999999 for the maximum number of users that have concurrent sessions on a session host.
    /// Should only be set if the type of your Virtual Desktop Host Pool is Pooled.
    /// </summary>
    [JsonPropertyName("maximumSessionsAllowed")]
    public double? MaximumSessionsAllowed { get; set; }

    /// <summary>Automatic assignment – The service will select an available host and assign it to an user. Possible values are Automatic and Direct. Direct Assignment – Admin selects a specific host to assign to an user. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("personalDesktopAssignmentType")]
    public string? PersonalDesktopAssignmentType { get; set; }

    /// <summary>
    /// Option to specify the preferred Application Group type for the Virtual Desktop Host Pool. Valid options are None, Desktop or RailApplications. Default is Desktop.
    /// Preferred App Group type to display
    /// </summary>
    [JsonPropertyName("preferredAppGroupType")]
    public string? PreferredAppGroupType { get; set; }

    /// <summary>Whether public network access is allowed for the Virtual Desktop Host Pool. Possible values are Enabled, Disabled, EnabledForClientsOnly and EnabledForSessionHostsOnly. Defaults to Enabled.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>The name of the resource group in which to create the Virtual Desktop Host Pool. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A scheduled_agent_updates block as defined below. This enables control of when Agent Updates will be applied to Session Hosts.</summary>
    [JsonPropertyName("scheduledAgentUpdates")]
    public V1beta1VirtualDesktopHostPoolStatusAtProviderScheduledAgentUpdates? ScheduledAgentUpdates { get; set; }

    /// <summary>Enables or disables the Start VM on Connection Feature. Defaults to false.</summary>
    [JsonPropertyName("startVmOnConnect")]
    public bool? StartVmOnConnect { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of the Virtual Desktop Host Pool. Valid options are Personal or Pooled. Changing the type forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Allows you to test service changes before they are deployed to production. Defaults to false.</summary>
    [JsonPropertyName("validateEnvironment")]
    public bool? ValidateEnvironment { get; set; }

    /// <summary>A VM template for session hosts configuration within hostpool. This is a JSON string.</summary>
    [JsonPropertyName("vmTemplate")]
    public string? VmTemplate { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolStatusConditions
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

/// <summary>VirtualDesktopHostPoolStatus defines the observed state of VirtualDesktopHostPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualDesktopHostPoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1VirtualDesktopHostPoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VirtualDesktopHostPoolStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VirtualDesktopHostPool is the Schema for the VirtualDesktopHostPools API. Manages a Virtual Desktop Host Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualDesktopHostPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualDesktopHostPoolSpec>, IStatus<V1beta1VirtualDesktopHostPoolStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualDesktopHostPool";
    public const string KubeGroup = "desktopvirtualization.azure.m.upbound.io";
    public const string KubePluralName = "virtualdesktophostpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "desktopvirtualization.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualDesktopHostPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualDesktopHostPoolSpec defines the desired state of VirtualDesktopHostPool</summary>
    [JsonPropertyName("spec")]
    public required V1beta1VirtualDesktopHostPoolSpec Spec { get; set; }

    /// <summary>VirtualDesktopHostPoolStatus defines the observed state of VirtualDesktopHostPool.</summary>
    [JsonPropertyName("status")]
    public V1beta1VirtualDesktopHostPoolStatus? Status { get; set; }
}