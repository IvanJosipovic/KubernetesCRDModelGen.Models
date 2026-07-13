#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datasync.aws.upbound.io;
/// <summary>Task is the Schema for the Tasks API. Manages an AWS DataSync Task</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2TaskList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Task>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "TaskList";
    public const string KubeGroup = "datasync.aws.upbound.io";
    public const string KubePluralName = "tasks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datasync.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TaskList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Task objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Task> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecDeletionPolicyEnum>))]
public enum V1beta2TaskSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecForProviderCloudwatchLogGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2TaskSpecForProviderCloudwatchLogGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecForProviderCloudwatchLogGroupArnRefPolicyResolveEnum>))]
public enum V1beta2TaskSpecForProviderCloudwatchLogGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderCloudwatchLogGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecForProviderCloudwatchLogGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecForProviderCloudwatchLogGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderCloudwatchLogGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TaskSpecForProviderCloudwatchLogGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderCloudwatchLogGroupArnSelector
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
    public V1beta2TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecForProviderDestinationLocationArnRefPolicyResolutionEnum>))]
public enum V1beta2TaskSpecForProviderDestinationLocationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecForProviderDestinationLocationArnRefPolicyResolveEnum>))]
public enum V1beta2TaskSpecForProviderDestinationLocationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderDestinationLocationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecForProviderDestinationLocationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecForProviderDestinationLocationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LocationS3 in datasync to populate destinationLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderDestinationLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TaskSpecForProviderDestinationLocationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecForProviderDestinationLocationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TaskSpecForProviderDestinationLocationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecForProviderDestinationLocationArnSelectorPolicyResolveEnum>))]
public enum V1beta2TaskSpecForProviderDestinationLocationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderDestinationLocationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecForProviderDestinationLocationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecForProviderDestinationLocationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LocationS3 in datasync to populate destinationLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderDestinationLocationArnSelector
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
    public V1beta2TaskSpecForProviderDestinationLocationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Filter rules that determines which files to exclude from a task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderExcludes
{
    /// <summary>The type of filter rule to apply. Valid values: SIMPLE_PATTERN.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>A single filter string that consists of the patterns to exclude. The patterns are delimited by &quot;|&quot; (that is, a pipe), for example: /folder1|/folder2</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Filter rules that determines which files to include in a task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderIncludes
{
    /// <summary>The type of filter rule to apply. Valid values: SIMPLE_PATTERN.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>A single filter string that consists of the patterns to exclude. The patterns are delimited by &quot;|&quot; (that is, a pipe), for example: /folder1|/folder2</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderOptions
{
    /// <summary>A file metadata that shows the last time a file was accessed (that is when the file was read or written to). If set to BEST_EFFORT, the DataSync Task attempts to preserve the original (that is, the version before sync PREPARING phase) atime attribute on all source files. Valid values: BEST_EFFORT, NONE. Default: BEST_EFFORT.</summary>
    [JsonPropertyName("atime")]
    public string? Atime { get; set; }

    /// <summary>Limits the bandwidth utilized. For example, to set a maximum of 1 MB, set this value to 1048576. Value values: -1 or greater. Default: -1 (unlimited).</summary>
    [JsonPropertyName("bytesPerSecond")]
    public double? BytesPerSecond { get; set; }

    /// <summary>Group identifier of the file&apos;s owners. Valid values: BOTH, INT_VALUE, NAME, NONE. Default: INT_VALUE (preserve integer value of the ID).</summary>
    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    /// <summary>Determines the type of logs that DataSync publishes to a log stream in the Amazon CloudWatch log group that you provide. Valid values: OFF, BASIC, TRANSFER. Default: OFF.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>A file metadata that indicates the last time a file was modified (written to) before the sync PREPARING phase. Value values: NONE, PRESERVE. Default: PRESERVE.</summary>
    [JsonPropertyName("mtime")]
    public string? Mtime { get; set; }

    /// <summary>Specifies whether object tags are maintained when transferring between object storage systems. If you want your DataSync task to ignore object tags, specify the NONE value. Valid values: PRESERVE, NONE. Default value: PRESERVE.</summary>
    [JsonPropertyName("objectTags")]
    public string? ObjectTags { get; set; }

    /// <summary>Determines whether files at the destination should be overwritten or preserved when copying files. Valid values: ALWAYS, NEVER. Default: ALWAYS.</summary>
    [JsonPropertyName("overwriteMode")]
    public string? OverwriteMode { get; set; }

    /// <summary>Determines which users or groups can access a file for a specific purpose such as reading, writing, or execution of the file. Valid values: NONE, PRESERVE. Default: PRESERVE.</summary>
    [JsonPropertyName("posixPermissions")]
    public string? PosixPermissions { get; set; }

    /// <summary>Whether files deleted in the source should be removed or preserved in the destination file system. Valid values: PRESERVE, REMOVE. Default: PRESERVE.</summary>
    [JsonPropertyName("preserveDeletedFiles")]
    public string? PreserveDeletedFiles { get; set; }

    /// <summary>Whether the DataSync Task should preserve the metadata of block and character devices in the source files system, and recreate the files with that device name and metadata on the destination. The DataSync Task can’t sync the actual contents of such devices, because many of the devices are non-terminal and don’t return an end of file (EOF) marker. Valid values: NONE, PRESERVE. Default: NONE (ignore special devices).</summary>
    [JsonPropertyName("preserveDevices")]
    public string? PreserveDevices { get; set; }

    /// <summary>Determines which components of the SMB security descriptor are copied from source to destination objects. This value is only used for transfers between SMB and Amazon FSx for Windows File Server locations, or between two Amazon FSx for Windows File Server locations. Valid values: NONE, OWNER_DACL, OWNER_DACL_SACL. Default: OWNER_DACL.</summary>
    [JsonPropertyName("securityDescriptorCopyFlags")]
    public string? SecurityDescriptorCopyFlags { get; set; }

    /// <summary>Determines whether tasks should be queued before executing the tasks. Valid values: ENABLED, DISABLED. Default ENABLED.</summary>
    [JsonPropertyName("taskQueueing")]
    public string? TaskQueueing { get; set; }

    /// <summary>Determines whether DataSync transfers only the data and metadata that differ between the source and the destination location, or whether DataSync transfers all the content from the source, without comparing to the destination location. Valid values: CHANGED, ALL. Default: CHANGED</summary>
    [JsonPropertyName("transferMode")]
    public string? TransferMode { get; set; }

    /// <summary>User identifier of the file&apos;s owners. Valid values: BOTH, INT_VALUE, NAME, NONE. Default: INT_VALUE (preserve integer value of the ID).</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Whether a data integrity verification should be performed at the end of a task execution after all data and metadata have been transferred. Valid values: NONE, POINT_IN_TIME_CONSISTENT, ONLY_FILES_TRANSFERRED. Default: POINT_IN_TIME_CONSISTENT.</summary>
    [JsonPropertyName("verifyMode")]
    public string? VerifyMode { get; set; }
}

/// <summary>Specifies a schedule used to periodically transfer files from a source to a destination location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderSchedule
{
    /// <summary>Specifies the schedule you want your task to use for repeated executions. For more information, see Schedule Expressions for Rules.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecForProviderSourceLocationArnRefPolicyResolutionEnum>))]
public enum V1beta2TaskSpecForProviderSourceLocationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecForProviderSourceLocationArnRefPolicyResolveEnum>))]
public enum V1beta2TaskSpecForProviderSourceLocationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderSourceLocationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecForProviderSourceLocationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecForProviderSourceLocationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LocationS3 in datasync to populate sourceLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderSourceLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TaskSpecForProviderSourceLocationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecForProviderSourceLocationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TaskSpecForProviderSourceLocationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecForProviderSourceLocationArnSelectorPolicyResolveEnum>))]
public enum V1beta2TaskSpecForProviderSourceLocationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderSourceLocationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecForProviderSourceLocationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecForProviderSourceLocationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LocationS3 in datasync to populate sourceLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderSourceLocationArnSelector
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
    public V1beta2TaskSpecForProviderSourceLocationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block containing the configuration of the reporting level for aspects of your task report. See report_overrides below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderTaskReportConfigReportOverrides
{
    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to delete in your destination location. This only applies if you configure your task to delete data in the destination that isn&apos;t in the source. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("deletedOverride")]
    public string? DeletedOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to skip during your transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("skippedOverride")]
    public string? SkippedOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("transferredOverride")]
    public string? TransferredOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to verify at the end of your transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("verifiedOverride")]
    public string? VerifiedOverride { get; set; }
}

