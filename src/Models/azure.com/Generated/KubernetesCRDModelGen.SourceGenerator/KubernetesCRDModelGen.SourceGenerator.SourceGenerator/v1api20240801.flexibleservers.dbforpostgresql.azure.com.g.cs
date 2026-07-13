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
/// - Generated from: /postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/FlexibleServers.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240801FlexibleServerList : IKubernetesObject<V1ListMeta>, IItems<V1api20240801FlexibleServer>
{
    public const string KubeApiVersion = "v1api20240801";
    public const string KubeKind = "FlexibleServerList";
    public const string KubeGroup = "dbforpostgresql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbforpostgresql.azure.com/v1api20240801";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240801FlexibleServer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240801FlexibleServer> Items { get; set; }
}

/// <summary>
/// AdministratorLoginPassword: Password assigned to the administrator login. As long as password authentication is enabled,
/// this password can be changed at any time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecAdministratorLoginPassword
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecAuthConfigActiveDirectoryAuthEnum>))]
public enum V1api20240801FlexibleServerSpecAuthConfigActiveDirectoryAuthEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>PasswordAuth: Indicates if the server supports password based authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecAuthConfigPasswordAuthEnum>))]
public enum V1api20240801FlexibleServerSpecAuthConfigPasswordAuthEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>AuthConfig: Authentication configuration properties of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecAuthConfig
{
    /// <summary>ActiveDirectoryAuth: Indicates if the server supports Microsoft Entra authentication.</summary>
    [JsonPropertyName("activeDirectoryAuth")]
    public V1api20240801FlexibleServerSpecAuthConfigActiveDirectoryAuthEnum? ActiveDirectoryAuth { get; set; }

    /// <summary>PasswordAuth: Indicates if the server supports password based authentication.</summary>
    [JsonPropertyName("passwordAuth")]
    public V1api20240801FlexibleServerSpecAuthConfigPasswordAuthEnum? PasswordAuth { get; set; }

