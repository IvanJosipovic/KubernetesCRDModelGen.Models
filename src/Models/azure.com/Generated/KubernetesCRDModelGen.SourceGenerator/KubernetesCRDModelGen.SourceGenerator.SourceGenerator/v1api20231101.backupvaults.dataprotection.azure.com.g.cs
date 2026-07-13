#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataprotection.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/DataProtection/stable/2023-11-01/dataprotection.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231101BackupVaultList : IKubernetesObject<V1ListMeta>, IItems<V1api20231101BackupVault>
{
    public const string KubeApiVersion = "v1api20231101";
    public const string KubeKind = "BackupVaultList";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaults";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataprotection.azure.com/v1api20231101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupVaultList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20231101BackupVault objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20231101BackupVault> Items { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20231101BackupVaultSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Input Managed Identity Details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecIdentity
{
    /// <summary>Type: The identityType which can be either SystemAssigned, UserAssigned, &apos;SystemAssigned,UserAssigned&apos; or None</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: Gets or sets the user assigned identities.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20231101BackupVaultSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>PrincipalId: indicates where the PrincipalId config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecOperatorSpecConfigMapsPrincipalId
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecOperatorSpecConfigMaps
{
    /// <summary>PrincipalId: indicates where the PrincipalId config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("principalId")]
    public V1api20231101BackupVaultSpecOperatorSpecConfigMapsPrincipalId? PrincipalId { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231101BackupVaultSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20231101BackupVaultSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231101BackupVaultSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>State: CrossRegionRestore state</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultSpecPropertiesFeatureSettingsCrossRegionRestoreSettingsStateEnum>))]
public enum V1api20231101BackupVaultSpecPropertiesFeatureSettingsCrossRegionRestoreSettingsStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecPropertiesFeatureSettingsCrossRegionRestoreSettings
{
    /// <summary>State: CrossRegionRestore state</summary>
    [JsonPropertyName("state")]
    public V1api20231101BackupVaultSpecPropertiesFeatureSettingsCrossRegionRestoreSettingsStateEnum? State { get; set; }
}

/// <summary>State: CrossSubscriptionRestore state</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultSpecPropertiesFeatureSettingsCrossSubscriptionRestoreSettingsStateEnum>))]
public enum V1api20231101BackupVaultSpecPropertiesFeatureSettingsCrossSubscriptionRestoreSettingsStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "PermanentlyDisabled"), JsonStringEnumMemberName("PermanentlyDisabled")]
    PermanentlyDisabled
}

/// <summary>CrossSubscriptionRestoreSettings: CrossSubscriptionRestore Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecPropertiesFeatureSettingsCrossSubscriptionRestoreSettings
{
    /// <summary>State: CrossSubscriptionRestore state</summary>
    [JsonPropertyName("state")]
    public V1api20231101BackupVaultSpecPropertiesFeatureSettingsCrossSubscriptionRestoreSettingsStateEnum? State { get; set; }
}

/// <summary>FeatureSettings: Feature Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecPropertiesFeatureSettings
{
    [JsonPropertyName("crossRegionRestoreSettings")]
    public V1api20231101BackupVaultSpecPropertiesFeatureSettingsCrossRegionRestoreSettings? CrossRegionRestoreSettings { get; set; }

    /// <summary>CrossSubscriptionRestoreSettings: CrossSubscriptionRestore Settings</summary>
    [JsonPropertyName("crossSubscriptionRestoreSettings")]
    public V1api20231101BackupVaultSpecPropertiesFeatureSettingsCrossSubscriptionRestoreSettings? CrossSubscriptionRestoreSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultSpecPropertiesMonitoringSettingsAzureMonitorAlertSettingsAlertsForAllJobFailuresEnum>))]
public enum V1api20231101BackupVaultSpecPropertiesMonitoringSettingsAzureMonitorAlertSettingsAlertsForAllJobFailuresEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>AzureMonitorAlertSettings: Settings for Azure Monitor based alerts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecPropertiesMonitoringSettingsAzureMonitorAlertSettings
{
    [JsonPropertyName("alertsForAllJobFailures")]
    public V1api20231101BackupVaultSpecPropertiesMonitoringSettingsAzureMonitorAlertSettingsAlertsForAllJobFailuresEnum? AlertsForAllJobFailures { get; set; }
}

/// <summary>MonitoringSettings: Monitoring Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecPropertiesMonitoringSettings
{
    /// <summary>AzureMonitorAlertSettings: Settings for Azure Monitor based alerts</summary>
    [JsonPropertyName("azureMonitorAlertSettings")]
    public V1api20231101BackupVaultSpecPropertiesMonitoringSettingsAzureMonitorAlertSettings? AzureMonitorAlertSettings { get; set; }
}

