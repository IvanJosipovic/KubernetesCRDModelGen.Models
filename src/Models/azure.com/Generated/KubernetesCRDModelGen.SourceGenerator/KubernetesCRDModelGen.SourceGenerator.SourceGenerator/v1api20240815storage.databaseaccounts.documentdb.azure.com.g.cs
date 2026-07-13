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
/// Storage version of v1api20240815.DatabaseAccount
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2024-08-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240815storageDatabaseAccountList : IKubernetesObject<V1ListMeta>, IItems<V1api20240815storageDatabaseAccount>
{
    public const string KubeApiVersion = "v1api20240815storage";
    public const string KubeKind = "DatabaseAccountList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "databaseaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20240815storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseAccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240815storageDatabaseAccount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240815storageDatabaseAccount> Items { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.AnalyticalStorageConfiguration
/// Analytical storage specific properties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecAnalyticalStorageConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("schemaType")]
    public string? SchemaType { get; set; }
}

/// <summary>Storage version of v1api20240815.ApiProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecApiProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.ContinuousModeProperties
/// Configuration values for periodic mode backup
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecBackupPolicyContinuousContinuousModeProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.BackupPolicyMigrationState
/// The object representing the state of the migration between the backup policies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecBackupPolicyContinuousMigrationState
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }
}

