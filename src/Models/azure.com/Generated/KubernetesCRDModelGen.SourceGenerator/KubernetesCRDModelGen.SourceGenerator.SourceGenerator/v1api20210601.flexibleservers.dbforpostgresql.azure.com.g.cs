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
/// - Generated from: /postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2021-06-01/postgresql.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601FlexibleServerList : IKubernetesObject<V1ListMeta>, IItems<V1api20210601FlexibleServer>
{
    public const string KubeApiVersion = "v1api20210601";
    public const string KubeKind = "FlexibleServerList";
    public const string KubeGroup = "dbforpostgresql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbforpostgresql.azure.com/v1api20210601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210601FlexibleServer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210601FlexibleServer> Items { get; set; }
}

/// <summary>AdministratorLoginPassword: The administrator login password (required for server creation).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecAdministratorLoginPassword
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

/// <summary>GeoRedundantBackup: A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601FlexibleServerSpecBackupGeoRedundantBackupEnum>))]
public enum V1api20210601FlexibleServerSpecBackupGeoRedundantBackupEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Backup: Backup properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecBackup
{
    /// <summary>BackupRetentionDays: Backup retention days for the server.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>GeoRedundantBackup: A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
    [JsonPropertyName("geoRedundantBackup")]
    public V1api20210601FlexibleServerSpecBackupGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }
}

/// <summary>CreateMode: The mode to create a new PostgreSQL server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601FlexibleServerSpecCreateModeEnum>))]
public enum V1api20210601FlexibleServerSpecCreateModeEnum
{
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "PointInTimeRestore"), JsonStringEnumMemberName("PointInTimeRestore")]
    PointInTimeRestore,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update
}

/// <summary>Mode: The HA mode for the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601FlexibleServerSpecHighAvailabilityModeEnum>))]
public enum V1api20210601FlexibleServerSpecHighAvailabilityModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "ZoneRedundant"), JsonStringEnumMemberName("ZoneRedundant")]
    ZoneRedundant
}

/// <summary>HighAvailability: High availability properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecHighAvailability
{
    /// <summary>Mode: The HA mode for the server.</summary>
    [JsonPropertyName("mode")]
    public V1api20210601FlexibleServerSpecHighAvailabilityModeEnum? Mode { get; set; }

    /// <summary>StandbyAvailabilityZone: availability zone information of the standby.</summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }
}

/// <summary>MaintenanceWindow: Maintenance window properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecMaintenanceWindow
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

/// <summary>DelegatedSubnetResourceReference: delegated subnet arm resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecNetworkDelegatedSubnetResourceReference
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

/// <summary>PrivateDnsZoneArmResourceReference: private dns zone arm resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecNetworkPrivateDnsZoneArmResourceReference
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

