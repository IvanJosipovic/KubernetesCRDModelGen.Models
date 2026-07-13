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
/// <summary>Space is the Schema for the Spaces API. Provides a SageMaker AI Space resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SpaceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Space>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SpaceList";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "spaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpaceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Space objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Space> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpaceSpecDeletionPolicyEnum>))]
public enum V1beta2SpaceSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpaceSpecForProviderDomainIdRefPolicyResolutionEnum>))]
public enum V1beta2SpaceSpecForProviderDomainIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpaceSpecForProviderDomainIdRefPolicyResolveEnum>))]
public enum V1beta2SpaceSpecForProviderDomainIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderDomainIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpaceSpecForProviderDomainIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpaceSpecForProviderDomainIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpaceSpecForProviderDomainIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpaceSpecForProviderDomainIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpaceSpecForProviderDomainIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpaceSpecForProviderDomainIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpaceSpecForProviderDomainIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderDomainIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpaceSpecForProviderDomainIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpaceSpecForProviderDomainIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderDomainIdSelector
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
    public V1beta2SpaceSpecForProviderDomainIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A collection of ownership settings. Required if space_sharing_settings is set. See ownership_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderOwnershipSettings
{
    /// <summary>The user profile who is the owner of the private space.</summary>
    [JsonPropertyName("ownerUserProfileName")]
    public string? OwnerUserProfileName { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }
}

/// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
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
public partial class V1beta2SpaceSpecForProviderSpaceSettingsCodeEditorAppSettings
{
    /// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2SpaceSpecForProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A custom file system in Amazon EFS. See efs_file_system Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsCustomFileSystemEfsFileSystem
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsCustomFileSystem
{
    /// <summary>A custom file system in Amazon EFS. See efs_file_system Block below.</summary>
    [JsonPropertyName("efsFileSystem")]
    public V1beta2SpaceSpecForProviderSpaceSettingsCustomFileSystemEfsFileSystem? EfsFileSystem { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }
}

/// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsJupyterLabAppSettings
{
    /// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. See code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2SpaceSpecForProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
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
public partial class V1beta2SpaceSpecForProviderSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. See code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2SpaceSpecForProviderSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2SpaceSpecForProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettingsCustomImage
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

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
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
public partial class V1beta2SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. See custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>A collection of EBS storage settings for a space. See ebs_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings
{
    /// <summary>The size of an EBS storage volume for a space.</summary>
    [JsonPropertyName("ebsVolumeSizeInGb")]
    public double? EbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings. See space_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettingsSpaceStorageSettings
{
    /// <summary>A collection of EBS storage settings for a space. See ebs_storage_settings Block below.</summary>
    [JsonPropertyName("ebsStorageSettings")]
    public V1beta2SpaceSpecForProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings? EbsStorageSettings { get; set; }
}

/// <summary>A collection of space settings. See space_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSettings
{
    /// <summary>The type of app created within the space.</summary>
    [JsonPropertyName("appType")]
    public string? AppType { get; set; }

    /// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1beta2SpaceSpecForProviderSpaceSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    /// <summary>A file system, created by you, that you assign to a space for an Amazon SageMaker AI Domain. See custom_file_system Block below.</summary>
    [JsonPropertyName("customFileSystem")]
    public IList<V1beta2SpaceSpecForProviderSpaceSettingsCustomFileSystem>? CustomFileSystem { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta2SpaceSpecForProviderSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta2SpaceSpecForProviderSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta2SpaceSpecForProviderSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The storage settings. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta2SpaceSpecForProviderSpaceSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }
}

/// <summary>A collection of space sharing settings. Required if ownership_settings is set. See space_sharing_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProviderSpaceSharingSettings
{
    /// <summary>Specifies the sharing type of the space. Valid values are Private and Shared.</summary>
    [JsonPropertyName("sharingType")]
    public string? SharingType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecForProvider
{
    /// <summary>The ID of the associated Domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdRef")]
    public V1beta2SpaceSpecForProviderDomainIdRef? DomainIdRef { get; set; }

    /// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdSelector")]
    public V1beta2SpaceSpecForProviderDomainIdSelector? DomainIdSelector { get; set; }

    /// <summary>A collection of ownership settings. Required if space_sharing_settings is set. See ownership_settings Block below.</summary>
    [JsonPropertyName("ownershipSettings")]
    public V1beta2SpaceSpecForProviderOwnershipSettings? OwnershipSettings { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The name of the space that appears in the SageMaker AI Studio UI.</summary>
    [JsonPropertyName("spaceDisplayName")]
    public string? SpaceDisplayName { get; set; }

    /// <summary>The name of the space.</summary>
    [JsonPropertyName("spaceName")]
    public string? SpaceName { get; set; }

    /// <summary>A collection of space settings. See space_settings Block below.</summary>
    [JsonPropertyName("spaceSettings")]
    public V1beta2SpaceSpecForProviderSpaceSettings? SpaceSettings { get; set; }

    /// <summary>A collection of space sharing settings. Required if ownership_settings is set. See space_sharing_settings Block below.</summary>
    [JsonPropertyName("spaceSharingSettings")]
    public V1beta2SpaceSpecForProviderSpaceSharingSettings? SpaceSharingSettings { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpaceSpecInitProviderDomainIdRefPolicyResolutionEnum>))]
public enum V1beta2SpaceSpecInitProviderDomainIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpaceSpecInitProviderDomainIdRefPolicyResolveEnum>))]
public enum V1beta2SpaceSpecInitProviderDomainIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderDomainIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpaceSpecInitProviderDomainIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpaceSpecInitProviderDomainIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpaceSpecInitProviderDomainIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpaceSpecInitProviderDomainIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpaceSpecInitProviderDomainIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpaceSpecInitProviderDomainIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpaceSpecInitProviderDomainIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderDomainIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpaceSpecInitProviderDomainIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpaceSpecInitProviderDomainIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderDomainIdSelector
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
    public V1beta2SpaceSpecInitProviderDomainIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A collection of ownership settings. Required if space_sharing_settings is set. See ownership_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderOwnershipSettings
{
    /// <summary>The user profile who is the owner of the private space.</summary>
    [JsonPropertyName("ownerUserProfileName")]
    public string? OwnerUserProfileName { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }
}

/// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
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
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettings
{
    /// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A custom file system in Amazon EFS. See efs_file_system Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsCustomFileSystemEfsFileSystem
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsCustomFileSystem
{
    /// <summary>A custom file system in Amazon EFS. See efs_file_system Block below.</summary>
    [JsonPropertyName("efsFileSystem")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsCustomFileSystemEfsFileSystem? EfsFileSystem { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }
}

/// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettings
{
    /// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. See code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
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
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. See code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettingsCustomImage
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

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
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
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. See custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>A collection of EBS storage settings for a space. See ebs_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings
{
    /// <summary>The size of an EBS storage volume for a space.</summary>
    [JsonPropertyName("ebsVolumeSizeInGb")]
    public double? EbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings. See space_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettingsSpaceStorageSettings
{
    /// <summary>A collection of EBS storage settings for a space. See ebs_storage_settings Block below.</summary>
    [JsonPropertyName("ebsStorageSettings")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings? EbsStorageSettings { get; set; }
}

/// <summary>A collection of space settings. See space_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSettings
{
    /// <summary>The type of app created within the space.</summary>
    [JsonPropertyName("appType")]
    public string? AppType { get; set; }

    /// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    /// <summary>A file system, created by you, that you assign to a space for an Amazon SageMaker AI Domain. See custom_file_system Block below.</summary>
    [JsonPropertyName("customFileSystem")]
    public IList<V1beta2SpaceSpecInitProviderSpaceSettingsCustomFileSystem>? CustomFileSystem { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The storage settings. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta2SpaceSpecInitProviderSpaceSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }
}

/// <summary>A collection of space sharing settings. Required if ownership_settings is set. See space_sharing_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecInitProviderSpaceSharingSettings
{
    /// <summary>Specifies the sharing type of the space. Valid values are Private and Shared.</summary>
    [JsonPropertyName("sharingType")]
    public string? SharingType { get; set; }
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
public partial class V1beta2SpaceSpecInitProvider
{
    /// <summary>The ID of the associated Domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdRef")]
    public V1beta2SpaceSpecInitProviderDomainIdRef? DomainIdRef { get; set; }

    /// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdSelector")]
    public V1beta2SpaceSpecInitProviderDomainIdSelector? DomainIdSelector { get; set; }

    /// <summary>A collection of ownership settings. Required if space_sharing_settings is set. See ownership_settings Block below.</summary>
    [JsonPropertyName("ownershipSettings")]
    public V1beta2SpaceSpecInitProviderOwnershipSettings? OwnershipSettings { get; set; }

    /// <summary>The name of the space that appears in the SageMaker AI Studio UI.</summary>
    [JsonPropertyName("spaceDisplayName")]
    public string? SpaceDisplayName { get; set; }

    /// <summary>The name of the space.</summary>
    [JsonPropertyName("spaceName")]
    public string? SpaceName { get; set; }

    /// <summary>A collection of space settings. See space_settings Block below.</summary>
    [JsonPropertyName("spaceSettings")]
    public V1beta2SpaceSpecInitProviderSpaceSettings? SpaceSettings { get; set; }

    /// <summary>A collection of space sharing settings. Required if ownership_settings is set. See space_sharing_settings Block below.</summary>
    [JsonPropertyName("spaceSharingSettings")]
    public V1beta2SpaceSpecInitProviderSpaceSharingSettings? SpaceSharingSettings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpaceSpecManagementPoliciesEnum>))]
public enum V1beta2SpaceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpaceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SpaceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpaceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SpaceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpaceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpaceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpaceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SpaceSpec defines the desired state of Space</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceSpec
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
    public V1beta2SpaceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SpaceSpecForProvider ForProvider { get; set; }

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
    public V1beta2SpaceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SpaceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SpaceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SpaceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A collection of ownership settings. Required if space_sharing_settings is set. See ownership_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderOwnershipSettings
{
    /// <summary>The user profile who is the owner of the private space.</summary>
    [JsonPropertyName("ownerUserProfileName")]
    public string? OwnerUserProfileName { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }
}

/// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
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
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettings
{
    /// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A custom file system in Amazon EFS. See efs_file_system Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsCustomFileSystemEfsFileSystem
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsCustomFileSystem
{
    /// <summary>A custom file system in Amazon EFS. See efs_file_system Block below.</summary>
    [JsonPropertyName("efsFileSystem")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsCustomFileSystemEfsFileSystem? EfsFileSystem { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }
}

/// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. See idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettings
{
    /// <summary>Settings that are used to configure and manage the lifecycle of JupyterLab applications in a space. See app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. See code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
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
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. See code_repository Block below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettingsCustomImage
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

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI image created on the instance.</summary>
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
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. See custom_image Block below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. See default_resource_spec Block below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

/// <summary>A collection of EBS storage settings for a space. See ebs_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings
{
    /// <summary>The size of an EBS storage volume for a space.</summary>
    [JsonPropertyName("ebsVolumeSizeInGb")]
    public double? EbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings. See space_storage_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettingsSpaceStorageSettings
{
    /// <summary>A collection of EBS storage settings for a space. See ebs_storage_settings Block below.</summary>
    [JsonPropertyName("ebsStorageSettings")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsSpaceStorageSettingsEbsStorageSettings? EbsStorageSettings { get; set; }
}

/// <summary>A collection of space settings. See space_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSettings
{
    /// <summary>The type of app created within the space.</summary>
    [JsonPropertyName("appType")]
    public string? AppType { get; set; }

    /// <summary>The Code Editor application settings. See code_editor_app_settings Block below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    /// <summary>A file system, created by you, that you assign to a space for an Amazon SageMaker AI Domain. See custom_file_system Block below.</summary>
    [JsonPropertyName("customFileSystem")]
    public IList<V1beta2SpaceStatusAtProviderSpaceSettingsCustomFileSystem>? CustomFileSystem { get; set; }

    /// <summary>The settings for the JupyterLab application. See jupyter_lab_app_settings Block below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server&apos;s app settings. See jupyter_server_app_settings Block below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See kernel_gateway_app_settings Block below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The storage settings. See space_storage_settings Block below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta2SpaceStatusAtProviderSpaceSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }
}

/// <summary>A collection of space sharing settings. Required if ownership_settings is set. See space_sharing_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProviderSpaceSharingSettings
{
    /// <summary>Specifies the sharing type of the space. Valid values are Private and Shared.</summary>
    [JsonPropertyName("sharingType")]
    public string? SharingType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusAtProvider
{
    /// <summary>The space&apos;s Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ID of the associated Domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>The ID of the space&apos;s profile in the Amazon Elastic File System volume.</summary>
    [JsonPropertyName("homeEfsFileSystemUid")]
    public string? HomeEfsFileSystemUid { get; set; }

    /// <summary>The space&apos;s Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A collection of ownership settings. Required if space_sharing_settings is set. See ownership_settings Block below.</summary>
    [JsonPropertyName("ownershipSettings")]
    public V1beta2SpaceStatusAtProviderOwnershipSettings? OwnershipSettings { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The name of the space that appears in the SageMaker AI Studio UI.</summary>
    [JsonPropertyName("spaceDisplayName")]
    public string? SpaceDisplayName { get; set; }

    /// <summary>The name of the space.</summary>
    [JsonPropertyName("spaceName")]
    public string? SpaceName { get; set; }

    /// <summary>A collection of space settings. See space_settings Block below.</summary>
    [JsonPropertyName("spaceSettings")]
    public V1beta2SpaceStatusAtProviderSpaceSettings? SpaceSettings { get; set; }

    /// <summary>A collection of space sharing settings. Required if ownership_settings is set. See space_sharing_settings Block below.</summary>
    [JsonPropertyName("spaceSharingSettings")]
    public V1beta2SpaceStatusAtProviderSpaceSharingSettings? SpaceSharingSettings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Returns the URL of the space. If the space is created with Amazon Web Services IAM Identity Center (Successor to Amazon Web Services Single Sign-On) authentication, users can navigate to the URL after appending the respective redirect parameter for the application type to be federated through Amazon Web Services IAM Identity Center.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatusConditions
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

/// <summary>SpaceStatus defines the observed state of Space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpaceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SpaceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SpaceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Space is the Schema for the Spaces API. Provides a SageMaker AI Space resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Space : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SpaceSpec>, IStatus<V1beta2SpaceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Space";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "spaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Space";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpaceSpec defines the desired state of Space</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SpaceSpec Spec { get; set; }

    /// <summary>SpaceStatus defines the observed state of Space.</summary>
    [JsonPropertyName("status")]
    public V1beta2SpaceStatus? Status { get; set; }
}