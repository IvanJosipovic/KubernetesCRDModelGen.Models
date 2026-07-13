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
/// - Generated from: /postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2025-08-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250801FlexibleServerList : IKubernetesObject<V1ListMeta>, IItems<V20250801FlexibleServer>
{
    public const string KubeApiVersion = "v20250801";
    public const string KubeKind = "FlexibleServerList";
    public const string KubeGroup = "dbforpostgresql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbforpostgresql.azure.com/v20250801";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250801FlexibleServer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250801FlexibleServer> Items { get; set; }
}

/// <summary>
/// AdministratorLoginPassword: Password assigned to the administrator login. As long as password authentication is enabled,
/// this password can be changed at any time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecAdministratorLoginPassword
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

/// <summary>ActiveDirectoryAuth: Indicates if the server supports Microsoft Entra authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecAuthConfigActiveDirectoryAuthEnum>))]
public enum V20250801FlexibleServerSpecAuthConfigActiveDirectoryAuthEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>PasswordAuth: Indicates if the server supports password based authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecAuthConfigPasswordAuthEnum>))]
public enum V20250801FlexibleServerSpecAuthConfigPasswordAuthEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>TenantIdFromConfig: Identifier of the tenant of the delegated resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecAuthConfigTenantIdFromConfig
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

/// <summary>AuthConfig: Authentication configuration properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecAuthConfig
{
    /// <summary>ActiveDirectoryAuth: Indicates if the server supports Microsoft Entra authentication.</summary>
    [JsonPropertyName("activeDirectoryAuth")]
    public V20250801FlexibleServerSpecAuthConfigActiveDirectoryAuthEnum? ActiveDirectoryAuth { get; set; }

    /// <summary>PasswordAuth: Indicates if the server supports password based authentication.</summary>
    [JsonPropertyName("passwordAuth")]
    public V20250801FlexibleServerSpecAuthConfigPasswordAuthEnum? PasswordAuth { get; set; }

    /// <summary>TenantId: Identifier of the tenant of the delegated resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>TenantIdFromConfig: Identifier of the tenant of the delegated resource.</summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V20250801FlexibleServerSpecAuthConfigTenantIdFromConfig? TenantIdFromConfig { get; set; }
}

/// <summary>GeoRedundantBackup: Indicates if the server is configured to create geographically redundant backups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecBackupGeoRedundantBackupEnum>))]
public enum V20250801FlexibleServerSpecBackupGeoRedundantBackupEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Backup: Backup properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecBackup
{
    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>GeoRedundantBackup: Indicates if the server is configured to create geographically redundant backups.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public V20250801FlexibleServerSpecBackupGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }
}

/// <summary>Cluster: Cluster properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecCluster
{
    /// <summary>ClusterSize: Number of nodes assigned to the elastic cluster.</summary>
    [JsonPropertyName("clusterSize")]
    public int? ClusterSize { get; set; }

    /// <summary>DefaultDatabaseName: Default database name for the elastic cluster.</summary>
    [JsonPropertyName("defaultDatabaseName")]
    public string? DefaultDatabaseName { get; set; }
}

/// <summary>CreateMode: Creation mode of a new server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecCreateModeEnum>))]
public enum V20250801FlexibleServerSpecCreateModeEnum
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

/// <summary>
/// GeoBackupKeyURIFromConfig: Identifier of the user assigned managed identity used to access the key in Azure Key Vault
/// for data encryption of the geographically redundant storage associated to a server that is configured to support
/// geographically redundant backups.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecDataEncryptionGeoBackupKeyURIFromConfig
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
/// GeoBackupUserAssignedIdentityReference: Identifier of the user assigned managed identity used to access the key in Azure
/// Key Vault for data encryption of the geographically redundant storage associated to a server that is configured to
/// support geographically redundant backups.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecDataEncryptionGeoBackupUserAssignedIdentityReference
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
/// PrimaryKeyURIFromConfig: URI of the key in Azure Key Vault used for data encryption of the primary storage associated to
/// a server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecDataEncryptionPrimaryKeyURIFromConfig
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
/// PrimaryUserAssignedIdentityReference: Identifier of the user assigned managed identity used to access the key in Azure
/// Key Vault for data encryption of the primary storage associated to a server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecDataEncryptionPrimaryUserAssignedIdentityReference
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

/// <summary>Type: Data encryption type used by a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecDataEncryptionTypeEnum>))]
public enum V20250801FlexibleServerSpecDataEncryptionTypeEnum
{
    [EnumMember(Value = "AzureKeyVault"), JsonStringEnumMemberName("AzureKeyVault")]
    AzureKeyVault,
    [EnumMember(Value = "SystemManaged"), JsonStringEnumMemberName("SystemManaged")]
    SystemManaged
}

