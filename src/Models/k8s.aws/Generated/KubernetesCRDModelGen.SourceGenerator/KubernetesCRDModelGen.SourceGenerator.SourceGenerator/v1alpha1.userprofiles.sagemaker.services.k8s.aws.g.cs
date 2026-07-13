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
/// <summary>UserProfile is the Schema for the UserProfiles API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1UserProfileList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1UserProfile>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "UserProfileList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "userprofiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserProfileList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1UserProfile objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1UserProfile> Items { get; set; }
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
public partial class V1alpha1UserProfileSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Specifies the ARN&apos;s of a SageMaker AI image and SageMaker AI image version,
/// and the instance type that the version runs on.
/// 
/// When both SageMakerImageVersionArn and SageMakerImageArn are passed, SageMakerImageVersionArn
/// is used. Any updates to SageMakerImageArn will not take effect if SageMakerImageVersionArn
/// already exists in the ResourceSpec because SageMakerImageVersionArn always
/// takes precedence. To clear the value set for SageMakerImageVersionArn, pass
/// None as the value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("lifecycleConfigARN")]
    public string? LifecycleConfigARN { get; set; }

    [JsonPropertyName("sageMakerImageARN")]
    public string? SageMakerImageARN { get; set; }

    [JsonPropertyName("sageMakerImageVersionARN")]
    public string? SageMakerImageVersionARN { get; set; }

    [JsonPropertyName("sageMakerImageVersionAlias")]
    public string? SageMakerImageVersionAlias { get; set; }
}

