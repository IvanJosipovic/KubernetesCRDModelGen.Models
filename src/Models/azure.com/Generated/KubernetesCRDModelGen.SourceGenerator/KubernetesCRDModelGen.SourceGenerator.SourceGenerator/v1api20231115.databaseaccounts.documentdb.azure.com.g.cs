#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentdb.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2023-11-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115DatabaseAccountList : IKubernetesObject<V1ListMeta>, IItems<V1api20231115DatabaseAccount>
{
    public const string KubeApiVersion = "v1api20231115";
    public const string KubeKind = "DatabaseAccountList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "databaseaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20231115";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseAccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20231115DatabaseAccount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20231115DatabaseAccount> Items { get; set; }
}

/// <summary>SchemaType: Describes the types of schema for analytical storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecAnalyticalStorageConfigurationSchemaTypeEnum>))]
public enum V1api20231115DatabaseAccountSpecAnalyticalStorageConfigurationSchemaTypeEnum
{
    [EnumMember(Value = "FullFidelity"), JsonStringEnumMemberName("FullFidelity")]
    FullFidelity,
    [EnumMember(Value = "WellDefined"), JsonStringEnumMemberName("WellDefined")]
    WellDefined
}

/// <summary>AnalyticalStorageConfiguration: Analytical storage specific properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecAnalyticalStorageConfiguration
{
    /// <summary>SchemaType: Describes the types of schema for analytical storage.</summary>
    [JsonPropertyName("schemaType")]
    public V1api20231115DatabaseAccountSpecAnalyticalStorageConfigurationSchemaTypeEnum? SchemaType { get; set; }
}

/// <summary>ServerVersion: Describes the ServerVersion of an a MongoDB account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecApiPropertiesServerVersionEnum>))]
public enum V1api20231115DatabaseAccountSpecApiPropertiesServerVersionEnum
{
    [EnumMember(Value = "3.2"), JsonStringEnumMemberName("3.2")]
    _32,
    [EnumMember(Value = "3.6"), JsonStringEnumMemberName("3.6")]
    _36,
    [EnumMember(Value = "4.0"), JsonStringEnumMemberName("4.0")]
    _40,
    [EnumMember(Value = "4.2"), JsonStringEnumMemberName("4.2")]
    _42
}

/// <summary>ApiProperties: API specific properties. Currently, supported only for MongoDB API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecApiProperties
{
    /// <summary>ServerVersion: Describes the ServerVersion of an a MongoDB account.</summary>
    [JsonPropertyName("serverVersion")]
    public V1api20231115DatabaseAccountSpecApiPropertiesServerVersionEnum? ServerVersion { get; set; }
}

/// <summary>Tier: Enum to indicate type of Continuous backup mode</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecBackupPolicyContinuousContinuousModePropertiesTierEnum>))]
public enum V1api20231115DatabaseAccountSpecBackupPolicyContinuousContinuousModePropertiesTierEnum
{
    [EnumMember(Value = "Continuous30Days"), JsonStringEnumMemberName("Continuous30Days")]
    Continuous30Days,
    [EnumMember(Value = "Continuous7Days"), JsonStringEnumMemberName("Continuous7Days")]
    Continuous7Days
}

/// <summary>ContinuousModeProperties: Configuration values for continuous mode backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecBackupPolicyContinuousContinuousModeProperties
{
    /// <summary>Tier: Enum to indicate type of Continuous backup mode</summary>
    [JsonPropertyName("tier")]
    public V1api20231115DatabaseAccountSpecBackupPolicyContinuousContinuousModePropertiesTierEnum? Tier { get; set; }
}

/// <summary>Status: Describes the status of migration between backup policy types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecBackupPolicyContinuousMigrationStateStatusEnum>))]
public enum V1api20231115DatabaseAccountSpecBackupPolicyContinuousMigrationStateStatusEnum
{
    [EnumMember(Value = "Completed"), JsonStringEnumMemberName("Completed")]
    Completed,
    [EnumMember(Value = "Failed"), JsonStringEnumMemberName("Failed")]
    Failed,
    [EnumMember(Value = "InProgress"), JsonStringEnumMemberName("InProgress")]
    InProgress,
    [EnumMember(Value = "Invalid"), JsonStringEnumMemberName("Invalid")]
    Invalid
}

/// <summary>TargetType: Describes the target backup policy type of the backup policy migration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecBackupPolicyContinuousMigrationStateTargetTypeEnum>))]
public enum V1api20231115DatabaseAccountSpecBackupPolicyContinuousMigrationStateTargetTypeEnum
{
    [EnumMember(Value = "Continuous"), JsonStringEnumMemberName("Continuous")]
    Continuous,
    [EnumMember(Value = "Periodic"), JsonStringEnumMemberName("Periodic")]
    Periodic
}

/// <summary>MigrationState: The object representing the state of the migration between the backup policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecBackupPolicyContinuousMigrationState
{
    /// <summary>StartTime: Time at which the backup policy migration started (ISO-8601 format).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Status: Describes the status of migration between backup policy types.</summary>
    [JsonPropertyName("status")]
    public V1api20231115DatabaseAccountSpecBackupPolicyContinuousMigrationStateStatusEnum? Status { get; set; }

    /// <summary>TargetType: Describes the target backup policy type of the backup policy migration.</summary>
    [JsonPropertyName("targetType")]
    public V1api20231115DatabaseAccountSpecBackupPolicyContinuousMigrationStateTargetTypeEnum? TargetType { get; set; }
}

/// <summary>Type: Describes the mode of backups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecBackupPolicyContinuousTypeEnum>))]
public enum V1api20231115DatabaseAccountSpecBackupPolicyContinuousTypeEnum
{
    [EnumMember(Value = "Continuous"), JsonStringEnumMemberName("Continuous")]
    Continuous
}

/// <summary>Continuous: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecBackupPolicyContinuous
{
    /// <summary>ContinuousModeProperties: Configuration values for continuous mode backup</summary>
    [JsonPropertyName("continuousModeProperties")]
    public V1api20231115DatabaseAccountSpecBackupPolicyContinuousContinuousModeProperties? ContinuousModeProperties { get; set; }

    /// <summary>MigrationState: The object representing the state of the migration between the backup policies.</summary>
    [JsonPropertyName("migrationState")]
    public V1api20231115DatabaseAccountSpecBackupPolicyContinuousMigrationState? MigrationState { get; set; }

    /// <summary>Type: Describes the mode of backups.</summary>
    [JsonPropertyName("type")]
    public required V1api20231115DatabaseAccountSpecBackupPolicyContinuousTypeEnum Type { get; set; }
}

/// <summary>Status: Describes the status of migration between backup policy types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecBackupPolicyPeriodicMigrationStateStatusEnum>))]
public enum V1api20231115DatabaseAccountSpecBackupPolicyPeriodicMigrationStateStatusEnum
{
    [EnumMember(Value = "Completed"), JsonStringEnumMemberName("Completed")]
    Completed,
    [EnumMember(Value = "Failed"), JsonStringEnumMemberName("Failed")]
    Failed,
    [EnumMember(Value = "InProgress"), JsonStringEnumMemberName("InProgress")]
    InProgress,
    [EnumMember(Value = "Invalid"), JsonStringEnumMemberName("Invalid")]
    Invalid
}

