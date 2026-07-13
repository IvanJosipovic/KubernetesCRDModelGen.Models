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
/// - Generated from: /redisenterprise/resource-manager/Microsoft.Cache/RedisEnterprise/stable/2021-03-01/redisenterprise.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}/databases/{databaseName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210301RedisEnterpriseDatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1api20210301RedisEnterpriseDatabase>
{
    public const string KubeApiVersion = "v1api20210301";
    public const string KubeKind = "RedisEnterpriseDatabaseList";
    public const string KubeGroup = "cache.azure.com";
    public const string KubePluralName = "redisenterprisedatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cache.azure.com/v1api20210301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RedisEnterpriseDatabaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210301RedisEnterpriseDatabase objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210301RedisEnterpriseDatabase> Items { get; set; }
}

/// <summary>
/// ClientProtocol: Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Default is
/// TLS-encrypted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210301RedisEnterpriseDatabaseSpecClientProtocolEnum>))]
public enum V1api20210301RedisEnterpriseDatabaseSpecClientProtocolEnum
{
    [EnumMember(Value = "Encrypted"), JsonStringEnumMemberName("Encrypted")]
    Encrypted,
    [EnumMember(Value = "Plaintext"), JsonStringEnumMemberName("Plaintext")]
    Plaintext
}

/// <summary>ClusteringPolicy: Clustering policy - default is OSSCluster. Specified at create time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210301RedisEnterpriseDatabaseSpecClusteringPolicyEnum>))]
public enum V1api20210301RedisEnterpriseDatabaseSpecClusteringPolicyEnum
{
    [EnumMember(Value = "EnterpriseCluster"), JsonStringEnumMemberName("EnterpriseCluster")]
    EnterpriseCluster,
    [EnumMember(Value = "OSSCluster"), JsonStringEnumMemberName("OSSCluster")]
    OSSCluster
}

/// <summary>EvictionPolicy: Redis eviction policy - default is VolatileLRU</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210301RedisEnterpriseDatabaseSpecEvictionPolicyEnum>))]
public enum V1api20210301RedisEnterpriseDatabaseSpecEvictionPolicyEnum
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

/// <summary>Specifies configuration of a redis module</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210301RedisEnterpriseDatabaseSpecModules
{
    /// <summary>Args: Configuration options for the module, e.g. &apos;ERROR_RATE 0.00 INITIAL_SIZE 400&apos;.</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210301RedisEnterpriseDatabaseSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210301RedisEnterpriseDatabaseSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210301RedisEnterpriseDatabaseSpecOperatorSpecSecretsPrimaryKey
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210301RedisEnterpriseDatabaseSpecOperatorSpecSecretsSecondaryKey
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
public partial class V1api20210301RedisEnterpriseDatabaseSpecOperatorSpecSecrets
{
    /// <summary>
    /// PrimaryKey: indicates where the PrimaryKey secret should be placed. If omitted, the secret will not be retrieved from
    /// Azure.
    /// </summary>
    [JsonPropertyName("primaryKey")]
    public V1api20210301RedisEnterpriseDatabaseSpecOperatorSpecSecretsPrimaryKey? PrimaryKey { get; set; }

    /// <summary>
    /// SecondaryKey: indicates where the SecondaryKey secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("secondaryKey")]
    public V1api20210301RedisEnterpriseDatabaseSpecOperatorSpecSecretsSecondaryKey? SecondaryKey { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210301RedisEnterpriseDatabaseSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210301RedisEnterpriseDatabaseSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210301RedisEnterpriseDatabaseSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20210301RedisEnterpriseDatabaseSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a cache.azure.com/RedisEnterprise resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210301RedisEnterpriseDatabaseSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>AofFrequency: Sets the frequency at which data is written to disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210301RedisEnterpriseDatabaseSpecPersistenceAofFrequencyEnum>))]
public enum V1api20210301RedisEnterpriseDatabaseSpecPersistenceAofFrequencyEnum
{
    [EnumMember(Value = "1s"), JsonStringEnumMemberName("1s")]
    _1s,
    [EnumMember(Value = "always"), JsonStringEnumMemberName("always")]
    Always
}

/// <summary>RdbFrequency: Sets the frequency at which a snapshot of the database is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210301RedisEnterpriseDatabaseSpecPersistenceRdbFrequencyEnum>))]
public enum V1api20210301RedisEnterpriseDatabaseSpecPersistenceRdbFrequencyEnum
{
    [EnumMember(Value = "12h"), JsonStringEnumMemberName("12h")]
    _12h,
    [EnumMember(Value = "1h"), JsonStringEnumMemberName("1h")]
    _1h,
    [EnumMember(Value = "6h"), JsonStringEnumMemberName("6h")]
    _6h
}

