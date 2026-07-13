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
/// <summary>PipelineExecution is the Schema for the PipelineExecutions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PipelineExecutionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1PipelineExecution>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PipelineExecutionList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "pipelineexecutions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PipelineExecutionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1PipelineExecution objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1PipelineExecution> Items { get; set; }
}

/// <summary>
/// This configuration, if specified, overrides the parallelism configuration
/// of the parent pipeline for this specific run.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineExecutionSpecParallelismConfiguration
{
    [JsonPropertyName("maxParallelExecutionSteps")]
    public long? MaxParallelExecutionSteps { get; set; }
}

/// <summary>Assigns a value to a named Pipeline parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineExecutionSpecPipelineParameters
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A step selected to run in selective execution mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineExecutionSpecSelectiveExecutionConfigSelectedSteps
{
    [JsonPropertyName("stepName")]
    public string? StepName { get; set; }
}

/// <summary>The selective execution configuration applied to the pipeline run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineExecutionSpecSelectiveExecutionConfig
{
    [JsonPropertyName("selectedSteps")]
    public IList<V1alpha1PipelineExecutionSpecSelectiveExecutionConfigSelectedSteps>? SelectedSteps { get; set; }

    [JsonPropertyName("sourcePipelineExecutionARN")]
    public string? SourcePipelineExecutionARN { get; set; }
}

/// <summary>
/// PipelineExecutionSpec defines the desired state of PipelineExecution.
/// 
/// An execution of a pipeline.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineExecutionSpec
{
    /// <summary>
    /// This configuration, if specified, overrides the parallelism configuration
    /// of the parent pipeline for this specific run.
    /// </summary>
    [JsonPropertyName("parallelismConfiguration")]
    public V1alpha1PipelineExecutionSpecParallelismConfiguration? ParallelismConfiguration { get; set; }

    /// <summary>
    /// The description of the pipeline execution.
    /// 
    /// Regex Pattern: `.*`
    /// </summary>
    [JsonPropertyName("pipelineExecutionDescription")]
    public string? PipelineExecutionDescription { get; set; }

    /// <summary>
    /// The display name of the pipeline execution.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,81}$`
    /// </summary>
    [JsonPropertyName("pipelineExecutionDisplayName")]
    public string? PipelineExecutionDisplayName { get; set; }

    /// <summary>
    /// The name or Amazon Resource Name (ARN) of the pipeline.
    /// 
    /// Regex Pattern: `^(arn:aws[a-z\-]*:sagemaker:[a-z0-9\-]*:[0-9]{12}:pipeline/.*)?([a-zA-Z0-9](-*[a-zA-Z0-9]){0,255})$`
    /// </summary>
    [JsonPropertyName("pipelineName")]
    public required string PipelineName { get; set; }

    /// <summary>Contains a list of pipeline parameters. This list can be empty.</summary>
    [JsonPropertyName("pipelineParameters")]
    public IList<V1alpha1PipelineExecutionSpecPipelineParameters>? PipelineParameters { get; set; }

    /// <summary>The ID of the pipeline version to start execution from.</summary>
    [JsonPropertyName("pipelineVersionID")]
    public long? PipelineVersionID { get; set; }

    /// <summary>The selective execution configuration applied to the pipeline run.</summary>
    [JsonPropertyName("selectiveExecutionConfig")]
    public V1alpha1PipelineExecutionSpecSelectiveExecutionConfig? SelectiveExecutionConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineExecutionStatusAckResourceMetadata
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
public partial class V1alpha1PipelineExecutionStatusConditions
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

/// <summary>PipelineExecutionStatus defines the observed state of PipelineExecution</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PipelineExecutionStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1PipelineExecutionStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PipelineExecutionStatusConditions>? Conditions { get; set; }

    /// <summary>The time when the pipeline execution was created.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// If the execution failed, a message describing why.
    /// 
    /// Regex Pattern: `.*`
    /// </summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>The time when the pipeline execution was modified last.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>The status of the pipeline execution.</summary>
    [JsonPropertyName("pipelineExecutionStatus")]
    public string? PipelineExecutionStatus { get; set; }
}

/// <summary>PipelineExecution is the Schema for the PipelineExecutions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PipelineExecution : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PipelineExecutionSpec?>, IStatus<V1alpha1PipelineExecutionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PipelineExecution";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "pipelineexecutions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PipelineExecution";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// PipelineExecutionSpec defines the desired state of PipelineExecution.
    /// 
    /// An execution of a pipeline.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1PipelineExecutionSpec? Spec { get; set; }

    /// <summary>PipelineExecutionStatus defines the observed state of PipelineExecution</summary>
    [JsonPropertyName("status")]
    public V1alpha1PipelineExecutionStatus? Status { get; set; }
}