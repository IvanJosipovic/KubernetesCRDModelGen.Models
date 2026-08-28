#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /sql/resource-manager/Microsoft.Sql/SQL/stable/2025-01-01/databases.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250101ServersDatabaseList : IKubernetesObject<V1ListMeta>, IItems<V20250101ServersDatabase>
{
    public const string KubeApiVersion = "v20250101";
    public const string KubeKind = "ServersDatabaseList";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversdatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v20250101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServersDatabaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250101ServersDatabase objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250101ServersDatabase> Items { get; set; }
}

/// <summary>AvailabilityZone: Specifies the availability zone the database is pinned to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabaseSpecAvailabilityZoneEnum>))]
public enum V20250101ServersDatabaseSpecAvailabilityZoneEnum
{
    [EnumMember(Value = "1"), JsonStringEnumMemberName("1")]
    _1,
    [EnumMember(Value = "2"), JsonStringEnumMemberName("2")]
    _2,
    [EnumMember(Value = "3"), JsonStringEnumMemberName("3")]
    _3,
    [EnumMember(Value = "NoPreference"), JsonStringEnumMemberName("NoPreference")]
    NoPreference
}

/// <summary>CatalogCollation: Collation of the metadata catalog.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabaseSpecCatalogCollationEnum>))]
public enum V20250101ServersDatabaseSpecCatalogCollationEnum
{
    [EnumMember(Value = "DATABASE_DEFAULT"), JsonStringEnumMemberName("DATABASE_DEFAULT")]
    DATABASEDEFAULT,
    [EnumMember(Value = "SQL_Latin1_General_CP1_CI_AS"), JsonStringEnumMemberName("SQL_Latin1_General_CP1_CI_AS")]
    SQLLatin1GeneralCP1CIAS
}

/// <summary>
/// CreateMode: Specifies the mode of database creation.
/// Default: regular database creation.
/// Copy: creates a database as a copy of an existing database. sourceDatabaseId must be specified as the resource ID of the
/// source database.
/// Secondary: creates a database as a secondary replica of an existing database. sourceDatabaseId must be specified as the
/// resource ID of the existing primary database.
/// PointInTimeRestore: Creates a database by restoring a point in time backup of an existing database. sourceDatabaseId
/// must be specified as the resource ID of the existing database, and restorePointInTime must be specified.
/// Recovery: Creates a database by restoring a geo-replicated backup. sourceDatabaseId must be specified as the recoverable
/// database resource ID to restore.
/// Restore: Creates a database by restoring a backup of a deleted database. sourceDatabaseId must be specified. If
/// sourceDatabaseId is the database&apos;s original resource ID, then sourceDatabaseDeletionDate must be specified. Otherwise
/// sourceDatabaseId must be the restorable dropped database resource ID and sourceDatabaseDeletionDate is ignored.
/// restorePointInTime may also be specified to restore from an earlier point in time.
/// RestoreLongTermRetentionBackup: Creates a database by restoring from a long term retention vault.
/// recoveryServicesRecoveryPointResourceId must be specified as the recovery point resource ID.
/// Copy, Secondary, and RestoreLongTermRetentionBackup are not supported for DataWarehouse edition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabaseSpecCreateModeEnum>))]
public enum V20250101ServersDatabaseSpecCreateModeEnum
{
    [EnumMember(Value = "Copy"), JsonStringEnumMemberName("Copy")]
    Copy,
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "OnlineSecondary"), JsonStringEnumMemberName("OnlineSecondary")]
    OnlineSecondary,
    [EnumMember(Value = "PointInTimeRestore"), JsonStringEnumMemberName("PointInTimeRestore")]
    PointInTimeRestore,
    [EnumMember(Value = "Recovery"), JsonStringEnumMemberName("Recovery")]
    Recovery,
    [EnumMember(Value = "Restore"), JsonStringEnumMemberName("Restore")]
    Restore,
    [EnumMember(Value = "RestoreExternalBackup"), JsonStringEnumMemberName("RestoreExternalBackup")]
    RestoreExternalBackup,
    [EnumMember(Value = "RestoreExternalBackupSecondary"), JsonStringEnumMemberName("RestoreExternalBackupSecondary")]
    RestoreExternalBackupSecondary,
    [EnumMember(Value = "RestoreLongTermRetentionBackup"), JsonStringEnumMemberName("RestoreLongTermRetentionBackup")]
    RestoreLongTermRetentionBackup,
    [EnumMember(Value = "Secondary"), JsonStringEnumMemberName("Secondary")]
    Secondary
}

/// <summary>ElasticPoolReference: The resource identifier of the elastic pool containing this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseSpecElasticPoolReference
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
/// FreeLimitExhaustionBehavior: Specifies the behavior when monthly free limits are exhausted for the free database.
/// AutoPause: The database will be auto paused upon exhaustion of free limits for remainder of the month.
/// BillForUsage: The database will continue to be online upon exhaustion of free limits and any overage will be billed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabaseSpecFreeLimitExhaustionBehaviorEnum>))]
public enum V20250101ServersDatabaseSpecFreeLimitExhaustionBehaviorEnum
{
    [EnumMember(Value = "AutoPause"), JsonStringEnumMemberName("AutoPause")]
    AutoPause,
    [EnumMember(Value = "BillOverUsage"), JsonStringEnumMemberName("BillOverUsage")]
    BillOverUsage
}

