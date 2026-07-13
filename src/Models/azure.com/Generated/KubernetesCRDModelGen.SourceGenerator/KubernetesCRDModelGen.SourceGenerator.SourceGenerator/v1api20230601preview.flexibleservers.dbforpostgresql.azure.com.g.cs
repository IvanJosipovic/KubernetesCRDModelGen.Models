#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dbforpostgresql.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /postgresql/resource-manager/Microsoft.DBforPostgreSQL/preview/2023-06-01-preview/FlexibleServers.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230601previewFlexibleServerList : IKubernetesObject<V1ListMeta>, IItems<V1api20230601previewFlexibleServer>
{
    public const string KubeApiVersion = "v1api20230601preview";
    public const string KubeKind = "FlexibleServerList";
    public const string KubeGroup = "dbforpostgresql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbforpostgresql.azure.com/v1api20230601preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230601previewFlexibleServer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230601previewFlexibleServer> Items { get; set; }
}

/// <summary>AdministratorLoginPassword: The administrator login password (required for server creation).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecAdministratorLoginPassword
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

/// <summary>ActiveDirectoryAuth: If Enabled, Azure Active Directory authentication is enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecAuthConfigActiveDirectoryAuthEnum>))]
public enum V1api20230601previewFlexibleServerSpecAuthConfigActiveDirectoryAuthEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>PasswordAuth: If Enabled, Password authentication is enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecAuthConfigPasswordAuthEnum>))]
public enum V1api20230601previewFlexibleServerSpecAuthConfigPasswordAuthEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>AuthConfig: AuthConfig properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecAuthConfig
{
    /// <summary>ActiveDirectoryAuth: If Enabled, Azure Active Directory authentication is enabled.</summary>
    [JsonPropertyName("activeDirectoryAuth")]
    public V1api20230601previewFlexibleServerSpecAuthConfigActiveDirectoryAuthEnum? ActiveDirectoryAuth { get; set; }

    /// <summary>PasswordAuth: If Enabled, Password authentication is enabled.</summary>
    [JsonPropertyName("passwordAuth")]
    public V1api20230601previewFlexibleServerSpecAuthConfigPasswordAuthEnum? PasswordAuth { get; set; }

    /// <summary>TenantId: Tenant id of the server.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>GeoRedundantBackup: A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecBackupGeoRedundantBackupEnum>))]
public enum V1api20230601previewFlexibleServerSpecBackupGeoRedundantBackupEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Backup: Backup properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecBackup
{
    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>GeoRedundantBackup: A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public V1api20230601previewFlexibleServerSpecBackupGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }
}

/// <summary>CreateMode: The mode to create a new PostgreSQL server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecCreateModeEnum>))]
public enum V1api20230601previewFlexibleServerSpecCreateModeEnum
{
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "GeoRestore"), JsonStringEnumMemberName("GeoRestore")]
    GeoRestore,
    [EnumMember(Value = "PointInTimeRestore"), JsonStringEnumMemberName("PointInTimeRestore")]
    PointInTimeRestore,
    [EnumMember(Value = "Replica"), JsonStringEnumMemberName("Replica")]
    Replica,
    [EnumMember(Value = "ReviveDropped"), JsonStringEnumMemberName("ReviveDropped")]
    ReviveDropped,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update
}

/// <summary>GeoBackupEncryptionKeyStatus: Geo-backup encryption key status for Data encryption enabled server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecDataEncryptionGeoBackupEncryptionKeyStatusEnum>))]
public enum V1api20230601previewFlexibleServerSpecDataEncryptionGeoBackupEncryptionKeyStatusEnum
{
    [EnumMember(Value = "Invalid"), JsonStringEnumMemberName("Invalid")]
    Invalid,
    [EnumMember(Value = "Valid"), JsonStringEnumMemberName("Valid")]
    Valid
}

/// <summary>GeoBackupKeyURIFromConfig: URI for the key in keyvault for data encryption for geo-backup of server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecDataEncryptionGeoBackupKeyURIFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// GeoBackupUserAssignedIdentityReference: Resource Id for the User assigned identity to be used for data encryption for
/// geo-backup of server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecDataEncryptionGeoBackupUserAssignedIdentityReference
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

/// <summary>PrimaryEncryptionKeyStatus: Primary encryption key status for Data encryption enabled server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecDataEncryptionPrimaryEncryptionKeyStatusEnum>))]
public enum V1api20230601previewFlexibleServerSpecDataEncryptionPrimaryEncryptionKeyStatusEnum
{
    [EnumMember(Value = "Invalid"), JsonStringEnumMemberName("Invalid")]
    Invalid,
    [EnumMember(Value = "Valid"), JsonStringEnumMemberName("Valid")]
    Valid
}