    /// <summary>TenantId: Identifier of the tenant of the delegated resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>GeoRedundantBackup: Indicates if the server is configured to create geographically redundant backups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecBackupGeoRedundantBackupEnum>))]
public enum V1api20240801FlexibleServerSpecBackupGeoRedundantBackupEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Backup: Backup properties of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecBackup
{
    /// <summary>BackupRetentionDays: Backup retention days for the flexible server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>GeoRedundantBackup: Indicates if the server is configured to create geographically redundant backups.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public V1api20240801FlexibleServerSpecBackupGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }
}

/// <summary>CreateMode: Creation mode of a new flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecCreateModeEnum>))]
public enum V1api20240801FlexibleServerSpecCreateModeEnum
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
/// GeoBackupEncryptionKeyStatus: Status of key used by a flexible server configured with data encryption based on customer
/// managed key, to encrypt the geographically redundant storage associated to the server when it is configured to support
/// geographically redundant backups.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecDataEncryptionGeoBackupEncryptionKeyStatusEnum>))]
public enum V1api20240801FlexibleServerSpecDataEncryptionGeoBackupEncryptionKeyStatusEnum
{
    [EnumMember(Value = "Invalid"), JsonStringEnumMemberName("Invalid")]
    Invalid,
    [EnumMember(Value = "Valid"), JsonStringEnumMemberName("Valid")]
    Valid
}

/// <summary>
/// GeoBackupKeyURIFromConfig: Identifier of the user assigned managed identity used to access the key in Azure Key Vault
/// for data encryption of the geographically redundant storage associated to a flexible server that is configured to
/// support geographically redundant backups.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecDataEncryptionGeoBackupKeyURIFromConfig
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
/// Key Vault for data encryption of the geographically redundant storage associated to a flexible server that is configured
/// to support geographically redundant backups.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecDataEncryptionGeoBackupUserAssignedIdentityReference
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
/// PrimaryEncryptionKeyStatus: Status of key used by a flexible server configured with data encryption based on customer
/// managed key, to encrypt the primary storage associated to the server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecDataEncryptionPrimaryEncryptionKeyStatusEnum>))]
public enum V1api20240801FlexibleServerSpecDataEncryptionPrimaryEncryptionKeyStatusEnum
{
    [EnumMember(Value = "Invalid"), JsonStringEnumMemberName("Invalid")]
    Invalid,
    [EnumMember(Value = "Valid"), JsonStringEnumMemberName("Valid")]
    Valid
}

/// <summary>
/// PrimaryKeyURIFromConfig: URI of the key in Azure Key Vault used for data encryption of the primary storage associated to
/// a flexible server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecDataEncryptionPrimaryKeyURIFromConfig
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
/// Key Vault for data encryption of the primary storage associated to a flexible server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecDataEncryptionPrimaryUserAssignedIdentityReference
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

/// <summary>Type: Data encryption type used by a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecDataEncryptionTypeEnum>))]
public enum V1api20240801FlexibleServerSpecDataEncryptionTypeEnum
{
    [EnumMember(Value = "AzureKeyVault"), JsonStringEnumMemberName("AzureKeyVault")]
    AzureKeyVault,
    [EnumMember(Value = "SystemManaged"), JsonStringEnumMemberName("SystemManaged")]
    SystemManaged
}

/// <summary>DataEncryption: Data encryption properties of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecDataEncryption
{
    /// <summary>
    /// GeoBackupEncryptionKeyStatus: Status of key used by a flexible server configured with data encryption based on customer
    /// managed key, to encrypt the geographically redundant storage associated to the server when it is configured to support
    /// geographically redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupEncryptionKeyStatus")]
    public V1api20240801FlexibleServerSpecDataEncryptionGeoBackupEncryptionKeyStatusEnum? GeoBackupEncryptionKeyStatus { get; set; }

    /// <summary>
    /// GeoBackupKeyURI: Identifier of the user assigned managed identity used to access the key in Azure Key Vault for data
    /// encryption of the geographically redundant storage associated to a flexible server that is configured to support
    /// geographically redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupKeyURI")]
    public string? GeoBackupKeyURI { get; set; }

    /// <summary>
    /// GeoBackupKeyURIFromConfig: Identifier of the user assigned managed identity used to access the key in Azure Key Vault
    /// for data encryption of the geographically redundant storage associated to a flexible server that is configured to
    /// support geographically redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupKeyURIFromConfig")]
    public V1api20240801FlexibleServerSpecDataEncryptionGeoBackupKeyURIFromConfig? GeoBackupKeyURIFromConfig { get; set; }

    /// <summary>
    /// GeoBackupUserAssignedIdentityReference: Identifier of the user assigned managed identity used to access the key in Azure
    /// Key Vault for data encryption of the geographically redundant storage associated to a flexible server that is configured
    /// to support geographically redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityReference")]
    public V1api20240801FlexibleServerSpecDataEncryptionGeoBackupUserAssignedIdentityReference? GeoBackupUserAssignedIdentityReference { get; set; }

    /// <summary>
    /// PrimaryEncryptionKeyStatus: Status of key used by a flexible server configured with data encryption based on customer
    /// managed key, to encrypt the primary storage associated to the server.
    /// </summary>
    [JsonPropertyName("primaryEncryptionKeyStatus")]
    public V1api20240801FlexibleServerSpecDataEncryptionPrimaryEncryptionKeyStatusEnum? PrimaryEncryptionKeyStatus { get; set; }

    /// <summary>
    /// PrimaryKeyURI: URI of the key in Azure Key Vault used for data encryption of the primary storage associated to a
    /// flexible server.
    /// </summary>
    [JsonPropertyName("primaryKeyURI")]
    public string? PrimaryKeyURI { get; set; }

    /// <summary>
    /// PrimaryKeyURIFromConfig: URI of the key in Azure Key Vault used for data encryption of the primary storage associated to
    /// a flexible server.
    /// </summary>
    [JsonPropertyName("primaryKeyURIFromConfig")]
    public V1api20240801FlexibleServerSpecDataEncryptionPrimaryKeyURIFromConfig? PrimaryKeyURIFromConfig { get; set; }

    /// <summary>
    /// PrimaryUserAssignedIdentityReference: Identifier of the user assigned managed identity used to access the key in Azure
    /// Key Vault for data encryption of the primary storage associated to a flexible server.
    /// </summary>
    [JsonPropertyName("primaryUserAssignedIdentityReference")]
    public V1api20240801FlexibleServerSpecDataEncryptionPrimaryUserAssignedIdentityReference? PrimaryUserAssignedIdentityReference { get; set; }

    /// <summary>Type: Data encryption type used by a flexible server.</summary>
    [JsonPropertyName("type")]
    public V1api20240801FlexibleServerSpecDataEncryptionTypeEnum? Type { get; set; }
}

/// <summary>Mode: High availability mode for a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecHighAvailabilityModeEnum>))]
public enum V1api20240801FlexibleServerSpecHighAvailabilityModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "SameZone"), JsonStringEnumMemberName("SameZone")]
    SameZone,
    [EnumMember(Value = "ZoneRedundant"), JsonStringEnumMemberName("ZoneRedundant")]
    ZoneRedundant
}

