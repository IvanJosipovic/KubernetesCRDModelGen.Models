#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.route53.aws.upbound.io;
/// <summary>Record is the Schema for the Records API. Provides a Route53 record resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RecordList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Record>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RecordList";
    public const string KubeGroup = "route53.aws.upbound.io";
    public const string KubePluralName = "records";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RecordList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Record objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Record> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecDeletionPolicyEnum>))]
public enum V1beta2RecordSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// An alias block. Conflicts with ttl &amp; records.
/// Documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderAlias
{
    /// <summary>Set to true if you want Route 53 to determine whether to respond to DNS queries using this resource record set by checking the health of the resource record set. Some resources have special requirements, see related part of documentation.</summary>
    [JsonPropertyName("evaluateTargetHealth")]
    public bool? EvaluateTargetHealth { get; set; }

    /// <summary>The name of the record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the hosted zone to contain this record.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary>A block indicating a routing policy based on the IP network ranges of requestors. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderCidrRoutingPolicy
{
    /// <summary>The CIDR collection ID. See the aws_route53_cidr_collection resource for more details.</summary>
    [JsonPropertyName("collectionId")]
    public string? CollectionId { get; set; }

    /// <summary>The CIDR collection location name. See the aws_route53_cidr_location resource for more details. A location_name with an asterisk &quot;*&quot; can be used to create a default CIDR record. collection_id is still required for default record.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

/// <summary>A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderFailoverRoutingPolicy
{
    /// <summary>The record type. Valid values are A, AAAA, CAA, CNAME, DS, HTTPS, MX, NAPTR, NS, PTR, SOA, SPF, SRV, SSHFP, SVCB, TLSA, and TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderGeolocationRoutingPolicy
{
    /// <summary>A two-letter continent code. See http://docs.aws.amazon.com/Route53/latest/APIReference/API_GetGeoLocation.html for code details. Either continent or country must be specified.</summary>
    [JsonPropertyName("continent")]
    public string? Continent { get; set; }

    /// <summary>A two-character country code or * to indicate a default resource record set.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>A subdivision code for a country.</summary>
    [JsonPropertyName("subdivision")]
    public string? Subdivision { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderGeoproximityRoutingPolicyCoordinates
{
    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }
}

/// <summary>A block indicating a routing policy based on the geoproximity of the requestor. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderGeoproximityRoutingPolicy
{
    /// <summary>A AWS region where the resource is present.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>Route more traffic or less traffic to the resource by specifying a value ranges between -90 to 90. See https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geoproximity.html for bias details.</summary>
    [JsonPropertyName("bias")]
    public double? Bias { get; set; }

    /// <summary>Specify latitude and longitude for routing traffic to non-AWS resources.</summary>
    [JsonPropertyName("coordinates")]
    public IList<V1beta2RecordSpecForProviderGeoproximityRoutingPolicyCoordinates>? Coordinates { get; set; }

    /// <summary>A AWS local zone group where the resource is present. See https://docs.aws.amazon.com/local-zones/latest/ug/available-local-zones.html for local zone group list.</summary>
    [JsonPropertyName("localZoneGroup")]
    public string? LocalZoneGroup { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecForProviderHealthCheckIdRefPolicyResolutionEnum>))]
public enum V1beta2RecordSpecForProviderHealthCheckIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecForProviderHealthCheckIdRefPolicyResolveEnum>))]
public enum V1beta2RecordSpecForProviderHealthCheckIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderHealthCheckIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecForProviderHealthCheckIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecForProviderHealthCheckIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HealthCheck in route53 to populate healthCheckId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderHealthCheckIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSpecForProviderHealthCheckIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecForProviderHealthCheckIdSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSpecForProviderHealthCheckIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecForProviderHealthCheckIdSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSpecForProviderHealthCheckIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderHealthCheckIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecForProviderHealthCheckIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecForProviderHealthCheckIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HealthCheck in route53 to populate healthCheckId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderHealthCheckIdSelector
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
    public V1beta2RecordSpecForProviderHealthCheckIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderLatencyRoutingPolicy
{
    /// <summary>An AWS region from which to measure latency. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-latency</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecForProviderRecordsRefsPolicyResolutionEnum>))]
public enum V1beta2RecordSpecForProviderRecordsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecForProviderRecordsRefsPolicyResolveEnum>))]
public enum V1beta2RecordSpecForProviderRecordsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderRecordsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecForProviderRecordsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecForProviderRecordsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderRecordsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSpecForProviderRecordsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecForProviderRecordsSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSpecForProviderRecordsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecForProviderRecordsSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSpecForProviderRecordsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderRecordsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecForProviderRecordsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecForProviderRecordsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of EIP in ec2 to populate records.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderRecordsSelector
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
    public V1beta2RecordSpecForProviderRecordsSelectorPolicy? Policy { get; set; }
}

