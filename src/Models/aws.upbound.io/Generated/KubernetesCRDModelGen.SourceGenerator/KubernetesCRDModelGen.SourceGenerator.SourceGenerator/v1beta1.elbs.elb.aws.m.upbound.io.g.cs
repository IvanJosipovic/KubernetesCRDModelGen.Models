#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elb.aws.m.upbound.io;
/// <summary>ELB is the Schema for the ELBs API. Provides an Elastic Load Balancer resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ELBList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ELB>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ELBList";
    public const string KubeGroup = "elb.aws.m.upbound.io";
    public const string KubePluralName = "elbs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elb.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ELBList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ELB objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ELB> Items { get; set; }
}

/// <summary>An Access Logs block. Access Logs documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecForProviderAccessLogs
{
    /// <summary>The S3 bucket name to store the logs in.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The S3 bucket prefix. Logs are stored in the root if not configured.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Boolean to enable / disable access_logs. Default is true</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The publishing interval in minutes. Valid values: 5 and 60. Default: 60</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }
}

/// <summary>A health_check block. Health Check documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecForProviderHealthCheck
{
    /// <summary>The number of checks before the instance is declared healthy.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>The publishing interval in minutes. Valid values: 5 and 60. Default: 60</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>
    /// The target of the check. Valid pattern is &quot;${PROTOCOL}:${PORT}${PATH}&quot;, where PROTOCOL
    /// values are:
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The length of time before the check times out.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>The number of checks before the instance is declared unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecForProviderInstancesRefsPolicyResolutionEnum>))]
public enum V1beta1ELBSpecForProviderInstancesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecForProviderInstancesRefsPolicyResolveEnum>))]
public enum V1beta1ELBSpecForProviderInstancesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecForProviderInstancesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ELBSpecForProviderInstancesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ELBSpecForProviderInstancesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecForProviderInstancesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ELBSpecForProviderInstancesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecForProviderInstancesSelectorPolicyResolutionEnum>))]
public enum V1beta1ELBSpecForProviderInstancesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecForProviderInstancesSelectorPolicyResolveEnum>))]
public enum V1beta1ELBSpecForProviderInstancesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecForProviderInstancesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ELBSpecForProviderInstancesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ELBSpecForProviderInstancesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Instance in ec2 to populate instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecForProviderInstancesSelector
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
    public V1beta1ELBSpecForProviderInstancesSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecForProviderListener
{
    /// <summary>The port on the instance to route to</summary>
    [JsonPropertyName("instancePort")]
    public double? InstancePort { get; set; }

    /// <summary>
    /// The protocol to use to the instance. Valid
    /// values are HTTP, HTTPS, TCP, or SSL
    /// </summary>
    [JsonPropertyName("instanceProtocol")]
    public string? InstanceProtocol { get; set; }

    /// <summary>The port to listen on for the load balancer</summary>
    [JsonPropertyName("lbPort")]
    public double? LbPort { get; set; }

    /// <summary>
    /// The protocol to listen on. Valid values are HTTP,
    /// HTTPS, TCP, or SSL
    /// </summary>
    [JsonPropertyName("lbProtocol")]
    public string? LbProtocol { get; set; }

    /// <summary>
    /// The ARN of an SSL certificate you have
    /// uploaded to AWS IAM. Note ECDSA-specific restrictions below.  Only valid when
    /// </summary>
    [JsonPropertyName("sslCertificateId")]
    public string? SslCertificateId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecForProviderSubnetsRefsPolicyResolutionEnum>))]