/// <summary>PrimaryKeyURIFromConfig: URI for the key in keyvault for data encryption of the primary server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecDataEncryptionPrimaryKeyURIFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// PrimaryUserAssignedIdentityReference: Resource Id for the User assigned identity to be used for data encryption of the
/// primary server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecDataEncryptionPrimaryUserAssignedIdentityReference
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

/// <summary>Type: Data encryption type to depict if it is System Managed vs Azure Key vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecDataEncryptionTypeEnum>))]
public enum V1api20230601previewFlexibleServerSpecDataEncryptionTypeEnum
{
    [EnumMember(Value = "AzureKeyVault"), JsonStringEnumMemberName("AzureKeyVault")]
    AzureKeyVault,
    [EnumMember(Value = "SystemManaged"), JsonStringEnumMemberName("SystemManaged")]
    SystemManaged
}

/// <summary>DataEncryption: Data encryption properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecDataEncryption
{
    /// <summary>GeoBackupEncryptionKeyStatus: Geo-backup encryption key status for Data encryption enabled server.</summary>
    [JsonPropertyName("geoBackupEncryptionKeyStatus")]
    public V1api20230601previewFlexibleServerSpecDataEncryptionGeoBackupEncryptionKeyStatusEnum? GeoBackupEncryptionKeyStatus { get; set; }

    /// <summary>GeoBackupKeyURI: URI for the key in keyvault for data encryption for geo-backup of server.</summary>
    [JsonPropertyName("geoBackupKeyURI")]
    public string? GeoBackupKeyURI { get; set; }

    /// <summary>GeoBackupKeyURIFromConfig: URI for the key in keyvault for data encryption for geo-backup of server.</summary>
    [JsonPropertyName("geoBackupKeyURIFromConfig")]
    public V1api20230601previewFlexibleServerSpecDataEncryptionGeoBackupKeyURIFromConfig? GeoBackupKeyURIFromConfig { get; set; }

    /// <summary>
    /// GeoBackupUserAssignedIdentityReference: Resource Id for the User assigned identity to be used for data encryption for
    /// geo-backup of server.
    /// </summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityReference")]
    public V1api20230601previewFlexibleServerSpecDataEncryptionGeoBackupUserAssignedIdentityReference? GeoBackupUserAssignedIdentityReference { get; set; }

    /// <summary>PrimaryEncryptionKeyStatus: Primary encryption key status for Data encryption enabled server.</summary>
    [JsonPropertyName("primaryEncryptionKeyStatus")]
    public V1api20230601previewFlexibleServerSpecDataEncryptionPrimaryEncryptionKeyStatusEnum? PrimaryEncryptionKeyStatus { get; set; }

    /// <summary>PrimaryKeyURI: URI for the key in keyvault for data encryption of the primary server.</summary>
    [JsonPropertyName("primaryKeyURI")]
    public string? PrimaryKeyURI { get; set; }

    /// <summary>PrimaryKeyURIFromConfig: URI for the key in keyvault for data encryption of the primary server.</summary>
    [JsonPropertyName("primaryKeyURIFromConfig")]
    public V1api20230601previewFlexibleServerSpecDataEncryptionPrimaryKeyURIFromConfig? PrimaryKeyURIFromConfig { get; set; }

    /// <summary>
    /// PrimaryUserAssignedIdentityReference: Resource Id for the User assigned identity to be used for data encryption of the
    /// primary server.
    /// </summary>
    [JsonPropertyName("primaryUserAssignedIdentityReference")]
    public V1api20230601previewFlexibleServerSpecDataEncryptionPrimaryUserAssignedIdentityReference? PrimaryUserAssignedIdentityReference { get; set; }

    /// <summary>Type: Data encryption type to depict if it is System Managed vs Azure Key vault.</summary>
    [JsonPropertyName("type")]
    public V1api20230601previewFlexibleServerSpecDataEncryptionTypeEnum? Type { get; set; }
}

/// <summary>Mode: The HA mode for the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecHighAvailabilityModeEnum>))]
public enum V1api20230601previewFlexibleServerSpecHighAvailabilityModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "SameZone"), JsonStringEnumMemberName("SameZone")]
    SameZone,
    [EnumMember(Value = "ZoneRedundant"), JsonStringEnumMemberName("ZoneRedundant")]
    ZoneRedundant
}