/// <summary>State: Immutability state</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultSpecPropertiesSecuritySettingsImmutabilitySettingsStateEnum>))]
public enum V1api20231101BackupVaultSpecPropertiesSecuritySettingsImmutabilitySettingsStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Locked"), JsonStringEnumMemberName("Locked")]
    Locked,
    [EnumMember(Value = "Unlocked"), JsonStringEnumMemberName("Unlocked")]
    Unlocked
}

/// <summary>ImmutabilitySettings: Immutability Settings at vault level</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecPropertiesSecuritySettingsImmutabilitySettings
{
    /// <summary>State: Immutability state</summary>
    [JsonPropertyName("state")]
    public V1api20231101BackupVaultSpecPropertiesSecuritySettingsImmutabilitySettingsStateEnum? State { get; set; }
}

/// <summary>State: State of soft delete</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultSpecPropertiesSecuritySettingsSoftDeleteSettingsStateEnum>))]
public enum V1api20231101BackupVaultSpecPropertiesSecuritySettingsSoftDeleteSettingsStateEnum
{
    [EnumMember(Value = "AlwaysOn"), JsonStringEnumMemberName("AlwaysOn")]
    AlwaysOn,
    [EnumMember(Value = "Off"), JsonStringEnumMemberName("Off")]
    Off,
    [EnumMember(Value = "On"), JsonStringEnumMemberName("On")]
    On
}

/// <summary>SoftDeleteSettings: Soft delete related settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecPropertiesSecuritySettingsSoftDeleteSettings
{
    /// <summary>RetentionDurationInDays: Soft delete retention duration</summary>
    [JsonPropertyName("retentionDurationInDays")]
    public double? RetentionDurationInDays { get; set; }

    /// <summary>State: State of soft delete</summary>
    [JsonPropertyName("state")]
    public V1api20231101BackupVaultSpecPropertiesSecuritySettingsSoftDeleteSettingsStateEnum? State { get; set; }
}

/// <summary>SecuritySettings: Security Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecPropertiesSecuritySettings
{
    /// <summary>ImmutabilitySettings: Immutability Settings at vault level</summary>
    [JsonPropertyName("immutabilitySettings")]
    public V1api20231101BackupVaultSpecPropertiesSecuritySettingsImmutabilitySettings? ImmutabilitySettings { get; set; }

    /// <summary>SoftDeleteSettings: Soft delete related settings</summary>
    [JsonPropertyName("softDeleteSettings")]
    public V1api20231101BackupVaultSpecPropertiesSecuritySettingsSoftDeleteSettings? SoftDeleteSettings { get; set; }
}

/// <summary>DatastoreType: Gets or sets the type of the datastore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultSpecPropertiesStorageSettingsDatastoreTypeEnum>))]
public enum V1api20231101BackupVaultSpecPropertiesStorageSettingsDatastoreTypeEnum
{
    [EnumMember(Value = "ArchiveStore"), JsonStringEnumMemberName("ArchiveStore")]
    ArchiveStore,
    [EnumMember(Value = "OperationalStore"), JsonStringEnumMemberName("OperationalStore")]
    OperationalStore,
    [EnumMember(Value = "VaultStore"), JsonStringEnumMemberName("VaultStore")]
    VaultStore
}

/// <summary>Type: Gets or sets the type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultSpecPropertiesStorageSettingsTypeEnum>))]
public enum V1api20231101BackupVaultSpecPropertiesStorageSettingsTypeEnum
{
    [EnumMember(Value = "GeoRedundant"), JsonStringEnumMemberName("GeoRedundant")]
    GeoRedundant,
    [EnumMember(Value = "LocallyRedundant"), JsonStringEnumMemberName("LocallyRedundant")]
    LocallyRedundant,
    [EnumMember(Value = "ZoneRedundant"), JsonStringEnumMemberName("ZoneRedundant")]
    ZoneRedundant
}

/// <summary>Storage setting</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecPropertiesStorageSettings
{
    /// <summary>DatastoreType: Gets or sets the type of the datastore.</summary>
    [JsonPropertyName("datastoreType")]
    public V1api20231101BackupVaultSpecPropertiesStorageSettingsDatastoreTypeEnum? DatastoreType { get; set; }

    /// <summary>Type: Gets or sets the type.</summary>
    [JsonPropertyName("type")]
    public V1api20231101BackupVaultSpecPropertiesStorageSettingsTypeEnum? Type { get; set; }
}

