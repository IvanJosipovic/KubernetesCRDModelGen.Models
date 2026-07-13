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
/// - Generated from: /mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2021-05-01/mysql.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20210501FlexibleServerList : IKubernetesObject<V1ListMeta>, IItems<V20210501FlexibleServer>
{
    public const string KubeApiVersion = "v20210501";
    public const string KubeKind = "FlexibleServerList";
    public const string KubeGroup = "dbformysql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbformysql.azure.com/v20210501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20210501FlexibleServer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20210501FlexibleServer> Items { get; set; }
}

/// <summary>AdministratorLoginPassword: The password of the administrator login (required for server creation).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecAdministratorLoginPassword
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
[JsonConverter(typeof(JsonStringEnumConverter<V20210501FlexibleServerSpecBackupGeoRedundantBackupEnum>))]
public enum V20210501FlexibleServerSpecBackupGeoRedundantBackupEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Backup: Backup related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecBackup
{
    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>GeoRedundantBackup: Whether or not geo redundant backup is enabled.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public V20210501FlexibleServerSpecBackupGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }
}

/// <summary>CreateMode: The mode to create a new MySQL server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210501FlexibleServerSpecCreateModeEnum>))]
public enum V20210501FlexibleServerSpecCreateModeEnum
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
public partial class V20210501FlexibleServerSpecDataEncryptionGeoBackupUserAssignedIdentityReference
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
public partial class V20210501FlexibleServerSpecDataEncryptionPrimaryUserAssignedIdentityReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V20210501FlexibleServerSpecDataEncryptionTypeEnum>))]
public enum V20210501FlexibleServerSpecDataEncryptionTypeEnum
{
    [EnumMember(Value = "AzureKeyVault"), JsonStringEnumMemberName("AzureKeyVault")]
    AzureKeyVault,
    [EnumMember(Value = "SystemManaged"), JsonStringEnumMemberName("SystemManaged")]
    SystemManaged
}

/// <summary>DataEncryption: The Data Encryption for CMK.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecDataEncryption
{
    /// <summary>GeoBackupKeyURI: Geo backup key uri as key vault can&apos;t cross region, need cmk in same region as geo backup</summary>
    [JsonPropertyName("geoBackupKeyURI")]
    public string? GeoBackupKeyURI { get; set; }

    /// <summary>
    /// GeoBackupUserAssignedIdentityReference: Geo backup user identity resource id as identity can&apos;t cross region, need
    /// identity in same region as geo backup
    /// </summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityReference")]
    public V20210501FlexibleServerSpecDataEncryptionGeoBackupUserAssignedIdentityReference? GeoBackupUserAssignedIdentityReference { get; set; }

    /// <summary>PrimaryKeyURI: Primary key uri</summary>
    [JsonPropertyName("primaryKeyURI")]
    public string? PrimaryKeyURI { get; set; }

    /// <summary>PrimaryUserAssignedIdentityReference: Primary user identity resource id</summary>
    [JsonPropertyName("primaryUserAssignedIdentityReference")]
    public V20210501FlexibleServerSpecDataEncryptionPrimaryUserAssignedIdentityReference? PrimaryUserAssignedIdentityReference { get; set; }

    /// <summary>Type: The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
    [JsonPropertyName("type")]
    public V20210501FlexibleServerSpecDataEncryptionTypeEnum? Type { get; set; }
}

/// <summary>Mode: High availability mode for a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210501FlexibleServerSpecHighAvailabilityModeEnum>))]
public enum V20210501FlexibleServerSpecHighAvailabilityModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "SameZone"), JsonStringEnumMemberName("SameZone")]
    SameZone,
    [EnumMember(Value = "ZoneRedundant"), JsonStringEnumMemberName("ZoneRedundant")]
    ZoneRedundant
}

/// <summary>HighAvailability: High availability related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecHighAvailability
{
    /// <summary>Mode: High availability mode for a server.</summary>
    [JsonPropertyName("mode")]
    public V20210501FlexibleServerSpecHighAvailabilityModeEnum? Mode { get; set; }

    /// <summary>StandbyAvailabilityZone: Availability zone of the standby server.</summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }
}

