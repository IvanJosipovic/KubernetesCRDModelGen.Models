#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cache.azure.upbound.io;
/// <summary>
/// RedisCache is the Schema for the RedisCaches API. Manages a Redis Cache
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RedisCacheList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RedisCache>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RedisCacheList";
    public const string KubeGroup = "cache.azure.upbound.io";
    public const string KubePluralName = "rediscaches";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cache.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RedisCacheList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1RedisCache objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1RedisCache> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Redis Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Redis Cluster. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderPatchSchedule
{
    /// <summary>the Weekday name - possible values include Monday, Tuesday, Wednesday etc.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The ISO 8601 timespan which specifies the amount of time the Redis Cache can be updated. Defaults to PT5H.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>the Start Hour for maintenance in UTC - possible values range from 0 - 23.</summary>
    [JsonPropertyName("startHourUtc")]
    public double? StartHourUtc { get; set; }
}

/// <summary>First Storage Account connection string for AOF persistence.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderRedisConfigurationAofStorageConnectionString0SecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Second Storage Account connection string for AOF persistence.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderRedisConfigurationAofStorageConnectionString1SecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>The Connection String to the Storage Account. Only supported for Premium SKUs. In the format: DefaultEndpointsProtocol=https;BlobEndpoint=${azurerm_storage_account.example.primary_blob_endpoint};AccountName=${azurerm_storage_account.example.name};AccountKey=${azurerm_storage_account.example.primary_access_key}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderRedisConfigurationRdbStorageConnectionStringSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderRedisConfiguration
{
    /// <summary>Enable Microsoft Entra (AAD) authentication. Defaults to false.</summary>
    [JsonPropertyName("activeDirectoryAuthenticationEnabled")]
    public bool? ActiveDirectoryAuthenticationEnabled { get; set; }

    /// <summary>Enable or disable AOF persistence for this Redis Cache. Defaults to false.</summary>
    [JsonPropertyName("aofBackupEnabled")]
    public bool? AofBackupEnabled { get; set; }

    /// <summary>First Storage Account connection string for AOF persistence.</summary>
    [JsonPropertyName("aofStorageConnectionString0SecretRef")]
    public V1beta1RedisCacheSpecForProviderRedisConfigurationAofStorageConnectionString0SecretRef? AofStorageConnectionString0SecretRef { get; set; }

    /// <summary>Second Storage Account connection string for AOF persistence.</summary>
    [JsonPropertyName("aofStorageConnectionString1SecretRef")]
    public V1beta1RedisCacheSpecForProviderRedisConfigurationAofStorageConnectionString1SecretRef? AofStorageConnectionString1SecretRef { get; set; }

    /// <summary>If set to false, the Redis instance will be accessible without authentication. Defaults to true.</summary>
    [JsonPropertyName("authenticationEnabled")]
    public bool? AuthenticationEnabled { get; set; }

    /// <summary>Preferred auth method to communicate to storage account used for data persistence. Possible values are SAS and ManagedIdentity.</summary>
    [JsonPropertyName("dataPersistenceAuthenticationMethod")]
    public string? DataPersistenceAuthenticationMethod { get; set; }

    /// <summary>Value in megabytes reserved to accommodate for memory fragmentation. Defaults are shown below.</summary>
    [JsonPropertyName("maxfragmentationmemoryReserved")]
    public double? MaxfragmentationmemoryReserved { get; set; }

    /// <summary>The max-memory delta for this Redis instance. Defaults are shown below.</summary>
    [JsonPropertyName("maxmemoryDelta")]
    public double? MaxmemoryDelta { get; set; }

    /// <summary>How Redis will select what to remove when maxmemory is reached. Defaults to volatile-lru.</summary>
    [JsonPropertyName("maxmemoryPolicy")]
    public string? MaxmemoryPolicy { get; set; }

    /// <summary>Value in megabytes reserved for non-cache usage e.g. failover. Defaults are shown below.</summary>
    [JsonPropertyName("maxmemoryReserved")]
    public double? MaxmemoryReserved { get; set; }

    /// <summary>Keyspace notifications allows clients to subscribe to Pub/Sub channels in order to receive events affecting the Redis data set in some way. Reference</summary>
    [JsonPropertyName("notifyKeyspaceEvents")]
    public string? NotifyKeyspaceEvents { get; set; }

    /// <summary>Is Backup Enabled? Only supported on Premium SKUs. Defaults to false.</summary>
    [JsonPropertyName("rdbBackupEnabled")]
    public bool? RdbBackupEnabled { get; set; }

    /// <summary>The Backup Frequency in Minutes. Only supported on Premium SKUs. Possible values are: 15, 30, 60, 360, 720 and 1440.</summary>
    [JsonPropertyName("rdbBackupFrequency")]
    public double? RdbBackupFrequency { get; set; }

    /// <summary>The maximum number of snapshots to create as a backup. Only supported for Premium SKUs.</summary>
    [JsonPropertyName("rdbBackupMaxSnapshotCount")]
    public double? RdbBackupMaxSnapshotCount { get; set; }

    /// <summary>The Connection String to the Storage Account. Only supported for Premium SKUs. In the format: DefaultEndpointsProtocol=https;BlobEndpoint=${azurerm_storage_account.example.primary_blob_endpoint};AccountName=${azurerm_storage_account.example.name};AccountKey=${azurerm_storage_account.example.primary_access_key}.</summary>
    [JsonPropertyName("rdbStorageConnectionStringSecretRef")]
    public V1beta1RedisCacheSpecForProviderRedisConfigurationRdbStorageConnectionStringSecretRef? RdbStorageConnectionStringSecretRef { get; set; }

    /// <summary>The ID of the Subscription containing the Storage Account.</summary>
    [JsonPropertyName("storageAccountSubscriptionId")]
    public string? StorageAccountSubscriptionId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RedisCacheSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RedisCacheSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisCacheSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RedisCacheSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RedisCacheSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderResourceGroupNameSelector
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
    public V1beta1RedisCacheSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecForProviderSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecForProviderSubnetIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecForProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RedisCacheSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RedisCacheSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisCacheSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecForProviderSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RedisCacheSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RedisCacheSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProviderSubnetIdSelector
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
    public V1beta1RedisCacheSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecForProvider
{
    /// <summary>Whether access key authentication is enabled? Defaults to true. active_directory_authentication_enabled must be set to true to disable access key authentication.</summary>
    [JsonPropertyName("accessKeysAuthenticationEnabled")]
    public bool? AccessKeysAuthenticationEnabled { get; set; }

    /// <summary>The size of the Redis cache to deploy. Valid values for a SKU family of C (Basic/Standard) are 0, 1, 2, 3, 4, 5, 6, and for P (Premium) family are 1, 2, 3, 4, 5.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The SKU family/pricing group to use. Valid values are C (for Basic/Standard SKU family) and P (for Premium)</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1RedisCacheSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>The location of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The minimum TLS version. Possible values are 1.0, 1.1 and 1.2. Defaults to 1.0.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Enable the non-SSL port (6379) - disabled by default.</summary>
    [JsonPropertyName("nonSslPortEnabled")]
    public bool? NonSslPortEnabled { get; set; }

    /// <summary>A list of patch_schedule blocks as defined below.</summary>
    [JsonPropertyName("patchSchedule")]
    public IList<V1beta1RedisCacheSpecForProviderPatchSchedule>? PatchSchedule { get; set; }

    /// <summary>The Static IP Address to assign to the Redis Cache when hosted inside the Virtual Network. This argument implies the use of subnet_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateStaticIpAddress")]
    public string? PrivateStaticIpAddress { get; set; }

    /// <summary>Whether or not public network access is allowed for this Redis Cache. true means this resource could be accessed by both public and private endpoint. false means only private endpoint access is allowed. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A redis_configuration block as defined below - with some limitations by SKU - defaults/details are shown below.</summary>
    [JsonPropertyName("redisConfiguration")]
    public IList<V1beta1RedisCacheSpecForProviderRedisConfiguration>? RedisConfiguration { get; set; }

    /// <summary>Redis version. Only major version needed. Possible values are 4 and 6. Defaults to 6.</summary>
    [JsonPropertyName("redisVersion")]
    public string? RedisVersion { get; set; }

    /// <summary>Amount of replicas to create per master for this Redis Cache.</summary>
    [JsonPropertyName("replicasPerMaster")]
    public double? ReplicasPerMaster { get; set; }

    /// <summary>Amount of replicas to create per primary for this Redis Cache. If both replicas_per_primary and replicas_per_master are set, they need to be equal.</summary>
    [JsonPropertyName("replicasPerPrimary")]
    public double? ReplicasPerPrimary { get; set; }

    /// <summary>The name of the resource group in which to create the Redis instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1RedisCacheSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1RedisCacheSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Only available when using the Premium SKU The number of Shards to create on the Redis Cluster.</summary>
    [JsonPropertyName("shardCount")]
    public double? ShardCount { get; set; }

    /// <summary>The SKU of Redis to use. Possible values are Basic, Standard and Premium.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Only available when using the Premium SKU The ID of the Subnet within which the Redis Cache should be deployed. This Subnet must only contain Azure Cache for Redis instances without any other type of resources. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1RedisCacheSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1RedisCacheSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A mapping of tenant settings to assign to the resource.</summary>
    [JsonPropertyName("tenantSettings")]
    public IDictionary<string, string>? TenantSettings { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Redis Cache should be located. Changing this forces a new Redis Cache to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Redis Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Redis Cluster. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecInitProviderPatchSchedule
{
    /// <summary>the Weekday name - possible values include Monday, Tuesday, Wednesday etc.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The ISO 8601 timespan which specifies the amount of time the Redis Cache can be updated. Defaults to PT5H.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>the Start Hour for maintenance in UTC - possible values range from 0 - 23.</summary>
    [JsonPropertyName("startHourUtc")]
    public double? StartHourUtc { get; set; }
}

/// <summary>First Storage Account connection string for AOF persistence.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecInitProviderRedisConfigurationAofStorageConnectionString0SecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Second Storage Account connection string for AOF persistence.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecInitProviderRedisConfigurationAofStorageConnectionString1SecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>The Connection String to the Storage Account. Only supported for Premium SKUs. In the format: DefaultEndpointsProtocol=https;BlobEndpoint=${azurerm_storage_account.example.primary_blob_endpoint};AccountName=${azurerm_storage_account.example.name};AccountKey=${azurerm_storage_account.example.primary_access_key}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecInitProviderRedisConfigurationRdbStorageConnectionStringSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecInitProviderRedisConfiguration
{
    /// <summary>Enable Microsoft Entra (AAD) authentication. Defaults to false.</summary>
    [JsonPropertyName("activeDirectoryAuthenticationEnabled")]
    public bool? ActiveDirectoryAuthenticationEnabled { get; set; }

    /// <summary>Enable or disable AOF persistence for this Redis Cache. Defaults to false.</summary>
    [JsonPropertyName("aofBackupEnabled")]
    public bool? AofBackupEnabled { get; set; }

    /// <summary>First Storage Account connection string for AOF persistence.</summary>
    [JsonPropertyName("aofStorageConnectionString0SecretRef")]
    public V1beta1RedisCacheSpecInitProviderRedisConfigurationAofStorageConnectionString0SecretRef? AofStorageConnectionString0SecretRef { get; set; }

    /// <summary>Second Storage Account connection string for AOF persistence.</summary>
    [JsonPropertyName("aofStorageConnectionString1SecretRef")]
    public V1beta1RedisCacheSpecInitProviderRedisConfigurationAofStorageConnectionString1SecretRef? AofStorageConnectionString1SecretRef { get; set; }

    /// <summary>If set to false, the Redis instance will be accessible without authentication. Defaults to true.</summary>
    [JsonPropertyName("authenticationEnabled")]
    public bool? AuthenticationEnabled { get; set; }

    /// <summary>Preferred auth method to communicate to storage account used for data persistence. Possible values are SAS and ManagedIdentity.</summary>
    [JsonPropertyName("dataPersistenceAuthenticationMethod")]
    public string? DataPersistenceAuthenticationMethod { get; set; }

    /// <summary>Value in megabytes reserved to accommodate for memory fragmentation. Defaults are shown below.</summary>
    [JsonPropertyName("maxfragmentationmemoryReserved")]
    public double? MaxfragmentationmemoryReserved { get; set; }

    /// <summary>The max-memory delta for this Redis instance. Defaults are shown below.</summary>
    [JsonPropertyName("maxmemoryDelta")]
    public double? MaxmemoryDelta { get; set; }

    /// <summary>How Redis will select what to remove when maxmemory is reached. Defaults to volatile-lru.</summary>
    [JsonPropertyName("maxmemoryPolicy")]
    public string? MaxmemoryPolicy { get; set; }

    /// <summary>Value in megabytes reserved for non-cache usage e.g. failover. Defaults are shown below.</summary>
    [JsonPropertyName("maxmemoryReserved")]
    public double? MaxmemoryReserved { get; set; }

    /// <summary>Keyspace notifications allows clients to subscribe to Pub/Sub channels in order to receive events affecting the Redis data set in some way. Reference</summary>
    [JsonPropertyName("notifyKeyspaceEvents")]
    public string? NotifyKeyspaceEvents { get; set; }

    /// <summary>Is Backup Enabled? Only supported on Premium SKUs. Defaults to false.</summary>
    [JsonPropertyName("rdbBackupEnabled")]
    public bool? RdbBackupEnabled { get; set; }

    /// <summary>The Backup Frequency in Minutes. Only supported on Premium SKUs. Possible values are: 15, 30, 60, 360, 720 and 1440.</summary>
    [JsonPropertyName("rdbBackupFrequency")]
    public double? RdbBackupFrequency { get; set; }

    /// <summary>The maximum number of snapshots to create as a backup. Only supported for Premium SKUs.</summary>
    [JsonPropertyName("rdbBackupMaxSnapshotCount")]
    public double? RdbBackupMaxSnapshotCount { get; set; }

    /// <summary>The Connection String to the Storage Account. Only supported for Premium SKUs. In the format: DefaultEndpointsProtocol=https;BlobEndpoint=${azurerm_storage_account.example.primary_blob_endpoint};AccountName=${azurerm_storage_account.example.name};AccountKey=${azurerm_storage_account.example.primary_access_key}.</summary>
    [JsonPropertyName("rdbStorageConnectionStringSecretRef")]
    public V1beta1RedisCacheSpecInitProviderRedisConfigurationRdbStorageConnectionStringSecretRef? RdbStorageConnectionStringSecretRef { get; set; }

    /// <summary>The ID of the Subscription containing the Storage Account.</summary>
    [JsonPropertyName("storageAccountSubscriptionId")]
    public string? StorageAccountSubscriptionId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecInitProviderSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecInitProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RedisCacheSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RedisCacheSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisCacheSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RedisCacheSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RedisCacheSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecInitProviderSubnetIdSelector
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
    public V1beta1RedisCacheSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecInitProvider
{
    /// <summary>Whether access key authentication is enabled? Defaults to true. active_directory_authentication_enabled must be set to true to disable access key authentication.</summary>
    [JsonPropertyName("accessKeysAuthenticationEnabled")]
    public bool? AccessKeysAuthenticationEnabled { get; set; }

    /// <summary>The size of the Redis cache to deploy. Valid values for a SKU family of C (Basic/Standard) are 0, 1, 2, 3, 4, 5, 6, and for P (Premium) family are 1, 2, 3, 4, 5.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The SKU family/pricing group to use. Valid values are C (for Basic/Standard SKU family) and P (for Premium)</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1RedisCacheSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>The location of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The minimum TLS version. Possible values are 1.0, 1.1 and 1.2. Defaults to 1.0.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Enable the non-SSL port (6379) - disabled by default.</summary>
    [JsonPropertyName("nonSslPortEnabled")]
    public bool? NonSslPortEnabled { get; set; }

    /// <summary>A list of patch_schedule blocks as defined below.</summary>
    [JsonPropertyName("patchSchedule")]
    public IList<V1beta1RedisCacheSpecInitProviderPatchSchedule>? PatchSchedule { get; set; }

    /// <summary>The Static IP Address to assign to the Redis Cache when hosted inside the Virtual Network. This argument implies the use of subnet_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateStaticIpAddress")]
    public string? PrivateStaticIpAddress { get; set; }

    /// <summary>Whether or not public network access is allowed for this Redis Cache. true means this resource could be accessed by both public and private endpoint. false means only private endpoint access is allowed. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A redis_configuration block as defined below - with some limitations by SKU - defaults/details are shown below.</summary>
    [JsonPropertyName("redisConfiguration")]
    public IList<V1beta1RedisCacheSpecInitProviderRedisConfiguration>? RedisConfiguration { get; set; }

    /// <summary>Redis version. Only major version needed. Possible values are 4 and 6. Defaults to 6.</summary>
    [JsonPropertyName("redisVersion")]
    public string? RedisVersion { get; set; }

    /// <summary>Amount of replicas to create per master for this Redis Cache.</summary>
    [JsonPropertyName("replicasPerMaster")]
    public double? ReplicasPerMaster { get; set; }

    /// <summary>Amount of replicas to create per primary for this Redis Cache. If both replicas_per_primary and replicas_per_master are set, they need to be equal.</summary>
    [JsonPropertyName("replicasPerPrimary")]
    public double? ReplicasPerPrimary { get; set; }

    /// <summary>Only available when using the Premium SKU The number of Shards to create on the Redis Cluster.</summary>
    [JsonPropertyName("shardCount")]
    public double? ShardCount { get; set; }

    /// <summary>The SKU of Redis to use. Possible values are Basic, Standard and Premium.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Only available when using the Premium SKU The ID of the Subnet within which the Redis Cache should be deployed. This Subnet must only contain Azure Cache for Redis instances without any other type of resources. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1RedisCacheSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1RedisCacheSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A mapping of tenant settings to assign to the resource.</summary>
    [JsonPropertyName("tenantSettings")]
    public IDictionary<string, string>? TenantSettings { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Redis Cache should be located. Changing this forces a new Redis Cache to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisCacheSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1RedisCacheSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RedisCacheSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RedisCacheSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisCacheSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RedisCacheSpec defines the desired state of RedisCache</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheSpec
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
    public V1beta1RedisCacheSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1RedisCacheSpecForProvider ForProvider { get; set; }

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
    public V1beta1RedisCacheSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1RedisCacheSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RedisCacheSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RedisCacheSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Redis Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Route ID.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Route ID.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Redis Cluster. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheStatusAtProviderPatchSchedule
{
    /// <summary>the Weekday name - possible values include Monday, Tuesday, Wednesday etc.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The ISO 8601 timespan which specifies the amount of time the Redis Cache can be updated. Defaults to PT5H.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>the Start Hour for maintenance in UTC - possible values range from 0 - 23.</summary>
    [JsonPropertyName("startHourUtc")]
    public double? StartHourUtc { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheStatusAtProviderRedisConfiguration
{
    /// <summary>Enable Microsoft Entra (AAD) authentication. Defaults to false.</summary>
    [JsonPropertyName("activeDirectoryAuthenticationEnabled")]
    public bool? ActiveDirectoryAuthenticationEnabled { get; set; }

    /// <summary>Enable or disable AOF persistence for this Redis Cache. Defaults to false.</summary>
    [JsonPropertyName("aofBackupEnabled")]
    public bool? AofBackupEnabled { get; set; }

    /// <summary>If set to false, the Redis instance will be accessible without authentication. Defaults to true.</summary>
    [JsonPropertyName("authenticationEnabled")]
    public bool? AuthenticationEnabled { get; set; }

    /// <summary>Preferred auth method to communicate to storage account used for data persistence. Possible values are SAS and ManagedIdentity.</summary>
    [JsonPropertyName("dataPersistenceAuthenticationMethod")]
    public string? DataPersistenceAuthenticationMethod { get; set; }

    /// <summary>Returns the max number of connected clients at the same time.</summary>
    [JsonPropertyName("maxclients")]
    public double? Maxclients { get; set; }

    /// <summary>Value in megabytes reserved to accommodate for memory fragmentation. Defaults are shown below.</summary>
    [JsonPropertyName("maxfragmentationmemoryReserved")]
    public double? MaxfragmentationmemoryReserved { get; set; }

    /// <summary>The max-memory delta for this Redis instance. Defaults are shown below.</summary>
    [JsonPropertyName("maxmemoryDelta")]
    public double? MaxmemoryDelta { get; set; }

    /// <summary>How Redis will select what to remove when maxmemory is reached. Defaults to volatile-lru.</summary>
    [JsonPropertyName("maxmemoryPolicy")]
    public string? MaxmemoryPolicy { get; set; }

    /// <summary>Value in megabytes reserved for non-cache usage e.g. failover. Defaults are shown below.</summary>
    [JsonPropertyName("maxmemoryReserved")]
    public double? MaxmemoryReserved { get; set; }

    /// <summary>Keyspace notifications allows clients to subscribe to Pub/Sub channels in order to receive events affecting the Redis data set in some way. Reference</summary>
    [JsonPropertyName("notifyKeyspaceEvents")]
    public string? NotifyKeyspaceEvents { get; set; }

    /// <summary>Is Backup Enabled? Only supported on Premium SKUs. Defaults to false.</summary>
    [JsonPropertyName("rdbBackupEnabled")]
    public bool? RdbBackupEnabled { get; set; }

    /// <summary>The Backup Frequency in Minutes. Only supported on Premium SKUs. Possible values are: 15, 30, 60, 360, 720 and 1440.</summary>
    [JsonPropertyName("rdbBackupFrequency")]
    public double? RdbBackupFrequency { get; set; }

    /// <summary>The maximum number of snapshots to create as a backup. Only supported for Premium SKUs.</summary>
    [JsonPropertyName("rdbBackupMaxSnapshotCount")]
    public double? RdbBackupMaxSnapshotCount { get; set; }

    /// <summary>The ID of the Subscription containing the Storage Account.</summary>
    [JsonPropertyName("storageAccountSubscriptionId")]
    public string? StorageAccountSubscriptionId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheStatusAtProvider
{
    /// <summary>Whether access key authentication is enabled? Defaults to true. active_directory_authentication_enabled must be set to true to disable access key authentication.</summary>
    [JsonPropertyName("accessKeysAuthenticationEnabled")]
    public bool? AccessKeysAuthenticationEnabled { get; set; }

    /// <summary>The size of the Redis cache to deploy. Valid values for a SKU family of C (Basic/Standard) are 0, 1, 2, 3, 4, 5, 6, and for P (Premium) family are 1, 2, 3, 4, 5.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The SKU family/pricing group to use. Valid values are C (for Basic/Standard SKU family) and P (for Premium)</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>The Hostname of the Redis Instance</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>The Route ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1RedisCacheStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>The location of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The minimum TLS version. Possible values are 1.0, 1.1 and 1.2. Defaults to 1.0.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Enable the non-SSL port (6379) - disabled by default.</summary>
    [JsonPropertyName("nonSslPortEnabled")]
    public bool? NonSslPortEnabled { get; set; }

    /// <summary>A list of patch_schedule blocks as defined below.</summary>
    [JsonPropertyName("patchSchedule")]
    public IList<V1beta1RedisCacheStatusAtProviderPatchSchedule>? PatchSchedule { get; set; }

    /// <summary>The non-SSL Port of the Redis Instance</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The Static IP Address to assign to the Redis Cache when hosted inside the Virtual Network. This argument implies the use of subnet_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateStaticIpAddress")]
    public string? PrivateStaticIpAddress { get; set; }

    /// <summary>Whether or not public network access is allowed for this Redis Cache. true means this resource could be accessed by both public and private endpoint. false means only private endpoint access is allowed. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A redis_configuration block as defined below - with some limitations by SKU - defaults/details are shown below.</summary>
    [JsonPropertyName("redisConfiguration")]
    public IList<V1beta1RedisCacheStatusAtProviderRedisConfiguration>? RedisConfiguration { get; set; }

    /// <summary>Redis version. Only major version needed. Possible values are 4 and 6. Defaults to 6.</summary>
    [JsonPropertyName("redisVersion")]
    public string? RedisVersion { get; set; }

    /// <summary>Amount of replicas to create per master for this Redis Cache.</summary>
    [JsonPropertyName("replicasPerMaster")]
    public double? ReplicasPerMaster { get; set; }

    /// <summary>Amount of replicas to create per primary for this Redis Cache. If both replicas_per_primary and replicas_per_master are set, they need to be equal.</summary>
    [JsonPropertyName("replicasPerPrimary")]
    public double? ReplicasPerPrimary { get; set; }

    /// <summary>The name of the resource group in which to create the Redis instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Only available when using the Premium SKU The number of Shards to create on the Redis Cluster.</summary>
    [JsonPropertyName("shardCount")]
    public double? ShardCount { get; set; }

    /// <summary>The SKU of Redis to use. Possible values are Basic, Standard and Premium.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The SSL Port of the Redis Instance</summary>
    [JsonPropertyName("sslPort")]
    public double? SslPort { get; set; }

    /// <summary>Only available when using the Premium SKU The ID of the Subnet within which the Redis Cache should be deployed. This Subnet must only contain Azure Cache for Redis instances without any other type of resources. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A mapping of tenant settings to assign to the resource.</summary>
    [JsonPropertyName("tenantSettings")]
    public IDictionary<string, string>? TenantSettings { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Redis Cache should be located. Changing this forces a new Redis Cache to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheStatusConditions
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

/// <summary>RedisCacheStatus defines the observed state of RedisCache.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1RedisCacheStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1RedisCacheStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RedisCacheStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// RedisCache is the Schema for the RedisCaches API. Manages a Redis Cache
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RedisCache : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RedisCacheSpec>, IStatus<V1beta1RedisCacheStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RedisCache";
    public const string KubeGroup = "cache.azure.upbound.io";
    public const string KubePluralName = "rediscaches";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cache.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RedisCache";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RedisCacheSpec defines the desired state of RedisCache</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RedisCacheSpec Spec { get; set; }

    /// <summary>RedisCacheStatus defines the observed state of RedisCache.</summary>
    [JsonPropertyName("status")]
    public V1beta1RedisCacheStatus? Status { get; set; }
}