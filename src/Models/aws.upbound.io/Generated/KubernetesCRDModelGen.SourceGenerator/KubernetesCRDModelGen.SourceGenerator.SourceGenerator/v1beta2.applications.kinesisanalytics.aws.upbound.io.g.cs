#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kinesisanalytics.aws.upbound.io;
/// <summary>Application is the Schema for the Applications API. Provides a AWS Kinesis Analytics Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Application>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ApplicationList";
    public const string KubeGroup = "kinesisanalytics.aws.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kinesisanalytics.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApplicationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Application objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Application> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecDeletionPolicyEnum>))]
public enum V1beta2ApplicationSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelector
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
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelector
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
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The CloudWatch log stream options to monitor application errors.
/// See CloudWatch Logging Options below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderCloudwatchLoggingOptions
{
    /// <summary>The ARN of the CloudWatch Log Stream.</summary>
    [JsonPropertyName("logStreamArn")]
    public string? LogStreamArn { get; set; }

    /// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnRef")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnRef? LogStreamArnRef { get; set; }

    /// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnSelector")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsLogStreamArnSelector? LogStreamArnSelector { get; set; }

    /// <summary>The ARN of the IAM Role used to send application messages.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptionsRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>
/// The Kinesis Firehose configuration for the streaming source. Conflicts with kinesis_stream.
/// See Kinesis Firehose below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsKinesisFirehose
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnSelector
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
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnSelector
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
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The Kinesis Stream configuration for the streaming source. Conflicts with kinesis_firehose.
/// See Kinesis Stream below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsKinesisStream
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamResourceArnSelector? ResourceArnSelector { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStreamRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>
/// The number of Parallel in-application streams to create.
/// See Parallelism below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsParallelism
{
    /// <summary>The Count of streams.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>The Lambda function configuration. See Lambda below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsProcessingConfigurationLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// The Processing Configuration to transform records as they are received from the stream.
/// See Processing Configuration below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsProcessingConfiguration
{
    /// <summary>The Lambda function configuration. See Lambda below for more details.</summary>
    [JsonPropertyName("lambda")]
    public V1beta2ApplicationSpecForProviderInputsProcessingConfigurationLambda? Lambda { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsSchemaRecordColumns
{
    /// <summary>The Mapping reference to the data element.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SQL Type of the column.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>
/// Mapping information when the record format uses delimiters.
/// See CSV Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsSchemaRecordFormatMappingParametersCsv
{
    /// <summary>The Column Delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The Row Delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>
/// Mapping information when JSON is the record format on the streaming source.
/// See JSON Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsSchemaRecordFormatMappingParametersJson
{
    /// <summary>Path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>
/// The Mapping Information for the record format.
/// See Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsSchemaRecordFormatMappingParameters
{
    /// <summary>
    /// Mapping information when the record format uses delimiters.
    /// See CSV Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("csv")]
    public V1beta2ApplicationSpecForProviderInputsSchemaRecordFormatMappingParametersCsv? Csv { get; set; }

    /// <summary>
    /// Mapping information when JSON is the record format on the streaming source.
    /// See JSON Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("json")]
    public V1beta2ApplicationSpecForProviderInputsSchemaRecordFormatMappingParametersJson? Json { get; set; }
}

/// <summary>
/// The Record Format and mapping information to schematize a record.
/// See Record Format below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsSchemaRecordFormat
{
    /// <summary>
    /// The Mapping Information for the record format.
    /// See Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta2ApplicationSpecForProviderInputsSchemaRecordFormatMappingParameters? MappingParameters { get; set; }
}

/// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsSchema
{
    /// <summary>
    /// The Record Column mapping for the streaming source data element.
    /// See Record Columns below for more details.
    /// </summary>
    [JsonPropertyName("recordColumns")]
    public IList<V1beta2ApplicationSpecForProviderInputsSchemaRecordColumns>? RecordColumns { get; set; }

    /// <summary>The Encoding of the record in the streaming source.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>
    /// The Record Format and mapping information to schematize a record.
    /// See Record Format below for more details.
    /// </summary>
    [JsonPropertyName("recordFormat")]
    public V1beta2ApplicationSpecForProviderInputsSchemaRecordFormat? RecordFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputsStartingPositionConfiguration
{
    /// <summary>The starting position on the stream. Valid values: LAST_STOPPED_POINT, NOW, TRIM_HORIZON.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }
}

/// <summary>Input configuration of the application. See Inputs below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderInputs
{
    /// <summary>
    /// The Kinesis Firehose configuration for the streaming source. Conflicts with kinesis_stream.
    /// See Kinesis Firehose below for more details.
    /// </summary>
    [JsonPropertyName("kinesisFirehose")]
    public V1beta2ApplicationSpecForProviderInputsKinesisFirehose? KinesisFirehose { get; set; }

    /// <summary>
    /// The Kinesis Stream configuration for the streaming source. Conflicts with kinesis_firehose.
    /// See Kinesis Stream below for more details.
    /// </summary>
    [JsonPropertyName("kinesisStream")]
    public V1beta2ApplicationSpecForProviderInputsKinesisStream? KinesisStream { get; set; }

    /// <summary>The Name Prefix to use when creating an in-application stream.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>
    /// The number of Parallel in-application streams to create.
    /// See Parallelism below for more details.
    /// </summary>
    [JsonPropertyName("parallelism")]
    public V1beta2ApplicationSpecForProviderInputsParallelism? Parallelism { get; set; }

    /// <summary>
    /// The Processing Configuration to transform records as they are received from the stream.
    /// See Processing Configuration below for more details.
    /// </summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta2ApplicationSpecForProviderInputsProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta2ApplicationSpecForProviderInputsSchema? Schema { get; set; }

    /// <summary>
    /// The point at which the application starts processing records from the streaming source.
    /// See Starting Position Configuration below for more details.
    /// </summary>
    [JsonPropertyName("startingPositionConfiguration")]
    public IList<V1beta2ApplicationSpecForProviderInputsStartingPositionConfiguration>? StartingPositionConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelector
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
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelector
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
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The Kinesis Firehose configuration for the destination stream. Conflicts with kinesis_stream.
/// See Kinesis Firehose below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputsKinesisFirehose
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseResourceArnSelector? ResourceArnSelector { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehoseRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>
/// The Kinesis Stream configuration for the destination stream. Conflicts with kinesis_firehose.
/// See Kinesis Stream below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputsKinesisStream
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Lambda function destination. See Lambda below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputsLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Schema format of the data written to the destination. See Destination Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputsSchema
{
    /// <summary>The Format Type of the records on the output stream. Can be CSV or JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderOutputs
{
    /// <summary>
    /// The Kinesis Firehose configuration for the destination stream. Conflicts with kinesis_stream.
    /// See Kinesis Firehose below for more details.
    /// </summary>
    [JsonPropertyName("kinesisFirehose")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisFirehose? KinesisFirehose { get; set; }

    /// <summary>
    /// The Kinesis Stream configuration for the destination stream. Conflicts with kinesis_firehose.
    /// See Kinesis Stream below for more details.
    /// </summary>
    [JsonPropertyName("kinesisStream")]
    public V1beta2ApplicationSpecForProviderOutputsKinesisStream? KinesisStream { get; set; }

    /// <summary>The Lambda function destination. See Lambda below for more details.</summary>
    [JsonPropertyName("lambda")]
    public V1beta2ApplicationSpecForProviderOutputsLambda? Lambda { get; set; }

    /// <summary>The Name of the in-application stream.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Schema format of the data written to the destination. See Destination Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta2ApplicationSpecForProviderOutputsSchema? Schema { get; set; }
}

/// <summary>The S3 configuration for the reference data source. See S3 Reference below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderReferenceDataSourcesS3
{
    /// <summary>The S3 Bucket ARN.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>The File Key name containing reference data.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderReferenceDataSourcesSchemaRecordColumns
{
    /// <summary>The Mapping reference to the data element.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SQL Type of the column.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>
/// Mapping information when the record format uses delimiters.
/// See CSV Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormatMappingParametersCsv
{
    /// <summary>The Column Delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The Row Delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>
/// Mapping information when JSON is the record format on the streaming source.
/// See JSON Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormatMappingParametersJson
{
    /// <summary>Path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>
/// The Mapping Information for the record format.
/// See Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormatMappingParameters
{
    /// <summary>
    /// Mapping information when the record format uses delimiters.
    /// See CSV Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("csv")]
    public V1beta2ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormatMappingParametersCsv? Csv { get; set; }

    /// <summary>
    /// Mapping information when JSON is the record format on the streaming source.
    /// See JSON Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("json")]
    public V1beta2ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormatMappingParametersJson? Json { get; set; }
}

/// <summary>
/// The Record Format and mapping information to schematize a record.
/// See Record Format below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormat
{
    /// <summary>
    /// The Mapping Information for the record format.
    /// See Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta2ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormatMappingParameters? MappingParameters { get; set; }
}

/// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderReferenceDataSourcesSchema
{
    /// <summary>
    /// The Record Column mapping for the streaming source data element.
    /// See Record Columns below for more details.
    /// </summary>
    [JsonPropertyName("recordColumns")]
    public IList<V1beta2ApplicationSpecForProviderReferenceDataSourcesSchemaRecordColumns>? RecordColumns { get; set; }

    /// <summary>The Encoding of the record in the streaming source.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>
    /// The Record Format and mapping information to schematize a record.
    /// See Record Format below for more details.
    /// </summary>
    [JsonPropertyName("recordFormat")]
    public V1beta2ApplicationSpecForProviderReferenceDataSourcesSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary>
/// An S3 Reference Data Source for the application.
/// See Reference Data Sources below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProviderReferenceDataSources
{
    /// <summary>The S3 configuration for the reference data source. See S3 Reference below for more details.</summary>
    [JsonPropertyName("s3")]
    public V1beta2ApplicationSpecForProviderReferenceDataSourcesS3? S3 { get; set; }

    /// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta2ApplicationSpecForProviderReferenceDataSourcesSchema? Schema { get; set; }

    /// <summary>The in-application Table Name.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecForProvider
{
    /// <summary>
    /// The CloudWatch log stream options to monitor application errors.
    /// See CloudWatch Logging Options below for more details.
    /// </summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta2ApplicationSpecForProviderCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>SQL Code to transform input data, and generate output.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Description of the application.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Input configuration of the application. See Inputs below for more details.</summary>
    [JsonPropertyName("inputs")]
    public V1beta2ApplicationSpecForProviderInputs? Inputs { get; set; }

    /// <summary>Output destination configuration of the application. See Outputs below for more details.</summary>
    [JsonPropertyName("outputs")]
    public IList<V1beta2ApplicationSpecForProviderOutputs>? Outputs { get; set; }

    /// <summary>
    /// An S3 Reference Data Source for the application.
    /// See Reference Data Sources below for more details.
    /// </summary>
    [JsonPropertyName("referenceDataSources")]
    public V1beta2ApplicationSpecForProviderReferenceDataSources? ReferenceDataSources { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// Whether to start or stop the Kinesis Analytics Application. To start an application, an input with a defined starting_position must be configured.
    /// To modify an application&apos;s starting position, first stop the application by setting start_application = false, then update starting_position and set start_application = true.
    /// </summary>
    [JsonPropertyName("startApplication")]
    public bool? StartApplication { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelector
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
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelector
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
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The CloudWatch log stream options to monitor application errors.
/// See CloudWatch Logging Options below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptions
{
    /// <summary>The ARN of the CloudWatch Log Stream.</summary>
    [JsonPropertyName("logStreamArn")]
    public string? LogStreamArn { get; set; }

    /// <summary>Reference to a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnRef")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnRef? LogStreamArnRef { get; set; }

    /// <summary>Selector for a Stream in cloudwatchlogs to populate logStreamArn.</summary>
    [JsonPropertyName("logStreamArnSelector")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsLogStreamArnSelector? LogStreamArnSelector { get; set; }

    /// <summary>The ARN of the IAM Role used to send application messages.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptionsRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>
/// The Kinesis Firehose configuration for the streaming source. Conflicts with kinesis_stream.
/// See Kinesis Firehose below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsKinesisFirehose
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelector
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
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelector
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
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The Kinesis Stream configuration for the streaming source. Conflicts with kinesis_firehose.
/// See Kinesis Stream below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsKinesisStream
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a Stream in kinesis to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamResourceArnSelector? ResourceArnSelector { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStreamRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>
/// The number of Parallel in-application streams to create.
/// See Parallelism below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsParallelism
{
    /// <summary>The Count of streams.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>The Lambda function configuration. See Lambda below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsProcessingConfigurationLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// The Processing Configuration to transform records as they are received from the stream.
/// See Processing Configuration below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsProcessingConfiguration
{
    /// <summary>The Lambda function configuration. See Lambda below for more details.</summary>
    [JsonPropertyName("lambda")]
    public V1beta2ApplicationSpecInitProviderInputsProcessingConfigurationLambda? Lambda { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsSchemaRecordColumns
{
    /// <summary>The Mapping reference to the data element.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SQL Type of the column.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>
/// Mapping information when the record format uses delimiters.
/// See CSV Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsSchemaRecordFormatMappingParametersCsv
{
    /// <summary>The Column Delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The Row Delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>
/// Mapping information when JSON is the record format on the streaming source.
/// See JSON Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsSchemaRecordFormatMappingParametersJson
{
    /// <summary>Path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>
/// The Mapping Information for the record format.
/// See Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsSchemaRecordFormatMappingParameters
{
    /// <summary>
    /// Mapping information when the record format uses delimiters.
    /// See CSV Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("csv")]
    public V1beta2ApplicationSpecInitProviderInputsSchemaRecordFormatMappingParametersCsv? Csv { get; set; }

    /// <summary>
    /// Mapping information when JSON is the record format on the streaming source.
    /// See JSON Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("json")]
    public V1beta2ApplicationSpecInitProviderInputsSchemaRecordFormatMappingParametersJson? Json { get; set; }
}

/// <summary>
/// The Record Format and mapping information to schematize a record.
/// See Record Format below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsSchemaRecordFormat
{
    /// <summary>
    /// The Mapping Information for the record format.
    /// See Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta2ApplicationSpecInitProviderInputsSchemaRecordFormatMappingParameters? MappingParameters { get; set; }
}

/// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsSchema
{
    /// <summary>
    /// The Record Column mapping for the streaming source data element.
    /// See Record Columns below for more details.
    /// </summary>
    [JsonPropertyName("recordColumns")]
    public IList<V1beta2ApplicationSpecInitProviderInputsSchemaRecordColumns>? RecordColumns { get; set; }

    /// <summary>The Encoding of the record in the streaming source.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>
    /// The Record Format and mapping information to schematize a record.
    /// See Record Format below for more details.
    /// </summary>
    [JsonPropertyName("recordFormat")]
    public V1beta2ApplicationSpecInitProviderInputsSchemaRecordFormat? RecordFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputsStartingPositionConfiguration
{
    /// <summary>The starting position on the stream. Valid values: LAST_STOPPED_POINT, NOW, TRIM_HORIZON.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }
}

/// <summary>Input configuration of the application. See Inputs below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderInputs
{
    /// <summary>
    /// The Kinesis Firehose configuration for the streaming source. Conflicts with kinesis_stream.
    /// See Kinesis Firehose below for more details.
    /// </summary>
    [JsonPropertyName("kinesisFirehose")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisFirehose? KinesisFirehose { get; set; }

    /// <summary>
    /// The Kinesis Stream configuration for the streaming source. Conflicts with kinesis_firehose.
    /// See Kinesis Stream below for more details.
    /// </summary>
    [JsonPropertyName("kinesisStream")]
    public V1beta2ApplicationSpecInitProviderInputsKinesisStream? KinesisStream { get; set; }

    /// <summary>The Name Prefix to use when creating an in-application stream.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>
    /// The number of Parallel in-application streams to create.
    /// See Parallelism below for more details.
    /// </summary>
    [JsonPropertyName("parallelism")]
    public V1beta2ApplicationSpecInitProviderInputsParallelism? Parallelism { get; set; }

    /// <summary>
    /// The Processing Configuration to transform records as they are received from the stream.
    /// See Processing Configuration below for more details.
    /// </summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta2ApplicationSpecInitProviderInputsProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta2ApplicationSpecInitProviderInputsSchema? Schema { get; set; }

    /// <summary>
    /// The point at which the application starts processing records from the streaming source.
    /// See Starting Position Configuration below for more details.
    /// </summary>
    [JsonPropertyName("startingPositionConfiguration")]
    public IList<V1beta2ApplicationSpecInitProviderInputsStartingPositionConfiguration>? StartingPositionConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelector
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
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelector
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
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The Kinesis Firehose configuration for the destination stream. Conflicts with kinesis_stream.
/// See Kinesis Firehose below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputsKinesisFirehose
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseResourceArnSelector? ResourceArnSelector { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehoseRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>
/// The Kinesis Stream configuration for the destination stream. Conflicts with kinesis_firehose.
/// See Kinesis Stream below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputsKinesisStream
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Lambda function destination. See Lambda below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputsLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Schema format of the data written to the destination. See Destination Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputsSchema
{
    /// <summary>The Format Type of the records on the output stream. Can be CSV or JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderOutputs
{
    /// <summary>
    /// The Kinesis Firehose configuration for the destination stream. Conflicts with kinesis_stream.
    /// See Kinesis Firehose below for more details.
    /// </summary>
    [JsonPropertyName("kinesisFirehose")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisFirehose? KinesisFirehose { get; set; }

    /// <summary>
    /// The Kinesis Stream configuration for the destination stream. Conflicts with kinesis_firehose.
    /// See Kinesis Stream below for more details.
    /// </summary>
    [JsonPropertyName("kinesisStream")]
    public V1beta2ApplicationSpecInitProviderOutputsKinesisStream? KinesisStream { get; set; }

    /// <summary>The Lambda function destination. See Lambda below for more details.</summary>
    [JsonPropertyName("lambda")]
    public V1beta2ApplicationSpecInitProviderOutputsLambda? Lambda { get; set; }

    /// <summary>The Name of the in-application stream.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Schema format of the data written to the destination. See Destination Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta2ApplicationSpecInitProviderOutputsSchema? Schema { get; set; }
}

/// <summary>The S3 configuration for the reference data source. See S3 Reference below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderReferenceDataSourcesS3
{
    /// <summary>The S3 Bucket ARN.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>The File Key name containing reference data.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordColumns
{
    /// <summary>The Mapping reference to the data element.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SQL Type of the column.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>
/// Mapping information when the record format uses delimiters.
/// See CSV Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormatMappingParametersCsv
{
    /// <summary>The Column Delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The Row Delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>
/// Mapping information when JSON is the record format on the streaming source.
/// See JSON Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormatMappingParametersJson
{
    /// <summary>Path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>
/// The Mapping Information for the record format.
/// See Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormatMappingParameters
{
    /// <summary>
    /// Mapping information when the record format uses delimiters.
    /// See CSV Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("csv")]
    public V1beta2ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormatMappingParametersCsv? Csv { get; set; }

    /// <summary>
    /// Mapping information when JSON is the record format on the streaming source.
    /// See JSON Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("json")]
    public V1beta2ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormatMappingParametersJson? Json { get; set; }
}

/// <summary>
/// The Record Format and mapping information to schematize a record.
/// See Record Format below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormat
{
    /// <summary>
    /// The Mapping Information for the record format.
    /// See Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta2ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormatMappingParameters? MappingParameters { get; set; }
}

/// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderReferenceDataSourcesSchema
{
    /// <summary>
    /// The Record Column mapping for the streaming source data element.
    /// See Record Columns below for more details.
    /// </summary>
    [JsonPropertyName("recordColumns")]
    public IList<V1beta2ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordColumns>? RecordColumns { get; set; }

    /// <summary>The Encoding of the record in the streaming source.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>
    /// The Record Format and mapping information to schematize a record.
    /// See Record Format below for more details.
    /// </summary>
    [JsonPropertyName("recordFormat")]
    public V1beta2ApplicationSpecInitProviderReferenceDataSourcesSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary>
/// An S3 Reference Data Source for the application.
/// See Reference Data Sources below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecInitProviderReferenceDataSources
{
    /// <summary>The S3 configuration for the reference data source. See S3 Reference below for more details.</summary>
    [JsonPropertyName("s3")]
    public V1beta2ApplicationSpecInitProviderReferenceDataSourcesS3? S3 { get; set; }

    /// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta2ApplicationSpecInitProviderReferenceDataSourcesSchema? Schema { get; set; }

    /// <summary>The in-application Table Name.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
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
public partial class V1beta2ApplicationSpecInitProvider
{
    /// <summary>
    /// The CloudWatch log stream options to monitor application errors.
    /// See CloudWatch Logging Options below for more details.
    /// </summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta2ApplicationSpecInitProviderCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>SQL Code to transform input data, and generate output.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Description of the application.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Input configuration of the application. See Inputs below for more details.</summary>
    [JsonPropertyName("inputs")]
    public V1beta2ApplicationSpecInitProviderInputs? Inputs { get; set; }

    /// <summary>Output destination configuration of the application. See Outputs below for more details.</summary>
    [JsonPropertyName("outputs")]
    public IList<V1beta2ApplicationSpecInitProviderOutputs>? Outputs { get; set; }

    /// <summary>
    /// An S3 Reference Data Source for the application.
    /// See Reference Data Sources below for more details.
    /// </summary>
    [JsonPropertyName("referenceDataSources")]
    public V1beta2ApplicationSpecInitProviderReferenceDataSources? ReferenceDataSources { get; set; }

    /// <summary>
    /// Whether to start or stop the Kinesis Analytics Application. To start an application, an input with a defined starting_position must be configured.
    /// To modify an application&apos;s starting position, first stop the application by setting start_application = false, then update starting_position and set start_application = true.
    /// </summary>
    [JsonPropertyName("startApplication")]
    public bool? StartApplication { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecManagementPoliciesEnum>))]
public enum V1beta2ApplicationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ApplicationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ApplicationSpec defines the desired state of Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationSpec
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
    public V1beta2ApplicationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ApplicationSpecForProvider ForProvider { get; set; }

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
    public V1beta2ApplicationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ApplicationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ApplicationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ApplicationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// The CloudWatch log stream options to monitor application errors.
/// See CloudWatch Logging Options below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderCloudwatchLoggingOptions
{
    /// <summary>The ARN of the Kinesis Analytics Application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ARN of the CloudWatch Log Stream.</summary>
    [JsonPropertyName("logStreamArn")]
    public string? LogStreamArn { get; set; }

    /// <summary>The ARN of the IAM Role used to send application messages.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// The Kinesis Firehose configuration for the streaming source. Conflicts with kinesis_stream.
/// See Kinesis Firehose below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputsKinesisFirehose
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// The Kinesis Stream configuration for the streaming source. Conflicts with kinesis_firehose.
/// See Kinesis Stream below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputsKinesisStream
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// The number of Parallel in-application streams to create.
/// See Parallelism below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputsParallelism
{
    /// <summary>The Count of streams.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>The Lambda function configuration. See Lambda below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputsProcessingConfigurationLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// The Processing Configuration to transform records as they are received from the stream.
/// See Processing Configuration below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputsProcessingConfiguration
{
    /// <summary>The Lambda function configuration. See Lambda below for more details.</summary>
    [JsonPropertyName("lambda")]
    public V1beta2ApplicationStatusAtProviderInputsProcessingConfigurationLambda? Lambda { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputsSchemaRecordColumns
{
    /// <summary>The Mapping reference to the data element.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SQL Type of the column.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>
/// Mapping information when the record format uses delimiters.
/// See CSV Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputsSchemaRecordFormatMappingParametersCsv
{
    /// <summary>The Column Delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The Row Delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>
/// Mapping information when JSON is the record format on the streaming source.
/// See JSON Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputsSchemaRecordFormatMappingParametersJson
{
    /// <summary>Path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>
/// The Mapping Information for the record format.
/// See Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputsSchemaRecordFormatMappingParameters
{
    /// <summary>
    /// Mapping information when the record format uses delimiters.
    /// See CSV Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("csv")]
    public V1beta2ApplicationStatusAtProviderInputsSchemaRecordFormatMappingParametersCsv? Csv { get; set; }

    /// <summary>
    /// Mapping information when JSON is the record format on the streaming source.
    /// See JSON Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("json")]
    public V1beta2ApplicationStatusAtProviderInputsSchemaRecordFormatMappingParametersJson? Json { get; set; }
}

/// <summary>
/// The Record Format and mapping information to schematize a record.
/// See Record Format below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputsSchemaRecordFormat
{
    /// <summary>
    /// The Mapping Information for the record format.
    /// See Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta2ApplicationStatusAtProviderInputsSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The Format Type of the records on the output stream. Can be CSV or JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputsSchema
{
    /// <summary>
    /// The Record Column mapping for the streaming source data element.
    /// See Record Columns below for more details.
    /// </summary>
    [JsonPropertyName("recordColumns")]
    public IList<V1beta2ApplicationStatusAtProviderInputsSchemaRecordColumns>? RecordColumns { get; set; }

    /// <summary>The Encoding of the record in the streaming source.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>
    /// The Record Format and mapping information to schematize a record.
    /// See Record Format below for more details.
    /// </summary>
    [JsonPropertyName("recordFormat")]
    public V1beta2ApplicationStatusAtProviderInputsSchemaRecordFormat? RecordFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputsStartingPositionConfiguration
{
    /// <summary>The starting position on the stream. Valid values: LAST_STOPPED_POINT, NOW, TRIM_HORIZON.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }
}

/// <summary>Input configuration of the application. See Inputs below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderInputs
{
    /// <summary>The ARN of the Kinesis Analytics Application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The Kinesis Firehose configuration for the streaming source. Conflicts with kinesis_stream.
    /// See Kinesis Firehose below for more details.
    /// </summary>
    [JsonPropertyName("kinesisFirehose")]
    public V1beta2ApplicationStatusAtProviderInputsKinesisFirehose? KinesisFirehose { get; set; }

    /// <summary>
    /// The Kinesis Stream configuration for the streaming source. Conflicts with kinesis_firehose.
    /// See Kinesis Stream below for more details.
    /// </summary>
    [JsonPropertyName("kinesisStream")]
    public V1beta2ApplicationStatusAtProviderInputsKinesisStream? KinesisStream { get; set; }

    /// <summary>The Name Prefix to use when creating an in-application stream.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>
    /// The number of Parallel in-application streams to create.
    /// See Parallelism below for more details.
    /// </summary>
    [JsonPropertyName("parallelism")]
    public V1beta2ApplicationStatusAtProviderInputsParallelism? Parallelism { get; set; }

    /// <summary>
    /// The Processing Configuration to transform records as they are received from the stream.
    /// See Processing Configuration below for more details.
    /// </summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta2ApplicationStatusAtProviderInputsProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta2ApplicationStatusAtProviderInputsSchema? Schema { get; set; }

    /// <summary>
    /// The point at which the application starts processing records from the streaming source.
    /// See Starting Position Configuration below for more details.
    /// </summary>
    [JsonPropertyName("startingPositionConfiguration")]
    public IList<V1beta2ApplicationStatusAtProviderInputsStartingPositionConfiguration>? StartingPositionConfiguration { get; set; }

    [JsonPropertyName("streamNames")]
    public IList<string>? StreamNames { get; set; }
}

/// <summary>
/// The Kinesis Firehose configuration for the destination stream. Conflicts with kinesis_stream.
/// See Kinesis Firehose below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderOutputsKinesisFirehose
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// The Kinesis Stream configuration for the destination stream. Conflicts with kinesis_firehose.
/// See Kinesis Stream below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderOutputsKinesisStream
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Lambda function destination. See Lambda below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderOutputsLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Schema format of the data written to the destination. See Destination Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderOutputsSchema
{
    /// <summary>The Format Type of the records on the output stream. Can be CSV or JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderOutputs
{
    /// <summary>The ARN of the Kinesis Analytics Application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The Kinesis Firehose configuration for the destination stream. Conflicts with kinesis_stream.
    /// See Kinesis Firehose below for more details.
    /// </summary>
    [JsonPropertyName("kinesisFirehose")]
    public V1beta2ApplicationStatusAtProviderOutputsKinesisFirehose? KinesisFirehose { get; set; }

    /// <summary>
    /// The Kinesis Stream configuration for the destination stream. Conflicts with kinesis_firehose.
    /// See Kinesis Stream below for more details.
    /// </summary>
    [JsonPropertyName("kinesisStream")]
    public V1beta2ApplicationStatusAtProviderOutputsKinesisStream? KinesisStream { get; set; }

    /// <summary>The Lambda function destination. See Lambda below for more details.</summary>
    [JsonPropertyName("lambda")]
    public V1beta2ApplicationStatusAtProviderOutputsLambda? Lambda { get; set; }

    /// <summary>The Name of the in-application stream.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Schema format of the data written to the destination. See Destination Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta2ApplicationStatusAtProviderOutputsSchema? Schema { get; set; }
}

/// <summary>The S3 configuration for the reference data source. See S3 Reference below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderReferenceDataSourcesS3
{
    /// <summary>The S3 Bucket ARN.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>The File Key name containing reference data.</summary>
    [JsonPropertyName("fileKey")]
    public string? FileKey { get; set; }

    /// <summary>The IAM Role ARN to read the data.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordColumns
{
    /// <summary>The Mapping reference to the data element.</summary>
    [JsonPropertyName("mapping")]
    public string? Mapping { get; set; }

    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SQL Type of the column.</summary>
    [JsonPropertyName("sqlType")]
    public string? SqlType { get; set; }
}

/// <summary>
/// Mapping information when the record format uses delimiters.
/// See CSV Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormatMappingParametersCsv
{
    /// <summary>The Column Delimiter.</summary>
    [JsonPropertyName("recordColumnDelimiter")]
    public string? RecordColumnDelimiter { get; set; }

    /// <summary>The Row Delimiter.</summary>
    [JsonPropertyName("recordRowDelimiter")]
    public string? RecordRowDelimiter { get; set; }
}

/// <summary>
/// Mapping information when JSON is the record format on the streaming source.
/// See JSON Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormatMappingParametersJson
{
    /// <summary>Path to the top-level parent that contains the records.</summary>
    [JsonPropertyName("recordRowPath")]
    public string? RecordRowPath { get; set; }
}

/// <summary>
/// The Mapping Information for the record format.
/// See Mapping Parameters below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormatMappingParameters
{
    /// <summary>
    /// Mapping information when the record format uses delimiters.
    /// See CSV Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("csv")]
    public V1beta2ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormatMappingParametersCsv? Csv { get; set; }

    /// <summary>
    /// Mapping information when JSON is the record format on the streaming source.
    /// See JSON Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("json")]
    public V1beta2ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormatMappingParametersJson? Json { get; set; }
}

/// <summary>
/// The Record Format and mapping information to schematize a record.
/// See Record Format below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormat
{
    /// <summary>
    /// The Mapping Information for the record format.
    /// See Mapping Parameters below for more details.
    /// </summary>
    [JsonPropertyName("mappingParameters")]
    public V1beta2ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormatMappingParameters? MappingParameters { get; set; }

    /// <summary>The Format Type of the records on the output stream. Can be CSV or JSON.</summary>
    [JsonPropertyName("recordFormatType")]
    public string? RecordFormatType { get; set; }
}

/// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderReferenceDataSourcesSchema
{
    /// <summary>
    /// The Record Column mapping for the streaming source data element.
    /// See Record Columns below for more details.
    /// </summary>
    [JsonPropertyName("recordColumns")]
    public IList<V1beta2ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordColumns>? RecordColumns { get; set; }

    /// <summary>The Encoding of the record in the streaming source.</summary>
    [JsonPropertyName("recordEncoding")]
    public string? RecordEncoding { get; set; }

    /// <summary>
    /// The Record Format and mapping information to schematize a record.
    /// See Record Format below for more details.
    /// </summary>
    [JsonPropertyName("recordFormat")]
    public V1beta2ApplicationStatusAtProviderReferenceDataSourcesSchemaRecordFormat? RecordFormat { get; set; }
}

/// <summary>
/// An S3 Reference Data Source for the application.
/// See Reference Data Sources below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProviderReferenceDataSources
{
    /// <summary>The ARN of the Kinesis Analytics Application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The S3 configuration for the reference data source. See S3 Reference below for more details.</summary>
    [JsonPropertyName("s3")]
    public V1beta2ApplicationStatusAtProviderReferenceDataSourcesS3? S3 { get; set; }

    /// <summary>The Schema format of the data in the streaming source. See Source Schema below for more details.</summary>
    [JsonPropertyName("schema")]
    public V1beta2ApplicationStatusAtProviderReferenceDataSourcesSchema? Schema { get; set; }

    /// <summary>The in-application Table Name.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusAtProvider
{
    /// <summary>The ARN of the Kinesis Analytics Appliation.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// The CloudWatch log stream options to monitor application errors.
    /// See CloudWatch Logging Options below for more details.
    /// </summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta2ApplicationStatusAtProviderCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>SQL Code to transform input data, and generate output.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>The Timestamp when the application version was created.</summary>
    [JsonPropertyName("createTimestamp")]
    public string? CreateTimestamp { get; set; }

    /// <summary>Description of the application.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ARN of the Kinesis Analytics Application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Input configuration of the application. See Inputs below for more details.</summary>
    [JsonPropertyName("inputs")]
    public V1beta2ApplicationStatusAtProviderInputs? Inputs { get; set; }

    /// <summary>The Timestamp when the application was last updated.</summary>
    [JsonPropertyName("lastUpdateTimestamp")]
    public string? LastUpdateTimestamp { get; set; }

    /// <summary>Output destination configuration of the application. See Outputs below for more details.</summary>
    [JsonPropertyName("outputs")]
    public IList<V1beta2ApplicationStatusAtProviderOutputs>? Outputs { get; set; }

    /// <summary>
    /// An S3 Reference Data Source for the application.
    /// See Reference Data Sources below for more details.
    /// </summary>
    [JsonPropertyName("referenceDataSources")]
    public V1beta2ApplicationStatusAtProviderReferenceDataSources? ReferenceDataSources { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Whether to start or stop the Kinesis Analytics Application. To start an application, an input with a defined starting_position must be configured.
    /// To modify an application&apos;s starting position, first stop the application by setting start_application = false, then update starting_position and set start_application = true.
    /// </summary>
    [JsonPropertyName("startApplication")]
    public bool? StartApplication { get; set; }

    /// <summary>The Status of the application.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The Version of the application.</summary>
    [JsonPropertyName("version")]
    public double? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatusConditions
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

/// <summary>ApplicationStatus defines the observed state of Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ApplicationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ApplicationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Application is the Schema for the Applications API. Provides a AWS Kinesis Analytics Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Application : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ApplicationSpec>, IStatus<V1beta2ApplicationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Application";
    public const string KubeGroup = "kinesisanalytics.aws.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kinesisanalytics.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Application";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationSpec defines the desired state of Application</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ApplicationSpec Spec { get; set; }

    /// <summary>ApplicationStatus defines the observed state of Application.</summary>
    [JsonPropertyName("status")]
    public V1beta2ApplicationStatus? Status { get; set; }
}