/// <summary>
/// The Code Editor application settings.
/// 
/// For more information about Code Editor, see Get started with Code Editor
/// in Amazon SageMaker (https://docs.aws.amazon.com/sagemaker/latest/dg/code-editor.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsCodeEditorAppSettings
{
    /// <summary>
    /// Specifies the ARN&apos;s of a SageMaker AI image and SageMaker AI image version,
    /// and the instance type that the version runs on.
    /// 
    /// When both SageMakerImageVersionArn and SageMakerImageArn are passed, SageMakerImageVersionArn
    /// is used. Any updates to SageMakerImageArn will not take effect if SageMakerImageVersionArn
    /// already exists in the ResourceSpec because SageMakerImageVersionArn always
    /// takes precedence. To clear the value set for SageMakerImageVersionArn, pass
    /// None as the value.
    /// </summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1alpha1UserProfileSpecUserSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// The settings for assigning a custom Amazon EFS file system to a user profile
/// or space for an Amazon SageMaker AI Domain.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsCustomFileSystemConfigsEfsFileSystemConfig
{
    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }

    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

/// <summary>
/// The settings for assigning a custom Amazon FSx for Lustre file system to
/// a user profile or space for an Amazon SageMaker Domain.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsCustomFileSystemConfigsFSxLustreFileSystemConfig
{
    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }

    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

/// <summary>Configuration for the custom Amazon S3 file system.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsCustomFileSystemConfigsS3FileSystemConfig
{
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// The settings for assigning a custom file system to a user profile or space
/// for an Amazon SageMaker AI Domain. Permitted users can access this file system
/// in Amazon SageMaker AI Studio.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsCustomFileSystemConfigs
{
    /// <summary>
    /// The settings for assigning a custom Amazon EFS file system to a user profile
    /// or space for an Amazon SageMaker AI Domain.
    /// </summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public V1alpha1UserProfileSpecUserSettingsCustomFileSystemConfigsEfsFileSystemConfig? EfsFileSystemConfig { get; set; }

    /// <summary>
    /// The settings for assigning a custom Amazon FSx for Lustre file system to
    /// a user profile or space for an Amazon SageMaker Domain.
    /// </summary>
    [JsonPropertyName("fSxLustreFileSystemConfig")]
    public V1alpha1UserProfileSpecUserSettingsCustomFileSystemConfigsFSxLustreFileSystemConfig? FSxLustreFileSystemConfig { get; set; }

    /// <summary>Configuration for the custom Amazon S3 file system.</summary>
    [JsonPropertyName("s3FileSystemConfig")]
    public V1alpha1UserProfileSpecUserSettingsCustomFileSystemConfigsS3FileSystemConfig? S3FileSystemConfig { get; set; }
}

/// <summary>Details about the POSIX identity that is used for file system operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsCustomPosixUserConfig
{
    [JsonPropertyName("gid")]
    public long? Gid { get; set; }

    [JsonPropertyName("uid")]
    public long? Uid { get; set; }
}

/// <summary>
/// A Git repository that SageMaker AI automatically displays to users for cloning
/// in the JupyterServer application.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsJupyterLabAppSettingsCodeRepositories
{
    [JsonPropertyName("repositoryURL")]
    public string? RepositoryURL { get; set; }
}

/// <summary>
/// A custom SageMaker AI image. For more information, see Bring your own SageMaker
/// AI image (https://docs.aws.amazon.com/sagemaker/latest/dg/studio-byoi.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsJupyterLabAppSettingsCustomImages
{
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    [JsonPropertyName("imageVersionNumber")]
    public long? ImageVersionNumber { get; set; }
}

/// <summary>
/// Specifies the ARN&apos;s of a SageMaker AI image and SageMaker AI image version,
/// and the instance type that the version runs on.
/// 
/// When both SageMakerImageVersionArn and SageMakerImageArn are passed, SageMakerImageVersionArn
/// is used. Any updates to SageMakerImageArn will not take effect if SageMakerImageVersionArn
/// already exists in the ResourceSpec because SageMakerImageVersionArn always
/// takes precedence. To clear the value set for SageMakerImageVersionArn, pass
/// None as the value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("lifecycleConfigARN")]
    public string? LifecycleConfigARN { get; set; }

    [JsonPropertyName("sageMakerImageARN")]
    public string? SageMakerImageARN { get; set; }

    [JsonPropertyName("sageMakerImageVersionARN")]
    public string? SageMakerImageVersionARN { get; set; }

    [JsonPropertyName("sageMakerImageVersionAlias")]
    public string? SageMakerImageVersionAlias { get; set; }
}

/// <summary>The settings for the JupyterLab application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsJupyterLabAppSettings
{
    [JsonPropertyName("codeRepositories")]
    public IList<V1alpha1UserProfileSpecUserSettingsJupyterLabAppSettingsCodeRepositories>? CodeRepositories { get; set; }

    [JsonPropertyName("customImages")]
    public IList<V1alpha1UserProfileSpecUserSettingsJupyterLabAppSettingsCustomImages>? CustomImages { get; set; }

    /// <summary>
    /// Specifies the ARN&apos;s of a SageMaker AI image and SageMaker AI image version,
    /// and the instance type that the version runs on.
    /// 
    /// When both SageMakerImageVersionArn and SageMakerImageArn are passed, SageMakerImageVersionArn
    /// is used. Any updates to SageMakerImageArn will not take effect if SageMakerImageVersionArn
    /// already exists in the ResourceSpec because SageMakerImageVersionArn always
    /// takes precedence. To clear the value set for SageMakerImageVersionArn, pass
    /// None as the value.
    /// </summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1alpha1UserProfileSpecUserSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// A Git repository that SageMaker AI automatically displays to users for cloning
/// in the JupyterServer application.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsJupyterServerAppSettingsCodeRepositories
{
    [JsonPropertyName("repositoryURL")]
    public string? RepositoryURL { get; set; }
}

/// <summary>
/// Specifies the ARN&apos;s of a SageMaker AI image and SageMaker AI image version,
/// and the instance type that the version runs on.
/// 
/// When both SageMakerImageVersionArn and SageMakerImageArn are passed, SageMakerImageVersionArn
/// is used. Any updates to SageMakerImageArn will not take effect if SageMakerImageVersionArn
/// already exists in the ResourceSpec because SageMakerImageVersionArn always
/// takes precedence. To clear the value set for SageMakerImageVersionArn, pass
/// None as the value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("lifecycleConfigARN")]
    public string? LifecycleConfigARN { get; set; }

    [JsonPropertyName("sageMakerImageARN")]
    public string? SageMakerImageARN { get; set; }

    [JsonPropertyName("sageMakerImageVersionARN")]
    public string? SageMakerImageVersionARN { get; set; }

    [JsonPropertyName("sageMakerImageVersionAlias")]
    public string? SageMakerImageVersionAlias { get; set; }
}

/// <summary>The JupyterServer app settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsJupyterServerAppSettings
{
    [JsonPropertyName("codeRepositories")]
    public IList<V1alpha1UserProfileSpecUserSettingsJupyterServerAppSettingsCodeRepositories>? CodeRepositories { get; set; }

    /// <summary>
    /// Specifies the ARN&apos;s of a SageMaker AI image and SageMaker AI image version,
    /// and the instance type that the version runs on.
    /// 
    /// When both SageMakerImageVersionArn and SageMakerImageArn are passed, SageMakerImageVersionArn
    /// is used. Any updates to SageMakerImageArn will not take effect if SageMakerImageVersionArn
    /// already exists in the ResourceSpec because SageMakerImageVersionArn always
    /// takes precedence. To clear the value set for SageMakerImageVersionArn, pass
    /// None as the value.
    /// </summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1alpha1UserProfileSpecUserSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// A custom SageMaker AI image. For more information, see Bring your own SageMaker
/// AI image (https://docs.aws.amazon.com/sagemaker/latest/dg/studio-byoi.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsKernelGatewayAppSettingsCustomImages
{
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    [JsonPropertyName("imageVersionNumber")]
    public long? ImageVersionNumber { get; set; }
}

/// <summary>
/// Specifies the ARN&apos;s of a SageMaker AI image and SageMaker AI image version,
/// and the instance type that the version runs on.
/// 
/// When both SageMakerImageVersionArn and SageMakerImageArn are passed, SageMakerImageVersionArn
/// is used. Any updates to SageMakerImageArn will not take effect if SageMakerImageVersionArn
/// already exists in the ResourceSpec because SageMakerImageVersionArn always
/// takes precedence. To clear the value set for SageMakerImageVersionArn, pass
/// None as the value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("lifecycleConfigARN")]
    public string? LifecycleConfigARN { get; set; }

    [JsonPropertyName("sageMakerImageARN")]
    public string? SageMakerImageARN { get; set; }

    [JsonPropertyName("sageMakerImageVersionARN")]
    public string? SageMakerImageVersionARN { get; set; }

    [JsonPropertyName("sageMakerImageVersionAlias")]
    public string? SageMakerImageVersionAlias { get; set; }
}

/// <summary>The KernelGateway app settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsKernelGatewayAppSettings
{
    [JsonPropertyName("customImages")]
    public IList<V1alpha1UserProfileSpecUserSettingsKernelGatewayAppSettingsCustomImages>? CustomImages { get; set; }

    /// <summary>
    /// Specifies the ARN&apos;s of a SageMaker AI image and SageMaker AI image version,
    /// and the instance type that the version runs on.
    /// 
    /// When both SageMakerImageVersionArn and SageMakerImageArn are passed, SageMakerImageVersionArn
    /// is used. Any updates to SageMakerImageArn will not take effect if SageMakerImageVersionArn
    /// already exists in the ResourceSpec because SageMakerImageVersionArn always
    /// takes precedence. To clear the value set for SageMakerImageVersionArn, pass
    /// None as the value.
    /// </summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1alpha1UserProfileSpecUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// A collection of settings that configure user interaction with the RStudioServerPro
/// app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsRStudioServerProAppSettings
{
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary>
/// Specifies options for sharing Amazon SageMaker AI Studio notebooks. These
/// settings are specified as part of DefaultUserSettings when the CreateDomain
/// API is called, and as part of UserSettings when the CreateUserProfile API
/// is called. When SharingSettings is not specified, notebook sharing isn&apos;t
/// allowed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsSharingSettings
{
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    [JsonPropertyName("s3KMSKeyID")]
    public string? S3KMSKeyID { get; set; }

    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>
/// A collection of default EBS storage settings that apply to spaces created
/// within a domain or user profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsSpaceStorageSettingsDefaultEBSStorageSettings
{
    [JsonPropertyName("defaultEBSVolumeSizeInGb")]
    public long? DefaultEBSVolumeSizeInGb { get; set; }

    [JsonPropertyName("maximumEBSVolumeSizeInGb")]
    public long? MaximumEBSVolumeSizeInGb { get; set; }
}

/// <summary>The default storage settings for a space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsSpaceStorageSettings
{
    /// <summary>
    /// A collection of default EBS storage settings that apply to spaces created
    /// within a domain or user profile.
    /// </summary>
    [JsonPropertyName("defaultEBSStorageSettings")]
    public V1alpha1UserProfileSpecUserSettingsSpaceStorageSettingsDefaultEBSStorageSettings? DefaultEBSStorageSettings { get; set; }
}

/// <summary>
/// Specifies the ARN&apos;s of a SageMaker AI image and SageMaker AI image version,
/// and the instance type that the version runs on.
/// 
/// When both SageMakerImageVersionArn and SageMakerImageArn are passed, SageMakerImageVersionArn
/// is used. Any updates to SageMakerImageArn will not take effect if SageMakerImageVersionArn
/// already exists in the ResourceSpec because SageMakerImageVersionArn always
/// takes precedence. To clear the value set for SageMakerImageVersionArn, pass
/// None as the value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsTensorBoardAppSettingsDefaultResourceSpec
{
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("lifecycleConfigARN")]
    public string? LifecycleConfigARN { get; set; }

    [JsonPropertyName("sageMakerImageARN")]
    public string? SageMakerImageARN { get; set; }

    [JsonPropertyName("sageMakerImageVersionARN")]
    public string? SageMakerImageVersionARN { get; set; }

    [JsonPropertyName("sageMakerImageVersionAlias")]
    public string? SageMakerImageVersionAlias { get; set; }
}

/// <summary>The TensorBoard app settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettingsTensorBoardAppSettings
{
    /// <summary>
    /// Specifies the ARN&apos;s of a SageMaker AI image and SageMaker AI image version,
    /// and the instance type that the version runs on.
    /// 
    /// When both SageMakerImageVersionArn and SageMakerImageArn are passed, SageMakerImageVersionArn
    /// is used. Any updates to SageMakerImageArn will not take effect if SageMakerImageVersionArn
    /// already exists in the ResourceSpec because SageMakerImageVersionArn always
    /// takes precedence. To clear the value set for SageMakerImageVersionArn, pass
    /// None as the value.
    /// </summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1alpha1UserProfileSpecUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A collection of settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpecUserSettings
{
    /// <summary>
    /// The Code Editor application settings.
    /// 
    /// For more information about Code Editor, see Get started with Code Editor
    /// in Amazon SageMaker (https://docs.aws.amazon.com/sagemaker/latest/dg/code-editor.html).
    /// </summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1alpha1UserProfileSpecUserSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    [JsonPropertyName("customFileSystemConfigs")]
    public IList<V1alpha1UserProfileSpecUserSettingsCustomFileSystemConfigs>? CustomFileSystemConfigs { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public V1alpha1UserProfileSpecUserSettingsCustomPosixUserConfig? CustomPosixUserConfig { get; set; }

    [JsonPropertyName("defaultLandingURI")]
    public string? DefaultLandingURI { get; set; }

    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1alpha1UserProfileSpecUserSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The JupyterServer app settings.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1alpha1UserProfileSpecUserSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The KernelGateway app settings.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1alpha1UserProfileSpecUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>
    /// A collection of settings that configure user interaction with the RStudioServerPro
    /// app.
    /// </summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public V1alpha1UserProfileSpecUserSettingsRStudioServerProAppSettings? RStudioServerProAppSettings { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>
    /// Specifies options for sharing Amazon SageMaker AI Studio notebooks. These
    /// settings are specified as part of DefaultUserSettings when the CreateDomain
    /// API is called, and as part of UserSettings when the CreateUserProfile API
    /// is called. When SharingSettings is not specified, notebook sharing isn&apos;t
    /// allowed.
    /// </summary>
    [JsonPropertyName("sharingSettings")]
    public V1alpha1UserProfileSpecUserSettingsSharingSettings? SharingSettings { get; set; }

    /// <summary>The default storage settings for a space.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1alpha1UserProfileSpecUserSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }

    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The TensorBoard app settings.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public V1alpha1UserProfileSpecUserSettingsTensorBoardAppSettings? TensorBoardAppSettings { get; set; }
}

/// <summary>UserProfileSpec defines the desired state of UserProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileSpec
{
    /// <summary>
    /// The ID of the associated Domain.
    /// 
    /// Regex Pattern: `^d-(-*[a-z0-9]){1,61}$`
    /// </summary>
    [JsonPropertyName("domainID")]
    public required string DomainID { get; set; }

    /// <summary>
    /// A specifier for the type of value specified in SingleSignOnUserValue. Currently,
    /// the only supported value is &quot;UserName&quot;. If the Domain&apos;s AuthMode is IAM Identity
    /// Center, this field is required. If the Domain&apos;s AuthMode is not IAM Identity
    /// Center, this field cannot be specified.
    /// 
    /// Regex Pattern: `^UserName$`
    /// </summary>
    [JsonPropertyName("singleSignOnUserIdentifier")]
    public string? SingleSignOnUserIdentifier { get; set; }

    /// <summary>
    /// The username of the associated Amazon Web Services Single Sign-On User for
    /// this UserProfile. If the Domain&apos;s AuthMode is IAM Identity Center, this field
    /// is required, and must match a valid username of a user in your directory.
    /// If the Domain&apos;s AuthMode is not IAM Identity Center, this field cannot be
    /// specified.
    /// </summary>
    [JsonPropertyName("singleSignOnUserValue")]
    public string? SingleSignOnUserValue { get; set; }

    /// <summary>
    /// Each tag consists of a key and an optional value. Tag keys must be unique
    /// per resource.
    /// 
    /// Tags that you specify for the User Profile are also added to all Apps that
    /// the User Profile launches.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1UserProfileSpecTags>? Tags { get; set; }

    /// <summary>
    /// A name for the UserProfile. This value is not case sensitive.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("userProfileName")]
    public required string UserProfileName { get; set; }

    /// <summary>A collection of settings.</summary>
    [JsonPropertyName("userSettings")]
    public V1alpha1UserProfileSpecUserSettings? UserSettings { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileStatusAckResourceMetadata
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
public partial class V1alpha1UserProfileStatusConditions
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

/// <summary>UserProfileStatus defines the observed state of UserProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserProfileStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1UserProfileStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1UserProfileStatusConditions>? Conditions { get; set; }

    /// <summary>The status.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>UserProfile is the Schema for the UserProfiles API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1UserProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1UserProfileSpec?>, IStatus<V1alpha1UserProfileStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "UserProfile";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "userprofiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserProfile";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserProfileSpec defines the desired state of UserProfile.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1UserProfileSpec? Spec { get; set; }

    /// <summary>UserProfileStatus defines the observed state of UserProfile</summary>
    [JsonPropertyName("status")]
    public V1alpha1UserProfileStatus? Status { get; set; }
}