/// <summary>TargetType: Describes the target backup policy type of the backup policy migration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecBackupPolicyPeriodicMigrationStateTargetTypeEnum>))]
public enum V1api20231115DatabaseAccountSpecBackupPolicyPeriodicMigrationStateTargetTypeEnum
{
    [EnumMember(Value = "Continuous"), JsonStringEnumMemberName("Continuous")]
    Continuous,
    [EnumMember(Value = "Periodic"), JsonStringEnumMemberName("Periodic")]
    Periodic
}

/// <summary>MigrationState: The object representing the state of the migration between the backup policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecBackupPolicyPeriodicMigrationState
{
    /// <summary>StartTime: Time at which the backup policy migration started (ISO-8601 format).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Status: Describes the status of migration between backup policy types.</summary>
    [JsonPropertyName("status")]
    public V1api20231115DatabaseAccountSpecBackupPolicyPeriodicMigrationStateStatusEnum? Status { get; set; }

    /// <summary>TargetType: Describes the target backup policy type of the backup policy migration.</summary>
    [JsonPropertyName("targetType")]
    public V1api20231115DatabaseAccountSpecBackupPolicyPeriodicMigrationStateTargetTypeEnum? TargetType { get; set; }
}

/// <summary>BackupStorageRedundancy: Enum to indicate type of backup residency</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecBackupPolicyPeriodicPeriodicModePropertiesBackupStorageRedundancyEnum>))]
public enum V1api20231115DatabaseAccountSpecBackupPolicyPeriodicPeriodicModePropertiesBackupStorageRedundancyEnum
{
    [EnumMember(Value = "Geo"), JsonStringEnumMemberName("Geo")]
    Geo,
    [EnumMember(Value = "Local"), JsonStringEnumMemberName("Local")]
    Local,
    [EnumMember(Value = "Zone"), JsonStringEnumMemberName("Zone")]
    Zone
}

/// <summary>PeriodicModeProperties: Configuration values for periodic mode backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecBackupPolicyPeriodicPeriodicModeProperties
{
    /// <summary>BackupIntervalInMinutes: An integer representing the interval in minutes between two backups</summary>
    [JsonPropertyName("backupIntervalInMinutes")]
    public int? BackupIntervalInMinutes { get; set; }

    /// <summary>BackupRetentionIntervalInHours: An integer representing the time (in hours) that each backup is retained</summary>
    [JsonPropertyName("backupRetentionIntervalInHours")]
    public int? BackupRetentionIntervalInHours { get; set; }

    /// <summary>BackupStorageRedundancy: Enum to indicate type of backup residency</summary>
    [JsonPropertyName("backupStorageRedundancy")]
    public V1api20231115DatabaseAccountSpecBackupPolicyPeriodicPeriodicModePropertiesBackupStorageRedundancyEnum? BackupStorageRedundancy { get; set; }
}

/// <summary>Type: Describes the mode of backups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecBackupPolicyPeriodicTypeEnum>))]
public enum V1api20231115DatabaseAccountSpecBackupPolicyPeriodicTypeEnum
{
    [EnumMember(Value = "Periodic"), JsonStringEnumMemberName("Periodic")]
    Periodic
}

/// <summary>Periodic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecBackupPolicyPeriodic
{
    /// <summary>MigrationState: The object representing the state of the migration between the backup policies.</summary>
    [JsonPropertyName("migrationState")]
    public V1api20231115DatabaseAccountSpecBackupPolicyPeriodicMigrationState? MigrationState { get; set; }

    /// <summary>PeriodicModeProperties: Configuration values for periodic mode backup</summary>
    [JsonPropertyName("periodicModeProperties")]
    public V1api20231115DatabaseAccountSpecBackupPolicyPeriodicPeriodicModeProperties? PeriodicModeProperties { get; set; }

    /// <summary>Type: Describes the mode of backups.</summary>
    [JsonPropertyName("type")]
    public required V1api20231115DatabaseAccountSpecBackupPolicyPeriodicTypeEnum Type { get; set; }
}

/// <summary>BackupPolicy: The object representing the policy for taking backups on an account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecBackupPolicy
{
    /// <summary>Continuous: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("continuous")]
    public V1api20231115DatabaseAccountSpecBackupPolicyContinuous? Continuous { get; set; }

    /// <summary>Periodic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("periodic")]
    public V1api20231115DatabaseAccountSpecBackupPolicyPeriodic? Periodic { get; set; }
}

/// <summary>Cosmos DB capability object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecCapabilities
{
    /// <summary>
    /// Name: Name of the Cosmos DB capability. For example, &quot;name&quot;: &quot;EnableCassandra&quot;. Current values also include
    /// &quot;EnableTable&quot; and &quot;EnableGremlin&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Capacity: The object that represents all properties related to capacity enforcement on an account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecCapacity
{
    /// <summary>
    /// TotalThroughputLimit: The total throughput limit imposed on the account. A totalThroughputLimit of 2000 imposes a strict
    /// limit of max throughput that can be provisioned on that account to be 2000. A totalThroughputLimit of -1 indicates no
    /// limits on provisioning of throughput.
    /// </summary>
    [JsonPropertyName("totalThroughputLimit")]
    public int? TotalThroughputLimit { get; set; }
}

/// <summary>ConnectorOffer: The cassandra connector offer type for the Cosmos DB database C* account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecConnectorOfferEnum>))]
public enum V1api20231115DatabaseAccountSpecConnectorOfferEnum
{
    [EnumMember(Value = "Small"), JsonStringEnumMemberName("Small")]
    Small
}

/// <summary>DefaultConsistencyLevel: The default consistency level and configuration settings of the Cosmos DB account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecConsistencyPolicyDefaultConsistencyLevelEnum>))]
public enum V1api20231115DatabaseAccountSpecConsistencyPolicyDefaultConsistencyLevelEnum
{
    [EnumMember(Value = "BoundedStaleness"), JsonStringEnumMemberName("BoundedStaleness")]
    BoundedStaleness,
    [EnumMember(Value = "ConsistentPrefix"), JsonStringEnumMemberName("ConsistentPrefix")]
    ConsistentPrefix,
    [EnumMember(Value = "Eventual"), JsonStringEnumMemberName("Eventual")]
    Eventual,
    [EnumMember(Value = "Session"), JsonStringEnumMemberName("Session")]
    Session,
    [EnumMember(Value = "Strong"), JsonStringEnumMemberName("Strong")]
    Strong
}

/// <summary>ConsistencyPolicy: The consistency policy for the Cosmos DB account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecConsistencyPolicy
{
    /// <summary>DefaultConsistencyLevel: The default consistency level and configuration settings of the Cosmos DB account.</summary>
    [JsonPropertyName("defaultConsistencyLevel")]
    public required V1api20231115DatabaseAccountSpecConsistencyPolicyDefaultConsistencyLevelEnum DefaultConsistencyLevel { get; set; }

    /// <summary>
    /// MaxIntervalInSeconds: When used with the Bounded Staleness consistency level, this value represents the time amount of
    /// staleness (in seconds) tolerated. Accepted range for this value is 5 - 86400. Required when defaultConsistencyPolicy is
    /// set to &apos;BoundedStaleness&apos;.
    /// </summary>
    [JsonPropertyName("maxIntervalInSeconds")]
    public int? MaxIntervalInSeconds { get; set; }

    /// <summary>
    /// MaxStalenessPrefix: When used with the Bounded Staleness consistency level, this value represents the number of stale
    /// requests tolerated. Accepted range for this value is 1 – 2,147,483,647. Required when defaultConsistencyPolicy is set
    /// to &apos;BoundedStaleness&apos;.
    /// </summary>
    [JsonPropertyName("maxStalenessPrefix")]
    public int? MaxStalenessPrefix { get; set; }
}

/// <summary>The CORS policy for the Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecCors
{
    /// <summary>AllowedHeaders: The request headers that the origin domain may specify on the CORS request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public string? AllowedHeaders { get; set; }

    /// <summary>AllowedMethods: The methods (HTTP request verbs) that the origin domain may use for a CORS request.</summary>
    [JsonPropertyName("allowedMethods")]
    public string? AllowedMethods { get; set; }

    /// <summary>AllowedOrigins: The origin domains that are permitted to make a request against the service via CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public required string AllowedOrigins { get; set; }

    /// <summary>
    /// ExposedHeaders: The response headers that may be sent in the response to the CORS request and exposed by the browser to
    /// the request issuer.
    /// </summary>
    [JsonPropertyName("exposedHeaders")]
    public string? ExposedHeaders { get; set; }

    /// <summary>MaxAgeInSeconds: The maximum amount time that a browser should cache the preflight OPTIONS request.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>CreateMode: Enum to indicate the mode of account creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecCreateModeEnum>))]
public enum V1api20231115DatabaseAccountSpecCreateModeEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "Restore"), JsonStringEnumMemberName("Restore")]
    Restore
}

