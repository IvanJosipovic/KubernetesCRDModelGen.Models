#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apprunner.aws.upbound.io;
/// <summary>Service is the Schema for the Services API. Manages an App Runner Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Service>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ServiceList";
    public const string KubeGroup = "apprunner.aws.upbound.io";
    public const string KubePluralName = "services";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apprunner.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Service objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Service> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecDeletionPolicyEnum>))]
public enum V1beta2ServiceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>(Forces new resource) An optional custom encryption key that App Runner uses to encrypt the copy of your source repository that it maintains and your service logs. By default, App Runner uses an AWS managed CMK. See Encryption Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderEncryptionConfiguration
{
    /// <summary>ARN of the KMS key used for encryption.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Settings of the health check that AWS App Runner performs to monitor the health of your service. See Health Check Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderHealthCheckConfiguration
{
    /// <summary>Number of consecutive checks that must succeed before App Runner decides that the service is healthy. Defaults to 1. Minimum value of 1. Maximum value of 20.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time interval, in seconds, between health checks. Defaults to 5. Minimum value of 1. Maximum value of 20.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>URL to send requests to for health checks. Defaults to /. Minimum length of 0. Maximum length of 51200.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>IP protocol that App Runner uses to perform health checks for your service. Valid values: TCP, HTTP. Defaults to TCP. If you set protocol to HTTP, App Runner sends health check requests to the HTTP path specified by path.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Time, in seconds, to wait for a health check response before deciding it failed. Defaults to 2. Minimum value of  1. Maximum value of 20.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Number of consecutive checks that must fail before App Runner decides that the service is unhealthy. Defaults to 5. Minimum value of  1. Maximum value of 20.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>The runtime configuration of instances (scaling units) of the App Runner service. See Instance Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderInstanceConfiguration
{
    /// <summary>Number of CPU units reserved for each instance of your App Runner service represented as a String. Defaults to 1024. Valid values: 256|512|1024|2048|4096|(0.25|0.5|1|2|4) vCPU.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>ARN of an IAM role that provides permissions to your App Runner service. These are permissions that your code needs when it calls any AWS APIs.</summary>
    [JsonPropertyName("instanceRoleArn")]
    public string? InstanceRoleArn { get; set; }

    /// <summary>Amount of memory, in MB or GB, reserved for each instance of your App Runner service. Defaults to 2048. Valid values: 512|1024|2048|3072|4096|6144|8192|10240|12288|(0.5|1|2|3|4|6|8|10|12) GB.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelector
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
    public V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Network configuration settings for outbound message traffic. See Egress Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfiguration
{
    /// <summary>The type of egress configuration. Valid values are: DEFAULT and VPC.</summary>
    [JsonPropertyName("egressType")]
    public string? EgressType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the App Runner VPC connector that you want to associate with your App Runner service. Only valid when EgressType = VPC.</summary>
    [JsonPropertyName("vpcConnectorArn")]
    public string? VpcConnectorArn { get; set; }

    /// <summary>Reference to a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
    [JsonPropertyName("vpcConnectorArnRef")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRef? VpcConnectorArnRef { get; set; }

    /// <summary>Selector for a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
    [JsonPropertyName("vpcConnectorArnSelector")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelector? VpcConnectorArnSelector { get; set; }
}

/// <summary>Network configuration settings for inbound network traffic. See Ingress Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationIngressConfiguration
{
    /// <summary>Specifies whether your App Runner service is publicly accessible. To make the service publicly accessible set it to True. To make the service privately accessible, from only within an Amazon VPC set it to False.</summary>
    [JsonPropertyName("isPubliclyAccessible")]
    public bool? IsPubliclyAccessible { get; set; }
}

/// <summary>Configuration settings related to network traffic of the web application that the App Runner service runs. See Network Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfiguration
{
    /// <summary>Network configuration settings for outbound message traffic. See Egress Configuration below for more details.</summary>
    [JsonPropertyName("egressConfiguration")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationEgressConfiguration? EgressConfiguration { get; set; }

    /// <summary>Network configuration settings for inbound network traffic. See Ingress Configuration below for more details.</summary>
    [JsonPropertyName("ingressConfiguration")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationIngressConfiguration? IngressConfiguration { get; set; }

    /// <summary>App Runner provides you with the option to choose between Internet Protocol version 4 (IPv4) and dual stack (IPv4 and IPv6) for your incoming public network configuration. Valid values: IPV4, DUAL_STACK. Default: IPV4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelector
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
    public V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The observability configuration of your service. See Observability Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderObservabilityConfiguration
{
    /// <summary>ARN of the observability configuration that is associated with the service. Specified only when observability_enabled is true.</summary>
    [JsonPropertyName("observabilityConfigurationArn")]
    public string? ObservabilityConfigurationArn { get; set; }

    /// <summary>Reference to a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
    [JsonPropertyName("observabilityConfigurationArnRef")]
    public V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRef? ObservabilityConfigurationArnRef { get; set; }

    /// <summary>Selector for a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
    [JsonPropertyName("observabilityConfigurationArnSelector")]
    public V1beta2ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelector? ObservabilityConfigurationArnSelector { get; set; }

    /// <summary>When true, an observability configuration resource is associated with the service.</summary>
    [JsonPropertyName("observabilityEnabled")]
    public bool? ObservabilityEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Connection in apprunner to populate connectionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Connection in apprunner to populate connectionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelector
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
    public V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Describes resources needed to authenticate access to some source repositories. See Authentication Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfiguration
{
    /// <summary>ARN of the IAM role that grants the App Runner service access to a source repository. Required for ECR image repositories (but not for ECR Public)</summary>
    [JsonPropertyName("accessRoleArn")]
    public string? AccessRoleArn { get; set; }

    /// <summary>ARN of the App Runner connection that enables the App Runner service to connect to a source repository. Required for GitHub code repositories.</summary>
    [JsonPropertyName("connectionArn")]
    public string? ConnectionArn { get; set; }

    /// <summary>Reference to a Connection in apprunner to populate connectionArn.</summary>
    [JsonPropertyName("connectionArnRef")]
    public V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRef? ConnectionArnRef { get; set; }

    /// <summary>Selector for a Connection in apprunner to populate connectionArn.</summary>
    [JsonPropertyName("connectionArnSelector")]
    public V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelector? ConnectionArnSelector { get; set; }
}

/// <summary>Basic configuration for building and running the App Runner service. Use this parameter to quickly launch an App Runner service without providing an apprunner.yaml file in the source code repository (or ignoring the file if it exists). See Code Configuration Values below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues
{
    /// <summary>Command App Runner runs to build your application.</summary>
    [JsonPropertyName("buildCommand")]
    public string? BuildCommand { get; set; }

    /// <summary>Port that your application listens to in the container. Defaults to &quot;8080&quot;.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Runtime environment type for building and running an App Runner service. Represents a programming language runtime. Valid values: PYTHON_3, NODEJS_12, NODEJS_14, NODEJS_16, CORRETTO_8, CORRETTO_11, GO_1, DOTNET_6, PHP_81, RUBY_31.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>Secrets and parameters available to your service as environment variables. A map of key/value pairs, where the key is the desired name of the Secret in the environment (i.e. it does not have to match the name of the secret in Secrets Manager or SSM Parameter Store), and the value is the ARN of the secret from AWS Secrets Manager or the ARN of the parameter in AWS SSM Parameter Store.</summary>
    [JsonPropertyName("runtimeEnvironmentSecrets")]
    public IDictionary<string, string>? RuntimeEnvironmentSecrets { get; set; }

    /// <summary>Environment variables available to your running App Runner service. A map of key/value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren&apos;t valid.</summary>
    [JsonPropertyName("runtimeEnvironmentVariables")]
    public IDictionary<string, string>? RuntimeEnvironmentVariables { get; set; }

    /// <summary>Command App Runner runs to start the application in the source image. If specified, this command overrides the Docker image’s default start command.</summary>
    [JsonPropertyName("startCommand")]
    public string? StartCommand { get; set; }
}

/// <summary>Configuration for building and running the service from a source code repository. See Code Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderSourceConfigurationCodeRepositoryCodeConfiguration
{
    /// <summary>Basic configuration for building and running the App Runner service. Use this parameter to quickly launch an App Runner service without providing an apprunner.yaml file in the source code repository (or ignoring the file if it exists). See Code Configuration Values below for more details.</summary>
    [JsonPropertyName("codeConfigurationValues")]
    public V1beta2ServiceSpecForProviderSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues? CodeConfigurationValues { get; set; }

    /// <summary>Source of the App Runner configuration. Valid values: REPOSITORY, API. Values are interpreted as follows:</summary>
    [JsonPropertyName("configurationSource")]
    public string? ConfigurationSource { get; set; }
}

/// <summary>Version that should be used within the source code repository. See Source Code Version below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderSourceConfigurationCodeRepositorySourceCodeVersion
{
    /// <summary>Type of version identifier. For a git-based repository, branches represent versions. Valid values: BRANCH.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Source code version. For a git-based repository, a branch name maps to a specific version. App Runner uses the most recent commit to the branch.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Description of a source code repository. See Code Repository below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderSourceConfigurationCodeRepository
{
    /// <summary>Configuration for building and running the service from a source code repository. See Code Configuration below for more details.</summary>
    [JsonPropertyName("codeConfiguration")]
    public V1beta2ServiceSpecForProviderSourceConfigurationCodeRepositoryCodeConfiguration? CodeConfiguration { get; set; }

    /// <summary>Location of the repository that contains the source code.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }

    /// <summary>Version that should be used within the source code repository. See Source Code Version below for more details.</summary>
    [JsonPropertyName("sourceCodeVersion")]
    public V1beta2ServiceSpecForProviderSourceConfigurationCodeRepositorySourceCodeVersion? SourceCodeVersion { get; set; }

    /// <summary>The path of the directory that stores source code and configuration files. The build and start commands also execute from here. The path is absolute from root and, if not specified, defaults to the repository root.</summary>
    [JsonPropertyName("sourceDirectory")]
    public string? SourceDirectory { get; set; }
}

/// <summary>Configuration for running the identified image. See Image Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderSourceConfigurationImageRepositoryImageConfiguration
{
    /// <summary>Port that your application listens to in the container. Defaults to &quot;8080&quot;.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Secrets and parameters available to your service as environment variables. A map of key/value pairs, where the key is the desired name of the Secret in the environment (i.e. it does not have to match the name of the secret in Secrets Manager or SSM Parameter Store), and the value is the ARN of the secret from AWS Secrets Manager or the ARN of the parameter in AWS SSM Parameter Store.</summary>
    [JsonPropertyName("runtimeEnvironmentSecrets")]
    public IDictionary<string, string>? RuntimeEnvironmentSecrets { get; set; }

    /// <summary>Environment variables available to your running App Runner service. A map of key/value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren&apos;t valid.</summary>
    [JsonPropertyName("runtimeEnvironmentVariables")]
    public IDictionary<string, string>? RuntimeEnvironmentVariables { get; set; }

    /// <summary>Command App Runner runs to start the application in the source image. If specified, this command overrides the Docker image’s default start command.</summary>
    [JsonPropertyName("startCommand")]
    public string? StartCommand { get; set; }
}

/// <summary>Description of a source image repository. See Image Repository below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderSourceConfigurationImageRepository
{
    /// <summary>Configuration for running the identified image. See Image Configuration below for more details.</summary>
    [JsonPropertyName("imageConfiguration")]
    public V1beta2ServiceSpecForProviderSourceConfigurationImageRepositoryImageConfiguration? ImageConfiguration { get; set; }

    /// <summary>
    /// Identifier of an image. For an image in Amazon Elastic Container Registry (Amazon ECR), this is an image name. For the
    /// image name format, see Pulling an image in the Amazon ECR User Guide.
    /// </summary>
    [JsonPropertyName("imageIdentifier")]
    public string? ImageIdentifier { get; set; }

    /// <summary>Type of the image repository. This reflects the repository provider and whether the repository is private or public. Valid values: ECR , ECR_PUBLIC.</summary>
    [JsonPropertyName("imageRepositoryType")]
    public string? ImageRepositoryType { get; set; }
}

/// <summary>The source to deploy to the App Runner service. Can be a code or an image repository. See Source Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderSourceConfiguration
{
    /// <summary>Describes resources needed to authenticate access to some source repositories. See Authentication Configuration below for more details.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta2ServiceSpecForProviderSourceConfigurationAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>Whether continuous integration from the source repository is enabled for the App Runner service. If set to true, each repository change (source code commit or new image version) starts a deployment. Defaults to true.</summary>
    [JsonPropertyName("autoDeploymentsEnabled")]
    public bool? AutoDeploymentsEnabled { get; set; }

    /// <summary>Description of a source code repository. See Code Repository below for more details.</summary>
    [JsonPropertyName("codeRepository")]
    public V1beta2ServiceSpecForProviderSourceConfigurationCodeRepository? CodeRepository { get; set; }

    /// <summary>Description of a source image repository. See Image Repository below for more details.</summary>
    [JsonPropertyName("imageRepository")]
    public V1beta2ServiceSpecForProviderSourceConfigurationImageRepository? ImageRepository { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProvider
{
    /// <summary>ARN of an App Runner automatic scaling configuration resource that you want to associate with your service. If not provided, App Runner associates the latest revision of a default auto scaling configuration.</summary>
    [JsonPropertyName("autoScalingConfigurationArn")]
    public string? AutoScalingConfigurationArn { get; set; }

    /// <summary>(Forces new resource) An optional custom encryption key that App Runner uses to encrypt the copy of your source repository that it maintains and your service logs. By default, App Runner uses an AWS managed CMK. See Encryption Configuration below for more details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2ServiceSpecForProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Settings of the health check that AWS App Runner performs to monitor the health of your service. See Health Check Configuration below for more details.</summary>
    [JsonPropertyName("healthCheckConfiguration")]
    public V1beta2ServiceSpecForProviderHealthCheckConfiguration? HealthCheckConfiguration { get; set; }

    /// <summary>The runtime configuration of instances (scaling units) of the App Runner service. See Instance Configuration below for more details.</summary>
    [JsonPropertyName("instanceConfiguration")]
    public V1beta2ServiceSpecForProviderInstanceConfiguration? InstanceConfiguration { get; set; }

    /// <summary>Configuration settings related to network traffic of the web application that the App Runner service runs. See Network Configuration below for more details.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta2ServiceSpecForProviderNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>The observability configuration of your service. See Observability Configuration below for more details.</summary>
    [JsonPropertyName("observabilityConfiguration")]
    public V1beta2ServiceSpecForProviderObservabilityConfiguration? ObservabilityConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>(Forces new resource) Name of the service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>The source to deploy to the App Runner service. Can be a code or an image repository. See Source Configuration below for more details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta2ServiceSpecForProviderSourceConfiguration? SourceConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>(Forces new resource) An optional custom encryption key that App Runner uses to encrypt the copy of your source repository that it maintains and your service logs. By default, App Runner uses an AWS managed CMK. See Encryption Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderEncryptionConfiguration
{
    /// <summary>ARN of the KMS key used for encryption.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Settings of the health check that AWS App Runner performs to monitor the health of your service. See Health Check Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderHealthCheckConfiguration
{
    /// <summary>Number of consecutive checks that must succeed before App Runner decides that the service is healthy. Defaults to 1. Minimum value of 1. Maximum value of 20.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time interval, in seconds, between health checks. Defaults to 5. Minimum value of 1. Maximum value of 20.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>URL to send requests to for health checks. Defaults to /. Minimum length of 0. Maximum length of 51200.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>IP protocol that App Runner uses to perform health checks for your service. Valid values: TCP, HTTP. Defaults to TCP. If you set protocol to HTTP, App Runner sends health check requests to the HTTP path specified by path.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Time, in seconds, to wait for a health check response before deciding it failed. Defaults to 2. Minimum value of  1. Maximum value of 20.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Number of consecutive checks that must fail before App Runner decides that the service is unhealthy. Defaults to 5. Minimum value of  1. Maximum value of 20.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>The runtime configuration of instances (scaling units) of the App Runner service. See Instance Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderInstanceConfiguration
{
    /// <summary>Number of CPU units reserved for each instance of your App Runner service represented as a String. Defaults to 1024. Valid values: 256|512|1024|2048|4096|(0.25|0.5|1|2|4) vCPU.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>ARN of an IAM role that provides permissions to your App Runner service. These are permissions that your code needs when it calls any AWS APIs.</summary>
    [JsonPropertyName("instanceRoleArn")]
    public string? InstanceRoleArn { get; set; }

    /// <summary>Amount of memory, in MB or GB, reserved for each instance of your App Runner service. Defaults to 2048. Valid values: 512|1024|2048|3072|4096|6144|8192|10240|12288|(0.5|1|2|3|4|6|8|10|12) GB.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelector
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
    public V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Network configuration settings for outbound message traffic. See Egress Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfiguration
{
    /// <summary>The type of egress configuration. Valid values are: DEFAULT and VPC.</summary>
    [JsonPropertyName("egressType")]
    public string? EgressType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the App Runner VPC connector that you want to associate with your App Runner service. Only valid when EgressType = VPC.</summary>
    [JsonPropertyName("vpcConnectorArn")]
    public string? VpcConnectorArn { get; set; }

    /// <summary>Reference to a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
    [JsonPropertyName("vpcConnectorArnRef")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRef? VpcConnectorArnRef { get; set; }

    /// <summary>Selector for a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
    [JsonPropertyName("vpcConnectorArnSelector")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelector? VpcConnectorArnSelector { get; set; }
}

/// <summary>Network configuration settings for inbound network traffic. See Ingress Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationIngressConfiguration
{
    /// <summary>Specifies whether your App Runner service is publicly accessible. To make the service publicly accessible set it to True. To make the service privately accessible, from only within an Amazon VPC set it to False.</summary>
    [JsonPropertyName("isPubliclyAccessible")]
    public bool? IsPubliclyAccessible { get; set; }
}

/// <summary>Configuration settings related to network traffic of the web application that the App Runner service runs. See Network Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfiguration
{
    /// <summary>Network configuration settings for outbound message traffic. See Egress Configuration below for more details.</summary>
    [JsonPropertyName("egressConfiguration")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationEgressConfiguration? EgressConfiguration { get; set; }

    /// <summary>Network configuration settings for inbound network traffic. See Ingress Configuration below for more details.</summary>
    [JsonPropertyName("ingressConfiguration")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationIngressConfiguration? IngressConfiguration { get; set; }

    /// <summary>App Runner provides you with the option to choose between Internet Protocol version 4 (IPv4) and dual stack (IPv4 and IPv6) for your incoming public network configuration. Valid values: IPV4, DUAL_STACK. Default: IPV4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelector
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
    public V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The observability configuration of your service. See Observability Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderObservabilityConfiguration
{
    /// <summary>ARN of the observability configuration that is associated with the service. Specified only when observability_enabled is true.</summary>
    [JsonPropertyName("observabilityConfigurationArn")]
    public string? ObservabilityConfigurationArn { get; set; }

    /// <summary>Reference to a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
    [JsonPropertyName("observabilityConfigurationArnRef")]
    public V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRef? ObservabilityConfigurationArnRef { get; set; }

    /// <summary>Selector for a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
    [JsonPropertyName("observabilityConfigurationArnSelector")]
    public V1beta2ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelector? ObservabilityConfigurationArnSelector { get; set; }

    /// <summary>When true, an observability configuration resource is associated with the service.</summary>
    [JsonPropertyName("observabilityEnabled")]
    public bool? ObservabilityEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Connection in apprunner to populate connectionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Connection in apprunner to populate connectionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelector
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
    public V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Describes resources needed to authenticate access to some source repositories. See Authentication Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfiguration
{
    /// <summary>ARN of the IAM role that grants the App Runner service access to a source repository. Required for ECR image repositories (but not for ECR Public)</summary>
    [JsonPropertyName("accessRoleArn")]
    public string? AccessRoleArn { get; set; }

    /// <summary>ARN of the App Runner connection that enables the App Runner service to connect to a source repository. Required for GitHub code repositories.</summary>
    [JsonPropertyName("connectionArn")]
    public string? ConnectionArn { get; set; }

    /// <summary>Reference to a Connection in apprunner to populate connectionArn.</summary>
    [JsonPropertyName("connectionArnRef")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRef? ConnectionArnRef { get; set; }

    /// <summary>Selector for a Connection in apprunner to populate connectionArn.</summary>
    [JsonPropertyName("connectionArnSelector")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelector? ConnectionArnSelector { get; set; }
}

/// <summary>Basic configuration for building and running the App Runner service. Use this parameter to quickly launch an App Runner service without providing an apprunner.yaml file in the source code repository (or ignoring the file if it exists). See Code Configuration Values below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues
{
    /// <summary>Command App Runner runs to build your application.</summary>
    [JsonPropertyName("buildCommand")]
    public string? BuildCommand { get; set; }

    /// <summary>Port that your application listens to in the container. Defaults to &quot;8080&quot;.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Runtime environment type for building and running an App Runner service. Represents a programming language runtime. Valid values: PYTHON_3, NODEJS_12, NODEJS_14, NODEJS_16, CORRETTO_8, CORRETTO_11, GO_1, DOTNET_6, PHP_81, RUBY_31.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>Secrets and parameters available to your service as environment variables. A map of key/value pairs, where the key is the desired name of the Secret in the environment (i.e. it does not have to match the name of the secret in Secrets Manager or SSM Parameter Store), and the value is the ARN of the secret from AWS Secrets Manager or the ARN of the parameter in AWS SSM Parameter Store.</summary>
    [JsonPropertyName("runtimeEnvironmentSecrets")]
    public IDictionary<string, string>? RuntimeEnvironmentSecrets { get; set; }

    /// <summary>Environment variables available to your running App Runner service. A map of key/value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren&apos;t valid.</summary>
    [JsonPropertyName("runtimeEnvironmentVariables")]
    public IDictionary<string, string>? RuntimeEnvironmentVariables { get; set; }

    /// <summary>Command App Runner runs to start the application in the source image. If specified, this command overrides the Docker image’s default start command.</summary>
    [JsonPropertyName("startCommand")]
    public string? StartCommand { get; set; }
}

/// <summary>Configuration for building and running the service from a source code repository. See Code Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderSourceConfigurationCodeRepositoryCodeConfiguration
{
    /// <summary>Basic configuration for building and running the App Runner service. Use this parameter to quickly launch an App Runner service without providing an apprunner.yaml file in the source code repository (or ignoring the file if it exists). See Code Configuration Values below for more details.</summary>
    [JsonPropertyName("codeConfigurationValues")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues? CodeConfigurationValues { get; set; }

    /// <summary>Source of the App Runner configuration. Valid values: REPOSITORY, API. Values are interpreted as follows:</summary>
    [JsonPropertyName("configurationSource")]
    public string? ConfigurationSource { get; set; }
}

/// <summary>Version that should be used within the source code repository. See Source Code Version below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderSourceConfigurationCodeRepositorySourceCodeVersion
{
    /// <summary>Type of version identifier. For a git-based repository, branches represent versions. Valid values: BRANCH.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Source code version. For a git-based repository, a branch name maps to a specific version. App Runner uses the most recent commit to the branch.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Description of a source code repository. See Code Repository below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderSourceConfigurationCodeRepository
{
    /// <summary>Configuration for building and running the service from a source code repository. See Code Configuration below for more details.</summary>
    [JsonPropertyName("codeConfiguration")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationCodeRepositoryCodeConfiguration? CodeConfiguration { get; set; }

    /// <summary>Location of the repository that contains the source code.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }

    /// <summary>Version that should be used within the source code repository. See Source Code Version below for more details.</summary>
    [JsonPropertyName("sourceCodeVersion")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationCodeRepositorySourceCodeVersion? SourceCodeVersion { get; set; }

    /// <summary>The path of the directory that stores source code and configuration files. The build and start commands also execute from here. The path is absolute from root and, if not specified, defaults to the repository root.</summary>
    [JsonPropertyName("sourceDirectory")]
    public string? SourceDirectory { get; set; }
}

/// <summary>Configuration for running the identified image. See Image Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderSourceConfigurationImageRepositoryImageConfiguration
{
    /// <summary>Port that your application listens to in the container. Defaults to &quot;8080&quot;.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Secrets and parameters available to your service as environment variables. A map of key/value pairs, where the key is the desired name of the Secret in the environment (i.e. it does not have to match the name of the secret in Secrets Manager or SSM Parameter Store), and the value is the ARN of the secret from AWS Secrets Manager or the ARN of the parameter in AWS SSM Parameter Store.</summary>
    [JsonPropertyName("runtimeEnvironmentSecrets")]
    public IDictionary<string, string>? RuntimeEnvironmentSecrets { get; set; }

    /// <summary>Environment variables available to your running App Runner service. A map of key/value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren&apos;t valid.</summary>
    [JsonPropertyName("runtimeEnvironmentVariables")]
    public IDictionary<string, string>? RuntimeEnvironmentVariables { get; set; }

    /// <summary>Command App Runner runs to start the application in the source image. If specified, this command overrides the Docker image’s default start command.</summary>
    [JsonPropertyName("startCommand")]
    public string? StartCommand { get; set; }
}

/// <summary>Description of a source image repository. See Image Repository below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderSourceConfigurationImageRepository
{
    /// <summary>Configuration for running the identified image. See Image Configuration below for more details.</summary>
    [JsonPropertyName("imageConfiguration")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationImageRepositoryImageConfiguration? ImageConfiguration { get; set; }

    /// <summary>
    /// Identifier of an image. For an image in Amazon Elastic Container Registry (Amazon ECR), this is an image name. For the
    /// image name format, see Pulling an image in the Amazon ECR User Guide.
    /// </summary>
    [JsonPropertyName("imageIdentifier")]
    public string? ImageIdentifier { get; set; }

    /// <summary>Type of the image repository. This reflects the repository provider and whether the repository is private or public. Valid values: ECR , ECR_PUBLIC.</summary>
    [JsonPropertyName("imageRepositoryType")]
    public string? ImageRepositoryType { get; set; }
}

/// <summary>The source to deploy to the App Runner service. Can be a code or an image repository. See Source Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderSourceConfiguration
{
    /// <summary>Describes resources needed to authenticate access to some source repositories. See Authentication Configuration below for more details.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>Whether continuous integration from the source repository is enabled for the App Runner service. If set to true, each repository change (source code commit or new image version) starts a deployment. Defaults to true.</summary>
    [JsonPropertyName("autoDeploymentsEnabled")]
    public bool? AutoDeploymentsEnabled { get; set; }

    /// <summary>Description of a source code repository. See Code Repository below for more details.</summary>
    [JsonPropertyName("codeRepository")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationCodeRepository? CodeRepository { get; set; }

    /// <summary>Description of a source image repository. See Image Repository below for more details.</summary>
    [JsonPropertyName("imageRepository")]
    public V1beta2ServiceSpecInitProviderSourceConfigurationImageRepository? ImageRepository { get; set; }
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
public partial class V1beta2ServiceSpecInitProvider
{
    /// <summary>ARN of an App Runner automatic scaling configuration resource that you want to associate with your service. If not provided, App Runner associates the latest revision of a default auto scaling configuration.</summary>
    [JsonPropertyName("autoScalingConfigurationArn")]
    public string? AutoScalingConfigurationArn { get; set; }

    /// <summary>(Forces new resource) An optional custom encryption key that App Runner uses to encrypt the copy of your source repository that it maintains and your service logs. By default, App Runner uses an AWS managed CMK. See Encryption Configuration below for more details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2ServiceSpecInitProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Settings of the health check that AWS App Runner performs to monitor the health of your service. See Health Check Configuration below for more details.</summary>
    [JsonPropertyName("healthCheckConfiguration")]
    public V1beta2ServiceSpecInitProviderHealthCheckConfiguration? HealthCheckConfiguration { get; set; }

    /// <summary>The runtime configuration of instances (scaling units) of the App Runner service. See Instance Configuration below for more details.</summary>
    [JsonPropertyName("instanceConfiguration")]
    public V1beta2ServiceSpecInitProviderInstanceConfiguration? InstanceConfiguration { get; set; }

    /// <summary>Configuration settings related to network traffic of the web application that the App Runner service runs. See Network Configuration below for more details.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta2ServiceSpecInitProviderNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>The observability configuration of your service. See Observability Configuration below for more details.</summary>
    [JsonPropertyName("observabilityConfiguration")]
    public V1beta2ServiceSpecInitProviderObservabilityConfiguration? ObservabilityConfiguration { get; set; }

    /// <summary>(Forces new resource) Name of the service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>The source to deploy to the App Runner service. Can be a code or an image repository. See Source Configuration below for more details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta2ServiceSpecInitProviderSourceConfiguration? SourceConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecManagementPoliciesEnum>))]
public enum V1beta2ServiceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ServiceSpec defines the desired state of Service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpec
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
    public V1beta2ServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ServiceSpecForProvider ForProvider { get; set; }

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
    public V1beta2ServiceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>(Forces new resource) An optional custom encryption key that App Runner uses to encrypt the copy of your source repository that it maintains and your service logs. By default, App Runner uses an AWS managed CMK. See Encryption Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderEncryptionConfiguration
{
    /// <summary>ARN of the KMS key used for encryption.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Settings of the health check that AWS App Runner performs to monitor the health of your service. See Health Check Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderHealthCheckConfiguration
{
    /// <summary>Number of consecutive checks that must succeed before App Runner decides that the service is healthy. Defaults to 1. Minimum value of 1. Maximum value of 20.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time interval, in seconds, between health checks. Defaults to 5. Minimum value of 1. Maximum value of 20.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>URL to send requests to for health checks. Defaults to /. Minimum length of 0. Maximum length of 51200.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>IP protocol that App Runner uses to perform health checks for your service. Valid values: TCP, HTTP. Defaults to TCP. If you set protocol to HTTP, App Runner sends health check requests to the HTTP path specified by path.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Time, in seconds, to wait for a health check response before deciding it failed. Defaults to 2. Minimum value of  1. Maximum value of 20.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Number of consecutive checks that must fail before App Runner decides that the service is unhealthy. Defaults to 5. Minimum value of  1. Maximum value of 20.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>The runtime configuration of instances (scaling units) of the App Runner service. See Instance Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderInstanceConfiguration
{
    /// <summary>Number of CPU units reserved for each instance of your App Runner service represented as a String. Defaults to 1024. Valid values: 256|512|1024|2048|4096|(0.25|0.5|1|2|4) vCPU.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>ARN of an IAM role that provides permissions to your App Runner service. These are permissions that your code needs when it calls any AWS APIs.</summary>
    [JsonPropertyName("instanceRoleArn")]
    public string? InstanceRoleArn { get; set; }

    /// <summary>Amount of memory, in MB or GB, reserved for each instance of your App Runner service. Defaults to 2048. Valid values: 512|1024|2048|3072|4096|6144|8192|10240|12288|(0.5|1|2|3|4|6|8|10|12) GB.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Network configuration settings for outbound message traffic. See Egress Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderNetworkConfigurationEgressConfiguration
{
    /// <summary>The type of egress configuration. Valid values are: DEFAULT and VPC.</summary>
    [JsonPropertyName("egressType")]
    public string? EgressType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the App Runner VPC connector that you want to associate with your App Runner service. Only valid when EgressType = VPC.</summary>
    [JsonPropertyName("vpcConnectorArn")]
    public string? VpcConnectorArn { get; set; }
}

/// <summary>Network configuration settings for inbound network traffic. See Ingress Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderNetworkConfigurationIngressConfiguration
{
    /// <summary>Specifies whether your App Runner service is publicly accessible. To make the service publicly accessible set it to True. To make the service privately accessible, from only within an Amazon VPC set it to False.</summary>
    [JsonPropertyName("isPubliclyAccessible")]
    public bool? IsPubliclyAccessible { get; set; }
}

/// <summary>Configuration settings related to network traffic of the web application that the App Runner service runs. See Network Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderNetworkConfiguration
{
    /// <summary>Network configuration settings for outbound message traffic. See Egress Configuration below for more details.</summary>
    [JsonPropertyName("egressConfiguration")]
    public V1beta2ServiceStatusAtProviderNetworkConfigurationEgressConfiguration? EgressConfiguration { get; set; }

    /// <summary>Network configuration settings for inbound network traffic. See Ingress Configuration below for more details.</summary>
    [JsonPropertyName("ingressConfiguration")]
    public V1beta2ServiceStatusAtProviderNetworkConfigurationIngressConfiguration? IngressConfiguration { get; set; }

    /// <summary>App Runner provides you with the option to choose between Internet Protocol version 4 (IPv4) and dual stack (IPv4 and IPv6) for your incoming public network configuration. Valid values: IPV4, DUAL_STACK. Default: IPV4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }
}

/// <summary>The observability configuration of your service. See Observability Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderObservabilityConfiguration
{
    /// <summary>ARN of the observability configuration that is associated with the service. Specified only when observability_enabled is true.</summary>
    [JsonPropertyName("observabilityConfigurationArn")]
    public string? ObservabilityConfigurationArn { get; set; }

    /// <summary>When true, an observability configuration resource is associated with the service.</summary>
    [JsonPropertyName("observabilityEnabled")]
    public bool? ObservabilityEnabled { get; set; }
}

/// <summary>Describes resources needed to authenticate access to some source repositories. See Authentication Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderSourceConfigurationAuthenticationConfiguration
{
    /// <summary>ARN of the IAM role that grants the App Runner service access to a source repository. Required for ECR image repositories (but not for ECR Public)</summary>
    [JsonPropertyName("accessRoleArn")]
    public string? AccessRoleArn { get; set; }

    /// <summary>ARN of the App Runner connection that enables the App Runner service to connect to a source repository. Required for GitHub code repositories.</summary>
    [JsonPropertyName("connectionArn")]
    public string? ConnectionArn { get; set; }
}

/// <summary>Basic configuration for building and running the App Runner service. Use this parameter to quickly launch an App Runner service without providing an apprunner.yaml file in the source code repository (or ignoring the file if it exists). See Code Configuration Values below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues
{
    /// <summary>Command App Runner runs to build your application.</summary>
    [JsonPropertyName("buildCommand")]
    public string? BuildCommand { get; set; }

    /// <summary>Port that your application listens to in the container. Defaults to &quot;8080&quot;.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Runtime environment type for building and running an App Runner service. Represents a programming language runtime. Valid values: PYTHON_3, NODEJS_12, NODEJS_14, NODEJS_16, CORRETTO_8, CORRETTO_11, GO_1, DOTNET_6, PHP_81, RUBY_31.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>Secrets and parameters available to your service as environment variables. A map of key/value pairs, where the key is the desired name of the Secret in the environment (i.e. it does not have to match the name of the secret in Secrets Manager or SSM Parameter Store), and the value is the ARN of the secret from AWS Secrets Manager or the ARN of the parameter in AWS SSM Parameter Store.</summary>
    [JsonPropertyName("runtimeEnvironmentSecrets")]
    public IDictionary<string, string>? RuntimeEnvironmentSecrets { get; set; }

    /// <summary>Environment variables available to your running App Runner service. A map of key/value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren&apos;t valid.</summary>
    [JsonPropertyName("runtimeEnvironmentVariables")]
    public IDictionary<string, string>? RuntimeEnvironmentVariables { get; set; }

    /// <summary>Command App Runner runs to start the application in the source image. If specified, this command overrides the Docker image’s default start command.</summary>
    [JsonPropertyName("startCommand")]
    public string? StartCommand { get; set; }
}

/// <summary>Configuration for building and running the service from a source code repository. See Code Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderSourceConfigurationCodeRepositoryCodeConfiguration
{
    /// <summary>Basic configuration for building and running the App Runner service. Use this parameter to quickly launch an App Runner service without providing an apprunner.yaml file in the source code repository (or ignoring the file if it exists). See Code Configuration Values below for more details.</summary>
    [JsonPropertyName("codeConfigurationValues")]
    public V1beta2ServiceStatusAtProviderSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues? CodeConfigurationValues { get; set; }

    /// <summary>Source of the App Runner configuration. Valid values: REPOSITORY, API. Values are interpreted as follows:</summary>
    [JsonPropertyName("configurationSource")]
    public string? ConfigurationSource { get; set; }
}

/// <summary>Version that should be used within the source code repository. See Source Code Version below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderSourceConfigurationCodeRepositorySourceCodeVersion
{
    /// <summary>Type of version identifier. For a git-based repository, branches represent versions. Valid values: BRANCH.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Source code version. For a git-based repository, a branch name maps to a specific version. App Runner uses the most recent commit to the branch.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Description of a source code repository. See Code Repository below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderSourceConfigurationCodeRepository
{
    /// <summary>Configuration for building and running the service from a source code repository. See Code Configuration below for more details.</summary>
    [JsonPropertyName("codeConfiguration")]
    public V1beta2ServiceStatusAtProviderSourceConfigurationCodeRepositoryCodeConfiguration? CodeConfiguration { get; set; }

    /// <summary>Location of the repository that contains the source code.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }

    /// <summary>Version that should be used within the source code repository. See Source Code Version below for more details.</summary>
    [JsonPropertyName("sourceCodeVersion")]
    public V1beta2ServiceStatusAtProviderSourceConfigurationCodeRepositorySourceCodeVersion? SourceCodeVersion { get; set; }

    /// <summary>The path of the directory that stores source code and configuration files. The build and start commands also execute from here. The path is absolute from root and, if not specified, defaults to the repository root.</summary>
    [JsonPropertyName("sourceDirectory")]
    public string? SourceDirectory { get; set; }
}

/// <summary>Configuration for running the identified image. See Image Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderSourceConfigurationImageRepositoryImageConfiguration
{
    /// <summary>Port that your application listens to in the container. Defaults to &quot;8080&quot;.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Secrets and parameters available to your service as environment variables. A map of key/value pairs, where the key is the desired name of the Secret in the environment (i.e. it does not have to match the name of the secret in Secrets Manager or SSM Parameter Store), and the value is the ARN of the secret from AWS Secrets Manager or the ARN of the parameter in AWS SSM Parameter Store.</summary>
    [JsonPropertyName("runtimeEnvironmentSecrets")]
    public IDictionary<string, string>? RuntimeEnvironmentSecrets { get; set; }

    /// <summary>Environment variables available to your running App Runner service. A map of key/value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren&apos;t valid.</summary>
    [JsonPropertyName("runtimeEnvironmentVariables")]
    public IDictionary<string, string>? RuntimeEnvironmentVariables { get; set; }

    /// <summary>Command App Runner runs to start the application in the source image. If specified, this command overrides the Docker image’s default start command.</summary>
    [JsonPropertyName("startCommand")]
    public string? StartCommand { get; set; }
}

/// <summary>Description of a source image repository. See Image Repository below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderSourceConfigurationImageRepository
{
    /// <summary>Configuration for running the identified image. See Image Configuration below for more details.</summary>
    [JsonPropertyName("imageConfiguration")]
    public V1beta2ServiceStatusAtProviderSourceConfigurationImageRepositoryImageConfiguration? ImageConfiguration { get; set; }

    /// <summary>
    /// Identifier of an image. For an image in Amazon Elastic Container Registry (Amazon ECR), this is an image name. For the
    /// image name format, see Pulling an image in the Amazon ECR User Guide.
    /// </summary>
    [JsonPropertyName("imageIdentifier")]
    public string? ImageIdentifier { get; set; }

    /// <summary>Type of the image repository. This reflects the repository provider and whether the repository is private or public. Valid values: ECR , ECR_PUBLIC.</summary>
    [JsonPropertyName("imageRepositoryType")]
    public string? ImageRepositoryType { get; set; }
}

/// <summary>The source to deploy to the App Runner service. Can be a code or an image repository. See Source Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderSourceConfiguration
{
    /// <summary>Describes resources needed to authenticate access to some source repositories. See Authentication Configuration below for more details.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta2ServiceStatusAtProviderSourceConfigurationAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>Whether continuous integration from the source repository is enabled for the App Runner service. If set to true, each repository change (source code commit or new image version) starts a deployment. Defaults to true.</summary>
    [JsonPropertyName("autoDeploymentsEnabled")]
    public bool? AutoDeploymentsEnabled { get; set; }

    /// <summary>Description of a source code repository. See Code Repository below for more details.</summary>
    [JsonPropertyName("codeRepository")]
    public V1beta2ServiceStatusAtProviderSourceConfigurationCodeRepository? CodeRepository { get; set; }

    /// <summary>Description of a source image repository. See Image Repository below for more details.</summary>
    [JsonPropertyName("imageRepository")]
    public V1beta2ServiceStatusAtProviderSourceConfigurationImageRepository? ImageRepository { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProvider
{
    /// <summary>ARN of the App Runner service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN of an App Runner automatic scaling configuration resource that you want to associate with your service. If not provided, App Runner associates the latest revision of a default auto scaling configuration.</summary>
    [JsonPropertyName("autoScalingConfigurationArn")]
    public string? AutoScalingConfigurationArn { get; set; }

    /// <summary>(Forces new resource) An optional custom encryption key that App Runner uses to encrypt the copy of your source repository that it maintains and your service logs. By default, App Runner uses an AWS managed CMK. See Encryption Configuration below for more details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2ServiceStatusAtProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Settings of the health check that AWS App Runner performs to monitor the health of your service. See Health Check Configuration below for more details.</summary>
    [JsonPropertyName("healthCheckConfiguration")]
    public V1beta2ServiceStatusAtProviderHealthCheckConfiguration? HealthCheckConfiguration { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The runtime configuration of instances (scaling units) of the App Runner service. See Instance Configuration below for more details.</summary>
    [JsonPropertyName("instanceConfiguration")]
    public V1beta2ServiceStatusAtProviderInstanceConfiguration? InstanceConfiguration { get; set; }

    /// <summary>Configuration settings related to network traffic of the web application that the App Runner service runs. See Network Configuration below for more details.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta2ServiceStatusAtProviderNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>The observability configuration of your service. See Observability Configuration below for more details.</summary>
    [JsonPropertyName("observabilityConfiguration")]
    public V1beta2ServiceStatusAtProviderObservabilityConfiguration? ObservabilityConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>An alphanumeric ID that App Runner generated for this service. Unique within the AWS Region.</summary>
    [JsonPropertyName("serviceId")]
    public string? ServiceId { get; set; }

    /// <summary>(Forces new resource) Name of the service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Subdomain URL that App Runner generated for this service. You can use this URL to access your service web application.</summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>The source to deploy to the App Runner service. Can be a code or an image repository. See Source Configuration below for more details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta2ServiceStatusAtProviderSourceConfiguration? SourceConfiguration { get; set; }

    /// <summary>Current state of the App Runner service.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusConditions
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

/// <summary>ServiceStatus defines the observed state of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ServiceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Service is the Schema for the Services API. Manages an App Runner Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Service : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ServiceSpec>, IStatus<V1beta2ServiceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Service";
    public const string KubeGroup = "apprunner.aws.upbound.io";
    public const string KubePluralName = "services";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apprunner.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Service";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceSpec defines the desired state of Service</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ServiceSpec Spec { get; set; }

    /// <summary>ServiceStatus defines the observed state of Service.</summary>
    [JsonPropertyName("status")]
    public V1beta2ServiceStatus? Status { get; set; }
}