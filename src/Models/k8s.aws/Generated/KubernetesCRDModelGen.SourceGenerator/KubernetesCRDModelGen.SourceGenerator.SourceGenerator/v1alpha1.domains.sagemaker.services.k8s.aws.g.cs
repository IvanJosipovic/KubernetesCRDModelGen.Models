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
/// <summary>Domain is the Schema for the Domains API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DomainList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Domain>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DomainList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Domain objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Domain> Items { get; set; }
}

/// <summary>
/// The settings for assigning a custom Amazon EFS file system to a user profile
/// or space for an Amazon SageMaker AI Domain.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultSpaceSettingsCustomFileSystemConfigsEfsFileSystemConfig
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
public partial class V1alpha1DomainSpecDefaultSpaceSettingsCustomFileSystemConfigsFSxLustreFileSystemConfig
{
    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }

    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

/// <summary>Configuration for the custom Amazon S3 file system.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultSpaceSettingsCustomFileSystemConfigsS3FileSystemConfig
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
public partial class V1alpha1DomainSpecDefaultSpaceSettingsCustomFileSystemConfigs
{
    /// <summary>
    /// The settings for assigning a custom Amazon EFS file system to a user profile
    /// or space for an Amazon SageMaker AI Domain.
    /// </summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public V1alpha1DomainSpecDefaultSpaceSettingsCustomFileSystemConfigsEfsFileSystemConfig? EfsFileSystemConfig { get; set; }

    /// <summary>
    /// The settings for assigning a custom Amazon FSx for Lustre file system to
    /// a user profile or space for an Amazon SageMaker Domain.
    /// </summary>
    [JsonPropertyName("fSxLustreFileSystemConfig")]
    public V1alpha1DomainSpecDefaultSpaceSettingsCustomFileSystemConfigsFSxLustreFileSystemConfig? FSxLustreFileSystemConfig { get; set; }

    /// <summary>Configuration for the custom Amazon S3 file system.</summary>
    [JsonPropertyName("s3FileSystemConfig")]
    public V1alpha1DomainSpecDefaultSpaceSettingsCustomFileSystemConfigsS3FileSystemConfig? S3FileSystemConfig { get; set; }
}

/// <summary>Details about the POSIX identity that is used for file system operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultSpaceSettingsCustomPosixUserConfig
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
public partial class V1alpha1DomainSpecDefaultSpaceSettingsJupyterLabAppSettingsCodeRepositories
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
public partial class V1alpha1DomainSpecDefaultSpaceSettingsJupyterLabAppSettingsCustomImages
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
public partial class V1alpha1DomainSpecDefaultSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
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
public partial class V1alpha1DomainSpecDefaultSpaceSettingsJupyterLabAppSettings
{
    [JsonPropertyName("codeRepositories")]
    public IList<V1alpha1DomainSpecDefaultSpaceSettingsJupyterLabAppSettingsCodeRepositories>? CodeRepositories { get; set; }