/// <summary>Configuration block containing the configuration for the Amazon S3 bucket where DataSync uploads your task report. See s3_destination below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderTaskReportConfigS3Destination
{
    /// <summary>Specifies the Amazon Resource Name (ARN) of the IAM policy that allows DataSync to upload a task report to your S3 bucket.</summary>
    [JsonPropertyName("bucketAccessRoleArn")]
    public string? BucketAccessRoleArn { get; set; }

    /// <summary>Specifies the ARN of the S3 bucket where DataSync uploads your report.</summary>
    [JsonPropertyName("s3BucketArn")]
    public string? S3BucketArn { get; set; }

    /// <summary>Specifies a bucket prefix for your report.</summary>
    [JsonPropertyName("subdirectory")]
    public string? Subdirectory { get; set; }
}

/// <summary>Configuration block containing the configuration of a DataSync Task Report. See task_report_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProviderTaskReportConfig
{
    /// <summary>Specifies the type of task report you&apos;d like. Valid values: SUMMARY_ONLY and STANDARD.</summary>
    [JsonPropertyName("outputType")]
    public string? OutputType { get; set; }

    /// <summary>Specifies whether you want your task report to include only what went wrong with your transfer or a list of what succeeded and didn&apos;t. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("reportLevel")]
    public string? ReportLevel { get; set; }

    /// <summary>Configuration block containing the configuration of the reporting level for aspects of your task report. See report_overrides below.</summary>
    [JsonPropertyName("reportOverrides")]
    public V1beta2TaskSpecForProviderTaskReportConfigReportOverrides? ReportOverrides { get; set; }

    /// <summary>Configuration block containing the configuration for the Amazon S3 bucket where DataSync uploads your task report. See s3_destination below.</summary>
    [JsonPropertyName("s3Destination")]
    public V1beta2TaskSpecForProviderTaskReportConfigS3Destination? S3Destination { get; set; }

    /// <summary>Specifies whether your task report includes the new version of each object transferred into an S3 bucket. This only applies if you enable versioning on your bucket. Keep in mind that setting this to INCLUDE can increase the duration of your task execution. Valid values: INCLUDE and NONE.</summary>
    [JsonPropertyName("s3ObjectVersioning")]
    public string? S3ObjectVersioning { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecForProvider
{
    /// <summary>Amazon Resource Name (ARN) of the CloudWatch Log Group that is used to monitor and log events in the sync task.</summary>
    [JsonPropertyName("cloudwatchLogGroupArn")]
    public string? CloudwatchLogGroupArn { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnRef")]
    public V1beta2TaskSpecForProviderCloudwatchLogGroupArnRef? CloudwatchLogGroupArnRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnSelector")]
    public V1beta2TaskSpecForProviderCloudwatchLogGroupArnSelector? CloudwatchLogGroupArnSelector { get; set; }

    /// <summary>Amazon Resource Name (ARN) of destination DataSync Location.</summary>
    [JsonPropertyName("destinationLocationArn")]
    public string? DestinationLocationArn { get; set; }

    /// <summary>Reference to a LocationS3 in datasync to populate destinationLocationArn.</summary>
    [JsonPropertyName("destinationLocationArnRef")]
    public V1beta2TaskSpecForProviderDestinationLocationArnRef? DestinationLocationArnRef { get; set; }

    /// <summary>Selector for a LocationS3 in datasync to populate destinationLocationArn.</summary>
    [JsonPropertyName("destinationLocationArnSelector")]
    public V1beta2TaskSpecForProviderDestinationLocationArnSelector? DestinationLocationArnSelector { get; set; }

    /// <summary>Filter rules that determines which files to exclude from a task.</summary>
    [JsonPropertyName("excludes")]
    public V1beta2TaskSpecForProviderExcludes? Excludes { get; set; }

    /// <summary>Filter rules that determines which files to include in a task.</summary>
    [JsonPropertyName("includes")]
    public V1beta2TaskSpecForProviderIncludes? Includes { get; set; }

    /// <summary>Name of the DataSync Task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.</summary>
    [JsonPropertyName("options")]
    public V1beta2TaskSpecForProviderOptions? Options { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Specifies a schedule used to periodically transfer files from a source to a destination location.</summary>
    [JsonPropertyName("schedule")]
    public V1beta2TaskSpecForProviderSchedule? Schedule { get; set; }

    /// <summary>Amazon Resource Name (ARN) of source DataSync Location.</summary>
    [JsonPropertyName("sourceLocationArn")]
    public string? SourceLocationArn { get; set; }

    /// <summary>Reference to a LocationS3 in datasync to populate sourceLocationArn.</summary>
    [JsonPropertyName("sourceLocationArnRef")]
    public V1beta2TaskSpecForProviderSourceLocationArnRef? SourceLocationArnRef { get; set; }

    /// <summary>Selector for a LocationS3 in datasync to populate sourceLocationArn.</summary>
    [JsonPropertyName("sourceLocationArnSelector")]
    public V1beta2TaskSpecForProviderSourceLocationArnSelector? SourceLocationArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One of the following task modes for your data transfer:</summary>
    [JsonPropertyName("taskMode")]
    public string? TaskMode { get; set; }

    /// <summary>Configuration block containing the configuration of a DataSync Task Report. See task_report_config below.</summary>
    [JsonPropertyName("taskReportConfig")]
    public V1beta2TaskSpecForProviderTaskReportConfig? TaskReportConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecInitProviderCloudwatchLogGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2TaskSpecInitProviderCloudwatchLogGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecInitProviderCloudwatchLogGroupArnRefPolicyResolveEnum>))]
public enum V1beta2TaskSpecInitProviderCloudwatchLogGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderCloudwatchLogGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecInitProviderCloudwatchLogGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecInitProviderCloudwatchLogGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderCloudwatchLogGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TaskSpecInitProviderCloudwatchLogGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderCloudwatchLogGroupArnSelector
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
    public V1beta2TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecInitProviderDestinationLocationArnRefPolicyResolutionEnum>))]