/// <summary>HighAvailability: High availability properties of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecHighAvailability
{
    /// <summary>Mode: High availability mode for a flexible server.</summary>
    [JsonPropertyName("mode")]
    public V1api20240801FlexibleServerSpecHighAvailabilityModeEnum? Mode { get; set; }

    /// <summary>
    /// StandbyAvailabilityZone: Availability zone associated to the standby server created when high availability is set to
    /// SameZone or ZoneRedundant.
    /// </summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }
}

/// <summary>Type: Types of identities associated with a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecIdentityTypeEnum>))]
public enum V1api20240801FlexibleServerSpecIdentityTypeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20240801FlexibleServerSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20240801FlexibleServerSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: User assigned managed identities assigned to the flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecIdentity
{
    /// <summary>PrincipalId: Identifier of the object of the service principal associated to the user assigned managed identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Type: Types of identities associated with a flexible server.</summary>
    [JsonPropertyName("type")]
    public required V1api20240801FlexibleServerSpecIdentityTypeEnum Type { get; set; }

    /// <summary>UserAssignedIdentities: Map of user assigned managed identities.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240801FlexibleServerSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>MaintenanceWindow: Maintenance window properties of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecMaintenanceWindow
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecNetworkDelegatedSubnetResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecNetworkPrivateDnsZoneArmResourceReference
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

/// <summary>PublicNetworkAccess: Indicates if public network access is enabled or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecNetworkPublicNetworkAccessEnum>))]
public enum V1api20240801FlexibleServerSpecNetworkPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// Network: Network properties of a flexible server. Only required if you want your server to be integrated into a virtual
/// network provided by customer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecNetwork
{
    /// <summary>
    /// DelegatedSubnetResourceReference: Resource identifier of the delegated subnet. Required during creation of a new server,
    /// in case you want the server to be integrated into your own virtual network. For an update operation, you only have to
    /// provide this property if you want to change the value assigned for the private DNS zone.
    /// </summary>
    [JsonPropertyName("delegatedSubnetResourceReference")]
    public V1api20240801FlexibleServerSpecNetworkDelegatedSubnetResourceReference? DelegatedSubnetResourceReference { get; set; }

    /// <summary>
    /// PrivateDnsZoneArmResourceReference: Identifier of the private DNS zone. Required during creation of a new server, in
    /// case you want the server to be integrated into your own virtual network. For an update operation, you only have to
    /// provide this property if you want to change the value assigned for the private DNS zone.
    /// </summary>
    [JsonPropertyName("privateDnsZoneArmResourceReference")]
    public V1api20240801FlexibleServerSpecNetworkPrivateDnsZoneArmResourceReference? PrivateDnsZoneArmResourceReference { get; set; }

    /// <summary>PublicNetworkAccess: Indicates if public network access is enabled or not.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20240801FlexibleServerSpecNetworkPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName
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
public partial class V1api20240801FlexibleServerSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName config map should be placed. If omitted, no
    /// config map will be created.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V1api20240801FlexibleServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecOperatorSpecSecretExpressions
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
public partial class V1api20240801FlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName
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
public partial class V1api20240801FlexibleServerSpecOperatorSpecSecrets
{
    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V1api20240801FlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240801FlexibleServerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20240801FlexibleServerSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240801FlexibleServerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20240801FlexibleServerSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecOwner
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecReplicaPromoteModeEnum>))]
public enum V1api20240801FlexibleServerSpecReplicaPromoteModeEnum
{
    [EnumMember(Value = "standalone"), JsonStringEnumMemberName("standalone")]
    Standalone,
    [EnumMember(Value = "switchover"), JsonStringEnumMemberName("switchover")]
    Switchover
}