/// <summary>Type: The identity type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabaseSpecIdentityTypeEnum>))]
public enum V20250101ServersDatabaseSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseSpecIdentityUserAssignedIdentitiesReference
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
public partial class V20250101ServersDatabaseSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250101ServersDatabaseSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The Azure Active Directory identity of the database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseSpecIdentity
{
    /// <summary>Type: The identity type</summary>
    [JsonPropertyName("type")]
    public V20250101ServersDatabaseSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentities: The resource ids of the user assigned identities to use</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20250101ServersDatabaseSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// LicenseType: The license type to apply for this database. `LicenseIncluded` if you need a license, or `BasePrice` if you
/// have a license and are eligible for the Azure Hybrid Benefit.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabaseSpecLicenseTypeEnum>))]
public enum V20250101ServersDatabaseSpecLicenseTypeEnum
{
    [EnumMember(Value = "BasePrice"), JsonStringEnumMemberName("BasePrice")]
    BasePrice,
    [EnumMember(Value = "LicenseIncluded"), JsonStringEnumMemberName("LicenseIncluded")]
    LicenseIncluded
}

/// <summary>
/// LongTermRetentionBackupResourceReference: The resource identifier of the long term retention backup associated with
/// create operation of this database.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseSpecLongTermRetentionBackupResourceReference
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
public partial class V20250101ServersDatabaseSpecOperatorSpecConfigMapExpressions
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
public partial class V20250101ServersDatabaseSpecOperatorSpecSecretExpressions
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
public partial class V20250101ServersDatabaseSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250101ServersDatabaseSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250101ServersDatabaseSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a sql.azure.com/Server resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PreferredEnclaveType: Type of enclave requested on the database i.e. Default or VBS enclaves.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabaseSpecPreferredEnclaveTypeEnum>))]
public enum V20250101ServersDatabaseSpecPreferredEnclaveTypeEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "VBS"), JsonStringEnumMemberName("VBS")]
    VBS
}

/// <summary>
/// ReadScale: The state of read-only routing. If enabled, connections that have application intent set to readonly in their
/// connection string may be routed to a readonly secondary replica in the same region. Not applicable to a Hyperscale
/// database within an elastic pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabaseSpecReadScaleEnum>))]
public enum V20250101ServersDatabaseSpecReadScaleEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// RecoverableDatabaseReference: The resource identifier of the recoverable database associated with create operation of
/// this database.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseSpecRecoverableDatabaseReference
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
/// RecoveryServicesRecoveryPointReference: The resource identifier of the recovery point associated with create operation
/// of this database.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseSpecRecoveryServicesRecoveryPointReference
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

/// <summary>RequestedBackupStorageRedundancy: The storage account type to be used to store backups for this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabaseSpecRequestedBackupStorageRedundancyEnum>))]
public enum V20250101ServersDatabaseSpecRequestedBackupStorageRedundancyEnum
{
    [EnumMember(Value = "Geo"), JsonStringEnumMemberName("Geo")]
    Geo,
    [EnumMember(Value = "GeoZone"), JsonStringEnumMemberName("GeoZone")]
    GeoZone,
    [EnumMember(Value = "Local"), JsonStringEnumMemberName("Local")]
    Local,
    [EnumMember(Value = "Zone"), JsonStringEnumMemberName("Zone")]
    Zone
}

/// <summary>
/// RestorableDroppedDatabaseReference: The resource identifier of the restorable dropped database associated with create
/// operation of this database.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseSpecRestorableDroppedDatabaseReference
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

/// <summary>SampleName: The name of the sample schema to apply when creating this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabaseSpecSampleNameEnum>))]
public enum V20250101ServersDatabaseSpecSampleNameEnum
{
    [EnumMember(Value = "AdventureWorksLT"), JsonStringEnumMemberName("AdventureWorksLT")]
    AdventureWorksLT,
    [EnumMember(Value = "WideWorldImportersFull"), JsonStringEnumMemberName("WideWorldImportersFull")]
    WideWorldImportersFull,
    [EnumMember(Value = "WideWorldImportersStd"), JsonStringEnumMemberName("WideWorldImportersStd")]
    WideWorldImportersStd
}

/// <summary>SecondaryType: The secondary type of the database if it is a secondary.  Valid values are Geo, Named and Standby.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabaseSpecSecondaryTypeEnum>))]
public enum V20250101ServersDatabaseSpecSecondaryTypeEnum
{
    [EnumMember(Value = "Geo"), JsonStringEnumMemberName("Geo")]
    Geo,
    [EnumMember(Value = "Named"), JsonStringEnumMemberName("Named")]
    Named,
    [EnumMember(Value = "Standby"), JsonStringEnumMemberName("Standby")]
    Standby
}