/// <summary>HighAvailability: High availability properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecHighAvailability
{
    /// <summary>Mode: The HA mode for the server.</summary>
    [JsonPropertyName("mode")]
    public V1api20230601previewFlexibleServerSpecHighAvailabilityModeEnum? Mode { get; set; }

    /// <summary>StandbyAvailabilityZone: availability zone information of the standby.</summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }
}

/// <summary>Type: the types of identities associated with this resource; currently restricted to &apos;None and UserAssigned&apos;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecIdentityTypeEnum>))]
public enum V1api20230601previewFlexibleServerSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20230601previewFlexibleServerSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20230601previewFlexibleServerSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Describes the identity of the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecIdentity
{
    /// <summary>Type: the types of identities associated with this resource; currently restricted to &apos;None and UserAssigned&apos;</summary>
    [JsonPropertyName("type")]
    public required V1api20230601previewFlexibleServerSpecIdentityTypeEnum Type { get; set; }

    /// <summary>UserAssignedIdentities: represents user assigned identities map.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20230601previewFlexibleServerSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>MaintenanceWindow: Maintenance window properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecMaintenanceWindow
{
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

/// <summary>
/// DelegatedSubnetResourceReference: Delegated subnet arm resource id. This is required to be passed during create, in case
/// we want the server to be VNET injected, i.e. Private access server. During update, pass this only if we want to update
/// the value for Private DNS zone.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecNetworkDelegatedSubnetResourceReference
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
/// PrivateDnsZoneArmResourceReference: Private dns zone arm resource id. This is required to be passed during create, in
/// case we want the server to be VNET injected, i.e. Private access server. During update, pass this only if we want to
/// update the value for Private DNS zone.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecNetworkPrivateDnsZoneArmResourceReference
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

/// <summary>PublicNetworkAccess: public network access is enabled or not</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecNetworkPublicNetworkAccessEnum>))]
public enum V1api20230601previewFlexibleServerSpecNetworkPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// Network: Network properties of a server. This Network property is required to be passed only in case you want the server
/// to be Private access server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecNetwork
{
    /// <summary>
    /// DelegatedSubnetResourceReference: Delegated subnet arm resource id. This is required to be passed during create, in case
    /// we want the server to be VNET injected, i.e. Private access server. During update, pass this only if we want to update
    /// the value for Private DNS zone.
    /// </summary>
    [JsonPropertyName("delegatedSubnetResourceReference")]
    public V1api20230601previewFlexibleServerSpecNetworkDelegatedSubnetResourceReference? DelegatedSubnetResourceReference { get; set; }

    /// <summary>
    /// PrivateDnsZoneArmResourceReference: Private dns zone arm resource id. This is required to be passed during create, in
    /// case we want the server to be VNET injected, i.e. Private access server. During update, pass this only if we want to
    /// update the value for Private DNS zone.
    /// </summary>
    [JsonPropertyName("privateDnsZoneArmResourceReference")]
    public V1api20230601previewFlexibleServerSpecNetworkPrivateDnsZoneArmResourceReference? PrivateDnsZoneArmResourceReference { get; set; }

    /// <summary>PublicNetworkAccess: public network access is enabled or not</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20230601previewFlexibleServerSpecNetworkPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecOperatorSpecConfigMapExpressions
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
/// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName config map should be placed. If omitted, no
/// config map will be created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName
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
public partial class V1api20230601previewFlexibleServerSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName config map should be placed. If omitted, no
    /// config map will be created.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V1api20230601previewFlexibleServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecOperatorSpecSecretExpressions
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
public partial class V1api20230601previewFlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName
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
public partial class V1api20230601previewFlexibleServerSpecOperatorSpecSecrets
{
    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V1api20230601previewFlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230601previewFlexibleServerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20230601previewFlexibleServerSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230601previewFlexibleServerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20230601previewFlexibleServerSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PromoteMode: Sets the promote mode for a replica server. This is a write only property.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecReplicaPromoteModeEnum>))]
public enum V1api20230601previewFlexibleServerSpecReplicaPromoteModeEnum
{
    [EnumMember(Value = "standalone"), JsonStringEnumMemberName("standalone")]
    Standalone,
    [EnumMember(Value = "switchover"), JsonStringEnumMemberName("switchover")]
    Switchover
}

/// <summary>PromoteOption: Sets the promote options for a replica server. This is a write only property.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecReplicaPromoteOptionEnum>))]
public enum V1api20230601previewFlexibleServerSpecReplicaPromoteOptionEnum
{
    [EnumMember(Value = "forced"), JsonStringEnumMemberName("forced")]
    Forced,
    [EnumMember(Value = "planned"), JsonStringEnumMemberName("planned")]
    Planned
}

/// <summary>Role: Used to indicate role of the server in replication set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecReplicaRoleEnum>))]
public enum V1api20230601previewFlexibleServerSpecReplicaRoleEnum
{
    [EnumMember(Value = "AsyncReplica"), JsonStringEnumMemberName("AsyncReplica")]
    AsyncReplica,
    [EnumMember(Value = "GeoAsyncReplica"), JsonStringEnumMemberName("GeoAsyncReplica")]
    GeoAsyncReplica,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Primary"), JsonStringEnumMemberName("Primary")]
    Primary
}

/// <summary>
/// Replica: Replica properties of a server. These Replica properties are required to be passed only in case you want to
/// Promote a server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecReplica
{
    /// <summary>PromoteMode: Sets the promote mode for a replica server. This is a write only property.</summary>
    [JsonPropertyName("promoteMode")]
    public V1api20230601previewFlexibleServerSpecReplicaPromoteModeEnum? PromoteMode { get; set; }

    /// <summary>PromoteOption: Sets the promote options for a replica server. This is a write only property.</summary>
    [JsonPropertyName("promoteOption")]
    public V1api20230601previewFlexibleServerSpecReplicaPromoteOptionEnum? PromoteOption { get; set; }

    /// <summary>Role: Used to indicate role of the server in replication set.</summary>
    [JsonPropertyName("role")]
    public V1api20230601previewFlexibleServerSpecReplicaRoleEnum? Role { get; set; }
}

/// <summary>ReplicationRole: Replication role of the server</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecReplicationRoleEnum>))]
public enum V1api20230601previewFlexibleServerSpecReplicationRoleEnum
{
    [EnumMember(Value = "AsyncReplica"), JsonStringEnumMemberName("AsyncReplica")]
    AsyncReplica,
    [EnumMember(Value = "GeoAsyncReplica"), JsonStringEnumMemberName("GeoAsyncReplica")]
    GeoAsyncReplica,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Primary"), JsonStringEnumMemberName("Primary")]
    Primary
}

/// <summary>Tier: The tier of the particular SKU, e.g. Burstable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecSkuTierEnum>))]
public enum V1api20230601previewFlexibleServerSpecSkuTierEnum
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
public partial class V1api20230601previewFlexibleServerSpecSku
{
    /// <summary>Name: The name of the sku, typically, tier + family + cores, e.g. Standard_D4s_v3.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Tier: The tier of the particular SKU, e.g. Burstable.</summary>
    [JsonPropertyName("tier")]
    public required V1api20230601previewFlexibleServerSpecSkuTierEnum Tier { get; set; }
}

/// <summary>
/// SourceServerResourceReference: The source server resource ID to restore from. It&apos;s required when &apos;createMode&apos; is
/// &apos;PointInTimeRestore&apos; or &apos;GeoRestore&apos; or &apos;Replica&apos; or &apos;ReviveDropped&apos;. This property is returned only for Replica server
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecSourceServerResourceReference
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

/// <summary>AutoGrow: Flag to enable / disable Storage Auto grow for flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecStorageAutoGrowEnum>))]
public enum V1api20230601previewFlexibleServerSpecStorageAutoGrowEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Tier: Name of storage tier for IOPS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecStorageTierEnum>))]
public enum V1api20230601previewFlexibleServerSpecStorageTierEnum
{
    [EnumMember(Value = "P1"), JsonStringEnumMemberName("P1")]
    P1,
    [EnumMember(Value = "P10"), JsonStringEnumMemberName("P10")]
    P10,
    [EnumMember(Value = "P15"), JsonStringEnumMemberName("P15")]
    P15,
    [EnumMember(Value = "P2"), JsonStringEnumMemberName("P2")]
    P2,
    [EnumMember(Value = "P20"), JsonStringEnumMemberName("P20")]
    P20,
    [EnumMember(Value = "P3"), JsonStringEnumMemberName("P3")]
    P3,
    [EnumMember(Value = "P30"), JsonStringEnumMemberName("P30")]
    P30,
    [EnumMember(Value = "P4"), JsonStringEnumMemberName("P4")]
    P4,
    [EnumMember(Value = "P40"), JsonStringEnumMemberName("P40")]
    P40,
    [EnumMember(Value = "P50"), JsonStringEnumMemberName("P50")]
    P50,
    [EnumMember(Value = "P6"), JsonStringEnumMemberName("P6")]
    P6,
    [EnumMember(Value = "P60"), JsonStringEnumMemberName("P60")]
    P60,
    [EnumMember(Value = "P70"), JsonStringEnumMemberName("P70")]
    P70,
    [EnumMember(Value = "P80"), JsonStringEnumMemberName("P80")]
    P80
}