/// <summary>DatabaseAccountOfferType: The offer type for the database</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecDatabaseAccountOfferTypeEnum>))]
public enum V1api20231115DatabaseAccountSpecDatabaseAccountOfferTypeEnum
{
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>
/// Type: The type of identity used for the resource. The type &apos;SystemAssigned,UserAssigned&apos; includes both an implicitly
/// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecIdentityTypeEnum>))]
public enum V1api20231115DatabaseAccountSpecIdentityTypeEnum
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
public partial class V1api20231115DatabaseAccountSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20231115DatabaseAccountSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20231115DatabaseAccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned,UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the service.
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20231115DatabaseAccountSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20231115DatabaseAccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>IpAddressOrRange object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecIpRules
{
    /// <summary>
    /// IpAddressOrRange: A single IPv4 address or a single IPv4 address range in CIDR format. Provided IPs must be
    /// well-formatted and cannot be contained in one of the following ranges: 10.0.0.0/8, 100.64.0.0/10, 172.16.0.0/12,
    /// 192.168.0.0/16, since these are not enforceable by the IP address filter. Example of valid inputs: “23.40.210.245”
    /// or “23.40.210.0/8”.
    /// </summary>
    [JsonPropertyName("ipAddressOrRange")]
    public string? IpAddressOrRange { get; set; }
}

/// <summary>Kind: Indicates the type of database account. This can only be set at database account creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecKindEnum>))]
public enum V1api20231115DatabaseAccountSpecKindEnum
{
    [EnumMember(Value = "GlobalDocumentDB"), JsonStringEnumMemberName("GlobalDocumentDB")]
    GlobalDocumentDB,
    [EnumMember(Value = "MongoDB"), JsonStringEnumMemberName("MongoDB")]
    MongoDB,
    [EnumMember(Value = "Parse"), JsonStringEnumMemberName("Parse")]
    Parse
}

/// <summary>A region in which the Azure Cosmos DB database account is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecLocations
{
    /// <summary>
    /// FailoverPriority: The failover priority of the region. A failover priority of 0 indicates a write region. The maximum
    /// value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the
    /// regions in which the database account exists.
    /// </summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary>IsZoneRedundant: Flag to indicate whether or not this region is an AvailabilityZone region</summary>
    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    /// <summary>LocationName: The name of the region.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

/// <summary>
/// MinimalTlsVersion: Indicates the minimum allowed Tls version. The default value is Tls 1.2. Cassandra and Mongo APIs
/// only work with Tls 1.2.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecMinimalTlsVersionEnum>))]
public enum V1api20231115DatabaseAccountSpecMinimalTlsVersionEnum
{
    [EnumMember(Value = "Tls"), JsonStringEnumMemberName("Tls")]
    Tls,
    [EnumMember(Value = "Tls11"), JsonStringEnumMemberName("Tls11")]
    Tls11,
    [EnumMember(Value = "Tls12"), JsonStringEnumMemberName("Tls12")]
    Tls12
}

/// <summary>NetworkAclBypass: Indicates what services are allowed to bypass firewall checks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecNetworkAclBypassEnum>))]
public enum V1api20231115DatabaseAccountSpecNetworkAclBypassEnum
{
    [EnumMember(Value = "AzureServices"), JsonStringEnumMemberName("AzureServices")]
    AzureServices,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecNetworkAclBypassResourceReferences
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
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecOperatorSpecSecretExpressions
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
/// DocumentEndpoint: indicates where the DocumentEndpoint secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecOperatorSpecSecretsDocumentEndpoint
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

/// <summary>
/// PrimaryMasterKey: indicates where the PrimaryMasterKey secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecOperatorSpecSecretsPrimaryMasterKey
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

/// <summary>
/// PrimaryReadonlyMasterKey: indicates where the PrimaryReadonlyMasterKey secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecOperatorSpecSecretsPrimaryReadonlyMasterKey
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

/// <summary>
/// SecondaryMasterKey: indicates where the SecondaryMasterKey secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecOperatorSpecSecretsSecondaryMasterKey
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

/// <summary>
/// SecondaryReadonlyMasterKey: indicates where the SecondaryReadonlyMasterKey secret should be placed. If omitted, the
/// secret will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecOperatorSpecSecretsSecondaryReadonlyMasterKey
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
public partial class V1api20231115DatabaseAccountSpecOperatorSpecSecrets
{
    /// <summary>
    /// DocumentEndpoint: indicates where the DocumentEndpoint secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("documentEndpoint")]
    public V1api20231115DatabaseAccountSpecOperatorSpecSecretsDocumentEndpoint? DocumentEndpoint { get; set; }

    /// <summary>
    /// PrimaryMasterKey: indicates where the PrimaryMasterKey secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("primaryMasterKey")]
    public V1api20231115DatabaseAccountSpecOperatorSpecSecretsPrimaryMasterKey? PrimaryMasterKey { get; set; }

    /// <summary>
    /// PrimaryReadonlyMasterKey: indicates where the PrimaryReadonlyMasterKey secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("primaryReadonlyMasterKey")]
    public V1api20231115DatabaseAccountSpecOperatorSpecSecretsPrimaryReadonlyMasterKey? PrimaryReadonlyMasterKey { get; set; }

    /// <summary>
    /// SecondaryMasterKey: indicates where the SecondaryMasterKey secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("secondaryMasterKey")]
    public V1api20231115DatabaseAccountSpecOperatorSpecSecretsSecondaryMasterKey? SecondaryMasterKey { get; set; }

    /// <summary>
    /// SecondaryReadonlyMasterKey: indicates where the SecondaryReadonlyMasterKey secret should be placed. If omitted, the
    /// secret will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("secondaryReadonlyMasterKey")]
    public V1api20231115DatabaseAccountSpecOperatorSpecSecretsSecondaryReadonlyMasterKey? SecondaryReadonlyMasterKey { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231115DatabaseAccountSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231115DatabaseAccountSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20231115DatabaseAccountSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecPublicNetworkAccessEnum>))]
public enum V1api20231115DatabaseAccountSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "SecuredByPerimeter"), JsonStringEnumMemberName("SecuredByPerimeter")]
    SecuredByPerimeter
}