/// <summary>Persistence: Persistence settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210301RedisEnterpriseDatabaseSpecPersistence
{
    /// <summary>AofEnabled: Sets whether AOF is enabled.</summary>
    [JsonPropertyName("aofEnabled")]
    public bool? AofEnabled { get; set; }

    /// <summary>AofFrequency: Sets the frequency at which data is written to disk.</summary>
    [JsonPropertyName("aofFrequency")]
    public V1api20210301RedisEnterpriseDatabaseSpecPersistenceAofFrequencyEnum? AofFrequency { get; set; }

    /// <summary>RdbEnabled: Sets whether RDB is enabled.</summary>
    [JsonPropertyName("rdbEnabled")]
    public bool? RdbEnabled { get; set; }

    /// <summary>RdbFrequency: Sets the frequency at which a snapshot of the database is created.</summary>
    [JsonPropertyName("rdbFrequency")]
    public V1api20210301RedisEnterpriseDatabaseSpecPersistenceRdbFrequencyEnum? RdbFrequency { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210301RedisEnterpriseDatabaseSpec
{
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
    public V1api20210301RedisEnterpriseDatabaseSpecClientProtocolEnum? ClientProtocol { get; set; }

    /// <summary>ClusteringPolicy: Clustering policy - default is OSSCluster. Specified at create time.</summary>
    [JsonPropertyName("clusteringPolicy")]
    public V1api20210301RedisEnterpriseDatabaseSpecClusteringPolicyEnum? ClusteringPolicy { get; set; }

    /// <summary>EvictionPolicy: Redis eviction policy - default is VolatileLRU</summary>
    [JsonPropertyName("evictionPolicy")]
    public V1api20210301RedisEnterpriseDatabaseSpecEvictionPolicyEnum? EvictionPolicy { get; set; }

    /// <summary>Modules: Optional set of redis modules to enable in this database - modules can only be added at creation time.</summary>
    [JsonPropertyName("modules")]
    public IList<V1api20210301RedisEnterpriseDatabaseSpecModules>? Modules { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210301RedisEnterpriseDatabaseSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a cache.azure.com/RedisEnterprise resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210301RedisEnterpriseDatabaseSpecOwner Owner { get; set; }

    /// <summary>Persistence: Persistence settings</summary>
    [JsonPropertyName("persistence")]
    public V1api20210301RedisEnterpriseDatabaseSpecPersistence? Persistence { get; set; }

    /// <summary>Port: TCP port of the database endpoint. Specified at create time. Defaults to an available port.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210301RedisEnterpriseDatabaseStatusConditions
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

/// <summary>Specifies configuration of a redis module</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210301RedisEnterpriseDatabaseStatusModules
{
    /// <summary>Args: Configuration options for the module, e.g. &apos;ERROR_RATE 0.00 INITIAL_SIZE 400&apos;.</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210301RedisEnterpriseDatabaseStatusPersistence
{
    /// <summary>AofEnabled: Sets whether AOF is enabled.</summary>
    [JsonPropertyName("aofEnabled")]
    public bool? AofEnabled { get; set; }

    /// <summary>AofFrequency: Sets the frequency at which data is written to disk.</summary>
    [JsonPropertyName("aofFrequency")]
    public string? AofFrequency { get; set; }

    /// <summary>RdbEnabled: Sets whether RDB is enabled.</summary>
    [JsonPropertyName("rdbEnabled")]
    public bool? RdbEnabled { get; set; }

    /// <summary>RdbFrequency: Sets the frequency at which a snapshot of the database is created.</summary>
    [JsonPropertyName("rdbFrequency")]
    public string? RdbFrequency { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210301RedisEnterpriseDatabaseStatus
{
    /// <summary>
    /// ClientProtocol: Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Default is
    /// TLS-encrypted.
    /// </summary>
    [JsonPropertyName("clientProtocol")]
    public string? ClientProtocol { get; set; }

    /// <summary>ClusteringPolicy: Clustering policy - default is OSSCluster. Specified at create time.</summary>
    [JsonPropertyName("clusteringPolicy")]
    public string? ClusteringPolicy { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210301RedisEnterpriseDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>EvictionPolicy: Redis eviction policy - default is VolatileLRU</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Modules: Optional set of redis modules to enable in this database - modules can only be added at creation time.</summary>
    [JsonPropertyName("modules")]
    public IList<V1api20210301RedisEnterpriseDatabaseStatusModules>? Modules { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Persistence: Persistence settings</summary>
    [JsonPropertyName("persistence")]
    public V1api20210301RedisEnterpriseDatabaseStatusPersistence? Persistence { get; set; }

    /// <summary>Port: TCP port of the database endpoint. Specified at create time. Defaults to an available port.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>ProvisioningState: Current provisioning status of the database</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceState: Current resource status of the database</summary>
    [JsonPropertyName("resourceState")]
    public string? ResourceState { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /redisenterprise/resource-manager/Microsoft.Cache/RedisEnterprise/stable/2021-03-01/redisenterprise.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}/databases/{databaseName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210301RedisEnterpriseDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210301RedisEnterpriseDatabaseSpec?>, IStatus<V1api20210301RedisEnterpriseDatabaseStatus?>
{
    public const string KubeApiVersion = "v1api20210301";
    public const string KubeKind = "RedisEnterpriseDatabase";
    public const string KubeGroup = "cache.azure.com";
    public const string KubePluralName = "redisenterprisedatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cache.azure.com/v1api20210301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RedisEnterpriseDatabase";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210301RedisEnterpriseDatabaseSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20210301RedisEnterpriseDatabaseStatus? Status { get; set; }
}