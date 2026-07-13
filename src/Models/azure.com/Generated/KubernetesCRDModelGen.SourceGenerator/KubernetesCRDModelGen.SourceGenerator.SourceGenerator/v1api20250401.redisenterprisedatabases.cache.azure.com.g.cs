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
/// - Generated from: /redisenterprise/resource-manager/Microsoft.Cache/RedisEnterprise/stable/2025-04-01/redisenterprise.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}/databases/{databaseName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250401RedisEnterpriseDatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1api20250401RedisEnterpriseDatabase>
{
    public const string KubeApiVersion = "v1api20250401";
    public const string KubeKind = "RedisEnterpriseDatabaseList";
    public const string KubeGroup = "cache.azure.com";
    public const string KubePluralName = "redisenterprisedatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cache.azure.com/v1api20250401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RedisEnterpriseDatabaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20250401RedisEnterpriseDatabase objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20250401RedisEnterpriseDatabase> Items { get; set; }
}

/// <summary>
/// AccessKeysAuthentication: This property can be Enabled/Disabled to allow or deny access with the current access keys.
/// Can be updated even after database is created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250401RedisEnterpriseDatabaseSpecAccessKeysAuthenticationEnum>))]
public enum V1api20250401RedisEnterpriseDatabaseSpecAccessKeysAuthenticationEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// ClientProtocol: Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Default is
/// TLS-encrypted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250401RedisEnterpriseDatabaseSpecClientProtocolEnum>))]
public enum V1api20250401RedisEnterpriseDatabaseSpecClientProtocolEnum
{
    [EnumMember(Value = "Encrypted"), JsonStringEnumMemberName("Encrypted")]
    Encrypted,
    [EnumMember(Value = "Plaintext"), JsonStringEnumMemberName("Plaintext")]
    Plaintext
}

/// <summary>
/// ClusteringPolicy: Clustering policy - default is OSSCluster. This property must be chosen at create time, and cannot be
/// changed without deleting the database.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250401RedisEnterpriseDatabaseSpecClusteringPolicyEnum>))]
public enum V1api20250401RedisEnterpriseDatabaseSpecClusteringPolicyEnum
{
    [EnumMember(Value = "EnterpriseCluster"), JsonStringEnumMemberName("EnterpriseCluster")]
    EnterpriseCluster,
    [EnumMember(Value = "OSSCluster"), JsonStringEnumMemberName("OSSCluster")]
    OSSCluster
}

/// <summary>
/// DeferUpgrade: Option to defer upgrade when newest version is released - default is NotDeferred. Learn more:
/// https://aka.ms/redisversionupgrade
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250401RedisEnterpriseDatabaseSpecDeferUpgradeEnum>))]
public enum V1api20250401RedisEnterpriseDatabaseSpecDeferUpgradeEnum
{
    [EnumMember(Value = "Deferred"), JsonStringEnumMemberName("Deferred")]
    Deferred,
    [EnumMember(Value = "NotDeferred"), JsonStringEnumMemberName("NotDeferred")]
    NotDeferred
}

/// <summary>EvictionPolicy: Redis eviction policy - default is VolatileLRU</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250401RedisEnterpriseDatabaseSpecEvictionPolicyEnum>))]
public enum V1api20250401RedisEnterpriseDatabaseSpecEvictionPolicyEnum
{
    [EnumMember(Value = "AllKeysLFU"), JsonStringEnumMemberName("AllKeysLFU")]
    AllKeysLFU,
    [EnumMember(Value = "AllKeysLRU"), JsonStringEnumMemberName("AllKeysLRU")]
    AllKeysLRU,
    [EnumMember(Value = "AllKeysRandom"), JsonStringEnumMemberName("AllKeysRandom")]
    AllKeysRandom,
    [EnumMember(Value = "NoEviction"), JsonStringEnumMemberName("NoEviction")]
    NoEviction,
    [EnumMember(Value = "VolatileLFU"), JsonStringEnumMemberName("VolatileLFU")]
    VolatileLFU,
    [EnumMember(Value = "VolatileLRU"), JsonStringEnumMemberName("VolatileLRU")]
    VolatileLRU,
    [EnumMember(Value = "VolatileRandom"), JsonStringEnumMemberName("VolatileRandom")]
    VolatileRandom,
    [EnumMember(Value = "VolatileTTL"), JsonStringEnumMemberName("VolatileTTL")]
    VolatileTTL
}

/// <summary>Reference: Resource ID of a database resource to link with this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseSpecGeoReplicationLinkedDatabasesReference
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

