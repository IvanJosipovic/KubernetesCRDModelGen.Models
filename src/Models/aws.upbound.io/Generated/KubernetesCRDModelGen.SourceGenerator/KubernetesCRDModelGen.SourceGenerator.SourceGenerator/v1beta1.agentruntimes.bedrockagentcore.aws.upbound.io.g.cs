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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecDeletionPolicyEnum>))]
public enum V1beta1AgentRuntimeSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configuration block for the Amazon S3 object that contains the source code for the agent runtime. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifactCodeConfigurationCode
{
    /// <summary>Configuration block for the Amazon S3 object that contains the source code for the agent runtime. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifactCodeConfigurationCodeS3? S3 { get; set; }
}

/// <summary>Code configuration block for the agent runtime artifact, including the source code location and execution settings. Exactly one of code_configuration or container_configuration must be specified. See code_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAgentRuntimeArtifactContainerConfiguration
{
    /// <summary>URI of the container image in Amazon ECR.</summary>
    [JsonPropertyName("containerUri")]
    public string? ContainerUri { get; set; }
}

/// <summary>Container artifact configuration. See agent_runtime_artifact below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment
{
    /// <summary>ARN of the hosting environment.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>Configuration restricting which workloads may use this authorizer. See allowed_workload_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration
{
    /// <summary>Hosting environments allowed to use the authorizer. Between 1 and 10 entries. See hosting_environment below.</summary>
    [JsonPropertyName("hostingEnvironment")]
    public IList<V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment>? HostingEnvironment { get; set; }

    /// <summary>List of workload identity names allowed to use the authorizer. Between 1 and 10 entries.</summary>
    [JsonPropertyName("workloadIdentities")]
    public IList<string>? WorkloadIdentities { get; set; }
}

/// <summary>Value or values to match for. See claim_match_value below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue
{
    /// <summary>String value to match for. Must be specified when claim_match_operator is EQUALS or CONTAINS. Exactly one of match_value_string or match_value_string_list must be specified.</summary>
    [JsonPropertyName("matchValueString")]
    public string? MatchValueString { get; set; }

    /// <summary>List of strings to check for a match. Must be specified when claim_match_operator is CONTAINS_ANY. Exactly one of match_value_string or match_value_string_list must be specified.</summary>
    [JsonPropertyName("matchValueStringList")]
    public IList<string>? MatchValueStringList { get; set; }
}

/// <summary>Configuration block to define the value or values to match for and the relationship of the match. See authorizing_claim_match_value below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
{
    /// <summary>Relationship between the claim field value and the value or values to match for. Valid values are EQUALS, CONTAINS, and CONTAINS_ANY. EQUALS can be used only when inbound_token_claim_value_type is STRING. CONTAINS or CONTAINS_ANY can be used only when inbound_token_claim_value_type is STRING_ARRAY.</summary>
    [JsonPropertyName("claimMatchOperator")]
    public string? ClaimMatchOperator { get; set; }

    /// <summary>Value or values to match for. See claim_match_value below.</summary>
    [JsonPropertyName("claimMatchValue")]
    public V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue? ClaimMatchValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
{
    /// <summary>Configuration block to define the value or values to match for and the relationship of the match. See authorizing_claim_match_value below.</summary>
    [JsonPropertyName("authorizingClaimMatchValue")]
    public V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue? AuthorizingClaimMatchValue { get; set; }

    /// <summary>Name of the custom claim field to check.</summary>
    [JsonPropertyName("inboundTokenClaimName")]
    public string? InboundTokenClaimName { get; set; }

    /// <summary>Data type of the claim value to check for. Valid values are STRING and STRING_ARRAY.</summary>
    [JsonPropertyName("inboundTokenClaimValueType")]
    public string? InboundTokenClaimValueType { get; set; }
}

/// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource
{
    /// <summary>IP address type for the endpoint. Valid values are IPV4 and IPV6.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain for the endpoint.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>IDs of the security groups for the endpoint.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>IDs of the subnets for the endpoint.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Identifier of the VPC for the endpoint.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint used to reach the authorization server. See private_endpoint below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint
{
    /// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

/// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointManagedVpcResource
{
    /// <summary>IP address type for the endpoint. Valid values are IPV4 and IPV6.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain for the endpoint.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>IDs of the security groups for the endpoint.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>IDs of the subnets for the endpoint.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Identifier of the VPC for the endpoint.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint configuration. See private_endpoint below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpoint
{
    /// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides
{
    /// <summary>Domain the override applies to.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Private endpoint configuration. See private_endpoint below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpoint? PrivateEndpoint { get; set; }
}

/// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizer
{
    /// <summary>Set of allowed audience values for JWT token validation.</summary>
    [JsonPropertyName("allowedAudience")]
    public IList<string>? AllowedAudience { get; set; }

    /// <summary>Set of allowed client IDs for JWT token validation.</summary>
    [JsonPropertyName("allowedClients")]
    public IList<string>? AllowedClients { get; set; }

    /// <summary>Set of scopes that are allowed to access the token.</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }

    /// <summary>Configuration restricting which workloads may use this authorizer. See allowed_workload_configuration below.</summary>
    [JsonPropertyName("allowedWorkloadConfiguration")]
    public V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration? AllowedWorkloadConfiguration { get; set; }

    /// <summary>Repeatable block to define a custom claim validation name, value, and operation. See custom_claim below.</summary>
    [JsonPropertyName("customClaim")]
    public IList<V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaim>? CustomClaim { get; set; }

    /// <summary>URL used to fetch OpenID Connect configuration or authorization server metadata. Must end with .well-known/openid-configuration.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Private endpoint used to reach the authorization server. See private_endpoint below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Overrides for the private endpoints used to reach the authorization server. See private_endpoint_overrides below.</summary>
    [JsonPropertyName("privateEndpointOverrides")]
    public IList<V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides>? PrivateEndpointOverrides { get; set; }
}

/// <summary>Authorization configuration for authenticating incoming requests. See authorizer_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderAuthorizerConfiguration
{
    /// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
    [JsonPropertyName("customJwtAuthorizer")]
    public V1beta1AgentRuntimeSpecForProviderAuthorizerConfigurationCustomJwtAuthorizer? CustomJwtAuthorizer { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessPoint in efs to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessPoint in efs to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelector
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
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Amazon EFS access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See efs_access_point below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPoint
{
    /// <summary>ARN of the Amazon S3 Files access point to mount into the agent runtime.</summary>
    [JsonPropertyName("accessPointArn")]
    public string? AccessPointArn { get; set; }

    /// <summary>Reference to a AccessPoint in efs to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnRef")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnRef? AccessPointArnRef { get; set; }

    /// <summary>Selector for a AccessPoint in efs to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnSelector")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelector? AccessPointArnSelector { get; set; }

    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessPoint in s3control to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessPoint in s3control to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelector
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
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Amazon S3 Files access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See s3_files_access_point below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPoint
{
    /// <summary>ARN of the Amazon S3 Files access point to mount into the agent runtime.</summary>
    [JsonPropertyName("accessPointArn")]
    public string? AccessPointArn { get; set; }

    /// <summary>Reference to a AccessPoint in s3control to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnRef")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRef? AccessPointArnRef { get; set; }

    /// <summary>Selector for a AccessPoint in s3control to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnSelector")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelector? AccessPointArnSelector { get; set; }

    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary>Session storage filesystem providing persistent storage across agent runtime session invocations. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See session_storage below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationSessionStorage
{
    /// <summary>Mount path for the session storage filesystem inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderFilesystemConfiguration
{
    /// <summary>Amazon EFS access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See efs_access_point below.</summary>
    [JsonPropertyName("efsAccessPoint")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationEfsAccessPoint? EfsAccessPoint { get; set; }

    /// <summary>Amazon S3 Files access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See s3_files_access_point below.</summary>
    [JsonPropertyName("s3FilesAccessPoint")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationS3FilesAccessPoint? S3FilesAccessPoint { get; set; }

    /// <summary>Session storage filesystem providing persistent storage across agent runtime session invocations. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See session_storage below.</summary>
    [JsonPropertyName("sessionStorage")]
    public V1beta1AgentRuntimeSpecForProviderFilesystemConfigurationSessionStorage? SessionStorage { get; set; }
}

/// <summary>Runtime session and resource lifecycle configuration for the agent runtime. See lifecycle_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecForProviderProtocolConfiguration
{
    /// <summary>Server protocol for the agent runtime. Valid values: HTTP, MCP, A2A, AGUI.</summary>
    [JsonPropertyName("serverProtocol")]
    public string? ServerProtocol { get; set; }
}

/// <summary>Configuration for HTTP request headers that will be passed through to the runtime. See request_header_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecForProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecForProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

    /// <summary>List of filesystems to mount into the agent runtime. Up to 5 entries are supported. Each entry is one of session storage, Amazon S3 Files access point, or Amazon EFS access point. See filesystem_configuration below.</summary>
    [JsonPropertyName("filesystemConfiguration")]
    public IList<V1beta1AgentRuntimeSpecForProviderFilesystemConfiguration>? FilesystemConfiguration { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifactCodeConfigurationCode
{
    /// <summary>Configuration block for the Amazon S3 object that contains the source code for the agent runtime. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifactCodeConfigurationCodeS3? S3 { get; set; }
}

/// <summary>Code configuration block for the agent runtime artifact, including the source code location and execution settings. Exactly one of code_configuration or container_configuration must be specified. See code_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAgentRuntimeArtifactContainerConfiguration
{
    /// <summary>URI of the container image in Amazon ECR.</summary>
    [JsonPropertyName("containerUri")]
    public string? ContainerUri { get; set; }
}

/// <summary>Container artifact configuration. See agent_runtime_artifact below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment
{
    /// <summary>ARN of the hosting environment.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>Configuration restricting which workloads may use this authorizer. See allowed_workload_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration
{
    /// <summary>Hosting environments allowed to use the authorizer. Between 1 and 10 entries. See hosting_environment below.</summary>
    [JsonPropertyName("hostingEnvironment")]
    public IList<V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment>? HostingEnvironment { get; set; }

    /// <summary>List of workload identity names allowed to use the authorizer. Between 1 and 10 entries.</summary>
    [JsonPropertyName("workloadIdentities")]
    public IList<string>? WorkloadIdentities { get; set; }
}

/// <summary>Value or values to match for. See claim_match_value below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue
{
    /// <summary>String value to match for. Must be specified when claim_match_operator is EQUALS or CONTAINS. Exactly one of match_value_string or match_value_string_list must be specified.</summary>
    [JsonPropertyName("matchValueString")]
    public string? MatchValueString { get; set; }

    /// <summary>List of strings to check for a match. Must be specified when claim_match_operator is CONTAINS_ANY. Exactly one of match_value_string or match_value_string_list must be specified.</summary>
    [JsonPropertyName("matchValueStringList")]
    public IList<string>? MatchValueStringList { get; set; }
}

/// <summary>Configuration block to define the value or values to match for and the relationship of the match. See authorizing_claim_match_value below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
{
    /// <summary>Relationship between the claim field value and the value or values to match for. Valid values are EQUALS, CONTAINS, and CONTAINS_ANY. EQUALS can be used only when inbound_token_claim_value_type is STRING. CONTAINS or CONTAINS_ANY can be used only when inbound_token_claim_value_type is STRING_ARRAY.</summary>
    [JsonPropertyName("claimMatchOperator")]
    public string? ClaimMatchOperator { get; set; }

    /// <summary>Value or values to match for. See claim_match_value below.</summary>
    [JsonPropertyName("claimMatchValue")]
    public V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue? ClaimMatchValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
{
    /// <summary>Configuration block to define the value or values to match for and the relationship of the match. See authorizing_claim_match_value below.</summary>
    [JsonPropertyName("authorizingClaimMatchValue")]
    public V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue? AuthorizingClaimMatchValue { get; set; }

    /// <summary>Name of the custom claim field to check.</summary>
    [JsonPropertyName("inboundTokenClaimName")]
    public string? InboundTokenClaimName { get; set; }

    /// <summary>Data type of the claim value to check for. Valid values are STRING and STRING_ARRAY.</summary>
    [JsonPropertyName("inboundTokenClaimValueType")]
    public string? InboundTokenClaimValueType { get; set; }
}

/// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource
{
    /// <summary>IP address type for the endpoint. Valid values are IPV4 and IPV6.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain for the endpoint.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>IDs of the security groups for the endpoint.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>IDs of the subnets for the endpoint.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Identifier of the VPC for the endpoint.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint used to reach the authorization server. See private_endpoint below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint
{
    /// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

/// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointManagedVpcResource
{
    /// <summary>IP address type for the endpoint. Valid values are IPV4 and IPV6.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain for the endpoint.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>IDs of the security groups for the endpoint.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>IDs of the subnets for the endpoint.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Identifier of the VPC for the endpoint.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint configuration. See private_endpoint below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpoint
{
    /// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides
{
    /// <summary>Domain the override applies to.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Private endpoint configuration. See private_endpoint below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpoint? PrivateEndpoint { get; set; }
}

/// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizer
{
    /// <summary>Set of allowed audience values for JWT token validation.</summary>
    [JsonPropertyName("allowedAudience")]
    public IList<string>? AllowedAudience { get; set; }

    /// <summary>Set of allowed client IDs for JWT token validation.</summary>
    [JsonPropertyName("allowedClients")]
    public IList<string>? AllowedClients { get; set; }

    /// <summary>Set of scopes that are allowed to access the token.</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }

    /// <summary>Configuration restricting which workloads may use this authorizer. See allowed_workload_configuration below.</summary>
    [JsonPropertyName("allowedWorkloadConfiguration")]
    public V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration? AllowedWorkloadConfiguration { get; set; }

    /// <summary>Repeatable block to define a custom claim validation name, value, and operation. See custom_claim below.</summary>
    [JsonPropertyName("customClaim")]
    public IList<V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaim>? CustomClaim { get; set; }

    /// <summary>URL used to fetch OpenID Connect configuration or authorization server metadata. Must end with .well-known/openid-configuration.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Private endpoint used to reach the authorization server. See private_endpoint below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Overrides for the private endpoints used to reach the authorization server. See private_endpoint_overrides below.</summary>
    [JsonPropertyName("privateEndpointOverrides")]
    public IList<V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides>? PrivateEndpointOverrides { get; set; }
}

/// <summary>Authorization configuration for authenticating incoming requests. See authorizer_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderAuthorizerConfiguration
{
    /// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
    [JsonPropertyName("customJwtAuthorizer")]
    public V1beta1AgentRuntimeSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizer? CustomJwtAuthorizer { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessPoint in efs to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessPoint in efs to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelector
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
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Amazon EFS access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See efs_access_point below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPoint
{
    /// <summary>ARN of the Amazon S3 Files access point to mount into the agent runtime.</summary>
    [JsonPropertyName("accessPointArn")]
    public string? AccessPointArn { get; set; }

    /// <summary>Reference to a AccessPoint in efs to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnRef")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnRef? AccessPointArnRef { get; set; }

    /// <summary>Selector for a AccessPoint in efs to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnSelector")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPointAccessPointArnSelector? AccessPointArnSelector { get; set; }

    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessPoint in s3control to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolutionEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessPoint in s3control to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelector
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
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Amazon S3 Files access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See s3_files_access_point below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPoint
{
    /// <summary>ARN of the Amazon S3 Files access point to mount into the agent runtime.</summary>
    [JsonPropertyName("accessPointArn")]
    public string? AccessPointArn { get; set; }

    /// <summary>Reference to a AccessPoint in s3control to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnRef")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnRef? AccessPointArnRef { get; set; }

    /// <summary>Selector for a AccessPoint in s3control to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnSelector")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPointAccessPointArnSelector? AccessPointArnSelector { get; set; }

    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary>Session storage filesystem providing persistent storage across agent runtime session invocations. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See session_storage below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationSessionStorage
{
    /// <summary>Mount path for the session storage filesystem inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderFilesystemConfiguration
{
    /// <summary>Amazon EFS access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See efs_access_point below.</summary>
    [JsonPropertyName("efsAccessPoint")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationEfsAccessPoint? EfsAccessPoint { get; set; }

    /// <summary>Amazon S3 Files access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See s3_files_access_point below.</summary>
    [JsonPropertyName("s3FilesAccessPoint")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationS3FilesAccessPoint? S3FilesAccessPoint { get; set; }

    /// <summary>Session storage filesystem providing persistent storage across agent runtime session invocations. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See session_storage below.</summary>
    [JsonPropertyName("sessionStorage")]
    public V1beta1AgentRuntimeSpecInitProviderFilesystemConfigurationSessionStorage? SessionStorage { get; set; }
}

/// <summary>Runtime session and resource lifecycle configuration for the agent runtime. See lifecycle_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeSpecInitProviderProtocolConfiguration
{
    /// <summary>Server protocol for the agent runtime. Valid values: HTTP, MCP, A2A, AGUI.</summary>
    [JsonPropertyName("serverProtocol")]
    public string? ServerProtocol { get; set; }
}

/// <summary>Configuration for HTTP request headers that will be passed through to the runtime. See request_header_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecInitProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecInitProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

    /// <summary>List of filesystems to mount into the agent runtime. Up to 5 entries are supported. Each entry is one of session storage, Amazon S3 Files access point, or Amazon EFS access point. See filesystem_configuration below.</summary>
    [JsonPropertyName("filesystemConfiguration")]
    public IList<V1beta1AgentRuntimeSpecInitProviderFilesystemConfiguration>? FilesystemConfiguration { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentRuntimeSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1AgentRuntimeSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifactCodeConfigurationCode
{
    /// <summary>Configuration block for the Amazon S3 object that contains the source code for the agent runtime. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifactCodeConfigurationCodeS3? S3 { get; set; }
}

/// <summary>Code configuration block for the agent runtime artifact, including the source code location and execution settings. Exactly one of code_configuration or container_configuration must be specified. See code_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAgentRuntimeArtifactContainerConfiguration
{
    /// <summary>URI of the container image in Amazon ECR.</summary>
    [JsonPropertyName("containerUri")]
    public string? ContainerUri { get; set; }
}

/// <summary>Container artifact configuration. See agent_runtime_artifact below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment
{
    /// <summary>ARN of the hosting environment.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>Configuration restricting which workloads may use this authorizer. See allowed_workload_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration
{
    /// <summary>Hosting environments allowed to use the authorizer. Between 1 and 10 entries. See hosting_environment below.</summary>
    [JsonPropertyName("hostingEnvironment")]
    public IList<V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment>? HostingEnvironment { get; set; }

    /// <summary>List of workload identity names allowed to use the authorizer. Between 1 and 10 entries.</summary>
    [JsonPropertyName("workloadIdentities")]
    public IList<string>? WorkloadIdentities { get; set; }
}

/// <summary>Value or values to match for. See claim_match_value below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue
{
    /// <summary>String value to match for. Must be specified when claim_match_operator is EQUALS or CONTAINS. Exactly one of match_value_string or match_value_string_list must be specified.</summary>
    [JsonPropertyName("matchValueString")]
    public string? MatchValueString { get; set; }

    /// <summary>List of strings to check for a match. Must be specified when claim_match_operator is CONTAINS_ANY. Exactly one of match_value_string or match_value_string_list must be specified.</summary>
    [JsonPropertyName("matchValueStringList")]
    public IList<string>? MatchValueStringList { get; set; }
}

/// <summary>Configuration block to define the value or values to match for and the relationship of the match. See authorizing_claim_match_value below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
{
    /// <summary>Relationship between the claim field value and the value or values to match for. Valid values are EQUALS, CONTAINS, and CONTAINS_ANY. EQUALS can be used only when inbound_token_claim_value_type is STRING. CONTAINS or CONTAINS_ANY can be used only when inbound_token_claim_value_type is STRING_ARRAY.</summary>
    [JsonPropertyName("claimMatchOperator")]
    public string? ClaimMatchOperator { get; set; }

    /// <summary>Value or values to match for. See claim_match_value below.</summary>
    [JsonPropertyName("claimMatchValue")]
    public V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue? ClaimMatchValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
{
    /// <summary>Configuration block to define the value or values to match for and the relationship of the match. See authorizing_claim_match_value below.</summary>
    [JsonPropertyName("authorizingClaimMatchValue")]
    public V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue? AuthorizingClaimMatchValue { get; set; }

    /// <summary>Name of the custom claim field to check.</summary>
    [JsonPropertyName("inboundTokenClaimName")]
    public string? InboundTokenClaimName { get; set; }

    /// <summary>Data type of the claim value to check for. Valid values are STRING and STRING_ARRAY.</summary>
    [JsonPropertyName("inboundTokenClaimValueType")]
    public string? InboundTokenClaimValueType { get; set; }
}

/// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource
{
    /// <summary>IP address type for the endpoint. Valid values are IPV4 and IPV6.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain for the endpoint.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>IDs of the security groups for the endpoint.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>IDs of the subnets for the endpoint.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Identifier of the VPC for the endpoint.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint used to reach the authorization server. See private_endpoint below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint
{
    /// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

/// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointManagedVpcResource
{
    /// <summary>IP address type for the endpoint. Valid values are IPV4 and IPV6.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain for the endpoint.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>IDs of the security groups for the endpoint.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>IDs of the subnets for the endpoint.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Identifier of the VPC for the endpoint.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint configuration. See private_endpoint below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpoint
{
    /// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides
{
    /// <summary>Domain the override applies to.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Private endpoint configuration. See private_endpoint below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpoint? PrivateEndpoint { get; set; }
}

/// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizer
{
    /// <summary>Set of allowed audience values for JWT token validation.</summary>
    [JsonPropertyName("allowedAudience")]
    public IList<string>? AllowedAudience { get; set; }

    /// <summary>Set of allowed client IDs for JWT token validation.</summary>
    [JsonPropertyName("allowedClients")]
    public IList<string>? AllowedClients { get; set; }

    /// <summary>Set of scopes that are allowed to access the token.</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }

    /// <summary>Configuration restricting which workloads may use this authorizer. See allowed_workload_configuration below.</summary>
    [JsonPropertyName("allowedWorkloadConfiguration")]
    public V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration? AllowedWorkloadConfiguration { get; set; }

    /// <summary>Repeatable block to define a custom claim validation name, value, and operation. See custom_claim below.</summary>
    [JsonPropertyName("customClaim")]
    public IList<V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaim>? CustomClaim { get; set; }

    /// <summary>URL used to fetch OpenID Connect configuration or authorization server metadata. Must end with .well-known/openid-configuration.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Private endpoint used to reach the authorization server. See private_endpoint below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Overrides for the private endpoints used to reach the authorization server. See private_endpoint_overrides below.</summary>
    [JsonPropertyName("privateEndpointOverrides")]
    public IList<V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides>? PrivateEndpointOverrides { get; set; }
}

/// <summary>Authorization configuration for authenticating incoming requests. See authorizer_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderAuthorizerConfiguration
{
    /// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
    [JsonPropertyName("customJwtAuthorizer")]
    public V1beta1AgentRuntimeStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizer? CustomJwtAuthorizer { get; set; }
}

/// <summary>Amazon EFS access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See efs_access_point below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderFilesystemConfigurationEfsAccessPoint
{
    /// <summary>ARN of the Amazon S3 Files access point to mount into the agent runtime.</summary>
    [JsonPropertyName("accessPointArn")]
    public string? AccessPointArn { get; set; }

    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary>Amazon S3 Files access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See s3_files_access_point below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderFilesystemConfigurationS3FilesAccessPoint
{
    /// <summary>ARN of the Amazon S3 Files access point to mount into the agent runtime.</summary>
    [JsonPropertyName("accessPointArn")]
    public string? AccessPointArn { get; set; }

    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

/// <summary>Session storage filesystem providing persistent storage across agent runtime session invocations. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See session_storage below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderFilesystemConfigurationSessionStorage
{
    /// <summary>Mount path for the session storage filesystem inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderFilesystemConfiguration
{
    /// <summary>Amazon EFS access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See efs_access_point below.</summary>
    [JsonPropertyName("efsAccessPoint")]
    public V1beta1AgentRuntimeStatusAtProviderFilesystemConfigurationEfsAccessPoint? EfsAccessPoint { get; set; }

    /// <summary>Amazon S3 Files access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See s3_files_access_point below.</summary>
    [JsonPropertyName("s3FilesAccessPoint")]
    public V1beta1AgentRuntimeStatusAtProviderFilesystemConfigurationS3FilesAccessPoint? S3FilesAccessPoint { get; set; }

    /// <summary>Session storage filesystem providing persistent storage across agent runtime session invocations. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See session_storage below.</summary>
    [JsonPropertyName("sessionStorage")]
    public V1beta1AgentRuntimeStatusAtProviderFilesystemConfigurationSessionStorage? SessionStorage { get; set; }
}

/// <summary>Runtime session and resource lifecycle configuration for the agent runtime. See lifecycle_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderNetworkConfigurationNetworkModeConfig
{
    /// <summary>(Read-only) Whether a service-managed Amazon S3 gateway endpoint is provisioned in the VPC for the agent runtime. This value is managed by the service and cannot be set: it is rejected on both create and update. Agent runtimes created on or after the May 5, 2026 rollout do not include a service-managed Amazon S3 gateway.</summary>
    [JsonPropertyName("requireServiceS3Endpoint")]
    public bool? RequireServiceS3Endpoint { get; set; }

    /// <summary>Security groups associated with the VPC configuration.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Subnets associated with the VPC configuration.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>Network configuration for the agent runtime. See network_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderProtocolConfiguration
{
    /// <summary>Server protocol for the agent runtime. Valid values: HTTP, MCP, A2A, AGUI.</summary>
    [JsonPropertyName("serverProtocol")]
    public string? ServerProtocol { get; set; }
}

/// <summary>Configuration for HTTP request headers that will be passed through to the runtime. See request_header_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderRequestHeaderConfiguration
{
    /// <summary>A list of HTTP request headers that are allowed to be passed through to the runtime.</summary>
    [JsonPropertyName("requestHeaderAllowlist")]
    public IList<string>? RequestHeaderAllowlist { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatusAtProviderWorkloadIdentityDetails
{
    /// <summary>ARN of the workload identity.</summary>
    [JsonPropertyName("workloadIdentityArn")]
    public string? WorkloadIdentityArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

    /// <summary>List of filesystems to mount into the agent runtime. Up to 5 entries are supported. Each entry is one of session storage, Amazon S3 Files access point, or Amazon EFS access point. See filesystem_configuration below.</summary>
    [JsonPropertyName("filesystemConfiguration")]
    public IList<V1beta1AgentRuntimeStatusAtProviderFilesystemConfiguration>? FilesystemConfiguration { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentRuntimeStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1AgentRuntimeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AgentRuntimeStatusConditions>? Conditions { get; set; }

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

/// <summary>AgentRuntime is the Schema for the AgentRuntimes API. Manages an AWS Bedrock AgentCore Agent Runtime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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