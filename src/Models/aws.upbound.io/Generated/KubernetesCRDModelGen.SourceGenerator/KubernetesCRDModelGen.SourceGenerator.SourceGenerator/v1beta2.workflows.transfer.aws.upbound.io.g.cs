#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.transfer.aws.upbound.io;
/// <summary>Workflow is the Schema for the Workflows API. Provides a AWS Transfer Workflow resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2WorkflowList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Workflow>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "WorkflowList";
    public const string KubeGroup = "transfer.aws.upbound.io";
    public const string KubePluralName = "workflows";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "transfer.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkflowList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Workflow objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Workflow> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowSpecDeletionPolicyEnum>))]
public enum V1beta2WorkflowSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionStepsCopyStepDetailsDestinationFileLocation
{
    /// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
    [JsonPropertyName("efsFileLocation")]
    public V1beta2WorkflowSpecForProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation { get; set; }

    /// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
    [JsonPropertyName("s3FileLocation")]
    public V1beta2WorkflowSpecForProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation { get; set; }
}

/// <summary>Details for a step that performs a file copy. See copy_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionStepsCopyStepDetails
{
    /// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public V1beta2WorkflowSpecForProviderOnExceptionStepsCopyStepDetailsDestinationFileLocation? DestinationFileLocation { get; set; }

    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary>Details for a step that invokes a lambda function. See custom_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionStepsCustomStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>ARN for the lambda function that is being called.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Timeout, in seconds, for the step.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocation
{
    /// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
    [JsonPropertyName("efsFileLocation")]
    public V1beta2WorkflowSpecForProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation { get; set; }

    /// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
    [JsonPropertyName("s3FileLocation")]
    public V1beta2WorkflowSpecForProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation { get; set; }
}

/// <summary>Details for a step that decrypts the file. See decrypt_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionStepsDecryptStepDetails
{
    /// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public V1beta2WorkflowSpecForProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocation? DestinationFileLocation { get; set; }

    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Type of encryption used. Currently, this value must be &quot;PGP&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details for a step that deletes the file. See delete_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionStepsDeleteStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionStepsTagStepDetailsTags
{
    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value that corresponds to the key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Details for a step that creates one or more tags. See tag_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionStepsTagStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta2WorkflowSpecForProviderOnExceptionStepsTagStepDetailsTags>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderOnExceptionSteps
{
    /// <summary>Details for a step that performs a file copy. See copy_step_details Block below.</summary>
    [JsonPropertyName("copyStepDetails")]
    public V1beta2WorkflowSpecForProviderOnExceptionStepsCopyStepDetails? CopyStepDetails { get; set; }

    /// <summary>Details for a step that invokes a lambda function. See custom_step_details Block below.</summary>
    [JsonPropertyName("customStepDetails")]
    public V1beta2WorkflowSpecForProviderOnExceptionStepsCustomStepDetails? CustomStepDetails { get; set; }

    /// <summary>Details for a step that decrypts the file. See decrypt_step_details Block below.</summary>
    [JsonPropertyName("decryptStepDetails")]
    public V1beta2WorkflowSpecForProviderOnExceptionStepsDecryptStepDetails? DecryptStepDetails { get; set; }

    /// <summary>Details for a step that deletes the file. See delete_step_details Block below.</summary>
    [JsonPropertyName("deleteStepDetails")]
    public V1beta2WorkflowSpecForProviderOnExceptionStepsDeleteStepDetails? DeleteStepDetails { get; set; }

    /// <summary>Details for a step that creates one or more tags. See tag_step_details Block below.</summary>
    [JsonPropertyName("tagStepDetails")]
    public V1beta2WorkflowSpecForProviderOnExceptionStepsTagStepDetails? TagStepDetails { get; set; }

    /// <summary>Step type. Valid values are COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsCopyStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsCopyStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsCopyStepDetailsDestinationFileLocation
{
    /// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
    [JsonPropertyName("efsFileLocation")]
    public V1beta2WorkflowSpecForProviderStepsCopyStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation { get; set; }

    /// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
    [JsonPropertyName("s3FileLocation")]
    public V1beta2WorkflowSpecForProviderStepsCopyStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation { get; set; }
}

/// <summary>Details for a step that performs a file copy. See copy_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsCopyStepDetails
{
    /// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public V1beta2WorkflowSpecForProviderStepsCopyStepDetailsDestinationFileLocation? DestinationFileLocation { get; set; }

    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetRefPolicyResolutionEnum>))]
public enum V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetRefPolicyResolveEnum>))]
public enum V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetSelectorPolicyResolveEnum>))]
public enum V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetSelector
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
    public V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetSelectorPolicy? Policy { get; set; }
}