/// <summary>DataEncryption: Data encryption properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecDataEncryption
{
    /// <summary>
    /// GeoBackupKeyURI: Identifier of the user assigned managed identity used to access the key in Azure Key Vault for data
    /// encryption of the geographically redundant storage associated to a server that is configured to support geographically
    /// redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupKeyURI")]
    public string? GeoBackupKeyURI { get; set; }

    /// <summary>
    /// GeoBackupKeyURIFromConfig: Identifier of the user assigned managed identity used to access the key in Azure Key Vault
    /// for data encryption of the geographically redundant storage associated to a server that is configured to support
    /// geographically redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupKeyURIFromConfig")]
    public V20250801FlexibleServerSpecDataEncryptionGeoBackupKeyURIFromConfig? GeoBackupKeyURIFromConfig { get; set; }

    /// <summary>
    /// GeoBackupUserAssignedIdentityReference: Identifier of the user assigned managed identity used to access the key in Azure
    /// Key Vault for data encryption of the geographically redundant storage associated to a server that is configured to
    /// support geographically redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityReference")]
    public V20250801FlexibleServerSpecDataEncryptionGeoBackupUserAssignedIdentityReference? GeoBackupUserAssignedIdentityReference { get; set; }

    /// <summary>PrimaryKeyURI: URI of the key in Azure Key Vault used for data encryption of the primary storage associated to a server.</summary>
    [JsonPropertyName("primaryKeyURI")]
    public string? PrimaryKeyURI { get; set; }

    /// <summary>
    /// PrimaryKeyURIFromConfig: URI of the key in Azure Key Vault used for data encryption of the primary storage associated to
    /// a server.
    /// </summary>
    [JsonPropertyName("primaryKeyURIFromConfig")]
    public V20250801FlexibleServerSpecDataEncryptionPrimaryKeyURIFromConfig? PrimaryKeyURIFromConfig { get; set; }

    /// <summary>
    /// PrimaryUserAssignedIdentityReference: Identifier of the user assigned managed identity used to access the key in Azure
    /// Key Vault for data encryption of the primary storage associated to a server.
    /// </summary>
    [JsonPropertyName("primaryUserAssignedIdentityReference")]
    public V20250801FlexibleServerSpecDataEncryptionPrimaryUserAssignedIdentityReference? PrimaryUserAssignedIdentityReference { get; set; }

    /// <summary>Type: Data encryption type used by a server.</summary>
    [JsonPropertyName("type")]
    public V20250801FlexibleServerSpecDataEncryptionTypeEnum? Type { get; set; }
}

/// <summary>Mode: High availability mode for a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecHighAvailabilityModeEnum>))]
public enum V20250801FlexibleServerSpecHighAvailabilityModeEnum
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
public partial class V20250801FlexibleServerSpecHighAvailability
{
    /// <summary>Mode: High availability mode for a server.</summary>
    [JsonPropertyName("mode")]
    public V20250801FlexibleServerSpecHighAvailabilityModeEnum? Mode { get; set; }

    /// <summary>
    /// StandbyAvailabilityZone: Availability zone associated to the standby server created when high availability is set to
    /// SameZone or ZoneRedundant.
    /// </summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }
}

/// <summary>Type: Types of identities associated with a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecIdentityTypeEnum>))]
public enum V20250801FlexibleServerSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned,UserAssigned"), JsonStringEnumMemberName("SystemAssigned,UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecIdentityUserAssignedIdentitiesReference
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
public partial class V20250801FlexibleServerSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250801FlexibleServerSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: User assigned managed identities assigned to the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecIdentity
{
    /// <summary>PrincipalId: Identifier of the object of the service principal associated to the user assigned managed identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Type: Types of identities associated with a server.</summary>
    [JsonPropertyName("type")]
    public required V20250801FlexibleServerSpecIdentityTypeEnum Type { get; set; }

