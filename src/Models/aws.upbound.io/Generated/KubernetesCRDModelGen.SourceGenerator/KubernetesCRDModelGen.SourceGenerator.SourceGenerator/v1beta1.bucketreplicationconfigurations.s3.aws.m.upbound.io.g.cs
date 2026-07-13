#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.m.upbound.io;
/// <summary>BucketReplicationConfiguration is the Schema for the BucketReplicationConfigurations API. Provides a S3 bucket replication configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BucketReplicationConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BucketReplicationConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketReplicationConfigurationList";
    public const string KubeGroup = "s3.aws.m.upbound.io";
    public const string KubePluralName = "bucketreplicationconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "s3.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BucketReplicationConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1BucketReplicationConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1BucketReplicationConfiguration> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderBucketRefPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderBucketRefPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecForProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecForProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecForProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderBucketSelectorPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderBucketSelectorPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecForProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecForProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderBucketSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecForProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderRoleRefPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderRoleRefPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderRoleSelectorPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderRoleSelectorPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRoleSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Whether delete markers are replicated. This argument is only valid with V2 replication configurations (i.e., when filter is used)documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDeleteMarkerReplication
{
    /// <summary>Whether delete markers should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block that specifies the overrides to use for object owners on replication. See below. Specify this only in a cross-account scenario (where source and destination bucket owners are not the same), and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not specified in the replication configuration, the replicas are owned by same AWS account that owns the source object. Must be used in conjunction with account owner override configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationAccessControlTranslation
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate replicaKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate replicaKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block that provides information about encryption. See below. If source_selection_criteria is specified, you must specify this element.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfiguration
{
    /// <summary>ID (Key ARN or Alias ARN) of the customer managed AWS KMS key stored in AWS Key Management Service (KMS) for the destination bucket.</summary>
    [JsonPropertyName("replicaKmsKeyId")]
    public string? ReplicaKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate replicaKmsKeyId.</summary>
    [JsonPropertyName("replicaKmsKeyIdRef")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRef? ReplicaKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate replicaKmsKeyId.</summary>
    [JsonPropertyName("replicaKmsKeyIdSelector")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelector? ReplicaKmsKeyIdSelector { get; set; }
}

/// <summary>Configuration block that specifies the time threshold for emitting the s3:Replication:OperationMissedThreshold event. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationMetricsEventThreshold
{
    /// <summary>Time in minutes. Valid values: 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>Configuration block that specifies replication metrics-related settings enabling replication metrics and events. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationMetrics
{
    /// <summary>Configuration block that specifies the time threshold for emitting the s3:Replication:OperationMissedThreshold event. See below.</summary>
    [JsonPropertyName("eventThreshold")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationMetricsEventThreshold? EventThreshold { get; set; }

    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block specifying the time by which replication should be complete for all objects and operations on objects. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationReplicationTimeTime
{
    /// <summary>Time in minutes. Valid values: 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>Configuration block that specifies S3 Replication Time Control (S3 RTC), including whether S3 RTC is enabled and the time when all objects and operations on objects must be replicated. See below. Replication Time Control must be used in conjunction with metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationReplicationTime
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Configuration block specifying the time by which replication should be complete for all objects and operations on objects. See below.</summary>
    [JsonPropertyName("time")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationReplicationTimeTime? Time { get; set; }
}

/// <summary>Specifies the destination for the rule. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleDestination
{
    /// <summary>Configuration block that specifies the overrides to use for object owners on replication. See below. Specify this only in a cross-account scenario (where source and destination bucket owners are not the same), and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not specified in the replication configuration, the replicas are owned by same AWS account that owns the source object. Must be used in conjunction with account owner override configuration.</summary>
    [JsonPropertyName("accessControlTranslation")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationAccessControlTranslation? AccessControlTranslation { get; set; }

    /// <summary>Account ID to specify the replica ownership. Must be used in conjunction with access_control_translation override configuration.</summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>ARN of the bucket where you want Amazon S3 to store the results.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationBucketSelector? BucketSelector { get; set; }

    /// <summary>Configuration block that provides information about encryption. See below. If source_selection_criteria is specified, you must specify this element.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Configuration block that specifies replication metrics-related settings enabling replication metrics and events. See below.</summary>
    [JsonPropertyName("metrics")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationMetrics? Metrics { get; set; }

    /// <summary>Configuration block that specifies S3 Replication Time Control (S3 RTC), including whether S3 RTC is enabled and the time when all objects and operations on objects must be replicated. See below. Replication Time Control must be used in conjunction with metrics.</summary>
    [JsonPropertyName("replicationTime")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestinationReplicationTime? ReplicationTime { get; set; }

    /// <summary>The storage class used to store the object. By default, Amazon S3 uses the storage class of the source object to create the object replica.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary>Replicate existing objects in the source bucket according to the rule configurations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleExistingObjectReplication
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for specifying rule filters. This element is required only if you specify more than one filter. See and below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleFilterAnd
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
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleFilterTag
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
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleFilter
{
    /// <summary>Configuration block for specifying rule filters. This element is required only if you specify more than one filter. See and below for more details.</summary>
    [JsonPropertyName("and")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleFilterAnd? And { get; set; }

    /// <summary>Object key name prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length. Defaults to an empty string (&quot; &quot;) if filter is not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Configuration block for specifying a tag key and value. See below.</summary>
    [JsonPropertyName("tag")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleFilterTag? Tag { get; set; }
}

/// <summary>Configuration block that you can specify for selections for modifications on replicas. Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest version of replication configuration (when filter is specified), you can specify this element and set the status to Enabled to replicate modifications on replicas.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleSourceSelectionCriteriaReplicaModifications
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If specified, replica_kms_key_id in destination encryption_configuration must be specified as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleSourceSelectionCriteriaSseKmsEncryptedObjects
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Specifies special object selection criteria. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRuleSourceSelectionCriteria
{
    /// <summary>Configuration block that you can specify for selections for modifications on replicas. Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest version of replication configuration (when filter is specified), you can specify this element and set the status to Enabled to replicate modifications on replicas.</summary>
    [JsonPropertyName("replicaModifications")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleSourceSelectionCriteriaReplicaModifications? ReplicaModifications { get; set; }

    /// <summary>Configuration block for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If specified, replica_kms_key_id in destination encryption_configuration must be specified as well.</summary>
    [JsonPropertyName("sseKmsEncryptedObjects")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProviderRule
{
    /// <summary>Whether delete markers are replicated. This argument is only valid with V2 replication configurations (i.e., when filter is used)documented below.</summary>
    [JsonPropertyName("deleteMarkerReplication")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDeleteMarkerReplication? DeleteMarkerReplication { get; set; }

    /// <summary>Specifies the destination for the rule. See below.</summary>
    [JsonPropertyName("destination")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleDestination? Destination { get; set; }

    /// <summary>Replicate existing objects in the source bucket according to the rule configurations. See below.</summary>
    [JsonPropertyName("existingObjectReplication")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleExistingObjectReplication? ExistingObjectReplication { get; set; }

    /// <summary>Filter that identifies subset of objects to which the replication rule applies. See below. If not specified, the rule will default to using prefix.</summary>
    [JsonPropertyName("filter")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleFilter? Filter { get; set; }

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
    public V1beta1BucketReplicationConfigurationSpecForProviderRuleSourceSelectionCriteria? SourceSelectionCriteria { get; set; }

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
public partial class V1beta1BucketReplicationConfigurationSpecForProviderTokenSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecForProvider
{
    /// <summary>Name of the source S3 bucket you want Amazon S3 to monitor.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketReplicationConfigurationSpecForProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketReplicationConfigurationSpecForProviderBucketSelector? BucketSelector { get; set; }

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
    public V1beta1BucketReplicationConfigurationSpecForProviderRoleRef? RoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate role.</summary>
    [JsonPropertyName("roleSelector")]
    public V1beta1BucketReplicationConfigurationSpecForProviderRoleSelector? RoleSelector { get; set; }

    /// <summary>List of configuration blocks describing the rules managing the replication. See below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1BucketReplicationConfigurationSpecForProviderRule>? Rule { get; set; }

    /// <summary>
    /// Token to allow replication to be enabled on an Object Lock-enabled bucket. You must contact AWS support for the bucket&apos;s &quot;Object Lock token&quot;.
    /// For more details, see Using S3 Object Lock with replication.
    /// </summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1beta1BucketReplicationConfigurationSpecForProviderTokenSecretRef? TokenSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderBucketRefPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderBucketRefPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderBucketSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderRoleRefPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderRoleRefPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRoleSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Whether delete markers are replicated. This argument is only valid with V2 replication configurations (i.e., when filter is used)documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDeleteMarkerReplication
{
    /// <summary>Whether delete markers should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block that specifies the overrides to use for object owners on replication. See below. Specify this only in a cross-account scenario (where source and destination bucket owners are not the same), and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not specified in the replication configuration, the replicas are owned by same AWS account that owns the source object. Must be used in conjunction with account owner override configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationAccessControlTranslation
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate replicaKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate replicaKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block that provides information about encryption. See below. If source_selection_criteria is specified, you must specify this element.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfiguration
{
    /// <summary>ID (Key ARN or Alias ARN) of the customer managed AWS KMS key stored in AWS Key Management Service (KMS) for the destination bucket.</summary>
    [JsonPropertyName("replicaKmsKeyId")]
    public string? ReplicaKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate replicaKmsKeyId.</summary>
    [JsonPropertyName("replicaKmsKeyIdRef")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdRef? ReplicaKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate replicaKmsKeyId.</summary>
    [JsonPropertyName("replicaKmsKeyIdSelector")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfigurationReplicaKmsKeyIdSelector? ReplicaKmsKeyIdSelector { get; set; }
}

/// <summary>Configuration block that specifies the time threshold for emitting the s3:Replication:OperationMissedThreshold event. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationMetricsEventThreshold
{
    /// <summary>Time in minutes. Valid values: 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>Configuration block that specifies replication metrics-related settings enabling replication metrics and events. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationMetrics
{
    /// <summary>Configuration block that specifies the time threshold for emitting the s3:Replication:OperationMissedThreshold event. See below.</summary>
    [JsonPropertyName("eventThreshold")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationMetricsEventThreshold? EventThreshold { get; set; }

    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block specifying the time by which replication should be complete for all objects and operations on objects. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationReplicationTimeTime
{
    /// <summary>Time in minutes. Valid values: 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>Configuration block that specifies S3 Replication Time Control (S3 RTC), including whether S3 RTC is enabled and the time when all objects and operations on objects must be replicated. See below. Replication Time Control must be used in conjunction with metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationReplicationTime
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Configuration block specifying the time by which replication should be complete for all objects and operations on objects. See below.</summary>
    [JsonPropertyName("time")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationReplicationTimeTime? Time { get; set; }
}

/// <summary>Specifies the destination for the rule. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestination
{
    /// <summary>Configuration block that specifies the overrides to use for object owners on replication. See below. Specify this only in a cross-account scenario (where source and destination bucket owners are not the same), and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not specified in the replication configuration, the replicas are owned by same AWS account that owns the source object. Must be used in conjunction with account owner override configuration.</summary>
    [JsonPropertyName("accessControlTranslation")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationAccessControlTranslation? AccessControlTranslation { get; set; }

    /// <summary>Account ID to specify the replica ownership. Must be used in conjunction with access_control_translation override configuration.</summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>ARN of the bucket where you want Amazon S3 to store the results.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationBucketSelector? BucketSelector { get; set; }

    /// <summary>Configuration block that provides information about encryption. See below. If source_selection_criteria is specified, you must specify this element.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Configuration block that specifies replication metrics-related settings enabling replication metrics and events. See below.</summary>
    [JsonPropertyName("metrics")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationMetrics? Metrics { get; set; }

    /// <summary>Configuration block that specifies S3 Replication Time Control (S3 RTC), including whether S3 RTC is enabled and the time when all objects and operations on objects must be replicated. See below. Replication Time Control must be used in conjunction with metrics.</summary>
    [JsonPropertyName("replicationTime")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestinationReplicationTime? ReplicationTime { get; set; }

    /// <summary>The storage class used to store the object. By default, Amazon S3 uses the storage class of the source object to create the object replica.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary>Replicate existing objects in the source bucket according to the rule configurations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleExistingObjectReplication
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for specifying rule filters. This element is required only if you specify more than one filter. See and below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleFilterAnd
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
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleFilterTag
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
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleFilter
{
    /// <summary>Configuration block for specifying rule filters. This element is required only if you specify more than one filter. See and below for more details.</summary>
    [JsonPropertyName("and")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleFilterAnd? And { get; set; }

    /// <summary>Object key name prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length. Defaults to an empty string (&quot; &quot;) if filter is not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Configuration block for specifying a tag key and value. See below.</summary>
    [JsonPropertyName("tag")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleFilterTag? Tag { get; set; }
}

/// <summary>Configuration block that you can specify for selections for modifications on replicas. Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest version of replication configuration (when filter is specified), you can specify this element and set the status to Enabled to replicate modifications on replicas.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleSourceSelectionCriteriaReplicaModifications
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If specified, replica_kms_key_id in destination encryption_configuration must be specified as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleSourceSelectionCriteriaSseKmsEncryptedObjects
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Specifies special object selection criteria. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRuleSourceSelectionCriteria
{
    /// <summary>Configuration block that you can specify for selections for modifications on replicas. Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest version of replication configuration (when filter is specified), you can specify this element and set the status to Enabled to replicate modifications on replicas.</summary>
    [JsonPropertyName("replicaModifications")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleSourceSelectionCriteriaReplicaModifications? ReplicaModifications { get; set; }

    /// <summary>Configuration block for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If specified, replica_kms_key_id in destination encryption_configuration must be specified as well.</summary>
    [JsonPropertyName("sseKmsEncryptedObjects")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderRule
{
    /// <summary>Whether delete markers are replicated. This argument is only valid with V2 replication configurations (i.e., when filter is used)documented below.</summary>
    [JsonPropertyName("deleteMarkerReplication")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDeleteMarkerReplication? DeleteMarkerReplication { get; set; }

    /// <summary>Specifies the destination for the rule. See below.</summary>
    [JsonPropertyName("destination")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleDestination? Destination { get; set; }

    /// <summary>Replicate existing objects in the source bucket according to the rule configurations. See below.</summary>
    [JsonPropertyName("existingObjectReplication")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleExistingObjectReplication? ExistingObjectReplication { get; set; }

    /// <summary>Filter that identifies subset of objects to which the replication rule applies. See below. If not specified, the rule will default to using prefix.</summary>
    [JsonPropertyName("filter")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleFilter? Filter { get; set; }

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
    public V1beta1BucketReplicationConfigurationSpecInitProviderRuleSourceSelectionCriteria? SourceSelectionCriteria { get; set; }

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
public partial class V1beta1BucketReplicationConfigurationSpecInitProviderTokenSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
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
public partial class V1beta1BucketReplicationConfigurationSpecInitProvider
{
    /// <summary>Name of the source S3 bucket you want Amazon S3 to monitor.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>ARN of the IAM role for Amazon S3 to assume when replicating the objects.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Reference to a Role in iam to populate role.</summary>
    [JsonPropertyName("roleRef")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRoleRef? RoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate role.</summary>
    [JsonPropertyName("roleSelector")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderRoleSelector? RoleSelector { get; set; }

    /// <summary>List of configuration blocks describing the rules managing the replication. See below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1BucketReplicationConfigurationSpecInitProviderRule>? Rule { get; set; }

    /// <summary>
    /// Token to allow replication to be enabled on an Object Lock-enabled bucket. You must contact AWS support for the bucket&apos;s &quot;Object Lock token&quot;.
    /// For more details, see Using S3 Object Lock with replication.
    /// </summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1beta1BucketReplicationConfigurationSpecInitProviderTokenSecretRef? TokenSecretRef { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketReplicationConfigurationSpecManagementPoliciesEnum>))]
public enum V1beta1BucketReplicationConfigurationSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>BucketReplicationConfigurationSpec defines the desired state of BucketReplicationConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1BucketReplicationConfigurationSpecForProvider ForProvider { get; set; }

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
    public V1beta1BucketReplicationConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BucketReplicationConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BucketReplicationConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BucketReplicationConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Whether delete markers are replicated. This argument is only valid with V2 replication configurations (i.e., when filter is used)documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleDeleteMarkerReplication
{
    /// <summary>Whether delete markers should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block that specifies the overrides to use for object owners on replication. See below. Specify this only in a cross-account scenario (where source and destination bucket owners are not the same), and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not specified in the replication configuration, the replicas are owned by same AWS account that owns the source object. Must be used in conjunction with account owner override configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestinationAccessControlTranslation
{
    /// <summary>Specifies the replica ownership. For default and valid values, see PUT bucket replication in the Amazon S3 API Reference. Valid values: Destination.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }
}

/// <summary>Configuration block that provides information about encryption. See below. If source_selection_criteria is specified, you must specify this element.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestinationEncryptionConfiguration
{
    /// <summary>ID (Key ARN or Alias ARN) of the customer managed AWS KMS key stored in AWS Key Management Service (KMS) for the destination bucket.</summary>
    [JsonPropertyName("replicaKmsKeyId")]
    public string? ReplicaKmsKeyId { get; set; }
}

/// <summary>Configuration block that specifies the time threshold for emitting the s3:Replication:OperationMissedThreshold event. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestinationMetricsEventThreshold
{
    /// <summary>Time in minutes. Valid values: 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>Configuration block that specifies replication metrics-related settings enabling replication metrics and events. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestinationMetrics
{
    /// <summary>Configuration block that specifies the time threshold for emitting the s3:Replication:OperationMissedThreshold event. See below.</summary>
    [JsonPropertyName("eventThreshold")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestinationMetricsEventThreshold? EventThreshold { get; set; }

    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block specifying the time by which replication should be complete for all objects and operations on objects. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestinationReplicationTimeTime
{
    /// <summary>Time in minutes. Valid values: 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

/// <summary>Configuration block that specifies S3 Replication Time Control (S3 RTC), including whether S3 RTC is enabled and the time when all objects and operations on objects must be replicated. See below. Replication Time Control must be used in conjunction with metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestinationReplicationTime
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Configuration block specifying the time by which replication should be complete for all objects and operations on objects. See below.</summary>
    [JsonPropertyName("time")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestinationReplicationTimeTime? Time { get; set; }
}

/// <summary>Specifies the destination for the rule. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestination
{
    /// <summary>Configuration block that specifies the overrides to use for object owners on replication. See below. Specify this only in a cross-account scenario (where source and destination bucket owners are not the same), and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not specified in the replication configuration, the replicas are owned by same AWS account that owns the source object. Must be used in conjunction with account owner override configuration.</summary>
    [JsonPropertyName("accessControlTranslation")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestinationAccessControlTranslation? AccessControlTranslation { get; set; }

    /// <summary>Account ID to specify the replica ownership. Must be used in conjunction with access_control_translation override configuration.</summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>ARN of the bucket where you want Amazon S3 to store the results.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Configuration block that provides information about encryption. See below. If source_selection_criteria is specified, you must specify this element.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestinationEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Configuration block that specifies replication metrics-related settings enabling replication metrics and events. See below.</summary>
    [JsonPropertyName("metrics")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestinationMetrics? Metrics { get; set; }

    /// <summary>Configuration block that specifies S3 Replication Time Control (S3 RTC), including whether S3 RTC is enabled and the time when all objects and operations on objects must be replicated. See below. Replication Time Control must be used in conjunction with metrics.</summary>
    [JsonPropertyName("replicationTime")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestinationReplicationTime? ReplicationTime { get; set; }

    /// <summary>The storage class used to store the object. By default, Amazon S3 uses the storage class of the source object to create the object replica.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary>Replicate existing objects in the source bucket according to the rule configurations. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleExistingObjectReplication
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for specifying rule filters. This element is required only if you specify more than one filter. See and below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleFilterAnd
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
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleFilterTag
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
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleFilter
{
    /// <summary>Configuration block for specifying rule filters. This element is required only if you specify more than one filter. See and below for more details.</summary>
    [JsonPropertyName("and")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleFilterAnd? And { get; set; }

    /// <summary>Object key name prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length. Defaults to an empty string (&quot; &quot;) if filter is not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Configuration block for specifying a tag key and value. See below.</summary>
    [JsonPropertyName("tag")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleFilterTag? Tag { get; set; }
}

/// <summary>Configuration block that you can specify for selections for modifications on replicas. Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest version of replication configuration (when filter is specified), you can specify this element and set the status to Enabled to replicate modifications on replicas.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleSourceSelectionCriteriaReplicaModifications
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If specified, replica_kms_key_id in destination encryption_configuration must be specified as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleSourceSelectionCriteriaSseKmsEncryptedObjects
{
    /// <summary>Whether the existing objects should be replicated. Either &quot;Enabled&quot; or &quot;Disabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Specifies special object selection criteria. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRuleSourceSelectionCriteria
{
    /// <summary>Configuration block that you can specify for selections for modifications on replicas. Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest version of replication configuration (when filter is specified), you can specify this element and set the status to Enabled to replicate modifications on replicas.</summary>
    [JsonPropertyName("replicaModifications")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleSourceSelectionCriteriaReplicaModifications? ReplicaModifications { get; set; }

    /// <summary>Configuration block for filter information for the selection of Amazon S3 objects encrypted with AWS KMS. If specified, replica_kms_key_id in destination encryption_configuration must be specified as well.</summary>
    [JsonPropertyName("sseKmsEncryptedObjects")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProviderRule
{
    /// <summary>Whether delete markers are replicated. This argument is only valid with V2 replication configurations (i.e., when filter is used)documented below.</summary>
    [JsonPropertyName("deleteMarkerReplication")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleDeleteMarkerReplication? DeleteMarkerReplication { get; set; }

    /// <summary>Specifies the destination for the rule. See below.</summary>
    [JsonPropertyName("destination")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleDestination? Destination { get; set; }

    /// <summary>Replicate existing objects in the source bucket according to the rule configurations. See below.</summary>
    [JsonPropertyName("existingObjectReplication")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleExistingObjectReplication? ExistingObjectReplication { get; set; }

    /// <summary>Filter that identifies subset of objects to which the replication rule applies. See below. If not specified, the rule will default to using prefix.</summary>
    [JsonPropertyName("filter")]
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleFilter? Filter { get; set; }

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
    public V1beta1BucketReplicationConfigurationStatusAtProviderRuleSourceSelectionCriteria? SourceSelectionCriteria { get; set; }

    /// <summary>Status of the rule. Either &quot;Enabled&quot; or &quot;Disabled&quot;. The rule is ignored if status is not &quot;Enabled&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusAtProvider
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
    public IList<V1beta1BucketReplicationConfigurationStatusAtProviderRule>? Rule { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketReplicationConfigurationStatusConditions
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
public partial class V1beta1BucketReplicationConfigurationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1BucketReplicationConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BucketReplicationConfigurationStatusConditions>? Conditions { get; set; }

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
public partial class V1beta1BucketReplicationConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BucketReplicationConfigurationSpec>, IStatus<V1beta1BucketReplicationConfigurationStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketReplicationConfiguration";
    public const string KubeGroup = "s3.aws.m.upbound.io";
    public const string KubePluralName = "bucketreplicationconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "s3.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BucketReplicationConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketReplicationConfigurationSpec defines the desired state of BucketReplicationConfiguration</summary>
    [JsonPropertyName("spec")]
    public required V1beta1BucketReplicationConfigurationSpec Spec { get; set; }

    /// <summary>BucketReplicationConfigurationStatus defines the observed state of BucketReplicationConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1BucketReplicationConfigurationStatus? Status { get; set; }
}