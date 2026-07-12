#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.services.k8s.aws;
/// <summary>NotebookInstance is the Schema for the NotebookInstances API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NotebookInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NotebookInstance>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NotebookInstanceList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "notebookinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NotebookInstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NotebookInstance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NotebookInstance> Items { get; set; }
}

/// <summary>
/// A tag object that consists of a key and an optional value, used to manage
/// metadata for SageMaker Amazon Web Services resources.
/// 
/// You can add tags to notebook instances, training jobs, hyperparameter tuning
/// jobs, batch transform jobs, models, labeling jobs, work teams, endpoint configurations,
/// and endpoints. For more information on adding tags to SageMaker resources,
/// see AddTags (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AddTags.html).
/// 
/// For more information on adding metadata to your Amazon Web Services resources
/// with tagging, see Tagging Amazon Web Services resources (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html).
/// For advice on best practices for managing Amazon Web Services resources with
/// tagging, see Tagging Best Practices: Implement an Effective Amazon Web Services
/// Resource Tagging Strategy (https://d1.awsstatic.com/whitepapers/aws-tagging-best-practices.pdf).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebookInstanceSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>NotebookInstanceSpec defines the desired state of NotebookInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebookInstanceSpec
{
    /// <summary>
    /// This parameter is no longer supported. Elastic Inference (EI) is no longer
    /// available.
    /// 
    /// This parameter was used to specify a list of EI instance types to associate
    /// with this notebook instance.
    /// </summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>
    /// An array of up to three Git repositories to associate with the notebook instance.
    /// These can be either the names of Git repositories stored as resources in
    /// your account, or the URL of Git repositories in Amazon Web Services CodeCommit
    /// (https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html) or
    /// in any other Git repository. These repositories are cloned at the same level
    /// as the default repository of your notebook instance. For more information,
    /// see Associating Git Repositories with SageMaker AI Notebook Instances (https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html).
    /// </summary>
    [JsonPropertyName("additionalCodeRepositories")]
    public IList<string>? AdditionalCodeRepositories { get; set; }

    /// <summary>
    /// A Git repository to associate with the notebook instance as its default code
    /// repository. This can be either the name of a Git repository stored as a resource
    /// in your account, or the URL of a Git repository in Amazon Web Services CodeCommit
    /// (https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html) or
    /// in any other Git repository. When you open a notebook instance, it opens
    /// in the directory that contains this repository. For more information, see
    /// Associating Git Repositories with SageMaker AI Notebook Instances (https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html).
    /// 
    /// Regex Pattern: `^https://([^/]+)/?(.*)$|^[a-zA-Z0-9](-*[a-zA-Z0-9])*$`
    /// </summary>
    [JsonPropertyName("defaultCodeRepository")]
    public string? DefaultCodeRepository { get; set; }

    /// <summary>
    /// Sets whether SageMaker AI provides internet access to the notebook instance.
    /// If you set this to Disabled this notebook instance is able to access resources
    /// only in your VPC, and is not be able to connect to SageMaker AI training
    /// and endpoint services unless you configure a NAT Gateway in your VPC.
    /// 
    /// For more information, see Notebook Instances Are Internet-Enabled by Default
    /// (https://docs.aws.amazon.com/sagemaker/latest/dg/appendix-additional-considerations.html#appendix-notebook-and-internet-access).
    /// You can set the value of this parameter to Disabled only if you set a value
    /// for the SubnetId parameter.
    /// </summary>
    [JsonPropertyName("directInternetAccess")]
    public string? DirectInternetAccess { get; set; }

    /// <summary>The type of ML compute instance to launch for the notebook instance.</summary>
    [JsonPropertyName("instanceType")]
    public required string InstanceType { get; set; }

    /// <summary>
    /// The IP address type for the notebook instance. Specify ipv4 for IPv4-only
    /// connectivity or dualstack for both IPv4 and IPv6 connectivity. When you specify
    /// dualstack, the subnet must support IPv6 CIDR blocks. If not specified, defaults
    /// to ipv4.
    /// </summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of a Amazon Web Services Key Management Service
    /// key that SageMaker AI uses to encrypt data on the storage volume attached
    /// to your notebook instance. The KMS key you provide must be enabled. For information,
    /// see Enabling and Disabling Keys (https://docs.aws.amazon.com/kms/latest/developerguide/enabling-keys.html)
    /// in the Amazon Web Services Key Management Service Developer Guide.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9:/_-]*$`
    /// </summary>
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>
    /// The name of a lifecycle configuration to associate with the notebook instance.
    /// For information about lifestyle configurations, see Step 2.1: (Optional)
    /// Customize a Notebook Instance (https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html).
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9])*$`
    /// </summary>
    [JsonPropertyName("lifecycleConfigName")]
    public string? LifecycleConfigName { get; set; }

    /// <summary>
    /// The name of the new notebook instance.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9])*$`
    /// </summary>
    [JsonPropertyName("notebookInstanceName")]
    public required string NotebookInstanceName { get; set; }

    /// <summary>
    /// The platform identifier of the notebook instance runtime environment.
    /// 
    /// Regex Pattern: `^(notebook-al1-v1|notebook-al2-v1|notebook-al2-v2|notebook-al2-v3|notebook-al2023-v1)$`
    /// </summary>
    [JsonPropertyName("platformIdentifier")]
    public string? PlatformIdentifier { get; set; }

    /// <summary>
    /// When you send any requests to Amazon Web Services resources from the notebook
    /// instance, SageMaker AI assumes this role to perform tasks on your behalf.
    /// You must grant this role necessary permissions so SageMaker AI can perform
    /// these tasks. The policy must allow the SageMaker AI service principal (sagemaker.amazonaws.com)
    /// permissions to assume this role. For more information, see SageMaker AI Roles
    /// (https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html).
    /// 
    /// To be able to pass this role to SageMaker AI, the caller of this API must
    /// have the iam:PassRole permission.
    /// 
    /// Regex Pattern: `^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,.@\-_/]+$`
    /// </summary>
    [JsonPropertyName("roleARN")]
    public required string RoleARN { get; set; }

    /// <summary>
    /// Whether root access is enabled or disabled for users of the notebook instance.
    /// The default value is Enabled.
    /// 
    /// Lifecycle configurations need root access to be able to set up a notebook
    /// instance. Because of this, lifecycle configurations associated with a notebook
    /// instance always run with root access even if you disable root access for
    /// users.
    /// </summary>
    [JsonPropertyName("rootAccess")]
    public string? RootAccess { get; set; }

    /// <summary>
    /// The VPC security group IDs, in the form sg-xxxxxxxx. The security groups
    /// must be for the same VPC as specified in the subnet.
    /// </summary>
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    /// <summary>
    /// The ID of the subnet in a VPC to which you would like to have a connectivity
    /// from your ML compute instance.
    /// 
    /// Regex Pattern: `^[-0-9a-zA-Z]+$`
    /// </summary>
    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }

    /// <summary>
    /// An array of key-value pairs. You can use tags to categorize your Amazon Web
    /// Services resources in different ways, for example, by purpose, owner, or
    /// environment. For more information, see Tagging Amazon Web Services Resources
    /// (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html).
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1NotebookInstanceSpecTags>? Tags { get; set; }

    /// <summary>
    /// The size, in GB, of the ML storage volume to attach to the notebook instance.
    /// The default value is 5 GB.
    /// </summary>
    [JsonPropertyName("volumeSizeInGB")]
    public long? VolumeSizeInGB { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebookInstanceStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebookInstanceStatusConditions
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

/// <summary>NotebookInstanceStatus defines the observed state of NotebookInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebookInstanceStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1NotebookInstanceStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NotebookInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>If status is Failed, the reason it failed.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>The status of the notebook instance.</summary>
    [JsonPropertyName("notebookInstanceStatus")]
    public string? NotebookInstanceStatus { get; set; }

    /// <summary>
    /// The URL that you use to connect to the Jupyter notebook that is running in
    /// your notebook instance.
    /// </summary>
    [JsonPropertyName("stoppedByControllerMetadata")]
    public string? StoppedByControllerMetadata { get; set; }

    /// <summary>
    /// The URL that you use to connect to the Jupyter notebook that is running in
    /// your notebook instance.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>NotebookInstance is the Schema for the NotebookInstances API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NotebookInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NotebookInstanceSpec?>, IStatus<V1alpha1NotebookInstanceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NotebookInstance";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "notebookinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NotebookInstance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NotebookInstanceSpec defines the desired state of NotebookInstance.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1NotebookInstanceSpec? Spec { get; set; }

    /// <summary>NotebookInstanceStatus defines the observed state of NotebookInstance</summary>
    [JsonPropertyName("status")]
    public V1alpha1NotebookInstanceStatus? Status { get; set; }
}