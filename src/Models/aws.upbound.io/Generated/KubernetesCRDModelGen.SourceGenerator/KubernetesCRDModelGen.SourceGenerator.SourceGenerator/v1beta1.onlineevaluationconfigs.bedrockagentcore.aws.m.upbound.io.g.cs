#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bedrockagentcore.aws.m.upbound.io;
/// <summary>OnlineEvaluationConfig is the Schema for the OnlineEvaluationConfigs API. Manages an AWS Bedrock AgentCore Online Evaluation Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OnlineEvaluationConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1OnlineEvaluationConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OnlineEvaluationConfigList";
    public const string KubeGroup = "bedrockagentcore.aws.m.upbound.io";
    public const string KubePluralName = "onlineevaluationconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OnlineEvaluationConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1OnlineEvaluationConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1OnlineEvaluationConfig> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicyResolutionEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicyResolveEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicyResolutionEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicyResolveEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Group in cloudwatchlogs to populate logGroupNames.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicy? Policy { get; set; }
}

/// <summary>CloudWatch logs configuration for reading agent traces. See cloudwatch_logs Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogs
{
    /// <summary>List of CloudWatch log group names to monitor for agent traces. Maximum 5.</summary>
    [JsonPropertyName("logGroupNames")]
    public IList<string>? LogGroupNames { get; set; }

    /// <summary>References to Group in cloudwatchlogs to populate logGroupNames.</summary>
    [JsonPropertyName("logGroupNamesRefs")]
    public IList<V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefs>? LogGroupNamesRefs { get; set; }

    /// <summary>Selector for a list of Group in cloudwatchlogs to populate logGroupNames.</summary>
    [JsonPropertyName("logGroupNamesSelector")]
    public V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelector? LogGroupNamesSelector { get; set; }

    /// <summary>List of service names to filter traces within the specified log groups.</summary>
    [JsonPropertyName("serviceNames")]
    public IList<string>? ServiceNames { get; set; }
}

