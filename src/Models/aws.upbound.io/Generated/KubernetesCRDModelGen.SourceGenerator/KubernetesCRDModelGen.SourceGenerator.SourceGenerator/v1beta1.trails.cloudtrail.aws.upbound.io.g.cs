#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudtrail.aws.upbound.io;
/// <summary>Trail is the Schema for the Trails API. Provides a CloudTrail resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TrailList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Trail>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TrailList";
    public const string KubeGroup = "cloudtrail.aws.upbound.io";
    public const string KubePluralName = "trails";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudtrail.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TrailList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Trail objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Trail> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecDeletionPolicyEnum>))]
public enum V1beta1TrailSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderAdvancedEventSelectorFieldSelector
{
    /// <summary>A list of values that includes events that match the last few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("endsWith")]
    public IList<string>? EndsWith { get; set; }

    /// <summary>A list of values that includes events that match the exact value of the event record field specified as the value of field. This is the only valid operator that you can use with the readOnly, eventCategory, and resources.type fields.</summary>
    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    /// <summary>Field in an event record on which to filter events to be logged. You can specify only the following values: readOnly, eventSource, eventName, eventCategory, resources.type, resources.ARN.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>A list of values that excludes events that match the last few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notEndsWith")]
    public IList<string>? NotEndsWith { get; set; }

    /// <summary>A list of values that excludes events that match the exact value of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }

    /// <summary>A list of values that excludes events that match the first few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notStartsWith")]
    public IList<string>? NotStartsWith { get; set; }