/// <summary>Properties: BackupVaultResource properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpecProperties
{
    /// <summary>FeatureSettings: Feature Settings</summary>
    [JsonPropertyName("featureSettings")]
    public V1api20231101BackupVaultSpecPropertiesFeatureSettings? FeatureSettings { get; set; }

    /// <summary>MonitoringSettings: Monitoring Settings</summary>
    [JsonPropertyName("monitoringSettings")]
    public V1api20231101BackupVaultSpecPropertiesMonitoringSettings? MonitoringSettings { get; set; }

    /// <summary>ReplicatedRegions: List of replicated regions for Backup Vault</summary>
    [JsonPropertyName("replicatedRegions")]
    public IList<string>? ReplicatedRegions { get; set; }

    /// <summary>SecuritySettings: Security Settings</summary>
    [JsonPropertyName("securitySettings")]
    public V1api20231101BackupVaultSpecPropertiesSecuritySettings? SecuritySettings { get; set; }

    /// <summary>StorageSettings: Storage Settings</summary>
    [JsonPropertyName("storageSettings")]
    public required IList<V1api20231101BackupVaultSpecPropertiesStorageSettings> StorageSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Identity: Input Managed Identity Details</summary>
    [JsonPropertyName("identity")]
    public V1api20231101BackupVaultSpecIdentity? Identity { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231101BackupVaultSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20231101BackupVaultSpecOwner Owner { get; set; }

    /// <summary>Properties: BackupVaultResource properties</summary>
    [JsonPropertyName("properties")]
    public required V1api20231101BackupVaultSpecProperties Properties { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>User assigned identity properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client ID of the assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID of the assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: Input Managed Identity Details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusIdentity
{
    /// <summary>
    /// PrincipalId: The object ID of the service principal object for the managed identity that is used to grant role-based
    /// access to an Azure resource.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: A Globally Unique Identifier (GUID) that represents the Azure AD tenant where the resource is now a member.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The identityType which can be either SystemAssigned, UserAssigned, &apos;SystemAssigned,UserAssigned&apos; or None</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: Gets or sets the user assigned identities.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20231101BackupVaultStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusPropertiesFeatureSettingsCrossRegionRestoreSettings
{
    /// <summary>State: CrossRegionRestore state</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>CrossSubscriptionRestoreSettings: CrossSubscriptionRestore Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusPropertiesFeatureSettingsCrossSubscriptionRestoreSettings
{
    /// <summary>State: CrossSubscriptionRestore state</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>FeatureSettings: Feature Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusPropertiesFeatureSettings
{
    [JsonPropertyName("crossRegionRestoreSettings")]
    public V1api20231101BackupVaultStatusPropertiesFeatureSettingsCrossRegionRestoreSettings? CrossRegionRestoreSettings { get; set; }

    /// <summary>CrossSubscriptionRestoreSettings: CrossSubscriptionRestore Settings</summary>
    [JsonPropertyName("crossSubscriptionRestoreSettings")]
    public V1api20231101BackupVaultStatusPropertiesFeatureSettingsCrossSubscriptionRestoreSettings? CrossSubscriptionRestoreSettings { get; set; }
}

/// <summary>AzureMonitorAlertSettings: Settings for Azure Monitor based alerts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusPropertiesMonitoringSettingsAzureMonitorAlertSettings
{
    [JsonPropertyName("alertsForAllJobFailures")]
    public string? AlertsForAllJobFailures { get; set; }
}

/// <summary>MonitoringSettings: Monitoring Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusPropertiesMonitoringSettings
{
    /// <summary>AzureMonitorAlertSettings: Settings for Azure Monitor based alerts</summary>
    [JsonPropertyName("azureMonitorAlertSettings")]
    public V1api20231101BackupVaultStatusPropertiesMonitoringSettingsAzureMonitorAlertSettings? AzureMonitorAlertSettings { get; set; }
}

/// <summary>ResourceMoveDetails: Resource move details for backup vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusPropertiesResourceMoveDetails
{
    /// <summary>CompletionTimeUtc: Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.</summary>
    [JsonPropertyName("completionTimeUtc")]
    public string? CompletionTimeUtc { get; set; }

    /// <summary>OperationId: CorrelationId of latest ResourceMove operation attempted</summary>
    [JsonPropertyName("operationId")]
    public string? OperationId { get; set; }

    /// <summary>SourceResourcePath: ARM resource path of source resource</summary>
    [JsonPropertyName("sourceResourcePath")]
    public string? SourceResourcePath { get; set; }

    /// <summary>StartTimeUtc: Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.</summary>
    [JsonPropertyName("startTimeUtc")]
    public string? StartTimeUtc { get; set; }

    /// <summary>TargetResourcePath: ARM resource path of target resource used in latest ResourceMove operation</summary>
    [JsonPropertyName("targetResourcePath")]
    public string? TargetResourcePath { get; set; }
}

/// <summary>ImmutabilitySettings: Immutability Settings at vault level</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusPropertiesSecuritySettingsImmutabilitySettings
{
    /// <summary>State: Immutability state</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>SoftDeleteSettings: Soft delete related settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusPropertiesSecuritySettingsSoftDeleteSettings
{
    /// <summary>RetentionDurationInDays: Soft delete retention duration</summary>
    [JsonPropertyName("retentionDurationInDays")]
    public double? RetentionDurationInDays { get; set; }

    /// <summary>State: State of soft delete</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>SecuritySettings: Security Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusPropertiesSecuritySettings
{
    /// <summary>ImmutabilitySettings: Immutability Settings at vault level</summary>
    [JsonPropertyName("immutabilitySettings")]
    public V1api20231101BackupVaultStatusPropertiesSecuritySettingsImmutabilitySettings? ImmutabilitySettings { get; set; }

    /// <summary>SoftDeleteSettings: Soft delete related settings</summary>
    [JsonPropertyName("softDeleteSettings")]
    public V1api20231101BackupVaultStatusPropertiesSecuritySettingsSoftDeleteSettings? SoftDeleteSettings { get; set; }
}

/// <summary>Storage setting</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusPropertiesStorageSettings
{
    /// <summary>DatastoreType: Gets or sets the type of the datastore.</summary>
    [JsonPropertyName("datastoreType")]
    public string? DatastoreType { get; set; }

    /// <summary>Type: Gets or sets the type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Properties: BackupVaultResource properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusProperties
{
    /// <summary>FeatureSettings: Feature Settings</summary>
    [JsonPropertyName("featureSettings")]
    public V1api20231101BackupVaultStatusPropertiesFeatureSettings? FeatureSettings { get; set; }

    /// <summary>IsVaultProtectedByResourceGuard: Is vault protected by resource guard</summary>
    [JsonPropertyName("isVaultProtectedByResourceGuard")]
    public bool? IsVaultProtectedByResourceGuard { get; set; }

    /// <summary>MonitoringSettings: Monitoring Settings</summary>
    [JsonPropertyName("monitoringSettings")]
    public V1api20231101BackupVaultStatusPropertiesMonitoringSettings? MonitoringSettings { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the BackupVault resource</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ReplicatedRegions: List of replicated regions for Backup Vault</summary>
    [JsonPropertyName("replicatedRegions")]
    public IList<string>? ReplicatedRegions { get; set; }

    /// <summary>ResourceMoveDetails: Resource move details for backup vault</summary>
    [JsonPropertyName("resourceMoveDetails")]
    public V1api20231101BackupVaultStatusPropertiesResourceMoveDetails? ResourceMoveDetails { get; set; }

    /// <summary>ResourceMoveState: Resource move state for backup vault</summary>
    [JsonPropertyName("resourceMoveState")]
    public string? ResourceMoveState { get; set; }

    /// <summary>SecureScore: Secure Score of Backup Vault</summary>
    [JsonPropertyName("secureScore")]
    public string? SecureScore { get; set; }

    /// <summary>SecuritySettings: Security Settings</summary>
    [JsonPropertyName("securitySettings")]
    public V1api20231101BackupVaultStatusPropertiesSecuritySettings? SecuritySettings { get; set; }

    /// <summary>StorageSettings: Storage Settings</summary>
    [JsonPropertyName("storageSettings")]
    public IList<V1api20231101BackupVaultStatusPropertiesStorageSettings>? StorageSettings { get; set; }
}

/// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Backup Vault Resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231101BackupVaultStatusConditions>? Conditions { get; set; }

    /// <summary>ETag: Optional ETag.</summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>Id: Resource Id represents the complete path to the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Input Managed Identity Details</summary>
    [JsonPropertyName("identity")]
    public V1api20231101BackupVaultStatusIdentity? Identity { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name associated with the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: BackupVaultResource properties</summary>
    [JsonPropertyName("properties")]
    public V1api20231101BackupVaultStatusProperties? Properties { get; set; }

    /// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20231101BackupVaultStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/DataProtection/stable/2023-11-01/dataprotection.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231101BackupVault : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231101BackupVaultSpec?>, IStatus<V1api20231101BackupVaultStatus?>
{
    public const string KubeApiVersion = "v1api20231101";
    public const string KubeKind = "BackupVault";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaults";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataprotection.azure.com/v1api20231101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupVault";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20231101BackupVaultSpec? Spec { get; set; }

    /// <summary>Backup Vault Resource</summary>
    [JsonPropertyName("status")]
    public V1api20231101BackupVaultStatus? Status { get; set; }
}