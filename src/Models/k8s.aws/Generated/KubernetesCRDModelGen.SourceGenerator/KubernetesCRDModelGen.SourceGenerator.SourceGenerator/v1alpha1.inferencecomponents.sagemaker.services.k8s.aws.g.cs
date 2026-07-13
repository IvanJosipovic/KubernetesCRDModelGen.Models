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
/// <summary>InferenceComponent is the Schema for the InferenceComponents API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1InferenceComponentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1InferenceComponent>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "InferenceComponentList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "inferencecomponents";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InferenceComponentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1InferenceComponent objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1InferenceComponent> Items { get; set; }
}

/// <summary>Runtime settings for a model that is deployed with an inference component.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InferenceComponentSpecRuntimeConfig
{
    [JsonPropertyName("copyCount")]
    public long? CopyCount { get; set; }
}

/// <summary>
/// Defines the compute resources to allocate to run a model, plus any adapter
/// models, that you assign to an inference component. These resources include
/// CPU cores, accelerators, and memory.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InferenceComponentSpecSpecificationComputeResourceRequirements
{
    [JsonPropertyName("maxMemoryRequiredInMb")]
    public long? MaxMemoryRequiredInMb { get; set; }

    [JsonPropertyName("minMemoryRequiredInMb")]
    public long? MinMemoryRequiredInMb { get; set; }

    [JsonPropertyName("numberOfAcceleratorDevicesRequired")]
    public double? NumberOfAcceleratorDevicesRequired { get; set; }

    [JsonPropertyName("numberOfCPUCoresRequired")]
    public double? NumberOfCPUCoresRequired { get; set; }
}

/// <summary>
/// Defines a container that provides the runtime environment for a model that
/// you deploy with an inference component.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InferenceComponentSpecSpecificationContainer
{
    [JsonPropertyName("artifactURL")]
    public string? ArtifactURL { get; set; }

    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }
}

/// <summary>Settings that take effect while the model container starts up.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InferenceComponentSpecSpecificationStartupParameters
{
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public long? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public long? ModelDataDownloadTimeoutInSeconds { get; set; }
}

/// <summary>
/// Details about the resources to deploy with this inference component, including
/// the model, container, and compute resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InferenceComponentSpecSpecification
{
    /// <summary>
    /// Defines the compute resources to allocate to run a model, plus any adapter
    /// models, that you assign to an inference component. These resources include
    /// CPU cores, accelerators, and memory.
    /// </summary>
    [JsonPropertyName("computeResourceRequirements")]
    public V1alpha1InferenceComponentSpecSpecificationComputeResourceRequirements? ComputeResourceRequirements { get; set; }

    /// <summary>
    /// Defines a container that provides the runtime environment for a model that
    /// you deploy with an inference component.
    /// </summary>
    [JsonPropertyName("container")]
    public V1alpha1InferenceComponentSpecSpecificationContainer? Container { get; set; }

    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Settings that take effect while the model container starts up.</summary>
    [JsonPropertyName("startupParameters")]
    public V1alpha1InferenceComponentSpecSpecificationStartupParameters? StartupParameters { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InferenceComponentSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>InferenceComponentSpec defines the desired state of InferenceComponent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InferenceComponentSpec
{
    /// <summary>
    /// The name of an existing endpoint where you host the inference component.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("endpointName")]
    public required string EndpointName { get; set; }

    /// <summary>
    /// A unique name to assign to the inference component.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9]([\-a-zA-Z0-9]*[a-zA-Z0-9])?$`
    /// </summary>
    [JsonPropertyName("inferenceComponentName")]
    public required string InferenceComponentName { get; set; }

    /// <summary>Runtime settings for a model that is deployed with an inference component.</summary>
    [JsonPropertyName("runtimeConfig")]
    public V1alpha1InferenceComponentSpecRuntimeConfig? RuntimeConfig { get; set; }

    /// <summary>
    /// Details about the resources to deploy with this inference component, including
    /// the model, container, and compute resources.
    /// </summary>
    [JsonPropertyName("specification")]
    public required V1alpha1InferenceComponentSpecSpecification Specification { get; set; }

    /// <summary>
    /// A list of key-value pairs associated with the model. For more information,
    /// see Tagging Amazon Web Services resources (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html)
    /// in the Amazon Web Services General Reference.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1InferenceComponentSpecTags>? Tags { get; set; }

    /// <summary>
    /// The name of an existing production variant where you host the inference component.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InferenceComponentStatusAckResourceMetadata
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
public partial class V1alpha1InferenceComponentStatusConditions
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

/// <summary>InferenceComponentStatus defines the observed state of InferenceComponent</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InferenceComponentStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1InferenceComponentStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1InferenceComponentStatusConditions>? Conditions { get; set; }

    /// <summary>The time when the inference component was created.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// The name of the endpoint that hosts the inference component.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>If the inference component status is Failed, the reason for the failure.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>The status of the inference component.</summary>
    [JsonPropertyName("inferenceComponentStatus")]
    public string? InferenceComponentStatus { get; set; }

    /// <summary>The time when the inference component was last updated.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>
    /// The name of the production variant that hosts the inference component.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }
}

/// <summary>InferenceComponent is the Schema for the InferenceComponents API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1InferenceComponent : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1InferenceComponentSpec?>, IStatus<V1alpha1InferenceComponentStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "InferenceComponent";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "inferencecomponents";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InferenceComponent";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InferenceComponentSpec defines the desired state of InferenceComponent.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1InferenceComponentSpec? Spec { get; set; }

    /// <summary>InferenceComponentStatus defines the observed state of InferenceComponent</summary>
    [JsonPropertyName("status")]
    public V1alpha1InferenceComponentStatus? Status { get; set; }
}