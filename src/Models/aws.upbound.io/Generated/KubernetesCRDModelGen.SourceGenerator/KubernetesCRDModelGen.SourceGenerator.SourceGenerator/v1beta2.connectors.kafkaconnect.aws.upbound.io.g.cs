#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kafkaconnect.aws.upbound.io;
/// <summary>Connector is the Schema for the Connectors API. Provides an Amazon MSK Connect Connector resource. Changes to any parameter besides &quot;scaling&quot; will be rejected. Instead you must create a new resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ConnectorList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Connector>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ConnectorList";
    public const string KubeGroup = "kafkaconnect.aws.upbound.io";
    public const string KubePluralName = "connectors";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafkaconnect.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConnectorList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Connector objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Connector> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecDeletionPolicyEnum>))]
public enum V1beta2ConnectorSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>The scale-in policy for the connector. See scale_in_policy Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderCapacityAutoscalingScaleInPolicy
{
    /// <summary>Specifies the CPU utilization percentage threshold at which you want connector scale in to be triggered.</summary>
    [JsonPropertyName("cpuUtilizationPercentage")]
    public double? CpuUtilizationPercentage { get; set; }
}

/// <summary>The scale-out policy for the connector. See scale_out_policy Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderCapacityAutoscalingScaleOutPolicy
{
    /// <summary>The CPU utilization percentage threshold at which you want connector scale out to be triggered.</summary>
    [JsonPropertyName("cpuUtilizationPercentage")]
    public double? CpuUtilizationPercentage { get; set; }
}

/// <summary>Information about the auto scaling parameters for the connector. See autoscaling Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderCapacityAutoscaling
{
    /// <summary>The maximum number of workers allocated to the connector.</summary>
    [JsonPropertyName("maxWorkerCount")]
    public double? MaxWorkerCount { get; set; }

    /// <summary>The number of microcontroller units (MCUs) allocated to each connector worker. Valid values: 1, 2, 4, 8. The default value is 1.</summary>
    [JsonPropertyName("mcuCount")]
    public double? McuCount { get; set; }

    /// <summary>The minimum number of workers allocated to the connector.</summary>
    [JsonPropertyName("minWorkerCount")]
    public double? MinWorkerCount { get; set; }

    /// <summary>The scale-in policy for the connector. See scale_in_policy Block for details.</summary>
    [JsonPropertyName("scaleInPolicy")]
    public V1beta2ConnectorSpecForProviderCapacityAutoscalingScaleInPolicy? ScaleInPolicy { get; set; }

    /// <summary>The scale-out policy for the connector. See scale_out_policy Block for details.</summary>
    [JsonPropertyName("scaleOutPolicy")]
    public V1beta2ConnectorSpecForProviderCapacityAutoscalingScaleOutPolicy? ScaleOutPolicy { get; set; }
}