/// <summary>Specifies details of a linked database resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseSpecGeoReplicationLinkedDatabases
{
    /// <summary>Reference: Resource ID of a database resource to link with this database.</summary>
    [JsonPropertyName("reference")]
    public V1api20250401RedisEnterpriseDatabaseSpecGeoReplicationLinkedDatabasesReference? Reference { get; set; }
}

/// <summary>GeoReplication: Optional set of properties to configure geo replication for this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseSpecGeoReplication
{
    /// <summary>GroupNickname: Name for the group of linked database resources</summary>
    [JsonPropertyName("groupNickname")]
    public string? GroupNickname { get; set; }

    /// <summary>LinkedDatabases: List of database resources to link with this database</summary>
    [JsonPropertyName("linkedDatabases")]
    public IList<V1api20250401RedisEnterpriseDatabaseSpecGeoReplicationLinkedDatabases>? LinkedDatabases { get; set; }
}

/// <summary>Specifies configuration of a redis module</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseSpecModules
{
    /// <summary>Args: Configuration options for the module, e.g. &apos;ERROR_RATE 0.01 INITIAL_SIZE 400&apos;.</summary>
    [JsonPropertyName("args")]
    public string? Args { get; set; }

    /// <summary>Name: The name of the module, e.g. &apos;RedisBloom&apos;, &apos;RediSearch&apos;, &apos;RedisTimeSeries&apos;</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20250401RedisEnterpriseDatabaseSpecOperatorSpecSecretExpressions
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
/// PrimaryKey: indicates where the PrimaryKey secret should be placed. If omitted, the secret will not be retrieved from
/// Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseSpecOperatorSpecSecretsPrimaryKey
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
public partial class V1api20250401RedisEnterpriseDatabaseSpecOperatorSpecSecretsSecondaryKey
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
public partial class V1api20250401RedisEnterpriseDatabaseSpecOperatorSpecSecrets
{
    /// <summary>
    /// PrimaryKey: indicates where the PrimaryKey secret should be placed. If omitted, the secret will not be retrieved from
    /// Azure.
    /// </summary>
    [JsonPropertyName("primaryKey")]
    public V1api20250401RedisEnterpriseDatabaseSpecOperatorSpecSecretsPrimaryKey? PrimaryKey { get; set; }

    /// <summary>
    /// SecondaryKey: indicates where the SecondaryKey secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("secondaryKey")]
    public V1api20250401RedisEnterpriseDatabaseSpecOperatorSpecSecretsSecondaryKey? SecondaryKey { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20250401RedisEnterpriseDatabaseSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20250401RedisEnterpriseDatabaseSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20250401RedisEnterpriseDatabaseSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a cache.azure.com/RedisEnterprise resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// AofFrequency: Sets the frequency at which data is written to disk. Defaults to &apos;1s&apos;, meaning &apos;every second&apos;. Note that
/// the &apos;always&apos; setting is deprecated, because of its performance impact.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250401RedisEnterpriseDatabaseSpecPersistenceAofFrequencyEnum>))]
public enum V1api20250401RedisEnterpriseDatabaseSpecPersistenceAofFrequencyEnum
{
    [EnumMember(Value = "1s"), JsonStringEnumMemberName("1s")]
    _1s,
    [EnumMember(Value = "always"), JsonStringEnumMemberName("always")]
    Always
}

/// <summary>RdbFrequency: Sets the frequency at which a snapshot of the database is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250401RedisEnterpriseDatabaseSpecPersistenceRdbFrequencyEnum>))]
public enum V1api20250401RedisEnterpriseDatabaseSpecPersistenceRdbFrequencyEnum
{
    [EnumMember(Value = "12h"), JsonStringEnumMemberName("12h")]
    _12h,
    [EnumMember(Value = "1h"), JsonStringEnumMemberName("1h")]
    _1h,
    [EnumMember(Value = "6h"), JsonStringEnumMemberName("6h")]
    _6h
}

/// <summary>Persistence: Persistence settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseSpecPersistence
{
    /// <summary>AofEnabled: Sets whether AOF is enabled. Note that at most one of AOF or RDB persistence may be enabled.</summary>
    [JsonPropertyName("aofEnabled")]
    public bool? AofEnabled { get; set; }

    /// <summary>
    /// AofFrequency: Sets the frequency at which data is written to disk. Defaults to &apos;1s&apos;, meaning &apos;every second&apos;. Note that
    /// the &apos;always&apos; setting is deprecated, because of its performance impact.
    /// </summary>
    [JsonPropertyName("aofFrequency")]
    public V1api20250401RedisEnterpriseDatabaseSpecPersistenceAofFrequencyEnum? AofFrequency { get; set; }

    /// <summary>RdbEnabled: Sets whether RDB is enabled. Note that at most one of AOF or RDB persistence may be enabled.</summary>
    [JsonPropertyName("rdbEnabled")]
    public bool? RdbEnabled { get; set; }

    /// <summary>RdbFrequency: Sets the frequency at which a snapshot of the database is created.</summary>
    [JsonPropertyName("rdbFrequency")]
    public V1api20250401RedisEnterpriseDatabaseSpecPersistenceRdbFrequencyEnum? RdbFrequency { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseSpec
{
    /// <summary>
    /// AccessKeysAuthentication: This property can be Enabled/Disabled to allow or deny access with the current access keys.
    /// Can be updated even after database is created.
    /// </summary>
    [JsonPropertyName("accessKeysAuthentication")]
    public V1api20250401RedisEnterpriseDatabaseSpecAccessKeysAuthenticationEnum? AccessKeysAuthentication { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// ClientProtocol: Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Default is
    /// TLS-encrypted.
    /// </summary>
    [JsonPropertyName("clientProtocol")]
    public V1api20250401RedisEnterpriseDatabaseSpecClientProtocolEnum? ClientProtocol { get; set; }

    /// <summary>
    /// ClusteringPolicy: Clustering policy - default is OSSCluster. This property must be chosen at create time, and cannot be
    /// changed without deleting the database.
    /// </summary>
    [JsonPropertyName("clusteringPolicy")]
    public V1api20250401RedisEnterpriseDatabaseSpecClusteringPolicyEnum? ClusteringPolicy { get; set; }

    /// <summary>
    /// DeferUpgrade: Option to defer upgrade when newest version is released - default is NotDeferred. Learn more:
    /// https://aka.ms/redisversionupgrade
    /// </summary>
    [JsonPropertyName("deferUpgrade")]
    public V1api20250401RedisEnterpriseDatabaseSpecDeferUpgradeEnum? DeferUpgrade { get; set; }

    /// <summary>EvictionPolicy: Redis eviction policy - default is VolatileLRU</summary>
    [JsonPropertyName("evictionPolicy")]
    public V1api20250401RedisEnterpriseDatabaseSpecEvictionPolicyEnum? EvictionPolicy { get; set; }

    /// <summary>GeoReplication: Optional set of properties to configure geo replication for this database.</summary>
    [JsonPropertyName("geoReplication")]
    public V1api20250401RedisEnterpriseDatabaseSpecGeoReplication? GeoReplication { get; set; }

    /// <summary>Modules: Optional set of redis modules to enable in this database - modules can only be added at creation time.</summary>
    [JsonPropertyName("modules")]
    public IList<V1api20250401RedisEnterpriseDatabaseSpecModules>? Modules { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20250401RedisEnterpriseDatabaseSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a cache.azure.com/RedisEnterprise resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20250401RedisEnterpriseDatabaseSpecOwner Owner { get; set; }

    /// <summary>Persistence: Persistence settings</summary>
    [JsonPropertyName("persistence")]
    public V1api20250401RedisEnterpriseDatabaseSpecPersistence? Persistence { get; set; }

    /// <summary>Port: TCP port of the database endpoint. Specified at create time. Defaults to an available port.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseStatusConditions
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

/// <summary>Specifies details of a linked database resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseStatusGeoReplicationLinkedDatabases
{
    /// <summary>Id: Resource ID of a database resource to link with this database.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>State: State of the link between the database resources.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>GeoReplication: Optional set of properties to configure geo replication for this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseStatusGeoReplication
{
    /// <summary>GroupNickname: Name for the group of linked database resources</summary>
    [JsonPropertyName("groupNickname")]
    public string? GroupNickname { get; set; }

    /// <summary>LinkedDatabases: List of database resources to link with this database</summary>
    [JsonPropertyName("linkedDatabases")]
    public IList<V1api20250401RedisEnterpriseDatabaseStatusGeoReplicationLinkedDatabases>? LinkedDatabases { get; set; }
}

/// <summary>Specifies configuration of a redis module</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseStatusModules
{
    /// <summary>Args: Configuration options for the module, e.g. &apos;ERROR_RATE 0.01 INITIAL_SIZE 400&apos;.</summary>
    [JsonPropertyName("args")]
    public string? Args { get; set; }

    /// <summary>Name: The name of the module, e.g. &apos;RedisBloom&apos;, &apos;RediSearch&apos;, &apos;RedisTimeSeries&apos;</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Version: The version of the module, e.g. &apos;1.0&apos;.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Persistence: Persistence settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseStatusPersistence
{
    /// <summary>AofEnabled: Sets whether AOF is enabled. Note that at most one of AOF or RDB persistence may be enabled.</summary>
    [JsonPropertyName("aofEnabled")]
    public bool? AofEnabled { get; set; }

    /// <summary>
    /// AofFrequency: Sets the frequency at which data is written to disk. Defaults to &apos;1s&apos;, meaning &apos;every second&apos;. Note that
    /// the &apos;always&apos; setting is deprecated, because of its performance impact.
    /// </summary>
    [JsonPropertyName("aofFrequency")]
    public string? AofFrequency { get; set; }

    /// <summary>RdbEnabled: Sets whether RDB is enabled. Note that at most one of AOF or RDB persistence may be enabled.</summary>
    [JsonPropertyName("rdbEnabled")]
    public bool? RdbEnabled { get; set; }

    /// <summary>RdbFrequency: Sets the frequency at which a snapshot of the database is created.</summary>
    [JsonPropertyName("rdbFrequency")]
    public string? RdbFrequency { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250401RedisEnterpriseDatabaseStatusSystemData
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
public partial class V1api20250401RedisEnterpriseDatabaseStatus
{
    /// <summary>
    /// AccessKeysAuthentication: This property can be Enabled/Disabled to allow or deny access with the current access keys.
    /// Can be updated even after database is created.
    /// </summary>
    [JsonPropertyName("accessKeysAuthentication")]
    public string? AccessKeysAuthentication { get; set; }

    /// <summary>
    /// ClientProtocol: Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Default is
    /// TLS-encrypted.
    /// </summary>
    [JsonPropertyName("clientProtocol")]
    public string? ClientProtocol { get; set; }

    /// <summary>
    /// ClusteringPolicy: Clustering policy - default is OSSCluster. This property must be chosen at create time, and cannot be
    /// changed without deleting the database.
    /// </summary>
    [JsonPropertyName("clusteringPolicy")]
    public string? ClusteringPolicy { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20250401RedisEnterpriseDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// DeferUpgrade: Option to defer upgrade when newest version is released - default is NotDeferred. Learn more:
    /// https://aka.ms/redisversionupgrade
    /// </summary>
    [JsonPropertyName("deferUpgrade")]
    public string? DeferUpgrade { get; set; }

    /// <summary>EvictionPolicy: Redis eviction policy - default is VolatileLRU</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>GeoReplication: Optional set of properties to configure geo replication for this database.</summary>
    [JsonPropertyName("geoReplication")]
    public V1api20250401RedisEnterpriseDatabaseStatusGeoReplication? GeoReplication { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Modules: Optional set of redis modules to enable in this database - modules can only be added at creation time.</summary>
    [JsonPropertyName("modules")]
    public IList<V1api20250401RedisEnterpriseDatabaseStatusModules>? Modules { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Persistence: Persistence settings</summary>
    [JsonPropertyName("persistence")]
    public V1api20250401RedisEnterpriseDatabaseStatusPersistence? Persistence { get; set; }

    /// <summary>Port: TCP port of the database endpoint. Specified at create time. Defaults to an available port.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>ProvisioningState: Current provisioning status of the database</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>RedisVersion: Version of Redis the database is running on, e.g. &apos;6.0&apos;</summary>
    [JsonPropertyName("redisVersion")]
    public string? RedisVersion { get; set; }

    /// <summary>ResourceState: Current resource status of the database</summary>
    [JsonPropertyName("resourceState")]
    public string? ResourceState { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20250401RedisEnterpriseDatabaseStatusSystemData? SystemData { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /redisenterprise/resource-manager/Microsoft.Cache/RedisEnterprise/stable/2025-04-01/redisenterprise.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}/databases/{databaseName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250401RedisEnterpriseDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20250401RedisEnterpriseDatabaseSpec?>, IStatus<V1api20250401RedisEnterpriseDatabaseStatus?>
{
    public const string KubeApiVersion = "v1api20250401";
    public const string KubeKind = "RedisEnterpriseDatabase";
    public const string KubeGroup = "cache.azure.com";
    public const string KubePluralName = "redisenterprisedatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cache.azure.com/v1api20250401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RedisEnterpriseDatabase";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20250401RedisEnterpriseDatabaseSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20250401RedisEnterpriseDatabaseStatus? Status { get; set; }
}