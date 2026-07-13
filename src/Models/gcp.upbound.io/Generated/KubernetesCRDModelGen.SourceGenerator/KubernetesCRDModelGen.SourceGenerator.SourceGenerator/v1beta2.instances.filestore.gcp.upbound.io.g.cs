#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.filestore.gcp.upbound.io;
/// <summary>Instance is the Schema for the Instances API. A Google Cloud Filestore instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Instance>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceList";
    public const string KubeGroup = "filestore.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "filestore.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Instance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Instance> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecDeletionPolicyEnum>))]
public enum V1beta2InstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderFileSharesNfsExportOptions
{
    /// <summary>
    /// Either READ_ONLY, for allowing only read requests on the exported directory,
    /// or READ_WRITE, for allowing both read and write requests. The default is READ_WRITE.
    /// Default value is READ_WRITE.
    /// Possible values are: READ_ONLY, READ_WRITE.
    /// </summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>
    /// An integer representing the anonymous group id with a default value of 65534.
    /// Anon_gid may only be set with squashMode of ROOT_SQUASH. An error will be returned
    /// if this field is specified for other squashMode settings.
    /// </summary>
    [JsonPropertyName("anonGid")]
    public double? AnonGid { get; set; }

    /// <summary>
    /// An integer representing the anonymous user id with a default value of 65534.
    /// Anon_uid may only be set with squashMode of ROOT_SQUASH. An error will be returned
    /// if this field is specified for other squashMode settings.
    /// </summary>
    [JsonPropertyName("anonUid")]
    public double? AnonUid { get; set; }

    /// <summary>
    /// List of either IPv4 addresses, or ranges in CIDR notation which may mount the file share.
    /// Overlapping IP ranges are not allowed, both within and across NfsExportOptions. An error will be returned.
    /// The limit is 64 IP ranges/addresses for each FileShareConfig among all NfsExportOptions.
    /// </summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>
    /// Either NO_ROOT_SQUASH, for allowing root access on the exported directory, or ROOT_SQUASH,
    /// for not allowing root access. The default is NO_ROOT_SQUASH.
    /// Default value is NO_ROOT_SQUASH.
    /// Possible values are: NO_ROOT_SQUASH, ROOT_SQUASH.
    /// </summary>
    [JsonPropertyName("squashMode")]
    public string? SquashMode { get; set; }
}

