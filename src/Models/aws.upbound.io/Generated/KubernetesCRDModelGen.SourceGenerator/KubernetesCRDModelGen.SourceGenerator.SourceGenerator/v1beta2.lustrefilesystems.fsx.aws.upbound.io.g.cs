#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.fsx.aws.upbound.io;
/// <summary>LustreFileSystem is the Schema for the LustreFileSystems API. Manages a FSx Lustre File System.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LustreFileSystemList : IKubernetesObject<V1ListMeta>, IItems<V1beta2LustreFileSystem>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LustreFileSystemList";
    public const string KubeGroup = "fsx.aws.upbound.io";
    public const string KubePluralName = "lustrefilesystems";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "fsx.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LustreFileSystemList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2LustreFileSystem objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2LustreFileSystem> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecDeletionPolicyEnum>))]
public enum V1beta2LustreFileSystemSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderDataReadCacheConfiguration
{
    /// <summary>Size of the file system&apos;s SSD read cache, in gibibytes (GiB). Required when the sizing_mode is USER_PROVISIONED.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>Sizing mode for the cache. Valud values are NO_CACHE, USER_PROVISIONED, and PROPORTIONAL_TO_THROUGHPUT_CAPACITY.</summary>
    [JsonPropertyName("sizingMode")]
    public string? SizingMode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecForProviderKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecForProviderKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecForProviderKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecForProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecForProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecForProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LustreFileSystemSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecForProviderKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecForProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecForProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderKmsKeyIdSelector
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
    public V1beta2LustreFileSystemSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The Lustre logging configuration used when creating an Amazon FSx for Lustre file system. When logging is enabled, Lustre logs error and warning events for data repositories associated with your file system to Amazon CloudWatch Logs. See log_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderLogConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) that specifies the destination of the logs. The name of the Amazon CloudWatch Logs log group must begin with the /aws/fsx prefix. If you do not provide a destination, Amazon FSx will create and use a log stream in the CloudWatch Logs /aws/fsx/lustre log group.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Sets which data repository events are logged by Amazon FSx. Valid values are WARN_ONLY, FAILURE_ONLY, ERROR_ONLY, WARN_ERROR and DISABLED. Default value is DISABLED.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }
}

