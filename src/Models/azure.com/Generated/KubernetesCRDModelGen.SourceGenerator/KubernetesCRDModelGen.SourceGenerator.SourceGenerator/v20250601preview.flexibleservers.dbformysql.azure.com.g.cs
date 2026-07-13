#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dbformysql.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2025-06-01-preview/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250601previewFlexibleServerList : IKubernetesObject<V1ListMeta>, IItems<V20250601previewFlexibleServer>
{
    public const string KubeApiVersion = "v20250601preview";
    public const string KubeKind = "FlexibleServerList";
    public const string KubeGroup = "dbformysql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbformysql.azure.com/v20250601preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250601previewFlexibleServer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250601previewFlexibleServer> Items { get; set; }
}

/// <summary>AdministratorLoginPassword: The password of the administrator login (required for server creation).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecAdministratorLoginPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>GeoRedundantBackup: Whether or not geo redundant backup is enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecBackupGeoRedundantBackupEnum>))]
public enum V20250601previewFlexibleServerSpecBackupGeoRedundantBackupEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Backup: Backup related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecBackup
{
    /// <summary>BackupIntervalHours: Backup interval hours for the server.</summary>
    [JsonPropertyName("backupIntervalHours")]
    public int? BackupIntervalHours { get; set; }

    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>GeoRedundantBackup: Whether or not geo redundant backup is enabled.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public V20250601previewFlexibleServerSpecBackupGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }
}

/// <summary>CreateMode: The mode to create a new MySQL server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecCreateModeEnum>))]
public enum V20250601previewFlexibleServerSpecCreateModeEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "GeoRestore"), JsonStringEnumMemberName("GeoRestore")]
    GeoRestore,
    [EnumMember(Value = "PointInTimeRestore"), JsonStringEnumMemberName("PointInTimeRestore")]
    PointInTimeRestore,
    [EnumMember(Value = "Replica"), JsonStringEnumMemberName("Replica")]
    Replica
}

/// <summary>
/// GeoBackupUserAssignedIdentityReference: Geo backup user identity resource id as identity can&apos;t cross region, need
/// identity in same region as geo backup
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecDataEncryptionGeoBackupUserAssignedIdentityReference
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

/// <summary>PrimaryUserAssignedIdentityReference: Primary user identity resource id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecDataEncryptionPrimaryUserAssignedIdentityReference
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

/// <summary>Type: The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecDataEncryptionTypeEnum>))]
public enum V20250601previewFlexibleServerSpecDataEncryptionTypeEnum
{
    [EnumMember(Value = "AzureKeyVault"), JsonStringEnumMemberName("AzureKeyVault")]
    AzureKeyVault,
    [EnumMember(Value = "SystemManaged"), JsonStringEnumMemberName("SystemManaged")]
    SystemManaged
}

/// <summary>DataEncryption: The Data Encryption for CMK.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecDataEncryption
{
    /// <summary>GeoBackupKeyURI: Geo backup key uri as key vault can&apos;t cross region, need cmk in same region as geo backup</summary>
    [JsonPropertyName("geoBackupKeyURI")]
    public string? GeoBackupKeyURI { get; set; }

    /// <summary>
    /// GeoBackupUserAssignedIdentityReference: Geo backup user identity resource id as identity can&apos;t cross region, need
    /// identity in same region as geo backup
    /// </summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityReference")]
    public V20250601previewFlexibleServerSpecDataEncryptionGeoBackupUserAssignedIdentityReference? GeoBackupUserAssignedIdentityReference { get; set; }

    /// <summary>PrimaryKeyURI: Primary key uri</summary>
    [JsonPropertyName("primaryKeyURI")]
    public string? PrimaryKeyURI { get; set; }

    /// <summary>PrimaryUserAssignedIdentityReference: Primary user identity resource id</summary>
    [JsonPropertyName("primaryUserAssignedIdentityReference")]
    public V20250601previewFlexibleServerSpecDataEncryptionPrimaryUserAssignedIdentityReference? PrimaryUserAssignedIdentityReference { get; set; }

    /// <summary>Type: The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
    [JsonPropertyName("type")]
    public V20250601previewFlexibleServerSpecDataEncryptionTypeEnum? Type { get; set; }
}

