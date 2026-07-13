#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.memcache.gcp.upbound.io;
/// <summary>Instance is the Schema for the Instances API. A Google Cloud Memcache instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Instance>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceList";
    public const string KubeGroup = "memcache.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memcache.gcp.upbound.io/v1beta2";

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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderAuthorizedNetworkRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderAuthorizedNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderAuthorizedNetworkRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderAuthorizedNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderAuthorizedNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderAuthorizedNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderAuthorizedNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Connection in servicenetworking to populate authorizedNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderAuthorizedNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecForProviderAuthorizedNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderAuthorizedNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderAuthorizedNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderAuthorizedNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderAuthorizedNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderAuthorizedNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderAuthorizedNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderAuthorizedNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Connection in servicenetworking to populate authorizedNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderAuthorizedNetworkSelector
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
    public V1beta2InstanceSpecForProviderAuthorizedNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Required. Start time of the window in UTC time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime
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
public partial class V1beta2InstanceSpecForProviderMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>Required. The day of week that maintenance updates occur.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>
    /// Required. The length of the maintenance window, ranging from 3 hours to 8 hours.
    /// A duration in seconds with up to nine fractional digits,
    /// terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// Required. Start time of the window in UTC time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("startTime")]
    public V1beta2InstanceSpecForProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime? StartTime { get; set; }
}