/// <summary>A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderWeightedRoutingPolicy
{
    /// <summary>A numeric value indicating the relative weight of the record. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-weighted.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecForProviderZoneIdRefPolicyResolutionEnum>))]
public enum V1beta2RecordSpecForProviderZoneIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecForProviderZoneIdRefPolicyResolveEnum>))]
public enum V1beta2RecordSpecForProviderZoneIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderZoneIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecForProviderZoneIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecForProviderZoneIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Zone in route53 to populate zoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderZoneIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSpecForProviderZoneIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecForProviderZoneIdSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSpecForProviderZoneIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecForProviderZoneIdSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSpecForProviderZoneIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderZoneIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecForProviderZoneIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecForProviderZoneIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Zone in route53 to populate zoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProviderZoneIdSelector
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
    public V1beta2RecordSpecForProviderZoneIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecForProvider
{
    /// <summary>
    /// An alias block. Conflicts with ttl &amp; records.
    /// Documented below.
    /// </summary>
    [JsonPropertyName("alias")]
    public V1beta2RecordSpecForProviderAlias? Alias { get; set; }

    /// <summary>false by default. This configuration is not recommended for most environments.</summary>
    [JsonPropertyName("allowOverwrite")]
    public bool? AllowOverwrite { get; set; }

    /// <summary>A block indicating a routing policy based on the IP network ranges of requestors. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("cidrRoutingPolicy")]
    public V1beta2RecordSpecForProviderCidrRoutingPolicy? CidrRoutingPolicy { get; set; }

    /// <summary>A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("failoverRoutingPolicy")]
    public V1beta2RecordSpecForProviderFailoverRoutingPolicy? FailoverRoutingPolicy { get; set; }

    /// <summary>A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("geolocationRoutingPolicy")]
    public V1beta2RecordSpecForProviderGeolocationRoutingPolicy? GeolocationRoutingPolicy { get; set; }

    /// <summary>A block indicating a routing policy based on the geoproximity of the requestor. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("geoproximityRoutingPolicy")]
    public V1beta2RecordSpecForProviderGeoproximityRoutingPolicy? GeoproximityRoutingPolicy { get; set; }

    /// <summary>The health check the record should be associated with.</summary>
    [JsonPropertyName("healthCheckId")]
    public string? HealthCheckId { get; set; }

    /// <summary>Reference to a HealthCheck in route53 to populate healthCheckId.</summary>
    [JsonPropertyName("healthCheckIdRef")]
    public V1beta2RecordSpecForProviderHealthCheckIdRef? HealthCheckIdRef { get; set; }

    /// <summary>Selector for a HealthCheck in route53 to populate healthCheckId.</summary>
    [JsonPropertyName("healthCheckIdSelector")]
    public V1beta2RecordSpecForProviderHealthCheckIdSelector? HealthCheckIdSelector { get; set; }

    /// <summary>A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("latencyRoutingPolicy")]
    public V1beta2RecordSpecForProviderLatencyRoutingPolicy? LatencyRoutingPolicy { get; set; }

    /// <summary>Set to true to indicate a multivalue answer routing policy. Conflicts with any other routing policy.</summary>
    [JsonPropertyName("multivalueAnswerRoutingPolicy")]
    public bool? MultivalueAnswerRoutingPolicy { get; set; }

    /// <summary>The name of the record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A string list of records.g., &quot;first255characters\&quot;\&quot;morecharacters&quot;).</summary>
    [JsonPropertyName("records")]
    public IList<string>? Records { get; set; }

    /// <summary>References to EIP in ec2 to populate records.</summary>
    [JsonPropertyName("recordsRefs")]
    public IList<V1beta2RecordSpecForProviderRecordsRefs>? RecordsRefs { get; set; }

    /// <summary>Selector for a list of EIP in ec2 to populate records.</summary>
    [JsonPropertyName("recordsSelector")]
    public V1beta2RecordSpecForProviderRecordsSelector? RecordsSelector { get; set; }

    /// <summary>Unique identifier to differentiate records with routing policies from one another. Required if using cidr_routing_policy, failover_routing_policy, geolocation_routing_policy,geoproximity_routing_policy, latency_routing_policy, multivalue_answer_routing_policy, or weighted_routing_policy.</summary>
    [JsonPropertyName("setIdentifier")]
    public string? SetIdentifier { get; set; }

    /// <summary>The TTL of the record.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The record type. Valid values are A, AAAA, CAA, CNAME, DS, HTTPS, MX, NAPTR, NS, PTR, SOA, SPF, SRV, SSHFP, SVCB, TLSA, and TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("weightedRoutingPolicy")]
    public V1beta2RecordSpecForProviderWeightedRoutingPolicy? WeightedRoutingPolicy { get; set; }

    /// <summary>The ID of the hosted zone to contain this record.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }

    /// <summary>Reference to a Zone in route53 to populate zoneId.</summary>
    [JsonPropertyName("zoneIdRef")]
    public V1beta2RecordSpecForProviderZoneIdRef? ZoneIdRef { get; set; }

    /// <summary>Selector for a Zone in route53 to populate zoneId.</summary>
    [JsonPropertyName("zoneIdSelector")]
    public V1beta2RecordSpecForProviderZoneIdSelector? ZoneIdSelector { get; set; }
}