/// <summary>Mode: High availability mode for a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecHighAvailabilityModeEnum>))]
public enum V20250601previewFlexibleServerSpecHighAvailabilityModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "SameZone"), JsonStringEnumMemberName("SameZone")]
    SameZone,
    [EnumMember(Value = "ZoneRedundant"), JsonStringEnumMemberName("ZoneRedundant")]
    ZoneRedundant
}

/// <summary>ReplicationMode: HA Replication mode for a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecHighAvailabilityReplicationModeEnum>))]
public enum V20250601previewFlexibleServerSpecHighAvailabilityReplicationModeEnum
{
    [EnumMember(Value = "BinaryLog"), JsonStringEnumMemberName("BinaryLog")]
    BinaryLog,
    [EnumMember(Value = "RedoLog"), JsonStringEnumMemberName("RedoLog")]
    RedoLog
}

/// <summary>HighAvailability: High availability related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecHighAvailability
{
    /// <summary>Mode: High availability mode for a server.</summary>
    [JsonPropertyName("mode")]
    public V20250601previewFlexibleServerSpecHighAvailabilityModeEnum? Mode { get; set; }

    /// <summary>ReplicationMode: HA Replication mode for a server.</summary>
    [JsonPropertyName("replicationMode")]
    public V20250601previewFlexibleServerSpecHighAvailabilityReplicationModeEnum? ReplicationMode { get; set; }

    /// <summary>StandbyAvailabilityZone: Availability zone of the standby server.</summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }
}

/// <summary>Type: Type of managed service identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecIdentityTypeEnum>))]
public enum V20250601previewFlexibleServerSpecIdentityTypeEnum
{
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecIdentityUserAssignedIdentitiesReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250601previewFlexibleServerSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The cmk identity for the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecIdentity
{
    /// <summary>Type: Type of managed service identity.</summary>
    [JsonPropertyName("type")]
    public V20250601previewFlexibleServerSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentities: Metadata of user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20250601previewFlexibleServerSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>SasToken: Sas token for accessing source storage. Read and list permissions are required for sas token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecImportSourcePropertiesSasToken
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>StorageType: Storage type of import source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecImportSourcePropertiesStorageTypeEnum>))]
public enum V20250601previewFlexibleServerSpecImportSourcePropertiesStorageTypeEnum
{
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob
}

/// <summary>ImportSourceProperties: Source properties for import from storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecImportSourceProperties
{
    /// <summary>DataDirPath: Relative path of data directory in storage.</summary>
    [JsonPropertyName("dataDirPath")]
    public string? DataDirPath { get; set; }

    /// <summary>SasToken: Sas token for accessing source storage. Read and list permissions are required for sas token.</summary>
    [JsonPropertyName("sasToken")]
    public V20250601previewFlexibleServerSpecImportSourcePropertiesSasToken? SasToken { get; set; }

    /// <summary>StorageType: Storage type of import source.</summary>
    [JsonPropertyName("storageType")]
    public V20250601previewFlexibleServerSpecImportSourcePropertiesStorageTypeEnum? StorageType { get; set; }

    /// <summary>StorageUrl: Uri of the import source storage.</summary>
    [JsonPropertyName("storageUrl")]
    public string? StorageUrl { get; set; }
}

/// <summary>PatchStrategy: The patch strategy of this server</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecMaintenancePolicyPatchStrategyEnum>))]
public enum V20250601previewFlexibleServerSpecMaintenancePolicyPatchStrategyEnum
{
    [EnumMember(Value = "Regular"), JsonStringEnumMemberName("Regular")]
    Regular,
    [EnumMember(Value = "VirtualCanary"), JsonStringEnumMemberName("VirtualCanary")]
    VirtualCanary
}

/// <summary>MaintenancePolicy: Maintenance policy of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecMaintenancePolicy
{
    /// <summary>PatchStrategy: The patch strategy of this server</summary>
    [JsonPropertyName("patchStrategy")]
    public V20250601previewFlexibleServerSpecMaintenancePolicyPatchStrategyEnum? PatchStrategy { get; set; }
}

/// <summary>BatchOfMaintenance: The batch of maintenance when enabled the custom managed maintenance window of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecMaintenanceWindowBatchOfMaintenanceEnum>))]
public enum V20250601previewFlexibleServerSpecMaintenanceWindowBatchOfMaintenanceEnum
{
    [EnumMember(Value = "Batch1"), JsonStringEnumMemberName("Batch1")]
    Batch1,
    [EnumMember(Value = "Batch2"), JsonStringEnumMemberName("Batch2")]
    Batch2,
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default
}

