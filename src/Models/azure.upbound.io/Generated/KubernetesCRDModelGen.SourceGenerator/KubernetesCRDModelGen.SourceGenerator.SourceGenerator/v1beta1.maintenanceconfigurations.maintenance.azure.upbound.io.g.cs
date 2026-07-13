#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.maintenance.azure.upbound.io;
/// <summary>
/// MaintenanceConfiguration is the Schema for the MaintenanceConfigurations API. Manages a Maintenance Configuration.
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MaintenanceConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MaintenanceConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MaintenanceConfigurationList";
    public const string KubeGroup = "maintenance.azure.upbound.io";
    public const string KubePluralName = "maintenanceconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "maintenance.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MaintenanceConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1MaintenanceConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1MaintenanceConfiguration> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MaintenanceConfigurationSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MaintenanceConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecForProviderInstallPatchesLinux
{
    /// <summary>List of Classification category of patches to be patched. Possible values are Critical, Security, UpdateRollup, FeaturePack, ServicePack, Definition, Tools and Updates.</summary>
    [JsonPropertyName("classificationsToInclude")]
    public IList<string>? ClassificationsToInclude { get; set; }

    /// <summary>List of package names to be excluded from patching.</summary>
    [JsonPropertyName("packageNamesMaskToExclude")]
    public IList<string>? PackageNamesMaskToExclude { get; set; }

    /// <summary>List of package names to be included for patching.</summary>
    [JsonPropertyName("packageNamesMaskToInclude")]
    public IList<string>? PackageNamesMaskToInclude { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecForProviderInstallPatchesWindows
{
    /// <summary>List of Classification category of patches to be patched. Possible values are Critical, Security, UpdateRollup, FeaturePack, ServicePack, Definition, Tools and Updates.</summary>
    [JsonPropertyName("classificationsToInclude")]
    public IList<string>? ClassificationsToInclude { get; set; }

    /// <summary>List of KB numbers to be excluded from patching.</summary>
    [JsonPropertyName("kbNumbersToExclude")]
    public IList<string>? KbNumbersToExclude { get; set; }

    /// <summary>List of KB numbers to be included for patching.</summary>
    [JsonPropertyName("kbNumbersToInclude")]
    public IList<string>? KbNumbersToInclude { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecForProviderInstallPatches
{
    /// <summary>A linux block as defined above. This property only applies when scope is set to InGuestPatch</summary>
    [JsonPropertyName("linux")]
    public IList<V1beta1MaintenanceConfigurationSpecForProviderInstallPatchesLinux>? Linux { get; set; }

    /// <summary>Possible reboot preference as defined by the user based on which it would be decided to reboot the machine or not after the patch operation is completed. Possible values are Always, IfRequired and Never. This property only applies when scope is set to InGuestPatch.</summary>
    [JsonPropertyName("reboot")]
    public string? Reboot { get; set; }

    /// <summary>A windows block as defined above. This property only applies when scope is set to InGuestPatch</summary>
    [JsonPropertyName("windows")]
    public IList<V1beta1MaintenanceConfigurationSpecForProviderInstallPatchesWindows>? Windows { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameSelector
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
    public V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecForProviderWindow
{
    /// <summary>The duration of the maintenance window in HH:mm format.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Effective expiration date of the maintenance window in YYYY-MM-DD hh:mm format.</summary>
    [JsonPropertyName("expirationDateTime")]
    public string? ExpirationDateTime { get; set; }

    /// <summary>The rate at which a maintenance window is expected to recur. The rate can be expressed as daily, weekly, or monthly schedules.</summary>
    [JsonPropertyName("recurEvery")]
    public string? RecurEvery { get; set; }

    /// <summary>Effective start date of the maintenance window in YYYY-MM-DD hh:mm format.</summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }

    /// <summary>The time zone for the maintenance window. A list of timezones can be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecForProvider
{
    /// <summary>The in guest user patch mode. Possible values are Platform or User. Must be specified when scope is InGuestPatch.</summary>
    [JsonPropertyName("inGuestUserPatchMode")]
    public string? InGuestUserPatchMode { get; set; }

    /// <summary>An install_patches block as defined below.</summary>
    [JsonPropertyName("installPatches")]
    public IList<V1beta1MaintenanceConfigurationSpecForProviderInstallPatches>? InstallPatches { get; set; }

    /// <summary>Specified the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A mapping of properties to assign to the resource.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The name of the Resource Group where the Maintenance Configuration should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MaintenanceConfigurationSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The scope of the Maintenance Configuration. Possible values are Extension, Host, InGuestPatch, OSImage, SQLDB or SQLManagedInstance.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>A mapping of tags to assign to the resource. The key could not contain upper case letter.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The visibility of the Maintenance Configuration. The only allowable value is Custom. Defaults to Custom.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>A window block as defined below.</summary>
    [JsonPropertyName("window")]
    public IList<V1beta1MaintenanceConfigurationSpecForProviderWindow>? Window { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecInitProviderInstallPatchesLinux
{
    /// <summary>List of Classification category of patches to be patched. Possible values are Critical, Security, UpdateRollup, FeaturePack, ServicePack, Definition, Tools and Updates.</summary>
    [JsonPropertyName("classificationsToInclude")]
    public IList<string>? ClassificationsToInclude { get; set; }

    /// <summary>List of package names to be excluded from patching.</summary>
    [JsonPropertyName("packageNamesMaskToExclude")]
    public IList<string>? PackageNamesMaskToExclude { get; set; }

    /// <summary>List of package names to be included for patching.</summary>
    [JsonPropertyName("packageNamesMaskToInclude")]
    public IList<string>? PackageNamesMaskToInclude { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecInitProviderInstallPatchesWindows
{
    /// <summary>List of Classification category of patches to be patched. Possible values are Critical, Security, UpdateRollup, FeaturePack, ServicePack, Definition, Tools and Updates.</summary>
    [JsonPropertyName("classificationsToInclude")]
    public IList<string>? ClassificationsToInclude { get; set; }

    /// <summary>List of KB numbers to be excluded from patching.</summary>
    [JsonPropertyName("kbNumbersToExclude")]
    public IList<string>? KbNumbersToExclude { get; set; }

    /// <summary>List of KB numbers to be included for patching.</summary>
    [JsonPropertyName("kbNumbersToInclude")]
    public IList<string>? KbNumbersToInclude { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecInitProviderInstallPatches
{
    /// <summary>A linux block as defined above. This property only applies when scope is set to InGuestPatch</summary>
    [JsonPropertyName("linux")]
    public IList<V1beta1MaintenanceConfigurationSpecInitProviderInstallPatchesLinux>? Linux { get; set; }

    /// <summary>Possible reboot preference as defined by the user based on which it would be decided to reboot the machine or not after the patch operation is completed. Possible values are Always, IfRequired and Never. This property only applies when scope is set to InGuestPatch.</summary>
    [JsonPropertyName("reboot")]
    public string? Reboot { get; set; }

    /// <summary>A windows block as defined above. This property only applies when scope is set to InGuestPatch</summary>
    [JsonPropertyName("windows")]
    public IList<V1beta1MaintenanceConfigurationSpecInitProviderInstallPatchesWindows>? Windows { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecInitProviderWindow
{
    /// <summary>The duration of the maintenance window in HH:mm format.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Effective expiration date of the maintenance window in YYYY-MM-DD hh:mm format.</summary>
    [JsonPropertyName("expirationDateTime")]
    public string? ExpirationDateTime { get; set; }

    /// <summary>The rate at which a maintenance window is expected to recur. The rate can be expressed as daily, weekly, or monthly schedules.</summary>
    [JsonPropertyName("recurEvery")]
    public string? RecurEvery { get; set; }

    /// <summary>Effective start date of the maintenance window in YYYY-MM-DD hh:mm format.</summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }

    /// <summary>The time zone for the maintenance window. A list of timezones can be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecInitProvider
{
    /// <summary>The in guest user patch mode. Possible values are Platform or User. Must be specified when scope is InGuestPatch.</summary>
    [JsonPropertyName("inGuestUserPatchMode")]
    public string? InGuestUserPatchMode { get; set; }

    /// <summary>An install_patches block as defined below.</summary>
    [JsonPropertyName("installPatches")]
    public IList<V1beta1MaintenanceConfigurationSpecInitProviderInstallPatches>? InstallPatches { get; set; }

    /// <summary>Specified the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A mapping of properties to assign to the resource.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The scope of the Maintenance Configuration. Possible values are Extension, Host, InGuestPatch, OSImage, SQLDB or SQLManagedInstance.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>A mapping of tags to assign to the resource. The key could not contain upper case letter.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The visibility of the Maintenance Configuration. The only allowable value is Custom. Defaults to Custom.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>A window block as defined below.</summary>
    [JsonPropertyName("window")]
    public IList<V1beta1MaintenanceConfigurationSpecInitProviderWindow>? Window { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MaintenanceConfigurationSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MaintenanceConfigurationSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MaintenanceConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MaintenanceConfigurationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MaintenanceConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MaintenanceConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MaintenanceConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MaintenanceConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MaintenanceConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MaintenanceConfigurationSpec defines the desired state of MaintenanceConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationSpec
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
    public V1beta1MaintenanceConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1MaintenanceConfigurationSpecForProvider ForProvider { get; set; }

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
    public V1beta1MaintenanceConfigurationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1MaintenanceConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MaintenanceConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MaintenanceConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationStatusAtProviderInstallPatchesLinux
{
    /// <summary>List of Classification category of patches to be patched. Possible values are Critical, Security, UpdateRollup, FeaturePack, ServicePack, Definition, Tools and Updates.</summary>
    [JsonPropertyName("classificationsToInclude")]
    public IList<string>? ClassificationsToInclude { get; set; }

    /// <summary>List of package names to be excluded from patching.</summary>
    [JsonPropertyName("packageNamesMaskToExclude")]
    public IList<string>? PackageNamesMaskToExclude { get; set; }

    /// <summary>List of package names to be included for patching.</summary>
    [JsonPropertyName("packageNamesMaskToInclude")]
    public IList<string>? PackageNamesMaskToInclude { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationStatusAtProviderInstallPatchesWindows
{
    /// <summary>List of Classification category of patches to be patched. Possible values are Critical, Security, UpdateRollup, FeaturePack, ServicePack, Definition, Tools and Updates.</summary>
    [JsonPropertyName("classificationsToInclude")]
    public IList<string>? ClassificationsToInclude { get; set; }

    /// <summary>List of KB numbers to be excluded from patching.</summary>
    [JsonPropertyName("kbNumbersToExclude")]
    public IList<string>? KbNumbersToExclude { get; set; }

    /// <summary>List of KB numbers to be included for patching.</summary>
    [JsonPropertyName("kbNumbersToInclude")]
    public IList<string>? KbNumbersToInclude { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationStatusAtProviderInstallPatches
{
    /// <summary>A linux block as defined above. This property only applies when scope is set to InGuestPatch</summary>
    [JsonPropertyName("linux")]
    public IList<V1beta1MaintenanceConfigurationStatusAtProviderInstallPatchesLinux>? Linux { get; set; }

    /// <summary>Possible reboot preference as defined by the user based on which it would be decided to reboot the machine or not after the patch operation is completed. Possible values are Always, IfRequired and Never. This property only applies when scope is set to InGuestPatch.</summary>
    [JsonPropertyName("reboot")]
    public string? Reboot { get; set; }

    /// <summary>A windows block as defined above. This property only applies when scope is set to InGuestPatch</summary>
    [JsonPropertyName("windows")]
    public IList<V1beta1MaintenanceConfigurationStatusAtProviderInstallPatchesWindows>? Windows { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationStatusAtProviderWindow
{
    /// <summary>The duration of the maintenance window in HH:mm format.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Effective expiration date of the maintenance window in YYYY-MM-DD hh:mm format.</summary>
    [JsonPropertyName("expirationDateTime")]
    public string? ExpirationDateTime { get; set; }

    /// <summary>The rate at which a maintenance window is expected to recur. The rate can be expressed as daily, weekly, or monthly schedules.</summary>
    [JsonPropertyName("recurEvery")]
    public string? RecurEvery { get; set; }

    /// <summary>Effective start date of the maintenance window in YYYY-MM-DD hh:mm format.</summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }

    /// <summary>The time zone for the maintenance window. A list of timezones can be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationStatusAtProvider
{
    /// <summary>The ID of the Maintenance Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The in guest user patch mode. Possible values are Platform or User. Must be specified when scope is InGuestPatch.</summary>
    [JsonPropertyName("inGuestUserPatchMode")]
    public string? InGuestUserPatchMode { get; set; }

    /// <summary>An install_patches block as defined below.</summary>
    [JsonPropertyName("installPatches")]
    public IList<V1beta1MaintenanceConfigurationStatusAtProviderInstallPatches>? InstallPatches { get; set; }

    /// <summary>Specified the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A mapping of properties to assign to the resource.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The name of the Resource Group where the Maintenance Configuration should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The scope of the Maintenance Configuration. Possible values are Extension, Host, InGuestPatch, OSImage, SQLDB or SQLManagedInstance.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>A mapping of tags to assign to the resource. The key could not contain upper case letter.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The visibility of the Maintenance Configuration. The only allowable value is Custom. Defaults to Custom.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>A window block as defined below.</summary>
    [JsonPropertyName("window")]
    public IList<V1beta1MaintenanceConfigurationStatusAtProviderWindow>? Window { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationStatusConditions
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

/// <summary>MaintenanceConfigurationStatus defines the observed state of MaintenanceConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MaintenanceConfigurationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1MaintenanceConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MaintenanceConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// MaintenanceConfiguration is the Schema for the MaintenanceConfigurations API. Manages a Maintenance Configuration.
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MaintenanceConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MaintenanceConfigurationSpec>, IStatus<V1beta1MaintenanceConfigurationStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MaintenanceConfiguration";
    public const string KubeGroup = "maintenance.azure.upbound.io";
    public const string KubePluralName = "maintenanceconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "maintenance.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MaintenanceConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MaintenanceConfigurationSpec defines the desired state of MaintenanceConfiguration</summary>
    [JsonPropertyName("spec")]
    public required V1beta1MaintenanceConfigurationSpec Spec { get; set; }

    /// <summary>MaintenanceConfigurationStatus defines the observed state of MaintenanceConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1MaintenanceConfigurationStatus? Status { get; set; }
}