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
/// Storage version of v1api20210601.FlexibleServer
/// Generator information:
/// - Generated from: /postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2021-06-01/postgresql.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601storageFlexibleServerList : IKubernetesObject<V1ListMeta>, IItems<V1api20210601storageFlexibleServer>
{
    public const string KubeApiVersion = "v1api20210601storage";
    public const string KubeKind = "FlexibleServerList";
    public const string KubeGroup = "dbforpostgresql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbforpostgresql.azure.com/v1api20210601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210601storageFlexibleServer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210601storageFlexibleServer> Items { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecAdministratorLoginPassword
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

/// <summary>
/// Storage version of v1api20210601.Backup
/// Backup properties of a server
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecBackup
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    [JsonPropertyName("geoRedundantBackup")]
    public string? GeoRedundantBackup { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.HighAvailability
/// High availability properties of a server
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecHighAvailability
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.MaintenanceWindow
/// Maintenance window properties of a server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecMaintenanceWindow
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("customWindow")]
    public string? CustomWindow { get; set; }

    [JsonPropertyName("dayOfWeek")]
    public int? DayOfWeek { get; set; }

    [JsonPropertyName("startHour")]
    public int? StartHour { get; set; }

    [JsonPropertyName("startMinute")]
    public int? StartMinute { get; set; }
}

/// <summary>DelegatedSubnetResourceReference: delegated subnet arm resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecNetworkDelegatedSubnetResourceReference
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
public partial class V1api20210601storageFlexibleServerSpecNetworkPrivateDnsZoneArmResourceReference
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
/// Storage version of v1api20210601.Network
/// Network properties of a server
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecNetwork
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>DelegatedSubnetResourceReference: delegated subnet arm resource id.</summary>
    [JsonPropertyName("delegatedSubnetResourceReference")]
    public V1api20210601storageFlexibleServerSpecNetworkDelegatedSubnetResourceReference? DelegatedSubnetResourceReference { get; set; }

    /// <summary>PrivateDnsZoneArmResourceReference: private dns zone arm resource id.</summary>
    [JsonPropertyName("privateDnsZoneArmResourceReference")]
    public V1api20210601storageFlexibleServerSpecNetworkPrivateDnsZoneArmResourceReference? PrivateDnsZoneArmResourceReference { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210601storageFlexibleServerSpecOperatorSpecSecretExpressions
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
public partial class V1api20210601storageFlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName
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

/// <summary>Storage version of v1api20210601.FlexibleServerOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecOperatorSpecSecrets
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
    [JsonPropertyName("fullyQualifiedDomainName")]
    public V1api20210601storageFlexibleServerSpecOperatorSpecSecretsFullyQualifiedDomainName? FullyQualifiedDomainName { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.FlexibleServerOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210601storageFlexibleServerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210601storageFlexibleServerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v1api20210601.FlexibleServerOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20210601storageFlexibleServerSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.Sku
/// Sku information related properties of a server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// SourceServerResourceReference: The source server resource ID to restore from. It&apos;s required when &apos;createMode&apos; is
/// &apos;PointInTimeRestore&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecSourceServerResourceReference
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
/// Storage version of v1api20210601.Storage
/// Storage properties of a server
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpecStorage
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }
}

