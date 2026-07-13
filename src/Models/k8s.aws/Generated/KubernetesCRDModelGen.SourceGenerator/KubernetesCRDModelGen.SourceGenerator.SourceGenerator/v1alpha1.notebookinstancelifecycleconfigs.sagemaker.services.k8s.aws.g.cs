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
/// <summary>NotebookInstanceLifecycleConfig is the Schema for the NotebookInstanceLifecycleConfigs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NotebookInstanceLifecycleConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NotebookInstanceLifecycleConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NotebookInstanceLifecycleConfigList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "notebookinstancelifecycleconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NotebookInstanceLifecycleConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NotebookInstanceLifecycleConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NotebookInstanceLifecycleConfig> Items { get; set; }
}

/// <summary>
/// Contains the notebook instance lifecycle configuration script.
/// 
/// Each lifecycle configuration script has a limit of 16384 characters.
/// 
/// The value of the $PATH environment variable that is available to both scripts
/// is /sbin:bin:/usr/sbin:/usr/bin.
/// 
/// View Amazon CloudWatch Logs for notebook instance lifecycle configurations
/// in log group /aws/sagemaker/NotebookInstances in log stream [notebook-instance-name]/[LifecycleConfigHook].
/// 
/// Lifecycle configuration scripts cannot run for longer than 5 minutes. If
/// a script runs for longer than 5 minutes, it fails and the notebook instance
/// is not created or started.
/// 
/// For information about notebook instance lifestyle configurations, see Step
/// 2.1: (Optional) Customize a Notebook Instance (https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebookInstanceLifecycleConfigSpecOnCreate
{
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}

/// <summary>
/// Contains the notebook instance lifecycle configuration script.
/// 
/// Each lifecycle configuration script has a limit of 16384 characters.
/// 
/// The value of the $PATH environment variable that is available to both scripts
/// is /sbin:bin:/usr/sbin:/usr/bin.
/// 
/// View Amazon CloudWatch Logs for notebook instance lifecycle configurations
/// in log group /aws/sagemaker/NotebookInstances in log stream [notebook-instance-name]/[LifecycleConfigHook].
/// 
/// Lifecycle configuration scripts cannot run for longer than 5 minutes. If
/// a script runs for longer than 5 minutes, it fails and the notebook instance
/// is not created or started.
/// 
/// For information about notebook instance lifestyle configurations, see Step
/// 2.1: (Optional) Customize a Notebook Instance (https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebookInstanceLifecycleConfigSpecOnStart
{
    [JsonPropertyName("content")]
    public string? Content { get; set; }
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
public partial class V1alpha1NotebookInstanceLifecycleConfigSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>NotebookInstanceLifecycleConfigSpec defines the desired state of NotebookInstanceLifecycleConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebookInstanceLifecycleConfigSpec
{
    /// <summary>
    /// The name of the lifecycle configuration.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9])*$`
    /// </summary>
    [JsonPropertyName("notebookInstanceLifecycleConfigName")]
    public required string NotebookInstanceLifecycleConfigName { get; set; }

    /// <summary>
    /// A shell script that runs only once, when you create a notebook instance.
    /// The shell script must be a base64-encoded string.
    /// </summary>
    [JsonPropertyName("onCreate")]
    public IList<V1alpha1NotebookInstanceLifecycleConfigSpecOnCreate>? OnCreate { get; set; }

    /// <summary>
    /// A shell script that runs every time you start a notebook instance, including
    /// when you create the notebook instance. The shell script must be a base64-encoded
    /// string.
    /// </summary>
    [JsonPropertyName("onStart")]
    public IList<V1alpha1NotebookInstanceLifecycleConfigSpecOnStart>? OnStart { get; set; }

    /// <summary>
    /// An array of key-value pairs. You can use tags to categorize your Amazon Web
    /// Services resources in different ways, for example, by purpose, owner, or
    /// environment. For more information, see Tagging Amazon Web Services Resources
    /// (https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html).
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1NotebookInstanceLifecycleConfigSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebookInstanceLifecycleConfigStatusAckResourceMetadata
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
public partial class V1alpha1NotebookInstanceLifecycleConfigStatusConditions
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

/// <summary>NotebookInstanceLifecycleConfigStatus defines the observed state of NotebookInstanceLifecycleConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NotebookInstanceLifecycleConfigStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1NotebookInstanceLifecycleConfigStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NotebookInstanceLifecycleConfigStatusConditions>? Conditions { get; set; }

    /// <summary>A timestamp that tells when the lifecycle configuration was created.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>A timestamp that tells when the lifecycle configuration was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }
}

/// <summary>NotebookInstanceLifecycleConfig is the Schema for the NotebookInstanceLifecycleConfigs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NotebookInstanceLifecycleConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NotebookInstanceLifecycleConfigSpec?>, IStatus<V1alpha1NotebookInstanceLifecycleConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NotebookInstanceLifecycleConfig";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "notebookinstancelifecycleconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NotebookInstanceLifecycleConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NotebookInstanceLifecycleConfigSpec defines the desired state of NotebookInstanceLifecycleConfig.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1NotebookInstanceLifecycleConfigSpec? Spec { get; set; }

    /// <summary>NotebookInstanceLifecycleConfigStatus defines the observed state of NotebookInstanceLifecycleConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1NotebookInstanceLifecycleConfigStatus? Status { get; set; }
}