/// <summary>
/// An alias block. Conflicts with ttl &amp; records.
/// Documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderAlias
{
    /// <summary>Set to true if you want Route 53 to determine whether to respond to DNS queries using this resource record set by checking the health of the resource record set. Some resources have special requirements, see related part of documentation.</summary>
    [JsonPropertyName("evaluateTargetHealth")]
    public bool? EvaluateTargetHealth { get; set; }

    /// <summary>The name of the record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the hosted zone to contain this record.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary>A block indicating a routing policy based on the IP network ranges of requestors. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderCidrRoutingPolicy
{
    /// <summary>The CIDR collection ID. See the aws_route53_cidr_collection resource for more details.</summary>
    [JsonPropertyName("collectionId")]
    public string? CollectionId { get; set; }

    /// <summary>The CIDR collection location name. See the aws_route53_cidr_location resource for more details. A location_name with an asterisk &quot;*&quot; can be used to create a default CIDR record. collection_id is still required for default record.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

/// <summary>A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderFailoverRoutingPolicy
{
    /// <summary>The record type. Valid values are A, AAAA, CAA, CNAME, DS, HTTPS, MX, NAPTR, NS, PTR, SOA, SPF, SRV, SSHFP, SVCB, TLSA, and TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderGeolocationRoutingPolicy
{
    /// <summary>A two-letter continent code. See http://docs.aws.amazon.com/Route53/latest/APIReference/API_GetGeoLocation.html for code details. Either continent or country must be specified.</summary>
    [JsonPropertyName("continent")]
    public string? Continent { get; set; }

    /// <summary>A two-character country code or * to indicate a default resource record set.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>A subdivision code for a country.</summary>
    [JsonPropertyName("subdivision")]
    public string? Subdivision { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderGeoproximityRoutingPolicyCoordinates
{
    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }
}

/// <summary>A block indicating a routing policy based on the geoproximity of the requestor. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderGeoproximityRoutingPolicy
{
    /// <summary>A AWS region where the resource is present.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>Route more traffic or less traffic to the resource by specifying a value ranges between -90 to 90. See https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geoproximity.html for bias details.</summary>
    [JsonPropertyName("bias")]
    public double? Bias { get; set; }

    /// <summary>Specify latitude and longitude for routing traffic to non-AWS resources.</summary>
    [JsonPropertyName("coordinates")]
    public IList<V1beta2RecordSpecInitProviderGeoproximityRoutingPolicyCoordinates>? Coordinates { get; set; }

    /// <summary>A AWS local zone group where the resource is present. See https://docs.aws.amazon.com/local-zones/latest/ug/available-local-zones.html for local zone group list.</summary>
    [JsonPropertyName("localZoneGroup")]
    public string? LocalZoneGroup { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecInitProviderHealthCheckIdRefPolicyResolutionEnum>))]
public enum V1beta2RecordSpecInitProviderHealthCheckIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecInitProviderHealthCheckIdRefPolicyResolveEnum>))]
public enum V1beta2RecordSpecInitProviderHealthCheckIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderHealthCheckIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecInitProviderHealthCheckIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecInitProviderHealthCheckIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HealthCheck in route53 to populate healthCheckId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderHealthCheckIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSpecInitProviderHealthCheckIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecInitProviderHealthCheckIdSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSpecInitProviderHealthCheckIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecInitProviderHealthCheckIdSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSpecInitProviderHealthCheckIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderHealthCheckIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecInitProviderHealthCheckIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecInitProviderHealthCheckIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HealthCheck in route53 to populate healthCheckId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderHealthCheckIdSelector
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
    public V1beta2RecordSpecInitProviderHealthCheckIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderLatencyRoutingPolicy
{
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecInitProviderRecordsRefsPolicyResolutionEnum>))]
public enum V1beta2RecordSpecInitProviderRecordsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecInitProviderRecordsRefsPolicyResolveEnum>))]
public enum V1beta2RecordSpecInitProviderRecordsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderRecordsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecInitProviderRecordsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecInitProviderRecordsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderRecordsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSpecInitProviderRecordsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecInitProviderRecordsSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSpecInitProviderRecordsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecInitProviderRecordsSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSpecInitProviderRecordsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderRecordsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecInitProviderRecordsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecInitProviderRecordsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of EIP in ec2 to populate records.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderRecordsSelector
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
    public V1beta2RecordSpecInitProviderRecordsSelectorPolicy? Policy { get; set; }
}

