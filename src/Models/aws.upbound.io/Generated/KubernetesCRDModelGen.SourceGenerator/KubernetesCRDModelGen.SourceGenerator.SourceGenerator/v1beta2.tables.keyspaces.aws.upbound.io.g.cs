#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.keyspaces.aws.upbound.io;
/// <summary>Table is the Schema for the Tables API. Provides a Keyspaces Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2TableList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Table>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "TableList";
    public const string KubeGroup = "keyspaces.aws.upbound.io";
    public const string KubePluralName = "tables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keyspaces.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TableList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Table objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Table> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TableSpecDeletionPolicyEnum>))]
public enum V1beta2TableSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Specifies the read/write throughput capacity mode for the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderCapacitySpecification
{
    /// <summary>The throughput capacity specified for read operations defined in read capacity units (RCUs).</summary>
    [JsonPropertyName("readCapacityUnits")]
    public double? ReadCapacityUnits { get; set; }

    /// <summary>The read/write throughput capacity mode for a table. Valid values: PAY_PER_REQUEST, PROVISIONED. The default value is PAY_PER_REQUEST.</summary>
    [JsonPropertyName("throughputMode")]
    public string? ThroughputMode { get; set; }

    /// <summary>The throughput capacity specified for write operations defined in write capacity units (WCUs).</summary>
    [JsonPropertyName("writeCapacityUnits")]
    public double? WriteCapacityUnits { get; set; }
}