/// <summary>Storage version of v1api20210601.FlexibleServer_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("administratorLoginPassword")]
    public V1api20210601storageFlexibleServerSpecAdministratorLoginPassword? AdministratorLoginPassword { get; set; }

    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.Backup
    /// Backup properties of a server
    /// </summary>
    [JsonPropertyName("backup")]
    public V1api20210601storageFlexibleServerSpecBackup? Backup { get; set; }

    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.HighAvailability
    /// High availability properties of a server
    /// </summary>
    [JsonPropertyName("highAvailability")]
    public V1api20210601storageFlexibleServerSpecHighAvailability? HighAvailability { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.MaintenanceWindow
    /// Maintenance window properties of a server.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1api20210601storageFlexibleServerSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.Network
    /// Network properties of a server
    /// </summary>
    [JsonPropertyName("network")]
    public V1api20210601storageFlexibleServerSpecNetwork? Network { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.FlexibleServerOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210601storageFlexibleServerSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210601storageFlexibleServerSpecOwner Owner { get; set; }

    [JsonPropertyName("pointInTimeUTC")]
    public string? PointInTimeUTC { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.Sku
    /// Sku information related properties of a server.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20210601storageFlexibleServerSpecSku? Sku { get; set; }

    /// <summary>
    /// SourceServerResourceReference: The source server resource ID to restore from. It&apos;s required when &apos;createMode&apos; is
    /// &apos;PointInTimeRestore&apos;.
    /// </summary>
    [JsonPropertyName("sourceServerResourceReference")]
    public V1api20210601storageFlexibleServerSpecSourceServerResourceReference? SourceServerResourceReference { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.Storage
    /// Storage properties of a server
    /// </summary>
    [JsonPropertyName("storage")]
    public V1api20210601storageFlexibleServerSpecStorage? Storage { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.Backup_STATUS
/// Backup properties of a server
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerStatusBackup
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    [JsonPropertyName("earliestRestoreDate")]
    public string? EarliestRestoreDate { get; set; }

    [JsonPropertyName("geoRedundantBackup")]
    public string? GeoRedundantBackup { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerStatusConditions
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
/// Storage version of v1api20210601.HighAvailability_STATUS
/// High availability properties of a server
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerStatusHighAvailability
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.MaintenanceWindow_STATUS
/// Maintenance window properties of a server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerStatusMaintenanceWindow
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("customWindow")]
    public string? CustomWindow { get; set; }

    [JsonPropertyName("dayOfWeek")]
    public int? DayOfWeek { get; set; }

    [JsonPropertyName("startHour")]
    public int? StartHour { get; set; }

    [JsonPropertyName("startMinute")]
    public int? StartMinute { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.Network_STATUS
/// Network properties of a server
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerStatusNetwork
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("delegatedSubnetResourceId")]
    public string? DelegatedSubnetResourceId { get; set; }

    [JsonPropertyName("privateDnsZoneArmResourceId")]
    public string? PrivateDnsZoneArmResourceId { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.Sku_STATUS
/// Sku information related properties of a server.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerStatusSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.Storage_STATUS
/// Storage properties of a server
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerStatusStorage
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("storageSizeGB")]
    public int? StorageSizeGB { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerStatusSystemData
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

/// <summary>Storage version of v1api20210601.FlexibleServer_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageFlexibleServerStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.Backup_STATUS
    /// Backup properties of a server
    /// </summary>
    [JsonPropertyName("backup")]
    public V1api20210601storageFlexibleServerStatusBackup? Backup { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20210601storageFlexibleServerStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    [JsonPropertyName("fullyQualifiedDomainName")]
    public string? FullyQualifiedDomainName { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.HighAvailability_STATUS
    /// High availability properties of a server
    /// </summary>
    [JsonPropertyName("highAvailability")]
    public V1api20210601storageFlexibleServerStatusHighAvailability? HighAvailability { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.MaintenanceWindow_STATUS
    /// Maintenance window properties of a server.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1api20210601storageFlexibleServerStatusMaintenanceWindow? MaintenanceWindow { get; set; }

    [JsonPropertyName("minorVersion")]
    public string? MinorVersion { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.Network_STATUS
    /// Network properties of a server
    /// </summary>
    [JsonPropertyName("network")]
    public V1api20210601storageFlexibleServerStatusNetwork? Network { get; set; }

    [JsonPropertyName("pointInTimeUTC")]
    public string? PointInTimeUTC { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.Sku_STATUS
    /// Sku information related properties of a server.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20210601storageFlexibleServerStatusSku? Sku { get; set; }

    [JsonPropertyName("sourceServerResourceId")]
    public string? SourceServerResourceId { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.Storage_STATUS
    /// Storage properties of a server
    /// </summary>
    [JsonPropertyName("storage")]
    public V1api20210601storageFlexibleServerStatusStorage? Storage { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20210601storageFlexibleServerStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.FlexibleServer
/// Generator information:
/// - Generated from: /postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2021-06-01/postgresql.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601storageFlexibleServer : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210601storageFlexibleServerSpec?>, IStatus<V1api20210601storageFlexibleServerStatus?>
{
    public const string KubeApiVersion = "v1api20210601storage";
    public const string KubeKind = "FlexibleServer";
    public const string KubeGroup = "dbforpostgresql.azure.com";
    public const string KubePluralName = "flexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dbforpostgresql.azure.com/v1api20210601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlexibleServer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20210601.FlexibleServer_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20210601storageFlexibleServerSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20210601.FlexibleServer_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20210601storageFlexibleServerStatus? Status { get; set; }
}