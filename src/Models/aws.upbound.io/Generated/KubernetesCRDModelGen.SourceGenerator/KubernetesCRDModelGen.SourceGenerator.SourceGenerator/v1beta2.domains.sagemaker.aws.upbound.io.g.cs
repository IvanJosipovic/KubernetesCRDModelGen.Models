#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.upbound.io;
/// <summary>Domain is the Schema for the Domains API. Provides a SageMaker AI Domain resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DomainList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Domain>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DomainList";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Domain objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Domain> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecDeletionPolicyEnum>))]
public enum V1beta2DomainSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker AI Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsCustomFileSystemConfigEfsFileSystemConfig? EfsFileSystemConfig { get; set; }
}

/// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettingsEmrSettings
{
    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles that the execution role of SageMaker AI can assume for performing operations or tasks related to Amazon EMR clusters or Amazon EMR Serverless applications. These roles define the permissions and access policies required when performing Amazon EMR-related operations, such as listing, connecting to, or terminating Amazon EMR clusters or Amazon EMR Serverless applications. They are typically used in cross-account access scenarios, where the Amazon EMR resources (clusters or serverless applications) are located in a different AWS account than the SageMaker AI domain.</summary>
    [JsonPropertyName("assumableRoleArns")]
    public IList<string>? AssumableRoleArns { get; set; }

    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles used by the Amazon EMR cluster instances or job execution environments to access other AWS services and resources needed during the runtime of your Amazon EMR or Amazon EMR Serverless workloads, such as Amazon S3 for data access, Amazon CloudWatch for logging, or other AWS services based on the particular workload requirements.</summary>
    [JsonPropertyName("executionRoleArns")]
    public IList<string>? ExecutionRoleArns { get; set; }
}

/// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
    [JsonPropertyName("emrSettings")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettingsEmrSettings? EmrSettings { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainSpecForProviderDefaultSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettings { get; set; }
}

/// <summary>The default space settings. See default_space_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultSpaceSettings
{
    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker AI Studio. See custom_file_system_config Block below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta2DomainSpecForProviderDefaultSpaceSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsCustomPosixUserConfig? CustomPosixUserConfig { get; set; }

    /// <summary>The execution role for the space.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The security groups for the Amazon Virtual Private Cloud that the space uses for communication.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }
}

/// <summary>The model deployment settings for the SageMaker AI Canvas application. See direct_deploy_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsDirectDeploySettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The settings for running Amazon EMR Serverless jobs in SageMaker AI Canvas. See emr_serverless_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS IAM role that is assumed for running Amazon EMR Serverless jobs in SageMaker AI Canvas. This role should have the necessary permissions to read and write data attached and a trust relationship with EMR Serverless.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this Domain.</summary>
    [JsonPropertyName("amazonBedrockRoleArn")]
    public string? AmazonBedrockRoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings
{
    /// <summary>The name of the data source that you&apos;re connecting to. Canvas currently supports OAuth for Snowflake and Salesforce Data Cloud. Valid values are SalesforceGenie and Snowflake.</summary>
    [JsonPropertyName("dataSourceName")]
    public string? DataSourceName { get; set; }

    /// <summary>The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials from your identity provider, such as the client ID and secret, authorization URL, and token URL.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The settings for document querying. See kendra_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsKendraSettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The model registry settings for the SageMaker AI Canvas application. See model_register_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsModelRegisterSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI model registry account. Required only to register model versions created by a different SageMaker AI Canvas AWS account than the AWS account in which SageMaker AI model registry is set up.</summary>
    [JsonPropertyName("crossAccountModelRegisterRoleArn")]
    public string? CrossAccountModelRegisterRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Time series forecast settings for the Canvas app. See time_series_forecasting_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings
{
    /// <summary>The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By default, Canvas uses the execution role specified in the UserProfile that launches the Canvas app. If an execution role is not specified in the UserProfile, Canvas uses the execution role specified in the Domain that owns the UserProfile. To allow time series forecasting, this IAM role should have the AmazonSageMakerCanvasForecastAccess policy attached and forecast.amazonaws.com added in the trust relationship as a service principal.</summary>
    [JsonPropertyName("amazonForecastRoleArn")]
    public string? AmazonForecastRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The workspace settings for the SageMaker AI Canvas application. See workspace_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsWorkspaceSettings
{
    /// <summary>The Amazon S3 bucket used to store artifacts generated by Canvas. Updating the Amazon S3 location impacts existing configuration settings, and Canvas users no longer have access to their artifacts. Canvas users must log out and log back in to apply the new location.</summary>
    [JsonPropertyName("s3ArtifactPath")]
    public string? S3ArtifactPath { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }
}

/// <summary>The Canvas app settings. See canvas_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettings
{
    /// <summary>The model deployment settings for the SageMaker AI Canvas application. See direct_deploy_settings Block below.</summary>
    [JsonPropertyName("directDeploySettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsDirectDeploySettings? DirectDeploySettings { get; set; }

    /// <summary>The settings for running Amazon EMR Serverless jobs in SageMaker AI Canvas. See emr_serverless_settings Block below.</summary>
    [JsonPropertyName("emrServerlessSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings? EmrServerlessSettings { get; set; }

    [JsonPropertyName("generativeAiSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings { get; set; }

    /// <summary>The settings for connecting to an external data source with OAuth. See identity_provider_oauth_settings Block below.</summary>
    [JsonPropertyName("identityProviderOauthSettings")]
    public IList<V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings>? IdentityProviderOauthSettings { get; set; }

    /// <summary>The settings for document querying. See kendra_settings Block below.</summary>
    [JsonPropertyName("kendraSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsKendraSettings? KendraSettings { get; set; }

    /// <summary>The model registry settings for the SageMaker AI Canvas application. See model_register_settings Block below.</summary>
    [JsonPropertyName("modelRegisterSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsModelRegisterSettings? ModelRegisterSettings { get; set; }

    /// <summary>Time series forecast settings for the Canvas app. See time_series_forecasting_settings Block below.</summary>
    [JsonPropertyName("timeSeriesForecastingSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings? TimeSeriesForecastingSettings { get; set; }

    /// <summary>The workspace settings for the SageMaker AI Canvas application. See workspace_settings Block below.</summary>
    [JsonPropertyName("workspaceSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettingsWorkspaceSettings? WorkspaceSettings { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker AI Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig? EfsFileSystemConfig { get; set; }
}

/// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleSelector
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
    public V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsEmrSettings
{
    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles that the execution role of SageMaker AI can assume for performing operations or tasks related to Amazon EMR clusters or Amazon EMR Serverless applications. These roles define the permissions and access policies required when performing Amazon EMR-related operations, such as listing, connecting to, or terminating Amazon EMR clusters or Amazon EMR Serverless applications. They are typically used in cross-account access scenarios, where the Amazon EMR resources (clusters or serverless applications) are located in a different AWS account than the SageMaker AI domain.</summary>
    [JsonPropertyName("assumableRoleArns")]
    public IList<string>? AssumableRoleArns { get; set; }

    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles used by the Amazon EMR cluster instances or job execution environments to access other AWS services and resources needed during the runtime of your Amazon EMR or Amazon EMR Serverless workloads, such as Amazon S3 for data access, Amazon CloudWatch for logging, or other AWS services based on the particular workload requirements.</summary>
    [JsonPropertyName("executionRoleArns")]
    public IList<string>? ExecutionRoleArns { get; set; }
}

/// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
    [JsonPropertyName("emrSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettingsEmrSettings? EmrSettings { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2DomainSpecForProviderDefaultUserSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelector
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
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ImageVersion in sagemaker to populate imageName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ImageVersion in sagemaker to populate imageName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelector
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
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>Reference to a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
    [JsonPropertyName("appImageConfigNameRef")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRef? AppImageConfigNameRef { get; set; }

    /// <summary>Selector for a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
    [JsonPropertyName("appImageConfigNameSelector")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelector? AppImageConfigNameSelector { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>Reference to a ImageVersion in sagemaker to populate imageName.</summary>
    [JsonPropertyName("imageNameRef")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRef? ImageNameRef { get; set; }

    /// <summary>Selector for a ImageVersion in sagemaker to populate imageName.</summary>
    [JsonPropertyName("imageNameSelector")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelector? ImageNameSelector { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsRSessionAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsRSessionAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The RSession app settings. See r_session_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsRSessionAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainSpecForProviderDefaultUserSettingsRSessionAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsRSessionAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See r_studio_server_pro_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsRStudioServerProAppSettings
{
    /// <summary>Indicates whether the current user has access to the RStudioServerPro app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    /// <summary>The level of permissions that the user has within the RStudioServerPro app. This value defaults to R_STUDIO_USER. The R_STUDIO_ADMIN value allows the user access to the RStudio Administrative Dashboard. Valid values are R_STUDIO_USER and R_STUDIO_ADMIN.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary>The sharing settings. See sharing_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsSharingSettings
{
    /// <summary>Whether to include the notebook cell output when sharing the notebook. The default is Disabled. Valid values are Allowed and Disabled.</summary>
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }

    /// <summary>When notebook_output_option is Allowed, the Amazon S3 bucket used to save the notebook cell output.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettings { get; set; }
}

/// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsStudioWebPortalSettings
{
    /// <summary>The Applications supported in Studio that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenAppTypes")]
    public IList<string>? HiddenAppTypes { get; set; }

    /// <summary>The instance types you are hiding from the Studio user interface.</summary>
    [JsonPropertyName("hiddenInstanceTypes")]
    public IList<string>? HiddenInstanceTypes { get; set; }

    /// <summary>The machine learning tools that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenMlTools")]
    public IList<string>? HiddenMlTools { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The TensorBoard app settings. See tensor_board_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettingsTensorBoardAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>The default user settings. See default_user_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDefaultUserSettings
{
    /// <summary>Indicates whether auto-mounting of an EFS volume is supported for the user profile. The DefaultAsDomain value is only supported for user profiles. Do not use the DefaultAsDomain value when setting this parameter for a domain. Valid values are: Enabled, Disabled, and DefaultAsDomain.</summary>
    [JsonPropertyName("autoMountHomeEfs")]
    public string? AutoMountHomeEfs { get; set; }

    /// <summary>The Canvas app settings. See canvas_app_settings Block below.</summary>
    [JsonPropertyName("canvasAppSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCanvasAppSettings? CanvasAppSettings { get; set; }

    /// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker AI Studio. See custom_file_system_config Block below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta2DomainSpecForProviderDefaultUserSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsCustomPosixUserConfig? CustomPosixUserConfig { get; set; }

    /// <summary>The default experience that the user is directed to when accessing the domain. The supported values are: studio::: Indicates that Studio is the default experience. This value can only be passed if StudioWebPortal is set to ENABLED. app:JupyterServer:: Indicates that Studio Classic is the default experience.</summary>
    [JsonPropertyName("defaultLandingUri")]
    public string? DefaultLandingUri { get; set; }

    /// <summary>The execution role ARN for the user.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRole.</summary>
    [JsonPropertyName("executionRoleRef")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleRef? ExecutionRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRole.</summary>
    [JsonPropertyName("executionRoleSelector")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsExecutionRoleSelector? ExecutionRoleSelector { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The RSession app settings. See r_session_app_settings Block below.</summary>
    [JsonPropertyName("rSessionAppSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsRSessionAppSettings? RSessionAppSettings { get; set; }

    /// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See r_studio_server_pro_app_settings Block below.</summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsRStudioServerProAppSettings? RStudioServerProAppSettings { get; set; }

    /// <summary>A list of security group IDs that will be attached to the user.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The sharing settings. See sharing_settings Block below.</summary>
    [JsonPropertyName("sharingSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsSharingSettings? SharingSettings { get; set; }

    /// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }

    /// <summary>Whether the user can access Studio. If this value is set to DISABLED, the user cannot access Studio, even if that is the default experience for the domain. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
    [JsonPropertyName("studioWebPortalSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsStudioWebPortalSettings? StudioWebPortalSettings { get; set; }

    /// <summary>The TensorBoard app settings. See tensor_board_app_settings Block below.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettingsTensorBoardAppSettings? TensorBoardAppSettings { get; set; }
}

/// <summary>A collection of settings that configure the domain’s Docker interaction. see docker_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDomainSettingsDockerSettings
{
    /// <summary>Indicates whether the domain can access Docker. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("enableDockerAccess")]
    public string? EnableDockerAccess { get; set; }

    /// <summary>The list of Amazon Web Services accounts that are trusted when the domain is created in VPC-only mode.</summary>
    [JsonPropertyName("vpcOnlyTrustedAccounts")]
    public IList<string>? VpcOnlyTrustedAccounts { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>A collection of settings that configure the RStudioServerPro Domain-level app. see r_studio_server_pro_domain_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDomainSettingsRStudioServerProDomainSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecForProviderDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The ARN of the execution role for the RStudioServerPro Domain-level app.</summary>
    [JsonPropertyName("domainExecutionRoleArn")]
    public string? DomainExecutionRoleArn { get; set; }

    /// <summary>A URL pointing to an RStudio Connect server.</summary>
    [JsonPropertyName("rStudioConnectUrl")]
    public string? RStudioConnectUrl { get; set; }

    /// <summary>A URL pointing to an RStudio Package Manager server.</summary>
    [JsonPropertyName("rStudioPackageManagerUrl")]
    public string? RStudioPackageManagerUrl { get; set; }
}

/// <summary>Configuration for trusted identity propagation. See the trusted_identity_propagation_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDomainSettingsTrustedIdentityPropagationSettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The domain settings. See domain_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDomainSettings
{
    /// <summary>A collection of settings that configure the domain’s Docker interaction. see docker_settings Block below.</summary>
    [JsonPropertyName("dockerSettings")]
    public V1beta2DomainSpecForProviderDomainSettingsDockerSettings? DockerSettings { get; set; }

    /// <summary>The configuration for attaching a SageMaker AI user profile name to the execution role as a sts:SourceIdentity key AWS Docs. Valid values are USER_PROFILE_NAME and DISABLED.</summary>
    [JsonPropertyName("executionRoleIdentityConfig")]
    public string? ExecutionRoleIdentityConfig { get; set; }

    /// <summary>A collection of settings that configure the RStudioServerPro Domain-level app. see r_studio_server_pro_domain_settings Block below.</summary>
    [JsonPropertyName("rStudioServerProDomainSettings")]
    public V1beta2DomainSpecForProviderDomainSettingsRStudioServerProDomainSettings? RStudioServerProDomainSettings { get; set; }

    /// <summary>The security groups for the Amazon Virtual Private Cloud that the Domain uses for communication between Domain-level apps and user apps.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Configuration for trusted identity propagation. See the trusted_identity_propagation_settings Block below.</summary>
    [JsonPropertyName("trustedIdentityPropagationSettings")]
    public V1beta2DomainSpecForProviderDomainSettingsTrustedIdentityPropagationSettings? TrustedIdentityPropagationSettings { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderKmsKeyIdSelector
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
    public V1beta2DomainSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The retention policy for this domain, which specifies whether resources will be retained after the Domain is deleted. By default, all resources are retained. See retention_policy Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderRetentionPolicy
{
    /// <summary>The retention policy for data stored on an Amazon Elastic File System (EFS) volume. Valid values are Retain or Delete.  Default value is Retain.</summary>
    [JsonPropertyName("homeEfsFileSystem")]
    public string? HomeEfsFileSystem { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderSubnetIdRefsPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderSubnetIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderSubnetIdRefsPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderSubnetIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecForProviderSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderSubnetIdSelector
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
    public V1beta2DomainSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcIdRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderVpcIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcIdRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderVpcIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderVpcIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderVpcIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecForProviderVpcIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderVpcIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcIdSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderVpcIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderVpcIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderVpcIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcIdSelector
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
    public V1beta2DomainSpecForProviderVpcIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProvider
{
    /// <summary>Specifies the VPC used for non-EFS traffic. The default value is PublicInternetOnly. Valid values are PublicInternetOnly and VpcOnly.</summary>
    [JsonPropertyName("appNetworkAccessType")]
    public string? AppNetworkAccessType { get; set; }

    /// <summary>The entity that creates and manages the required security groups for inter-app communication in VPCOnly mode. Valid values are Service and Customer.</summary>
    [JsonPropertyName("appSecurityGroupManagement")]
    public string? AppSecurityGroupManagement { get; set; }

    /// <summary>The mode of authentication that members use to access the domain. Valid values are IAM and SSO.</summary>
    [JsonPropertyName("authMode")]
    public string? AuthMode { get; set; }

    /// <summary>The default space settings. See default_space_settings Block below.</summary>
    [JsonPropertyName("defaultSpaceSettings")]
    public V1beta2DomainSpecForProviderDefaultSpaceSettings? DefaultSpaceSettings { get; set; }

    /// <summary>The default user settings. See default_user_settings Block below.</summary>
    [JsonPropertyName("defaultUserSettings")]
    public V1beta2DomainSpecForProviderDefaultUserSettings? DefaultUserSettings { get; set; }

    /// <summary>The domain name.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The domain settings. See domain_settings Block below.</summary>
    [JsonPropertyName("domainSettings")]
    public V1beta2DomainSpecForProviderDomainSettings? DomainSettings { get; set; }

    /// <summary>The AWS KMS customer managed CMK used to encrypt the EFS volume attached to the domain.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2DomainSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2DomainSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The retention policy for this domain, which specifies whether resources will be retained after the Domain is deleted. By default, all resources are retained. See retention_policy Block below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta2DomainSpecForProviderRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta2DomainSpecForProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2DomainSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The VPC subnets that Studio uses for communication.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Indicates whether custom tag propagation is supported for the domain. Defaults to DISABLED. Valid values are: ENABLED and DISABLED.</summary>
    [JsonPropertyName("tagPropagation")]
    public string? TagPropagation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Amazon Virtual Private Cloud (VPC) that Studio uses for communication.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta2DomainSpecForProviderVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta2DomainSpecForProviderVpcIdSelector? VpcIdSelector { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker AI Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsCustomFileSystemConfigEfsFileSystemConfig? EfsFileSystemConfig { get; set; }
}

/// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettingsEmrSettings
{
    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles that the execution role of SageMaker AI can assume for performing operations or tasks related to Amazon EMR clusters or Amazon EMR Serverless applications. These roles define the permissions and access policies required when performing Amazon EMR-related operations, such as listing, connecting to, or terminating Amazon EMR clusters or Amazon EMR Serverless applications. They are typically used in cross-account access scenarios, where the Amazon EMR resources (clusters or serverless applications) are located in a different AWS account than the SageMaker AI domain.</summary>
    [JsonPropertyName("assumableRoleArns")]
    public IList<string>? AssumableRoleArns { get; set; }

    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles used by the Amazon EMR cluster instances or job execution environments to access other AWS services and resources needed during the runtime of your Amazon EMR or Amazon EMR Serverless workloads, such as Amazon S3 for data access, Amazon CloudWatch for logging, or other AWS services based on the particular workload requirements.</summary>
    [JsonPropertyName("executionRoleArns")]
    public IList<string>? ExecutionRoleArns { get; set; }
}

/// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
    [JsonPropertyName("emrSettings")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettingsEmrSettings? EmrSettings { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainSpecInitProviderDefaultSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettings { get; set; }
}

/// <summary>The default space settings. See default_space_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultSpaceSettings
{
    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker AI Studio. See custom_file_system_config Block below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta2DomainSpecInitProviderDefaultSpaceSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsCustomPosixUserConfig? CustomPosixUserConfig { get; set; }

    /// <summary>The execution role for the space.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The security groups for the Amazon Virtual Private Cloud that the space uses for communication.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }
}

/// <summary>The model deployment settings for the SageMaker AI Canvas application. See direct_deploy_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsDirectDeploySettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The settings for running Amazon EMR Serverless jobs in SageMaker AI Canvas. See emr_serverless_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS IAM role that is assumed for running Amazon EMR Serverless jobs in SageMaker AI Canvas. This role should have the necessary permissions to read and write data attached and a trust relationship with EMR Serverless.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this Domain.</summary>
    [JsonPropertyName("amazonBedrockRoleArn")]
    public string? AmazonBedrockRoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings
{
    /// <summary>The name of the data source that you&apos;re connecting to. Canvas currently supports OAuth for Snowflake and Salesforce Data Cloud. Valid values are SalesforceGenie and Snowflake.</summary>
    [JsonPropertyName("dataSourceName")]
    public string? DataSourceName { get; set; }

    /// <summary>The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials from your identity provider, such as the client ID and secret, authorization URL, and token URL.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The settings for document querying. See kendra_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsKendraSettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The model registry settings for the SageMaker AI Canvas application. See model_register_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsModelRegisterSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI model registry account. Required only to register model versions created by a different SageMaker AI Canvas AWS account than the AWS account in which SageMaker AI model registry is set up.</summary>
    [JsonPropertyName("crossAccountModelRegisterRoleArn")]
    public string? CrossAccountModelRegisterRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Time series forecast settings for the Canvas app. See time_series_forecasting_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings
{
    /// <summary>The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By default, Canvas uses the execution role specified in the UserProfile that launches the Canvas app. If an execution role is not specified in the UserProfile, Canvas uses the execution role specified in the Domain that owns the UserProfile. To allow time series forecasting, this IAM role should have the AmazonSageMakerCanvasForecastAccess policy attached and forecast.amazonaws.com added in the trust relationship as a service principal.</summary>
    [JsonPropertyName("amazonForecastRoleArn")]
    public string? AmazonForecastRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The workspace settings for the SageMaker AI Canvas application. See workspace_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsWorkspaceSettings
{
    /// <summary>The Amazon S3 bucket used to store artifacts generated by Canvas. Updating the Amazon S3 location impacts existing configuration settings, and Canvas users no longer have access to their artifacts. Canvas users must log out and log back in to apply the new location.</summary>
    [JsonPropertyName("s3ArtifactPath")]
    public string? S3ArtifactPath { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }
}

/// <summary>The Canvas app settings. See canvas_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettings
{
    /// <summary>The model deployment settings for the SageMaker AI Canvas application. See direct_deploy_settings Block below.</summary>
    [JsonPropertyName("directDeploySettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsDirectDeploySettings? DirectDeploySettings { get; set; }

    /// <summary>The settings for running Amazon EMR Serverless jobs in SageMaker AI Canvas. See emr_serverless_settings Block below.</summary>
    [JsonPropertyName("emrServerlessSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings? EmrServerlessSettings { get; set; }

    [JsonPropertyName("generativeAiSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings { get; set; }

    /// <summary>The settings for connecting to an external data source with OAuth. See identity_provider_oauth_settings Block below.</summary>
    [JsonPropertyName("identityProviderOauthSettings")]
    public IList<V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings>? IdentityProviderOauthSettings { get; set; }

    /// <summary>The settings for document querying. See kendra_settings Block below.</summary>
    [JsonPropertyName("kendraSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsKendraSettings? KendraSettings { get; set; }

    /// <summary>The model registry settings for the SageMaker AI Canvas application. See model_register_settings Block below.</summary>
    [JsonPropertyName("modelRegisterSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsModelRegisterSettings? ModelRegisterSettings { get; set; }

    /// <summary>Time series forecast settings for the Canvas app. See time_series_forecasting_settings Block below.</summary>
    [JsonPropertyName("timeSeriesForecastingSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings? TimeSeriesForecastingSettings { get; set; }

    /// <summary>The workspace settings for the SageMaker AI Canvas application. See workspace_settings Block below.</summary>
    [JsonPropertyName("workspaceSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettingsWorkspaceSettings? WorkspaceSettings { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker AI Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig? EfsFileSystemConfig { get; set; }
}

/// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelector
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
    public V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsEmrSettings
{
    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles that the execution role of SageMaker AI can assume for performing operations or tasks related to Amazon EMR clusters or Amazon EMR Serverless applications. These roles define the permissions and access policies required when performing Amazon EMR-related operations, such as listing, connecting to, or terminating Amazon EMR clusters or Amazon EMR Serverless applications. They are typically used in cross-account access scenarios, where the Amazon EMR resources (clusters or serverless applications) are located in a different AWS account than the SageMaker AI domain.</summary>
    [JsonPropertyName("assumableRoleArns")]
    public IList<string>? AssumableRoleArns { get; set; }

    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles used by the Amazon EMR cluster instances or job execution environments to access other AWS services and resources needed during the runtime of your Amazon EMR or Amazon EMR Serverless workloads, such as Amazon S3 for data access, Amazon CloudWatch for logging, or other AWS services based on the particular workload requirements.</summary>
    [JsonPropertyName("executionRoleArns")]
    public IList<string>? ExecutionRoleArns { get; set; }
}

/// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
    [JsonPropertyName("emrSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettingsEmrSettings? EmrSettings { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelector
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
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ImageVersion in sagemaker to populate imageName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ImageVersion in sagemaker to populate imageName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelector
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
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>Reference to a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
    [JsonPropertyName("appImageConfigNameRef")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameRef? AppImageConfigNameRef { get; set; }

    /// <summary>Selector for a AppImageConfig in sagemaker to populate appImageConfigName.</summary>
    [JsonPropertyName("appImageConfigNameSelector")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageAppImageConfigNameSelector? AppImageConfigNameSelector { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>Reference to a ImageVersion in sagemaker to populate imageName.</summary>
    [JsonPropertyName("imageNameRef")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameRef? ImageNameRef { get; set; }

    /// <summary>Selector for a ImageVersion in sagemaker to populate imageName.</summary>
    [JsonPropertyName("imageNameSelector")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImageImageNameSelector? ImageNameSelector { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsRSessionAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsRSessionAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The RSession app settings. See r_session_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsRSessionAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainSpecInitProviderDefaultUserSettingsRSessionAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsRSessionAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See r_studio_server_pro_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsRStudioServerProAppSettings
{
    /// <summary>Indicates whether the current user has access to the RStudioServerPro app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    /// <summary>The level of permissions that the user has within the RStudioServerPro app. This value defaults to R_STUDIO_USER. The R_STUDIO_ADMIN value allows the user access to the RStudio Administrative Dashboard. Valid values are R_STUDIO_USER and R_STUDIO_ADMIN.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary>The sharing settings. See sharing_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsSharingSettings
{
    /// <summary>Whether to include the notebook cell output when sharing the notebook. The default is Disabled. Valid values are Allowed and Disabled.</summary>
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }

    /// <summary>When notebook_output_option is Allowed, the Amazon S3 bucket used to save the notebook cell output.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettings { get; set; }
}

/// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsStudioWebPortalSettings
{
    /// <summary>The Applications supported in Studio that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenAppTypes")]
    public IList<string>? HiddenAppTypes { get; set; }

    /// <summary>The instance types you are hiding from the Studio user interface.</summary>
    [JsonPropertyName("hiddenInstanceTypes")]
    public IList<string>? HiddenInstanceTypes { get; set; }

    /// <summary>The machine learning tools that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenMlTools")]
    public IList<string>? HiddenMlTools { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The TensorBoard app settings. See tensor_board_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettingsTensorBoardAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>The default user settings. See default_user_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDefaultUserSettings
{
    /// <summary>Indicates whether auto-mounting of an EFS volume is supported for the user profile. The DefaultAsDomain value is only supported for user profiles. Do not use the DefaultAsDomain value when setting this parameter for a domain. Valid values are: Enabled, Disabled, and DefaultAsDomain.</summary>
    [JsonPropertyName("autoMountHomeEfs")]
    public string? AutoMountHomeEfs { get; set; }

    /// <summary>The Canvas app settings. See canvas_app_settings Block below.</summary>
    [JsonPropertyName("canvasAppSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCanvasAppSettings? CanvasAppSettings { get; set; }

    /// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker AI Studio. See custom_file_system_config Block below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta2DomainSpecInitProviderDefaultUserSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsCustomPosixUserConfig? CustomPosixUserConfig { get; set; }

    /// <summary>The default experience that the user is directed to when accessing the domain. The supported values are: studio::: Indicates that Studio is the default experience. This value can only be passed if StudioWebPortal is set to ENABLED. app:JupyterServer:: Indicates that Studio Classic is the default experience.</summary>
    [JsonPropertyName("defaultLandingUri")]
    public string? DefaultLandingUri { get; set; }

    /// <summary>The execution role ARN for the user.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRole.</summary>
    [JsonPropertyName("executionRoleRef")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleRef? ExecutionRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRole.</summary>
    [JsonPropertyName("executionRoleSelector")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsExecutionRoleSelector? ExecutionRoleSelector { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The RSession app settings. See r_session_app_settings Block below.</summary>
    [JsonPropertyName("rSessionAppSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsRSessionAppSettings? RSessionAppSettings { get; set; }

    /// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See r_studio_server_pro_app_settings Block below.</summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsRStudioServerProAppSettings? RStudioServerProAppSettings { get; set; }

    /// <summary>A list of security group IDs that will be attached to the user.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The sharing settings. See sharing_settings Block below.</summary>
    [JsonPropertyName("sharingSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsSharingSettings? SharingSettings { get; set; }

    /// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }

    /// <summary>Whether the user can access Studio. If this value is set to DISABLED, the user cannot access Studio, even if that is the default experience for the domain. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
    [JsonPropertyName("studioWebPortalSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsStudioWebPortalSettings? StudioWebPortalSettings { get; set; }

    /// <summary>The TensorBoard app settings. See tensor_board_app_settings Block below.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettingsTensorBoardAppSettings? TensorBoardAppSettings { get; set; }
}

/// <summary>A collection of settings that configure the domain’s Docker interaction. see docker_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDomainSettingsDockerSettings
{
    /// <summary>Indicates whether the domain can access Docker. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("enableDockerAccess")]
    public string? EnableDockerAccess { get; set; }

    /// <summary>The list of Amazon Web Services accounts that are trusted when the domain is created in VPC-only mode.</summary>
    [JsonPropertyName("vpcOnlyTrustedAccounts")]
    public IList<string>? VpcOnlyTrustedAccounts { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>A collection of settings that configure the RStudioServerPro Domain-level app. see r_studio_server_pro_domain_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDomainSettingsRStudioServerProDomainSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainSpecInitProviderDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The ARN of the execution role for the RStudioServerPro Domain-level app.</summary>
    [JsonPropertyName("domainExecutionRoleArn")]
    public string? DomainExecutionRoleArn { get; set; }

    /// <summary>A URL pointing to an RStudio Connect server.</summary>
    [JsonPropertyName("rStudioConnectUrl")]
    public string? RStudioConnectUrl { get; set; }

    /// <summary>A URL pointing to an RStudio Package Manager server.</summary>
    [JsonPropertyName("rStudioPackageManagerUrl")]
    public string? RStudioPackageManagerUrl { get; set; }
}

/// <summary>Configuration for trusted identity propagation. See the trusted_identity_propagation_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDomainSettingsTrustedIdentityPropagationSettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The domain settings. See domain_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDomainSettings
{
    /// <summary>A collection of settings that configure the domain’s Docker interaction. see docker_settings Block below.</summary>
    [JsonPropertyName("dockerSettings")]
    public V1beta2DomainSpecInitProviderDomainSettingsDockerSettings? DockerSettings { get; set; }

    /// <summary>The configuration for attaching a SageMaker AI user profile name to the execution role as a sts:SourceIdentity key AWS Docs. Valid values are USER_PROFILE_NAME and DISABLED.</summary>
    [JsonPropertyName("executionRoleIdentityConfig")]
    public string? ExecutionRoleIdentityConfig { get; set; }

    /// <summary>A collection of settings that configure the RStudioServerPro Domain-level app. see r_studio_server_pro_domain_settings Block below.</summary>
    [JsonPropertyName("rStudioServerProDomainSettings")]
    public V1beta2DomainSpecInitProviderDomainSettingsRStudioServerProDomainSettings? RStudioServerProDomainSettings { get; set; }

    /// <summary>The security groups for the Amazon Virtual Private Cloud that the Domain uses for communication between Domain-level apps and user apps.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Configuration for trusted identity propagation. See the trusted_identity_propagation_settings Block below.</summary>
    [JsonPropertyName("trustedIdentityPropagationSettings")]
    public V1beta2DomainSpecInitProviderDomainSettingsTrustedIdentityPropagationSettings? TrustedIdentityPropagationSettings { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderKmsKeyIdSelector
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
    public V1beta2DomainSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The retention policy for this domain, which specifies whether resources will be retained after the Domain is deleted. By default, all resources are retained. See retention_policy Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderRetentionPolicy
{
    /// <summary>The retention policy for data stored on an Amazon Elastic File System (EFS) volume. Valid values are Retain or Delete.  Default value is Retain.</summary>
    [JsonPropertyName("homeEfsFileSystem")]
    public string? HomeEfsFileSystem { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderSubnetIdRefsPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderSubnetIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderSubnetIdRefsPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderSubnetIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecInitProviderSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderSubnetIdSelector
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
    public V1beta2DomainSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcIdRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderVpcIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcIdRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderVpcIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderVpcIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderVpcIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecInitProviderVpcIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderVpcIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcIdSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderVpcIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderVpcIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderVpcIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcIdSelector
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
    public V1beta2DomainSpecInitProviderVpcIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2DomainSpecInitProvider
{
    /// <summary>Specifies the VPC used for non-EFS traffic. The default value is PublicInternetOnly. Valid values are PublicInternetOnly and VpcOnly.</summary>
    [JsonPropertyName("appNetworkAccessType")]
    public string? AppNetworkAccessType { get; set; }

    /// <summary>The entity that creates and manages the required security groups for inter-app communication in VPCOnly mode. Valid values are Service and Customer.</summary>
    [JsonPropertyName("appSecurityGroupManagement")]
    public string? AppSecurityGroupManagement { get; set; }

    /// <summary>The mode of authentication that members use to access the domain. Valid values are IAM and SSO.</summary>
    [JsonPropertyName("authMode")]
    public string? AuthMode { get; set; }

    /// <summary>The default space settings. See default_space_settings Block below.</summary>
    [JsonPropertyName("defaultSpaceSettings")]
    public V1beta2DomainSpecInitProviderDefaultSpaceSettings? DefaultSpaceSettings { get; set; }

    /// <summary>The default user settings. See default_user_settings Block below.</summary>
    [JsonPropertyName("defaultUserSettings")]
    public V1beta2DomainSpecInitProviderDefaultUserSettings? DefaultUserSettings { get; set; }

    /// <summary>The domain name.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The domain settings. See domain_settings Block below.</summary>
    [JsonPropertyName("domainSettings")]
    public V1beta2DomainSpecInitProviderDomainSettings? DomainSettings { get; set; }

    /// <summary>The AWS KMS customer managed CMK used to encrypt the EFS volume attached to the domain.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2DomainSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2DomainSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The retention policy for this domain, which specifies whether resources will be retained after the Domain is deleted. By default, all resources are retained. See retention_policy Block below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta2DomainSpecInitProviderRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta2DomainSpecInitProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2DomainSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The VPC subnets that Studio uses for communication.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Indicates whether custom tag propagation is supported for the domain. Defaults to DISABLED. Valid values are: ENABLED and DISABLED.</summary>
    [JsonPropertyName("tagPropagation")]
    public string? TagPropagation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Amazon Virtual Private Cloud (VPC) that Studio uses for communication.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>Reference to a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdRef")]
    public V1beta2DomainSpecInitProviderVpcIdRef? VpcIdRef { get; set; }

    /// <summary>Selector for a VPC in ec2 to populate vpcId.</summary>
    [JsonPropertyName("vpcIdSelector")]
    public V1beta2DomainSpecInitProviderVpcIdSelector? VpcIdSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecManagementPoliciesEnum>))]
public enum V1beta2DomainSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DomainSpec defines the desired state of Domain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpec
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
    public V1beta2DomainSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DomainSpecForProvider ForProvider { get; set; }

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
    public V1beta2DomainSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DomainSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker AI Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsCustomFileSystemConfigEfsFileSystemConfig? EfsFileSystemConfig { get; set; }
}

/// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettingsEmrSettings
{
    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles that the execution role of SageMaker AI can assume for performing operations or tasks related to Amazon EMR clusters or Amazon EMR Serverless applications. These roles define the permissions and access policies required when performing Amazon EMR-related operations, such as listing, connecting to, or terminating Amazon EMR clusters or Amazon EMR Serverless applications. They are typically used in cross-account access scenarios, where the Amazon EMR resources (clusters or serverless applications) are located in a different AWS account than the SageMaker AI domain.</summary>
    [JsonPropertyName("assumableRoleArns")]
    public IList<string>? AssumableRoleArns { get; set; }

    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles used by the Amazon EMR cluster instances or job execution environments to access other AWS services and resources needed during the runtime of your Amazon EMR or Amazon EMR Serverless workloads, such as Amazon S3 for data access, Amazon CloudWatch for logging, or other AWS services based on the particular workload requirements.</summary>
    [JsonPropertyName("executionRoleArns")]
    public IList<string>? ExecutionRoleArns { get; set; }
}

/// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
    [JsonPropertyName("emrSettings")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettingsEmrSettings? EmrSettings { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainStatusAtProviderDefaultSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettings { get; set; }
}

/// <summary>The default space settings. See default_space_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultSpaceSettings
{
    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker AI Studio. See custom_file_system_config Block below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta2DomainStatusAtProviderDefaultSpaceSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsCustomPosixUserConfig? CustomPosixUserConfig { get; set; }

    /// <summary>The execution role for the space.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The security groups for the Amazon Virtual Private Cloud that the space uses for communication.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }
}

/// <summary>The model deployment settings for the SageMaker AI Canvas application. See direct_deploy_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsDirectDeploySettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The settings for running Amazon EMR Serverless jobs in SageMaker AI Canvas. See emr_serverless_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS IAM role that is assumed for running Amazon EMR Serverless jobs in SageMaker AI Canvas. This role should have the necessary permissions to read and write data attached and a trust relationship with EMR Serverless.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this Domain.</summary>
    [JsonPropertyName("amazonBedrockRoleArn")]
    public string? AmazonBedrockRoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings
{
    /// <summary>The name of the data source that you&apos;re connecting to. Canvas currently supports OAuth for Snowflake and Salesforce Data Cloud. Valid values are SalesforceGenie and Snowflake.</summary>
    [JsonPropertyName("dataSourceName")]
    public string? DataSourceName { get; set; }

    /// <summary>The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials from your identity provider, such as the client ID and secret, authorization URL, and token URL.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The settings for document querying. See kendra_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsKendraSettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The model registry settings for the SageMaker AI Canvas application. See model_register_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsModelRegisterSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI model registry account. Required only to register model versions created by a different SageMaker AI Canvas AWS account than the AWS account in which SageMaker AI model registry is set up.</summary>
    [JsonPropertyName("crossAccountModelRegisterRoleArn")]
    public string? CrossAccountModelRegisterRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Time series forecast settings for the Canvas app. See time_series_forecasting_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings
{
    /// <summary>The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By default, Canvas uses the execution role specified in the UserProfile that launches the Canvas app. If an execution role is not specified in the UserProfile, Canvas uses the execution role specified in the Domain that owns the UserProfile. To allow time series forecasting, this IAM role should have the AmazonSageMakerCanvasForecastAccess policy attached and forecast.amazonaws.com added in the trust relationship as a service principal.</summary>
    [JsonPropertyName("amazonForecastRoleArn")]
    public string? AmazonForecastRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The workspace settings for the SageMaker AI Canvas application. See workspace_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsWorkspaceSettings
{
    /// <summary>The Amazon S3 bucket used to store artifacts generated by Canvas. Updating the Amazon S3 location impacts existing configuration settings, and Canvas users no longer have access to their artifacts. Canvas users must log out and log back in to apply the new location.</summary>
    [JsonPropertyName("s3ArtifactPath")]
    public string? S3ArtifactPath { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }
}

/// <summary>The Canvas app settings. See canvas_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettings
{
    /// <summary>The model deployment settings for the SageMaker AI Canvas application. See direct_deploy_settings Block below.</summary>
    [JsonPropertyName("directDeploySettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsDirectDeploySettings? DirectDeploySettings { get; set; }

    /// <summary>The settings for running Amazon EMR Serverless jobs in SageMaker AI Canvas. See emr_serverless_settings Block below.</summary>
    [JsonPropertyName("emrServerlessSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings? EmrServerlessSettings { get; set; }

    [JsonPropertyName("generativeAiSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings { get; set; }

    /// <summary>The settings for connecting to an external data source with OAuth. See identity_provider_oauth_settings Block below.</summary>
    [JsonPropertyName("identityProviderOauthSettings")]
    public IList<V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings>? IdentityProviderOauthSettings { get; set; }

    /// <summary>The settings for document querying. See kendra_settings Block below.</summary>
    [JsonPropertyName("kendraSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsKendraSettings? KendraSettings { get; set; }

    /// <summary>The model registry settings for the SageMaker AI Canvas application. See model_register_settings Block below.</summary>
    [JsonPropertyName("modelRegisterSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsModelRegisterSettings? ModelRegisterSettings { get; set; }

    /// <summary>Time series forecast settings for the Canvas app. See time_series_forecasting_settings Block below.</summary>
    [JsonPropertyName("timeSeriesForecastingSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings? TimeSeriesForecastingSettings { get; set; }

    /// <summary>The workspace settings for the SageMaker AI Canvas application. See workspace_settings Block below.</summary>
    [JsonPropertyName("workspaceSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettingsWorkspaceSettings? WorkspaceSettings { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker AI Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See efs_file_system_config Block below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCustomFileSystemConfigEfsFileSystemConfig? EfsFileSystemConfig { get; set; }
}

/// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsEmrSettings
{
    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles that the execution role of SageMaker AI can assume for performing operations or tasks related to Amazon EMR clusters or Amazon EMR Serverless applications. These roles define the permissions and access policies required when performing Amazon EMR-related operations, such as listing, connecting to, or terminating Amazon EMR clusters or Amazon EMR Serverless applications. They are typically used in cross-account access scenarios, where the Amazon EMR resources (clusters or serverless applications) are located in a different AWS account than the SageMaker AI domain.</summary>
    [JsonPropertyName("assumableRoleArns")]
    public IList<string>? AssumableRoleArns { get; set; }

    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles used by the Amazon EMR cluster instances or job execution environments to access other AWS services and resources needed during the runtime of your Amazon EMR or Amazon EMR Serverless workloads, such as Amazon S3 for data access, Amazon CloudWatch for logging, or other AWS services based on the particular workload requirements.</summary>
    [JsonPropertyName("executionRoleArns")]
    public IList<string>? ExecutionRoleArns { get; set; }
}

/// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
    [JsonPropertyName("emrSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettingsEmrSettings? EmrSettings { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainStatusAtProviderDefaultUserSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsRSessionAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsRSessionAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The RSession app settings. See r_session_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsRSessionAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2DomainStatusAtProviderDefaultUserSettingsRSessionAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsRSessionAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See r_studio_server_pro_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsRStudioServerProAppSettings
{
    /// <summary>Indicates whether the current user has access to the RStudioServerPro app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    /// <summary>The level of permissions that the user has within the RStudioServerPro app. This value defaults to R_STUDIO_USER. The R_STUDIO_ADMIN value allows the user access to the RStudio Administrative Dashboard. Valid values are R_STUDIO_USER and R_STUDIO_ADMIN.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary>The sharing settings. See sharing_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsSharingSettings
{
    /// <summary>Whether to include the notebook cell output when sharing the notebook. The default is Disabled. Valid values are Allowed and Disabled.</summary>
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }

    /// <summary>When notebook_output_option is Allowed, the Amazon S3 bucket used to save the notebook cell output.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See default_ebs_storage_settings Block below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettings { get; set; }
}

/// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsStudioWebPortalSettings
{
    /// <summary>The Applications supported in Studio that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenAppTypes")]
    public IList<string>? HiddenAppTypes { get; set; }

    /// <summary>The instance types you are hiding from the Studio user interface.</summary>
    [JsonPropertyName("hiddenInstanceTypes")]
    public IList<string>? HiddenInstanceTypes { get; set; }

    /// <summary>The machine learning tools that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenMlTools")]
    public IList<string>? HiddenMlTools { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The TensorBoard app settings. See tensor_board_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettingsTensorBoardAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>The default user settings. See default_user_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDefaultUserSettings
{
    /// <summary>Indicates whether auto-mounting of an EFS volume is supported for the user profile. The DefaultAsDomain value is only supported for user profiles. Do not use the DefaultAsDomain value when setting this parameter for a domain. Valid values are: Enabled, Disabled, and DefaultAsDomain.</summary>
    [JsonPropertyName("autoMountHomeEfs")]
    public string? AutoMountHomeEfs { get; set; }

    /// <summary>The Canvas app settings. See canvas_app_settings Block below.</summary>
    [JsonPropertyName("canvasAppSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCanvasAppSettings? CanvasAppSettings { get; set; }

    /// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker AI Studio. See custom_file_system_config Block below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta2DomainStatusAtProviderDefaultUserSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See custom_posix_user_config Block below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsCustomPosixUserConfig? CustomPosixUserConfig { get; set; }

    /// <summary>The default experience that the user is directed to when accessing the domain. The supported values are: studio::: Indicates that Studio is the default experience. This value can only be passed if StudioWebPortal is set to ENABLED. app:JupyterServer:: Indicates that Studio Classic is the default experience.</summary>
    [JsonPropertyName("defaultLandingUri")]
    public string? DefaultLandingUri { get; set; }

    /// <summary>The execution role ARN for the user.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The RSession app settings. See r_session_app_settings Block below.</summary>
    [JsonPropertyName("rSessionAppSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsRSessionAppSettings? RSessionAppSettings { get; set; }

    /// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See r_studio_server_pro_app_settings Block below.</summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsRStudioServerProAppSettings? RStudioServerProAppSettings { get; set; }

    /// <summary>A list of security group IDs that will be attached to the user.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The sharing settings. See sharing_settings Block below.</summary>
    [JsonPropertyName("sharingSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsSharingSettings? SharingSettings { get; set; }

    /// <summary>The storage settings for a private space. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }

    /// <summary>Whether the user can access Studio. If this value is set to DISABLED, the user cannot access Studio, even if that is the default experience for the domain. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
    [JsonPropertyName("studioWebPortalSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsStudioWebPortalSettings? StudioWebPortalSettings { get; set; }

    /// <summary>The TensorBoard app settings. See tensor_board_app_settings Block below.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettingsTensorBoardAppSettings? TensorBoardAppSettings { get; set; }
}

/// <summary>A collection of settings that configure the domain’s Docker interaction. see docker_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDomainSettingsDockerSettings
{
    /// <summary>Indicates whether the domain can access Docker. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("enableDockerAccess")]
    public string? EnableDockerAccess { get; set; }

    /// <summary>The list of Amazon Web Services accounts that are trusted when the domain is created in VPC-only mode.</summary>
    [JsonPropertyName("vpcOnlyTrustedAccounts")]
    public IList<string>? VpcOnlyTrustedAccounts { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>A collection of settings that configure the RStudioServerPro Domain-level app. see r_studio_server_pro_domain_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDomainSettingsRStudioServerProDomainSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2DomainStatusAtProviderDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The ARN of the execution role for the RStudioServerPro Domain-level app.</summary>
    [JsonPropertyName("domainExecutionRoleArn")]
    public string? DomainExecutionRoleArn { get; set; }

    /// <summary>A URL pointing to an RStudio Connect server.</summary>
    [JsonPropertyName("rStudioConnectUrl")]
    public string? RStudioConnectUrl { get; set; }

    /// <summary>A URL pointing to an RStudio Package Manager server.</summary>
    [JsonPropertyName("rStudioPackageManagerUrl")]
    public string? RStudioPackageManagerUrl { get; set; }
}

/// <summary>Configuration for trusted identity propagation. See the trusted_identity_propagation_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDomainSettingsTrustedIdentityPropagationSettings
{
    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The domain settings. See domain_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDomainSettings
{
    /// <summary>A collection of settings that configure the domain’s Docker interaction. see docker_settings Block below.</summary>
    [JsonPropertyName("dockerSettings")]
    public V1beta2DomainStatusAtProviderDomainSettingsDockerSettings? DockerSettings { get; set; }

    /// <summary>The configuration for attaching a SageMaker AI user profile name to the execution role as a sts:SourceIdentity key AWS Docs. Valid values are USER_PROFILE_NAME and DISABLED.</summary>
    [JsonPropertyName("executionRoleIdentityConfig")]
    public string? ExecutionRoleIdentityConfig { get; set; }

    /// <summary>A collection of settings that configure the RStudioServerPro Domain-level app. see r_studio_server_pro_domain_settings Block below.</summary>
    [JsonPropertyName("rStudioServerProDomainSettings")]
    public V1beta2DomainStatusAtProviderDomainSettingsRStudioServerProDomainSettings? RStudioServerProDomainSettings { get; set; }

    /// <summary>The security groups for the Amazon Virtual Private Cloud that the Domain uses for communication between Domain-level apps and user apps.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Configuration for trusted identity propagation. See the trusted_identity_propagation_settings Block below.</summary>
    [JsonPropertyName("trustedIdentityPropagationSettings")]
    public V1beta2DomainStatusAtProviderDomainSettingsTrustedIdentityPropagationSettings? TrustedIdentityPropagationSettings { get; set; }
}

/// <summary>The retention policy for this domain, which specifies whether resources will be retained after the Domain is deleted. By default, all resources are retained. See retention_policy Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderRetentionPolicy
{
    /// <summary>The retention policy for data stored on an Amazon Elastic File System (EFS) volume. Valid values are Retain or Delete.  Default value is Retain.</summary>
    [JsonPropertyName("homeEfsFileSystem")]
    public string? HomeEfsFileSystem { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProvider
{
    /// <summary>Specifies the VPC used for non-EFS traffic. The default value is PublicInternetOnly. Valid values are PublicInternetOnly and VpcOnly.</summary>
    [JsonPropertyName("appNetworkAccessType")]
    public string? AppNetworkAccessType { get; set; }

    /// <summary>The entity that creates and manages the required security groups for inter-app communication in VPCOnly mode. Valid values are Service and Customer.</summary>
    [JsonPropertyName("appSecurityGroupManagement")]
    public string? AppSecurityGroupManagement { get; set; }

    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this Domain.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The mode of authentication that members use to access the domain. Valid values are IAM and SSO.</summary>
    [JsonPropertyName("authMode")]
    public string? AuthMode { get; set; }

    /// <summary>The default space settings. See default_space_settings Block below.</summary>
    [JsonPropertyName("defaultSpaceSettings")]
    public V1beta2DomainStatusAtProviderDefaultSpaceSettings? DefaultSpaceSettings { get; set; }

    /// <summary>The default user settings. See default_user_settings Block below.</summary>
    [JsonPropertyName("defaultUserSettings")]
    public V1beta2DomainStatusAtProviderDefaultUserSettings? DefaultUserSettings { get; set; }

    /// <summary>The domain name.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The domain settings. See domain_settings Block below.</summary>
    [JsonPropertyName("domainSettings")]
    public V1beta2DomainStatusAtProviderDomainSettings? DomainSettings { get; set; }

    /// <summary>The ID of the Amazon Elastic File System (EFS) managed by this Domain.</summary>
    [JsonPropertyName("homeEfsFileSystemId")]
    public string? HomeEfsFileSystemId { get; set; }

    /// <summary>The ID of the Domain.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The AWS KMS customer managed CMK used to encrypt the EFS volume attached to the domain.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The retention policy for this domain, which specifies whether resources will be retained after the Domain is deleted. By default, all resources are retained. See retention_policy Block below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta2DomainStatusAtProviderRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>The ID of the security group that authorizes traffic between the RSessionGateway apps and the RStudioServerPro app.</summary>
    [JsonPropertyName("securityGroupIdForDomainBoundary")]
    public string? SecurityGroupIdForDomainBoundary { get; set; }

    /// <summary>The ARN of the application managed by SageMaker AI in IAM Identity Center. This value is only returned for domains created after September 19, 2023.</summary>
    [JsonPropertyName("singleSignOnApplicationArn")]
    public string? SingleSignOnApplicationArn { get; set; }

    /// <summary>The SSO managed application instance ID.</summary>
    [JsonPropertyName("singleSignOnManagedApplicationInstanceId")]
    public string? SingleSignOnManagedApplicationInstanceId { get; set; }

    /// <summary>The VPC subnets that Studio uses for communication.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Indicates whether custom tag propagation is supported for the domain. Defaults to DISABLED. Valid values are: ENABLED and DISABLED.</summary>
    [JsonPropertyName("tagPropagation")]
    public string? TagPropagation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The domain&apos;s URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The ID of the Amazon Virtual Private Cloud (VPC) that Studio uses for communication.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusConditions
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

/// <summary>DomainStatus defines the observed state of Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DomainStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DomainStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Domain is the Schema for the Domains API. Provides a SageMaker AI Domain resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Domain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DomainSpec>, IStatus<V1beta2DomainStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Domain";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainSpec defines the desired state of Domain</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DomainSpec Spec { get; set; }

    /// <summary>DomainStatus defines the observed state of Domain.</summary>
    [JsonPropertyName("status")]
    public V1beta2DomainStatus? Status { get; set; }
}