/// <summary>A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderWeightedRoutingPolicy
{
    /// <summary>A numeric value indicating the relative weight of the record. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-weighted.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecInitProviderZoneIdRefPolicyResolutionEnum>))]
public enum V1beta2RecordSpecInitProviderZoneIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecInitProviderZoneIdRefPolicyResolveEnum>))]
public enum V1beta2RecordSpecInitProviderZoneIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderZoneIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecInitProviderZoneIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecInitProviderZoneIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Zone in route53 to populate zoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderZoneIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSpecInitProviderZoneIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecInitProviderZoneIdSelectorPolicyResolutionEnum>))]
public enum V1beta2RecordSpecInitProviderZoneIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecInitProviderZoneIdSelectorPolicyResolveEnum>))]
public enum V1beta2RecordSpecInitProviderZoneIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderZoneIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecInitProviderZoneIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecInitProviderZoneIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Zone in route53 to populate zoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecInitProviderZoneIdSelector
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
    public V1beta2RecordSpecInitProviderZoneIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2RecordSpecInitProvider
{
    /// <summary>
    /// An alias block. Conflicts with ttl &amp; records.
    /// Documented below.
    /// </summary>
    [JsonPropertyName("alias")]
    public V1beta2RecordSpecInitProviderAlias? Alias { get; set; }

    /// <summary>false by default. This configuration is not recommended for most environments.</summary>
    [JsonPropertyName("allowOverwrite")]
    public bool? AllowOverwrite { get; set; }

    /// <summary>A block indicating a routing policy based on the IP network ranges of requestors. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("cidrRoutingPolicy")]
    public V1beta2RecordSpecInitProviderCidrRoutingPolicy? CidrRoutingPolicy { get; set; }

    /// <summary>A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("failoverRoutingPolicy")]
    public V1beta2RecordSpecInitProviderFailoverRoutingPolicy? FailoverRoutingPolicy { get; set; }

    /// <summary>A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("geolocationRoutingPolicy")]
    public V1beta2RecordSpecInitProviderGeolocationRoutingPolicy? GeolocationRoutingPolicy { get; set; }

    /// <summary>A block indicating a routing policy based on the geoproximity of the requestor. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("geoproximityRoutingPolicy")]
    public V1beta2RecordSpecInitProviderGeoproximityRoutingPolicy? GeoproximityRoutingPolicy { get; set; }

    /// <summary>The health check the record should be associated with.</summary>
    [JsonPropertyName("healthCheckId")]
    public string? HealthCheckId { get; set; }

    /// <summary>Reference to a HealthCheck in route53 to populate healthCheckId.</summary>
    [JsonPropertyName("healthCheckIdRef")]
    public V1beta2RecordSpecInitProviderHealthCheckIdRef? HealthCheckIdRef { get; set; }

    /// <summary>Selector for a HealthCheck in route53 to populate healthCheckId.</summary>
    [JsonPropertyName("healthCheckIdSelector")]
    public V1beta2RecordSpecInitProviderHealthCheckIdSelector? HealthCheckIdSelector { get; set; }

    /// <summary>A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("latencyRoutingPolicy")]
    public V1beta2RecordSpecInitProviderLatencyRoutingPolicy? LatencyRoutingPolicy { get; set; }

    /// <summary>Set to true to indicate a multivalue answer routing policy. Conflicts with any other routing policy.</summary>
    [JsonPropertyName("multivalueAnswerRoutingPolicy")]
    public bool? MultivalueAnswerRoutingPolicy { get; set; }

    /// <summary>The name of the record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A string list of records.g., &quot;first255characters\&quot;\&quot;morecharacters&quot;).</summary>
    [JsonPropertyName("records")]
    public IList<string>? Records { get; set; }

    /// <summary>References to EIP in ec2 to populate records.</summary>
    [JsonPropertyName("recordsRefs")]
    public IList<V1beta2RecordSpecInitProviderRecordsRefs>? RecordsRefs { get; set; }

    /// <summary>Selector for a list of EIP in ec2 to populate records.</summary>
    [JsonPropertyName("recordsSelector")]
    public V1beta2RecordSpecInitProviderRecordsSelector? RecordsSelector { get; set; }

    /// <summary>Unique identifier to differentiate records with routing policies from one another. Required if using cidr_routing_policy, failover_routing_policy, geolocation_routing_policy,geoproximity_routing_policy, latency_routing_policy, multivalue_answer_routing_policy, or weighted_routing_policy.</summary>
    [JsonPropertyName("setIdentifier")]
    public string? SetIdentifier { get; set; }

    /// <summary>The TTL of the record.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The record type. Valid values are A, AAAA, CAA, CNAME, DS, HTTPS, MX, NAPTR, NS, PTR, SOA, SPF, SRV, SSHFP, SVCB, TLSA, and TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("weightedRoutingPolicy")]
    public V1beta2RecordSpecInitProviderWeightedRoutingPolicy? WeightedRoutingPolicy { get; set; }

    /// <summary>The ID of the hosted zone to contain this record.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }

    /// <summary>Reference to a Zone in route53 to populate zoneId.</summary>
    [JsonPropertyName("zoneIdRef")]
    public V1beta2RecordSpecInitProviderZoneIdRef? ZoneIdRef { get; set; }

    /// <summary>Selector for a Zone in route53 to populate zoneId.</summary>
    [JsonPropertyName("zoneIdSelector")]
    public V1beta2RecordSpecInitProviderZoneIdSelector? ZoneIdSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecManagementPoliciesEnum>))]