/// <summary>
/// MaintenanceWindow: Maintenance window of a server. Known issue: cannot be set during server creation or updated with
/// other properties during server update; must be updated separately.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecMaintenanceWindow
{
    /// <summary>BatchOfMaintenance: The batch of maintenance when enabled the custom managed maintenance window of a server.</summary>
    [JsonPropertyName("batchOfMaintenance")]
    public V20250601previewFlexibleServerSpecMaintenanceWindowBatchOfMaintenanceEnum? BatchOfMaintenance { get; set; }

    /// <summary>CustomWindow: indicates whether custom window is enabled or disabled</summary>
    [JsonPropertyName("customWindow")]
    public string? CustomWindow { get; set; }

    /// <summary>DayOfWeek: day of week for maintenance window</summary>
    [JsonPropertyName("dayOfWeek")]
    public int? DayOfWeek { get; set; }

    /// <summary>StartHour: start hour for maintenance window</summary>
    [JsonPropertyName("startHour")]
    public int? StartHour { get; set; }

    /// <summary>StartMinute: start minute for maintenance window</summary>
    [JsonPropertyName("startMinute")]
    public int? StartMinute { get; set; }
}

/// <summary>DelegatedSubnetResourceReference: Delegated subnet resource id used to setup vnet for a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecNetworkDelegatedSubnetResourceReference
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

/// <summary>PrivateDnsZoneResourceReference: Private DNS zone resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecNetworkPrivateDnsZoneResourceReference
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

/// <summary>
/// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is &apos;Disabled&apos; when server
/// has VNet integration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecNetworkPublicNetworkAccessEnum>))]
public enum V20250601previewFlexibleServerSpecNetworkPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Network: Network related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecNetwork
{
    /// <summary>DelegatedSubnetResourceReference: Delegated subnet resource id used to setup vnet for a server.</summary>
    [JsonPropertyName("delegatedSubnetResourceReference")]
    public V20250601previewFlexibleServerSpecNetworkDelegatedSubnetResourceReference? DelegatedSubnetResourceReference { get; set; }

    /// <summary>PrivateDnsZoneResourceReference: Private DNS zone resource id.</summary>
    [JsonPropertyName("privateDnsZoneResourceReference")]
    public V20250601previewFlexibleServerSpecNetworkPrivateDnsZoneResourceReference? PrivateDnsZoneResourceReference { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is &apos;Disabled&apos; when server
    /// has VNet integration.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V20250601previewFlexibleServerSpecNetworkPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecOperatorSpecConfigMapExpressions
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
/// AdministratorLogin: indicates where the AdministratorLogin config map should be placed. If omitted, no config map will
/// be created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecOperatorSpecConfigMapsAdministratorLogin
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

/// <summary>
/// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName config map should be placed. If omitted, no
/// config map will be created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// AdministratorLogin: indicates where the AdministratorLogin config map should be placed. If omitted, no config map will
    /// be created.
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public V20250601previewFlexibleServerSpecOperatorSpecConfigMapsAdministratorLogin? AdministratorLogin { get; set; }

    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName config map should be placed. If omitted, no
    /// config map will be created.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V20250601previewFlexibleServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecOperatorSpecSecretExpressions
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
/// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Secrets: configures where to place Azure generated secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecOperatorSpecSecrets
{
    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V20250601previewFlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250601previewFlexibleServerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V20250601previewFlexibleServerSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250601previewFlexibleServerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V20250601previewFlexibleServerSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ReplicationRole: The replication role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecReplicationRoleEnum>))]
public enum V20250601previewFlexibleServerSpecReplicationRoleEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Replica"), JsonStringEnumMemberName("Replica")]
    Replica,
    [EnumMember(Value = "Source"), JsonStringEnumMemberName("Source")]
    Source
}

/// <summary>Tier: The tier of the particular SKU, e.g. GeneralPurpose.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecSkuTierEnum>))]
public enum V20250601previewFlexibleServerSpecSkuTierEnum
{
    [EnumMember(Value = "Burstable"), JsonStringEnumMemberName("Burstable")]
    Burstable,
    [EnumMember(Value = "GeneralPurpose"), JsonStringEnumMemberName("GeneralPurpose")]
    GeneralPurpose,
    [EnumMember(Value = "MemoryOptimized"), JsonStringEnumMemberName("MemoryOptimized")]
    MemoryOptimized
}