/// <summary>Data source configuration specifying where to read agent traces. See data_source_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfig
{
    /// <summary>CloudWatch logs configuration for reading agent traces. See cloudwatch_logs Block below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfigCloudwatchLogs? CloudwatchLogs { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate evaluationExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate evaluationExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdRefPolicyResolutionEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdRefPolicyResolveEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Evaluator in bedrockagentcore to populate evaluatorId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdSelectorPolicyResolutionEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdSelectorPolicyResolveEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Evaluator in bedrockagentcore to populate evaluatorId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderEvaluator
{
    /// <summary>Unique identifier of the evaluator. Can reference builtin evaluators (e.g., Builtin.Helpfulness, Builtin.GoalSuccessRate) or custom evaluator IDs.</summary>
    [JsonPropertyName("evaluatorId")]
    public string? EvaluatorId { get; set; }

    /// <summary>Reference to a Evaluator in bedrockagentcore to populate evaluatorId.</summary>
    [JsonPropertyName("evaluatorIdRef")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdRef? EvaluatorIdRef { get; set; }

    /// <summary>Selector for a Evaluator in bedrockagentcore to populate evaluatorId.</summary>
    [JsonPropertyName("evaluatorIdSelector")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluatorEvaluatorIdSelector? EvaluatorIdSelector { get; set; }
}

/// <summary>Value to compare against. See value Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderRuleFilterValue
{
    /// <summary>Boolean value for true/false filtering.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Numeric value for numerical filtering.</summary>
    [JsonPropertyName("doubleValue")]
    public double? DoubleValue { get; set; }

    /// <summary>String value for text-based filtering.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderRuleFilter
{
    /// <summary>Key or field name to filter on within the agent trace data.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Comparison operator. Valid values: Equals, NotEquals, GreaterThan, LessThan, GreaterThanOrEqual, LessThanOrEqual, Contains, NotContains.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Value to compare against. See value Block below.</summary>
    [JsonPropertyName("value")]
    public V1beta1OnlineEvaluationConfigSpecForProviderRuleFilterValue? Value { get; set; }
}

/// <summary>Sampling configuration determining what percentage of agent traces to evaluate. See sampling_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderRuleSamplingConfig
{
    /// <summary>Percentage of agent traces to sample for evaluation, from 0.01 to 100.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }
}

/// <summary>Session configuration defining timeout settings for detecting when agent sessions are complete. See session_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderRuleSessionConfig
{
    /// <summary>Minutes of inactivity after which a session is considered complete. Between 1 and 60.</summary>
    [JsonPropertyName("sessionTimeoutMinutes")]
    public double? SessionTimeoutMinutes { get; set; }
}

/// <summary>Evaluation rule defining sampling configuration, filters, and session detection settings. See rule Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProviderRule
{
    /// <summary>List of filters determining which agent traces to evaluate. Maximum 5. See filter Block below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1OnlineEvaluationConfigSpecForProviderRuleFilter>? Filter { get; set; }

    /// <summary>Sampling configuration determining what percentage of agent traces to evaluate. See sampling_config Block below.</summary>
    [JsonPropertyName("samplingConfig")]
    public V1beta1OnlineEvaluationConfigSpecForProviderRuleSamplingConfig? SamplingConfig { get; set; }

    /// <summary>Session configuration defining timeout settings for detecting when agent sessions are complete. See session_config Block below.</summary>
    [JsonPropertyName("sessionConfig")]
    public V1beta1OnlineEvaluationConfigSpecForProviderRuleSessionConfig? SessionConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecForProvider
{
    /// <summary>Data source configuration specifying where to read agent traces. See data_source_config Block below.</summary>
    [JsonPropertyName("dataSourceConfig")]
    public V1beta1OnlineEvaluationConfigSpecForProviderDataSourceConfig? DataSourceConfig { get; set; }

    /// <summary>Description of the online evaluation configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to enable the online evaluation configuration immediately upon creation.</summary>
    [JsonPropertyName("enableOnCreate")]
    public bool? EnableOnCreate { get; set; }

    /// <summary>ARN of the IAM role that grants permissions to read from CloudWatch logs, write evaluation results, and invoke Amazon Bedrock models for evaluation.</summary>
    [JsonPropertyName("evaluationExecutionRoleArn")]
    public string? EvaluationExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate evaluationExecutionRoleArn.</summary>
    [JsonPropertyName("evaluationExecutionRoleArnRef")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnRef? EvaluationExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate evaluationExecutionRoleArn.</summary>
    [JsonPropertyName("evaluationExecutionRoleArnSelector")]
    public V1beta1OnlineEvaluationConfigSpecForProviderEvaluationExecutionRoleArnSelector? EvaluationExecutionRoleArnSelector { get; set; }

    /// <summary>List of evaluators to apply during online evaluation. Minimum 1, maximum 10. See evaluator Block below.</summary>
    [JsonPropertyName("evaluator")]
    public IList<V1beta1OnlineEvaluationConfigSpecForProviderEvaluator>? Evaluator { get; set; }

    /// <summary>Execution status to enable or disable the online evaluation. Valid values: ENABLED, DISABLED. Computed on create based on enable_on_create.</summary>
    [JsonPropertyName("executionStatus")]
    public string? ExecutionStatus { get; set; }

    /// <summary>Name of the online evaluation configuration. Must start with a letter and contain only alphanumeric characters and underscores, up to 48 characters.</summary>
    [JsonPropertyName("onlineEvaluationConfigName")]
    public string? OnlineEvaluationConfigName { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Evaluation rule defining sampling configuration, filters, and session detection settings. See rule Block below.</summary>
    [JsonPropertyName("rule")]
    public V1beta1OnlineEvaluationConfigSpecForProviderRule? Rule { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicyResolutionEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicyResolveEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicyResolutionEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicyResolveEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Group in cloudwatchlogs to populate logGroupNames.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelectorPolicy? Policy { get; set; }
}

/// <summary>CloudWatch logs configuration for reading agent traces. See cloudwatch_logs Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogs
{
    /// <summary>List of CloudWatch log group names to monitor for agent traces. Maximum 5.</summary>
    [JsonPropertyName("logGroupNames")]
    public IList<string>? LogGroupNames { get; set; }

    /// <summary>References to Group in cloudwatchlogs to populate logGroupNames.</summary>
    [JsonPropertyName("logGroupNamesRefs")]
    public IList<V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesRefs>? LogGroupNamesRefs { get; set; }

    /// <summary>Selector for a list of Group in cloudwatchlogs to populate logGroupNames.</summary>
    [JsonPropertyName("logGroupNamesSelector")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogsLogGroupNamesSelector? LogGroupNamesSelector { get; set; }

    /// <summary>List of service names to filter traces within the specified log groups.</summary>
    [JsonPropertyName("serviceNames")]
    public IList<string>? ServiceNames { get; set; }
}

/// <summary>Data source configuration specifying where to read agent traces. See data_source_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfig
{
    /// <summary>CloudWatch logs configuration for reading agent traces. See cloudwatch_logs Block below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfigCloudwatchLogs? CloudwatchLogs { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate evaluationExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate evaluationExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdRefPolicyResolutionEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdRefPolicyResolveEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Evaluator in bedrockagentcore to populate evaluatorId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdSelectorPolicyResolutionEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdSelectorPolicyResolveEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Evaluator in bedrockagentcore to populate evaluatorId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderEvaluator
{
    /// <summary>Unique identifier of the evaluator. Can reference builtin evaluators (e.g., Builtin.Helpfulness, Builtin.GoalSuccessRate) or custom evaluator IDs.</summary>
    [JsonPropertyName("evaluatorId")]
    public string? EvaluatorId { get; set; }

    /// <summary>Reference to a Evaluator in bedrockagentcore to populate evaluatorId.</summary>
    [JsonPropertyName("evaluatorIdRef")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdRef? EvaluatorIdRef { get; set; }

    /// <summary>Selector for a Evaluator in bedrockagentcore to populate evaluatorId.</summary>
    [JsonPropertyName("evaluatorIdSelector")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluatorEvaluatorIdSelector? EvaluatorIdSelector { get; set; }
}

/// <summary>Value to compare against. See value Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderRuleFilterValue
{
    /// <summary>Boolean value for true/false filtering.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Numeric value for numerical filtering.</summary>
    [JsonPropertyName("doubleValue")]
    public double? DoubleValue { get; set; }

    /// <summary>String value for text-based filtering.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderRuleFilter
{
    /// <summary>Key or field name to filter on within the agent trace data.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Comparison operator. Valid values: Equals, NotEquals, GreaterThan, LessThan, GreaterThanOrEqual, LessThanOrEqual, Contains, NotContains.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Value to compare against. See value Block below.</summary>
    [JsonPropertyName("value")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderRuleFilterValue? Value { get; set; }
}

/// <summary>Sampling configuration determining what percentage of agent traces to evaluate. See sampling_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderRuleSamplingConfig
{
    /// <summary>Percentage of agent traces to sample for evaluation, from 0.01 to 100.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }
}

/// <summary>Session configuration defining timeout settings for detecting when agent sessions are complete. See session_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderRuleSessionConfig
{
    /// <summary>Minutes of inactivity after which a session is considered complete. Between 1 and 60.</summary>
    [JsonPropertyName("sessionTimeoutMinutes")]
    public double? SessionTimeoutMinutes { get; set; }
}

/// <summary>Evaluation rule defining sampling configuration, filters, and session detection settings. See rule Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProviderRule
{
    /// <summary>List of filters determining which agent traces to evaluate. Maximum 5. See filter Block below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1OnlineEvaluationConfigSpecInitProviderRuleFilter>? Filter { get; set; }

    /// <summary>Sampling configuration determining what percentage of agent traces to evaluate. See sampling_config Block below.</summary>
    [JsonPropertyName("samplingConfig")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderRuleSamplingConfig? SamplingConfig { get; set; }

    /// <summary>Session configuration defining timeout settings for detecting when agent sessions are complete. See session_config Block below.</summary>
    [JsonPropertyName("sessionConfig")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderRuleSessionConfig? SessionConfig { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecInitProvider
{
    /// <summary>Data source configuration specifying where to read agent traces. See data_source_config Block below.</summary>
    [JsonPropertyName("dataSourceConfig")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderDataSourceConfig? DataSourceConfig { get; set; }

    /// <summary>Description of the online evaluation configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to enable the online evaluation configuration immediately upon creation.</summary>
    [JsonPropertyName("enableOnCreate")]
    public bool? EnableOnCreate { get; set; }

    /// <summary>ARN of the IAM role that grants permissions to read from CloudWatch logs, write evaluation results, and invoke Amazon Bedrock models for evaluation.</summary>
    [JsonPropertyName("evaluationExecutionRoleArn")]
    public string? EvaluationExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate evaluationExecutionRoleArn.</summary>
    [JsonPropertyName("evaluationExecutionRoleArnRef")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnRef? EvaluationExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate evaluationExecutionRoleArn.</summary>
    [JsonPropertyName("evaluationExecutionRoleArnSelector")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderEvaluationExecutionRoleArnSelector? EvaluationExecutionRoleArnSelector { get; set; }

    /// <summary>List of evaluators to apply during online evaluation. Minimum 1, maximum 10. See evaluator Block below.</summary>
    [JsonPropertyName("evaluator")]
    public IList<V1beta1OnlineEvaluationConfigSpecInitProviderEvaluator>? Evaluator { get; set; }

    /// <summary>Execution status to enable or disable the online evaluation. Valid values: ENABLED, DISABLED. Computed on create based on enable_on_create.</summary>
    [JsonPropertyName("executionStatus")]
    public string? ExecutionStatus { get; set; }

    /// <summary>Name of the online evaluation configuration. Must start with a letter and contain only alphanumeric characters and underscores, up to 48 characters.</summary>
    [JsonPropertyName("onlineEvaluationConfigName")]
    public string? OnlineEvaluationConfigName { get; set; }

    /// <summary>Evaluation rule defining sampling configuration, filters, and session detection settings. See rule Block below.</summary>
    [JsonPropertyName("rule")]
    public V1beta1OnlineEvaluationConfigSpecInitProviderRule? Rule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OnlineEvaluationConfigSpecManagementPoliciesEnum>))]
public enum V1beta1OnlineEvaluationConfigSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>OnlineEvaluationConfigSpec defines the desired state of OnlineEvaluationConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1OnlineEvaluationConfigSpecForProvider ForProvider { get; set; }

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
    public V1beta1OnlineEvaluationConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1OnlineEvaluationConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OnlineEvaluationConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OnlineEvaluationConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>CloudWatch logs configuration for reading agent traces. See cloudwatch_logs Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatusAtProviderDataSourceConfigCloudwatchLogs
{
    /// <summary>List of CloudWatch log group names to monitor for agent traces. Maximum 5.</summary>
    [JsonPropertyName("logGroupNames")]
    public IList<string>? LogGroupNames { get; set; }

    /// <summary>List of service names to filter traces within the specified log groups.</summary>
    [JsonPropertyName("serviceNames")]
    public IList<string>? ServiceNames { get; set; }
}

/// <summary>Data source configuration specifying where to read agent traces. See data_source_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatusAtProviderDataSourceConfig
{
    /// <summary>CloudWatch logs configuration for reading agent traces. See cloudwatch_logs Block below.</summary>
    [JsonPropertyName("cloudwatchLogs")]
    public V1beta1OnlineEvaluationConfigStatusAtProviderDataSourceConfigCloudwatchLogs? CloudwatchLogs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatusAtProviderEvaluator
{
    /// <summary>Unique identifier of the evaluator. Can reference builtin evaluators (e.g., Builtin.Helpfulness, Builtin.GoalSuccessRate) or custom evaluator IDs.</summary>
    [JsonPropertyName("evaluatorId")]
    public string? EvaluatorId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatusAtProviderOutputConfigCloudwatchConfig
{
    /// <summary>Name of the CloudWatch log group where evaluation results are written.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatusAtProviderOutputConfig
{
    /// <summary>CloudWatch configuration for evaluation results. See cloudwatch_config Block below.</summary>
    [JsonPropertyName("cloudwatchConfig")]
    public IList<V1beta1OnlineEvaluationConfigStatusAtProviderOutputConfigCloudwatchConfig>? CloudwatchConfig { get; set; }
}

/// <summary>Value to compare against. See value Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatusAtProviderRuleFilterValue
{
    /// <summary>Boolean value for true/false filtering.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>Numeric value for numerical filtering.</summary>
    [JsonPropertyName("doubleValue")]
    public double? DoubleValue { get; set; }

    /// <summary>String value for text-based filtering.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatusAtProviderRuleFilter
{
    /// <summary>Key or field name to filter on within the agent trace data.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Comparison operator. Valid values: Equals, NotEquals, GreaterThan, LessThan, GreaterThanOrEqual, LessThanOrEqual, Contains, NotContains.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Value to compare against. See value Block below.</summary>
    [JsonPropertyName("value")]
    public V1beta1OnlineEvaluationConfigStatusAtProviderRuleFilterValue? Value { get; set; }
}

/// <summary>Sampling configuration determining what percentage of agent traces to evaluate. See sampling_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatusAtProviderRuleSamplingConfig
{
    /// <summary>Percentage of agent traces to sample for evaluation, from 0.01 to 100.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }
}

/// <summary>Session configuration defining timeout settings for detecting when agent sessions are complete. See session_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatusAtProviderRuleSessionConfig
{
    /// <summary>Minutes of inactivity after which a session is considered complete. Between 1 and 60.</summary>
    [JsonPropertyName("sessionTimeoutMinutes")]
    public double? SessionTimeoutMinutes { get; set; }
}

/// <summary>Evaluation rule defining sampling configuration, filters, and session detection settings. See rule Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatusAtProviderRule
{
    /// <summary>List of filters determining which agent traces to evaluate. Maximum 5. See filter Block below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1OnlineEvaluationConfigStatusAtProviderRuleFilter>? Filter { get; set; }

    /// <summary>Sampling configuration determining what percentage of agent traces to evaluate. See sampling_config Block below.</summary>
    [JsonPropertyName("samplingConfig")]
    public V1beta1OnlineEvaluationConfigStatusAtProviderRuleSamplingConfig? SamplingConfig { get; set; }

    /// <summary>Session configuration defining timeout settings for detecting when agent sessions are complete. See session_config Block below.</summary>
    [JsonPropertyName("sessionConfig")]
    public V1beta1OnlineEvaluationConfigStatusAtProviderRuleSessionConfig? SessionConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatusAtProvider
{
    /// <summary>Data source configuration specifying where to read agent traces. See data_source_config Block below.</summary>
    [JsonPropertyName("dataSourceConfig")]
    public V1beta1OnlineEvaluationConfigStatusAtProviderDataSourceConfig? DataSourceConfig { get; set; }

    /// <summary>Description of the online evaluation configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to enable the online evaluation configuration immediately upon creation.</summary>
    [JsonPropertyName("enableOnCreate")]
    public bool? EnableOnCreate { get; set; }

    /// <summary>ARN of the IAM role that grants permissions to read from CloudWatch logs, write evaluation results, and invoke Amazon Bedrock models for evaluation.</summary>
    [JsonPropertyName("evaluationExecutionRoleArn")]
    public string? EvaluationExecutionRoleArn { get; set; }

    /// <summary>List of evaluators to apply during online evaluation. Minimum 1, maximum 10. See evaluator Block below.</summary>
    [JsonPropertyName("evaluator")]
    public IList<V1beta1OnlineEvaluationConfigStatusAtProviderEvaluator>? Evaluator { get; set; }

    /// <summary>Execution status to enable or disable the online evaluation. Valid values: ENABLED, DISABLED. Computed on create based on enable_on_create.</summary>
    [JsonPropertyName("executionStatus")]
    public string? ExecutionStatus { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of the online evaluation configuration.</summary>
    [JsonPropertyName("onlineEvaluationConfigArn")]
    public string? OnlineEvaluationConfigArn { get; set; }

    /// <summary>Unique identifier of the online evaluation configuration.</summary>
    [JsonPropertyName("onlineEvaluationConfigId")]
    public string? OnlineEvaluationConfigId { get; set; }

    /// <summary>Name of the online evaluation configuration. Must start with a letter and contain only alphanumeric characters and underscores, up to 48 characters.</summary>
    [JsonPropertyName("onlineEvaluationConfigName")]
    public string? OnlineEvaluationConfigName { get; set; }

    /// <summary>Configuration specifying where evaluation results are written. See output_config Block below.</summary>
    [JsonPropertyName("outputConfig")]
    public IList<V1beta1OnlineEvaluationConfigStatusAtProviderOutputConfig>? OutputConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Evaluation rule defining sampling configuration, filters, and session detection settings. See rule Block below.</summary>
    [JsonPropertyName("rule")]
    public V1beta1OnlineEvaluationConfigStatusAtProviderRule? Rule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatusConditions
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

/// <summary>OnlineEvaluationConfigStatus defines the observed state of OnlineEvaluationConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OnlineEvaluationConfigStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1OnlineEvaluationConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OnlineEvaluationConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OnlineEvaluationConfig is the Schema for the OnlineEvaluationConfigs API. Manages an AWS Bedrock AgentCore Online Evaluation Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OnlineEvaluationConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OnlineEvaluationConfigSpec>, IStatus<V1beta1OnlineEvaluationConfigStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OnlineEvaluationConfig";
    public const string KubeGroup = "bedrockagentcore.aws.m.upbound.io";
    public const string KubePluralName = "onlineevaluationconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OnlineEvaluationConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OnlineEvaluationConfigSpec defines the desired state of OnlineEvaluationConfig</summary>
    [JsonPropertyName("spec")]
    public required V1beta1OnlineEvaluationConfigSpec Spec { get; set; }

    /// <summary>OnlineEvaluationConfigStatus defines the observed state of OnlineEvaluationConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1OnlineEvaluationConfigStatus? Status { get; set; }
}