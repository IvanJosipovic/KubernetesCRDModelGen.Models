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
/// <summary>Nodegroup is the Schema for the Nodegroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NodegroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Nodegroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NodegroupList";
    public const string KubeGroup = "eks.services.k8s.aws";
    public const string KubePluralName = "nodegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NodegroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Nodegroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Nodegroup> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecClusterRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecClusterRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1NodegroupSpecClusterRefFrom? From { get; set; }
}

/// <summary>
/// An object representing a node group&apos;s launch template specification. When
/// using this object, don&apos;t directly specify instanceTypes, diskSize, or remoteAccess.
/// You cannot later specify a different launch template ID or name than what
/// was used to create the node group.
/// 
/// Make sure that the launch template meets the requirements in launchTemplateSpecification.
/// Also refer to Customizing managed nodes with launch templates (https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html)
/// in the Amazon EKS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecLaunchTemplate
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecNodeRoleRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecNodeRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1NodegroupSpecNodeRoleRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecRemoteAccessSourceSecurityGroupRefsFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecRemoteAccessSourceSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1NodegroupSpecRemoteAccessSourceSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// The remote access configuration to use with your node group. For Linux, the
/// protocol is SSH. For Windows, the protocol is RDP. If you specify launchTemplate,
/// then don&apos;t specify remoteAccess, or the node group deployment will fail.
/// For more information about using launch templates with Amazon EKS, see Customizing
/// managed nodes with launch templates (https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html)
/// in the Amazon EKS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecRemoteAccess
{
    [JsonPropertyName("ec2SshKey")]
    public string? Ec2SshKey { get; set; }

    /// <summary>Reference field for SourceSecurityGroups</summary>
    [JsonPropertyName("sourceSecurityGroupRefs")]
    public IList<V1alpha1NodegroupSpecRemoteAccessSourceSecurityGroupRefs>? SourceSecurityGroupRefs { get; set; }

    [JsonPropertyName("sourceSecurityGroups")]
    public IList<string>? SourceSecurityGroups { get; set; }
}