public enum V1beta2TaskSpecInitProviderDestinationLocationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecInitProviderDestinationLocationArnRefPolicyResolveEnum>))]
public enum V1beta2TaskSpecInitProviderDestinationLocationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderDestinationLocationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecInitProviderDestinationLocationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecInitProviderDestinationLocationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LocationS3 in datasync to populate destinationLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderDestinationLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TaskSpecInitProviderDestinationLocationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecInitProviderDestinationLocationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TaskSpecInitProviderDestinationLocationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecInitProviderDestinationLocationArnSelectorPolicyResolveEnum>))]
public enum V1beta2TaskSpecInitProviderDestinationLocationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderDestinationLocationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecInitProviderDestinationLocationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecInitProviderDestinationLocationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LocationS3 in datasync to populate destinationLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderDestinationLocationArnSelector
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
    public V1beta2TaskSpecInitProviderDestinationLocationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Filter rules that determines which files to exclude from a task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderExcludes
{
    /// <summary>The type of filter rule to apply. Valid values: SIMPLE_PATTERN.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>A single filter string that consists of the patterns to exclude. The patterns are delimited by &quot;|&quot; (that is, a pipe), for example: /folder1|/folder2</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Filter rules that determines which files to include in a task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderIncludes
{
    /// <summary>The type of filter rule to apply. Valid values: SIMPLE_PATTERN.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>A single filter string that consists of the patterns to exclude. The patterns are delimited by &quot;|&quot; (that is, a pipe), for example: /folder1|/folder2</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderOptions
{
    /// <summary>A file metadata that shows the last time a file was accessed (that is when the file was read or written to). If set to BEST_EFFORT, the DataSync Task attempts to preserve the original (that is, the version before sync PREPARING phase) atime attribute on all source files. Valid values: BEST_EFFORT, NONE. Default: BEST_EFFORT.</summary>
    [JsonPropertyName("atime")]
    public string? Atime { get; set; }

    /// <summary>Limits the bandwidth utilized. For example, to set a maximum of 1 MB, set this value to 1048576. Value values: -1 or greater. Default: -1 (unlimited).</summary>
    [JsonPropertyName("bytesPerSecond")]
    public double? BytesPerSecond { get; set; }

    /// <summary>Group identifier of the file&apos;s owners. Valid values: BOTH, INT_VALUE, NAME, NONE. Default: INT_VALUE (preserve integer value of the ID).</summary>
    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    /// <summary>Determines the type of logs that DataSync publishes to a log stream in the Amazon CloudWatch log group that you provide. Valid values: OFF, BASIC, TRANSFER. Default: OFF.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>A file metadata that indicates the last time a file was modified (written to) before the sync PREPARING phase. Value values: NONE, PRESERVE. Default: PRESERVE.</summary>
    [JsonPropertyName("mtime")]
    public string? Mtime { get; set; }

    /// <summary>Specifies whether object tags are maintained when transferring between object storage systems. If you want your DataSync task to ignore object tags, specify the NONE value. Valid values: PRESERVE, NONE. Default value: PRESERVE.</summary>
    [JsonPropertyName("objectTags")]
    public string? ObjectTags { get; set; }

    /// <summary>Determines whether files at the destination should be overwritten or preserved when copying files. Valid values: ALWAYS, NEVER. Default: ALWAYS.</summary>
    [JsonPropertyName("overwriteMode")]
    public string? OverwriteMode { get; set; }

    /// <summary>Determines which users or groups can access a file for a specific purpose such as reading, writing, or execution of the file. Valid values: NONE, PRESERVE. Default: PRESERVE.</summary>
    [JsonPropertyName("posixPermissions")]
    public string? PosixPermissions { get; set; }

    /// <summary>Whether files deleted in the source should be removed or preserved in the destination file system. Valid values: PRESERVE, REMOVE. Default: PRESERVE.</summary>
    [JsonPropertyName("preserveDeletedFiles")]
    public string? PreserveDeletedFiles { get; set; }

    /// <summary>Whether the DataSync Task should preserve the metadata of block and character devices in the source files system, and recreate the files with that device name and metadata on the destination. The DataSync Task can’t sync the actual contents of such devices, because many of the devices are non-terminal and don’t return an end of file (EOF) marker. Valid values: NONE, PRESERVE. Default: NONE (ignore special devices).</summary>
    [JsonPropertyName("preserveDevices")]
    public string? PreserveDevices { get; set; }

    /// <summary>Determines which components of the SMB security descriptor are copied from source to destination objects. This value is only used for transfers between SMB and Amazon FSx for Windows File Server locations, or between two Amazon FSx for Windows File Server locations. Valid values: NONE, OWNER_DACL, OWNER_DACL_SACL. Default: OWNER_DACL.</summary>
    [JsonPropertyName("securityDescriptorCopyFlags")]
    public string? SecurityDescriptorCopyFlags { get; set; }

    /// <summary>Determines whether tasks should be queued before executing the tasks. Valid values: ENABLED, DISABLED. Default ENABLED.</summary>
    [JsonPropertyName("taskQueueing")]
    public string? TaskQueueing { get; set; }

    /// <summary>Determines whether DataSync transfers only the data and metadata that differ between the source and the destination location, or whether DataSync transfers all the content from the source, without comparing to the destination location. Valid values: CHANGED, ALL. Default: CHANGED</summary>
    [JsonPropertyName("transferMode")]
    public string? TransferMode { get; set; }

    /// <summary>User identifier of the file&apos;s owners. Valid values: BOTH, INT_VALUE, NAME, NONE. Default: INT_VALUE (preserve integer value of the ID).</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Whether a data integrity verification should be performed at the end of a task execution after all data and metadata have been transferred. Valid values: NONE, POINT_IN_TIME_CONSISTENT, ONLY_FILES_TRANSFERRED. Default: POINT_IN_TIME_CONSISTENT.</summary>
    [JsonPropertyName("verifyMode")]
    public string? VerifyMode { get; set; }
}

/// <summary>Specifies a schedule used to periodically transfer files from a source to a destination location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderSchedule
{
    /// <summary>Specifies the schedule you want your task to use for repeated executions. For more information, see Schedule Expressions for Rules.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecInitProviderSourceLocationArnRefPolicyResolutionEnum>))]
public enum V1beta2TaskSpecInitProviderSourceLocationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecInitProviderSourceLocationArnRefPolicyResolveEnum>))]
public enum V1beta2TaskSpecInitProviderSourceLocationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderSourceLocationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecInitProviderSourceLocationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecInitProviderSourceLocationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LocationS3 in datasync to populate sourceLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderSourceLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TaskSpecInitProviderSourceLocationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecInitProviderSourceLocationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TaskSpecInitProviderSourceLocationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecInitProviderSourceLocationArnSelectorPolicyResolveEnum>))]
public enum V1beta2TaskSpecInitProviderSourceLocationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderSourceLocationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecInitProviderSourceLocationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecInitProviderSourceLocationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LocationS3 in datasync to populate sourceLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderSourceLocationArnSelector
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
    public V1beta2TaskSpecInitProviderSourceLocationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block containing the configuration of the reporting level for aspects of your task report. See report_overrides below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderTaskReportConfigReportOverrides
{
    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to delete in your destination location. This only applies if you configure your task to delete data in the destination that isn&apos;t in the source. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("deletedOverride")]
    public string? DeletedOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to skip during your transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("skippedOverride")]
    public string? SkippedOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("transferredOverride")]
    public string? TransferredOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to verify at the end of your transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("verifiedOverride")]
    public string? VerifiedOverride { get; set; }
}