/// <summary>Storage version of v1api20240815.ContinuousModeBackupPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecBackupPolicyContinuous
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.ContinuousModeProperties
    /// Configuration values for periodic mode backup
    /// </summary>
    [JsonPropertyName("continuousModeProperties")]
    public V1api20240815storageDatabaseAccountSpecBackupPolicyContinuousContinuousModeProperties? ContinuousModeProperties { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.BackupPolicyMigrationState
    /// The object representing the state of the migration between the backup policies.
    /// </summary>
    [JsonPropertyName("migrationState")]
    public V1api20240815storageDatabaseAccountSpecBackupPolicyContinuousMigrationState? MigrationState { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.BackupPolicyMigrationState
/// The object representing the state of the migration between the backup policies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecBackupPolicyPeriodicMigrationState
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.PeriodicModeProperties
/// Configuration values for periodic mode backup
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecBackupPolicyPeriodicPeriodicModeProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backupIntervalInMinutes")]
    public int? BackupIntervalInMinutes { get; set; }

    [JsonPropertyName("backupRetentionIntervalInHours")]
    public int? BackupRetentionIntervalInHours { get; set; }

    [JsonPropertyName("backupStorageRedundancy")]
    public string? BackupStorageRedundancy { get; set; }
}

/// <summary>Storage version of v1api20240815.PeriodicModeBackupPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecBackupPolicyPeriodic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.BackupPolicyMigrationState
    /// The object representing the state of the migration between the backup policies.
    /// </summary>
    [JsonPropertyName("migrationState")]
    public V1api20240815storageDatabaseAccountSpecBackupPolicyPeriodicMigrationState? MigrationState { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.PeriodicModeProperties
    /// Configuration values for periodic mode backup
    /// </summary>
    [JsonPropertyName("periodicModeProperties")]
    public V1api20240815storageDatabaseAccountSpecBackupPolicyPeriodicPeriodicModeProperties? PeriodicModeProperties { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240815.BackupPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecBackupPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240815.ContinuousModeBackupPolicy</summary>
    [JsonPropertyName("continuous")]
    public V1api20240815storageDatabaseAccountSpecBackupPolicyContinuous? Continuous { get; set; }

    /// <summary>Storage version of v1api20240815.PeriodicModeBackupPolicy</summary>
    [JsonPropertyName("periodic")]
    public V1api20240815storageDatabaseAccountSpecBackupPolicyPeriodic? Periodic { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.Capability
/// Cosmos DB capability object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecCapabilities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.Capacity
/// The object that represents all properties related to capacity enforcement on an account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecCapacity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("totalThroughputLimit")]
    public int? TotalThroughputLimit { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.ConsistencyPolicy
/// The consistency policy for the Cosmos DB database account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecConsistencyPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultConsistencyLevel")]
    public string? DefaultConsistencyLevel { get; set; }

    [JsonPropertyName("maxIntervalInSeconds")]
    public int? MaxIntervalInSeconds { get; set; }

    [JsonPropertyName("maxStalenessPrefix")]
    public int? MaxStalenessPrefix { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.CorsPolicy
/// The CORS policy for the Cosmos DB database account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecCors
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedHeaders")]
    public string? AllowedHeaders { get; set; }

    [JsonPropertyName("allowedMethods")]
    public string? AllowedMethods { get; set; }

    [JsonPropertyName("allowedOrigins")]
    public string? AllowedOrigins { get; set; }

    [JsonPropertyName("exposedHeaders")]
    public string? ExposedHeaders { get; set; }

    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v1api20240815.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20240815storageDatabaseAccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.ManagedServiceIdentity
/// Identity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecIdentity
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
    public IList<V1api20240815storageDatabaseAccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.IpAddressOrRange
/// IpAddressOrRange object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecIpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ipAddressOrRange")]
    public string? IpAddressOrRange { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.Location
/// A region in which the Azure Cosmos DB database account is deployed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecLocations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecNetworkAclBypassResourceReferences
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
public partial class V1api20240815storageDatabaseAccountSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240815storageDatabaseAccountSpecOperatorSpecSecretExpressions
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecOperatorSpecSecretsDocumentEndpoint
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecOperatorSpecSecretsPrimaryMasterKey
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecOperatorSpecSecretsPrimaryReadonlyMasterKey
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecOperatorSpecSecretsSecondaryMasterKey
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecOperatorSpecSecretsSecondaryReadonlyMasterKey
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

/// <summary>Storage version of v1api20240815.DatabaseAccountOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecOperatorSpecSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("documentEndpoint")]
    public V1api20240815storageDatabaseAccountSpecOperatorSpecSecretsDocumentEndpoint? DocumentEndpoint { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("primaryMasterKey")]
    public V1api20240815storageDatabaseAccountSpecOperatorSpecSecretsPrimaryMasterKey? PrimaryMasterKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("primaryReadonlyMasterKey")]
    public V1api20240815storageDatabaseAccountSpecOperatorSpecSecretsPrimaryReadonlyMasterKey? PrimaryReadonlyMasterKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("secondaryMasterKey")]
    public V1api20240815storageDatabaseAccountSpecOperatorSpecSecretsSecondaryMasterKey? SecondaryMasterKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("secondaryReadonlyMasterKey")]
    public V1api20240815storageDatabaseAccountSpecOperatorSpecSecretsSecondaryReadonlyMasterKey? SecondaryReadonlyMasterKey { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.DatabaseAccountOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240815storageDatabaseAccountSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240815storageDatabaseAccountSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v1api20240815.DatabaseAccountOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20240815storageDatabaseAccountSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.DatabaseRestoreResource
/// Specific Databases to restore.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecRestoreParametersDatabasesToRestore
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("collectionNames")]
    public IList<string>? CollectionNames { get; set; }

    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.GremlinDatabaseRestoreResource
/// Specific Gremlin Databases to restore.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecRestoreParametersGremlinDatabasesToRestore
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    [JsonPropertyName("graphNames")]
    public IList<string>? GraphNames { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.RestoreParameters
/// Parameters to indicate the information about the restore.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecRestoreParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("databasesToRestore")]
    public IList<V1api20240815storageDatabaseAccountSpecRestoreParametersDatabasesToRestore>? DatabasesToRestore { get; set; }

    [JsonPropertyName("gremlinDatabasesToRestore")]
    public IList<V1api20240815storageDatabaseAccountSpecRestoreParametersGremlinDatabasesToRestore>? GremlinDatabasesToRestore { get; set; }

    [JsonPropertyName("restoreMode")]
    public string? RestoreMode { get; set; }

    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }

    [JsonPropertyName("restoreWithTtlDisabled")]
    public bool? RestoreWithTtlDisabled { get; set; }

    [JsonPropertyName("tablesToRestore")]
    public IList<string>? TablesToRestore { get; set; }
}

/// <summary>
/// Reference: Resource ID of a subnet, for example:
/// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecVirtualNetworkRulesReference
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
/// Storage version of v1api20240815.VirtualNetworkRule
/// Virtual Network ACL Rule object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpecVirtualNetworkRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ignoreMissingVNetServiceEndpoint")]
    public bool? IgnoreMissingVNetServiceEndpoint { get; set; }

    /// <summary>
    /// Reference: Resource ID of a subnet, for example:
    /// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.
    /// </summary>
    [JsonPropertyName("reference")]
    public V1api20240815storageDatabaseAccountSpecVirtualNetworkRulesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20240815.DatabaseAccount_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.AnalyticalStorageConfiguration
    /// Analytical storage specific properties.
    /// </summary>
    [JsonPropertyName("analyticalStorageConfiguration")]
    public V1api20240815storageDatabaseAccountSpecAnalyticalStorageConfiguration? AnalyticalStorageConfiguration { get; set; }

    /// <summary>Storage version of v1api20240815.ApiProperties</summary>
    [JsonPropertyName("apiProperties")]
    public V1api20240815storageDatabaseAccountSpecApiProperties? ApiProperties { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20240815.BackupPolicy</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20240815storageDatabaseAccountSpecBackupPolicy? BackupPolicy { get; set; }

    [JsonPropertyName("capabilities")]
    public IList<V1api20240815storageDatabaseAccountSpecCapabilities>? Capabilities { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.Capacity
    /// The object that represents all properties related to capacity enforcement on an account.
    /// </summary>
    [JsonPropertyName("capacity")]
    public V1api20240815storageDatabaseAccountSpecCapacity? Capacity { get; set; }

    [JsonPropertyName("connectorOffer")]
    public string? ConnectorOffer { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.ConsistencyPolicy
    /// The consistency policy for the Cosmos DB database account.
    /// </summary>
    [JsonPropertyName("consistencyPolicy")]
    public V1api20240815storageDatabaseAccountSpecConsistencyPolicy? ConsistencyPolicy { get; set; }

    [JsonPropertyName("cors")]
    public IList<V1api20240815storageDatabaseAccountSpecCors>? Cors { get; set; }

    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    [JsonPropertyName("databaseAccountOfferType")]
    public string? DatabaseAccountOfferType { get; set; }

    [JsonPropertyName("defaultIdentity")]
    public string? DefaultIdentity { get; set; }

    [JsonPropertyName("disableKeyBasedMetadataWriteAccess")]
    public bool? DisableKeyBasedMetadataWriteAccess { get; set; }

    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    [JsonPropertyName("enableAnalyticalStorage")]
    public bool? EnableAnalyticalStorage { get; set; }

    [JsonPropertyName("enableAutomaticFailover")]
    public bool? EnableAutomaticFailover { get; set; }

    [JsonPropertyName("enableBurstCapacity")]
    public bool? EnableBurstCapacity { get; set; }

    [JsonPropertyName("enableCassandraConnector")]
    public bool? EnableCassandraConnector { get; set; }

    [JsonPropertyName("enableFreeTier")]
    public bool? EnableFreeTier { get; set; }

    [JsonPropertyName("enableMultipleWriteLocations")]
    public bool? EnableMultipleWriteLocations { get; set; }

    [JsonPropertyName("enablePartitionMerge")]
    public bool? EnablePartitionMerge { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.ManagedServiceIdentity
    /// Identity for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20240815storageDatabaseAccountSpecIdentity? Identity { get; set; }

    [JsonPropertyName("ipRules")]
    public IList<V1api20240815storageDatabaseAccountSpecIpRules>? IpRules { get; set; }

    [JsonPropertyName("isVirtualNetworkFilterEnabled")]
    public bool? IsVirtualNetworkFilterEnabled { get; set; }

    [JsonPropertyName("keyVaultKeyUri")]
    public string? KeyVaultKeyUri { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("locations")]
    public IList<V1api20240815storageDatabaseAccountSpecLocations>? Locations { get; set; }

    [JsonPropertyName("minimalTlsVersion")]
    public string? MinimalTlsVersion { get; set; }

    [JsonPropertyName("networkAclBypass")]
    public string? NetworkAclBypass { get; set; }

    [JsonPropertyName("networkAclBypassResourceReferences")]
    public IList<V1api20240815storageDatabaseAccountSpecNetworkAclBypassResourceReferences>? NetworkAclBypassResourceReferences { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.DatabaseAccountOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240815storageDatabaseAccountSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240815storageDatabaseAccountSpecOwner Owner { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.RestoreParameters
    /// Parameters to indicate the information about the restore.
    /// </summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20240815storageDatabaseAccountSpecRestoreParameters? RestoreParameters { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20240815storageDatabaseAccountSpecVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.AnalyticalStorageConfiguration_STATUS
/// Analytical storage specific properties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusAnalyticalStorageConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("schemaType")]
    public string? SchemaType { get; set; }
}

/// <summary>Storage version of v1api20240815.ApiProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusApiProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.ContinuousModeProperties_STATUS
/// Configuration values for periodic mode backup
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusBackupPolicyContinuousContinuousModeProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.BackupPolicyMigrationState_STATUS
/// The object representing the state of the migration between the backup policies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusBackupPolicyContinuousMigrationState
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }
}

/// <summary>Storage version of v1api20240815.ContinuousModeBackupPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusBackupPolicyContinuous
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.ContinuousModeProperties_STATUS
    /// Configuration values for periodic mode backup
    /// </summary>
    [JsonPropertyName("continuousModeProperties")]
    public V1api20240815storageDatabaseAccountStatusBackupPolicyContinuousContinuousModeProperties? ContinuousModeProperties { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.BackupPolicyMigrationState_STATUS
    /// The object representing the state of the migration between the backup policies.
    /// </summary>
    [JsonPropertyName("migrationState")]
    public V1api20240815storageDatabaseAccountStatusBackupPolicyContinuousMigrationState? MigrationState { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.BackupPolicyMigrationState_STATUS
/// The object representing the state of the migration between the backup policies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusBackupPolicyPeriodicMigrationState
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.PeriodicModeProperties_STATUS
/// Configuration values for periodic mode backup
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusBackupPolicyPeriodicPeriodicModeProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backupIntervalInMinutes")]
    public int? BackupIntervalInMinutes { get; set; }

    [JsonPropertyName("backupRetentionIntervalInHours")]
    public int? BackupRetentionIntervalInHours { get; set; }

    [JsonPropertyName("backupStorageRedundancy")]
    public string? BackupStorageRedundancy { get; set; }
}

/// <summary>Storage version of v1api20240815.PeriodicModeBackupPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusBackupPolicyPeriodic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.BackupPolicyMigrationState_STATUS
    /// The object representing the state of the migration between the backup policies.
    /// </summary>
    [JsonPropertyName("migrationState")]
    public V1api20240815storageDatabaseAccountStatusBackupPolicyPeriodicMigrationState? MigrationState { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.PeriodicModeProperties_STATUS
    /// Configuration values for periodic mode backup
    /// </summary>
    [JsonPropertyName("periodicModeProperties")]
    public V1api20240815storageDatabaseAccountStatusBackupPolicyPeriodicPeriodicModeProperties? PeriodicModeProperties { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240815.BackupPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusBackupPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240815.ContinuousModeBackupPolicy_STATUS</summary>
    [JsonPropertyName("continuous")]
    public V1api20240815storageDatabaseAccountStatusBackupPolicyContinuous? Continuous { get; set; }

    /// <summary>Storage version of v1api20240815.PeriodicModeBackupPolicy_STATUS</summary>
    [JsonPropertyName("periodic")]
    public V1api20240815storageDatabaseAccountStatusBackupPolicyPeriodic? Periodic { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.Capability_STATUS
/// Cosmos DB capability object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusCapabilities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.Capacity_STATUS
/// The object that represents all properties related to capacity enforcement on an account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusCapacity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("totalThroughputLimit")]
    public int? TotalThroughputLimit { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusConditions
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
/// Storage version of v1api20240815.ConsistencyPolicy_STATUS
/// The consistency policy for the Cosmos DB database account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusConsistencyPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultConsistencyLevel")]
    public string? DefaultConsistencyLevel { get; set; }

    [JsonPropertyName("maxIntervalInSeconds")]
    public int? MaxIntervalInSeconds { get; set; }

    [JsonPropertyName("maxStalenessPrefix")]
    public int? MaxStalenessPrefix { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.CorsPolicy_STATUS
/// The CORS policy for the Cosmos DB database account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusCors
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedHeaders")]
    public string? AllowedHeaders { get; set; }

    [JsonPropertyName("allowedMethods")]
    public string? AllowedMethods { get; set; }

    [JsonPropertyName("allowedOrigins")]
    public string? AllowedOrigins { get; set; }

    [JsonPropertyName("exposedHeaders")]
    public string? ExposedHeaders { get; set; }

    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.FailoverPolicy_STATUS
/// The failover policy for a given region of a database account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusFailoverPolicies
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

/// <summary>Storage version of v1api20240815.ManagedServiceIdentity_UserAssignedIdentities_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusIdentityUserAssignedIdentities
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
/// Storage version of v1api20240815.ManagedServiceIdentity_STATUS
/// Identity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20240815storageDatabaseAccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.IpAddressOrRange_STATUS
/// IpAddressOrRange object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusIpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ipAddressOrRange")]
    public string? IpAddressOrRange { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.AccountKeyMetadata_STATUS
/// The metadata related to an access key for a given database account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusKeysMetadataPrimaryMasterKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("generationTime")]
    public string? GenerationTime { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.AccountKeyMetadata_STATUS
/// The metadata related to an access key for a given database account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusKeysMetadataPrimaryReadonlyMasterKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("generationTime")]
    public string? GenerationTime { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.AccountKeyMetadata_STATUS
/// The metadata related to an access key for a given database account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusKeysMetadataSecondaryMasterKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("generationTime")]
    public string? GenerationTime { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.AccountKeyMetadata_STATUS
/// The metadata related to an access key for a given database account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusKeysMetadataSecondaryReadonlyMasterKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("generationTime")]
    public string? GenerationTime { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.DatabaseAccountKeysMetadata_STATUS
/// The metadata related to each access key for the given Cosmos DB database account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusKeysMetadata
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.AccountKeyMetadata_STATUS
    /// The metadata related to an access key for a given database account.
    /// </summary>
    [JsonPropertyName("primaryMasterKey")]
    public V1api20240815storageDatabaseAccountStatusKeysMetadataPrimaryMasterKey? PrimaryMasterKey { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.AccountKeyMetadata_STATUS
    /// The metadata related to an access key for a given database account.
    /// </summary>
    [JsonPropertyName("primaryReadonlyMasterKey")]
    public V1api20240815storageDatabaseAccountStatusKeysMetadataPrimaryReadonlyMasterKey? PrimaryReadonlyMasterKey { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.AccountKeyMetadata_STATUS
    /// The metadata related to an access key for a given database account.
    /// </summary>
    [JsonPropertyName("secondaryMasterKey")]
    public V1api20240815storageDatabaseAccountStatusKeysMetadataSecondaryMasterKey? SecondaryMasterKey { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.AccountKeyMetadata_STATUS
    /// The metadata related to an access key for a given database account.
    /// </summary>
    [JsonPropertyName("secondaryReadonlyMasterKey")]
    public V1api20240815storageDatabaseAccountStatusKeysMetadataSecondaryReadonlyMasterKey? SecondaryReadonlyMasterKey { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.Location_STATUS
/// A region in which the Azure Cosmos DB database account is deployed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusLocations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.PrivateEndpointConnection_STATUS
/// A private endpoint connection
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusPrivateEndpointConnections
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.Location_STATUS
/// A region in which the Azure Cosmos DB database account is deployed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusReadLocations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.DatabaseRestoreResource_STATUS
/// Specific Databases to restore.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusRestoreParametersDatabasesToRestore
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("collectionNames")]
    public IList<string>? CollectionNames { get; set; }

    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.GremlinDatabaseRestoreResource_STATUS
/// Specific Gremlin Databases to restore.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusRestoreParametersGremlinDatabasesToRestore
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    [JsonPropertyName("graphNames")]
    public IList<string>? GraphNames { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.RestoreParameters_STATUS
/// Parameters to indicate the information about the restore.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusRestoreParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("databasesToRestore")]
    public IList<V1api20240815storageDatabaseAccountStatusRestoreParametersDatabasesToRestore>? DatabasesToRestore { get; set; }

    [JsonPropertyName("gremlinDatabasesToRestore")]
    public IList<V1api20240815storageDatabaseAccountStatusRestoreParametersGremlinDatabasesToRestore>? GremlinDatabasesToRestore { get; set; }

    [JsonPropertyName("restoreMode")]
    public string? RestoreMode { get; set; }

    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }

    [JsonPropertyName("restoreWithTtlDisabled")]
    public bool? RestoreWithTtlDisabled { get; set; }

    [JsonPropertyName("tablesToRestore")]
    public IList<string>? TablesToRestore { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.VirtualNetworkRule_STATUS
/// Virtual Network ACL Rule object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusVirtualNetworkRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("ignoreMissingVNetServiceEndpoint")]
    public bool? IgnoreMissingVNetServiceEndpoint { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.Location_STATUS
/// A region in which the Azure Cosmos DB database account is deployed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatusWriteLocations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    [JsonPropertyName("failoverPriority")]
    public int? FailoverPriority { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isZoneRedundant")]
    public bool? IsZoneRedundant { get; set; }

    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>Storage version of v1api20240815.DatabaseAccount_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageDatabaseAccountStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.AnalyticalStorageConfiguration_STATUS
    /// Analytical storage specific properties.
    /// </summary>
    [JsonPropertyName("analyticalStorageConfiguration")]
    public V1api20240815storageDatabaseAccountStatusAnalyticalStorageConfiguration? AnalyticalStorageConfiguration { get; set; }

    /// <summary>Storage version of v1api20240815.ApiProperties_STATUS</summary>
    [JsonPropertyName("apiProperties")]
    public V1api20240815storageDatabaseAccountStatusApiProperties? ApiProperties { get; set; }

    /// <summary>Storage version of v1api20240815.BackupPolicy_STATUS</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20240815storageDatabaseAccountStatusBackupPolicy? BackupPolicy { get; set; }

    [JsonPropertyName("capabilities")]
    public IList<V1api20240815storageDatabaseAccountStatusCapabilities>? Capabilities { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.Capacity_STATUS
    /// The object that represents all properties related to capacity enforcement on an account.
    /// </summary>
    [JsonPropertyName("capacity")]
    public V1api20240815storageDatabaseAccountStatusCapacity? Capacity { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20240815storageDatabaseAccountStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("connectorOffer")]
    public string? ConnectorOffer { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.ConsistencyPolicy_STATUS
    /// The consistency policy for the Cosmos DB database account.
    /// </summary>
    [JsonPropertyName("consistencyPolicy")]
    public V1api20240815storageDatabaseAccountStatusConsistencyPolicy? ConsistencyPolicy { get; set; }

    [JsonPropertyName("cors")]
    public IList<V1api20240815storageDatabaseAccountStatusCors>? Cors { get; set; }

    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    [JsonPropertyName("customerManagedKeyStatus")]
    public string? CustomerManagedKeyStatus { get; set; }

    [JsonPropertyName("databaseAccountOfferType")]
    public string? DatabaseAccountOfferType { get; set; }

    [JsonPropertyName("defaultIdentity")]
    public string? DefaultIdentity { get; set; }

    [JsonPropertyName("disableKeyBasedMetadataWriteAccess")]
    public bool? DisableKeyBasedMetadataWriteAccess { get; set; }

    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    [JsonPropertyName("documentEndpoint")]
    public string? DocumentEndpoint { get; set; }

    [JsonPropertyName("enableAnalyticalStorage")]
    public bool? EnableAnalyticalStorage { get; set; }

    [JsonPropertyName("enableAutomaticFailover")]
    public bool? EnableAutomaticFailover { get; set; }

    [JsonPropertyName("enableBurstCapacity")]
    public bool? EnableBurstCapacity { get; set; }

    [JsonPropertyName("enableCassandraConnector")]
    public bool? EnableCassandraConnector { get; set; }

    [JsonPropertyName("enableFreeTier")]
    public bool? EnableFreeTier { get; set; }

    [JsonPropertyName("enableMultipleWriteLocations")]
    public bool? EnableMultipleWriteLocations { get; set; }

    [JsonPropertyName("enablePartitionMerge")]
    public bool? EnablePartitionMerge { get; set; }

    [JsonPropertyName("failoverPolicies")]
    public IList<V1api20240815storageDatabaseAccountStatusFailoverPolicies>? FailoverPolicies { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.ManagedServiceIdentity_STATUS
    /// Identity for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20240815storageDatabaseAccountStatusIdentity? Identity { get; set; }

    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    [JsonPropertyName("ipRules")]
    public IList<V1api20240815storageDatabaseAccountStatusIpRules>? IpRules { get; set; }

    [JsonPropertyName("isVirtualNetworkFilterEnabled")]
    public bool? IsVirtualNetworkFilterEnabled { get; set; }

    [JsonPropertyName("keyVaultKeyUri")]
    public string? KeyVaultKeyUri { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.DatabaseAccountKeysMetadata_STATUS
    /// The metadata related to each access key for the given Cosmos DB database account.
    /// </summary>
    [JsonPropertyName("keysMetadata")]
    public V1api20240815storageDatabaseAccountStatusKeysMetadata? KeysMetadata { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("locations")]
    public IList<V1api20240815storageDatabaseAccountStatusLocations>? Locations { get; set; }

    [JsonPropertyName("minimalTlsVersion")]
    public string? MinimalTlsVersion { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("networkAclBypass")]
    public string? NetworkAclBypass { get; set; }

    [JsonPropertyName("networkAclBypassResourceIds")]
    public IList<string>? NetworkAclBypassResourceIds { get; set; }

    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20240815storageDatabaseAccountStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("readLocations")]
    public IList<V1api20240815storageDatabaseAccountStatusReadLocations>? ReadLocations { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.RestoreParameters_STATUS
    /// Parameters to indicate the information about the restore.
    /// </summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20240815storageDatabaseAccountStatusRestoreParameters? RestoreParameters { get; set; }

    /// <summary>
    /// Storage version of v1api20240815.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20240815storageDatabaseAccountStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20240815storageDatabaseAccountStatusVirtualNetworkRules>? VirtualNetworkRules { get; set; }

    [JsonPropertyName("writeLocations")]
    public IList<V1api20240815storageDatabaseAccountStatusWriteLocations>? WriteLocations { get; set; }
}

/// <summary>
/// Storage version of v1api20240815.DatabaseAccount
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2024-08-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240815storageDatabaseAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240815storageDatabaseAccountSpec?>, IStatus<V1api20240815storageDatabaseAccountStatus?>
{
    public const string KubeApiVersion = "v1api20240815storage";
    public const string KubeKind = "DatabaseAccount";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "databaseaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20240815storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseAccount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240815.DatabaseAccount_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240815storageDatabaseAccountSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240815.DatabaseAccount_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240815storageDatabaseAccountStatus? Status { get; set; }
}