    /// <summary>A list of values that includes events that match the first few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("startsWith")]
    public IList<string>? StartsWith { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderAdvancedEventSelector
{
    /// <summary>Specifies the selector statements in an advanced event selector. Fields documented below.</summary>
    [JsonPropertyName("fieldSelector")]
    public IList<V1beta1TrailSpecForProviderAdvancedEventSelectorFieldSelector>? FieldSelector { get; set; }

    /// <summary>Name of the trail.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecForProviderCloudWatchLogsRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1TrailSpecForProviderCloudWatchLogsRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecForProviderCloudWatchLogsRoleArnRefPolicyResolveEnum>))]
public enum V1beta1TrailSpecForProviderCloudWatchLogsRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderCloudWatchLogsRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecForProviderCloudWatchLogsRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecForProviderCloudWatchLogsRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate cloudWatchLogsRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderCloudWatchLogsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrailSpecForProviderCloudWatchLogsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecForProviderCloudWatchLogsRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1TrailSpecForProviderCloudWatchLogsRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecForProviderCloudWatchLogsRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1TrailSpecForProviderCloudWatchLogsRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderCloudWatchLogsRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecForProviderCloudWatchLogsRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecForProviderCloudWatchLogsRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate cloudWatchLogsRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderCloudWatchLogsRoleArnSelector
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
    public V1beta1TrailSpecForProviderCloudWatchLogsRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderEventSelectorDataResource
{
    /// <summary>Resource type in which you want to log data events. You can specify only the following value: &quot;AWS::S3::Object&quot;, &quot;AWS::Lambda::Function&quot; and &quot;AWS::DynamoDB::Table&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>List of ARN strings or partial ARN strings to specify selectors for data audit events over data resources. ARN list is specific to single-valued type. For example, arn:aws:s3:::&lt;bucket name&gt;/ for all objects in a bucket, arn:aws:s3:::&lt;bucket name&gt;/key for specific objects, arn:aws:lambda for all lambda events within an account, arn:aws:lambda:&lt;region&gt;:&lt;account number&gt;:function:&lt;function name&gt; for a specific Lambda function, arn:aws:dynamodb for all DDB events for all tables within an account, or arn:aws:dynamodb:&lt;region&gt;:&lt;account number&gt;:table/&lt;table name&gt; for a specific DynamoDB table.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderEventSelector
{
    /// <summary>Configuration block for data events. See details below.</summary>
    [JsonPropertyName("dataResource")]
    public IList<V1beta1TrailSpecForProviderEventSelectorDataResource>? DataResource { get; set; }

    /// <summary>A set of event sources to exclude. Valid values include: kms.amazonaws.com and rdsdata.amazonaws.com. include_management_events must be set totrue to allow this.</summary>
    [JsonPropertyName("excludeManagementEventSources")]
    public IList<string>? ExcludeManagementEventSources { get; set; }

    /// <summary>Whether to include management events for your trail. Defaults to true.</summary>
    [JsonPropertyName("includeManagementEvents")]
    public bool? IncludeManagementEvents { get; set; }

    /// <summary>Type of events to log. Valid values are ReadOnly, WriteOnly, All. Default value is All.</summary>
    [JsonPropertyName("readWriteType")]
    public string? ReadWriteType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderInsightSelector
{
    /// <summary>Type of insights to log on a trail. Valid values are: ApiCallRateInsight and ApiErrorRateInsight.</summary>
    [JsonPropertyName("insightType")]
    public string? InsightType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecForProviderKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta1TrailSpecForProviderKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecForProviderKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta1TrailSpecForProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecForProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecForProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrailSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta1TrailSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecForProviderKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta1TrailSpecForProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecForProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderKmsKeyIdSelector
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
    public V1beta1TrailSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecForProviderS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta1TrailSpecForProviderS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecForProviderS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta1TrailSpecForProviderS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecForProviderS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecForProviderS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate s3BucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrailSpecForProviderS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecForProviderS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1TrailSpecForProviderS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecForProviderS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1TrailSpecForProviderS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecForProviderS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecForProviderS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate s3BucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProviderS3BucketNameSelector
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
    public V1beta1TrailSpecForProviderS3BucketNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecForProvider
{
    /// <summary>Specifies an advanced event selector for enabling data event logging. Fields documented below. Conflicts with event_selector.</summary>
    [JsonPropertyName("advancedEventSelector")]
    public IList<V1beta1TrailSpecForProviderAdvancedEventSelector>? AdvancedEventSelector { get; set; }

    /// <summary>Log group name using an ARN that represents the log group to which CloudTrail logs will be delivered. Note that CloudTrail requires the Log Stream wildcard.</summary>
    [JsonPropertyName("cloudWatchLogsGroupArn")]
    public string? CloudWatchLogsGroupArn { get; set; }

    /// <summary>Role for the CloudWatch Logs endpoint to assume to write to a user’s log group.</summary>
    [JsonPropertyName("cloudWatchLogsRoleArn")]
    public string? CloudWatchLogsRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate cloudWatchLogsRoleArn.</summary>
    [JsonPropertyName("cloudWatchLogsRoleArnRef")]
    public V1beta1TrailSpecForProviderCloudWatchLogsRoleArnRef? CloudWatchLogsRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate cloudWatchLogsRoleArn.</summary>
    [JsonPropertyName("cloudWatchLogsRoleArnSelector")]
    public V1beta1TrailSpecForProviderCloudWatchLogsRoleArnSelector? CloudWatchLogsRoleArnSelector { get; set; }

    /// <summary>Whether log file integrity validation is enabled. Defaults to false.</summary>
    [JsonPropertyName("enableLogFileValidation")]
    public bool? EnableLogFileValidation { get; set; }

    /// <summary>Enables logging for the trail. When set to true, logging is started by calling the StartLogging API. When set to false, logging is stopped by calling the StopLogging API. Defaults to true.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>Specifies an event selector for enabling data event logging. Fields documented below. Please note the CloudTrail limits when configuring these. Conflicts with advanced_event_selector.</summary>
    [JsonPropertyName("eventSelector")]
    public IList<V1beta1TrailSpecForProviderEventSelector>? EventSelector { get; set; }

    /// <summary>Whether the trail is publishing events from global services such as IAM to the log files. Defaults to true.</summary>
    [JsonPropertyName("includeGlobalServiceEvents")]
    public bool? IncludeGlobalServiceEvents { get; set; }

    /// <summary>Configuration block for identifying unusual operational activity. See details below.</summary>
    [JsonPropertyName("insightSelector")]
    public IList<V1beta1TrailSpecForProviderInsightSelector>? InsightSelector { get; set; }

    /// <summary>Whether the trail is created in the current region or in all regions. Defaults to false.</summary>
    [JsonPropertyName("isMultiRegionTrail")]
    public bool? IsMultiRegionTrail { get; set; }

    /// <summary>Whether the trail is an AWS Organizations trail. Organization trails log events for the master account and all member accounts. Can only be created in the organization master account. Defaults to false.</summary>
    [JsonPropertyName("isOrganizationTrail")]
    public bool? IsOrganizationTrail { get; set; }

    /// <summary>KMS key ARN to use to encrypt the logs delivered by CloudTrail.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1TrailSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1TrailSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Name of the S3 bucket designated for publishing log files.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate s3BucketName.</summary>
    [JsonPropertyName("s3BucketNameRef")]
    public V1beta1TrailSpecForProviderS3BucketNameRef? S3BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate s3BucketName.</summary>
    [JsonPropertyName("s3BucketNameSelector")]
    public V1beta1TrailSpecForProviderS3BucketNameSelector? S3BucketNameSelector { get; set; }

    /// <summary>S3 key prefix that follows the name of the bucket you have designated for log file delivery.</summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }

    /// <summary>Name of the Amazon SNS topic defined for notification of log file delivery. Specify the SNS topic ARN if it resides in another region.</summary>
    [JsonPropertyName("snsTopicName")]
    public string? SnsTopicName { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderAdvancedEventSelectorFieldSelector
{
    /// <summary>A list of values that includes events that match the last few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("endsWith")]
    public IList<string>? EndsWith { get; set; }

    /// <summary>A list of values that includes events that match the exact value of the event record field specified as the value of field. This is the only valid operator that you can use with the readOnly, eventCategory, and resources.type fields.</summary>
    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    /// <summary>Field in an event record on which to filter events to be logged. You can specify only the following values: readOnly, eventSource, eventName, eventCategory, resources.type, resources.ARN.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>A list of values that excludes events that match the last few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notEndsWith")]
    public IList<string>? NotEndsWith { get; set; }

    /// <summary>A list of values that excludes events that match the exact value of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }

    /// <summary>A list of values that excludes events that match the first few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notStartsWith")]
    public IList<string>? NotStartsWith { get; set; }

    /// <summary>A list of values that includes events that match the first few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("startsWith")]
    public IList<string>? StartsWith { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderAdvancedEventSelector
{
    /// <summary>Specifies the selector statements in an advanced event selector. Fields documented below.</summary>
    [JsonPropertyName("fieldSelector")]
    public IList<V1beta1TrailSpecInitProviderAdvancedEventSelectorFieldSelector>? FieldSelector { get; set; }

    /// <summary>Name of the trail.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnRefPolicyResolveEnum>))]
public enum V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate cloudWatchLogsRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate cloudWatchLogsRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnSelector
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
    public V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderEventSelectorDataResource
{
    /// <summary>Resource type in which you want to log data events. You can specify only the following value: &quot;AWS::S3::Object&quot;, &quot;AWS::Lambda::Function&quot; and &quot;AWS::DynamoDB::Table&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>List of ARN strings or partial ARN strings to specify selectors for data audit events over data resources. ARN list is specific to single-valued type. For example, arn:aws:s3:::&lt;bucket name&gt;/ for all objects in a bucket, arn:aws:s3:::&lt;bucket name&gt;/key for specific objects, arn:aws:lambda for all lambda events within an account, arn:aws:lambda:&lt;region&gt;:&lt;account number&gt;:function:&lt;function name&gt; for a specific Lambda function, arn:aws:dynamodb for all DDB events for all tables within an account, or arn:aws:dynamodb:&lt;region&gt;:&lt;account number&gt;:table/&lt;table name&gt; for a specific DynamoDB table.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderEventSelector
{
    /// <summary>Configuration block for data events. See details below.</summary>
    [JsonPropertyName("dataResource")]
    public IList<V1beta1TrailSpecInitProviderEventSelectorDataResource>? DataResource { get; set; }

    /// <summary>A set of event sources to exclude. Valid values include: kms.amazonaws.com and rdsdata.amazonaws.com. include_management_events must be set totrue to allow this.</summary>
    [JsonPropertyName("excludeManagementEventSources")]
    public IList<string>? ExcludeManagementEventSources { get; set; }

    /// <summary>Whether to include management events for your trail. Defaults to true.</summary>
    [JsonPropertyName("includeManagementEvents")]
    public bool? IncludeManagementEvents { get; set; }

    /// <summary>Type of events to log. Valid values are ReadOnly, WriteOnly, All. Default value is All.</summary>
    [JsonPropertyName("readWriteType")]
    public string? ReadWriteType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderInsightSelector
{
    /// <summary>Type of insights to log on a trail. Valid values are: ApiCallRateInsight and ApiErrorRateInsight.</summary>
    [JsonPropertyName("insightType")]
    public string? InsightType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecInitProviderKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta1TrailSpecInitProviderKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecInitProviderKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta1TrailSpecInitProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecInitProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecInitProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrailSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta1TrailSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta1TrailSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderKmsKeyIdSelector
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
    public V1beta1TrailSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecInitProviderS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta1TrailSpecInitProviderS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecInitProviderS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta1TrailSpecInitProviderS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecInitProviderS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecInitProviderS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate s3BucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrailSpecInitProviderS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecInitProviderS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1TrailSpecInitProviderS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecInitProviderS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1TrailSpecInitProviderS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecInitProviderS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecInitProviderS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate s3BucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecInitProviderS3BucketNameSelector
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
    public V1beta1TrailSpecInitProviderS3BucketNameSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1TrailSpecInitProvider
{
    /// <summary>Specifies an advanced event selector for enabling data event logging. Fields documented below. Conflicts with event_selector.</summary>
    [JsonPropertyName("advancedEventSelector")]
    public IList<V1beta1TrailSpecInitProviderAdvancedEventSelector>? AdvancedEventSelector { get; set; }

    /// <summary>Log group name using an ARN that represents the log group to which CloudTrail logs will be delivered. Note that CloudTrail requires the Log Stream wildcard.</summary>
    [JsonPropertyName("cloudWatchLogsGroupArn")]
    public string? CloudWatchLogsGroupArn { get; set; }

    /// <summary>Role for the CloudWatch Logs endpoint to assume to write to a user’s log group.</summary>
    [JsonPropertyName("cloudWatchLogsRoleArn")]
    public string? CloudWatchLogsRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate cloudWatchLogsRoleArn.</summary>
    [JsonPropertyName("cloudWatchLogsRoleArnRef")]
    public V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnRef? CloudWatchLogsRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate cloudWatchLogsRoleArn.</summary>
    [JsonPropertyName("cloudWatchLogsRoleArnSelector")]
    public V1beta1TrailSpecInitProviderCloudWatchLogsRoleArnSelector? CloudWatchLogsRoleArnSelector { get; set; }

    /// <summary>Whether log file integrity validation is enabled. Defaults to false.</summary>
    [JsonPropertyName("enableLogFileValidation")]
    public bool? EnableLogFileValidation { get; set; }

    /// <summary>Enables logging for the trail. When set to true, logging is started by calling the StartLogging API. When set to false, logging is stopped by calling the StopLogging API. Defaults to true.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>Specifies an event selector for enabling data event logging. Fields documented below. Please note the CloudTrail limits when configuring these. Conflicts with advanced_event_selector.</summary>
    [JsonPropertyName("eventSelector")]
    public IList<V1beta1TrailSpecInitProviderEventSelector>? EventSelector { get; set; }

    /// <summary>Whether the trail is publishing events from global services such as IAM to the log files. Defaults to true.</summary>
    [JsonPropertyName("includeGlobalServiceEvents")]
    public bool? IncludeGlobalServiceEvents { get; set; }

    /// <summary>Configuration block for identifying unusual operational activity. See details below.</summary>
    [JsonPropertyName("insightSelector")]
    public IList<V1beta1TrailSpecInitProviderInsightSelector>? InsightSelector { get; set; }

    /// <summary>Whether the trail is created in the current region or in all regions. Defaults to false.</summary>
    [JsonPropertyName("isMultiRegionTrail")]
    public bool? IsMultiRegionTrail { get; set; }

    /// <summary>Whether the trail is an AWS Organizations trail. Organization trails log events for the master account and all member accounts. Can only be created in the organization master account. Defaults to false.</summary>
    [JsonPropertyName("isOrganizationTrail")]
    public bool? IsOrganizationTrail { get; set; }

    /// <summary>KMS key ARN to use to encrypt the logs delivered by CloudTrail.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1TrailSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1TrailSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Name of the S3 bucket designated for publishing log files.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate s3BucketName.</summary>
    [JsonPropertyName("s3BucketNameRef")]
    public V1beta1TrailSpecInitProviderS3BucketNameRef? S3BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate s3BucketName.</summary>
    [JsonPropertyName("s3BucketNameSelector")]
    public V1beta1TrailSpecInitProviderS3BucketNameSelector? S3BucketNameSelector { get; set; }

    /// <summary>S3 key prefix that follows the name of the bucket you have designated for log file delivery.</summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }

    /// <summary>Name of the Amazon SNS topic defined for notification of log file delivery. Specify the SNS topic ARN if it resides in another region.</summary>
    [JsonPropertyName("snsTopicName")]
    public string? SnsTopicName { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecManagementPoliciesEnum>))]
public enum V1beta1TrailSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1TrailSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrailSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1TrailSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrailSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrailSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrailSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>TrailSpec defines the desired state of Trail</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailSpec
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
    public V1beta1TrailSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1TrailSpecForProvider ForProvider { get; set; }

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
    public V1beta1TrailSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1TrailSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TrailSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TrailSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailStatusAtProviderAdvancedEventSelectorFieldSelector
{
    /// <summary>A list of values that includes events that match the last few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("endsWith")]
    public IList<string>? EndsWith { get; set; }

    /// <summary>A list of values that includes events that match the exact value of the event record field specified as the value of field. This is the only valid operator that you can use with the readOnly, eventCategory, and resources.type fields.</summary>
    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    /// <summary>Field in an event record on which to filter events to be logged. You can specify only the following values: readOnly, eventSource, eventName, eventCategory, resources.type, resources.ARN.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>A list of values that excludes events that match the last few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notEndsWith")]
    public IList<string>? NotEndsWith { get; set; }

    /// <summary>A list of values that excludes events that match the exact value of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }

    /// <summary>A list of values that excludes events that match the first few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notStartsWith")]
    public IList<string>? NotStartsWith { get; set; }

    /// <summary>A list of values that includes events that match the first few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("startsWith")]
    public IList<string>? StartsWith { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailStatusAtProviderAdvancedEventSelector
{
    /// <summary>Specifies the selector statements in an advanced event selector. Fields documented below.</summary>
    [JsonPropertyName("fieldSelector")]
    public IList<V1beta1TrailStatusAtProviderAdvancedEventSelectorFieldSelector>? FieldSelector { get; set; }

    /// <summary>Name of the trail.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailStatusAtProviderEventSelectorDataResource
{
    /// <summary>Resource type in which you want to log data events. You can specify only the following value: &quot;AWS::S3::Object&quot;, &quot;AWS::Lambda::Function&quot; and &quot;AWS::DynamoDB::Table&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>List of ARN strings or partial ARN strings to specify selectors for data audit events over data resources. ARN list is specific to single-valued type. For example, arn:aws:s3:::&lt;bucket name&gt;/ for all objects in a bucket, arn:aws:s3:::&lt;bucket name&gt;/key for specific objects, arn:aws:lambda for all lambda events within an account, arn:aws:lambda:&lt;region&gt;:&lt;account number&gt;:function:&lt;function name&gt; for a specific Lambda function, arn:aws:dynamodb for all DDB events for all tables within an account, or arn:aws:dynamodb:&lt;region&gt;:&lt;account number&gt;:table/&lt;table name&gt; for a specific DynamoDB table.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailStatusAtProviderEventSelector
{
    /// <summary>Configuration block for data events. See details below.</summary>
    [JsonPropertyName("dataResource")]
    public IList<V1beta1TrailStatusAtProviderEventSelectorDataResource>? DataResource { get; set; }

    /// <summary>A set of event sources to exclude. Valid values include: kms.amazonaws.com and rdsdata.amazonaws.com. include_management_events must be set totrue to allow this.</summary>
    [JsonPropertyName("excludeManagementEventSources")]
    public IList<string>? ExcludeManagementEventSources { get; set; }

    /// <summary>Whether to include management events for your trail. Defaults to true.</summary>
    [JsonPropertyName("includeManagementEvents")]
    public bool? IncludeManagementEvents { get; set; }

    /// <summary>Type of events to log. Valid values are ReadOnly, WriteOnly, All. Default value is All.</summary>
    [JsonPropertyName("readWriteType")]
    public string? ReadWriteType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailStatusAtProviderInsightSelector
{
    /// <summary>Type of insights to log on a trail. Valid values are: ApiCallRateInsight and ApiErrorRateInsight.</summary>
    [JsonPropertyName("insightType")]
    public string? InsightType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailStatusAtProvider
{
    /// <summary>Specifies an advanced event selector for enabling data event logging. Fields documented below. Conflicts with event_selector.</summary>
    [JsonPropertyName("advancedEventSelector")]
    public IList<V1beta1TrailStatusAtProviderAdvancedEventSelector>? AdvancedEventSelector { get; set; }

    /// <summary>ARN of the trail.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Log group name using an ARN that represents the log group to which CloudTrail logs will be delivered. Note that CloudTrail requires the Log Stream wildcard.</summary>
    [JsonPropertyName("cloudWatchLogsGroupArn")]
    public string? CloudWatchLogsGroupArn { get; set; }

    /// <summary>Role for the CloudWatch Logs endpoint to assume to write to a user’s log group.</summary>
    [JsonPropertyName("cloudWatchLogsRoleArn")]
    public string? CloudWatchLogsRoleArn { get; set; }

    /// <summary>Whether log file integrity validation is enabled. Defaults to false.</summary>
    [JsonPropertyName("enableLogFileValidation")]
    public bool? EnableLogFileValidation { get; set; }

    /// <summary>Enables logging for the trail. When set to true, logging is started by calling the StartLogging API. When set to false, logging is stopped by calling the StopLogging API. Defaults to true.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>Specifies an event selector for enabling data event logging. Fields documented below. Please note the CloudTrail limits when configuring these. Conflicts with advanced_event_selector.</summary>
    [JsonPropertyName("eventSelector")]
    public IList<V1beta1TrailStatusAtProviderEventSelector>? EventSelector { get; set; }

    /// <summary>Region in which the trail was created.</summary>
    [JsonPropertyName("homeRegion")]
    public string? HomeRegion { get; set; }

    /// <summary>ARN of the trail.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether the trail is publishing events from global services such as IAM to the log files. Defaults to true.</summary>
    [JsonPropertyName("includeGlobalServiceEvents")]
    public bool? IncludeGlobalServiceEvents { get; set; }

    /// <summary>Configuration block for identifying unusual operational activity. See details below.</summary>
    [JsonPropertyName("insightSelector")]
    public IList<V1beta1TrailStatusAtProviderInsightSelector>? InsightSelector { get; set; }

    /// <summary>Whether the trail is created in the current region or in all regions. Defaults to false.</summary>
    [JsonPropertyName("isMultiRegionTrail")]
    public bool? IsMultiRegionTrail { get; set; }

    /// <summary>Whether the trail is an AWS Organizations trail. Organization trails log events for the master account and all member accounts. Can only be created in the organization master account. Defaults to false.</summary>
    [JsonPropertyName("isOrganizationTrail")]
    public bool? IsOrganizationTrail { get; set; }

    /// <summary>KMS key ARN to use to encrypt the logs delivered by CloudTrail.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Name of the S3 bucket designated for publishing log files.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>S3 key prefix that follows the name of the bucket you have designated for log file delivery.</summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }

    /// <summary>ARN of the Amazon SNS topic that CloudTrail uses to send notifications when log files are delivered.</summary>
    [JsonPropertyName("snsTopicArn")]
    public string? SnsTopicArn { get; set; }

    /// <summary>Name of the Amazon SNS topic defined for notification of log file delivery. Specify the SNS topic ARN if it resides in another region.</summary>
    [JsonPropertyName("snsTopicName")]
    public string? SnsTopicName { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailStatusConditions
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

/// <summary>TrailStatus defines the observed state of Trail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrailStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1TrailStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TrailStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Trail is the Schema for the Trails API. Provides a CloudTrail resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Trail : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TrailSpec>, IStatus<V1beta1TrailStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Trail";
    public const string KubeGroup = "cloudtrail.aws.upbound.io";
    public const string KubePluralName = "trails";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudtrail.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Trail";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TrailSpec defines the desired state of Trail</summary>
    [JsonPropertyName("spec")]
    public required V1beta1TrailSpec Spec { get; set; }

    /// <summary>TrailStatus defines the observed state of Trail.</summary>
    [JsonPropertyName("status")]
    public V1beta1TrailStatus? Status { get; set; }
}