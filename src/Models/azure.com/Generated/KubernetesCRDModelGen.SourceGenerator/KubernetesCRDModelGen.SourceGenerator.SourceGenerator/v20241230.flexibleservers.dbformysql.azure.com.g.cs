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
/// - Generated from: /mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2024-12-30/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20241230FlexibleServerList : IKubernetesObject<V1ListMeta>, IItems<V20241230FlexibleServer>
{
    public const string KubeApiVersion = "v20241230";
    public const string KubeKind = "FlexibleServerList";
    public const string KubeGroup = "dbformysql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbformysql.azure.com/v20241230";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20241230FlexibleServer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20241230FlexibleServer> Items { get; set; }
}

/// <summary>AdministratorLoginPassword: The password of the administrator login (required for server creation).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecAdministratorLoginPassword
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecBackupGeoRedundantBackupEnum>))]
public enum V20241230FlexibleServerSpecBackupGeoRedundantBackupEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Backup: Backup related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecBackup
{
    /// <summary>BackupIntervalHours: Backup interval hours for the server.</summary>
    [JsonPropertyName("backupIntervalHours")]
    public int? BackupIntervalHours { get; set; }

    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>GeoRedundantBackup: Whether or not geo redundant backup is enabled.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public V20241230FlexibleServerSpecBackupGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }
}

/// <summary>CreateMode: The mode to create a new MySQL server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecCreateModeEnum>))]
public enum V20241230FlexibleServerSpecCreateModeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecDataEncryptionGeoBackupUserAssignedIdentityReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecDataEncryptionPrimaryUserAssignedIdentityReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecDataEncryptionTypeEnum>))]
public enum V20241230FlexibleServerSpecDataEncryptionTypeEnum
{
    [EnumMember(Value = "AzureKeyVault"), JsonStringEnumMemberName("AzureKeyVault")]
    AzureKeyVault,
    [EnumMember(Value = "SystemManaged"), JsonStringEnumMemberName("SystemManaged")]
    SystemManaged
}

/// <summary>DataEncryption: The Data Encryption for CMK.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecDataEncryption
{
    /// <summary>GeoBackupKeyURI: Geo backup key uri as key vault can&apos;t cross region, need cmk in same region as geo backup</summary>
    [JsonPropertyName("geoBackupKeyURI")]
    public string? GeoBackupKeyURI { get; set; }

    /// <summary>
    /// GeoBackupUserAssignedIdentityReference: Geo backup user identity resource id as identity can&apos;t cross region, need
    /// identity in same region as geo backup
    /// </summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityReference")]
    public V20241230FlexibleServerSpecDataEncryptionGeoBackupUserAssignedIdentityReference? GeoBackupUserAssignedIdentityReference { get; set; }

    /// <summary>PrimaryKeyURI: Primary key uri</summary>
    [JsonPropertyName("primaryKeyURI")]
    public string? PrimaryKeyURI { get; set; }

    /// <summary>PrimaryUserAssignedIdentityReference: Primary user identity resource id</summary>
    [JsonPropertyName("primaryUserAssignedIdentityReference")]
    public V20241230FlexibleServerSpecDataEncryptionPrimaryUserAssignedIdentityReference? PrimaryUserAssignedIdentityReference { get; set; }

    /// <summary>Type: The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
    [JsonPropertyName("type")]
    public V20241230FlexibleServerSpecDataEncryptionTypeEnum? Type { get; set; }
}

/// <summary>Mode: High availability mode for a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecHighAvailabilityModeEnum>))]
public enum V20241230FlexibleServerSpecHighAvailabilityModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "SameZone"), JsonStringEnumMemberName("SameZone")]
    SameZone,
    [EnumMember(Value = "ZoneRedundant"), JsonStringEnumMemberName("ZoneRedundant")]
    ZoneRedundant
}