/// <summary>The Lustre metadata configuration used when creating an Amazon FSx for Lustre file system. This can be used to specify a user provisioned metadata scale. This is only supported when deployment_type is set to PERSISTENT_2. See metadata_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderMetadataConfiguration
{
    /// <summary>Amount of IOPS provisioned for metadata. This parameter should only be used when the mode is set to USER_PROVISIONED. Valid Values are 1500,3000,6000 and 12000 through 192000 in increments of 12000. Valid values for INTELLIGENT_TIERING storage type are 6000 or 12000.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Mode for the metadata configuration of the file system. Valid values are AUTOMATIC, and USER_PROVISIONED. Must be set to USER_PROVISIONED for INTELLIGENT_TIERING storage type.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>The Lustre root squash configuration used when creating an Amazon FSx for Lustre file system. When enabled, root squash restricts root-level access from clients that try to access your file system as a root user. See root_squash_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderRootSquashConfiguration
{
    /// <summary>When root squash is enabled, you can optionally specify an array of NIDs of clients for which root squash does not apply. A client NID is a Lustre Network Identifier used to uniquely identify a client. You can specify the NID as either a single address or a range of addresses: 1. A single address is described in standard Lustre NID format by specifying the client’s IP address followed by the Lustre network ID (for example, 10.0.1.6@tcp). 2. An address range is described using a dash to separate the range (for example, 10.0.[2-10].[1-255]@tcp).</summary>
    [JsonPropertyName("noSquashNids")]
    public IList<string>? NoSquashNids { get; set; }

    /// <summary>You enable root squash by setting a user ID (UID) and group ID (GID) for the file system in the format UID:GID (for example, 365534:65534). The UID and GID values can range from 0 to 4294967294.</summary>
    [JsonPropertyName("rootSquash")]
    public string? RootSquash { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecForProviderSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecForProviderSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecForProviderSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecForProviderSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecForProviderSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecForProviderSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LustreFileSystemSpecForProviderSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecForProviderSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecForProviderSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderSecurityGroupIdSelector
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
    public V1beta2LustreFileSystemSpecForProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecForProviderSubnetIdRefsPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecForProviderSubnetIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecForProviderSubnetIdRefsPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecForProviderSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderSubnetIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecForProviderSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecForProviderSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LustreFileSystemSpecForProviderSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecForProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProviderSubnetIdSelector
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
    public V1beta2LustreFileSystemSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecForProvider
{
    /// <summary>How Amazon FSx keeps your file and directory listings up to date as you add or modify objects in your linked S3 bucket. see Auto Import Data Repo for more details. Only supported on PERSISTENT_1 deployment types.</summary>
    [JsonPropertyName("autoImportPolicy")]
    public string? AutoImportPolicy { get; set; }

    /// <summary>The number of days to retain automatic backups. Setting this to 0 disables automatic backups. You can retain automatic backups for a maximum of 90 days. only valid for PERSISTENT_1 and PERSISTENT_2 deployment_type.</summary>
    [JsonPropertyName("automaticBackupRetentionDays")]
    public double? AutomaticBackupRetentionDays { get; set; }

    /// <summary>The ID of the source backup to create the filesystem from.</summary>
    [JsonPropertyName("backupId")]
    public string? BackupId { get; set; }

    /// <summary>A boolean flag indicating whether tags for the file system should be copied to backups. Applicable for PERSISTENT_1 and PERSISTENT_2 deployment_type. The default value is false.</summary>
    [JsonPropertyName("copyTagsToBackups")]
    public bool? CopyTagsToBackups { get; set; }

    /// <summary>A recurring daily time, in the format HH:MM. HH is the zero-padded hour of the day (0-23), and MM is the zero-padded minute of the hour. For example, 05:00 specifies 5 AM daily. only valid for PERSISTENT_1 and PERSISTENT_2 deployment_type. Requires automatic_backup_retention_days to be set.</summary>
    [JsonPropertyName("dailyAutomaticBackupStartTime")]
    public string? DailyAutomaticBackupStartTime { get; set; }

    /// <summary>Sets the data compression configuration for the file system. Valid values are LZ4 and NONE. Default value is NONE. Unsetting this value reverts the compression type back to NONE.</summary>
    [JsonPropertyName("dataCompressionType")]
    public string? DataCompressionType { get; set; }

    [JsonPropertyName("dataReadCacheConfiguration")]
    public V1beta2LustreFileSystemSpecForProviderDataReadCacheConfiguration? DataReadCacheConfiguration { get; set; }

    /// <summary>- The filesystem deployment type. One of: SCRATCH_1, SCRATCH_2, PERSISTENT_1, PERSISTENT_2.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>- The type of drive cache used by PERSISTENT_1 filesystems that are provisioned with HDD storage_type. Required for HDD storage_type, set to either READ or NONE.</summary>
    [JsonPropertyName("driveCacheType")]
    public string? DriveCacheType { get; set; }

    /// <summary>Adds support for Elastic Fabric Adapter (EFA) and GPUDirect Storage (GDS) to Lustre. This must be set at creation. If set this cannot be changed and this prevents changes to per_unit_storage_throughput. This is only supported when deployment_type is set to PERSISTENT_2, metadata_configuration is used, and an EFA-enabled security group is attached.</summary>
    [JsonPropertyName("efaEnabled")]
    public bool? EfaEnabled { get; set; }

    /// <summary>S3 URI (with optional prefix) where the root of your Amazon FSx file system is exported. Can only be specified with import_path argument and the path must use the same Amazon S3 bucket as specified in import_path. Set equal to import_path to overwrite files on export. Defaults to s3://{IMPORT BUCKET}/FSxLustre{CREATION TIMESTAMP}. Only supported on PERSISTENT_1 deployment types.</summary>
    [JsonPropertyName("exportPath")]
    public string? ExportPath { get; set; }

    /// <summary>Sets the Lustre version for the file system that you&apos;re creating. Valid values are 2.10 for SCRATCH_1, SCRATCH_2 and PERSISTENT_1 deployment types. Valid values for 2.12 include all deployment types.</summary>
    [JsonPropertyName("fileSystemTypeVersion")]
    public string? FileSystemTypeVersion { get; set; }

    /// <summary>A map of tags to apply to the file system&apos;s final backup.</summary>
    [JsonPropertyName("finalBackupTags")]
    public IDictionary<string, string>? FinalBackupTags { get; set; }

    /// <summary>S3 URI (with optional prefix) that you&apos;re using as the data repository for your FSx for Lustre file system. For example, s3://example-bucket/optional-prefix/. Only supported on PERSISTENT_1 deployment types.</summary>
    [JsonPropertyName("importPath")]
    public string? ImportPath { get; set; }

    /// <summary>For files imported from a data repository, this value determines the stripe count and maximum amount of data per file (in MiB) stored on a single physical disk. Can only be specified with import_path argument. Defaults to 1024. Minimum of 1 and maximum of 512000. Only supported on PERSISTENT_1 deployment types.</summary>
    [JsonPropertyName("importedFileChunkSize")]
    public double? ImportedFileChunkSize { get; set; }

    /// <summary>ARN for the KMS Key to encrypt the file system at rest, applicable for PERSISTENT_1 and PERSISTENT_2 deployment_type. Defaults to an AWS managed KMS Key.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2LustreFileSystemSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2LustreFileSystemSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The Lustre logging configuration used when creating an Amazon FSx for Lustre file system. When logging is enabled, Lustre logs error and warning events for data repositories associated with your file system to Amazon CloudWatch Logs. See log_configuration Block for details.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta2LustreFileSystemSpecForProviderLogConfiguration? LogConfiguration { get; set; }

    /// <summary>The Lustre metadata configuration used when creating an Amazon FSx for Lustre file system. This can be used to specify a user provisioned metadata scale. This is only supported when deployment_type is set to PERSISTENT_2. See metadata_configuration Block for details.</summary>
    [JsonPropertyName("metadataConfiguration")]
    public V1beta2LustreFileSystemSpecForProviderMetadataConfiguration? MetadataConfiguration { get; set; }

    /// <summary>- Describes the amount of read and write throughput for each 1 tebibyte of storage, in MB/s/TiB, required for the PERSISTENT_1 and PERSISTENT_2 deployment_type. Valid values for PERSISTENT_1 deployment_type and SSD storage_type are 50, 100, 200. Valid values for PERSISTENT_1 deployment_type and HDD storage_type are 12, 40. Valid values for PERSISTENT_2 deployment_type and  SSD storage_type are 125, 250, 500, 1000.</summary>
    [JsonPropertyName("perUnitStorageThroughput")]
    public double? PerUnitStorageThroughput { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The Lustre root squash configuration used when creating an Amazon FSx for Lustre file system. When enabled, root squash restricts root-level access from clients that try to access your file system as a root user. See root_squash_configuration Block for details.</summary>
    [JsonPropertyName("rootSquashConfiguration")]
    public V1beta2LustreFileSystemSpecForProviderRootSquashConfiguration? RootSquashConfiguration { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta2LustreFileSystemSpecForProviderSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta2LustreFileSystemSpecForProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>When enabled, will skip the default final backup taken when the file system is deleted. This configuration must be applied separately before attempting to delete the resource to have the desired behavior. Defaults to true.</summary>
    [JsonPropertyName("skipFinalBackup")]
    public bool? SkipFinalBackup { get; set; }

    /// <summary>The storage capacity (GiB) of the file system. Minimum of 1200. See more details at Allowed values for Fsx storage capacity. Update is allowed only for SCRATCH_2, PERSISTENT_1 and PERSISTENT_2 deployment types, See more details at Fsx Storage Capacity Update. Required when not creating filesystem for a backup.</summary>
    [JsonPropertyName("storageCapacity")]
    public double? StorageCapacity { get; set; }

    /// <summary>- The filesystem storage type. One of SSD, HDD or INTELLIGENT_TIERING, defaults to SSD. HDD is only supported on PERSISTENT_1 deployment types. INTELLIGENT_TIERING requires data_read_cache_configuration and metadata_configuration to be set and is only supported for PERSISTENT_2 deployment types.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta2LustreFileSystemSpecForProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2LustreFileSystemSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A list of IDs for the subnets that the file system will be accessible from. File systems currently support only one subnet. The file server is also launched in that subnet&apos;s Availability Zone.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Throughput in MBps required for the INTELLIGENT_TIERING storage type. Must be 4000 or multiples of 4000.</summary>
    [JsonPropertyName("throughputCapacity")]
    public double? ThroughputCapacity { get; set; }

    /// <summary>The preferred start time (in d:HH:MM format) to perform weekly maintenance, in the UTC time zone.</summary>
    [JsonPropertyName("weeklyMaintenanceStartTime")]
    public string? WeeklyMaintenanceStartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderDataReadCacheConfiguration
{
    /// <summary>Size of the file system&apos;s SSD read cache, in gibibytes (GiB). Required when the sizing_mode is USER_PROVISIONED.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>Sizing mode for the cache. Valud values are NO_CACHE, USER_PROVISIONED, and PROPORTIONAL_TO_THROUGHPUT_CAPACITY.</summary>
    [JsonPropertyName("sizingMode")]
    public string? SizingMode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecInitProviderKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecInitProviderKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecInitProviderKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecInitProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecInitProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecInitProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LustreFileSystemSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderKmsKeyIdSelector
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
    public V1beta2LustreFileSystemSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The Lustre logging configuration used when creating an Amazon FSx for Lustre file system. When logging is enabled, Lustre logs error and warning events for data repositories associated with your file system to Amazon CloudWatch Logs. See log_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderLogConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) that specifies the destination of the logs. The name of the Amazon CloudWatch Logs log group must begin with the /aws/fsx prefix. If you do not provide a destination, Amazon FSx will create and use a log stream in the CloudWatch Logs /aws/fsx/lustre log group.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Sets which data repository events are logged by Amazon FSx. Valid values are WARN_ONLY, FAILURE_ONLY, ERROR_ONLY, WARN_ERROR and DISABLED. Default value is DISABLED.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }
}

/// <summary>The Lustre metadata configuration used when creating an Amazon FSx for Lustre file system. This can be used to specify a user provisioned metadata scale. This is only supported when deployment_type is set to PERSISTENT_2. See metadata_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderMetadataConfiguration
{
    /// <summary>Amount of IOPS provisioned for metadata. This parameter should only be used when the mode is set to USER_PROVISIONED. Valid Values are 1500,3000,6000 and 12000 through 192000 in increments of 12000. Valid values for INTELLIGENT_TIERING storage type are 6000 or 12000.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Mode for the metadata configuration of the file system. Valid values are AUTOMATIC, and USER_PROVISIONED. Must be set to USER_PROVISIONED for INTELLIGENT_TIERING storage type.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>The Lustre root squash configuration used when creating an Amazon FSx for Lustre file system. When enabled, root squash restricts root-level access from clients that try to access your file system as a root user. See root_squash_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderRootSquashConfiguration
{
    /// <summary>When root squash is enabled, you can optionally specify an array of NIDs of clients for which root squash does not apply. A client NID is a Lustre Network Identifier used to uniquely identify a client. You can specify the NID as either a single address or a range of addresses: 1. A single address is described in standard Lustre NID format by specifying the client’s IP address followed by the Lustre network ID (for example, 10.0.1.6@tcp). 2. An address range is described using a dash to separate the range (for example, 10.0.[2-10].[1-255]@tcp).</summary>
    [JsonPropertyName("noSquashNids")]
    public IList<string>? NoSquashNids { get; set; }

    /// <summary>You enable root squash by setting a user ID (UID) and group ID (GID) for the file system in the format UID:GID (for example, 365534:65534). The UID and GID values can range from 0 to 4294967294.</summary>
    [JsonPropertyName("rootSquash")]
    public string? RootSquash { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdSelector
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
    public V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecInitProviderSubnetIdRefsPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecInitProviderSubnetIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecInitProviderSubnetIdRefsPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecInitProviderSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderSubnetIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecInitProviderSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecInitProviderSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LustreFileSystemSpecInitProviderSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecInitProviderSubnetIdSelector
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
    public V1beta2LustreFileSystemSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2LustreFileSystemSpecInitProvider
{
    /// <summary>How Amazon FSx keeps your file and directory listings up to date as you add or modify objects in your linked S3 bucket. see Auto Import Data Repo for more details. Only supported on PERSISTENT_1 deployment types.</summary>
    [JsonPropertyName("autoImportPolicy")]
    public string? AutoImportPolicy { get; set; }

    /// <summary>The number of days to retain automatic backups. Setting this to 0 disables automatic backups. You can retain automatic backups for a maximum of 90 days. only valid for PERSISTENT_1 and PERSISTENT_2 deployment_type.</summary>
    [JsonPropertyName("automaticBackupRetentionDays")]
    public double? AutomaticBackupRetentionDays { get; set; }

    /// <summary>The ID of the source backup to create the filesystem from.</summary>
    [JsonPropertyName("backupId")]
    public string? BackupId { get; set; }

    /// <summary>A boolean flag indicating whether tags for the file system should be copied to backups. Applicable for PERSISTENT_1 and PERSISTENT_2 deployment_type. The default value is false.</summary>
    [JsonPropertyName("copyTagsToBackups")]
    public bool? CopyTagsToBackups { get; set; }

    /// <summary>A recurring daily time, in the format HH:MM. HH is the zero-padded hour of the day (0-23), and MM is the zero-padded minute of the hour. For example, 05:00 specifies 5 AM daily. only valid for PERSISTENT_1 and PERSISTENT_2 deployment_type. Requires automatic_backup_retention_days to be set.</summary>
    [JsonPropertyName("dailyAutomaticBackupStartTime")]
    public string? DailyAutomaticBackupStartTime { get; set; }

    /// <summary>Sets the data compression configuration for the file system. Valid values are LZ4 and NONE. Default value is NONE. Unsetting this value reverts the compression type back to NONE.</summary>
    [JsonPropertyName("dataCompressionType")]
    public string? DataCompressionType { get; set; }

    [JsonPropertyName("dataReadCacheConfiguration")]
    public V1beta2LustreFileSystemSpecInitProviderDataReadCacheConfiguration? DataReadCacheConfiguration { get; set; }

    /// <summary>- The filesystem deployment type. One of: SCRATCH_1, SCRATCH_2, PERSISTENT_1, PERSISTENT_2.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>- The type of drive cache used by PERSISTENT_1 filesystems that are provisioned with HDD storage_type. Required for HDD storage_type, set to either READ or NONE.</summary>
    [JsonPropertyName("driveCacheType")]
    public string? DriveCacheType { get; set; }

    /// <summary>Adds support for Elastic Fabric Adapter (EFA) and GPUDirect Storage (GDS) to Lustre. This must be set at creation. If set this cannot be changed and this prevents changes to per_unit_storage_throughput. This is only supported when deployment_type is set to PERSISTENT_2, metadata_configuration is used, and an EFA-enabled security group is attached.</summary>
    [JsonPropertyName("efaEnabled")]
    public bool? EfaEnabled { get; set; }

    /// <summary>S3 URI (with optional prefix) where the root of your Amazon FSx file system is exported. Can only be specified with import_path argument and the path must use the same Amazon S3 bucket as specified in import_path. Set equal to import_path to overwrite files on export. Defaults to s3://{IMPORT BUCKET}/FSxLustre{CREATION TIMESTAMP}. Only supported on PERSISTENT_1 deployment types.</summary>
    [JsonPropertyName("exportPath")]
    public string? ExportPath { get; set; }

    /// <summary>Sets the Lustre version for the file system that you&apos;re creating. Valid values are 2.10 for SCRATCH_1, SCRATCH_2 and PERSISTENT_1 deployment types. Valid values for 2.12 include all deployment types.</summary>
    [JsonPropertyName("fileSystemTypeVersion")]
    public string? FileSystemTypeVersion { get; set; }

    /// <summary>A map of tags to apply to the file system&apos;s final backup.</summary>
    [JsonPropertyName("finalBackupTags")]
    public IDictionary<string, string>? FinalBackupTags { get; set; }

    /// <summary>S3 URI (with optional prefix) that you&apos;re using as the data repository for your FSx for Lustre file system. For example, s3://example-bucket/optional-prefix/. Only supported on PERSISTENT_1 deployment types.</summary>
    [JsonPropertyName("importPath")]
    public string? ImportPath { get; set; }

    /// <summary>For files imported from a data repository, this value determines the stripe count and maximum amount of data per file (in MiB) stored on a single physical disk. Can only be specified with import_path argument. Defaults to 1024. Minimum of 1 and maximum of 512000. Only supported on PERSISTENT_1 deployment types.</summary>
    [JsonPropertyName("importedFileChunkSize")]
    public double? ImportedFileChunkSize { get; set; }

    /// <summary>ARN for the KMS Key to encrypt the file system at rest, applicable for PERSISTENT_1 and PERSISTENT_2 deployment_type. Defaults to an AWS managed KMS Key.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2LustreFileSystemSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2LustreFileSystemSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The Lustre logging configuration used when creating an Amazon FSx for Lustre file system. When logging is enabled, Lustre logs error and warning events for data repositories associated with your file system to Amazon CloudWatch Logs. See log_configuration Block for details.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta2LustreFileSystemSpecInitProviderLogConfiguration? LogConfiguration { get; set; }

    /// <summary>The Lustre metadata configuration used when creating an Amazon FSx for Lustre file system. This can be used to specify a user provisioned metadata scale. This is only supported when deployment_type is set to PERSISTENT_2. See metadata_configuration Block for details.</summary>
    [JsonPropertyName("metadataConfiguration")]
    public V1beta2LustreFileSystemSpecInitProviderMetadataConfiguration? MetadataConfiguration { get; set; }

    /// <summary>- Describes the amount of read and write throughput for each 1 tebibyte of storage, in MB/s/TiB, required for the PERSISTENT_1 and PERSISTENT_2 deployment_type. Valid values for PERSISTENT_1 deployment_type and SSD storage_type are 50, 100, 200. Valid values for PERSISTENT_1 deployment_type and HDD storage_type are 12, 40. Valid values for PERSISTENT_2 deployment_type and  SSD storage_type are 125, 250, 500, 1000.</summary>
    [JsonPropertyName("perUnitStorageThroughput")]
    public double? PerUnitStorageThroughput { get; set; }

    /// <summary>The Lustre root squash configuration used when creating an Amazon FSx for Lustre file system. When enabled, root squash restricts root-level access from clients that try to access your file system as a root user. See root_squash_configuration Block for details.</summary>
    [JsonPropertyName("rootSquashConfiguration")]
    public V1beta2LustreFileSystemSpecInitProviderRootSquashConfiguration? RootSquashConfiguration { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta2LustreFileSystemSpecInitProviderSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>When enabled, will skip the default final backup taken when the file system is deleted. This configuration must be applied separately before attempting to delete the resource to have the desired behavior. Defaults to true.</summary>
    [JsonPropertyName("skipFinalBackup")]
    public bool? SkipFinalBackup { get; set; }

    /// <summary>The storage capacity (GiB) of the file system. Minimum of 1200. See more details at Allowed values for Fsx storage capacity. Update is allowed only for SCRATCH_2, PERSISTENT_1 and PERSISTENT_2 deployment types, See more details at Fsx Storage Capacity Update. Required when not creating filesystem for a backup.</summary>
    [JsonPropertyName("storageCapacity")]
    public double? StorageCapacity { get; set; }

    /// <summary>- The filesystem storage type. One of SSD, HDD or INTELLIGENT_TIERING, defaults to SSD. HDD is only supported on PERSISTENT_1 deployment types. INTELLIGENT_TIERING requires data_read_cache_configuration and metadata_configuration to be set and is only supported for PERSISTENT_2 deployment types.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta2LustreFileSystemSpecInitProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2LustreFileSystemSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A list of IDs for the subnets that the file system will be accessible from. File systems currently support only one subnet. The file server is also launched in that subnet&apos;s Availability Zone.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Throughput in MBps required for the INTELLIGENT_TIERING storage type. Must be 4000 or multiples of 4000.</summary>
    [JsonPropertyName("throughputCapacity")]
    public double? ThroughputCapacity { get; set; }

    /// <summary>The preferred start time (in d:HH:MM format) to perform weekly maintenance, in the UTC time zone.</summary>
    [JsonPropertyName("weeklyMaintenanceStartTime")]
    public string? WeeklyMaintenanceStartTime { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecManagementPoliciesEnum>))]
public enum V1beta2LustreFileSystemSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2LustreFileSystemSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LustreFileSystemSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2LustreFileSystemSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LustreFileSystemSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LustreFileSystemSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LustreFileSystemSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>LustreFileSystemSpec defines the desired state of LustreFileSystem</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemSpec
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
    public V1beta2LustreFileSystemSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2LustreFileSystemSpecForProvider ForProvider { get; set; }

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
    public V1beta2LustreFileSystemSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2LustreFileSystemSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2LustreFileSystemSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2LustreFileSystemSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemStatusAtProviderDataReadCacheConfiguration
{
    /// <summary>Size of the file system&apos;s SSD read cache, in gibibytes (GiB). Required when the sizing_mode is USER_PROVISIONED.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>Sizing mode for the cache. Valud values are NO_CACHE, USER_PROVISIONED, and PROPORTIONAL_TO_THROUGHPUT_CAPACITY.</summary>
    [JsonPropertyName("sizingMode")]
    public string? SizingMode { get; set; }
}

/// <summary>The Lustre logging configuration used when creating an Amazon FSx for Lustre file system. When logging is enabled, Lustre logs error and warning events for data repositories associated with your file system to Amazon CloudWatch Logs. See log_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemStatusAtProviderLogConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) that specifies the destination of the logs. The name of the Amazon CloudWatch Logs log group must begin with the /aws/fsx prefix. If you do not provide a destination, Amazon FSx will create and use a log stream in the CloudWatch Logs /aws/fsx/lustre log group.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Sets which data repository events are logged by Amazon FSx. Valid values are WARN_ONLY, FAILURE_ONLY, ERROR_ONLY, WARN_ERROR and DISABLED. Default value is DISABLED.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }
}

/// <summary>The Lustre metadata configuration used when creating an Amazon FSx for Lustre file system. This can be used to specify a user provisioned metadata scale. This is only supported when deployment_type is set to PERSISTENT_2. See metadata_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemStatusAtProviderMetadataConfiguration
{
    /// <summary>Amount of IOPS provisioned for metadata. This parameter should only be used when the mode is set to USER_PROVISIONED. Valid Values are 1500,3000,6000 and 12000 through 192000 in increments of 12000. Valid values for INTELLIGENT_TIERING storage type are 6000 or 12000.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Mode for the metadata configuration of the file system. Valid values are AUTOMATIC, and USER_PROVISIONED. Must be set to USER_PROVISIONED for INTELLIGENT_TIERING storage type.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>The Lustre root squash configuration used when creating an Amazon FSx for Lustre file system. When enabled, root squash restricts root-level access from clients that try to access your file system as a root user. See root_squash_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemStatusAtProviderRootSquashConfiguration
{
    /// <summary>When root squash is enabled, you can optionally specify an array of NIDs of clients for which root squash does not apply. A client NID is a Lustre Network Identifier used to uniquely identify a client. You can specify the NID as either a single address or a range of addresses: 1. A single address is described in standard Lustre NID format by specifying the client’s IP address followed by the Lustre network ID (for example, 10.0.1.6@tcp). 2. An address range is described using a dash to separate the range (for example, 10.0.[2-10].[1-255]@tcp).</summary>
    [JsonPropertyName("noSquashNids")]
    public IList<string>? NoSquashNids { get; set; }

    /// <summary>You enable root squash by setting a user ID (UID) and group ID (GID) for the file system in the format UID:GID (for example, 365534:65534). The UID and GID values can range from 0 to 4294967294.</summary>
    [JsonPropertyName("rootSquash")]
    public string? RootSquash { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemStatusAtProvider
{
    /// <summary>Amazon Resource Name of the file system.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>How Amazon FSx keeps your file and directory listings up to date as you add or modify objects in your linked S3 bucket. see Auto Import Data Repo for more details. Only supported on PERSISTENT_1 deployment types.</summary>
    [JsonPropertyName("autoImportPolicy")]
    public string? AutoImportPolicy { get; set; }

    /// <summary>The number of days to retain automatic backups. Setting this to 0 disables automatic backups. You can retain automatic backups for a maximum of 90 days. only valid for PERSISTENT_1 and PERSISTENT_2 deployment_type.</summary>
    [JsonPropertyName("automaticBackupRetentionDays")]
    public double? AutomaticBackupRetentionDays { get; set; }

    /// <summary>The ID of the source backup to create the filesystem from.</summary>
    [JsonPropertyName("backupId")]
    public string? BackupId { get; set; }

    /// <summary>A boolean flag indicating whether tags for the file system should be copied to backups. Applicable for PERSISTENT_1 and PERSISTENT_2 deployment_type. The default value is false.</summary>
    [JsonPropertyName("copyTagsToBackups")]
    public bool? CopyTagsToBackups { get; set; }

    /// <summary>A recurring daily time, in the format HH:MM. HH is the zero-padded hour of the day (0-23), and MM is the zero-padded minute of the hour. For example, 05:00 specifies 5 AM daily. only valid for PERSISTENT_1 and PERSISTENT_2 deployment_type. Requires automatic_backup_retention_days to be set.</summary>
    [JsonPropertyName("dailyAutomaticBackupStartTime")]
    public string? DailyAutomaticBackupStartTime { get; set; }

    /// <summary>Sets the data compression configuration for the file system. Valid values are LZ4 and NONE. Default value is NONE. Unsetting this value reverts the compression type back to NONE.</summary>
    [JsonPropertyName("dataCompressionType")]
    public string? DataCompressionType { get; set; }

    [JsonPropertyName("dataReadCacheConfiguration")]
    public V1beta2LustreFileSystemStatusAtProviderDataReadCacheConfiguration? DataReadCacheConfiguration { get; set; }

    /// <summary>- The filesystem deployment type. One of: SCRATCH_1, SCRATCH_2, PERSISTENT_1, PERSISTENT_2.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>DNS name for the file system, e.g., fs-12345678.fsx.us-west-2.amazonaws.com</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>- The type of drive cache used by PERSISTENT_1 filesystems that are provisioned with HDD storage_type. Required for HDD storage_type, set to either READ or NONE.</summary>
    [JsonPropertyName("driveCacheType")]
    public string? DriveCacheType { get; set; }

    /// <summary>Adds support for Elastic Fabric Adapter (EFA) and GPUDirect Storage (GDS) to Lustre. This must be set at creation. If set this cannot be changed and this prevents changes to per_unit_storage_throughput. This is only supported when deployment_type is set to PERSISTENT_2, metadata_configuration is used, and an EFA-enabled security group is attached.</summary>
    [JsonPropertyName("efaEnabled")]
    public bool? EfaEnabled { get; set; }

    /// <summary>S3 URI (with optional prefix) where the root of your Amazon FSx file system is exported. Can only be specified with import_path argument and the path must use the same Amazon S3 bucket as specified in import_path. Set equal to import_path to overwrite files on export. Defaults to s3://{IMPORT BUCKET}/FSxLustre{CREATION TIMESTAMP}. Only supported on PERSISTENT_1 deployment types.</summary>
    [JsonPropertyName("exportPath")]
    public string? ExportPath { get; set; }

    /// <summary>Sets the Lustre version for the file system that you&apos;re creating. Valid values are 2.10 for SCRATCH_1, SCRATCH_2 and PERSISTENT_1 deployment types. Valid values for 2.12 include all deployment types.</summary>
    [JsonPropertyName("fileSystemTypeVersion")]
    public string? FileSystemTypeVersion { get; set; }

    /// <summary>A map of tags to apply to the file system&apos;s final backup.</summary>
    [JsonPropertyName("finalBackupTags")]
    public IDictionary<string, string>? FinalBackupTags { get; set; }

    /// <summary>Identifier of the file system, e.g., fs-12345678</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>S3 URI (with optional prefix) that you&apos;re using as the data repository for your FSx for Lustre file system. For example, s3://example-bucket/optional-prefix/. Only supported on PERSISTENT_1 deployment types.</summary>
    [JsonPropertyName("importPath")]
    public string? ImportPath { get; set; }

    /// <summary>For files imported from a data repository, this value determines the stripe count and maximum amount of data per file (in MiB) stored on a single physical disk. Can only be specified with import_path argument. Defaults to 1024. Minimum of 1 and maximum of 512000. Only supported on PERSISTENT_1 deployment types.</summary>
    [JsonPropertyName("importedFileChunkSize")]
    public double? ImportedFileChunkSize { get; set; }

    /// <summary>ARN for the KMS Key to encrypt the file system at rest, applicable for PERSISTENT_1 and PERSISTENT_2 deployment_type. Defaults to an AWS managed KMS Key.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The Lustre logging configuration used when creating an Amazon FSx for Lustre file system. When logging is enabled, Lustre logs error and warning events for data repositories associated with your file system to Amazon CloudWatch Logs. See log_configuration Block for details.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta2LustreFileSystemStatusAtProviderLogConfiguration? LogConfiguration { get; set; }

    /// <summary>The Lustre metadata configuration used when creating an Amazon FSx for Lustre file system. This can be used to specify a user provisioned metadata scale. This is only supported when deployment_type is set to PERSISTENT_2. See metadata_configuration Block for details.</summary>
    [JsonPropertyName("metadataConfiguration")]
    public V1beta2LustreFileSystemStatusAtProviderMetadataConfiguration? MetadataConfiguration { get; set; }

    /// <summary>The value to be used when mounting the filesystem.</summary>
    [JsonPropertyName("mountName")]
    public string? MountName { get; set; }

    /// <summary>Set of Elastic Network Interface identifiers from which the file system is accessible. As explained in the documentation, the first network interface returned is the primary network interface.</summary>
    [JsonPropertyName("networkInterfaceIds")]
    public IList<string>? NetworkInterfaceIds { get; set; }

    /// <summary>AWS account identifier that created the file system.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>- Describes the amount of read and write throughput for each 1 tebibyte of storage, in MB/s/TiB, required for the PERSISTENT_1 and PERSISTENT_2 deployment_type. Valid values for PERSISTENT_1 deployment_type and SSD storage_type are 50, 100, 200. Valid values for PERSISTENT_1 deployment_type and HDD storage_type are 12, 40. Valid values for PERSISTENT_2 deployment_type and  SSD storage_type are 125, 250, 500, 1000.</summary>
    [JsonPropertyName("perUnitStorageThroughput")]
    public double? PerUnitStorageThroughput { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The Lustre root squash configuration used when creating an Amazon FSx for Lustre file system. When enabled, root squash restricts root-level access from clients that try to access your file system as a root user. See root_squash_configuration Block for details.</summary>
    [JsonPropertyName("rootSquashConfiguration")]
    public V1beta2LustreFileSystemStatusAtProviderRootSquashConfiguration? RootSquashConfiguration { get; set; }

    /// <summary>A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>When enabled, will skip the default final backup taken when the file system is deleted. This configuration must be applied separately before attempting to delete the resource to have the desired behavior. Defaults to true.</summary>
    [JsonPropertyName("skipFinalBackup")]
    public bool? SkipFinalBackup { get; set; }

    /// <summary>The storage capacity (GiB) of the file system. Minimum of 1200. See more details at Allowed values for Fsx storage capacity. Update is allowed only for SCRATCH_2, PERSISTENT_1 and PERSISTENT_2 deployment types, See more details at Fsx Storage Capacity Update. Required when not creating filesystem for a backup.</summary>
    [JsonPropertyName("storageCapacity")]
    public double? StorageCapacity { get; set; }

    /// <summary>- The filesystem storage type. One of SSD, HDD or INTELLIGENT_TIERING, defaults to SSD. HDD is only supported on PERSISTENT_1 deployment types. INTELLIGENT_TIERING requires data_read_cache_configuration and metadata_configuration to be set and is only supported for PERSISTENT_2 deployment types.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>A list of IDs for the subnets that the file system will be accessible from. File systems currently support only one subnet. The file server is also launched in that subnet&apos;s Availability Zone.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput in MBps required for the INTELLIGENT_TIERING storage type. Must be 4000 or multiples of 4000.</summary>
    [JsonPropertyName("throughputCapacity")]
    public double? ThroughputCapacity { get; set; }

    /// <summary>Identifier of the Virtual Private Cloud for the file system.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>The preferred start time (in d:HH:MM format) to perform weekly maintenance, in the UTC time zone.</summary>
    [JsonPropertyName("weeklyMaintenanceStartTime")]
    public string? WeeklyMaintenanceStartTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemStatusConditions
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

/// <summary>LustreFileSystemStatus defines the observed state of LustreFileSystem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LustreFileSystemStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2LustreFileSystemStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2LustreFileSystemStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LustreFileSystem is the Schema for the LustreFileSystems API. Manages a FSx Lustre File System.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LustreFileSystem : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2LustreFileSystemSpec>, IStatus<V1beta2LustreFileSystemStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LustreFileSystem";
    public const string KubeGroup = "fsx.aws.upbound.io";
    public const string KubePluralName = "lustrefilesystems";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "fsx.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LustreFileSystem";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LustreFileSystemSpec defines the desired state of LustreFileSystem</summary>
    [JsonPropertyName("spec")]
    public required V1beta2LustreFileSystemSpec Spec { get; set; }

    /// <summary>LustreFileSystemStatus defines the observed state of LustreFileSystem.</summary>
    [JsonPropertyName("status")]
    public V1beta2LustreFileSystemStatus? Status { get; set; }
}