/// <summary>
/// Type: Storage type for the server. Allowed values are Premium_LRS and PremiumV2_LRS, and default is Premium_LRS if not
/// specified
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecStorageTypeEnum>))]
public enum V1api20230601previewFlexibleServerSpecStorageTypeEnum
{
    [EnumMember(Value = "PremiumV2_LRS"), JsonStringEnumMemberName("PremiumV2_LRS")]
    PremiumV2LRS,
    [EnumMember(Value = "Premium_LRS"), JsonStringEnumMemberName("Premium_LRS")]
    PremiumLRS
}

/// <summary>Storage: Storage properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpecStorage
{
    /// <summary>AutoGrow: Flag to enable / disable Storage Auto grow for flexible server.</summary>
    [JsonPropertyName("autoGrow")]
    public V1api20230601previewFlexibleServerSpecStorageAutoGrowEnum? AutoGrow { get; set; }

    /// <summary>Iops: Storage tier IOPS quantity. This property is required to be set for storage Type PremiumV2_LRS</summary>
    [JsonPropertyName("iops")]
    public int? Iops { get; set; }

    /// <summary>StorageSizeGB: Max storage allowed for a server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }

    /// <summary>Throughput: Storage throughput for the server. This is required to be set for storage Type PremiumV2_LRS</summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }

    /// <summary>Tier: Name of storage tier for IOPS.</summary>
    [JsonPropertyName("tier")]
    public V1api20230601previewFlexibleServerSpecStorageTierEnum? Tier { get; set; }

    /// <summary>
    /// Type: Storage type for the server. Allowed values are Premium_LRS and PremiumV2_LRS, and default is Premium_LRS if not
    /// specified
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20230601previewFlexibleServerSpecStorageTypeEnum? Type { get; set; }
}

