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
/// <summary>Stage is the Kargo API&apos;s main type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1StageList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Stage>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "StageList";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "stages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StageList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Stage objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Stage> Items { get; set; }
}

/// <summary>Retry is the retry policy for this step.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecPromotionTemplateSpecStepsRetry
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1StageSpecPromotionTemplateSpecStepsTaskKindEnum>))]
public enum V1alpha1StageSpecPromotionTemplateSpecStepsTaskKindEnum
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
public partial class V1alpha1StageSpecPromotionTemplateSpecStepsTask
{
    /// <summary>
    /// Kind is the type of the PromotionTask. Can be either PromotionTask or
    /// ClusterPromotionTask, default is PromotionTask.
    /// </summary>
    [JsonPropertyName("kind")]
    public V1alpha1StageSpecPromotionTemplateSpecStepsTaskKindEnum? Kind { get; set; }

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
public partial class V1alpha1StageSpecPromotionTemplateSpecStepsVars
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
public partial class V1alpha1StageSpecPromotionTemplateSpecSteps
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
    public V1alpha1StageSpecPromotionTemplateSpecStepsRetry? Retry { get; set; }

    /// <summary>
    /// Task is a reference to a PromotionTask that should be inflated into a
    /// Promotion when it is built from a PromotionTemplate.
    /// </summary>
    [JsonPropertyName("task")]
    public V1alpha1StageSpecPromotionTemplateSpecStepsTask? Task { get; set; }

    /// <summary>Uses identifies a runner that can execute this step.</summary>
    [JsonPropertyName("uses")]
    public string? Uses { get; set; }