/// <summary>
/// PromoteOption: Data synchronization option to use when processing the operation specified in the promoteMode property
/// This property is write only. Planned means that the operation will wait for data in the read replica to be fully
/// synchronized with its source server before it initiates the operation. Forced means that the operation will not wait for
/// data in the read replica to be synchronized with its source server before it initiates the operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecReplicaPromoteOptionEnum>))]
public enum V1api20240801FlexibleServerSpecReplicaPromoteOptionEnum
{
    [EnumMember(Value = "forced"), JsonStringEnumMemberName("forced")]
    Forced,
    [EnumMember(Value = "planned"), JsonStringEnumMemberName("planned")]
    Planned
}

/// <summary>Role: Role of the server in a replication set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecReplicaRoleEnum>))]
public enum V1api20240801FlexibleServerSpecReplicaRoleEnum
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

/// <summary>Replica: Read replica properties of a flexible server. Required only in case that you want to promote a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecReplica
{
    /// <summary>
    /// PromoteMode: Type of operation to apply on the read replica. This property is write only. Standalone means that the read
    /// replica will be promoted to a standalone server, and will become a completely independent entity from the replication
    /// set. Switchover means that the read replica will roles with the primary server.
    /// </summary>
    [JsonPropertyName("promoteMode")]
    public V1api20240801FlexibleServerSpecReplicaPromoteModeEnum? PromoteMode { get; set; }

    /// <summary>
    /// PromoteOption: Data synchronization option to use when processing the operation specified in the promoteMode property
    /// This property is write only. Planned means that the operation will wait for data in the read replica to be fully
    /// synchronized with its source server before it initiates the operation. Forced means that the operation will not wait for
    /// data in the read replica to be synchronized with its source server before it initiates the operation.
    /// </summary>
    [JsonPropertyName("promoteOption")]
    public V1api20240801FlexibleServerSpecReplicaPromoteOptionEnum? PromoteOption { get; set; }

    /// <summary>Role: Role of the server in a replication set.</summary>
    [JsonPropertyName("role")]
    public V1api20240801FlexibleServerSpecReplicaRoleEnum? Role { get; set; }
}

/// <summary>ReplicationRole: Role of the server in a replication set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecReplicationRoleEnum>))]
public enum V1api20240801FlexibleServerSpecReplicationRoleEnum
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

/// <summary>Tier: Tier of the compute assigned to a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecSkuTierEnum>))]
public enum V1api20240801FlexibleServerSpecSkuTierEnum
{
    [EnumMember(Value = "Burstable"), JsonStringEnumMemberName("Burstable")]
    Burstable,
    [EnumMember(Value = "GeneralPurpose"), JsonStringEnumMemberName("GeneralPurpose")]
    GeneralPurpose,
    [EnumMember(Value = "MemoryOptimized"), JsonStringEnumMemberName("MemoryOptimized")]
    MemoryOptimized
}

/// <summary>Sku: Compute tier and size of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecSku
{
    /// <summary>Name: Name by which is known a given compute size assigned to a flexible server.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Tier: Tier of the compute assigned to a flexible server.</summary>
    [JsonPropertyName("tier")]
    public required V1api20240801FlexibleServerSpecSkuTierEnum Tier { get; set; }
}