/// <summary>Specific Databases to restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecRestoreParametersDatabasesToRestore
{
    /// <summary>CollectionNames: The names of the collections available for restore.</summary>
    [JsonPropertyName("collectionNames")]
    public IList<string>? CollectionNames { get; set; }

    /// <summary>DatabaseName: The name of the database available for restore.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }
}

/// <summary>Specific Gremlin Databases to restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecRestoreParametersGremlinDatabasesToRestore
{
    /// <summary>DatabaseName: The name of the gremlin database available for restore.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>GraphNames: The names of the graphs available for restore.</summary>
    [JsonPropertyName("graphNames")]
    public IList<string>? GraphNames { get; set; }
}

/// <summary>RestoreMode: Describes the mode of the restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115DatabaseAccountSpecRestoreParametersRestoreModeEnum>))]
public enum V1api20231115DatabaseAccountSpecRestoreParametersRestoreModeEnum
{
    [EnumMember(Value = "PointInTime"), JsonStringEnumMemberName("PointInTime")]
    PointInTime
}

/// <summary>RestoreParameters: Parameters to indicate the information about the restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecRestoreParameters
{
    /// <summary>DatabasesToRestore: List of specific databases available for restore.</summary>
    [JsonPropertyName("databasesToRestore")]
    public IList<V1api20231115DatabaseAccountSpecRestoreParametersDatabasesToRestore>? DatabasesToRestore { get; set; }

    /// <summary>GremlinDatabasesToRestore: List of specific gremlin databases available for restore.</summary>
    [JsonPropertyName("gremlinDatabasesToRestore")]
    public IList<V1api20231115DatabaseAccountSpecRestoreParametersGremlinDatabasesToRestore>? GremlinDatabasesToRestore { get; set; }

    /// <summary>RestoreMode: Describes the mode of the restore.</summary>
    [JsonPropertyName("restoreMode")]
    public V1api20231115DatabaseAccountSpecRestoreParametersRestoreModeEnum? RestoreMode { get; set; }

    /// <summary>
    /// RestoreSource: The id of the restorable database account from which the restore has to be initiated. For example:
    /// /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{restorableDatabaseAccountName}
    /// </summary>
    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    /// <summary>RestoreTimestampInUtc: Time to which the account has to be restored (ISO-8601 format).</summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }

    /// <summary>TablesToRestore: List of specific tables available for restore.</summary>
    [JsonPropertyName("tablesToRestore")]
    public IList<string>? TablesToRestore { get; set; }
}

/// <summary>
/// Reference: Resource ID of a subnet, for example:
/// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecVirtualNetworkRulesReference
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