/// <summary>Details for a step that invokes a lambda function. See custom_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsCustomStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>ARN for the lambda function that is being called.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Reference to a Function in lambda to populate target.</summary>
    [JsonPropertyName("targetRef")]
    public V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetRef? TargetRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate target.</summary>
    [JsonPropertyName("targetSelector")]
    public V1beta2WorkflowSpecForProviderStepsCustomStepDetailsTargetSelector? TargetSelector { get; set; }

    /// <summary>Timeout, in seconds, for the step.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsDecryptStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsDecryptStepDetailsDestinationFileLocation
{
    /// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
    [JsonPropertyName("efsFileLocation")]
    public V1beta2WorkflowSpecForProviderStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation { get; set; }

    /// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
    [JsonPropertyName("s3FileLocation")]
    public V1beta2WorkflowSpecForProviderStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation { get; set; }
}

/// <summary>Details for a step that decrypts the file. See decrypt_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsDecryptStepDetails
{
    /// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public V1beta2WorkflowSpecForProviderStepsDecryptStepDetailsDestinationFileLocation? DestinationFileLocation { get; set; }

    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Type of encryption used. Currently, this value must be &quot;PGP&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details for a step that deletes the file. See delete_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsDeleteStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsTagStepDetailsTags
{
    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value that corresponds to the key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Details for a step that creates one or more tags. See tag_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderStepsTagStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta2WorkflowSpecForProviderStepsTagStepDetailsTags>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProviderSteps
{
    /// <summary>Details for a step that performs a file copy. See copy_step_details Block below.</summary>
    [JsonPropertyName("copyStepDetails")]
    public V1beta2WorkflowSpecForProviderStepsCopyStepDetails? CopyStepDetails { get; set; }

    /// <summary>Details for a step that invokes a lambda function. See custom_step_details Block below.</summary>
    [JsonPropertyName("customStepDetails")]
    public V1beta2WorkflowSpecForProviderStepsCustomStepDetails? CustomStepDetails { get; set; }

    /// <summary>Details for a step that decrypts the file. See decrypt_step_details Block below.</summary>
    [JsonPropertyName("decryptStepDetails")]
    public V1beta2WorkflowSpecForProviderStepsDecryptStepDetails? DecryptStepDetails { get; set; }

    /// <summary>Details for a step that deletes the file. See delete_step_details Block below.</summary>
    [JsonPropertyName("deleteStepDetails")]
    public V1beta2WorkflowSpecForProviderStepsDeleteStepDetails? DeleteStepDetails { get; set; }

    /// <summary>Details for a step that creates one or more tags. See tag_step_details Block below.</summary>
    [JsonPropertyName("tagStepDetails")]
    public V1beta2WorkflowSpecForProviderStepsTagStepDetails? TagStepDetails { get; set; }

    /// <summary>Step type. Valid values are COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecForProvider
{
    /// <summary>Textual description for the workflow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Steps (actions) to take if errors are encountered during execution of the workflow. See on_exception_steps Block below.</summary>
    [JsonPropertyName("onExceptionSteps")]
    public IList<V1beta2WorkflowSpecForProviderOnExceptionSteps>? OnExceptionSteps { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Details for the steps that are in the specified workflow. See steps Block below.</summary>
    [JsonPropertyName("steps")]
    public IList<V1beta2WorkflowSpecForProviderSteps>? Steps { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionStepsCopyStepDetailsDestinationFileLocation
{
    /// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
    [JsonPropertyName("efsFileLocation")]
    public V1beta2WorkflowSpecInitProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation { get; set; }

    /// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
    [JsonPropertyName("s3FileLocation")]
    public V1beta2WorkflowSpecInitProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation { get; set; }
}

/// <summary>Details for a step that performs a file copy. See copy_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionStepsCopyStepDetails
{
    /// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public V1beta2WorkflowSpecInitProviderOnExceptionStepsCopyStepDetailsDestinationFileLocation? DestinationFileLocation { get; set; }

    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary>Details for a step that invokes a lambda function. See custom_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionStepsCustomStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>ARN for the lambda function that is being called.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Timeout, in seconds, for the step.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocation
{
    /// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
    [JsonPropertyName("efsFileLocation")]
    public V1beta2WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation { get; set; }

    /// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
    [JsonPropertyName("s3FileLocation")]
    public V1beta2WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation { get; set; }
}

/// <summary>Details for a step that decrypts the file. See decrypt_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetails
{
    /// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public V1beta2WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocation? DestinationFileLocation { get; set; }

    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Type of encryption used. Currently, this value must be &quot;PGP&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details for a step that deletes the file. See delete_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionStepsDeleteStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionStepsTagStepDetailsTags
{
    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value that corresponds to the key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Details for a step that creates one or more tags. See tag_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionStepsTagStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta2WorkflowSpecInitProviderOnExceptionStepsTagStepDetailsTags>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderOnExceptionSteps
{
    /// <summary>Details for a step that performs a file copy. See copy_step_details Block below.</summary>
    [JsonPropertyName("copyStepDetails")]
    public V1beta2WorkflowSpecInitProviderOnExceptionStepsCopyStepDetails? CopyStepDetails { get; set; }

    /// <summary>Details for a step that invokes a lambda function. See custom_step_details Block below.</summary>
    [JsonPropertyName("customStepDetails")]
    public V1beta2WorkflowSpecInitProviderOnExceptionStepsCustomStepDetails? CustomStepDetails { get; set; }

    /// <summary>Details for a step that decrypts the file. See decrypt_step_details Block below.</summary>
    [JsonPropertyName("decryptStepDetails")]
    public V1beta2WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetails? DecryptStepDetails { get; set; }

    /// <summary>Details for a step that deletes the file. See delete_step_details Block below.</summary>
    [JsonPropertyName("deleteStepDetails")]
    public V1beta2WorkflowSpecInitProviderOnExceptionStepsDeleteStepDetails? DeleteStepDetails { get; set; }

    /// <summary>Details for a step that creates one or more tags. See tag_step_details Block below.</summary>
    [JsonPropertyName("tagStepDetails")]
    public V1beta2WorkflowSpecInitProviderOnExceptionStepsTagStepDetails? TagStepDetails { get; set; }

    /// <summary>Step type. Valid values are COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsCopyStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsCopyStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsCopyStepDetailsDestinationFileLocation
{
    /// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
    [JsonPropertyName("efsFileLocation")]
    public V1beta2WorkflowSpecInitProviderStepsCopyStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation { get; set; }

    /// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
    [JsonPropertyName("s3FileLocation")]
    public V1beta2WorkflowSpecInitProviderStepsCopyStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation { get; set; }
}

/// <summary>Details for a step that performs a file copy. See copy_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsCopyStepDetails
{
    /// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public V1beta2WorkflowSpecInitProviderStepsCopyStepDetailsDestinationFileLocation? DestinationFileLocation { get; set; }

    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetRefPolicyResolutionEnum>))]
public enum V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetRefPolicyResolveEnum>))]
public enum V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelectorPolicyResolveEnum>))]
public enum V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelector
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
    public V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelectorPolicy? Policy { get; set; }
}

/// <summary>Details for a step that invokes a lambda function. See custom_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsCustomStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>ARN for the lambda function that is being called.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Reference to a Function in lambda to populate target.</summary>
    [JsonPropertyName("targetRef")]
    public V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetRef? TargetRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate target.</summary>
    [JsonPropertyName("targetSelector")]
    public V1beta2WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelector? TargetSelector { get; set; }

    /// <summary>Timeout, in seconds, for the step.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsDecryptStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsDecryptStepDetailsDestinationFileLocation
{
    /// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
    [JsonPropertyName("efsFileLocation")]
    public V1beta2WorkflowSpecInitProviderStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation { get; set; }

    /// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
    [JsonPropertyName("s3FileLocation")]
    public V1beta2WorkflowSpecInitProviderStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation { get; set; }
}

/// <summary>Details for a step that decrypts the file. See decrypt_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsDecryptStepDetails
{
    /// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public V1beta2WorkflowSpecInitProviderStepsDecryptStepDetailsDestinationFileLocation? DestinationFileLocation { get; set; }

    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Type of encryption used. Currently, this value must be &quot;PGP&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details for a step that deletes the file. See delete_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsDeleteStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsTagStepDetailsTags
{
    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value that corresponds to the key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Details for a step that creates one or more tags. See tag_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderStepsTagStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta2WorkflowSpecInitProviderStepsTagStepDetailsTags>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecInitProviderSteps
{
    /// <summary>Details for a step that performs a file copy. See copy_step_details Block below.</summary>
    [JsonPropertyName("copyStepDetails")]
    public V1beta2WorkflowSpecInitProviderStepsCopyStepDetails? CopyStepDetails { get; set; }

    /// <summary>Details for a step that invokes a lambda function. See custom_step_details Block below.</summary>
    [JsonPropertyName("customStepDetails")]
    public V1beta2WorkflowSpecInitProviderStepsCustomStepDetails? CustomStepDetails { get; set; }

    /// <summary>Details for a step that decrypts the file. See decrypt_step_details Block below.</summary>
    [JsonPropertyName("decryptStepDetails")]
    public V1beta2WorkflowSpecInitProviderStepsDecryptStepDetails? DecryptStepDetails { get; set; }

    /// <summary>Details for a step that deletes the file. See delete_step_details Block below.</summary>
    [JsonPropertyName("deleteStepDetails")]
    public V1beta2WorkflowSpecInitProviderStepsDeleteStepDetails? DeleteStepDetails { get; set; }

    /// <summary>Details for a step that creates one or more tags. See tag_step_details Block below.</summary>
    [JsonPropertyName("tagStepDetails")]
    public V1beta2WorkflowSpecInitProviderStepsTagStepDetails? TagStepDetails { get; set; }

    /// <summary>Step type. Valid values are COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
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
public partial class V1beta2WorkflowSpecInitProvider
{
    /// <summary>Textual description for the workflow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Steps (actions) to take if errors are encountered during execution of the workflow. See on_exception_steps Block below.</summary>
    [JsonPropertyName("onExceptionSteps")]
    public IList<V1beta2WorkflowSpecInitProviderOnExceptionSteps>? OnExceptionSteps { get; set; }

    /// <summary>Details for the steps that are in the specified workflow. See steps Block below.</summary>
    [JsonPropertyName("steps")]
    public IList<V1beta2WorkflowSpecInitProviderSteps>? Steps { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowSpecManagementPoliciesEnum>))]
public enum V1beta2WorkflowSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2WorkflowSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2WorkflowSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkflowSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkflowSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkflowSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>WorkflowSpec defines the desired state of Workflow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowSpec
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
    public V1beta2WorkflowSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2WorkflowSpecForProvider ForProvider { get; set; }

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
    public V1beta2WorkflowSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2WorkflowSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2WorkflowSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2WorkflowSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionStepsCopyStepDetailsDestinationFileLocation
{
    /// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
    [JsonPropertyName("efsFileLocation")]
    public V1beta2WorkflowStatusAtProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation { get; set; }

    /// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
    [JsonPropertyName("s3FileLocation")]
    public V1beta2WorkflowStatusAtProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation { get; set; }
}

/// <summary>Details for a step that performs a file copy. See copy_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionStepsCopyStepDetails
{
    /// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public V1beta2WorkflowStatusAtProviderOnExceptionStepsCopyStepDetailsDestinationFileLocation? DestinationFileLocation { get; set; }

    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary>Details for a step that invokes a lambda function. See custom_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionStepsCustomStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>ARN for the lambda function that is being called.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Timeout, in seconds, for the step.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocation
{
    /// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
    [JsonPropertyName("efsFileLocation")]
    public V1beta2WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation { get; set; }

    /// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
    [JsonPropertyName("s3FileLocation")]
    public V1beta2WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation { get; set; }
}

/// <summary>Details for a step that decrypts the file. See decrypt_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetails
{
    /// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public V1beta2WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocation? DestinationFileLocation { get; set; }

    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Type of encryption used. Currently, this value must be &quot;PGP&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details for a step that deletes the file. See delete_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionStepsDeleteStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionStepsTagStepDetailsTags
{
    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value that corresponds to the key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Details for a step that creates one or more tags. See tag_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionStepsTagStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta2WorkflowStatusAtProviderOnExceptionStepsTagStepDetailsTags>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderOnExceptionSteps
{
    /// <summary>Details for a step that performs a file copy. See copy_step_details Block below.</summary>
    [JsonPropertyName("copyStepDetails")]
    public V1beta2WorkflowStatusAtProviderOnExceptionStepsCopyStepDetails? CopyStepDetails { get; set; }

    /// <summary>Details for a step that invokes a lambda function. See custom_step_details Block below.</summary>
    [JsonPropertyName("customStepDetails")]
    public V1beta2WorkflowStatusAtProviderOnExceptionStepsCustomStepDetails? CustomStepDetails { get; set; }

    /// <summary>Details for a step that decrypts the file. See decrypt_step_details Block below.</summary>
    [JsonPropertyName("decryptStepDetails")]
    public V1beta2WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetails? DecryptStepDetails { get; set; }

    /// <summary>Details for a step that deletes the file. See delete_step_details Block below.</summary>
    [JsonPropertyName("deleteStepDetails")]
    public V1beta2WorkflowStatusAtProviderOnExceptionStepsDeleteStepDetails? DeleteStepDetails { get; set; }

    /// <summary>Details for a step that creates one or more tags. See tag_step_details Block below.</summary>
    [JsonPropertyName("tagStepDetails")]
    public V1beta2WorkflowStatusAtProviderOnExceptionStepsTagStepDetails? TagStepDetails { get; set; }

    /// <summary>Step type. Valid values are COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderStepsCopyStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderStepsCopyStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderStepsCopyStepDetailsDestinationFileLocation
{
    /// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
    [JsonPropertyName("efsFileLocation")]
    public V1beta2WorkflowStatusAtProviderStepsCopyStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation { get; set; }

    /// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
    [JsonPropertyName("s3FileLocation")]
    public V1beta2WorkflowStatusAtProviderStepsCopyStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation { get; set; }
}

/// <summary>Details for a step that performs a file copy. See copy_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderStepsCopyStepDetails
{
    /// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public V1beta2WorkflowStatusAtProviderStepsCopyStepDetailsDestinationFileLocation? DestinationFileLocation { get; set; }

    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary>Details for a step that invokes a lambda function. See custom_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderStepsCustomStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>ARN for the lambda function that is being called.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Timeout, in seconds, for the step.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderStepsDecryptStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderStepsDecryptStepDetailsDestinationFileLocation
{
    /// <summary>Details for the EFS file being copied. See efs_file_location Block below.</summary>
    [JsonPropertyName("efsFileLocation")]
    public V1beta2WorkflowStatusAtProviderStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation { get; set; }

    /// <summary>Details for the S3 file being copied. See s3_file_location Block below.</summary>
    [JsonPropertyName("s3FileLocation")]
    public V1beta2WorkflowStatusAtProviderStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation { get; set; }
}

/// <summary>Details for a step that decrypts the file. See decrypt_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderStepsDecryptStepDetails
{
    /// <summary>Location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username. See destination_file_location Block below.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public V1beta2WorkflowStatusAtProviderStepsDecryptStepDetailsDestinationFileLocation? DestinationFileLocation { get; set; }

    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Type of encryption used. Currently, this value must be &quot;PGP&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details for a step that deletes the file. See delete_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderStepsDeleteStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderStepsTagStepDetailsTags
{
    /// <summary>Name assigned to the tag that you create.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value that corresponds to the key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Details for a step that creates one or more tags. See tag_step_details Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderStepsTagStepDetails
{
    /// <summary>Name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>File to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta2WorkflowStatusAtProviderStepsTagStepDetailsTags>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProviderSteps
{
    /// <summary>Details for a step that performs a file copy. See copy_step_details Block below.</summary>
    [JsonPropertyName("copyStepDetails")]
    public V1beta2WorkflowStatusAtProviderStepsCopyStepDetails? CopyStepDetails { get; set; }

    /// <summary>Details for a step that invokes a lambda function. See custom_step_details Block below.</summary>
    [JsonPropertyName("customStepDetails")]
    public V1beta2WorkflowStatusAtProviderStepsCustomStepDetails? CustomStepDetails { get; set; }

    /// <summary>Details for a step that decrypts the file. See decrypt_step_details Block below.</summary>
    [JsonPropertyName("decryptStepDetails")]
    public V1beta2WorkflowStatusAtProviderStepsDecryptStepDetails? DecryptStepDetails { get; set; }

    /// <summary>Details for a step that deletes the file. See delete_step_details Block below.</summary>
    [JsonPropertyName("deleteStepDetails")]
    public V1beta2WorkflowStatusAtProviderStepsDeleteStepDetails? DeleteStepDetails { get; set; }

    /// <summary>Details for a step that creates one or more tags. See tag_step_details Block below.</summary>
    [JsonPropertyName("tagStepDetails")]
    public V1beta2WorkflowStatusAtProviderStepsTagStepDetails? TagStepDetails { get; set; }

    /// <summary>Step type. Valid values are COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatusAtProvider
{
    /// <summary>Workflow ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Textual description for the workflow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Workflow ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Steps (actions) to take if errors are encountered during execution of the workflow. See on_exception_steps Block below.</summary>
    [JsonPropertyName("onExceptionSteps")]
    public IList<V1beta2WorkflowStatusAtProviderOnExceptionSteps>? OnExceptionSteps { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Details for the steps that are in the specified workflow. See steps Block below.</summary>
    [JsonPropertyName("steps")]
    public IList<V1beta2WorkflowStatusAtProviderSteps>? Steps { get; set; }

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
public partial class V1beta2WorkflowStatusConditions
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

/// <summary>WorkflowStatus defines the observed state of Workflow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2WorkflowStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2WorkflowStatusConditions>? Conditions { get; set; }

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

/// <summary>Workflow is the Schema for the Workflows API. Provides a AWS Transfer Workflow resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Workflow : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2WorkflowSpec>, IStatus<V1beta2WorkflowStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Workflow";
    public const string KubeGroup = "transfer.aws.upbound.io";
    public const string KubePluralName = "workflows";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "transfer.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Workflow";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkflowSpec defines the desired state of Workflow</summary>
    [JsonPropertyName("spec")]
    public required V1beta2WorkflowSpec Spec { get; set; }

    /// <summary>WorkflowStatus defines the observed state of Workflow.</summary>
    [JsonPropertyName("status")]
    public V1beta2WorkflowStatus? Status { get; set; }
}