/// <summary>
/// SourceServerResourceReference: Identifier of the flexible server to be used as the source of the new flexible server.
/// Required when &apos;createMode&apos; is &apos;PointInTimeRestore&apos;, &apos;GeoRestore&apos;, &apos;Replica&apos;, or &apos;ReviveDropped&apos;. This property is
/// returned only when the target flexible server is a read replica.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecSourceServerResourceReference
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
/// AutoGrow: Flag to enable or disable the automatic growth of storage size of a flexible server when available space is
/// nearing zero and conditions allow for automatically growing storage size.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecStorageAutoGrowEnum>))]
public enum V1api20240801FlexibleServerSpecStorageAutoGrowEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Tier: Storage tier of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecStorageTierEnum>))]
public enum V1api20240801FlexibleServerSpecStorageTierEnum
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
/// Type: Type of storage assigned to a flexible server. Allowed values are Premium_LRS or PremiumV2_LRS. If not specified,
/// it defaults to Premium_LRS.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecStorageTypeEnum>))]
public enum V1api20240801FlexibleServerSpecStorageTypeEnum
{
    [EnumMember(Value = "PremiumV2_LRS"), JsonStringEnumMemberName("PremiumV2_LRS")]
    PremiumV2LRS,
    [EnumMember(Value = "Premium_LRS"), JsonStringEnumMemberName("Premium_LRS")]
    PremiumLRS
}

/// <summary>Storage: Storage properties of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpecStorage
{
    /// <summary>
    /// AutoGrow: Flag to enable or disable the automatic growth of storage size of a flexible server when available space is
    /// nearing zero and conditions allow for automatically growing storage size.
    /// </summary>
    [JsonPropertyName("autoGrow")]
    public V1api20240801FlexibleServerSpecStorageAutoGrowEnum? AutoGrow { get; set; }

    /// <summary>Iops: Maximum IOPS supported for storage. Required when type of storage is PremiumV2_LRS.</summary>
    [JsonPropertyName("iops")]
    public int? Iops { get; set; }

    /// <summary>StorageSizeGB: Size of storage assigned to a flexible server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }

    /// <summary>Throughput: Maximum throughput supported for storage. Required when type of storage is PremiumV2_LRS.</summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }

    /// <summary>Tier: Storage tier of a flexible server.</summary>
    [JsonPropertyName("tier")]
    public V1api20240801FlexibleServerSpecStorageTierEnum? Tier { get; set; }

    /// <summary>
    /// Type: Type of storage assigned to a flexible server. Allowed values are Premium_LRS or PremiumV2_LRS. If not specified,
    /// it defaults to Premium_LRS.
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20240801FlexibleServerSpecStorageTypeEnum? Type { get; set; }
}