public enum V1beta1ELBSpecForProviderSubnetsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecForProviderSubnetsRefsPolicyResolveEnum>))]
public enum V1beta1ELBSpecForProviderSubnetsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecForProviderSubnetsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ELBSpecForProviderSubnetsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ELBSpecForProviderSubnetsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecForProviderSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ELBSpecForProviderSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecForProviderSubnetsSelectorPolicyResolutionEnum>))]
public enum V1beta1ELBSpecForProviderSubnetsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecForProviderSubnetsSelectorPolicyResolveEnum>))]
public enum V1beta1ELBSpecForProviderSubnetsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecForProviderSubnetsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ELBSpecForProviderSubnetsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ELBSpecForProviderSubnetsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecForProviderSubnetsSelector
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
    public V1beta1ELBSpecForProviderSubnetsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecForProvider
{
    /// <summary>An Access Logs block. Access Logs documented below.</summary>
    [JsonPropertyName("accessLogs")]
    public V1beta1ELBSpecForProviderAccessLogs? AccessLogs { get; set; }

    /// <summary>The AZ&apos;s to serve traffic in.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Boolean to enable connection draining. Default: false</summary>
    [JsonPropertyName("connectionDraining")]
    public bool? ConnectionDraining { get; set; }

    /// <summary>The time in seconds to allow for connections to drain. Default: 300</summary>
    [JsonPropertyName("connectionDrainingTimeout")]
    public double? ConnectionDrainingTimeout { get; set; }

    /// <summary>Enable cross-zone load balancing. Default: true</summary>
    [JsonPropertyName("crossZoneLoadBalancing")]
    public bool? CrossZoneLoadBalancing { get; set; }

    /// <summary>Determines how the load balancer handles requests that might pose a security risk to an application due to HTTP desync. Valid values are monitor, defensive (default), strictest.</summary>
    [JsonPropertyName("desyncMitigationMode")]
    public string? DesyncMitigationMode { get; set; }

    /// <summary>A health_check block. Health Check documented below.</summary>
    [JsonPropertyName("healthCheck")]
    public V1beta1ELBSpecForProviderHealthCheck? HealthCheck { get; set; }

    /// <summary>The time in seconds that the connection is allowed to be idle. Default: 60</summary>
    [JsonPropertyName("idleTimeout")]
    public double? IdleTimeout { get; set; }

    /// <summary>A list of instance ids to place in the ELB pool.</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }

    /// <summary>References to Instance in ec2 to populate instances.</summary>
    [JsonPropertyName("instancesRefs")]
    public IList<V1beta1ELBSpecForProviderInstancesRefs>? InstancesRefs { get; set; }

    /// <summary>Selector for a list of Instance in ec2 to populate instances.</summary>
    [JsonPropertyName("instancesSelector")]
    public V1beta1ELBSpecForProviderInstancesSelector? InstancesSelector { get; set; }

    /// <summary>If true, ELB will be an internal ELB.</summary>
    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    /// <summary>A list of listener blocks. Listeners documented below.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta1ELBSpecForProviderListener>? Listener { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// A list of security group IDs to assign to the ELB.
    /// Only valid if creating an ELB within a VPC
    /// </summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The name of the security group that you can use as
    /// part of your inbound rules for your load balancer&apos;s back-end application
    /// instances. Use this for Classic or Default VPC only.
    /// </summary>
    [JsonPropertyName("sourceSecurityGroup")]
    public string? SourceSecurityGroup { get; set; }

    /// <summary>A list of subnet IDs to attach to the ELB. When an update to subnets will remove all current subnets, this will force a new resource.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsRefs")]
    public IList<V1beta1ELBSpecForProviderSubnetsRefs>? SubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsSelector")]
    public V1beta1ELBSpecForProviderSubnetsSelector? SubnetsSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>An Access Logs block. Access Logs documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecInitProviderAccessLogs
{
    /// <summary>The S3 bucket name to store the logs in.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The S3 bucket prefix. Logs are stored in the root if not configured.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Boolean to enable / disable access_logs. Default is true</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The publishing interval in minutes. Valid values: 5 and 60. Default: 60</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }
}

/// <summary>A health_check block. Health Check documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecInitProviderHealthCheck
{
    /// <summary>The number of checks before the instance is declared healthy.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>The publishing interval in minutes. Valid values: 5 and 60. Default: 60</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>
    /// The target of the check. Valid pattern is &quot;${PROTOCOL}:${PORT}${PATH}&quot;, where PROTOCOL
    /// values are:
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The length of time before the check times out.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>The number of checks before the instance is declared unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecInitProviderInstancesRefsPolicyResolutionEnum>))]
public enum V1beta1ELBSpecInitProviderInstancesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecInitProviderInstancesRefsPolicyResolveEnum>))]
public enum V1beta1ELBSpecInitProviderInstancesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecInitProviderInstancesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ELBSpecInitProviderInstancesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ELBSpecInitProviderInstancesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecInitProviderInstancesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ELBSpecInitProviderInstancesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecInitProviderInstancesSelectorPolicyResolutionEnum>))]
public enum V1beta1ELBSpecInitProviderInstancesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecInitProviderInstancesSelectorPolicyResolveEnum>))]
public enum V1beta1ELBSpecInitProviderInstancesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecInitProviderInstancesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ELBSpecInitProviderInstancesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ELBSpecInitProviderInstancesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Instance in ec2 to populate instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecInitProviderInstancesSelector
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
    public V1beta1ELBSpecInitProviderInstancesSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecInitProviderListener
{
    /// <summary>The port on the instance to route to</summary>
    [JsonPropertyName("instancePort")]
    public double? InstancePort { get; set; }

    /// <summary>
    /// The protocol to use to the instance. Valid
    /// values are HTTP, HTTPS, TCP, or SSL
    /// </summary>
    [JsonPropertyName("instanceProtocol")]
    public string? InstanceProtocol { get; set; }

    /// <summary>The port to listen on for the load balancer</summary>
    [JsonPropertyName("lbPort")]
    public double? LbPort { get; set; }

    /// <summary>
    /// The protocol to listen on. Valid values are HTTP,
    /// HTTPS, TCP, or SSL
    /// </summary>
    [JsonPropertyName("lbProtocol")]
    public string? LbProtocol { get; set; }

    /// <summary>
    /// The ARN of an SSL certificate you have
    /// uploaded to AWS IAM. Note ECDSA-specific restrictions below.  Only valid when
    /// </summary>
    [JsonPropertyName("sslCertificateId")]
    public string? SslCertificateId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecInitProviderSubnetsRefsPolicyResolutionEnum>))]