/// <summary>HighAvailability: High availability related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecHighAvailability
{
    /// <summary>Mode: High availability mode for a server.</summary>
    [JsonPropertyName("mode")]
    public V20241230FlexibleServerSpecHighAvailabilityModeEnum? Mode { get; set; }

    /// <summary>StandbyAvailabilityZone: Availability zone of the standby server.</summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }
}

/// <summary>Type: Type of managed service identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecIdentityTypeEnum>))]
public enum V20241230FlexibleServerSpecIdentityTypeEnum
{
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecIdentityUserAssignedIdentitiesReference
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
public partial class V20241230FlexibleServerSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20241230FlexibleServerSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The cmk identity for the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecIdentity
{
    /// <summary>Type: Type of managed service identity.</summary>
    [JsonPropertyName("type")]
    public V20241230FlexibleServerSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentities: Metadata of user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20241230FlexibleServerSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>SasToken: Sas token for accessing source storage. Read and list permissions are required for sas token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecImportSourcePropertiesSasToken
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecImportSourcePropertiesStorageTypeEnum>))]
public enum V20241230FlexibleServerSpecImportSourcePropertiesStorageTypeEnum
{
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob
}

/// <summary>ImportSourceProperties: Source properties for import from storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecImportSourceProperties
{
    /// <summary>DataDirPath: Relative path of data directory in storage.</summary>
    [JsonPropertyName("dataDirPath")]
    public string? DataDirPath { get; set; }

    /// <summary>SasToken: Sas token for accessing source storage. Read and list permissions are required for sas token.</summary>
    [JsonPropertyName("sasToken")]
    public V20241230FlexibleServerSpecImportSourcePropertiesSasToken? SasToken { get; set; }

    /// <summary>StorageType: Storage type of import source.</summary>
    [JsonPropertyName("storageType")]
    public V20241230FlexibleServerSpecImportSourcePropertiesStorageTypeEnum? StorageType { get; set; }

    /// <summary>StorageUrl: Uri of the import source storage.</summary>
    [JsonPropertyName("storageUrl")]
    public string? StorageUrl { get; set; }
}

/// <summary>PatchStrategy: The patch strategy of this server</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecMaintenancePolicyPatchStrategyEnum>))]
public enum V20241230FlexibleServerSpecMaintenancePolicyPatchStrategyEnum
{
    [EnumMember(Value = "Regular"), JsonStringEnumMemberName("Regular")]
    Regular,
    [EnumMember(Value = "VirtualCanary"), JsonStringEnumMemberName("VirtualCanary")]
    VirtualCanary
}

/// <summary>MaintenancePolicy: Maintenance policy of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecMaintenancePolicy
{
    /// <summary>PatchStrategy: The patch strategy of this server</summary>
    [JsonPropertyName("patchStrategy")]
    public V20241230FlexibleServerSpecMaintenancePolicyPatchStrategyEnum? PatchStrategy { get; set; }
}

/// <summary>BatchOfMaintenance: The batch of maintenance when enabled the custom managed maintenance window of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecMaintenanceWindowBatchOfMaintenanceEnum>))]
public enum V20241230FlexibleServerSpecMaintenanceWindowBatchOfMaintenanceEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecMaintenanceWindow
{
    /// <summary>BatchOfMaintenance: The batch of maintenance when enabled the custom managed maintenance window of a server.</summary>
    [JsonPropertyName("batchOfMaintenance")]
    public V20241230FlexibleServerSpecMaintenanceWindowBatchOfMaintenanceEnum? BatchOfMaintenance { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecNetworkDelegatedSubnetResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecNetworkPrivateDnsZoneResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecNetworkPublicNetworkAccessEnum>))]
public enum V20241230FlexibleServerSpecNetworkPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Network: Network related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecNetwork
{
    /// <summary>DelegatedSubnetResourceReference: Delegated subnet resource id used to setup vnet for a server.</summary>
    [JsonPropertyName("delegatedSubnetResourceReference")]
    public V20241230FlexibleServerSpecNetworkDelegatedSubnetResourceReference? DelegatedSubnetResourceReference { get; set; }

