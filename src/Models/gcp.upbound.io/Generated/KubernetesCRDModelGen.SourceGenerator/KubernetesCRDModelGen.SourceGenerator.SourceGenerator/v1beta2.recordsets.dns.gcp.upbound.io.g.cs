#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dns.gcp.upbound.io;
/// <summary>RecordSet is the Schema for the RecordSets API. Manages a set of DNS records within Google Cloud DNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RecordSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta2RecordSet>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RecordSetList";
    public const string KubeGroup = "dns.gcp.upbound.io";
    public const string KubePluralName = "recordsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dns.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RecordSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2RecordSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2RecordSet> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecDeletionPolicyEnum>))]
public enum V1beta2RecordSetSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderManagedZoneRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecForProviderManagedZoneRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderManagedZoneRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecForProviderManagedZoneRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderManagedZoneRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecForProviderManagedZoneRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecForProviderManagedZoneRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedZone in dns to populate managedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderManagedZoneRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecForProviderManagedZoneRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderManagedZoneSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecForProviderManagedZoneSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderManagedZoneSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecForProviderManagedZoneSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderManagedZoneSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecForProviderManagedZoneSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecForProviderManagedZoneSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedZone in dns to populate managedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderManagedZoneSelector
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
    public V1beta2RecordSetSpecForProviderManagedZoneSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&quot;tcp&quot;, &quot;udp&quot;]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: [&quot;regionalL4ilb&quot;, &quot;regionalL7ilb&quot;, &quot;globalL7ilb&quot;]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta2RecordSetSpecForProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyGeo
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckSelector
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
    public V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&quot;tcp&quot;, &quot;udp&quot;]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: [&quot;regionalL4ilb&quot;, &quot;regionalL7ilb&quot;, &quot;globalL7ilb&quot;]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeo
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelector
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
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelector
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
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelector
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
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelector
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
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressRef")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef? IpAddressRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressSelector")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelector? IpAddressSelector { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&quot;tcp&quot;, &quot;udp&quot;]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: [&quot;regionalL4ilb&quot;, &quot;regionalL7ilb&quot;, &quot;globalL7ilb&quot;]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelector? NetworkUrlSelector { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelector? ProjectSelector { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate region.</summary>
    [JsonPropertyName("regionRef")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef? RegionRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate region.</summary>
    [JsonPropertyName("regionSelector")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelector? RegionSelector { get; set; }
}

/// <summary>
/// The list of global primary targets to be health checked.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimary
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

/// <summary>
/// The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackup
{
    /// <summary>
    /// The backup geo targets, which provide a regional failover policy for the otherwise global primary targets.
    /// Structure is document above.
    /// </summary>
    [JsonPropertyName("backupGeo")]
    public IList<V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeo>? BackupGeo { get; set; }

    /// <summary>Specifies whether to enable fencing for backup geo queries.</summary>
    [JsonPropertyName("enableGeoFencingForBackups")]
    public bool? EnableGeoFencingForBackups { get; set; }

    /// <summary>
    /// The list of global primary targets to be health checked.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primary")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimary? Primary { get; set; }

    /// <summary>Specifies the percentage of traffic to send to the backup targets even when the primary targets are healthy.</summary>
    [JsonPropertyName("trickleRatio")]
    public double? TrickleRatio { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&quot;tcp&quot;, &quot;udp&quot;]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: [&quot;regionalL4ilb&quot;, &quot;regionalL7ilb&quot;, &quot;globalL7ilb&quot;]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyWrrHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta2RecordSetSpecForProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicyWrr
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyWrrHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>The ratio of traffic routed to the target.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// The configuration for steering traffic based on query.
/// Now you can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProviderRoutingPolicy
{
    /// <summary>Specifies whether to enable fencing for geo queries.</summary>
    [JsonPropertyName("enableGeoFencing")]
    public bool? EnableGeoFencing { get; set; }

    /// <summary>
    /// The configuration for Geolocation based routing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("geo")]
    public IList<V1beta2RecordSetSpecForProviderRoutingPolicyGeo>? Geo { get; set; }

    /// <summary>Specifies the health check (used with external endpoints).</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckSelector")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyHealthCheckSelector? HealthCheckSelector { get; set; }

    /// <summary>
    /// The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primaryBackup")]
    public V1beta2RecordSetSpecForProviderRoutingPolicyPrimaryBackup? PrimaryBackup { get; set; }

    /// <summary>
    /// The configuration for Weighted Round Robin based routing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wrr")]
    public IList<V1beta2RecordSetSpecForProviderRoutingPolicyWrr>? Wrr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecForProvider
{
    /// <summary>
    /// The name of the zone in which this record set will
    /// reside.
    /// </summary>
    [JsonPropertyName("managedZone")]
    public string? ManagedZone { get; set; }

    /// <summary>Reference to a ManagedZone in dns to populate managedZone.</summary>
    [JsonPropertyName("managedZoneRef")]
    public V1beta2RecordSetSpecForProviderManagedZoneRef? ManagedZoneRef { get; set; }

    /// <summary>Selector for a ManagedZone in dns to populate managedZone.</summary>
    [JsonPropertyName("managedZoneSelector")]
    public V1beta2RecordSetSpecForProviderManagedZoneSelector? ManagedZoneSelector { get; set; }

    /// <summary>The DNS name this record set will apply to.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The configuration for steering traffic based on query.
    /// Now you can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("routingPolicy")]
    public V1beta2RecordSetSpecForProviderRoutingPolicy? RoutingPolicy { get; set; }

    /// <summary>
    /// The string data for the records in this record set
    /// whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding \&quot; if you don&apos;t want your string to get split on spaces.g. &quot;first255characters\&quot; \&quot;morecharacters&quot;).
    /// </summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>The time-to-live of this record set (seconds).</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The DNS record set type.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderManagedZoneRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecInitProviderManagedZoneRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderManagedZoneRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecInitProviderManagedZoneRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderManagedZoneRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecInitProviderManagedZoneRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecInitProviderManagedZoneRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedZone in dns to populate managedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderManagedZoneRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecInitProviderManagedZoneRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderManagedZoneSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecInitProviderManagedZoneSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderManagedZoneSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecInitProviderManagedZoneSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderManagedZoneSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecInitProviderManagedZoneSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecInitProviderManagedZoneSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedZone in dns to populate managedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderManagedZoneSelector
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
    public V1beta2RecordSetSpecInitProviderManagedZoneSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&quot;tcp&quot;, &quot;udp&quot;]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: [&quot;regionalL4ilb&quot;, &quot;regionalL7ilb&quot;, &quot;globalL7ilb&quot;]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta2RecordSetSpecInitProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyGeo
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckSelector
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
    public V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&quot;tcp&quot;, &quot;udp&quot;]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: [&quot;regionalL4ilb&quot;, &quot;regionalL7ilb&quot;, &quot;globalL7ilb&quot;]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeo
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelector
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
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelector
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
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelector
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
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelector
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
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressRef")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef? IpAddressRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressSelector")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelector? IpAddressSelector { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&quot;tcp&quot;, &quot;udp&quot;]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: [&quot;regionalL4ilb&quot;, &quot;regionalL7ilb&quot;, &quot;globalL7ilb&quot;]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelector? NetworkUrlSelector { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelector? ProjectSelector { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate region.</summary>
    [JsonPropertyName("regionRef")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef? RegionRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate region.</summary>
    [JsonPropertyName("regionSelector")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelector? RegionSelector { get; set; }
}

/// <summary>
/// The list of global primary targets to be health checked.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimary
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

/// <summary>
/// The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackup
{
    /// <summary>
    /// The backup geo targets, which provide a regional failover policy for the otherwise global primary targets.
    /// Structure is document above.
    /// </summary>
    [JsonPropertyName("backupGeo")]
    public IList<V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeo>? BackupGeo { get; set; }

    /// <summary>Specifies whether to enable fencing for backup geo queries.</summary>
    [JsonPropertyName("enableGeoFencingForBackups")]
    public bool? EnableGeoFencingForBackups { get; set; }

    /// <summary>
    /// The list of global primary targets to be health checked.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primary")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimary? Primary { get; set; }

    /// <summary>Specifies the percentage of traffic to send to the backup targets even when the primary targets are healthy.</summary>
    [JsonPropertyName("trickleRatio")]
    public double? TrickleRatio { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&quot;tcp&quot;, &quot;udp&quot;]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: [&quot;regionalL4ilb&quot;, &quot;regionalL7ilb&quot;, &quot;globalL7ilb&quot;]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyWrrHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta2RecordSetSpecInitProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicyWrr
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyWrrHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>The ratio of traffic routed to the target.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// The configuration for steering traffic based on query.
/// Now you can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecInitProviderRoutingPolicy
{
    /// <summary>Specifies whether to enable fencing for geo queries.</summary>
    [JsonPropertyName("enableGeoFencing")]
    public bool? EnableGeoFencing { get; set; }

    /// <summary>
    /// The configuration for Geolocation based routing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("geo")]
    public IList<V1beta2RecordSetSpecInitProviderRoutingPolicyGeo>? Geo { get; set; }

    /// <summary>Specifies the health check (used with external endpoints).</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckSelector")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyHealthCheckSelector? HealthCheckSelector { get; set; }

    /// <summary>
    /// The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primaryBackup")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicyPrimaryBackup? PrimaryBackup { get; set; }

    /// <summary>
    /// The configuration for Weighted Round Robin based routing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wrr")]
    public IList<V1beta2RecordSetSpecInitProviderRoutingPolicyWrr>? Wrr { get; set; }
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
public partial class V1beta2RecordSetSpecInitProvider
{
    /// <summary>
    /// The name of the zone in which this record set will
    /// reside.
    /// </summary>
    [JsonPropertyName("managedZone")]
    public string? ManagedZone { get; set; }

    /// <summary>Reference to a ManagedZone in dns to populate managedZone.</summary>
    [JsonPropertyName("managedZoneRef")]
    public V1beta2RecordSetSpecInitProviderManagedZoneRef? ManagedZoneRef { get; set; }

    /// <summary>Selector for a ManagedZone in dns to populate managedZone.</summary>
    [JsonPropertyName("managedZoneSelector")]
    public V1beta2RecordSetSpecInitProviderManagedZoneSelector? ManagedZoneSelector { get; set; }

    /// <summary>The DNS name this record set will apply to.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The configuration for steering traffic based on query.
    /// Now you can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("routingPolicy")]
    public V1beta2RecordSetSpecInitProviderRoutingPolicy? RoutingPolicy { get; set; }

    /// <summary>
    /// The string data for the records in this record set
    /// whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding \&quot; if you don&apos;t want your string to get split on spaces.g. &quot;first255characters\&quot; \&quot;morecharacters&quot;).
    /// </summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>The time-to-live of this record set (seconds).</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The DNS record set type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecManagementPoliciesEnum>))]
public enum V1beta2RecordSetSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2RecordSetSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSetSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2RecordSetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RecordSetSpec defines the desired state of RecordSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetSpec
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
    public V1beta2RecordSetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2RecordSetSpecForProvider ForProvider { get; set; }

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
    public V1beta2RecordSetSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2RecordSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RecordSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RecordSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&quot;tcp&quot;, &quot;udp&quot;]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: [&quot;regionalL4ilb&quot;, &quot;regionalL7ilb&quot;, &quot;globalL7ilb&quot;]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicyGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta2RecordSetStatusAtProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicyGeo
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta2RecordSetStatusAtProviderRoutingPolicyGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&quot;tcp&quot;, &quot;udp&quot;]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: [&quot;regionalL4ilb&quot;, &quot;regionalL7ilb&quot;, &quot;globalL7ilb&quot;]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta2RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeo
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta2RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&quot;tcp&quot;, &quot;udp&quot;]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: [&quot;regionalL4ilb&quot;, &quot;regionalL7ilb&quot;, &quot;globalL7ilb&quot;]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// The list of global primary targets to be health checked.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicyPrimaryBackupPrimary
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta2RecordSetStatusAtProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

/// <summary>
/// The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicyPrimaryBackup
{
    /// <summary>
    /// The backup geo targets, which provide a regional failover policy for the otherwise global primary targets.
    /// Structure is document above.
    /// </summary>
    [JsonPropertyName("backupGeo")]
    public IList<V1beta2RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeo>? BackupGeo { get; set; }

    /// <summary>Specifies whether to enable fencing for backup geo queries.</summary>
    [JsonPropertyName("enableGeoFencingForBackups")]
    public bool? EnableGeoFencingForBackups { get; set; }

    /// <summary>
    /// The list of global primary targets to be health checked.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primary")]
    public V1beta2RecordSetStatusAtProviderRoutingPolicyPrimaryBackupPrimary? Primary { get; set; }

    /// <summary>Specifies the percentage of traffic to send to the backup targets even when the primary targets are healthy.</summary>
    [JsonPropertyName("trickleRatio")]
    public double? TrickleRatio { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&quot;tcp&quot;, &quot;udp&quot;]</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>The type of load balancer. This value is case-sensitive. Possible values: [&quot;regionalL4ilb&quot;, &quot;regionalL7ilb&quot;, &quot;globalL7ilb&quot;]</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>The fully qualified url of the network in which the load balancer belongs. This should be formatted like projects/{project}/global/networks/{network} or https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}.</summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>The configured port of the load balancer.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicyWrrHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta2RecordSetStatusAtProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicyWrr
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta2RecordSetStatusAtProviderRoutingPolicyWrrHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>The ratio of traffic routed to the target.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// The configuration for steering traffic based on query.
/// Now you can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProviderRoutingPolicy
{
    /// <summary>Specifies whether to enable fencing for geo queries.</summary>
    [JsonPropertyName("enableGeoFencing")]
    public bool? EnableGeoFencing { get; set; }

    /// <summary>
    /// The configuration for Geolocation based routing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("geo")]
    public IList<V1beta2RecordSetStatusAtProviderRoutingPolicyGeo>? Geo { get; set; }

    /// <summary>Specifies the health check (used with external endpoints).</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>
    /// The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primaryBackup")]
    public V1beta2RecordSetStatusAtProviderRoutingPolicyPrimaryBackup? PrimaryBackup { get; set; }

    /// <summary>
    /// The configuration for Weighted Round Robin based routing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wrr")]
    public IList<V1beta2RecordSetStatusAtProviderRoutingPolicyWrr>? Wrr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusAtProvider
{
    /// <summary>an identifier for the resource with format projects/{{project}}/managedZones/{{zone}}/rrsets/{{name}}/{{type}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The name of the zone in which this record set will
    /// reside.
    /// </summary>
    [JsonPropertyName("managedZone")]
    public string? ManagedZone { get; set; }

    /// <summary>The DNS name this record set will apply to.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The configuration for steering traffic based on query.
    /// Now you can specify either Weighted Round Robin(WRR) type or Geolocation(GEO) type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("routingPolicy")]
    public V1beta2RecordSetStatusAtProviderRoutingPolicy? RoutingPolicy { get; set; }

    /// <summary>
    /// The string data for the records in this record set
    /// whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding \&quot; if you don&apos;t want your string to get split on spaces.g. &quot;first255characters\&quot; \&quot;morecharacters&quot;).
    /// </summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }

    /// <summary>The time-to-live of this record set (seconds).</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The DNS record set type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatusConditions
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

/// <summary>RecordSetStatus defines the observed state of RecordSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2RecordSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RecordSetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RecordSet is the Schema for the RecordSets API. Manages a set of DNS records within Google Cloud DNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RecordSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RecordSetSpec>, IStatus<V1beta2RecordSetStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RecordSet";
    public const string KubeGroup = "dns.gcp.upbound.io";
    public const string KubePluralName = "recordsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dns.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RecordSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RecordSetSpec defines the desired state of RecordSet</summary>
    [JsonPropertyName("spec")]
    public required V1beta2RecordSetSpec Spec { get; set; }

    /// <summary>RecordSetStatus defines the observed state of RecordSet.</summary>
    [JsonPropertyName("status")]
    public V1beta2RecordSetStatus? Status { get; set; }
}