    /// <summary>
    /// Vars is a list of variables that can be referenced by expressions in
    /// the step&apos;s Config. The values override the values specified in the
    /// PromotionSpec.
    /// </summary>
    [JsonPropertyName("vars")]
    public IList<V1alpha1StageSpecPromotionTemplateSpecStepsVars>? Vars { get; set; }
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
public partial class V1alpha1StageSpecPromotionTemplateSpecVars
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
/// PromotionTemplateSpec describes the (partial) specification of a Promotion
/// for a Stage. This is a template that can be used to create a Promotion for a
/// Stage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecPromotionTemplateSpec
{
    /// <summary>
    /// Steps specifies the directives to be executed as part of a Promotion.
    /// The order in which the directives are executed is the order in which they
    /// are listed in this field.
    /// </summary>
    [JsonPropertyName("steps")]
    public IList<V1alpha1StageSpecPromotionTemplateSpecSteps>? Steps { get; set; }

    /// <summary>
    /// Vars is a list of variables that can be referenced by expressions in
    /// promotion steps.
    /// </summary>
    [JsonPropertyName("vars")]
    public IList<V1alpha1StageSpecPromotionTemplateSpecVars>? Vars { get; set; }
}

/// <summary>
/// PromotionTemplate describes how to incorporate Freight into the Stage
/// using a Promotion.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecPromotionTemplate
{
    /// <summary>
    /// PromotionTemplateSpec describes the (partial) specification of a Promotion
    /// for a Stage. This is a template that can be used to create a Promotion for a
    /// Stage.
    /// </summary>
    [JsonPropertyName("spec")]
    public required V1alpha1StageSpecPromotionTemplateSpec Spec { get; set; }
}

/// <summary>
/// Kind is the kind of resource from which Freight may have originated. At
/// present, this can only be &quot;Warehouse&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1StageSpecRequestedFreightOriginKindEnum>))]
public enum V1alpha1StageSpecRequestedFreightOriginKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>
/// Origin specifies from where the requested Freight must have originated.
/// This is a required field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecRequestedFreightOrigin
{
    /// <summary>
    /// Kind is the kind of resource from which Freight may have originated. At
    /// present, this can only be &quot;Warehouse&quot;.
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1StageSpecRequestedFreightOriginKindEnum Kind { get; set; }

    /// <summary>
    /// Name is the name of the resource of the kind indicated by the Kind field
    /// from which Freight may originate.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SelectionPolicy specifies the rules for identifying new Freight that is
/// eligible for auto-promotion to this Stage. This field is optional. When
/// left unspecified, the field is implicitly treated as if its value were
/// &quot;NewestFreight&quot;.
/// 
/// Accepted Values:
/// 
/// - &quot;NewestFreight&quot;: The newest Freight that is available to the Stage is
///   eligible for auto-promotion.
/// 
/// - &quot;MatchUpstream&quot;: Only the Freight currently used immediately upstream
///   from this Stage is eligible for auto-promotion. This policy may only
///   be applied when the Stage has exactly one upstream Stage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1StageSpecRequestedFreightSourcesAutoPromotionOptionsSelectionPolicyEnum>))]
public enum V1alpha1StageSpecRequestedFreightSourcesAutoPromotionOptionsSelectionPolicyEnum
{
    [EnumMember(Value = "NewestFreight"), JsonStringEnumMemberName("NewestFreight")]
    NewestFreight,
    [EnumMember(Value = "MatchUpstream"), JsonStringEnumMemberName("MatchUpstream")]
    MatchUpstream
}

/// <summary>
/// AutoPromotionOptions specifies options pertaining to auto-promotion. These
/// settings have no effect if auto-promotion is not enabled for this Stage at
/// the ProjectConfig level.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecRequestedFreightSourcesAutoPromotionOptions
{
    /// <summary>
    /// SelectionPolicy specifies the rules for identifying new Freight that is
    /// eligible for auto-promotion to this Stage. This field is optional. When
    /// left unspecified, the field is implicitly treated as if its value were
    /// &quot;NewestFreight&quot;.
    /// 
    /// Accepted Values:
    /// 
    /// - &quot;NewestFreight&quot;: The newest Freight that is available to the Stage is
    ///   eligible for auto-promotion.
    /// 
    /// - &quot;MatchUpstream&quot;: Only the Freight currently used immediately upstream
    ///   from this Stage is eligible for auto-promotion. This policy may only
    ///   be applied when the Stage has exactly one upstream Stage.
    /// </summary>
    [JsonPropertyName("selectionPolicy")]
    public V1alpha1StageSpecRequestedFreightSourcesAutoPromotionOptionsSelectionPolicyEnum? SelectionPolicy { get; set; }
}

/// <summary>
/// Sources describes where the requested Freight may be obtained from. This is
/// a required field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecRequestedFreightSources
{
    /// <summary>
    /// AutoPromotionOptions specifies options pertaining to auto-promotion. These
    /// settings have no effect if auto-promotion is not enabled for this Stage at
    /// the ProjectConfig level.
    /// </summary>
    [JsonPropertyName("autoPromotionOptions")]
    public V1alpha1StageSpecRequestedFreightSourcesAutoPromotionOptions? AutoPromotionOptions { get; set; }

    /// <summary>
    /// AvailabilityStrategy specifies the semantics for how requested Freight is
    /// made available to the Stage. This field is optional. When left unspecified,
    /// the field is implicitly treated as if its value were &quot;OneOf&quot;.
    /// 
    /// Accepted Values:
    /// 
    /// - &quot;All&quot;: Freight must be verified and, if applicable, soaked in all
    ///   upstream Stages to be considered available for promotion.
    /// - &quot;OneOf&quot;: Freight must be verified and, if applicable, soaked in at least
    ///    one upstream Stage to be considered available for promotion.
    /// - &quot; &quot;: Treated the same as &quot;OneOf&quot;.
    /// </summary>
    [JsonPropertyName("availabilityStrategy")]
    public string? AvailabilityStrategy { get; set; }

    /// <summary>
    /// Direct indicates the requested Freight may be obtained directly from the
    /// Warehouse from which it originated. If this field&apos;s value is false, then
    /// the value of the Stages field must be non-empty. i.e. Between the two
    /// fields, at least one source must be specified.
    /// </summary>
    [JsonPropertyName("direct")]
    public bool? Direct { get; set; }

    /// <summary>
    /// RequiredSoakTime specifies a minimum duration for which the requested
    /// Freight must have continuously occupied (&quot;soaked in&quot;) in an upstream Stage
    /// before becoming available for promotion to this Stage. This is an optional
    /// field. If nil or zero, no soak time is required. Any soak time requirement
    /// is in ADDITION to the requirement that Freight be verified in an upstream
    /// Stage to become available for promotion to this Stage, although a manual
    /// approval for promotion to this Stage will supersede any soak time
    /// requirement.
    /// </summary>
    [JsonPropertyName("requiredSoakTime")]
    public string? RequiredSoakTime { get; set; }

    /// <summary>
    /// Stages identifies other &quot;upstream&quot; Stages as potential sources of the
    /// requested Freight. If this field&apos;s value is empty, then the value of the
    /// Direct field must be true. i.e. Between the two fields, at least on source
    /// must be specified.
    /// </summary>
    [JsonPropertyName("stages")]
    public IList<string>? Stages { get; set; }
}

/// <summary>
/// FreightRequest expresses a Stage&apos;s need for Freight having originated from a
/// particular Warehouse.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecRequestedFreight
{
    /// <summary>
    /// Origin specifies from where the requested Freight must have originated.
    /// This is a required field.
    /// </summary>
    [JsonPropertyName("origin")]
    public required V1alpha1StageSpecRequestedFreightOrigin Origin { get; set; }

    /// <summary>
    /// Sources describes where the requested Freight may be obtained from. This is
    /// a required field.
    /// </summary>
    [JsonPropertyName("sources")]
    public required V1alpha1StageSpecRequestedFreightSources Sources { get; set; }
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
public partial class V1alpha1StageSpecVars
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
/// AnalysisRunMetadata contains optional metadata that should be applied to
/// all AnalysisRuns.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecVerificationAnalysisRunMetadata
{
    /// <summary>Additional annotations to apply to an AnalysisRun.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Additional labels to apply to an AnalysisRun.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>
/// Kind is the type of the AnalysisTemplate. Can be either AnalysisTemplate or
/// ClusterAnalysisTemplate, default is AnalysisTemplate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1StageSpecVerificationAnalysisTemplatesKindEnum>))]
public enum V1alpha1StageSpecVerificationAnalysisTemplatesKindEnum
{
    [EnumMember(Value = "AnalysisTemplate"), JsonStringEnumMemberName("AnalysisTemplate")]
    AnalysisTemplate,
    [EnumMember(Value = "ClusterAnalysisTemplate"), JsonStringEnumMemberName("ClusterAnalysisTemplate")]
    ClusterAnalysisTemplate
}

/// <summary>AnalysisTemplateReference is a reference to an AnalysisTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecVerificationAnalysisTemplates
{
    /// <summary>
    /// Kind is the type of the AnalysisTemplate. Can be either AnalysisTemplate or
    /// ClusterAnalysisTemplate, default is AnalysisTemplate.
    /// </summary>
    [JsonPropertyName("kind")]
    public V1alpha1StageSpecVerificationAnalysisTemplatesKindEnum? Kind { get; set; }

    /// <summary>
    /// Name is the name of the AnalysisTemplate in the same project/namespace as
    /// the Stage.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AnalysisRunArgument represents an argument to be added to an AnalysisRun.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecVerificationArgs
{
    /// <summary>Name is the name of the argument.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value is the value of the argument.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Verification describes how to verify a Stage&apos;s current Freight is fit for
/// promotion downstream.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecVerification
{
    /// <summary>
    /// AnalysisRunMetadata contains optional metadata that should be applied to
    /// all AnalysisRuns.
    /// </summary>
    [JsonPropertyName("analysisRunMetadata")]
    public V1alpha1StageSpecVerificationAnalysisRunMetadata? AnalysisRunMetadata { get; set; }

    /// <summary>
    /// AnalysisTemplates is a list of AnalysisTemplates from which AnalysisRuns
    /// should be created to verify a Stage&apos;s current Freight is fit to be promoted
    /// downstream.
    /// </summary>
    [JsonPropertyName("analysisTemplates")]
    public IList<V1alpha1StageSpecVerificationAnalysisTemplates>? AnalysisTemplates { get; set; }

    /// <summary>Args lists arguments that should be added to all AnalysisRuns.</summary>
    [JsonPropertyName("args")]
    public IList<V1alpha1StageSpecVerificationArgs>? Args { get; set; }
}

/// <summary>
/// Spec describes sources of Freight used by the Stage and how to incorporate
/// Freight into the Stage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpec
{
    /// <summary>
    /// PromotionTemplate describes how to incorporate Freight into the Stage
    /// using a Promotion.
    /// </summary>
    [JsonPropertyName("promotionTemplate")]
    public V1alpha1StageSpecPromotionTemplate? PromotionTemplate { get; set; }

    /// <summary>
    /// RequestedFreight expresses the Stage&apos;s need for certain pieces of Freight,
    /// each having originated from a particular Warehouse. This list must be
    /// non-empty. In the common case, a Stage will request Freight having
    /// originated from just one specific Warehouse. In advanced cases, requesting
    /// Freight from multiple Warehouses provides a method of advancing new
    /// artifacts of different types through parallel pipelines at different
    /// speeds. This can be useful, for instance, if a Stage is home to multiple
    /// microservices that are independently versioned.
    /// </summary>
    [JsonPropertyName("requestedFreight")]
    public required IList<V1alpha1StageSpecRequestedFreight> RequestedFreight { get; set; }

    /// <summary>
    /// Shard is the name of the shard that this Stage belongs to. This is an
    /// optional field. If not specified, the Stage will belong to the default
    /// shard. A defaulting webhook will sync the value of the
    /// kargo.akuity.io/shard label with the value of this field. When this field
    /// is empty, the webhook will ensure that label is absent.
    /// </summary>
    [JsonPropertyName("shard")]
    public string? Shard { get; set; }

    /// <summary>
    /// Vars is a list of variables that can be referenced anywhere in the
    /// StageSpec that supports expressions. For example, the PromotionTemplate
    /// and arguments of the Verification.
    /// </summary>
    [JsonPropertyName("vars")]
    public IList<V1alpha1StageSpecVars>? Vars { get; set; }

    /// <summary>
    /// Verification describes how to verify a Stage&apos;s current Freight is fit for
    /// promotion downstream.
    /// </summary>
    [JsonPropertyName("verification")]
    public V1alpha1StageSpecVerification? Verification { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1StageStatusConditionsStatusEnum>))]
public enum V1alpha1StageStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1alpha1StageStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ArtifactReference is a reference to a specific version of an artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionFreightArtifacts
{
    /// <summary>
    /// ArtifactType specifies the type of artifact this is. Often, but not always,
    /// it will be the media type (MIME type) of the artifact referenced by this
    /// ArtifactReference.
    /// </summary>
    [JsonPropertyName("artifactType")]
    public string? ArtifactType { get; set; }

    /// <summary>
    /// Metadata is a JSON object containing a mostly opaque collection of artifact
    /// attributes. (It must be an object. It may not be a list or a scalar value.)
    /// &quot;Mostly&quot; because Kargo may understand how to interpret some documented,
    /// well-known, top-level keys. Those aside, this metadata is only understood
    /// by a corresponding Subscriber implementation that created it.
    /// </summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>
    /// SubscriptionName is the name of the Subscription that discovered this
    /// artifact.
    /// </summary>
    [JsonPropertyName("subscriptionName")]
    public required string SubscriptionName { get; set; }

    /// <summary>Version identifies a specific revision of this artifact.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>Chart describes a specific version of a Helm chart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionFreightCharts
{
    /// <summary>Name specifies the name of the chart.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// RepoURL specifies the URL of a Helm chart repository. Classic chart
    /// repositories (using HTTP/S) can contain differently named charts. When this
    /// field points to such a repository, the Name field will specify the name of
    /// the chart within the repository. In the case of a repository within an OCI
    /// registry, the URL implicitly points to a specific chart and the Name field
    /// will be empty.
    /// </summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>Version specifies a particular version of the chart.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>GitCommit describes a specific commit from a specific Git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionFreightCommits
{
    /// <summary>Author is the author of the commit.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>Branch denotes the branch of the repository where this commit was found.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Committer is the person who committed the commit.</summary>
    [JsonPropertyName("committer")]
    public string? Committer { get; set; }

    /// <summary>
    /// ID is the ID of a specific commit in the Git repository specified by
    /// RepoURL.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Message is the message associated with the commit. At present, this only
    /// contains the first line (subject) of the commit message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>RepoURL is the URL of a Git repository.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag denotes a tag in the repository that matched selection criteria and
    /// resolved to this commit.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Image describes a specific version of a container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionFreightImages
{
    /// <summary>Annotations is a map of arbitrary metadata for the image.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Digest identifies a specific version of the image in the repository
    /// specified by RepoURL. This is a more precise identifier than Tag.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>RepoURL describes the repository in which the image can be found.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag identifies a specific version of the image in the repository specified
    /// by RepoURL.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Kind is the kind of resource from which Freight may have originated. At
/// present, this can only be &quot;Warehouse&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1StageStatusCurrentPromotionFreightOriginKindEnum>))]
public enum V1alpha1StageStatusCurrentPromotionFreightOriginKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionFreightOrigin
{
    /// <summary>
    /// Kind is the kind of resource from which Freight may have originated. At
    /// present, this can only be &quot;Warehouse&quot;.
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1StageStatusCurrentPromotionFreightOriginKindEnum Kind { get; set; }

    /// <summary>
    /// Name is the name of the resource of the kind indicated by the Kind field
    /// from which Freight may originate.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Freight is the freight being promoted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionFreight
{
    /// <summary>
    /// Artifacts describes specific versions of artifacts other
    /// than Git repository commits, container images, and Helm charts.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1StageStatusCurrentPromotionFreightArtifacts>? Artifacts { get; set; }

    /// <summary>Charts describes specific versions of specific Helm charts.</summary>
    [JsonPropertyName("charts")]
    public IList<V1alpha1StageStatusCurrentPromotionFreightCharts>? Charts { get; set; }

    /// <summary>Commits describes specific Git repository commits.</summary>
    [JsonPropertyName("commits")]
    public IList<V1alpha1StageStatusCurrentPromotionFreightCommits>? Commits { get; set; }

    /// <summary>Images describes specific versions of specific container images.</summary>
    [JsonPropertyName("images")]
    public IList<V1alpha1StageStatusCurrentPromotionFreightImages>? Images { get; set; }

    /// <summary>
    /// Name is a system-assigned identifier derived deterministically from
    /// the contents of the Freight. I.e., two pieces of Freight can be compared
    /// for equality by comparing their Names.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
    [JsonPropertyName("origin")]
    public V1alpha1StageStatusCurrentPromotionFreightOrigin? Origin { get; set; }
}

/// <summary>ArtifactReference is a reference to a specific version of an artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightArtifacts
{
    /// <summary>
    /// ArtifactType specifies the type of artifact this is. Often, but not always,
    /// it will be the media type (MIME type) of the artifact referenced by this
    /// ArtifactReference.
    /// </summary>
    [JsonPropertyName("artifactType")]
    public string? ArtifactType { get; set; }

    /// <summary>
    /// Metadata is a JSON object containing a mostly opaque collection of artifact
    /// attributes. (It must be an object. It may not be a list or a scalar value.)
    /// &quot;Mostly&quot; because Kargo may understand how to interpret some documented,
    /// well-known, top-level keys. Those aside, this metadata is only understood
    /// by a corresponding Subscriber implementation that created it.
    /// </summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>
    /// SubscriptionName is the name of the Subscription that discovered this
    /// artifact.
    /// </summary>
    [JsonPropertyName("subscriptionName")]
    public required string SubscriptionName { get; set; }

    /// <summary>Version identifies a specific revision of this artifact.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>Chart describes a specific version of a Helm chart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightCharts
{
    /// <summary>Name specifies the name of the chart.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// RepoURL specifies the URL of a Helm chart repository. Classic chart
    /// repositories (using HTTP/S) can contain differently named charts. When this
    /// field points to such a repository, the Name field will specify the name of
    /// the chart within the repository. In the case of a repository within an OCI
    /// registry, the URL implicitly points to a specific chart and the Name field
    /// will be empty.
    /// </summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>Version specifies a particular version of the chart.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>GitCommit describes a specific commit from a specific Git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightCommits
{
    /// <summary>Author is the author of the commit.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>Branch denotes the branch of the repository where this commit was found.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Committer is the person who committed the commit.</summary>
    [JsonPropertyName("committer")]
    public string? Committer { get; set; }

    /// <summary>
    /// ID is the ID of a specific commit in the Git repository specified by
    /// RepoURL.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Message is the message associated with the commit. At present, this only
    /// contains the first line (subject) of the commit message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>RepoURL is the URL of a Git repository.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag denotes a tag in the repository that matched selection criteria and
    /// resolved to this commit.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Image describes a specific version of a container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightImages
{
    /// <summary>Annotations is a map of arbitrary metadata for the image.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Digest identifies a specific version of the image in the repository
    /// specified by RepoURL. This is a more precise identifier than Tag.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>RepoURL describes the repository in which the image can be found.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag identifies a specific version of the image in the repository specified
    /// by RepoURL.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Kind is the kind of resource from which Freight may have originated. At
/// present, this can only be &quot;Warehouse&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1StageStatusCurrentPromotionStatusFreightOriginKindEnum>))]
public enum V1alpha1StageStatusCurrentPromotionStatusFreightOriginKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightOrigin
{
    /// <summary>
    /// Kind is the kind of resource from which Freight may have originated. At
    /// present, this can only be &quot;Warehouse&quot;.
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1StageStatusCurrentPromotionStatusFreightOriginKindEnum Kind { get; set; }

    /// <summary>
    /// Name is the name of the resource of the kind indicated by the Kind field
    /// from which Freight may originate.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Freight is the detail of the piece of freight that was referenced by this promotion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreight
{
    /// <summary>
    /// Artifacts describes specific versions of artifacts other
    /// than Git repository commits, container images, and Helm charts.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1StageStatusCurrentPromotionStatusFreightArtifacts>? Artifacts { get; set; }

    /// <summary>Charts describes specific versions of specific Helm charts.</summary>
    [JsonPropertyName("charts")]
    public IList<V1alpha1StageStatusCurrentPromotionStatusFreightCharts>? Charts { get; set; }

    /// <summary>Commits describes specific Git repository commits.</summary>
    [JsonPropertyName("commits")]
    public IList<V1alpha1StageStatusCurrentPromotionStatusFreightCommits>? Commits { get; set; }

    /// <summary>Images describes specific versions of specific container images.</summary>
    [JsonPropertyName("images")]
    public IList<V1alpha1StageStatusCurrentPromotionStatusFreightImages>? Images { get; set; }

    /// <summary>
    /// Name is a system-assigned identifier derived deterministically from
    /// the contents of the Freight. I.e., two pieces of Freight can be compared
    /// for equality by comparing their Names.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
    [JsonPropertyName("origin")]
    public V1alpha1StageStatusCurrentPromotionStatusFreightOrigin? Origin { get; set; }
}

/// <summary>ArtifactReference is a reference to a specific version of an artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsArtifacts
{
    /// <summary>
    /// ArtifactType specifies the type of artifact this is. Often, but not always,
    /// it will be the media type (MIME type) of the artifact referenced by this
    /// ArtifactReference.
    /// </summary>
    [JsonPropertyName("artifactType")]
    public string? ArtifactType { get; set; }

    /// <summary>
    /// Metadata is a JSON object containing a mostly opaque collection of artifact
    /// attributes. (It must be an object. It may not be a list or a scalar value.)
    /// &quot;Mostly&quot; because Kargo may understand how to interpret some documented,
    /// well-known, top-level keys. Those aside, this metadata is only understood
    /// by a corresponding Subscriber implementation that created it.
    /// </summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>
    /// SubscriptionName is the name of the Subscription that discovered this
    /// artifact.
    /// </summary>
    [JsonPropertyName("subscriptionName")]
    public required string SubscriptionName { get; set; }

    /// <summary>Version identifies a specific revision of this artifact.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>Chart describes a specific version of a Helm chart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsCharts
{
    /// <summary>Name specifies the name of the chart.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// RepoURL specifies the URL of a Helm chart repository. Classic chart
    /// repositories (using HTTP/S) can contain differently named charts. When this
    /// field points to such a repository, the Name field will specify the name of
    /// the chart within the repository. In the case of a repository within an OCI
    /// registry, the URL implicitly points to a specific chart and the Name field
    /// will be empty.
    /// </summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>Version specifies a particular version of the chart.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>GitCommit describes a specific commit from a specific Git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsCommits
{
    /// <summary>Author is the author of the commit.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>Branch denotes the branch of the repository where this commit was found.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Committer is the person who committed the commit.</summary>
    [JsonPropertyName("committer")]
    public string? Committer { get; set; }

    /// <summary>
    /// ID is the ID of a specific commit in the Git repository specified by
    /// RepoURL.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Message is the message associated with the commit. At present, this only
    /// contains the first line (subject) of the commit message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>RepoURL is the URL of a Git repository.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag denotes a tag in the repository that matched selection criteria and
    /// resolved to this commit.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Image describes a specific version of a container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsImages
{
    /// <summary>Annotations is a map of arbitrary metadata for the image.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Digest identifies a specific version of the image in the repository
    /// specified by RepoURL. This is a more precise identifier than Tag.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>RepoURL describes the repository in which the image can be found.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag identifies a specific version of the image in the repository specified
    /// by RepoURL.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Kind is the kind of resource from which Freight may have originated. At
/// present, this can only be &quot;Warehouse&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsOriginKindEnum>))]
public enum V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsOriginKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsOrigin
{
    /// <summary>
    /// Kind is the kind of resource from which Freight may have originated. At
    /// present, this can only be &quot;Warehouse&quot;.
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsOriginKindEnum Kind { get; set; }

    /// <summary>
    /// Name is the name of the resource of the kind indicated by the Kind field
    /// from which Freight may originate.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// FreightReference is a simplified representation of a piece of Freight -- not
/// a root resource type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItems
{
    /// <summary>
    /// Artifacts describes specific versions of artifacts other
    /// than Git repository commits, container images, and Helm charts.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsArtifacts>? Artifacts { get; set; }

    /// <summary>Charts describes specific versions of specific Helm charts.</summary>
    [JsonPropertyName("charts")]
    public IList<V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsCharts>? Charts { get; set; }

    /// <summary>Commits describes specific Git repository commits.</summary>
    [JsonPropertyName("commits")]
    public IList<V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsCommits>? Commits { get; set; }

    /// <summary>Images describes specific versions of specific container images.</summary>
    [JsonPropertyName("images")]
    public IList<V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsImages>? Images { get; set; }

    /// <summary>
    /// Name is a system-assigned identifier derived deterministically from
    /// the contents of the Freight. I.e., two pieces of Freight can be compared
    /// for equality by comparing their Names.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
    [JsonPropertyName("origin")]
    public V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItemsOrigin? Origin { get; set; }
}

/// <summary>
/// AnalysisRun is a reference to the Argo Rollouts AnalysisRun that implements
/// the Verification process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightCollectionVerificationHistoryAnalysisRun
{
    /// <summary>Name is the name of the AnalysisRun.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the namespace of the AnalysisRun.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    /// <summary>Phase is the last observed phase of the AnalysisRun referenced by Name.</summary>
    [JsonPropertyName("phase")]
    public required string Phase { get; set; }
}

/// <summary>
/// VerificationInfo contains the details of an instance of a Verification
/// process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightCollectionVerificationHistory
{
    /// <summary>
    /// Actor is the name of the entity that initiated or aborted the
    /// Verification process.
    /// </summary>
    [JsonPropertyName("actor")]
    public string? Actor { get; set; }

    /// <summary>
    /// AnalysisRun is a reference to the Argo Rollouts AnalysisRun that implements
    /// the Verification process.
    /// </summary>
    [JsonPropertyName("analysisRun")]
    public V1alpha1StageStatusCurrentPromotionStatusFreightCollectionVerificationHistoryAnalysisRun? AnalysisRun { get; set; }

    /// <summary>FinishTime is the time at which the Verification process finished.</summary>
    [JsonPropertyName("finishTime")]
    public DateTime? FinishTime { get; set; }

    /// <summary>ID is the identifier of the Verification process.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Message may contain additional information about why the verification
    /// process is in its current phase.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Phase describes the current phase of the Verification process. Generally,
    /// this will be a reflection of the underlying AnalysisRun&apos;s phase, however,
    /// there are exceptions to this, such as in the case where an AnalysisRun
    /// cannot be launched successfully.
    /// </summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>StartTime is the time at which the Verification process was started.</summary>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }
}

/// <summary>
/// FreightCollection contains the details of the piece of Freight referenced
/// by this Promotion as well as any additional Freight that is carried over
/// from the target Stage&apos;s current state.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusFreightCollection
{
    /// <summary>
    /// ID is a unique and deterministically calculated identifier for the
    /// FreightCollection. It is updated on each use of the UpdateOrPush method.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Freight is a map of FreightReference objects, indexed by their Warehouse
    /// origin.
    /// </summary>
    [JsonPropertyName("items")]
    public IDictionary<string, V1alpha1StageStatusCurrentPromotionStatusFreightCollectionItems>? Items { get; set; }

    /// <summary>
    /// VerificationHistory is a stack of recent VerificationInfo. By default,
    /// the last ten VerificationInfo are stored.
    /// </summary>
    [JsonPropertyName("verificationHistory")]
    public IList<V1alpha1StageStatusCurrentPromotionStatusFreightCollectionVerificationHistory>? VerificationHistory { get; set; }
}

/// <summary>
/// HealthCheckStep describes a health check directive which can be executed by
/// a Stage to verify the health of a Promotion result.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusHealthChecks
{
    /// <summary>Config is the configuration for the directive.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>Uses identifies a runner that can execute this step.</summary>
    [JsonPropertyName("uses")]
    public required string Uses { get; set; }
}

/// <summary>
/// StepExecutionMetadata tracks metadata pertaining to the execution of
/// a promotion step.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatusStepExecutionMetadata
{
    /// <summary>Alias is the alias of the step.</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>
    /// ContinueOnError is a boolean value that, if set to true, will cause the
    /// Promotion to continue executing the next step even if this step fails. It
    /// also will not permit this failure to impact the overall status of the
    /// Promotion.
    /// </summary>
    [JsonPropertyName("continueOnError")]
    public bool? ContinueOnError { get; set; }

    /// <summary>ErrorCount tracks consecutive failed attempts to execute the step.</summary>
    [JsonPropertyName("errorCount")]
    public int? ErrorCount { get; set; }

    /// <summary>
    /// FinishedAt is the time at which the final attempt to execute the step
    /// completed.
    /// </summary>
    [JsonPropertyName("finishedAt")]
    public DateTime? FinishedAt { get; set; }

    /// <summary>Message is a display message about the step, including any errors.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// StartedAt is the time at which the first attempt to execute the step
    /// began.
    /// </summary>
    [JsonPropertyName("startedAt")]
    public DateTime? StartedAt { get; set; }

    /// <summary>Status is the high-level outcome of the step.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Status is the (optional) status of the Promotion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotionStatus
{
    /// <summary>
    /// CurrentStep is the index of the current promotion step being executed. This
    /// permits steps that have already run successfully to be skipped on
    /// subsequent reconciliations attempts.
    /// </summary>
    [JsonPropertyName("currentStep")]
    public long? CurrentStep { get; set; }

    /// <summary>FinishedAt is the time when the promotion was completed.</summary>
    [JsonPropertyName("finishedAt")]
    public DateTime? FinishedAt { get; set; }

    /// <summary>Freight is the detail of the piece of freight that was referenced by this promotion.</summary>
    [JsonPropertyName("freight")]
    public V1alpha1StageStatusCurrentPromotionStatusFreight? Freight { get; set; }

    /// <summary>
    /// FreightCollection contains the details of the piece of Freight referenced
    /// by this Promotion as well as any additional Freight that is carried over
    /// from the target Stage&apos;s current state.
    /// </summary>
    [JsonPropertyName("freightCollection")]
    public V1alpha1StageStatusCurrentPromotionStatusFreightCollection? FreightCollection { get; set; }

    /// <summary>
    /// HealthChecks contains the health check directives to be executed after
    /// the Promotion has completed.
    /// </summary>
    [JsonPropertyName("healthChecks")]
    public IList<V1alpha1StageStatusCurrentPromotionStatusHealthChecks>? HealthChecks { get; set; }

    /// <summary>
    /// LastHandledRefresh holds the value of the most recent AnnotationKeyRefresh
    /// annotation that was handled by the controller. This field can be used to
    /// determine whether the request to refresh the resource has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledRefresh")]
    public string? LastHandledRefresh { get; set; }

    /// <summary>
    /// Message is a display message about the promotion, including any errors
    /// preventing the Promotion controller from executing this Promotion.
    /// i.e. If the Phase field has a value of Failed, this field can be expected
    /// to explain why.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Phase describes where the Promotion currently is in its lifecycle.</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>StartedAt is the time when the promotion started.</summary>
    [JsonPropertyName("startedAt")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// State stores the state of the promotion process between reconciliation
    /// attempts.
    /// </summary>
    [JsonPropertyName("state")]
    public JsonNode? State { get; set; }

    /// <summary>
    /// StepExecutionMetadata tracks metadata pertaining to the execution
    /// of individual promotion steps.
    /// </summary>
    [JsonPropertyName("stepExecutionMetadata")]
    public IList<V1alpha1StageStatusCurrentPromotionStatusStepExecutionMetadata>? StepExecutionMetadata { get; set; }
}

/// <summary>CurrentPromotion is a reference to the currently Running promotion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusCurrentPromotion
{
    /// <summary>FinishedAt is the time at which the Promotion was completed.</summary>
    [JsonPropertyName("finishedAt")]
    public DateTime? FinishedAt { get; set; }

    /// <summary>Freight is the freight being promoted.</summary>
    [JsonPropertyName("freight")]
    public V1alpha1StageStatusCurrentPromotionFreight? Freight { get; set; }

    /// <summary>Name is the name of the Promotion.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Status is the (optional) status of the Promotion.</summary>
    [JsonPropertyName("status")]
    public V1alpha1StageStatusCurrentPromotionStatus? Status { get; set; }
}

/// <summary>ArtifactReference is a reference to a specific version of an artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusFreightHistoryItemsArtifacts
{
    /// <summary>
    /// ArtifactType specifies the type of artifact this is. Often, but not always,
    /// it will be the media type (MIME type) of the artifact referenced by this
    /// ArtifactReference.
    /// </summary>
    [JsonPropertyName("artifactType")]
    public string? ArtifactType { get; set; }

    /// <summary>
    /// Metadata is a JSON object containing a mostly opaque collection of artifact
    /// attributes. (It must be an object. It may not be a list or a scalar value.)
    /// &quot;Mostly&quot; because Kargo may understand how to interpret some documented,
    /// well-known, top-level keys. Those aside, this metadata is only understood
    /// by a corresponding Subscriber implementation that created it.
    /// </summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>
    /// SubscriptionName is the name of the Subscription that discovered this
    /// artifact.
    /// </summary>
    [JsonPropertyName("subscriptionName")]
    public required string SubscriptionName { get; set; }

    /// <summary>Version identifies a specific revision of this artifact.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>Chart describes a specific version of a Helm chart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusFreightHistoryItemsCharts
{
    /// <summary>Name specifies the name of the chart.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// RepoURL specifies the URL of a Helm chart repository. Classic chart
    /// repositories (using HTTP/S) can contain differently named charts. When this
    /// field points to such a repository, the Name field will specify the name of
    /// the chart within the repository. In the case of a repository within an OCI
    /// registry, the URL implicitly points to a specific chart and the Name field
    /// will be empty.
    /// </summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>Version specifies a particular version of the chart.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>GitCommit describes a specific commit from a specific Git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusFreightHistoryItemsCommits
{
    /// <summary>Author is the author of the commit.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>Branch denotes the branch of the repository where this commit was found.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Committer is the person who committed the commit.</summary>
    [JsonPropertyName("committer")]
    public string? Committer { get; set; }

    /// <summary>
    /// ID is the ID of a specific commit in the Git repository specified by
    /// RepoURL.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Message is the message associated with the commit. At present, this only
    /// contains the first line (subject) of the commit message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>RepoURL is the URL of a Git repository.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag denotes a tag in the repository that matched selection criteria and
    /// resolved to this commit.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Image describes a specific version of a container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusFreightHistoryItemsImages
{
    /// <summary>Annotations is a map of arbitrary metadata for the image.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Digest identifies a specific version of the image in the repository
    /// specified by RepoURL. This is a more precise identifier than Tag.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>RepoURL describes the repository in which the image can be found.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag identifies a specific version of the image in the repository specified
    /// by RepoURL.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Kind is the kind of resource from which Freight may have originated. At
/// present, this can only be &quot;Warehouse&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1StageStatusFreightHistoryItemsOriginKindEnum>))]
public enum V1alpha1StageStatusFreightHistoryItemsOriginKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusFreightHistoryItemsOrigin
{
    /// <summary>
    /// Kind is the kind of resource from which Freight may have originated. At
    /// present, this can only be &quot;Warehouse&quot;.
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1StageStatusFreightHistoryItemsOriginKindEnum Kind { get; set; }

    /// <summary>
    /// Name is the name of the resource of the kind indicated by the Kind field
    /// from which Freight may originate.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// FreightReference is a simplified representation of a piece of Freight -- not
/// a root resource type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusFreightHistoryItems
{
    /// <summary>
    /// Artifacts describes specific versions of artifacts other
    /// than Git repository commits, container images, and Helm charts.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1StageStatusFreightHistoryItemsArtifacts>? Artifacts { get; set; }

    /// <summary>Charts describes specific versions of specific Helm charts.</summary>
    [JsonPropertyName("charts")]
    public IList<V1alpha1StageStatusFreightHistoryItemsCharts>? Charts { get; set; }

    /// <summary>Commits describes specific Git repository commits.</summary>
    [JsonPropertyName("commits")]
    public IList<V1alpha1StageStatusFreightHistoryItemsCommits>? Commits { get; set; }

    /// <summary>Images describes specific versions of specific container images.</summary>
    [JsonPropertyName("images")]
    public IList<V1alpha1StageStatusFreightHistoryItemsImages>? Images { get; set; }

    /// <summary>
    /// Name is a system-assigned identifier derived deterministically from
    /// the contents of the Freight. I.e., two pieces of Freight can be compared
    /// for equality by comparing their Names.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
    [JsonPropertyName("origin")]
    public V1alpha1StageStatusFreightHistoryItemsOrigin? Origin { get; set; }
}

/// <summary>
/// AnalysisRun is a reference to the Argo Rollouts AnalysisRun that implements
/// the Verification process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusFreightHistoryVerificationHistoryAnalysisRun
{
    /// <summary>Name is the name of the AnalysisRun.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the namespace of the AnalysisRun.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    /// <summary>Phase is the last observed phase of the AnalysisRun referenced by Name.</summary>
    [JsonPropertyName("phase")]
    public required string Phase { get; set; }
}

/// <summary>
/// VerificationInfo contains the details of an instance of a Verification
/// process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusFreightHistoryVerificationHistory
{
    /// <summary>
    /// Actor is the name of the entity that initiated or aborted the
    /// Verification process.
    /// </summary>
    [JsonPropertyName("actor")]
    public string? Actor { get; set; }

    /// <summary>
    /// AnalysisRun is a reference to the Argo Rollouts AnalysisRun that implements
    /// the Verification process.
    /// </summary>
    [JsonPropertyName("analysisRun")]
    public V1alpha1StageStatusFreightHistoryVerificationHistoryAnalysisRun? AnalysisRun { get; set; }

    /// <summary>FinishTime is the time at which the Verification process finished.</summary>
    [JsonPropertyName("finishTime")]
    public DateTime? FinishTime { get; set; }

    /// <summary>ID is the identifier of the Verification process.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Message may contain additional information about why the verification
    /// process is in its current phase.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Phase describes the current phase of the Verification process. Generally,
    /// this will be a reflection of the underlying AnalysisRun&apos;s phase, however,
    /// there are exceptions to this, such as in the case where an AnalysisRun
    /// cannot be launched successfully.
    /// </summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>StartTime is the time at which the Verification process was started.</summary>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }
}

/// <summary>
/// FreightCollection is a collection of FreightReferences, each of which
/// represents a piece of Freight that has been selected for deployment to a
/// Stage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusFreightHistory
{
    /// <summary>
    /// ID is a unique and deterministically calculated identifier for the
    /// FreightCollection. It is updated on each use of the UpdateOrPush method.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Freight is a map of FreightReference objects, indexed by their Warehouse
    /// origin.
    /// </summary>
    [JsonPropertyName("items")]
    public IDictionary<string, V1alpha1StageStatusFreightHistoryItems>? Items { get; set; }

    /// <summary>
    /// VerificationHistory is a stack of recent VerificationInfo. By default,
    /// the last ten VerificationInfo are stored.
    /// </summary>
    [JsonPropertyName("verificationHistory")]
    public IList<V1alpha1StageStatusFreightHistoryVerificationHistory>? VerificationHistory { get; set; }
}

/// <summary>Health is the Stage&apos;s last observed health.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusHealth
{
    /// <summary>
    /// Config is the opaque configuration of all health checks performed on this
    /// Stage.
    /// </summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>
    /// Issues clarifies why a Stage in any state other than Healthy is in that
    /// state. This field will always be the empty when a Stage is Healthy.
    /// </summary>
    [JsonPropertyName("issues")]
    public IList<string>? Issues { get; set; }

    /// <summary>Output is the opaque output of all health checks performed on this Stage.</summary>
    [JsonPropertyName("output")]
    public JsonNode? Output { get; set; }

    /// <summary>Status describes the health of the Stage.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ArtifactReference is a reference to a specific version of an artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionFreightArtifacts
{
    /// <summary>
    /// ArtifactType specifies the type of artifact this is. Often, but not always,
    /// it will be the media type (MIME type) of the artifact referenced by this
    /// ArtifactReference.
    /// </summary>
    [JsonPropertyName("artifactType")]
    public string? ArtifactType { get; set; }

    /// <summary>
    /// Metadata is a JSON object containing a mostly opaque collection of artifact
    /// attributes. (It must be an object. It may not be a list or a scalar value.)
    /// &quot;Mostly&quot; because Kargo may understand how to interpret some documented,
    /// well-known, top-level keys. Those aside, this metadata is only understood
    /// by a corresponding Subscriber implementation that created it.
    /// </summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>
    /// SubscriptionName is the name of the Subscription that discovered this
    /// artifact.
    /// </summary>
    [JsonPropertyName("subscriptionName")]
    public required string SubscriptionName { get; set; }

    /// <summary>Version identifies a specific revision of this artifact.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>Chart describes a specific version of a Helm chart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionFreightCharts
{
    /// <summary>Name specifies the name of the chart.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// RepoURL specifies the URL of a Helm chart repository. Classic chart
    /// repositories (using HTTP/S) can contain differently named charts. When this
    /// field points to such a repository, the Name field will specify the name of
    /// the chart within the repository. In the case of a repository within an OCI
    /// registry, the URL implicitly points to a specific chart and the Name field
    /// will be empty.
    /// </summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>Version specifies a particular version of the chart.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>GitCommit describes a specific commit from a specific Git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionFreightCommits
{
    /// <summary>Author is the author of the commit.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>Branch denotes the branch of the repository where this commit was found.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Committer is the person who committed the commit.</summary>
    [JsonPropertyName("committer")]
    public string? Committer { get; set; }

    /// <summary>
    /// ID is the ID of a specific commit in the Git repository specified by
    /// RepoURL.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Message is the message associated with the commit. At present, this only
    /// contains the first line (subject) of the commit message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>RepoURL is the URL of a Git repository.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag denotes a tag in the repository that matched selection criteria and
    /// resolved to this commit.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Image describes a specific version of a container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionFreightImages
{
    /// <summary>Annotations is a map of arbitrary metadata for the image.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Digest identifies a specific version of the image in the repository
    /// specified by RepoURL. This is a more precise identifier than Tag.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>RepoURL describes the repository in which the image can be found.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag identifies a specific version of the image in the repository specified
    /// by RepoURL.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Kind is the kind of resource from which Freight may have originated. At
/// present, this can only be &quot;Warehouse&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1StageStatusLastPromotionFreightOriginKindEnum>))]
public enum V1alpha1StageStatusLastPromotionFreightOriginKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionFreightOrigin
{
    /// <summary>
    /// Kind is the kind of resource from which Freight may have originated. At
    /// present, this can only be &quot;Warehouse&quot;.
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1StageStatusLastPromotionFreightOriginKindEnum Kind { get; set; }

    /// <summary>
    /// Name is the name of the resource of the kind indicated by the Kind field
    /// from which Freight may originate.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Freight is the freight being promoted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionFreight
{
    /// <summary>
    /// Artifacts describes specific versions of artifacts other
    /// than Git repository commits, container images, and Helm charts.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1StageStatusLastPromotionFreightArtifacts>? Artifacts { get; set; }

    /// <summary>Charts describes specific versions of specific Helm charts.</summary>
    [JsonPropertyName("charts")]
    public IList<V1alpha1StageStatusLastPromotionFreightCharts>? Charts { get; set; }

    /// <summary>Commits describes specific Git repository commits.</summary>
    [JsonPropertyName("commits")]
    public IList<V1alpha1StageStatusLastPromotionFreightCommits>? Commits { get; set; }

    /// <summary>Images describes specific versions of specific container images.</summary>
    [JsonPropertyName("images")]
    public IList<V1alpha1StageStatusLastPromotionFreightImages>? Images { get; set; }

    /// <summary>
    /// Name is a system-assigned identifier derived deterministically from
    /// the contents of the Freight. I.e., two pieces of Freight can be compared
    /// for equality by comparing their Names.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
    [JsonPropertyName("origin")]
    public V1alpha1StageStatusLastPromotionFreightOrigin? Origin { get; set; }
}

/// <summary>ArtifactReference is a reference to a specific version of an artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightArtifacts
{
    /// <summary>
    /// ArtifactType specifies the type of artifact this is. Often, but not always,
    /// it will be the media type (MIME type) of the artifact referenced by this
    /// ArtifactReference.
    /// </summary>
    [JsonPropertyName("artifactType")]
    public string? ArtifactType { get; set; }

    /// <summary>
    /// Metadata is a JSON object containing a mostly opaque collection of artifact
    /// attributes. (It must be an object. It may not be a list or a scalar value.)
    /// &quot;Mostly&quot; because Kargo may understand how to interpret some documented,
    /// well-known, top-level keys. Those aside, this metadata is only understood
    /// by a corresponding Subscriber implementation that created it.
    /// </summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>
    /// SubscriptionName is the name of the Subscription that discovered this
    /// artifact.
    /// </summary>
    [JsonPropertyName("subscriptionName")]
    public required string SubscriptionName { get; set; }

    /// <summary>Version identifies a specific revision of this artifact.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>Chart describes a specific version of a Helm chart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightCharts
{
    /// <summary>Name specifies the name of the chart.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// RepoURL specifies the URL of a Helm chart repository. Classic chart
    /// repositories (using HTTP/S) can contain differently named charts. When this
    /// field points to such a repository, the Name field will specify the name of
    /// the chart within the repository. In the case of a repository within an OCI
    /// registry, the URL implicitly points to a specific chart and the Name field
    /// will be empty.
    /// </summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>Version specifies a particular version of the chart.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>GitCommit describes a specific commit from a specific Git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightCommits
{
    /// <summary>Author is the author of the commit.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>Branch denotes the branch of the repository where this commit was found.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Committer is the person who committed the commit.</summary>
    [JsonPropertyName("committer")]
    public string? Committer { get; set; }

    /// <summary>
    /// ID is the ID of a specific commit in the Git repository specified by
    /// RepoURL.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Message is the message associated with the commit. At present, this only
    /// contains the first line (subject) of the commit message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>RepoURL is the URL of a Git repository.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag denotes a tag in the repository that matched selection criteria and
    /// resolved to this commit.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Image describes a specific version of a container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightImages
{
    /// <summary>Annotations is a map of arbitrary metadata for the image.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Digest identifies a specific version of the image in the repository
    /// specified by RepoURL. This is a more precise identifier than Tag.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>RepoURL describes the repository in which the image can be found.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag identifies a specific version of the image in the repository specified
    /// by RepoURL.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Kind is the kind of resource from which Freight may have originated. At
/// present, this can only be &quot;Warehouse&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1StageStatusLastPromotionStatusFreightOriginKindEnum>))]
public enum V1alpha1StageStatusLastPromotionStatusFreightOriginKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightOrigin
{
    /// <summary>
    /// Kind is the kind of resource from which Freight may have originated. At
    /// present, this can only be &quot;Warehouse&quot;.
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1StageStatusLastPromotionStatusFreightOriginKindEnum Kind { get; set; }

    /// <summary>
    /// Name is the name of the resource of the kind indicated by the Kind field
    /// from which Freight may originate.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Freight is the detail of the piece of freight that was referenced by this promotion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreight
{
    /// <summary>
    /// Artifacts describes specific versions of artifacts other
    /// than Git repository commits, container images, and Helm charts.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1StageStatusLastPromotionStatusFreightArtifacts>? Artifacts { get; set; }

    /// <summary>Charts describes specific versions of specific Helm charts.</summary>
    [JsonPropertyName("charts")]
    public IList<V1alpha1StageStatusLastPromotionStatusFreightCharts>? Charts { get; set; }

    /// <summary>Commits describes specific Git repository commits.</summary>
    [JsonPropertyName("commits")]
    public IList<V1alpha1StageStatusLastPromotionStatusFreightCommits>? Commits { get; set; }

    /// <summary>Images describes specific versions of specific container images.</summary>
    [JsonPropertyName("images")]
    public IList<V1alpha1StageStatusLastPromotionStatusFreightImages>? Images { get; set; }

    /// <summary>
    /// Name is a system-assigned identifier derived deterministically from
    /// the contents of the Freight. I.e., two pieces of Freight can be compared
    /// for equality by comparing their Names.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
    [JsonPropertyName("origin")]
    public V1alpha1StageStatusLastPromotionStatusFreightOrigin? Origin { get; set; }
}

/// <summary>ArtifactReference is a reference to a specific version of an artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsArtifacts
{
    /// <summary>
    /// ArtifactType specifies the type of artifact this is. Often, but not always,
    /// it will be the media type (MIME type) of the artifact referenced by this
    /// ArtifactReference.
    /// </summary>
    [JsonPropertyName("artifactType")]
    public string? ArtifactType { get; set; }

    /// <summary>
    /// Metadata is a JSON object containing a mostly opaque collection of artifact
    /// attributes. (It must be an object. It may not be a list or a scalar value.)
    /// &quot;Mostly&quot; because Kargo may understand how to interpret some documented,
    /// well-known, top-level keys. Those aside, this metadata is only understood
    /// by a corresponding Subscriber implementation that created it.
    /// </summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>
    /// SubscriptionName is the name of the Subscription that discovered this
    /// artifact.
    /// </summary>
    [JsonPropertyName("subscriptionName")]
    public required string SubscriptionName { get; set; }

    /// <summary>Version identifies a specific revision of this artifact.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>Chart describes a specific version of a Helm chart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsCharts
{
    /// <summary>Name specifies the name of the chart.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// RepoURL specifies the URL of a Helm chart repository. Classic chart
    /// repositories (using HTTP/S) can contain differently named charts. When this
    /// field points to such a repository, the Name field will specify the name of
    /// the chart within the repository. In the case of a repository within an OCI
    /// registry, the URL implicitly points to a specific chart and the Name field
    /// will be empty.
    /// </summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>Version specifies a particular version of the chart.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>GitCommit describes a specific commit from a specific Git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsCommits
{
    /// <summary>Author is the author of the commit.</summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>Branch denotes the branch of the repository where this commit was found.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Committer is the person who committed the commit.</summary>
    [JsonPropertyName("committer")]
    public string? Committer { get; set; }

    /// <summary>
    /// ID is the ID of a specific commit in the Git repository specified by
    /// RepoURL.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Message is the message associated with the commit. At present, this only
    /// contains the first line (subject) of the commit message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>RepoURL is the URL of a Git repository.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag denotes a tag in the repository that matched selection criteria and
    /// resolved to this commit.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Image describes a specific version of a container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsImages
{
    /// <summary>Annotations is a map of arbitrary metadata for the image.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Digest identifies a specific version of the image in the repository
    /// specified by RepoURL. This is a more precise identifier than Tag.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>RepoURL describes the repository in which the image can be found.</summary>
    [JsonPropertyName("repoURL")]
    public string? RepoURL { get; set; }

    /// <summary>
    /// Tag identifies a specific version of the image in the repository specified
    /// by RepoURL.
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>
/// Kind is the kind of resource from which Freight may have originated. At
/// present, this can only be &quot;Warehouse&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsOriginKindEnum>))]
public enum V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsOriginKindEnum
{
    [EnumMember(Value = "Warehouse"), JsonStringEnumMemberName("Warehouse")]
    Warehouse
}

/// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsOrigin
{
    /// <summary>
    /// Kind is the kind of resource from which Freight may have originated. At
    /// present, this can only be &quot;Warehouse&quot;.
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsOriginKindEnum Kind { get; set; }

    /// <summary>
    /// Name is the name of the resource of the kind indicated by the Kind field
    /// from which Freight may originate.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// FreightReference is a simplified representation of a piece of Freight -- not
/// a root resource type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightCollectionItems
{
    /// <summary>
    /// Artifacts describes specific versions of artifacts other
    /// than Git repository commits, container images, and Helm charts.
    /// </summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsArtifacts>? Artifacts { get; set; }

    /// <summary>Charts describes specific versions of specific Helm charts.</summary>
    [JsonPropertyName("charts")]
    public IList<V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsCharts>? Charts { get; set; }

    /// <summary>Commits describes specific Git repository commits.</summary>
    [JsonPropertyName("commits")]
    public IList<V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsCommits>? Commits { get; set; }

    /// <summary>Images describes specific versions of specific container images.</summary>
    [JsonPropertyName("images")]
    public IList<V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsImages>? Images { get; set; }

    /// <summary>
    /// Name is a system-assigned identifier derived deterministically from
    /// the contents of the Freight. I.e., two pieces of Freight can be compared
    /// for equality by comparing their Names.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Origin describes a kind of Freight in terms of its origin.</summary>
    [JsonPropertyName("origin")]
    public V1alpha1StageStatusLastPromotionStatusFreightCollectionItemsOrigin? Origin { get; set; }
}

/// <summary>
/// AnalysisRun is a reference to the Argo Rollouts AnalysisRun that implements
/// the Verification process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightCollectionVerificationHistoryAnalysisRun
{
    /// <summary>Name is the name of the AnalysisRun.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the namespace of the AnalysisRun.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    /// <summary>Phase is the last observed phase of the AnalysisRun referenced by Name.</summary>
    [JsonPropertyName("phase")]
    public required string Phase { get; set; }
}

/// <summary>
/// VerificationInfo contains the details of an instance of a Verification
/// process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightCollectionVerificationHistory
{
    /// <summary>
    /// Actor is the name of the entity that initiated or aborted the
    /// Verification process.
    /// </summary>
    [JsonPropertyName("actor")]
    public string? Actor { get; set; }

    /// <summary>
    /// AnalysisRun is a reference to the Argo Rollouts AnalysisRun that implements
    /// the Verification process.
    /// </summary>
    [JsonPropertyName("analysisRun")]
    public V1alpha1StageStatusLastPromotionStatusFreightCollectionVerificationHistoryAnalysisRun? AnalysisRun { get; set; }

    /// <summary>FinishTime is the time at which the Verification process finished.</summary>
    [JsonPropertyName("finishTime")]
    public DateTime? FinishTime { get; set; }

    /// <summary>ID is the identifier of the Verification process.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Message may contain additional information about why the verification
    /// process is in its current phase.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Phase describes the current phase of the Verification process. Generally,
    /// this will be a reflection of the underlying AnalysisRun&apos;s phase, however,
    /// there are exceptions to this, such as in the case where an AnalysisRun
    /// cannot be launched successfully.
    /// </summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>StartTime is the time at which the Verification process was started.</summary>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }
}

/// <summary>
/// FreightCollection contains the details of the piece of Freight referenced
/// by this Promotion as well as any additional Freight that is carried over
/// from the target Stage&apos;s current state.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusFreightCollection
{
    /// <summary>
    /// ID is a unique and deterministically calculated identifier for the
    /// FreightCollection. It is updated on each use of the UpdateOrPush method.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Freight is a map of FreightReference objects, indexed by their Warehouse
    /// origin.
    /// </summary>
    [JsonPropertyName("items")]
    public IDictionary<string, V1alpha1StageStatusLastPromotionStatusFreightCollectionItems>? Items { get; set; }

    /// <summary>
    /// VerificationHistory is a stack of recent VerificationInfo. By default,
    /// the last ten VerificationInfo are stored.
    /// </summary>
    [JsonPropertyName("verificationHistory")]
    public IList<V1alpha1StageStatusLastPromotionStatusFreightCollectionVerificationHistory>? VerificationHistory { get; set; }
}

/// <summary>
/// HealthCheckStep describes a health check directive which can be executed by
/// a Stage to verify the health of a Promotion result.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusHealthChecks
{
    /// <summary>Config is the configuration for the directive.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>Uses identifies a runner that can execute this step.</summary>
    [JsonPropertyName("uses")]
    public required string Uses { get; set; }
}

/// <summary>
/// StepExecutionMetadata tracks metadata pertaining to the execution of
/// a promotion step.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatusStepExecutionMetadata
{
    /// <summary>Alias is the alias of the step.</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>
    /// ContinueOnError is a boolean value that, if set to true, will cause the
    /// Promotion to continue executing the next step even if this step fails. It
    /// also will not permit this failure to impact the overall status of the
    /// Promotion.
    /// </summary>
    [JsonPropertyName("continueOnError")]
    public bool? ContinueOnError { get; set; }

    /// <summary>ErrorCount tracks consecutive failed attempts to execute the step.</summary>
    [JsonPropertyName("errorCount")]
    public int? ErrorCount { get; set; }

    /// <summary>
    /// FinishedAt is the time at which the final attempt to execute the step
    /// completed.
    /// </summary>
    [JsonPropertyName("finishedAt")]
    public DateTime? FinishedAt { get; set; }

    /// <summary>Message is a display message about the step, including any errors.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// StartedAt is the time at which the first attempt to execute the step
    /// began.
    /// </summary>
    [JsonPropertyName("startedAt")]
    public DateTime? StartedAt { get; set; }

    /// <summary>Status is the high-level outcome of the step.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Status is the (optional) status of the Promotion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotionStatus
{
    /// <summary>
    /// CurrentStep is the index of the current promotion step being executed. This
    /// permits steps that have already run successfully to be skipped on
    /// subsequent reconciliations attempts.
    /// </summary>
    [JsonPropertyName("currentStep")]
    public long? CurrentStep { get; set; }

    /// <summary>FinishedAt is the time when the promotion was completed.</summary>
    [JsonPropertyName("finishedAt")]
    public DateTime? FinishedAt { get; set; }

    /// <summary>Freight is the detail of the piece of freight that was referenced by this promotion.</summary>
    [JsonPropertyName("freight")]
    public V1alpha1StageStatusLastPromotionStatusFreight? Freight { get; set; }

    /// <summary>
    /// FreightCollection contains the details of the piece of Freight referenced
    /// by this Promotion as well as any additional Freight that is carried over
    /// from the target Stage&apos;s current state.
    /// </summary>
    [JsonPropertyName("freightCollection")]
    public V1alpha1StageStatusLastPromotionStatusFreightCollection? FreightCollection { get; set; }

    /// <summary>
    /// HealthChecks contains the health check directives to be executed after
    /// the Promotion has completed.
    /// </summary>
    [JsonPropertyName("healthChecks")]
    public IList<V1alpha1StageStatusLastPromotionStatusHealthChecks>? HealthChecks { get; set; }

    /// <summary>
    /// LastHandledRefresh holds the value of the most recent AnnotationKeyRefresh
    /// annotation that was handled by the controller. This field can be used to
    /// determine whether the request to refresh the resource has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledRefresh")]
    public string? LastHandledRefresh { get; set; }

    /// <summary>
    /// Message is a display message about the promotion, including any errors
    /// preventing the Promotion controller from executing this Promotion.
    /// i.e. If the Phase field has a value of Failed, this field can be expected
    /// to explain why.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Phase describes where the Promotion currently is in its lifecycle.</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>StartedAt is the time when the promotion started.</summary>
    [JsonPropertyName("startedAt")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// State stores the state of the promotion process between reconciliation
    /// attempts.
    /// </summary>
    [JsonPropertyName("state")]
    public JsonNode? State { get; set; }

    /// <summary>
    /// StepExecutionMetadata tracks metadata pertaining to the execution
    /// of individual promotion steps.
    /// </summary>
    [JsonPropertyName("stepExecutionMetadata")]
    public IList<V1alpha1StageStatusLastPromotionStatusStepExecutionMetadata>? StepExecutionMetadata { get; set; }
}

/// <summary>LastPromotion is a reference to the last completed promotion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusLastPromotion
{
    /// <summary>FinishedAt is the time at which the Promotion was completed.</summary>
    [JsonPropertyName("finishedAt")]
    public DateTime? FinishedAt { get; set; }

    /// <summary>Freight is the freight being promoted.</summary>
    [JsonPropertyName("freight")]
    public V1alpha1StageStatusLastPromotionFreight? Freight { get; set; }

    /// <summary>Name is the name of the Promotion.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Status is the (optional) status of the Promotion.</summary>
    [JsonPropertyName("status")]
    public V1alpha1StageStatusLastPromotionStatus? Status { get; set; }
}

/// <summary>Status describes the Stage&apos;s current and recent Freight, health, and more.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatus
{
    /// <summary>
    /// AutoPromotionEnabled indicates whether automatic promotion is enabled
    /// for the Stage based on the ProjectConfig.
    /// </summary>
    [JsonPropertyName("autoPromotionEnabled")]
    public bool? AutoPromotionEnabled { get; set; }

    /// <summary>
    /// Conditions contains the last observations of the Stage&apos;s current
    /// state.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1StageStatusConditions>? Conditions { get; set; }

    /// <summary>CurrentPromotion is a reference to the currently Running promotion.</summary>
    [JsonPropertyName("currentPromotion")]
    public V1alpha1StageStatusCurrentPromotion? CurrentPromotion { get; set; }

    /// <summary>
    /// FreightHistory is a list of recent Freight selections that were deployed
    /// to the Stage. By default, the last ten Freight selections are stored.
    /// The first item in the list is the most recent Freight selection and
    /// currently deployed to the Stage, subsequent items are older selections.
    /// </summary>
    [JsonPropertyName("freightHistory")]
    public IList<V1alpha1StageStatusFreightHistory>? FreightHistory { get; set; }

    /// <summary>
    /// FreightSummary is human-readable text maintained by the controller that
    /// summarizes what Freight is currently deployed to the Stage. For Stages that
    /// request a single piece of Freight AND the request has been fulfilled, this
    /// field will simply contain the name of the Freight. For Stages that request
    /// a single piece of Freight AND the request has NOT been fulfilled, or for
    /// Stages that request multiple pieces of Freight, this field will contain a
    /// summary of fulfilled/requested Freight. The existence of this field is a
    /// workaround for kubectl limitations so that this complex but valuable
    /// information can be displayed in a column in response to `kubectl get
    /// stages`.
    /// </summary>
    [JsonPropertyName("freightSummary")]
    public string? FreightSummary { get; set; }

    /// <summary>Health is the Stage&apos;s last observed health.</summary>
    [JsonPropertyName("health")]
    public V1alpha1StageStatusHealth? Health { get; set; }

    /// <summary>
    /// LastHandledRefresh holds the value of the most recent AnnotationKeyRefresh
    /// annotation that was handled by the controller. This field can be used to
    /// determine whether the request to refresh the resource has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledRefresh")]
    public string? LastHandledRefresh { get; set; }

    /// <summary>LastPromotion is a reference to the last completed promotion.</summary>
    [JsonPropertyName("lastPromotion")]
    public V1alpha1StageStatusLastPromotion? LastPromotion { get; set; }

    /// <summary>
    /// Metadata is a map of arbitrary metadata associated with the Stage.
    /// This is useful for storing additional information about the Stage
    /// that can be shared across promotions, verifications, or other processes.
    /// </summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, JsonNode>? Metadata { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that this Stage
    /// status was reconciled against.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Stage is the Kargo API&apos;s main type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Stage : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1StageSpec>, IStatus<V1alpha1StageStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Stage";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "stages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Stage";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Spec describes sources of Freight used by the Stage and how to incorporate
    /// Freight into the Stage.
    /// </summary>
    [JsonPropertyName("spec")]
    public required V1alpha1StageSpec Spec { get; set; }

    /// <summary>Status describes the Stage&apos;s current and recent Freight, health, and more.</summary>
    [JsonPropertyName("status")]
    public V1alpha1StageStatus? Status { get; set; }
}