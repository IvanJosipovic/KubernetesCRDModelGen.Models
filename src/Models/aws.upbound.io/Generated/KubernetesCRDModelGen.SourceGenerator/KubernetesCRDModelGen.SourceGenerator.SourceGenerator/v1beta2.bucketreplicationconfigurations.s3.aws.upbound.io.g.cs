#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.upbound.io;
/// <summary>BucketReplicationConfiguration is the Schema for the BucketReplicationConfigurations API. Provides a S3 bucket replication configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BucketReplicationConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2BucketReplicationConfiguration>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BucketReplicationConfigurationList";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "bucketreplicationconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "s3.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BucketReplicationConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2BucketReplicationConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2BucketReplicationConfiguration> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecDeletionPolicyEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderBucketRefPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderBucketRefPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecForProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecForProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketReplicationConfigurationSpecForProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderBucketSelectorPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderBucketSelectorPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecForProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecForProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderBucketSelector
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
    public V1beta2BucketReplicationConfigurationSpecForProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderRoleRefPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderRoleRefPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderRoleSelectorPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderRoleSelectorPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRoleSelector
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
    public V1beta2BucketReplicationConfigurationSpecForProviderRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Whether delete markers are replicated. This argument is only valid with V2 replication configurations (i.e., when filter is used)documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDeleteMarkerReplication
{
    /// <summary>Whether delete markers should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block that specifies the overrides to use for object owners on replication. See below. Specify this only in a cross-account scenario (where source and destination bucket owners are not the same), and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not specified in the replication configuration, the replicas are owned by same AWS account that owns the source object. Must be used in conjunction with account owner override configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationAccessControlTranslation
{
    /// <summary>Specifies the replica ownership. For default and valid values, see PUT bucket replication in the Amazon S3 API Reference. Valid values: Destination.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelector
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
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate replicaKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate replicaKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelector
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
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block that provides information about encryption. See below. If source_selection_criteria is specified, you must specify this element.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfiguration
{
    /// <summary>ID (Key ARN or Alias ARN) of the customer managed AWS KMS key stored in AWS Key Management Service (KMS) for the destination bucket.</summary>
    [JsonPropertyName("replicaKmsKeyId")]
    public string? ReplicaKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate replicaKmsKeyId.</summary>
    [JsonPropertyName("replicaKmsKeyIdRef")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRef? ReplicaKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate replicaKmsKeyId.</summary>
    [JsonPropertyName("replicaKmsKeyIdSelector")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelector? ReplicaKmsKeyIdSelector { get; set; }
}

/// <summary>Configuration block that specifies the time threshold for emitting the s3:Replication:OperationMissedThreshold event. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationMetricsEventThreshold
{
    /// <summary>Time in minutes. Valid values: 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>Configuration block that specifies replication metrics-related settings enabling replication metrics and events. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationMetrics
{
    /// <summary>Configuration block that specifies the time threshold for emitting the s3:Replication:OperationMissedThreshold event. See below.</summary>
    [JsonPropertyName("eventThreshold")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationMetricsEventThreshold? EventThreshold { get; set; }

    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block specifying the time by which replication should be complete for all objects and operations on objects. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationReplicationTimeTime
{
    /// <summary>Time in minutes. Valid values: 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>Configuration block that specifies S3 Replication Time Control (S3 RTC), including whether S3 RTC is enabled and the time when all objects and operations on objects must be replicated. See below. Replication Time Control must be used in conjunction with metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationReplicationTime
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Configuration block specifying the time by which replication should be complete for all objects and operations on objects. See below.</summary>
    [JsonPropertyName("time")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationReplicationTimeTime? Time { get; set; }
}

/// <summary>Specifies the destination for the rule. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleDestination
{
    /// <summary>Configuration block that specifies the overrides to use for object owners on replication. See below. Specify this only in a cross-account scenario (where source and destination bucket owners are not the same), and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not specified in the replication configuration, the replicas are owned by same AWS account that owns the source object. Must be used in conjunction with account owner override configuration.</summary>
    [JsonPropertyName("accessControlTranslation")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationAccessControlTranslation? AccessControlTranslation { get; set; }

    /// <summary>Account ID to specify the replica ownership. Must be used in conjunction with access_control_translation override configuration.</summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>ARN of the bucket where you want Amazon S3 to store the results.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelector? BucketSelector { get; set; }

    /// <summary>Configuration block that provides information about encryption. See below. If source_selection_criteria is specified, you must specify this element.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Configuration block that specifies replication metrics-related settings enabling replication metrics and events. See below.</summary>
    [JsonPropertyName("metrics")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationMetrics? Metrics { get; set; }

    /// <summary>Configuration block that specifies S3 Replication Time Control (S3 RTC), including whether S3 RTC is enabled and the time when all objects and operations on objects must be replicated. See below. Replication Time Control must be used in conjunction with metrics.</summary>
    [JsonPropertyName("replicationTime")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestinationReplicationTime? ReplicationTime { get; set; }

    /// <summary>The storage class used to store the object. By default, Amazon S3 uses the storage class of the source object to create the object replica.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary>Replicate existing objects in the source bucket according to the rule configurations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleExistingObjectReplication
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for specifying rule filters. This element is required only if you specify more than one filter. See and below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleFilterAnd
{
    /// <summary>Object key name prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length. Defaults to an empty string (&quot; &quot;) if filter is not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Map of tags (key and value pairs) that identifies a subset of objects to which the rule applies. The rule applies only to objects having all the tags in its tagset.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Configuration block for specifying a tag key and value. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleFilterTag
{
    /// <summary>Name of the object key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value of the tag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Filter that identifies subset of objects to which the replication rule applies. See below. If not specified, the rule will default to using prefix.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleFilter
{
    /// <summary>Configuration block for specifying rule filters. This element is required only if you specify more than one filter. See and below for more details.</summary>
    [JsonPropertyName("and")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleFilterAnd? And { get; set; }

    /// <summary>Object key name prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length. Defaults to an empty string (&quot; &quot;) if filter is not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Configuration block for specifying a tag key and value. See below.</summary>
    [JsonPropertyName("tag")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleFilterTag? Tag { get; set; }
}

/// <summary>Configuration block that you can specify for selections for modifications on replicas. Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest version of replication configuration (when filter is specified), you can specify this element and set the status to Enabled to replicate modifications on replicas.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleSourceSelectionCriteriaReplicaModifications
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If specified, replica_kms_key_id in destination encryption_configuration must be specified as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleSourceSelectionCriteriaSseKmsEncryptedObjects
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Specifies special object selection criteria. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRuleSourceSelectionCriteria
{
    /// <summary>Configuration block that you can specify for selections for modifications on replicas. Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest version of replication configuration (when filter is specified), you can specify this element and set the status to Enabled to replicate modifications on replicas.</summary>
    [JsonPropertyName("replicaModifications")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleSourceSelectionCriteriaReplicaModifications? ReplicaModifications { get; set; }

    /// <summary>Configuration block for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If specified, replica_kms_key_id in destination encryption_configuration must be specified as well.</summary>
    [JsonPropertyName("sseKmsEncryptedObjects")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderRule
{
    /// <summary>Whether delete markers are replicated. This argument is only valid with V2 replication configurations (i.e., when filter is used)documented below.</summary>
    [JsonPropertyName("deleteMarkerReplication")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDeleteMarkerReplication? DeleteMarkerReplication { get; set; }

    /// <summary>Specifies the destination for the rule. See below.</summary>
    [JsonPropertyName("destination")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleDestination? Destination { get; set; }

    /// <summary>Replicate existing objects in the source bucket according to the rule configurations. See below.</summary>
    [JsonPropertyName("existingObjectReplication")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleExistingObjectReplication? ExistingObjectReplication { get; set; }

    /// <summary>Filter that identifies subset of objects to which the replication rule applies. See below. If not specified, the rule will default to using prefix.</summary>
    [JsonPropertyName("filter")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleFilter? Filter { get; set; }

    /// <summary>Unique identifier for the rule. Must be less than or equal to 255 characters in length.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Object key name prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length. Defaults to an empty string (&quot; &quot;) if filter is not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Priority associated with the rule. Priority should only be set if filter is configured. If not provided, defaults to 0. Priority must be unique between multiple rules.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies special object selection criteria. See below.</summary>
    [JsonPropertyName("sourceSelectionCriteria")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRuleSourceSelectionCriteria? SourceSelectionCriteria { get; set; }

    /// <summary>Status of the rule. Either &quot;Enabled&quot; or &quot;Disabled&quot;. The rule is ignored if status is not &quot;Enabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Token to allow replication to be enabled on an Object Lock-enabled bucket. You must contact AWS support for the bucket&apos;s &quot;Object Lock token&quot;.
/// For more details, see Using S3 Object Lock with replication.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProviderTokenSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecForProvider
{
    /// <summary>Name of the source S3 bucket you want Amazon S3 to monitor.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2BucketReplicationConfigurationSpecForProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2BucketReplicationConfigurationSpecForProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>ARN of the IAM role for Amazon S3 to assume when replicating the objects.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Reference to a Role in iam to populate role.</summary>
    [JsonPropertyName("roleRef")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRoleRef? RoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate role.</summary>
    [JsonPropertyName("roleSelector")]
    public V1beta2BucketReplicationConfigurationSpecForProviderRoleSelector? RoleSelector { get; set; }

    /// <summary>List of configuration blocks describing the rules managing the replication. See below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2BucketReplicationConfigurationSpecForProviderRule>? Rule { get; set; }

    /// <summary>
    /// Token to allow replication to be enabled on an Object Lock-enabled bucket. You must contact AWS support for the bucket&apos;s &quot;Object Lock token&quot;.
    /// For more details, see Using S3 Object Lock with replication.
    /// </summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1beta2BucketReplicationConfigurationSpecForProviderTokenSecretRef? TokenSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderBucketRefPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderBucketRefPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderBucketSelector
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
    public V1beta2BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderRoleRefPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderRoleRefPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRoleSelector
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
    public V1beta2BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Whether delete markers are replicated. This argument is only valid with V2 replication configurations (i.e., when filter is used)documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDeleteMarkerReplication
{
    /// <summary>Whether delete markers should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block that specifies the overrides to use for object owners on replication. See below. Specify this only in a cross-account scenario (where source and destination bucket owners are not the same), and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not specified in the replication configuration, the replicas are owned by same AWS account that owns the source object. Must be used in conjunction with account owner override configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationAccessControlTranslation
{
    /// <summary>Specifies the replica ownership. For default and valid values, see PUT bucket replication in the Amazon S3 API Reference. Valid values: Destination.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelector
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
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate replicaKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate replicaKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelector
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
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block that provides information about encryption. See below. If source_selection_criteria is specified, you must specify this element.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfiguration
{
    /// <summary>ID (Key ARN or Alias ARN) of the customer managed AWS KMS key stored in AWS Key Management Service (KMS) for the destination bucket.</summary>
    [JsonPropertyName("replicaKmsKeyId")]
    public string? ReplicaKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate replicaKmsKeyId.</summary>
    [JsonPropertyName("replicaKmsKeyIdRef")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRef? ReplicaKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate replicaKmsKeyId.</summary>
    [JsonPropertyName("replicaKmsKeyIdSelector")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelector? ReplicaKmsKeyIdSelector { get; set; }
}

/// <summary>Configuration block that specifies the time threshold for emitting the s3:Replication:OperationMissedThreshold event. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationMetricsEventThreshold
{
    /// <summary>Time in minutes. Valid values: 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>Configuration block that specifies replication metrics-related settings enabling replication metrics and events. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationMetrics
{
    /// <summary>Configuration block that specifies the time threshold for emitting the s3:Replication:OperationMissedThreshold event. See below.</summary>
    [JsonPropertyName("eventThreshold")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationMetricsEventThreshold? EventThreshold { get; set; }

    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block specifying the time by which replication should be complete for all objects and operations on objects. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationReplicationTimeTime
{
    /// <summary>Time in minutes. Valid values: 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>Configuration block that specifies S3 Replication Time Control (S3 RTC), including whether S3 RTC is enabled and the time when all objects and operations on objects must be replicated. See below. Replication Time Control must be used in conjunction with metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationReplicationTime
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Configuration block specifying the time by which replication should be complete for all objects and operations on objects. See below.</summary>
    [JsonPropertyName("time")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationReplicationTimeTime? Time { get; set; }
}

/// <summary>Specifies the destination for the rule. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestination
{
    /// <summary>Configuration block that specifies the overrides to use for object owners on replication. See below. Specify this only in a cross-account scenario (where source and destination bucket owners are not the same), and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not specified in the replication configuration, the replicas are owned by same AWS account that owns the source object. Must be used in conjunction with account owner override configuration.</summary>
    [JsonPropertyName("accessControlTranslation")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationAccessControlTranslation? AccessControlTranslation { get; set; }

    /// <summary>Account ID to specify the replica ownership. Must be used in conjunction with access_control_translation override configuration.</summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>ARN of the bucket where you want Amazon S3 to store the results.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelector? BucketSelector { get; set; }

    /// <summary>Configuration block that provides information about encryption. See below. If source_selection_criteria is specified, you must specify this element.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Configuration block that specifies replication metrics-related settings enabling replication metrics and events. See below.</summary>
    [JsonPropertyName("metrics")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationMetrics? Metrics { get; set; }

    /// <summary>Configuration block that specifies S3 Replication Time Control (S3 RTC), including whether S3 RTC is enabled and the time when all objects and operations on objects must be replicated. See below. Replication Time Control must be used in conjunction with metrics.</summary>
    [JsonPropertyName("replicationTime")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestinationReplicationTime? ReplicationTime { get; set; }

    /// <summary>The storage class used to store the object. By default, Amazon S3 uses the storage class of the source object to create the object replica.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary>Replicate existing objects in the source bucket according to the rule configurations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleExistingObjectReplication
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for specifying rule filters. This element is required only if you specify more than one filter. See and below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleFilterAnd
{
    /// <summary>Object key name prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length. Defaults to an empty string (&quot; &quot;) if filter is not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Map of tags (key and value pairs) that identifies a subset of objects to which the rule applies. The rule applies only to objects having all the tags in its tagset.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Configuration block for specifying a tag key and value. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleFilterTag
{
    /// <summary>Name of the object key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value of the tag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Filter that identifies subset of objects to which the replication rule applies. See below. If not specified, the rule will default to using prefix.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleFilter
{
    /// <summary>Configuration block for specifying rule filters. This element is required only if you specify more than one filter. See and below for more details.</summary>
    [JsonPropertyName("and")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleFilterAnd? And { get; set; }

    /// <summary>Object key name prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length. Defaults to an empty string (&quot; &quot;) if filter is not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Configuration block for specifying a tag key and value. See below.</summary>
    [JsonPropertyName("tag")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleFilterTag? Tag { get; set; }
}

/// <summary>Configuration block that you can specify for selections for modifications on replicas. Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest version of replication configuration (when filter is specified), you can specify this element and set the status to Enabled to replicate modifications on replicas.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleSourceSelectionCriteriaReplicaModifications
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If specified, replica_kms_key_id in destination encryption_configuration must be specified as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleSourceSelectionCriteriaSseKmsEncryptedObjects
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Specifies special object selection criteria. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRuleSourceSelectionCriteria
{
    /// <summary>Configuration block that you can specify for selections for modifications on replicas. Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest version of replication configuration (when filter is specified), you can specify this element and set the status to Enabled to replicate modifications on replicas.</summary>
    [JsonPropertyName("replicaModifications")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleSourceSelectionCriteriaReplicaModifications? ReplicaModifications { get; set; }

    /// <summary>Configuration block for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If specified, replica_kms_key_id in destination encryption_configuration must be specified as well.</summary>
    [JsonPropertyName("sseKmsEncryptedObjects")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderRule
{
    /// <summary>Whether delete markers are replicated. This argument is only valid with V2 replication configurations (i.e., when filter is used)documented below.</summary>
    [JsonPropertyName("deleteMarkerReplication")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDeleteMarkerReplication? DeleteMarkerReplication { get; set; }

    /// <summary>Specifies the destination for the rule. See below.</summary>
    [JsonPropertyName("destination")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleDestination? Destination { get; set; }

    /// <summary>Replicate existing objects in the source bucket according to the rule configurations. See below.</summary>
    [JsonPropertyName("existingObjectReplication")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleExistingObjectReplication? ExistingObjectReplication { get; set; }

    /// <summary>Filter that identifies subset of objects to which the replication rule applies. See below. If not specified, the rule will default to using prefix.</summary>
    [JsonPropertyName("filter")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleFilter? Filter { get; set; }

    /// <summary>Unique identifier for the rule. Must be less than or equal to 255 characters in length.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Object key name prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length. Defaults to an empty string (&quot; &quot;) if filter is not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Priority associated with the rule. Priority should only be set if filter is configured. If not provided, defaults to 0. Priority must be unique between multiple rules.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies special object selection criteria. See below.</summary>
    [JsonPropertyName("sourceSelectionCriteria")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRuleSourceSelectionCriteria? SourceSelectionCriteria { get; set; }

    /// <summary>Status of the rule. Either &quot;Enabled&quot; or &quot;Disabled&quot;. The rule is ignored if status is not &quot;Enabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Token to allow replication to be enabled on an Object Lock-enabled bucket. You must contact AWS support for the bucket&apos;s &quot;Object Lock token&quot;.
/// For more details, see Using S3 Object Lock with replication.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecInitProviderTokenSecretRef
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
public partial class V1beta2BucketReplicationConfigurationSpecInitProvider
{
    /// <summary>Name of the source S3 bucket you want Amazon S3 to monitor.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>ARN of the IAM role for Amazon S3 to assume when replicating the objects.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Reference to a Role in iam to populate role.</summary>
    [JsonPropertyName("roleRef")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRoleRef? RoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate role.</summary>
    [JsonPropertyName("roleSelector")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderRoleSelector? RoleSelector { get; set; }

    /// <summary>List of configuration blocks describing the rules managing the replication. See below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2BucketReplicationConfigurationSpecInitProviderRule>? Rule { get; set; }

    /// <summary>
    /// Token to allow replication to be enabled on an Object Lock-enabled bucket. You must contact AWS support for the bucket&apos;s &quot;Object Lock token&quot;.
    /// For more details, see Using S3 Object Lock with replication.
    /// </summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1beta2BucketReplicationConfigurationSpecInitProviderTokenSecretRef? TokenSecretRef { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecManagementPoliciesEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketReplicationConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2BucketReplicationConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketReplicationConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketReplicationConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketReplicationConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>BucketReplicationConfigurationSpec defines the desired state of BucketReplicationConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationSpec
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
    public V1beta2BucketReplicationConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2BucketReplicationConfigurationSpecForProvider ForProvider { get; set; }

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
    public V1beta2BucketReplicationConfigurationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2BucketReplicationConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2BucketReplicationConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2BucketReplicationConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Whether delete markers are replicated. This argument is only valid with V2 replication configurations (i.e., when filter is used)documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleDeleteMarkerReplication
{
    /// <summary>Whether delete markers should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block that specifies the overrides to use for object owners on replication. See below. Specify this only in a cross-account scenario (where source and destination bucket owners are not the same), and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not specified in the replication configuration, the replicas are owned by same AWS account that owns the source object. Must be used in conjunction with account owner override configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestinationAccessControlTranslation
{
    /// <summary>Specifies the replica ownership. For default and valid values, see PUT bucket replication in the Amazon S3 API Reference. Valid values: Destination.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }
}

/// <summary>Configuration block that provides information about encryption. See below. If source_selection_criteria is specified, you must specify this element.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestinationEncryptionConfiguration
{
    /// <summary>ID (Key ARN or Alias ARN) of the customer managed AWS KMS key stored in AWS Key Management Service (KMS) for the destination bucket.</summary>
    [JsonPropertyName("replicaKmsKeyId")]
    public string? ReplicaKmsKeyId { get; set; }
}

/// <summary>Configuration block that specifies the time threshold for emitting the s3:Replication:OperationMissedThreshold event. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestinationMetricsEventThreshold
{
    /// <summary>Time in minutes. Valid values: 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>Configuration block that specifies replication metrics-related settings enabling replication metrics and events. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestinationMetrics
{
    /// <summary>Configuration block that specifies the time threshold for emitting the s3:Replication:OperationMissedThreshold event. See below.</summary>
    [JsonPropertyName("eventThreshold")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestinationMetricsEventThreshold? EventThreshold { get; set; }

    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block specifying the time by which replication should be complete for all objects and operations on objects. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestinationReplicationTimeTime
{
    /// <summary>Time in minutes. Valid values: 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>Configuration block that specifies S3 Replication Time Control (S3 RTC), including whether S3 RTC is enabled and the time when all objects and operations on objects must be replicated. See below. Replication Time Control must be used in conjunction with metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestinationReplicationTime
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Configuration block specifying the time by which replication should be complete for all objects and operations on objects. See below.</summary>
    [JsonPropertyName("time")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestinationReplicationTimeTime? Time { get; set; }
}

/// <summary>Specifies the destination for the rule. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestination
{
    /// <summary>Configuration block that specifies the overrides to use for object owners on replication. See below. Specify this only in a cross-account scenario (where source and destination bucket owners are not the same), and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not specified in the replication configuration, the replicas are owned by same AWS account that owns the source object. Must be used in conjunction with account owner override configuration.</summary>
    [JsonPropertyName("accessControlTranslation")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestinationAccessControlTranslation? AccessControlTranslation { get; set; }

    /// <summary>Account ID to specify the replica ownership. Must be used in conjunction with access_control_translation override configuration.</summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>ARN of the bucket where you want Amazon S3 to store the results.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Configuration block that provides information about encryption. See below. If source_selection_criteria is specified, you must specify this element.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestinationEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Configuration block that specifies replication metrics-related settings enabling replication metrics and events. See below.</summary>
    [JsonPropertyName("metrics")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestinationMetrics? Metrics { get; set; }

    /// <summary>Configuration block that specifies S3 Replication Time Control (S3 RTC), including whether S3 RTC is enabled and the time when all objects and operations on objects must be replicated. See below. Replication Time Control must be used in conjunction with metrics.</summary>
    [JsonPropertyName("replicationTime")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestinationReplicationTime? ReplicationTime { get; set; }

    /// <summary>The storage class used to store the object. By default, Amazon S3 uses the storage class of the source object to create the object replica.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary>Replicate existing objects in the source bucket according to the rule configurations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleExistingObjectReplication
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for specifying rule filters. This element is required only if you specify more than one filter. See and below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleFilterAnd
{
    /// <summary>Object key name prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length. Defaults to an empty string (&quot; &quot;) if filter is not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Map of tags (key and value pairs) that identifies a subset of objects to which the rule applies. The rule applies only to objects having all the tags in its tagset.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Configuration block for specifying a tag key and value. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleFilterTag
{
    /// <summary>Name of the object key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value of the tag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Filter that identifies subset of objects to which the replication rule applies. See below. If not specified, the rule will default to using prefix.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleFilter
{
    /// <summary>Configuration block for specifying rule filters. This element is required only if you specify more than one filter. See and below for more details.</summary>
    [JsonPropertyName("and")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleFilterAnd? And { get; set; }

    /// <summary>Object key name prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length. Defaults to an empty string (&quot; &quot;) if filter is not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Configuration block for specifying a tag key and value. See below.</summary>
    [JsonPropertyName("tag")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleFilterTag? Tag { get; set; }
}

/// <summary>Configuration block that you can specify for selections for modifications on replicas. Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest version of replication configuration (when filter is specified), you can specify this element and set the status to Enabled to replicate modifications on replicas.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleSourceSelectionCriteriaReplicaModifications
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If specified, replica_kms_key_id in destination encryption_configuration must be specified as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleSourceSelectionCriteriaSseKmsEncryptedObjects
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Specifies special object selection criteria. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRuleSourceSelectionCriteria
{
    /// <summary>Configuration block that you can specify for selections for modifications on replicas. Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest version of replication configuration (when filter is specified), you can specify this element and set the status to Enabled to replicate modifications on replicas.</summary>
    [JsonPropertyName("replicaModifications")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleSourceSelectionCriteriaReplicaModifications? ReplicaModifications { get; set; }

    /// <summary>Configuration block for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If specified, replica_kms_key_id in destination encryption_configuration must be specified as well.</summary>
    [JsonPropertyName("sseKmsEncryptedObjects")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProviderRule
{
    /// <summary>Whether delete markers are replicated. This argument is only valid with V2 replication configurations (i.e., when filter is used)documented below.</summary>
    [JsonPropertyName("deleteMarkerReplication")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleDeleteMarkerReplication? DeleteMarkerReplication { get; set; }

    /// <summary>Specifies the destination for the rule. See below.</summary>
    [JsonPropertyName("destination")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleDestination? Destination { get; set; }

    /// <summary>Replicate existing objects in the source bucket according to the rule configurations. See below.</summary>
    [JsonPropertyName("existingObjectReplication")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleExistingObjectReplication? ExistingObjectReplication { get; set; }

    /// <summary>Filter that identifies subset of objects to which the replication rule applies. See below. If not specified, the rule will default to using prefix.</summary>
    [JsonPropertyName("filter")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleFilter? Filter { get; set; }

    /// <summary>Unique identifier for the rule. Must be less than or equal to 255 characters in length.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Object key name prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length. Defaults to an empty string (&quot; &quot;) if filter is not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Priority associated with the rule. Priority should only be set if filter is configured. If not provided, defaults to 0. Priority must be unique between multiple rules.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies special object selection criteria. See below.</summary>
    [JsonPropertyName("sourceSelectionCriteria")]
    public V1beta2BucketReplicationConfigurationStatusAtProviderRuleSourceSelectionCriteria? SourceSelectionCriteria { get; set; }

    /// <summary>Status of the rule. Either &quot;Enabled&quot; or &quot;Disabled&quot;. The rule is ignored if status is not &quot;Enabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusAtProvider
{
    /// <summary>Name of the source S3 bucket you want Amazon S3 to monitor.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>S3 source bucket name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ARN of the IAM role for Amazon S3 to assume when replicating the objects.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>List of configuration blocks describing the rules managing the replication. See below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2BucketReplicationConfigurationStatusAtProviderRule>? Rule { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatusConditions
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

/// <summary>BucketReplicationConfigurationStatus defines the observed state of BucketReplicationConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketReplicationConfigurationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2BucketReplicationConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2BucketReplicationConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BucketReplicationConfiguration is the Schema for the BucketReplicationConfigurations API. Provides a S3 bucket replication configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BucketReplicationConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BucketReplicationConfigurationSpec>, IStatus<V1beta2BucketReplicationConfigurationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BucketReplicationConfiguration";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "bucketreplicationconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "s3.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BucketReplicationConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketReplicationConfigurationSpec defines the desired state of BucketReplicationConfiguration</summary>
    [JsonPropertyName("spec")]
    public required V1beta2BucketReplicationConfigurationSpec Spec { get; set; }

    /// <summary>BucketReplicationConfigurationStatus defines the observed state of BucketReplicationConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta2BucketReplicationConfigurationStatus? Status { get; set; }
}