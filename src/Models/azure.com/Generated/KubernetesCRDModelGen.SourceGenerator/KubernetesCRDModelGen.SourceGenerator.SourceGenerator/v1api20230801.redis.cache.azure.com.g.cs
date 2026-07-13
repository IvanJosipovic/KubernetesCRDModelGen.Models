#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cache.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /redis/resource-manager/Microsoft.Cache/Redis/stable/2023-08-01/redis.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230801RedisList : IKubernetesObject<V1ListMeta>, IItems<V1api20230801Redis>
{
    public const string KubeApiVersion = "v1api20230801";
    public const string KubeKind = "RedisList";
    public const string KubeGroup = "cache.azure.com";
    public const string KubePluralName = "redis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cache.azure.com/v1api20230801";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RedisList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230801Redis objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230801Redis> Items { get; set; }
}

/// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230801RedisSpecIdentityTypeEnum>))]
public enum V1api20230801RedisSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned, UserAssigned"), JsonStringEnumMemberName("SystemAssigned, UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20230801RedisSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20230801RedisSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecIdentity
{
    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public required V1api20230801RedisSpecIdentityTypeEnum Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20230801RedisSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// MinimumTlsVersion: Optional: requires clients to use a specified TLS version (or higher) to connect (e,g, &apos;1.0&apos;, &apos;1.1&apos;,
/// &apos;1.2&apos;)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230801RedisSpecMinimumTlsVersionEnum>))]
public enum V1api20230801RedisSpecMinimumTlsVersionEnum
{
    [EnumMember(Value = "1.0"), JsonStringEnumMemberName("1.0")]
    _10,
    [EnumMember(Value = "1.1"), JsonStringEnumMemberName("1.1")]
    _11,
    [EnumMember(Value = "1.2"), JsonStringEnumMemberName("1.2")]
    _12
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230801RedisSpecOperatorSpecSecretExpressions
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

/// <summary>HostName: indicates where the HostName secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecOperatorSpecSecretsHostName
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

/// <summary>Port: indicates where the Port secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecOperatorSpecSecretsPort
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
/// PrimaryKey: indicates where the PrimaryKey secret should be placed. If omitted, the secret will not be retrieved from
/// Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecOperatorSpecSecretsPrimaryKey
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
/// SecondaryKey: indicates where the SecondaryKey secret should be placed. If omitted, the secret will not be retrieved
/// from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecOperatorSpecSecretsSecondaryKey
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

/// <summary>SSLPort: indicates where the SSLPort secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecOperatorSpecSecretsSslPort
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
public partial class V1api20230801RedisSpecOperatorSpecSecrets
{
    /// <summary>HostName: indicates where the HostName secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("hostName")]
    public V1api20230801RedisSpecOperatorSpecSecretsHostName? HostName { get; set; }

    /// <summary>Port: indicates where the Port secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("port")]
    public V1api20230801RedisSpecOperatorSpecSecretsPort? Port { get; set; }

    /// <summary>
    /// PrimaryKey: indicates where the PrimaryKey secret should be placed. If omitted, the secret will not be retrieved from
    /// Azure.
    /// </summary>
    [JsonPropertyName("primaryKey")]
    public V1api20230801RedisSpecOperatorSpecSecretsPrimaryKey? PrimaryKey { get; set; }

    /// <summary>
    /// SecondaryKey: indicates where the SecondaryKey secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("secondaryKey")]
    public V1api20230801RedisSpecOperatorSpecSecretsSecondaryKey? SecondaryKey { get; set; }

