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
/// Storage version of v1api20211101.ServersDatabase
/// Generator information:
/// - Generated from: /sql/resource-manager/Microsoft.Sql/stable/2021-11-01/Databases.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101storageServersDatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1api20211101storageServersDatabase>
{
    public const string KubeApiVersion = "v1api20211101storage";
    public const string KubeKind = "ServersDatabaseList";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversdatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v1api20211101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServersDatabaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20211101storageServersDatabase objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20211101storageServersDatabase> Items { get; set; }
}

/// <summary>ElasticPoolReference: The resource identifier of the elastic pool containing this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecElasticPoolReference
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

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v1api20211101.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20211101storageServersDatabaseSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20211101.DatabaseIdentity
/// Azure Active Directory identity configuration for a resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20211101storageServersDatabaseSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// LongTermRetentionBackupResourceReference: The resource identifier of the long term retention backup associated with
/// create operation of this database.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecLongTermRetentionBackupResourceReference
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
public partial class V1api20211101storageServersDatabaseSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20211101storageServersDatabaseSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20211101.ServersDatabaseOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20211101storageServersDatabaseSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20211101storageServersDatabaseSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a sql.azure.com/Server resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// RecoverableDatabaseReference: The resource identifier of the recoverable database associated with create operation of
/// this database.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecRecoverableDatabaseReference
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
public partial class V1api20211101storageServersDatabaseSpecRecoveryServicesRecoveryPointReference
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
/// RestorableDroppedDatabaseReference: The resource identifier of the restorable dropped database associated with create
/// operation of this database.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecRestorableDroppedDatabaseReference
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
/// Storage version of v1api20211101.Sku
/// An ARM Resource SKU.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [JsonPropertyName("family")]
    public string? Family { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// SourceDatabaseReference: The resource identifier of the source database associated with create operation of this
/// database.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpecSourceDatabaseReference
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
public partial class V1api20211101storageServersDatabaseSpecSourceResourceReference
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

/// <summary>Storage version of v1api20211101.ServersDatabase_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoPauseDelay")]
    public int? AutoPauseDelay { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    [JsonPropertyName("catalogCollation")]
    public string? CatalogCollation { get; set; }

    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>ElasticPoolReference: The resource identifier of the elastic pool containing this database.</summary>
    [JsonPropertyName("elasticPoolReference")]
    public V1api20211101storageServersDatabaseSpecElasticPoolReference? ElasticPoolReference { get; set; }

    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    [JsonPropertyName("highAvailabilityReplicaCount")]
    public int? HighAvailabilityReplicaCount { get; set; }

    /// <summary>
    /// Storage version of v1api20211101.DatabaseIdentity
    /// Azure Active Directory identity configuration for a resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20211101storageServersDatabaseSpecIdentity? Identity { get; set; }

    [JsonPropertyName("isLedgerOn")]
    public bool? IsLedgerOn { get; set; }

    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// LongTermRetentionBackupResourceReference: The resource identifier of the long term retention backup associated with
    /// create operation of this database.
    /// </summary>
    [JsonPropertyName("longTermRetentionBackupResourceReference")]
    public V1api20211101storageServersDatabaseSpecLongTermRetentionBackupResourceReference? LongTermRetentionBackupResourceReference { get; set; }

    [JsonPropertyName("maintenanceConfigurationId")]
    public string? MaintenanceConfigurationId { get; set; }

    [JsonPropertyName("maxSizeBytes")]
    public int? MaxSizeBytes { get; set; }

    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>
    /// Storage version of v1api20211101.ServersDatabaseOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20211101storageServersDatabaseSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a sql.azure.com/Server resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20211101storageServersDatabaseSpecOwner Owner { get; set; }

    [JsonPropertyName("readScale")]
    public string? ReadScale { get; set; }

    /// <summary>
    /// RecoverableDatabaseReference: The resource identifier of the recoverable database associated with create operation of
    /// this database.
    /// </summary>
    [JsonPropertyName("recoverableDatabaseReference")]
    public V1api20211101storageServersDatabaseSpecRecoverableDatabaseReference? RecoverableDatabaseReference { get; set; }

    /// <summary>
    /// RecoveryServicesRecoveryPointReference: The resource identifier of the recovery point associated with create operation
    /// of this database.
    /// </summary>
    [JsonPropertyName("recoveryServicesRecoveryPointReference")]
    public V1api20211101storageServersDatabaseSpecRecoveryServicesRecoveryPointReference? RecoveryServicesRecoveryPointReference { get; set; }

    [JsonPropertyName("requestedBackupStorageRedundancy")]
    public string? RequestedBackupStorageRedundancy { get; set; }

    /// <summary>
    /// RestorableDroppedDatabaseReference: The resource identifier of the restorable dropped database associated with create
    /// operation of this database.
    /// </summary>
    [JsonPropertyName("restorableDroppedDatabaseReference")]
    public V1api20211101storageServersDatabaseSpecRestorableDroppedDatabaseReference? RestorableDroppedDatabaseReference { get; set; }

    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    [JsonPropertyName("sampleName")]
    public string? SampleName { get; set; }

    [JsonPropertyName("secondaryType")]
    public string? SecondaryType { get; set; }

    /// <summary>
    /// Storage version of v1api20211101.Sku
    /// An ARM Resource SKU.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20211101storageServersDatabaseSpecSku? Sku { get; set; }

    [JsonPropertyName("sourceDatabaseDeletionDate")]
    public string? SourceDatabaseDeletionDate { get; set; }

    /// <summary>
    /// SourceDatabaseReference: The resource identifier of the source database associated with create operation of this
    /// database.
    /// </summary>
    [JsonPropertyName("sourceDatabaseReference")]
    public V1api20211101storageServersDatabaseSpecSourceDatabaseReference? SourceDatabaseReference { get; set; }

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
    public V1api20211101storageServersDatabaseSpecSourceResourceReference? SourceResourceReference { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseStatusConditions
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

/// <summary>
/// Storage version of v1api20211101.Sku_STATUS
/// An ARM Resource SKU.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseStatusCurrentSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [JsonPropertyName("family")]
    public string? Family { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v1api20211101.DatabaseUserIdentity_STATUS
/// Azure Active Directory identity configuration for a resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseStatusIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Storage version of v1api20211101.DatabaseIdentity_STATUS
/// Azure Active Directory identity configuration for a resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20211101storageServersDatabaseStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v1api20211101.Sku_STATUS
/// An ARM Resource SKU.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseStatusSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [JsonPropertyName("family")]
    public string? Family { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20211101.ServersDatabase_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101storageServersDatabaseStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoPauseDelay")]
    public int? AutoPauseDelay { get; set; }

    [JsonPropertyName("catalogCollation")]
    public string? CatalogCollation { get; set; }

    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20211101storageServersDatabaseStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    [JsonPropertyName("currentBackupStorageRedundancy")]
    public string? CurrentBackupStorageRedundancy { get; set; }

    [JsonPropertyName("currentServiceObjectiveName")]
    public string? CurrentServiceObjectiveName { get; set; }

    /// <summary>
    /// Storage version of v1api20211101.Sku_STATUS
    /// An ARM Resource SKU.
    /// </summary>
    [JsonPropertyName("currentSku")]
    public V1api20211101storageServersDatabaseStatusCurrentSku? CurrentSku { get; set; }

    [JsonPropertyName("databaseId")]
    public string? DatabaseId { get; set; }

    [JsonPropertyName("defaultSecondaryLocation")]
    public string? DefaultSecondaryLocation { get; set; }

    [JsonPropertyName("earliestRestoreDate")]
    public string? EarliestRestoreDate { get; set; }

    [JsonPropertyName("elasticPoolId")]
    public string? ElasticPoolId { get; set; }

    [JsonPropertyName("failoverGroupId")]
    public string? FailoverGroupId { get; set; }

    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    [JsonPropertyName("highAvailabilityReplicaCount")]
    public int? HighAvailabilityReplicaCount { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20211101.DatabaseIdentity_STATUS
    /// Azure Active Directory identity configuration for a resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20211101storageServersDatabaseStatusIdentity? Identity { get; set; }

    [JsonPropertyName("isInfraEncryptionEnabled")]
    public bool? IsInfraEncryptionEnabled { get; set; }

    [JsonPropertyName("isLedgerOn")]
    public bool? IsLedgerOn { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("longTermRetentionBackupResourceId")]
    public string? LongTermRetentionBackupResourceId { get; set; }

    [JsonPropertyName("maintenanceConfigurationId")]
    public string? MaintenanceConfigurationId { get; set; }

    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    [JsonPropertyName("maxLogSizeBytes")]
    public int? MaxLogSizeBytes { get; set; }

    [JsonPropertyName("maxSizeBytes")]
    public int? MaxSizeBytes { get; set; }

    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pausedDate")]
    public string? PausedDate { get; set; }

    [JsonPropertyName("readScale")]
    public string? ReadScale { get; set; }

    [JsonPropertyName("recoverableDatabaseId")]
    public string? RecoverableDatabaseId { get; set; }

    [JsonPropertyName("recoveryServicesRecoveryPointId")]
    public string? RecoveryServicesRecoveryPointId { get; set; }

    [JsonPropertyName("requestedBackupStorageRedundancy")]
    public string? RequestedBackupStorageRedundancy { get; set; }

    [JsonPropertyName("requestedServiceObjectiveName")]
    public string? RequestedServiceObjectiveName { get; set; }

    [JsonPropertyName("restorableDroppedDatabaseId")]
    public string? RestorableDroppedDatabaseId { get; set; }

    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    [JsonPropertyName("resumedDate")]
    public string? ResumedDate { get; set; }

    [JsonPropertyName("sampleName")]
    public string? SampleName { get; set; }

    [JsonPropertyName("secondaryType")]
    public string? SecondaryType { get; set; }

    /// <summary>
    /// Storage version of v1api20211101.Sku_STATUS
    /// An ARM Resource SKU.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20211101storageServersDatabaseStatusSku? Sku { get; set; }

    [JsonPropertyName("sourceDatabaseDeletionDate")]
    public string? SourceDatabaseDeletionDate { get; set; }

    [JsonPropertyName("sourceDatabaseId")]
    public string? SourceDatabaseId { get; set; }

    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// Storage version of v1api20211101.ServersDatabase
/// Generator information:
/// - Generated from: /sql/resource-manager/Microsoft.Sql/stable/2021-11-01/Databases.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101storageServersDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211101storageServersDatabaseSpec?>, IStatus<V1api20211101storageServersDatabaseStatus?>
{
    public const string KubeApiVersion = "v1api20211101storage";
    public const string KubeKind = "ServersDatabase";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversdatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v1api20211101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServersDatabase";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20211101.ServersDatabase_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20211101storageServersDatabaseSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20211101.ServersDatabase_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20211101storageServersDatabaseStatus? Status { get; set; }
}