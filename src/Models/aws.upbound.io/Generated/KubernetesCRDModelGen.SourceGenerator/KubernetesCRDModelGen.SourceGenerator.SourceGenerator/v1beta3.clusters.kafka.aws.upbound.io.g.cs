#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kafka.aws.upbound.io;
/// <summary>Cluster is the Schema for the Clusters API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta3ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta3Cluster>
{
    public const string KubeApiVersion = "v1beta3";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "kafka.aws.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.aws.upbound.io/v1beta3";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta3Cluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta3Cluster> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecDeletionPolicyEnum>))]
public enum V1beta3ClusterSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate clientSubnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelector
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
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicy? Policy { get; set; }
}

/// <summary>Access control settings for brokers. See connectivity_info public_access Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess
{
    /// <summary>Public access type. Valid values: DISABLED, SERVICE_PROVIDED_EIPS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SASL authentication type details for VPC connectivity. See vpc_connectivity client_authentication sasl Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary>Configuration block for specifying a client authentication. See client_authentication Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See vpc_connectivity client_authentication sasl Argument Reference below.</summary>
    [JsonPropertyName("sasl")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }
}

/// <summary>VPC connectivity access control for brokers. See connectivity_info vpc_connectivity Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity
{
    /// <summary>Configuration block for specifying a client authentication. See client_authentication Argument Reference below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication? ClientAuthentication { get; set; }
}

