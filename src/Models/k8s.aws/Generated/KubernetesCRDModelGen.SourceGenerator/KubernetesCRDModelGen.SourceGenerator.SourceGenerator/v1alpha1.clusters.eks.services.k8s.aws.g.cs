#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eks.services.k8s.aws;
/// <summary>Cluster is the Schema for the Clusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Cluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "eks.services.k8s.aws";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Cluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Cluster> Items { get; set; }
}

/// <summary>The access configuration for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecAccessConfig
{
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    [JsonPropertyName("bootstrapClusterCreatorAdminPermissions")]
    public bool? BootstrapClusterCreatorAdminPermissions { get; set; }
}

/// <summary>
/// Enable or disable the compute capability of EKS Auto Mode when creating your
/// EKS Auto Mode cluster. If the compute capability is enabled, EKS Auto Mode
/// will create and delete EC2 Managed Instances in your Amazon Web Services
/// account
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecComputeConfig
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("nodePools")]
    public IList<string>? NodePools { get; set; }

    [JsonPropertyName("nodeRoleARN")]
    public string? NodeRoleARN { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecEncryptionConfigProviderKeyRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for KeyARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecEncryptionConfigProviderKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecEncryptionConfigProviderKeyRefFrom? From { get; set; }
}

/// <summary>Identifies the Key Management Service (KMS) key used to encrypt the secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecEncryptionConfigProvider
{
    [JsonPropertyName("keyARN")]
    public string? KeyARN { get; set; }

    /// <summary>Reference field for KeyARN</summary>
    [JsonPropertyName("keyRef")]
    public V1alpha1ClusterSpecEncryptionConfigProviderKeyRef? KeyRef { get; set; }
}

/// <summary>The encryption configuration for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecEncryptionConfig
{
    /// <summary>Identifies the Key Management Service (KMS) key used to encrypt the secrets.</summary>
    [JsonPropertyName("provider")]
    public V1alpha1ClusterSpecEncryptionConfigProvider? Provider { get; set; }

    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }
}

/// <summary>
/// Indicates the current configuration of the load balancing capability on your
/// EKS Auto Mode cluster. For example, if the capability is enabled or disabled.
/// For more information, see EKS Auto Mode load balancing capability in the
/// Amazon EKS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecKubernetesNetworkConfigElasticLoadBalancing
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The Kubernetes network configuration for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecKubernetesNetworkConfig
{
    /// <summary>
    /// Indicates the current configuration of the load balancing capability on your
    /// EKS Auto Mode cluster. For example, if the capability is enabled or disabled.
    /// For more information, see EKS Auto Mode load balancing capability in the
    /// Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("elasticLoadBalancing")]
    public V1alpha1ClusterSpecKubernetesNetworkConfigElasticLoadBalancing? ElasticLoadBalancing { get; set; }

    [JsonPropertyName("ipFamily")]
    public string? IpFamily { get; set; }

    [JsonPropertyName("serviceIPv4CIDR")]
    public string? ServiceIPv4CIDR { get; set; }
}

/// <summary>
/// An object representing the enabled or disabled Kubernetes control plane logs
/// for your cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecLoggingClusterLogging
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>
/// Enable or disable exporting the Kubernetes control plane logs for your cluster
/// to CloudWatch Logs . By default, cluster control plane logs aren&apos;t exported
/// to CloudWatch Logs . For more information, see Amazon EKS Cluster control
/// plane logs (https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html)
/// in the Amazon EKS User Guide .
/// 
/// CloudWatch Logs ingestion, archive storage, and data scanning rates apply
/// to exported control plane logs. For more information, see CloudWatch Pricing
/// (http://aws.amazon.com/cloudwatch/pricing/).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecLogging
{
    [JsonPropertyName("clusterLogging")]
    public IList<V1alpha1ClusterSpecLoggingClusterLogging>? ClusterLogging { get; set; }
}