/// <summary>
/// Sku: The database SKU.
/// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition,
/// family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation`
/// REST API or one of the following commands:
/// ```azurecli
/// az sql db list-editions -l &lt;location&gt; -o table
/// ```
/// ```powershell
/// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
/// ```
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseSpecSku
{
    /// <summary>Capacity: Capacity of the particular SKU.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU, typically, a letter + Number code, e.g. P3.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Size: Size of the particular SKU</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Tier: The tier or edition of the particular SKU, e.g. Basic, Premium.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// SourceDatabaseReference: The resource identifier of the source database associated with create operation of this
/// database.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseSpecSourceDatabaseReference
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
/// SourceResourceReference: The resource identifier of the source associated with the create operation of this database.
/// This property is only supported for DataWarehouse edition and allows to restore across subscriptions.
/// When sourceResourceId is specified, sourceDatabaseId, recoverableDatabaseId, restorableDroppedDatabaseId and
/// sourceDatabaseDeletionDate must not be specified and CreateMode must be PointInTimeRestore, Restore or Recover.
/// When createMode is PointInTimeRestore, sourceResourceId must be the resource ID of the existing database or existing sql
/// pool, and restorePointInTime must be specified.
/// When createMode is Restore, sourceResourceId must be the resource ID of restorable dropped database or restorable
/// dropped sql pool.
/// When createMode is Recover, sourceResourceId must be the resource ID of recoverable database or recoverable sql pool.
/// When source subscription belongs to a different tenant than target subscription, “x-ms-authorization-auxiliary”
/// header must contain authentication token for the source tenant. For more details about
/// “x-ms-authorization-auxiliary” header see
/// https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/authenticate-multi-tenant
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseSpecSourceResourceReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseSpec
{
    /// <summary>
    /// AutoPauseDelay: Time in minutes after which database is automatically paused. A value of -1 means that automatic pause
    /// is disabled
    /// </summary>
    [JsonPropertyName("autoPauseDelay")]
    public int? AutoPauseDelay { get; set; }

    /// <summary>AvailabilityZone: Specifies the availability zone the database is pinned to.</summary>
    [JsonPropertyName("availabilityZone")]
    public V20250101ServersDatabaseSpecAvailabilityZoneEnum? AvailabilityZone { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CatalogCollation: Collation of the metadata catalog.</summary>
    [JsonPropertyName("catalogCollation")]
    public V20250101ServersDatabaseSpecCatalogCollationEnum? CatalogCollation { get; set; }

    /// <summary>Collation: The collation of the database.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>
    /// CreateMode: Specifies the mode of database creation.
    /// Default: regular database creation.
    /// Copy: creates a database as a copy of an existing database. sourceDatabaseId must be specified as the resource ID of the
    /// source database.
    /// Secondary: creates a database as a secondary replica of an existing database. sourceDatabaseId must be specified as the
    /// resource ID of the existing primary database.
    /// PointInTimeRestore: Creates a database by restoring a point in time backup of an existing database. sourceDatabaseId
    /// must be specified as the resource ID of the existing database, and restorePointInTime must be specified.
    /// Recovery: Creates a database by restoring a geo-replicated backup. sourceDatabaseId must be specified as the recoverable
    /// database resource ID to restore.
    /// Restore: Creates a database by restoring a backup of a deleted database. sourceDatabaseId must be specified. If
    /// sourceDatabaseId is the database&apos;s original resource ID, then sourceDatabaseDeletionDate must be specified. Otherwise
    /// sourceDatabaseId must be the restorable dropped database resource ID and sourceDatabaseDeletionDate is ignored.
    /// restorePointInTime may also be specified to restore from an earlier point in time.
    /// RestoreLongTermRetentionBackup: Creates a database by restoring from a long term retention vault.
    /// recoveryServicesRecoveryPointResourceId must be specified as the recovery point resource ID.
    /// Copy, Secondary, and RestoreLongTermRetentionBackup are not supported for DataWarehouse edition.
    /// </summary>
    [JsonPropertyName("createMode")]
    public V20250101ServersDatabaseSpecCreateModeEnum? CreateMode { get; set; }

    /// <summary>ElasticPoolReference: The resource identifier of the elastic pool containing this database.</summary>
    [JsonPropertyName("elasticPoolReference")]
    public V20250101ServersDatabaseSpecElasticPoolReference? ElasticPoolReference { get; set; }

    /// <summary>EncryptionProtector: The azure key vault URI of the database if it&apos;s configured with per Database Customer Managed Keys.</summary>
    [JsonPropertyName("encryptionProtector")]
    public string? EncryptionProtector { get; set; }

    /// <summary>EncryptionProtectorAutoRotation: The flag to enable or disable auto rotation of database encryption protector AKV key.</summary>
    [JsonPropertyName("encryptionProtectorAutoRotation")]
    public bool? EncryptionProtectorAutoRotation { get; set; }

    /// <summary>FederatedClientId: The Client id used for cross tenant per database CMK scenario</summary>
    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    /// <summary>
    /// FreeLimitExhaustionBehavior: Specifies the behavior when monthly free limits are exhausted for the free database.
    /// AutoPause: The database will be auto paused upon exhaustion of free limits for remainder of the month.
    /// BillForUsage: The database will continue to be online upon exhaustion of free limits and any overage will be billed.
    /// </summary>
    [JsonPropertyName("freeLimitExhaustionBehavior")]
    public V20250101ServersDatabaseSpecFreeLimitExhaustionBehaviorEnum? FreeLimitExhaustionBehavior { get; set; }

    /// <summary>
    /// HighAvailabilityReplicaCount: The number of secondary replicas associated with the Business Critical, Premium, or
    /// Hyperscale edition database that are used to provide high availability. Not applicable to a Hyperscale database within
    /// an elastic pool.
    /// </summary>
    [JsonPropertyName("highAvailabilityReplicaCount")]
    public int? HighAvailabilityReplicaCount { get; set; }

    /// <summary>Identity: The Azure Active Directory identity of the database.</summary>
    [JsonPropertyName("identity")]
    public V20250101ServersDatabaseSpecIdentity? Identity { get; set; }

    /// <summary>
    /// IsLedgerOn: Whether or not this database is a ledger database, which means all tables in the database are ledger tables.
    /// Note: the value of this property cannot be changed after the database has been created.
    /// </summary>
    [JsonPropertyName("isLedgerOn")]
    public bool? IsLedgerOn { get; set; }

    /// <summary>
    /// LicenseType: The license type to apply for this database. `LicenseIncluded` if you need a license, or `BasePrice` if you
    /// have a license and are eligible for the Azure Hybrid Benefit.
    /// </summary>
    [JsonPropertyName("licenseType")]
    public V20250101ServersDatabaseSpecLicenseTypeEnum? LicenseType { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// LongTermRetentionBackupResourceReference: The resource identifier of the long term retention backup associated with
    /// create operation of this database.
    /// </summary>
    [JsonPropertyName("longTermRetentionBackupResourceReference")]
    public V20250101ServersDatabaseSpecLongTermRetentionBackupResourceReference? LongTermRetentionBackupResourceReference { get; set; }

    /// <summary>
    /// MaintenanceConfigurationId: Maintenance configuration id assigned to the database. This configuration defines the period
    /// when the maintenance updates will occur.
    /// </summary>
    [JsonPropertyName("maintenanceConfigurationId")]
    public string? MaintenanceConfigurationId { get; set; }

    /// <summary>
    /// ManualCutover: Whether or not customer controlled manual cutover needs to be done during Update Database operation to
    /// Hyperscale tier.
    /// This property is only applicable when scaling database from Business Critical/General Purpose/Premium/Standard tier to
    /// Hyperscale tier.
    /// When manualCutover is specified, the scaling operation will wait for user input to trigger cutover to Hyperscale
    /// database.
    /// To trigger cutover, please provide &apos;performCutover&apos; parameter when the Scaling operation is in Waiting state.
    /// </summary>
    [JsonPropertyName("manualCutover")]
    public bool? ManualCutover { get; set; }

    /// <summary>MaxSizeBytes: The max size of the database expressed in bytes.</summary>
    [JsonPropertyName("maxSizeBytes")]
    public int? MaxSizeBytes { get; set; }

    /// <summary>MinCapacity: Minimal capacity that database will always have allocated, if not paused</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250101ServersDatabaseSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a sql.azure.com/Server resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250101ServersDatabaseSpecOwner Owner { get; set; }

    /// <summary>
    /// PerformCutover: To trigger customer controlled manual cutover during the wait state while Scaling operation is in
    /// progress.
    /// This property parameter is only applicable for scaling operations that are initiated along with &apos;manualCutover&apos;
    /// parameter.
    /// This property is only applicable when scaling database from Business Critical/General Purpose/Premium/Standard tier to
    /// Hyperscale tier is already in progress.
    /// When performCutover is specified, the scaling operation will trigger cutover and perform role-change to Hyperscale
    /// database.
    /// </summary>
    [JsonPropertyName("performCutover")]
    public bool? PerformCutover { get; set; }

    /// <summary>PreferredEnclaveType: Type of enclave requested on the database i.e. Default or VBS enclaves.</summary>
    [JsonPropertyName("preferredEnclaveType")]
    public V20250101ServersDatabaseSpecPreferredEnclaveTypeEnum? PreferredEnclaveType { get; set; }

    /// <summary>
    /// ReadScale: The state of read-only routing. If enabled, connections that have application intent set to readonly in their
    /// connection string may be routed to a readonly secondary replica in the same region. Not applicable to a Hyperscale
    /// database within an elastic pool.
    /// </summary>
    [JsonPropertyName("readScale")]
    public V20250101ServersDatabaseSpecReadScaleEnum? ReadScale { get; set; }

    /// <summary>
    /// RecoverableDatabaseReference: The resource identifier of the recoverable database associated with create operation of
    /// this database.
    /// </summary>
    [JsonPropertyName("recoverableDatabaseReference")]
    public V20250101ServersDatabaseSpecRecoverableDatabaseReference? RecoverableDatabaseReference { get; set; }

    /// <summary>
    /// RecoveryServicesRecoveryPointReference: The resource identifier of the recovery point associated with create operation
    /// of this database.
    /// </summary>
    [JsonPropertyName("recoveryServicesRecoveryPointReference")]
    public V20250101ServersDatabaseSpecRecoveryServicesRecoveryPointReference? RecoveryServicesRecoveryPointReference { get; set; }

    /// <summary>RequestedBackupStorageRedundancy: The storage account type to be used to store backups for this database.</summary>
    [JsonPropertyName("requestedBackupStorageRedundancy")]
    public V20250101ServersDatabaseSpecRequestedBackupStorageRedundancyEnum? RequestedBackupStorageRedundancy { get; set; }

    /// <summary>
    /// RestorableDroppedDatabaseReference: The resource identifier of the restorable dropped database associated with create
    /// operation of this database.
    /// </summary>
    [JsonPropertyName("restorableDroppedDatabaseReference")]
    public V20250101ServersDatabaseSpecRestorableDroppedDatabaseReference? RestorableDroppedDatabaseReference { get; set; }

    /// <summary>
    /// RestorePointInTime: Specifies the point in time (ISO8601 format) of the source database that will be restored to create
    /// the new database.
    /// </summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>SampleName: The name of the sample schema to apply when creating this database.</summary>
    [JsonPropertyName("sampleName")]
    public V20250101ServersDatabaseSpecSampleNameEnum? SampleName { get; set; }

    /// <summary>SecondaryType: The secondary type of the database if it is a secondary.  Valid values are Geo, Named and Standby.</summary>
    [JsonPropertyName("secondaryType")]
    public V20250101ServersDatabaseSpecSecondaryTypeEnum? SecondaryType { get; set; }

    /// <summary>
    /// Sku: The database SKU.
    /// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition,
    /// family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation`
    /// REST API or one of the following commands:
    /// ```azurecli
    /// az sql db list-editions -l &lt;location&gt; -o table
    /// ```
    /// ```powershell
    /// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
    /// ```
    /// </summary>
    [JsonPropertyName("sku")]
    public V20250101ServersDatabaseSpecSku? Sku { get; set; }

    /// <summary>SourceDatabaseDeletionDate: Specifies the time that the database was deleted.</summary>
    [JsonPropertyName("sourceDatabaseDeletionDate")]
    public string? SourceDatabaseDeletionDate { get; set; }

    /// <summary>
    /// SourceDatabaseReference: The resource identifier of the source database associated with create operation of this
    /// database.
    /// </summary>
    [JsonPropertyName("sourceDatabaseReference")]
    public V20250101ServersDatabaseSpecSourceDatabaseReference? SourceDatabaseReference { get; set; }

    /// <summary>
    /// SourceResourceReference: The resource identifier of the source associated with the create operation of this database.
    /// This property is only supported for DataWarehouse edition and allows to restore across subscriptions.
    /// When sourceResourceId is specified, sourceDatabaseId, recoverableDatabaseId, restorableDroppedDatabaseId and
    /// sourceDatabaseDeletionDate must not be specified and CreateMode must be PointInTimeRestore, Restore or Recover.
    /// When createMode is PointInTimeRestore, sourceResourceId must be the resource ID of the existing database or existing sql
    /// pool, and restorePointInTime must be specified.
    /// When createMode is Restore, sourceResourceId must be the resource ID of restorable dropped database or restorable
    /// dropped sql pool.
    /// When createMode is Recover, sourceResourceId must be the resource ID of recoverable database or recoverable sql pool.
    /// When source subscription belongs to a different tenant than target subscription, “x-ms-authorization-auxiliary”
    /// header must contain authentication token for the source tenant. For more details about
    /// “x-ms-authorization-auxiliary” header see
    /// https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/authenticate-multi-tenant
    /// </summary>
    [JsonPropertyName("sourceResourceReference")]
    public V20250101ServersDatabaseSpecSourceResourceReference? SourceResourceReference { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>UseFreeLimit: Whether or not the database uses free monthly limits. Allowed on one database in a subscription.</summary>
    [JsonPropertyName("useFreeLimit")]
    public bool? UseFreeLimit { get; set; }

    /// <summary>
    /// ZoneRedundant: Whether or not this database is zone redundant, which means the replicas of this database will be spread
    /// across multiple availability zones.
    /// </summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseStatusConditions
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

/// <summary>CurrentSku: The name and tier of the SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseStatusCurrentSku
{
    /// <summary>Capacity: Capacity of the particular SKU.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU, typically, a letter + Number code, e.g. P3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Size: Size of the particular SKU</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Tier: The tier or edition of the particular SKU, e.g. Basic, Premium.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Azure Active Directory identity configuration for a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The Azure Active Directory client id.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The Azure Active Directory principal id.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The Azure Active Directory identity of the database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseStatusIdentity
{
    /// <summary>TenantId: The Azure Active Directory tenant id.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The identity type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: The resource ids of the user assigned identities to use</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20250101ServersDatabaseStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Database level key used for encryption at rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseStatusKeys
{
    /// <summary>CreationDate: The database key creation date.</summary>
    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    /// <summary>KeyVersion: The database key&apos;s version.</summary>
    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }

    /// <summary>Subregion: Subregion of the server key.</summary>
    [JsonPropertyName("subregion")]
    public string? Subregion { get; set; }

    /// <summary>Thumbprint: Thumbprint of the database key.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>Type: The database key type. Only supported value is &apos;AzureKeyVault&apos;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Sku: The database SKU.
/// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition,
/// family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation`
/// REST API or one of the following commands:
/// ```azurecli
/// az sql db list-editions -l &lt;location&gt; -o table
/// ```
/// ```powershell
/// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
/// ```
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseStatusSku
{
    /// <summary>Capacity: Capacity of the particular SKU.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU, typically, a letter + Number code, e.g. P3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Size: Size of the particular SKU</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Tier: The tier or edition of the particular SKU, e.g. Basic, Premium.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabaseStatusSystemData
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
public partial class V20250101ServersDatabaseStatus
{
    /// <summary>
    /// AutoPauseDelay: Time in minutes after which database is automatically paused. A value of -1 means that automatic pause
    /// is disabled
    /// </summary>
    [JsonPropertyName("autoPauseDelay")]
    public int? AutoPauseDelay { get; set; }

    /// <summary>AvailabilityZone: Specifies the availability zone the database is pinned to.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>CatalogCollation: Collation of the metadata catalog.</summary>
    [JsonPropertyName("catalogCollation")]
    public string? CatalogCollation { get; set; }

    /// <summary>Collation: The collation of the database.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250101ServersDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// CreateMode: Specifies the mode of database creation.
    /// Default: regular database creation.
    /// Copy: creates a database as a copy of an existing database. sourceDatabaseId must be specified as the resource ID of the
    /// source database.
    /// Secondary: creates a database as a secondary replica of an existing database. sourceDatabaseId must be specified as the
    /// resource ID of the existing primary database.
    /// PointInTimeRestore: Creates a database by restoring a point in time backup of an existing database. sourceDatabaseId
    /// must be specified as the resource ID of the existing database, and restorePointInTime must be specified.
    /// Recovery: Creates a database by restoring a geo-replicated backup. sourceDatabaseId must be specified as the recoverable
    /// database resource ID to restore.
    /// Restore: Creates a database by restoring a backup of a deleted database. sourceDatabaseId must be specified. If
    /// sourceDatabaseId is the database&apos;s original resource ID, then sourceDatabaseDeletionDate must be specified. Otherwise
    /// sourceDatabaseId must be the restorable dropped database resource ID and sourceDatabaseDeletionDate is ignored.
    /// restorePointInTime may also be specified to restore from an earlier point in time.
    /// RestoreLongTermRetentionBackup: Creates a database by restoring from a long term retention vault.
    /// recoveryServicesRecoveryPointResourceId must be specified as the recovery point resource ID.
    /// Copy, Secondary, and RestoreLongTermRetentionBackup are not supported for DataWarehouse edition.
    /// </summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>CreationDate: The creation date of the database (ISO8601 format).</summary>
    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    /// <summary>CurrentBackupStorageRedundancy: The storage account type used to store backups for this database.</summary>
    [JsonPropertyName("currentBackupStorageRedundancy")]
    public string? CurrentBackupStorageRedundancy { get; set; }

    /// <summary>CurrentServiceObjectiveName: The current service level objective name of the database.</summary>
    [JsonPropertyName("currentServiceObjectiveName")]
    public string? CurrentServiceObjectiveName { get; set; }

    /// <summary>CurrentSku: The name and tier of the SKU.</summary>
    [JsonPropertyName("currentSku")]
    public V20250101ServersDatabaseStatusCurrentSku? CurrentSku { get; set; }

    /// <summary>DatabaseId: The ID of the database.</summary>
    [JsonPropertyName("databaseId")]
    public string? DatabaseId { get; set; }

    /// <summary>DefaultSecondaryLocation: The default secondary region for this database.</summary>
    [JsonPropertyName("defaultSecondaryLocation")]
    public string? DefaultSecondaryLocation { get; set; }

    /// <summary>
    /// EarliestRestoreDate: This records the earliest start date and time that restore is available for this database (ISO8601
    /// format).
    /// </summary>
    [JsonPropertyName("earliestRestoreDate")]
    public string? EarliestRestoreDate { get; set; }

    /// <summary>ElasticPoolId: The resource identifier of the elastic pool containing this database.</summary>
    [JsonPropertyName("elasticPoolId")]
    public string? ElasticPoolId { get; set; }

    /// <summary>EncryptionProtector: The azure key vault URI of the database if it&apos;s configured with per Database Customer Managed Keys.</summary>
    [JsonPropertyName("encryptionProtector")]
    public string? EncryptionProtector { get; set; }

    /// <summary>EncryptionProtectorAutoRotation: The flag to enable or disable auto rotation of database encryption protector AKV key.</summary>
    [JsonPropertyName("encryptionProtectorAutoRotation")]
    public bool? EncryptionProtectorAutoRotation { get; set; }

    /// <summary>FailoverGroupId: Failover Group resource identifier that this database belongs to.</summary>
    [JsonPropertyName("failoverGroupId")]
    public string? FailoverGroupId { get; set; }

    /// <summary>FederatedClientId: The Client id used for cross tenant per database CMK scenario</summary>
    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    /// <summary>
    /// FreeLimitExhaustionBehavior: Specifies the behavior when monthly free limits are exhausted for the free database.
    /// AutoPause: The database will be auto paused upon exhaustion of free limits for remainder of the month.
    /// BillForUsage: The database will continue to be online upon exhaustion of free limits and any overage will be billed.
    /// </summary>
    [JsonPropertyName("freeLimitExhaustionBehavior")]
    public string? FreeLimitExhaustionBehavior { get; set; }

    /// <summary>
    /// HighAvailabilityReplicaCount: The number of secondary replicas associated with the Business Critical, Premium, or
    /// Hyperscale edition database that are used to provide high availability. Not applicable to a Hyperscale database within
    /// an elastic pool.
    /// </summary>
    [JsonPropertyName("highAvailabilityReplicaCount")]
    public int? HighAvailabilityReplicaCount { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The Azure Active Directory identity of the database.</summary>
    [JsonPropertyName("identity")]
    public V20250101ServersDatabaseStatusIdentity? Identity { get; set; }

    /// <summary>IsInfraEncryptionEnabled: Infra encryption is enabled for this database.</summary>
    [JsonPropertyName("isInfraEncryptionEnabled")]
    public bool? IsInfraEncryptionEnabled { get; set; }

    /// <summary>
    /// IsLedgerOn: Whether or not this database is a ledger database, which means all tables in the database are ledger tables.
    /// Note: the value of this property cannot be changed after the database has been created.
    /// </summary>
    [JsonPropertyName("isLedgerOn")]
    public bool? IsLedgerOn { get; set; }

    /// <summary>Keys: The resource ids of the user assigned identities to use</summary>
    [JsonPropertyName("keys")]
    public IDictionary<string, V20250101ServersDatabaseStatusKeys>? Keys { get; set; }

    /// <summary>Kind: Kind of database. This is metadata used for the Azure portal experience.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// LicenseType: The license type to apply for this database. `LicenseIncluded` if you need a license, or `BasePrice` if you
    /// have a license and are eligible for the Azure Hybrid Benefit.
    /// </summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// LongTermRetentionBackupResourceId: The resource identifier of the long term retention backup associated with create
    /// operation of this database.
    /// </summary>
    [JsonPropertyName("longTermRetentionBackupResourceId")]
    public string? LongTermRetentionBackupResourceId { get; set; }

    /// <summary>
    /// MaintenanceConfigurationId: Maintenance configuration id assigned to the database. This configuration defines the period
    /// when the maintenance updates will occur.
    /// </summary>
    [JsonPropertyName("maintenanceConfigurationId")]
    public string? MaintenanceConfigurationId { get; set; }

    /// <summary>ManagedBy: Resource that manages the database.</summary>
    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    /// <summary>
    /// ManualCutover: Whether or not customer controlled manual cutover needs to be done during Update Database operation to
    /// Hyperscale tier.
    /// This property is only applicable when scaling database from Business Critical/General Purpose/Premium/Standard tier to
    /// Hyperscale tier.
    /// When manualCutover is specified, the scaling operation will wait for user input to trigger cutover to Hyperscale
    /// database.
    /// To trigger cutover, please provide &apos;performCutover&apos; parameter when the Scaling operation is in Waiting state.
    /// </summary>
    [JsonPropertyName("manualCutover")]
    public bool? ManualCutover { get; set; }

    /// <summary>MaxLogSizeBytes: The max log size for this database.</summary>
    [JsonPropertyName("maxLogSizeBytes")]
    public int? MaxLogSizeBytes { get; set; }

    /// <summary>MaxSizeBytes: The max size of the database expressed in bytes.</summary>
    [JsonPropertyName("maxSizeBytes")]
    public int? MaxSizeBytes { get; set; }

    /// <summary>MinCapacity: Minimal capacity that database will always have allocated, if not paused</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PausedDate: The date when database was paused by user configuration or action(ISO8601 format). Null if the database is
    /// ready.
    /// </summary>
    [JsonPropertyName("pausedDate")]
    public string? PausedDate { get; set; }

    /// <summary>
    /// PerformCutover: To trigger customer controlled manual cutover during the wait state while Scaling operation is in
    /// progress.
    /// This property parameter is only applicable for scaling operations that are initiated along with &apos;manualCutover&apos;
    /// parameter.
    /// This property is only applicable when scaling database from Business Critical/General Purpose/Premium/Standard tier to
    /// Hyperscale tier is already in progress.
    /// When performCutover is specified, the scaling operation will trigger cutover and perform role-change to Hyperscale
    /// database.
    /// </summary>
    [JsonPropertyName("performCutover")]
    public bool? PerformCutover { get; set; }

    /// <summary>PreferredEnclaveType: Type of enclave requested on the database i.e. Default or VBS enclaves.</summary>
    [JsonPropertyName("preferredEnclaveType")]
    public string? PreferredEnclaveType { get; set; }

    /// <summary>
    /// ReadScale: The state of read-only routing. If enabled, connections that have application intent set to readonly in their
    /// connection string may be routed to a readonly secondary replica in the same region. Not applicable to a Hyperscale
    /// database within an elastic pool.
    /// </summary>
    [JsonPropertyName("readScale")]
    public string? ReadScale { get; set; }

    /// <summary>
    /// RecoverableDatabaseId: The resource identifier of the recoverable database associated with create operation of this
    /// database.
    /// </summary>
    [JsonPropertyName("recoverableDatabaseId")]
    public string? RecoverableDatabaseId { get; set; }

    /// <summary>
    /// RecoveryServicesRecoveryPointId: The resource identifier of the recovery point associated with create operation of this
    /// database.
    /// </summary>
    [JsonPropertyName("recoveryServicesRecoveryPointId")]
    public string? RecoveryServicesRecoveryPointId { get; set; }

    /// <summary>RequestedBackupStorageRedundancy: The storage account type to be used to store backups for this database.</summary>
    [JsonPropertyName("requestedBackupStorageRedundancy")]
    public string? RequestedBackupStorageRedundancy { get; set; }

    /// <summary>RequestedServiceObjectiveName: The requested service level objective name of the database.</summary>
    [JsonPropertyName("requestedServiceObjectiveName")]
    public string? RequestedServiceObjectiveName { get; set; }

    /// <summary>
    /// RestorableDroppedDatabaseId: The resource identifier of the restorable dropped database associated with create operation
    /// of this database.
    /// </summary>
    [JsonPropertyName("restorableDroppedDatabaseId")]
    public string? RestorableDroppedDatabaseId { get; set; }

    /// <summary>
    /// RestorePointInTime: Specifies the point in time (ISO8601 format) of the source database that will be restored to create
    /// the new database.
    /// </summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>
    /// ResumedDate: The date when database was resumed by user action or database login (ISO8601 format). Null if the database
    /// is paused.
    /// </summary>
    [JsonPropertyName("resumedDate")]
    public string? ResumedDate { get; set; }

    /// <summary>SampleName: The name of the sample schema to apply when creating this database.</summary>
    [JsonPropertyName("sampleName")]
    public string? SampleName { get; set; }

    /// <summary>SecondaryType: The secondary type of the database if it is a secondary.  Valid values are Geo, Named and Standby.</summary>
    [JsonPropertyName("secondaryType")]
    public string? SecondaryType { get; set; }

    /// <summary>
    /// Sku: The database SKU.
    /// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition,
    /// family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation`
    /// REST API or one of the following commands:
    /// ```azurecli
    /// az sql db list-editions -l &lt;location&gt; -o table
    /// ```
    /// ```powershell
    /// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
    /// ```
    /// </summary>
    [JsonPropertyName("sku")]
    public V20250101ServersDatabaseStatusSku? Sku { get; set; }

    /// <summary>SourceDatabaseDeletionDate: Specifies the time that the database was deleted.</summary>
    [JsonPropertyName("sourceDatabaseDeletionDate")]
    public string? SourceDatabaseDeletionDate { get; set; }

    /// <summary>SourceDatabaseId: The resource identifier of the source database associated with create operation of this database.</summary>
    [JsonPropertyName("sourceDatabaseId")]
    public string? SourceDatabaseId { get; set; }

    /// <summary>
    /// SourceResourceId: The resource identifier of the source associated with the create operation of this database.
    /// This property is only supported for DataWarehouse edition and allows to restore across subscriptions.
    /// When sourceResourceId is specified, sourceDatabaseId, recoverableDatabaseId, restorableDroppedDatabaseId and
    /// sourceDatabaseDeletionDate must not be specified and CreateMode must be PointInTimeRestore, Restore or Recover.
    /// When createMode is PointInTimeRestore, sourceResourceId must be the resource ID of the existing database or existing sql
    /// pool, and restorePointInTime must be specified.
    /// When createMode is Restore, sourceResourceId must be the resource ID of restorable dropped database or restorable
    /// dropped sql pool.
    /// When createMode is Recover, sourceResourceId must be the resource ID of recoverable database or recoverable sql pool.
    /// When source subscription belongs to a different tenant than target subscription, “x-ms-authorization-auxiliary”
    /// header must contain authentication token for the source tenant. For more details about
    /// “x-ms-authorization-auxiliary” header see
    /// https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/authenticate-multi-tenant
    /// </summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }

    /// <summary>Status: The status of the database.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20250101ServersDatabaseStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UseFreeLimit: Whether or not the database uses free monthly limits. Allowed on one database in a subscription.</summary>
    [JsonPropertyName("useFreeLimit")]
    public bool? UseFreeLimit { get; set; }

    /// <summary>
    /// ZoneRedundant: Whether or not this database is zone redundant, which means the replicas of this database will be spread
    /// across multiple availability zones.
    /// </summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /sql/resource-manager/Microsoft.Sql/SQL/stable/2025-01-01/databases.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250101ServersDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V20250101ServersDatabaseSpec?>, IStatus<V20250101ServersDatabaseStatus?>
{
    public const string KubeApiVersion = "v20250101";
    public const string KubeKind = "ServersDatabase";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversdatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v20250101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServersDatabase";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250101ServersDatabaseSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20250101ServersDatabaseStatus? Status { get; set; }
}