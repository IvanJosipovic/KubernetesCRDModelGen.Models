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
/// <summary>OrchestratedVirtualMachineScaleSet is the Schema for the OrchestratedVirtualMachineScaleSets API. Manages an Virtual Machine Scale Set in Flexible Orchestration Mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2OrchestratedVirtualMachineScaleSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta2OrchestratedVirtualMachineScaleSet>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "OrchestratedVirtualMachineScaleSetList";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "orchestratedvirtualmachinescalesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OrchestratedVirtualMachineScaleSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2OrchestratedVirtualMachineScaleSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2OrchestratedVirtualMachineScaleSet> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecDeletionPolicyEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>An additional_capabilities block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderAdditionalCapabilities
{
    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine Scale Set? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary>An automatic_instance_repair block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderAutomaticInstanceRepair
{
    /// <summary>The repair action that will be used for repairing unhealthy virtual machines in the scale set. Possible values include Replace, Restart, Reimage.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Should the automatic instance repair be enabled on this Virtual Machine Scale Set? Possible values are true and false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amount of time for which automatic repairs will be delayed. The grace period starts right after the VM is found unhealthy. Possible values are between 10 and 90 minutes. The time duration should be specified in ISO 8601 format (e.g. PT10M to PT90M).</summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary>A boot_diagnostics block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor. By including a boot_diagnostics block without passing the storage_account_uri field will cause the API to utilize a Managed Storage Account to store the Boot Diagnostics output.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderDataDisk
{
    /// <summary>The type of Caching which should be used for this Data Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The create option which should be used for this Data Disk. Possible values are Empty and FromImage. Defaults to Empty. (FromImage should only be used if the source image includes data disks).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt the Data Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The size of the Data Disk which should be created. Required if create_option is specified as Empty.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which must be unique within the Virtual Machine. Required if create_option is specified as Empty.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The Type of Storage Account which should back this Data Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS and UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies the Read-Write IOPS for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskIopsReadWrite")]
    public double? UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>Specifies the bandwidth in MB per second for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskMbpsReadWrite")]
    public double? UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the Data Disk. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>A protected_settings_from_key_vault block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsFromKeyVault
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsSecretRef
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderExtension
{
    /// <summary>Should the latest version of the Extension be used at Deployment Time, if one is available? This won&apos;t auto-update the extension on existing installation. Defaults to true.</summary>
    [JsonPropertyName("autoUpgradeMinorVersionEnabled")]
    public bool? AutoUpgradeMinorVersionEnabled { get; set; }

    /// <summary>An ordered list of Extension names which Virtual Machine Scale Set should provision after VM creation.</summary>
    [JsonPropertyName("extensionsToProvisionAfterVmCreation")]
    public IList<string>? ExtensionsToProvisionAfterVmCreation { get; set; }

    /// <summary>Should failures from the extension be suppressed? Possible values are true or false.</summary>
    [JsonPropertyName("failureSuppressionEnabled")]
    public bool? FailureSuppressionEnabled { get; set; }

    /// <summary>A value which, when different to the previous value can be used to force-run the Extension even if the Extension Configuration hasn&apos;t changed.</summary>
    [JsonPropertyName("forceExtensionExecutionOnChange")]
    public string? ForceExtensionExecutionOnChange { get; set; }

    /// <summary>The name for the Virtual Machine Scale Set Extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsFromKeyVault? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>A JSON String which specifies Sensitive Settings (such as Passwords) for the Extension.</summary>
    [JsonPropertyName("protectedSettingsSecretRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsSecretRef? ProtectedSettingsSecretRef { get; set; }

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

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Managed Identity IDs to be assigned to this Windows Virtual Machine Scale Set.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of Managed Identity that should be configured on this Windows Virtual Machine Scale Set. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddress
{
    /// <summary>The Prefix which should be used for the Domain Name Label for each Virtual Machine Instance. Azure concatenates the Domain Name Label and Virtual Machine Index to create a unique Domain Name Label for each Virtual Machine. Valid values must be between 1 and 26 characters long, start with a lower case letter, end with a lower case letter or number and contains only a-z, 0-9 and hyphens.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>The Idle Timeout in Minutes for the Public IP Address. Possible values are in the range 4 to 32.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>One or more ip_tag blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTag")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag>? IpTag { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Public IP Address Prefix from where Public IP Addresses should be allocated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>The name of the SKU to be used by this Virtual Machine Scale Set. Valid values include: any of the General purpose, Compute optimized, Memory optimized, Storage optimized, GPU optimized, FPGA optimized, High performance, or Previous generation virtual machine SKUs.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelector
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
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfiguration
{
    /// <summary>A list of Backend Address Pools IDs from a Application Gateway which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPoolIds")]
    public IList<string>? ApplicationGatewayBackendAddressPoolIds { get; set; }

    /// <summary>A list of Application Security Group IDs which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>A list of Backend Address Pools IDs from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolIds")]
    public IList<string>? LoadBalancerBackendAddressPoolIds { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>A public_ip_address block as defined below.</summary>
    [JsonPropertyName("publicIpAddress")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddress>? PublicIpAddress { get; set; }

    /// <summary>The ID of the Subnet which this IP Configuration should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterface
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

    /// <summary>Does this Network Interface support Accelerated Networking? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>Does this Network Interface support IP Forwarding? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("enableIpForwarding")]
    public bool? EnableIpForwarding { get; set; }

    /// <summary>One or more ip_configuration blocks as defined above.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Name which should be used for this Network Interface. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Network Security Group which should be assigned to this Network Interface.</summary>
    [JsonPropertyName("networkSecurityGroupId")]
    public string? NetworkSecurityGroupId { get; set; }

    /// <summary>Is this the Primary IP Configuration? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsDiskDiffDiskSettings
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine Scale Set is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the OS Disk. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileCustomDataSecretRef
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

/// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationAdminPasswordSecretRef
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationAdminSshKey
{
    /// <summary>The Public Key which should be used for authentication, which needs to be in ssh-rsa format with at least 2048-bit or in ssh-ed25519 format.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The Username for which this Public SSH Key should be configured.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationSecretCertificate
{
    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationSecret
{
    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary>A linux_configuration block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfiguration
{
    /// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationAdminPasswordSecretRef? AdminPasswordSecretRef { get; set; }

    /// <summary>A admin_ssh_key block as documented below.</summary>
    [JsonPropertyName("adminSshKey")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationAdminSshKey>? AdminSshKey { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>When an admin_password is specified disable_password_authentication must be set to false. Defaults to true.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the virtual machines that are associated to the Virtual Machine Scale Set. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching of this Windows Virtual Machine. Possible values are Manual, AutomaticByOS and AutomaticByPlatform. Defaults to AutomaticByOS. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationSecret>? Secret { get; set; }
}

/// <summary>The XML formatted content that is added to the unattend.xml file for the specified path and component. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationAdditionalUnattendContentContentSecretRef
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>The XML formatted content that is added to the unattend.xml file for the specified path and component. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("contentSecretRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationAdditionalUnattendContentContentSecretRef? ContentSecretRef { get; set; }

    /// <summary>The name of the setting to which the content applies. Possible values are AutoLogon and FirstLogonCommands. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("setting")]
    public string? Setting { get; set; }
}

/// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationAdminPasswordSecretRef
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationSecretCertificate
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationSecret
{
    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationWinrmListener
{
    /// <summary>The Secret URL of a Key Vault Certificate, which must be specified when protocol is set to Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary>Specifies the protocol of listener. Possible values are Http or Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>A windows_configuration block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfiguration
{
    /// <summary>One or more additional_unattend_content blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationAdminPasswordSecretRef? AdminPasswordSecretRef { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>Are automatic updates enabled for this Virtual Machine? Defaults to true.</summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Should the VM be patched without requiring a reboot? Possible values are true or false. Defaults to false. For more information about hot patching please see the product documentation.</summary>
    [JsonPropertyName("hotpatchingEnabled")]
    public bool? HotpatchingEnabled { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the virtual machines that are associated to the Virtual Machine Scale Set. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching of this Windows Virtual Machine. Possible values are Manual, AutomaticByOS and AutomaticByPlatform. Defaults to AutomaticByOS. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationSecret>? Secret { get; set; }

    /// <summary>Specifies the time zone of the virtual machine, the possible values are defined here.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>One or more winrm_listener blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("winrmListener")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationWinrmListener>? WinrmListener { get; set; }
}

/// <summary>An os_profile block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfile
{
    /// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("customDataSecretRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileCustomDataSecretRef? CustomDataSecretRef { get; set; }

    /// <summary>A linux_configuration block as documented below.</summary>
    [JsonPropertyName("linuxConfiguration")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary>A windows_configuration block as documented below.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>A plan block as documented below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderPlan
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

/// <summary>a priority_mix block as defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderPriorityMix
{
    /// <summary>Specifies the base number of VMs of Regular priority that will be created before any VMs of priority Spot are created. Possible values are integers between 0 and 1000. Defaults to 0.</summary>
    [JsonPropertyName("baseRegularCount")]
    public double? BaseRegularCount { get; set; }

    /// <summary>Specifies the desired percentage of VM instances that are of Regular priority after the base count has been reached. Possible values are integers between 0 and 100. Defaults to 0.</summary>
    [JsonPropertyName("regularPercentageAboveBase")]
    public double? RegularPercentageAboveBase { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelector
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
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A rolling_upgrade_policy block as defined below. This is Required when upgrade_mode is set to Rolling and cannot be specified when upgrade_mode is set to Manual. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderRollingUpgradePolicy
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

    /// <summary>The wait time between completing the update for all virtual machines in one batch and starting the next batch. The time duration should be specified in ISO 8601 duration format.</summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary>Upgrade all unhealthy instances in a scale set before any healthy instances. Possible values are true or false.</summary>
    [JsonPropertyName("prioritizeUnhealthyInstancesEnabled")]
    public bool? PrioritizeUnhealthyInstancesEnabled { get; set; }
}

/// <summary>An sku_profile block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderSkuProfile
{
    /// <summary>Specifies the allocation strategy for the virtual machine scale set based on which the VMs will be allocated. Possible values are CapacityOptimized, LowestPrice and Prioritized.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Specifies the VM sizes for the virtual machine scale set.</summary>
    [JsonPropertyName("vmSizes")]
    public IList<string>? VmSizes { get; set; }
}

/// <summary>A source_image_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderSourceImageReference
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

/// <summary>A termination_notification block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine Scale Set? Possible values true or false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderUserDataBase64SecretRef
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecForProvider
{
    /// <summary>An additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>An automatic_instance_repair block as defined below.</summary>
    [JsonPropertyName("automaticInstanceRepair")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderAutomaticInstanceRepair? AutomaticInstanceRepair { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderBootDiagnostics? BootDiagnostics { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine Scale Set should be allocated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderDataDisk>? DataDisk { get; set; }

    /// <summary>Should disks attached to this Virtual Machine Scale Set be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>The Policy which should be used by Spot Virtual Machines that are Evicted from the Scale Set. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>One or more extension blocks as defined below</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderExtension>? Extension { get; set; }

    /// <summary>Should extension operations be allowed on the Virtual Machine Scale Set? Possible values are true or false. Defaults to true. Changing this forces a new Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("extensionOperationsEnabled")]
    public bool? ExtensionOperationsEnabled { get; set; }

    /// <summary>Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The number of Virtual Machines in the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }

    /// <summary>Specifies the type of on-premise license (also known as Azure Hybrid Use Benefit) which should be used for this Virtual Machine Scale Set. Possible values are None, Windows_Client and Windows_Server.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>The Azure location where the Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you&apos;re willing to pay for each Virtual Machine in this Scale Set, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machines in the Scale Set will be evicted using the eviction_policy. Defaults to -1, which means that each Virtual Machine in the Scale Set should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>Specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations for Virtual Machine Scale Set. Possible values are 2020-11-01 and 2022-11-01. Defaults to 2020-11-01.</summary>
    [JsonPropertyName("networkApiVersion")]
    public string? NetworkApiVersion { get; set; }

    /// <summary>One or more network_interface blocks as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>An os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsDisk? OsDisk { get; set; }

    /// <summary>An os_profile block as defined below.</summary>
    [JsonPropertyName("osProfile")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderOsProfile? OsProfile { get; set; }

    /// <summary>A plan block as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderPlan? Plan { get; set; }

    /// <summary>Specifies the number of fault domains that are used by this Virtual Machine Scale Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public double? PlatformFaultDomainCount { get; set; }

    /// <summary>The Priority of this Virtual Machine Scale Set. Possible values are Regular and Spot. Defaults to Regular. Changing this value forces a new resource.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>a priority_mix block as defined below</summary>
    [JsonPropertyName("priorityMix")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderPriorityMix? PriorityMix { get; set; }

    /// <summary>The ID of the Proximity Placement Group which the Virtual Machine should be assigned to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>The name of the Resource Group in which the Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A rolling_upgrade_policy block as defined below. This is Required when upgrade_mode is set to Rolling and cannot be specified when upgrade_mode is set to Manual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderRollingUpgradePolicy? RollingUpgradePolicy { get; set; }

    /// <summary>Should this Virtual Machine Scale Set be limited to a Single Placement Group, which means the number of instances will be capped at 100 Virtual Machines. Possible values are true or false.</summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>The name of the SKU to be used by this Virtual Machine Scale Set. Valid values include: any of the General purpose, Compute optimized, Memory optimized, Storage optimized, GPU optimized, FPGA optimized, High performance, or Previous generation virtual machine SKUs.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>An sku_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuProfile")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderSkuProfile? SkuProfile { get; set; }

    /// <summary>The ID of an Image which each Virtual Machine in this Scale Set should be based on. Possible Image ID types include Image IDs, Shared Image IDs, Shared Image Version IDs, Community Gallery Image IDs, Community Gallery Image Version IDs, Shared Gallery Image IDs and Shared Gallery Image Version IDs.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below.</summary>
    [JsonPropertyName("sourceImageReference")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderSourceImageReference? SourceImageReference { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderTerminationNotification? TerminationNotification { get; set; }

    /// <summary>Specifies how upgrades (e.g. changing the Image/SKU) should be performed to Virtual Machine Instances. Possible values are Automatic, Manual and Rolling. Defaults to Manual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("userDataBase64SecretRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecForProviderUserDataBase64SecretRef? UserDataBase64SecretRef { get; set; }

    /// <summary>Should the Virtual Machines in this Scale Set be strictly evenly distributed across Availability Zones? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Specifies a list of Availability Zones across which the Virtual Machine Scale Set will create instances.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>An additional_capabilities block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderAdditionalCapabilities
{
    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine Scale Set? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary>An automatic_instance_repair block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderAutomaticInstanceRepair
{
    /// <summary>The repair action that will be used for repairing unhealthy virtual machines in the scale set. Possible values include Replace, Restart, Reimage.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Should the automatic instance repair be enabled on this Virtual Machine Scale Set? Possible values are true and false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amount of time for which automatic repairs will be delayed. The grace period starts right after the VM is found unhealthy. Possible values are between 10 and 90 minutes. The time duration should be specified in ISO 8601 format (e.g. PT10M to PT90M).</summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary>A boot_diagnostics block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor. By including a boot_diagnostics block without passing the storage_account_uri field will cause the API to utilize a Managed Storage Account to store the Boot Diagnostics output.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderDataDisk
{
    /// <summary>The type of Caching which should be used for this Data Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The create option which should be used for this Data Disk. Possible values are Empty and FromImage. Defaults to Empty. (FromImage should only be used if the source image includes data disks).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt the Data Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The size of the Data Disk which should be created. Required if create_option is specified as Empty.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which must be unique within the Virtual Machine. Required if create_option is specified as Empty.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The Type of Storage Account which should back this Data Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS and UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies the Read-Write IOPS for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskIopsReadWrite")]
    public double? UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>Specifies the bandwidth in MB per second for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskMbpsReadWrite")]
    public double? UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the Data Disk. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>A protected_settings_from_key_vault block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderExtensionProtectedSettingsFromKeyVault
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderExtensionProtectedSettingsSecretRef
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderExtension
{
    /// <summary>Should the latest version of the Extension be used at Deployment Time, if one is available? This won&apos;t auto-update the extension on existing installation. Defaults to true.</summary>
    [JsonPropertyName("autoUpgradeMinorVersionEnabled")]
    public bool? AutoUpgradeMinorVersionEnabled { get; set; }

    /// <summary>An ordered list of Extension names which Virtual Machine Scale Set should provision after VM creation.</summary>
    [JsonPropertyName("extensionsToProvisionAfterVmCreation")]
    public IList<string>? ExtensionsToProvisionAfterVmCreation { get; set; }

    /// <summary>Should failures from the extension be suppressed? Possible values are true or false.</summary>
    [JsonPropertyName("failureSuppressionEnabled")]
    public bool? FailureSuppressionEnabled { get; set; }

    /// <summary>A value which, when different to the previous value can be used to force-run the Extension even if the Extension Configuration hasn&apos;t changed.</summary>
    [JsonPropertyName("forceExtensionExecutionOnChange")]
    public string? ForceExtensionExecutionOnChange { get; set; }

    /// <summary>The name for the Virtual Machine Scale Set Extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderExtensionProtectedSettingsFromKeyVault? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>A JSON String which specifies Sensitive Settings (such as Passwords) for the Extension.</summary>
    [JsonPropertyName("protectedSettingsSecretRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderExtensionProtectedSettingsSecretRef? ProtectedSettingsSecretRef { get; set; }

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

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Managed Identity IDs to be assigned to this Windows Virtual Machine Scale Set.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of Managed Identity that should be configured on this Windows Virtual Machine Scale Set. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddress
{
    /// <summary>The Prefix which should be used for the Domain Name Label for each Virtual Machine Instance. Azure concatenates the Domain Name Label and Virtual Machine Index to create a unique Domain Name Label for each Virtual Machine. Valid values must be between 1 and 26 characters long, start with a lower case letter, end with a lower case letter or number and contains only a-z, 0-9 and hyphens.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>The Idle Timeout in Minutes for the Public IP Address. Possible values are in the range 4 to 32.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>One or more ip_tag blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTag")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag>? IpTag { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Public IP Address Prefix from where Public IP Addresses should be allocated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>The name of the SKU to be used by this Virtual Machine Scale Set. Valid values include: any of the General purpose, Compute optimized, Memory optimized, Storage optimized, GPU optimized, FPGA optimized, High performance, or Previous generation virtual machine SKUs.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelector
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
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfiguration
{
    /// <summary>A list of Backend Address Pools IDs from a Application Gateway which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPoolIds")]
    public IList<string>? ApplicationGatewayBackendAddressPoolIds { get; set; }

    /// <summary>A list of Application Security Group IDs which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>A list of Backend Address Pools IDs from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolIds")]
    public IList<string>? LoadBalancerBackendAddressPoolIds { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>A public_ip_address block as defined below.</summary>
    [JsonPropertyName("publicIpAddress")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddress>? PublicIpAddress { get; set; }

    /// <summary>The ID of the Subnet which this IP Configuration should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterface
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

    /// <summary>Does this Network Interface support Accelerated Networking? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>Does this Network Interface support IP Forwarding? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("enableIpForwarding")]
    public bool? EnableIpForwarding { get; set; }

    /// <summary>One or more ip_configuration blocks as defined above.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Name which should be used for this Network Interface. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Network Security Group which should be assigned to this Network Interface.</summary>
    [JsonPropertyName("networkSecurityGroupId")]
    public string? NetworkSecurityGroupId { get; set; }

    /// <summary>Is this the Primary IP Configuration? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsDiskDiffDiskSettings
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine Scale Set is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the OS Disk. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileCustomDataSecretRef
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

/// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationAdminPasswordSecretRef
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationAdminSshKey
{
    /// <summary>The Public Key which should be used for authentication, which needs to be in ssh-rsa format with at least 2048-bit or in ssh-ed25519 format.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The Username for which this Public SSH Key should be configured.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationSecretCertificate
{
    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationSecret
{
    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary>A linux_configuration block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfiguration
{
    /// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationAdminPasswordSecretRef? AdminPasswordSecretRef { get; set; }

    /// <summary>A admin_ssh_key block as documented below.</summary>
    [JsonPropertyName("adminSshKey")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationAdminSshKey>? AdminSshKey { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>When an admin_password is specified disable_password_authentication must be set to false. Defaults to true.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the virtual machines that are associated to the Virtual Machine Scale Set. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching of this Windows Virtual Machine. Possible values are Manual, AutomaticByOS and AutomaticByPlatform. Defaults to AutomaticByOS. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationSecret>? Secret { get; set; }
}

/// <summary>The XML formatted content that is added to the unattend.xml file for the specified path and component. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationAdditionalUnattendContentContentSecretRef
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>The XML formatted content that is added to the unattend.xml file for the specified path and component. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("contentSecretRef")]
    public required V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationAdditionalUnattendContentContentSecretRef ContentSecretRef { get; set; }

    /// <summary>The name of the setting to which the content applies. Possible values are AutoLogon and FirstLogonCommands. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("setting")]
    public string? Setting { get; set; }
}

/// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationAdminPasswordSecretRef
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationSecretCertificate
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationSecret
{
    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationWinrmListener
{
    /// <summary>The Secret URL of a Key Vault Certificate, which must be specified when protocol is set to Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary>Specifies the protocol of listener. Possible values are Http or Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>A windows_configuration block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfiguration
{
    /// <summary>One or more additional_unattend_content blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public required V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationAdminPasswordSecretRef AdminPasswordSecretRef { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>Are automatic updates enabled for this Virtual Machine? Defaults to true.</summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Should the VM be patched without requiring a reboot? Possible values are true or false. Defaults to false. For more information about hot patching please see the product documentation.</summary>
    [JsonPropertyName("hotpatchingEnabled")]
    public bool? HotpatchingEnabled { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the virtual machines that are associated to the Virtual Machine Scale Set. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching of this Windows Virtual Machine. Possible values are Manual, AutomaticByOS and AutomaticByPlatform. Defaults to AutomaticByOS. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationSecret>? Secret { get; set; }

    /// <summary>Specifies the time zone of the virtual machine, the possible values are defined here.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>One or more winrm_listener blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("winrmListener")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationWinrmListener>? WinrmListener { get; set; }
}

/// <summary>An os_profile block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfile
{
    /// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("customDataSecretRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileCustomDataSecretRef? CustomDataSecretRef { get; set; }

    /// <summary>A linux_configuration block as documented below.</summary>
    [JsonPropertyName("linuxConfiguration")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary>A windows_configuration block as documented below.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>A plan block as documented below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderPlan
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

/// <summary>a priority_mix block as defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderPriorityMix
{
    /// <summary>Specifies the base number of VMs of Regular priority that will be created before any VMs of priority Spot are created. Possible values are integers between 0 and 1000. Defaults to 0.</summary>
    [JsonPropertyName("baseRegularCount")]
    public double? BaseRegularCount { get; set; }

    /// <summary>Specifies the desired percentage of VM instances that are of Regular priority after the base count has been reached. Possible values are integers between 0 and 100. Defaults to 0.</summary>
    [JsonPropertyName("regularPercentageAboveBase")]
    public double? RegularPercentageAboveBase { get; set; }
}

/// <summary>A rolling_upgrade_policy block as defined below. This is Required when upgrade_mode is set to Rolling and cannot be specified when upgrade_mode is set to Manual. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderRollingUpgradePolicy
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

    /// <summary>The wait time between completing the update for all virtual machines in one batch and starting the next batch. The time duration should be specified in ISO 8601 duration format.</summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary>Upgrade all unhealthy instances in a scale set before any healthy instances. Possible values are true or false.</summary>
    [JsonPropertyName("prioritizeUnhealthyInstancesEnabled")]
    public bool? PrioritizeUnhealthyInstancesEnabled { get; set; }
}

/// <summary>An sku_profile block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderSkuProfile
{
    /// <summary>Specifies the allocation strategy for the virtual machine scale set based on which the VMs will be allocated. Possible values are CapacityOptimized, LowestPrice and Prioritized.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Specifies the VM sizes for the virtual machine scale set.</summary>
    [JsonPropertyName("vmSizes")]
    public IList<string>? VmSizes { get; set; }
}

/// <summary>A source_image_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderSourceImageReference
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

/// <summary>A termination_notification block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine Scale Set? Possible values true or false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderUserDataBase64SecretRef
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecInitProvider
{
    /// <summary>An additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>An automatic_instance_repair block as defined below.</summary>
    [JsonPropertyName("automaticInstanceRepair")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderAutomaticInstanceRepair? AutomaticInstanceRepair { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderBootDiagnostics? BootDiagnostics { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine Scale Set should be allocated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderDataDisk>? DataDisk { get; set; }

    /// <summary>Should disks attached to this Virtual Machine Scale Set be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>The Policy which should be used by Spot Virtual Machines that are Evicted from the Scale Set. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>One or more extension blocks as defined below</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderExtension>? Extension { get; set; }

    /// <summary>Should extension operations be allowed on the Virtual Machine Scale Set? Possible values are true or false. Defaults to true. Changing this forces a new Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("extensionOperationsEnabled")]
    public bool? ExtensionOperationsEnabled { get; set; }

    /// <summary>Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The number of Virtual Machines in the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }

    /// <summary>Specifies the type of on-premise license (also known as Azure Hybrid Use Benefit) which should be used for this Virtual Machine Scale Set. Possible values are None, Windows_Client and Windows_Server.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>The Azure location where the Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you&apos;re willing to pay for each Virtual Machine in this Scale Set, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machines in the Scale Set will be evicted using the eviction_policy. Defaults to -1, which means that each Virtual Machine in the Scale Set should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>Specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations for Virtual Machine Scale Set. Possible values are 2020-11-01 and 2022-11-01. Defaults to 2020-11-01.</summary>
    [JsonPropertyName("networkApiVersion")]
    public string? NetworkApiVersion { get; set; }

    /// <summary>One or more network_interface blocks as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>An os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsDisk? OsDisk { get; set; }

    /// <summary>An os_profile block as defined below.</summary>
    [JsonPropertyName("osProfile")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfile? OsProfile { get; set; }

    /// <summary>A plan block as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderPlan? Plan { get; set; }

    /// <summary>Specifies the number of fault domains that are used by this Virtual Machine Scale Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public double? PlatformFaultDomainCount { get; set; }

    /// <summary>The Priority of this Virtual Machine Scale Set. Possible values are Regular and Spot. Defaults to Regular. Changing this value forces a new resource.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>a priority_mix block as defined below</summary>
    [JsonPropertyName("priorityMix")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderPriorityMix? PriorityMix { get; set; }

    /// <summary>The ID of the Proximity Placement Group which the Virtual Machine should be assigned to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>A rolling_upgrade_policy block as defined below. This is Required when upgrade_mode is set to Rolling and cannot be specified when upgrade_mode is set to Manual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderRollingUpgradePolicy? RollingUpgradePolicy { get; set; }

    /// <summary>Should this Virtual Machine Scale Set be limited to a Single Placement Group, which means the number of instances will be capped at 100 Virtual Machines. Possible values are true or false.</summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>The name of the SKU to be used by this Virtual Machine Scale Set. Valid values include: any of the General purpose, Compute optimized, Memory optimized, Storage optimized, GPU optimized, FPGA optimized, High performance, or Previous generation virtual machine SKUs.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>An sku_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuProfile")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderSkuProfile? SkuProfile { get; set; }

    /// <summary>The ID of an Image which each Virtual Machine in this Scale Set should be based on. Possible Image ID types include Image IDs, Shared Image IDs, Shared Image Version IDs, Community Gallery Image IDs, Community Gallery Image Version IDs, Shared Gallery Image IDs and Shared Gallery Image Version IDs.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below.</summary>
    [JsonPropertyName("sourceImageReference")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderSourceImageReference? SourceImageReference { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderTerminationNotification? TerminationNotification { get; set; }

    /// <summary>Specifies how upgrades (e.g. changing the Image/SKU) should be performed to Virtual Machine Instances. Possible values are Automatic, Manual and Rolling. Defaults to Manual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("userDataBase64SecretRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProviderUserDataBase64SecretRef? UserDataBase64SecretRef { get; set; }

    /// <summary>Should the Virtual Machines in this Scale Set be strictly evenly distributed across Availability Zones? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Specifies a list of Availability Zones across which the Virtual Machine Scale Set will create instances.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecManagementPoliciesEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>OrchestratedVirtualMachineScaleSetSpec defines the desired state of OrchestratedVirtualMachineScaleSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetSpec
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
    public V1beta2OrchestratedVirtualMachineScaleSetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2OrchestratedVirtualMachineScaleSetSpecForProvider ForProvider { get; set; }

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
    public V1beta2OrchestratedVirtualMachineScaleSetSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2OrchestratedVirtualMachineScaleSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2OrchestratedVirtualMachineScaleSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An additional_capabilities block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderAdditionalCapabilities
{
    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine Scale Set? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary>An automatic_instance_repair block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderAutomaticInstanceRepair
{
    /// <summary>The repair action that will be used for repairing unhealthy virtual machines in the scale set. Possible values include Replace, Restart, Reimage.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Should the automatic instance repair be enabled on this Virtual Machine Scale Set? Possible values are true and false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amount of time for which automatic repairs will be delayed. The grace period starts right after the VM is found unhealthy. Possible values are between 10 and 90 minutes. The time duration should be specified in ISO 8601 format (e.g. PT10M to PT90M).</summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary>A boot_diagnostics block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor. By including a boot_diagnostics block without passing the storage_account_uri field will cause the API to utilize a Managed Storage Account to store the Boot Diagnostics output.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderDataDisk
{
    /// <summary>The type of Caching which should be used for this Data Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The create option which should be used for this Data Disk. Possible values are Empty and FromImage. Defaults to Empty. (FromImage should only be used if the source image includes data disks).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt the Data Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The size of the Data Disk which should be created. Required if create_option is specified as Empty.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which must be unique within the Virtual Machine. Required if create_option is specified as Empty.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The Type of Storage Account which should back this Data Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS and UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies the Read-Write IOPS for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskIopsReadWrite")]
    public double? UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>Specifies the bandwidth in MB per second for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskMbpsReadWrite")]
    public double? UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the Data Disk. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>A protected_settings_from_key_vault block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderExtensionProtectedSettingsFromKeyVault
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderExtension
{
    /// <summary>Should the latest version of the Extension be used at Deployment Time, if one is available? This won&apos;t auto-update the extension on existing installation. Defaults to true.</summary>
    [JsonPropertyName("autoUpgradeMinorVersionEnabled")]
    public bool? AutoUpgradeMinorVersionEnabled { get; set; }

    /// <summary>An ordered list of Extension names which Virtual Machine Scale Set should provision after VM creation.</summary>
    [JsonPropertyName("extensionsToProvisionAfterVmCreation")]
    public IList<string>? ExtensionsToProvisionAfterVmCreation { get; set; }

    /// <summary>Should failures from the extension be suppressed? Possible values are true or false.</summary>
    [JsonPropertyName("failureSuppressionEnabled")]
    public bool? FailureSuppressionEnabled { get; set; }

    /// <summary>A value which, when different to the previous value can be used to force-run the Extension even if the Extension Configuration hasn&apos;t changed.</summary>
    [JsonPropertyName("forceExtensionExecutionOnChange")]
    public string? ForceExtensionExecutionOnChange { get; set; }

    /// <summary>The name for the Virtual Machine Scale Set Extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderExtensionProtectedSettingsFromKeyVault? ProtectedSettingsFromKeyVault { get; set; }

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

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Managed Identity IDs to be assigned to this Windows Virtual Machine Scale Set.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of Managed Identity that should be configured on this Windows Virtual Machine Scale Set. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddress
{
    /// <summary>The Prefix which should be used for the Domain Name Label for each Virtual Machine Instance. Azure concatenates the Domain Name Label and Virtual Machine Index to create a unique Domain Name Label for each Virtual Machine. Valid values must be between 1 and 26 characters long, start with a lower case letter, end with a lower case letter or number and contains only a-z, 0-9 and hyphens.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>The Idle Timeout in Minutes for the Public IP Address. Possible values are in the range 4 to 32.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>One or more ip_tag blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTag")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag>? IpTag { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Public IP Address Prefix from where Public IP Addresses should be allocated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>The name of the SKU to be used by this Virtual Machine Scale Set. Valid values include: any of the General purpose, Compute optimized, Memory optimized, Storage optimized, GPU optimized, FPGA optimized, High performance, or Previous generation virtual machine SKUs.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfiguration
{
    /// <summary>A list of Backend Address Pools IDs from a Application Gateway which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPoolIds")]
    public IList<string>? ApplicationGatewayBackendAddressPoolIds { get; set; }

    /// <summary>A list of Application Security Group IDs which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>A list of Backend Address Pools IDs from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolIds")]
    public IList<string>? LoadBalancerBackendAddressPoolIds { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>A public_ip_address block as defined below.</summary>
    [JsonPropertyName("publicIpAddress")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddress>? PublicIpAddress { get; set; }

    /// <summary>The ID of the Subnet which this IP Configuration should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterface
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

    /// <summary>Does this Network Interface support Accelerated Networking? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>Does this Network Interface support IP Forwarding? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("enableIpForwarding")]
    public bool? EnableIpForwarding { get; set; }

    /// <summary>One or more ip_configuration blocks as defined above.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Name which should be used for this Network Interface. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Network Security Group which should be assigned to this Network Interface.</summary>
    [JsonPropertyName("networkSecurityGroupId")]
    public string? NetworkSecurityGroupId { get; set; }

    /// <summary>Is this the Primary IP Configuration? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsDiskDiffDiskSettings
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine Scale Set is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the OS Disk. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfigurationAdminSshKey
{
    /// <summary>The Public Key which should be used for authentication, which needs to be in ssh-rsa format with at least 2048-bit or in ssh-ed25519 format.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The Username for which this Public SSH Key should be configured.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfigurationSecretCertificate
{
    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfigurationSecret
{
    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfigurationSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary>A linux_configuration block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfiguration
{
    /// <summary>A admin_ssh_key block as documented below.</summary>
    [JsonPropertyName("adminSshKey")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfigurationAdminSshKey>? AdminSshKey { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>When an admin_password is specified disable_password_authentication must be set to false. Defaults to true.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the virtual machines that are associated to the Virtual Machine Scale Set. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching of this Windows Virtual Machine. Possible values are Manual, AutomaticByOS and AutomaticByPlatform. Defaults to AutomaticByOS. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfigurationSecret>? Secret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>The name of the setting to which the content applies. Possible values are AutoLogon and FirstLogonCommands. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("setting")]
    public string? Setting { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationSecretCertificate
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
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationSecret
{
    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationWinrmListener
{
    /// <summary>The Secret URL of a Key Vault Certificate, which must be specified when protocol is set to Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary>Specifies the protocol of listener. Possible values are Http or Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>A windows_configuration block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfiguration
{
    /// <summary>One or more additional_unattend_content blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>Are automatic updates enabled for this Virtual Machine? Defaults to true.</summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Should the VM be patched without requiring a reboot? Possible values are true or false. Defaults to false. For more information about hot patching please see the product documentation.</summary>
    [JsonPropertyName("hotpatchingEnabled")]
    public bool? HotpatchingEnabled { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the virtual machines that are associated to the Virtual Machine Scale Set. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching of this Windows Virtual Machine. Possible values are Manual, AutomaticByOS and AutomaticByPlatform. Defaults to AutomaticByOS. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationSecret>? Secret { get; set; }

    /// <summary>Specifies the time zone of the virtual machine, the possible values are defined here.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>One or more winrm_listener blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("winrmListener")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationWinrmListener>? WinrmListener { get; set; }
}

/// <summary>An os_profile block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfile
{
    /// <summary>A linux_configuration block as documented below.</summary>
    [JsonPropertyName("linuxConfiguration")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary>A windows_configuration block as documented below.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>A plan block as documented below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderPlan
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

/// <summary>a priority_mix block as defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderPriorityMix
{
    /// <summary>Specifies the base number of VMs of Regular priority that will be created before any VMs of priority Spot are created. Possible values are integers between 0 and 1000. Defaults to 0.</summary>
    [JsonPropertyName("baseRegularCount")]
    public double? BaseRegularCount { get; set; }

    /// <summary>Specifies the desired percentage of VM instances that are of Regular priority after the base count has been reached. Possible values are integers between 0 and 100. Defaults to 0.</summary>
    [JsonPropertyName("regularPercentageAboveBase")]
    public double? RegularPercentageAboveBase { get; set; }
}

/// <summary>A rolling_upgrade_policy block as defined below. This is Required when upgrade_mode is set to Rolling and cannot be specified when upgrade_mode is set to Manual. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderRollingUpgradePolicy
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

    /// <summary>The wait time between completing the update for all virtual machines in one batch and starting the next batch. The time duration should be specified in ISO 8601 duration format.</summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary>Upgrade all unhealthy instances in a scale set before any healthy instances. Possible values are true or false.</summary>
    [JsonPropertyName("prioritizeUnhealthyInstancesEnabled")]
    public bool? PrioritizeUnhealthyInstancesEnabled { get; set; }
}

/// <summary>An sku_profile block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderSkuProfile
{
    /// <summary>Specifies the allocation strategy for the virtual machine scale set based on which the VMs will be allocated. Possible values are CapacityOptimized, LowestPrice and Prioritized.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Specifies the VM sizes for the virtual machine scale set.</summary>
    [JsonPropertyName("vmSizes")]
    public IList<string>? VmSizes { get; set; }
}

/// <summary>A source_image_reference block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderSourceImageReference
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

/// <summary>A termination_notification block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine Scale Set? Possible values true or false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusAtProvider
{
    /// <summary>An additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>An automatic_instance_repair block as defined below.</summary>
    [JsonPropertyName("automaticInstanceRepair")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderAutomaticInstanceRepair? AutomaticInstanceRepair { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderBootDiagnostics? BootDiagnostics { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine Scale Set should be allocated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderDataDisk>? DataDisk { get; set; }

    /// <summary>Should disks attached to this Virtual Machine Scale Set be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>The Policy which should be used by Spot Virtual Machines that are Evicted from the Scale Set. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>One or more extension blocks as defined below</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderExtension>? Extension { get; set; }

    /// <summary>Should extension operations be allowed on the Virtual Machine Scale Set? Possible values are true or false. Defaults to true. Changing this forces a new Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("extensionOperationsEnabled")]
    public bool? ExtensionOperationsEnabled { get; set; }

    /// <summary>Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>The ID of the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The number of Virtual Machines in the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }

    /// <summary>Specifies the type of on-premise license (also known as Azure Hybrid Use Benefit) which should be used for this Virtual Machine Scale Set. Possible values are None, Windows_Client and Windows_Server.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>The Azure location where the Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you&apos;re willing to pay for each Virtual Machine in this Scale Set, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machines in the Scale Set will be evicted using the eviction_policy. Defaults to -1, which means that each Virtual Machine in the Scale Set should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>Specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations for Virtual Machine Scale Set. Possible values are 2020-11-01 and 2022-11-01. Defaults to 2020-11-01.</summary>
    [JsonPropertyName("networkApiVersion")]
    public string? NetworkApiVersion { get; set; }

    /// <summary>One or more network_interface blocks as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>An os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsDisk? OsDisk { get; set; }

    /// <summary>An os_profile block as defined below.</summary>
    [JsonPropertyName("osProfile")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfile? OsProfile { get; set; }

    /// <summary>A plan block as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderPlan? Plan { get; set; }

    /// <summary>Specifies the number of fault domains that are used by this Virtual Machine Scale Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public double? PlatformFaultDomainCount { get; set; }

    /// <summary>The Priority of this Virtual Machine Scale Set. Possible values are Regular and Spot. Defaults to Regular. Changing this value forces a new resource.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>a priority_mix block as defined below</summary>
    [JsonPropertyName("priorityMix")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderPriorityMix? PriorityMix { get; set; }

    /// <summary>The ID of the Proximity Placement Group which the Virtual Machine should be assigned to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>The name of the Resource Group in which the Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A rolling_upgrade_policy block as defined below. This is Required when upgrade_mode is set to Rolling and cannot be specified when upgrade_mode is set to Manual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderRollingUpgradePolicy? RollingUpgradePolicy { get; set; }

    /// <summary>Should this Virtual Machine Scale Set be limited to a Single Placement Group, which means the number of instances will be capped at 100 Virtual Machines. Possible values are true or false.</summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>The name of the SKU to be used by this Virtual Machine Scale Set. Valid values include: any of the General purpose, Compute optimized, Memory optimized, Storage optimized, GPU optimized, FPGA optimized, High performance, or Previous generation virtual machine SKUs.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>An sku_profile block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuProfile")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderSkuProfile? SkuProfile { get; set; }

    /// <summary>The ID of an Image which each Virtual Machine in this Scale Set should be based on. Possible Image ID types include Image IDs, Shared Image IDs, Shared Image Version IDs, Community Gallery Image IDs, Community Gallery Image Version IDs, Shared Gallery Image IDs and Shared Gallery Image Version IDs.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below.</summary>
    [JsonPropertyName("sourceImageReference")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderSourceImageReference? SourceImageReference { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProviderTerminationNotification? TerminationNotification { get; set; }

    /// <summary>The Unique ID for the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }

    /// <summary>Specifies how upgrades (e.g. changing the Image/SKU) should be performed to Virtual Machine Instances. Possible values are Automatic, Manual and Rolling. Defaults to Manual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>Should the Virtual Machines in this Scale Set be strictly evenly distributed across Availability Zones? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Specifies a list of Availability Zones across which the Virtual Machine Scale Set will create instances.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatusConditions
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

/// <summary>OrchestratedVirtualMachineScaleSetStatus defines the observed state of OrchestratedVirtualMachineScaleSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrchestratedVirtualMachineScaleSetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2OrchestratedVirtualMachineScaleSetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OrchestratedVirtualMachineScaleSet is the Schema for the OrchestratedVirtualMachineScaleSets API. Manages an Virtual Machine Scale Set in Flexible Orchestration Mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2OrchestratedVirtualMachineScaleSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2OrchestratedVirtualMachineScaleSetSpec>, IStatus<V1beta2OrchestratedVirtualMachineScaleSetStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "OrchestratedVirtualMachineScaleSet";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "orchestratedvirtualmachinescalesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OrchestratedVirtualMachineScaleSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OrchestratedVirtualMachineScaleSetSpec defines the desired state of OrchestratedVirtualMachineScaleSet</summary>
    [JsonPropertyName("spec")]
    public required V1beta2OrchestratedVirtualMachineScaleSetSpec Spec { get; set; }

    /// <summary>OrchestratedVirtualMachineScaleSetStatus defines the observed state of OrchestratedVirtualMachineScaleSet.</summary>
    [JsonPropertyName("status")]
    public V1beta2OrchestratedVirtualMachineScaleSetStatus? Status { get; set; }
}