/// <summary>
/// The placement configuration for all the control plane instances of your local
/// Amazon EKS cluster on an Amazon Web Services Outpost. For more information,
/// see Capacity considerations (https://docs.aws.amazon.com/eks/latest/userguide/eks-outposts-capacity-considerations.html)
/// in the Amazon EKS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecOutpostConfigControlPlanePlacement
{
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }
}

/// <summary>
/// An object representing the configuration of your local Amazon EKS cluster
/// on an Amazon Web Services Outpost. Before creating a local cluster on an
/// Outpost, review Local clusters for Amazon EKS on Amazon Web Services Outposts
/// (https://docs.aws.amazon.com/eks/latest/userguide/eks-outposts-local-cluster-overview.html)
/// in the Amazon EKS User Guide. This object isn&apos;t available for creating Amazon
/// EKS clusters on the Amazon Web Services cloud.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecOutpostConfig
{
    [JsonPropertyName("controlPlaneInstanceType")]
    public string? ControlPlaneInstanceType { get; set; }

    /// <summary>
    /// The placement configuration for all the control plane instances of your local
    /// Amazon EKS cluster on an Amazon Web Services Outpost. For more information,
    /// see Capacity considerations (https://docs.aws.amazon.com/eks/latest/userguide/eks-outposts-capacity-considerations.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("controlPlanePlacement")]
    public V1alpha1ClusterSpecOutpostConfigControlPlanePlacement? ControlPlanePlacement { get; set; }

    [JsonPropertyName("outpostARNs")]
    public IList<string>? OutpostARNs { get; set; }
}

/// <summary>
/// A network CIDR that can contain hybrid nodes.
/// 
/// These CIDR blocks define the expected IP address range of the hybrid nodes
/// that join the cluster. These blocks are typically determined by your network
/// administrator.
/// 
/// Enter one or more IPv4 CIDR blocks in decimal dotted-quad notation (for example,
/// 10.2.0.0/16).
/// 
/// It must satisfy the following requirements:
/// 
///   - Each block must be within an IPv4 RFC-1918 network range. Minimum allowed
///     size is /32, maximum allowed size is /8. Publicly-routable addresses aren&apos;t
///     supported.
/// 
///   - Each block cannot overlap with the range of the VPC CIDR blocks for
///     your EKS resources, or the block of the Kubernetes service IP range.
/// 
///   - Each block must have a route to the VPC that uses the VPC CIDR blocks,
///     not public IPs or Elastic IPs. There are many options including Transit
///     Gateway, Site-to-Site VPN, or Direct Connect.
/// 
///   - Each host must allow outbound connection to the EKS cluster control
///     plane on TCP ports 443 and 10250.
/// 
///   - Each host must allow inbound connection from the EKS cluster control
///     plane on TCP port 10250 for logs, exec and port-forward operations.
/// 
///   - Each host must allow TCP and UDP network connectivity to and from other
///     hosts that are running CoreDNS on UDP port 53 for service and pod DNS
///     names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecRemoteNetworkConfigRemoteNodeNetworks
{
    [JsonPropertyName("cidrs")]
    public IList<string>? Cidrs { get; set; }
}

/// <summary>
/// A network CIDR that can contain pods that run Kubernetes webhooks on hybrid
/// nodes.
/// 
/// These CIDR blocks are determined by configuring your Container Network Interface
/// (CNI) plugin. We recommend the Calico CNI or Cilium CNI. Note that the Amazon
/// VPC CNI plugin for Kubernetes isn&apos;t available for on-premises and edge locations.
/// 
/// Enter one or more IPv4 CIDR blocks in decimal dotted-quad notation (for example,
/// 10.2.0.0/16).
/// 
/// It must satisfy the following requirements:
/// 
///   - Each block must be within an IPv4 RFC-1918 network range. Minimum allowed
///     size is /32, maximum allowed size is /8. Publicly-routable addresses aren&apos;t
///     supported.
/// 
///   - Each block cannot overlap with the range of the VPC CIDR blocks for
///     your EKS resources, or the block of the Kubernetes service IP range.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecRemoteNetworkConfigRemotePodNetworks
{
    [JsonPropertyName("cidrs")]
    public IList<string>? Cidrs { get; set; }
}