    /// <summary>UserAssignedIdentities: Map of user assigned managed identities.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20250801FlexibleServerSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>MaintenanceWindow: Maintenance window properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecMaintenanceWindow
{
    /// <summary>CustomWindow: Indicates whether custom window is enabled or disabled.</summary>
    [JsonPropertyName("customWindow")]
    public string? CustomWindow { get; set; }

    /// <summary>DayOfWeek: Day of the week to be used for maintenance window.</summary>
    [JsonPropertyName("dayOfWeek")]
    public int? DayOfWeek { get; set; }

    /// <summary>StartHour: Start hour to be used for maintenance window.</summary>
    [JsonPropertyName("startHour")]
    public int? StartHour { get; set; }

    /// <summary>StartMinute: Start minute to be used for maintenance window.</summary>
    [JsonPropertyName("startMinute")]
    public int? StartMinute { get; set; }
}

/// <summary>
/// DelegatedSubnetResourceReference: Resource identifier of the delegated subnet. Required during creation of a new server,
/// in case you want the server to be integrated into your own virtual network. For an update operation, you only have to
/// provide this property if you want to change the value assigned for the private DNS zone.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecNetworkDelegatedSubnetResourceReference
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
/// PrivateDnsZoneArmResourceReference: Identifier of the private DNS zone. Required during creation of a new server, in
/// case you want the server to be integrated into your own virtual network. For an update operation, you only have to
/// provide this property if you want to change the value assigned for the private DNS zone.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecNetworkPrivateDnsZoneArmResourceReference
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
/// PublicNetworkAccess: Indicates if public network access is enabled or not. This is only supported for servers that are
/// not integrated into a virtual network which is owned and provided by customer when server is deployed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecNetworkPublicNetworkAccessEnum>))]
public enum V20250801FlexibleServerSpecNetworkPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// Network: Network properties of a server. Only required if you want your server to be integrated into a virtual network
/// provided by customer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecNetwork
{
    /// <summary>
    /// DelegatedSubnetResourceReference: Resource identifier of the delegated subnet. Required during creation of a new server,
    /// in case you want the server to be integrated into your own virtual network. For an update operation, you only have to
    /// provide this property if you want to change the value assigned for the private DNS zone.
    /// </summary>
    [JsonPropertyName("delegatedSubnetResourceReference")]
    public V20250801FlexibleServerSpecNetworkDelegatedSubnetResourceReference? DelegatedSubnetResourceReference { get; set; }

    /// <summary>
    /// PrivateDnsZoneArmResourceReference: Identifier of the private DNS zone. Required during creation of a new server, in
    /// case you want the server to be integrated into your own virtual network. For an update operation, you only have to
    /// provide this property if you want to change the value assigned for the private DNS zone.
    /// </summary>
    [JsonPropertyName("privateDnsZoneArmResourceReference")]
    public V20250801FlexibleServerSpecNetworkPrivateDnsZoneArmResourceReference? PrivateDnsZoneArmResourceReference { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Indicates if public network access is enabled or not. This is only supported for servers that are
    /// not integrated into a virtual network which is owned and provided by customer when server is deployed.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V20250801FlexibleServerSpecNetworkPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecOperatorSpecConfigMapExpressions
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
public partial class V20250801FlexibleServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName
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
public partial class V20250801FlexibleServerSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName config map should be placed. If omitted, no
    /// config map will be created.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V20250801FlexibleServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecOperatorSpecSecretExpressions
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
public partial class V20250801FlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName
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
public partial class V20250801FlexibleServerSpecOperatorSpecSecrets
{
    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V20250801FlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250801FlexibleServerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V20250801FlexibleServerSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250801FlexibleServerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V20250801FlexibleServerSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PromoteMode: Type of operation to apply on the read replica. This property is write only. Standalone means that the read
/// replica will be promoted to a standalone server, and will become a completely independent entity from the replication
/// set. Switchover means that the read replica will roles with the primary server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecReplicaPromoteModeEnum>))]
public enum V20250801FlexibleServerSpecReplicaPromoteModeEnum
{
    [EnumMember(Value = "Standalone"), JsonStringEnumMemberName("Standalone")]
    Standalone,
    [EnumMember(Value = "Switchover"), JsonStringEnumMemberName("Switchover")]
    Switchover
}

/// <summary>
/// PromoteOption: Data synchronization option to use when processing the operation specified in the promoteMode property.
/// This property is write only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecReplicaPromoteOptionEnum>))]
public enum V20250801FlexibleServerSpecReplicaPromoteOptionEnum
{
    [EnumMember(Value = "Forced"), JsonStringEnumMemberName("Forced")]
    Forced,
    [EnumMember(Value = "Planned"), JsonStringEnumMemberName("Planned")]
    Planned
}

/// <summary>Role: Role of the server in a replication set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecReplicaRoleEnum>))]
public enum V20250801FlexibleServerSpecReplicaRoleEnum
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

/// <summary>Replica: Read replica properties of a server. Required only in case that you want to promote a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecReplica
{
    /// <summary>
    /// PromoteMode: Type of operation to apply on the read replica. This property is write only. Standalone means that the read
    /// replica will be promoted to a standalone server, and will become a completely independent entity from the replication
    /// set. Switchover means that the read replica will roles with the primary server.
    /// </summary>
    [JsonPropertyName("promoteMode")]
    public V20250801FlexibleServerSpecReplicaPromoteModeEnum? PromoteMode { get; set; }

    /// <summary>
    /// PromoteOption: Data synchronization option to use when processing the operation specified in the promoteMode property.
    /// This property is write only.
    /// </summary>
    [JsonPropertyName("promoteOption")]
    public V20250801FlexibleServerSpecReplicaPromoteOptionEnum? PromoteOption { get; set; }

    /// <summary>Role: Role of the server in a replication set.</summary>
    [JsonPropertyName("role")]
    public V20250801FlexibleServerSpecReplicaRoleEnum? Role { get; set; }
}

/// <summary>ReplicationRole: Role of the server in a replication set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecReplicationRoleEnum>))]
public enum V20250801FlexibleServerSpecReplicationRoleEnum
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

/// <summary>Tier: Tier of the compute assigned to a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecSkuTierEnum>))]
public enum V20250801FlexibleServerSpecSkuTierEnum
{
    [EnumMember(Value = "Burstable"), JsonStringEnumMemberName("Burstable")]
    Burstable,
    [EnumMember(Value = "GeneralPurpose"), JsonStringEnumMemberName("GeneralPurpose")]
    GeneralPurpose,
    [EnumMember(Value = "MemoryOptimized"), JsonStringEnumMemberName("MemoryOptimized")]
    MemoryOptimized
}

/// <summary>Sku: Compute tier and size of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecSku
{
    /// <summary>Name: Name by which is known a given compute size assigned to a server.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Tier: Tier of the compute assigned to a server.</summary>
    [JsonPropertyName("tier")]
    public required V20250801FlexibleServerSpecSkuTierEnum Tier { get; set; }
}

/// <summary>
/// SourceServerResourceReference: Identifier of the server to be used as the source of the new server. Required when
/// &apos;createMode&apos; is &apos;PointInTimeRestore&apos;, &apos;GeoRestore&apos;, &apos;Replica&apos;, or &apos;ReviveDropped&apos;. This property is returned only when
/// the target server is a read replica.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecSourceServerResourceReference
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
/// AutoGrow: Flag to enable or disable the automatic growth of storage size of a server when available space is nearing
/// zero and conditions allow for automatically growing storage size.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecStorageAutoGrowEnum>))]
public enum V20250801FlexibleServerSpecStorageAutoGrowEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Tier: Storage tier of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecStorageTierEnum>))]
public enum V20250801FlexibleServerSpecStorageTierEnum
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
/// Type: Type of storage assigned to a server. Allowed values are Premium_LRS, PremiumV2_LRS, or UltraSSD_LRS. If not
/// specified, it defaults to Premium_LRS.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecStorageTypeEnum>))]
public enum V20250801FlexibleServerSpecStorageTypeEnum
{
    [EnumMember(Value = "PremiumV2_LRS"), JsonStringEnumMemberName("PremiumV2_LRS")]
    PremiumV2LRS,
    [EnumMember(Value = "Premium_LRS"), JsonStringEnumMemberName("Premium_LRS")]
    PremiumLRS,
    [EnumMember(Value = "UltraSSD_LRS"), JsonStringEnumMemberName("UltraSSD_LRS")]
    UltraSSDLRS
}

/// <summary>Storage: Storage properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpecStorage
{
    /// <summary>
    /// AutoGrow: Flag to enable or disable the automatic growth of storage size of a server when available space is nearing
    /// zero and conditions allow for automatically growing storage size.
    /// </summary>
    [JsonPropertyName("autoGrow")]
    public V20250801FlexibleServerSpecStorageAutoGrowEnum? AutoGrow { get; set; }

    /// <summary>Iops: Maximum IOPS supported for storage. Required when type of storage is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("iops")]
    public int? Iops { get; set; }

    /// <summary>StorageSizeGB: Size of storage assigned to a server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }

    /// <summary>Throughput: Maximum throughput supported for storage. Required when type of storage is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }

    /// <summary>Tier: Storage tier of a server.</summary>
    [JsonPropertyName("tier")]
    public V20250801FlexibleServerSpecStorageTierEnum? Tier { get; set; }

    /// <summary>
    /// Type: Type of storage assigned to a server. Allowed values are Premium_LRS, PremiumV2_LRS, or UltraSSD_LRS. If not
    /// specified, it defaults to Premium_LRS.
    /// </summary>
    [JsonPropertyName("type")]
    public V20250801FlexibleServerSpecStorageTypeEnum? Type { get; set; }
}

/// <summary>Version: Major version of PostgreSQL database engine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250801FlexibleServerSpecVersionEnum>))]
public enum V20250801FlexibleServerSpecVersionEnum
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
    _16,
    [EnumMember(Value = "17"), JsonStringEnumMemberName("17")]
    _17,
    [EnumMember(Value = "18"), JsonStringEnumMemberName("18")]
    _18
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerSpec
{
    /// <summary>
    /// AdministratorLogin: Name of the login designated as the first password based administrator assigned to your instance of
    /// PostgreSQL. Must be specified the first time that you enable password based authentication on a server. Once set to a
    /// given value, it cannot be changed for the rest of the life of a server. If you disable password based authentication on
    /// a server which had it enabled, this password based role isn&apos;t deleted.
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>
    /// AdministratorLoginPassword: Password assigned to the administrator login. As long as password authentication is enabled,
    /// this password can be changed at any time.
    /// </summary>
    [JsonPropertyName("administratorLoginPassword")]
    public V20250801FlexibleServerSpecAdministratorLoginPassword? AdministratorLoginPassword { get; set; }

    /// <summary>AuthConfig: Authentication configuration properties of a server.</summary>
    [JsonPropertyName("authConfig")]
    public V20250801FlexibleServerSpecAuthConfig? AuthConfig { get; set; }

    /// <summary>AvailabilityZone: Availability zone of a server.</summary>
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
    public V20250801FlexibleServerSpecBackup? Backup { get; set; }

    /// <summary>Cluster: Cluster properties of a server.</summary>
    [JsonPropertyName("cluster")]
    public V20250801FlexibleServerSpecCluster? Cluster { get; set; }

    /// <summary>CreateMode: Creation mode of a new server.</summary>
    [JsonPropertyName("createMode")]
    public V20250801FlexibleServerSpecCreateModeEnum? CreateMode { get; set; }

    /// <summary>DataEncryption: Data encryption properties of a server.</summary>
    [JsonPropertyName("dataEncryption")]
    public V20250801FlexibleServerSpecDataEncryption? DataEncryption { get; set; }

    /// <summary>HighAvailability: High availability properties of a server.</summary>
    [JsonPropertyName("highAvailability")]
    public V20250801FlexibleServerSpecHighAvailability? HighAvailability { get; set; }

    /// <summary>Identity: User assigned managed identities assigned to the server.</summary>
    [JsonPropertyName("identity")]
    public V20250801FlexibleServerSpecIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MaintenanceWindow: Maintenance window properties of a server.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V20250801FlexibleServerSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>
    /// Network: Network properties of a server. Only required if you want your server to be integrated into a virtual network
    /// provided by customer.
    /// </summary>
    [JsonPropertyName("network")]
    public V20250801FlexibleServerSpecNetwork? Network { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250801FlexibleServerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250801FlexibleServerSpecOwner Owner { get; set; }

    /// <summary>
    /// PointInTimeUTC: Creation time (in ISO8601 format) of the backup which you want to restore in the new server. It&apos;s
    /// required when &apos;createMode&apos; is &apos;PointInTimeRestore&apos;, &apos;GeoRestore&apos;, or &apos;ReviveDropped&apos;.
    /// </summary>
    [JsonPropertyName("pointInTimeUTC")]
    public string? PointInTimeUTC { get; set; }

    /// <summary>Replica: Read replica properties of a server. Required only in case that you want to promote a server.</summary>
    [JsonPropertyName("replica")]
    public V20250801FlexibleServerSpecReplica? Replica { get; set; }

    /// <summary>ReplicationRole: Role of the server in a replication set.</summary>
    [JsonPropertyName("replicationRole")]
    public V20250801FlexibleServerSpecReplicationRoleEnum? ReplicationRole { get; set; }

    /// <summary>Sku: Compute tier and size of a server.</summary>
    [JsonPropertyName("sku")]
    public V20250801FlexibleServerSpecSku? Sku { get; set; }

    /// <summary>
    /// SourceServerResourceReference: Identifier of the server to be used as the source of the new server. Required when
    /// &apos;createMode&apos; is &apos;PointInTimeRestore&apos;, &apos;GeoRestore&apos;, &apos;Replica&apos;, or &apos;ReviveDropped&apos;. This property is returned only when
    /// the target server is a read replica.
    /// </summary>
    [JsonPropertyName("sourceServerResourceReference")]
    public V20250801FlexibleServerSpecSourceServerResourceReference? SourceServerResourceReference { get; set; }

    /// <summary>Storage: Storage properties of a server.</summary>
    [JsonPropertyName("storage")]
    public V20250801FlexibleServerSpecStorage? Storage { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Version: Major version of PostgreSQL database engine.</summary>
    [JsonPropertyName("version")]
    public V20250801FlexibleServerSpecVersionEnum? Version { get; set; }
}

/// <summary>AuthConfig: Authentication configuration properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusAuthConfig
{
    /// <summary>ActiveDirectoryAuth: Indicates if the server supports Microsoft Entra authentication.</summary>
    [JsonPropertyName("activeDirectoryAuth")]
    public string? ActiveDirectoryAuth { get; set; }

    /// <summary>PasswordAuth: Indicates if the server supports password based authentication.</summary>
    [JsonPropertyName("passwordAuth")]
    public string? PasswordAuth { get; set; }

    /// <summary>TenantId: Identifier of the tenant of the delegated resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Backup: Backup properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusBackup
{
    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>EarliestRestoreDate: Earliest restore point time (ISO8601 format) for a server.</summary>
    [JsonPropertyName("earliestRestoreDate")]
    public string? EarliestRestoreDate { get; set; }

    /// <summary>GeoRedundantBackup: Indicates if the server is configured to create geographically redundant backups.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public string? GeoRedundantBackup { get; set; }
}

/// <summary>Cluster: Cluster properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusCluster
{
    /// <summary>ClusterSize: Number of nodes assigned to the elastic cluster.</summary>
    [JsonPropertyName("clusterSize")]
    public int? ClusterSize { get; set; }

    /// <summary>DefaultDatabaseName: Default database name for the elastic cluster.</summary>
    [JsonPropertyName("defaultDatabaseName")]
    public string? DefaultDatabaseName { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusConditions
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
public partial class V20250801FlexibleServerStatusDataEncryption
{
    /// <summary>
    /// GeoBackupEncryptionKeyStatus: Status of key used by a server configured with data encryption based on customer managed
    /// key, to encrypt the geographically redundant storage associated to the server when it is configured to support
    /// geographically redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupEncryptionKeyStatus")]
    public string? GeoBackupEncryptionKeyStatus { get; set; }

    /// <summary>
    /// GeoBackupKeyURI: Identifier of the user assigned managed identity used to access the key in Azure Key Vault for data
    /// encryption of the geographically redundant storage associated to a server that is configured to support geographically
    /// redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupKeyURI")]
    public string? GeoBackupKeyURI { get; set; }

    /// <summary>
    /// GeoBackupUserAssignedIdentityId: Identifier of the user assigned managed identity used to access the key in Azure Key
    /// Vault for data encryption of the geographically redundant storage associated to a server that is configured to support
    /// geographically redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityId")]
    public string? GeoBackupUserAssignedIdentityId { get; set; }

    /// <summary>
    /// PrimaryEncryptionKeyStatus: Status of key used by a server configured with data encryption based on customer managed
    /// key, to encrypt the primary storage associated to the server.
    /// </summary>
    [JsonPropertyName("primaryEncryptionKeyStatus")]
    public string? PrimaryEncryptionKeyStatus { get; set; }

    /// <summary>PrimaryKeyURI: URI of the key in Azure Key Vault used for data encryption of the primary storage associated to a server.</summary>
    [JsonPropertyName("primaryKeyURI")]
    public string? PrimaryKeyURI { get; set; }

    /// <summary>
    /// PrimaryUserAssignedIdentityId: Identifier of the user assigned managed identity used to access the key in Azure Key
    /// Vault for data encryption of the primary storage associated to a server.
    /// </summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }

    /// <summary>Type: Data encryption type used by a server.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>HighAvailability: High availability properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusHighAvailability
{
    /// <summary>Mode: High availability mode for a server.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// StandbyAvailabilityZone: Availability zone associated to the standby server created when high availability is set to
    /// SameZone or ZoneRedundant.
    /// </summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }

    /// <summary>State: Possible states of the standby server created when high availability is set to SameZone or ZoneRedundant.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>User assigned managed identity associated with a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: Identifier of the client of the service principal associated to the user assigned managed identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: Identifier of the object of the service principal associated to the user assigned managed identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: User assigned managed identities assigned to the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusIdentity
{
    /// <summary>PrincipalId: Identifier of the object of the service principal associated to the user assigned managed identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: Identifier of the tenant of a server.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Types of identities associated with a server.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: Map of user assigned managed identities.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20250801FlexibleServerStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>MaintenanceWindow: Maintenance window properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusMaintenanceWindow
{
    /// <summary>CustomWindow: Indicates whether custom window is enabled or disabled.</summary>
    [JsonPropertyName("customWindow")]
    public string? CustomWindow { get; set; }

    /// <summary>DayOfWeek: Day of the week to be used for maintenance window.</summary>
    [JsonPropertyName("dayOfWeek")]
    public int? DayOfWeek { get; set; }

    /// <summary>StartHour: Start hour to be used for maintenance window.</summary>
    [JsonPropertyName("startHour")]
    public int? StartHour { get; set; }

    /// <summary>StartMinute: Start minute to be used for maintenance window.</summary>
    [JsonPropertyName("startMinute")]
    public int? StartMinute { get; set; }
}

/// <summary>
/// Network: Network properties of a server. Only required if you want your server to be integrated into a virtual network
/// provided by customer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusNetwork
{
    /// <summary>
    /// DelegatedSubnetResourceId: Resource identifier of the delegated subnet. Required during creation of a new server, in
    /// case you want the server to be integrated into your own virtual network. For an update operation, you only have to
    /// provide this property if you want to change the value assigned for the private DNS zone.
    /// </summary>
    [JsonPropertyName("delegatedSubnetResourceId")]
    public string? DelegatedSubnetResourceId { get; set; }

    /// <summary>
    /// PrivateDnsZoneArmResourceId: Identifier of the private DNS zone. Required during creation of a new server, in case you
    /// want the server to be integrated into your own virtual network. For an update operation, you only have to provide this
    /// property if you want to change the value assigned for the private DNS zone.
    /// </summary>
    [JsonPropertyName("privateDnsZoneArmResourceId")]
    public string? PrivateDnsZoneArmResourceId { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Indicates if public network access is enabled or not. This is only supported for servers that are
    /// not integrated into a virtual network which is owned and provided by customer when server is deployed.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }
}

/// <summary>The private endpoint connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Replica: Read replica properties of a server. Required only in case that you want to promote a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusReplica
{
    /// <summary>Capacity: Maximum number of read replicas allowed for a server.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>
    /// PromoteMode: Type of operation to apply on the read replica. This property is write only. Standalone means that the read
    /// replica will be promoted to a standalone server, and will become a completely independent entity from the replication
    /// set. Switchover means that the read replica will roles with the primary server.
    /// </summary>
    [JsonPropertyName("promoteMode")]
    public string? PromoteMode { get; set; }

    /// <summary>
    /// PromoteOption: Data synchronization option to use when processing the operation specified in the promoteMode property.
    /// This property is write only.
    /// </summary>
    [JsonPropertyName("promoteOption")]
    public string? PromoteOption { get; set; }

    /// <summary>
    /// ReplicationState: Indicates the replication state of a read replica. This property is returned only when the target
    /// server is a read replica. Possible  values are Active, Broken, Catchup, Provisioning, Reconfiguring, and Updating
    /// </summary>
    [JsonPropertyName("replicationState")]
    public string? ReplicationState { get; set; }

    /// <summary>Role: Role of the server in a replication set.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>Sku: Compute tier and size of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusSku
{
    /// <summary>Name: Name by which is known a given compute size assigned to a server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: Tier of the compute assigned to a server.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage: Storage properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusStorage
{
    /// <summary>
    /// AutoGrow: Flag to enable or disable the automatic growth of storage size of a server when available space is nearing
    /// zero and conditions allow for automatically growing storage size.
    /// </summary>
    [JsonPropertyName("autoGrow")]
    public string? AutoGrow { get; set; }

    /// <summary>Iops: Maximum IOPS supported for storage. Required when type of storage is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("iops")]
    public int? Iops { get; set; }

    /// <summary>StorageSizeGB: Size of storage assigned to a server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }

    /// <summary>Throughput: Maximum throughput supported for storage. Required when type of storage is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }

    /// <summary>Tier: Storage tier of a server.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>
    /// Type: Type of storage assigned to a server. Allowed values are Premium_LRS, PremiumV2_LRS, or UltraSSD_LRS. If not
    /// specified, it defaults to Premium_LRS.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250801FlexibleServerStatusSystemData
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
public partial class V20250801FlexibleServerStatus
{
    /// <summary>
    /// AdministratorLogin: Name of the login designated as the first password based administrator assigned to your instance of
    /// PostgreSQL. Must be specified the first time that you enable password based authentication on a server. Once set to a
    /// given value, it cannot be changed for the rest of the life of a server. If you disable password based authentication on
    /// a server which had it enabled, this password based role isn&apos;t deleted.
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>AuthConfig: Authentication configuration properties of a server.</summary>
    [JsonPropertyName("authConfig")]
    public V20250801FlexibleServerStatusAuthConfig? AuthConfig { get; set; }

    /// <summary>AvailabilityZone: Availability zone of a server.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Backup: Backup properties of a server.</summary>
    [JsonPropertyName("backup")]
    public V20250801FlexibleServerStatusBackup? Backup { get; set; }

    /// <summary>Cluster: Cluster properties of a server.</summary>
    [JsonPropertyName("cluster")]
    public V20250801FlexibleServerStatusCluster? Cluster { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250801FlexibleServerStatusConditions>? Conditions { get; set; }

    /// <summary>CreateMode: Creation mode of a new server.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>DataEncryption: Data encryption properties of a server.</summary>
    [JsonPropertyName("dataEncryption")]
    public V20250801FlexibleServerStatusDataEncryption? DataEncryption { get; set; }

    /// <summary>FullyQualifiedDomainName: Fully qualified domain name of a server.</summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public string? FullyQualifiedDomainName { get; set; }

    /// <summary>HighAvailability: High availability properties of a server.</summary>
    [JsonPropertyName("highAvailability")]
    public V20250801FlexibleServerStatusHighAvailability? HighAvailability { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: User assigned managed identities assigned to the server.</summary>
    [JsonPropertyName("identity")]
    public V20250801FlexibleServerStatusIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaintenanceWindow: Maintenance window properties of a server.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V20250801FlexibleServerStatusMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>MinorVersion: Minor version of PostgreSQL database engine.</summary>
    [JsonPropertyName("minorVersion")]
    public string? MinorVersion { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Network: Network properties of a server. Only required if you want your server to be integrated into a virtual network
    /// provided by customer.
    /// </summary>
    [JsonPropertyName("network")]
    public V20250801FlexibleServerStatusNetwork? Network { get; set; }

    /// <summary>
    /// PointInTimeUTC: Creation time (in ISO8601 format) of the backup which you want to restore in the new server. It&apos;s
    /// required when &apos;createMode&apos; is &apos;PointInTimeRestore&apos;, &apos;GeoRestore&apos;, or &apos;ReviveDropped&apos;.
    /// </summary>
    [JsonPropertyName("pointInTimeUTC")]
    public string? PointInTimeUTC { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connections associated with the specified server.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V20250801FlexibleServerStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>Replica: Read replica properties of a server. Required only in case that you want to promote a server.</summary>
    [JsonPropertyName("replica")]
    public V20250801FlexibleServerStatusReplica? Replica { get; set; }

    /// <summary>ReplicaCapacity: Maximum number of read replicas allowed for a server.</summary>
    [JsonPropertyName("replicaCapacity")]
    public int? ReplicaCapacity { get; set; }

    /// <summary>ReplicationRole: Role of the server in a replication set.</summary>
    [JsonPropertyName("replicationRole")]
    public string? ReplicationRole { get; set; }

    /// <summary>Sku: Compute tier and size of a server.</summary>
    [JsonPropertyName("sku")]
    public V20250801FlexibleServerStatusSku? Sku { get; set; }

    /// <summary>
    /// SourceServerResourceId: Identifier of the server to be used as the source of the new server. Required when &apos;createMode&apos;
    /// is &apos;PointInTimeRestore&apos;, &apos;GeoRestore&apos;, &apos;Replica&apos;, or &apos;ReviveDropped&apos;. This property is returned only when the target
    /// server is a read replica.
    /// </summary>
    [JsonPropertyName("sourceServerResourceId")]
    public string? SourceServerResourceId { get; set; }

    /// <summary>State: Possible states of a server.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Storage: Storage properties of a server.</summary>
    [JsonPropertyName("storage")]
    public V20250801FlexibleServerStatusStorage? Storage { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20250801FlexibleServerStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Version: Major version of PostgreSQL database engine.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2025-08-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250801FlexibleServer : IKubernetesObject<V1ObjectMeta>, ISpec<V20250801FlexibleServerSpec?>, IStatus<V20250801FlexibleServerStatus?>
{
    public const string KubeApiVersion = "v20250801";
    public const string KubeKind = "FlexibleServer";
    public const string KubeGroup = "dbforpostgresql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbforpostgresql.azure.com/v20250801";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250801FlexibleServerSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20250801FlexibleServerStatus? Status { get; set; }
}