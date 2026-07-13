#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elb.aws.upbound.io;
/// <summary>ELB is the Schema for the ELBs API. Provides an Elastic Load Balancer resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ELBList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ELB>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ELBList";
    public const string KubeGroup = "elb.aws.upbound.io";
    public const string KubePluralName = "elbs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elb.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ELBList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ELB objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ELB> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecDeletionPolicyEnum>))]
public enum V1beta2ELBSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>An Access Logs block. Access Logs documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecForProviderAccessLogs
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
public partial class V1beta2ELBSpecForProviderHealthCheck
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecForProviderInstancesRefsPolicyResolutionEnum>))]
public enum V1beta2ELBSpecForProviderInstancesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecForProviderInstancesRefsPolicyResolveEnum>))]
public enum V1beta2ELBSpecForProviderInstancesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecForProviderInstancesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ELBSpecForProviderInstancesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ELBSpecForProviderInstancesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecForProviderInstancesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ELBSpecForProviderInstancesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecForProviderInstancesSelectorPolicyResolutionEnum>))]
public enum V1beta2ELBSpecForProviderInstancesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecForProviderInstancesSelectorPolicyResolveEnum>))]
public enum V1beta2ELBSpecForProviderInstancesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecForProviderInstancesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ELBSpecForProviderInstancesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ELBSpecForProviderInstancesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Instance in ec2 to populate instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecForProviderInstancesSelector
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
    public V1beta2ELBSpecForProviderInstancesSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecForProviderListener
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecForProviderSubnetsRefsPolicyResolutionEnum>))]
public enum V1beta2ELBSpecForProviderSubnetsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecForProviderSubnetsRefsPolicyResolveEnum>))]
public enum V1beta2ELBSpecForProviderSubnetsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecForProviderSubnetsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ELBSpecForProviderSubnetsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ELBSpecForProviderSubnetsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecForProviderSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ELBSpecForProviderSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecForProviderSubnetsSelectorPolicyResolutionEnum>))]
public enum V1beta2ELBSpecForProviderSubnetsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecForProviderSubnetsSelectorPolicyResolveEnum>))]
public enum V1beta2ELBSpecForProviderSubnetsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecForProviderSubnetsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ELBSpecForProviderSubnetsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ELBSpecForProviderSubnetsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecForProviderSubnetsSelector
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
    public V1beta2ELBSpecForProviderSubnetsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecForProvider
{
    /// <summary>An Access Logs block. Access Logs documented below.</summary>
    [JsonPropertyName("accessLogs")]
    public V1beta2ELBSpecForProviderAccessLogs? AccessLogs { get; set; }

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
    public V1beta2ELBSpecForProviderHealthCheck? HealthCheck { get; set; }

    /// <summary>The time in seconds that the connection is allowed to be idle. Default: 60</summary>
    [JsonPropertyName("idleTimeout")]
    public double? IdleTimeout { get; set; }

    /// <summary>A list of instance ids to place in the ELB pool.</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }

    /// <summary>References to Instance in ec2 to populate instances.</summary>
    [JsonPropertyName("instancesRefs")]
    public IList<V1beta2ELBSpecForProviderInstancesRefs>? InstancesRefs { get; set; }

    /// <summary>Selector for a list of Instance in ec2 to populate instances.</summary>
    [JsonPropertyName("instancesSelector")]
    public V1beta2ELBSpecForProviderInstancesSelector? InstancesSelector { get; set; }

    /// <summary>If true, ELB will be an internal ELB.</summary>
    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    /// <summary>A list of listener blocks. Listeners documented below.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta2ELBSpecForProviderListener>? Listener { get; set; }

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
    public IList<V1beta2ELBSpecForProviderSubnetsRefs>? SubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsSelector")]
    public V1beta2ELBSpecForProviderSubnetsSelector? SubnetsSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>An Access Logs block. Access Logs documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecInitProviderAccessLogs
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
public partial class V1beta2ELBSpecInitProviderHealthCheck
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecInitProviderInstancesRefsPolicyResolutionEnum>))]
public enum V1beta2ELBSpecInitProviderInstancesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecInitProviderInstancesRefsPolicyResolveEnum>))]
public enum V1beta2ELBSpecInitProviderInstancesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecInitProviderInstancesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ELBSpecInitProviderInstancesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ELBSpecInitProviderInstancesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecInitProviderInstancesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ELBSpecInitProviderInstancesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecInitProviderInstancesSelectorPolicyResolutionEnum>))]
public enum V1beta2ELBSpecInitProviderInstancesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecInitProviderInstancesSelectorPolicyResolveEnum>))]
public enum V1beta2ELBSpecInitProviderInstancesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecInitProviderInstancesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ELBSpecInitProviderInstancesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ELBSpecInitProviderInstancesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Instance in ec2 to populate instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecInitProviderInstancesSelector
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
    public V1beta2ELBSpecInitProviderInstancesSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecInitProviderListener
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecInitProviderSubnetsRefsPolicyResolutionEnum>))]
public enum V1beta2ELBSpecInitProviderSubnetsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecInitProviderSubnetsRefsPolicyResolveEnum>))]
public enum V1beta2ELBSpecInitProviderSubnetsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecInitProviderSubnetsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ELBSpecInitProviderSubnetsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ELBSpecInitProviderSubnetsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecInitProviderSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ELBSpecInitProviderSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecInitProviderSubnetsSelectorPolicyResolutionEnum>))]
public enum V1beta2ELBSpecInitProviderSubnetsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecInitProviderSubnetsSelectorPolicyResolveEnum>))]
public enum V1beta2ELBSpecInitProviderSubnetsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecInitProviderSubnetsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ELBSpecInitProviderSubnetsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ELBSpecInitProviderSubnetsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecInitProviderSubnetsSelector
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
    public V1beta2ELBSpecInitProviderSubnetsSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2ELBSpecInitProvider
{
    /// <summary>An Access Logs block. Access Logs documented below.</summary>
    [JsonPropertyName("accessLogs")]
    public V1beta2ELBSpecInitProviderAccessLogs? AccessLogs { get; set; }

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
    public V1beta2ELBSpecInitProviderHealthCheck? HealthCheck { get; set; }

    /// <summary>The time in seconds that the connection is allowed to be idle. Default: 60</summary>
    [JsonPropertyName("idleTimeout")]
    public double? IdleTimeout { get; set; }

    /// <summary>A list of instance ids to place in the ELB pool.</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }

    /// <summary>References to Instance in ec2 to populate instances.</summary>
    [JsonPropertyName("instancesRefs")]
    public IList<V1beta2ELBSpecInitProviderInstancesRefs>? InstancesRefs { get; set; }

    /// <summary>Selector for a list of Instance in ec2 to populate instances.</summary>
    [JsonPropertyName("instancesSelector")]
    public V1beta2ELBSpecInitProviderInstancesSelector? InstancesSelector { get; set; }

    /// <summary>If true, ELB will be an internal ELB.</summary>
    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    /// <summary>A list of listener blocks. Listeners documented below.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta2ELBSpecInitProviderListener>? Listener { get; set; }

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
    public IList<V1beta2ELBSpecInitProviderSubnetsRefs>? SubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetsSelector")]
    public V1beta2ELBSpecInitProviderSubnetsSelector? SubnetsSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecManagementPoliciesEnum>))]