/// <summary>Information about the cluster access configuration. See broker_node_group_info connectivity_info Argument Reference below. For security reasons, you can&apos;t turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfo
{
    /// <summary>Access control settings for brokers. See connectivity_info public_access Argument Reference below.</summary>
    [JsonPropertyName("publicAccess")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess? PublicAccess { get; set; }

    /// <summary>VPC connectivity access control for brokers. See connectivity_info vpc_connectivity Argument Reference below.</summary>
    [JsonPropertyName("vpcConnectivity")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity? VpcConnectivity { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelector
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
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicy? Policy { get; set; }
}

/// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See ebs_storage_info provisioned_throughput Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Throughput value of the EBS volumes for the data drive on each kafka broker node in MiB per second. The minimum value is 250. The maximum value varies between broker type. You can refer to the valid values for the maximum volume throughput at the following documentation on throughput bottlenecks</summary>
    [JsonPropertyName("volumeThroughput")]
    public double? VolumeThroughput { get; set; }
}

/// <summary>A block that contains EBS volume information. See storage_info ebs_storage_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo
{
    /// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See ebs_storage_info provisioned_throughput Argument Reference below.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput? ProvisionedThroughput { get; set; }

    /// <summary>The size in GiB of the EBS volume for the data drive on each broker node. Minimum value of 1 and maximum value of 16384.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }
}

/// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See broker_node_group_info storage_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfoStorageInfo
{
    /// <summary>A block that contains EBS volume information. See storage_info ebs_storage_info Argument Reference below.</summary>
    [JsonPropertyName("ebsStorageInfo")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo? EbsStorageInfo { get; set; }
}

/// <summary>Configuration block for the broker nodes of the Kafka cluster. See broker_node_group_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderBrokerNodeGroupInfo
{
    /// <summary>The distribution of broker nodes across availability zones (documentation). Currently, the only valid value is DEFAULT.</summary>
    [JsonPropertyName("azDistribution")]
    public string? AzDistribution { get; set; }

    /// <summary>A list of subnets to connect to in client VPC (documentation).</summary>
    [JsonPropertyName("clientSubnets")]
    public IList<string>? ClientSubnets { get; set; }

    /// <summary>References to Subnet in ec2 to populate clientSubnets.</summary>
    [JsonPropertyName("clientSubnetsRefs")]
    public IList<V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsRefs>? ClientSubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate clientSubnets.</summary>
    [JsonPropertyName("clientSubnetsSelector")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoClientSubnetsSelector? ClientSubnetsSelector { get; set; }

    /// <summary>Information about the cluster access configuration. See broker_node_group_info connectivity_info Argument Reference below. For security reasons, you can&apos;t turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
    [JsonPropertyName("connectivityInfo")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoConnectivityInfo? ConnectivityInfo { get; set; }

    /// <summary>Specify the instance type to use for the kafka brokersE.g., kafka.m5.large. (Pricing info)</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>A list of the security groups to associate with the elastic network interfaces to control who can communicate with the cluster.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupsRefs")]
    public IList<V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsRefs>? SecurityGroupsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupsSelector")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoSecurityGroupsSelector? SecurityGroupsSelector { get; set; }

    /// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See broker_node_group_info storage_info Argument Reference below.</summary>
    [JsonPropertyName("storageInfo")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfoStorageInfo? StorageInfo { get; set; }
}

/// <summary>SASL authentication type details for VPC connectivity. See vpc_connectivity client_authentication sasl Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary>Enables TLS authentication for VPC connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderClientAuthenticationTls
{
    /// <summary>List of ACM Certificate Authority Amazon Resource Names (ARNs).</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Configuration block for specifying a client authentication. See client_authentication Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See vpc_connectivity client_authentication sasl Argument Reference below.</summary>
    [JsonPropertyName("sasl")]
    public V1beta3ClusterSpecForProviderClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public V1beta3ClusterSpecForProviderClientAuthenticationTls? Tls { get; set; }

    /// <summary>Enables unauthenticated access.</summary>
    [JsonPropertyName("unauthenticated")]
    public bool? Unauthenticated { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderConfigurationInfoArnRefPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderConfigurationInfoArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderConfigurationInfoArnRefPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderConfigurationInfoArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderConfigurationInfoArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderConfigurationInfoArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderConfigurationInfoArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Configuration in kafka to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderConfigurationInfoArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecForProviderConfigurationInfoArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderConfigurationInfoArnSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderConfigurationInfoArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderConfigurationInfoArnSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderConfigurationInfoArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderConfigurationInfoArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderConfigurationInfoArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderConfigurationInfoArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Configuration in kafka to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderConfigurationInfoArnSelector
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
    public V1beta3ClusterSpecForProviderConfigurationInfoArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for specifying an MSK Configuration to attach to Kafka brokers. See configuration_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderConfigurationInfo
{
    /// <summary>Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Configuration in kafka to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta3ClusterSpecForProviderConfigurationInfoArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Configuration in kafka to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta3ClusterSpecForProviderConfigurationInfoArnSelector? ArnSelector { get; set; }

    /// <summary>Revision of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelector
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
    public V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block to specify encryption in transit. See encryption_info encryption_in_transit Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderEncryptionInfoEncryptionInTransit
{
    /// <summary>Encryption setting for data in transit between clients and brokers. Valid values: TLS, TLS_PLAINTEXT, and PLAINTEXT. Default value is TLS.</summary>
    [JsonPropertyName("clientBroker")]
    public string? ClientBroker { get; set; }

    /// <summary>Whether data communication among broker nodes is encrypted. Default value: true.</summary>
    [JsonPropertyName("inCluster")]
    public bool? InCluster { get; set; }
}

/// <summary>Configuration block for specifying encryption. See encryption_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderEncryptionInfo
{
    /// <summary>The ARN of the KMS key used for encryption at rest of the broker data volumes.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArn")]
    public string? EncryptionAtRestKmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArnRef")]
    public V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnRef? EncryptionAtRestKmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArnSelector")]
    public V1beta3ClusterSpecForProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelector? EncryptionAtRestKmsKeyArnSelector { get; set; }

    /// <summary>Configuration block to specify encryption in transit. See encryption_info encryption_in_transit Argument Reference below.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public V1beta3ClusterSpecForProviderEncryptionInfoEncryptionInTransit? EncryptionInTransit { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelector
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
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for Cloudwatch Logs settings. See logging_info broker_logs cloudwatch_logs Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogs
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the Cloudwatch Log Group to deliver logs to.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupRef")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRef? LogGroupRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupSelector")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelector? LogGroupSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelector
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
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for Kinesis Data Firehose settings. See logging_info broker_logs firehose Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehose
{
    /// <summary>Name of the Kinesis Data Firehose delivery stream to deliver logs to.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamRef")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRef? DeliveryStreamRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamSelector")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelector? DeliveryStreamSelector { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelector
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
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for S3 settings. See logging_info broker_logs s3 Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3
{
    /// <summary>Name of the S3 bucket to deliver logs to.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3BucketSelector? BucketSelector { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prefix to append to the folder name.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Configuration block for Broker Logs settings for logging info. See logging_info broker_logs Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfoBrokerLogs
{
    /// <summary>Configuration block for Cloudwatch Logs settings. See logging_info broker_logs cloudwatch_logs Argument Reference below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary>Configuration block for Kinesis Data Firehose settings. See logging_info broker_logs firehose Argument Reference below.</summary>
    [JsonPropertyName("firehose")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsFirehose? Firehose { get; set; }

    /// <summary>Configuration block for S3 settings. See logging_info broker_logs s3 Argument Reference below.</summary>
    [JsonPropertyName("s3")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogsS3? S3 { get; set; }
}

/// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See logging_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderLoggingInfo
{
    /// <summary>Configuration block for Broker Logs settings for logging info. See logging_info broker_logs Argument Reference below.</summary>
    [JsonPropertyName("brokerLogs")]
    public V1beta3ClusterSpecForProviderLoggingInfoBrokerLogs? BrokerLogs { get; set; }
}

/// <summary>Configuration block for JMX Exporter. See open_monitoring prometheus jmx_exporter Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderOpenMonitoringPrometheusJmxExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Configuration block for Node Exporter. See open_monitoring prometheus node_exporter Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderOpenMonitoringPrometheusNodeExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Configuration block for Prometheus settings for open monitoring. See open_monitoring prometheus Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderOpenMonitoringPrometheus
{
    /// <summary>Configuration block for JMX Exporter. See open_monitoring prometheus jmx_exporter Argument Reference below.</summary>
    [JsonPropertyName("jmxExporter")]
    public V1beta3ClusterSpecForProviderOpenMonitoringPrometheusJmxExporter? JmxExporter { get; set; }

    /// <summary>Configuration block for Node Exporter. See open_monitoring prometheus node_exporter Argument Reference below.</summary>
    [JsonPropertyName("nodeExporter")]
    public V1beta3ClusterSpecForProviderOpenMonitoringPrometheusNodeExporter? NodeExporter { get; set; }
}

/// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See open_monitoring Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderOpenMonitoring
{
    /// <summary>Configuration block for Prometheus settings for open monitoring. See open_monitoring prometheus Argument Reference below.</summary>
    [JsonPropertyName("prometheus")]
    public V1beta3ClusterSpecForProviderOpenMonitoringPrometheus? Prometheus { get; set; }
}

/// <summary>Configuration block for intelligent rebalancing. See rebalancing Argument Reference below. Only applicable to MSK Provisioned clusters with Express brokers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProviderRebalancing
{
    /// <summary>The status of intelligent rebalancing. Valid values: ACTIVE, PAUSED. Default is ACTIVE for new Express-based clusters.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecForProvider
{
    /// <summary>Configuration block for the broker nodes of the Kafka cluster. See broker_node_group_info Argument Reference below.</summary>
    [JsonPropertyName("brokerNodeGroupInfo")]
    public V1beta3ClusterSpecForProviderBrokerNodeGroupInfo? BrokerNodeGroupInfo { get; set; }

    /// <summary>Configuration block for specifying a client authentication. See client_authentication Argument Reference below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta3ClusterSpecForProviderClientAuthentication? ClientAuthentication { get; set; }

    /// <summary>Name of the MSK cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Configuration block for specifying an MSK Configuration to attach to Kafka brokers. See configuration_info Argument Reference below.</summary>
    [JsonPropertyName("configurationInfo")]
    public V1beta3ClusterSpecForProviderConfigurationInfo? ConfigurationInfo { get; set; }

    /// <summary>Configuration block for specifying encryption. See encryption_info Argument Reference below.</summary>
    [JsonPropertyName("encryptionInfo")]
    public V1beta3ClusterSpecForProviderEncryptionInfo? EncryptionInfo { get; set; }

    /// <summary>Specify the desired enhanced MSK CloudWatch monitoring level. See Monitoring Amazon MSK with Amazon CloudWatch</summary>
    [JsonPropertyName("enhancedMonitoring")]
    public string? EnhancedMonitoring { get; set; }

    /// <summary>Specify the desired Kafka software version.</summary>
    [JsonPropertyName("kafkaVersion")]
    public string? KafkaVersion { get; set; }

    /// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See logging_info Argument Reference below.</summary>
    [JsonPropertyName("loggingInfo")]
    public V1beta3ClusterSpecForProviderLoggingInfo? LoggingInfo { get; set; }

    /// <summary>The desired total number of broker nodes in the kafka cluster.  It must be a multiple of the number of specified client subnets.</summary>
    [JsonPropertyName("numberOfBrokerNodes")]
    public double? NumberOfBrokerNodes { get; set; }

    /// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See open_monitoring Argument Reference below.</summary>
    [JsonPropertyName("openMonitoring")]
    public V1beta3ClusterSpecForProviderOpenMonitoring? OpenMonitoring { get; set; }

    /// <summary>Configuration block for intelligent rebalancing. See rebalancing Argument Reference below. Only applicable to MSK Provisioned clusters with Express brokers.</summary>
    [JsonPropertyName("rebalancing")]
    public V1beta3ClusterSpecForProviderRebalancing? Rebalancing { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Controls storage mode for supported storage tiers. Valid values are: LOCAL or TIERED.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate clientSubnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelector
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
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelectorPolicy? Policy { get; set; }
}

/// <summary>Access control settings for brokers. See connectivity_info public_access Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess
{
    /// <summary>Public access type. Valid values: DISABLED, SERVICE_PROVIDED_EIPS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SASL authentication type details for VPC connectivity. See vpc_connectivity client_authentication sasl Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary>Configuration block for specifying a client authentication. See client_authentication Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See vpc_connectivity client_authentication sasl Argument Reference below.</summary>
    [JsonPropertyName("sasl")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }
}

/// <summary>VPC connectivity access control for brokers. See connectivity_info vpc_connectivity Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity
{
    /// <summary>Configuration block for specifying a client authentication. See client_authentication Argument Reference below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication? ClientAuthentication { get; set; }
}

/// <summary>Information about the cluster access configuration. See broker_node_group_info connectivity_info Argument Reference below. For security reasons, you can&apos;t turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfo
{
    /// <summary>Access control settings for brokers. See connectivity_info public_access Argument Reference below.</summary>
    [JsonPropertyName("publicAccess")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess? PublicAccess { get; set; }

    /// <summary>VPC connectivity access control for brokers. See connectivity_info vpc_connectivity Argument Reference below.</summary>
    [JsonPropertyName("vpcConnectivity")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity? VpcConnectivity { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelector
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
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelectorPolicy? Policy { get; set; }
}

/// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See ebs_storage_info provisioned_throughput Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Throughput value of the EBS volumes for the data drive on each kafka broker node in MiB per second. The minimum value is 250. The maximum value varies between broker type. You can refer to the valid values for the maximum volume throughput at the following documentation on throughput bottlenecks</summary>
    [JsonPropertyName("volumeThroughput")]
    public double? VolumeThroughput { get; set; }
}

/// <summary>A block that contains EBS volume information. See storage_info ebs_storage_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo
{
    /// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See ebs_storage_info provisioned_throughput Argument Reference below.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput? ProvisionedThroughput { get; set; }

    /// <summary>The size in GiB of the EBS volume for the data drive on each broker node. Minimum value of 1 and maximum value of 16384.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }
}

/// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See broker_node_group_info storage_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfo
{
    /// <summary>A block that contains EBS volume information. See storage_info ebs_storage_info Argument Reference below.</summary>
    [JsonPropertyName("ebsStorageInfo")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo? EbsStorageInfo { get; set; }
}

/// <summary>Configuration block for the broker nodes of the Kafka cluster. See broker_node_group_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderBrokerNodeGroupInfo
{
    /// <summary>The distribution of broker nodes across availability zones (documentation). Currently, the only valid value is DEFAULT.</summary>
    [JsonPropertyName("azDistribution")]
    public string? AzDistribution { get; set; }

    /// <summary>A list of subnets to connect to in client VPC (documentation).</summary>
    [JsonPropertyName("clientSubnets")]
    public IList<string>? ClientSubnets { get; set; }

    /// <summary>References to Subnet in ec2 to populate clientSubnets.</summary>
    [JsonPropertyName("clientSubnetsRefs")]
    public IList<V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsRefs>? ClientSubnetsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate clientSubnets.</summary>
    [JsonPropertyName("clientSubnetsSelector")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoClientSubnetsSelector? ClientSubnetsSelector { get; set; }

    /// <summary>Information about the cluster access configuration. See broker_node_group_info connectivity_info Argument Reference below. For security reasons, you can&apos;t turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
    [JsonPropertyName("connectivityInfo")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoConnectivityInfo? ConnectivityInfo { get; set; }

    /// <summary>Specify the instance type to use for the kafka brokersE.g., kafka.m5.large. (Pricing info)</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>A list of the security groups to associate with the elastic network interfaces to control who can communicate with the cluster.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupsRefs")]
    public IList<V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsRefs>? SecurityGroupsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupsSelector")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoSecurityGroupsSelector? SecurityGroupsSelector { get; set; }

    /// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See broker_node_group_info storage_info Argument Reference below.</summary>
    [JsonPropertyName("storageInfo")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfoStorageInfo? StorageInfo { get; set; }
}

/// <summary>SASL authentication type details for VPC connectivity. See vpc_connectivity client_authentication sasl Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary>Enables TLS authentication for VPC connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderClientAuthenticationTls
{
    /// <summary>List of ACM Certificate Authority Amazon Resource Names (ARNs).</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Configuration block for specifying a client authentication. See client_authentication Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See vpc_connectivity client_authentication sasl Argument Reference below.</summary>
    [JsonPropertyName("sasl")]
    public V1beta3ClusterSpecInitProviderClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public V1beta3ClusterSpecInitProviderClientAuthenticationTls? Tls { get; set; }

    /// <summary>Enables unauthenticated access.</summary>
    [JsonPropertyName("unauthenticated")]
    public bool? Unauthenticated { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderConfigurationInfoArnRefPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderConfigurationInfoArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderConfigurationInfoArnRefPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderConfigurationInfoArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderConfigurationInfoArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderConfigurationInfoArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderConfigurationInfoArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Configuration in kafka to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderConfigurationInfoArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecInitProviderConfigurationInfoArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderConfigurationInfoArnSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderConfigurationInfoArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderConfigurationInfoArnSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderConfigurationInfoArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderConfigurationInfoArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderConfigurationInfoArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderConfigurationInfoArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Configuration in kafka to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderConfigurationInfoArnSelector
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
    public V1beta3ClusterSpecInitProviderConfigurationInfoArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for specifying an MSK Configuration to attach to Kafka brokers. See configuration_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderConfigurationInfo
{
    /// <summary>Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Configuration in kafka to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta3ClusterSpecInitProviderConfigurationInfoArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Configuration in kafka to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta3ClusterSpecInitProviderConfigurationInfoArnSelector? ArnSelector { get; set; }

    /// <summary>Revision of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelector
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
    public V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block to specify encryption in transit. See encryption_info encryption_in_transit Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionInTransit
{
    /// <summary>Encryption setting for data in transit between clients and brokers. Valid values: TLS, TLS_PLAINTEXT, and PLAINTEXT. Default value is TLS.</summary>
    [JsonPropertyName("clientBroker")]
    public string? ClientBroker { get; set; }

    /// <summary>Whether data communication among broker nodes is encrypted. Default value: true.</summary>
    [JsonPropertyName("inCluster")]
    public bool? InCluster { get; set; }
}

/// <summary>Configuration block for specifying encryption. See encryption_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderEncryptionInfo
{
    /// <summary>The ARN of the KMS key used for encryption at rest of the broker data volumes.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArn")]
    public string? EncryptionAtRestKmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArnRef")]
    public V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnRef? EncryptionAtRestKmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate encryptionAtRestKmsKeyArn.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArnSelector")]
    public V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionAtRestKmsKeyArnSelector? EncryptionAtRestKmsKeyArnSelector { get; set; }

    /// <summary>Configuration block to specify encryption in transit. See encryption_info encryption_in_transit Argument Reference below.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public V1beta3ClusterSpecInitProviderEncryptionInfoEncryptionInTransit? EncryptionInTransit { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelector
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
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for Cloudwatch Logs settings. See logging_info broker_logs cloudwatch_logs Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogs
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the Cloudwatch Log Group to deliver logs to.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupRef")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupRef? LogGroupRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroup.</summary>
    [JsonPropertyName("logGroupSelector")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogsLogGroupSelector? LogGroupSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelector
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
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for Kinesis Data Firehose settings. See logging_info broker_logs firehose Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehose
{
    /// <summary>Name of the Kinesis Data Firehose delivery stream to deliver logs to.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamRef")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamRef? DeliveryStreamRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStream.</summary>
    [JsonPropertyName("deliveryStreamSelector")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehoseDeliveryStreamSelector? DeliveryStreamSelector { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolveEnum>))]
public enum V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelector
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
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for S3 settings. See logging_info broker_logs s3 Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3
{
    /// <summary>Name of the S3 bucket to deliver logs to.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3BucketSelector? BucketSelector { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prefix to append to the folder name.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Configuration block for Broker Logs settings for logging info. See logging_info broker_logs Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogs
{
    /// <summary>Configuration block for Cloudwatch Logs settings. See logging_info broker_logs cloudwatch_logs Argument Reference below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary>Configuration block for Kinesis Data Firehose settings. See logging_info broker_logs firehose Argument Reference below.</summary>
    [JsonPropertyName("firehose")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsFirehose? Firehose { get; set; }

    /// <summary>Configuration block for S3 settings. See logging_info broker_logs s3 Argument Reference below.</summary>
    [JsonPropertyName("s3")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogsS3? S3 { get; set; }
}

/// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See logging_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderLoggingInfo
{
    /// <summary>Configuration block for Broker Logs settings for logging info. See logging_info broker_logs Argument Reference below.</summary>
    [JsonPropertyName("brokerLogs")]
    public V1beta3ClusterSpecInitProviderLoggingInfoBrokerLogs? BrokerLogs { get; set; }
}

/// <summary>Configuration block for JMX Exporter. See open_monitoring prometheus jmx_exporter Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderOpenMonitoringPrometheusJmxExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Configuration block for Node Exporter. See open_monitoring prometheus node_exporter Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderOpenMonitoringPrometheusNodeExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Configuration block for Prometheus settings for open monitoring. See open_monitoring prometheus Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderOpenMonitoringPrometheus
{
    /// <summary>Configuration block for JMX Exporter. See open_monitoring prometheus jmx_exporter Argument Reference below.</summary>
    [JsonPropertyName("jmxExporter")]
    public V1beta3ClusterSpecInitProviderOpenMonitoringPrometheusJmxExporter? JmxExporter { get; set; }

    /// <summary>Configuration block for Node Exporter. See open_monitoring prometheus node_exporter Argument Reference below.</summary>
    [JsonPropertyName("nodeExporter")]
    public V1beta3ClusterSpecInitProviderOpenMonitoringPrometheusNodeExporter? NodeExporter { get; set; }
}

/// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See open_monitoring Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderOpenMonitoring
{
    /// <summary>Configuration block for Prometheus settings for open monitoring. See open_monitoring prometheus Argument Reference below.</summary>
    [JsonPropertyName("prometheus")]
    public V1beta3ClusterSpecInitProviderOpenMonitoringPrometheus? Prometheus { get; set; }
}

/// <summary>Configuration block for intelligent rebalancing. See rebalancing Argument Reference below. Only applicable to MSK Provisioned clusters with Express brokers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecInitProviderRebalancing
{
    /// <summary>The status of intelligent rebalancing. Valid values: ACTIVE, PAUSED. Default is ACTIVE for new Express-based clusters.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
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
public partial class V1beta3ClusterSpecInitProvider
{
    /// <summary>Configuration block for the broker nodes of the Kafka cluster. See broker_node_group_info Argument Reference below.</summary>
    [JsonPropertyName("brokerNodeGroupInfo")]
    public V1beta3ClusterSpecInitProviderBrokerNodeGroupInfo? BrokerNodeGroupInfo { get; set; }

    /// <summary>Configuration block for specifying a client authentication. See client_authentication Argument Reference below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta3ClusterSpecInitProviderClientAuthentication? ClientAuthentication { get; set; }

    /// <summary>Name of the MSK cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Configuration block for specifying an MSK Configuration to attach to Kafka brokers. See configuration_info Argument Reference below.</summary>
    [JsonPropertyName("configurationInfo")]
    public V1beta3ClusterSpecInitProviderConfigurationInfo? ConfigurationInfo { get; set; }

    /// <summary>Configuration block for specifying encryption. See encryption_info Argument Reference below.</summary>
    [JsonPropertyName("encryptionInfo")]
    public V1beta3ClusterSpecInitProviderEncryptionInfo? EncryptionInfo { get; set; }

    /// <summary>Specify the desired enhanced MSK CloudWatch monitoring level. See Monitoring Amazon MSK with Amazon CloudWatch</summary>
    [JsonPropertyName("enhancedMonitoring")]
    public string? EnhancedMonitoring { get; set; }

    /// <summary>Specify the desired Kafka software version.</summary>
    [JsonPropertyName("kafkaVersion")]
    public string? KafkaVersion { get; set; }

    /// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See logging_info Argument Reference below.</summary>
    [JsonPropertyName("loggingInfo")]
    public V1beta3ClusterSpecInitProviderLoggingInfo? LoggingInfo { get; set; }

    /// <summary>The desired total number of broker nodes in the kafka cluster.  It must be a multiple of the number of specified client subnets.</summary>
    [JsonPropertyName("numberOfBrokerNodes")]
    public double? NumberOfBrokerNodes { get; set; }

    /// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See open_monitoring Argument Reference below.</summary>
    [JsonPropertyName("openMonitoring")]
    public V1beta3ClusterSpecInitProviderOpenMonitoring? OpenMonitoring { get; set; }

    /// <summary>Configuration block for intelligent rebalancing. See rebalancing Argument Reference below. Only applicable to MSK Provisioned clusters with Express brokers.</summary>
    [JsonPropertyName("rebalancing")]
    public V1beta3ClusterSpecInitProviderRebalancing? Rebalancing { get; set; }

    /// <summary>Controls storage mode for supported storage tiers. Valid values are: LOCAL or TIERED.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecManagementPoliciesEnum>))]
public enum V1beta3ClusterSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta3ClusterSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ClusterSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta3ClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3ClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3ClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterSpec
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
    public V1beta3ClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta3ClusterSpecForProvider ForProvider { get; set; }

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
    public V1beta3ClusterSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta3ClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta3ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta3ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Access control settings for brokers. See connectivity_info public_access Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess
{
    /// <summary>Public access type. Valid values: DISABLED, SERVICE_PROVIDED_EIPS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SASL authentication type details for VPC connectivity. See vpc_connectivity client_authentication sasl Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary>Configuration block for specifying a client authentication. See client_authentication Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See vpc_connectivity client_authentication sasl Argument Reference below.</summary>
    [JsonPropertyName("sasl")]
    public V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }
}

/// <summary>VPC connectivity access control for brokers. See connectivity_info vpc_connectivity Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity
{
    /// <summary>Configuration block for specifying a client authentication. See client_authentication Argument Reference below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication? ClientAuthentication { get; set; }
}

/// <summary>Information about the cluster access configuration. See broker_node_group_info connectivity_info Argument Reference below. For security reasons, you can&apos;t turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfo
{
    /// <summary>Access control settings for brokers. See connectivity_info public_access Argument Reference below.</summary>
    [JsonPropertyName("publicAccess")]
    public V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoPublicAccess? PublicAccess { get; set; }

    /// <summary>VPC connectivity access control for brokers. See connectivity_info vpc_connectivity Argument Reference below.</summary>
    [JsonPropertyName("vpcConnectivity")]
    public V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfoVpcConnectivity? VpcConnectivity { get; set; }
}

/// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See ebs_storage_info provisioned_throughput Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Throughput value of the EBS volumes for the data drive on each kafka broker node in MiB per second. The minimum value is 250. The maximum value varies between broker type. You can refer to the valid values for the maximum volume throughput at the following documentation on throughput bottlenecks</summary>
    [JsonPropertyName("volumeThroughput")]
    public double? VolumeThroughput { get; set; }
}

/// <summary>A block that contains EBS volume information. See storage_info ebs_storage_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo
{
    /// <summary>A block that contains EBS volume provisioned throughput information. To provision storage throughput, you must choose broker type kafka.m5.4xlarge or larger. See ebs_storage_info provisioned_throughput Argument Reference below.</summary>
    [JsonPropertyName("provisionedThroughput")]
    public V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput? ProvisionedThroughput { get; set; }

    /// <summary>The size in GiB of the EBS volume for the data drive on each broker node. Minimum value of 1 and maximum value of 16384.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }
}

/// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See broker_node_group_info storage_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfo
{
    /// <summary>A block that contains EBS volume information. See storage_info ebs_storage_info Argument Reference below.</summary>
    [JsonPropertyName("ebsStorageInfo")]
    public V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfoEbsStorageInfo? EbsStorageInfo { get; set; }
}

/// <summary>Configuration block for the broker nodes of the Kafka cluster. See broker_node_group_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderBrokerNodeGroupInfo
{
    /// <summary>The distribution of broker nodes across availability zones (documentation). Currently, the only valid value is DEFAULT.</summary>
    [JsonPropertyName("azDistribution")]
    public string? AzDistribution { get; set; }

    /// <summary>A list of subnets to connect to in client VPC (documentation).</summary>
    [JsonPropertyName("clientSubnets")]
    public IList<string>? ClientSubnets { get; set; }

    /// <summary>Information about the cluster access configuration. See broker_node_group_info connectivity_info Argument Reference below. For security reasons, you can&apos;t turn on public access while creating an MSK cluster. However, you can update an existing cluster to make it publicly accessible. You can also create a new cluster and then update it to make it publicly accessible (documentation).</summary>
    [JsonPropertyName("connectivityInfo")]
    public V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoConnectivityInfo? ConnectivityInfo { get; set; }

    /// <summary>Specify the instance type to use for the kafka brokersE.g., kafka.m5.large. (Pricing info)</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>A list of the security groups to associate with the elastic network interfaces to control who can communicate with the cluster.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>A block that contains information about storage volumes attached to MSK broker nodes. See broker_node_group_info storage_info Argument Reference below.</summary>
    [JsonPropertyName("storageInfo")]
    public V1beta3ClusterStatusAtProviderBrokerNodeGroupInfoStorageInfo? StorageInfo { get; set; }
}

/// <summary>SASL authentication type details for VPC connectivity. See vpc_connectivity client_authentication sasl Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderClientAuthenticationSasl
{
    /// <summary>Enables SASL/IAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("iam")]
    public bool? Iam { get; set; }

    /// <summary>Enables SASL/SCRAM authentication for VPC connectivity.</summary>
    [JsonPropertyName("scram")]
    public bool? Scram { get; set; }
}

/// <summary>Enables TLS authentication for VPC connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderClientAuthenticationTls
{
    /// <summary>List of ACM Certificate Authority Amazon Resource Names (ARNs).</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Configuration block for specifying a client authentication. See client_authentication Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderClientAuthentication
{
    /// <summary>SASL authentication type details for VPC connectivity. See vpc_connectivity client_authentication sasl Argument Reference below.</summary>
    [JsonPropertyName("sasl")]
    public V1beta3ClusterStatusAtProviderClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Enables TLS authentication for VPC connectivity.</summary>
    [JsonPropertyName("tls")]
    public V1beta3ClusterStatusAtProviderClientAuthenticationTls? Tls { get; set; }

    /// <summary>Enables unauthenticated access.</summary>
    [JsonPropertyName("unauthenticated")]
    public bool? Unauthenticated { get; set; }
}

/// <summary>Configuration block for specifying an MSK Configuration to attach to Kafka brokers. See configuration_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderConfigurationInfo
{
    /// <summary>Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Revision of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }
}

/// <summary>Configuration block to specify encryption in transit. See encryption_info encryption_in_transit Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderEncryptionInfoEncryptionInTransit
{
    /// <summary>Encryption setting for data in transit between clients and brokers. Valid values: TLS, TLS_PLAINTEXT, and PLAINTEXT. Default value is TLS.</summary>
    [JsonPropertyName("clientBroker")]
    public string? ClientBroker { get; set; }

    /// <summary>Whether data communication among broker nodes is encrypted. Default value: true.</summary>
    [JsonPropertyName("inCluster")]
    public bool? InCluster { get; set; }
}

/// <summary>Configuration block for specifying encryption. See encryption_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderEncryptionInfo
{
    /// <summary>The ARN of the KMS key used for encryption at rest of the broker data volumes.</summary>
    [JsonPropertyName("encryptionAtRestKmsKeyArn")]
    public string? EncryptionAtRestKmsKeyArn { get; set; }

    /// <summary>Configuration block to specify encryption in transit. See encryption_info encryption_in_transit Argument Reference below.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public V1beta3ClusterStatusAtProviderEncryptionInfoEncryptionInTransit? EncryptionInTransit { get; set; }
}

/// <summary>Configuration block for Cloudwatch Logs settings. See logging_info broker_logs cloudwatch_logs Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderLoggingInfoBrokerLogsCloudwatchLogs
{
    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the Cloudwatch Log Group to deliver logs to.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

/// <summary>Configuration block for Kinesis Data Firehose settings. See logging_info broker_logs firehose Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderLoggingInfoBrokerLogsFirehose
{
    /// <summary>Name of the Kinesis Data Firehose delivery stream to deliver logs to.</summary>
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for S3 settings. See logging_info broker_logs s3 Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderLoggingInfoBrokerLogsS3
{
    /// <summary>Name of the S3 bucket to deliver logs to.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Controls whether provisioned throughput is enabled or not. Default value: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prefix to append to the folder name.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Configuration block for Broker Logs settings for logging info. See logging_info broker_logs Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderLoggingInfoBrokerLogs
{
    /// <summary>Configuration block for Cloudwatch Logs settings. See logging_info broker_logs cloudwatch_logs Argument Reference below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta3ClusterStatusAtProviderLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogs { get; set; }

    /// <summary>Configuration block for Kinesis Data Firehose settings. See logging_info broker_logs firehose Argument Reference below.</summary>
    [JsonPropertyName("firehose")]
    public V1beta3ClusterStatusAtProviderLoggingInfoBrokerLogsFirehose? Firehose { get; set; }

    /// <summary>Configuration block for S3 settings. See logging_info broker_logs s3 Argument Reference below.</summary>
    [JsonPropertyName("s3")]
    public V1beta3ClusterStatusAtProviderLoggingInfoBrokerLogsS3? S3 { get; set; }
}

/// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See logging_info Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderLoggingInfo
{
    /// <summary>Configuration block for Broker Logs settings for logging info. See logging_info broker_logs Argument Reference below.</summary>
    [JsonPropertyName("brokerLogs")]
    public V1beta3ClusterStatusAtProviderLoggingInfoBrokerLogs? BrokerLogs { get; set; }
}

/// <summary>Configuration block for JMX Exporter. See open_monitoring prometheus jmx_exporter Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderOpenMonitoringPrometheusJmxExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Configuration block for Node Exporter. See open_monitoring prometheus node_exporter Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderOpenMonitoringPrometheusNodeExporter
{
    /// <summary>Indicates whether you want to enable or disable the JMX Exporter.</summary>
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Configuration block for Prometheus settings for open monitoring. See open_monitoring prometheus Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderOpenMonitoringPrometheus
{
    /// <summary>Configuration block for JMX Exporter. See open_monitoring prometheus jmx_exporter Argument Reference below.</summary>
    [JsonPropertyName("jmxExporter")]
    public V1beta3ClusterStatusAtProviderOpenMonitoringPrometheusJmxExporter? JmxExporter { get; set; }

    /// <summary>Configuration block for Node Exporter. See open_monitoring prometheus node_exporter Argument Reference below.</summary>
    [JsonPropertyName("nodeExporter")]
    public V1beta3ClusterStatusAtProviderOpenMonitoringPrometheusNodeExporter? NodeExporter { get; set; }
}

/// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See open_monitoring Argument Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderOpenMonitoring
{
    /// <summary>Configuration block for Prometheus settings for open monitoring. See open_monitoring prometheus Argument Reference below.</summary>
    [JsonPropertyName("prometheus")]
    public V1beta3ClusterStatusAtProviderOpenMonitoringPrometheus? Prometheus { get; set; }
}

/// <summary>Configuration block for intelligent rebalancing. See rebalancing Argument Reference below. Only applicable to MSK Provisioned clusters with Express brokers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProviderRebalancing
{
    /// <summary>The status of intelligent rebalancing. Valid values: ACTIVE, PAUSED. Default is ACTIVE for new Express-based clusters.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the MSK Configuration to use in the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Comma separated list of one or more hostname:port pairs of kafka brokers suitable to bootstrap connectivity to the kafka cluster. Contains a value if encryption_info.0.encryption_in_transit.0.client_broker is set to PLAINTEXT or TLS_PLAINTEXT. The resource sorts values alphabetically. AWS may not always return all endpoints so this value is not guaranteed to be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokers")]
    public string? BootstrapBrokers { get; set; }

    /// <summary>One or more DNS names (or IP addresses) and SASL IAM port pairs. For example, b-1-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9198,b-2-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9198,b-3-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9198. This attribute will have a value if encryption_info.0.encryption_in_transit.0.client_broker is set to TLS_PLAINTEXT or TLS and client_authentication.0.sasl.0.iam is set to true and broker_node_group_info.0.connectivity_info.0.public_access.0.type is set to SERVICE_PROVIDED_EIPS and the cluster fulfill all other requirements for public access. The resource sorts the list alphabetically. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersPublicSaslIam")]
    public string? BootstrapBrokersPublicSaslIam { get; set; }

    /// <summary>One or more DNS names (or IP addresses) and SASL SCRAM port pairs. For example, b-1-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9196,b-2-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9196,b-3-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9196. This attribute will have a value if encryption_info.0.encryption_in_transit.0.client_broker is set to TLS_PLAINTEXT or TLS and client_authentication.0.sasl.0.scram is set to true and broker_node_group_info.0.connectivity_info.0.public_access.0.type is set to SERVICE_PROVIDED_EIPS and the cluster fulfill all other requirements for public access. The resource sorts the list alphabetically. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersPublicSaslScram")]
    public string? BootstrapBrokersPublicSaslScram { get; set; }

    /// <summary>One or more DNS names (or IP addresses) and TLS port pairs. For example, b-1-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9194,b-2-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9194,b-3-public.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9194. This attribute will have a value if encryption_info.0.encryption_in_transit.0.client_broker is set to TLS_PLAINTEXT or TLS and broker_node_group_info.0.connectivity_info.0.public_access.0.type is set to SERVICE_PROVIDED_EIPS and the cluster fulfill all other requirements for public access. The resource sorts the list alphabetically. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersPublicTls")]
    public string? BootstrapBrokersPublicTls { get; set; }

    /// <summary>One or more DNS names (or IP addresses) and SASL IAM port pairs. For example, b-1.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9098,b-2.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9098,b-3.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9098. This attribute will have a value if encryption_info.0.encryption_in_transit.0.client_broker is set to TLS_PLAINTEXT or TLS and client_authentication.0.sasl.0.iam is set to true. The resource sorts the list alphabetically. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersSaslIam")]
    public string? BootstrapBrokersSaslIam { get; set; }

    /// <summary>One or more DNS names (or IP addresses) and SASL SCRAM port pairs. For example, b-1.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9096,b-2.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9096,b-3.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9096. This attribute will have a value if encryption_info.0.encryption_in_transit.0.client_broker is set to TLS_PLAINTEXT or TLS and client_authentication.0.sasl.0.scram is set to true. The resource sorts the list alphabetically. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersSaslScram")]
    public string? BootstrapBrokersSaslScram { get; set; }

    /// <summary>One or more DNS names (or IP addresses) and TLS port pairs. For example, b-1.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9094,b-2.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9094,b-3.exampleClusterName.abcde.c2.kafka.us-east-1.amazonaws.com:9094. This attribute will have a value if encryption_info.0.encryption_in_transit.0.client_broker is set to TLS_PLAINTEXT or TLS. The resource sorts the list alphabetically. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersTls")]
    public string? BootstrapBrokersTls { get; set; }

    /// <summary>A string containing one or more DNS names (or IP addresses) and SASL IAM port pairs for VPC connectivity. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersVpcConnectivitySaslIam")]
    public string? BootstrapBrokersVpcConnectivitySaslIam { get; set; }

    /// <summary>A string containing one or more DNS names (or IP addresses) and SASL SCRAM port pairs for VPC connectivity. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersVpcConnectivitySaslScram")]
    public string? BootstrapBrokersVpcConnectivitySaslScram { get; set; }

    /// <summary>A string containing one or more DNS names (or IP addresses) and TLS port pairs for VPC connectivity. AWS may not always return all endpoints so the values may not be stable across applies.</summary>
    [JsonPropertyName("bootstrapBrokersVpcConnectivityTls")]
    public string? BootstrapBrokersVpcConnectivityTls { get; set; }

    /// <summary>Configuration block for the broker nodes of the Kafka cluster. See broker_node_group_info Argument Reference below.</summary>
    [JsonPropertyName("brokerNodeGroupInfo")]
    public V1beta3ClusterStatusAtProviderBrokerNodeGroupInfo? BrokerNodeGroupInfo { get; set; }

    /// <summary>Configuration block for specifying a client authentication. See client_authentication Argument Reference below.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1beta3ClusterStatusAtProviderClientAuthentication? ClientAuthentication { get; set; }

    /// <summary>Name of the MSK cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>UUID of the MSK cluster, for use in IAM policies.</summary>
    [JsonPropertyName("clusterUuid")]
    public string? ClusterUuid { get; set; }

    /// <summary>Configuration block for specifying an MSK Configuration to attach to Kafka brokers. See configuration_info Argument Reference below.</summary>
    [JsonPropertyName("configurationInfo")]
    public V1beta3ClusterStatusAtProviderConfigurationInfo? ConfigurationInfo { get; set; }

    /// <summary>Current version of the MSK Cluster used for updates, e.g., K13V1IB3VIYZZH</summary>
    [JsonPropertyName("currentVersion")]
    public string? CurrentVersion { get; set; }

    /// <summary>Configuration block for specifying encryption. See encryption_info Argument Reference below.</summary>
    [JsonPropertyName("encryptionInfo")]
    public V1beta3ClusterStatusAtProviderEncryptionInfo? EncryptionInfo { get; set; }

    /// <summary>Specify the desired enhanced MSK CloudWatch monitoring level. See Monitoring Amazon MSK with Amazon CloudWatch</summary>
    [JsonPropertyName("enhancedMonitoring")]
    public string? EnhancedMonitoring { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specify the desired Kafka software version.</summary>
    [JsonPropertyName("kafkaVersion")]
    public string? KafkaVersion { get; set; }

    /// <summary>Configuration block for streaming broker logs to Cloudwatch/S3/Kinesis Firehose. See logging_info Argument Reference below.</summary>
    [JsonPropertyName("loggingInfo")]
    public V1beta3ClusterStatusAtProviderLoggingInfo? LoggingInfo { get; set; }

    /// <summary>The desired total number of broker nodes in the kafka cluster.  It must be a multiple of the number of specified client subnets.</summary>
    [JsonPropertyName("numberOfBrokerNodes")]
    public double? NumberOfBrokerNodes { get; set; }

    /// <summary>Configuration block for JMX and Node monitoring for the MSK cluster. See open_monitoring Argument Reference below.</summary>
    [JsonPropertyName("openMonitoring")]
    public V1beta3ClusterStatusAtProviderOpenMonitoring? OpenMonitoring { get; set; }

    /// <summary>Configuration block for intelligent rebalancing. See rebalancing Argument Reference below. Only applicable to MSK Provisioned clusters with Express brokers.</summary>
    [JsonPropertyName("rebalancing")]
    public V1beta3ClusterStatusAtProviderRebalancing? Rebalancing { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Controls storage mode for supported storage tiers. Valid values are: LOCAL or TIERED.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>A comma separated list of one or more hostname:port pairs to use to connect to the Apache Zookeeper cluster. The returned values are sorted alphabetically. The AWS API may not return all endpoints, so this value is not guaranteed to be stable across applies.</summary>
    [JsonPropertyName("zookeeperConnectString")]
    public string? ZookeeperConnectString { get; set; }

    /// <summary>A comma separated list of one or more hostname:port pairs to use to connect to the Apache Zookeeper cluster via TLS. The returned values are sorted alphabetically. The AWS API may not return all endpoints, so this value is not guaranteed to be stable across applies.</summary>
    [JsonPropertyName("zookeeperConnectStringTls")]
    public string? ZookeeperConnectStringTls { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatusConditions
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

/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ClusterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta3ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta3ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta3Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta3ClusterSpec>, IStatus<V1beta3ClusterStatus?>
{
    public const string KubeApiVersion = "v1beta3";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "kafka.aws.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.aws.upbound.io/v1beta3";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Cluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public required V1beta3ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta3ClusterStatus? Status { get; set; }
}