/// <summary>Configuration block containing the configuration for the Amazon S3 bucket where DataSync uploads your task report. See s3_destination below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderTaskReportConfigS3Destination
{
    /// <summary>Specifies the Amazon Resource Name (ARN) of the IAM policy that allows DataSync to upload a task report to your S3 bucket.</summary>
    [JsonPropertyName("bucketAccessRoleArn")]
    public string? BucketAccessRoleArn { get; set; }

    /// <summary>Specifies the ARN of the S3 bucket where DataSync uploads your report.</summary>
    [JsonPropertyName("s3BucketArn")]
    public string? S3BucketArn { get; set; }

    /// <summary>Specifies a bucket prefix for your report.</summary>
    [JsonPropertyName("subdirectory")]
    public string? Subdirectory { get; set; }
}

/// <summary>Configuration block containing the configuration of a DataSync Task Report. See task_report_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecInitProviderTaskReportConfig
{
    /// <summary>Specifies the type of task report you&apos;d like. Valid values: SUMMARY_ONLY and STANDARD.</summary>
    [JsonPropertyName("outputType")]
    public string? OutputType { get; set; }

    /// <summary>Specifies whether you want your task report to include only what went wrong with your transfer or a list of what succeeded and didn&apos;t. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("reportLevel")]
    public string? ReportLevel { get; set; }

    /// <summary>Configuration block containing the configuration of the reporting level for aspects of your task report. See report_overrides below.</summary>
    [JsonPropertyName("reportOverrides")]
    public V1beta2TaskSpecInitProviderTaskReportConfigReportOverrides? ReportOverrides { get; set; }

    /// <summary>Configuration block containing the configuration for the Amazon S3 bucket where DataSync uploads your task report. See s3_destination below.</summary>
    [JsonPropertyName("s3Destination")]
    public V1beta2TaskSpecInitProviderTaskReportConfigS3Destination? S3Destination { get; set; }

    /// <summary>Specifies whether your task report includes the new version of each object transferred into an S3 bucket. This only applies if you enable versioning on your bucket. Keep in mind that setting this to INCLUDE can increase the duration of your task execution. Valid values: INCLUDE and NONE.</summary>
    [JsonPropertyName("s3ObjectVersioning")]
    public string? S3ObjectVersioning { get; set; }
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
public partial class V1beta2TaskSpecInitProvider
{
    /// <summary>Amazon Resource Name (ARN) of the CloudWatch Log Group that is used to monitor and log events in the sync task.</summary>
    [JsonPropertyName("cloudwatchLogGroupArn")]
    public string? CloudwatchLogGroupArn { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnRef")]
    public V1beta2TaskSpecInitProviderCloudwatchLogGroupArnRef? CloudwatchLogGroupArnRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnSelector")]
    public V1beta2TaskSpecInitProviderCloudwatchLogGroupArnSelector? CloudwatchLogGroupArnSelector { get; set; }

    /// <summary>Amazon Resource Name (ARN) of destination DataSync Location.</summary>
    [JsonPropertyName("destinationLocationArn")]
    public string? DestinationLocationArn { get; set; }

    /// <summary>Reference to a LocationS3 in datasync to populate destinationLocationArn.</summary>
    [JsonPropertyName("destinationLocationArnRef")]
    public V1beta2TaskSpecInitProviderDestinationLocationArnRef? DestinationLocationArnRef { get; set; }

    /// <summary>Selector for a LocationS3 in datasync to populate destinationLocationArn.</summary>
    [JsonPropertyName("destinationLocationArnSelector")]
    public V1beta2TaskSpecInitProviderDestinationLocationArnSelector? DestinationLocationArnSelector { get; set; }

    /// <summary>Filter rules that determines which files to exclude from a task.</summary>
    [JsonPropertyName("excludes")]
    public V1beta2TaskSpecInitProviderExcludes? Excludes { get; set; }

    /// <summary>Filter rules that determines which files to include in a task.</summary>
    [JsonPropertyName("includes")]
    public V1beta2TaskSpecInitProviderIncludes? Includes { get; set; }

    /// <summary>Name of the DataSync Task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.</summary>
    [JsonPropertyName("options")]
    public V1beta2TaskSpecInitProviderOptions? Options { get; set; }

    /// <summary>Specifies a schedule used to periodically transfer files from a source to a destination location.</summary>
    [JsonPropertyName("schedule")]
    public V1beta2TaskSpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>Amazon Resource Name (ARN) of source DataSync Location.</summary>
    [JsonPropertyName("sourceLocationArn")]
    public string? SourceLocationArn { get; set; }

    /// <summary>Reference to a LocationS3 in datasync to populate sourceLocationArn.</summary>
    [JsonPropertyName("sourceLocationArnRef")]
    public V1beta2TaskSpecInitProviderSourceLocationArnRef? SourceLocationArnRef { get; set; }

    /// <summary>Selector for a LocationS3 in datasync to populate sourceLocationArn.</summary>
    [JsonPropertyName("sourceLocationArnSelector")]
    public V1beta2TaskSpecInitProviderSourceLocationArnSelector? SourceLocationArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One of the following task modes for your data transfer:</summary>
    [JsonPropertyName("taskMode")]
    public string? TaskMode { get; set; }

    /// <summary>Configuration block containing the configuration of a DataSync Task Report. See task_report_config below.</summary>
    [JsonPropertyName("taskReportConfig")]
    public V1beta2TaskSpecInitProviderTaskReportConfig? TaskReportConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecManagementPoliciesEnum>))]
