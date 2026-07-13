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
/// - Generated from: /sql/resource-manager/Microsoft.Sql/stable/2021-11-01/Databases.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101ServersDatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1api20211101ServersDatabase>
{
    public const string KubeApiVersion = "v1api20211101";
    public const string KubeKind = "ServersDatabaseList";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversdatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v1api20211101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServersDatabaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20211101ServersDatabase objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20211101ServersDatabase> Items { get; set; }
}

/// <summary>CatalogCollation: Collation of the metadata catalog.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServersDatabaseSpecCatalogCollationEnum>))]
public enum V1api20211101ServersDatabaseSpecCatalogCollationEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServersDatabaseSpecCreateModeEnum>))]
public enum V1api20211101ServersDatabaseSpecCreateModeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecElasticPoolReference
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

/// <summary>Type: The identity type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServersDatabaseSpecIdentityTypeEnum>))]
public enum V1api20211101ServersDatabaseSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20211101ServersDatabaseSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20211101ServersDatabaseSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The Azure Active Directory identity of the database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecIdentity
{
    /// <summary>Type: The identity type</summary>
    [JsonPropertyName("type")]
    public V1api20211101ServersDatabaseSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentities: The resource ids of the user assigned identities to use</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20211101ServersDatabaseSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// LicenseType: The license type to apply for this database. `LicenseIncluded` if you need a license, or `BasePrice` if you
/// have a license and are eligible for the Azure Hybrid Benefit.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServersDatabaseSpecLicenseTypeEnum>))]
public enum V1api20211101ServersDatabaseSpecLicenseTypeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecLongTermRetentionBackupResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20211101ServersDatabaseSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20211101ServersDatabaseSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20211101ServersDatabaseSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a sql.azure.com/Server resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// ReadScale: The state of read-only routing. If enabled, connections that have application intent set to readonly in their
/// connection string may be routed to a readonly secondary replica in the same region. Not applicable to a Hyperscale
/// database within an elastic pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServersDatabaseSpecReadScaleEnum>))]
public enum V1api20211101ServersDatabaseSpecReadScaleEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecRecoverableDatabaseReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecRecoveryServicesRecoveryPointReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServersDatabaseSpecRequestedBackupStorageRedundancyEnum>))]
public enum V1api20211101ServersDatabaseSpecRequestedBackupStorageRedundancyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecRestorableDroppedDatabaseReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServersDatabaseSpecSampleNameEnum>))]
public enum V1api20211101ServersDatabaseSpecSampleNameEnum
{
    [EnumMember(Value = "AdventureWorksLT"), JsonStringEnumMemberName("AdventureWorksLT")]
    AdventureWorksLT,
    [EnumMember(Value = "WideWorldImportersFull"), JsonStringEnumMemberName("WideWorldImportersFull")]
    WideWorldImportersFull,
    [EnumMember(Value = "WideWorldImportersStd"), JsonStringEnumMemberName("WideWorldImportersStd")]
    WideWorldImportersStd
}

/// <summary>SecondaryType: The secondary type of the database if it is a secondary.  Valid values are Geo and Named.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServersDatabaseSpecSecondaryTypeEnum>))]
public enum V1api20211101ServersDatabaseSpecSecondaryTypeEnum
{
    [EnumMember(Value = "Geo"), JsonStringEnumMemberName("Geo")]
    Geo,
    [EnumMember(Value = "Named"), JsonStringEnumMemberName("Named")]
    Named
}