/// <summary>Sku: The SKU (pricing tier) of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecSku
{
    /// <summary>Name: The name of the sku, e.g. Standard_D32s_v3.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Tier: The tier of the particular SKU, e.g. GeneralPurpose.</summary>
    [JsonPropertyName("tier")]
    public required V20250601previewFlexibleServerSpecSkuTierEnum Tier { get; set; }
}

/// <summary>SourceServerResourceReference: The source MySQL server id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecSourceServerResourceReference
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

/// <summary>AutoGrow: Enable Storage Auto Grow or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecStorageAutoGrowEnum>))]
public enum V20250601previewFlexibleServerSpecStorageAutoGrowEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>AutoIoScaling: Enable IO Auto Scaling or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecStorageAutoIoScalingEnum>))]
public enum V20250601previewFlexibleServerSpecStorageAutoIoScalingEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>LogOnDisk: Enable Log On Disk or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecStorageLogOnDiskEnum>))]
public enum V20250601previewFlexibleServerSpecStorageLogOnDiskEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>StorageRedundancy: The redundant type of the server storage. The parameter is used for server creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601previewFlexibleServerSpecStorageStorageRedundancyEnum>))]
public enum V20250601previewFlexibleServerSpecStorageStorageRedundancyEnum
{
    [EnumMember(Value = "LocalRedundancy"), JsonStringEnumMemberName("LocalRedundancy")]
    LocalRedundancy,
    [EnumMember(Value = "ZoneRedundancy"), JsonStringEnumMemberName("ZoneRedundancy")]
    ZoneRedundancy
}