public enum V1beta2TaskSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2TaskSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2TaskSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TaskSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>TaskSpec defines the desired state of Task</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskSpec
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
    public V1beta2TaskSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2TaskSpecForProvider ForProvider { get; set; }

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
    public V1beta2TaskSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2TaskSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2TaskSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2TaskSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Filter rules that determines which files to exclude from a task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskStatusAtProviderExcludes
{
    /// <summary>The type of filter rule to apply. Valid values: SIMPLE_PATTERN.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>A single filter string that consists of the patterns to exclude. The patterns are delimited by &quot;|&quot; (that is, a pipe), for example: /folder1|/folder2</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Filter rules that determines which files to include in a task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskStatusAtProviderIncludes
{
    /// <summary>The type of filter rule to apply. Valid values: SIMPLE_PATTERN.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>A single filter string that consists of the patterns to exclude. The patterns are delimited by &quot;|&quot; (that is, a pipe), for example: /folder1|/folder2</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskStatusAtProviderOptions
{
    /// <summary>A file metadata that shows the last time a file was accessed (that is when the file was read or written to). If set to BEST_EFFORT, the DataSync Task attempts to preserve the original (that is, the version before sync PREPARING phase) atime attribute on all source files. Valid values: BEST_EFFORT, NONE. Default: BEST_EFFORT.</summary>
    [JsonPropertyName("atime")]
    public string? Atime { get; set; }

    /// <summary>Limits the bandwidth utilized. For example, to set a maximum of 1 MB, set this value to 1048576. Value values: -1 or greater. Default: -1 (unlimited).</summary>
    [JsonPropertyName("bytesPerSecond")]
    public double? BytesPerSecond { get; set; }

    /// <summary>Group identifier of the file&apos;s owners. Valid values: BOTH, INT_VALUE, NAME, NONE. Default: INT_VALUE (preserve integer value of the ID).</summary>
    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    /// <summary>Determines the type of logs that DataSync publishes to a log stream in the Amazon CloudWatch log group that you provide. Valid values: OFF, BASIC, TRANSFER. Default: OFF.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>A file metadata that indicates the last time a file was modified (written to) before the sync PREPARING phase. Value values: NONE, PRESERVE. Default: PRESERVE.</summary>
    [JsonPropertyName("mtime")]
    public string? Mtime { get; set; }

    /// <summary>Specifies whether object tags are maintained when transferring between object storage systems. If you want your DataSync task to ignore object tags, specify the NONE value. Valid values: PRESERVE, NONE. Default value: PRESERVE.</summary>
    [JsonPropertyName("objectTags")]
    public string? ObjectTags { get; set; }

    /// <summary>Determines whether files at the destination should be overwritten or preserved when copying files. Valid values: ALWAYS, NEVER. Default: ALWAYS.</summary>
    [JsonPropertyName("overwriteMode")]
    public string? OverwriteMode { get; set; }

    /// <summary>Determines which users or groups can access a file for a specific purpose such as reading, writing, or execution of the file. Valid values: NONE, PRESERVE. Default: PRESERVE.</summary>
    [JsonPropertyName("posixPermissions")]
    public string? PosixPermissions { get; set; }

    /// <summary>Whether files deleted in the source should be removed or preserved in the destination file system. Valid values: PRESERVE, REMOVE. Default: PRESERVE.</summary>
    [JsonPropertyName("preserveDeletedFiles")]
    public string? PreserveDeletedFiles { get; set; }

    /// <summary>Whether the DataSync Task should preserve the metadata of block and character devices in the source files system, and recreate the files with that device name and metadata on the destination. The DataSync Task can’t sync the actual contents of such devices, because many of the devices are non-terminal and don’t return an end of file (EOF) marker. Valid values: NONE, PRESERVE. Default: NONE (ignore special devices).</summary>
    [JsonPropertyName("preserveDevices")]
    public string? PreserveDevices { get; set; }

    /// <summary>Determines which components of the SMB security descriptor are copied from source to destination objects. This value is only used for transfers between SMB and Amazon FSx for Windows File Server locations, or between two Amazon FSx for Windows File Server locations. Valid values: NONE, OWNER_DACL, OWNER_DACL_SACL. Default: OWNER_DACL.</summary>
    [JsonPropertyName("securityDescriptorCopyFlags")]
    public string? SecurityDescriptorCopyFlags { get; set; }

    /// <summary>Determines whether tasks should be queued before executing the tasks. Valid values: ENABLED, DISABLED. Default ENABLED.</summary>
    [JsonPropertyName("taskQueueing")]
    public string? TaskQueueing { get; set; }

    /// <summary>Determines whether DataSync transfers only the data and metadata that differ between the source and the destination location, or whether DataSync transfers all the content from the source, without comparing to the destination location. Valid values: CHANGED, ALL. Default: CHANGED</summary>
    [JsonPropertyName("transferMode")]
    public string? TransferMode { get; set; }

    /// <summary>User identifier of the file&apos;s owners. Valid values: BOTH, INT_VALUE, NAME, NONE. Default: INT_VALUE (preserve integer value of the ID).</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Whether a data integrity verification should be performed at the end of a task execution after all data and metadata have been transferred. Valid values: NONE, POINT_IN_TIME_CONSISTENT, ONLY_FILES_TRANSFERRED. Default: POINT_IN_TIME_CONSISTENT.</summary>
    [JsonPropertyName("verifyMode")]
    public string? VerifyMode { get; set; }
}

/// <summary>Specifies a schedule used to periodically transfer files from a source to a destination location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskStatusAtProviderSchedule
{
    /// <summary>Specifies the schedule you want your task to use for repeated executions. For more information, see Schedule Expressions for Rules.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }
}

/// <summary>Configuration block containing the configuration of the reporting level for aspects of your task report. See report_overrides below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskStatusAtProviderTaskReportConfigReportOverrides
{
    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to delete in your destination location. This only applies if you configure your task to delete data in the destination that isn&apos;t in the source. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("deletedOverride")]
    public string? DeletedOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to skip during your transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("skippedOverride")]
    public string? SkippedOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("transferredOverride")]
    public string? TransferredOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to verify at the end of your transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("verifiedOverride")]
    public string? VerifiedOverride { get; set; }
}

