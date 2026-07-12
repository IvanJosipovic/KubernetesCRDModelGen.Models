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
/// <summary>Space is the Schema for the Spaces API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SpaceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Space>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SpaceList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "spaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpaceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Space objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Space> Items { get; set; }
}

/// <summary>A collection of ownership settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecOwnershipSettings
{
    [JsonPropertyName("ownerUserProfileName")]
    public string? OwnerUserProfileName { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications in a space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    [JsonPropertyName("idleTimeoutInMinutes")]
    public long? IdleTimeoutInMinutes { get; set; }
}

/// <summary>
/// Settings that are used to configure and manage the lifecycle of Amazon SageMaker
/// Studio applications in a space.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications in a space.</summary>
    [JsonPropertyName("idleSettings")]
    public V1alpha1SpaceSpecSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
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
public partial class V1alpha1SpaceSpecSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec
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

/// <summary>The application settings for a Code Editor space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsCodeEditorAppSettings
{
    /// <summary>
    /// Settings that are used to configure and manage the lifecycle of Amazon SageMaker
    /// Studio applications in a space.
    /// </summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1alpha1SpaceSpecSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

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
    public V1alpha1SpaceSpecSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>
/// A file system, created by you in Amazon EFS, that you assign to a user profile
/// or space for an Amazon SageMaker AI Domain. Permitted users can access this
/// file system in Amazon SageMaker AI Studio.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsCustomFileSystemsEfsFileSystem
{
    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }
}

/// <summary>A custom file system in Amazon FSx for Lustre.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsCustomFileSystemsFSxLustreFileSystem
{
    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }
}

