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
/// <summary>AppImageConfig is the Schema for the AppImageConfigs API. Provides a SageMaker AI App Image Config resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AppImageConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta2AppImageConfig>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AppImageConfigList";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "appimageconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AppImageConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2AppImageConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2AppImageConfig> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppImageConfigSpecDeletionPolicyEnum>))]
public enum V1beta2AppImageConfigSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecForProviderCodeEditorAppImageConfigContainerConfig
{
    /// <summary>The arguments for the container when you&apos;re running the application.</summary>
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    /// <summary>The entrypoint used to run the application in the container.</summary>
    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    /// <summary>The environment variables to set in the container.</summary>
    [JsonPropertyName("containerEnvironmentVariables")]
    public IDictionary<string, string>? ContainerEnvironmentVariables { get; set; }
}

/// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecForProviderCodeEditorAppImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user&apos;s EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary>The CodeEditorAppImageConfig. See Code Editor App Image Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecForProviderCodeEditorAppImageConfig
{
    /// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
    [JsonPropertyName("containerConfig")]
    public V1beta2AppImageConfigSpecForProviderCodeEditorAppImageConfigContainerConfig? ContainerConfig { get; set; }

    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public V1beta2AppImageConfigSpecForProviderCodeEditorAppImageConfigFileSystemConfig? FileSystemConfig { get; set; }
}

/// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecForProviderJupyterLabImageConfigContainerConfig
{
    /// <summary>The arguments for the container when you&apos;re running the application.</summary>
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    /// <summary>The entrypoint used to run the application in the container.</summary>
    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    /// <summary>The environment variables to set in the container.</summary>
    [JsonPropertyName("containerEnvironmentVariables")]
    public IDictionary<string, string>? ContainerEnvironmentVariables { get; set; }
}

/// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecForProviderJupyterLabImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user&apos;s EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary>The JupyterLabAppImageConfig. See Jupyter Lab Image Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecForProviderJupyterLabImageConfig
{
    /// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
    [JsonPropertyName("containerConfig")]
    public V1beta2AppImageConfigSpecForProviderJupyterLabImageConfigContainerConfig? ContainerConfig { get; set; }

    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public V1beta2AppImageConfigSpecForProviderJupyterLabImageConfigFileSystemConfig? FileSystemConfig { get; set; }
}

/// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecForProviderKernelGatewayImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user&apos;s EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecForProviderKernelGatewayImageConfigKernelSpec
{
    /// <summary>The display name of the kernel.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the kernel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The configuration for the file system and kernels in a SageMaker AI image running as a KernelGateway app. See Kernel Gateway Image Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecForProviderKernelGatewayImageConfig
{
    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public V1beta2AppImageConfigSpecForProviderKernelGatewayImageConfigFileSystemConfig? FileSystemConfig { get; set; }

    /// <summary>The default branch for the Git repository. See Kernel Spec details below.</summary>
    [JsonPropertyName("kernelSpec")]
    public IList<V1beta2AppImageConfigSpecForProviderKernelGatewayImageConfigKernelSpec>? KernelSpec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecForProvider
{
    /// <summary>The CodeEditorAppImageConfig. See Code Editor App Image Config details below.</summary>
    [JsonPropertyName("codeEditorAppImageConfig")]
    public V1beta2AppImageConfigSpecForProviderCodeEditorAppImageConfig? CodeEditorAppImageConfig { get; set; }

    /// <summary>The JupyterLabAppImageConfig. See Jupyter Lab Image Config details below.</summary>
    [JsonPropertyName("jupyterLabImageConfig")]
    public V1beta2AppImageConfigSpecForProviderJupyterLabImageConfig? JupyterLabImageConfig { get; set; }

    /// <summary>The configuration for the file system and kernels in a SageMaker AI image running as a KernelGateway app. See Kernel Gateway Image Config details below.</summary>
    [JsonPropertyName("kernelGatewayImageConfig")]
    public V1beta2AppImageConfigSpecForProviderKernelGatewayImageConfig? KernelGatewayImageConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecInitProviderCodeEditorAppImageConfigContainerConfig
{
    /// <summary>The arguments for the container when you&apos;re running the application.</summary>
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    /// <summary>The entrypoint used to run the application in the container.</summary>
    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    /// <summary>The environment variables to set in the container.</summary>
    [JsonPropertyName("containerEnvironmentVariables")]
    public IDictionary<string, string>? ContainerEnvironmentVariables { get; set; }
}

/// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecInitProviderCodeEditorAppImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user&apos;s EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary>The CodeEditorAppImageConfig. See Code Editor App Image Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecInitProviderCodeEditorAppImageConfig
{
    /// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
    [JsonPropertyName("containerConfig")]
    public V1beta2AppImageConfigSpecInitProviderCodeEditorAppImageConfigContainerConfig? ContainerConfig { get; set; }

    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public V1beta2AppImageConfigSpecInitProviderCodeEditorAppImageConfigFileSystemConfig? FileSystemConfig { get; set; }
}

/// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecInitProviderJupyterLabImageConfigContainerConfig
{
    /// <summary>The arguments for the container when you&apos;re running the application.</summary>
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    /// <summary>The entrypoint used to run the application in the container.</summary>
    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    /// <summary>The environment variables to set in the container.</summary>
    [JsonPropertyName("containerEnvironmentVariables")]
    public IDictionary<string, string>? ContainerEnvironmentVariables { get; set; }
}

/// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecInitProviderJupyterLabImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user&apos;s EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary>The JupyterLabAppImageConfig. See Jupyter Lab Image Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecInitProviderJupyterLabImageConfig
{
    /// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
    [JsonPropertyName("containerConfig")]
    public V1beta2AppImageConfigSpecInitProviderJupyterLabImageConfigContainerConfig? ContainerConfig { get; set; }

    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public V1beta2AppImageConfigSpecInitProviderJupyterLabImageConfigFileSystemConfig? FileSystemConfig { get; set; }
}

/// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecInitProviderKernelGatewayImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user&apos;s EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecInitProviderKernelGatewayImageConfigKernelSpec
{
    /// <summary>The display name of the kernel.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the kernel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The configuration for the file system and kernels in a SageMaker AI image running as a KernelGateway app. See Kernel Gateway Image Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecInitProviderKernelGatewayImageConfig
{
    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public V1beta2AppImageConfigSpecInitProviderKernelGatewayImageConfigFileSystemConfig? FileSystemConfig { get; set; }

    /// <summary>The default branch for the Git repository. See Kernel Spec details below.</summary>
    [JsonPropertyName("kernelSpec")]
    public IList<V1beta2AppImageConfigSpecInitProviderKernelGatewayImageConfigKernelSpec>? KernelSpec { get; set; }
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
public partial class V1beta2AppImageConfigSpecInitProvider
{
    /// <summary>The CodeEditorAppImageConfig. See Code Editor App Image Config details below.</summary>
    [JsonPropertyName("codeEditorAppImageConfig")]
    public V1beta2AppImageConfigSpecInitProviderCodeEditorAppImageConfig? CodeEditorAppImageConfig { get; set; }

    /// <summary>The JupyterLabAppImageConfig. See Jupyter Lab Image Config details below.</summary>
    [JsonPropertyName("jupyterLabImageConfig")]
    public V1beta2AppImageConfigSpecInitProviderJupyterLabImageConfig? JupyterLabImageConfig { get; set; }

    /// <summary>The configuration for the file system and kernels in a SageMaker AI image running as a KernelGateway app. See Kernel Gateway Image Config details below.</summary>
    [JsonPropertyName("kernelGatewayImageConfig")]
    public V1beta2AppImageConfigSpecInitProviderKernelGatewayImageConfig? KernelGatewayImageConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppImageConfigSpecManagementPoliciesEnum>))]
public enum V1beta2AppImageConfigSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppImageConfigSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2AppImageConfigSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppImageConfigSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2AppImageConfigSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AppImageConfigSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AppImageConfigSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AppImageConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AppImageConfigSpec defines the desired state of AppImageConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigSpec
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
    public V1beta2AppImageConfigSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2AppImageConfigSpecForProvider ForProvider { get; set; }

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
    public V1beta2AppImageConfigSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2AppImageConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2AppImageConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2AppImageConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigStatusAtProviderCodeEditorAppImageConfigContainerConfig
{
    /// <summary>The arguments for the container when you&apos;re running the application.</summary>
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    /// <summary>The entrypoint used to run the application in the container.</summary>
    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    /// <summary>The environment variables to set in the container.</summary>
    [JsonPropertyName("containerEnvironmentVariables")]
    public IDictionary<string, string>? ContainerEnvironmentVariables { get; set; }
}

/// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigStatusAtProviderCodeEditorAppImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user&apos;s EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary>The CodeEditorAppImageConfig. See Code Editor App Image Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigStatusAtProviderCodeEditorAppImageConfig
{
    /// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
    [JsonPropertyName("containerConfig")]
    public V1beta2AppImageConfigStatusAtProviderCodeEditorAppImageConfigContainerConfig? ContainerConfig { get; set; }

    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public V1beta2AppImageConfigStatusAtProviderCodeEditorAppImageConfigFileSystemConfig? FileSystemConfig { get; set; }
}

/// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigStatusAtProviderJupyterLabImageConfigContainerConfig
{
    /// <summary>The arguments for the container when you&apos;re running the application.</summary>
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    /// <summary>The entrypoint used to run the application in the container.</summary>
    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    /// <summary>The environment variables to set in the container.</summary>
    [JsonPropertyName("containerEnvironmentVariables")]
    public IDictionary<string, string>? ContainerEnvironmentVariables { get; set; }
}

/// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigStatusAtProviderJupyterLabImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user&apos;s EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary>The JupyterLabAppImageConfig. See Jupyter Lab Image Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigStatusAtProviderJupyterLabImageConfig
{
    /// <summary>The configuration used to run the application image container. See Container Config details below.</summary>
    [JsonPropertyName("containerConfig")]
    public V1beta2AppImageConfigStatusAtProviderJupyterLabImageConfigContainerConfig? ContainerConfig { get; set; }

    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public V1beta2AppImageConfigStatusAtProviderJupyterLabImageConfigFileSystemConfig? FileSystemConfig { get; set; }
}

/// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigStatusAtProviderKernelGatewayImageConfigFileSystemConfig
{
    /// <summary>The default POSIX group ID (GID). If not specified, defaults to 100. Valid values are 0 and 100.</summary>
    [JsonPropertyName("defaultGid")]
    public double? DefaultGid { get; set; }

    /// <summary>The default POSIX user ID (UID). If not specified, defaults to 1000. Valid values are 0 and 1000.</summary>
    [JsonPropertyName("defaultUid")]
    public double? DefaultUid { get; set; }

    /// <summary>The path within the image to mount the user&apos;s EFS home directory. The directory should be empty. If not specified, defaults to /home/sagemaker-user.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigStatusAtProviderKernelGatewayImageConfigKernelSpec
{
    /// <summary>The display name of the kernel.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the kernel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The configuration for the file system and kernels in a SageMaker AI image running as a KernelGateway app. See Kernel Gateway Image Config details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigStatusAtProviderKernelGatewayImageConfig
{
    /// <summary>The URL where the Git repository is located. See File System Config details below.</summary>
    [JsonPropertyName("fileSystemConfig")]
    public V1beta2AppImageConfigStatusAtProviderKernelGatewayImageConfigFileSystemConfig? FileSystemConfig { get; set; }

    /// <summary>The default branch for the Git repository. See Kernel Spec details below.</summary>
    [JsonPropertyName("kernelSpec")]
    public IList<V1beta2AppImageConfigStatusAtProviderKernelGatewayImageConfigKernelSpec>? KernelSpec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this App Image Config.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The CodeEditorAppImageConfig. See Code Editor App Image Config details below.</summary>
    [JsonPropertyName("codeEditorAppImageConfig")]
    public V1beta2AppImageConfigStatusAtProviderCodeEditorAppImageConfig? CodeEditorAppImageConfig { get; set; }

    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The JupyterLabAppImageConfig. See Jupyter Lab Image Config details below.</summary>
    [JsonPropertyName("jupyterLabImageConfig")]
    public V1beta2AppImageConfigStatusAtProviderJupyterLabImageConfig? JupyterLabImageConfig { get; set; }

    /// <summary>The configuration for the file system and kernels in a SageMaker AI image running as a KernelGateway app. See Kernel Gateway Image Config details below.</summary>
    [JsonPropertyName("kernelGatewayImageConfig")]
    public V1beta2AppImageConfigStatusAtProviderKernelGatewayImageConfig? KernelGatewayImageConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigStatusConditions
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

/// <summary>AppImageConfigStatus defines the observed state of AppImageConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppImageConfigStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2AppImageConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AppImageConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AppImageConfig is the Schema for the AppImageConfigs API. Provides a SageMaker AI App Image Config resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AppImageConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2AppImageConfigSpec>, IStatus<V1beta2AppImageConfigStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AppImageConfig";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "appimageconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AppImageConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppImageConfigSpec defines the desired state of AppImageConfig</summary>
    [JsonPropertyName("spec")]
    public required V1beta2AppImageConfigSpec Spec { get; set; }

    /// <summary>AppImageConfigStatus defines the observed state of AppImageConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta2AppImageConfigStatus? Status { get; set; }
}