/// <summary>
/// The scaling configuration details for the Auto Scaling group that is created
/// for your node group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecScalingConfig
{
    [JsonPropertyName("desiredSize")]
    public long? DesiredSize { get; set; }

    [JsonPropertyName("maxSize")]
    public long? MaxSize { get; set; }

    [JsonPropertyName("minSize")]
    public long? MinSize { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecSubnetRefsFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1NodegroupSpecSubnetRefsFrom? From { get; set; }
}

/// <summary>
/// A property that allows a node to repel a Pod. For more information, see Node
/// taints on managed node groups (https://docs.aws.amazon.com/eks/latest/userguide/node-taints-managed-node-groups.html)
/// in the Amazon EKS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecTaints
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The node group update configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpecUpdateConfig
{
    [JsonPropertyName("maxUnavailable")]
    public long? MaxUnavailable { get; set; }

    [JsonPropertyName("maxUnavailablePercentage")]
    public long? MaxUnavailablePercentage { get; set; }
}

/// <summary>
/// NodegroupSpec defines the desired state of Nodegroup.
/// 
/// An object representing an Amazon EKS managed node group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupSpec
{
    /// <summary>
    /// The AMI type for your node group. If you specify launchTemplate, and your
    /// launch template uses a custom AMI, then don&apos;t specify amiType, or the node
    /// group deployment will fail. If your launch template uses a Windows custom
    /// AMI, then add eks:kube-proxy-windows to your Windows nodes rolearn in the
    /// aws-auth ConfigMap. For more information about using launch templates with
    /// Amazon EKS, see Customizing managed nodes with launch templates (https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("amiType")]
    public string? AmiType { get; set; }

    /// <summary>The capacity type for your node group.</summary>
    [JsonPropertyName("capacityType")]
    public string? CapacityType { get; set; }

    /// <summary>
    /// A unique, case-sensitive identifier that you provide to ensurethe idempotency
    /// of the request.
    /// </summary>
    [JsonPropertyName("clientRequestToken")]
    public string? ClientRequestToken { get; set; }

    /// <summary>The name of your cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("clusterRef")]
    public V1alpha1NodegroupSpecClusterRef? ClusterRef { get; set; }

    /// <summary>
    /// The root device disk size (in GiB) for your node group instances. The default
    /// disk size is 20 GiB for Linux and Bottlerocket. The default disk size is
    /// 50 GiB for Windows. If you specify launchTemplate, then don&apos;t specify diskSize,
    /// or the node group deployment will fail. For more information about using
    /// launch templates with Amazon EKS, see Customizing managed nodes with launch
    /// templates (https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("diskSize")]
    public long? DiskSize { get; set; }

    /// <summary>
    /// Specify the instance types for a node group. If you specify a GPU instance
    /// type, make sure to also specify an applicable GPU AMI type with the amiType
    /// parameter. If you specify launchTemplate, then you can specify zero or one
    /// instance type in your launch template or you can specify 0-20 instance types
    /// for instanceTypes. If however, you specify an instance type in your launch
    /// template and specify any instanceTypes, the node group deployment will fail.
    /// If you don&apos;t specify an instance type in a launch template or for instanceTypes,
    /// then t3.medium is used, by default. If you specify Spot for capacityType,
    /// then we recommend specifying multiple values for instanceTypes. For more
    /// information, see Managed node group capacity types (https://docs.aws.amazon.com/eks/latest/userguide/managed-node-groups.html#managed-node-group-capacity-types)
    /// and Customizing managed nodes with launch templates (https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("instanceTypes")]
    public IList<string>? InstanceTypes { get; set; }

    /// <summary>
    /// The Kubernetes labels to apply to the nodes in the node group when they are
    /// created.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// An object representing a node group&apos;s launch template specification. When
    /// using this object, don&apos;t directly specify instanceTypes, diskSize, or remoteAccess.
    /// You cannot later specify a different launch template ID or name than what
    /// was used to create the node group.
    /// 
    /// Make sure that the launch template meets the requirements in launchTemplateSpecification.
    /// Also refer to Customizing managed nodes with launch templates (https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("launchTemplate")]
    public V1alpha1NodegroupSpecLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>The unique name to give your node group.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the IAM role to associate with your node
    /// group. The Amazon EKS worker node kubelet daemon makes calls to Amazon Web
    /// Services APIs on your behalf. Nodes receive permissions for these API calls
    /// through an IAM instance profile and associated policies. Before you can launch
    /// nodes and register them into a cluster, you must create an IAM role for those
    /// nodes to use when they are launched. For more information, see Amazon EKS
    /// node IAM role (https://docs.aws.amazon.com/eks/latest/userguide/create-node-role.html)
    /// in the Amazon EKS User Guide . If you specify launchTemplate, then don&apos;t
    /// specify IamInstanceProfile (https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_IamInstanceProfile.html)
    /// in your launch template, or the node group deployment will fail. For more
    /// information about using launch templates with Amazon EKS, see Customizing
    /// managed nodes with launch templates (https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("nodeRole")]
    public string? NodeRole { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("nodeRoleRef")]
    public V1alpha1NodegroupSpecNodeRoleRef? NodeRoleRef { get; set; }

    /// <summary>
    /// The AMI version of the Amazon EKS optimized AMI to use with your node group.
    /// By default, the latest available AMI version for the node group&apos;s current
    /// Kubernetes version is used. For information about Linux versions, see Amazon
    /// EKS optimized Amazon Linux AMI versions (https://docs.aws.amazon.com/eks/latest/userguide/eks-linux-ami-versions.html)
    /// in the Amazon EKS User Guide. Amazon EKS managed node groups support the
    /// November 2022 and later releases of the Windows AMIs. For information about
    /// Windows versions, see Amazon EKS optimized Windows AMI versions (https://docs.aws.amazon.com/eks/latest/userguide/eks-ami-versions-windows.html)
    /// in the Amazon EKS User Guide.
    /// 
    /// If you specify launchTemplate, and your launch template uses a custom AMI,
    /// then don&apos;t specify releaseVersion, or the node group deployment will fail.
    /// For more information about using launch templates with Amazon EKS, see Customizing
    /// managed nodes with launch templates (https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("releaseVersion")]
    public string? ReleaseVersion { get; set; }

    /// <summary>
    /// The remote access configuration to use with your node group. For Linux, the
    /// protocol is SSH. For Windows, the protocol is RDP. If you specify launchTemplate,
    /// then don&apos;t specify remoteAccess, or the node group deployment will fail.
    /// For more information about using launch templates with Amazon EKS, see Customizing
    /// managed nodes with launch templates (https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("remoteAccess")]
    public V1alpha1NodegroupSpecRemoteAccess? RemoteAccess { get; set; }

    /// <summary>
    /// The scaling configuration details for the Auto Scaling group that is created
    /// for your node group.
    /// </summary>
    [JsonPropertyName("scalingConfig")]
    public V1alpha1NodegroupSpecScalingConfig? ScalingConfig { get; set; }

    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1NodegroupSpecSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>
    /// The subnets to use for the Auto Scaling group that is created for your node
    /// group. If you specify launchTemplate, then don&apos;t specify SubnetId (https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateNetworkInterface.html)
    /// in your launch template, or the node group deployment will fail. For more
    /// information about using launch templates with Amazon EKS, see Customizing
    /// managed nodes with launch templates (https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>
    /// Metadata that assists with categorization and organization. Each tag consists
    /// of a key and an optional value. You define both. Tags don&apos;t propagate to
    /// any other cluster or Amazon Web Services resources.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The Kubernetes taints to be applied to the nodes in the node group. For more
    /// information, see Node taints on managed node groups (https://docs.aws.amazon.com/eks/latest/userguide/node-taints-managed-node-groups.html).
    /// </summary>
    [JsonPropertyName("taints")]
    public IList<V1alpha1NodegroupSpecTaints>? Taints { get; set; }

    /// <summary>The node group update configuration.</summary>
    [JsonPropertyName("updateConfig")]
    public V1alpha1NodegroupSpecUpdateConfig? UpdateConfig { get; set; }

    /// <summary>
    /// The Kubernetes version to use for your managed nodes. By default, the Kubernetes
    /// version of the cluster is used, and this is the only accepted specified value.
    /// If you specify launchTemplate, and your launch template uses a custom AMI,
    /// then don&apos;t specify version, or the node group deployment will fail. For more
    /// information about using launch templates with Amazon EKS, see Customizing
    /// managed nodes with launch templates (https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html)
    /// in the Amazon EKS User Guide.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupStatusAckResourceMetadata
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

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupStatusConditions
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

/// <summary>An object representing an issue with an Amazon EKS resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupStatusHealthIssues
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("resourceIDs")]
    public IList<string>? ResourceIDs { get; set; }
}