/// <summary>Configuration block containing the configuration for the Amazon S3 bucket where DataSync uploads your task report. See s3_destination below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskStatusAtProviderTaskReportConfigS3Destination
{
    /// <summary>Specifies the Amazon Resource Name (ARN) of the IAM policy that allows DataSync to upload a task report to your S3 bucket.</summary>
    [JsonPropertyName("bucketAccessRoleArn")]
    public string? BucketAccessRoleArn { get; set; }

    /// <summary>Specifies the ARN of the S3 bucket where DataSync uploads your report.</summary>
    [JsonPropertyName("s3BucketArn")]
    public string? S3BucketArn { get; set; }

    /// <summary>Specifies a bucket prefix for your report.</summary>
    [JsonPropertyName("subdirectory")]
    public string? Subdirectory { get; set; }
}

/// <summary>Configuration block containing the configuration of a DataSync Task Report. See task_report_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskStatusAtProviderTaskReportConfig
{
    /// <summary>Specifies the type of task report you&apos;d like. Valid values: SUMMARY_ONLY and STANDARD.</summary>
    [JsonPropertyName("outputType")]
    public string? OutputType { get; set; }

    /// <summary>Specifies whether you want your task report to include only what went wrong with your transfer or a list of what succeeded and didn&apos;t. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("reportLevel")]
    public string? ReportLevel { get; set; }

    /// <summary>Configuration block containing the configuration of the reporting level for aspects of your task report. See report_overrides below.</summary>
    [JsonPropertyName("reportOverrides")]
    public V1beta2TaskStatusAtProviderTaskReportConfigReportOverrides? ReportOverrides { get; set; }

    /// <summary>Configuration block containing the configuration for the Amazon S3 bucket where DataSync uploads your task report. See s3_destination below.</summary>
    [JsonPropertyName("s3Destination")]
    public V1beta2TaskStatusAtProviderTaskReportConfigS3Destination? S3Destination { get; set; }

    /// <summary>Specifies whether your task report includes the new version of each object transferred into an S3 bucket. This only applies if you enable versioning on your bucket. Keep in mind that setting this to INCLUDE can increase the duration of your task execution. Valid values: INCLUDE and NONE.</summary>
    [JsonPropertyName("s3ObjectVersioning")]
    public string? S3ObjectVersioning { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the DataSync Task.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the CloudWatch Log Group that is used to monitor and log events in the sync task.</summary>
    [JsonPropertyName("cloudwatchLogGroupArn")]
    public string? CloudwatchLogGroupArn { get; set; }

    /// <summary>Amazon Resource Name (ARN) of destination DataSync Location.</summary>
    [JsonPropertyName("destinationLocationArn")]
    public string? DestinationLocationArn { get; set; }

    /// <summary>Filter rules that determines which files to exclude from a task.</summary>
    [JsonPropertyName("excludes")]
    public V1beta2TaskStatusAtProviderExcludes? Excludes { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the DataSync Task.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Filter rules that determines which files to include in a task.</summary>
    [JsonPropertyName("includes")]
    public V1beta2TaskStatusAtProviderIncludes? Includes { get; set; }

    /// <summary>Name of the DataSync Task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.</summary>
    [JsonPropertyName("options")]
    public V1beta2TaskStatusAtProviderOptions? Options { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Specifies a schedule used to periodically transfer files from a source to a destination location.</summary>
    [JsonPropertyName("schedule")]
    public V1beta2TaskStatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>Amazon Resource Name (ARN) of source DataSync Location.</summary>
    [JsonPropertyName("sourceLocationArn")]
    public string? SourceLocationArn { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>One of the following task modes for your data transfer:</summary>
    [JsonPropertyName("taskMode")]
    public string? TaskMode { get; set; }

    /// <summary>Configuration block containing the configuration of a DataSync Task Report. See task_report_config below.</summary>
    [JsonPropertyName("taskReportConfig")]
    public V1beta2TaskStatusAtProviderTaskReportConfig? TaskReportConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskStatusConditions
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

/// <summary>TaskStatus defines the observed state of Task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2TaskStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2TaskStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Task is the Schema for the Tasks API. Manages an AWS DataSync Task</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Task : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2TaskSpec>, IStatus<V1beta2TaskStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Task";
    public const string KubeGroup = "datasync.aws.upbound.io";
    public const string KubePluralName = "tasks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datasync.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Task";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TaskSpec defines the desired state of Task</summary>
    [JsonPropertyName("spec")]
    public required V1beta2TaskSpec Spec { get; set; }

    /// <summary>TaskStatus defines the observed state of Task.</summary>
    [JsonPropertyName("status")]
    public V1beta2TaskStatus? Status { get; set; }
}