public enum V1beta1ELBSpecInitProviderSubnetsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecInitProviderSubnetsRefsPolicyResolveEnum>))]
public enum V1beta1ELBSpecInitProviderSubnetsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecInitProviderSubnetsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ELBSpecInitProviderSubnetsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ELBSpecInitProviderSubnetsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecInitProviderSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ELBSpecInitProviderSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecInitProviderSubnetsSelectorPolicyResolutionEnum>))]
public enum V1beta1ELBSpecInitProviderSubnetsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecInitProviderSubnetsSelectorPolicyResolveEnum>))]
public enum V1beta1ELBSpecInitProviderSubnetsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecInitProviderSubnetsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ELBSpecInitProviderSubnetsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ELBSpecInitProviderSubnetsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpecInitProviderSubnetsSelector
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
    public V1beta1ELBSpecInitProviderSubnetsSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1ELBSpecInitProvider
{
    /// <summary>An Access Logs block. Access Logs documented below.</summary>
    [JsonPropertyName("accessLogs")]
    public V1beta1ELBSpecInitProviderAccessLogs? AccessLogs { get; set; }

    /// <summary>The AZ&apos;s to serve traffic in.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Boolean to enable connection draining. Default: false</summary>
    [JsonPropertyName("connectionDraining")]
    public bool? ConnectionDraining { get; set; }

    /// <summary>The time in seconds to allow for connections to drain. Default: 300</summary>
    [JsonPropertyName("connectionDrainingTimeout")]
    public double? ConnectionDrainingTimeout { get; set; }

    /// <summary>Enable cross-zone load balancing. Default: true</summary>
    [JsonPropertyName("crossZoneLoadBalancing")]
    public bool? CrossZoneLoadBalancing { get; set; }

    /// <summary>Determines how the load balancer handles requests that might pose a security risk to an application due to HTTP desync. Valid values are monitor, defensive (default), strictest.</summary>
    [JsonPropertyName("desyncMitigationMode")]
    public string? DesyncMitigationMode { get; set; }

    /// <summary>A health_check block. Health Check documented below.</summary>
    [JsonPropertyName("healthCheck")]
    public V1beta1ELBSpecInitProviderHealthCheck? HealthCheck { get; set; }

    /// <summary>The time in seconds that the connection is allowed to be idle. Default: 60</summary>
    [JsonPropertyName("idleTimeout")]
    public double? IdleTimeout { get; set; }

    /// <summary>A list of instance ids to place in the ELB pool.</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }

    /// <summary>References to Instance in ec2 to populate instances.</summary>
    [JsonPropertyName("instancesRefs")]
    public IList<V1beta1ELBSpecInitProviderInstancesRefs>? InstancesRefs { get; set; }

    /// <summary>Selector for a list of Instance in ec2 to populate instances.</summary>
    [JsonPropertyName("instancesSelector")]
    public V1beta1ELBSpecInitProviderInstancesSelector? InstancesSelector { get; set; }

    /// <summary>If true, ELB will be an internal ELB.</summary>
    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    /// <summary>A list of listener blocks. Listeners documented below.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta1ELBSpecInitProviderListener>? Listener { get; set; }

    /// <summary>
    /// A list of security group IDs to assign to the ELB.
    /// Only valid if creating an ELB within a VPC
    /// </summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The name of the security group that you can use as
    /// part of your inbound rules for your load balancer&apos;s back-end application
    /// instances. Use this for Classic or Default VPC only.
    /// </summary>
    [JsonPropertyName("sourceSecurityGroup")]
    public string? SourceSecurityGroup { get; set; }

    /// <summary>A list of subnet IDs to attach to the ELB. When an update to subnets will remove all current subnets, this will force a new resource.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsRefs")]
    public IList<V1beta1ELBSpecInitProviderSubnetsRefs>? SubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsSelector")]
    public V1beta1ELBSpecInitProviderSubnetsSelector? SubnetsSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ELBSpecManagementPoliciesEnum>))]