/// <summary>Enables client-side timestamps for the table. By default, the setting is disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderClientSideTimestamps
{
    /// <summary>Shows how to enable client-side timestamps settings for the specified table. Valid values: ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>A description of the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderComment
{
    /// <summary>A description of the table.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>Specifies how the encryption key for encryption at rest is managed for the table. More information can be found in the Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderEncryptionSpecification
{
    /// <summary>The Amazon Resource Name (ARN) of the customer managed KMS key.</summary>
    [JsonPropertyName("kmsKeyIdentifier")]
    public string? KmsKeyIdentifier { get; set; }

    /// <summary>The encryption option specified for the table. Valid values: AWS_OWNED_KMS_KEY, CUSTOMER_MANAGED_KMS_KEY. The default value is AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TableSpecForProviderKeyspaceNameRefPolicyResolutionEnum>))]
public enum V1beta2TableSpecForProviderKeyspaceNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TableSpecForProviderKeyspaceNameRefPolicyResolveEnum>))]
public enum V1beta2TableSpecForProviderKeyspaceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderKeyspaceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TableSpecForProviderKeyspaceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TableSpecForProviderKeyspaceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Keyspace in keyspaces to populate keyspaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderKeyspaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TableSpecForProviderKeyspaceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TableSpecForProviderKeyspaceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2TableSpecForProviderKeyspaceNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TableSpecForProviderKeyspaceNameSelectorPolicyResolveEnum>))]
public enum V1beta2TableSpecForProviderKeyspaceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderKeyspaceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TableSpecForProviderKeyspaceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TableSpecForProviderKeyspaceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Keyspace in keyspaces to populate keyspaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderKeyspaceNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TableSpecForProviderKeyspaceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies if point-in-time recovery is enabled or disabled for the table. More information can be found in the Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderPointInTimeRecovery
{
    /// <summary>Shows how to enable client-side timestamps settings for the specified table. Valid values: ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderSchemaDefinitionClusteringKey
{
    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order modifier. Valid values: ASC, DESC.</summary>
    [JsonPropertyName("orderBy")]
    public string? OrderBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderSchemaDefinitionColumn
{
    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The encryption option specified for the table. Valid values: AWS_OWNED_KMS_KEY, CUSTOMER_MANAGED_KMS_KEY. The default value is AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderSchemaDefinitionPartitionKey
{
    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderSchemaDefinitionStaticColumn
{
    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Describes the schema of the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderSchemaDefinition
{
    /// <summary>The columns that are part of the clustering key of the table.</summary>
    [JsonPropertyName("clusteringKey")]
    public IList<V1beta2TableSpecForProviderSchemaDefinitionClusteringKey>? ClusteringKey { get; set; }

    /// <summary>The regular columns of the table.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta2TableSpecForProviderSchemaDefinitionColumn>? Column { get; set; }

    /// <summary>The columns that are part of the partition key of the table .</summary>
    [JsonPropertyName("partitionKey")]
    public IList<V1beta2TableSpecForProviderSchemaDefinitionPartitionKey>? PartitionKey { get; set; }

    /// <summary>The columns that have been defined as STATIC. Static columns store values that are shared by all rows in the same partition.</summary>
    [JsonPropertyName("staticColumn")]
    public IList<V1beta2TableSpecForProviderSchemaDefinitionStaticColumn>? StaticColumn { get; set; }
}

/// <summary>Enables Time to Live custom settings for the table. More information can be found in the Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProviderTtl
{
    /// <summary>Shows how to enable client-side timestamps settings for the specified table. Valid values: ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecForProvider
{
    /// <summary>Specifies the read/write throughput capacity mode for the table.</summary>
    [JsonPropertyName("capacitySpecification")]
    public V1beta2TableSpecForProviderCapacitySpecification? CapacitySpecification { get; set; }

    /// <summary>Enables client-side timestamps for the table. By default, the setting is disabled.</summary>
    [JsonPropertyName("clientSideTimestamps")]
    public V1beta2TableSpecForProviderClientSideTimestamps? ClientSideTimestamps { get; set; }

    /// <summary>A description of the table.</summary>
    [JsonPropertyName("comment")]
    public V1beta2TableSpecForProviderComment? Comment { get; set; }

    /// <summary>The default Time to Live setting in seconds for the table. More information can be found in the Developer Guide.</summary>
    [JsonPropertyName("defaultTimeToLive")]
    public double? DefaultTimeToLive { get; set; }

    /// <summary>Specifies how the encryption key for encryption at rest is managed for the table. More information can be found in the Developer Guide.</summary>
    [JsonPropertyName("encryptionSpecification")]
    public V1beta2TableSpecForProviderEncryptionSpecification? EncryptionSpecification { get; set; }

    /// <summary>The name of the keyspace that the table is going to be created in.</summary>
    [JsonPropertyName("keyspaceName")]
    public string? KeyspaceName { get; set; }

    /// <summary>Reference to a Keyspace in keyspaces to populate keyspaceName.</summary>
    [JsonPropertyName("keyspaceNameRef")]
    public V1beta2TableSpecForProviderKeyspaceNameRef? KeyspaceNameRef { get; set; }

    /// <summary>Selector for a Keyspace in keyspaces to populate keyspaceName.</summary>
    [JsonPropertyName("keyspaceNameSelector")]
    public V1beta2TableSpecForProviderKeyspaceNameSelector? KeyspaceNameSelector { get; set; }

    /// <summary>Specifies if point-in-time recovery is enabled or disabled for the table. More information can be found in the Developer Guide.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public V1beta2TableSpecForProviderPointInTimeRecovery? PointInTimeRecovery { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Describes the schema of the table.</summary>
    [JsonPropertyName("schemaDefinition")]
    public V1beta2TableSpecForProviderSchemaDefinition? SchemaDefinition { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Enables Time to Live custom settings for the table. More information can be found in the Developer Guide.</summary>
    [JsonPropertyName("ttl")]
    public V1beta2TableSpecForProviderTtl? Ttl { get; set; }
}

/// <summary>Specifies the read/write throughput capacity mode for the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderCapacitySpecification
{
    /// <summary>The throughput capacity specified for read operations defined in read capacity units (RCUs).</summary>
    [JsonPropertyName("readCapacityUnits")]
    public double? ReadCapacityUnits { get; set; }

    /// <summary>The read/write throughput capacity mode for a table. Valid values: PAY_PER_REQUEST, PROVISIONED. The default value is PAY_PER_REQUEST.</summary>
    [JsonPropertyName("throughputMode")]
    public string? ThroughputMode { get; set; }

    /// <summary>The throughput capacity specified for write operations defined in write capacity units (WCUs).</summary>
    [JsonPropertyName("writeCapacityUnits")]
    public double? WriteCapacityUnits { get; set; }
}

/// <summary>Enables client-side timestamps for the table. By default, the setting is disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderClientSideTimestamps
{
    /// <summary>Shows how to enable client-side timestamps settings for the specified table. Valid values: ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>A description of the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderComment
{
    /// <summary>A description of the table.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>Specifies how the encryption key for encryption at rest is managed for the table. More information can be found in the Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderEncryptionSpecification
{
    /// <summary>The Amazon Resource Name (ARN) of the customer managed KMS key.</summary>
    [JsonPropertyName("kmsKeyIdentifier")]
    public string? KmsKeyIdentifier { get; set; }

    /// <summary>The encryption option specified for the table. Valid values: AWS_OWNED_KMS_KEY, CUSTOMER_MANAGED_KMS_KEY. The default value is AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TableSpecInitProviderKeyspaceNameRefPolicyResolutionEnum>))]
public enum V1beta2TableSpecInitProviderKeyspaceNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TableSpecInitProviderKeyspaceNameRefPolicyResolveEnum>))]
public enum V1beta2TableSpecInitProviderKeyspaceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderKeyspaceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TableSpecInitProviderKeyspaceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TableSpecInitProviderKeyspaceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Keyspace in keyspaces to populate keyspaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderKeyspaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TableSpecInitProviderKeyspaceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TableSpecInitProviderKeyspaceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2TableSpecInitProviderKeyspaceNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TableSpecInitProviderKeyspaceNameSelectorPolicyResolveEnum>))]
public enum V1beta2TableSpecInitProviderKeyspaceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderKeyspaceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TableSpecInitProviderKeyspaceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TableSpecInitProviderKeyspaceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Keyspace in keyspaces to populate keyspaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderKeyspaceNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TableSpecInitProviderKeyspaceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies if point-in-time recovery is enabled or disabled for the table. More information can be found in the Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderPointInTimeRecovery
{
    /// <summary>Shows how to enable client-side timestamps settings for the specified table. Valid values: ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderSchemaDefinitionClusteringKey
{
    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order modifier. Valid values: ASC, DESC.</summary>
    [JsonPropertyName("orderBy")]
    public string? OrderBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderSchemaDefinitionColumn
{
    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The encryption option specified for the table. Valid values: AWS_OWNED_KMS_KEY, CUSTOMER_MANAGED_KMS_KEY. The default value is AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderSchemaDefinitionPartitionKey
{
    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderSchemaDefinitionStaticColumn
{
    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Describes the schema of the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderSchemaDefinition
{
    /// <summary>The columns that are part of the clustering key of the table.</summary>
    [JsonPropertyName("clusteringKey")]
    public IList<V1beta2TableSpecInitProviderSchemaDefinitionClusteringKey>? ClusteringKey { get; set; }

    /// <summary>The regular columns of the table.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta2TableSpecInitProviderSchemaDefinitionColumn>? Column { get; set; }

    /// <summary>The columns that are part of the partition key of the table .</summary>
    [JsonPropertyName("partitionKey")]
    public IList<V1beta2TableSpecInitProviderSchemaDefinitionPartitionKey>? PartitionKey { get; set; }

    /// <summary>The columns that have been defined as STATIC. Static columns store values that are shared by all rows in the same partition.</summary>
    [JsonPropertyName("staticColumn")]
    public IList<V1beta2TableSpecInitProviderSchemaDefinitionStaticColumn>? StaticColumn { get; set; }
}

/// <summary>Enables Time to Live custom settings for the table. More information can be found in the Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProviderTtl
{
    /// <summary>Shows how to enable client-side timestamps settings for the specified table. Valid values: ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecInitProvider
{
    /// <summary>Specifies the read/write throughput capacity mode for the table.</summary>
    [JsonPropertyName("capacitySpecification")]
    public V1beta2TableSpecInitProviderCapacitySpecification? CapacitySpecification { get; set; }

    /// <summary>Enables client-side timestamps for the table. By default, the setting is disabled.</summary>
    [JsonPropertyName("clientSideTimestamps")]
    public V1beta2TableSpecInitProviderClientSideTimestamps? ClientSideTimestamps { get; set; }

    /// <summary>A description of the table.</summary>
    [JsonPropertyName("comment")]
    public V1beta2TableSpecInitProviderComment? Comment { get; set; }

    /// <summary>The default Time to Live setting in seconds for the table. More information can be found in the Developer Guide.</summary>
    [JsonPropertyName("defaultTimeToLive")]
    public double? DefaultTimeToLive { get; set; }

    /// <summary>Specifies how the encryption key for encryption at rest is managed for the table. More information can be found in the Developer Guide.</summary>
    [JsonPropertyName("encryptionSpecification")]
    public V1beta2TableSpecInitProviderEncryptionSpecification? EncryptionSpecification { get; set; }

    /// <summary>The name of the keyspace that the table is going to be created in.</summary>
    [JsonPropertyName("keyspaceName")]
    public string? KeyspaceName { get; set; }

    /// <summary>Reference to a Keyspace in keyspaces to populate keyspaceName.</summary>
    [JsonPropertyName("keyspaceNameRef")]
    public V1beta2TableSpecInitProviderKeyspaceNameRef? KeyspaceNameRef { get; set; }

    /// <summary>Selector for a Keyspace in keyspaces to populate keyspaceName.</summary>
    [JsonPropertyName("keyspaceNameSelector")]
    public V1beta2TableSpecInitProviderKeyspaceNameSelector? KeyspaceNameSelector { get; set; }

    /// <summary>Specifies if point-in-time recovery is enabled or disabled for the table. More information can be found in the Developer Guide.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public V1beta2TableSpecInitProviderPointInTimeRecovery? PointInTimeRecovery { get; set; }

    /// <summary>Describes the schema of the table.</summary>
    [JsonPropertyName("schemaDefinition")]
    public V1beta2TableSpecInitProviderSchemaDefinition? SchemaDefinition { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Enables Time to Live custom settings for the table. More information can be found in the Developer Guide.</summary>
    [JsonPropertyName("ttl")]
    public V1beta2TableSpecInitProviderTtl? Ttl { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TableSpecManagementPoliciesEnum>))]
public enum V1beta2TableSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TableSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2TableSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TableSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2TableSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TableSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TableSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TableSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>TableSpec defines the desired state of Table</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta2TableSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2TableSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta2TableSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2TableSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2TableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2TableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Specifies the read/write throughput capacity mode for the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusAtProviderCapacitySpecification
{
    /// <summary>The throughput capacity specified for read operations defined in read capacity units (RCUs).</summary>
    [JsonPropertyName("readCapacityUnits")]
    public double? ReadCapacityUnits { get; set; }

    /// <summary>The read/write throughput capacity mode for a table. Valid values: PAY_PER_REQUEST, PROVISIONED. The default value is PAY_PER_REQUEST.</summary>
    [JsonPropertyName("throughputMode")]
    public string? ThroughputMode { get; set; }

    /// <summary>The throughput capacity specified for write operations defined in write capacity units (WCUs).</summary>
    [JsonPropertyName("writeCapacityUnits")]
    public double? WriteCapacityUnits { get; set; }
}

/// <summary>Enables client-side timestamps for the table. By default, the setting is disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusAtProviderClientSideTimestamps
{
    /// <summary>Shows how to enable client-side timestamps settings for the specified table. Valid values: ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>A description of the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusAtProviderComment
{
    /// <summary>A description of the table.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>Specifies how the encryption key for encryption at rest is managed for the table. More information can be found in the Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusAtProviderEncryptionSpecification
{
    /// <summary>The Amazon Resource Name (ARN) of the customer managed KMS key.</summary>
    [JsonPropertyName("kmsKeyIdentifier")]
    public string? KmsKeyIdentifier { get; set; }

    /// <summary>The encryption option specified for the table. Valid values: AWS_OWNED_KMS_KEY, CUSTOMER_MANAGED_KMS_KEY. The default value is AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Specifies if point-in-time recovery is enabled or disabled for the table. More information can be found in the Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusAtProviderPointInTimeRecovery
{
    /// <summary>Shows how to enable client-side timestamps settings for the specified table. Valid values: ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusAtProviderSchemaDefinitionClusteringKey
{
    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order modifier. Valid values: ASC, DESC.</summary>
    [JsonPropertyName("orderBy")]
    public string? OrderBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusAtProviderSchemaDefinitionColumn
{
    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The encryption option specified for the table. Valid values: AWS_OWNED_KMS_KEY, CUSTOMER_MANAGED_KMS_KEY. The default value is AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusAtProviderSchemaDefinitionPartitionKey
{
    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusAtProviderSchemaDefinitionStaticColumn
{
    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Describes the schema of the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusAtProviderSchemaDefinition
{
    /// <summary>The columns that are part of the clustering key of the table.</summary>
    [JsonPropertyName("clusteringKey")]
    public IList<V1beta2TableStatusAtProviderSchemaDefinitionClusteringKey>? ClusteringKey { get; set; }

    /// <summary>The regular columns of the table.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta2TableStatusAtProviderSchemaDefinitionColumn>? Column { get; set; }

    /// <summary>The columns that are part of the partition key of the table .</summary>
    [JsonPropertyName("partitionKey")]
    public IList<V1beta2TableStatusAtProviderSchemaDefinitionPartitionKey>? PartitionKey { get; set; }

    /// <summary>The columns that have been defined as STATIC. Static columns store values that are shared by all rows in the same partition.</summary>
    [JsonPropertyName("staticColumn")]
    public IList<V1beta2TableStatusAtProviderSchemaDefinitionStaticColumn>? StaticColumn { get; set; }
}

/// <summary>Enables Time to Live custom settings for the table. More information can be found in the Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusAtProviderTtl
{
    /// <summary>Shows how to enable client-side timestamps settings for the specified table. Valid values: ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusAtProvider
{
    /// <summary>The ARN of the table.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specifies the read/write throughput capacity mode for the table.</summary>
    [JsonPropertyName("capacitySpecification")]
    public V1beta2TableStatusAtProviderCapacitySpecification? CapacitySpecification { get; set; }

    /// <summary>Enables client-side timestamps for the table. By default, the setting is disabled.</summary>
    [JsonPropertyName("clientSideTimestamps")]
    public V1beta2TableStatusAtProviderClientSideTimestamps? ClientSideTimestamps { get; set; }

    /// <summary>A description of the table.</summary>
    [JsonPropertyName("comment")]
    public V1beta2TableStatusAtProviderComment? Comment { get; set; }

    /// <summary>The default Time to Live setting in seconds for the table. More information can be found in the Developer Guide.</summary>
    [JsonPropertyName("defaultTimeToLive")]
    public double? DefaultTimeToLive { get; set; }

    /// <summary>Specifies how the encryption key for encryption at rest is managed for the table. More information can be found in the Developer Guide.</summary>
    [JsonPropertyName("encryptionSpecification")]
    public V1beta2TableStatusAtProviderEncryptionSpecification? EncryptionSpecification { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the keyspace that the table is going to be created in.</summary>
    [JsonPropertyName("keyspaceName")]
    public string? KeyspaceName { get; set; }

    /// <summary>Specifies if point-in-time recovery is enabled or disabled for the table. More information can be found in the Developer Guide.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public V1beta2TableStatusAtProviderPointInTimeRecovery? PointInTimeRecovery { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Describes the schema of the table.</summary>
    [JsonPropertyName("schemaDefinition")]
    public V1beta2TableStatusAtProviderSchemaDefinition? SchemaDefinition { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Enables Time to Live custom settings for the table. More information can be found in the Developer Guide.</summary>
    [JsonPropertyName("ttl")]
    public V1beta2TableStatusAtProviderTtl? Ttl { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>TableStatus defines the observed state of Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TableStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2TableStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2TableStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Table is the Schema for the Tables API. Provides a Keyspaces Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Table : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2TableSpec>, IStatus<V1beta2TableStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Table";
    public const string KubeGroup = "keyspaces.aws.upbound.io";
    public const string KubePluralName = "tables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keyspaces.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Table";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TableSpec defines the desired state of Table</summary>
    [JsonPropertyName("spec")]
    public required V1beta2TableSpec Spec { get; set; }

    /// <summary>TableStatus defines the observed state of Table.</summary>
    [JsonPropertyName("status")]
    public V1beta2TableStatus? Status { get; set; }
}