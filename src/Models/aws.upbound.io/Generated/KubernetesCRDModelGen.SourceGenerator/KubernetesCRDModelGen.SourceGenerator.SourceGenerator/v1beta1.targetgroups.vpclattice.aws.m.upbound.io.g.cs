#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vpclattice.aws.m.upbound.io;
/// <summary>TargetGroup is the Schema for the TargetGroups API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TargetGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1TargetGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TargetGroupList";
    public const string KubeGroup = "vpclattice.aws.m.upbound.io";
    public const string KubePluralName = "targetgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vpclattice.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TargetGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1TargetGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1TargetGroup> Items { get; set; }
}

/// <summary>The codes to use when checking for a successful response from a target. These are called Success codes in the console.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecForProviderConfigHealthCheckMatcher
{
    /// <summary>The HTTP codes to use when checking for a successful response from a target.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The health check configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecForProviderConfigHealthCheck
{
    /// <summary>Indicates whether health checking is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The approximate amount of time, in seconds, between health checks of an individual target. The range is 5–300 seconds. The default is 30 seconds.</summary>
    [JsonPropertyName("healthCheckIntervalSeconds")]
    public double? HealthCheckIntervalSeconds { get; set; }

    /// <summary>The amount of time, in seconds, to wait before reporting a target as unhealthy. The range is 1–120 seconds. The default is 5 seconds.</summary>
    [JsonPropertyName("healthCheckTimeoutSeconds")]
    public double? HealthCheckTimeoutSeconds { get; set; }

    [JsonPropertyName("healthyThresholdCount")]
    public double? HealthyThresholdCount { get; set; }

    /// <summary>The codes to use when checking for a successful response from a target. These are called Success codes in the console.</summary>
    [JsonPropertyName("matcher")]
    public V1beta1TargetGroupSpecForProviderConfigHealthCheckMatcher? Matcher { get; set; }

    /// <summary>The destination for health checks on the targets. If the protocol version is HTTP/1.1 or HTTP/2, specify a valid URI (for example, /path?query). The default path is /. Health checks are not supported if the protocol version is gRPC, however, you can choose HTTP/1.1 or HTTP/2 and specify a valid URI.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port on which the targets are listening.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol to use for routing traffic to the targets. Valid Values are HTTP | HTTPS.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The protocol version. Valid Values are HTTP1 | HTTP2 | GRPC. Default value is HTTP1.</summary>
    [JsonPropertyName("protocolVersion")]
    public string? ProtocolVersion { get; set; }

    /// <summary>The number of consecutive failed health checks required before considering a target unhealthy. The range is 2–10. The default is 2.</summary>
    [JsonPropertyName("unhealthyThresholdCount")]
    public double? UnhealthyThresholdCount { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TargetGroupSpecForProviderConfigVpcIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1TargetGroupSpecForProviderConfigVpcIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TargetGroupSpecForProviderConfigVpcIdentifierRefPolicyResolveEnum>))]
