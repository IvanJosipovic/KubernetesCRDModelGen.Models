#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.upbound.io;
/// <summary>WindowsVirtualMachineScaleSet is the Schema for the WindowsVirtualMachineScaleSets API. Manages a Windows Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2WindowsVirtualMachineScaleSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta2WindowsVirtualMachineScaleSet>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "WindowsVirtualMachineScaleSetList";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "windowsvirtualmachinescalesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WindowsVirtualMachineScaleSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2WindowsVirtualMachineScaleSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2WindowsVirtualMachineScaleSet> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecDeletionPolicyEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>An additional_capabilities block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderAdditionalCapabilities
{
    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine Scale Set? Possible values are true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary>The XML formatted content that is added to the unattend.xml file for the specified path and component. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderAdditionalUnattendContentContentSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderAdditionalUnattendContent
{
    /// <summary>The XML formatted content that is added to the unattend.xml file for the specified path and component. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("contentSecretRef")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderAdditionalUnattendContentContentSecretRef? ContentSecretRef { get; set; }

    /// <summary>The name of the setting to which the content applies. Possible values are AutoLogon and FirstLogonCommands. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("setting")]
    public string? Setting { get; set; }
}

/// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderAdminPasswordSecretRef
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

/// <summary>An automatic_instance_repair block as defined below. To enable the automatic instance repair, this Virtual Machine Scale Set must have a valid health_probe_id or an Application Health Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderAutomaticInstanceRepair
{
    /// <summary>The repair action that will be used for repairing unhealthy virtual machines in the scale set. Possible values include Replace, Restart, Reimage.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Should the automatic instance repair be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amount of time for which automatic repairs will be delayed. The grace period starts right after the VM is found unhealthy. Possible values are between 10 and 90 minutes. The time duration should be specified in ISO 8601 format (e.g. PT10M to PT90M).</summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary>An automatic_os_upgrade_policy block as defined below. This can only be specified when upgrade_mode is set to either Automatic or Rolling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderAutomaticOsUpgradePolicy
{
    /// <summary>Should automatic rollbacks be disabled?</summary>
    [JsonPropertyName("disableAutomaticRollback")]
    public bool? DisableAutomaticRollback { get; set; }

    /// <summary>Should OS Upgrades automatically be applied to Scale Set instances in a rolling fashion when a newer version of the OS Image becomes available?</summary>
    [JsonPropertyName("enableAutomaticOsUpgrade")]
    public bool? EnableAutomaticOsUpgrade { get; set; }
}

/// <summary>A boot_diagnostics block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

/// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderCustomDataSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderDataDisk
{
    /// <summary>The type of Caching which should be used for this Data Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The create option which should be used for this Data Disk. Possible values are Empty and FromImage. Defaults to Empty. (FromImage should only be used if the source image includes data disks).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The size of the Data Disk which should be created.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which must be unique within the Virtual Machine.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The name of the Data Disk.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Type of Storage Account which should back this Data Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS and UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies the Read-Write IOPS for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskIopsReadWrite")]
    public double? UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>Specifies the bandwidth in MB per second for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskMbpsReadWrite")]
    public double? UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>A protected_settings_from_key_vault block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsFromKeyVault
{
    /// <summary>The URL to the Key Vault Secret which stores the protected settings.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A JSON String which specifies Sensitive Settings (such as Passwords) for the Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderExtension
{
    /// <summary>Should the latest version of the Extension be used at Deployment Time, if one is available? This won&apos;t auto-update the extension on existing installation. Defaults to true.</summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>Should the Extension be automatically updated whenever the Publisher releases a new version of this VM Extension?</summary>
    [JsonPropertyName("automaticUpgradeEnabled")]
    public bool? AutomaticUpgradeEnabled { get; set; }

    /// <summary>A value which, when different to the previous value can be used to force-run the Extension even if the Extension Configuration hasn&apos;t changed.</summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>The name for the Virtual Machine Scale Set Extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsFromKeyVault? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>A JSON String which specifies Sensitive Settings (such as Passwords) for the Extension.</summary>
    [JsonPropertyName("protectedSettingsSecretRef")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsSecretRef? ProtectedSettingsSecretRef { get; set; }

    /// <summary>An ordered list of Extension names which this should be provisioned after.</summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>Specifies the Publisher of the Extension.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>A JSON String which specifies Settings for the Extension.</summary>
    [JsonPropertyName("settings")]
    public string? Settings { get; set; }

    /// <summary>Specifies the Type of the Extension.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the version of the extension to use, available versions can be found using the Azure CLI.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderGalleryApplication
{
    /// <summary>Specifies the URI to an Azure Blob that will replace the default configuration for the package if provided. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("configurationBlobUri")]
    public string? ConfigurationBlobUri { get; set; }

    /// <summary>Specifies the order in which the packages have to be installed. Possible values are between 0 and 2147483647. Defaults to 0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Specifies a passthrough value for more generic context. This field can be any valid string value. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Specifies the Gallery Application Version resource ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Windows Virtual Machine Scale Set.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Windows Virtual Machine Scale Set. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag
{
    /// <summary>The IP Tag associated with the Public IP, such as SQL or Storage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The Type of IP Tag, such as FirstPartyUsage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddress
{
    /// <summary>The Prefix which should be used for the Domain Name Label for each Virtual Machine Instance. Azure concatenates the Domain Name Label and Virtual Machine Index to create a unique Domain Name Label for each Virtual Machine.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>The Idle Timeout in Minutes for the Public IP Address. Possible values are in the range 4 to 32.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>One or more ip_tag blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTag")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag>? IpTag { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Public IP Address Prefix from where Public IP Addresses should be allocated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelector
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
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfiguration
{
    /// <summary>A list of Backend Address Pools ID&apos;s from a Application Gateway which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPoolIds")]
    public IList<string>? ApplicationGatewayBackendAddressPoolIds { get; set; }

    /// <summary>A list of Application Security Group ID&apos;s which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>A list of Backend Address Pools ID&apos;s from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolIds")]
    public IList<string>? LoadBalancerBackendAddressPoolIds { get; set; }

    /// <summary>A list of NAT Rule ID&apos;s from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerInboundNatRulesIds")]
    public IList<string>? LoadBalancerInboundNatRulesIds { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>A public_ip_address block as defined below.</summary>
    [JsonPropertyName("publicIpAddress")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddress>? PublicIpAddress { get; set; }

    /// <summary>The ID of the Subnet which this IP Configuration should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterface
{
    /// <summary>Specifies the auxiliary mode used to enable network high-performance feature on Network Virtual Appliances (NVAs). This feature offers competitive performance in Connections Per Second (CPS) optimization, along with improvements to handling large amounts of simultaneous connections. Possible values are AcceleratedConnections and Floating.</summary>
    [JsonPropertyName("auxiliaryMode")]
    public string? AuxiliaryMode { get; set; }

    /// <summary>Specifies the SKU used for the network high-performance feature on Network Virtual Appliances (NVAs). Possible values are A1, A2, A4 and A8.</summary>
    [JsonPropertyName("auxiliarySku")]
    public string? AuxiliarySku { get; set; }

    /// <summary>A list of IP Addresses of DNS Servers which should be assigned to the Network Interface.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>Does this Network Interface support Accelerated Networking? Defaults to false.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>Does this Network Interface support IP Forwarding? Defaults to false.</summary>
    [JsonPropertyName("enableIpForwarding")]
    public bool? EnableIpForwarding { get; set; }

    /// <summary>One or more ip_configuration blocks as defined above.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Name which should be used for this Network Interface. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Network Security Group which should be assigned to this Network Interface.</summary>
    [JsonPropertyName("networkSecurityGroupId")]
    public string? NetworkSecurityGroupId { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderOsDiskDiffDiskSettings
{
    /// <summary>Specifies the Ephemeral Disk Settings for the OS Disk. At this time the only possible value is Local. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("option")]
    public string? Option { get; set; }

    /// <summary>Specifies where to store the Ephemeral Disk. Possible values are CacheDisk and ResourceDisk. Defaults to CacheDisk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary>An os_disk block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine Scale Set is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt the OS Disk when the Virtual Machine Scale Set is Confidential VMSS. Conflicts with disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureVmDiskEncryptionSetId")]
    public string? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>Encryption Type when the Virtual Machine Scale Set is Confidential VMSS. Possible values are VMGuestStateOnly and DiskWithVMGuestState. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderPlan
{
    /// <summary>Specifies the name of the image from the marketplace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the product of the image from the marketplace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the publisher of the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameSelector
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
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A rolling_upgrade_policy block as defined below. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderRollingUpgradePolicy
{
    /// <summary>Should the Virtual Machine Scale Set ignore the Azure Zone boundaries when constructing upgrade batches? Possible values are true or false.</summary>
    [JsonPropertyName("crossZoneUpgradesEnabled")]
    public bool? CrossZoneUpgradesEnabled { get; set; }

    /// <summary>The maximum percent of total virtual machine instances that will be upgraded simultaneously by the rolling upgrade in one batch. As this is a maximum, unhealthy instances in previous or future batches can cause the percentage of instances in a batch to decrease to ensure higher reliability.</summary>
    [JsonPropertyName("maxBatchInstancePercent")]
    public double? MaxBatchInstancePercent { get; set; }

    /// <summary>The maximum percentage of the total virtual machine instances in the scale set that can be simultaneously unhealthy, either as a result of being upgraded, or by being found in an unhealthy state by the virtual machine health checks before the rolling upgrade aborts. This constraint will be checked prior to starting any batch.</summary>
    [JsonPropertyName("maxUnhealthyInstancePercent")]
    public double? MaxUnhealthyInstancePercent { get; set; }

    /// <summary>The maximum percentage of upgraded virtual machine instances that can be found to be in an unhealthy state. This check will happen after each batch is upgraded. If this percentage is ever exceeded, the rolling update aborts.</summary>
    [JsonPropertyName("maxUnhealthyUpgradedInstancePercent")]
    public double? MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>Create new virtual machines to upgrade the scale set, rather than updating the existing virtual machines. Existing virtual machines will be deleted once the new virtual machines are created for each batch. Possible values are true or false.</summary>
    [JsonPropertyName("maximumSurgeInstancesEnabled")]
    public bool? MaximumSurgeInstancesEnabled { get; set; }

    /// <summary>The wait time between completing the update for all virtual machines in one batch and starting the next batch. The time duration should be specified in ISO 8601 format.</summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary>Upgrade all unhealthy instances in a scale set before any healthy instances. Possible values are true or false.</summary>
    [JsonPropertyName("prioritizeUnhealthyInstancesEnabled")]
    public bool? PrioritizeUnhealthyInstancesEnabled { get; set; }
}

/// <summary>A scale_in block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderScaleIn
{
    /// <summary>Should the virtual machines chosen for removal be force deleted when the virtual machine scale set is being scaled-in? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("forceDeletionEnabled")]
    public bool? ForceDeletionEnabled { get; set; }

    /// <summary>The scale-in policy rule that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled in. Possible values for the scale-in policy rules are Default, NewestVM and OldestVM, defaults to Default. For more information about scale in policy, please refer to this doc.</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderSecretCertificate
{
    /// <summary>The certificate store on the Virtual Machine where the certificate should be added.</summary>
    [JsonPropertyName("store")]
    public string? Store { get; set; }

    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderSecret
{
    /// <summary>One or more certificate blocks as defined above.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecForProviderSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary>A source_image_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderSourceImageReference
{
    /// <summary>Specifies the offer of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Specifies the publisher of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Specifies the SKU of the image used to create the virtual machines.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A spot_restore block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderSpotRestore
{
    /// <summary>Should the Spot-Try-Restore feature be enabled? The Spot-Try-Restore feature will attempt to automatically restore the evicted Spot Virtual Machine Scale Set VM instances opportunistically based on capacity availability and pricing constraints. Possible values are true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The length of time that the Virtual Machine Scale Set should attempt to restore the Spot VM instances which have been evicted. The time duration should be between 15 minutes and 120 minutes (inclusive). The time duration should be specified in the ISO 8601 format. Defaults to PT1H. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>A termination_notification block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProviderWinrmListener
{
    /// <summary>The Secret URL of a Key Vault Certificate, which must be specified when protocol is set to Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary>The Protocol of the WinRM Listener. Possible values are Http and Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecForProvider
{
    /// <summary>An additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>One or more additional_unattend_content blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecForProviderAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderAdminPasswordSecretRef? AdminPasswordSecretRef { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>An automatic_instance_repair block as defined below. To enable the automatic instance repair, this Virtual Machine Scale Set must have a valid health_probe_id or an Application Health Extension.</summary>
    [JsonPropertyName("automaticInstanceRepair")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderAutomaticInstanceRepair? AutomaticInstanceRepair { get; set; }

    /// <summary>An automatic_os_upgrade_policy block as defined below. This can only be specified when upgrade_mode is set to either Automatic or Rolling.</summary>
    [JsonPropertyName("automaticOsUpgradePolicy")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderAutomaticOsUpgradePolicy? AutomaticOsUpgradePolicy { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderBootDiagnostics? BootDiagnostics { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine Scale Set should be allocated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("customDataSecretRef")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderCustomDataSecretRef? CustomDataSecretRef { get; set; }

    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecForProviderDataDisk>? DataDisk { get; set; }

    /// <summary>Should Virtual Machine Extensions be run on Overprovisioned Virtual Machines in the Scale Set? Defaults to false.</summary>
    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedMachines")]
    public bool? DoNotRunExtensionsOnOverprovisionedMachines { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Windows Virtual Machine Scale Set should exist. Changing this forces a new Windows Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Are automatic updates enabled for this Virtual Machine? Defaults to true.</summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Should all of the disks (including the temp disk) attached to this Virtual Machine be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>Specifies the eviction policy for Virtual Machines in this Scale Set. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>One or more extension blocks as defined below</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecForProviderExtension>? Extension { get; set; }

    /// <summary>Should extension operations be allowed on the Virtual Machine Scale Set? Possible values are true or false. Defaults to true. Changing this forces a new Windows Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("extensionOperationsEnabled")]
    public bool? ExtensionOperationsEnabled { get; set; }

    /// <summary>Specifies the duration allocated for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>One or more gallery_application blocks as defined below.</summary>
    [JsonPropertyName("galleryApplication")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecForProviderGalleryApplication>? GalleryApplication { get; set; }

    /// <summary>The ID of a Load Balancer Probe which should be used to determine the health of an instance. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling.</summary>
    [JsonPropertyName("healthProbeId")]
    public string? HealthProbeId { get; set; }

    /// <summary>Specifies the ID of the dedicated host group that the virtual machine scale set resides in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The number of Virtual Machines in the Scale Set.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }

    /// <summary>Specifies the type of on-premise license (also known as Azure Hybrid Use Benefit) which should be used for this Virtual Machine Scale Set. Possible values are None, Windows_Client and Windows_Server.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>The Azure location where the Windows Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you&apos;re willing to pay for each Virtual Machine in this Scale Set, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machines in the Scale Set will be evicted using the eviction_policy. Defaults to -1, which means that each Virtual Machine in the Scale Set should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>One or more network_interface blocks as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecForProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>An os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderOsDisk? OsDisk { get; set; }

    /// <summary>Should Azure over-provision Virtual Machines in this Scale Set? This means that multiple Virtual Machines will be provisioned and Azure will keep the instances which become available first - which improves provisioning success rates and improves deployment time. You&apos;re not billed for these over-provisioned VM&apos;s and they don&apos;t count towards the Subscription Quota. Defaults to true.</summary>
    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderPlan? Plan { get; set; }

    /// <summary>Specifies the number of fault domains that are used by this Linux Virtual Machine Scale Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public double? PlatformFaultDomainCount { get; set; }

    /// <summary>The Priority of this Virtual Machine Scale Set. Possible values are Regular and Spot. Defaults to Regular. Changing this value forces a new resource.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>The ID of the Proximity Placement Group in which the Virtual Machine Scale Set should be assigned to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Should resilient VM creation be enabled? When enabled, the service will attempt to create VMs in alternative fault domains or zones if the primary location fails during creation. Defaults to false.</summary>
    [JsonPropertyName("resilientVmCreationEnabled")]
    public bool? ResilientVmCreationEnabled { get; set; }

    /// <summary>Should resilient VM deletion be enabled? When enabled, the service will use a more resilient deletion process that attempts to gracefully handle failures during VM termination. Defaults to false.</summary>
    [JsonPropertyName("resilientVmDeletionEnabled")]
    public bool? ResilientVmDeletionEnabled { get; set; }

    /// <summary>The name of the Resource Group in which the Windows Virtual Machine Scale Set should be exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A rolling_upgrade_policy block as defined below. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderRollingUpgradePolicy? RollingUpgradePolicy { get; set; }

    /// <summary>A scale_in block as defined below.</summary>
    [JsonPropertyName("scaleIn")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderScaleIn? ScaleIn { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecForProviderSecret>? Secret { get; set; }

    /// <summary>Specifies if Secure Boot and Trusted Launch is enabled for the Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary>Should this Virtual Machine Scale Set be limited to a Single Placement Group, which means the number of instances will be capped at 100 Virtual Machines. Defaults to true.</summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>The Virtual Machine SKU for the Scale Set, such as Standard_F2.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The ID of an Image which each Virtual Machine in this Scale Set should be based on. Possible Image ID types include Image ID, Shared Image ID, Shared Image Version ID, Community Gallery Image ID, Community Gallery Image Version ID, Shared Gallery Image ID and Shared Gallery Image Version ID.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below.</summary>
    [JsonPropertyName("sourceImageReference")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderSourceImageReference? SourceImageReference { get; set; }

    /// <summary>A spot_restore block as defined below.</summary>
    [JsonPropertyName("spotRestore")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderSpotRestore? SpotRestore { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public V1beta2WindowsVirtualMachineScaleSetSpecForProviderTerminationNotification? TerminationNotification { get; set; }

    /// <summary>Specifies the time zone of the virtual machine, the possible values are defined here.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>Specifies how Upgrades (e.g. changing the Image/SKU) should be performed to Virtual Machine Instances. Possible values are Automatic, Manual and Rolling. Defaults to Manual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Specifies if vTPM (Virtual Trusted Platform Module) and Trusted Launch is enabled for the Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vtpmEnabled")]
    public bool? VtpmEnabled { get; set; }

    /// <summary>One or more winrm_listener blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("winrmListener")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecForProviderWinrmListener>? WinrmListener { get; set; }

    /// <summary>Should the Virtual Machines in this Scale Set be strictly evenly distributed across Availability Zones? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Windows Virtual Machine Scale Set should be located.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>An additional_capabilities block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderAdditionalCapabilities
{
    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine Scale Set? Possible values are true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary>The XML formatted content that is added to the unattend.xml file for the specified path and component. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderAdditionalUnattendContentContentSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderAdditionalUnattendContent
{
    /// <summary>The XML formatted content that is added to the unattend.xml file for the specified path and component. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("contentSecretRef")]
    public required V1beta2WindowsVirtualMachineScaleSetSpecInitProviderAdditionalUnattendContentContentSecretRef ContentSecretRef { get; set; }

    /// <summary>The name of the setting to which the content applies. Possible values are AutoLogon and FirstLogonCommands. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("setting")]
    public string? Setting { get; set; }
}

/// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderAdminPasswordSecretRef
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

/// <summary>An automatic_instance_repair block as defined below. To enable the automatic instance repair, this Virtual Machine Scale Set must have a valid health_probe_id or an Application Health Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderAutomaticInstanceRepair
{
    /// <summary>The repair action that will be used for repairing unhealthy virtual machines in the scale set. Possible values include Replace, Restart, Reimage.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Should the automatic instance repair be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amount of time for which automatic repairs will be delayed. The grace period starts right after the VM is found unhealthy. Possible values are between 10 and 90 minutes. The time duration should be specified in ISO 8601 format (e.g. PT10M to PT90M).</summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary>An automatic_os_upgrade_policy block as defined below. This can only be specified when upgrade_mode is set to either Automatic or Rolling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderAutomaticOsUpgradePolicy
{
    /// <summary>Should automatic rollbacks be disabled?</summary>
    [JsonPropertyName("disableAutomaticRollback")]
    public bool? DisableAutomaticRollback { get; set; }

    /// <summary>Should OS Upgrades automatically be applied to Scale Set instances in a rolling fashion when a newer version of the OS Image becomes available?</summary>
    [JsonPropertyName("enableAutomaticOsUpgrade")]
    public bool? EnableAutomaticOsUpgrade { get; set; }
}

/// <summary>A boot_diagnostics block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

/// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderCustomDataSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderDataDisk
{
    /// <summary>The type of Caching which should be used for this Data Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The create option which should be used for this Data Disk. Possible values are Empty and FromImage. Defaults to Empty. (FromImage should only be used if the source image includes data disks).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The size of the Data Disk which should be created.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which must be unique within the Virtual Machine.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The name of the Data Disk.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Type of Storage Account which should back this Data Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS and UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies the Read-Write IOPS for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskIopsReadWrite")]
    public double? UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>Specifies the bandwidth in MB per second for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskMbpsReadWrite")]
    public double? UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>A protected_settings_from_key_vault block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderExtensionProtectedSettingsFromKeyVault
{
    /// <summary>The URL to the Key Vault Secret which stores the protected settings.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A JSON String which specifies Sensitive Settings (such as Passwords) for the Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderExtensionProtectedSettingsSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderExtension
{
    /// <summary>Should the latest version of the Extension be used at Deployment Time, if one is available? This won&apos;t auto-update the extension on existing installation. Defaults to true.</summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>Should the Extension be automatically updated whenever the Publisher releases a new version of this VM Extension?</summary>
    [JsonPropertyName("automaticUpgradeEnabled")]
    public bool? AutomaticUpgradeEnabled { get; set; }

    /// <summary>A value which, when different to the previous value can be used to force-run the Extension even if the Extension Configuration hasn&apos;t changed.</summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>The name for the Virtual Machine Scale Set Extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderExtensionProtectedSettingsFromKeyVault? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>A JSON String which specifies Sensitive Settings (such as Passwords) for the Extension.</summary>
    [JsonPropertyName("protectedSettingsSecretRef")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderExtensionProtectedSettingsSecretRef? ProtectedSettingsSecretRef { get; set; }

    /// <summary>An ordered list of Extension names which this should be provisioned after.</summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>Specifies the Publisher of the Extension.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>A JSON String which specifies Settings for the Extension.</summary>
    [JsonPropertyName("settings")]
    public string? Settings { get; set; }

    /// <summary>Specifies the Type of the Extension.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the version of the extension to use, available versions can be found using the Azure CLI.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderGalleryApplication
{
    /// <summary>Specifies the URI to an Azure Blob that will replace the default configuration for the package if provided. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("configurationBlobUri")]
    public string? ConfigurationBlobUri { get; set; }

    /// <summary>Specifies the order in which the packages have to be installed. Possible values are between 0 and 2147483647. Defaults to 0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Specifies a passthrough value for more generic context. This field can be any valid string value. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Specifies the Gallery Application Version resource ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Windows Virtual Machine Scale Set.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Windows Virtual Machine Scale Set. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag
{
    /// <summary>The IP Tag associated with the Public IP, such as SQL or Storage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The Type of IP Tag, such as FirstPartyUsage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddress
{
    /// <summary>The Prefix which should be used for the Domain Name Label for each Virtual Machine Instance. Azure concatenates the Domain Name Label and Virtual Machine Index to create a unique Domain Name Label for each Virtual Machine.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>The Idle Timeout in Minutes for the Public IP Address. Possible values are in the range 4 to 32.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>One or more ip_tag blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTag")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag>? IpTag { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Public IP Address Prefix from where Public IP Addresses should be allocated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelector
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
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfiguration
{
    /// <summary>A list of Backend Address Pools ID&apos;s from a Application Gateway which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPoolIds")]
    public IList<string>? ApplicationGatewayBackendAddressPoolIds { get; set; }

    /// <summary>A list of Application Security Group ID&apos;s which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>A list of Backend Address Pools ID&apos;s from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolIds")]
    public IList<string>? LoadBalancerBackendAddressPoolIds { get; set; }

    /// <summary>A list of NAT Rule ID&apos;s from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerInboundNatRulesIds")]
    public IList<string>? LoadBalancerInboundNatRulesIds { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>A public_ip_address block as defined below.</summary>
    [JsonPropertyName("publicIpAddress")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddress>? PublicIpAddress { get; set; }

    /// <summary>The ID of the Subnet which this IP Configuration should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterface
{
    /// <summary>Specifies the auxiliary mode used to enable network high-performance feature on Network Virtual Appliances (NVAs). This feature offers competitive performance in Connections Per Second (CPS) optimization, along with improvements to handling large amounts of simultaneous connections. Possible values are AcceleratedConnections and Floating.</summary>
    [JsonPropertyName("auxiliaryMode")]
    public string? AuxiliaryMode { get; set; }

    /// <summary>Specifies the SKU used for the network high-performance feature on Network Virtual Appliances (NVAs). Possible values are A1, A2, A4 and A8.</summary>
    [JsonPropertyName("auxiliarySku")]
    public string? AuxiliarySku { get; set; }

    /// <summary>A list of IP Addresses of DNS Servers which should be assigned to the Network Interface.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>Does this Network Interface support Accelerated Networking? Defaults to false.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>Does this Network Interface support IP Forwarding? Defaults to false.</summary>
    [JsonPropertyName("enableIpForwarding")]
    public bool? EnableIpForwarding { get; set; }

    /// <summary>One or more ip_configuration blocks as defined above.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Name which should be used for this Network Interface. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Network Security Group which should be assigned to this Network Interface.</summary>
    [JsonPropertyName("networkSecurityGroupId")]
    public string? NetworkSecurityGroupId { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderOsDiskDiffDiskSettings
{
    /// <summary>Specifies the Ephemeral Disk Settings for the OS Disk. At this time the only possible value is Local. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("option")]
    public string? Option { get; set; }

    /// <summary>Specifies where to store the Ephemeral Disk. Possible values are CacheDisk and ResourceDisk. Defaults to CacheDisk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary>An os_disk block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine Scale Set is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt the OS Disk when the Virtual Machine Scale Set is Confidential VMSS. Conflicts with disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureVmDiskEncryptionSetId")]
    public string? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>Encryption Type when the Virtual Machine Scale Set is Confidential VMSS. Possible values are VMGuestStateOnly and DiskWithVMGuestState. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderPlan
{
    /// <summary>Specifies the name of the image from the marketplace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the product of the image from the marketplace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the publisher of the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>A rolling_upgrade_policy block as defined below. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderRollingUpgradePolicy
{
    /// <summary>Should the Virtual Machine Scale Set ignore the Azure Zone boundaries when constructing upgrade batches? Possible values are true or false.</summary>
    [JsonPropertyName("crossZoneUpgradesEnabled")]
    public bool? CrossZoneUpgradesEnabled { get; set; }

    /// <summary>The maximum percent of total virtual machine instances that will be upgraded simultaneously by the rolling upgrade in one batch. As this is a maximum, unhealthy instances in previous or future batches can cause the percentage of instances in a batch to decrease to ensure higher reliability.</summary>
    [JsonPropertyName("maxBatchInstancePercent")]
    public double? MaxBatchInstancePercent { get; set; }

    /// <summary>The maximum percentage of the total virtual machine instances in the scale set that can be simultaneously unhealthy, either as a result of being upgraded, or by being found in an unhealthy state by the virtual machine health checks before the rolling upgrade aborts. This constraint will be checked prior to starting any batch.</summary>
    [JsonPropertyName("maxUnhealthyInstancePercent")]
    public double? MaxUnhealthyInstancePercent { get; set; }

    /// <summary>The maximum percentage of upgraded virtual machine instances that can be found to be in an unhealthy state. This check will happen after each batch is upgraded. If this percentage is ever exceeded, the rolling update aborts.</summary>
    [JsonPropertyName("maxUnhealthyUpgradedInstancePercent")]
    public double? MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>Create new virtual machines to upgrade the scale set, rather than updating the existing virtual machines. Existing virtual machines will be deleted once the new virtual machines are created for each batch. Possible values are true or false.</summary>
    [JsonPropertyName("maximumSurgeInstancesEnabled")]
    public bool? MaximumSurgeInstancesEnabled { get; set; }

    /// <summary>The wait time between completing the update for all virtual machines in one batch and starting the next batch. The time duration should be specified in ISO 8601 format.</summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary>Upgrade all unhealthy instances in a scale set before any healthy instances. Possible values are true or false.</summary>
    [JsonPropertyName("prioritizeUnhealthyInstancesEnabled")]
    public bool? PrioritizeUnhealthyInstancesEnabled { get; set; }
}

/// <summary>A scale_in block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderScaleIn
{
    /// <summary>Should the virtual machines chosen for removal be force deleted when the virtual machine scale set is being scaled-in? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("forceDeletionEnabled")]
    public bool? ForceDeletionEnabled { get; set; }

    /// <summary>The scale-in policy rule that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled in. Possible values for the scale-in policy rules are Default, NewestVM and OldestVM, defaults to Default. For more information about scale in policy, please refer to this doc.</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderSecretCertificate
{
    /// <summary>The certificate store on the Virtual Machine where the certificate should be added.</summary>
    [JsonPropertyName("store")]
    public string? Store { get; set; }

    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderSecret
{
    /// <summary>One or more certificate blocks as defined above.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary>A source_image_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderSourceImageReference
{
    /// <summary>Specifies the offer of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Specifies the publisher of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Specifies the SKU of the image used to create the virtual machines.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A spot_restore block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderSpotRestore
{
    /// <summary>Should the Spot-Try-Restore feature be enabled? The Spot-Try-Restore feature will attempt to automatically restore the evicted Spot Virtual Machine Scale Set VM instances opportunistically based on capacity availability and pricing constraints. Possible values are true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The length of time that the Virtual Machine Scale Set should attempt to restore the Spot VM instances which have been evicted. The time duration should be between 15 minutes and 120 minutes (inclusive). The time duration should be specified in the ISO 8601 format. Defaults to PT1H. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>A termination_notification block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProviderWinrmListener
{
    /// <summary>The Secret URL of a Key Vault Certificate, which must be specified when protocol is set to Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary>The Protocol of the WinRM Listener. Possible values are Http and Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
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
public partial class V1beta2WindowsVirtualMachineScaleSetSpecInitProvider
{
    /// <summary>An additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>One or more additional_unattend_content blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public required V1beta2WindowsVirtualMachineScaleSetSpecInitProviderAdminPasswordSecretRef AdminPasswordSecretRef { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>An automatic_instance_repair block as defined below. To enable the automatic instance repair, this Virtual Machine Scale Set must have a valid health_probe_id or an Application Health Extension.</summary>
    [JsonPropertyName("automaticInstanceRepair")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderAutomaticInstanceRepair? AutomaticInstanceRepair { get; set; }

    /// <summary>An automatic_os_upgrade_policy block as defined below. This can only be specified when upgrade_mode is set to either Automatic or Rolling.</summary>
    [JsonPropertyName("automaticOsUpgradePolicy")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderAutomaticOsUpgradePolicy? AutomaticOsUpgradePolicy { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderBootDiagnostics? BootDiagnostics { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine Scale Set should be allocated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("customDataSecretRef")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderCustomDataSecretRef? CustomDataSecretRef { get; set; }

    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderDataDisk>? DataDisk { get; set; }

    /// <summary>Should Virtual Machine Extensions be run on Overprovisioned Virtual Machines in the Scale Set? Defaults to false.</summary>
    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedMachines")]
    public bool? DoNotRunExtensionsOnOverprovisionedMachines { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Windows Virtual Machine Scale Set should exist. Changing this forces a new Windows Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Are automatic updates enabled for this Virtual Machine? Defaults to true.</summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Should all of the disks (including the temp disk) attached to this Virtual Machine be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>Specifies the eviction policy for Virtual Machines in this Scale Set. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>One or more extension blocks as defined below</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderExtension>? Extension { get; set; }

    /// <summary>Should extension operations be allowed on the Virtual Machine Scale Set? Possible values are true or false. Defaults to true. Changing this forces a new Windows Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("extensionOperationsEnabled")]
    public bool? ExtensionOperationsEnabled { get; set; }

    /// <summary>Specifies the duration allocated for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>One or more gallery_application blocks as defined below.</summary>
    [JsonPropertyName("galleryApplication")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderGalleryApplication>? GalleryApplication { get; set; }

    /// <summary>The ID of a Load Balancer Probe which should be used to determine the health of an instance. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling.</summary>
    [JsonPropertyName("healthProbeId")]
    public string? HealthProbeId { get; set; }

    /// <summary>Specifies the ID of the dedicated host group that the virtual machine scale set resides in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The number of Virtual Machines in the Scale Set.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }

    /// <summary>Specifies the type of on-premise license (also known as Azure Hybrid Use Benefit) which should be used for this Virtual Machine Scale Set. Possible values are None, Windows_Client and Windows_Server.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>The Azure location where the Windows Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you&apos;re willing to pay for each Virtual Machine in this Scale Set, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machines in the Scale Set will be evicted using the eviction_policy. Defaults to -1, which means that each Virtual Machine in the Scale Set should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>One or more network_interface blocks as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>An os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderOsDisk? OsDisk { get; set; }

    /// <summary>Should Azure over-provision Virtual Machines in this Scale Set? This means that multiple Virtual Machines will be provisioned and Azure will keep the instances which become available first - which improves provisioning success rates and improves deployment time. You&apos;re not billed for these over-provisioned VM&apos;s and they don&apos;t count towards the Subscription Quota. Defaults to true.</summary>
    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderPlan? Plan { get; set; }

    /// <summary>Specifies the number of fault domains that are used by this Linux Virtual Machine Scale Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public double? PlatformFaultDomainCount { get; set; }

    /// <summary>The Priority of this Virtual Machine Scale Set. Possible values are Regular and Spot. Defaults to Regular. Changing this value forces a new resource.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>The ID of the Proximity Placement Group in which the Virtual Machine Scale Set should be assigned to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Should resilient VM creation be enabled? When enabled, the service will attempt to create VMs in alternative fault domains or zones if the primary location fails during creation. Defaults to false.</summary>
    [JsonPropertyName("resilientVmCreationEnabled")]
    public bool? ResilientVmCreationEnabled { get; set; }

    /// <summary>Should resilient VM deletion be enabled? When enabled, the service will use a more resilient deletion process that attempts to gracefully handle failures during VM termination. Defaults to false.</summary>
    [JsonPropertyName("resilientVmDeletionEnabled")]
    public bool? ResilientVmDeletionEnabled { get; set; }

    /// <summary>A rolling_upgrade_policy block as defined below. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderRollingUpgradePolicy? RollingUpgradePolicy { get; set; }

    /// <summary>A scale_in block as defined below.</summary>
    [JsonPropertyName("scaleIn")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderScaleIn? ScaleIn { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderSecret>? Secret { get; set; }

    /// <summary>Specifies if Secure Boot and Trusted Launch is enabled for the Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary>Should this Virtual Machine Scale Set be limited to a Single Placement Group, which means the number of instances will be capped at 100 Virtual Machines. Defaults to true.</summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>The Virtual Machine SKU for the Scale Set, such as Standard_F2.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The ID of an Image which each Virtual Machine in this Scale Set should be based on. Possible Image ID types include Image ID, Shared Image ID, Shared Image Version ID, Community Gallery Image ID, Community Gallery Image Version ID, Shared Gallery Image ID and Shared Gallery Image Version ID.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below.</summary>
    [JsonPropertyName("sourceImageReference")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderSourceImageReference? SourceImageReference { get; set; }

    /// <summary>A spot_restore block as defined below.</summary>
    [JsonPropertyName("spotRestore")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderSpotRestore? SpotRestore { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProviderTerminationNotification? TerminationNotification { get; set; }

    /// <summary>Specifies the time zone of the virtual machine, the possible values are defined here.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>Specifies how Upgrades (e.g. changing the Image/SKU) should be performed to Virtual Machine Instances. Possible values are Automatic, Manual and Rolling. Defaults to Manual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Specifies if vTPM (Virtual Trusted Platform Module) and Trusted Launch is enabled for the Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vtpmEnabled")]
    public bool? VtpmEnabled { get; set; }

    /// <summary>One or more winrm_listener blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("winrmListener")]
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecInitProviderWinrmListener>? WinrmListener { get; set; }

    /// <summary>Should the Virtual Machines in this Scale Set be strictly evenly distributed across Availability Zones? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Windows Virtual Machine Scale Set should be located.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecManagementPoliciesEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WindowsVirtualMachineScaleSetSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2WindowsVirtualMachineScaleSetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WindowsVirtualMachineScaleSetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WindowsVirtualMachineScaleSetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WindowsVirtualMachineScaleSetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>WindowsVirtualMachineScaleSetSpec defines the desired state of WindowsVirtualMachineScaleSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetSpec
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
    public V1beta2WindowsVirtualMachineScaleSetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2WindowsVirtualMachineScaleSetSpecForProvider ForProvider { get; set; }

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
    public V1beta2WindowsVirtualMachineScaleSetSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2WindowsVirtualMachineScaleSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2WindowsVirtualMachineScaleSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2WindowsVirtualMachineScaleSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An additional_capabilities block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderAdditionalCapabilities
{
    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine Scale Set? Possible values are true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderAdditionalUnattendContent
{
    /// <summary>The name of the setting to which the content applies. Possible values are AutoLogon and FirstLogonCommands. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("setting")]
    public string? Setting { get; set; }
}

/// <summary>An automatic_instance_repair block as defined below. To enable the automatic instance repair, this Virtual Machine Scale Set must have a valid health_probe_id or an Application Health Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderAutomaticInstanceRepair
{
    /// <summary>The repair action that will be used for repairing unhealthy virtual machines in the scale set. Possible values include Replace, Restart, Reimage.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Should the automatic instance repair be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amount of time for which automatic repairs will be delayed. The grace period starts right after the VM is found unhealthy. Possible values are between 10 and 90 minutes. The time duration should be specified in ISO 8601 format (e.g. PT10M to PT90M).</summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary>An automatic_os_upgrade_policy block as defined below. This can only be specified when upgrade_mode is set to either Automatic or Rolling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderAutomaticOsUpgradePolicy
{
    /// <summary>Should automatic rollbacks be disabled?</summary>
    [JsonPropertyName("disableAutomaticRollback")]
    public bool? DisableAutomaticRollback { get; set; }

    /// <summary>Should OS Upgrades automatically be applied to Scale Set instances in a rolling fashion when a newer version of the OS Image becomes available?</summary>
    [JsonPropertyName("enableAutomaticOsUpgrade")]
    public bool? EnableAutomaticOsUpgrade { get; set; }
}

/// <summary>A boot_diagnostics block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderDataDisk
{
    /// <summary>The type of Caching which should be used for this Data Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The create option which should be used for this Data Disk. Possible values are Empty and FromImage. Defaults to Empty. (FromImage should only be used if the source image includes data disks).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The size of the Data Disk which should be created.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which must be unique within the Virtual Machine.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The name of the Data Disk.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Type of Storage Account which should back this Data Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS and UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies the Read-Write IOPS for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskIopsReadWrite")]
    public double? UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>Specifies the bandwidth in MB per second for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskMbpsReadWrite")]
    public double? UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>A protected_settings_from_key_vault block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderExtensionProtectedSettingsFromKeyVault
{
    /// <summary>The URL to the Key Vault Secret which stores the protected settings.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderExtension
{
    /// <summary>Should the latest version of the Extension be used at Deployment Time, if one is available? This won&apos;t auto-update the extension on existing installation. Defaults to true.</summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>Should the Extension be automatically updated whenever the Publisher releases a new version of this VM Extension?</summary>
    [JsonPropertyName("automaticUpgradeEnabled")]
    public bool? AutomaticUpgradeEnabled { get; set; }

    /// <summary>A value which, when different to the previous value can be used to force-run the Extension even if the Extension Configuration hasn&apos;t changed.</summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>The name for the Virtual Machine Scale Set Extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderExtensionProtectedSettingsFromKeyVault? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>An ordered list of Extension names which this should be provisioned after.</summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>Specifies the Publisher of the Extension.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>A JSON String which specifies Settings for the Extension.</summary>
    [JsonPropertyName("settings")]
    public string? Settings { get; set; }

    /// <summary>Specifies the Type of the Extension.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the version of the extension to use, available versions can be found using the Azure CLI.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderGalleryApplication
{
    /// <summary>Specifies the URI to an Azure Blob that will replace the default configuration for the package if provided. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("configurationBlobUri")]
    public string? ConfigurationBlobUri { get; set; }

    /// <summary>Specifies the order in which the packages have to be installed. Possible values are between 0 and 2147483647. Defaults to 0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Specifies a passthrough value for more generic context. This field can be any valid string value. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Specifies the Gallery Application Version resource ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Windows Virtual Machine Scale Set.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Windows Virtual Machine Scale Set. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag
{
    /// <summary>The IP Tag associated with the Public IP, such as SQL or Storage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The Type of IP Tag, such as FirstPartyUsage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddress
{
    /// <summary>The Prefix which should be used for the Domain Name Label for each Virtual Machine Instance. Azure concatenates the Domain Name Label and Virtual Machine Index to create a unique Domain Name Label for each Virtual Machine.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>The Idle Timeout in Minutes for the Public IP Address. Possible values are in the range 4 to 32.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>One or more ip_tag blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTag")]
    public IList<V1beta2WindowsVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag>? IpTag { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Public IP Address Prefix from where Public IP Addresses should be allocated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfiguration
{
    /// <summary>A list of Backend Address Pools ID&apos;s from a Application Gateway which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPoolIds")]
    public IList<string>? ApplicationGatewayBackendAddressPoolIds { get; set; }

    /// <summary>A list of Application Security Group ID&apos;s which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>A list of Backend Address Pools ID&apos;s from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolIds")]
    public IList<string>? LoadBalancerBackendAddressPoolIds { get; set; }

    /// <summary>A list of NAT Rule ID&apos;s from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerInboundNatRulesIds")]
    public IList<string>? LoadBalancerInboundNatRulesIds { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>A public_ip_address block as defined below.</summary>
    [JsonPropertyName("publicIpAddress")]
    public IList<V1beta2WindowsVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddress>? PublicIpAddress { get; set; }

    /// <summary>The ID of the Subnet which this IP Configuration should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderNetworkInterface
{
    /// <summary>Specifies the auxiliary mode used to enable network high-performance feature on Network Virtual Appliances (NVAs). This feature offers competitive performance in Connections Per Second (CPS) optimization, along with improvements to handling large amounts of simultaneous connections. Possible values are AcceleratedConnections and Floating.</summary>
    [JsonPropertyName("auxiliaryMode")]
    public string? AuxiliaryMode { get; set; }

    /// <summary>Specifies the SKU used for the network high-performance feature on Network Virtual Appliances (NVAs). Possible values are A1, A2, A4 and A8.</summary>
    [JsonPropertyName("auxiliarySku")]
    public string? AuxiliarySku { get; set; }

    /// <summary>A list of IP Addresses of DNS Servers which should be assigned to the Network Interface.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>Does this Network Interface support Accelerated Networking? Defaults to false.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>Does this Network Interface support IP Forwarding? Defaults to false.</summary>
    [JsonPropertyName("enableIpForwarding")]
    public bool? EnableIpForwarding { get; set; }

    /// <summary>One or more ip_configuration blocks as defined above.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta2WindowsVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Name which should be used for this Network Interface. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Network Security Group which should be assigned to this Network Interface.</summary>
    [JsonPropertyName("networkSecurityGroupId")]
    public string? NetworkSecurityGroupId { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderOsDiskDiffDiskSettings
{
    /// <summary>Specifies the Ephemeral Disk Settings for the OS Disk. At this time the only possible value is Local. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("option")]
    public string? Option { get; set; }

    /// <summary>Specifies where to store the Ephemeral Disk. Possible values are CacheDisk and ResourceDisk. Defaults to CacheDisk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary>An os_disk block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine Scale Set is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt the OS Disk when the Virtual Machine Scale Set is Confidential VMSS. Conflicts with disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureVmDiskEncryptionSetId")]
    public string? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>Encryption Type when the Virtual Machine Scale Set is Confidential VMSS. Possible values are VMGuestStateOnly and DiskWithVMGuestState. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderPlan
{
    /// <summary>Specifies the name of the image from the marketplace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the product of the image from the marketplace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the publisher of the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>A rolling_upgrade_policy block as defined below. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderRollingUpgradePolicy
{
    /// <summary>Should the Virtual Machine Scale Set ignore the Azure Zone boundaries when constructing upgrade batches? Possible values are true or false.</summary>
    [JsonPropertyName("crossZoneUpgradesEnabled")]
    public bool? CrossZoneUpgradesEnabled { get; set; }

    /// <summary>The maximum percent of total virtual machine instances that will be upgraded simultaneously by the rolling upgrade in one batch. As this is a maximum, unhealthy instances in previous or future batches can cause the percentage of instances in a batch to decrease to ensure higher reliability.</summary>
    [JsonPropertyName("maxBatchInstancePercent")]
    public double? MaxBatchInstancePercent { get; set; }

    /// <summary>The maximum percentage of the total virtual machine instances in the scale set that can be simultaneously unhealthy, either as a result of being upgraded, or by being found in an unhealthy state by the virtual machine health checks before the rolling upgrade aborts. This constraint will be checked prior to starting any batch.</summary>
    [JsonPropertyName("maxUnhealthyInstancePercent")]
    public double? MaxUnhealthyInstancePercent { get; set; }

    /// <summary>The maximum percentage of upgraded virtual machine instances that can be found to be in an unhealthy state. This check will happen after each batch is upgraded. If this percentage is ever exceeded, the rolling update aborts.</summary>
    [JsonPropertyName("maxUnhealthyUpgradedInstancePercent")]
    public double? MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>Create new virtual machines to upgrade the scale set, rather than updating the existing virtual machines. Existing virtual machines will be deleted once the new virtual machines are created for each batch. Possible values are true or false.</summary>
    [JsonPropertyName("maximumSurgeInstancesEnabled")]
    public bool? MaximumSurgeInstancesEnabled { get; set; }

    /// <summary>The wait time between completing the update for all virtual machines in one batch and starting the next batch. The time duration should be specified in ISO 8601 format.</summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary>Upgrade all unhealthy instances in a scale set before any healthy instances. Possible values are true or false.</summary>
    [JsonPropertyName("prioritizeUnhealthyInstancesEnabled")]
    public bool? PrioritizeUnhealthyInstancesEnabled { get; set; }
}

/// <summary>A scale_in block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderScaleIn
{
    /// <summary>Should the virtual machines chosen for removal be force deleted when the virtual machine scale set is being scaled-in? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("forceDeletionEnabled")]
    public bool? ForceDeletionEnabled { get; set; }

    /// <summary>The scale-in policy rule that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled in. Possible values for the scale-in policy rules are Default, NewestVM and OldestVM, defaults to Default. For more information about scale in policy, please refer to this doc.</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderSecretCertificate
{
    /// <summary>The certificate store on the Virtual Machine where the certificate should be added.</summary>
    [JsonPropertyName("store")]
    public string? Store { get; set; }

    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderSecret
{
    /// <summary>One or more certificate blocks as defined above.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2WindowsVirtualMachineScaleSetStatusAtProviderSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary>A source_image_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderSourceImageReference
{
    /// <summary>Specifies the offer of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Specifies the publisher of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Specifies the SKU of the image used to create the virtual machines.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A spot_restore block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderSpotRestore
{
    /// <summary>Should the Spot-Try-Restore feature be enabled? The Spot-Try-Restore feature will attempt to automatically restore the evicted Spot Virtual Machine Scale Set VM instances opportunistically based on capacity availability and pricing constraints. Possible values are true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The length of time that the Virtual Machine Scale Set should attempt to restore the Spot VM instances which have been evicted. The time duration should be between 15 minutes and 120 minutes (inclusive). The time duration should be specified in the ISO 8601 format. Defaults to PT1H. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>A termination_notification block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProviderWinrmListener
{
    /// <summary>The Secret URL of a Key Vault Certificate, which must be specified when protocol is set to Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary>The Protocol of the WinRM Listener. Possible values are Http and Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusAtProvider
{
    /// <summary>An additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>One or more additional_unattend_content blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1beta2WindowsVirtualMachineScaleSetStatusAtProviderAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>An automatic_instance_repair block as defined below. To enable the automatic instance repair, this Virtual Machine Scale Set must have a valid health_probe_id or an Application Health Extension.</summary>
    [JsonPropertyName("automaticInstanceRepair")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderAutomaticInstanceRepair? AutomaticInstanceRepair { get; set; }

    /// <summary>An automatic_os_upgrade_policy block as defined below. This can only be specified when upgrade_mode is set to either Automatic or Rolling.</summary>
    [JsonPropertyName("automaticOsUpgradePolicy")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderAutomaticOsUpgradePolicy? AutomaticOsUpgradePolicy { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderBootDiagnostics? BootDiagnostics { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine Scale Set should be allocated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta2WindowsVirtualMachineScaleSetStatusAtProviderDataDisk>? DataDisk { get; set; }

    /// <summary>Should Virtual Machine Extensions be run on Overprovisioned Virtual Machines in the Scale Set? Defaults to false.</summary>
    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedMachines")]
    public bool? DoNotRunExtensionsOnOverprovisionedMachines { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Windows Virtual Machine Scale Set should exist. Changing this forces a new Windows Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Are automatic updates enabled for this Virtual Machine? Defaults to true.</summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Should all of the disks (including the temp disk) attached to this Virtual Machine be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>Specifies the eviction policy for Virtual Machines in this Scale Set. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>One or more extension blocks as defined below</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta2WindowsVirtualMachineScaleSetStatusAtProviderExtension>? Extension { get; set; }

    /// <summary>Should extension operations be allowed on the Virtual Machine Scale Set? Possible values are true or false. Defaults to true. Changing this forces a new Windows Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("extensionOperationsEnabled")]
    public bool? ExtensionOperationsEnabled { get; set; }

    /// <summary>Specifies the duration allocated for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>One or more gallery_application blocks as defined below.</summary>
    [JsonPropertyName("galleryApplication")]
    public IList<V1beta2WindowsVirtualMachineScaleSetStatusAtProviderGalleryApplication>? GalleryApplication { get; set; }

    /// <summary>The ID of a Load Balancer Probe which should be used to determine the health of an instance. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling.</summary>
    [JsonPropertyName("healthProbeId")]
    public string? HealthProbeId { get; set; }

    /// <summary>Specifies the ID of the dedicated host group that the virtual machine scale set resides in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>The ID of the Windows Virtual Machine Scale Set.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The number of Virtual Machines in the Scale Set.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }

    /// <summary>Specifies the type of on-premise license (also known as Azure Hybrid Use Benefit) which should be used for this Virtual Machine Scale Set. Possible values are None, Windows_Client and Windows_Server.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>The Azure location where the Windows Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you&apos;re willing to pay for each Virtual Machine in this Scale Set, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machines in the Scale Set will be evicted using the eviction_policy. Defaults to -1, which means that each Virtual Machine in the Scale Set should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>One or more network_interface blocks as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta2WindowsVirtualMachineScaleSetStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>An os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderOsDisk? OsDisk { get; set; }

    /// <summary>Should Azure over-provision Virtual Machines in this Scale Set? This means that multiple Virtual Machines will be provisioned and Azure will keep the instances which become available first - which improves provisioning success rates and improves deployment time. You&apos;re not billed for these over-provisioned VM&apos;s and they don&apos;t count towards the Subscription Quota. Defaults to true.</summary>
    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderPlan? Plan { get; set; }

    /// <summary>Specifies the number of fault domains that are used by this Linux Virtual Machine Scale Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public double? PlatformFaultDomainCount { get; set; }

    /// <summary>The Priority of this Virtual Machine Scale Set. Possible values are Regular and Spot. Defaults to Regular. Changing this value forces a new resource.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>The ID of the Proximity Placement Group in which the Virtual Machine Scale Set should be assigned to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Should resilient VM creation be enabled? When enabled, the service will attempt to create VMs in alternative fault domains or zones if the primary location fails during creation. Defaults to false.</summary>
    [JsonPropertyName("resilientVmCreationEnabled")]
    public bool? ResilientVmCreationEnabled { get; set; }

    /// <summary>Should resilient VM deletion be enabled? When enabled, the service will use a more resilient deletion process that attempts to gracefully handle failures during VM termination. Defaults to false.</summary>
    [JsonPropertyName("resilientVmDeletionEnabled")]
    public bool? ResilientVmDeletionEnabled { get; set; }

    /// <summary>The name of the Resource Group in which the Windows Virtual Machine Scale Set should be exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A rolling_upgrade_policy block as defined below. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderRollingUpgradePolicy? RollingUpgradePolicy { get; set; }

    /// <summary>A scale_in block as defined below.</summary>
    [JsonPropertyName("scaleIn")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderScaleIn? ScaleIn { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2WindowsVirtualMachineScaleSetStatusAtProviderSecret>? Secret { get; set; }

    /// <summary>Specifies if Secure Boot and Trusted Launch is enabled for the Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary>Should this Virtual Machine Scale Set be limited to a Single Placement Group, which means the number of instances will be capped at 100 Virtual Machines. Defaults to true.</summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>The Virtual Machine SKU for the Scale Set, such as Standard_F2.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The ID of an Image which each Virtual Machine in this Scale Set should be based on. Possible Image ID types include Image ID, Shared Image ID, Shared Image Version ID, Community Gallery Image ID, Community Gallery Image Version ID, Shared Gallery Image ID and Shared Gallery Image Version ID.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below.</summary>
    [JsonPropertyName("sourceImageReference")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderSourceImageReference? SourceImageReference { get; set; }

    /// <summary>A spot_restore block as defined below.</summary>
    [JsonPropertyName("spotRestore")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderSpotRestore? SpotRestore { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProviderTerminationNotification? TerminationNotification { get; set; }

    /// <summary>Specifies the time zone of the virtual machine, the possible values are defined here.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>The Unique ID for this Windows Virtual Machine Scale Set.</summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }

    /// <summary>Specifies how Upgrades (e.g. changing the Image/SKU) should be performed to Virtual Machine Instances. Possible values are Automatic, Manual and Rolling. Defaults to Manual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Specifies if vTPM (Virtual Trusted Platform Module) and Trusted Launch is enabled for the Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vtpmEnabled")]
    public bool? VtpmEnabled { get; set; }

    /// <summary>One or more winrm_listener blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("winrmListener")]
    public IList<V1beta2WindowsVirtualMachineScaleSetStatusAtProviderWinrmListener>? WinrmListener { get; set; }

    /// <summary>Should the Virtual Machines in this Scale Set be strictly evenly distributed across Availability Zones? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Windows Virtual Machine Scale Set should be located.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatusConditions
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

/// <summary>WindowsVirtualMachineScaleSetStatus defines the observed state of WindowsVirtualMachineScaleSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WindowsVirtualMachineScaleSetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2WindowsVirtualMachineScaleSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2WindowsVirtualMachineScaleSetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WindowsVirtualMachineScaleSet is the Schema for the WindowsVirtualMachineScaleSets API. Manages a Windows Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2WindowsVirtualMachineScaleSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2WindowsVirtualMachineScaleSetSpec>, IStatus<V1beta2WindowsVirtualMachineScaleSetStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "WindowsVirtualMachineScaleSet";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "windowsvirtualmachinescalesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WindowsVirtualMachineScaleSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WindowsVirtualMachineScaleSetSpec defines the desired state of WindowsVirtualMachineScaleSet</summary>
    [JsonPropertyName("spec")]
    public required V1beta2WindowsVirtualMachineScaleSetSpec Spec { get; set; }

    /// <summary>WindowsVirtualMachineScaleSetStatus defines the observed state of WindowsVirtualMachineScaleSet.</summary>
    [JsonPropertyName("status")]
    public V1beta2WindowsVirtualMachineScaleSetStatus? Status { get; set; }
}