    [JsonPropertyName("customImages")]
    public IList<V1alpha1DomainSpecDefaultSpaceSettingsJupyterLabAppSettingsCustomImages>? CustomImages { get; set; }

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
    public V1alpha1DomainSpecDefaultSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// A Git repository that SageMaker AI automatically displays to users for cloning
/// in the JupyterServer application.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultSpaceSettingsJupyterServerAppSettingsCodeRepositories
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
public partial class V1alpha1DomainSpecDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
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
public partial class V1alpha1DomainSpecDefaultSpaceSettingsJupyterServerAppSettings
{
    [JsonPropertyName("codeRepositories")]
    public IList<V1alpha1DomainSpecDefaultSpaceSettingsJupyterServerAppSettingsCodeRepositories>? CodeRepositories { get; set; }

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
    public V1alpha1DomainSpecDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// A custom SageMaker AI image. For more information, see Bring your own SageMaker
/// AI image (https://docs.aws.amazon.com/sagemaker/latest/dg/studio-byoi.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultSpaceSettingsKernelGatewayAppSettingsCustomImages
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
public partial class V1alpha1DomainSpecDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
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
public partial class V1alpha1DomainSpecDefaultSpaceSettingsKernelGatewayAppSettings
{
    [JsonPropertyName("customImages")]
    public IList<V1alpha1DomainSpecDefaultSpaceSettingsKernelGatewayAppSettingsCustomImages>? CustomImages { get; set; }

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
    public V1alpha1DomainSpecDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// A collection of default EBS storage settings that apply to spaces created
/// within a domain or user profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultSpaceSettingsSpaceStorageSettingsDefaultEBSStorageSettings
{
    [JsonPropertyName("defaultEBSVolumeSizeInGb")]
    public long? DefaultEBSVolumeSizeInGb { get; set; }

    [JsonPropertyName("maximumEBSVolumeSizeInGb")]
    public long? MaximumEBSVolumeSizeInGb { get; set; }
}

/// <summary>The default storage settings for a space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultSpaceSettingsSpaceStorageSettings
{
    /// <summary>
    /// A collection of default EBS storage settings that apply to spaces created
    /// within a domain or user profile.
    /// </summary>
    [JsonPropertyName("defaultEBSStorageSettings")]
    public V1alpha1DomainSpecDefaultSpaceSettingsSpaceStorageSettingsDefaultEBSStorageSettings? DefaultEBSStorageSettings { get; set; }
}

/// <summary>The default settings for shared spaces that users create in the domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultSpaceSettings
{
    [JsonPropertyName("customFileSystemConfigs")]
    public IList<V1alpha1DomainSpecDefaultSpaceSettingsCustomFileSystemConfigs>? CustomFileSystemConfigs { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public V1alpha1DomainSpecDefaultSpaceSettingsCustomPosixUserConfig? CustomPosixUserConfig { get; set; }

    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1alpha1DomainSpecDefaultSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The JupyterServer app settings.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1alpha1DomainSpecDefaultSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The KernelGateway app settings.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1alpha1DomainSpecDefaultSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The default storage settings for a space.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1alpha1DomainSpecDefaultSpaceSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }
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
public partial class V1alpha1DomainSpecDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec
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
public partial class V1alpha1DomainSpecDefaultUserSettingsCodeEditorAppSettings
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
    public V1alpha1DomainSpecDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// The settings for assigning a custom Amazon EFS file system to a user profile
/// or space for an Amazon SageMaker AI Domain.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultUserSettingsCustomFileSystemConfigsEfsFileSystemConfig
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
public partial class V1alpha1DomainSpecDefaultUserSettingsCustomFileSystemConfigsFSxLustreFileSystemConfig
{
    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }

    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

/// <summary>Configuration for the custom Amazon S3 file system.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultUserSettingsCustomFileSystemConfigsS3FileSystemConfig
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
public partial class V1alpha1DomainSpecDefaultUserSettingsCustomFileSystemConfigs
{
    /// <summary>
    /// The settings for assigning a custom Amazon EFS file system to a user profile
    /// or space for an Amazon SageMaker AI Domain.
    /// </summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public V1alpha1DomainSpecDefaultUserSettingsCustomFileSystemConfigsEfsFileSystemConfig? EfsFileSystemConfig { get; set; }

    /// <summary>
    /// The settings for assigning a custom Amazon FSx for Lustre file system to
    /// a user profile or space for an Amazon SageMaker Domain.
    /// </summary>
    [JsonPropertyName("fSxLustreFileSystemConfig")]
    public V1alpha1DomainSpecDefaultUserSettingsCustomFileSystemConfigsFSxLustreFileSystemConfig? FSxLustreFileSystemConfig { get; set; }

    /// <summary>Configuration for the custom Amazon S3 file system.</summary>
    [JsonPropertyName("s3FileSystemConfig")]
    public V1alpha1DomainSpecDefaultUserSettingsCustomFileSystemConfigsS3FileSystemConfig? S3FileSystemConfig { get; set; }
}

/// <summary>Details about the POSIX identity that is used for file system operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultUserSettingsCustomPosixUserConfig
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
public partial class V1alpha1DomainSpecDefaultUserSettingsJupyterLabAppSettingsCodeRepositories
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
public partial class V1alpha1DomainSpecDefaultUserSettingsJupyterLabAppSettingsCustomImages
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
public partial class V1alpha1DomainSpecDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec
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
public partial class V1alpha1DomainSpecDefaultUserSettingsJupyterLabAppSettings
{
    [JsonPropertyName("codeRepositories")]
    public IList<V1alpha1DomainSpecDefaultUserSettingsJupyterLabAppSettingsCodeRepositories>? CodeRepositories { get; set; }

    [JsonPropertyName("customImages")]
    public IList<V1alpha1DomainSpecDefaultUserSettingsJupyterLabAppSettingsCustomImages>? CustomImages { get; set; }

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
    public V1alpha1DomainSpecDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// A Git repository that SageMaker AI automatically displays to users for cloning
/// in the JupyterServer application.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultUserSettingsJupyterServerAppSettingsCodeRepositories
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
public partial class V1alpha1DomainSpecDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec
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
public partial class V1alpha1DomainSpecDefaultUserSettingsJupyterServerAppSettings
{
    [JsonPropertyName("codeRepositories")]
    public IList<V1alpha1DomainSpecDefaultUserSettingsJupyterServerAppSettingsCodeRepositories>? CodeRepositories { get; set; }

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
    public V1alpha1DomainSpecDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// A custom SageMaker AI image. For more information, see Bring your own SageMaker
/// AI image (https://docs.aws.amazon.com/sagemaker/latest/dg/studio-byoi.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultUserSettingsKernelGatewayAppSettingsCustomImages
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
public partial class V1alpha1DomainSpecDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
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
public partial class V1alpha1DomainSpecDefaultUserSettingsKernelGatewayAppSettings
{
    [JsonPropertyName("customImages")]
    public IList<V1alpha1DomainSpecDefaultUserSettingsKernelGatewayAppSettingsCustomImages>? CustomImages { get; set; }

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
    public V1alpha1DomainSpecDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// A collection of settings that configure user interaction with the RStudioServerPro
/// app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultUserSettingsRStudioServerProAppSettings
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
public partial class V1alpha1DomainSpecDefaultUserSettingsSharingSettings
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
public partial class V1alpha1DomainSpecDefaultUserSettingsSpaceStorageSettingsDefaultEBSStorageSettings
{
    [JsonPropertyName("defaultEBSVolumeSizeInGb")]
    public long? DefaultEBSVolumeSizeInGb { get; set; }

    [JsonPropertyName("maximumEBSVolumeSizeInGb")]
    public long? MaximumEBSVolumeSizeInGb { get; set; }
}

/// <summary>The default storage settings for a space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultUserSettingsSpaceStorageSettings
{
    /// <summary>
    /// A collection of default EBS storage settings that apply to spaces created
    /// within a domain or user profile.
    /// </summary>
    [JsonPropertyName("defaultEBSStorageSettings")]
    public V1alpha1DomainSpecDefaultUserSettingsSpaceStorageSettingsDefaultEBSStorageSettings? DefaultEBSStorageSettings { get; set; }
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
public partial class V1alpha1DomainSpecDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec
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
public partial class V1alpha1DomainSpecDefaultUserSettingsTensorBoardAppSettings
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
    public V1alpha1DomainSpecDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>
/// The default settings to use to create a user profile when UserSettings isn&apos;t
/// specified in the call to the CreateUserProfile API.
/// 
/// SecurityGroups is aggregated when specified in both calls. For all other
/// settings in UserSettings, the values specified in CreateUserProfile take
/// precedence over those specified in CreateDomain.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDefaultUserSettings
{
    /// <summary>
    /// The Code Editor application settings.
    /// 
    /// For more information about Code Editor, see Get started with Code Editor
    /// in Amazon SageMaker (https://docs.aws.amazon.com/sagemaker/latest/dg/code-editor.html).
    /// </summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1alpha1DomainSpecDefaultUserSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    [JsonPropertyName("customFileSystemConfigs")]
    public IList<V1alpha1DomainSpecDefaultUserSettingsCustomFileSystemConfigs>? CustomFileSystemConfigs { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public V1alpha1DomainSpecDefaultUserSettingsCustomPosixUserConfig? CustomPosixUserConfig { get; set; }

    [JsonPropertyName("defaultLandingURI")]
    public string? DefaultLandingURI { get; set; }

    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1alpha1DomainSpecDefaultUserSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The JupyterServer app settings.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1alpha1DomainSpecDefaultUserSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The KernelGateway app settings.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1alpha1DomainSpecDefaultUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>
    /// A collection of settings that configure user interaction with the RStudioServerPro
    /// app.
    /// </summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public V1alpha1DomainSpecDefaultUserSettingsRStudioServerProAppSettings? RStudioServerProAppSettings { get; set; }

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
    public V1alpha1DomainSpecDefaultUserSettingsSharingSettings? SharingSettings { get; set; }

    /// <summary>The default storage settings for a space.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1alpha1DomainSpecDefaultUserSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }

    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The TensorBoard app settings.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public V1alpha1DomainSpecDefaultUserSettingsTensorBoardAppSettings? TensorBoardAppSettings { get; set; }
}

/// <summary>A collection of settings that configure the domain&apos;s Docker interaction.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDomainSettingsDockerSettings
{
    [JsonPropertyName("enableDockerAccess")]
    public string? EnableDockerAccess { get; set; }

    [JsonPropertyName("rootlessDocker")]
    public string? RootlessDocker { get; set; }

    [JsonPropertyName("vpcOnlyTrustedAccounts")]
    public IList<string>? VpcOnlyTrustedAccounts { get; set; }
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
public partial class V1alpha1DomainSpecDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec
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
/// A collection of settings that configure the RStudioServerPro Domain-level
/// app.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDomainSettingsRStudioServerProDomainSettings
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
    public V1alpha1DomainSpecDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("domainExecutionRoleARN")]
    public string? DomainExecutionRoleARN { get; set; }

    [JsonPropertyName("rStudioConnectURL")]
    public string? RStudioConnectURL { get; set; }

    [JsonPropertyName("rStudioPackageManagerURL")]
    public string? RStudioPackageManagerURL { get; set; }
}

/// <summary>
/// The Trusted Identity Propagation (TIP) settings for the SageMaker domain.
/// These settings determine how user identities from IAM Identity Center are
/// propagated through the domain to TIP enabled Amazon Web Services services.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDomainSettingsTrustedIdentityPropagationSettings
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// The settings that apply to an Amazon SageMaker AI domain when you use it
/// in Amazon SageMaker Unified Studio.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDomainSettingsUnifiedStudioSettings
{
    [JsonPropertyName("domainAccountID")]
    public string? DomainAccountID { get; set; }

    [JsonPropertyName("domainID")]
    public string? DomainID { get; set; }

    [JsonPropertyName("domainRegion")]
    public string? DomainRegion { get; set; }

    [JsonPropertyName("environmentID")]
    public string? EnvironmentID { get; set; }

    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }

    [JsonPropertyName("projectS3Path")]
    public string? ProjectS3Path { get; set; }

    [JsonPropertyName("singleSignOnApplicationARN")]
    public string? SingleSignOnApplicationARN { get; set; }

    [JsonPropertyName("studioWebPortalAccess")]
    public string? StudioWebPortalAccess { get; set; }
}

/// <summary>A collection of Domain settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDomainSettings
{
    /// <summary>A collection of settings that configure the domain&apos;s Docker interaction.</summary>
    [JsonPropertyName("dockerSettings")]
    public V1alpha1DomainSpecDomainSettingsDockerSettings? DockerSettings { get; set; }

    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>
    /// A collection of settings that configure the RStudioServerPro Domain-level
    /// app.
    /// </summary>
    [JsonPropertyName("rStudioServerProDomainSettings")]
    public V1alpha1DomainSpecDomainSettingsRStudioServerProDomainSettings? RStudioServerProDomainSettings { get; set; }

    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    /// <summary>
    /// The Trusted Identity Propagation (TIP) settings for the SageMaker domain.
    /// These settings determine how user identities from IAM Identity Center are
    /// propagated through the domain to TIP enabled Amazon Web Services services.
    /// </summary>
    [JsonPropertyName("trustedIdentityPropagationSettings")]
    public V1alpha1DomainSpecDomainSettingsTrustedIdentityPropagationSettings? TrustedIdentityPropagationSettings { get; set; }

    /// <summary>
    /// The settings that apply to an Amazon SageMaker AI domain when you use it
    /// in Amazon SageMaker Unified Studio.
    /// </summary>
    [JsonPropertyName("unifiedStudioSettings")]
    public V1alpha1DomainSpecDomainSettingsUnifiedStudioSettings? UnifiedStudioSettings { get; set; }
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
public partial class V1alpha1DomainSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DomainSpec defines the desired state of Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpec
{
    /// <summary>
    /// Specifies the VPC used for non-EFS traffic. The default value is PublicInternetOnly.
    /// 
    ///   - PublicInternetOnly - Non-EFS traffic is through a VPC managed by Amazon
    ///     SageMaker AI, which allows direct internet access
    /// 
    ///   - VpcOnly - All traffic is through the specified VPC and subnets
    /// </summary>
    [JsonPropertyName("appNetworkAccessType")]
    public string? AppNetworkAccessType { get; set; }

    /// <summary>
    /// The entity that creates and manages the required security groups for inter-app
    /// communication in VPCOnly mode. Required when CreateDomain.AppNetworkAccessType
    /// is VPCOnly and DomainSettings.RStudioServerProDomainSettings.DomainExecutionRoleArn
    /// is provided. If setting up the domain for use with RStudio, this value must
    /// be set to Service.
    /// </summary>
    [JsonPropertyName("appSecurityGroupManagement")]
    public string? AppSecurityGroupManagement { get; set; }

    /// <summary>The mode of authentication that members use to access the domain.</summary>
    [JsonPropertyName("authMode")]
    public required string AuthMode { get; set; }

    /// <summary>The default settings for shared spaces that users create in the domain.</summary>
    [JsonPropertyName("defaultSpaceSettings")]
    public V1alpha1DomainSpecDefaultSpaceSettings? DefaultSpaceSettings { get; set; }

    /// <summary>
    /// The default settings to use to create a user profile when UserSettings isn&apos;t
    /// specified in the call to the CreateUserProfile API.
    /// 
    /// SecurityGroups is aggregated when specified in both calls. For all other
    /// settings in UserSettings, the values specified in CreateUserProfile take
    /// precedence over those specified in CreateDomain.
    /// </summary>
    [JsonPropertyName("defaultUserSettings")]
    public required V1alpha1DomainSpecDefaultUserSettings DefaultUserSettings { get; set; }

    /// <summary>
    /// A name for the domain.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("domainName")]
    public required string DomainName { get; set; }

    /// <summary>A collection of Domain settings.</summary>
    [JsonPropertyName("domainSettings")]
    public V1alpha1DomainSpecDomainSettings? DomainSettings { get; set; }

    /// <summary>
    /// Use KmsKeyId.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9:/_-]*$`
    /// </summary>
    [JsonPropertyName("homeEFSFileSystemKMSKeyID")]
    public string? HomeEFSFileSystemKMSKeyID { get; set; }

    /// <summary>
    /// SageMaker AI uses Amazon Web Services KMS to encrypt EFS and EBS volumes
    /// attached to the domain with an Amazon Web Services managed key by default.
    /// For more control, specify a customer managed key.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9:/_-]*$`
    /// </summary>
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>
    /// The VPC subnets that the domain uses for communication.
    /// 
    /// The field is optional when the AppNetworkAccessType parameter is set to PublicInternetOnly
    /// for domains created from Amazon SageMaker Unified Studio.
    /// </summary>
    [JsonPropertyName("subnetIDs")]
    public IList<string>? SubnetIDs { get; set; }

    /// <summary>
    /// Tags to associated with the Domain. Each tag consists of a key and an optional
    /// value. Tag keys must be unique per resource. Tags are searchable using the
    /// Search API.
    /// 
    /// Tags that you specify for the Domain are also added to all Apps that the
    /// Domain launches.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DomainSpecTags>? Tags { get; set; }

    /// <summary>
    /// The ID of the Amazon Virtual Private Cloud (VPC) that the domain uses for
    /// communication.
    /// 
    /// The field is optional when the AppNetworkAccessType parameter is set to PublicInternetOnly
    /// for domains created from Amazon SageMaker Unified Studio.
    /// 
    /// Regex Pattern: `^[-0-9a-zA-Z]+$`
    /// </summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainStatusAckResourceMetadata
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
public partial class V1alpha1DomainStatusConditions
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

/// <summary>DomainStatus defines the observed state of Domain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DomainStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DomainStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The domain ID.
    /// 
    /// Regex Pattern: `^d-(-*[a-z0-9]){1,61}$`
    /// </summary>
    [JsonPropertyName("domainID")]
    public string? DomainID { get; set; }

    /// <summary>The status.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The URL to the created domain.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Domain is the Schema for the Domains API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Domain : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DomainSpec?>, IStatus<V1alpha1DomainStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Domain";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainSpec defines the desired state of Domain.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DomainSpec? Spec { get; set; }

    /// <summary>DomainStatus defines the observed state of Domain</summary>
    [JsonPropertyName("status")]
    public V1alpha1DomainStatus? Status { get; set; }
}