    /// <summary>PrivateDnsZoneResourceReference: Private DNS zone resource id.</summary>
    [JsonPropertyName("privateDnsZoneResourceReference")]
    public V20241230FlexibleServerSpecNetworkPrivateDnsZoneResourceReference? PrivateDnsZoneResourceReference { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public network access is allowed for this server. Value is &apos;Disabled&apos; when server
    /// has VNet integration.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V20241230FlexibleServerSpecNetworkPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecOperatorSpecConfigMapsAdministratorLogin
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName
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
public partial class V20241230FlexibleServerSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// AdministratorLogin: indicates where the AdministratorLogin config map should be placed. If omitted, no config map will
    /// be created.
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public V20241230FlexibleServerSpecOperatorSpecConfigMapsAdministratorLogin? AdministratorLogin { get; set; }

    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName config map should be placed. If omitted, no
    /// config map will be created.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V20241230FlexibleServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecOperatorSpecSecrets
{
    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V20241230FlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20241230FlexibleServerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V20241230FlexibleServerSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20241230FlexibleServerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V20241230FlexibleServerSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ReplicationRole: The replication role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecReplicationRoleEnum>))]
public enum V20241230FlexibleServerSpecReplicationRoleEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Replica"), JsonStringEnumMemberName("Replica")]
    Replica,
    [EnumMember(Value = "Source"), JsonStringEnumMemberName("Source")]
    Source
}

/// <summary>Tier: The tier of the particular SKU, e.g. GeneralPurpose.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecSkuTierEnum>))]
public enum V20241230FlexibleServerSpecSkuTierEnum
{
    [EnumMember(Value = "Burstable"), JsonStringEnumMemberName("Burstable")]
    Burstable,
    [EnumMember(Value = "GeneralPurpose"), JsonStringEnumMemberName("GeneralPurpose")]
    GeneralPurpose,
    [EnumMember(Value = "MemoryOptimized"), JsonStringEnumMemberName("MemoryOptimized")]
    MemoryOptimized
}

/// <summary>Sku: The SKU (pricing tier) of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecSku
{
    /// <summary>Name: The name of the sku, e.g. Standard_D32s_v3.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Tier: The tier of the particular SKU, e.g. GeneralPurpose.</summary>
    [JsonPropertyName("tier")]
    public required V20241230FlexibleServerSpecSkuTierEnum Tier { get; set; }
}

/// <summary>SourceServerResourceReference: The source MySQL server id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecSourceServerResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecStorageAutoGrowEnum>))]
public enum V20241230FlexibleServerSpecStorageAutoGrowEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>AutoIoScaling: Enable IO Auto Scaling or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecStorageAutoIoScalingEnum>))]
public enum V20241230FlexibleServerSpecStorageAutoIoScalingEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>LogOnDisk: Enable Log On Disk or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecStorageLogOnDiskEnum>))]
public enum V20241230FlexibleServerSpecStorageLogOnDiskEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>StorageRedundancy: The redundant type of the server storage. The parameter is used for server creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241230FlexibleServerSpecStorageStorageRedundancyEnum>))]
public enum V20241230FlexibleServerSpecStorageStorageRedundancyEnum
{
    [EnumMember(Value = "LocalRedundancy"), JsonStringEnumMemberName("LocalRedundancy")]
    LocalRedundancy,
    [EnumMember(Value = "ZoneRedundancy"), JsonStringEnumMemberName("ZoneRedundancy")]
    ZoneRedundancy
}