public enum V1beta1TargetGroupSpecForProviderConfigVpcIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecForProviderConfigVpcIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TargetGroupSpecForProviderConfigVpcIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TargetGroupSpecForProviderConfigVpcIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPC in ec2 to populate vpcIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecForProviderConfigVpcIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetGroupSpecForProviderConfigVpcIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TargetGroupSpecForProviderConfigVpcIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1TargetGroupSpecForProviderConfigVpcIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TargetGroupSpecForProviderConfigVpcIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1TargetGroupSpecForProviderConfigVpcIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecForProviderConfigVpcIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TargetGroupSpecForProviderConfigVpcIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TargetGroupSpecForProviderConfigVpcIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPC in ec2 to populate vpcIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecForProviderConfigVpcIdentifierSelector
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
    public V1beta1TargetGroupSpecForProviderConfigVpcIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>The target group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecForProviderConfig
{
    /// <summary>The health check configuration.</summary>
    [JsonPropertyName("healthCheck")]
    public V1beta1TargetGroupSpecForProviderConfigHealthCheck? HealthCheck { get; set; }

    /// <summary>The type of IP address used for the target group. Valid values: IPV4 | IPV6.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>The version of the event structure that the Lambda function receives. Supported only if type is LAMBDA. Valid Values are V1 | V2.</summary>
    [JsonPropertyName("lambdaEventStructureVersion")]
    public string? LambdaEventStructureVersion { get; set; }

    /// <summary>The port on which the targets are listening.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol to use for routing traffic to the targets. Valid Values are HTTP | HTTPS.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The protocol version. Valid Values are HTTP1 | HTTP2 | GRPC. Default value is HTTP1.</summary>
    [JsonPropertyName("protocolVersion")]
    public string? ProtocolVersion { get; set; }

    /// <summary>The ID of the VPC.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcIdentifier.</summary>
    [JsonPropertyName("vpcIdentifierRef")]
    public V1beta1TargetGroupSpecForProviderConfigVpcIdentifierRef? VpcIdentifierRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcIdentifier.</summary>
    [JsonPropertyName("vpcIdentifierSelector")]
    public V1beta1TargetGroupSpecForProviderConfigVpcIdentifierSelector? VpcIdentifierSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecForProvider
{
    /// <summary>The target group configuration.</summary>
    [JsonPropertyName("config")]
    public V1beta1TargetGroupSpecForProviderConfig? Config { get; set; }

    /// <summary>The name of the target group. The name must be unique within the account. The valid characters are a-z, 0-9, and hyphens (-). You can&apos;t use a hyphen as the first or last character, or immediately after another hyphen.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of target group. Valid Values are IP | LAMBDA | INSTANCE | ALB</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The codes to use when checking for a successful response from a target. These are called Success codes in the console.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecInitProviderConfigHealthCheckMatcher
{
    /// <summary>The HTTP codes to use when checking for a successful response from a target.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The health check configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecInitProviderConfigHealthCheck
{
    /// <summary>Indicates whether health checking is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The approximate amount of time, in seconds, between health checks of an individual target. The range is 5–300 seconds. The default is 30 seconds.</summary>
    [JsonPropertyName("healthCheckIntervalSeconds")]
    public double? HealthCheckIntervalSeconds { get; set; }

    /// <summary>The amount of time, in seconds, to wait before reporting a target as unhealthy. The range is 1–120 seconds. The default is 5 seconds.</summary>
    [JsonPropertyName("healthCheckTimeoutSeconds")]
    public double? HealthCheckTimeoutSeconds { get; set; }

    [JsonPropertyName("healthyThresholdCount")]
    public double? HealthyThresholdCount { get; set; }

    /// <summary>The codes to use when checking for a successful response from a target. These are called Success codes in the console.</summary>
    [JsonPropertyName("matcher")]
    public V1beta1TargetGroupSpecInitProviderConfigHealthCheckMatcher? Matcher { get; set; }

    /// <summary>The destination for health checks on the targets. If the protocol version is HTTP/1.1 or HTTP/2, specify a valid URI (for example, /path?query). The default path is /. Health checks are not supported if the protocol version is gRPC, however, you can choose HTTP/1.1 or HTTP/2 and specify a valid URI.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port on which the targets are listening.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol to use for routing traffic to the targets. Valid Values are HTTP | HTTPS.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The protocol version. Valid Values are HTTP1 | HTTP2 | GRPC. Default value is HTTP1.</summary>
    [JsonPropertyName("protocolVersion")]
    public string? ProtocolVersion { get; set; }

    /// <summary>The number of consecutive failed health checks required before considering a target unhealthy. The range is 2–10. The default is 2.</summary>
    [JsonPropertyName("unhealthyThresholdCount")]
    public double? UnhealthyThresholdCount { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierRefPolicyResolveEnum>))]
public enum V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPC in ec2 to populate vpcIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPC in ec2 to populate vpcIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierSelector
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
    public V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>The target group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpecInitProviderConfig
{
    /// <summary>The health check configuration.</summary>
    [JsonPropertyName("healthCheck")]
    public V1beta1TargetGroupSpecInitProviderConfigHealthCheck? HealthCheck { get; set; }

    /// <summary>The type of IP address used for the target group. Valid values: IPV4 | IPV6.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>The version of the event structure that the Lambda function receives. Supported only if type is LAMBDA. Valid Values are V1 | V2.</summary>
    [JsonPropertyName("lambdaEventStructureVersion")]
    public string? LambdaEventStructureVersion { get; set; }

    /// <summary>The port on which the targets are listening.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol to use for routing traffic to the targets. Valid Values are HTTP | HTTPS.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The protocol version. Valid Values are HTTP1 | HTTP2 | GRPC. Default value is HTTP1.</summary>
    [JsonPropertyName("protocolVersion")]
    public string? ProtocolVersion { get; set; }

    /// <summary>The ID of the VPC.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcIdentifier.</summary>
    [JsonPropertyName("vpcIdentifierRef")]
    public V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierRef? VpcIdentifierRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcIdentifier.</summary>
    [JsonPropertyName("vpcIdentifierSelector")]
    public V1beta1TargetGroupSpecInitProviderConfigVpcIdentifierSelector? VpcIdentifierSelector { get; set; }
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
public partial class V1beta1TargetGroupSpecInitProvider
{
    /// <summary>The target group configuration.</summary>
    [JsonPropertyName("config")]
    public V1beta1TargetGroupSpecInitProviderConfig? Config { get; set; }

    /// <summary>The name of the target group. The name must be unique within the account. The valid characters are a-z, 0-9, and hyphens (-). You can&apos;t use a hyphen as the first or last character, or immediately after another hyphen.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of target group. Valid Values are IP | LAMBDA | INSTANCE | ALB</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TargetGroupSpecManagementPoliciesEnum>))]
public enum V1beta1TargetGroupSpecManagementPoliciesEnum
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
public partial class V1beta1TargetGroupSpecProviderConfigRef
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
public partial class V1beta1TargetGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>TargetGroupSpec defines the desired state of TargetGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1TargetGroupSpecForProvider ForProvider { get; set; }

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
    public V1beta1TargetGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TargetGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TargetGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TargetGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The codes to use when checking for a successful response from a target. These are called Success codes in the console.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupStatusAtProviderConfigHealthCheckMatcher
{
    /// <summary>The HTTP codes to use when checking for a successful response from a target.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The health check configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupStatusAtProviderConfigHealthCheck
{
    /// <summary>Indicates whether health checking is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The approximate amount of time, in seconds, between health checks of an individual target. The range is 5–300 seconds. The default is 30 seconds.</summary>
    [JsonPropertyName("healthCheckIntervalSeconds")]
    public double? HealthCheckIntervalSeconds { get; set; }

    /// <summary>The amount of time, in seconds, to wait before reporting a target as unhealthy. The range is 1–120 seconds. The default is 5 seconds.</summary>
    [JsonPropertyName("healthCheckTimeoutSeconds")]
    public double? HealthCheckTimeoutSeconds { get; set; }

    [JsonPropertyName("healthyThresholdCount")]
    public double? HealthyThresholdCount { get; set; }

    /// <summary>The codes to use when checking for a successful response from a target. These are called Success codes in the console.</summary>
    [JsonPropertyName("matcher")]
    public V1beta1TargetGroupStatusAtProviderConfigHealthCheckMatcher? Matcher { get; set; }

    /// <summary>The destination for health checks on the targets. If the protocol version is HTTP/1.1 or HTTP/2, specify a valid URI (for example, /path?query). The default path is /. Health checks are not supported if the protocol version is gRPC, however, you can choose HTTP/1.1 or HTTP/2 and specify a valid URI.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port on which the targets are listening.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol to use for routing traffic to the targets. Valid Values are HTTP | HTTPS.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The protocol version. Valid Values are HTTP1 | HTTP2 | GRPC. Default value is HTTP1.</summary>
    [JsonPropertyName("protocolVersion")]
    public string? ProtocolVersion { get; set; }

    /// <summary>The number of consecutive failed health checks required before considering a target unhealthy. The range is 2–10. The default is 2.</summary>
    [JsonPropertyName("unhealthyThresholdCount")]
    public double? UnhealthyThresholdCount { get; set; }
}

/// <summary>The target group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupStatusAtProviderConfig
{
    /// <summary>The health check configuration.</summary>
    [JsonPropertyName("healthCheck")]
    public V1beta1TargetGroupStatusAtProviderConfigHealthCheck? HealthCheck { get; set; }

    /// <summary>The type of IP address used for the target group. Valid values: IPV4 | IPV6.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>The version of the event structure that the Lambda function receives. Supported only if type is LAMBDA. Valid Values are V1 | V2.</summary>
    [JsonPropertyName("lambdaEventStructureVersion")]
    public string? LambdaEventStructureVersion { get; set; }

    /// <summary>The port on which the targets are listening.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol to use for routing traffic to the targets. Valid Values are HTTP | HTTPS.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The protocol version. Valid Values are HTTP1 | HTTP2 | GRPC. Default value is HTTP1.</summary>
    [JsonPropertyName("protocolVersion")]
    public string? ProtocolVersion { get; set; }

    /// <summary>The ID of the VPC.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupStatusAtProvider
{
    /// <summary>ARN of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The target group configuration.</summary>
    [JsonPropertyName("config")]
    public V1beta1TargetGroupStatusAtProviderConfig? Config { get; set; }

    /// <summary>Unique identifier for the target group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the target group. The name must be unique within the account. The valid characters are a-z, 0-9, and hyphens (-). You can&apos;t use a hyphen as the first or last character, or immediately after another hyphen.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Status of the target group.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The type of target group. Valid Values are IP | LAMBDA | INSTANCE | ALB</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupStatusConditions
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

/// <summary>TargetGroupStatus defines the observed state of TargetGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetGroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1TargetGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TargetGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TargetGroup is the Schema for the TargetGroups API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TargetGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TargetGroupSpec>, IStatus<V1beta1TargetGroupStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TargetGroup";
    public const string KubeGroup = "vpclattice.aws.m.upbound.io";
    public const string KubePluralName = "targetgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vpclattice.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TargetGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TargetGroupSpec defines the desired state of TargetGroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta1TargetGroupSpec Spec { get; set; }

    /// <summary>TargetGroupStatus defines the observed state of TargetGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1TargetGroupStatus? Status { get; set; }
}