/// <summary>Version: Major version of PostgreSQL database engine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240801FlexibleServerSpecVersionEnum>))]
public enum V1api20240801FlexibleServerSpecVersionEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerSpec
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
    public V1api20240801FlexibleServerSpecAdministratorLoginPassword? AdministratorLoginPassword { get; set; }

    /// <summary>AuthConfig: Authentication configuration properties of a flexible server.</summary>
    [JsonPropertyName("authConfig")]
    public V1api20240801FlexibleServerSpecAuthConfig? AuthConfig { get; set; }

    /// <summary>AvailabilityZone: Availability zone of a flexible server.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Backup: Backup properties of a flexible server.</summary>
    [JsonPropertyName("backup")]
    public V1api20240801FlexibleServerSpecBackup? Backup { get; set; }

    /// <summary>CreateMode: Creation mode of a new flexible server.</summary>
    [JsonPropertyName("createMode")]
    public V1api20240801FlexibleServerSpecCreateModeEnum? CreateMode { get; set; }

    /// <summary>DataEncryption: Data encryption properties of a flexible server.</summary>
    [JsonPropertyName("dataEncryption")]
    public V1api20240801FlexibleServerSpecDataEncryption? DataEncryption { get; set; }

    /// <summary>HighAvailability: High availability properties of a flexible server.</summary>
    [JsonPropertyName("highAvailability")]
    public V1api20240801FlexibleServerSpecHighAvailability? HighAvailability { get; set; }

    /// <summary>Identity: User assigned managed identities assigned to the flexible server.</summary>
    [JsonPropertyName("identity")]
    public V1api20240801FlexibleServerSpecIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MaintenanceWindow: Maintenance window properties of a flexible server.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1api20240801FlexibleServerSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>
    /// Network: Network properties of a flexible server. Only required if you want your server to be integrated into a virtual
    /// network provided by customer.
    /// </summary>
    [JsonPropertyName("network")]
    public V1api20240801FlexibleServerSpecNetwork? Network { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240801FlexibleServerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240801FlexibleServerSpecOwner Owner { get; set; }

    /// <summary>
    /// PointInTimeUTC: Creation time (in ISO8601 format) of the backup which you want to restore in the new flexible server.
    /// It&apos;s required when &apos;createMode&apos; is &apos;PointInTimeRestore&apos;, &apos;GeoRestore&apos;, or &apos;ReviveDropped&apos;.
    /// </summary>
    [JsonPropertyName("pointInTimeUTC")]
    public string? PointInTimeUTC { get; set; }

    /// <summary>Replica: Read replica properties of a flexible server. Required only in case that you want to promote a server.</summary>
    [JsonPropertyName("replica")]
    public V1api20240801FlexibleServerSpecReplica? Replica { get; set; }

    /// <summary>ReplicationRole: Role of the server in a replication set.</summary>
    [JsonPropertyName("replicationRole")]
    public V1api20240801FlexibleServerSpecReplicationRoleEnum? ReplicationRole { get; set; }

    /// <summary>Sku: Compute tier and size of a flexible server.</summary>
    [JsonPropertyName("sku")]
    public V1api20240801FlexibleServerSpecSku? Sku { get; set; }

    /// <summary>
    /// SourceServerResourceReference: Identifier of the flexible server to be used as the source of the new flexible server.
    /// Required when &apos;createMode&apos; is &apos;PointInTimeRestore&apos;, &apos;GeoRestore&apos;, &apos;Replica&apos;, or &apos;ReviveDropped&apos;. This property is
    /// returned only when the target flexible server is a read replica.
    /// </summary>
    [JsonPropertyName("sourceServerResourceReference")]
    public V1api20240801FlexibleServerSpecSourceServerResourceReference? SourceServerResourceReference { get; set; }

    /// <summary>Storage: Storage properties of a flexible server.</summary>
    [JsonPropertyName("storage")]
    public V1api20240801FlexibleServerSpecStorage? Storage { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Version: Major version of PostgreSQL database engine.</summary>
    [JsonPropertyName("version")]
    public V1api20240801FlexibleServerSpecVersionEnum? Version { get; set; }
}

/// <summary>AuthConfig: Authentication configuration properties of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusAuthConfig
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

/// <summary>Backup: Backup properties of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusBackup
{
    /// <summary>BackupRetentionDays: Backup retention days for the flexible server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>EarliestRestoreDate: Earliest restore point time (ISO8601 format) for a flexible server.</summary>
    [JsonPropertyName("earliestRestoreDate")]
    public string? EarliestRestoreDate { get; set; }

    /// <summary>GeoRedundantBackup: Indicates if the server is configured to create geographically redundant backups.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public string? GeoRedundantBackup { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusConditions
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

/// <summary>DataEncryption: Data encryption properties of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusDataEncryption
{
    /// <summary>
    /// GeoBackupEncryptionKeyStatus: Status of key used by a flexible server configured with data encryption based on customer
    /// managed key, to encrypt the geographically redundant storage associated to the server when it is configured to support
    /// geographically redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupEncryptionKeyStatus")]
    public string? GeoBackupEncryptionKeyStatus { get; set; }

    /// <summary>
    /// GeoBackupKeyURI: Identifier of the user assigned managed identity used to access the key in Azure Key Vault for data
    /// encryption of the geographically redundant storage associated to a flexible server that is configured to support
    /// geographically redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupKeyURI")]
    public string? GeoBackupKeyURI { get; set; }

    /// <summary>
    /// GeoBackupUserAssignedIdentityId: Identifier of the user assigned managed identity used to access the key in Azure Key
    /// Vault for data encryption of the geographically redundant storage associated to a flexible server that is configured to
    /// support geographically redundant backups.
    /// </summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityId")]
    public string? GeoBackupUserAssignedIdentityId { get; set; }

    /// <summary>
    /// PrimaryEncryptionKeyStatus: Status of key used by a flexible server configured with data encryption based on customer
    /// managed key, to encrypt the primary storage associated to the server.
    /// </summary>
    [JsonPropertyName("primaryEncryptionKeyStatus")]
    public string? PrimaryEncryptionKeyStatus { get; set; }

    /// <summary>
    /// PrimaryKeyURI: URI of the key in Azure Key Vault used for data encryption of the primary storage associated to a
    /// flexible server.
    /// </summary>
    [JsonPropertyName("primaryKeyURI")]
    public string? PrimaryKeyURI { get; set; }

    /// <summary>
    /// PrimaryUserAssignedIdentityId: Identifier of the user assigned managed identity used to access the key in Azure Key
    /// Vault for data encryption of the primary storage associated to a flexible server.
    /// </summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }

    /// <summary>Type: Data encryption type used by a flexible server.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>HighAvailability: High availability properties of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusHighAvailability
{
    /// <summary>Mode: High availability mode for a flexible server.</summary>
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

/// <summary>User assigned managed identity associated with a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: Identifier of the client of the service principal associated to the user assigned managed identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: Identifier of the object of the service principal associated to the user assigned managed identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: User assigned managed identities assigned to the flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusIdentity
{
    /// <summary>PrincipalId: Identifier of the object of the service principal associated to the user assigned managed identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: Identifier of the tenant of a flexible server.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Types of identities associated with a flexible server.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: Map of user assigned managed identities.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20240801FlexibleServerStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>MaintenanceWindow: Maintenance window properties of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusMaintenanceWindow
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
/// Network: Network properties of a flexible server. Only required if you want your server to be integrated into a virtual
/// network provided by customer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusNetwork
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

    /// <summary>PublicNetworkAccess: Indicates if public network access is enabled or not.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }
}

/// <summary>The private endpoint connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Replica: Read replica properties of a flexible server. Required only in case that you want to promote a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusReplica
{
    /// <summary>Capacity: Maximum number of read replicas allowed for a flexible server.</summary>
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
    /// PromoteOption: Data synchronization option to use when processing the operation specified in the promoteMode property
    /// This property is write only. Planned means that the operation will wait for data in the read replica to be fully
    /// synchronized with its source server before it initiates the operation. Forced means that the operation will not wait for
    /// data in the read replica to be synchronized with its source server before it initiates the operation.
    /// </summary>
    [JsonPropertyName("promoteOption")]
    public string? PromoteOption { get; set; }

    /// <summary>
    /// ReplicationState: Indicates the replication state of a read replica. This property is returned only when the target
    /// flexible server is a read replica. Possible  values are Active, Broken, Catchup, Provisioning, Reconfiguring, and
    /// Updating
    /// </summary>
    [JsonPropertyName("replicationState")]
    public string? ReplicationState { get; set; }

    /// <summary>Role: Role of the server in a replication set.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>Sku: Compute tier and size of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusSku
{
    /// <summary>Name: Name by which is known a given compute size assigned to a flexible server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: Tier of the compute assigned to a flexible server.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage: Storage properties of a flexible server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusStorage
{
    /// <summary>
    /// AutoGrow: Flag to enable or disable the automatic growth of storage size of a flexible server when available space is
    /// nearing zero and conditions allow for automatically growing storage size.
    /// </summary>
    [JsonPropertyName("autoGrow")]
    public string? AutoGrow { get; set; }

    /// <summary>Iops: Maximum IOPS supported for storage. Required when type of storage is PremiumV2_LRS.</summary>
    [JsonPropertyName("iops")]
    public int? Iops { get; set; }

    /// <summary>StorageSizeGB: Size of storage assigned to a flexible server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }

    /// <summary>Throughput: Maximum throughput supported for storage. Required when type of storage is PremiumV2_LRS.</summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }

    /// <summary>Tier: Storage tier of a flexible server.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>
    /// Type: Type of storage assigned to a flexible server. Allowed values are Premium_LRS or PremiumV2_LRS. If not specified,
    /// it defaults to Premium_LRS.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240801FlexibleServerStatusSystemData
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
public partial class V1api20240801FlexibleServerStatus
{
    /// <summary>
    /// AdministratorLogin: Name of the login designated as the first password based administrator assigned to your instance of
    /// PostgreSQL. Must be specified the first time that you enable password based authentication on a server. Once set to a
    /// given value, it cannot be changed for the rest of the life of a server. If you disable password based authentication on
    /// a server which had it enabled, this password based role isn&apos;t deleted.
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>AuthConfig: Authentication configuration properties of a flexible server.</summary>
    [JsonPropertyName("authConfig")]
    public V1api20240801FlexibleServerStatusAuthConfig? AuthConfig { get; set; }

    /// <summary>AvailabilityZone: Availability zone of a flexible server.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Backup: Backup properties of a flexible server.</summary>
    [JsonPropertyName("backup")]
    public V1api20240801FlexibleServerStatusBackup? Backup { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240801FlexibleServerStatusConditions>? Conditions { get; set; }

    /// <summary>CreateMode: Creation mode of a new flexible server.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>DataEncryption: Data encryption properties of a flexible server.</summary>
    [JsonPropertyName("dataEncryption")]
    public V1api20240801FlexibleServerStatusDataEncryption? DataEncryption { get; set; }

    /// <summary>FullyQualifiedDomainName: Fully qualified domain name of a flexible server.</summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public string? FullyQualifiedDomainName { get; set; }

    /// <summary>HighAvailability: High availability properties of a flexible server.</summary>
    [JsonPropertyName("highAvailability")]
    public V1api20240801FlexibleServerStatusHighAvailability? HighAvailability { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: User assigned managed identities assigned to the flexible server.</summary>
    [JsonPropertyName("identity")]
    public V1api20240801FlexibleServerStatusIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaintenanceWindow: Maintenance window properties of a flexible server.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1api20240801FlexibleServerStatusMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>MinorVersion: Minor version of PostgreSQL database engine.</summary>
    [JsonPropertyName("minorVersion")]
    public string? MinorVersion { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Network: Network properties of a flexible server. Only required if you want your server to be integrated into a virtual
    /// network provided by customer.
    /// </summary>
    [JsonPropertyName("network")]
    public V1api20240801FlexibleServerStatusNetwork? Network { get; set; }

    /// <summary>
    /// PointInTimeUTC: Creation time (in ISO8601 format) of the backup which you want to restore in the new flexible server.
    /// It&apos;s required when &apos;createMode&apos; is &apos;PointInTimeRestore&apos;, &apos;GeoRestore&apos;, or &apos;ReviveDropped&apos;.
    /// </summary>
    [JsonPropertyName("pointInTimeUTC")]
    public string? PointInTimeUTC { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connections associated with the specified flexible server.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20240801FlexibleServerStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>Replica: Read replica properties of a flexible server. Required only in case that you want to promote a server.</summary>
    [JsonPropertyName("replica")]
    public V1api20240801FlexibleServerStatusReplica? Replica { get; set; }

    /// <summary>ReplicaCapacity: Maximum number of read replicas allowed for a flexible server.</summary>
    [JsonPropertyName("replicaCapacity")]
    public int? ReplicaCapacity { get; set; }

    /// <summary>ReplicationRole: Role of the server in a replication set.</summary>
    [JsonPropertyName("replicationRole")]
    public string? ReplicationRole { get; set; }

    /// <summary>Sku: Compute tier and size of a flexible server.</summary>
    [JsonPropertyName("sku")]
    public V1api20240801FlexibleServerStatusSku? Sku { get; set; }

    /// <summary>
    /// SourceServerResourceId: Identifier of the flexible server to be used as the source of the new flexible server. Required
    /// when &apos;createMode&apos; is &apos;PointInTimeRestore&apos;, &apos;GeoRestore&apos;, &apos;Replica&apos;, or &apos;ReviveDropped&apos;. This property is returned only
    /// when the target flexible server is a read replica.
    /// </summary>
    [JsonPropertyName("sourceServerResourceId")]
    public string? SourceServerResourceId { get; set; }

    /// <summary>State: Possible states of a flexible server.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Storage: Storage properties of a flexible server.</summary>
    [JsonPropertyName("storage")]
    public V1api20240801FlexibleServerStatusStorage? Storage { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240801FlexibleServerStatusSystemData? SystemData { get; set; }

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
/// - Generated from: /postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/FlexibleServers.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240801FlexibleServer : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240801FlexibleServerSpec?>, IStatus<V1api20240801FlexibleServerStatus?>
{
    public const string KubeApiVersion = "v1api20240801";
    public const string KubeKind = "FlexibleServer";
    public const string KubeGroup = "dbforpostgresql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbforpostgresql.azure.com/v1api20240801";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240801FlexibleServerSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20240801FlexibleServerStatus? Status { get; set; }
}