#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dns.gcp.m.upbound.io;
/// <summary>RecordSet is the Schema for the RecordSets API. Manages a set of DNS records within Google Cloud DNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RecordSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RecordSet>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RecordSetList";
    public const string KubeGroup = "dns.gcp.m.upbound.io";
    public const string KubePluralName = "recordsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dns.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RecordSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1RecordSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1RecordSet> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderManagedZoneRefPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecForProviderManagedZoneRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderManagedZoneRefPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecForProviderManagedZoneRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderManagedZoneRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecForProviderManagedZoneRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecForProviderManagedZoneRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedZone in dns to populate managedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderManagedZoneRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecForProviderManagedZoneRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderManagedZoneSelectorPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecForProviderManagedZoneSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderManagedZoneSelectorPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecForProviderManagedZoneSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderManagedZoneSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecForProviderManagedZoneSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecForProviderManagedZoneSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedZone in dns to populate managedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderManagedZoneSelector
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
    public V1beta1RecordSetSpecForProviderManagedZoneSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers
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
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyGeo
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelector
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
    public V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers
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
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeo
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelector
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
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelector
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
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelector
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
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelector
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
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressRef")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef? IpAddressRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressSelector")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelector? IpAddressSelector { get; set; }

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
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelector? NetworkUrlSelector { get; set; }

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
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelector? ProjectSelector { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate region.</summary>
    [JsonPropertyName("regionRef")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef? RegionRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate region.</summary>
    [JsonPropertyName("regionSelector")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelector? RegionSelector { get; set; }
}

/// <summary>
/// The list of global primary targets to be health checked.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimary
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

/// <summary>
/// The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackup
{
    /// <summary>
    /// The backup geo targets, which provide a regional failover policy for the otherwise global primary targets.
    /// Structure is document above.
    /// </summary>
    [JsonPropertyName("backupGeo")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupBackupGeo>? BackupGeo { get; set; }

    /// <summary>Specifies whether to enable fencing for backup geo queries.</summary>
    [JsonPropertyName("enableGeoFencingForBackups")]
    public bool? EnableGeoFencingForBackups { get; set; }

    /// <summary>
    /// The list of global primary targets to be health checked.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primary")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackupPrimary? Primary { get; set; }

    /// <summary>Specifies the percentage of traffic to send to the backup targets even when the primary targets are healthy.</summary>
    [JsonPropertyName("trickleRatio")]
    public double? TrickleRatio { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers
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
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyWrrHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProviderRoutingPolicyWrr
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyWrrHealthCheckedTargets? HealthCheckedTargets { get; set; }

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
public partial class V1beta1RecordSetSpecForProviderRoutingPolicy
{
    /// <summary>Specifies whether to enable fencing for geo queries.</summary>
    [JsonPropertyName("enableGeoFencing")]
    public bool? EnableGeoFencing { get; set; }

    /// <summary>
    /// The configuration for Geolocation based routing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("geo")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyGeo>? Geo { get; set; }

    /// <summary>Specifies the health check (used with external endpoints).</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckSelector")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyHealthCheckSelector? HealthCheckSelector { get; set; }

    /// <summary>
    /// The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primaryBackup")]
    public V1beta1RecordSetSpecForProviderRoutingPolicyPrimaryBackup? PrimaryBackup { get; set; }

    /// <summary>
    /// The configuration for Weighted Round Robin based routing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wrr")]
    public IList<V1beta1RecordSetSpecForProviderRoutingPolicyWrr>? Wrr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecForProvider
{
    /// <summary>
    /// The name of the zone in which this record set will
    /// reside.
    /// </summary>
    [JsonPropertyName("managedZone")]
    public string? ManagedZone { get; set; }

    /// <summary>Reference to a ManagedZone in dns to populate managedZone.</summary>
    [JsonPropertyName("managedZoneRef")]
    public V1beta1RecordSetSpecForProviderManagedZoneRef? ManagedZoneRef { get; set; }

    /// <summary>Selector for a ManagedZone in dns to populate managedZone.</summary>
    [JsonPropertyName("managedZoneSelector")]
    public V1beta1RecordSetSpecForProviderManagedZoneSelector? ManagedZoneSelector { get; set; }

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
    public V1beta1RecordSetSpecForProviderRoutingPolicy? RoutingPolicy { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderManagedZoneRefPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecInitProviderManagedZoneRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderManagedZoneRefPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecInitProviderManagedZoneRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderManagedZoneRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecInitProviderManagedZoneRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecInitProviderManagedZoneRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedZone in dns to populate managedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderManagedZoneRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecInitProviderManagedZoneRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderManagedZoneSelectorPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecInitProviderManagedZoneSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderManagedZoneSelectorPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecInitProviderManagedZoneSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderManagedZoneSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecInitProviderManagedZoneSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecInitProviderManagedZoneSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedZone in dns to populate managedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderManagedZoneSelector
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
    public V1beta1RecordSetSpecInitProviderManagedZoneSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers
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
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyGeo
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelector
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
    public V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers
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
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeo
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate ipAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelector
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
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelector
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
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelector
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
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolutionEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolveEnum>))]
public enum V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelector
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
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers
{
    /// <summary>The frontend IP address of the load balancer.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressRef")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressRef? IpAddressRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate ipAddress.</summary>
    [JsonPropertyName("ipAddressSelector")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersIpAddressSelector? IpAddressSelector { get; set; }

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
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersNetworkUrlSelector? NetworkUrlSelector { get; set; }

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
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersProjectSelector? ProjectSelector { get; set; }

    /// <summary>The region of the load balancer. Only needed for regional load balancers.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate region.</summary>
    [JsonPropertyName("regionRef")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionRef? RegionRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate region.</summary>
    [JsonPropertyName("regionSelector")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancersRegionSelector? RegionSelector { get; set; }
}

/// <summary>
/// The list of global primary targets to be health checked.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimary
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

/// <summary>
/// The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackup
{
    /// <summary>
    /// The backup geo targets, which provide a regional failover policy for the otherwise global primary targets.
    /// Structure is document above.
    /// </summary>
    [JsonPropertyName("backupGeo")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupBackupGeo>? BackupGeo { get; set; }

    /// <summary>Specifies whether to enable fencing for backup geo queries.</summary>
    [JsonPropertyName("enableGeoFencingForBackups")]
    public bool? EnableGeoFencingForBackups { get; set; }

    /// <summary>
    /// The list of global primary targets to be health checked.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primary")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackupPrimary? Primary { get; set; }

    /// <summary>Specifies the percentage of traffic to send to the backup targets even when the primary targets are healthy.</summary>
    [JsonPropertyName("trickleRatio")]
    public double? TrickleRatio { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers
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
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyWrrHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicyWrr
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyWrrHealthCheckedTargets? HealthCheckedTargets { get; set; }

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
public partial class V1beta1RecordSetSpecInitProviderRoutingPolicy
{
    /// <summary>Specifies whether to enable fencing for geo queries.</summary>
    [JsonPropertyName("enableGeoFencing")]
    public bool? EnableGeoFencing { get; set; }

    /// <summary>
    /// The configuration for Geolocation based routing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("geo")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyGeo>? Geo { get; set; }

    /// <summary>Specifies the health check (used with external endpoints).</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>Reference to a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Selector for a HealthCheck in compute to populate healthCheck.</summary>
    [JsonPropertyName("healthCheckSelector")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyHealthCheckSelector? HealthCheckSelector { get; set; }

    /// <summary>
    /// The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primaryBackup")]
    public V1beta1RecordSetSpecInitProviderRoutingPolicyPrimaryBackup? PrimaryBackup { get; set; }

    /// <summary>
    /// The configuration for Weighted Round Robin based routing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wrr")]
    public IList<V1beta1RecordSetSpecInitProviderRoutingPolicyWrr>? Wrr { get; set; }
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
public partial class V1beta1RecordSetSpecInitProvider
{
    /// <summary>
    /// The name of the zone in which this record set will
    /// reside.
    /// </summary>
    [JsonPropertyName("managedZone")]
    public string? ManagedZone { get; set; }

    /// <summary>Reference to a ManagedZone in dns to populate managedZone.</summary>
    [JsonPropertyName("managedZoneRef")]
    public V1beta1RecordSetSpecInitProviderManagedZoneRef? ManagedZoneRef { get; set; }

    /// <summary>Selector for a ManagedZone in dns to populate managedZone.</summary>
    [JsonPropertyName("managedZoneSelector")]
    public V1beta1RecordSetSpecInitProviderManagedZoneSelector? ManagedZoneSelector { get; set; }

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
    public V1beta1RecordSetSpecInitProviderRoutingPolicy? RoutingPolicy { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RecordSetSpecManagementPoliciesEnum>))]
public enum V1beta1RecordSetSpecManagementPoliciesEnum
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
public partial class V1beta1RecordSetSpecProviderConfigRef
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
public partial class V1beta1RecordSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RecordSetSpec defines the desired state of RecordSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1RecordSetSpecForProvider ForProvider { get; set; }

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
    public V1beta1RecordSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RecordSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RecordSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RecordSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers
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
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyGeo
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetStatusAtProviderRoutingPolicyGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers
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
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeo
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeoHealthCheckedTargets? HealthCheckedTargets { get; set; }

    /// <summary>The location name defined in Google Cloud.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Same as rrdatas above.</summary>
    [JsonPropertyName("rrdatas")]
    public IList<string>? Rrdatas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers
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
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupPrimary
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupPrimaryInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

/// <summary>
/// The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackup
{
    /// <summary>
    /// The backup geo targets, which provide a regional failover policy for the otherwise global primary targets.
    /// Structure is document above.
    /// </summary>
    [JsonPropertyName("backupGeo")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupBackupGeo>? BackupGeo { get; set; }

    /// <summary>Specifies whether to enable fencing for backup geo queries.</summary>
    [JsonPropertyName("enableGeoFencingForBackups")]
    public bool? EnableGeoFencingForBackups { get; set; }

    /// <summary>
    /// The list of global primary targets to be health checked.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primary")]
    public V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackupPrimary? Primary { get; set; }

    /// <summary>Specifies the percentage of traffic to send to the backup targets even when the primary targets are healthy.</summary>
    [JsonPropertyName("trickleRatio")]
    public double? TrickleRatio { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers
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
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyWrrHealthCheckedTargets
{
    /// <summary>The list of external endpoint addresses to health check.</summary>
    [JsonPropertyName("externalEndpoints")]
    public IList<string>? ExternalEndpoints { get; set; }

    /// <summary>
    /// The list of internal load balancers to health check.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("internalLoadBalancers")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyWrrHealthCheckedTargetsInternalLoadBalancers>? InternalLoadBalancers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicyWrr
{
    /// <summary>
    /// The list of targets to be health checked. Note that if DNSSEC is enabled for this zone, only one of rrdatas or health_checked_targets can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("healthCheckedTargets")]
    public V1beta1RecordSetStatusAtProviderRoutingPolicyWrrHealthCheckedTargets? HealthCheckedTargets { get; set; }

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
public partial class V1beta1RecordSetStatusAtProviderRoutingPolicy
{
    /// <summary>Specifies whether to enable fencing for geo queries.</summary>
    [JsonPropertyName("enableGeoFencing")]
    public bool? EnableGeoFencing { get; set; }

    /// <summary>
    /// The configuration for Geolocation based routing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("geo")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyGeo>? Geo { get; set; }

    /// <summary>Specifies the health check (used with external endpoints).</summary>
    [JsonPropertyName("healthCheck")]
    public string? HealthCheck { get; set; }

    /// <summary>
    /// The configuration for a failover policy with global to regional failover. Queries are responded to with the global primary targets, but if none of the primary targets are healthy, then we fallback to a regional failover policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primaryBackup")]
    public V1beta1RecordSetStatusAtProviderRoutingPolicyPrimaryBackup? PrimaryBackup { get; set; }

    /// <summary>
    /// The configuration for Weighted Round Robin based routing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wrr")]
    public IList<V1beta1RecordSetStatusAtProviderRoutingPolicyWrr>? Wrr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RecordSetStatusAtProvider
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
    public V1beta1RecordSetStatusAtProviderRoutingPolicy? RoutingPolicy { get; set; }

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
public partial class V1beta1RecordSetStatusConditions
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
public partial class V1beta1RecordSetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1RecordSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RecordSetStatusConditions>? Conditions { get; set; }

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
public partial class V1beta1RecordSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RecordSetSpec>, IStatus<V1beta1RecordSetStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RecordSet";
    public const string KubeGroup = "dns.gcp.m.upbound.io";
    public const string KubePluralName = "recordsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dns.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RecordSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RecordSetSpec defines the desired state of RecordSet</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RecordSetSpec Spec { get; set; }

    /// <summary>RecordSetStatus defines the observed state of RecordSet.</summary>
    [JsonPropertyName("status")]
    public V1beta1RecordSetStatus? Status { get; set; }
}