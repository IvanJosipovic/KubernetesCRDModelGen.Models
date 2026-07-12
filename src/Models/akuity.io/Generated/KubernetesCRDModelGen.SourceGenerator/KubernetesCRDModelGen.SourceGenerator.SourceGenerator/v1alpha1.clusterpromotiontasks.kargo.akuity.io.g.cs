#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kargo.akuity.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterPromotionTaskList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterPromotionTask>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterPromotionTaskList";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "clusterpromotiontasks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterPromotionTaskList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ClusterPromotionTask objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ClusterPromotionTask> Items { get; set; }
}

/// <summary>Retry is the retry policy for this step.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPromotionTaskSpecStepsRetry
{
    /// <summary>
    /// ErrorThreshold is the number of consecutive times the step must fail (for
    /// any reason) before retries are abandoned and the entire Promotion is marked
    /// as failed.
    /// 
    /// If this field is set to 0, the effective default will be a step-specific
    /// one. If no step-specific default exists (i.e. is also 0), the effective
    /// default will be the system-wide default of 1.
    /// 
    /// A value of 1 will cause the Promotion to be marked as failed after just
    /// a single failure; i.e. no retries will be attempted.
    /// 
    /// There is no option to specify an infinite number of retries using a value
    /// such as -1.
    /// 
    /// In a future release, Kargo is likely to become capable of distinguishing
    /// between recoverable and non-recoverable step failures. At that time, it is
    /// planned that unrecoverable failures will not be subject to this threshold
    /// and will immediately cause the Promotion to be marked as failed without
    /// further condition.
    /// </summary>
    [JsonPropertyName("errorThreshold")]
    public int? ErrorThreshold { get; set; }

    /// <summary>
    /// Timeout is the soft maximum interval in which a step that returns a Running
    /// status (which typically indicates it&apos;s waiting for something to happen)
    /// may be retried.
    /// 
    /// The maximum is a soft one because the check for whether the interval has
    /// elapsed occurs AFTER the step has run. This effectively means a step may
    /// run ONCE beyond the close of the interval.
    /// 
    /// If this field is set to nil, the effective default will be a step-specific
    /// one. If no step-specific default exists (i.e. is also nil), the effective
    /// default will be the system-wide default of 0.
    /// 
    /// A value of 0 will cause the step to be retried indefinitely unless the
    /// ErrorThreshold is reached.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>
/// Kind is the type of the PromotionTask. Can be either PromotionTask or
/// ClusterPromotionTask, default is PromotionTask.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterPromotionTaskSpecStepsTaskKindEnum>))]
public enum V1alpha1ClusterPromotionTaskSpecStepsTaskKindEnum
{
    [EnumMember(Value = "PromotionTask"), JsonStringEnumMemberName("PromotionTask")]
    PromotionTask,
    [EnumMember(Value = "ClusterPromotionTask"), JsonStringEnumMemberName("ClusterPromotionTask")]
    ClusterPromotionTask
}

/// <summary>
/// Task is a reference to a PromotionTask that should be inflated into a
/// Promotion when it is built from a PromotionTemplate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPromotionTaskSpecStepsTask
{
    /// <summary>
    /// Kind is the type of the PromotionTask. Can be either PromotionTask or
    /// ClusterPromotionTask, default is PromotionTask.
    /// </summary>
    [JsonPropertyName("kind")]
    public V1alpha1ClusterPromotionTaskSpecStepsTaskKindEnum? Kind { get; set; }

    /// <summary>Name is the name of the (Cluster)PromotionTask.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ExpressionVariable describes a single variable that may be referenced by
/// expressions in the context of a ClusterPromotionTask, PromotionTask,
/// Promotion, AnalysisRun arguments, or other objects that support expressions.
/// 
/// It is used to pass information to the expression evaluation engine, and to
/// allow for dynamic evaluation of expressions based on the variable values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPromotionTaskSpecStepsVars
{
    /// <summary>Name is the name of the variable.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is the value of the variable. It is allowed to utilize expressions
    /// in the value.
    /// See https://docs.kargo.io/user-guide/reference-docs/expressions for details.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>PromotionStep describes a directive to be executed as part of a Promotion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPromotionTaskSpecSteps
{
    /// <summary>As is the alias this step can be referred to as.</summary>
    [JsonPropertyName("as")]
    public string? As { get; set; }

    /// <summary>
    /// Config is opaque configuration for the PromotionStep that is understood
    /// only by each PromotionStep&apos;s implementation. It is legal to utilize
    /// expressions in defining values at any level of this block.
    /// See https://docs.kargo.io/user-guide/reference-docs/expressions for details.
    /// </summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>
    /// ContinueOnError is a boolean value that, if set to true, will cause the
    /// Promotion to continue executing the next step even if this step fails. It
    /// also will not permit this failure to impact the overall status of the
    /// Promotion.
    /// </summary>
    [JsonPropertyName("continueOnError")]
    public bool? ContinueOnError { get; set; }

    /// <summary>
    /// If is an optional expression that, if present, must evaluate to a boolean
    /// value. If the expression evaluates to false, the step will be skipped.
    /// If the expression does not evaluate to a boolean value, the step will be
    /// considered to have failed.
    /// </summary>
    [JsonPropertyName("if")]
    public string? If { get; set; }

    /// <summary>Retry is the retry policy for this step.</summary>
    [JsonPropertyName("retry")]
    public V1alpha1ClusterPromotionTaskSpecStepsRetry? Retry { get; set; }

    /// <summary>
    /// Task is a reference to a PromotionTask that should be inflated into a
    /// Promotion when it is built from a PromotionTemplate.
    /// </summary>
    [JsonPropertyName("task")]
    public V1alpha1ClusterPromotionTaskSpecStepsTask? Task { get; set; }

    /// <summary>Uses identifies a runner that can execute this step.</summary>
    [JsonPropertyName("uses")]
    public string? Uses { get; set; }

    /// <summary>
    /// Vars is a list of variables that can be referenced by expressions in
    /// the step&apos;s Config. The values override the values specified in the
    /// PromotionSpec.
    /// </summary>
    [JsonPropertyName("vars")]
    public IList<V1alpha1ClusterPromotionTaskSpecStepsVars>? Vars { get; set; }
}

/// <summary>
/// ExpressionVariable describes a single variable that may be referenced by
/// expressions in the context of a ClusterPromotionTask, PromotionTask,
/// Promotion, AnalysisRun arguments, or other objects that support expressions.
/// 
/// It is used to pass information to the expression evaluation engine, and to
/// allow for dynamic evaluation of expressions based on the variable values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPromotionTaskSpecVars
{
    /// <summary>Name is the name of the variable.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is the value of the variable. It is allowed to utilize expressions
    /// in the value.
    /// See https://docs.kargo.io/user-guide/reference-docs/expressions for details.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Spec describes the desired transition of a specific Stage into a specific
/// Freight.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterPromotionTaskSpec
{
    /// <summary>
    /// Steps specifies the directives to be executed as part of this
    /// PromotionTask. The steps as defined here are inflated into a
    /// Promotion when it is built from a PromotionTemplate.
    /// </summary>
    [JsonPropertyName("steps")]
    public required IList<V1alpha1ClusterPromotionTaskSpecSteps> Steps { get; set; }

    /// <summary>
    /// Vars specifies the variables available to the PromotionTask. The
    /// values of these variables are the default values that can be
    /// overridden by the step referencing the task.
    /// </summary>
    [JsonPropertyName("vars")]
    public IList<V1alpha1ClusterPromotionTaskSpecVars>? Vars { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterPromotionTask : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterPromotionTaskSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterPromotionTask";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "clusterpromotiontasks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterPromotionTask";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Spec describes the desired transition of a specific Stage into a specific
    /// Freight.
    /// </summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ClusterPromotionTaskSpec Spec { get; set; }
}