/// <summary>Virtual Network ACL Rule object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpecVirtualNetworkRules
{
    /// <summary>IgnoreMissingVNetServiceEndpoint: Create firewall rule before the virtual network has vnet service endpoint enabled.</summary>
    [JsonPropertyName("ignoreMissingVNetServiceEndpoint")]
    public bool? IgnoreMissingVNetServiceEndpoint { get; set; }

    /// <summary>
    /// Reference: Resource ID of a subnet, for example:
    /// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.
    /// </summary>
    [JsonPropertyName("reference")]
    public V1api20231115DatabaseAccountSpecVirtualNetworkRulesReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountSpec
{
    /// <summary>AnalyticalStorageConfiguration: Analytical storage specific properties.</summary>
    [JsonPropertyName("analyticalStorageConfiguration")]
    public V1api20231115DatabaseAccountSpecAnalyticalStorageConfiguration? AnalyticalStorageConfiguration { get; set; }

    /// <summary>ApiProperties: API specific properties. Currently, supported only for MongoDB API.</summary>
    [JsonPropertyName("apiProperties")]
    public V1api20231115DatabaseAccountSpecApiProperties? ApiProperties { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>BackupPolicy: The object representing the policy for taking backups on an account.</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20231115DatabaseAccountSpecBackupPolicy? BackupPolicy { get; set; }

    /// <summary>Capabilities: List of Cosmos DB capabilities for the account</summary>
    [JsonPropertyName("capabilities")]
    public IList<V1api20231115DatabaseAccountSpecCapabilities>? Capabilities { get; set; }

    /// <summary>Capacity: The object that represents all properties related to capacity enforcement on an account.</summary>
    [JsonPropertyName("capacity")]
    public V1api20231115DatabaseAccountSpecCapacity? Capacity { get; set; }

    /// <summary>ConnectorOffer: The cassandra connector offer type for the Cosmos DB database C* account.</summary>
    [JsonPropertyName("connectorOffer")]
    public V1api20231115DatabaseAccountSpecConnectorOfferEnum? ConnectorOffer { get; set; }

    /// <summary>ConsistencyPolicy: The consistency policy for the Cosmos DB account.</summary>
    [JsonPropertyName("consistencyPolicy")]
    public V1api20231115DatabaseAccountSpecConsistencyPolicy? ConsistencyPolicy { get; set; }

    /// <summary>Cors: The CORS policy for the Cosmos DB database account.</summary>
    [JsonPropertyName("cors")]
    public IList<V1api20231115DatabaseAccountSpecCors>? Cors { get; set; }

    /// <summary>CreateMode: Enum to indicate the mode of account creation.</summary>
    [JsonPropertyName("createMode")]
    public V1api20231115DatabaseAccountSpecCreateModeEnum? CreateMode { get; set; }

    /// <summary>DatabaseAccountOfferType: The offer type for the database</summary>
    [JsonPropertyName("databaseAccountOfferType")]
    public required V1api20231115DatabaseAccountSpecDatabaseAccountOfferTypeEnum DatabaseAccountOfferType { get; set; }

    /// <summary>
    /// DefaultIdentity: The default identity for accessing key vault used in features like customer managed keys. The default
    /// identity needs to be explicitly set by the users. It can be &quot;FirstPartyIdentity&quot;, &quot;SystemAssignedIdentity&quot; and more.
    /// </summary>
    [JsonPropertyName("defaultIdentity")]
    public string? DefaultIdentity { get; set; }

    /// <summary>
    /// DisableKeyBasedMetadataWriteAccess: Disable write operations on metadata resources (databases, containers, throughput)
    /// via account keys
    /// </summary>
    [JsonPropertyName("disableKeyBasedMetadataWriteAccess")]
    public bool? DisableKeyBasedMetadataWriteAccess { get; set; }

    /// <summary>DisableLocalAuth: Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication.</summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>EnableAnalyticalStorage: Flag to indicate whether to enable storage analytics.</summary>
    [JsonPropertyName("enableAnalyticalStorage")]
    public bool? EnableAnalyticalStorage { get; set; }

    /// <summary>
    /// EnableAutomaticFailover: Enables automatic failover of the write region in the rare event that the region is unavailable
    /// due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the
    /// failover priorities configured for the account.
    /// </summary>
    [JsonPropertyName("enableAutomaticFailover")]
    public bool? EnableAutomaticFailover { get; set; }

    /// <summary>EnableBurstCapacity: Flag to indicate enabling/disabling of Burst Capacity feature on the account</summary>
    [JsonPropertyName("enableBurstCapacity")]
    public bool? EnableBurstCapacity { get; set; }

    /// <summary>EnableCassandraConnector: Enables the cassandra connector on the Cosmos DB C* account</summary>
    [JsonPropertyName("enableCassandraConnector")]
    public bool? EnableCassandraConnector { get; set; }

    /// <summary>EnableFreeTier: Flag to indicate whether Free Tier is enabled.</summary>
    [JsonPropertyName("enableFreeTier")]
    public bool? EnableFreeTier { get; set; }

    /// <summary>EnableMultipleWriteLocations: Enables the account to write in multiple locations</summary>
    [JsonPropertyName("enableMultipleWriteLocations")]
    public bool? EnableMultipleWriteLocations { get; set; }

    /// <summary>EnablePartitionMerge: Flag to indicate enabling/disabling of Partition Merge feature on the account</summary>
    [JsonPropertyName("enablePartitionMerge")]
    public bool? EnablePartitionMerge { get; set; }

    /// <summary>Identity: Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20231115DatabaseAccountSpecIdentity? Identity { get; set; }

    /// <summary>IpRules: List of IpRules.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20231115DatabaseAccountSpecIpRules>? IpRules { get; set; }

    /// <summary>IsVirtualNetworkFilterEnabled: Flag to indicate whether to enable/disable Virtual Network ACL rules.</summary>
    [JsonPropertyName("isVirtualNetworkFilterEnabled")]
    public bool? IsVirtualNetworkFilterEnabled { get; set; }

    /// <summary>KeyVaultKeyUri: The URI of the key vault</summary>
    [JsonPropertyName("keyVaultKeyUri")]
    public string? KeyVaultKeyUri { get; set; }

    /// <summary>Kind: Indicates the type of database account. This can only be set at database account creation.</summary>
    [JsonPropertyName("kind")]
    public V1api20231115DatabaseAccountSpecKindEnum? Kind { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Locations: An array that contains the georeplication locations enabled for the Cosmos DB account.</summary>
    [JsonPropertyName("locations")]
    public required IList<V1api20231115DatabaseAccountSpecLocations> Locations { get; set; }

    /// <summary>
    /// MinimalTlsVersion: Indicates the minimum allowed Tls version. The default value is Tls 1.2. Cassandra and Mongo APIs
    /// only work with Tls 1.2.
    /// </summary>
    [JsonPropertyName("minimalTlsVersion")]
    public V1api20231115DatabaseAccountSpecMinimalTlsVersionEnum? MinimalTlsVersion { get; set; }

    /// <summary>NetworkAclBypass: Indicates what services are allowed to bypass firewall checks.</summary>
    [JsonPropertyName("networkAclBypass")]
    public V1api20231115DatabaseAccountSpecNetworkAclBypassEnum? NetworkAclBypass { get; set; }

    /// <summary>
    /// NetworkAclBypassResourceReferences: An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB
    /// account.
    /// </summary>
    [JsonPropertyName("networkAclBypassResourceReferences")]
    public IList<V1api20231115DatabaseAccountSpecNetworkAclBypassResourceReferences>? NetworkAclBypassResourceReferences { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231115DatabaseAccountSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20231115DatabaseAccountSpecOwner Owner { get; set; }

    /// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20231115DatabaseAccountSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>RestoreParameters: Parameters to indicate the information about the restore.</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20231115DatabaseAccountSpecRestoreParameters? RestoreParameters { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>VirtualNetworkRules: List of Virtual Network ACL rules configured for the Cosmos DB account.</summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20231115DatabaseAccountSpecVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>AnalyticalStorageConfiguration: Analytical storage specific properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusAnalyticalStorageConfiguration
{
    /// <summary>SchemaType: Describes the types of schema for analytical storage.</summary>
    [JsonPropertyName("schemaType")]
    public string? SchemaType { get; set; }
}

/// <summary>ApiProperties: API specific properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusApiProperties
{
    /// <summary>ServerVersion: Describes the ServerVersion of an a MongoDB account.</summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }
}

/// <summary>ContinuousModeProperties: Configuration values for continuous mode backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusBackupPolicyContinuousContinuousModeProperties
{
    /// <summary>Tier: Enum to indicate type of Continuous backup mode</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>MigrationState: The object representing the state of the migration between the backup policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusBackupPolicyContinuousMigrationState
{
    /// <summary>StartTime: Time at which the backup policy migration started (ISO-8601 format).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Status: Describes the status of migration between backup policy types.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>TargetType: Describes the target backup policy type of the backup policy migration.</summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }
}

/// <summary>Continuous: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusBackupPolicyContinuous
{
    /// <summary>ContinuousModeProperties: Configuration values for continuous mode backup</summary>
    [JsonPropertyName("continuousModeProperties")]
    public V1api20231115DatabaseAccountStatusBackupPolicyContinuousContinuousModeProperties? ContinuousModeProperties { get; set; }

    /// <summary>MigrationState: The object representing the state of the migration between the backup policies.</summary>
    [JsonPropertyName("migrationState")]
    public V1api20231115DatabaseAccountStatusBackupPolicyContinuousMigrationState? MigrationState { get; set; }

    /// <summary>Type: Describes the mode of backups.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>MigrationState: The object representing the state of the migration between the backup policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusBackupPolicyPeriodicMigrationState
{
    /// <summary>StartTime: Time at which the backup policy migration started (ISO-8601 format).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Status: Describes the status of migration between backup policy types.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>TargetType: Describes the target backup policy type of the backup policy migration.</summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }
}

/// <summary>PeriodicModeProperties: Configuration values for periodic mode backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusBackupPolicyPeriodicPeriodicModeProperties
{
    /// <summary>BackupIntervalInMinutes: An integer representing the interval in minutes between two backups</summary>
    [JsonPropertyName("backupIntervalInMinutes")]
    public int? BackupIntervalInMinutes { get; set; }

    /// <summary>BackupRetentionIntervalInHours: An integer representing the time (in hours) that each backup is retained</summary>
    [JsonPropertyName("backupRetentionIntervalInHours")]
    public int? BackupRetentionIntervalInHours { get; set; }

    /// <summary>BackupStorageRedundancy: Enum to indicate type of backup residency</summary>
    [JsonPropertyName("backupStorageRedundancy")]
    public string? BackupStorageRedundancy { get; set; }
}

/// <summary>Periodic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusBackupPolicyPeriodic
{
    /// <summary>MigrationState: The object representing the state of the migration between the backup policies.</summary>
    [JsonPropertyName("migrationState")]
    public V1api20231115DatabaseAccountStatusBackupPolicyPeriodicMigrationState? MigrationState { get; set; }

    /// <summary>PeriodicModeProperties: Configuration values for periodic mode backup</summary>
    [JsonPropertyName("periodicModeProperties")]
    public V1api20231115DatabaseAccountStatusBackupPolicyPeriodicPeriodicModeProperties? PeriodicModeProperties { get; set; }

    /// <summary>Type: Describes the mode of backups.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>BackupPolicy: The object representing the policy for taking backups on an account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusBackupPolicy
{
    /// <summary>Continuous: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("continuous")]
    public V1api20231115DatabaseAccountStatusBackupPolicyContinuous? Continuous { get; set; }

    /// <summary>Periodic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("periodic")]
    public V1api20231115DatabaseAccountStatusBackupPolicyPeriodic? Periodic { get; set; }
}

/// <summary>Cosmos DB capability object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusCapabilities
{
    /// <summary>
    /// Name: Name of the Cosmos DB capability. For example, &quot;name&quot;: &quot;EnableCassandra&quot;. Current values also include
    /// &quot;EnableTable&quot; and &quot;EnableGremlin&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Capacity: The object that represents all properties related to capacity enforcement on an account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusCapacity
{
    /// <summary>
    /// TotalThroughputLimit: The total throughput limit imposed on the account. A totalThroughputLimit of 2000 imposes a strict
    /// limit of max throughput that can be provisioned on that account to be 2000. A totalThroughputLimit of -1 indicates no
    /// limits on provisioning of throughput.
    /// </summary>
    [JsonPropertyName("totalThroughputLimit")]
    public int? TotalThroughputLimit { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusConditions
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

/// <summary>ConsistencyPolicy: The consistency policy for the Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusConsistencyPolicy
{
    /// <summary>DefaultConsistencyLevel: The default consistency level and configuration settings of the Cosmos DB account.</summary>
    [JsonPropertyName("defaultConsistencyLevel")]
    public string? DefaultConsistencyLevel { get; set; }

    /// <summary>
    /// MaxIntervalInSeconds: When used with the Bounded Staleness consistency level, this value represents the time amount of
    /// staleness (in seconds) tolerated. Accepted range for this value is 5 - 86400. Required when defaultConsistencyPolicy is
    /// set to &apos;BoundedStaleness&apos;.
    /// </summary>
    [JsonPropertyName("maxIntervalInSeconds")]
    public int? MaxIntervalInSeconds { get; set; }

    /// <summary>
    /// MaxStalenessPrefix: When used with the Bounded Staleness consistency level, this value represents the number of stale
    /// requests tolerated. Accepted range for this value is 1 – 2,147,483,647. Required when defaultConsistencyPolicy is set
    /// to &apos;BoundedStaleness&apos;.
    /// </summary>
    [JsonPropertyName("maxStalenessPrefix")]
    public int? MaxStalenessPrefix { get; set; }
}

/// <summary>The CORS policy for the Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusCors
{
    /// <summary>AllowedHeaders: The request headers that the origin domain may specify on the CORS request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public string? AllowedHeaders { get; set; }

    /// <summary>AllowedMethods: The methods (HTTP request verbs) that the origin domain may use for a CORS request.</summary>
    [JsonPropertyName("allowedMethods")]
    public string? AllowedMethods { get; set; }

    /// <summary>AllowedOrigins: The origin domains that are permitted to make a request against the service via CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public string? AllowedOrigins { get; set; }

    /// <summary>
    /// ExposedHeaders: The response headers that may be sent in the response to the CORS request and exposed by the browser to
    /// the request issuer.
    /// </summary>
    [JsonPropertyName("exposedHeaders")]
    public string? ExposedHeaders { get; set; }

    /// <summary>MaxAgeInSeconds: The maximum amount time that a browser should cache the preflight OPTIONS request.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>The failover policy for a given region of a database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusFailoverPolicies
{
    /// <summary>
    /// FailoverPriority: The failover priority of the region. A failover priority of 0 indicates a write region. The maximum
    /// value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the
    /// regions in which the database account exists.
    /// </summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary>
    /// Id: The unique identifier of the region in which the database account replicates to. Example:
    /// &amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>LocationName: The name of the region in which the database account exists.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusIdentity
{
    /// <summary>
    /// PrincipalId: The principal id of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant id of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned,UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the service.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20231115DatabaseAccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>IpAddressOrRange object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusIpRules
{
    /// <summary>
    /// IpAddressOrRange: A single IPv4 address or a single IPv4 address range in CIDR format. Provided IPs must be
    /// well-formatted and cannot be contained in one of the following ranges: 10.0.0.0/8, 100.64.0.0/10, 172.16.0.0/12,
    /// 192.168.0.0/16, since these are not enforceable by the IP address filter. Example of valid inputs: “23.40.210.245”
    /// or “23.40.210.0/8”.
    /// </summary>
    [JsonPropertyName("ipAddressOrRange")]
    public string? IpAddressOrRange { get; set; }
}

/// <summary>PrimaryMasterKey: The metadata related to the Primary Read-Write Key for the given Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusKeysMetadataPrimaryMasterKey
{
    /// <summary>
    /// GenerationTime: Generation time in UTC of the key in ISO-8601 format. If the value is missing from the object, it means
    /// that the last key regeneration was triggered before 2022-06-18.
    /// </summary>
    [JsonPropertyName("generationTime")]
    public string? GenerationTime { get; set; }
}

/// <summary>PrimaryReadonlyMasterKey: The metadata related to the Primary Read-Only Key for the given Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusKeysMetadataPrimaryReadonlyMasterKey
{
    /// <summary>
    /// GenerationTime: Generation time in UTC of the key in ISO-8601 format. If the value is missing from the object, it means
    /// that the last key regeneration was triggered before 2022-06-18.
    /// </summary>
    [JsonPropertyName("generationTime")]
    public string? GenerationTime { get; set; }
}

/// <summary>SecondaryMasterKey: The metadata related to the Secondary Read-Write Key for the given Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusKeysMetadataSecondaryMasterKey
{
    /// <summary>
    /// GenerationTime: Generation time in UTC of the key in ISO-8601 format. If the value is missing from the object, it means
    /// that the last key regeneration was triggered before 2022-06-18.
    /// </summary>
    [JsonPropertyName("generationTime")]
    public string? GenerationTime { get; set; }
}

/// <summary>SecondaryReadonlyMasterKey: The metadata related to the Secondary Read-Only Key for the given Cosmos DB database account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusKeysMetadataSecondaryReadonlyMasterKey
{
    /// <summary>
    /// GenerationTime: Generation time in UTC of the key in ISO-8601 format. If the value is missing from the object, it means
    /// that the last key regeneration was triggered before 2022-06-18.
    /// </summary>
    [JsonPropertyName("generationTime")]
    public string? GenerationTime { get; set; }
}

/// <summary>KeysMetadata: The object that represents the metadata for the Account Keys of the Cosmos DB account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusKeysMetadata
{
    /// <summary>PrimaryMasterKey: The metadata related to the Primary Read-Write Key for the given Cosmos DB database account.</summary>
    [JsonPropertyName("primaryMasterKey")]
    public V1api20231115DatabaseAccountStatusKeysMetadataPrimaryMasterKey? PrimaryMasterKey { get; set; }

    /// <summary>PrimaryReadonlyMasterKey: The metadata related to the Primary Read-Only Key for the given Cosmos DB database account.</summary>
    [JsonPropertyName("primaryReadonlyMasterKey")]
    public V1api20231115DatabaseAccountStatusKeysMetadataPrimaryReadonlyMasterKey? PrimaryReadonlyMasterKey { get; set; }

    /// <summary>SecondaryMasterKey: The metadata related to the Secondary Read-Write Key for the given Cosmos DB database account.</summary>
    [JsonPropertyName("secondaryMasterKey")]
    public V1api20231115DatabaseAccountStatusKeysMetadataSecondaryMasterKey? SecondaryMasterKey { get; set; }

    /// <summary>SecondaryReadonlyMasterKey: The metadata related to the Secondary Read-Only Key for the given Cosmos DB database account.</summary>
    [JsonPropertyName("secondaryReadonlyMasterKey")]
    public V1api20231115DatabaseAccountStatusKeysMetadataSecondaryReadonlyMasterKey? SecondaryReadonlyMasterKey { get; set; }
}

/// <summary>A region in which the Azure Cosmos DB database account is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusLocations
{
    /// <summary>
    /// DocumentEndpoint: The connection endpoint for the specific region. Example:
    /// https://&amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.documents.azure.com:443/
    /// </summary>
    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    /// <summary>
    /// FailoverPriority: The failover priority of the region. A failover priority of 0 indicates a write region. The maximum
    /// value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the
    /// regions in which the database account exists.
    /// </summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary>Id: The unique identifier of the region within the database account. Example: &amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsZoneRedundant: Flag to indicate whether or not this region is an AvailabilityZone region</summary>
    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    /// <summary>LocationName: The name of the region.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>A private endpoint connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A region in which the Azure Cosmos DB database account is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusReadLocations
{
    /// <summary>
    /// DocumentEndpoint: The connection endpoint for the specific region. Example:
    /// https://&amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.documents.azure.com:443/
    /// </summary>
    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    /// <summary>
    /// FailoverPriority: The failover priority of the region. A failover priority of 0 indicates a write region. The maximum
    /// value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the
    /// regions in which the database account exists.
    /// </summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary>Id: The unique identifier of the region within the database account. Example: &amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsZoneRedundant: Flag to indicate whether or not this region is an AvailabilityZone region</summary>
    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    /// <summary>LocationName: The name of the region.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>Specific Databases to restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusRestoreParametersDatabasesToRestore
{
    /// <summary>CollectionNames: The names of the collections available for restore.</summary>
    [JsonPropertyName("collectionNames")]
    public IList<string>? CollectionNames { get; set; }

    /// <summary>DatabaseName: The name of the database available for restore.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }
}

/// <summary>Specific Gremlin Databases to restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusRestoreParametersGremlinDatabasesToRestore
{
    /// <summary>DatabaseName: The name of the gremlin database available for restore.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>GraphNames: The names of the graphs available for restore.</summary>
    [JsonPropertyName("graphNames")]
    public IList<string>? GraphNames { get; set; }
}

/// <summary>RestoreParameters: Parameters to indicate the information about the restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusRestoreParameters
{
    /// <summary>DatabasesToRestore: List of specific databases available for restore.</summary>
    [JsonPropertyName("databasesToRestore")]
    public IList<V1api20231115DatabaseAccountStatusRestoreParametersDatabasesToRestore>? DatabasesToRestore { get; set; }

    /// <summary>GremlinDatabasesToRestore: List of specific gremlin databases available for restore.</summary>
    [JsonPropertyName("gremlinDatabasesToRestore")]
    public IList<V1api20231115DatabaseAccountStatusRestoreParametersGremlinDatabasesToRestore>? GremlinDatabasesToRestore { get; set; }

    /// <summary>RestoreMode: Describes the mode of the restore.</summary>
    [JsonPropertyName("restoreMode")]
    public string? RestoreMode { get; set; }

    /// <summary>
    /// RestoreSource: The id of the restorable database account from which the restore has to be initiated. For example:
    /// /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{restorableDatabaseAccountName}
    /// </summary>
    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    /// <summary>RestoreTimestampInUtc: Time to which the account has to be restored (ISO-8601 format).</summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }

    /// <summary>TablesToRestore: List of specific tables available for restore.</summary>
    [JsonPropertyName("tablesToRestore")]
    public IList<string>? TablesToRestore { get; set; }
}

/// <summary>SystemData: The system meta data relating to this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusSystemData
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

/// <summary>Virtual Network ACL Rule object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusVirtualNetworkRules
{
    /// <summary>
    /// Id: Resource ID of a subnet, for example:
    /// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IgnoreMissingVNetServiceEndpoint: Create firewall rule before the virtual network has vnet service endpoint enabled.</summary>
    [JsonPropertyName("ignoreMissingVNetServiceEndpoint")]
    public bool? IgnoreMissingVNetServiceEndpoint { get; set; }
}

/// <summary>A region in which the Azure Cosmos DB database account is deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatusWriteLocations
{
    /// <summary>
    /// DocumentEndpoint: The connection endpoint for the specific region. Example:
    /// https://&amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.documents.azure.com:443/
    /// </summary>
    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    /// <summary>
    /// FailoverPriority: The failover priority of the region. A failover priority of 0 indicates a write region. The maximum
    /// value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the
    /// regions in which the database account exists.
    /// </summary>
    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    /// <summary>Id: The unique identifier of the region within the database account. Example: &amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsZoneRedundant: Flag to indicate whether or not this region is an AvailabilityZone region</summary>
    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    /// <summary>LocationName: The name of the region.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115DatabaseAccountStatus
{
    /// <summary>AnalyticalStorageConfiguration: Analytical storage specific properties.</summary>
    [JsonPropertyName("analyticalStorageConfiguration")]
    public V1api20231115DatabaseAccountStatusAnalyticalStorageConfiguration? AnalyticalStorageConfiguration { get; set; }

    /// <summary>ApiProperties: API specific properties.</summary>
    [JsonPropertyName("apiProperties")]
    public V1api20231115DatabaseAccountStatusApiProperties? ApiProperties { get; set; }

    /// <summary>BackupPolicy: The object representing the policy for taking backups on an account.</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20231115DatabaseAccountStatusBackupPolicy? BackupPolicy { get; set; }

    /// <summary>Capabilities: List of Cosmos DB capabilities for the account</summary>
    [JsonPropertyName("capabilities")]
    public IList<V1api20231115DatabaseAccountStatusCapabilities>? Capabilities { get; set; }

    /// <summary>Capacity: The object that represents all properties related to capacity enforcement on an account.</summary>
    [JsonPropertyName("capacity")]
    public V1api20231115DatabaseAccountStatusCapacity? Capacity { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231115DatabaseAccountStatusConditions>? Conditions { get; set; }

    /// <summary>ConnectorOffer: The cassandra connector offer type for the Cosmos DB database C* account.</summary>
    [JsonPropertyName("connectorOffer")]
    public string? ConnectorOffer { get; set; }

    /// <summary>ConsistencyPolicy: The consistency policy for the Cosmos DB database account.</summary>
    [JsonPropertyName("consistencyPolicy")]
    public V1api20231115DatabaseAccountStatusConsistencyPolicy? ConsistencyPolicy { get; set; }

    /// <summary>Cors: The CORS policy for the Cosmos DB database account.</summary>
    [JsonPropertyName("cors")]
    public IList<V1api20231115DatabaseAccountStatusCors>? Cors { get; set; }

    /// <summary>CreateMode: Enum to indicate the mode of account creation.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>
    /// CustomerManagedKeyStatus: Indicates the status of the Customer Managed Key feature on the account. In case there are
    /// errors, the property provides troubleshooting guidance.
    /// </summary>
    [JsonPropertyName("customerManagedKeyStatus")]
    public string? CustomerManagedKeyStatus { get; set; }

    /// <summary>DatabaseAccountOfferType: The offer type for the Cosmos DB database account. Default value: Standard.</summary>
    [JsonPropertyName("databaseAccountOfferType")]
    public string? DatabaseAccountOfferType { get; set; }

    /// <summary>
    /// DefaultIdentity: The default identity for accessing key vault used in features like customer managed keys. The default
    /// identity needs to be explicitly set by the users. It can be &quot;FirstPartyIdentity&quot;, &quot;SystemAssignedIdentity&quot; and more.
    /// </summary>
    [JsonPropertyName("defaultIdentity")]
    public string? DefaultIdentity { get; set; }

    /// <summary>
    /// DisableKeyBasedMetadataWriteAccess: Disable write operations on metadata resources (databases, containers, throughput)
    /// via account keys
    /// </summary>
    [JsonPropertyName("disableKeyBasedMetadataWriteAccess")]
    public bool? DisableKeyBasedMetadataWriteAccess { get; set; }

    /// <summary>DisableLocalAuth: Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication.</summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>DocumentEndpoint: The connection endpoint for the Cosmos DB database account.</summary>
    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    /// <summary>EnableAnalyticalStorage: Flag to indicate whether to enable storage analytics.</summary>
    [JsonPropertyName("enableAnalyticalStorage")]
    public bool? EnableAnalyticalStorage { get; set; }

    /// <summary>
    /// EnableAutomaticFailover: Enables automatic failover of the write region in the rare event that the region is unavailable
    /// due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the
    /// failover priorities configured for the account.
    /// </summary>
    [JsonPropertyName("enableAutomaticFailover")]
    public bool? EnableAutomaticFailover { get; set; }

    /// <summary>EnableBurstCapacity: Flag to indicate enabling/disabling of Burst Capacity feature on the account</summary>
    [JsonPropertyName("enableBurstCapacity")]
    public bool? EnableBurstCapacity { get; set; }

    /// <summary>EnableCassandraConnector: Enables the cassandra connector on the Cosmos DB C* account</summary>
    [JsonPropertyName("enableCassandraConnector")]
    public bool? EnableCassandraConnector { get; set; }

    /// <summary>EnableFreeTier: Flag to indicate whether Free Tier is enabled.</summary>
    [JsonPropertyName("enableFreeTier")]
    public bool? EnableFreeTier { get; set; }

    /// <summary>EnableMultipleWriteLocations: Enables the account to write in multiple locations</summary>
    [JsonPropertyName("enableMultipleWriteLocations")]
    public bool? EnableMultipleWriteLocations { get; set; }

    /// <summary>EnablePartitionMerge: Flag to indicate enabling/disabling of Partition Merge feature on the account</summary>
    [JsonPropertyName("enablePartitionMerge")]
    public bool? EnablePartitionMerge { get; set; }

    /// <summary>FailoverPolicies: An array that contains the regions ordered by their failover priorities.</summary>
    [JsonPropertyName("failoverPolicies")]
    public IList<V1api20231115DatabaseAccountStatusFailoverPolicies>? FailoverPolicies { get; set; }

    /// <summary>Id: The unique resource identifier of the ARM resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20231115DatabaseAccountStatusIdentity? Identity { get; set; }

    /// <summary>InstanceId: A unique identifier assigned to the database account</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>IpRules: List of IpRules.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20231115DatabaseAccountStatusIpRules>? IpRules { get; set; }

    /// <summary>IsVirtualNetworkFilterEnabled: Flag to indicate whether to enable/disable Virtual Network ACL rules.</summary>
    [JsonPropertyName("isVirtualNetworkFilterEnabled")]
    public bool? IsVirtualNetworkFilterEnabled { get; set; }

    /// <summary>KeyVaultKeyUri: The URI of the key vault</summary>
    [JsonPropertyName("keyVaultKeyUri")]
    public string? KeyVaultKeyUri { get; set; }

    /// <summary>KeysMetadata: The object that represents the metadata for the Account Keys of the Cosmos DB account.</summary>
    [JsonPropertyName("keysMetadata")]
    public V1api20231115DatabaseAccountStatusKeysMetadata? KeysMetadata { get; set; }

    /// <summary>Kind: Indicates the type of database account. This can only be set at database account creation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Locations: An array that contains all of the locations enabled for the Cosmos DB account.</summary>
    [JsonPropertyName("locations")]
    public IList<V1api20231115DatabaseAccountStatusLocations>? Locations { get; set; }

    /// <summary>
    /// MinimalTlsVersion: Indicates the minimum allowed Tls version. The default value is Tls 1.2. Cassandra and Mongo APIs
    /// only work with Tls 1.2.
    /// </summary>
    [JsonPropertyName("minimalTlsVersion")]
    public string? MinimalTlsVersion { get; set; }

    /// <summary>Name: The name of the ARM resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkAclBypass: Indicates what services are allowed to bypass firewall checks.</summary>
    [JsonPropertyName("networkAclBypass")]
    public string? NetworkAclBypass { get; set; }

    /// <summary>NetworkAclBypassResourceIds: An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account.</summary>
    [JsonPropertyName("networkAclBypassResourceIds")]
    public IList<string>? NetworkAclBypassResourceIds { get; set; }

    /// <summary>PrivateEndpointConnections: List of Private Endpoint Connections configured for the Cosmos DB account.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20231115DatabaseAccountStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>ReadLocations: An array that contains of the read locations enabled for the Cosmos DB account.</summary>
    [JsonPropertyName("readLocations")]
    public IList<V1api20231115DatabaseAccountStatusReadLocations>? ReadLocations { get; set; }

    /// <summary>RestoreParameters: Parameters to indicate the information about the restore.</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20231115DatabaseAccountStatusRestoreParameters? RestoreParameters { get; set; }

    /// <summary>SystemData: The system meta data relating to this resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20231115DatabaseAccountStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of Azure resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>VirtualNetworkRules: List of Virtual Network ACL rules configured for the Cosmos DB account.</summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20231115DatabaseAccountStatusVirtualNetworkRules>? VirtualNetworkRules { get; set; }

    /// <summary>WriteLocations: An array that contains the write location for the Cosmos DB account.</summary>
    [JsonPropertyName("writeLocations")]
    public IList<V1api20231115DatabaseAccountStatusWriteLocations>? WriteLocations { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2023-11-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115DatabaseAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231115DatabaseAccountSpec?>, IStatus<V1api20231115DatabaseAccountStatus?>
{
    public const string KubeApiVersion = "v1api20231115";
    public const string KubeKind = "DatabaseAccount";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "databaseaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20231115";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseAccount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20231115DatabaseAccountSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20231115DatabaseAccountStatus? Status { get; set; }
}