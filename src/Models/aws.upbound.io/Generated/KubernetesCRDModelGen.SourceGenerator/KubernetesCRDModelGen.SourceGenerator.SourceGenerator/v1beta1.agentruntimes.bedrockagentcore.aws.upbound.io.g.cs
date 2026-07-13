#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bedrockagentcore.aws.upbound.io;
/// <summary>AgentRuntime is the Schema for the AgentRuntimes API. Manages an AWS Bedrock AgentCore Agent Runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AgentRuntimeList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AgentRuntime>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AgentRuntimeList";
    public const string KubeGroup = "bedrockagentcore.aws.upbound.io";
    public const string KubePluralName = "agentruntimes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AgentRuntimeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AgentRuntime objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AgentRuntime> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecDeletionPolicyEnum>))]
public enum V1beta1AgentRuntimeSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configuration block for the Amazon S3 object that contains the source code for the agent runtime. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifactCodeConfigurationCodeS3
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Key of the object containing the ZIP file of the source code for the agent runtime in the Amazon S3 bucket.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Version ID of the Amazon S3 object. If not specified, the latest version of the object is used.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary>Configuration block for the source code location and configuration details. See code below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifactCodeConfigurationCode
{
    /// <summary>Configuration block for the Amazon S3 object that contains the source code for the agent runtime. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifactCodeConfigurationCodeS3? S3 { get; set; }
}

/// <summary>Code configuration block for the agent runtime artifact, including the source code location and execution settings. Exactly one of code_configuration or container_configuration must be specified. See code_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifactCodeConfiguration
{
    /// <summary>Configuration block for the source code location and configuration details. See code below.</summary>
    [JsonPropertyName("code")]
    public V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifactCodeConfigurationCode? Code { get; set; }

    /// <summary>Array specifying the entry point for code execution, indicating the function or method to invoke when the code runs. The array must contain 1 or 2 elements. Examples: [&quot;main.py&quot;], [&quot;opentelemetry-instrument&quot;, &quot;main.py&quot;].</summary>
    [JsonPropertyName("entryPoint")]
    public IList<string>? EntryPoint { get; set; }

    /// <summary>Runtime environment used to execute the code. Valid values: PYTHON_3_10, PYTHON_3_11, PYTHON_3_12, PYTHON_3_13.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }
}

/// <summary>Container configuration block for the agent artifact. Exactly one of code_configuration or container_configuration must be specified. See container_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifactContainerConfiguration
{
    /// <summary>URI of the container image in Amazon ECR.</summary>
    [JsonPropertyName("containerUri")]
    public string? ContainerUri { get; set; }
}

/// <summary>Container artifact configuration. See agent_runtime_artifact below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifact
{
    /// <summary>Code configuration block for the agent runtime artifact, including the source code location and execution settings. Exactly one of code_configuration or container_configuration must be specified. See code_configuration below.</summary>
    [JsonPropertyName("codeConfiguration")]
    public V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifactCodeConfiguration? CodeConfiguration { get; set; }

    /// <summary>Container configuration block for the agent artifact. Exactly one of code_configuration or container_configuration must be specified. See container_configuration below.</summary>
    [JsonPropertyName("containerConfiguration")]
    public V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifactContainerConfiguration? ContainerConfiguration { get; set; }
}

/// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizer
{
    /// <summary>Set of allowed audience values for JWT token validation.</summary>
    [JsonPropertyName("allowedAudience")]
    public IList<string>? AllowedAudience { get; set; }

    /// <summary>Set of allowed client IDs for JWT token validation.</summary>
    [JsonPropertyName("allowedClients")]
    public IList<string>? AllowedClients { get; set; }

    /// <summary>URL used to fetch OpenID Connect configuration or authorization server metadata. Must end with .well-known/openid-configuration.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Authorization configuration for authenticating incoming requests. See authorizer_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfiguration
{
    /// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
    [JsonPropertyName("customJwtAuthorizer")]
    public V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizer? CustomJwtAuthorizer { get; set; }
}

/// <summary>Runtime session and resource lifecycle configuration for the agent runtime. See lifecycle_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderLifecycleConfiguration
{
    /// <summary>Timeout in seconds for idle runtime sessions.</summary>
    [JsonPropertyName("idleRuntimeSessionTimeout")]
    public double? IdleRuntimeSessionTimeout { get; set; }

    /// <summary>Maximum lifetime for the instance in seconds.</summary>
    [JsonPropertyName("maxLifetime")]
    public double? MaxLifetime { get; set; }
}

/// <summary>Network mode configuration. See network_mode_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderNetworkConfigurationNetworkModeConfig
{
    /// <summary>Security groups associated with the VPC configuration.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Subnets associated with the VPC configuration.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>Network configuration for the agent runtime. See network_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderNetworkConfiguration
{
    /// <summary>Network mode for the agent runtime. Valid values: PUBLIC, VPC.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>Network mode configuration. See network_mode_config below.</summary>
    [JsonPropertyName("networkModeConfig")]
    public V1beta1AgentRuntimeSpecForProviderNetworkConfigurationNetworkModeConfig? NetworkModeConfig { get; set; }
}

/// <summary>Protocol configuration for the agent runtime. See protocol_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderProtocolConfiguration
{
    /// <summary>Server protocol for the agent runtime. Valid values: HTTP, MCP, A2A.</summary>
    [JsonPropertyName("serverProtocol")]
    public string? ServerProtocol { get; set; }
}

/// <summary>Configuration for HTTP request headers that will be passed through to the runtime. See request_header_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderRequestHeaderConfiguration
{
    /// <summary>A list of HTTP request headers that are allowed to be passed through to the runtime.</summary>
    [JsonPropertyName("requestHeaderAllowlist")]
    public IList<string>? RequestHeaderAllowlist { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecForProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecForProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentRuntimeSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecForProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecForProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderRoleArnSelector
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
    public V1beta1AgentRuntimeSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProvider
{
    /// <summary>Container artifact configuration. See agent_runtime_artifact below.</summary>
    [JsonPropertyName("agentRuntimeArtifact")]
    public V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifact? AgentRuntimeArtifact { get; set; }

    /// <summary>Name of the agent runtime.</summary>
    [JsonPropertyName("agentRuntimeName")]
    public string? AgentRuntimeName { get; set; }

    /// <summary>Authorization configuration for authenticating incoming requests. See authorizer_configuration below.</summary>
    [JsonPropertyName("authorizerConfiguration")]
    public V1beta1AgentRuntimeSpecForProviderAuthorizerConfiguration? AuthorizerConfiguration { get; set; }

    /// <summary>Description of the agent runtime.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Map of environment variables to pass to the container.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Runtime session and resource lifecycle configuration for the agent runtime. See lifecycle_configuration below.</summary>
    [JsonPropertyName("lifecycleConfiguration")]
    public V1beta1AgentRuntimeSpecForProviderLifecycleConfiguration? LifecycleConfiguration { get; set; }

    /// <summary>Network configuration for the agent runtime. See network_configuration below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta1AgentRuntimeSpecForProviderNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>Protocol configuration for the agent runtime. See protocol_configuration below.</summary>
    [JsonPropertyName("protocolConfiguration")]
    public V1beta1AgentRuntimeSpecForProviderProtocolConfiguration? ProtocolConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration for HTTP request headers that will be passed through to the runtime. See request_header_configuration below.</summary>
    [JsonPropertyName("requestHeaderConfiguration")]
    public V1beta1AgentRuntimeSpecForProviderRequestHeaderConfiguration? RequestHeaderConfiguration { get; set; }

    /// <summary>ARN of the IAM role that the agent runtime assumes to access AWS services.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1AgentRuntimeSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1AgentRuntimeSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Configuration block for the Amazon S3 object that contains the source code for the agent runtime. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifactCodeConfigurationCodeS3
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Key of the object containing the ZIP file of the source code for the agent runtime in the Amazon S3 bucket.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Version ID of the Amazon S3 object. If not specified, the latest version of the object is used.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary>Configuration block for the source code location and configuration details. See code below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifactCodeConfigurationCode
{
    /// <summary>Configuration block for the Amazon S3 object that contains the source code for the agent runtime. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifactCodeConfigurationCodeS3? S3 { get; set; }
}

/// <summary>Code configuration block for the agent runtime artifact, including the source code location and execution settings. Exactly one of code_configuration or container_configuration must be specified. See code_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifactCodeConfiguration
{
    /// <summary>Configuration block for the source code location and configuration details. See code below.</summary>
    [JsonPropertyName("code")]
    public V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifactCodeConfigurationCode? Code { get; set; }

    /// <summary>Array specifying the entry point for code execution, indicating the function or method to invoke when the code runs. The array must contain 1 or 2 elements. Examples: [&quot;main.py&quot;], [&quot;opentelemetry-instrument&quot;, &quot;main.py&quot;].</summary>
    [JsonPropertyName("entryPoint")]
    public IList<string>? EntryPoint { get; set; }

    /// <summary>Runtime environment used to execute the code. Valid values: PYTHON_3_10, PYTHON_3_11, PYTHON_3_12, PYTHON_3_13.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }
}

/// <summary>Container configuration block for the agent artifact. Exactly one of code_configuration or container_configuration must be specified. See container_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifactContainerConfiguration
{
    /// <summary>URI of the container image in Amazon ECR.</summary>
    [JsonPropertyName("containerUri")]
    public string? ContainerUri { get; set; }
}

/// <summary>Container artifact configuration. See agent_runtime_artifact below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifact
{
    /// <summary>Code configuration block for the agent runtime artifact, including the source code location and execution settings. Exactly one of code_configuration or container_configuration must be specified. See code_configuration below.</summary>
    [JsonPropertyName("codeConfiguration")]
    public V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifactCodeConfiguration? CodeConfiguration { get; set; }

    /// <summary>Container configuration block for the agent artifact. Exactly one of code_configuration or container_configuration must be specified. See container_configuration below.</summary>
    [JsonPropertyName("containerConfiguration")]
    public V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifactContainerConfiguration? ContainerConfiguration { get; set; }
}

/// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizer
{
    /// <summary>Set of allowed audience values for JWT token validation.</summary>
    [JsonPropertyName("allowedAudience")]
    public IList<string>? AllowedAudience { get; set; }

    /// <summary>Set of allowed client IDs for JWT token validation.</summary>
    [JsonPropertyName("allowedClients")]
    public IList<string>? AllowedClients { get; set; }

    /// <summary>URL used to fetch OpenID Connect configuration or authorization server metadata. Must end with .well-known/openid-configuration.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Authorization configuration for authenticating incoming requests. See authorizer_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfiguration
{
    /// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
    [JsonPropertyName("customJwtAuthorizer")]
    public V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizer? CustomJwtAuthorizer { get; set; }
}

/// <summary>Runtime session and resource lifecycle configuration for the agent runtime. See lifecycle_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderLifecycleConfiguration
{
    /// <summary>Timeout in seconds for idle runtime sessions.</summary>
    [JsonPropertyName("idleRuntimeSessionTimeout")]
    public double? IdleRuntimeSessionTimeout { get; set; }

    /// <summary>Maximum lifetime for the instance in seconds.</summary>
    [JsonPropertyName("maxLifetime")]
    public double? MaxLifetime { get; set; }
}

/// <summary>Network mode configuration. See network_mode_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderNetworkConfigurationNetworkModeConfig
{
    /// <summary>Security groups associated with the VPC configuration.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Subnets associated with the VPC configuration.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>Network configuration for the agent runtime. See network_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderNetworkConfiguration
{
    /// <summary>Network mode for the agent runtime. Valid values: PUBLIC, VPC.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>Network mode configuration. See network_mode_config below.</summary>
    [JsonPropertyName("networkModeConfig")]
    public V1beta1AgentRuntimeSpecInitProviderNetworkConfigurationNetworkModeConfig? NetworkModeConfig { get; set; }
}

/// <summary>Protocol configuration for the agent runtime. See protocol_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderProtocolConfiguration
{
    /// <summary>Server protocol for the agent runtime. Valid values: HTTP, MCP, A2A.</summary>
    [JsonPropertyName("serverProtocol")]
    public string? ServerProtocol { get; set; }
}

/// <summary>Configuration for HTTP request headers that will be passed through to the runtime. See request_header_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderRequestHeaderConfiguration
{
    /// <summary>A list of HTTP request headers that are allowed to be passed through to the runtime.</summary>
    [JsonPropertyName("requestHeaderAllowlist")]
    public IList<string>? RequestHeaderAllowlist { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecInitProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecInitProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentRuntimeSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecInitProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecInitProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderRoleArnSelector
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
    public V1beta1AgentRuntimeSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1AgentRuntimeSpecInitProvider
{
    /// <summary>Container artifact configuration. See agent_runtime_artifact below.</summary>
    [JsonPropertyName("agentRuntimeArtifact")]
    public V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifact? AgentRuntimeArtifact { get; set; }

    /// <summary>Name of the agent runtime.</summary>
    [JsonPropertyName("agentRuntimeName")]
    public string? AgentRuntimeName { get; set; }

    /// <summary>Authorization configuration for authenticating incoming requests. See authorizer_configuration below.</summary>
    [JsonPropertyName("authorizerConfiguration")]
    public V1beta1AgentRuntimeSpecInitProviderAuthorizerConfiguration? AuthorizerConfiguration { get; set; }

    /// <summary>Description of the agent runtime.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Map of environment variables to pass to the container.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Runtime session and resource lifecycle configuration for the agent runtime. See lifecycle_configuration below.</summary>
    [JsonPropertyName("lifecycleConfiguration")]
    public V1beta1AgentRuntimeSpecInitProviderLifecycleConfiguration? LifecycleConfiguration { get; set; }

    /// <summary>Network configuration for the agent runtime. See network_configuration below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta1AgentRuntimeSpecInitProviderNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>Protocol configuration for the agent runtime. See protocol_configuration below.</summary>
    [JsonPropertyName("protocolConfiguration")]
    public V1beta1AgentRuntimeSpecInitProviderProtocolConfiguration? ProtocolConfiguration { get; set; }

    /// <summary>Configuration for HTTP request headers that will be passed through to the runtime. See request_header_configuration below.</summary>
    [JsonPropertyName("requestHeaderConfiguration")]
    public V1beta1AgentRuntimeSpecInitProviderRequestHeaderConfiguration? RequestHeaderConfiguration { get; set; }

    /// <summary>ARN of the IAM role that the agent runtime assumes to access AWS services.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1AgentRuntimeSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1AgentRuntimeSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecManagementPoliciesEnum>))]
public enum V1beta1AgentRuntimeSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentRuntimeSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AgentRuntimeSpec defines the desired state of AgentRuntime</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpec
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
    public V1beta1AgentRuntimeSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1AgentRuntimeSpecForProvider ForProvider { get; set; }

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
    public V1beta1AgentRuntimeSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1AgentRuntimeSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AgentRuntimeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AgentRuntimeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block for the Amazon S3 object that contains the source code for the agent runtime. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifactCodeConfigurationCodeS3
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Key of the object containing the ZIP file of the source code for the agent runtime in the Amazon S3 bucket.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Version ID of the Amazon S3 object. If not specified, the latest version of the object is used.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary>Configuration block for the source code location and configuration details. See code below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifactCodeConfigurationCode
{
    /// <summary>Configuration block for the Amazon S3 object that contains the source code for the agent runtime. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifactCodeConfigurationCodeS3? S3 { get; set; }
}

/// <summary>Code configuration block for the agent runtime artifact, including the source code location and execution settings. Exactly one of code_configuration or container_configuration must be specified. See code_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifactCodeConfiguration
{
    /// <summary>Configuration block for the source code location and configuration details. See code below.</summary>
    [JsonPropertyName("code")]
    public V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifactCodeConfigurationCode? Code { get; set; }

    /// <summary>Array specifying the entry point for code execution, indicating the function or method to invoke when the code runs. The array must contain 1 or 2 elements. Examples: [&quot;main.py&quot;], [&quot;opentelemetry-instrument&quot;, &quot;main.py&quot;].</summary>
    [JsonPropertyName("entryPoint")]
    public IList<string>? EntryPoint { get; set; }

    /// <summary>Runtime environment used to execute the code. Valid values: PYTHON_3_10, PYTHON_3_11, PYTHON_3_12, PYTHON_3_13.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }
}

/// <summary>Container configuration block for the agent artifact. Exactly one of code_configuration or container_configuration must be specified. See container_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifactContainerConfiguration
{
    /// <summary>URI of the container image in Amazon ECR.</summary>
    [JsonPropertyName("containerUri")]
    public string? ContainerUri { get; set; }
}

/// <summary>Container artifact configuration. See agent_runtime_artifact below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifact
{
    /// <summary>Code configuration block for the agent runtime artifact, including the source code location and execution settings. Exactly one of code_configuration or container_configuration must be specified. See code_configuration below.</summary>
    [JsonPropertyName("codeConfiguration")]
    public V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifactCodeConfiguration? CodeConfiguration { get; set; }

    /// <summary>Container configuration block for the agent artifact. Exactly one of code_configuration or container_configuration must be specified. See container_configuration below.</summary>
    [JsonPropertyName("containerConfiguration")]
    public V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifactContainerConfiguration? ContainerConfiguration { get; set; }
}

/// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizer
{
    /// <summary>Set of allowed audience values for JWT token validation.</summary>
    [JsonPropertyName("allowedAudience")]
    public IList<string>? AllowedAudience { get; set; }

    /// <summary>Set of allowed client IDs for JWT token validation.</summary>
    [JsonPropertyName("allowedClients")]
    public IList<string>? AllowedClients { get; set; }

    /// <summary>URL used to fetch OpenID Connect configuration or authorization server metadata. Must end with .well-known/openid-configuration.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Authorization configuration for authenticating incoming requests. See authorizer_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfiguration
{
    /// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
    [JsonPropertyName("customJwtAuthorizer")]
    public V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizer? CustomJwtAuthorizer { get; set; }
}

/// <summary>Runtime session and resource lifecycle configuration for the agent runtime. See lifecycle_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderLifecycleConfiguration
{
    /// <summary>Timeout in seconds for idle runtime sessions.</summary>
    [JsonPropertyName("idleRuntimeSessionTimeout")]
    public double? IdleRuntimeSessionTimeout { get; set; }

    /// <summary>Maximum lifetime for the instance in seconds.</summary>
    [JsonPropertyName("maxLifetime")]
    public double? MaxLifetime { get; set; }
}

/// <summary>Network mode configuration. See network_mode_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderNetworkConfigurationNetworkModeConfig
{
    /// <summary>Security groups associated with the VPC configuration.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Subnets associated with the VPC configuration.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>Network configuration for the agent runtime. See network_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderNetworkConfiguration
{
    /// <summary>Network mode for the agent runtime. Valid values: PUBLIC, VPC.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>Network mode configuration. See network_mode_config below.</summary>
    [JsonPropertyName("networkModeConfig")]
    public V1beta1AgentRuntimeStatusAtProviderNetworkConfigurationNetworkModeConfig? NetworkModeConfig { get; set; }
}

/// <summary>Protocol configuration for the agent runtime. See protocol_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderProtocolConfiguration
{
    /// <summary>Server protocol for the agent runtime. Valid values: HTTP, MCP, A2A.</summary>
    [JsonPropertyName("serverProtocol")]
    public string? ServerProtocol { get; set; }
}

/// <summary>Configuration for HTTP request headers that will be passed through to the runtime. See request_header_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderRequestHeaderConfiguration
{
    /// <summary>A list of HTTP request headers that are allowed to be passed through to the runtime.</summary>
    [JsonPropertyName("requestHeaderAllowlist")]
    public IList<string>? RequestHeaderAllowlist { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderWorkloadIdentityDetails
{
    /// <summary>ARN of the workload identity.</summary>
    [JsonPropertyName("workloadIdentityArn")]
    public string? WorkloadIdentityArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProvider
{
    /// <summary>ARN of the Agent Runtime.</summary>
    [JsonPropertyName("agentRuntimeArn")]
    public string? AgentRuntimeArn { get; set; }

    /// <summary>Container artifact configuration. See agent_runtime_artifact below.</summary>
    [JsonPropertyName("agentRuntimeArtifact")]
    public V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifact? AgentRuntimeArtifact { get; set; }

    /// <summary>Unique identifier of the Agent Runtime.</summary>
    [JsonPropertyName("agentRuntimeId")]
    public string? AgentRuntimeId { get; set; }

    /// <summary>Name of the agent runtime.</summary>
    [JsonPropertyName("agentRuntimeName")]
    public string? AgentRuntimeName { get; set; }

    /// <summary>Version of the Agent Runtime.</summary>
    [JsonPropertyName("agentRuntimeVersion")]
    public string? AgentRuntimeVersion { get; set; }

    /// <summary>Authorization configuration for authenticating incoming requests. See authorizer_configuration below.</summary>
    [JsonPropertyName("authorizerConfiguration")]
    public V1beta1AgentRuntimeStatusAtProviderAuthorizerConfiguration? AuthorizerConfiguration { get; set; }

    /// <summary>Description of the agent runtime.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Map of environment variables to pass to the container.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Runtime session and resource lifecycle configuration for the agent runtime. See lifecycle_configuration below.</summary>
    [JsonPropertyName("lifecycleConfiguration")]
    public V1beta1AgentRuntimeStatusAtProviderLifecycleConfiguration? LifecycleConfiguration { get; set; }

    /// <summary>Network configuration for the agent runtime. See network_configuration below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta1AgentRuntimeStatusAtProviderNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>Protocol configuration for the agent runtime. See protocol_configuration below.</summary>
    [JsonPropertyName("protocolConfiguration")]
    public V1beta1AgentRuntimeStatusAtProviderProtocolConfiguration? ProtocolConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration for HTTP request headers that will be passed through to the runtime. See request_header_configuration below.</summary>
    [JsonPropertyName("requestHeaderConfiguration")]
    public V1beta1AgentRuntimeStatusAtProviderRequestHeaderConfiguration? RequestHeaderConfiguration { get; set; }

    /// <summary>ARN of the IAM role that the agent runtime assumes to access AWS services.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Workload identity details for the agent runtime. See workload_identity_details below.</summary>
    [JsonPropertyName("workloadIdentityDetails")]
    public IList<V1beta1AgentRuntimeStatusAtProviderWorkloadIdentityDetails>? WorkloadIdentityDetails { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusConditions
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

/// <summary>AgentRuntimeStatus defines the observed state of AgentRuntime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1AgentRuntimeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AgentRuntimeStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AgentRuntime is the Schema for the AgentRuntimes API. Manages an AWS Bedrock AgentCore Agent Runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AgentRuntime : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AgentRuntimeSpec>, IStatus<V1beta1AgentRuntimeStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AgentRuntime";
    public const string KubeGroup = "bedrockagentcore.aws.upbound.io";
    public const string KubePluralName = "agentruntimes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AgentRuntime";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AgentRuntimeSpec defines the desired state of AgentRuntime</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AgentRuntimeSpec Spec { get; set; }

    /// <summary>AgentRuntimeStatus defines the observed state of AgentRuntime.</summary>
    [JsonPropertyName("status")]
    public V1beta1AgentRuntimeStatus? Status { get; set; }
}