/// <summary>Storage: Storage related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpecStorage
{
    /// <summary>AutoGrow: Enable Storage Auto Grow or not.</summary>
    [JsonPropertyName("autoGrow")]
    public V20250601previewFlexibleServerSpecStorageAutoGrowEnum? AutoGrow { get; set; }

    /// <summary>AutoIoScaling: Enable IO Auto Scaling or not.</summary>
    [JsonPropertyName("autoIoScaling")]
    public V20250601previewFlexibleServerSpecStorageAutoIoScalingEnum? AutoIoScaling { get; set; }

    /// <summary>Iops: Storage IOPS for a server.</summary>
    [JsonPropertyName("iops")]
    public int? Iops { get; set; }

    /// <summary>LogOnDisk: Enable Log On Disk or not.</summary>
    [JsonPropertyName("logOnDisk")]
    public V20250601previewFlexibleServerSpecStorageLogOnDiskEnum? LogOnDisk { get; set; }

    /// <summary>StorageRedundancy: The redundant type of the server storage. The parameter is used for server creation.</summary>
    [JsonPropertyName("storageRedundancy")]
    public V20250601previewFlexibleServerSpecStorageStorageRedundancyEnum? StorageRedundancy { get; set; }

    /// <summary>StorageSizeGB: Max storage size allowed for a server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerSpec
{
    /// <summary>
    /// AdministratorLogin: The administrator&apos;s login name of a server. Can only be specified when the server is being created
    /// (and is required for creation).
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>AdministratorLoginPassword: The password of the administrator login (required for server creation).</summary>
    [JsonPropertyName("administratorLoginPassword")]
    public V20250601previewFlexibleServerSpecAdministratorLoginPassword? AdministratorLoginPassword { get; set; }

    /// <summary>AvailabilityZone: availability Zone information of the server.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Backup: Backup related properties of a server.</summary>
    [JsonPropertyName("backup")]
    public V20250601previewFlexibleServerSpecBackup? Backup { get; set; }

    /// <summary>CreateMode: The mode to create a new MySQL server.</summary>
    [JsonPropertyName("createMode")]
    public V20250601previewFlexibleServerSpecCreateModeEnum? CreateMode { get; set; }

    /// <summary>DataEncryption: The Data Encryption for CMK.</summary>
    [JsonPropertyName("dataEncryption")]
    public V20250601previewFlexibleServerSpecDataEncryption? DataEncryption { get; set; }

    /// <summary>DatabasePort: The server database port. Can only be specified when the server is being created.</summary>
    [JsonPropertyName("databasePort")]
    public int? DatabasePort { get; set; }

    /// <summary>HighAvailability: High availability related properties of a server.</summary>
    [JsonPropertyName("highAvailability")]
    public V20250601previewFlexibleServerSpecHighAvailability? HighAvailability { get; set; }

    /// <summary>Identity: The cmk identity for the server.</summary>
    [JsonPropertyName("identity")]
    public V20250601previewFlexibleServerSpecIdentity? Identity { get; set; }

    /// <summary>ImportSourceProperties: Source properties for import from storage.</summary>
    [JsonPropertyName("importSourceProperties")]
    public V20250601previewFlexibleServerSpecImportSourceProperties? ImportSourceProperties { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// LowerCaseTableNames: The mysql parameter lower_case_table_names. Can only be specified when the server is being created.
    /// Allowed values 1 or 2.
    /// </summary>
    [JsonPropertyName("lowerCaseTableNames")]
    public int? LowerCaseTableNames { get; set; }

    /// <summary>MaintenancePolicy: Maintenance policy of a server.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V20250601previewFlexibleServerSpecMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>
    /// MaintenanceWindow: Maintenance window of a server. Known issue: cannot be set during server creation or updated with
    /// other properties during server update; must be updated separately.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public V20250601previewFlexibleServerSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>Network: Network related properties of a server.</summary>
    [JsonPropertyName("network")]
    public V20250601previewFlexibleServerSpecNetwork? Network { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250601previewFlexibleServerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250601previewFlexibleServerSpecOwner Owner { get; set; }

    /// <summary>ReplicationRole: The replication role.</summary>
    [JsonPropertyName("replicationRole")]
    public V20250601previewFlexibleServerSpecReplicationRoleEnum? ReplicationRole { get; set; }

    /// <summary>RestorePointInTime: Restore point creation time (ISO8601 format), specifying the time to restore from.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>Sku: The SKU (pricing tier) of the server.</summary>
    [JsonPropertyName("sku")]
    public V20250601previewFlexibleServerSpecSku? Sku { get; set; }

    /// <summary>SourceServerResourceReference: The source MySQL server id.</summary>
    [JsonPropertyName("sourceServerResourceReference")]
    public V20250601previewFlexibleServerSpecSourceServerResourceReference? SourceServerResourceReference { get; set; }

    /// <summary>Storage: Storage related properties of a server.</summary>
    [JsonPropertyName("storage")]
    public V20250601previewFlexibleServerSpecStorage? Storage { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Version: Major version of MySQL. 8.0.21 stands for MySQL 8.0, 5.7.44 stands for MySQL 5.7</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Backup: Backup related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusBackup
{
    /// <summary>BackupIntervalHours: Backup interval hours for the server.</summary>
    [JsonPropertyName("backupIntervalHours")]
    public int? BackupIntervalHours { get; set; }

    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>EarliestRestoreDate: Earliest restore point creation time (ISO8601 format)</summary>
    [JsonPropertyName("earliestRestoreDate")]
    public string? EarliestRestoreDate { get; set; }

    /// <summary>GeoRedundantBackup: Whether or not geo redundant backup is enabled.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public string? GeoRedundantBackup { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusConditions
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

/// <summary>DataEncryption: The Data Encryption for CMK.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusDataEncryption
{
    /// <summary>GeoBackupKeyURI: Geo backup key uri as key vault can&apos;t cross region, need cmk in same region as geo backup</summary>
    [JsonPropertyName("geoBackupKeyURI")]
    public string? GeoBackupKeyURI { get; set; }

    /// <summary>
    /// GeoBackupUserAssignedIdentityId: Geo backup user identity resource id as identity can&apos;t cross region, need identity in
    /// same region as geo backup
    /// </summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityId")]
    public string? GeoBackupUserAssignedIdentityId { get; set; }

    /// <summary>PrimaryKeyURI: Primary key uri</summary>
    [JsonPropertyName("primaryKeyURI")]
    public string? PrimaryKeyURI { get; set; }

    /// <summary>PrimaryUserAssignedIdentityId: Primary user identity resource id</summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }

    /// <summary>Type: The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>HighAvailability: High availability related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusHighAvailability
{
    /// <summary>Mode: High availability mode for a server.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>ReplicationMode: HA Replication mode for a server.</summary>
    [JsonPropertyName("replicationMode")]
    public string? ReplicationMode { get; set; }

    /// <summary>StandbyAvailabilityZone: Availability zone of the standby server.</summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }

    /// <summary>State: The state of server high availability.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Metadata of user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: Client Id of user assigned identity</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: Principal Id of user assigned identity</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The cmk identity for the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusIdentity
{
    /// <summary>PrincipalId: ObjectId from the KeyVault</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: TenantId from the KeyVault</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of managed service identity.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: Metadata of user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20250601previewFlexibleServerStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>ImportSourceProperties: Source properties for import from storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusImportSourceProperties
{
    /// <summary>DataDirPath: Relative path of data directory in storage.</summary>
    [JsonPropertyName("dataDirPath")]
    public string? DataDirPath { get; set; }

    /// <summary>StorageType: Storage type of import source.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>StorageUrl: Uri of the import source storage.</summary>
    [JsonPropertyName("storageUrl")]
    public string? StorageUrl { get; set; }
}

/// <summary>MaintenancePolicy: Maintenance policy of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusMaintenancePolicy
{
    /// <summary>PatchStrategy: The patch strategy of this server</summary>
    [JsonPropertyName("patchStrategy")]
    public string? PatchStrategy { get; set; }
}

/// <summary>
/// MaintenanceWindow: Maintenance window of a server. Known issue: cannot be set during server creation or updated with
/// other properties during server update; must be updated separately.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusMaintenanceWindow
{
    /// <summary>BatchOfMaintenance: The batch of maintenance when enabled the custom managed maintenance window of a server.</summary>
    [JsonPropertyName("batchOfMaintenance")]
    public string? BatchOfMaintenance { get; set; }

    /// <summary>CustomWindow: indicates whether custom window is enabled or disabled</summary>
    [JsonPropertyName("customWindow")]
    public string? CustomWindow { get; set; }

    /// <summary>DayOfWeek: day of week for maintenance window</summary>
    [JsonPropertyName("dayOfWeek")]
    public int? DayOfWeek { get; set; }

    /// <summary>StartHour: start hour for maintenance window</summary>
    [JsonPropertyName("startHour")]
    public int? StartHour { get; set; }

    /// <summary>StartMinute: start minute for maintenance window</summary>
    [JsonPropertyName("startMinute")]
    public int? StartMinute { get; set; }
}

/// <summary>Network: Network related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusNetwork
{
    /// <summary>DelegatedSubnetResourceId: Delegated subnet resource id used to setup vnet for a server.</summary>
    [JsonPropertyName("delegatedSubnetResourceId")]
    public string? DelegatedSubnetResourceId { get; set; }

    /// <summary>PrivateDnsZoneResourceId: Private DNS zone resource id.</summary>
    [JsonPropertyName("privateDnsZoneResourceId")]
    public string? PrivateDnsZoneResourceId { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is &apos;Disabled&apos; when server
    /// has VNet integration.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }
}

/// <summary>The private endpoint connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Sku: The SKU (pricing tier) of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusSku
{
    /// <summary>Name: The name of the sku, e.g. Standard_D32s_v3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: The tier of the particular SKU, e.g. GeneralPurpose.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage: Storage related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusStorage
{
    /// <summary>AutoGrow: Enable Storage Auto Grow or not.</summary>
    [JsonPropertyName("autoGrow")]
    public string? AutoGrow { get; set; }

    /// <summary>AutoIoScaling: Enable IO Auto Scaling or not.</summary>
    [JsonPropertyName("autoIoScaling")]
    public string? AutoIoScaling { get; set; }

    /// <summary>Iops: Storage IOPS for a server.</summary>
    [JsonPropertyName("iops")]
    public int? Iops { get; set; }

    /// <summary>LogOnDisk: Enable Log On Disk or not.</summary>
    [JsonPropertyName("logOnDisk")]
    public string? LogOnDisk { get; set; }

    /// <summary>StorageRedundancy: The redundant type of the server storage. The parameter is used for server creation.</summary>
    [JsonPropertyName("storageRedundancy")]
    public string? StorageRedundancy { get; set; }

    /// <summary>StorageSizeGB: Max storage size allowed for a server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }

    /// <summary>StorageSku: The sku name of the server storage.</summary>
    [JsonPropertyName("storageSku")]
    public string? StorageSku { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601previewFlexibleServerStatus
{
    /// <summary>
    /// AdministratorLogin: The administrator&apos;s login name of a server. Can only be specified when the server is being created
    /// (and is required for creation).
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>AvailabilityZone: availability Zone information of the server.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Backup: Backup related properties of a server.</summary>
    [JsonPropertyName("backup")]
    public V20250601previewFlexibleServerStatusBackup? Backup { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250601previewFlexibleServerStatusConditions>? Conditions { get; set; }

    /// <summary>CreateMode: The mode to create a new MySQL server.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>DataEncryption: The Data Encryption for CMK.</summary>
    [JsonPropertyName("dataEncryption")]
    public V20250601previewFlexibleServerStatusDataEncryption? DataEncryption { get; set; }

    /// <summary>DatabasePort: The server database port. Can only be specified when the server is being created.</summary>
    [JsonPropertyName("databasePort")]
    public int? DatabasePort { get; set; }

    /// <summary>FullVersion: Major version and actual engine version</summary>
    [JsonPropertyName("fullVersion")]
    public string? FullVersion { get; set; }

    /// <summary>FullyQualifiedDomainName: The fully qualified domain name of a server.</summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public string? FullyQualifiedDomainName { get; set; }

    /// <summary>HighAvailability: High availability related properties of a server.</summary>
    [JsonPropertyName("highAvailability")]
    public V20250601previewFlexibleServerStatusHighAvailability? HighAvailability { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The cmk identity for the server.</summary>
    [JsonPropertyName("identity")]
    public V20250601previewFlexibleServerStatusIdentity? Identity { get; set; }

    /// <summary>ImportSourceProperties: Source properties for import from storage.</summary>
    [JsonPropertyName("importSourceProperties")]
    public V20250601previewFlexibleServerStatusImportSourceProperties? ImportSourceProperties { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// LowerCaseTableNames: The mysql parameter lower_case_table_names. Can only be specified when the server is being created.
    /// Allowed values 1 or 2.
    /// </summary>
    [JsonPropertyName("lowerCaseTableNames")]
    public int? LowerCaseTableNames { get; set; }

    /// <summary>MaintenancePolicy: Maintenance policy of a server.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V20250601previewFlexibleServerStatusMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>
    /// MaintenanceWindow: Maintenance window of a server. Known issue: cannot be set during server creation or updated with
    /// other properties during server update; must be updated separately.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public V20250601previewFlexibleServerStatusMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Network: Network related properties of a server.</summary>
    [JsonPropertyName("network")]
    public V20250601previewFlexibleServerStatusNetwork? Network { get; set; }

    /// <summary>PrivateEndpointConnections: PrivateEndpointConnections related properties of a server.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V20250601previewFlexibleServerStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ReplicaCapacity: The maximum number of replicas that a primary server can have.</summary>
    [JsonPropertyName("replicaCapacity")]
    public int? ReplicaCapacity { get; set; }

    /// <summary>ReplicationRole: The replication role.</summary>
    [JsonPropertyName("replicationRole")]
    public string? ReplicationRole { get; set; }

    /// <summary>RestorePointInTime: Restore point creation time (ISO8601 format), specifying the time to restore from.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>Sku: The SKU (pricing tier) of the server.</summary>
    [JsonPropertyName("sku")]
    public V20250601previewFlexibleServerStatusSku? Sku { get; set; }

    /// <summary>SourceServerResourceId: The source MySQL server id.</summary>
    [JsonPropertyName("sourceServerResourceId")]
    public string? SourceServerResourceId { get; set; }

    /// <summary>State: The state of a server.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Storage: Storage related properties of a server.</summary>
    [JsonPropertyName("storage")]
    public V20250601previewFlexibleServerStatusStorage? Storage { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20250601previewFlexibleServerStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Version: Major version of MySQL. 8.0.21 stands for MySQL 8.0, 5.7.44 stands for MySQL 5.7</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/preview/2025-06-01-preview/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250601previewFlexibleServer : IKubernetesObject<V1ObjectMeta>, ISpec<V20250601previewFlexibleServerSpec?>, IStatus<V20250601previewFlexibleServerStatus?>
{
    public const string KubeApiVersion = "v20250601preview";
    public const string KubeKind = "FlexibleServer";
    public const string KubeGroup = "dbformysql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbformysql.azure.com/v20250601preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250601previewFlexibleServerSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20250601previewFlexibleServerStatus? Status { get; set; }
}