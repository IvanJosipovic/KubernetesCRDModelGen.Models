#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pubsub.gcp.upbound.io;
/// <summary>LiteTopic is the Schema for the LiteTopics API. A named resource to which messages are sent by publishers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LiteTopicList : IKubernetesObject<V1ListMeta>, IItems<V1beta2LiteTopic>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LiteTopicList";
    public const string KubeGroup = "pubsub.gcp.upbound.io";
    public const string KubePluralName = "litetopics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pubsub.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LiteTopicList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2LiteTopic objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2LiteTopic> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LiteTopicSpecDeletionPolicyEnum>))]
public enum V1beta2LiteTopicSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// The capacity configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecForProviderPartitionConfigCapacity
{
    /// <summary>Subscribe throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("publishMibPerSec")]
    public double? PublishMibPerSec { get; set; }

    /// <summary>Publish throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("subscribeMibPerSec")]
    public double? SubscribeMibPerSec { get; set; }
}

/// <summary>
/// The settings for this topic&apos;s partitions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecForProviderPartitionConfig
{
    /// <summary>
    /// The capacity configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("capacity")]
    public V1beta2LiteTopicSpecForProviderPartitionConfigCapacity? Capacity { get; set; }

    /// <summary>The number of partitions in the topic. Must be at least 1.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicyResolutionEnum>))]
public enum V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicyResolveEnum>))]
public enum V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LiteReservation in pubsub to populate throughputReservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicyResolutionEnum>))]
public enum V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicyResolveEnum>))]
public enum V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LiteReservation in pubsub to populate throughputReservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationSelector
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
    public V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The settings for this topic&apos;s Reservation usage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecForProviderReservationConfig
{
    /// <summary>The Reservation to use for this topic&apos;s throughput capacity.</summary>
    [JsonPropertyName("throughputReservation")]
    public string? ThroughputReservation { get; set; }

    /// <summary>Reference to a LiteReservation in pubsub to populate throughputReservation.</summary>
    [JsonPropertyName("throughputReservationRef")]
    public V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationRef? ThroughputReservationRef { get; set; }

    /// <summary>Selector for a LiteReservation in pubsub to populate throughputReservation.</summary>
    [JsonPropertyName("throughputReservationSelector")]
    public V1beta2LiteTopicSpecForProviderReservationConfigThroughputReservationSelector? ThroughputReservationSelector { get; set; }
}

/// <summary>
/// The settings for a topic&apos;s message retention.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecForProviderRetentionConfig
{
    /// <summary>
    /// The provisioned storage, in bytes, per partition. If the number of bytes stored
    /// in any of the topic&apos;s partitions grows beyond this value, older messages will be
    /// dropped to make room for newer ones, regardless of the value of period.
    /// </summary>
    [JsonPropertyName("perPartitionBytes")]
    public string? PerPartitionBytes { get; set; }

    /// <summary>
    /// How long a published message is retained. If unset, messages will be retained as
    /// long as the bytes retained for each partition is below perPartitionBytes. A
    /// duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecForProvider
{
    /// <summary>
    /// The settings for this topic&apos;s partitions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("partitionConfig")]
    public V1beta2LiteTopicSpecForProviderPartitionConfig? PartitionConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the pubsub lite topic.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The settings for this topic&apos;s Reservation usage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("reservationConfig")]
    public V1beta2LiteTopicSpecForProviderReservationConfig? ReservationConfig { get; set; }

    /// <summary>
    /// The settings for a topic&apos;s message retention.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retentionConfig")]
    public V1beta2LiteTopicSpecForProviderRetentionConfig? RetentionConfig { get; set; }

    /// <summary>The zone of the pubsub lite topic.</summary>
    [JsonPropertyName("zone")]
    public required string Zone { get; set; }
}

/// <summary>
/// The capacity configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecInitProviderPartitionConfigCapacity
{
    /// <summary>Subscribe throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("publishMibPerSec")]
    public double? PublishMibPerSec { get; set; }

    /// <summary>Publish throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("subscribeMibPerSec")]
    public double? SubscribeMibPerSec { get; set; }
}

/// <summary>
/// The settings for this topic&apos;s partitions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecInitProviderPartitionConfig
{
    /// <summary>
    /// The capacity configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("capacity")]
    public V1beta2LiteTopicSpecInitProviderPartitionConfigCapacity? Capacity { get; set; }

    /// <summary>The number of partitions in the topic. Must be at least 1.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicyResolutionEnum>))]
public enum V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicyResolveEnum>))]
public enum V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LiteReservation in pubsub to populate throughputReservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicyResolutionEnum>))]
public enum V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicyResolveEnum>))]
public enum V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LiteReservation in pubsub to populate throughputReservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationSelector
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
    public V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The settings for this topic&apos;s Reservation usage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecInitProviderReservationConfig
{
    /// <summary>The Reservation to use for this topic&apos;s throughput capacity.</summary>
    [JsonPropertyName("throughputReservation")]
    public string? ThroughputReservation { get; set; }

    /// <summary>Reference to a LiteReservation in pubsub to populate throughputReservation.</summary>
    [JsonPropertyName("throughputReservationRef")]
    public V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationRef? ThroughputReservationRef { get; set; }

    /// <summary>Selector for a LiteReservation in pubsub to populate throughputReservation.</summary>
    [JsonPropertyName("throughputReservationSelector")]
    public V1beta2LiteTopicSpecInitProviderReservationConfigThroughputReservationSelector? ThroughputReservationSelector { get; set; }
}