/// <summary>Version: PostgreSQL Server version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230601previewFlexibleServerSpecVersionEnum>))]
public enum V1api20230601previewFlexibleServerSpecVersionEnum
{
    [EnumMember(Value = "11"), JsonStringEnumMemberName("11")]
    _11,
    [EnumMember(Value = "12"), JsonStringEnumMemberName("12")]
    _12,
    [EnumMember(Value = "13"), JsonStringEnumMemberName("13")]
    _13,
    [EnumMember(Value = "14"), JsonStringEnumMemberName("14")]
    _14,
    [EnumMember(Value = "15"), JsonStringEnumMemberName("15")]
    _15,
    [EnumMember(Value = "16"), JsonStringEnumMemberName("16")]
    _16
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerSpec
{
    /// <summary>
    /// AdministratorLogin: The administrator&apos;s login name of a server. Can only be specified when the server is being created
    /// (and is required for creation).
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>AdministratorLoginPassword: The administrator login password (required for server creation).</summary>
    [JsonPropertyName("administratorLoginPassword")]
    public V1api20230601previewFlexibleServerSpecAdministratorLoginPassword? AdministratorLoginPassword { get; set; }

    /// <summary>AuthConfig: AuthConfig properties of a server.</summary>
    [JsonPropertyName("authConfig")]
    public V1api20230601previewFlexibleServerSpecAuthConfig? AuthConfig { get; set; }

    /// <summary>AvailabilityZone: availability zone information of the server.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Backup: Backup properties of a server.</summary>
    [JsonPropertyName("backup")]
    public V1api20230601previewFlexibleServerSpecBackup? Backup { get; set; }

    /// <summary>CreateMode: The mode to create a new PostgreSQL server.</summary>
    [JsonPropertyName("createMode")]
    public V1api20230601previewFlexibleServerSpecCreateModeEnum? CreateMode { get; set; }

    /// <summary>DataEncryption: Data encryption properties of a server.</summary>
    [JsonPropertyName("dataEncryption")]
    public V1api20230601previewFlexibleServerSpecDataEncryption? DataEncryption { get; set; }

    /// <summary>HighAvailability: High availability properties of a server.</summary>
    [JsonPropertyName("highAvailability")]
    public V1api20230601previewFlexibleServerSpecHighAvailability? HighAvailability { get; set; }

    /// <summary>Identity: Describes the identity of the application.</summary>
    [JsonPropertyName("identity")]
    public V1api20230601previewFlexibleServerSpecIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MaintenanceWindow: Maintenance window properties of a server.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1api20230601previewFlexibleServerSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>
    /// Network: Network properties of a server. This Network property is required to be passed only in case you want the server
    /// to be Private access server.
    /// </summary>
    [JsonPropertyName("network")]
    public V1api20230601previewFlexibleServerSpecNetwork? Network { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230601previewFlexibleServerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230601previewFlexibleServerSpecOwner Owner { get; set; }

    /// <summary>
    /// PointInTimeUTC: Restore point creation time (ISO8601 format), specifying the time to restore from. It&apos;s required when
    /// &apos;createMode&apos; is &apos;PointInTimeRestore&apos; or &apos;GeoRestore&apos; or &apos;ReviveDropped&apos;.
    /// </summary>
    [JsonPropertyName("pointInTimeUTC")]
    public string? PointInTimeUTC { get; set; }

    /// <summary>
    /// Replica: Replica properties of a server. These Replica properties are required to be passed only in case you want to
    /// Promote a server.
    /// </summary>
    [JsonPropertyName("replica")]
    public V1api20230601previewFlexibleServerSpecReplica? Replica { get; set; }

    /// <summary>ReplicationRole: Replication role of the server</summary>
    [JsonPropertyName("replicationRole")]
    public V1api20230601previewFlexibleServerSpecReplicationRoleEnum? ReplicationRole { get; set; }

    /// <summary>Sku: The SKU (pricing tier) of the server.</summary>
    [JsonPropertyName("sku")]
    public V1api20230601previewFlexibleServerSpecSku? Sku { get; set; }

    /// <summary>
    /// SourceServerResourceReference: The source server resource ID to restore from. It&apos;s required when &apos;createMode&apos; is
    /// &apos;PointInTimeRestore&apos; or &apos;GeoRestore&apos; or &apos;Replica&apos; or &apos;ReviveDropped&apos;. This property is returned only for Replica server
    /// </summary>
    [JsonPropertyName("sourceServerResourceReference")]
    public V1api20230601previewFlexibleServerSpecSourceServerResourceReference? SourceServerResourceReference { get; set; }

    /// <summary>Storage: Storage properties of a server.</summary>
    [JsonPropertyName("storage")]
    public V1api20230601previewFlexibleServerSpecStorage? Storage { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Version: PostgreSQL Server version.</summary>
    [JsonPropertyName("version")]
    public V1api20230601previewFlexibleServerSpecVersionEnum? Version { get; set; }
}

/// <summary>AuthConfig: AuthConfig properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusAuthConfig
{
    /// <summary>ActiveDirectoryAuth: If Enabled, Azure Active Directory authentication is enabled.</summary>
    [JsonPropertyName("activeDirectoryAuth")]
    public string? ActiveDirectoryAuth { get; set; }

    /// <summary>PasswordAuth: If Enabled, Password authentication is enabled.</summary>
    [JsonPropertyName("passwordAuth")]
    public string? PasswordAuth { get; set; }

    /// <summary>TenantId: Tenant id of the server.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Backup: Backup properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusBackup
{
    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>EarliestRestoreDate: The earliest restore point time (ISO8601 format) for server.</summary>
    [JsonPropertyName("earliestRestoreDate")]
    public string? EarliestRestoreDate { get; set; }

    /// <summary>GeoRedundantBackup: A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public string? GeoRedundantBackup { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusConditions
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

/// <summary>DataEncryption: Data encryption properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusDataEncryption
{
    /// <summary>GeoBackupEncryptionKeyStatus: Geo-backup encryption key status for Data encryption enabled server.</summary>
    [JsonPropertyName("geoBackupEncryptionKeyStatus")]
    public string? GeoBackupEncryptionKeyStatus { get; set; }

    /// <summary>GeoBackupKeyURI: URI for the key in keyvault for data encryption for geo-backup of server.</summary>
    [JsonPropertyName("geoBackupKeyURI")]
    public string? GeoBackupKeyURI { get; set; }

    /// <summary>
    /// GeoBackupUserAssignedIdentityId: Resource Id for the User assigned identity to be used for data encryption for
    /// geo-backup of server.
    /// </summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityId")]
    public string? GeoBackupUserAssignedIdentityId { get; set; }

    /// <summary>PrimaryEncryptionKeyStatus: Primary encryption key status for Data encryption enabled server.</summary>
    [JsonPropertyName("primaryEncryptionKeyStatus")]
    public string? PrimaryEncryptionKeyStatus { get; set; }

    /// <summary>PrimaryKeyURI: URI for the key in keyvault for data encryption of the primary server.</summary>
    [JsonPropertyName("primaryKeyURI")]
    public string? PrimaryKeyURI { get; set; }

    /// <summary>
    /// PrimaryUserAssignedIdentityId: Resource Id for the User assigned identity to be used for data encryption of the primary
    /// server.
    /// </summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }

    /// <summary>Type: Data encryption type to depict if it is System Managed vs Azure Key vault.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>HighAvailability: High availability properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusHighAvailability
{
    /// <summary>Mode: The HA mode for the server.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>StandbyAvailabilityZone: availability zone information of the standby.</summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }

    /// <summary>State: A state of a HA server that is visible to user.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Describes a single user-assigned identity associated with the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: the client identifier of the Service Principal which this identity represents.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: the object identifier of the Service Principal which this identity represents.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: Describes the identity of the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusIdentity
{
    /// <summary>TenantId: Tenant id of the server.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: the types of identities associated with this resource; currently restricted to &apos;None and UserAssigned&apos;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: represents user assigned identities map.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20230601previewFlexibleServerStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>MaintenanceWindow: Maintenance window properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusMaintenanceWindow
{
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

/// <summary>
/// Network: Network properties of a server. This Network property is required to be passed only in case you want the server
/// to be Private access server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusNetwork
{
    /// <summary>
    /// DelegatedSubnetResourceId: Delegated subnet arm resource id. This is required to be passed during create, in case we
    /// want the server to be VNET injected, i.e. Private access server. During update, pass this only if we want to update the
    /// value for Private DNS zone.
    /// </summary>
    [JsonPropertyName("delegatedSubnetResourceId")]
    public string? DelegatedSubnetResourceId { get; set; }

    /// <summary>
    /// PrivateDnsZoneArmResourceId: Private dns zone arm resource id. This is required to be passed during create, in case we
    /// want the server to be VNET injected, i.e. Private access server. During update, pass this only if we want to update the
    /// value for Private DNS zone.
    /// </summary>
    [JsonPropertyName("privateDnsZoneArmResourceId")]
    public string? PrivateDnsZoneArmResourceId { get; set; }

    /// <summary>PublicNetworkAccess: public network access is enabled or not</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }
}

/// <summary>The private endpoint connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Replica: Replica properties of a server. These Replica properties are required to be passed only in case you want to
/// Promote a server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusReplica
{
    /// <summary>Capacity: Replicas allowed for a server.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>PromoteMode: Sets the promote mode for a replica server. This is a write only property.</summary>
    [JsonPropertyName("promoteMode")]
    public string? PromoteMode { get; set; }

    /// <summary>PromoteOption: Sets the promote options for a replica server. This is a write only property.</summary>
    [JsonPropertyName("promoteOption")]
    public string? PromoteOption { get; set; }

    /// <summary>
    /// ReplicationState: Gets the replication state of a replica server. This property is returned only for replicas api call.
    /// Supported values are Active, Catchup, Provisioning, Updating, Broken, Reconfiguring
    /// </summary>
    [JsonPropertyName("replicationState")]
    public string? ReplicationState { get; set; }

    /// <summary>Role: Used to indicate role of the server in replication set.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>Sku: The SKU (pricing tier) of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusSku
{
    /// <summary>Name: The name of the sku, typically, tier + family + cores, e.g. Standard_D4s_v3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: The tier of the particular SKU, e.g. Burstable.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage: Storage properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusStorage
{
    /// <summary>AutoGrow: Flag to enable / disable Storage Auto grow for flexible server.</summary>
    [JsonPropertyName("autoGrow")]
    public string? AutoGrow { get; set; }

    /// <summary>Iops: Storage tier IOPS quantity. This property is required to be set for storage Type PremiumV2_LRS</summary>
    [JsonPropertyName("iops")]
    public int? Iops { get; set; }

    /// <summary>StorageSizeGB: Max storage allowed for a server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }

    /// <summary>Throughput: Storage throughput for the server. This is required to be set for storage Type PremiumV2_LRS</summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }

    /// <summary>Tier: Name of storage tier for IOPS.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>
    /// Type: Storage type for the server. Allowed values are Premium_LRS and PremiumV2_LRS, and default is Premium_LRS if not
    /// specified
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230601previewFlexibleServerStatusSystemData
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
public partial class V1api20230601previewFlexibleServerStatus
{
    /// <summary>
    /// AdministratorLogin: The administrator&apos;s login name of a server. Can only be specified when the server is being created
    /// (and is required for creation).
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>AuthConfig: AuthConfig properties of a server.</summary>
    [JsonPropertyName("authConfig")]
    public V1api20230601previewFlexibleServerStatusAuthConfig? AuthConfig { get; set; }

    /// <summary>AvailabilityZone: availability zone information of the server.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Backup: Backup properties of a server.</summary>
    [JsonPropertyName("backup")]
    public V1api20230601previewFlexibleServerStatusBackup? Backup { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230601previewFlexibleServerStatusConditions>? Conditions { get; set; }

    /// <summary>CreateMode: The mode to create a new PostgreSQL server.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>DataEncryption: Data encryption properties of a server.</summary>
    [JsonPropertyName("dataEncryption")]
    public V1api20230601previewFlexibleServerStatusDataEncryption? DataEncryption { get; set; }

    /// <summary>FullyQualifiedDomainName: The fully qualified domain name of a server.</summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public string? FullyQualifiedDomainName { get; set; }

    /// <summary>HighAvailability: High availability properties of a server.</summary>
    [JsonPropertyName("highAvailability")]
    public V1api20230601previewFlexibleServerStatusHighAvailability? HighAvailability { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Describes the identity of the application.</summary>
    [JsonPropertyName("identity")]
    public V1api20230601previewFlexibleServerStatusIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaintenanceWindow: Maintenance window properties of a server.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1api20230601previewFlexibleServerStatusMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>MinorVersion: The minor version of the server.</summary>
    [JsonPropertyName("minorVersion")]
    public string? MinorVersion { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Network: Network properties of a server. This Network property is required to be passed only in case you want the server
    /// to be Private access server.
    /// </summary>
    [JsonPropertyName("network")]
    public V1api20230601previewFlexibleServerStatusNetwork? Network { get; set; }

    /// <summary>
    /// PointInTimeUTC: Restore point creation time (ISO8601 format), specifying the time to restore from. It&apos;s required when
    /// &apos;createMode&apos; is &apos;PointInTimeRestore&apos; or &apos;GeoRestore&apos; or &apos;ReviveDropped&apos;.
    /// </summary>
    [JsonPropertyName("pointInTimeUTC")]
    public string? PointInTimeUTC { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connections associated with the specified resource.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20230601previewFlexibleServerStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>
    /// Replica: Replica properties of a server. These Replica properties are required to be passed only in case you want to
    /// Promote a server.
    /// </summary>
    [JsonPropertyName("replica")]
    public V1api20230601previewFlexibleServerStatusReplica? Replica { get; set; }

    /// <summary>ReplicaCapacity: Replicas allowed for a server.</summary>
    [JsonPropertyName("replicaCapacity")]
    public int? ReplicaCapacity { get; set; }

    /// <summary>ReplicationRole: Replication role of the server</summary>
    [JsonPropertyName("replicationRole")]
    public string? ReplicationRole { get; set; }

    /// <summary>Sku: The SKU (pricing tier) of the server.</summary>
    [JsonPropertyName("sku")]
    public V1api20230601previewFlexibleServerStatusSku? Sku { get; set; }

    /// <summary>
    /// SourceServerResourceId: The source server resource ID to restore from. It&apos;s required when &apos;createMode&apos; is
    /// &apos;PointInTimeRestore&apos; or &apos;GeoRestore&apos; or &apos;Replica&apos; or &apos;ReviveDropped&apos;. This property is returned only for Replica server
    /// </summary>
    [JsonPropertyName("sourceServerResourceId")]
    public string? SourceServerResourceId { get; set; }

    /// <summary>State: A state of a server that is visible to user.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Storage: Storage properties of a server.</summary>
    [JsonPropertyName("storage")]
    public V1api20230601previewFlexibleServerStatusStorage? Storage { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20230601previewFlexibleServerStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Version: PostgreSQL Server version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /postgresql/resource-manager/Microsoft.DBforPostgreSQL/preview/2023-06-01-preview/FlexibleServers.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230601previewFlexibleServer : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230601previewFlexibleServerSpec?>, IStatus<V1api20230601previewFlexibleServerStatus?>
{
    public const string KubeApiVersion = "v1api20230601preview";
    public const string KubeKind = "FlexibleServer";
    public const string KubeGroup = "dbforpostgresql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbforpostgresql.azure.com/v1api20230601preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230601previewFlexibleServerSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20230601previewFlexibleServerStatus? Status { get; set; }
}