/// <summary>
/// The health status of the node group. If there are issues with your node group&apos;s
/// health, they are listed here.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupStatusHealth
{
    [JsonPropertyName("issues")]
    public IList<V1alpha1NodegroupStatusHealthIssues>? Issues { get; set; }
}

/// <summary>
/// An Auto Scaling group that is associated with an Amazon EKS managed node
/// group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupStatusResourcesAutoScalingGroups
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The resources associated with the node group, such as Auto Scaling groups
/// and security groups for remote access.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupStatusResources
{
    [JsonPropertyName("autoScalingGroups")]
    public IList<V1alpha1NodegroupStatusResourcesAutoScalingGroups>? AutoScalingGroups { get; set; }

    [JsonPropertyName("remoteAccessSecurityGroup")]
    public string? RemoteAccessSecurityGroup { get; set; }
}

/// <summary>NodegroupStatus defines the observed state of Nodegroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NodegroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1NodegroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NodegroupStatusConditions>? Conditions { get; set; }

    /// <summary>The Unix epoch timestamp at object creation.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("desiredSize")]
    public long? DesiredSize { get; set; }

    /// <summary>
    /// The health status of the node group. If there are issues with your node group&apos;s
    /// health, they are listed here.
    /// </summary>
    [JsonPropertyName("health")]
    public V1alpha1NodegroupStatusHealth? Health { get; set; }

    /// <summary>The Unix epoch timestamp for the last modification to the object.</summary>
    [JsonPropertyName("modifiedAt")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The resources associated with the node group, such as Auto Scaling groups
    /// and security groups for remote access.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1alpha1NodegroupStatusResources? Resources { get; set; }

    /// <summary>The current status of the managed node group.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Nodegroup is the Schema for the Nodegroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Nodegroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NodegroupSpec?>, IStatus<V1alpha1NodegroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Nodegroup";
    public const string KubeGroup = "eks.services.k8s.aws";
    public const string KubePluralName = "nodegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Nodegroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// NodegroupSpec defines the desired state of Nodegroup.
    /// 
    /// An object representing an Amazon EKS managed node group.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1NodegroupSpec? Spec { get; set; }

    /// <summary>NodegroupStatus defines the observed state of Nodegroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1NodegroupStatus? Status { get; set; }
}