    /// <summary>SSLPort: indicates where the SSLPort secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("sslPort")]
    public V1api20230801RedisSpecOperatorSpecSecretsSslPort? SslPort { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230801RedisSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230801RedisSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20230801RedisSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PublicNetworkAccess: Whether or not public endpoint access is allowed for this cache.  Value is optional but if passed
/// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. If &apos;Disabled&apos;, private endpoints are the exclusive access method. Default value is
/// &apos;Enabled&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230801RedisSpecPublicNetworkAccessEnum>))]
public enum V1api20230801RedisSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// RedisConfiguration: All Redis Settings. Few possible keys:
/// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
/// etc.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecRedisConfiguration
{
    /// <summary>AadEnabled: Specifies whether AAD based authentication has been enabled or disabled for the cache</summary>
    [JsonPropertyName("aad-enabled")]
    public string? AadEnabled { get; set; }

    /// <summary>AofBackupEnabled: Specifies whether the aof backup is enabled</summary>
    [JsonPropertyName("aof-backup-enabled")]
    public string? AofBackupEnabled { get; set; }

    /// <summary>AofStorageConnectionString0: First storage account connection string</summary>
    [JsonPropertyName("aof-storage-connection-string-0")]
    public string? AofStorageConnectionString0 { get; set; }

    /// <summary>AofStorageConnectionString1: Second storage account connection string</summary>
    [JsonPropertyName("aof-storage-connection-string-1")]
    public string? AofStorageConnectionString1 { get; set; }

    /// <summary>
    /// Authnotrequired: Specifies whether the authentication is disabled. Setting this property is highly discouraged from
    /// security point of view.
    /// </summary>
    [JsonPropertyName("authnotrequired")]
    public string? Authnotrequired { get; set; }

    /// <summary>MaxfragmentationmemoryReserved: Value in megabytes reserved for fragmentation per shard</summary>
    [JsonPropertyName("maxfragmentationmemory-reserved")]
    public string? MaxfragmentationmemoryReserved { get; set; }

    /// <summary>MaxmemoryDelta: Value in megabytes reserved for non-cache usage per shard e.g. failover.</summary>
    [JsonPropertyName("maxmemory-delta")]
    public string? MaxmemoryDelta { get; set; }

    /// <summary>MaxmemoryPolicy: The eviction strategy used when your data won&apos;t fit within its memory limit.</summary>
    [JsonPropertyName("maxmemory-policy")]
    public string? MaxmemoryPolicy { get; set; }

    /// <summary>MaxmemoryReserved: Value in megabytes reserved for non-cache usage per shard e.g. failover.</summary>
    [JsonPropertyName("maxmemory-reserved")]
    public string? MaxmemoryReserved { get; set; }

    /// <summary>NotifyKeyspaceEvents: The keyspace events which should be monitored.</summary>
    [JsonPropertyName("notify-keyspace-events")]
    public string? NotifyKeyspaceEvents { get; set; }

    /// <summary>
    /// PreferredDataPersistenceAuthMethod: Preferred auth method to communicate to storage account used for data persistence,
    /// specify SAS or ManagedIdentity, default value is SAS
    /// </summary>
    [JsonPropertyName("preferred-data-persistence-auth-method")]
    public string? PreferredDataPersistenceAuthMethod { get; set; }

    /// <summary>RdbBackupEnabled: Specifies whether the rdb backup is enabled</summary>
    [JsonPropertyName("rdb-backup-enabled")]
    public string? RdbBackupEnabled { get; set; }

    /// <summary>
    /// RdbBackupFrequency: Specifies the frequency for creating rdb backup in minutes. Valid values: (15, 30, 60, 360, 720,
    /// 1440)
    /// </summary>
    [JsonPropertyName("rdb-backup-frequency")]
    public string? RdbBackupFrequency { get; set; }

    /// <summary>RdbBackupMaxSnapshotCount: Specifies the maximum number of snapshots for rdb backup</summary>
    [JsonPropertyName("rdb-backup-max-snapshot-count")]
    public string? RdbBackupMaxSnapshotCount { get; set; }

    /// <summary>RdbStorageConnectionString: The storage account connection string for storing rdb file</summary>
    [JsonPropertyName("rdb-storage-connection-string")]
    public string? RdbStorageConnectionString { get; set; }

    /// <summary>StorageSubscriptionId: SubscriptionId of the storage account for persistence (aof/rdb) using ManagedIdentity.</summary>
    [JsonPropertyName("storage-subscription-id")]
    public string? StorageSubscriptionId { get; set; }
}

/// <summary>Family: The SKU family to use. Valid values: (C, P). (C = Basic/Standard, P = Premium).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230801RedisSpecSkuFamilyEnum>))]
public enum V1api20230801RedisSpecSkuFamilyEnum
{
    [EnumMember(Value = "C"), JsonStringEnumMemberName("C")]
    C,
    [EnumMember(Value = "P"), JsonStringEnumMemberName("P")]
    P
}

/// <summary>Name: The type of Redis cache to deploy. Valid values: (Basic, Standard, Premium)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230801RedisSpecSkuNameEnum>))]
public enum V1api20230801RedisSpecSkuNameEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The SKU of the Redis cache to deploy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecSku
{
    /// <summary>
    /// Capacity: The size of the Redis cache to deploy. Valid values: for C (Basic/Standard) family (0, 1, 2, 3, 4, 5, 6), for
    /// P (Premium) family (1, 2, 3, 4).
    /// </summary>
    [JsonPropertyName("capacity")]
    public required int Capacity { get; set; }

    /// <summary>Family: The SKU family to use. Valid values: (C, P). (C = Basic/Standard, P = Premium).</summary>
    [JsonPropertyName("family")]
    public required V1api20230801RedisSpecSkuFamilyEnum Family { get; set; }

    /// <summary>Name: The type of Redis cache to deploy. Valid values: (Basic, Standard, Premium)</summary>
    [JsonPropertyName("name")]
    public required V1api20230801RedisSpecSkuNameEnum Name { get; set; }
}

/// <summary>
/// SubnetReference: The full resource ID of a subnet in a virtual network to deploy the Redis cache in. Example format:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpecSubnetReference
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
/// UpdateChannel: Optional: Specifies the update channel for the monthly Redis updates your Redis Cache will receive.
/// Caches using &apos;Preview&apos; update channel get latest Redis updates at least 4 weeks ahead of &apos;Stable&apos; channel caches.
/// Default value is &apos;Stable&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230801RedisSpecUpdateChannelEnum>))]
public enum V1api20230801RedisSpecUpdateChannelEnum
{
    [EnumMember(Value = "Preview"), JsonStringEnumMemberName("Preview")]
    Preview,
    [EnumMember(Value = "Stable"), JsonStringEnumMemberName("Stable")]
    Stable
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>EnableNonSslPort: Specifies whether the non-ssl Redis server port (6379) is enabled.</summary>
    [JsonPropertyName("enableNonSslPort")]
    public bool? EnableNonSslPort { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20230801RedisSpecIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// MinimumTlsVersion: Optional: requires clients to use a specified TLS version (or higher) to connect (e,g, &apos;1.0&apos;, &apos;1.1&apos;,
    /// &apos;1.2&apos;)
    /// </summary>
    [JsonPropertyName("minimumTlsVersion")]
    public V1api20230801RedisSpecMinimumTlsVersionEnum? MinimumTlsVersion { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230801RedisSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230801RedisSpecOwner Owner { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public endpoint access is allowed for this cache.  Value is optional but if passed
    /// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. If &apos;Disabled&apos;, private endpoints are the exclusive access method. Default value is
    /// &apos;Enabled&apos;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20230801RedisSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>
    /// RedisConfiguration: All Redis Settings. Few possible keys:
    /// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
    /// etc.
    /// </summary>
    [JsonPropertyName("redisConfiguration")]
    public V1api20230801RedisSpecRedisConfiguration? RedisConfiguration { get; set; }

    /// <summary>
    /// RedisVersion: Redis version. This should be in the form &apos;major[.minor]&apos; (only &apos;major&apos; is required) or the value &apos;latest&apos;
    /// which refers to the latest stable Redis version that is available. Supported versions: 4.0, 6.0 (latest). Default value
    /// is &apos;latest&apos;.
    /// </summary>
    [JsonPropertyName("redisVersion")]
    public string? RedisVersion { get; set; }

    /// <summary>ReplicasPerMaster: The number of replicas to be created per primary.</summary>
    [JsonPropertyName("replicasPerMaster")]
    public int? ReplicasPerMaster { get; set; }

    /// <summary>ReplicasPerPrimary: The number of replicas to be created per primary.</summary>
    [JsonPropertyName("replicasPerPrimary")]
    public int? ReplicasPerPrimary { get; set; }

    /// <summary>ShardCount: The number of shards to be created on a Premium Cluster Cache.</summary>
    [JsonPropertyName("shardCount")]
    public int? ShardCount { get; set; }

    /// <summary>Sku: The SKU of the Redis cache to deploy.</summary>
    [JsonPropertyName("sku")]
    public required V1api20230801RedisSpecSku Sku { get; set; }

    /// <summary>
    /// StaticIP: Static IP address. Optionally, may be specified when deploying a Redis cache inside an existing Azure Virtual
    /// Network; auto assigned by default.
    /// </summary>
    [JsonPropertyName("staticIP")]
    public string? StaticIP { get; set; }

    /// <summary>
    /// SubnetReference: The full resource ID of a subnet in a virtual network to deploy the Redis cache in. Example format:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1
    /// </summary>
    [JsonPropertyName("subnetReference")]
    public V1api20230801RedisSpecSubnetReference? SubnetReference { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TenantSettings: A dictionary of tenant settings</summary>
    [JsonPropertyName("tenantSettings")]
    public IDictionary<string, string>? TenantSettings { get; set; }

    /// <summary>
    /// UpdateChannel: Optional: Specifies the update channel for the monthly Redis updates your Redis Cache will receive.
    /// Caches using &apos;Preview&apos; update channel get latest Redis updates at least 4 weeks ahead of &apos;Stable&apos; channel caches.
    /// Default value is &apos;Stable&apos;.
    /// </summary>
    [JsonPropertyName("updateChannel")]
    public V1api20230801RedisSpecUpdateChannelEnum? UpdateChannel { get; set; }

    /// <summary>Zones: A list of availability zones denoting where the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisStatusConditions
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

/// <summary>User assigned identity properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client ID of the assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID of the assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisStatusIdentity
{
    /// <summary>
    /// PrincipalId: The service principal ID of the system assigned identity. This property will only be provided for a system
    /// assigned identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant ID of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20230801RedisStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Details of single instance of redis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisStatusInstances
{
    /// <summary>IsMaster: Specifies whether the instance is a primary node.</summary>
    [JsonPropertyName("isMaster")]
    public bool? IsMaster { get; set; }

    /// <summary>IsPrimary: Specifies whether the instance is a primary node.</summary>
    [JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; set; }

    /// <summary>NonSslPort: If enableNonSslPort is true, provides Redis instance Non-SSL port.</summary>
    [JsonPropertyName("nonSslPort")]
    public int? NonSslPort { get; set; }

    /// <summary>ShardId: If clustering is enabled, the Shard ID of Redis Instance</summary>
    [JsonPropertyName("shardId")]
    public int? ShardId { get; set; }

    /// <summary>SslPort: Redis instance SSL port.</summary>
    [JsonPropertyName("sslPort")]
    public int? SslPort { get; set; }

    /// <summary>Zone: If the Cache uses availability zones, specifies availability zone where this instance is located.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>Linked server Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisStatusLinkedServers
{
    /// <summary>Id: Linked server Id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>The Private Endpoint Connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// RedisConfiguration: All Redis Settings. Few possible keys:
/// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
/// etc.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisStatusRedisConfiguration
{
    /// <summary>AadEnabled: Specifies whether AAD based authentication has been enabled or disabled for the cache</summary>
    [JsonPropertyName("aad-enabled")]
    public string? AadEnabled { get; set; }

    /// <summary>AofBackupEnabled: Specifies whether the aof backup is enabled</summary>
    [JsonPropertyName("aof-backup-enabled")]
    public string? AofBackupEnabled { get; set; }

    /// <summary>AofStorageConnectionString0: First storage account connection string</summary>
    [JsonPropertyName("aof-storage-connection-string-0")]
    public string? AofStorageConnectionString0 { get; set; }

    /// <summary>AofStorageConnectionString1: Second storage account connection string</summary>
    [JsonPropertyName("aof-storage-connection-string-1")]
    public string? AofStorageConnectionString1 { get; set; }

    /// <summary>
    /// Authnotrequired: Specifies whether the authentication is disabled. Setting this property is highly discouraged from
    /// security point of view.
    /// </summary>
    [JsonPropertyName("authnotrequired")]
    public string? Authnotrequired { get; set; }

    /// <summary>Maxclients: The max clients config</summary>
    [JsonPropertyName("maxclients")]
    public string? Maxclients { get; set; }

    /// <summary>MaxfragmentationmemoryReserved: Value in megabytes reserved for fragmentation per shard</summary>
    [JsonPropertyName("maxfragmentationmemory-reserved")]
    public string? MaxfragmentationmemoryReserved { get; set; }

    /// <summary>MaxmemoryDelta: Value in megabytes reserved for non-cache usage per shard e.g. failover.</summary>
    [JsonPropertyName("maxmemory-delta")]
    public string? MaxmemoryDelta { get; set; }

    /// <summary>MaxmemoryPolicy: The eviction strategy used when your data won&apos;t fit within its memory limit.</summary>
    [JsonPropertyName("maxmemory-policy")]
    public string? MaxmemoryPolicy { get; set; }

    /// <summary>MaxmemoryReserved: Value in megabytes reserved for non-cache usage per shard e.g. failover.</summary>
    [JsonPropertyName("maxmemory-reserved")]
    public string? MaxmemoryReserved { get; set; }

    /// <summary>NotifyKeyspaceEvents: The keyspace events which should be monitored.</summary>
    [JsonPropertyName("notify-keyspace-events")]
    public string? NotifyKeyspaceEvents { get; set; }

    /// <summary>
    /// PreferredDataArchiveAuthMethod: Preferred auth method to communicate to storage account used for data archive, specify
    /// SAS or ManagedIdentity, default value is SAS
    /// </summary>
    [JsonPropertyName("preferred-data-archive-auth-method")]
    public string? PreferredDataArchiveAuthMethod { get; set; }

    /// <summary>
    /// PreferredDataPersistenceAuthMethod: Preferred auth method to communicate to storage account used for data persistence,
    /// specify SAS or ManagedIdentity, default value is SAS
    /// </summary>
    [JsonPropertyName("preferred-data-persistence-auth-method")]
    public string? PreferredDataPersistenceAuthMethod { get; set; }

    /// <summary>RdbBackupEnabled: Specifies whether the rdb backup is enabled</summary>
    [JsonPropertyName("rdb-backup-enabled")]
    public string? RdbBackupEnabled { get; set; }

    /// <summary>
    /// RdbBackupFrequency: Specifies the frequency for creating rdb backup in minutes. Valid values: (15, 30, 60, 360, 720,
    /// 1440)
    /// </summary>
    [JsonPropertyName("rdb-backup-frequency")]
    public string? RdbBackupFrequency { get; set; }

    /// <summary>RdbBackupMaxSnapshotCount: Specifies the maximum number of snapshots for rdb backup</summary>
    [JsonPropertyName("rdb-backup-max-snapshot-count")]
    public string? RdbBackupMaxSnapshotCount { get; set; }

    /// <summary>RdbStorageConnectionString: The storage account connection string for storing rdb file</summary>
    [JsonPropertyName("rdb-storage-connection-string")]
    public string? RdbStorageConnectionString { get; set; }

    /// <summary>StorageSubscriptionId: SubscriptionId of the storage account for persistence (aof/rdb) using ManagedIdentity.</summary>
    [JsonPropertyName("storage-subscription-id")]
    public string? StorageSubscriptionId { get; set; }

    /// <summary>ZonalConfiguration: Zonal Configuration</summary>
    [JsonPropertyName("zonal-configuration")]
    public string? ZonalConfiguration { get; set; }
}

/// <summary>Sku: The SKU of the Redis cache to deploy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisStatusSku
{
    /// <summary>
    /// Capacity: The size of the Redis cache to deploy. Valid values: for C (Basic/Standard) family (0, 1, 2, 3, 4, 5, 6), for
    /// P (Premium) family (1, 2, 3, 4).
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: The SKU family to use. Valid values: (C, P). (C = Basic/Standard, P = Premium).</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The type of Redis cache to deploy. Valid values: (Basic, Standard, Premium)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230801RedisStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230801RedisStatusConditions>? Conditions { get; set; }

    /// <summary>EnableNonSslPort: Specifies whether the non-ssl Redis server port (6379) is enabled.</summary>
    [JsonPropertyName("enableNonSslPort")]
    public bool? EnableNonSslPort { get; set; }

    /// <summary>HostName: Redis host name.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20230801RedisStatusIdentity? Identity { get; set; }

    /// <summary>Instances: List of the Redis instances associated with the cache</summary>
    [JsonPropertyName("instances")]
    public IList<V1api20230801RedisStatusInstances>? Instances { get; set; }

    /// <summary>LinkedServers: List of the linked servers associated with the cache</summary>
    [JsonPropertyName("linkedServers")]
    public IList<V1api20230801RedisStatusLinkedServers>? LinkedServers { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// MinimumTlsVersion: Optional: requires clients to use a specified TLS version (or higher) to connect (e,g, &apos;1.0&apos;, &apos;1.1&apos;,
    /// &apos;1.2&apos;)
    /// </summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Port: Redis non-SSL port.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connection associated with the specified redis cache</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20230801RedisStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: Redis instance provisioning status.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public endpoint access is allowed for this cache.  Value is optional but if passed
    /// in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. If &apos;Disabled&apos;, private endpoints are the exclusive access method. Default value is
    /// &apos;Enabled&apos;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// RedisConfiguration: All Redis Settings. Few possible keys:
    /// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
    /// etc.
    /// </summary>
    [JsonPropertyName("redisConfiguration")]
    public V1api20230801RedisStatusRedisConfiguration? RedisConfiguration { get; set; }

    /// <summary>
    /// RedisVersion: Redis version. This should be in the form &apos;major[.minor]&apos; (only &apos;major&apos; is required) or the value &apos;latest&apos;
    /// which refers to the latest stable Redis version that is available. Supported versions: 4.0, 6.0 (latest). Default value
    /// is &apos;latest&apos;.
    /// </summary>
    [JsonPropertyName("redisVersion")]
    public string? RedisVersion { get; set; }

    /// <summary>ReplicasPerMaster: The number of replicas to be created per primary.</summary>
    [JsonPropertyName("replicasPerMaster")]
    public int? ReplicasPerMaster { get; set; }

    /// <summary>ReplicasPerPrimary: The number of replicas to be created per primary.</summary>
    [JsonPropertyName("replicasPerPrimary")]
    public int? ReplicasPerPrimary { get; set; }

    /// <summary>ShardCount: The number of shards to be created on a Premium Cluster Cache.</summary>
    [JsonPropertyName("shardCount")]
    public int? ShardCount { get; set; }

    /// <summary>Sku: The SKU of the Redis cache to deploy.</summary>
    [JsonPropertyName("sku")]
    public V1api20230801RedisStatusSku? Sku { get; set; }

    /// <summary>SslPort: Redis SSL port.</summary>
    [JsonPropertyName("sslPort")]
    public int? SslPort { get; set; }

    /// <summary>
    /// StaticIP: Static IP address. Optionally, may be specified when deploying a Redis cache inside an existing Azure Virtual
    /// Network; auto assigned by default.
    /// </summary>
    [JsonPropertyName("staticIP")]
    public string? StaticIP { get; set; }

    /// <summary>
    /// SubnetId: The full resource ID of a subnet in a virtual network to deploy the Redis cache in. Example format:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1
    /// </summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TenantSettings: A dictionary of tenant settings</summary>
    [JsonPropertyName("tenantSettings")]
    public IDictionary<string, string>? TenantSettings { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UpdateChannel: Optional: Specifies the update channel for the monthly Redis updates your Redis Cache will receive.
    /// Caches using &apos;Preview&apos; update channel get latest Redis updates at least 4 weeks ahead of &apos;Stable&apos; channel caches.
    /// Default value is &apos;Stable&apos;.
    /// </summary>
    [JsonPropertyName("updateChannel")]
    public string? UpdateChannel { get; set; }

    /// <summary>Zones: A list of availability zones denoting where the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /redis/resource-manager/Microsoft.Cache/Redis/stable/2023-08-01/redis.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230801Redis : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230801RedisSpec?>, IStatus<V1api20230801RedisStatus?>
{
    public const string KubeApiVersion = "v1api20230801";
    public const string KubeKind = "Redis";
    public const string KubeGroup = "cache.azure.com";
    public const string KubePluralName = "redis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cache.azure.com/v1api20230801";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Redis";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230801RedisSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20230801RedisStatus? Status { get; set; }
}