/// <summary>Type: Type of managed service identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210501FlexibleServerSpecIdentityTypeEnum>))]
public enum V20210501FlexibleServerSpecIdentityTypeEnum
{
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecIdentityUserAssignedIdentitiesReference
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
public partial class V20210501FlexibleServerSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20210501FlexibleServerSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The cmk identity for the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecIdentity
{
    /// <summary>Type: Type of managed service identity.</summary>
    [JsonPropertyName("type")]
    public V20210501FlexibleServerSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentities: Metadata of user assigned identity.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20210501FlexibleServerSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>MaintenanceWindow: Maintenance window of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecMaintenanceWindow
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

/// <summary>DelegatedSubnetResourceReference: Delegated subnet resource id used to setup vnet for a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecNetworkDelegatedSubnetResourceReference
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
public partial class V20210501FlexibleServerSpecNetworkPrivateDnsZoneResourceReference
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

/// <summary>Network: Network related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecNetwork
{
    /// <summary>DelegatedSubnetResourceReference: Delegated subnet resource id used to setup vnet for a server.</summary>
    [JsonPropertyName("delegatedSubnetResourceReference")]
    public V20210501FlexibleServerSpecNetworkDelegatedSubnetResourceReference? DelegatedSubnetResourceReference { get; set; }

    /// <summary>PrivateDnsZoneResourceReference: Private DNS zone resource id.</summary>
    [JsonPropertyName("privateDnsZoneResourceReference")]
    public V20210501FlexibleServerSpecNetworkPrivateDnsZoneResourceReference? PrivateDnsZoneResourceReference { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecOperatorSpecConfigMapExpressions
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
public partial class V20210501FlexibleServerSpecOperatorSpecConfigMapsAdministratorLogin
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
public partial class V20210501FlexibleServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName
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
public partial class V20210501FlexibleServerSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// AdministratorLogin: indicates where the AdministratorLogin config map should be placed. If omitted, no config map will
    /// be created.
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public V20210501FlexibleServerSpecOperatorSpecConfigMapsAdministratorLogin? AdministratorLogin { get; set; }

    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName config map should be placed. If omitted, no
    /// config map will be created.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V20210501FlexibleServerSpecOperatorSpecConfigMapsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecOperatorSpecSecretExpressions
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
public partial class V20210501FlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName
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
public partial class V20210501FlexibleServerSpecOperatorSpecSecrets
{
    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V20210501FlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20210501FlexibleServerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V20210501FlexibleServerSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20210501FlexibleServerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V20210501FlexibleServerSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ReplicationRole: The replication role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210501FlexibleServerSpecReplicationRoleEnum>))]
public enum V20210501FlexibleServerSpecReplicationRoleEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V20210501FlexibleServerSpecSkuTierEnum>))]
public enum V20210501FlexibleServerSpecSkuTierEnum
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
public partial class V20210501FlexibleServerSpecSku
{
    /// <summary>Name: The name of the sku, e.g. Standard_D32s_v3.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Tier: The tier of the particular SKU, e.g. GeneralPurpose.</summary>
    [JsonPropertyName("tier")]
    public required V20210501FlexibleServerSpecSkuTierEnum Tier { get; set; }
}

/// <summary>AutoGrow: Enable Storage Auto Grow or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210501FlexibleServerSpecStorageAutoGrowEnum>))]
public enum V20210501FlexibleServerSpecStorageAutoGrowEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Storage: Storage related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpecStorage
{
    /// <summary>AutoGrow: Enable Storage Auto Grow or not.</summary>
    [JsonPropertyName("autoGrow")]
    public V20210501FlexibleServerSpecStorageAutoGrowEnum? AutoGrow { get; set; }

    /// <summary>Iops: Storage IOPS for a server.</summary>
    [JsonPropertyName("iops")]
    public int? Iops { get; set; }