/// <summary>Network: Network properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecNetwork
{
    /// <summary>DelegatedSubnetResourceReference: delegated subnet arm resource id.</summary>
    [JsonPropertyName("delegatedSubnetResourceReference")]
    public V1api20210601FlexibleServerSpecNetworkDelegatedSubnetResourceReference? DelegatedSubnetResourceReference { get; set; }

    /// <summary>PrivateDnsZoneArmResourceReference: private dns zone arm resource id.</summary>
    [JsonPropertyName("privateDnsZoneArmResourceReference")]
    public V1api20210601FlexibleServerSpecNetworkPrivateDnsZoneArmResourceReference? PrivateDnsZoneArmResourceReference { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecOperatorSpecConfigMapExpressions
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
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecOperatorSpecSecretExpressions
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
public partial class V1api20210601FlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName
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
public partial class V1api20210601FlexibleServerSpecOperatorSpecSecrets
{
    /// <summary>
    /// FullyQualifiedDomainName: indicates where the FullyQualifiedDomainName secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V1api20210601FlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210601FlexibleServerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210601FlexibleServerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20210601FlexibleServerSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Tier: The tier of the particular SKU, e.g. Burstable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601FlexibleServerSpecSkuTierEnum>))]
public enum V1api20210601FlexibleServerSpecSkuTierEnum
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
public partial class V1api20210601FlexibleServerSpecSku
{
    /// <summary>Name: The name of the sku, typically, tier + family + cores, e.g. Standard_D4s_v3.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Tier: The tier of the particular SKU, e.g. Burstable.</summary>
    [JsonPropertyName("tier")]
    public required V1api20210601FlexibleServerSpecSkuTierEnum Tier { get; set; }
}

/// <summary>
/// SourceServerResourceReference: The source server resource ID to restore from. It&apos;s required when &apos;createMode&apos; is
/// &apos;PointInTimeRestore&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecSourceServerResourceReference
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

/// <summary>Storage: Storage properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpecStorage
{
    /// <summary>StorageSizeGB: Max storage allowed for a server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }
}

/// <summary>Version: PostgreSQL Server version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210601FlexibleServerSpecVersionEnum>))]
public enum V1api20210601FlexibleServerSpecVersionEnum
{
    [EnumMember(Value = "11"), JsonStringEnumMemberName("11")]
    _11,
    [EnumMember(Value = "12"), JsonStringEnumMemberName("12")]
    _12,
    [EnumMember(Value = "13"), JsonStringEnumMemberName("13")]
    _13,
    [EnumMember(Value = "14"), JsonStringEnumMemberName("14")]
    _14
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerSpec
{
    /// <summary>
    /// AdministratorLogin: The administrator&apos;s login name of a server. Can only be specified when the server is being created
    /// (and is required for creation).
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>AdministratorLoginPassword: The administrator login password (required for server creation).</summary>
    [JsonPropertyName("administratorLoginPassword")]
    public V1api20210601FlexibleServerSpecAdministratorLoginPassword? AdministratorLoginPassword { get; set; }

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
    public V1api20210601FlexibleServerSpecBackup? Backup { get; set; }

    /// <summary>CreateMode: The mode to create a new PostgreSQL server.</summary>
    [JsonPropertyName("createMode")]
    public V1api20210601FlexibleServerSpecCreateModeEnum? CreateMode { get; set; }

    /// <summary>HighAvailability: High availability properties of a server.</summary>
    [JsonPropertyName("highAvailability")]
    public V1api20210601FlexibleServerSpecHighAvailability? HighAvailability { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MaintenanceWindow: Maintenance window properties of a server.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1api20210601FlexibleServerSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>Network: Network properties of a server.</summary>
    [JsonPropertyName("network")]
    public V1api20210601FlexibleServerSpecNetwork? Network { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210601FlexibleServerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210601FlexibleServerSpecOwner Owner { get; set; }

    /// <summary>
    /// PointInTimeUTC: Restore point creation time (ISO8601 format), specifying the time to restore from. It&apos;s required when
    /// &apos;createMode&apos; is &apos;PointInTimeRestore&apos;.
    /// </summary>
    [JsonPropertyName("pointInTimeUTC")]
    public string? PointInTimeUTC { get; set; }

    /// <summary>Sku: The SKU (pricing tier) of the server.</summary>
    [JsonPropertyName("sku")]
    public V1api20210601FlexibleServerSpecSku? Sku { get; set; }

    /// <summary>
    /// SourceServerResourceReference: The source server resource ID to restore from. It&apos;s required when &apos;createMode&apos; is
    /// &apos;PointInTimeRestore&apos;.
    /// </summary>
    [JsonPropertyName("sourceServerResourceReference")]
    public V1api20210601FlexibleServerSpecSourceServerResourceReference? SourceServerResourceReference { get; set; }

    /// <summary>Storage: Storage properties of a server.</summary>
    [JsonPropertyName("storage")]
    public V1api20210601FlexibleServerSpecStorage? Storage { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Version: PostgreSQL Server version.</summary>
    [JsonPropertyName("version")]
    public V1api20210601FlexibleServerSpecVersionEnum? Version { get; set; }
}

/// <summary>Backup: Backup properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerStatusBackup
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
public partial class V1api20210601FlexibleServerStatusConditions
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

/// <summary>HighAvailability: High availability properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerStatusHighAvailability
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

/// <summary>MaintenanceWindow: Maintenance window properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerStatusMaintenanceWindow
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

/// <summary>Network: Network properties of a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerStatusNetwork
{
    /// <summary>DelegatedSubnetResourceId: delegated subnet arm resource id.</summary>
    [JsonPropertyName("delegatedSubnetResourceId")]
    public string? DelegatedSubnetResourceId { get; set; }

    /// <summary>PrivateDnsZoneArmResourceId: private dns zone arm resource id.</summary>
    [JsonPropertyName("privateDnsZoneArmResourceId")]
    public string? PrivateDnsZoneArmResourceId { get; set; }

    /// <summary>PublicNetworkAccess: public network access is enabled or not</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }
}

/// <summary>Sku: The SKU (pricing tier) of the server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerStatusSku
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
public partial class V1api20210601FlexibleServerStatusStorage
{
    /// <summary>StorageSizeGB: Max storage allowed for a server.</summary>
    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }
}

/// <summary>SystemData: The system metadata relating to this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601FlexibleServerStatusSystemData
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
public partial class V1api20210601FlexibleServerStatus
{
    /// <summary>
    /// AdministratorLogin: The administrator&apos;s login name of a server. Can only be specified when the server is being created
    /// (and is required for creation).
    /// </summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>AvailabilityZone: availability zone information of the server.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Backup: Backup properties of a server.</summary>
    [JsonPropertyName("backup")]
    public V1api20210601FlexibleServerStatusBackup? Backup { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210601FlexibleServerStatusConditions>? Conditions { get; set; }

    /// <summary>CreateMode: The mode to create a new PostgreSQL server.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>FullyQualifiedDomainName: The fully qualified domain name of a server.</summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public string? FullyQualifiedDomainName { get; set; }

    /// <summary>HighAvailability: High availability properties of a server.</summary>
    [JsonPropertyName("highAvailability")]
    public V1api20210601FlexibleServerStatusHighAvailability? HighAvailability { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaintenanceWindow: Maintenance window properties of a server.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1api20210601FlexibleServerStatusMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>MinorVersion: The minor version of the server.</summary>
    [JsonPropertyName("minorVersion")]
    public string? MinorVersion { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Network: Network properties of a server.</summary>
    [JsonPropertyName("network")]
    public V1api20210601FlexibleServerStatusNetwork? Network { get; set; }

    /// <summary>
    /// PointInTimeUTC: Restore point creation time (ISO8601 format), specifying the time to restore from. It&apos;s required when
    /// &apos;createMode&apos; is &apos;PointInTimeRestore&apos;.
    /// </summary>
    [JsonPropertyName("pointInTimeUTC")]
    public string? PointInTimeUTC { get; set; }

    /// <summary>Sku: The SKU (pricing tier) of the server.</summary>
    [JsonPropertyName("sku")]
    public V1api20210601FlexibleServerStatusSku? Sku { get; set; }

    /// <summary>
    /// SourceServerResourceId: The source server resource ID to restore from. It&apos;s required when &apos;createMode&apos; is
    /// &apos;PointInTimeRestore&apos;.
    /// </summary>
    [JsonPropertyName("sourceServerResourceId")]
    public string? SourceServerResourceId { get; set; }

    /// <summary>State: A state of a server that is visible to user.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Storage: Storage properties of a server.</summary>
    [JsonPropertyName("storage")]
    public V1api20210601FlexibleServerStatusStorage? Storage { get; set; }

    /// <summary>SystemData: The system metadata relating to this resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20210601FlexibleServerStatusSystemData? SystemData { get; set; }

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
/// - Generated from: /postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2021-06-01/postgresql.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601FlexibleServer : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210601FlexibleServerSpec?>, IStatus<V1api20210601FlexibleServerStatus?>
{
    public const string KubeApiVersion = "v1api20210601";
    public const string KubeKind = "FlexibleServer";
    public const string KubeGroup = "dbforpostgresql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbforpostgresql.azure.com/v1api20210601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210601FlexibleServerSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20210601FlexibleServerStatus? Status { get; set; }
}