public enum V1beta2RecordSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2RecordSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecordSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2RecordSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RecordSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RecordSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RecordSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RecordSpec defines the desired state of Record</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordSpec
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
    public V1beta2RecordSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2RecordSpecForProvider ForProvider { get; set; }

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
    public V1beta2RecordSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2RecordSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RecordSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RecordSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// An alias block. Conflicts with ttl &amp; records.
/// Documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordStatusAtProviderAlias
{
    /// <summary>Set to true if you want Route 53 to determine whether to respond to DNS queries using this resource record set by checking the health of the resource record set. Some resources have special requirements, see related part of documentation.</summary>
    [JsonPropertyName("evaluateTargetHealth")]
    public bool? EvaluateTargetHealth { get; set; }

    /// <summary>The name of the record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the hosted zone to contain this record.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary>A block indicating a routing policy based on the IP network ranges of requestors. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordStatusAtProviderCidrRoutingPolicy
{
    /// <summary>The CIDR collection ID. See the aws_route53_cidr_collection resource for more details.</summary>
    [JsonPropertyName("collectionId")]
    public string? CollectionId { get; set; }

    /// <summary>The CIDR collection location name. See the aws_route53_cidr_location resource for more details. A location_name with an asterisk &quot;*&quot; can be used to create a default CIDR record. collection_id is still required for default record.</summary>
    [JsonPropertyName("locationName")]
    public string? LocationName { get; set; }
}

/// <summary>A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordStatusAtProviderFailoverRoutingPolicy
{
    /// <summary>The record type. Valid values are A, AAAA, CAA, CNAME, DS, HTTPS, MX, NAPTR, NS, PTR, SOA, SPF, SRV, SSHFP, SVCB, TLSA, and TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordStatusAtProviderGeolocationRoutingPolicy
{
    /// <summary>A two-letter continent code. See http://docs.aws.amazon.com/Route53/latest/APIReference/API_GetGeoLocation.html for code details. Either continent or country must be specified.</summary>
    [JsonPropertyName("continent")]
    public string? Continent { get; set; }

    /// <summary>A two-character country code or * to indicate a default resource record set.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>A subdivision code for a country.</summary>
    [JsonPropertyName("subdivision")]
    public string? Subdivision { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordStatusAtProviderGeoproximityRoutingPolicyCoordinates
{
    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }
}

/// <summary>A block indicating a routing policy based on the geoproximity of the requestor. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordStatusAtProviderGeoproximityRoutingPolicy
{
    /// <summary>A AWS region where the resource is present.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>Route more traffic or less traffic to the resource by specifying a value ranges between -90 to 90. See https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geoproximity.html for bias details.</summary>
    [JsonPropertyName("bias")]
    public double? Bias { get; set; }

    /// <summary>Specify latitude and longitude for routing traffic to non-AWS resources.</summary>
    [JsonPropertyName("coordinates")]
    public IList<V1beta2RecordStatusAtProviderGeoproximityRoutingPolicyCoordinates>? Coordinates { get; set; }

    /// <summary>A AWS local zone group where the resource is present. See https://docs.aws.amazon.com/local-zones/latest/ug/available-local-zones.html for local zone group list.</summary>
    [JsonPropertyName("localZoneGroup")]
    public string? LocalZoneGroup { get; set; }
}

/// <summary>A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordStatusAtProviderLatencyRoutingPolicy
{
    /// <summary>An AWS region from which to measure latency. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-latency</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordStatusAtProviderWeightedRoutingPolicy
{
    /// <summary>A numeric value indicating the relative weight of the record. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-weighted.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordStatusAtProvider
{
    /// <summary>
    /// An alias block. Conflicts with ttl &amp; records.
    /// Documented below.
    /// </summary>
    [JsonPropertyName("alias")]
    public V1beta2RecordStatusAtProviderAlias? Alias { get; set; }

    /// <summary>false by default. This configuration is not recommended for most environments.</summary>
    [JsonPropertyName("allowOverwrite")]
    public bool? AllowOverwrite { get; set; }

    /// <summary>A block indicating a routing policy based on the IP network ranges of requestors. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("cidrRoutingPolicy")]
    public V1beta2RecordStatusAtProviderCidrRoutingPolicy? CidrRoutingPolicy { get; set; }

    /// <summary>A block indicating the routing behavior when associated health check fails. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("failoverRoutingPolicy")]
    public V1beta2RecordStatusAtProviderFailoverRoutingPolicy? FailoverRoutingPolicy { get; set; }

    /// <summary>FQDN built using the zone domain and name.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>A block indicating a routing policy based on the geolocation of the requestor. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("geolocationRoutingPolicy")]
    public V1beta2RecordStatusAtProviderGeolocationRoutingPolicy? GeolocationRoutingPolicy { get; set; }

    /// <summary>A block indicating a routing policy based on the geoproximity of the requestor. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("geoproximityRoutingPolicy")]
    public V1beta2RecordStatusAtProviderGeoproximityRoutingPolicy? GeoproximityRoutingPolicy { get; set; }

    /// <summary>The health check the record should be associated with.</summary>
    [JsonPropertyName("healthCheckId")]
    public string? HealthCheckId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A block indicating a routing policy based on the latency between the requestor and an AWS region. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("latencyRoutingPolicy")]
    public V1beta2RecordStatusAtProviderLatencyRoutingPolicy? LatencyRoutingPolicy { get; set; }

    /// <summary>Set to true to indicate a multivalue answer routing policy. Conflicts with any other routing policy.</summary>
    [JsonPropertyName("multivalueAnswerRoutingPolicy")]
    public bool? MultivalueAnswerRoutingPolicy { get; set; }

    /// <summary>The name of the record.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A string list of records.g., &quot;first255characters\&quot;\&quot;morecharacters&quot;).</summary>
    [JsonPropertyName("records")]
    public IList<string>? Records { get; set; }

    /// <summary>Unique identifier to differentiate records with routing policies from one another. Required if using cidr_routing_policy, failover_routing_policy, geolocation_routing_policy,geoproximity_routing_policy, latency_routing_policy, multivalue_answer_routing_policy, or weighted_routing_policy.</summary>
    [JsonPropertyName("setIdentifier")]
    public string? SetIdentifier { get; set; }

    /// <summary>The TTL of the record.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The record type. Valid values are A, AAAA, CAA, CNAME, DS, HTTPS, MX, NAPTR, NS, PTR, SOA, SPF, SRV, SSHFP, SVCB, TLSA, and TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A block indicating a weighted routing policy. Conflicts with any other routing policy. Documented below.</summary>
    [JsonPropertyName("weightedRoutingPolicy")]
    public V1beta2RecordStatusAtProviderWeightedRoutingPolicy? WeightedRoutingPolicy { get; set; }

    /// <summary>The ID of the hosted zone to contain this record.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordStatusConditions
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

/// <summary>RecordStatus defines the observed state of Record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecordStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2RecordStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RecordStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Record is the Schema for the Records API. Provides a Route53 record resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Record : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RecordSpec>, IStatus<V1beta2RecordStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Record";
    public const string KubeGroup = "route53.aws.upbound.io";
    public const string KubePluralName = "records";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Record";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RecordSpec defines the desired state of Record</summary>
    [JsonPropertyName("spec")]
    public required V1beta2RecordSpec Spec { get; set; }

    /// <summary>RecordStatus defines the observed state of Record.</summary>
    [JsonPropertyName("status")]
    public V1beta2RecordStatus? Status { get; set; }
}