    /// <summary>StorageSizeGB: Max storage size allowed for a server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerSpec
{
    /// <summary>
    /// AdministratorLogin: The administrator&apos;s login name of a server. Can only be specified when the server is being created
    /// (and is required for creation).
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>AdministratorLoginPassword: The password of the administrator login (required for server creation).</summary>
    [JsonPropertyName("administratorLoginPassword")]
    public V20210501FlexibleServerSpecAdministratorLoginPassword? AdministratorLoginPassword { get; set; }

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
    public V20210501FlexibleServerSpecBackup? Backup { get; set; }

    /// <summary>CreateMode: The mode to create a new MySQL server.</summary>
    [JsonPropertyName("createMode")]
    public V20210501FlexibleServerSpecCreateModeEnum? CreateMode { get; set; }

    /// <summary>DataEncryption: The Data Encryption for CMK.</summary>
    [JsonPropertyName("dataEncryption")]
    public V20210501FlexibleServerSpecDataEncryption? DataEncryption { get; set; }

    /// <summary>HighAvailability: High availability related properties of a server.</summary>
    [JsonPropertyName("highAvailability")]
    public V20210501FlexibleServerSpecHighAvailability? HighAvailability { get; set; }

    /// <summary>Identity: The cmk identity for the server.</summary>
    [JsonPropertyName("identity")]
    public V20210501FlexibleServerSpecIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MaintenanceWindow: Maintenance window of a server.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V20210501FlexibleServerSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>Network: Network related properties of a server.</summary>
    [JsonPropertyName("network")]
    public V20210501FlexibleServerSpecNetwork? Network { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20210501FlexibleServerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20210501FlexibleServerSpecOwner Owner { get; set; }

    /// <summary>ReplicationRole: The replication role.</summary>
    [JsonPropertyName("replicationRole")]
    public V20210501FlexibleServerSpecReplicationRoleEnum? ReplicationRole { get; set; }

    /// <summary>RestorePointInTime: Restore point creation time (ISO8601 format), specifying the time to restore from.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>Sku: The SKU (pricing tier) of the server.</summary>
    [JsonPropertyName("sku")]
    public V20210501FlexibleServerSpecSku? Sku { get; set; }

    /// <summary>SourceServerResourceId: The source MySQL server id.</summary>
    [JsonPropertyName("sourceServerResourceId")]
    public string? SourceServerResourceId { get; set; }

    /// <summary>Storage: Storage related properties of a server.</summary>
    [JsonPropertyName("storage")]
    public V20210501FlexibleServerSpecStorage? Storage { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Version: Server version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Backup: Backup related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerStatusBackup
{
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
public partial class V20210501FlexibleServerStatusConditions
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
public partial class V20210501FlexibleServerStatusDataEncryption
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
public partial class V20210501FlexibleServerStatusHighAvailability
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

/// <summary>Identity: The cmk identity for the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerStatusIdentity
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
    public IDictionary<string, JsonNode>? UserAssignedIdentities { get; set; }
}

/// <summary>MaintenanceWindow: Maintenance window of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerStatusMaintenanceWindow
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

/// <summary>Network: Network related properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerStatusNetwork
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

/// <summary>Sku: The SKU (pricing tier) of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerStatusSku
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
public partial class V20210501FlexibleServerStatusStorage
{
    /// <summary>AutoGrow: Enable Storage Auto Grow or not.</summary>
    [JsonPropertyName("autoGrow")]
    public string? AutoGrow { get; set; }

    /// <summary>Iops: Storage IOPS for a server.</summary>
    [JsonPropertyName("iops")]
    public int? Iops { get; set; }

    /// <summary>StorageSizeGB: Max storage size allowed for a server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }

    /// <summary>StorageSku: The sku name of the server storage.</summary>
    [JsonPropertyName("storageSku")]
    public string? StorageSku { get; set; }
}

/// <summary>SystemData: The system metadata relating to this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210501FlexibleServerStatusSystemData
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
public partial class V20210501FlexibleServerStatus
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
    public V20210501FlexibleServerStatusBackup? Backup { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20210501FlexibleServerStatusConditions>? Conditions { get; set; }

    /// <summary>CreateMode: The mode to create a new MySQL server.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>DataEncryption: The Data Encryption for CMK.</summary>
    [JsonPropertyName("dataEncryption")]
    public V20210501FlexibleServerStatusDataEncryption? DataEncryption { get; set; }

    /// <summary>FullyQualifiedDomainName: The fully qualified domain name of a server.</summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public string? FullyQualifiedDomainName { get; set; }

    /// <summary>HighAvailability: High availability related properties of a server.</summary>
    [JsonPropertyName("highAvailability")]
    public V20210501FlexibleServerStatusHighAvailability? HighAvailability { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The cmk identity for the server.</summary>
    [JsonPropertyName("identity")]
    public V20210501FlexibleServerStatusIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaintenanceWindow: Maintenance window of a server.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V20210501FlexibleServerStatusMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Network: Network related properties of a server.</summary>
    [JsonPropertyName("network")]
    public V20210501FlexibleServerStatusNetwork? Network { get; set; }

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
    public V20210501FlexibleServerStatusSku? Sku { get; set; }

    /// <summary>SourceServerResourceId: The source MySQL server id.</summary>
    [JsonPropertyName("sourceServerResourceId")]
    public string? SourceServerResourceId { get; set; }

    /// <summary>State: The state of a server.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Storage: Storage related properties of a server.</summary>
    [JsonPropertyName("storage")]
    public V20210501FlexibleServerStatusStorage? Storage { get; set; }

    /// <summary>SystemData: The system metadata relating to this resource.</summary>
    [JsonPropertyName("systemData")]
    public V20210501FlexibleServerStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Version: Server version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2021-05-01/mysql.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20210501FlexibleServer : IKubernetesObject<V1ObjectMeta>, ISpec<V20210501FlexibleServerSpec?>, IStatus<V20210501FlexibleServerStatus?>
{
    public const string KubeApiVersion = "v20210501";
    public const string KubeKind = "FlexibleServer";
    public const string KubeGroup = "dbformysql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbformysql.azure.com/v20210501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20210501FlexibleServerSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20210501FlexibleServerStatus? Status { get; set; }
}