/// <summary>
/// The configuration in the cluster for EKS Hybrid Nodes. You can add, change,
/// or remove this configuration after the cluster is created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecRemoteNetworkConfig
{
    [JsonPropertyName("remoteNodeNetworks")]
    public IList<V1alpha1ClusterSpecRemoteNetworkConfigRemoteNodeNetworks>? RemoteNodeNetworks { get; set; }

    [JsonPropertyName("remotePodNetworks")]
    public IList<V1alpha1ClusterSpecRemoteNetworkConfigRemotePodNetworks>? RemotePodNetworks { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecResourcesVPCConfigSecurityGroupRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecResourcesVPCConfigSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecResourcesVPCConfigSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecResourcesVPCConfigSubnetRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecResourcesVPCConfigSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecResourcesVPCConfigSubnetRefsFrom? From { get; set; }
}

/// <summary>
/// The VPC configuration that&apos;s used by the cluster control plane. Amazon EKS
/// VPC resources have specific requirements to work properly with Kubernetes.
/// For more information, see Cluster VPC Considerations (https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html)
/// and Cluster Security Group Considerations (https://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html)
/// in the Amazon EKS User Guide. You must specify at least two subnets. You
/// can specify up to five security groups. However, we recommend that you use
/// a dedicated security group for your cluster control plane.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecResourcesVPCConfig
{
    [JsonPropertyName("endpointPrivateAccess")]
    public bool? EndpointPrivateAccess { get; set; }

    [JsonPropertyName("endpointPublicAccess")]
    public bool? EndpointPublicAccess { get; set; }

    [JsonPropertyName("publicAccessCIDRs")]
    public IList<string>? PublicAccessCIDRs { get; set; }

    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    /// <summary>Reference field for SecurityGroupIDs</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1ClusterSpecResourcesVPCConfigSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    [JsonPropertyName("subnetIDs")]
    public IList<string>? SubnetIDs { get; set; }

    /// <summary>Reference field for SubnetIDs</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1ClusterSpecResourcesVPCConfigSubnetRefs>? SubnetRefs { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecRoleRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecRoleRefFrom? From { get; set; }
}

/// <summary>
/// Indicates the current configuration of the block storage capability on your
/// EKS Auto Mode cluster. For example, if the capability is enabled or disabled.
/// If the block storage capability is enabled, EKS Auto Mode will create and
/// delete EBS volumes in your Amazon Web Services account. For more information,
/// see EKS Auto Mode block storage capability in the Amazon EKS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecStorageConfigBlockStorage
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Enable or disable the block storage capability of EKS Auto Mode when creating
/// your EKS Auto Mode cluster. If the block storage capability is enabled, EKS
/// Auto Mode will create and delete EBS volumes in your Amazon Web Services
/// account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecStorageConfig
{
    /// <summary>
    /// Indicates the current configuration of the block storage capability on your
    /// EKS Auto Mode cluster. For example, if the capability is enabled or disabled.
    /// If the block storage capability is enabled, EKS Auto Mode will create and
    /// delete EBS volumes in your Amazon Web Services account. For more information,
    /// see EKS Auto Mode block storage capability in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("blockStorage")]
    public V1alpha1ClusterSpecStorageConfigBlockStorage? BlockStorage { get; set; }
}

/// <summary>
/// New clusters, by default, have extended support enabled. You can disable
/// extended support when creating a cluster by setting this value to STANDARD.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecUpgradePolicy
{
    [JsonPropertyName("supportType")]
    public string? SupportType { get; set; }
}

/// <summary>
/// Enable or disable ARC zonal shift for the cluster. If zonal shift is enabled,
/// Amazon Web Services configures zonal autoshift for the cluster.
/// 
/// Zonal shift is a feature of Amazon Application Recovery Controller (ARC).
/// ARC zonal shift is designed to be a temporary measure that allows you to
/// move traffic for a resource away from an impaired AZ until the zonal shift
/// expires or you cancel it. You can extend the zonal shift if necessary.
/// 
/// You can start a zonal shift for an Amazon EKS cluster, or you can allow Amazon
/// Web Services to do it for you by enabling zonal autoshift. This shift updates
/// the flow of east-to-west network traffic in your cluster to only consider
/// network endpoints for Pods running on worker nodes in healthy AZs. Additionally,
/// any ALB or NLB handling ingress traffic for applications in your Amazon EKS
/// cluster will automatically route traffic to targets in the healthy AZs. For
/// more information about zonal shift in EKS, see Learn about Amazon Application
/// Recovery Controller (ARC) Zonal Shift in Amazon EKS (https://docs.aws.amazon.com/eks/latest/userguide/zone-shift.html)
/// in the Amazon EKS User Guide .
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecZonalShiftConfig
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// ClusterSpec defines the desired state of Cluster.
/// 
/// An object representing an Amazon EKS cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpec
{
    /// <summary>The access configuration for the cluster.</summary>
    [JsonPropertyName("accessConfig")]
    public V1alpha1ClusterSpecAccessConfig? AccessConfig { get; set; }

    /// <summary>
    /// If you set this value to False when creating a cluster, the default networking
    /// add-ons will not be installed.
    /// 
    /// The default networking add-ons include vpc-cni, coredns, and kube-proxy.
    /// 
    /// Use this option when you plan to install third-party alternative add-ons
    /// or self-manage the default networking add-ons.
    /// </summary>
    [JsonPropertyName("bootstrapSelfManagedAddons")]
    public bool? BootstrapSelfManagedAddons { get; set; }

    /// <summary>
    /// A unique, case-sensitive identifier that you provide to ensurethe idempotency
    /// of the request.
    /// </summary>
    [JsonPropertyName("clientRequestToken")]
    public string? ClientRequestToken { get; set; }

    /// <summary>
    /// Enable or disable the compute capability of EKS Auto Mode when creating your
    /// EKS Auto Mode cluster. If the compute capability is enabled, EKS Auto Mode
    /// will create and delete EC2 Managed Instances in your Amazon Web Services
    /// account
    /// </summary>
    [JsonPropertyName("computeConfig")]
    public V1alpha1ClusterSpecComputeConfig? ComputeConfig { get; set; }

    /// <summary>The encryption configuration for the cluster.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1alpha1ClusterSpecEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>The Kubernetes network configuration for the cluster.</summary>
    [JsonPropertyName("kubernetesNetworkConfig")]
    public V1alpha1ClusterSpecKubernetesNetworkConfig? KubernetesNetworkConfig { get; set; }

    /// <summary>
    /// Enable or disable exporting the Kubernetes control plane logs for your cluster
    /// to CloudWatch Logs . By default, cluster control plane logs aren&apos;t exported
    /// to CloudWatch Logs . For more information, see Amazon EKS Cluster control
    /// plane logs (https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html)
    /// in the Amazon EKS User Guide .
    /// 
    /// CloudWatch Logs ingestion, archive storage, and data scanning rates apply
    /// to exported control plane logs. For more information, see CloudWatch Pricing
    /// (http://aws.amazon.com/cloudwatch/pricing/).
    /// </summary>
    [JsonPropertyName("logging")]
    public V1alpha1ClusterSpecLogging? Logging { get; set; }

    /// <summary>
    /// The unique name to give to your cluster. The name can contain only alphanumeric
    /// characters (case-sensitive),hyphens, and underscores. It must start with
    /// an alphanumeric character and can&apos;t be longer than100 characters. The name
    /// must be unique within the Amazon Web Services Region and Amazon Web Services
    /// account that you&apos;re creating the cluster in.
    /// 
    /// Regex Pattern: `^[0-9A-Za-z][A-Za-z0-9\-_]*$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// An object representing the configuration of your local Amazon EKS cluster
    /// on an Amazon Web Services Outpost. Before creating a local cluster on an
    /// Outpost, review Local clusters for Amazon EKS on Amazon Web Services Outposts
    /// (https://docs.aws.amazon.com/eks/latest/userguide/eks-outposts-local-cluster-overview.html)
    /// in the Amazon EKS User Guide. This object isn&apos;t available for creating Amazon
    /// EKS clusters on the Amazon Web Services cloud.
    /// </summary>
    [JsonPropertyName("outpostConfig")]
    public V1alpha1ClusterSpecOutpostConfig? OutpostConfig { get; set; }

    /// <summary>
    /// The configuration in the cluster for EKS Hybrid Nodes. You can add, change,
    /// or remove this configuration after the cluster is created.
    /// </summary>
    [JsonPropertyName("remoteNetworkConfig")]
    public V1alpha1ClusterSpecRemoteNetworkConfig? RemoteNetworkConfig { get; set; }

    /// <summary>
    /// The VPC configuration that&apos;s used by the cluster control plane. Amazon EKS
    /// VPC resources have specific requirements to work properly with Kubernetes.
    /// For more information, see Cluster VPC Considerations (https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html)
    /// and Cluster Security Group Considerations (https://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html)
    /// in the Amazon EKS User Guide. You must specify at least two subnets. You
    /// can specify up to five security groups. However, we recommend that you use
    /// a dedicated security group for your cluster control plane.
    /// </summary>
    [JsonPropertyName("resourcesVPCConfig")]
    public required V1alpha1ClusterSpecResourcesVPCConfig ResourcesVPCConfig { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the IAM role that provides permissions
    /// for the Kubernetes control plane to make calls to Amazon Web Services API
    /// operations on your behalf. For more information, see Amazon EKS Service IAM
    /// Role (https://docs.aws.amazon.com/eks/latest/userguide/service_IAM_role.html)
    /// in the Amazon EKS User Guide .
    /// </summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("roleRef")]
    public V1alpha1ClusterSpecRoleRef? RoleRef { get; set; }

    /// <summary>
    /// Enable or disable the block storage capability of EKS Auto Mode when creating
    /// your EKS Auto Mode cluster. If the block storage capability is enabled, EKS
    /// Auto Mode will create and delete EBS volumes in your Amazon Web Services
    /// account.
    /// </summary>
    [JsonPropertyName("storageConfig")]
    public V1alpha1ClusterSpecStorageConfig? StorageConfig { get; set; }

    /// <summary>
    /// Metadata that assists with categorization and organization. Each tag consists
    /// of a key and an optional value. You define both. Tags don&apos;t propagate to
    /// any other cluster or Amazon Web Services resources.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// New clusters, by default, have extended support enabled. You can disable
    /// extended support when creating a cluster by setting this value to STANDARD.
    /// </summary>
    [JsonPropertyName("upgradePolicy")]
    public V1alpha1ClusterSpecUpgradePolicy? UpgradePolicy { get; set; }

    /// <summary>
    /// The desired Kubernetes version for your cluster. If you don&apos;t specify a value
    /// here, the default version available in Amazon EKS is used.
    /// 
    /// The default version might not be the latest version available.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// Enable or disable ARC zonal shift for the cluster. If zonal shift is enabled,
    /// Amazon Web Services configures zonal autoshift for the cluster.
    /// 
    /// Zonal shift is a feature of Amazon Application Recovery Controller (ARC).
    /// ARC zonal shift is designed to be a temporary measure that allows you to
    /// move traffic for a resource away from an impaired AZ until the zonal shift
    /// expires or you cancel it. You can extend the zonal shift if necessary.
    /// 
    /// You can start a zonal shift for an Amazon EKS cluster, or you can allow Amazon
    /// Web Services to do it for you by enabling zonal autoshift. This shift updates
    /// the flow of east-to-west network traffic in your cluster to only consider
    /// network endpoints for Pods running on worker nodes in healthy AZs. Additionally,
    /// any ALB or NLB handling ingress traffic for applications in your Amazon EKS
    /// cluster will automatically route traffic to targets in the healthy AZs. For
    /// more information about zonal shift in EKS, see Learn about Amazon Application
    /// Recovery Controller (ARC) Zonal Shift in Amazon EKS (https://docs.aws.amazon.com/eks/latest/userguide/zone-shift.html)
    /// in the Amazon EKS User Guide .
    /// </summary>
    [JsonPropertyName("zonalShiftConfig")]
    public V1alpha1ClusterSpecZonalShiftConfig? ZonalShiftConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>The certificate-authority-data for your cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusCertificateAuthority
{
    [JsonPropertyName("data")]
    public string? Data { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>The configuration used to connect to a cluster for registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusConnectorConfig
{
    [JsonPropertyName("activationCode")]
    public string? ActivationCode { get; set; }

    [JsonPropertyName("activationExpiry")]
    public DateTime? ActivationExpiry { get; set; }

    [JsonPropertyName("activationID")]
    public string? ActivationID { get; set; }

    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }
}

/// <summary>An issue with your Amazon EKS cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusHealthIssues
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("resourceIDs")]
    public IList<string>? ResourceIDs { get; set; }
}

/// <summary>An object representing the health of your Amazon EKS cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusHealth
{
    [JsonPropertyName("issues")]
    public IList<V1alpha1ClusterStatusHealthIssues>? Issues { get; set; }
}

/// <summary>
/// An object representing the OpenID Connect (https://openid.net/connect/) (OIDC)
/// identity provider information for the cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusIdentityOidc
{
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>The identity provider information for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusIdentity
{
    /// <summary>
    /// An object representing the OpenID Connect (https://openid.net/connect/) (OIDC)
    /// identity provider information for the cluster.
    /// </summary>
    [JsonPropertyName("oidc")]
    public V1alpha1ClusterStatusIdentityOidc? Oidc { get; set; }
}

/// <summary>ClusterStatus defines the observed state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ClusterStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The certificate-authority-data for your cluster.</summary>
    [JsonPropertyName("certificateAuthority")]
    public V1alpha1ClusterStatusCertificateAuthority? CertificateAuthority { get; set; }

    /// <summary>
    /// The cluster security group that was created by Amazon EKS for the cluster.
    /// Managed node groups use this security group for control-plane-to-data-plane
    /// communication.
    /// </summary>
    [JsonPropertyName("clusterSecurityGroupID")]
    public string? ClusterSecurityGroupID { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>The configuration used to connect to a cluster for registration.</summary>
    [JsonPropertyName("connectorConfig")]
    public V1alpha1ClusterStatusConnectorConfig? ConnectorConfig { get; set; }

    /// <summary>The Unix epoch timestamp at object creation.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>The endpoint for your Kubernetes API server.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>An object representing the health of your Amazon EKS cluster.</summary>
    [JsonPropertyName("health")]
    public V1alpha1ClusterStatusHealth? Health { get; set; }

    /// <summary>
    /// The ID of your local Amazon EKS cluster on an Amazon Web Services Outpost.
    /// This property isn&apos;t available for an Amazon EKS cluster on the Amazon Web
    /// Services cloud.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The identity provider information for the cluster.</summary>
    [JsonPropertyName("identity")]
    public V1alpha1ClusterStatusIdentity? Identity { get; set; }

    /// <summary>
    /// The platform version of your Amazon EKS cluster. For more information about
    /// clusters deployed on the Amazon Web Services Cloud, see Platform versions
    /// (https://docs.aws.amazon.com/eks/latest/userguide/platform-versions.html)
    /// in the Amazon EKS User Guide . For more information about local clusters
    /// deployed on an Outpost, see Amazon EKS local cluster platform versions (https://docs.aws.amazon.com/eks/latest/userguide/eks-outposts-platform-versions.html)
    /// in the Amazon EKS User Guide .
    /// </summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>The current status of the cluster.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterSpec?>, IStatus<V1alpha1ClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "eks.services.k8s.aws";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Cluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ClusterSpec defines the desired state of Cluster.
    /// 
    /// An object representing an Amazon EKS cluster.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ClusterSpec? Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1ClusterStatus? Status { get; set; }
}