/// <summary>Details about a fixed capacity allocated to a connector. See provisioned_capacity Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderCapacityProvisionedCapacity
{
    /// <summary>The number of microcontroller units (MCUs) allocated to each connector worker. Valid values: 1, 2, 4, 8. The default value is 1.</summary>
    [JsonPropertyName("mcuCount")]
    public double? McuCount { get; set; }

    /// <summary>The number of workers that are allocated to the connector.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary>Information about the capacity allocated to the connector. See capacity Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderCapacity
{
    /// <summary>Information about the auto scaling parameters for the connector. See autoscaling Block for details.</summary>
    [JsonPropertyName("autoscaling")]
    public V1beta2ConnectorSpecForProviderCapacityAutoscaling? Autoscaling { get; set; }

    /// <summary>Details about a fixed capacity allocated to a connector. See provisioned_capacity Block for details.</summary>
    [JsonPropertyName("provisionedCapacity")]
    public V1beta2ConnectorSpecForProviderCapacityProvisionedCapacity? ProvisionedCapacity { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelector
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
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelector
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
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster. See vpc Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpc
{
    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>The security groups for the connector.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetSelector")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpcSubnetSelector? SubnetSelector { get; set; }

    /// <summary>The subnets for the connector.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>The Apache Kafka cluster to which the connector is connected. See apache_kafka_cluster Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaCluster
{
    /// <summary>The bootstrap servers of the cluster.</summary>
    [JsonPropertyName("bootstrapServers")]
    public string? BootstrapServers { get; set; }

    /// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster. See vpc Block for details.</summary>
    [JsonPropertyName("vpc")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaClusterVpc? Vpc { get; set; }
}

/// <summary>Specifies which Apache Kafka cluster to connect to. See kafka_cluster Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaCluster
{
    /// <summary>The Apache Kafka cluster to which the connector is connected. See apache_kafka_cluster Block for details.</summary>
    [JsonPropertyName("apacheKafkaCluster")]
    public V1beta2ConnectorSpecForProviderKafkaClusterApacheKafkaCluster? ApacheKafkaCluster { get; set; }
}

/// <summary>Details of the client authentication used by the Apache Kafka cluster. See kafka_cluster_client_authentication Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaClusterClientAuthentication
{
    /// <summary>The type of client authentication used to connect to the Apache Kafka cluster. Valid values: IAM, NONE. A value of NONE means that no client authentication is used. The default value is NONE.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }
}

/// <summary>Details of encryption in transit to the Apache Kafka cluster. See kafka_cluster_encryption_in_transit Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderKafkaClusterEncryptionInTransit
{
    /// <summary>The type of encryption in transit to the Apache Kafka cluster. Valid values: PLAINTEXT, TLS. The default values is PLAINTEXT.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelector
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
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about delivering logs to Amazon CloudWatch Logs. See cloudwatch_logs Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogs
{
    /// <summary>Whether log delivery to Amazon CloudWatch Logs is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the CloudWatch log group that is the destination for log delivery.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupRef")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRef? LogGroupRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupSelector")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelector? LogGroupSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelector
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
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about delivering logs to Amazon Kinesis Data Firehose. See firehose Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehose
{
    /// <summary>The name of the Kinesis Data Firehose delivery stream that is the destination for log delivery.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamRef")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRef? DeliveryStreamRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamSelector")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelector? DeliveryStreamSelector { get; set; }

    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelector
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
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about delivering logs to Amazon S3. See s3 Block for deetails.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3
{
    /// <summary>The name of the S3 bucket that is the destination for log delivery.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3BucketSelector? BucketSelector { get; set; }

    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The S3 prefix that is the destination for log delivery.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>The workers can send worker logs to different destination types. This configuration specifies the details of these destinations. See worker_log_delivery Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDelivery
{
    /// <summary>Details about delivering logs to Amazon CloudWatch Logs. See cloudwatch_logs Block for details.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary>Details about delivering logs to Amazon Kinesis Data Firehose. See firehose Block for details.</summary>
    [JsonPropertyName("firehose")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryFirehose? Firehose { get; set; }

    /// <summary>Details about delivering logs to Amazon S3. See s3 Block for deetails.</summary>
    [JsonPropertyName("s3")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDeliveryS3? S3 { get; set; }
}

/// <summary>Details about log delivery. See log_delivery Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderLogDelivery
{
    /// <summary>The workers can send worker logs to different destination types. This configuration specifies the details of these destinations. See worker_log_delivery Block for details.</summary>
    [JsonPropertyName("workerLogDelivery")]
    public V1beta2ConnectorSpecForProviderLogDeliveryWorkerLogDelivery? WorkerLogDelivery { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderPluginCustomPluginArnRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderPluginCustomPluginArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderPluginCustomPluginArnRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderPluginCustomPluginArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderPluginCustomPluginArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderPluginCustomPluginArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderPluginCustomPluginArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CustomPlugin in kafkaconnect to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderPluginCustomPluginArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecForProviderPluginCustomPluginArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CustomPlugin in kafkaconnect to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderPluginCustomPluginArnSelector
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
    public V1beta2ConnectorSpecForProviderPluginCustomPluginArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about a custom plugin. See custom_plugin Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderPluginCustomPlugin
{
    /// <summary>The Amazon Resource Name (ARN) of the custom plugin.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a CustomPlugin in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2ConnectorSpecForProviderPluginCustomPluginArnRef? ArnRef { get; set; }

    /// <summary>Selector for a CustomPlugin in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2ConnectorSpecForProviderPluginCustomPluginArnSelector? ArnSelector { get; set; }

    /// <summary>The revision of the custom plugin.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderPlugin
{
    /// <summary>Details about a custom plugin. See custom_plugin Block for details.</summary>
    [JsonPropertyName("customPlugin")]
    public V1beta2ConnectorSpecForProviderPluginCustomPlugin? CustomPlugin { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderServiceExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderServiceExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderServiceExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderServiceExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderServiceExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderServiceExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderServiceExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderServiceExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecForProviderServiceExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderServiceExecutionRoleArnSelector
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
    public V1beta2ConnectorSpecForProviderServiceExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderWorkerConfigurationArnRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderWorkerConfigurationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderWorkerConfigurationArnRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderWorkerConfigurationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderWorkerConfigurationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderWorkerConfigurationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderWorkerConfigurationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a WorkerConfiguration in kafkaconnect to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderWorkerConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecForProviderWorkerConfigurationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a WorkerConfiguration in kafkaconnect to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderWorkerConfigurationArnSelector
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
    public V1beta2ConnectorSpecForProviderWorkerConfigurationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies which worker configuration to use with the connector. See worker_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProviderWorkerConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the worker configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a WorkerConfiguration in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2ConnectorSpecForProviderWorkerConfigurationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a WorkerConfiguration in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2ConnectorSpecForProviderWorkerConfigurationArnSelector? ArnSelector { get; set; }

    /// <summary>The revision of the worker configuration.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecForProvider
{
    /// <summary>Information about the capacity allocated to the connector. See capacity Block for details.</summary>
    [JsonPropertyName("capacity")]
    public V1beta2ConnectorSpecForProviderCapacity? Capacity { get; set; }

    /// <summary>A map of keys to values that represent the configuration for the connector.</summary>
    [JsonPropertyName("connectorConfiguration")]
    public IDictionary<string, string>? ConnectorConfiguration { get; set; }

    /// <summary>A summary description of the connector.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies which Apache Kafka cluster to connect to. See kafka_cluster Block for details.</summary>
    [JsonPropertyName("kafkaCluster")]
    public V1beta2ConnectorSpecForProviderKafkaCluster? KafkaCluster { get; set; }

    /// <summary>Details of the client authentication used by the Apache Kafka cluster. See kafka_cluster_client_authentication Block for details.</summary>
    [JsonPropertyName("kafkaClusterClientAuthentication")]
    public V1beta2ConnectorSpecForProviderKafkaClusterClientAuthentication? KafkaClusterClientAuthentication { get; set; }

    /// <summary>Details of encryption in transit to the Apache Kafka cluster. See kafka_cluster_encryption_in_transit Block for details.</summary>
    [JsonPropertyName("kafkaClusterEncryptionInTransit")]
    public V1beta2ConnectorSpecForProviderKafkaClusterEncryptionInTransit? KafkaClusterEncryptionInTransit { get; set; }

    /// <summary>The version of Kafka Connect. It has to be compatible with both the Apache Kafka cluster&apos;s version and the plugins.</summary>
    [JsonPropertyName("kafkaconnectVersion")]
    public string? KafkaconnectVersion { get; set; }

    /// <summary>Details about log delivery. See log_delivery Block for details.</summary>
    [JsonPropertyName("logDelivery")]
    public V1beta2ConnectorSpecForProviderLogDelivery? LogDelivery { get; set; }

    /// <summary>The name of the connector.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Specifies which plugins to use for the connector. See plugin Block for details.</summary>
    [JsonPropertyName("plugin")]
    public IList<V1beta2ConnectorSpecForProviderPlugin>? Plugin { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role used by the connector to access the Amazon Web Services resources that it needs. The types of resources depends on the logic of the connector. For example, a connector that has Amazon S3 as a destination must have permissions that allow it to write to the S3 destination bucket.</summary>
    [JsonPropertyName("serviceExecutionRoleArn")]
    public string? ServiceExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnRef")]
    public V1beta2ConnectorSpecForProviderServiceExecutionRoleArnRef? ServiceExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnSelector")]
    public V1beta2ConnectorSpecForProviderServiceExecutionRoleArnSelector? ServiceExecutionRoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies which worker configuration to use with the connector. See worker_configuration Block for details.</summary>
    [JsonPropertyName("workerConfiguration")]
    public V1beta2ConnectorSpecForProviderWorkerConfiguration? WorkerConfiguration { get; set; }
}

/// <summary>The scale-in policy for the connector. See scale_in_policy Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderCapacityAutoscalingScaleInPolicy
{
    /// <summary>Specifies the CPU utilization percentage threshold at which you want connector scale in to be triggered.</summary>
    [JsonPropertyName("cpuUtilizationPercentage")]
    public double? CpuUtilizationPercentage { get; set; }
}

/// <summary>The scale-out policy for the connector. See scale_out_policy Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderCapacityAutoscalingScaleOutPolicy
{
    /// <summary>The CPU utilization percentage threshold at which you want connector scale out to be triggered.</summary>
    [JsonPropertyName("cpuUtilizationPercentage")]
    public double? CpuUtilizationPercentage { get; set; }
}

/// <summary>Information about the auto scaling parameters for the connector. See autoscaling Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderCapacityAutoscaling
{
    /// <summary>The maximum number of workers allocated to the connector.</summary>
    [JsonPropertyName("maxWorkerCount")]
    public double? MaxWorkerCount { get; set; }

    /// <summary>The number of microcontroller units (MCUs) allocated to each connector worker. Valid values: 1, 2, 4, 8. The default value is 1.</summary>
    [JsonPropertyName("mcuCount")]
    public double? McuCount { get; set; }

    /// <summary>The minimum number of workers allocated to the connector.</summary>
    [JsonPropertyName("minWorkerCount")]
    public double? MinWorkerCount { get; set; }

    /// <summary>The scale-in policy for the connector. See scale_in_policy Block for details.</summary>
    [JsonPropertyName("scaleInPolicy")]
    public V1beta2ConnectorSpecInitProviderCapacityAutoscalingScaleInPolicy? ScaleInPolicy { get; set; }

    /// <summary>The scale-out policy for the connector. See scale_out_policy Block for details.</summary>
    [JsonPropertyName("scaleOutPolicy")]
    public V1beta2ConnectorSpecInitProviderCapacityAutoscalingScaleOutPolicy? ScaleOutPolicy { get; set; }
}

/// <summary>Details about a fixed capacity allocated to a connector. See provisioned_capacity Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderCapacityProvisionedCapacity
{
    /// <summary>The number of microcontroller units (MCUs) allocated to each connector worker. Valid values: 1, 2, 4, 8. The default value is 1.</summary>
    [JsonPropertyName("mcuCount")]
    public double? McuCount { get; set; }

    /// <summary>The number of workers that are allocated to the connector.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary>Information about the capacity allocated to the connector. See capacity Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderCapacity
{
    /// <summary>Information about the auto scaling parameters for the connector. See autoscaling Block for details.</summary>
    [JsonPropertyName("autoscaling")]
    public V1beta2ConnectorSpecInitProviderCapacityAutoscaling? Autoscaling { get; set; }

    /// <summary>Details about a fixed capacity allocated to a connector. See provisioned_capacity Block for details.</summary>
    [JsonPropertyName("provisionedCapacity")]
    public V1beta2ConnectorSpecInitProviderCapacityProvisionedCapacity? ProvisionedCapacity { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelector
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
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelector
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
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelectorPolicy? Policy { get; set; }
}

/// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster. See vpc Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpc
{
    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>The security groups for the connector.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetSelector")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpcSubnetSelector? SubnetSelector { get; set; }

    /// <summary>The subnets for the connector.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>The Apache Kafka cluster to which the connector is connected. See apache_kafka_cluster Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaCluster
{
    /// <summary>The bootstrap servers of the cluster.</summary>
    [JsonPropertyName("bootstrapServers")]
    public string? BootstrapServers { get; set; }

    /// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster. See vpc Block for details.</summary>
    [JsonPropertyName("vpc")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaClusterVpc? Vpc { get; set; }
}

/// <summary>Specifies which Apache Kafka cluster to connect to. See kafka_cluster Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaCluster
{
    /// <summary>The Apache Kafka cluster to which the connector is connected. See apache_kafka_cluster Block for details.</summary>
    [JsonPropertyName("apacheKafkaCluster")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterApacheKafkaCluster? ApacheKafkaCluster { get; set; }
}

/// <summary>Details of the client authentication used by the Apache Kafka cluster. See kafka_cluster_client_authentication Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaClusterClientAuthentication
{
    /// <summary>The type of client authentication used to connect to the Apache Kafka cluster. Valid values: IAM, NONE. A value of NONE means that no client authentication is used. The default value is NONE.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }
}

/// <summary>Details of encryption in transit to the Apache Kafka cluster. See kafka_cluster_encryption_in_transit Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderKafkaClusterEncryptionInTransit
{
    /// <summary>The type of encryption in transit to the Apache Kafka cluster. Valid values: PLAINTEXT, TLS. The default values is PLAINTEXT.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelector
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
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about delivering logs to Amazon CloudWatch Logs. See cloudwatch_logs Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogs
{
    /// <summary>Whether log delivery to Amazon CloudWatch Logs is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the CloudWatch log group that is the destination for log delivery.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupRef")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupRef? LogGroupRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupSelector")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogsLogGroupSelector? LogGroupSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelector
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
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about delivering logs to Amazon Kinesis Data Firehose. See firehose Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehose
{
    /// <summary>The name of the Kinesis Data Firehose delivery stream that is the destination for log delivery.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamRef")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamRef? DeliveryStreamRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamSelector")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehoseDeliveryStreamSelector? DeliveryStreamSelector { get; set; }

    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelector
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
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about delivering logs to Amazon S3. See s3 Block for deetails.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3
{
    /// <summary>The name of the S3 bucket that is the destination for log delivery.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3BucketSelector? BucketSelector { get; set; }

    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The S3 prefix that is the destination for log delivery.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>The workers can send worker logs to different destination types. This configuration specifies the details of these destinations. See worker_log_delivery Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDelivery
{
    /// <summary>Details about delivering logs to Amazon CloudWatch Logs. See cloudwatch_logs Block for details.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary>Details about delivering logs to Amazon Kinesis Data Firehose. See firehose Block for details.</summary>
    [JsonPropertyName("firehose")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryFirehose? Firehose { get; set; }

    /// <summary>Details about delivering logs to Amazon S3. See s3 Block for deetails.</summary>
    [JsonPropertyName("s3")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDeliveryS3? S3 { get; set; }
}

/// <summary>Details about log delivery. See log_delivery Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderLogDelivery
{
    /// <summary>The workers can send worker logs to different destination types. This configuration specifies the details of these destinations. See worker_log_delivery Block for details.</summary>
    [JsonPropertyName("workerLogDelivery")]
    public V1beta2ConnectorSpecInitProviderLogDeliveryWorkerLogDelivery? WorkerLogDelivery { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderPluginCustomPluginArnRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderPluginCustomPluginArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderPluginCustomPluginArnRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderPluginCustomPluginArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderPluginCustomPluginArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderPluginCustomPluginArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderPluginCustomPluginArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CustomPlugin in kafkaconnect to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderPluginCustomPluginArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecInitProviderPluginCustomPluginArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CustomPlugin in kafkaconnect to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderPluginCustomPluginArnSelector
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
    public V1beta2ConnectorSpecInitProviderPluginCustomPluginArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about a custom plugin. See custom_plugin Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderPluginCustomPlugin
{
    /// <summary>The Amazon Resource Name (ARN) of the custom plugin.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a CustomPlugin in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2ConnectorSpecInitProviderPluginCustomPluginArnRef? ArnRef { get; set; }

    /// <summary>Selector for a CustomPlugin in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2ConnectorSpecInitProviderPluginCustomPluginArnSelector? ArnSelector { get; set; }

    /// <summary>The revision of the custom plugin.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderPlugin
{
    /// <summary>Details about a custom plugin. See custom_plugin Block for details.</summary>
    [JsonPropertyName("customPlugin")]
    public V1beta2ConnectorSpecInitProviderPluginCustomPlugin? CustomPlugin { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnSelector
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
    public V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderWorkerConfigurationArnRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderWorkerConfigurationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderWorkerConfigurationArnRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderWorkerConfigurationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderWorkerConfigurationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderWorkerConfigurationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderWorkerConfigurationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a WorkerConfiguration in kafkaconnect to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderWorkerConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecInitProviderWorkerConfigurationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a WorkerConfiguration in kafkaconnect to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderWorkerConfigurationArnSelector
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
    public V1beta2ConnectorSpecInitProviderWorkerConfigurationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies which worker configuration to use with the connector. See worker_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecInitProviderWorkerConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the worker configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a WorkerConfiguration in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2ConnectorSpecInitProviderWorkerConfigurationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a WorkerConfiguration in kafkaconnect to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2ConnectorSpecInitProviderWorkerConfigurationArnSelector? ArnSelector { get; set; }

    /// <summary>The revision of the worker configuration.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
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
public partial class V1beta2ConnectorSpecInitProvider
{
    /// <summary>Information about the capacity allocated to the connector. See capacity Block for details.</summary>
    [JsonPropertyName("capacity")]
    public V1beta2ConnectorSpecInitProviderCapacity? Capacity { get; set; }

    /// <summary>A map of keys to values that represent the configuration for the connector.</summary>
    [JsonPropertyName("connectorConfiguration")]
    public IDictionary<string, string>? ConnectorConfiguration { get; set; }

    /// <summary>A summary description of the connector.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies which Apache Kafka cluster to connect to. See kafka_cluster Block for details.</summary>
    [JsonPropertyName("kafkaCluster")]
    public V1beta2ConnectorSpecInitProviderKafkaCluster? KafkaCluster { get; set; }

    /// <summary>Details of the client authentication used by the Apache Kafka cluster. See kafka_cluster_client_authentication Block for details.</summary>
    [JsonPropertyName("kafkaClusterClientAuthentication")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterClientAuthentication? KafkaClusterClientAuthentication { get; set; }

    /// <summary>Details of encryption in transit to the Apache Kafka cluster. See kafka_cluster_encryption_in_transit Block for details.</summary>
    [JsonPropertyName("kafkaClusterEncryptionInTransit")]
    public V1beta2ConnectorSpecInitProviderKafkaClusterEncryptionInTransit? KafkaClusterEncryptionInTransit { get; set; }

    /// <summary>The version of Kafka Connect. It has to be compatible with both the Apache Kafka cluster&apos;s version and the plugins.</summary>
    [JsonPropertyName("kafkaconnectVersion")]
    public string? KafkaconnectVersion { get; set; }

    /// <summary>Details about log delivery. See log_delivery Block for details.</summary>
    [JsonPropertyName("logDelivery")]
    public V1beta2ConnectorSpecInitProviderLogDelivery? LogDelivery { get; set; }

    /// <summary>Specifies which plugins to use for the connector. See plugin Block for details.</summary>
    [JsonPropertyName("plugin")]
    public IList<V1beta2ConnectorSpecInitProviderPlugin>? Plugin { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role used by the connector to access the Amazon Web Services resources that it needs. The types of resources depends on the logic of the connector. For example, a connector that has Amazon S3 as a destination must have permissions that allow it to write to the S3 destination bucket.</summary>
    [JsonPropertyName("serviceExecutionRoleArn")]
    public string? ServiceExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnRef")]
    public V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnRef? ServiceExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceExecutionRoleArn.</summary>
    [JsonPropertyName("serviceExecutionRoleArnSelector")]
    public V1beta2ConnectorSpecInitProviderServiceExecutionRoleArnSelector? ServiceExecutionRoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies which worker configuration to use with the connector. See worker_configuration Block for details.</summary>
    [JsonPropertyName("workerConfiguration")]
    public V1beta2ConnectorSpecInitProviderWorkerConfiguration? WorkerConfiguration { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecManagementPoliciesEnum>))]
public enum V1beta2ConnectorSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ConnectorSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectorSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ConnectorSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectorSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectorSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectorSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ConnectorSpec defines the desired state of Connector</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorSpec
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
    public V1beta2ConnectorSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ConnectorSpecForProvider ForProvider { get; set; }

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
    public V1beta2ConnectorSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ConnectorSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ConnectorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ConnectorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The scale-in policy for the connector. See scale_in_policy Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderCapacityAutoscalingScaleInPolicy
{
    /// <summary>Specifies the CPU utilization percentage threshold at which you want connector scale in to be triggered.</summary>
    [JsonPropertyName("cpuUtilizationPercentage")]
    public double? CpuUtilizationPercentage { get; set; }
}

/// <summary>The scale-out policy for the connector. See scale_out_policy Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderCapacityAutoscalingScaleOutPolicy
{
    /// <summary>The CPU utilization percentage threshold at which you want connector scale out to be triggered.</summary>
    [JsonPropertyName("cpuUtilizationPercentage")]
    public double? CpuUtilizationPercentage { get; set; }
}

/// <summary>Information about the auto scaling parameters for the connector. See autoscaling Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderCapacityAutoscaling
{
    /// <summary>The maximum number of workers allocated to the connector.</summary>
    [JsonPropertyName("maxWorkerCount")]
    public double? MaxWorkerCount { get; set; }

    /// <summary>The number of microcontroller units (MCUs) allocated to each connector worker. Valid values: 1, 2, 4, 8. The default value is 1.</summary>
    [JsonPropertyName("mcuCount")]
    public double? McuCount { get; set; }

    /// <summary>The minimum number of workers allocated to the connector.</summary>
    [JsonPropertyName("minWorkerCount")]
    public double? MinWorkerCount { get; set; }

    /// <summary>The scale-in policy for the connector. See scale_in_policy Block for details.</summary>
    [JsonPropertyName("scaleInPolicy")]
    public V1beta2ConnectorStatusAtProviderCapacityAutoscalingScaleInPolicy? ScaleInPolicy { get; set; }

    /// <summary>The scale-out policy for the connector. See scale_out_policy Block for details.</summary>
    [JsonPropertyName("scaleOutPolicy")]
    public V1beta2ConnectorStatusAtProviderCapacityAutoscalingScaleOutPolicy? ScaleOutPolicy { get; set; }
}

/// <summary>Details about a fixed capacity allocated to a connector. See provisioned_capacity Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderCapacityProvisionedCapacity
{
    /// <summary>The number of microcontroller units (MCUs) allocated to each connector worker. Valid values: 1, 2, 4, 8. The default value is 1.</summary>
    [JsonPropertyName("mcuCount")]
    public double? McuCount { get; set; }

    /// <summary>The number of workers that are allocated to the connector.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary>Information about the capacity allocated to the connector. See capacity Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderCapacity
{
    /// <summary>Information about the auto scaling parameters for the connector. See autoscaling Block for details.</summary>
    [JsonPropertyName("autoscaling")]
    public V1beta2ConnectorStatusAtProviderCapacityAutoscaling? Autoscaling { get; set; }

    /// <summary>Details about a fixed capacity allocated to a connector. See provisioned_capacity Block for details.</summary>
    [JsonPropertyName("provisionedCapacity")]
    public V1beta2ConnectorStatusAtProviderCapacityProvisionedCapacity? ProvisionedCapacity { get; set; }
}

/// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster. See vpc Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderKafkaClusterApacheKafkaClusterVpc
{
    /// <summary>The security groups for the connector.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The subnets for the connector.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>The Apache Kafka cluster to which the connector is connected. See apache_kafka_cluster Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderKafkaClusterApacheKafkaCluster
{
    /// <summary>The bootstrap servers of the cluster.</summary>
    [JsonPropertyName("bootstrapServers")]
    public string? BootstrapServers { get; set; }

    /// <summary>Details of an Amazon VPC which has network connectivity to the Apache Kafka cluster. See vpc Block for details.</summary>
    [JsonPropertyName("vpc")]
    public V1beta2ConnectorStatusAtProviderKafkaClusterApacheKafkaClusterVpc? Vpc { get; set; }
}

/// <summary>Specifies which Apache Kafka cluster to connect to. See kafka_cluster Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderKafkaCluster
{
    /// <summary>The Apache Kafka cluster to which the connector is connected. See apache_kafka_cluster Block for details.</summary>
    [JsonPropertyName("apacheKafkaCluster")]
    public V1beta2ConnectorStatusAtProviderKafkaClusterApacheKafkaCluster? ApacheKafkaCluster { get; set; }
}

/// <summary>Details of the client authentication used by the Apache Kafka cluster. See kafka_cluster_client_authentication Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderKafkaClusterClientAuthentication
{
    /// <summary>The type of client authentication used to connect to the Apache Kafka cluster. Valid values: IAM, NONE. A value of NONE means that no client authentication is used. The default value is NONE.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }
}

/// <summary>Details of encryption in transit to the Apache Kafka cluster. See kafka_cluster_encryption_in_transit Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderKafkaClusterEncryptionInTransit
{
    /// <summary>The type of encryption in transit to the Apache Kafka cluster. Valid values: PLAINTEXT, TLS. The default values is PLAINTEXT.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }
}

/// <summary>Details about delivering logs to Amazon CloudWatch Logs. See cloudwatch_logs Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderLogDeliveryWorkerLogDeliveryCloudwatchLogs
{
    /// <summary>Whether log delivery to Amazon CloudWatch Logs is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the CloudWatch log group that is the destination for log delivery.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

/// <summary>Details about delivering logs to Amazon Kinesis Data Firehose. See firehose Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderLogDeliveryWorkerLogDeliveryFirehose
{
    /// <summary>The name of the Kinesis Data Firehose delivery stream that is the destination for log delivery.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Details about delivering logs to Amazon S3. See s3 Block for deetails.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderLogDeliveryWorkerLogDeliveryS3
{
    /// <summary>The name of the S3 bucket that is the destination for log delivery.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Specifies whether connector logs get sent to the specified Amazon S3 destination.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The S3 prefix that is the destination for log delivery.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>The workers can send worker logs to different destination types. This configuration specifies the details of these destinations. See worker_log_delivery Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderLogDeliveryWorkerLogDelivery
{
    /// <summary>Details about delivering logs to Amazon CloudWatch Logs. See cloudwatch_logs Block for details.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta2ConnectorStatusAtProviderLogDeliveryWorkerLogDeliveryCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary>Details about delivering logs to Amazon Kinesis Data Firehose. See firehose Block for details.</summary>
    [JsonPropertyName("firehose")]
    public V1beta2ConnectorStatusAtProviderLogDeliveryWorkerLogDeliveryFirehose? Firehose { get; set; }

    /// <summary>Details about delivering logs to Amazon S3. See s3 Block for deetails.</summary>
    [JsonPropertyName("s3")]
    public V1beta2ConnectorStatusAtProviderLogDeliveryWorkerLogDeliveryS3? S3 { get; set; }
}

/// <summary>Details about log delivery. See log_delivery Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderLogDelivery
{
    /// <summary>The workers can send worker logs to different destination types. This configuration specifies the details of these destinations. See worker_log_delivery Block for details.</summary>
    [JsonPropertyName("workerLogDelivery")]
    public V1beta2ConnectorStatusAtProviderLogDeliveryWorkerLogDelivery? WorkerLogDelivery { get; set; }
}

/// <summary>Details about a custom plugin. See custom_plugin Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderPluginCustomPlugin
{
    /// <summary>The Amazon Resource Name (ARN) of the custom plugin.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The revision of the custom plugin.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderPlugin
{
    /// <summary>Details about a custom plugin. See custom_plugin Block for details.</summary>
    [JsonPropertyName("customPlugin")]
    public V1beta2ConnectorStatusAtProviderPluginCustomPlugin? CustomPlugin { get; set; }
}

/// <summary>Specifies which worker configuration to use with the connector. See worker_configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProviderWorkerConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the worker configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The revision of the worker configuration.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the connector.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Information about the capacity allocated to the connector. See capacity Block for details.</summary>
    [JsonPropertyName("capacity")]
    public V1beta2ConnectorStatusAtProviderCapacity? Capacity { get; set; }

    /// <summary>A map of keys to values that represent the configuration for the connector.</summary>
    [JsonPropertyName("connectorConfiguration")]
    public IDictionary<string, string>? ConnectorConfiguration { get; set; }

    /// <summary>A summary description of the connector.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies which Apache Kafka cluster to connect to. See kafka_cluster Block for details.</summary>
    [JsonPropertyName("kafkaCluster")]
    public V1beta2ConnectorStatusAtProviderKafkaCluster? KafkaCluster { get; set; }

    /// <summary>Details of the client authentication used by the Apache Kafka cluster. See kafka_cluster_client_authentication Block for details.</summary>
    [JsonPropertyName("kafkaClusterClientAuthentication")]
    public V1beta2ConnectorStatusAtProviderKafkaClusterClientAuthentication? KafkaClusterClientAuthentication { get; set; }

    /// <summary>Details of encryption in transit to the Apache Kafka cluster. See kafka_cluster_encryption_in_transit Block for details.</summary>
    [JsonPropertyName("kafkaClusterEncryptionInTransit")]
    public V1beta2ConnectorStatusAtProviderKafkaClusterEncryptionInTransit? KafkaClusterEncryptionInTransit { get; set; }

    /// <summary>The version of Kafka Connect. It has to be compatible with both the Apache Kafka cluster&apos;s version and the plugins.</summary>
    [JsonPropertyName("kafkaconnectVersion")]
    public string? KafkaconnectVersion { get; set; }

    /// <summary>Details about log delivery. See log_delivery Block for details.</summary>
    [JsonPropertyName("logDelivery")]
    public V1beta2ConnectorStatusAtProviderLogDelivery? LogDelivery { get; set; }

    /// <summary>The name of the connector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which plugins to use for the connector. See plugin Block for details.</summary>
    [JsonPropertyName("plugin")]
    public IList<V1beta2ConnectorStatusAtProviderPlugin>? Plugin { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role used by the connector to access the Amazon Web Services resources that it needs. The types of resources depends on the logic of the connector. For example, a connector that has Amazon S3 as a destination must have permissions that allow it to write to the S3 destination bucket.</summary>
    [JsonPropertyName("serviceExecutionRoleArn")]
    public string? ServiceExecutionRoleArn { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The current version of the connector.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Specifies which worker configuration to use with the connector. See worker_configuration Block for details.</summary>
    [JsonPropertyName("workerConfiguration")]
    public V1beta2ConnectorStatusAtProviderWorkerConfiguration? WorkerConfiguration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatusConditions
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

/// <summary>ConnectorStatus defines the observed state of Connector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectorStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ConnectorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ConnectorStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Connector is the Schema for the Connectors API. Provides an Amazon MSK Connect Connector resource. Changes to any parameter besides &quot;scaling&quot; will be rejected. Instead you must create a new resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Connector : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ConnectorSpec>, IStatus<V1beta2ConnectorStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Connector";
    public const string KubeGroup = "kafkaconnect.aws.upbound.io";
    public const string KubePluralName = "connectors";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafkaconnect.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Connector";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConnectorSpec defines the desired state of Connector</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ConnectorSpec Spec { get; set; }

    /// <summary>ConnectorStatus defines the observed state of Connector.</summary>
    [JsonPropertyName("status")]
    public V1beta2ConnectorStatus? Status { get; set; }
}