/// <summary>
/// Sku: The database SKU.
/// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition,
/// family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation`
/// REST API or one of the following commands:
/// ```azurecli
/// az sql db list-editions -l &lt;location&gt; -o table
/// ````
/// ```powershell
/// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
/// ````
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecSku
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecSourceDatabaseReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpecSourceResourceReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseSpec
{
    /// <summary>
    /// AutoPauseDelay: Time in minutes after which database is automatically paused. A value of -1 means that automatic pause
    /// is disabled
    /// </summary>
    [JsonPropertyName("autoPauseDelay")]
    public int? AutoPauseDelay { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CatalogCollation: Collation of the metadata catalog.</summary>
    [JsonPropertyName("catalogCollation")]
    public V1api20211101ServersDatabaseSpecCatalogCollationEnum? CatalogCollation { get; set; }

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
    public V1api20211101ServersDatabaseSpecCreateModeEnum? CreateMode { get; set; }

    /// <summary>ElasticPoolReference: The resource identifier of the elastic pool containing this database.</summary>
    [JsonPropertyName("elasticPoolReference")]
    public V1api20211101ServersDatabaseSpecElasticPoolReference? ElasticPoolReference { get; set; }

    /// <summary>FederatedClientId: The Client id used for cross tenant per database CMK scenario</summary>
    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    /// <summary>
    /// HighAvailabilityReplicaCount: The number of secondary replicas associated with the database that are used to provide
    /// high availability. Not applicable to a Hyperscale database within an elastic pool.
    /// </summary>
    [JsonPropertyName("highAvailabilityReplicaCount")]
    public int? HighAvailabilityReplicaCount { get; set; }

    /// <summary>Identity: The Azure Active Directory identity of the database.</summary>
    [JsonPropertyName("identity")]
    public V1api20211101ServersDatabaseSpecIdentity? Identity { get; set; }

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
    public V1api20211101ServersDatabaseSpecLicenseTypeEnum? LicenseType { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// LongTermRetentionBackupResourceReference: The resource identifier of the long term retention backup associated with
    /// create operation of this database.
    /// </summary>
    [JsonPropertyName("longTermRetentionBackupResourceReference")]
    public V1api20211101ServersDatabaseSpecLongTermRetentionBackupResourceReference? LongTermRetentionBackupResourceReference { get; set; }

    /// <summary>
    /// MaintenanceConfigurationId: Maintenance configuration id assigned to the database. This configuration defines the period
    /// when the maintenance updates will occur.
    /// </summary>
    [JsonPropertyName("maintenanceConfigurationId")]
    public string? MaintenanceConfigurationId { get; set; }

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
    public V1api20211101ServersDatabaseSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a sql.azure.com/Server resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20211101ServersDatabaseSpecOwner Owner { get; set; }

    /// <summary>
    /// ReadScale: The state of read-only routing. If enabled, connections that have application intent set to readonly in their
    /// connection string may be routed to a readonly secondary replica in the same region. Not applicable to a Hyperscale
    /// database within an elastic pool.
    /// </summary>
    [JsonPropertyName("readScale")]
    public V1api20211101ServersDatabaseSpecReadScaleEnum? ReadScale { get; set; }

    /// <summary>
    /// RecoverableDatabaseReference: The resource identifier of the recoverable database associated with create operation of
    /// this database.
    /// </summary>
    [JsonPropertyName("recoverableDatabaseReference")]
    public V1api20211101ServersDatabaseSpecRecoverableDatabaseReference? RecoverableDatabaseReference { get; set; }

    /// <summary>
    /// RecoveryServicesRecoveryPointReference: The resource identifier of the recovery point associated with create operation
    /// of this database.
    /// </summary>
    [JsonPropertyName("recoveryServicesRecoveryPointReference")]
    public V1api20211101ServersDatabaseSpecRecoveryServicesRecoveryPointReference? RecoveryServicesRecoveryPointReference { get; set; }

    /// <summary>RequestedBackupStorageRedundancy: The storage account type to be used to store backups for this database.</summary>
    [JsonPropertyName("requestedBackupStorageRedundancy")]
    public V1api20211101ServersDatabaseSpecRequestedBackupStorageRedundancyEnum? RequestedBackupStorageRedundancy { get; set; }

    /// <summary>
    /// RestorableDroppedDatabaseReference: The resource identifier of the restorable dropped database associated with create
    /// operation of this database.
    /// </summary>
    [JsonPropertyName("restorableDroppedDatabaseReference")]
    public V1api20211101ServersDatabaseSpecRestorableDroppedDatabaseReference? RestorableDroppedDatabaseReference { get; set; }

    /// <summary>
    /// RestorePointInTime: Specifies the point in time (ISO8601 format) of the source database that will be restored to create
    /// the new database.
    /// </summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>SampleName: The name of the sample schema to apply when creating this database.</summary>
    [JsonPropertyName("sampleName")]
    public V1api20211101ServersDatabaseSpecSampleNameEnum? SampleName { get; set; }

    /// <summary>SecondaryType: The secondary type of the database if it is a secondary.  Valid values are Geo and Named.</summary>
    [JsonPropertyName("secondaryType")]
    public V1api20211101ServersDatabaseSpecSecondaryTypeEnum? SecondaryType { get; set; }

    /// <summary>
    /// Sku: The database SKU.
    /// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition,
    /// family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation`
    /// REST API or one of the following commands:
    /// ```azurecli
    /// az sql db list-editions -l &lt;location&gt; -o table
    /// ````
    /// ```powershell
    /// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
    /// ````
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20211101ServersDatabaseSpecSku? Sku { get; set; }

    /// <summary>SourceDatabaseDeletionDate: Specifies the time that the database was deleted.</summary>
    [JsonPropertyName("sourceDatabaseDeletionDate")]
    public string? SourceDatabaseDeletionDate { get; set; }

    /// <summary>
    /// SourceDatabaseReference: The resource identifier of the source database associated with create operation of this
    /// database.
    /// </summary>
    [JsonPropertyName("sourceDatabaseReference")]
    public V1api20211101ServersDatabaseSpecSourceDatabaseReference? SourceDatabaseReference { get; set; }

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
    public V1api20211101ServersDatabaseSpecSourceResourceReference? SourceResourceReference { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// ZoneRedundant: Whether or not this database is zone redundant, which means the replicas of this database will be spread
    /// across multiple availability zones.
    /// </summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseStatusCurrentSku
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The Azure Active Directory client id.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The Azure Active Directory principal id.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The Azure Active Directory identity of the database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseStatusIdentity
{
    /// <summary>TenantId: The Azure Active Directory tenant id.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The identity type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: The resource ids of the user assigned identities to use</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20211101ServersDatabaseStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Sku: The database SKU.
/// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition,
/// family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation`
/// REST API or one of the following commands:
/// ```azurecli
/// az sql db list-editions -l &lt;location&gt; -o table
/// ````
/// ```powershell
/// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
/// ````
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseStatusSku
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersDatabaseStatus
{
    /// <summary>
    /// AutoPauseDelay: Time in minutes after which database is automatically paused. A value of -1 means that automatic pause
    /// is disabled
    /// </summary>
    [JsonPropertyName("autoPauseDelay")]
    public int? AutoPauseDelay { get; set; }

    /// <summary>CatalogCollation: Collation of the metadata catalog.</summary>
    [JsonPropertyName("catalogCollation")]
    public string? CatalogCollation { get; set; }

    /// <summary>Collation: The collation of the database.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211101ServersDatabaseStatusConditions>? Conditions { get; set; }

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
    public V1api20211101ServersDatabaseStatusCurrentSku? CurrentSku { get; set; }

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

    /// <summary>FailoverGroupId: Failover Group resource identifier that this database belongs to.</summary>
    [JsonPropertyName("failoverGroupId")]
    public string? FailoverGroupId { get; set; }

    /// <summary>FederatedClientId: The Client id used for cross tenant per database CMK scenario</summary>
    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    /// <summary>
    /// HighAvailabilityReplicaCount: The number of secondary replicas associated with the database that are used to provide
    /// high availability. Not applicable to a Hyperscale database within an elastic pool.
    /// </summary>
    [JsonPropertyName("highAvailabilityReplicaCount")]
    public int? HighAvailabilityReplicaCount { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The Azure Active Directory identity of the database.</summary>
    [JsonPropertyName("identity")]
    public V1api20211101ServersDatabaseStatusIdentity? Identity { get; set; }

    /// <summary>IsInfraEncryptionEnabled: Infra encryption is enabled for this database.</summary>
    [JsonPropertyName("isInfraEncryptionEnabled")]
    public bool? IsInfraEncryptionEnabled { get; set; }

    /// <summary>
    /// IsLedgerOn: Whether or not this database is a ledger database, which means all tables in the database are ledger tables.
    /// Note: the value of this property cannot be changed after the database has been created.
    /// </summary>
    [JsonPropertyName("isLedgerOn")]
    public bool? IsLedgerOn { get; set; }

    /// <summary>Kind: Kind of database. This is metadata used for the Azure portal experience.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// LicenseType: The license type to apply for this database. `LicenseIncluded` if you need a license, or `BasePrice` if you
    /// have a license and are eligible for the Azure Hybrid Benefit.
    /// </summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Location: Resource location.</summary>
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

    /// <summary>MaxLogSizeBytes: The max log size for this database.</summary>
    [JsonPropertyName("maxLogSizeBytes")]
    public int? MaxLogSizeBytes { get; set; }

    /// <summary>MaxSizeBytes: The max size of the database expressed in bytes.</summary>
    [JsonPropertyName("maxSizeBytes")]
    public int? MaxSizeBytes { get; set; }

    /// <summary>MinCapacity: Minimal capacity that database will always have allocated, if not paused</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PausedDate: The date when database was paused by user configuration or action(ISO8601 format). Null if the database is
    /// ready.
    /// </summary>
    [JsonPropertyName("pausedDate")]
    public string? PausedDate { get; set; }

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

    /// <summary>SecondaryType: The secondary type of the database if it is a secondary.  Valid values are Geo and Named.</summary>
    [JsonPropertyName("secondaryType")]
    public string? SecondaryType { get; set; }

    /// <summary>
    /// Sku: The database SKU.
    /// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition,
    /// family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation`
    /// REST API or one of the following commands:
    /// ```azurecli
    /// az sql db list-editions -l &lt;location&gt; -o table
    /// ````
    /// ```powershell
    /// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
    /// ````
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20211101ServersDatabaseStatusSku? Sku { get; set; }

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

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// ZoneRedundant: Whether or not this database is zone redundant, which means the replicas of this database will be spread
    /// across multiple availability zones.
    /// </summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /sql/resource-manager/Microsoft.Sql/stable/2021-11-01/Databases.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101ServersDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211101ServersDatabaseSpec?>, IStatus<V1api20211101ServersDatabaseStatus?>
{
    public const string KubeApiVersion = "v1api20211101";
    public const string KubeKind = "ServersDatabase";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversdatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v1api20211101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServersDatabase";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20211101ServersDatabaseSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20211101ServersDatabaseStatus? Status { get; set; }
}