public enum V1beta1ELBSpecManagementPoliciesEnum
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
public partial class V1beta1ELBSpecProviderConfigRef
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
public partial class V1beta1ELBSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ELBSpec defines the desired state of ELB</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ELBSpecForProvider ForProvider { get; set; }

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
    public V1beta1ELBSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ELBSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ELBSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ELBSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An Access Logs block. Access Logs documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBStatusAtProviderAccessLogs
{
    /// <summary>The S3 bucket name to store the logs in.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The S3 bucket prefix. Logs are stored in the root if not configured.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Boolean to enable / disable access_logs. Default is true</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The publishing interval in minutes. Valid values: 5 and 60. Default: 60</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }
}

/// <summary>A health_check block. Health Check documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBStatusAtProviderHealthCheck
{
    /// <summary>The number of checks before the instance is declared healthy.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>The publishing interval in minutes. Valid values: 5 and 60. Default: 60</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>
    /// The target of the check. Valid pattern is &quot;${PROTOCOL}:${PORT}${PATH}&quot;, where PROTOCOL
    /// values are:
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>The length of time before the check times out.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>The number of checks before the instance is declared unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBStatusAtProviderListener
{
    /// <summary>The port on the instance to route to</summary>
    [JsonPropertyName("instancePort")]
    public double? InstancePort { get; set; }

    /// <summary>
    /// The protocol to use to the instance. Valid
    /// values are HTTP, HTTPS, TCP, or SSL
    /// </summary>
    [JsonPropertyName("instanceProtocol")]
    public string? InstanceProtocol { get; set; }

    /// <summary>The port to listen on for the load balancer</summary>
    [JsonPropertyName("lbPort")]
    public double? LbPort { get; set; }

    /// <summary>
    /// The protocol to listen on. Valid values are HTTP,
    /// HTTPS, TCP, or SSL
    /// </summary>
    [JsonPropertyName("lbProtocol")]
    public string? LbProtocol { get; set; }

    /// <summary>
    /// The ARN of an SSL certificate you have
    /// uploaded to AWS IAM. Note ECDSA-specific restrictions below.  Only valid when
    /// </summary>
    [JsonPropertyName("sslCertificateId")]
    public string? SslCertificateId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBStatusAtProvider
{
    /// <summary>An Access Logs block. Access Logs documented below.</summary>
    [JsonPropertyName("accessLogs")]
    public V1beta1ELBStatusAtProviderAccessLogs? AccessLogs { get; set; }

    /// <summary>The ARN of the ELB</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The AZ&apos;s to serve traffic in.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Boolean to enable connection draining. Default: false</summary>
    [JsonPropertyName("connectionDraining")]
    public bool? ConnectionDraining { get; set; }

    /// <summary>The time in seconds to allow for connections to drain. Default: 300</summary>
    [JsonPropertyName("connectionDrainingTimeout")]
    public double? ConnectionDrainingTimeout { get; set; }

    /// <summary>Enable cross-zone load balancing. Default: true</summary>
    [JsonPropertyName("crossZoneLoadBalancing")]
    public bool? CrossZoneLoadBalancing { get; set; }

    /// <summary>Determines how the load balancer handles requests that might pose a security risk to an application due to HTTP desync. Valid values are monitor, defensive (default), strictest.</summary>
    [JsonPropertyName("desyncMitigationMode")]
    public string? DesyncMitigationMode { get; set; }

    /// <summary>The DNS name of the ELB</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>A health_check block. Health Check documented below.</summary>
    [JsonPropertyName("healthCheck")]
    public V1beta1ELBStatusAtProviderHealthCheck? HealthCheck { get; set; }

    /// <summary>The name of the ELB</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The time in seconds that the connection is allowed to be idle. Default: 60</summary>
    [JsonPropertyName("idleTimeout")]
    public double? IdleTimeout { get; set; }

    /// <summary>A list of instance ids to place in the ELB pool.</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }

    /// <summary>If true, ELB will be an internal ELB.</summary>
    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    /// <summary>A list of listener blocks. Listeners documented below.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta1ELBStatusAtProviderListener>? Listener { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// A list of security group IDs to assign to the ELB.
    /// Only valid if creating an ELB within a VPC
    /// </summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The name of the security group that you can use as
    /// part of your inbound rules for your load balancer&apos;s back-end application
    /// instances. Use this for Classic or Default VPC only.
    /// </summary>
    [JsonPropertyName("sourceSecurityGroup")]
    public string? SourceSecurityGroup { get; set; }

    /// <summary>
    /// The ID of the security group that you can use as
    /// part of your inbound rules for your load balancer&apos;s back-end application
    /// instances. Only available on ELBs launched in a VPC.
    /// </summary>
    [JsonPropertyName("sourceSecurityGroupId")]
    public string? SourceSecurityGroupId { get; set; }

    /// <summary>A list of subnet IDs to attach to the ELB. When an update to subnets will remove all current subnets, this will force a new resource.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The canonical hosted zone ID of the ELB (to be used in a Route 53 Alias record)</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBStatusConditions
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

/// <summary>ELBStatus defines the observed state of ELB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ELBStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ELBStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ELBStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ELB is the Schema for the ELBs API. Provides an Elastic Load Balancer resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ELB : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ELBSpec>, IStatus<V1beta1ELBStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ELB";
    public const string KubeGroup = "elb.aws.m.upbound.io";
    public const string KubePluralName = "elbs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elb.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ELB";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ELBSpec defines the desired state of ELB</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ELBSpec Spec { get; set; }

    /// <summary>ELBStatus defines the observed state of ELB.</summary>
    [JsonPropertyName("status")]
    public V1beta1ELBStatus? Status { get; set; }
}