/// <summary>
/// File system shares on the instance. For this version, only a
/// single file share is supported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderFileShares
{
    /// <summary>
    /// File share capacity in GiB. This must be at least 1024 GiB
    /// for the standard tier, or 2560 GiB for the premium tier.
    /// </summary>
    [JsonPropertyName("capacityGb")]
    public double? CapacityGb { get; set; }

    /// <summary>The name of the fileshare (16 characters or less)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Nfs Export Options. There is a limit of 10 export options per file share.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nfsExportOptions")]
    public IList<V1beta2InstanceSpecForProviderFileSharesNfsExportOptions>? NfsExportOptions { get; set; }

    /// <summary>
    /// The resource name of the backup, in the format
    /// projects/{projectId}/locations/{locationId}/backups/{backupId},
    /// that this file share has been restored from.
    /// </summary>
    [JsonPropertyName("sourceBackup")]
    public string? SourceBackup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderInitialReplicationReplicas
{
    /// <summary>The peer instance.</summary>
    [JsonPropertyName("peerInstance")]
    public string? PeerInstance { get; set; }
}

/// <summary>
/// Replication configuration, once set, this cannot be updated.
/// Additionally this should be specified on the replica instance only, indicating the active as the peer_instance
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderInitialReplication
{
    /// <summary>
    /// The replication role.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replicas")]
    public IList<V1beta2InstanceSpecForProviderInitialReplicationReplicas>? Replicas { get; set; }

    /// <summary>
    /// The replication role.
    /// Default value is STANDBY.
    /// Possible values are: ROLE_UNSPECIFIED, ACTIVE, STANDBY.
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderKmsKeyNameRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderKmsKeyNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderKmsKeyNameRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderKmsKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderKmsKeyNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderKmsKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderKmsKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecForProviderKmsKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderKmsKeyNameSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderKmsKeyNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderKmsKeyNameSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderKmsKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderKmsKeyNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderKmsKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderKmsKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderKmsKeyNameSelector
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
    public V1beta2InstanceSpecForProviderKmsKeyNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderNetworks
{
    /// <summary>
    /// The network connect mode of the Filestore instance.
    /// If not provided, the connect mode defaults to
    /// DIRECT_PEERING.
    /// Default value is DIRECT_PEERING.
    /// Possible values are: DIRECT_PEERING, PRIVATE_SERVICE_ACCESS, PRIVATE_SERVICE_CONNECT.
    /// </summary>
    [JsonPropertyName("connectMode")]
    public string? ConnectMode { get; set; }

    /// <summary>
    /// IP versions for which the instance has
    /// IP addresses assigned.
    /// Each value may be one of: ADDRESS_MODE_UNSPECIFIED, MODE_IPV4, MODE_IPV6.
    /// </summary>
    [JsonPropertyName("modes")]
    public IList<string>? Modes { get; set; }

    /// <summary>
    /// The name of the GCE VPC network to which the
    /// instance is connected.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// A /29 CIDR block that identifies the range of IP
    /// addresses reserved for this instance.
    /// </summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }
}

/// <summary>
/// The instance will have a fixed provisioned IOPS value,
/// which will remain constant regardless of instance
/// capacity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderPerformanceConfigFixedIops
{
    /// <summary>
    /// The number of IOPS to provision for the instance.
    /// max_iops must be in multiple of 1000.
    /// </summary>
    [JsonPropertyName("maxIops")]
    public double? MaxIops { get; set; }
}

/// <summary>
/// The instance provisioned IOPS will change dynamically
/// based on the capacity of the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderPerformanceConfigIopsPerTb
{
    /// <summary>
    /// The instance max IOPS will be calculated by multiplying
    /// the capacity of the instance (TB) by max_iops_per_tb,
    /// and rounding to the nearest 1000. The instance max IOPS
    /// will be changed dynamically based on the instance
    /// capacity.
    /// </summary>
    [JsonPropertyName("maxIopsPerTb")]
    public double? MaxIopsPerTb { get; set; }
}

/// <summary>
/// Performance configuration for the instance. If not provided,
/// the default performance settings will be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderPerformanceConfig
{
    /// <summary>
    /// The instance will have a fixed provisioned IOPS value,
    /// which will remain constant regardless of instance
    /// capacity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedIops")]
    public V1beta2InstanceSpecForProviderPerformanceConfigFixedIops? FixedIops { get; set; }

    /// <summary>
    /// The instance provisioned IOPS will change dynamically
    /// based on the capacity of the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("iopsPerTb")]
    public V1beta2InstanceSpecForProviderPerformanceConfigIopsPerTb? IopsPerTb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProvider
{
    /// <summary>Indicates whether the instance is protected against deletion.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>The reason for enabling deletion protection.</summary>
    [JsonPropertyName("deletionProtectionReason")]
    public string? DeletionProtectionReason { get; set; }

    /// <summary>A description of the instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// File system shares on the instance. For this version, only a
    /// single file share is supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fileShares")]
    public V1beta2InstanceSpecForProviderFileShares? FileShares { get; set; }

    /// <summary>
    /// Replication configuration, once set, this cannot be updated.
    /// Additionally this should be specified on the replica instance only, indicating the active as the peer_instance
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("initialReplication")]
    public V1beta2InstanceSpecForProviderInitialReplication? InitialReplication { get; set; }

    /// <summary>KMS key name used for data encryption.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta2InstanceSpecForProviderKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta2InstanceSpecForProviderKmsKeyNameSelector? KmsKeyNameSelector { get; set; }

    /// <summary>Resource labels to represent user-provided metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the location of the instance. This can be a region for ENTERPRISE tier instances.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// VPC networks to which the instance is connected. For this version,
    /// only a single network is supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networks")]
    public IList<V1beta2InstanceSpecForProviderNetworks>? Networks { get; set; }

    /// <summary>
    /// Performance configuration for the instance. If not provided,
    /// the default performance settings will be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("performanceConfig")]
    public V1beta2InstanceSpecForProviderPerformanceConfig? PerformanceConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Either NFSv3, for using NFS version 3 as file sharing protocol,
    /// or NFSv4.1, for using NFS version 4.1 as file sharing protocol.
    /// NFSv4.1 can be used with HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE.
    /// The default is NFSv3.
    /// Default value is NFS_V3.
    /// Possible values are: NFS_V3, NFS_V4_1.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys
    /// and values have the same definition as resource manager
    /// tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456. The field is
    /// ignored when empty. The field is immutable and causes
    /// resource replacement when mutated. This field is only set
    /// at create time and modifying this field after creation
    /// will trigger recreation. To apply tags to an existing
    /// resource, see the google_tags_tag_value resource.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The service tier of the instance.
    /// Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The name of the Filestore zone of the instance.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderFileSharesNfsExportOptions
{
    /// <summary>
    /// Either READ_ONLY, for allowing only read requests on the exported directory,
    /// or READ_WRITE, for allowing both read and write requests. The default is READ_WRITE.
    /// Default value is READ_WRITE.
    /// Possible values are: READ_ONLY, READ_WRITE.
    /// </summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>
    /// An integer representing the anonymous group id with a default value of 65534.
    /// Anon_gid may only be set with squashMode of ROOT_SQUASH. An error will be returned
    /// if this field is specified for other squashMode settings.
    /// </summary>
    [JsonPropertyName("anonGid")]
    public double? AnonGid { get; set; }

    /// <summary>
    /// An integer representing the anonymous user id with a default value of 65534.
    /// Anon_uid may only be set with squashMode of ROOT_SQUASH. An error will be returned
    /// if this field is specified for other squashMode settings.
    /// </summary>
    [JsonPropertyName("anonUid")]
    public double? AnonUid { get; set; }

    /// <summary>
    /// List of either IPv4 addresses, or ranges in CIDR notation which may mount the file share.
    /// Overlapping IP ranges are not allowed, both within and across NfsExportOptions. An error will be returned.
    /// The limit is 64 IP ranges/addresses for each FileShareConfig among all NfsExportOptions.
    /// </summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>
    /// Either NO_ROOT_SQUASH, for allowing root access on the exported directory, or ROOT_SQUASH,
    /// for not allowing root access. The default is NO_ROOT_SQUASH.
    /// Default value is NO_ROOT_SQUASH.
    /// Possible values are: NO_ROOT_SQUASH, ROOT_SQUASH.
    /// </summary>
    [JsonPropertyName("squashMode")]
    public string? SquashMode { get; set; }
}

/// <summary>
/// File system shares on the instance. For this version, only a
/// single file share is supported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderFileShares
{
    /// <summary>
    /// File share capacity in GiB. This must be at least 1024 GiB
    /// for the standard tier, or 2560 GiB for the premium tier.
    /// </summary>
    [JsonPropertyName("capacityGb")]
    public double? CapacityGb { get; set; }

    /// <summary>The name of the fileshare (16 characters or less)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Nfs Export Options. There is a limit of 10 export options per file share.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nfsExportOptions")]
    public IList<V1beta2InstanceSpecInitProviderFileSharesNfsExportOptions>? NfsExportOptions { get; set; }

    /// <summary>
    /// The resource name of the backup, in the format
    /// projects/{projectId}/locations/{locationId}/backups/{backupId},
    /// that this file share has been restored from.
    /// </summary>
    [JsonPropertyName("sourceBackup")]
    public string? SourceBackup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderInitialReplicationReplicas
{
    /// <summary>The peer instance.</summary>
    [JsonPropertyName("peerInstance")]
    public string? PeerInstance { get; set; }
}

/// <summary>
/// Replication configuration, once set, this cannot be updated.
/// Additionally this should be specified on the replica instance only, indicating the active as the peer_instance
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderInitialReplication
{
    /// <summary>
    /// The replication role.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replicas")]
    public IList<V1beta2InstanceSpecInitProviderInitialReplicationReplicas>? Replicas { get; set; }

    /// <summary>
    /// The replication role.
    /// Default value is STANDBY.
    /// Possible values are: ROLE_UNSPECIFIED, ACTIVE, STANDBY.
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderKmsKeyNameRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderKmsKeyNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderKmsKeyNameRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderKmsKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderKmsKeyNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderKmsKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderKmsKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecInitProviderKmsKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderKmsKeyNameSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderKmsKeyNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderKmsKeyNameSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderKmsKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderKmsKeyNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderKmsKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderKmsKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderKmsKeyNameSelector
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
    public V1beta2InstanceSpecInitProviderKmsKeyNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderNetworks
{
    /// <summary>
    /// The network connect mode of the Filestore instance.
    /// If not provided, the connect mode defaults to
    /// DIRECT_PEERING.
    /// Default value is DIRECT_PEERING.
    /// Possible values are: DIRECT_PEERING, PRIVATE_SERVICE_ACCESS, PRIVATE_SERVICE_CONNECT.
    /// </summary>
    [JsonPropertyName("connectMode")]
    public string? ConnectMode { get; set; }

    /// <summary>
    /// IP versions for which the instance has
    /// IP addresses assigned.
    /// Each value may be one of: ADDRESS_MODE_UNSPECIFIED, MODE_IPV4, MODE_IPV6.
    /// </summary>
    [JsonPropertyName("modes")]
    public IList<string>? Modes { get; set; }

    /// <summary>
    /// The name of the GCE VPC network to which the
    /// instance is connected.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// A /29 CIDR block that identifies the range of IP
    /// addresses reserved for this instance.
    /// </summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }
}

/// <summary>
/// The instance will have a fixed provisioned IOPS value,
/// which will remain constant regardless of instance
/// capacity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderPerformanceConfigFixedIops
{
    /// <summary>
    /// The number of IOPS to provision for the instance.
    /// max_iops must be in multiple of 1000.
    /// </summary>
    [JsonPropertyName("maxIops")]
    public double? MaxIops { get; set; }
}

/// <summary>
/// The instance provisioned IOPS will change dynamically
/// based on the capacity of the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderPerformanceConfigIopsPerTb
{
    /// <summary>
    /// The instance max IOPS will be calculated by multiplying
    /// the capacity of the instance (TB) by max_iops_per_tb,
    /// and rounding to the nearest 1000. The instance max IOPS
    /// will be changed dynamically based on the instance
    /// capacity.
    /// </summary>
    [JsonPropertyName("maxIopsPerTb")]
    public double? MaxIopsPerTb { get; set; }
}

/// <summary>
/// Performance configuration for the instance. If not provided,
/// the default performance settings will be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderPerformanceConfig
{
    /// <summary>
    /// The instance will have a fixed provisioned IOPS value,
    /// which will remain constant regardless of instance
    /// capacity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedIops")]
    public V1beta2InstanceSpecInitProviderPerformanceConfigFixedIops? FixedIops { get; set; }

    /// <summary>
    /// The instance provisioned IOPS will change dynamically
    /// based on the capacity of the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("iopsPerTb")]
    public V1beta2InstanceSpecInitProviderPerformanceConfigIopsPerTb? IopsPerTb { get; set; }
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
public partial class V1beta2InstanceSpecInitProvider
{
    /// <summary>Indicates whether the instance is protected against deletion.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>The reason for enabling deletion protection.</summary>
    [JsonPropertyName("deletionProtectionReason")]
    public string? DeletionProtectionReason { get; set; }

    /// <summary>A description of the instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// File system shares on the instance. For this version, only a
    /// single file share is supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fileShares")]
    public V1beta2InstanceSpecInitProviderFileShares? FileShares { get; set; }

    /// <summary>
    /// Replication configuration, once set, this cannot be updated.
    /// Additionally this should be specified on the replica instance only, indicating the active as the peer_instance
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("initialReplication")]
    public V1beta2InstanceSpecInitProviderInitialReplication? InitialReplication { get; set; }

    /// <summary>KMS key name used for data encryption.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta2InstanceSpecInitProviderKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta2InstanceSpecInitProviderKmsKeyNameSelector? KmsKeyNameSelector { get; set; }

    /// <summary>Resource labels to represent user-provided metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// VPC networks to which the instance is connected. For this version,
    /// only a single network is supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networks")]
    public IList<V1beta2InstanceSpecInitProviderNetworks>? Networks { get; set; }

    /// <summary>
    /// Performance configuration for the instance. If not provided,
    /// the default performance settings will be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("performanceConfig")]
    public V1beta2InstanceSpecInitProviderPerformanceConfig? PerformanceConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Either NFSv3, for using NFS version 3 as file sharing protocol,
    /// or NFSv4.1, for using NFS version 4.1 as file sharing protocol.
    /// NFSv4.1 can be used with HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE.
    /// The default is NFSv3.
    /// Default value is NFS_V3.
    /// Possible values are: NFS_V3, NFS_V4_1.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys
    /// and values have the same definition as resource manager
    /// tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456. The field is
    /// ignored when empty. The field is immutable and causes
    /// resource replacement when mutated. This field is only set
    /// at create time and modifying this field after creation
    /// will trigger recreation. To apply tags to an existing
    /// resource, see the google_tags_tag_value resource.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The service tier of the instance.
    /// Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The name of the Filestore zone of the instance.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecManagementPoliciesEnum>))]
public enum V1beta2InstanceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>InstanceSpec defines the desired state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpec
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
    public V1beta2InstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2InstanceSpecForProvider ForProvider { get; set; }

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
    public V1beta2InstanceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2InstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderEffectiveReplicationReplicas
{
    /// <summary>
    /// (Output)
    /// Output only. The timestamp of the latest replication snapshot taken on the active instance and is already replicated safely.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;
    /// </summary>
    [JsonPropertyName("lastActiveSyncTime")]
    public string? LastActiveSyncTime { get; set; }

    /// <summary>The peer instance.</summary>
    [JsonPropertyName("peerInstance")]
    public string? PeerInstance { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The replica state
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. Additional information about the replication state, if available.
    /// </summary>
    [JsonPropertyName("stateReasons")]
    public IList<string>? StateReasons { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderEffectiveReplication
{
    /// <summary>
    /// The replication role.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replicas")]
    public IList<V1beta2InstanceStatusAtProviderEffectiveReplicationReplicas>? Replicas { get; set; }

    /// <summary>
    /// (Output)
    /// The replication role.
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderFileSharesNfsExportOptions
{
    /// <summary>
    /// Either READ_ONLY, for allowing only read requests on the exported directory,
    /// or READ_WRITE, for allowing both read and write requests. The default is READ_WRITE.
    /// Default value is READ_WRITE.
    /// Possible values are: READ_ONLY, READ_WRITE.
    /// </summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>
    /// An integer representing the anonymous group id with a default value of 65534.
    /// Anon_gid may only be set with squashMode of ROOT_SQUASH. An error will be returned
    /// if this field is specified for other squashMode settings.
    /// </summary>
    [JsonPropertyName("anonGid")]
    public double? AnonGid { get; set; }

    /// <summary>
    /// An integer representing the anonymous user id with a default value of 65534.
    /// Anon_uid may only be set with squashMode of ROOT_SQUASH. An error will be returned
    /// if this field is specified for other squashMode settings.
    /// </summary>
    [JsonPropertyName("anonUid")]
    public double? AnonUid { get; set; }

    /// <summary>
    /// List of either IPv4 addresses, or ranges in CIDR notation which may mount the file share.
    /// Overlapping IP ranges are not allowed, both within and across NfsExportOptions. An error will be returned.
    /// The limit is 64 IP ranges/addresses for each FileShareConfig among all NfsExportOptions.
    /// </summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>
    /// Either NO_ROOT_SQUASH, for allowing root access on the exported directory, or ROOT_SQUASH,
    /// for not allowing root access. The default is NO_ROOT_SQUASH.
    /// Default value is NO_ROOT_SQUASH.
    /// Possible values are: NO_ROOT_SQUASH, ROOT_SQUASH.
    /// </summary>
    [JsonPropertyName("squashMode")]
    public string? SquashMode { get; set; }
}

/// <summary>
/// File system shares on the instance. For this version, only a
/// single file share is supported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderFileShares
{
    /// <summary>
    /// File share capacity in GiB. This must be at least 1024 GiB
    /// for the standard tier, or 2560 GiB for the premium tier.
    /// </summary>
    [JsonPropertyName("capacityGb")]
    public double? CapacityGb { get; set; }

    /// <summary>The name of the fileshare (16 characters or less)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Nfs Export Options. There is a limit of 10 export options per file share.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nfsExportOptions")]
    public IList<V1beta2InstanceStatusAtProviderFileSharesNfsExportOptions>? NfsExportOptions { get; set; }

    /// <summary>
    /// The resource name of the backup, in the format
    /// projects/{projectId}/locations/{locationId}/backups/{backupId},
    /// that this file share has been restored from.
    /// </summary>
    [JsonPropertyName("sourceBackup")]
    public string? SourceBackup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderInitialReplicationReplicas
{
    /// <summary>The peer instance.</summary>
    [JsonPropertyName("peerInstance")]
    public string? PeerInstance { get; set; }
}

/// <summary>
/// Replication configuration, once set, this cannot be updated.
/// Additionally this should be specified on the replica instance only, indicating the active as the peer_instance
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderInitialReplication
{
    /// <summary>
    /// The replication role.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replicas")]
    public IList<V1beta2InstanceStatusAtProviderInitialReplicationReplicas>? Replicas { get; set; }

    /// <summary>
    /// The replication role.
    /// Default value is STANDBY.
    /// Possible values are: ROLE_UNSPECIFIED, ACTIVE, STANDBY.
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderNetworks
{
    /// <summary>
    /// The network connect mode of the Filestore instance.
    /// If not provided, the connect mode defaults to
    /// DIRECT_PEERING.
    /// Default value is DIRECT_PEERING.
    /// Possible values are: DIRECT_PEERING, PRIVATE_SERVICE_ACCESS, PRIVATE_SERVICE_CONNECT.
    /// </summary>
    [JsonPropertyName("connectMode")]
    public string? ConnectMode { get; set; }

    /// <summary>
    /// (Output)
    /// A list of IPv4 or IPv6 addresses.
    /// </summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>
    /// IP versions for which the instance has
    /// IP addresses assigned.
    /// Each value may be one of: ADDRESS_MODE_UNSPECIFIED, MODE_IPV4, MODE_IPV6.
    /// </summary>
    [JsonPropertyName("modes")]
    public IList<string>? Modes { get; set; }

    /// <summary>
    /// The name of the GCE VPC network to which the
    /// instance is connected.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// A /29 CIDR block that identifies the range of IP
    /// addresses reserved for this instance.
    /// </summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }
}

/// <summary>
/// The instance will have a fixed provisioned IOPS value,
/// which will remain constant regardless of instance
/// capacity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderPerformanceConfigFixedIops
{
    /// <summary>
    /// The number of IOPS to provision for the instance.
    /// max_iops must be in multiple of 1000.
    /// </summary>
    [JsonPropertyName("maxIops")]
    public double? MaxIops { get; set; }
}

/// <summary>
/// The instance provisioned IOPS will change dynamically
/// based on the capacity of the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderPerformanceConfigIopsPerTb
{
    /// <summary>
    /// The instance max IOPS will be calculated by multiplying
    /// the capacity of the instance (TB) by max_iops_per_tb,
    /// and rounding to the nearest 1000. The instance max IOPS
    /// will be changed dynamically based on the instance
    /// capacity.
    /// </summary>
    [JsonPropertyName("maxIopsPerTb")]
    public double? MaxIopsPerTb { get; set; }
}

/// <summary>
/// Performance configuration for the instance. If not provided,
/// the default performance settings will be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderPerformanceConfig
{
    /// <summary>
    /// The instance will have a fixed provisioned IOPS value,
    /// which will remain constant regardless of instance
    /// capacity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedIops")]
    public V1beta2InstanceStatusAtProviderPerformanceConfigFixedIops? FixedIops { get; set; }

    /// <summary>
    /// The instance provisioned IOPS will change dynamically
    /// based on the capacity of the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("iopsPerTb")]
    public V1beta2InstanceStatusAtProviderPerformanceConfigIopsPerTb? IopsPerTb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProvider
{
    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Indicates whether the instance is protected against deletion.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>The reason for enabling deletion protection.</summary>
    [JsonPropertyName("deletionProtectionReason")]
    public string? DeletionProtectionReason { get; set; }

    /// <summary>A description of the instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// Output only fields for replication configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("effectiveReplication")]
    public IList<V1beta2InstanceStatusAtProviderEffectiveReplication>? EffectiveReplication { get; set; }

    /// <summary>
    /// Server-specified ETag for the instance resource to prevent
    /// simultaneous updates from overwriting each other.
    /// </summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// File system shares on the instance. For this version, only a
    /// single file share is supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fileShares")]
    public V1beta2InstanceStatusAtProviderFileShares? FileShares { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/instances/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Replication configuration, once set, this cannot be updated.
    /// Additionally this should be specified on the replica instance only, indicating the active as the peer_instance
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("initialReplication")]
    public V1beta2InstanceStatusAtProviderInitialReplication? InitialReplication { get; set; }

    /// <summary>KMS key name used for data encryption.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Resource labels to represent user-provided metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the location of the instance. This can be a region for ENTERPRISE tier instances.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// VPC networks to which the instance is connected. For this version,
    /// only a single network is supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networks")]
    public IList<V1beta2InstanceStatusAtProviderNetworks>? Networks { get; set; }

    /// <summary>
    /// Performance configuration for the instance. If not provided,
    /// the default performance settings will be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("performanceConfig")]
    public V1beta2InstanceStatusAtProviderPerformanceConfig? PerformanceConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Either NFSv3, for using NFS version 3 as file sharing protocol,
    /// or NFSv4.1, for using NFS version 4.1 as file sharing protocol.
    /// NFSv4.1 can be used with HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE.
    /// The default is NFSv3.
    /// Default value is NFS_V3.
    /// Possible values are: NFS_V3, NFS_V4_1.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys
    /// and values have the same definition as resource manager
    /// tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456. The field is
    /// ignored when empty. The field is immutable and causes
    /// resource replacement when mutated. This field is only set
    /// at create time and modifying this field after creation
    /// will trigger recreation. To apply tags to an existing
    /// resource, see the google_tags_tag_value resource.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>
    /// The service tier of the instance.
    /// Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The name of the Filestore zone of the instance.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusConditions
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

/// <summary>InstanceStatus defines the observed state of Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Instance is the Schema for the Instances API. A Google Cloud Filestore instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2InstanceSpec>, IStatus<V1beta2InstanceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "filestore.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "filestore.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Instance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public required V1beta2InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta2InstanceStatus? Status { get; set; }
}