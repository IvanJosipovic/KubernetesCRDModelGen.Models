#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.memorystore.gcp.upbound.io;
/// <summary>Instance is the Schema for the Instances API. A Google Cloud Memorystore instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Instance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceList";
    public const string KubeGroup = "memorystore.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorystore.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Instance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Instance> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecDeletionPolicyEnum>))]
public enum V1beta1InstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Start time of the window in UTC time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAutomatedBackupConfigFixedFrequencyScheduleStartTime
{
    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &quot;24:00:00&quot; for scenarios like business closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }
}

/// <summary>
/// Trigger automated backups at a fixed frequency.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAutomatedBackupConfigFixedFrequencySchedule
{
    /// <summary>
    /// Start time of the window in UTC time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("startTime")]
    public V1beta1InstanceSpecForProviderAutomatedBackupConfigFixedFrequencyScheduleStartTime? StartTime { get; set; }
}

/// <summary>
/// The automated backup config for a instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAutomatedBackupConfig
{
    /// <summary>
    /// Trigger automated backups at a fixed frequency.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedFrequencySchedule")]
    public V1beta1InstanceSpecForProviderAutomatedBackupConfigFixedFrequencySchedule? FixedFrequencySchedule { get; set; }

    /// <summary>
    /// How long to keep automated backups before the backups are deleted.
    /// The value should be between 1 day and 365 days. If not specified, the default value is 35 days.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;. The default_value is &quot;3024000s&quot;
    /// </summary>
    [JsonPropertyName("retention")]
    public string? Retention { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicyResolutionEnum>))]
public enum V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicyResolveEnum>))]
public enum V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in memorystore to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicyResolutionEnum>))]
public enum V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicyResolveEnum>))]
public enum V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in memorystore to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelector
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
    public V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// This field is only set for a secondary instance. Details of the primary instance that is used as the replication source for this secondary instance. This is allowed to be set only for clusters whose cluster role is of type SECONDARY.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstance
{
    /// <summary>The full resource path of the Nth instance in the format: projects/{project}/locations/{region}/instance/{instance-id}</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Reference to a Instance in memorystore to populate instance.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRef? InstanceRef { get; set; }

    /// <summary>Selector for a Instance in memorystore to populate instance.</summary>
    [JsonPropertyName("instanceSelector")]
    public V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelector? InstanceSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigSecondaryInstances
{
    /// <summary>The full resource path of the Nth instance in the format: projects/{project}/locations/{region}/instance/{instance-id}</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }
}

/// <summary>
/// Cross instance replication config
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCrossInstanceReplicationConfig
{
    /// <summary>The instance role supports the following values:</summary>
    [JsonPropertyName("instanceRole")]
    public string? InstanceRole { get; set; }

    /// <summary>
    /// This field is only set for a secondary instance. Details of the primary instance that is used as the replication source for this secondary instance. This is allowed to be set only for clusters whose cluster role is of type SECONDARY.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primaryInstance")]
    public V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigPrimaryInstance? PrimaryInstance { get; set; }

    /// <summary>
    /// List of secondary instances that are replicating from this primary cluster. This is allowed to be set only for instances whose cluster role is of type PRIMARY.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secondaryInstances")]
    public IList<V1beta1InstanceSpecForProviderCrossInstanceReplicationConfigSecondaryInstances>? SecondaryInstances { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkRefPolicyResolutionEnum>))]
public enum V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkRefPolicyResolveEnum>))]
public enum V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicyResolveEnum>))]
public enum V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkSelector
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
    public V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpoints
{
    /// <summary>
    /// (Output)
    /// Output only. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpointsNetworkSelector? NetworkSelector { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderDesiredPscAutoConnections
{
    /// <summary>
    /// (Output)
    /// Output only. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// GCS source for the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderGcsSource
{
    /// <summary>
    /// URIs of the GCS objects to import.
    /// Example: gs://bucket1/object1, gs://bucket2/folder2/object2
    /// </summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>
/// Start time of the window in UTC time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime
{
    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &quot;24:00:00&quot; for scenarios like business closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59.
    /// An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>The day of week that maintenance updates occur.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>
    /// Start time of the window in UTC time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("startTime")]
    public V1beta1InstanceSpecForProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime? StartTime { get; set; }
}

/// <summary>
/// Maintenance policy for a cluster
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderMaintenancePolicy
{
    /// <summary>
    /// Optional. Maintenance window that is applied to resources covered by this policy.
    /// Minimum 1. For the current version, the maximum number
    /// of weekly_window is expected to be one.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta1InstanceSpecForProviderMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}

/// <summary>
/// Managed backup source for the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderManagedBackupSource
{
    /// <summary>Example: projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}.</summary>
    [JsonPropertyName("backup")]
    public string? Backup { get; set; }
}

/// <summary>
/// Configuration for AOF based persistence.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderPersistenceConfigAofConfig
{
    /// <summary>
    /// Optional. The fsync mode.
    /// Possible values:
    /// NEVER
    /// EVERY_SEC
    /// ALWAYS
    /// </summary>
    [JsonPropertyName("appendFsync")]
    public string? AppendFsync { get; set; }
}

/// <summary>
/// Configuration for RDB based persistence.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderPersistenceConfigRdbConfig
{
    /// <summary>
    /// Optional. Period between RDB snapshots.
    /// Possible values:
    /// ONE_HOUR
    /// SIX_HOURS
    /// TWELVE_HOURS
    /// TWENTY_FOUR_HOURS
    /// </summary>
    [JsonPropertyName("rdbSnapshotPeriod")]
    public string? RdbSnapshotPeriod { get; set; }

    /// <summary>
    /// Optional. Time that the first snapshot was/will be attempted, and to which future
    /// snapshots will be aligned. If not provided, the current time will be
    /// used.
    /// </summary>
    [JsonPropertyName("rdbSnapshotStartTime")]
    public string? RdbSnapshotStartTime { get; set; }
}

/// <summary>
/// Represents persistence configuration for a instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderPersistenceConfig
{
    /// <summary>
    /// Configuration for AOF based persistence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aofConfig")]
    public V1beta1InstanceSpecForProviderPersistenceConfigAofConfig? AofConfig { get; set; }

    /// <summary>
    /// Optional. Current persistence mode.
    /// Possible values:
    /// DISABLED
    /// RDB
    /// AOF
    /// Possible values are: DISABLED, RDB, AOF.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Configuration for RDB based persistence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rdbConfig")]
    public V1beta1InstanceSpecForProviderPersistenceConfigRdbConfig? RdbConfig { get; set; }
}

/// <summary>
/// Zone distribution configuration for allocation of instance resources.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderZoneDistributionConfig
{
    /// <summary>
    /// Optional. Current zone distribution mode. Defaults to MULTI_ZONE.
    /// Possible values:
    /// MULTI_ZONE
    /// SINGLE_ZONE
    /// Possible values are: MULTI_ZONE, SINGLE_ZONE.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Optional. Defines zone where all resources will be allocated with SINGLE_ZONE mode.
    /// Ignored for MULTI_ZONE mode.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProvider
{
    /// <summary>
    /// Optional. Immutable. Authorization mode of the instance. Possible values:
    /// AUTH_DISABLED
    /// IAM_AUTH
    /// </summary>
    [JsonPropertyName("authorizationMode")]
    public string? AuthorizationMode { get; set; }

    /// <summary>
    /// The automated backup config for a instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("automatedBackupConfig")]
    public V1beta1InstanceSpecForProviderAutomatedBackupConfig? AutomatedBackupConfig { get; set; }

    /// <summary>
    /// Cross instance replication config
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("crossInstanceReplicationConfig")]
    public V1beta1InstanceSpecForProviderCrossInstanceReplicationConfig? CrossInstanceReplicationConfig { get; set; }

    /// <summary>Optional. If set to true deletion of the instance will fail.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Immutable. User inputs for the auto-created endpoints connections.</summary>
    [JsonPropertyName("desiredAutoCreatedEndpoints")]
    public IList<V1beta1InstanceSpecForProviderDesiredAutoCreatedEndpoints>? DesiredAutoCreatedEndpoints { get; set; }

    /// <summary>desired_psc_auto_connections is deprecated  Use desired_auto_created_endpoints instead.</summary>
    [JsonPropertyName("desiredPscAutoConnections")]
    public IList<V1beta1InstanceSpecForProviderDesiredPscAutoConnections>? DesiredPscAutoConnections { get; set; }

    /// <summary>Optional. User-provided engine configurations for the instance.</summary>
    [JsonPropertyName("engineConfigs")]
    public IDictionary<string, string>? EngineConfigs { get; set; }

    /// <summary>Optional. Engine version of the instance.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>
    /// GCS source for the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsSource")]
    public V1beta1InstanceSpecForProviderGcsSource? GcsSource { get; set; }

    /// <summary>The KMS key used to encrypt the at-rest data of the cluster</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>
    /// Optional. Labels to represent user-provided metadata.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Resource ID segment making up resource name. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type memorystore.googleapis.com/CertificateAuthority.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// Maintenance policy for a cluster
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1InstanceSpecForProviderMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>
    /// Managed backup source for the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("managedBackupSource")]
    public V1beta1InstanceSpecForProviderManagedBackupSource? ManagedBackupSource { get; set; }

    /// <summary>
    /// Optional. cluster or cluster-disabled.
    /// Possible values:
    /// CLUSTER
    /// CLUSTER_DISABLED
    /// Possible values are: CLUSTER, CLUSTER_DISABLED.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Optional. Machine type for individual nodes of the instance.
    /// Possible values:
    /// SHARED_CORE_NANO
    /// HIGHMEM_MEDIUM
    /// HIGHMEM_XLARGE
    /// STANDARD_SMALL
    /// </summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>
    /// Represents persistence configuration for a instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("persistenceConfig")]
    public V1beta1InstanceSpecForProviderPersistenceConfig? PersistenceConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Optional. Number of replica nodes per shard. If omitted the default is 0 replicas.</summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>Required. Number of shards for the instance.</summary>
    [JsonPropertyName("shardCount")]
    public double? ShardCount { get; set; }

    /// <summary>
    /// Optional. Immutable. In-transit encryption mode of the instance.
    /// Possible values:
    /// TRANSIT_ENCRYPTION_DISABLED
    /// SERVER_AUTHENTICATION
    /// </summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }

    /// <summary>
    /// Zone distribution configuration for allocation of instance resources.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("zoneDistributionConfig")]
    public V1beta1InstanceSpecForProviderZoneDistributionConfig? ZoneDistributionConfig { get; set; }
}

/// <summary>
/// Start time of the window in UTC time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAutomatedBackupConfigFixedFrequencyScheduleStartTime
{
    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &quot;24:00:00&quot; for scenarios like business closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }
}

/// <summary>
/// Trigger automated backups at a fixed frequency.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAutomatedBackupConfigFixedFrequencySchedule
{
    /// <summary>
    /// Start time of the window in UTC time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("startTime")]
    public V1beta1InstanceSpecInitProviderAutomatedBackupConfigFixedFrequencyScheduleStartTime? StartTime { get; set; }
}

/// <summary>
/// The automated backup config for a instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAutomatedBackupConfig
{
    /// <summary>
    /// Trigger automated backups at a fixed frequency.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedFrequencySchedule")]
    public V1beta1InstanceSpecInitProviderAutomatedBackupConfigFixedFrequencySchedule? FixedFrequencySchedule { get; set; }

    /// <summary>
    /// How long to keep automated backups before the backups are deleted.
    /// The value should be between 1 day and 365 days. If not specified, the default value is 35 days.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;. The default_value is &quot;3024000s&quot;
    /// </summary>
    [JsonPropertyName("retention")]
    public string? Retention { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicyResolutionEnum>))]
public enum V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicyResolveEnum>))]
public enum V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in memorystore to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicyResolutionEnum>))]
public enum V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicyResolveEnum>))]
public enum V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in memorystore to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelector
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
    public V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// This field is only set for a secondary instance. Details of the primary instance that is used as the replication source for this secondary instance. This is allowed to be set only for clusters whose cluster role is of type SECONDARY.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstance
{
    /// <summary>The full resource path of the Nth instance in the format: projects/{project}/locations/{region}/instance/{instance-id}</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Reference to a Instance in memorystore to populate instance.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceRef? InstanceRef { get; set; }

    /// <summary>Selector for a Instance in memorystore to populate instance.</summary>
    [JsonPropertyName("instanceSelector")]
    public V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstanceInstanceSelector? InstanceSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigSecondaryInstances
{
    /// <summary>The full resource path of the Nth instance in the format: projects/{project}/locations/{region}/instance/{instance-id}</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }
}

/// <summary>
/// Cross instance replication config
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfig
{
    /// <summary>The instance role supports the following values:</summary>
    [JsonPropertyName("instanceRole")]
    public string? InstanceRole { get; set; }

    /// <summary>
    /// This field is only set for a secondary instance. Details of the primary instance that is used as the replication source for this secondary instance. This is allowed to be set only for clusters whose cluster role is of type SECONDARY.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primaryInstance")]
    public V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigPrimaryInstance? PrimaryInstance { get; set; }

    /// <summary>
    /// List of secondary instances that are replicating from this primary cluster. This is allowed to be set only for instances whose cluster role is of type PRIMARY.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secondaryInstances")]
    public IList<V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfigSecondaryInstances>? SecondaryInstances { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkRefPolicyResolutionEnum>))]
public enum V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkRefPolicyResolveEnum>))]
public enum V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicyResolveEnum>))]
public enum V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkSelector
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
    public V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpoints
{
    /// <summary>
    /// (Output)
    /// Output only. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpointsNetworkSelector? NetworkSelector { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderDesiredPscAutoConnections
{
    /// <summary>
    /// (Output)
    /// Output only. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// GCS source for the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderGcsSource
{
    /// <summary>
    /// URIs of the GCS objects to import.
    /// Example: gs://bucket1/object1, gs://bucket2/folder2/object2
    /// </summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>
/// Start time of the window in UTC time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime
{
    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &quot;24:00:00&quot; for scenarios like business closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59.
    /// An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>The day of week that maintenance updates occur.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>
    /// Start time of the window in UTC time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("startTime")]
    public V1beta1InstanceSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime? StartTime { get; set; }
}

/// <summary>
/// Maintenance policy for a cluster
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderMaintenancePolicy
{
    /// <summary>
    /// Optional. Maintenance window that is applied to resources covered by this policy.
    /// Minimum 1. For the current version, the maximum number
    /// of weekly_window is expected to be one.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta1InstanceSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}

/// <summary>
/// Managed backup source for the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderManagedBackupSource
{
    /// <summary>Example: projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}.</summary>
    [JsonPropertyName("backup")]
    public string? Backup { get; set; }
}

/// <summary>
/// Configuration for AOF based persistence.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderPersistenceConfigAofConfig
{
    /// <summary>
    /// Optional. The fsync mode.
    /// Possible values:
    /// NEVER
    /// EVERY_SEC
    /// ALWAYS
    /// </summary>
    [JsonPropertyName("appendFsync")]
    public string? AppendFsync { get; set; }
}

/// <summary>
/// Configuration for RDB based persistence.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderPersistenceConfigRdbConfig
{
    /// <summary>
    /// Optional. Period between RDB snapshots.
    /// Possible values:
    /// ONE_HOUR
    /// SIX_HOURS
    /// TWELVE_HOURS
    /// TWENTY_FOUR_HOURS
    /// </summary>
    [JsonPropertyName("rdbSnapshotPeriod")]
    public string? RdbSnapshotPeriod { get; set; }

    /// <summary>
    /// Optional. Time that the first snapshot was/will be attempted, and to which future
    /// snapshots will be aligned. If not provided, the current time will be
    /// used.
    /// </summary>
    [JsonPropertyName("rdbSnapshotStartTime")]
    public string? RdbSnapshotStartTime { get; set; }
}

/// <summary>
/// Represents persistence configuration for a instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderPersistenceConfig
{
    /// <summary>
    /// Configuration for AOF based persistence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aofConfig")]
    public V1beta1InstanceSpecInitProviderPersistenceConfigAofConfig? AofConfig { get; set; }

    /// <summary>
    /// Optional. Current persistence mode.
    /// Possible values:
    /// DISABLED
    /// RDB
    /// AOF
    /// Possible values are: DISABLED, RDB, AOF.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Configuration for RDB based persistence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rdbConfig")]
    public V1beta1InstanceSpecInitProviderPersistenceConfigRdbConfig? RdbConfig { get; set; }
}

/// <summary>
/// Zone distribution configuration for allocation of instance resources.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderZoneDistributionConfig
{
    /// <summary>
    /// Optional. Current zone distribution mode. Defaults to MULTI_ZONE.
    /// Possible values:
    /// MULTI_ZONE
    /// SINGLE_ZONE
    /// Possible values are: MULTI_ZONE, SINGLE_ZONE.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Optional. Defines zone where all resources will be allocated with SINGLE_ZONE mode.
    /// Ignored for MULTI_ZONE mode.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
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
public partial class V1beta1InstanceSpecInitProvider
{
    /// <summary>
    /// Optional. Immutable. Authorization mode of the instance. Possible values:
    /// AUTH_DISABLED
    /// IAM_AUTH
    /// </summary>
    [JsonPropertyName("authorizationMode")]
    public string? AuthorizationMode { get; set; }

    /// <summary>
    /// The automated backup config for a instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("automatedBackupConfig")]
    public V1beta1InstanceSpecInitProviderAutomatedBackupConfig? AutomatedBackupConfig { get; set; }

    /// <summary>
    /// Cross instance replication config
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("crossInstanceReplicationConfig")]
    public V1beta1InstanceSpecInitProviderCrossInstanceReplicationConfig? CrossInstanceReplicationConfig { get; set; }

    /// <summary>Optional. If set to true deletion of the instance will fail.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Immutable. User inputs for the auto-created endpoints connections.</summary>
    [JsonPropertyName("desiredAutoCreatedEndpoints")]
    public IList<V1beta1InstanceSpecInitProviderDesiredAutoCreatedEndpoints>? DesiredAutoCreatedEndpoints { get; set; }

    /// <summary>desired_psc_auto_connections is deprecated  Use desired_auto_created_endpoints instead.</summary>
    [JsonPropertyName("desiredPscAutoConnections")]
    public IList<V1beta1InstanceSpecInitProviderDesiredPscAutoConnections>? DesiredPscAutoConnections { get; set; }

    /// <summary>Optional. User-provided engine configurations for the instance.</summary>
    [JsonPropertyName("engineConfigs")]
    public IDictionary<string, string>? EngineConfigs { get; set; }

    /// <summary>Optional. Engine version of the instance.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>
    /// GCS source for the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsSource")]
    public V1beta1InstanceSpecInitProviderGcsSource? GcsSource { get; set; }

    /// <summary>The KMS key used to encrypt the at-rest data of the cluster</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>
    /// Optional. Labels to represent user-provided metadata.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Maintenance policy for a cluster
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1InstanceSpecInitProviderMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>
    /// Managed backup source for the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("managedBackupSource")]
    public V1beta1InstanceSpecInitProviderManagedBackupSource? ManagedBackupSource { get; set; }

    /// <summary>
    /// Optional. cluster or cluster-disabled.
    /// Possible values:
    /// CLUSTER
    /// CLUSTER_DISABLED
    /// Possible values are: CLUSTER, CLUSTER_DISABLED.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Optional. Machine type for individual nodes of the instance.
    /// Possible values:
    /// SHARED_CORE_NANO
    /// HIGHMEM_MEDIUM
    /// HIGHMEM_XLARGE
    /// STANDARD_SMALL
    /// </summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>
    /// Represents persistence configuration for a instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("persistenceConfig")]
    public V1beta1InstanceSpecInitProviderPersistenceConfig? PersistenceConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Optional. Number of replica nodes per shard. If omitted the default is 0 replicas.</summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>Required. Number of shards for the instance.</summary>
    [JsonPropertyName("shardCount")]
    public double? ShardCount { get; set; }

    /// <summary>
    /// Optional. Immutable. In-transit encryption mode of the instance.
    /// Possible values:
    /// TRANSIT_ENCRYPTION_DISABLED
    /// SERVER_AUTHENTICATION
    /// </summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }

    /// <summary>
    /// Zone distribution configuration for allocation of instance resources.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("zoneDistributionConfig")]
    public V1beta1InstanceSpecInitProviderZoneDistributionConfig? ZoneDistributionConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecManagementPoliciesEnum>))]
public enum V1beta1InstanceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1InstanceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstanceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1InstanceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecWriteConnectionSecretToRef
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
public partial class V1beta1InstanceSpec
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
    public V1beta1InstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1InstanceSpecForProvider ForProvider { get; set; }

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
    public V1beta1InstanceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1InstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Start time of the window in UTC time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderAutomatedBackupConfigFixedFrequencyScheduleStartTime
{
    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &quot;24:00:00&quot; for scenarios like business closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }
}

/// <summary>
/// Trigger automated backups at a fixed frequency.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderAutomatedBackupConfigFixedFrequencySchedule
{
    /// <summary>
    /// Start time of the window in UTC time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("startTime")]
    public V1beta1InstanceStatusAtProviderAutomatedBackupConfigFixedFrequencyScheduleStartTime? StartTime { get; set; }
}

/// <summary>
/// The automated backup config for a instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderAutomatedBackupConfig
{
    /// <summary>
    /// Trigger automated backups at a fixed frequency.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedFrequencySchedule")]
    public V1beta1InstanceStatusAtProviderAutomatedBackupConfigFixedFrequencySchedule? FixedFrequencySchedule { get; set; }

    /// <summary>
    /// How long to keep automated backups before the backups are deleted.
    /// The value should be between 1 day and 365 days. If not specified, the default value is 35 days.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;. The default_value is &quot;3024000s&quot;
    /// </summary>
    [JsonPropertyName("retention")]
    public string? Retention { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderCrossInstanceReplicationConfigMembershipPrimaryInstance
{
    /// <summary>The full resource path of the Nth instance in the format: projects/{project}/locations/{region}/instance/{instance-id}</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Output only. System assigned, unique identifier for the instance.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderCrossInstanceReplicationConfigMembershipSecondaryInstance
{
    /// <summary>The full resource path of the Nth instance in the format: projects/{project}/locations/{region}/instance/{instance-id}</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Output only. System assigned, unique identifier for the instance.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderCrossInstanceReplicationConfigMembership
{
    /// <summary>
    /// (Output)
    /// Details of the primary instance that is used as the replication source for all the secondary instances.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primaryInstance")]
    public IList<V1beta1InstanceStatusAtProviderCrossInstanceReplicationConfigMembershipPrimaryInstance>? PrimaryInstance { get; set; }

    /// <summary>
    /// (Output)
    /// List of secondary instances that are replicating from the primary instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secondaryInstance")]
    public IList<V1beta1InstanceStatusAtProviderCrossInstanceReplicationConfigMembershipSecondaryInstance>? SecondaryInstance { get; set; }
}

/// <summary>
/// This field is only set for a secondary instance. Details of the primary instance that is used as the replication source for this secondary instance. This is allowed to be set only for clusters whose cluster role is of type SECONDARY.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderCrossInstanceReplicationConfigPrimaryInstance
{
    /// <summary>The full resource path of the Nth instance in the format: projects/{project}/locations/{region}/instance/{instance-id}</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Output only. System assigned, unique identifier for the instance.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderCrossInstanceReplicationConfigSecondaryInstances
{
    /// <summary>The full resource path of the Nth instance in the format: projects/{project}/locations/{region}/instance/{instance-id}</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Output only. System assigned, unique identifier for the instance.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>
/// Cross instance replication config
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderCrossInstanceReplicationConfig
{
    /// <summary>The instance role supports the following values:</summary>
    [JsonPropertyName("instanceRole")]
    public string? InstanceRole { get; set; }

    /// <summary>
    /// (Output)
    /// An output only view of all the member instance participating in cross instance replication. This field is populated for all the member clusters irrespective of their cluster role.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("membership")]
    public IList<V1beta1InstanceStatusAtProviderCrossInstanceReplicationConfigMembership>? Membership { get; set; }

    /// <summary>
    /// This field is only set for a secondary instance. Details of the primary instance that is used as the replication source for this secondary instance. This is allowed to be set only for clusters whose cluster role is of type SECONDARY.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primaryInstance")]
    public V1beta1InstanceStatusAtProviderCrossInstanceReplicationConfigPrimaryInstance? PrimaryInstance { get; set; }

    /// <summary>
    /// List of secondary instances that are replicating from this primary cluster. This is allowed to be set only for instances whose cluster role is of type PRIMARY.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secondaryInstances")]
    public IList<V1beta1InstanceStatusAtProviderCrossInstanceReplicationConfigSecondaryInstances>? SecondaryInstances { get; set; }

    /// <summary>
    /// (Output)
    /// The last time cross instance replication config was updated.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderDesiredAutoCreatedEndpoints
{
    /// <summary>
    /// (Output)
    /// Output only. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderDesiredPscAutoConnections
{
    /// <summary>
    /// (Output)
    /// Output only. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderDiscoveryEndpoints
{
    /// <summary>
    /// (Output)
    /// Output only. IP address of the exposed endpoint clients connect to.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The network where the IP address of the discovery endpoint will be
    /// reserved, in the form of
    /// projects/{network_project}/global/networks/{network_id}.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The port number of the exposed endpoint.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// Detailed information of a PSC connection that is created through service connectivity automation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderEndpointsConnectionsPscAutoConnection
{
    /// <summary>
    /// (Output)
    /// Output Only. Type of a PSC Connection.
    /// Possible values:
    /// CONNECTION_TYPE_DISCOVERY
    /// CONNECTION_TYPE_PRIMARY
    /// CONNECTION_TYPE_READER
    /// </summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The URI of the consumer side forwarding rule.
    /// Format:
    /// projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}
    /// </summary>
    [JsonPropertyName("forwardingRule")]
    public string? ForwardingRule { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The IP allocated on the consumer network for the PSC forwarding rule.
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. Ports of the exposed endpoint.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The PSC connection id of the forwarding rule connected to the
    /// service attachment.
    /// </summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The service attachment which is the target of the PSC connection, in the form of projects/{project-id}/regions/{region}/serviceAttachments/{service-attachment-id}.
    /// </summary>
    [JsonPropertyName("serviceAttachment")]
    public string? ServiceAttachment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderEndpointsConnections
{
    /// <summary>
    /// Detailed information of a PSC connection that is created through service connectivity automation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscAutoConnection")]
    public V1beta1InstanceStatusAtProviderEndpointsConnectionsPscAutoConnection? PscAutoConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderEndpoints
{
    /// <summary>
    /// A group of PSC connections. They are created in the same VPC network, one for each service attachment in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("connections")]
    public IList<V1beta1InstanceStatusAtProviderEndpointsConnections>? Connections { get; set; }
}

/// <summary>
/// GCS source for the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderGcsSource
{
    /// <summary>
    /// URIs of the GCS objects to import.
    /// Example: gs://bucket1/object1, gs://bucket2/folder2/object2
    /// </summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>
/// Start time of the window in UTC time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime
{
    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &quot;24:00:00&quot; for scenarios like business closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59.
    /// An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>The day of week that maintenance updates occur.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>
    /// (Output)
    /// Duration of the maintenance window.
    /// The current window is fixed at 1 hour.
    /// A duration in seconds with up to nine fractional digits,
    /// terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// Start time of the window in UTC time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("startTime")]
    public V1beta1InstanceStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime? StartTime { get; set; }
}

/// <summary>
/// Maintenance policy for a cluster
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderMaintenancePolicy
{
    /// <summary>
    /// (Output)
    /// The time when the policy was created.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// (Output)
    /// The time when the policy was last updated.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// Optional. Maintenance window that is applied to resources covered by this policy.
    /// Minimum 1. For the current version, the maximum number
    /// of weekly_window is expected to be one.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta1InstanceStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderMaintenanceSchedule
{
    /// <summary>
    /// (Output)
    /// The end time of any upcoming scheduled maintenance for this cluster.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// (Output)
    /// The deadline that the maintenance schedule start time
    /// can not go beyond, including reschedule.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("scheduleDeadlineTime")]
    public string? ScheduleDeadlineTime { get; set; }

    /// <summary>
    /// (Output)
    /// The start time of any upcoming scheduled maintenance for this cluster.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>
/// Managed backup source for the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderManagedBackupSource
{
    /// <summary>Example: projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}.</summary>
    [JsonPropertyName("backup")]
    public string? Backup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderManagedServerCaCaCerts
{
    /// <summary>
    /// (Output)
    /// The certificates that form the CA chain, from leaf to root order
    /// </summary>
    [JsonPropertyName("certificates")]
    public IList<string>? Certificates { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderManagedServerCa
{
    /// <summary>
    /// (Output)
    /// The PEM encoded CA certificate chains for managed server authentication
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("caCerts")]
    public IList<V1beta1InstanceStatusAtProviderManagedServerCaCaCerts>? CaCerts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderNodeConfig
{
    /// <summary>
    /// (Output)
    /// Output only. Memory size in GB of the node.
    /// </summary>
    [JsonPropertyName("sizeGb")]
    public double? SizeGb { get; set; }
}

/// <summary>
/// Configuration for AOF based persistence.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderPersistenceConfigAofConfig
{
    /// <summary>
    /// Optional. The fsync mode.
    /// Possible values:
    /// NEVER
    /// EVERY_SEC
    /// ALWAYS
    /// </summary>
    [JsonPropertyName("appendFsync")]
    public string? AppendFsync { get; set; }
}

/// <summary>
/// Configuration for RDB based persistence.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderPersistenceConfigRdbConfig
{
    /// <summary>
    /// Optional. Period between RDB snapshots.
    /// Possible values:
    /// ONE_HOUR
    /// SIX_HOURS
    /// TWELVE_HOURS
    /// TWENTY_FOUR_HOURS
    /// </summary>
    [JsonPropertyName("rdbSnapshotPeriod")]
    public string? RdbSnapshotPeriod { get; set; }

    /// <summary>
    /// Optional. Time that the first snapshot was/will be attempted, and to which future
    /// snapshots will be aligned. If not provided, the current time will be
    /// used.
    /// </summary>
    [JsonPropertyName("rdbSnapshotStartTime")]
    public string? RdbSnapshotStartTime { get; set; }
}

/// <summary>
/// Represents persistence configuration for a instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderPersistenceConfig
{
    /// <summary>
    /// Configuration for AOF based persistence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aofConfig")]
    public V1beta1InstanceStatusAtProviderPersistenceConfigAofConfig? AofConfig { get; set; }

    /// <summary>
    /// Optional. Current persistence mode.
    /// Possible values:
    /// DISABLED
    /// RDB
    /// AOF
    /// Possible values are: DISABLED, RDB, AOF.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Configuration for RDB based persistence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rdbConfig")]
    public V1beta1InstanceStatusAtProviderPersistenceConfigRdbConfig? RdbConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderPscAttachmentDetails
{
    /// <summary>
    /// (Output)
    /// Service attachment URI which your self-created PscConnection should use as target.
    /// </summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>
    /// (Output)
    /// Service attachment URI which your self-created PscConnection should use as target.
    /// </summary>
    [JsonPropertyName("serviceAttachment")]
    public string? ServiceAttachment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderPscAutoConnections
{
    /// <summary>
    /// (Output)
    /// Output Only. Type of a PSC Connection.
    /// Possible values:
    /// CONNECTION_TYPE_DISCOVERY
    /// CONNECTION_TYPE_PRIMARY
    /// CONNECTION_TYPE_READER
    /// </summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The URI of the consumer side forwarding rule.
    /// Format:
    /// projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}
    /// </summary>
    [JsonPropertyName("forwardingRule")]
    public string? ForwardingRule { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The IP allocated on the consumer network for the PSC forwarding rule.
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. Ports of the exposed endpoint.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The consumer project_id where the forwarding rule is created from.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The PSC connection id of the forwarding rule connected to the
    /// service attachment.
    /// </summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }

    /// <summary>
    /// (Output)
    /// Output Only. The status of the PSC connection: whether a connection exists and ACTIVE or it no longer exists.
    /// Possible values:
    /// ACTIVE
    /// NOT_FOUND
    /// </summary>
    [JsonPropertyName("pscConnectionStatus")]
    public string? PscConnectionStatus { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The service attachment which is the target of the PSC connection, in the form of projects/{project-id}/regions/{region}/serviceAttachments/{service-attachment-id}.
    /// </summary>
    [JsonPropertyName("serviceAttachment")]
    public string? ServiceAttachment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderStateInfoUpdateInfo
{
    /// <summary>
    /// (Output)
    /// Output only. Target engine version for the instance.
    /// </summary>
    [JsonPropertyName("targetEngineVersion")]
    public string? TargetEngineVersion { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. Target node type for the instance.
    /// </summary>
    [JsonPropertyName("targetNodeType")]
    public string? TargetNodeType { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. Target number of replica nodes per shard for the instance.
    /// </summary>
    [JsonPropertyName("targetReplicaCount")]
    public double? TargetReplicaCount { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. Target number of shards for the instance.
    /// </summary>
    [JsonPropertyName("targetShardCount")]
    public double? TargetShardCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderStateInfo
{
    /// <summary>
    /// (Output)
    /// Represents information about instance with state UPDATING.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("updateInfo")]
    public IList<V1beta1InstanceStatusAtProviderStateInfoUpdateInfo>? UpdateInfo { get; set; }
}

/// <summary>
/// Zone distribution configuration for allocation of instance resources.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderZoneDistributionConfig
{
    /// <summary>
    /// Optional. Current zone distribution mode. Defaults to MULTI_ZONE.
    /// Possible values:
    /// MULTI_ZONE
    /// SINGLE_ZONE
    /// Possible values are: MULTI_ZONE, SINGLE_ZONE.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Optional. Defines zone where all resources will be allocated with SINGLE_ZONE mode.
    /// Ignored for MULTI_ZONE mode.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProvider
{
    /// <summary>
    /// Optional. Immutable. Authorization mode of the instance. Possible values:
    /// AUTH_DISABLED
    /// IAM_AUTH
    /// </summary>
    [JsonPropertyName("authorizationMode")]
    public string? AuthorizationMode { get; set; }

    /// <summary>
    /// The automated backup config for a instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("automatedBackupConfig")]
    public V1beta1InstanceStatusAtProviderAutomatedBackupConfig? AutomatedBackupConfig { get; set; }

    /// <summary>
    /// The backup collection full resource name.
    /// Example: projects/{project}/locations/{location}/backupCollections/{collection}
    /// </summary>
    [JsonPropertyName("backupCollection")]
    public string? BackupCollection { get; set; }

    /// <summary>Output only. Creation timestamp of the instance.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Cross instance replication config
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("crossInstanceReplicationConfig")]
    public V1beta1InstanceStatusAtProviderCrossInstanceReplicationConfig? CrossInstanceReplicationConfig { get; set; }

    /// <summary>Optional. If set to true deletion of the instance will fail.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Immutable. User inputs for the auto-created endpoints connections.</summary>
    [JsonPropertyName("desiredAutoCreatedEndpoints")]
    public IList<V1beta1InstanceStatusAtProviderDesiredAutoCreatedEndpoints>? DesiredAutoCreatedEndpoints { get; set; }

    /// <summary>desired_psc_auto_connections is deprecated  Use desired_auto_created_endpoints instead.</summary>
    [JsonPropertyName("desiredPscAutoConnections")]
    public IList<V1beta1InstanceStatusAtProviderDesiredPscAutoConnections>? DesiredPscAutoConnections { get; set; }

    /// <summary>
    /// (Deprecated)
    /// Deprecated. Output only. Endpoints clients can connect to the instance through.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("discoveryEndpoints")]
    public IList<V1beta1InstanceStatusAtProviderDiscoveryEndpoints>? DiscoveryEndpoints { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// Endpoints for the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("endpoints")]
    public IList<V1beta1InstanceStatusAtProviderEndpoints>? Endpoints { get; set; }

    /// <summary>Optional. User-provided engine configurations for the instance.</summary>
    [JsonPropertyName("engineConfigs")]
    public IDictionary<string, string>? EngineConfigs { get; set; }

    /// <summary>Optional. Engine version of the instance.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>
    /// GCS source for the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsSource")]
    public V1beta1InstanceStatusAtProviderGcsSource? GcsSource { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/instances/{{instance_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The KMS key used to encrypt the at-rest data of the cluster</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>
    /// Optional. Labels to represent user-provided metadata.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Resource ID segment making up resource name. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type memorystore.googleapis.com/CertificateAuthority.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Maintenance policy for a cluster
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1InstanceStatusAtProviderMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>
    /// Upcoming maintenance schedule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta1InstanceStatusAtProviderMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>
    /// Managed backup source for the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("managedBackupSource")]
    public V1beta1InstanceStatusAtProviderManagedBackupSource? ManagedBackupSource { get; set; }

    /// <summary>
    /// Instance&apos;s Certificate Authority. This field will only be populated if instance&apos;s transit_encryption_mode is SERVER_AUTHENTICATION
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("managedServerCa")]
    public IList<V1beta1InstanceStatusAtProviderManagedServerCa>? ManagedServerCa { get; set; }

    /// <summary>
    /// Optional. cluster or cluster-disabled.
    /// Possible values:
    /// CLUSTER
    /// CLUSTER_DISABLED
    /// Possible values are: CLUSTER, CLUSTER_DISABLED.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Identifier. Unique name of the instance.
    /// Format: projects/{project}/locations/{location}/instances/{instance}
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Represents configuration for nodes of the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1InstanceStatusAtProviderNodeConfig>? NodeConfig { get; set; }

    /// <summary>
    /// Optional. Machine type for individual nodes of the instance.
    /// Possible values:
    /// SHARED_CORE_NANO
    /// HIGHMEM_MEDIUM
    /// HIGHMEM_XLARGE
    /// STANDARD_SMALL
    /// </summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>
    /// Represents persistence configuration for a instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("persistenceConfig")]
    public V1beta1InstanceStatusAtProviderPersistenceConfig? PersistenceConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Configuration of a service attachment of the cluster, for creating PSC connections.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscAttachmentDetails")]
    public IList<V1beta1InstanceStatusAtProviderPscAttachmentDetails>? PscAttachmentDetails { get; set; }

    /// <summary>
    /// (Deprecated)
    /// Output only. User inputs and resource details of the auto-created PSC connections.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pscAutoConnections")]
    public IList<V1beta1InstanceStatusAtProviderPscAutoConnections>? PscAutoConnections { get; set; }

    /// <summary>Optional. Number of replica nodes per shard. If omitted the default is 0 replicas.</summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>Required. Number of shards for the instance.</summary>
    [JsonPropertyName("shardCount")]
    public double? ShardCount { get; set; }

    /// <summary>
    /// Output only. Current state of the instance.
    /// Possible values:
    /// CREATING
    /// ACTIVE
    /// UPDATING
    /// DELETING
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// Additional information about the state of the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("stateInfo")]
    public IList<V1beta1InstanceStatusAtProviderStateInfo>? StateInfo { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>
    /// Optional. Immutable. In-transit encryption mode of the instance.
    /// Possible values:
    /// TRANSIT_ENCRYPTION_DISABLED
    /// SERVER_AUTHENTICATION
    /// </summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }

    /// <summary>Output only. System assigned, unique identifier for the instance.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Latest update timestamp of the instance.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// Zone distribution configuration for allocation of instance resources.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("zoneDistributionConfig")]
    public V1beta1InstanceStatusAtProviderZoneDistributionConfig? ZoneDistributionConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusConditions
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
public partial class V1beta1InstanceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Instance is the Schema for the Instances API. A Google Cloud Memorystore instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceSpec>, IStatus<V1beta1InstanceStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "memorystore.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorystore.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Instance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public required V1beta1InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceStatus? Status { get; set; }
}