public enum V1beta2ELBSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ELBSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ELBSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ELBSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ELBSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ELBSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ELBSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ELBSpec defines the desired state of ELB</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBSpec
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
    public V1beta2ELBSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ELBSpecForProvider ForProvider { get; set; }

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
    public V1beta2ELBSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ELBSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ELBSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ELBSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An Access Logs block. Access Logs documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ELBStatusAtProviderAccessLogs
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
public partial class V1beta2ELBStatusAtProviderHealthCheck
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
public partial class V1beta2ELBStatusAtProviderListener
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
public partial class V1beta2ELBStatusAtProvider
{
    /// <summary>An Access Logs block. Access Logs documented below.</summary>
    [JsonPropertyName("accessLogs")]
    public V1beta2ELBStatusAtProviderAccessLogs? AccessLogs { get; set; }

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
    public V1beta2ELBStatusAtProviderHealthCheck? HealthCheck { get; set; }

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
    public IList<V1beta2ELBStatusAtProviderListener>? Listener { get; set; }

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
public partial class V1beta2ELBStatusConditions
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
public partial class V1beta2ELBStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ELBStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ELBStatusConditions>? Conditions { get; set; }

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
public partial class V1beta2ELB : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ELBSpec>, IStatus<V1beta2ELBStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ELB";
    public const string KubeGroup = "elb.aws.upbound.io";
    public const string KubePluralName = "elbs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elb.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ELB";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ELBSpec defines the desired state of ELB</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ELBSpec Spec { get; set; }

    /// <summary>ELBStatus defines the observed state of ELB.</summary>
    [JsonPropertyName("status")]
    public V1beta2ELBStatus? Status { get; set; }
}