/// <summary>
/// A custom file system in Amazon S3. This is only supported in Amazon SageMaker
/// Unified Studio.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsCustomFileSystemsS3FileSystem
{
    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// A file system, created by you, that you assign to a user profile or space
/// for an Amazon SageMaker AI Domain. Permitted users can access this file system
/// in Amazon SageMaker AI Studio.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsCustomFileSystems
{
    /// <summary>
    /// A file system, created by you in Amazon EFS, that you assign to a user profile
    /// or space for an Amazon SageMaker AI Domain. Permitted users can access this
    /// file system in Amazon SageMaker AI Studio.
    /// </summary>
    [JsonPropertyName("efsFileSystem")]
    public V1alpha1SpaceSpecSpaceSettingsCustomFileSystemsEfsFileSystem? EfsFileSystem { get; set; }

    /// <summary>A custom file system in Amazon FSx for Lustre.</summary>
    [JsonPropertyName("fSxLustreFileSystem")]
    public V1alpha1SpaceSpecSpaceSettingsCustomFileSystemsFSxLustreFileSystem? FSxLustreFileSystem { get; set; }

    /// <summary>
    /// A custom file system in Amazon S3. This is only supported in Amazon SageMaker
    /// Unified Studio.
    /// </summary>
    [JsonPropertyName("s3FileSystem")]
    public V1alpha1SpaceSpecSpaceSettingsCustomFileSystemsS3FileSystem? S3FileSystem { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications in a space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    [JsonPropertyName("idleTimeoutInMinutes")]
    public long? IdleTimeoutInMinutes { get; set; }
}

/// <summary>
/// Settings that are used to configure and manage the lifecycle of Amazon SageMaker
/// Studio applications in a space.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications in a space.</summary>
    [JsonPropertyName("idleSettings")]
    public V1alpha1SpaceSpecSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

/// <summary>
/// A Git repository that SageMaker AI automatically displays to users for cloning
/// in the JupyterServer application.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsJupyterLabAppSettingsCodeRepositories
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
public partial class V1alpha1SpaceSpecSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
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

/// <summary>The settings for the JupyterLab application within a space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsJupyterLabAppSettings
{
    /// <summary>
    /// Settings that are used to configure and manage the lifecycle of Amazon SageMaker
    /// Studio applications in a space.
    /// </summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1alpha1SpaceSpecSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    [JsonPropertyName("codeRepositories")]
    public IList<V1alpha1SpaceSpecSpaceSettingsJupyterLabAppSettingsCodeRepositories>? CodeRepositories { get; set; }

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
    public V1alpha1SpaceSpecSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>
/// A Git repository that SageMaker AI automatically displays to users for cloning
/// in the JupyterServer application.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsJupyterServerAppSettingsCodeRepositories
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
public partial class V1alpha1SpaceSpecSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
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
public partial class V1alpha1SpaceSpecSpaceSettingsJupyterServerAppSettings
{
    [JsonPropertyName("codeRepositories")]
    public IList<V1alpha1SpaceSpecSpaceSettingsJupyterServerAppSettingsCodeRepositories>? CodeRepositories { get; set; }

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
    public V1alpha1SpaceSpecSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// A custom SageMaker AI image. For more information, see Bring your own SageMaker
/// AI image (https://docs.aws.amazon.com/sagemaker/latest/dg/studio-byoi.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsKernelGatewayAppSettingsCustomImages
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
public partial class V1alpha1SpaceSpecSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
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
public partial class V1alpha1SpaceSpecSpaceSettingsKernelGatewayAppSettings
{
    [JsonPropertyName("customImages")]
    public IList<V1alpha1SpaceSpecSpaceSettingsKernelGatewayAppSettingsCustomImages>? CustomImages { get; set; }

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
    public V1alpha1SpaceSpecSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    [JsonPropertyName("lifecycleConfigARNs")]
    public IList<string>? LifecycleConfigARNs { get; set; }
}

/// <summary>
/// A collection of EBS storage settings that apply to both private and shared
/// spaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsSpaceStorageSettingsEbsStorageSettings
{
    [JsonPropertyName("ebsVolumeSizeInGb")]
    public long? EbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings for a space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettingsSpaceStorageSettings
{
    /// <summary>
    /// A collection of EBS storage settings that apply to both private and shared
    /// spaces.
    /// </summary>
    [JsonPropertyName("ebsStorageSettings")]
    public V1alpha1SpaceSpecSpaceSettingsSpaceStorageSettingsEbsStorageSettings? EbsStorageSettings { get; set; }
}

/// <summary>A collection of space settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSettings
{
    [JsonPropertyName("appType")]
    public string? AppType { get; set; }

    /// <summary>The application settings for a Code Editor space.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1alpha1SpaceSpecSpaceSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    [JsonPropertyName("customFileSystems")]
    public IList<V1alpha1SpaceSpecSpaceSettingsCustomFileSystems>? CustomFileSystems { get; set; }

    /// <summary>The settings for the JupyterLab application within a space.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1alpha1SpaceSpecSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The JupyterServer app settings.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1alpha1SpaceSpecSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The KernelGateway app settings.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1alpha1SpaceSpecSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    [JsonPropertyName("remoteAccess")]
    public string? RemoteAccess { get; set; }

    [JsonPropertyName("spaceManagedResources")]
    public string? SpaceManagedResources { get; set; }

    /// <summary>The storage settings for a space.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1alpha1SpaceSpecSpaceSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }
}

/// <summary>A collection of space sharing settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpecSpaceSharingSettings
{
    [JsonPropertyName("sharingType")]
    public string? SharingType { get; set; }
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
public partial class V1alpha1SpaceSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>SpaceSpec defines the desired state of Space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceSpec
{
    /// <summary>
    /// The ID of the associated domain.
    /// 
    /// Regex Pattern: `^d-(-*[a-z0-9]){1,61}$`
    /// </summary>
    [JsonPropertyName("domainID")]
    public required string DomainID { get; set; }

    /// <summary>A collection of ownership settings.</summary>
    [JsonPropertyName("ownershipSettings")]
    public V1alpha1SpaceSpecOwnershipSettings? OwnershipSettings { get; set; }

    /// <summary>
    /// The name of the space that appears in the SageMaker Studio UI.
    /// 
    /// Regex Pattern: `^(?!\s*$).+$`
    /// </summary>
    [JsonPropertyName("spaceDisplayName")]
    public string? SpaceDisplayName { get; set; }

    /// <summary>
    /// The name of the space.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("spaceName")]
    public required string SpaceName { get; set; }

    /// <summary>A collection of space settings.</summary>
    [JsonPropertyName("spaceSettings")]
    public V1alpha1SpaceSpecSpaceSettings? SpaceSettings { get; set; }

    /// <summary>A collection of space sharing settings.</summary>
    [JsonPropertyName("spaceSharingSettings")]
    public V1alpha1SpaceSpecSpaceSharingSettings? SpaceSharingSettings { get; set; }

    /// <summary>
    /// Tags to associated with the space. Each tag consists of a key and an optional
    /// value. Tag keys must be unique for each resource. Tags are searchable using
    /// the Search API.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1SpaceSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceStatusAckResourceMetadata
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
public partial class V1alpha1SpaceStatusConditions
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

/// <summary>SpaceStatus defines the observed state of Space</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpaceStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1SpaceStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SpaceStatusConditions>? Conditions { get; set; }

    /// <summary>The creation time.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>The failure reason.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>
    /// The ID of the space&apos;s profile in the Amazon EFS volume.
    /// 
    /// Regex Pattern: `^\d+$`
    /// </summary>
    [JsonPropertyName("homeEFSFileSystemUID")]
    public string? HomeEFSFileSystemUID { get; set; }

    /// <summary>The status.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Returns the URL of the space. If the space is created with Amazon Web Services
    /// IAM Identity Center (Successor to Amazon Web Services Single Sign-On) authentication,
    /// users can navigate to the URL after appending the respective redirect parameter
    /// for the application type to be federated through Amazon Web Services IAM
    /// Identity Center.
    /// 
    /// The following application types are supported:
    /// 
    ///    * Studio Classic: &amp;redirect=JupyterServer
    /// 
    ///    * JupyterLab: &amp;redirect=JupyterLab
    /// 
    ///    * Code Editor, based on Code-OSS, Visual Studio Code - Open Source: &amp;redirect=CodeEditor
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Space is the Schema for the Spaces API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Space : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SpaceSpec?>, IStatus<V1alpha1SpaceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Space";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "spaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Space";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpaceSpec defines the desired state of Space.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1SpaceSpec? Spec { get; set; }

    /// <summary>SpaceStatus defines the observed state of Space</summary>
    [JsonPropertyName("status")]
    public V1alpha1SpaceStatus? Status { get; set; }
}