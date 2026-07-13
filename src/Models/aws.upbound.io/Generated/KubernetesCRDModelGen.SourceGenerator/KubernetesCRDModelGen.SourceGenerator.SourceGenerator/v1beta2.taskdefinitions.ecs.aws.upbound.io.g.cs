#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ecs.aws.upbound.io;
/// <summary>TaskDefinition is the Schema for the TaskDefinitions API. Manages a revision of an ECS task definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2TaskDefinitionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2TaskDefinition>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "TaskDefinitionList";
    public const string KubeGroup = "ecs.aws.upbound.io";
    public const string KubePluralName = "taskdefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TaskDefinitionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2TaskDefinition objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2TaskDefinition> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskDefinitionSpecDeletionPolicyEnum>))]
public enum V1beta2TaskDefinitionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>The amount of ephemeral storage to allocate for the task. This parameter is used to expand the total amount of ephemeral storage available, beyond the default amount, for tasks hosted on AWS Fargate. See Ephemeral Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderEphemeralStorage
{
    /// <summary>The total amount, in GiB, of ephemeral storage to set for the task. The minimum supported value is 21 GiB and the maximum supported value is 200 GiB.</summary>
    [JsonPropertyName("sizeInGib")]
    public double? SizeInGib { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskDefinitionSpecForProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2TaskDefinitionSpecForProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskDefinitionSpecForProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta2TaskDefinitionSpecForProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskDefinitionSpecForProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskDefinitionSpecForProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TaskDefinitionSpecForProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskDefinitionSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TaskDefinitionSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskDefinitionSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2TaskDefinitionSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskDefinitionSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskDefinitionSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderExecutionRoleArnSelector
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
    public V1beta2TaskDefinitionSpecForProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderPlacementConstraints
{
    /// <summary>Cluster Query Language expression to apply to the constraint. For more information, see Cluster Query Language in the Amazon EC2 Container Service Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Type of constraint. Use memberOf to restrict selection to a group of valid candidates. Note that distinctInstance is not supported in task definitions.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block for the App Mesh proxy. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderProxyConfiguration
{
    /// <summary>Name of the container that will serve as the App Mesh proxy.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Set of network configuration parameters to provide the Container Network Interface (CNI) plugin, specified a key-value mapping.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Proxy type. The default value is APPMESH. The only supported value is APPMESH.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block for runtime_platform that containers in your task may use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderRuntimePlatform
{
    /// <summary>Must be set to either X86_64 or ARM64; see cpu architecture</summary>
    [JsonPropertyName("cpuArchitecture")]
    public string? CpuArchitecture { get; set; }

    /// <summary>If the requires_compatibilities is FARGATE this field is required; must be set to a valid option from the operating system family in the runtime platform setting</summary>
    [JsonPropertyName("operatingSystemFamily")]
    public string? OperatingSystemFamily { get; set; }
}

/// <summary>Configuration block to configure a docker volume. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderVolumeDockerVolumeConfiguration
{
    /// <summary>If this value is true, the Docker volume is created if it does not already exist. Note: This field is only used if the scope is shared.</summary>
    [JsonPropertyName("autoprovision")]
    public bool? Autoprovision { get; set; }

    /// <summary>Docker volume driver to use. The driver value must match the driver name provided by Docker because it is used for task placement.</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>Map of Docker driver specific options.</summary>
    [JsonPropertyName("driverOpts")]
    public IDictionary<string, string>? DriverOpts { get; set; }

    /// <summary>Map of custom metadata to add to your Docker volume.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Scope for the Docker volume, which determines its lifecycle, either task or shared.  Docker volumes that are scoped to a task are automatically provisioned when the task starts and destroyed when the task stops. Docker volumes that are scoped as shared persist after the task stops.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Configuration block for authorization for the Amazon EFS file system. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderVolumeEfsVolumeConfigurationAuthorizationConfig
{
    /// <summary>Access point ID to use. If an access point is specified, the root directory value will be relative to the directory set for the access point. If specified, transit encryption must be enabled in the EFSVolumeConfiguration.</summary>
    [JsonPropertyName("accessPointId")]
    public string? AccessPointId { get; set; }

    /// <summary>Whether or not to use the Amazon ECS task IAM role defined in a task definition when mounting the Amazon EFS file system. If enabled, transit encryption must be enabled in the EFSVolumeConfiguration. Valid values: ENABLED, DISABLED. If this parameter is omitted, the default value of DISABLED is used.</summary>
    [JsonPropertyName("iam")]
    public string? Iam { get; set; }
}

/// <summary>Configuration block for an EFS volume. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderVolumeEfsVolumeConfiguration
{
    /// <summary>Configuration block for authorization for the Amazon EFS file system. Detailed below.</summary>
    [JsonPropertyName("authorizationConfig")]
    public V1beta2TaskDefinitionSpecForProviderVolumeEfsVolumeConfigurationAuthorizationConfig? AuthorizationConfig { get; set; }

    /// <summary>ID of the EFS File System.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Directory within the Amazon EFS file system to mount as the root directory inside the host. If this parameter is omitted, the root of the Amazon EFS volume will be used. Specifying / will have the same effect as omitting this parameter. This argument is ignored when using authorization_config.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }

    /// <summary>Whether or not to enable encryption for Amazon EFS data in transit between the Amazon ECS host and the Amazon EFS server. Transit encryption must be enabled if Amazon EFS IAM authorization is used. Valid values: ENABLED, DISABLED. If this parameter is omitted, the default value of DISABLED is used.</summary>
    [JsonPropertyName("transitEncryption")]
    public string? TransitEncryption { get; set; }

    /// <summary>Port to use for transit encryption. If you do not specify a transit encryption port, it will use the port selection strategy that the Amazon EFS mount helper uses.</summary>
    [JsonPropertyName("transitEncryptionPort")]
    public double? TransitEncryptionPort { get; set; }
}

/// <summary>Configuration block for authorization for the Amazon FSx for Windows File Server file system detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig
{
    /// <summary>The authorization credential option to use. The authorization credential options can be provided using either the Amazon Resource Name (ARN) of an AWS Secrets Manager secret or AWS Systems Manager Parameter Store parameter. The ARNs refer to the stored credentials.</summary>
    [JsonPropertyName("credentialsParameter")]
    public string? CredentialsParameter { get; set; }

    /// <summary>A fully qualified domain name hosted by an AWS Directory Service Managed Microsoft AD (Active Directory) or self-hosted AD on Amazon EC2.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}

/// <summary>Configuration block for an FSX Windows File Server volume. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderVolumeFsxWindowsFileServerVolumeConfiguration
{
    /// <summary>Configuration block for authorization for the Amazon FSx for Windows File Server file system detailed below.</summary>
    [JsonPropertyName("authorizationConfig")]
    public V1beta2TaskDefinitionSpecForProviderVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig? AuthorizationConfig { get; set; }

    /// <summary>The Amazon FSx for Windows File Server file system ID to use.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The directory within the Amazon FSx for Windows File Server file system to mount as the root directory inside the host.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProviderVolume
{
    /// <summary>Whether the volume should be configured at launch time. This is used to create Amazon EBS volumes for standalone tasks or tasks created as part of a service. Each task definition revision may only have one volume configured at launch in the volume configuration.</summary>
    [JsonPropertyName("configureAtLaunch")]
    public bool? ConfigureAtLaunch { get; set; }

    /// <summary>Configuration block to configure a docker volume. Detailed below.</summary>
    [JsonPropertyName("dockerVolumeConfiguration")]
    public V1beta2TaskDefinitionSpecForProviderVolumeDockerVolumeConfiguration? DockerVolumeConfiguration { get; set; }

    /// <summary>Configuration block for an EFS volume. Detailed below.</summary>
    [JsonPropertyName("efsVolumeConfiguration")]
    public V1beta2TaskDefinitionSpecForProviderVolumeEfsVolumeConfiguration? EfsVolumeConfiguration { get; set; }

    /// <summary>Configuration block for an FSX Windows File Server volume. Detailed below.</summary>
    [JsonPropertyName("fsxWindowsFileServerVolumeConfiguration")]
    public V1beta2TaskDefinitionSpecForProviderVolumeFsxWindowsFileServerVolumeConfiguration? FsxWindowsFileServerVolumeConfiguration { get; set; }

    /// <summary>Path on the host container instance that is presented to the container. If not set, ECS will create a nonpersistent data volume that starts empty and is deleted after the task has finished.</summary>
    [JsonPropertyName("hostPath")]
    public string? HostPath { get; set; }

    /// <summary>
    /// Name of the volume. This name is referenced in the sourceVolume
    /// parameter of container definition in the mountPoints section.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecForProvider
{
    /// <summary>A list of valid container definitions provided as a single valid JSON document. Please note that you should only provide values that are part of the container definition document. For a detailed description of what parameters are available, see the Task Definition Parameters section from the official Developer Guide.</summary>
    [JsonPropertyName("containerDefinitions")]
    public string? ContainerDefinitions { get; set; }

    /// <summary>Number of cpu units used by the task. If the requires_compatibilities is FARGATE this field is required.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Enables fault injection and allows for fault injection requests to be accepted from the task&apos;s containers. Default is false.</summary>
    [JsonPropertyName("enableFaultInjection")]
    public bool? EnableFaultInjection { get; set; }

    /// <summary>The amount of ephemeral storage to allocate for the task. This parameter is used to expand the total amount of ephemeral storage available, beyond the default amount, for tasks hosted on AWS Fargate. See Ephemeral Storage.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public V1beta2TaskDefinitionSpecForProviderEphemeralStorage? EphemeralStorage { get; set; }

    /// <summary>ARN of the task execution role that the Amazon ECS container agent and the Docker daemon can assume.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta2TaskDefinitionSpecForProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta2TaskDefinitionSpecForProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>A unique name for your task definition.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>IPC resource namespace to be used for the containers in the task. Valid values: host, task, none.</summary>
    [JsonPropertyName("ipcMode")]
    public string? IpcMode { get; set; }

    /// <summary>Amount (in MiB) of memory used by the task. If the requires_compatibilities is FARGATE this field is required.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>Docker networking mode to use for the containers in the task. Valid values: awsvpc, bridge, host, and none.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>Process namespace to use for the containers in the task. Valid values: host, task`.</summary>
    [JsonPropertyName("pidMode")]
    public string? PidMode { get; set; }

    /// <summary>Configuration block for rules that are taken into consideration during task placement. Maximum number of placement_constraints is 10. Detailed below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta2TaskDefinitionSpecForProviderPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>Configuration block for the App Mesh proxy. Detailed below.</summary>
    [JsonPropertyName("proxyConfiguration")]
    public V1beta2TaskDefinitionSpecForProviderProxyConfiguration? ProxyConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Set of launch types required by the task. Valid values: EC2, EXTERNAL, FARGATE, MANAGED_INSTANCES.</summary>
    [JsonPropertyName("requiresCompatibilities")]
    public IList<string>? RequiresCompatibilities { get; set; }

    /// <summary>Configuration block for runtime_platform that containers in your task may use.</summary>
    [JsonPropertyName("runtimePlatform")]
    public V1beta2TaskDefinitionSpecForProviderRuntimePlatform? RuntimePlatform { get; set; }

    /// <summary>Whether to retain the old revision when the resource is destroyed or replacement is necessary. Default is false.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ARN of IAM role that allows your Amazon ECS container task to make calls to other AWS services.</summary>
    [JsonPropertyName("taskRoleArn")]
    public string? TaskRoleArn { get; set; }

    /// <summary>Whether should track latest ACTIVE task definition on AWS or the one created with the resource stored in state. Default is false. Useful in the event the task definition is modified outside of this resource.</summary>
    [JsonPropertyName("trackLatest")]
    public bool? TrackLatest { get; set; }

    /// <summary>Repeatable configuration block for volumes that containers in your task may use. Detailed below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta2TaskDefinitionSpecForProviderVolume>? Volume { get; set; }
}

/// <summary>The amount of ephemeral storage to allocate for the task. This parameter is used to expand the total amount of ephemeral storage available, beyond the default amount, for tasks hosted on AWS Fargate. See Ephemeral Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderEphemeralStorage
{
    /// <summary>The total amount, in GiB, of ephemeral storage to set for the task. The minimum supported value is 21 GiB and the maximum supported value is 200 GiB.</summary>
    [JsonPropertyName("sizeInGib")]
    public double? SizeInGib { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnSelector
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
    public V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderPlacementConstraints
{
    /// <summary>Cluster Query Language expression to apply to the constraint. For more information, see Cluster Query Language in the Amazon EC2 Container Service Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Type of constraint. Use memberOf to restrict selection to a group of valid candidates. Note that distinctInstance is not supported in task definitions.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block for the App Mesh proxy. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderProxyConfiguration
{
    /// <summary>Name of the container that will serve as the App Mesh proxy.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Set of network configuration parameters to provide the Container Network Interface (CNI) plugin, specified a key-value mapping.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Proxy type. The default value is APPMESH. The only supported value is APPMESH.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block for runtime_platform that containers in your task may use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderRuntimePlatform
{
    /// <summary>Must be set to either X86_64 or ARM64; see cpu architecture</summary>
    [JsonPropertyName("cpuArchitecture")]
    public string? CpuArchitecture { get; set; }

    /// <summary>If the requires_compatibilities is FARGATE this field is required; must be set to a valid option from the operating system family in the runtime platform setting</summary>
    [JsonPropertyName("operatingSystemFamily")]
    public string? OperatingSystemFamily { get; set; }
}

/// <summary>Configuration block to configure a docker volume. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderVolumeDockerVolumeConfiguration
{
    /// <summary>If this value is true, the Docker volume is created if it does not already exist. Note: This field is only used if the scope is shared.</summary>
    [JsonPropertyName("autoprovision")]
    public bool? Autoprovision { get; set; }

    /// <summary>Docker volume driver to use. The driver value must match the driver name provided by Docker because it is used for task placement.</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>Map of Docker driver specific options.</summary>
    [JsonPropertyName("driverOpts")]
    public IDictionary<string, string>? DriverOpts { get; set; }

    /// <summary>Map of custom metadata to add to your Docker volume.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Scope for the Docker volume, which determines its lifecycle, either task or shared.  Docker volumes that are scoped to a task are automatically provisioned when the task starts and destroyed when the task stops. Docker volumes that are scoped as shared persist after the task stops.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Configuration block for authorization for the Amazon EFS file system. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderVolumeEfsVolumeConfigurationAuthorizationConfig
{
    /// <summary>Access point ID to use. If an access point is specified, the root directory value will be relative to the directory set for the access point. If specified, transit encryption must be enabled in the EFSVolumeConfiguration.</summary>
    [JsonPropertyName("accessPointId")]
    public string? AccessPointId { get; set; }

    /// <summary>Whether or not to use the Amazon ECS task IAM role defined in a task definition when mounting the Amazon EFS file system. If enabled, transit encryption must be enabled in the EFSVolumeConfiguration. Valid values: ENABLED, DISABLED. If this parameter is omitted, the default value of DISABLED is used.</summary>
    [JsonPropertyName("iam")]
    public string? Iam { get; set; }
}

/// <summary>Configuration block for an EFS volume. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderVolumeEfsVolumeConfiguration
{
    /// <summary>Configuration block for authorization for the Amazon EFS file system. Detailed below.</summary>
    [JsonPropertyName("authorizationConfig")]
    public V1beta2TaskDefinitionSpecInitProviderVolumeEfsVolumeConfigurationAuthorizationConfig? AuthorizationConfig { get; set; }

    /// <summary>ID of the EFS File System.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Directory within the Amazon EFS file system to mount as the root directory inside the host. If this parameter is omitted, the root of the Amazon EFS volume will be used. Specifying / will have the same effect as omitting this parameter. This argument is ignored when using authorization_config.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }

    /// <summary>Whether or not to enable encryption for Amazon EFS data in transit between the Amazon ECS host and the Amazon EFS server. Transit encryption must be enabled if Amazon EFS IAM authorization is used. Valid values: ENABLED, DISABLED. If this parameter is omitted, the default value of DISABLED is used.</summary>
    [JsonPropertyName("transitEncryption")]
    public string? TransitEncryption { get; set; }

    /// <summary>Port to use for transit encryption. If you do not specify a transit encryption port, it will use the port selection strategy that the Amazon EFS mount helper uses.</summary>
    [JsonPropertyName("transitEncryptionPort")]
    public double? TransitEncryptionPort { get; set; }
}

/// <summary>Configuration block for authorization for the Amazon FSx for Windows File Server file system detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig
{
    /// <summary>The authorization credential option to use. The authorization credential options can be provided using either the Amazon Resource Name (ARN) of an AWS Secrets Manager secret or AWS Systems Manager Parameter Store parameter. The ARNs refer to the stored credentials.</summary>
    [JsonPropertyName("credentialsParameter")]
    public string? CredentialsParameter { get; set; }

    /// <summary>A fully qualified domain name hosted by an AWS Directory Service Managed Microsoft AD (Active Directory) or self-hosted AD on Amazon EC2.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}

/// <summary>Configuration block for an FSX Windows File Server volume. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderVolumeFsxWindowsFileServerVolumeConfiguration
{
    /// <summary>Configuration block for authorization for the Amazon FSx for Windows File Server file system detailed below.</summary>
    [JsonPropertyName("authorizationConfig")]
    public V1beta2TaskDefinitionSpecInitProviderVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig? AuthorizationConfig { get; set; }

    /// <summary>The Amazon FSx for Windows File Server file system ID to use.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The directory within the Amazon FSx for Windows File Server file system to mount as the root directory inside the host.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecInitProviderVolume
{
    /// <summary>Whether the volume should be configured at launch time. This is used to create Amazon EBS volumes for standalone tasks or tasks created as part of a service. Each task definition revision may only have one volume configured at launch in the volume configuration.</summary>
    [JsonPropertyName("configureAtLaunch")]
    public bool? ConfigureAtLaunch { get; set; }

    /// <summary>Configuration block to configure a docker volume. Detailed below.</summary>
    [JsonPropertyName("dockerVolumeConfiguration")]
    public V1beta2TaskDefinitionSpecInitProviderVolumeDockerVolumeConfiguration? DockerVolumeConfiguration { get; set; }

    /// <summary>Configuration block for an EFS volume. Detailed below.</summary>
    [JsonPropertyName("efsVolumeConfiguration")]
    public V1beta2TaskDefinitionSpecInitProviderVolumeEfsVolumeConfiguration? EfsVolumeConfiguration { get; set; }

    /// <summary>Configuration block for an FSX Windows File Server volume. Detailed below.</summary>
    [JsonPropertyName("fsxWindowsFileServerVolumeConfiguration")]
    public V1beta2TaskDefinitionSpecInitProviderVolumeFsxWindowsFileServerVolumeConfiguration? FsxWindowsFileServerVolumeConfiguration { get; set; }

    /// <summary>Path on the host container instance that is presented to the container. If not set, ECS will create a nonpersistent data volume that starts empty and is deleted after the task has finished.</summary>
    [JsonPropertyName("hostPath")]
    public string? HostPath { get; set; }

    /// <summary>
    /// Name of the volume. This name is referenced in the sourceVolume
    /// parameter of container definition in the mountPoints section.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
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
public partial class V1beta2TaskDefinitionSpecInitProvider
{
    /// <summary>A list of valid container definitions provided as a single valid JSON document. Please note that you should only provide values that are part of the container definition document. For a detailed description of what parameters are available, see the Task Definition Parameters section from the official Developer Guide.</summary>
    [JsonPropertyName("containerDefinitions")]
    public string? ContainerDefinitions { get; set; }

    /// <summary>Number of cpu units used by the task. If the requires_compatibilities is FARGATE this field is required.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Enables fault injection and allows for fault injection requests to be accepted from the task&apos;s containers. Default is false.</summary>
    [JsonPropertyName("enableFaultInjection")]
    public bool? EnableFaultInjection { get; set; }

    /// <summary>The amount of ephemeral storage to allocate for the task. This parameter is used to expand the total amount of ephemeral storage available, beyond the default amount, for tasks hosted on AWS Fargate. See Ephemeral Storage.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public V1beta2TaskDefinitionSpecInitProviderEphemeralStorage? EphemeralStorage { get; set; }

    /// <summary>ARN of the task execution role that the Amazon ECS container agent and the Docker daemon can assume.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta2TaskDefinitionSpecInitProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>A unique name for your task definition.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>IPC resource namespace to be used for the containers in the task. Valid values: host, task, none.</summary>
    [JsonPropertyName("ipcMode")]
    public string? IpcMode { get; set; }

    /// <summary>Amount (in MiB) of memory used by the task. If the requires_compatibilities is FARGATE this field is required.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>Docker networking mode to use for the containers in the task. Valid values: awsvpc, bridge, host, and none.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>Process namespace to use for the containers in the task. Valid values: host, task`.</summary>
    [JsonPropertyName("pidMode")]
    public string? PidMode { get; set; }

    /// <summary>Configuration block for rules that are taken into consideration during task placement. Maximum number of placement_constraints is 10. Detailed below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta2TaskDefinitionSpecInitProviderPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>Configuration block for the App Mesh proxy. Detailed below.</summary>
    [JsonPropertyName("proxyConfiguration")]
    public V1beta2TaskDefinitionSpecInitProviderProxyConfiguration? ProxyConfiguration { get; set; }

    /// <summary>Set of launch types required by the task. Valid values: EC2, EXTERNAL, FARGATE, MANAGED_INSTANCES.</summary>
    [JsonPropertyName("requiresCompatibilities")]
    public IList<string>? RequiresCompatibilities { get; set; }

    /// <summary>Configuration block for runtime_platform that containers in your task may use.</summary>
    [JsonPropertyName("runtimePlatform")]
    public V1beta2TaskDefinitionSpecInitProviderRuntimePlatform? RuntimePlatform { get; set; }

    /// <summary>Whether to retain the old revision when the resource is destroyed or replacement is necessary. Default is false.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ARN of IAM role that allows your Amazon ECS container task to make calls to other AWS services.</summary>
    [JsonPropertyName("taskRoleArn")]
    public string? TaskRoleArn { get; set; }

    /// <summary>Whether should track latest ACTIVE task definition on AWS or the one created with the resource stored in state. Default is false. Useful in the event the task definition is modified outside of this resource.</summary>
    [JsonPropertyName("trackLatest")]
    public bool? TrackLatest { get; set; }

    /// <summary>Repeatable configuration block for volumes that containers in your task may use. Detailed below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta2TaskDefinitionSpecInitProviderVolume>? Volume { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskDefinitionSpecManagementPoliciesEnum>))]
public enum V1beta2TaskDefinitionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskDefinitionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2TaskDefinitionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2TaskDefinitionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2TaskDefinitionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2TaskDefinitionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2TaskDefinitionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2TaskDefinitionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>TaskDefinitionSpec defines the desired state of TaskDefinition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionSpec
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
    public V1beta2TaskDefinitionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2TaskDefinitionSpecForProvider ForProvider { get; set; }

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
    public V1beta2TaskDefinitionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2TaskDefinitionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2TaskDefinitionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2TaskDefinitionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The amount of ephemeral storage to allocate for the task. This parameter is used to expand the total amount of ephemeral storage available, beyond the default amount, for tasks hosted on AWS Fargate. See Ephemeral Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatusAtProviderEphemeralStorage
{
    /// <summary>The total amount, in GiB, of ephemeral storage to set for the task. The minimum supported value is 21 GiB and the maximum supported value is 200 GiB.</summary>
    [JsonPropertyName("sizeInGib")]
    public double? SizeInGib { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatusAtProviderPlacementConstraints
{
    /// <summary>Cluster Query Language expression to apply to the constraint. For more information, see Cluster Query Language in the Amazon EC2 Container Service Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Type of constraint. Use memberOf to restrict selection to a group of valid candidates. Note that distinctInstance is not supported in task definitions.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block for the App Mesh proxy. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatusAtProviderProxyConfiguration
{
    /// <summary>Name of the container that will serve as the App Mesh proxy.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Set of network configuration parameters to provide the Container Network Interface (CNI) plugin, specified a key-value mapping.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Proxy type. The default value is APPMESH. The only supported value is APPMESH.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block for runtime_platform that containers in your task may use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatusAtProviderRuntimePlatform
{
    /// <summary>Must be set to either X86_64 or ARM64; see cpu architecture</summary>
    [JsonPropertyName("cpuArchitecture")]
    public string? CpuArchitecture { get; set; }

    /// <summary>If the requires_compatibilities is FARGATE this field is required; must be set to a valid option from the operating system family in the runtime platform setting</summary>
    [JsonPropertyName("operatingSystemFamily")]
    public string? OperatingSystemFamily { get; set; }
}

/// <summary>Configuration block to configure a docker volume. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatusAtProviderVolumeDockerVolumeConfiguration
{
    /// <summary>If this value is true, the Docker volume is created if it does not already exist. Note: This field is only used if the scope is shared.</summary>
    [JsonPropertyName("autoprovision")]
    public bool? Autoprovision { get; set; }

    /// <summary>Docker volume driver to use. The driver value must match the driver name provided by Docker because it is used for task placement.</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>Map of Docker driver specific options.</summary>
    [JsonPropertyName("driverOpts")]
    public IDictionary<string, string>? DriverOpts { get; set; }

    /// <summary>Map of custom metadata to add to your Docker volume.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Scope for the Docker volume, which determines its lifecycle, either task or shared.  Docker volumes that are scoped to a task are automatically provisioned when the task starts and destroyed when the task stops. Docker volumes that are scoped as shared persist after the task stops.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Configuration block for authorization for the Amazon EFS file system. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatusAtProviderVolumeEfsVolumeConfigurationAuthorizationConfig
{
    /// <summary>Access point ID to use. If an access point is specified, the root directory value will be relative to the directory set for the access point. If specified, transit encryption must be enabled in the EFSVolumeConfiguration.</summary>
    [JsonPropertyName("accessPointId")]
    public string? AccessPointId { get; set; }

    /// <summary>Whether or not to use the Amazon ECS task IAM role defined in a task definition when mounting the Amazon EFS file system. If enabled, transit encryption must be enabled in the EFSVolumeConfiguration. Valid values: ENABLED, DISABLED. If this parameter is omitted, the default value of DISABLED is used.</summary>
    [JsonPropertyName("iam")]
    public string? Iam { get; set; }
}

/// <summary>Configuration block for an EFS volume. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatusAtProviderVolumeEfsVolumeConfiguration
{
    /// <summary>Configuration block for authorization for the Amazon EFS file system. Detailed below.</summary>
    [JsonPropertyName("authorizationConfig")]
    public V1beta2TaskDefinitionStatusAtProviderVolumeEfsVolumeConfigurationAuthorizationConfig? AuthorizationConfig { get; set; }

    /// <summary>ID of the EFS File System.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>Directory within the Amazon EFS file system to mount as the root directory inside the host. If this parameter is omitted, the root of the Amazon EFS volume will be used. Specifying / will have the same effect as omitting this parameter. This argument is ignored when using authorization_config.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }

    /// <summary>Whether or not to enable encryption for Amazon EFS data in transit between the Amazon ECS host and the Amazon EFS server. Transit encryption must be enabled if Amazon EFS IAM authorization is used. Valid values: ENABLED, DISABLED. If this parameter is omitted, the default value of DISABLED is used.</summary>
    [JsonPropertyName("transitEncryption")]
    public string? TransitEncryption { get; set; }

    /// <summary>Port to use for transit encryption. If you do not specify a transit encryption port, it will use the port selection strategy that the Amazon EFS mount helper uses.</summary>
    [JsonPropertyName("transitEncryptionPort")]
    public double? TransitEncryptionPort { get; set; }
}

/// <summary>Configuration block for authorization for the Amazon FSx for Windows File Server file system detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatusAtProviderVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig
{
    /// <summary>The authorization credential option to use. The authorization credential options can be provided using either the Amazon Resource Name (ARN) of an AWS Secrets Manager secret or AWS Systems Manager Parameter Store parameter. The ARNs refer to the stored credentials.</summary>
    [JsonPropertyName("credentialsParameter")]
    public string? CredentialsParameter { get; set; }

    /// <summary>A fully qualified domain name hosted by an AWS Directory Service Managed Microsoft AD (Active Directory) or self-hosted AD on Amazon EC2.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}

/// <summary>Configuration block for an FSX Windows File Server volume. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatusAtProviderVolumeFsxWindowsFileServerVolumeConfiguration
{
    /// <summary>Configuration block for authorization for the Amazon FSx for Windows File Server file system detailed below.</summary>
    [JsonPropertyName("authorizationConfig")]
    public V1beta2TaskDefinitionStatusAtProviderVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig? AuthorizationConfig { get; set; }

    /// <summary>The Amazon FSx for Windows File Server file system ID to use.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The directory within the Amazon FSx for Windows File Server file system to mount as the root directory inside the host.</summary>
    [JsonPropertyName("rootDirectory")]
    public string? RootDirectory { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatusAtProviderVolume
{
    /// <summary>Whether the volume should be configured at launch time. This is used to create Amazon EBS volumes for standalone tasks or tasks created as part of a service. Each task definition revision may only have one volume configured at launch in the volume configuration.</summary>
    [JsonPropertyName("configureAtLaunch")]
    public bool? ConfigureAtLaunch { get; set; }

    /// <summary>Configuration block to configure a docker volume. Detailed below.</summary>
    [JsonPropertyName("dockerVolumeConfiguration")]
    public V1beta2TaskDefinitionStatusAtProviderVolumeDockerVolumeConfiguration? DockerVolumeConfiguration { get; set; }

    /// <summary>Configuration block for an EFS volume. Detailed below.</summary>
    [JsonPropertyName("efsVolumeConfiguration")]
    public V1beta2TaskDefinitionStatusAtProviderVolumeEfsVolumeConfiguration? EfsVolumeConfiguration { get; set; }

    /// <summary>Configuration block for an FSX Windows File Server volume. Detailed below.</summary>
    [JsonPropertyName("fsxWindowsFileServerVolumeConfiguration")]
    public V1beta2TaskDefinitionStatusAtProviderVolumeFsxWindowsFileServerVolumeConfiguration? FsxWindowsFileServerVolumeConfiguration { get; set; }

    /// <summary>Path on the host container instance that is presented to the container. If not set, ECS will create a nonpersistent data volume that starts empty and is deleted after the task has finished.</summary>
    [JsonPropertyName("hostPath")]
    public string? HostPath { get; set; }

    /// <summary>
    /// Name of the volume. This name is referenced in the sourceVolume
    /// parameter of container definition in the mountPoints section.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatusAtProvider
{
    /// <summary>Full ARN of the Task Definition (including both family and revision).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN of the Task Definition with the trailing revision removed. This may be useful for situations where the latest task definition is always desired. If a revision isn&apos;t specified, the latest ACTIVE revision is used. See the AWS documentation for details.</summary>
    [JsonPropertyName("arnWithoutRevision")]
    public string? ArnWithoutRevision { get; set; }

    /// <summary>A list of valid container definitions provided as a single valid JSON document. Please note that you should only provide values that are part of the container definition document. For a detailed description of what parameters are available, see the Task Definition Parameters section from the official Developer Guide.</summary>
    [JsonPropertyName("containerDefinitions")]
    public string? ContainerDefinitions { get; set; }

    /// <summary>Number of cpu units used by the task. If the requires_compatibilities is FARGATE this field is required.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Enables fault injection and allows for fault injection requests to be accepted from the task&apos;s containers. Default is false.</summary>
    [JsonPropertyName("enableFaultInjection")]
    public bool? EnableFaultInjection { get; set; }

    /// <summary>The amount of ephemeral storage to allocate for the task. This parameter is used to expand the total amount of ephemeral storage available, beyond the default amount, for tasks hosted on AWS Fargate. See Ephemeral Storage.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public V1beta2TaskDefinitionStatusAtProviderEphemeralStorage? EphemeralStorage { get; set; }

    /// <summary>ARN of the task execution role that the Amazon ECS container agent and the Docker daemon can assume.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>A unique name for your task definition.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IPC resource namespace to be used for the containers in the task. Valid values: host, task, none.</summary>
    [JsonPropertyName("ipcMode")]
    public string? IpcMode { get; set; }

    /// <summary>Amount (in MiB) of memory used by the task. If the requires_compatibilities is FARGATE this field is required.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>Docker networking mode to use for the containers in the task. Valid values: awsvpc, bridge, host, and none.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>Process namespace to use for the containers in the task. Valid values: host, task`.</summary>
    [JsonPropertyName("pidMode")]
    public string? PidMode { get; set; }

    /// <summary>Configuration block for rules that are taken into consideration during task placement. Maximum number of placement_constraints is 10. Detailed below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta2TaskDefinitionStatusAtProviderPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>Configuration block for the App Mesh proxy. Detailed below.</summary>
    [JsonPropertyName("proxyConfiguration")]
    public V1beta2TaskDefinitionStatusAtProviderProxyConfiguration? ProxyConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Set of launch types required by the task. Valid values: EC2, EXTERNAL, FARGATE, MANAGED_INSTANCES.</summary>
    [JsonPropertyName("requiresCompatibilities")]
    public IList<string>? RequiresCompatibilities { get; set; }

    /// <summary>Revision of the task in a particular family.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }

    /// <summary>Configuration block for runtime_platform that containers in your task may use.</summary>
    [JsonPropertyName("runtimePlatform")]
    public V1beta2TaskDefinitionStatusAtProviderRuntimePlatform? RuntimePlatform { get; set; }

    /// <summary>Whether to retain the old revision when the resource is destroyed or replacement is necessary. Default is false.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>ARN of IAM role that allows your Amazon ECS container task to make calls to other AWS services.</summary>
    [JsonPropertyName("taskRoleArn")]
    public string? TaskRoleArn { get; set; }

    /// <summary>Whether should track latest ACTIVE task definition on AWS or the one created with the resource stored in state. Default is false. Useful in the event the task definition is modified outside of this resource.</summary>
    [JsonPropertyName("trackLatest")]
    public bool? TrackLatest { get; set; }

    /// <summary>Repeatable configuration block for volumes that containers in your task may use. Detailed below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta2TaskDefinitionStatusAtProviderVolume>? Volume { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatusConditions
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

/// <summary>TaskDefinitionStatus defines the observed state of TaskDefinition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2TaskDefinitionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2TaskDefinitionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2TaskDefinitionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TaskDefinition is the Schema for the TaskDefinitions API. Manages a revision of an ECS task definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2TaskDefinition : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2TaskDefinitionSpec>, IStatus<V1beta2TaskDefinitionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "TaskDefinition";
    public const string KubeGroup = "ecs.aws.upbound.io";
    public const string KubePluralName = "taskdefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TaskDefinition";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TaskDefinitionSpec defines the desired state of TaskDefinition</summary>
    [JsonPropertyName("spec")]
    public required V1beta2TaskDefinitionSpec Spec { get; set; }

    /// <summary>TaskDefinitionStatus defines the observed state of TaskDefinition.</summary>
    [JsonPropertyName("status")]
    public V1beta2TaskDefinitionStatus? Status { get; set; }
}