/// <summary>
/// The settings for a topic&apos;s message retention.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecInitProviderRetentionConfig
{
    /// <summary>
    /// The provisioned storage, in bytes, per partition. If the number of bytes stored
    /// in any of the topic&apos;s partitions grows beyond this value, older messages will be
    /// dropped to make room for newer ones, regardless of the value of period.
    /// </summary>
    [JsonPropertyName("perPartitionBytes")]
    public string? PerPartitionBytes { get; set; }

    /// <summary>
    /// How long a published message is retained. If unset, messages will be retained as
    /// long as the bytes retained for each partition is below perPartitionBytes. A
    /// duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
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
public partial class V1beta2LiteTopicSpecInitProvider
{
    /// <summary>
    /// The settings for this topic&apos;s partitions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("partitionConfig")]
    public V1beta2LiteTopicSpecInitProviderPartitionConfig? PartitionConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the pubsub lite topic.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The settings for this topic&apos;s Reservation usage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("reservationConfig")]
    public V1beta2LiteTopicSpecInitProviderReservationConfig? ReservationConfig { get; set; }

    /// <summary>
    /// The settings for a topic&apos;s message retention.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retentionConfig")]
    public V1beta2LiteTopicSpecInitProviderRetentionConfig? RetentionConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LiteTopicSpecManagementPoliciesEnum>))]
public enum V1beta2LiteTopicSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LiteTopicSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2LiteTopicSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LiteTopicSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2LiteTopicSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LiteTopicSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LiteTopicSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LiteTopicSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>LiteTopicSpec defines the desired state of LiteTopic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicSpec
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
    public V1beta2LiteTopicSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2LiteTopicSpecForProvider ForProvider { get; set; }

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
    public V1beta2LiteTopicSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2LiteTopicSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2LiteTopicSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2LiteTopicSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// The capacity configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicStatusAtProviderPartitionConfigCapacity
{
    /// <summary>Subscribe throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("publishMibPerSec")]
    public double? PublishMibPerSec { get; set; }

    /// <summary>Publish throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("subscribeMibPerSec")]
    public double? SubscribeMibPerSec { get; set; }
}

/// <summary>
/// The settings for this topic&apos;s partitions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicStatusAtProviderPartitionConfig
{
    /// <summary>
    /// The capacity configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("capacity")]
    public V1beta2LiteTopicStatusAtProviderPartitionConfigCapacity? Capacity { get; set; }

    /// <summary>The number of partitions in the topic. Must be at least 1.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>
/// The settings for this topic&apos;s Reservation usage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicStatusAtProviderReservationConfig
{
    /// <summary>The Reservation to use for this topic&apos;s throughput capacity.</summary>
    [JsonPropertyName("throughputReservation")]
    public string? ThroughputReservation { get; set; }
}

/// <summary>
/// The settings for a topic&apos;s message retention.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicStatusAtProviderRetentionConfig
{
    /// <summary>
    /// The provisioned storage, in bytes, per partition. If the number of bytes stored
    /// in any of the topic&apos;s partitions grows beyond this value, older messages will be
    /// dropped to make room for newer ones, regardless of the value of period.
    /// </summary>
    [JsonPropertyName("perPartitionBytes")]
    public string? PerPartitionBytes { get; set; }

    /// <summary>
    /// How long a published message is retained. If unset, messages will be retained as
    /// long as the bytes retained for each partition is below perPartitionBytes. A
    /// duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicStatusAtProvider
{
    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{zone}}/topics/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The settings for this topic&apos;s partitions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("partitionConfig")]
    public V1beta2LiteTopicStatusAtProviderPartitionConfig? PartitionConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the pubsub lite topic.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The settings for this topic&apos;s Reservation usage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("reservationConfig")]
    public V1beta2LiteTopicStatusAtProviderReservationConfig? ReservationConfig { get; set; }

    /// <summary>
    /// The settings for a topic&apos;s message retention.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retentionConfig")]
    public V1beta2LiteTopicStatusAtProviderRetentionConfig? RetentionConfig { get; set; }

    /// <summary>The zone of the pubsub lite topic.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicStatusConditions
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

/// <summary>LiteTopicStatus defines the observed state of LiteTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LiteTopicStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2LiteTopicStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2LiteTopicStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LiteTopic is the Schema for the LiteTopics API. A named resource to which messages are sent by publishers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LiteTopic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2LiteTopicSpec>, IStatus<V1beta2LiteTopicStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LiteTopic";
    public const string KubeGroup = "pubsub.gcp.upbound.io";
    public const string KubePluralName = "litetopics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pubsub.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LiteTopic";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LiteTopicSpec defines the desired state of LiteTopic</summary>
    [JsonPropertyName("spec")]
    public required V1beta2LiteTopicSpec Spec { get; set; }

    /// <summary>LiteTopicStatus defines the observed state of LiteTopic.</summary>
    [JsonPropertyName("status")]
    public V1beta2LiteTopicStatus? Status { get; set; }
}