/// <summary>Storage: Storage related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpecStorage
{
    /// <summary>AutoGrow: Enable Storage Auto Grow or not.</summary>
    [JsonPropertyName("autoGrow")]
    public V20241230FlexibleServerSpecStorageAutoGrowEnum? AutoGrow { get; set; }

    /// <summary>AutoIoScaling: Enable IO Auto Scaling or not.</summary>
    [JsonPropertyName("autoIoScaling")]
    public V20241230FlexibleServerSpecStorageAutoIoScalingEnum? AutoIoScaling { get; set; }

    /// <summary>Iops: Storage IOPS for a server.</summary>
    [JsonPropertyName("iops")]
    public int? Iops { get; set; }

    /// <summary>LogOnDisk: Enable Log On Disk or not.</summary>
    [JsonPropertyName("logOnDisk")]
    public V20241230FlexibleServerSpecStorageLogOnDiskEnum? LogOnDisk { get; set; }

    /// <summary>StorageRedundancy: The redundant type of the server storage. The parameter is used for server creation.</summary>
    [JsonPropertyName("storageRedundancy")]
    public V20241230FlexibleServerSpecStorageStorageRedundancyEnum? StorageRedundancy { get; set; }

    /// <summary>StorageSizeGB: Max storage size allowed for a server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerSpec
{
    /// <summary>
    /// AdministratorLogin: The administrator&apos;s login name of a server. Can only be specified when the server is being created
    /// (and is required for creation).
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>AdministratorLoginPassword: The password of the administrator login (required for server creation).</summary>
    [JsonPropertyName("administratorLoginPassword")]
    public V20241230FlexibleServerSpecAdministratorLoginPassword? AdministratorLoginPassword { get; set; }

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
    public V20241230FlexibleServerSpecBackup? Backup { get; set; }

    /// <summary>CreateMode: The mode to create a new MySQL server.</summary>
    [JsonPropertyName("createMode")]
    public V20241230FlexibleServerSpecCreateModeEnum? CreateMode { get; set; }

    /// <summary>DataEncryption: The Data Encryption for CMK.</summary>
    [JsonPropertyName("dataEncryption")]
    public V20241230FlexibleServerSpecDataEncryption? DataEncryption { get; set; }

    /// <summary>DatabasePort: The server database port. Can only be specified when the server is being created.</summary>
    [JsonPropertyName("databasePort")]
    public int? DatabasePort { get; set; }

    /// <summary>HighAvailability: High availability related properties of a server.</summary>
    [JsonPropertyName("highAvailability")]
    public V20241230FlexibleServerSpecHighAvailability? HighAvailability { get; set; }

    /// <summary>Identity: The cmk identity for the server.</summary>
    [JsonPropertyName("identity")]
    public V20241230FlexibleServerSpecIdentity? Identity { get; set; }

    /// <summary>ImportSourceProperties: Source properties for import from storage.</summary>
    [JsonPropertyName("importSourceProperties")]
    public V20241230FlexibleServerSpecImportSourceProperties? ImportSourceProperties { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MaintenancePolicy: Maintenance policy of a server.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V20241230FlexibleServerSpecMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>
    /// MaintenanceWindow: Maintenance window of a server. Known issue: cannot be set during server creation or updated with
    /// other properties during server update; must be updated separately.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public V20241230FlexibleServerSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>Network: Network related properties of a server.</summary>
    [JsonPropertyName("network")]
    public V20241230FlexibleServerSpecNetwork? Network { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20241230FlexibleServerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20241230FlexibleServerSpecOwner Owner { get; set; }

    /// <summary>ReplicationRole: The replication role.</summary>
    [JsonPropertyName("replicationRole")]
    public V20241230FlexibleServerSpecReplicationRoleEnum? ReplicationRole { get; set; }

    /// <summary>RestorePointInTime: Restore point creation time (ISO8601 format), specifying the time to restore from.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>Sku: The SKU (pricing tier) of the server.</summary>
    [JsonPropertyName("sku")]
    public V20241230FlexibleServerSpecSku? Sku { get; set; }

    /// <summary>SourceServerResourceReference: The source MySQL server id.</summary>
    [JsonPropertyName("sourceServerResourceReference")]
    public V20241230FlexibleServerSpecSourceServerResourceReference? SourceServerResourceReference { get; set; }

    /// <summary>Storage: Storage related properties of a server.</summary>
    [JsonPropertyName("storage")]
    public V20241230FlexibleServerSpecStorage? Storage { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Version: Major version of MySQL. 8.0.21 stands for MySQL 8.0, 5.7.44 stands for MySQL 5.7</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Backup: Backup related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusBackup
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusDataEncryption
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusHighAvailability
{
    /// <summary>Mode: High availability mode for a server.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>StandbyAvailabilityZone: Availability zone of the standby server.</summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }

    /// <summary>State: The state of server high availability.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Metadata of user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: Client Id of user assigned identity</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: Principal Id of user assigned identity</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The cmk identity for the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusIdentity
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
    public IDictionary<string, V20241230FlexibleServerStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>ImportSourceProperties: Source properties for import from storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusImportSourceProperties
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusMaintenancePolicy
{
    /// <summary>PatchStrategy: The patch strategy of this server</summary>
    [JsonPropertyName("patchStrategy")]
    public string? PatchStrategy { get; set; }
}

/// <summary>
/// MaintenanceWindow: Maintenance window of a server. Known issue: cannot be set during server creation or updated with
/// other properties during server update; must be updated separately.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusMaintenanceWindow
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusNetwork
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Sku: The SKU (pricing tier) of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusSku
{
    /// <summary>Name: The name of the sku, e.g. Standard_D32s_v3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: The tier of the particular SKU, e.g. GeneralPurpose.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage: Storage related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusStorage
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241230FlexibleServerStatus
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
    public V20241230FlexibleServerStatusBackup? Backup { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20241230FlexibleServerStatusConditions>? Conditions { get; set; }

    /// <summary>CreateMode: The mode to create a new MySQL server.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>DataEncryption: The Data Encryption for CMK.</summary>
    [JsonPropertyName("dataEncryption")]
    public V20241230FlexibleServerStatusDataEncryption? DataEncryption { get; set; }

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
    public V20241230FlexibleServerStatusHighAvailability? HighAvailability { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The cmk identity for the server.</summary>
    [JsonPropertyName("identity")]
    public V20241230FlexibleServerStatusIdentity? Identity { get; set; }

    /// <summary>ImportSourceProperties: Source properties for import from storage.</summary>
    [JsonPropertyName("importSourceProperties")]
    public V20241230FlexibleServerStatusImportSourceProperties? ImportSourceProperties { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaintenancePolicy: Maintenance policy of a server.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V20241230FlexibleServerStatusMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>
    /// MaintenanceWindow: Maintenance window of a server. Known issue: cannot be set during server creation or updated with
    /// other properties during server update; must be updated separately.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public V20241230FlexibleServerStatusMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Network: Network related properties of a server.</summary>
    [JsonPropertyName("network")]
    public V20241230FlexibleServerStatusNetwork? Network { get; set; }

    /// <summary>PrivateEndpointConnections: PrivateEndpointConnections related properties of a server.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V20241230FlexibleServerStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

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
    public V20241230FlexibleServerStatusSku? Sku { get; set; }

    /// <summary>SourceServerResourceId: The source MySQL server id.</summary>
    [JsonPropertyName("sourceServerResourceId")]
    public string? SourceServerResourceId { get; set; }

    /// <summary>State: The state of a server.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Storage: Storage related properties of a server.</summary>
    [JsonPropertyName("storage")]
    public V20241230FlexibleServerStatusStorage? Storage { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20241230FlexibleServerStatusSystemData? SystemData { get; set; }

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
/// - Generated from: /mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2024-12-30/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20241230FlexibleServer : IKubernetesObject<V1ObjectMeta>, ISpec<V20241230FlexibleServerSpec?>, IStatus<V20241230FlexibleServerStatus?>
{
    public const string KubeApiVersion = "v20241230";
    public const string KubeKind = "FlexibleServer";
    public const string KubeGroup = "dbformysql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbformysql.azure.com/v20241230";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20241230FlexibleServerSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20241230FlexibleServerStatus? Status { get; set; }
}