/// <summary>
/// Maintenance policy for an instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderMaintenancePolicy
{
    /// <summary>
    /// Optional. Description of what this policy is for.
    /// Create/Update methods return INVALID_ARGUMENT if the
    /// length is greater than 512.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Required. Maintenance window that is applied to resources covered by this policy.
    /// Minimum 1. For the current version, the maximum number of weekly_maintenance_windows
    /// is expected to be one.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta2InstanceSpecForProviderMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}

/// <summary>
/// User-specified parameters for this memcache instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderMemcacheParameters
{
    /// <summary>User-defined set of parameters to use in the memcache process.</summary>
    [JsonPropertyName("params")]
    public IDictionary<string, string>? Params { get; set; }
}

/// <summary>
/// Configuration for memcache nodes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderNodeConfig
{
    /// <summary>Number of CPUs per node.</summary>
    [JsonPropertyName("cpuCount")]
    public double? CpuCount { get; set; }

    /// <summary>Memory size in Mebibytes for each memcache node.</summary>
    [JsonPropertyName("memorySizeMb")]
    public double? MemorySizeMb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProvider
{
    /// <summary>
    /// The full name of the GCE network to connect the instance to.  If not provided,
    /// &apos;default&apos; will be used.
    /// </summary>
    [JsonPropertyName("authorizedNetwork")]
    public string? AuthorizedNetwork { get; set; }

    /// <summary>Reference to a Connection in servicenetworking to populate authorizedNetwork.</summary>
    [JsonPropertyName("authorizedNetworkRef")]
    public V1beta2InstanceSpecForProviderAuthorizedNetworkRef? AuthorizedNetworkRef { get; set; }

    /// <summary>Selector for a Connection in servicenetworking to populate authorizedNetwork.</summary>
    [JsonPropertyName("authorizedNetworkSelector")]
    public V1beta2InstanceSpecForProviderAuthorizedNetworkSelector? AuthorizedNetworkSelector { get; set; }

    /// <summary>A user-visible name for the instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Resource labels to represent user-provided metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Maintenance policy for an instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta2InstanceSpecForProviderMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>
    /// User-specified parameters for this memcache instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("memcacheParameters")]
    public V1beta2InstanceSpecForProviderMemcacheParameters? MemcacheParameters { get; set; }

    /// <summary>
    /// The major version of Memcached software. If not provided, latest supported version will be used.
    /// Currently the latest supported major version is MEMCACHE_1_5. The minor version will be automatically
    /// determined by our system based on the latest supported minor version.
    /// Default value is MEMCACHE_1_5.
    /// Possible values are: MEMCACHE_1_5, MEMCACHE_1_6_15.
    /// </summary>
    [JsonPropertyName("memcacheVersion")]
    public string? MemcacheVersion { get; set; }

    /// <summary>The resource name of the instance.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Configuration for memcache nodes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta2InstanceSpecForProviderNodeConfig? NodeConfig { get; set; }

    /// <summary>Number of nodes in the memcache instance.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the Memcache instance. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Contains the name of allocated IP address ranges associated with
    /// the private service access connection for example, &quot;test-default&quot;
    /// associated with IP range 10.0.0.0/29.
    /// </summary>
    [JsonPropertyName("reservedIpRangeId")]
    public IList<string>? ReservedIpRangeId { get; set; }

    /// <summary>
    /// Zones where memcache nodes should be provisioned.  If not
    /// provided, all zones will be used.
    /// </summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderAuthorizedNetworkRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderAuthorizedNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderAuthorizedNetworkRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderAuthorizedNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderAuthorizedNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderAuthorizedNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderAuthorizedNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Connection in servicenetworking to populate authorizedNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderAuthorizedNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecInitProviderAuthorizedNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderAuthorizedNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderAuthorizedNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderAuthorizedNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderAuthorizedNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderAuthorizedNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderAuthorizedNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderAuthorizedNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Connection in servicenetworking to populate authorizedNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderAuthorizedNetworkSelector
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
    public V1beta2InstanceSpecInitProviderAuthorizedNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Required. Start time of the window in UTC time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime
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
public partial class V1beta2InstanceSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>Required. The day of week that maintenance updates occur.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>
    /// Required. The length of the maintenance window, ranging from 3 hours to 8 hours.
    /// A duration in seconds with up to nine fractional digits,
    /// terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// Required. Start time of the window in UTC time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("startTime")]
    public V1beta2InstanceSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime? StartTime { get; set; }
}

/// <summary>
/// Maintenance policy for an instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderMaintenancePolicy
{
    /// <summary>
    /// Optional. Description of what this policy is for.
    /// Create/Update methods return INVALID_ARGUMENT if the
    /// length is greater than 512.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Required. Maintenance window that is applied to resources covered by this policy.
    /// Minimum 1. For the current version, the maximum number of weekly_maintenance_windows
    /// is expected to be one.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta2InstanceSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}

/// <summary>
/// User-specified parameters for this memcache instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderMemcacheParameters
{
    /// <summary>User-defined set of parameters to use in the memcache process.</summary>
    [JsonPropertyName("params")]
    public IDictionary<string, string>? Params { get; set; }
}

/// <summary>
/// Configuration for memcache nodes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderNodeConfig
{
    /// <summary>Number of CPUs per node.</summary>
    [JsonPropertyName("cpuCount")]
    public double? CpuCount { get; set; }

    /// <summary>Memory size in Mebibytes for each memcache node.</summary>
    [JsonPropertyName("memorySizeMb")]
    public double? MemorySizeMb { get; set; }
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
    /// <summary>
    /// The full name of the GCE network to connect the instance to.  If not provided,
    /// &apos;default&apos; will be used.
    /// </summary>
    [JsonPropertyName("authorizedNetwork")]
    public string? AuthorizedNetwork { get; set; }

    /// <summary>Reference to a Connection in servicenetworking to populate authorizedNetwork.</summary>
    [JsonPropertyName("authorizedNetworkRef")]
    public V1beta2InstanceSpecInitProviderAuthorizedNetworkRef? AuthorizedNetworkRef { get; set; }

    /// <summary>Selector for a Connection in servicenetworking to populate authorizedNetwork.</summary>
    [JsonPropertyName("authorizedNetworkSelector")]
    public V1beta2InstanceSpecInitProviderAuthorizedNetworkSelector? AuthorizedNetworkSelector { get; set; }

    /// <summary>A user-visible name for the instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Resource labels to represent user-provided metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Maintenance policy for an instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta2InstanceSpecInitProviderMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>
    /// User-specified parameters for this memcache instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("memcacheParameters")]
    public V1beta2InstanceSpecInitProviderMemcacheParameters? MemcacheParameters { get; set; }

    /// <summary>
    /// The major version of Memcached software. If not provided, latest supported version will be used.
    /// Currently the latest supported major version is MEMCACHE_1_5. The minor version will be automatically
    /// determined by our system based on the latest supported minor version.
    /// Default value is MEMCACHE_1_5.
    /// Possible values are: MEMCACHE_1_5, MEMCACHE_1_6_15.
    /// </summary>
    [JsonPropertyName("memcacheVersion")]
    public string? MemcacheVersion { get; set; }

    /// <summary>The resource name of the instance.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Configuration for memcache nodes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta2InstanceSpecInitProviderNodeConfig? NodeConfig { get; set; }

    /// <summary>Number of nodes in the memcache instance.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the Memcache instance. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Contains the name of allocated IP address ranges associated with
    /// the private service access connection for example, &quot;test-default&quot;
    /// associated with IP range 10.0.0.0/29.
    /// </summary>
    [JsonPropertyName("reservedIpRangeId")]
    public IList<string>? ReservedIpRangeId { get; set; }

    /// <summary>
    /// Zones where memcache nodes should be provisioned.  If not
    /// provided, all zones will be used.
    /// </summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
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

/// <summary>
/// Required. Start time of the window in UTC time.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime
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
public partial class V1beta2InstanceStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>Required. The day of week that maintenance updates occur.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>
    /// Required. The length of the maintenance window, ranging from 3 hours to 8 hours.
    /// A duration in seconds with up to nine fractional digits,
    /// terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// Required. Start time of the window in UTC time.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("startTime")]
    public V1beta2InstanceStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime? StartTime { get; set; }
}

/// <summary>
/// Maintenance policy for an instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderMaintenancePolicy
{
    /// <summary>
    /// (Output)
    /// Output only. The time when the policy was created.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Optional. Description of what this policy is for.
    /// Create/Update methods return INVALID_ARGUMENT if the
    /// length is greater than 512.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The time when the policy was updated.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// Required. Maintenance window that is applied to resources covered by this policy.
    /// Minimum 1. For the current version, the maximum number of weekly_maintenance_windows
    /// is expected to be one.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta2InstanceStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderMaintenanceSchedule
{
    /// <summary>
    /// (Output)
    /// Output only. The end time of any upcoming scheduled maintenance for this instance.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The deadline that the maintenance schedule start time
    /// can not go beyond, including reschedule.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("scheduleDeadlineTime")]
    public string? ScheduleDeadlineTime { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The start time of any upcoming scheduled maintenance for this instance.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderMemcacheNodes
{
    /// <summary>
    /// (Output)
    /// Hostname or IP address of the Memcached node used by the clients to connect to the Memcached server on this node.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// (Output)
    /// Identifier of the Memcached node. The node id does not include project or location like the Memcached instance name.
    /// </summary>
    [JsonPropertyName("nodeId")]
    public string? NodeId { get; set; }

    /// <summary>
    /// (Output)
    /// The port number of the Memcached server on this node.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// (Output)
    /// Current state of the Memcached node.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// (Output)
    /// Location (GCP Zone) for the Memcached node.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>
/// User-specified parameters for this memcache instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderMemcacheParameters
{
    /// <summary>
    /// (Output)
    /// This is a unique ID associated with this set of parameters.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>User-defined set of parameters to use in the memcache process.</summary>
    [JsonPropertyName("params")]
    public IDictionary<string, string>? Params { get; set; }
}

/// <summary>
/// Configuration for memcache nodes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderNodeConfig
{
    /// <summary>Number of CPUs per node.</summary>
    [JsonPropertyName("cpuCount")]
    public double? CpuCount { get; set; }

    /// <summary>Memory size in Mebibytes for each memcache node.</summary>
    [JsonPropertyName("memorySizeMb")]
    public double? MemorySizeMb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProvider
{
    /// <summary>
    /// The full name of the GCE network to connect the instance to.  If not provided,
    /// &apos;default&apos; will be used.
    /// </summary>
    [JsonPropertyName("authorizedNetwork")]
    public string? AuthorizedNetwork { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Endpoint for Discovery API</summary>
    [JsonPropertyName("discoveryEndpoint")]
    public string? DiscoveryEndpoint { get; set; }

    /// <summary>A user-visible name for the instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{region}}/instances/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Resource labels to represent user-provided metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Maintenance policy for an instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta2InstanceStatusAtProviderMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>
    /// Output only. Published maintenance schedule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta2InstanceStatusAtProviderMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>The full version of memcached server running on this instance.</summary>
    [JsonPropertyName("memcacheFullVersion")]
    public string? MemcacheFullVersion { get; set; }

    /// <summary>
    /// Additional information about the instance state, if available.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("memcacheNodes")]
    public IList<V1beta2InstanceStatusAtProviderMemcacheNodes>? MemcacheNodes { get; set; }

    /// <summary>
    /// User-specified parameters for this memcache instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("memcacheParameters")]
    public V1beta2InstanceStatusAtProviderMemcacheParameters? MemcacheParameters { get; set; }

    /// <summary>
    /// The major version of Memcached software. If not provided, latest supported version will be used.
    /// Currently the latest supported major version is MEMCACHE_1_5. The minor version will be automatically
    /// determined by our system based on the latest supported minor version.
    /// Default value is MEMCACHE_1_5.
    /// Possible values are: MEMCACHE_1_5, MEMCACHE_1_6_15.
    /// </summary>
    [JsonPropertyName("memcacheVersion")]
    public string? MemcacheVersion { get; set; }

    /// <summary>The resource name of the instance.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Configuration for memcache nodes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta2InstanceStatusAtProviderNodeConfig? NodeConfig { get; set; }

    /// <summary>Number of nodes in the memcache instance.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the Memcache instance. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Contains the name of allocated IP address ranges associated with
    /// the private service access connection for example, &quot;test-default&quot;
    /// associated with IP range 10.0.0.0/29.
    /// </summary>
    [JsonPropertyName("reservedIpRangeId")]
    public IList<string>? ReservedIpRangeId { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>
    /// Zones where memcache nodes should be provisioned.  If not
    /// provided, all zones will be used.
    /// </summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
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

/// <summary>Instance is the Schema for the Instances API. A Google Cloud Memcache instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2InstanceSpec>, IStatus<V1beta2InstanceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "memcache.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memcache.gcp.upbound.io/v1beta2";

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