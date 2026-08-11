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
/// <summary>Harness is the Schema for the Harnesss API. Manages an AWS Bedrock AgentCore Harness.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HarnessList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Harness>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HarnessList";
    public const string KubeGroup = "bedrockagentcore.aws.upbound.io";
    public const string KubePluralName = "harnesses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HarnessList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Harness objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Harness> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecDeletionPolicyEnum>))]
public enum V1beta1HarnessSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment
{
    /// <summary>ARN of the hosting environment.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>Configuration restricting which workloads may use this authorizer. See allowed_workload_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration
{
    /// <summary>Hosting environments allowed to use the authorizer. Between 1 and 10 entries. See hosting_environment below.</summary>
    [JsonPropertyName("hostingEnvironment")]
    public IList<V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment>? HostingEnvironment { get; set; }

    /// <summary>List of workload identity names allowed to use the authorizer. Between 1 and 10 entries.</summary>
    [JsonPropertyName("workloadIdentities")]
    public IList<string>? WorkloadIdentities { get; set; }
}

/// <summary>Value or values to match for. See claim_match_value below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue
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
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
{
    /// <summary>Relationship between the claim field value and the value or values to match for. Valid values are EQUALS, CONTAINS, and CONTAINS_ANY. EQUALS can be used only when inbound_token_claim_value_type is STRING. CONTAINS or CONTAINS_ANY can be used only when inbound_token_claim_value_type is STRING_ARRAY.</summary>
    [JsonPropertyName("claimMatchOperator")]
    public string? ClaimMatchOperator { get; set; }

    /// <summary>Value or values to match for. See claim_match_value below.</summary>
    [JsonPropertyName("claimMatchValue")]
    public V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue? ClaimMatchValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
{
    /// <summary>Configuration block to define the value or values to match for and the relationship of the match. See authorizing_claim_match_value below.</summary>
    [JsonPropertyName("authorizingClaimMatchValue")]
    public V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue? AuthorizingClaimMatchValue { get; set; }

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
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource
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
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint used to reach the authorization server. See private_endpoint below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint
{
    /// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

/// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointManagedVpcResource
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
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint configuration. See private_endpoint below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpoint
{
    /// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides
{
    /// <summary>Domain the override applies to.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Private endpoint configuration. See private_endpoint below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpoint? PrivateEndpoint { get; set; }
}

/// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizer
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
    public V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration? AllowedWorkloadConfiguration { get; set; }

    /// <summary>Repeatable block to define a custom claim validation name, value, and operation. See custom_claim below.</summary>
    [JsonPropertyName("customClaim")]
    public IList<V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaim>? CustomClaim { get; set; }

    /// <summary>URL used to fetch OpenID Connect configuration or authorization server metadata. Must end with .well-known/openid-configuration.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Private endpoint used to reach the authorization server. See private_endpoint below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Overrides for the private endpoints used to reach the authorization server. See private_endpoint_overrides below.</summary>
    [JsonPropertyName("privateEndpointOverrides")]
    public IList<V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides>? PrivateEndpointOverrides { get; set; }
}

/// <summary>Authorization configuration for authenticating requests. See authorizer_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderAuthorizerConfiguration
{
    /// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
    [JsonPropertyName("customJwtAuthorizer")]
    public V1beta1HarnessSpecForProviderAuthorizerConfigurationCustomJwtAuthorizer? CustomJwtAuthorizer { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AgentRuntime in bedrockagentcore to populate agentRuntimeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AgentRuntime in bedrockagentcore to populate agentRuntimeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelector
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
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessPoint in efs to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessPoint in efs to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelector
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
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint
{
    /// <summary>ARN of the Amazon S3 Files access point to mount into the agent runtime.</summary>
    [JsonPropertyName("accessPointArn")]
    public string? AccessPointArn { get; set; }

    /// <summary>Reference to a AccessPoint in efs to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnRef")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRef? AccessPointArnRef { get; set; }

    /// <summary>Selector for a AccessPoint in efs to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnSelector")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelector? AccessPointArnSelector { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessPoint in s3control to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessPoint in s3control to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelector
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
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPoint
{
    /// <summary>ARN of the Amazon S3 Files access point to mount into the agent runtime.</summary>
    [JsonPropertyName("accessPointArn")]
    public string? AccessPointArn { get; set; }

    /// <summary>Reference to a AccessPoint in s3control to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnRef")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRef? AccessPointArnRef { get; set; }

    /// <summary>Selector for a AccessPoint in s3control to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnSelector")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelector? AccessPointArnSelector { get; set; }

    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationSessionStorage
{
    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfiguration
{
    /// <summary>Amazon EFS access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See efs_access_point below.</summary>
    [JsonPropertyName("efsAccessPoint")]
    public IList<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint>? EfsAccessPoint { get; set; }

    /// <summary>Amazon S3 Files access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See s3_files_access_point below.</summary>
    [JsonPropertyName("s3FilesAccessPoint")]
    public IList<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPoint>? S3FilesAccessPoint { get; set; }

    /// <summary>Session storage filesystem providing persistent storage across agent runtime session invocations. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See session_storage below.</summary>
    [JsonPropertyName("sessionStorage")]
    public IList<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationSessionStorage>? SessionStorage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentLifecycleConfiguration
{
    /// <summary>Timeout in seconds for idle sessions.</summary>
    [JsonPropertyName("idleRuntimeSessionTimeout")]
    public double? IdleRuntimeSessionTimeout { get; set; }

    /// <summary>Maximum lifetime of the instance in seconds.</summary>
    [JsonPropertyName("maxLifetime")]
    public double? MaxLifetime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig
{
    /// <summary>Whether to require an S3 endpoint for the service in the VPC.</summary>
    [JsonPropertyName("requireServiceS3Endpoint")]
    public bool? RequireServiceS3Endpoint { get; set; }

    /// <summary>Security groups for the VPC.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Subnets for the VPC.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration
{
    /// <summary>Network mode. Valid values: PUBLIC, VPC.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>VPC configuration. See network_mode_config below.</summary>
    [JsonPropertyName("networkModeConfig")]
    public IList<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig>? NetworkModeConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironment
{
    /// <summary>ARN of the AgentCore memory resource.</summary>
    [JsonPropertyName("agentRuntimeArn")]
    public string? AgentRuntimeArn { get; set; }

    /// <summary>Reference to a AgentRuntime in bedrockagentcore to populate agentRuntimeArn.</summary>
    [JsonPropertyName("agentRuntimeArnRef")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRef? AgentRuntimeArnRef { get; set; }

    /// <summary>Selector for a AgentRuntime in bedrockagentcore to populate agentRuntimeArn.</summary>
    [JsonPropertyName("agentRuntimeArnSelector")]
    public V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelector? AgentRuntimeArnSelector { get; set; }

    [JsonPropertyName("agentRuntimeId")]
    public string? AgentRuntimeId { get; set; }

    [JsonPropertyName("agentRuntimeName")]
    public string? AgentRuntimeName { get; set; }

    /// <summary>Filesystem configurations. See filesystem_configuration below.</summary>
    [JsonPropertyName("filesystemConfiguration")]
    public IList<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfiguration>? FilesystemConfiguration { get; set; }

    /// <summary>Lifecycle configuration. See lifecycle_configuration below.</summary>
    [JsonPropertyName("lifecycleConfiguration")]
    public IList<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentLifecycleConfiguration>? LifecycleConfiguration { get; set; }

    /// <summary>Network configuration. See network_configuration below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration>? NetworkConfiguration { get; set; }
}

/// <summary>Compute environment configuration. See environment below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironment
{
    /// <summary>AgentCore runtime environment configuration. See agentcore_runtime_environment below.</summary>
    [JsonPropertyName("agentcoreRuntimeEnvironment")]
    public IList<V1beta1HarnessSpecForProviderEnvironmentAgentcoreRuntimeEnvironment>? AgentcoreRuntimeEnvironment { get; set; }
}

/// <summary>Container configuration. See container_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentArtifactContainerConfiguration
{
    /// <summary>URI of the container image.</summary>
    [JsonPropertyName("containerUri")]
    public string? ContainerUri { get; set; }
}

/// <summary>Environment artifact configuration. See environment_artifact below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentArtifact
{
    /// <summary>Container configuration. See container_configuration below.</summary>
    [JsonPropertyName("containerConfiguration")]
    public V1beta1HarnessSpecForProviderEnvironmentArtifactContainerConfiguration? ContainerConfiguration { get; set; }
}

/// <summary>Map of environment variables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderEnvironmentVariablesSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecForProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderExecutionRoleArnSelector
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
    public V1beta1HarnessSpecForProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Memory in bedrockagentcore to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Memory in bedrockagentcore to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnSelector
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
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MemoryStrategy in bedrockagentcore to populate strategyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MemoryStrategy in bedrockagentcore to populate strategyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelector
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
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Retrieval configuration parameters. See retrieval_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfig
{
    /// <summary>Key for the retrieval configuration map block.</summary>
    [JsonPropertyName("mapBlockKey")]
    public string? MapBlockKey { get; set; }

    /// <summary>Relevance score threshold. Valid value is between 0 and 1.</summary>
    [JsonPropertyName("relevanceScore")]
    public double? RelevanceScore { get; set; }

    /// <summary>ID of the memory strategy.</summary>
    [JsonPropertyName("strategyId")]
    public string? StrategyId { get; set; }

    /// <summary>Reference to a MemoryStrategy in bedrockagentcore to populate strategyId.</summary>
    [JsonPropertyName("strategyIdRef")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRef? StrategyIdRef { get; set; }

    /// <summary>Selector for a MemoryStrategy in bedrockagentcore to populate strategyId.</summary>
    [JsonPropertyName("strategyIdSelector")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelector? StrategyIdSelector { get; set; }

    /// <summary>Top-k sampling parameter.</summary>
    [JsonPropertyName("topK")]
    public double? TopK { get; set; }
}

/// <summary>AgentCore memory configuration. See agentcore_memory_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfiguration
{
    /// <summary>Actor ID for memory sessions.</summary>
    [JsonPropertyName("actorId")]
    public string? ActorId { get; set; }

    /// <summary>ARN of the hosting environment.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Memory in bedrockagentcore to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Memory in bedrockagentcore to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationArnSelector? ArnSelector { get; set; }

    /// <summary>Number of recent messages to keep in the conversation window.</summary>
    [JsonPropertyName("messagesCount")]
    public double? MessagesCount { get; set; }

    /// <summary>Retrieval configuration parameters. See retrieval_config below.</summary>
    [JsonPropertyName("retrievalConfig")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfigurationRetrievalConfig? RetrievalConfig { get; set; }
}

/// <summary>Memory configuration. See memory below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderMemory
{
    /// <summary>AgentCore memory configuration. See agentcore_memory_configuration below.</summary>
    [JsonPropertyName("agentcoreMemoryConfiguration")]
    public V1beta1HarnessSpecForProviderMemoryAgentcoreMemoryConfiguration? AgentcoreMemoryConfiguration { get; set; }
}

/// <summary>Amazon Bedrock model configuration. See bedrock_model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderModelBedrockModelConfig
{
    /// <summary>Maximum number of tokens in the model response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Bedrock model ID (e.g., anthropic.claude-sonnet-4-20250514).</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Temperature for sampling. Must be between 0 and 2.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Top-p (nucleus) sampling parameter. Must be between 0 and 1.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate apiKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate apiKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnSelector
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
    public V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Gemini model configuration. See gemini_model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderModelGeminiModelConfig
{
    /// <summary>ARN of the secret containing the API key.</summary>
    [JsonPropertyName("apiKeyArn")]
    public string? ApiKeyArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate apiKeyArn.</summary>
    [JsonPropertyName("apiKeyArnRef")]
    public V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnRef? ApiKeyArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate apiKeyArn.</summary>
    [JsonPropertyName("apiKeyArnSelector")]
    public V1beta1HarnessSpecForProviderModelGeminiModelConfigApiKeyArnSelector? ApiKeyArnSelector { get; set; }

    /// <summary>Maximum number of tokens in the model response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Bedrock model ID (e.g., anthropic.claude-sonnet-4-20250514).</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Temperature for sampling. Must be between 0 and 2.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Top-k sampling parameter.</summary>
    [JsonPropertyName("topK")]
    public double? TopK { get; set; }

    /// <summary>Top-p (nucleus) sampling parameter. Must be between 0 and 1.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate apiKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate apiKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnSelector
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
    public V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>OpenAI model configuration. See openai_model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderModelOpenaiModelConfig
{
    /// <summary>ARN of the secret containing the API key.</summary>
    [JsonPropertyName("apiKeyArn")]
    public string? ApiKeyArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate apiKeyArn.</summary>
    [JsonPropertyName("apiKeyArnRef")]
    public V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnRef? ApiKeyArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate apiKeyArn.</summary>
    [JsonPropertyName("apiKeyArnSelector")]
    public V1beta1HarnessSpecForProviderModelOpenaiModelConfigApiKeyArnSelector? ApiKeyArnSelector { get; set; }

    /// <summary>Maximum number of tokens in the model response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Bedrock model ID (e.g., anthropic.claude-sonnet-4-20250514).</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Temperature for sampling. Must be between 0 and 2.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Top-p (nucleus) sampling parameter. Must be between 0 and 1.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Model configuration for the harness. See model below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderModel
{
    /// <summary>Amazon Bedrock model configuration. See bedrock_model_config below.</summary>
    [JsonPropertyName("bedrockModelConfig")]
    public V1beta1HarnessSpecForProviderModelBedrockModelConfig? BedrockModelConfig { get; set; }

    /// <summary>Gemini model configuration. See gemini_model_config below.</summary>
    [JsonPropertyName("geminiModelConfig")]
    public V1beta1HarnessSpecForProviderModelGeminiModelConfig? GeminiModelConfig { get; set; }

    /// <summary>OpenAI model configuration. See openai_model_config below.</summary>
    [JsonPropertyName("openaiModelConfig")]
    public V1beta1HarnessSpecForProviderModelOpenaiModelConfig? OpenaiModelConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderSkill
{
    /// <summary>Path to the skill.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Text content of the system prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderSystemPromptTextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderSystemPrompt
{
    /// <summary>Text content of the system prompt.</summary>
    [JsonPropertyName("textSecretRef")]
    public V1beta1HarnessSpecForProviderSystemPromptTextSecretRef? TextSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Browser in bedrockagentcore to populate browserArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Browser in bedrockagentcore to populate browserArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnSelector
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
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicy? Policy { get; set; }
}

/// <summary>AgentCore browser configuration. See agentcore_browser below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowser
{
    /// <summary>ARN of the AgentCore browser resource.</summary>
    [JsonPropertyName("browserArn")]
    public string? BrowserArn { get; set; }

    /// <summary>Reference to a Browser in bedrockagentcore to populate browserArn.</summary>
    [JsonPropertyName("browserArnRef")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnRef? BrowserArnRef { get; set; }

    /// <summary>Selector for a Browser in bedrockagentcore to populate browserArn.</summary>
    [JsonPropertyName("browserArnSelector")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowserBrowserArnSelector? BrowserArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CodeInterpreter in bedrockagentcore to populate codeInterpreterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CodeInterpreter in bedrockagentcore to populate codeInterpreterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelector
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
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>AgentCore code interpreter configuration. See agentcore_code_interpreter below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreter
{
    /// <summary>ARN of the AgentCore code interpreter resource.</summary>
    [JsonPropertyName("codeInterpreterArn")]
    public string? CodeInterpreterArn { get; set; }

    /// <summary>Reference to a CodeInterpreter in bedrockagentcore to populate codeInterpreterArn.</summary>
    [JsonPropertyName("codeInterpreterArnRef")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRef? CodeInterpreterArnRef { get; set; }

    /// <summary>Selector for a CodeInterpreter in bedrockagentcore to populate codeInterpreterArn.</summary>
    [JsonPropertyName("codeInterpreterArnSelector")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelector? CodeInterpreterArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Gateway in bedrockagentcore to populate gatewayArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Gateway in bedrockagentcore to populate gatewayArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnSelector
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
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Oauth2CredentialProvider in bedrockagentcore to populate providerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Oauth2CredentialProvider in bedrockagentcore to populate providerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelector
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
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicy? Policy { get; set; }
}

/// <summary>OAuth credential provider configuration. See oauth below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauth
{
    /// <summary>Map of custom parameters.</summary>
    [JsonPropertyName("customParameters")]
    public IDictionary<string, string>? CustomParameters { get; set; }

    /// <summary>Default return URL for OAuth flow.</summary>
    [JsonPropertyName("defaultReturnUrl")]
    public string? DefaultReturnUrl { get; set; }

    /// <summary>OAuth grant type.</summary>
    [JsonPropertyName("grantType")]
    public string? GrantType { get; set; }

    /// <summary>ARN of the OAuth credential provider.</summary>
    [JsonPropertyName("providerArn")]
    public string? ProviderArn { get; set; }

    /// <summary>Reference to a Oauth2CredentialProvider in bedrockagentcore to populate providerArn.</summary>
    [JsonPropertyName("providerArnRef")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRef? ProviderArnRef { get; set; }

    /// <summary>Selector for a Oauth2CredentialProvider in bedrockagentcore to populate providerArn.</summary>
    [JsonPropertyName("providerArnSelector")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelector? ProviderArnSelector { get; set; }

    /// <summary>List of OAuth scopes.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Outbound authentication configuration. See outbound_auth below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuth
{
    /// <summary>Set to true to use AWS IAM authentication.</summary>
    [JsonPropertyName("awsIam")]
    public bool? AwsIam { get; set; }

    /// <summary>Set to true to disable authentication.</summary>
    [JsonPropertyName("none")]
    public bool? None { get; set; }

    /// <summary>OAuth credential provider configuration. See oauth below.</summary>
    [JsonPropertyName("oauth")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuthOauth? Oauth { get; set; }
}

/// <summary>AgentCore gateway configuration. See agentcore_gateway below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigAgentcoreGateway
{
    /// <summary>ARN of the AgentCore gateway resource.</summary>
    [JsonPropertyName("gatewayArn")]
    public string? GatewayArn { get; set; }

    /// <summary>Reference to a Gateway in bedrockagentcore to populate gatewayArn.</summary>
    [JsonPropertyName("gatewayArnRef")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnRef? GatewayArnRef { get; set; }

    /// <summary>Selector for a Gateway in bedrockagentcore to populate gatewayArn.</summary>
    [JsonPropertyName("gatewayArnSelector")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayGatewayArnSelector? GatewayArnSelector { get; set; }

    /// <summary>Outbound authentication configuration. See outbound_auth below.</summary>
    [JsonPropertyName("outboundAuth")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGatewayOutboundAuth? OutboundAuth { get; set; }
}

/// <summary>JSON string defining the input schema for the function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigInlineFunctionInputSchemaSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Inline function configuration. See inline_function below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigInlineFunction
{
    /// <summary>Description of the inline function.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON string defining the input schema for the function.</summary>
    [JsonPropertyName("inputSchemaSecretRef")]
    public V1beta1HarnessSpecForProviderToolConfigInlineFunctionInputSchemaSecretRef? InputSchemaSecretRef { get; set; }
}

/// <summary>Map of HTTP headers to include in requests to the MCP server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigRemoteMcpHeadersSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>URL of the remote MCP server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigRemoteMcpUrlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Remote MCP server configuration. See remote_mcp below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfigRemoteMcp
{
    /// <summary>Map of HTTP headers to include in requests to the MCP server.</summary>
    [JsonPropertyName("headersSecretRef")]
    public V1beta1HarnessSpecForProviderToolConfigRemoteMcpHeadersSecretRef? HeadersSecretRef { get; set; }

    /// <summary>URL of the remote MCP server.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1beta1HarnessSpecForProviderToolConfigRemoteMcpUrlSecretRef? UrlSecretRef { get; set; }
}

/// <summary>Tool-specific configuration. See tool config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderToolConfig
{
    /// <summary>AgentCore browser configuration. See agentcore_browser below.</summary>
    [JsonPropertyName("agentcoreBrowser")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreBrowser? AgentcoreBrowser { get; set; }

    /// <summary>AgentCore code interpreter configuration. See agentcore_code_interpreter below.</summary>
    [JsonPropertyName("agentcoreCodeInterpreter")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreCodeInterpreter? AgentcoreCodeInterpreter { get; set; }

    /// <summary>AgentCore gateway configuration. See agentcore_gateway below.</summary>
    [JsonPropertyName("agentcoreGateway")]
    public V1beta1HarnessSpecForProviderToolConfigAgentcoreGateway? AgentcoreGateway { get; set; }

    /// <summary>Inline function configuration. See inline_function below.</summary>
    [JsonPropertyName("inlineFunction")]
    public V1beta1HarnessSpecForProviderToolConfigInlineFunction? InlineFunction { get; set; }

    /// <summary>Remote MCP server configuration. See remote_mcp below.</summary>
    [JsonPropertyName("remoteMcp")]
    public V1beta1HarnessSpecForProviderToolConfigRemoteMcp? RemoteMcp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderTool
{
    /// <summary>Tool-specific configuration. See tool config below.</summary>
    [JsonPropertyName("config")]
    public V1beta1HarnessSpecForProviderToolConfig? Config { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of tool. Valid values: remote_mcp, agentcore_browser, agentcore_gateway, inline_function, agentcore_code_interpreter.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderTruncationConfigSlidingWindow
{
    /// <summary>Number of recent messages to keep in the conversation window.</summary>
    [JsonPropertyName("messagesCount")]
    public double? MessagesCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderTruncationConfigSummarization
{
    /// <summary>Number of recent messages to preserve without summarization.</summary>
    [JsonPropertyName("preserveRecentMessages")]
    public double? PreserveRecentMessages { get; set; }

    /// <summary>Custom system prompt for the summarization model.</summary>
    [JsonPropertyName("summarizationSystemPrompt")]
    public string? SummarizationSystemPrompt { get; set; }

    /// <summary>Ratio of the conversation to summarize (0 to 1).</summary>
    [JsonPropertyName("summaryRatio")]
    public double? SummaryRatio { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderTruncationConfig
{
    /// <summary>Sliding window truncation configuration. See sliding_window below.</summary>
    [JsonPropertyName("slidingWindow")]
    public IList<V1beta1HarnessSpecForProviderTruncationConfigSlidingWindow>? SlidingWindow { get; set; }

    /// <summary>Summarization truncation configuration. See summarization below.</summary>
    [JsonPropertyName("summarization")]
    public IList<V1beta1HarnessSpecForProviderTruncationConfigSummarization>? Summarization { get; set; }
}

/// <summary>Truncation configuration for conversation history. See truncation below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProviderTruncation
{
    /// <summary>Strategy-specific configuration. See truncation config below.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1HarnessSpecForProviderTruncationConfig>? Config { get; set; }

    /// <summary>Truncation strategy. Valid values: sliding_window, summarization, none.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecForProvider
{
    /// <summary>List of tool names allowed for the harness. Use [&quot;*&quot;] to allow all tools.</summary>
    [JsonPropertyName("allowedTools")]
    public IList<string>? AllowedTools { get; set; }

    /// <summary>Authorization configuration for authenticating requests. See authorizer_configuration below.</summary>
    [JsonPropertyName("authorizerConfiguration")]
    public V1beta1HarnessSpecForProviderAuthorizerConfiguration? AuthorizerConfiguration { get; set; }

    /// <summary>Compute environment configuration. See environment below.</summary>
    [JsonPropertyName("environment")]
    public V1beta1HarnessSpecForProviderEnvironment? Environment { get; set; }

    /// <summary>Environment artifact configuration. See environment_artifact below.</summary>
    [JsonPropertyName("environmentArtifact")]
    public V1beta1HarnessSpecForProviderEnvironmentArtifact? EnvironmentArtifact { get; set; }

    /// <summary>Map of environment variables.</summary>
    [JsonPropertyName("environmentVariablesSecretRef")]
    public V1beta1HarnessSpecForProviderEnvironmentVariablesSecretRef? EnvironmentVariablesSecretRef { get; set; }

    /// <summary>ARN of the IAM role that the harness assumes to access AWS services.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1HarnessSpecForProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1HarnessSpecForProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>Name of the harness. Must be 1-40 characters, alphanumeric and underscores only.</summary>
    [JsonPropertyName("harnessName")]
    public string? HarnessName { get; set; }

    /// <summary>Maximum number of iterations the agent loop can perform.</summary>
    [JsonPropertyName("maxIterations")]
    public double? MaxIterations { get; set; }

    /// <summary>Maximum number of tokens in the model response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Memory configuration. See memory below.</summary>
    [JsonPropertyName("memory")]
    public V1beta1HarnessSpecForProviderMemory? Memory { get; set; }

    /// <summary>Model configuration for the harness. See model below.</summary>
    [JsonPropertyName("model")]
    public V1beta1HarnessSpecForProviderModel? Model { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Skill configurations. See skill below.</summary>
    [JsonPropertyName("skill")]
    public IList<V1beta1HarnessSpecForProviderSkill>? Skill { get; set; }

    /// <summary>System prompt blocks for the harness. See system_prompt below.</summary>
    [JsonPropertyName("systemPrompt")]
    public IList<V1beta1HarnessSpecForProviderSystemPrompt>? SystemPrompt { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Timeout in seconds for the harness execution.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>Tool configurations. See tool below.</summary>
    [JsonPropertyName("tool")]
    public IList<V1beta1HarnessSpecForProviderTool>? Tool { get; set; }

    /// <summary>Truncation configuration for conversation history. See truncation below.</summary>
    [JsonPropertyName("truncation")]
    public V1beta1HarnessSpecForProviderTruncation? Truncation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment
{
    /// <summary>ARN of the hosting environment.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>Configuration restricting which workloads may use this authorizer. See allowed_workload_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration
{
    /// <summary>Hosting environments allowed to use the authorizer. Between 1 and 10 entries. See hosting_environment below.</summary>
    [JsonPropertyName("hostingEnvironment")]
    public IList<V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment>? HostingEnvironment { get; set; }

    /// <summary>List of workload identity names allowed to use the authorizer. Between 1 and 10 entries.</summary>
    [JsonPropertyName("workloadIdentities")]
    public IList<string>? WorkloadIdentities { get; set; }
}

/// <summary>Value or values to match for. See claim_match_value below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue
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
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
{
    /// <summary>Relationship between the claim field value and the value or values to match for. Valid values are EQUALS, CONTAINS, and CONTAINS_ANY. EQUALS can be used only when inbound_token_claim_value_type is STRING. CONTAINS or CONTAINS_ANY can be used only when inbound_token_claim_value_type is STRING_ARRAY.</summary>
    [JsonPropertyName("claimMatchOperator")]
    public string? ClaimMatchOperator { get; set; }

    /// <summary>Value or values to match for. See claim_match_value below.</summary>
    [JsonPropertyName("claimMatchValue")]
    public V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue? ClaimMatchValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
{
    /// <summary>Configuration block to define the value or values to match for and the relationship of the match. See authorizing_claim_match_value below.</summary>
    [JsonPropertyName("authorizingClaimMatchValue")]
    public V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue? AuthorizingClaimMatchValue { get; set; }

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
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource
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
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint used to reach the authorization server. See private_endpoint below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint
{
    /// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

/// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointManagedVpcResource
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
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint configuration. See private_endpoint below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpoint
{
    /// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides
{
    /// <summary>Domain the override applies to.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Private endpoint configuration. See private_endpoint below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpoint? PrivateEndpoint { get; set; }
}

/// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizer
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
    public V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration? AllowedWorkloadConfiguration { get; set; }

    /// <summary>Repeatable block to define a custom claim validation name, value, and operation. See custom_claim below.</summary>
    [JsonPropertyName("customClaim")]
    public IList<V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaim>? CustomClaim { get; set; }

    /// <summary>URL used to fetch OpenID Connect configuration or authorization server metadata. Must end with .well-known/openid-configuration.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Private endpoint used to reach the authorization server. See private_endpoint below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Overrides for the private endpoints used to reach the authorization server. See private_endpoint_overrides below.</summary>
    [JsonPropertyName("privateEndpointOverrides")]
    public IList<V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides>? PrivateEndpointOverrides { get; set; }
}

/// <summary>Authorization configuration for authenticating requests. See authorizer_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderAuthorizerConfiguration
{
    /// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
    [JsonPropertyName("customJwtAuthorizer")]
    public V1beta1HarnessSpecInitProviderAuthorizerConfigurationCustomJwtAuthorizer? CustomJwtAuthorizer { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AgentRuntime in bedrockagentcore to populate agentRuntimeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AgentRuntime in bedrockagentcore to populate agentRuntimeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelector
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
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessPoint in efs to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessPoint in efs to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelector
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
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint
{
    /// <summary>ARN of the Amazon S3 Files access point to mount into the agent runtime.</summary>
    [JsonPropertyName("accessPointArn")]
    public string? AccessPointArn { get; set; }

    /// <summary>Reference to a AccessPoint in efs to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnRef")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnRef? AccessPointArnRef { get; set; }

    /// <summary>Selector for a AccessPoint in efs to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnSelector")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPointAccessPointArnSelector? AccessPointArnSelector { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessPoint in s3control to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessPoint in s3control to populate accessPointArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelector
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
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPoint
{
    /// <summary>ARN of the Amazon S3 Files access point to mount into the agent runtime.</summary>
    [JsonPropertyName("accessPointArn")]
    public string? AccessPointArn { get; set; }

    /// <summary>Reference to a AccessPoint in s3control to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnRef")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnRef? AccessPointArnRef { get; set; }

    /// <summary>Selector for a AccessPoint in s3control to populate accessPointArn.</summary>
    [JsonPropertyName("accessPointArnSelector")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPointAccessPointArnSelector? AccessPointArnSelector { get; set; }

    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationSessionStorage
{
    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfiguration
{
    /// <summary>Amazon EFS access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See efs_access_point below.</summary>
    [JsonPropertyName("efsAccessPoint")]
    public IList<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint>? EfsAccessPoint { get; set; }

    /// <summary>Amazon S3 Files access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See s3_files_access_point below.</summary>
    [JsonPropertyName("s3FilesAccessPoint")]
    public IList<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPoint>? S3FilesAccessPoint { get; set; }

    /// <summary>Session storage filesystem providing persistent storage across agent runtime session invocations. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See session_storage below.</summary>
    [JsonPropertyName("sessionStorage")]
    public IList<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationSessionStorage>? SessionStorage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentLifecycleConfiguration
{
    /// <summary>Timeout in seconds for idle sessions.</summary>
    [JsonPropertyName("idleRuntimeSessionTimeout")]
    public double? IdleRuntimeSessionTimeout { get; set; }

    /// <summary>Maximum lifetime of the instance in seconds.</summary>
    [JsonPropertyName("maxLifetime")]
    public double? MaxLifetime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig
{
    /// <summary>Whether to require an S3 endpoint for the service in the VPC.</summary>
    [JsonPropertyName("requireServiceS3Endpoint")]
    public bool? RequireServiceS3Endpoint { get; set; }

    /// <summary>Security groups for the VPC.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Subnets for the VPC.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration
{
    /// <summary>Network mode. Valid values: PUBLIC, VPC.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>VPC configuration. See network_mode_config below.</summary>
    [JsonPropertyName("networkModeConfig")]
    public IList<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig>? NetworkModeConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironment
{
    /// <summary>ARN of the AgentCore memory resource.</summary>
    [JsonPropertyName("agentRuntimeArn")]
    public string? AgentRuntimeArn { get; set; }

    /// <summary>Reference to a AgentRuntime in bedrockagentcore to populate agentRuntimeArn.</summary>
    [JsonPropertyName("agentRuntimeArnRef")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnRef? AgentRuntimeArnRef { get; set; }

    /// <summary>Selector for a AgentRuntime in bedrockagentcore to populate agentRuntimeArn.</summary>
    [JsonPropertyName("agentRuntimeArnSelector")]
    public V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentAgentRuntimeArnSelector? AgentRuntimeArnSelector { get; set; }

    [JsonPropertyName("agentRuntimeId")]
    public string? AgentRuntimeId { get; set; }

    [JsonPropertyName("agentRuntimeName")]
    public string? AgentRuntimeName { get; set; }

    /// <summary>Filesystem configurations. See filesystem_configuration below.</summary>
    [JsonPropertyName("filesystemConfiguration")]
    public IList<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfiguration>? FilesystemConfiguration { get; set; }

    /// <summary>Lifecycle configuration. See lifecycle_configuration below.</summary>
    [JsonPropertyName("lifecycleConfiguration")]
    public IList<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentLifecycleConfiguration>? LifecycleConfiguration { get; set; }

    /// <summary>Network configuration. See network_configuration below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration>? NetworkConfiguration { get; set; }
}

/// <summary>Compute environment configuration. See environment below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironment
{
    /// <summary>AgentCore runtime environment configuration. See agentcore_runtime_environment below.</summary>
    [JsonPropertyName("agentcoreRuntimeEnvironment")]
    public IList<V1beta1HarnessSpecInitProviderEnvironmentAgentcoreRuntimeEnvironment>? AgentcoreRuntimeEnvironment { get; set; }
}

/// <summary>Container configuration. See container_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentArtifactContainerConfiguration
{
    /// <summary>URI of the container image.</summary>
    [JsonPropertyName("containerUri")]
    public string? ContainerUri { get; set; }
}

/// <summary>Environment artifact configuration. See environment_artifact below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderEnvironmentArtifact
{
    /// <summary>Container configuration. See container_configuration below.</summary>
    [JsonPropertyName("containerConfiguration")]
    public V1beta1HarnessSpecInitProviderEnvironmentArtifactContainerConfiguration? ContainerConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecInitProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderExecutionRoleArnSelector
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
    public V1beta1HarnessSpecInitProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Memory in bedrockagentcore to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Memory in bedrockagentcore to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnSelector
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
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MemoryStrategy in bedrockagentcore to populate strategyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MemoryStrategy in bedrockagentcore to populate strategyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelector
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
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Retrieval configuration parameters. See retrieval_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfig
{
    /// <summary>Key for the retrieval configuration map block.</summary>
    [JsonPropertyName("mapBlockKey")]
    public string? MapBlockKey { get; set; }

    /// <summary>Relevance score threshold. Valid value is between 0 and 1.</summary>
    [JsonPropertyName("relevanceScore")]
    public double? RelevanceScore { get; set; }

    /// <summary>ID of the memory strategy.</summary>
    [JsonPropertyName("strategyId")]
    public string? StrategyId { get; set; }

    /// <summary>Reference to a MemoryStrategy in bedrockagentcore to populate strategyId.</summary>
    [JsonPropertyName("strategyIdRef")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdRef? StrategyIdRef { get; set; }

    /// <summary>Selector for a MemoryStrategy in bedrockagentcore to populate strategyId.</summary>
    [JsonPropertyName("strategyIdSelector")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfigStrategyIdSelector? StrategyIdSelector { get; set; }

    /// <summary>Top-k sampling parameter.</summary>
    [JsonPropertyName("topK")]
    public double? TopK { get; set; }
}

/// <summary>AgentCore memory configuration. See agentcore_memory_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfiguration
{
    /// <summary>Actor ID for memory sessions.</summary>
    [JsonPropertyName("actorId")]
    public string? ActorId { get; set; }

    /// <summary>ARN of the hosting environment.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Memory in bedrockagentcore to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Memory in bedrockagentcore to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationArnSelector? ArnSelector { get; set; }

    /// <summary>Number of recent messages to keep in the conversation window.</summary>
    [JsonPropertyName("messagesCount")]
    public double? MessagesCount { get; set; }

    /// <summary>Retrieval configuration parameters. See retrieval_config below.</summary>
    [JsonPropertyName("retrievalConfig")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfigurationRetrievalConfig? RetrievalConfig { get; set; }
}

/// <summary>Memory configuration. See memory below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderMemory
{
    /// <summary>AgentCore memory configuration. See agentcore_memory_configuration below.</summary>
    [JsonPropertyName("agentcoreMemoryConfiguration")]
    public V1beta1HarnessSpecInitProviderMemoryAgentcoreMemoryConfiguration? AgentcoreMemoryConfiguration { get; set; }
}

/// <summary>Amazon Bedrock model configuration. See bedrock_model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderModelBedrockModelConfig
{
    /// <summary>Maximum number of tokens in the model response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Bedrock model ID (e.g., anthropic.claude-sonnet-4-20250514).</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Temperature for sampling. Must be between 0 and 2.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Top-p (nucleus) sampling parameter. Must be between 0 and 1.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate apiKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate apiKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnSelector
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
    public V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Gemini model configuration. See gemini_model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderModelGeminiModelConfig
{
    /// <summary>ARN of the secret containing the API key.</summary>
    [JsonPropertyName("apiKeyArn")]
    public string? ApiKeyArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate apiKeyArn.</summary>
    [JsonPropertyName("apiKeyArnRef")]
    public V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnRef? ApiKeyArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate apiKeyArn.</summary>
    [JsonPropertyName("apiKeyArnSelector")]
    public V1beta1HarnessSpecInitProviderModelGeminiModelConfigApiKeyArnSelector? ApiKeyArnSelector { get; set; }

    /// <summary>Maximum number of tokens in the model response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Bedrock model ID (e.g., anthropic.claude-sonnet-4-20250514).</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Temperature for sampling. Must be between 0 and 2.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Top-k sampling parameter.</summary>
    [JsonPropertyName("topK")]
    public double? TopK { get; set; }

    /// <summary>Top-p (nucleus) sampling parameter. Must be between 0 and 1.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate apiKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate apiKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnSelector
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
    public V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>OpenAI model configuration. See openai_model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderModelOpenaiModelConfig
{
    /// <summary>ARN of the secret containing the API key.</summary>
    [JsonPropertyName("apiKeyArn")]
    public string? ApiKeyArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate apiKeyArn.</summary>
    [JsonPropertyName("apiKeyArnRef")]
    public V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnRef? ApiKeyArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate apiKeyArn.</summary>
    [JsonPropertyName("apiKeyArnSelector")]
    public V1beta1HarnessSpecInitProviderModelOpenaiModelConfigApiKeyArnSelector? ApiKeyArnSelector { get; set; }

    /// <summary>Maximum number of tokens in the model response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Bedrock model ID (e.g., anthropic.claude-sonnet-4-20250514).</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Temperature for sampling. Must be between 0 and 2.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Top-p (nucleus) sampling parameter. Must be between 0 and 1.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Model configuration for the harness. See model below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderModel
{
    /// <summary>Amazon Bedrock model configuration. See bedrock_model_config below.</summary>
    [JsonPropertyName("bedrockModelConfig")]
    public V1beta1HarnessSpecInitProviderModelBedrockModelConfig? BedrockModelConfig { get; set; }

    /// <summary>Gemini model configuration. See gemini_model_config below.</summary>
    [JsonPropertyName("geminiModelConfig")]
    public V1beta1HarnessSpecInitProviderModelGeminiModelConfig? GeminiModelConfig { get; set; }

    /// <summary>OpenAI model configuration. See openai_model_config below.</summary>
    [JsonPropertyName("openaiModelConfig")]
    public V1beta1HarnessSpecInitProviderModelOpenaiModelConfig? OpenaiModelConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderSkill
{
    /// <summary>Path to the skill.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Text content of the system prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderSystemPromptTextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderSystemPrompt
{
    /// <summary>Text content of the system prompt.</summary>
    [JsonPropertyName("textSecretRef")]
    public required V1beta1HarnessSpecInitProviderSystemPromptTextSecretRef TextSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Browser in bedrockagentcore to populate browserArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Browser in bedrockagentcore to populate browserArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnSelector
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
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnSelectorPolicy? Policy { get; set; }
}

/// <summary>AgentCore browser configuration. See agentcore_browser below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowser
{
    /// <summary>ARN of the AgentCore browser resource.</summary>
    [JsonPropertyName("browserArn")]
    public string? BrowserArn { get; set; }

    /// <summary>Reference to a Browser in bedrockagentcore to populate browserArn.</summary>
    [JsonPropertyName("browserArnRef")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnRef? BrowserArnRef { get; set; }

    /// <summary>Selector for a Browser in bedrockagentcore to populate browserArn.</summary>
    [JsonPropertyName("browserArnSelector")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowserBrowserArnSelector? BrowserArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CodeInterpreter in bedrockagentcore to populate codeInterpreterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CodeInterpreter in bedrockagentcore to populate codeInterpreterArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelector
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
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelectorPolicy? Policy { get; set; }
}

/// <summary>AgentCore code interpreter configuration. See agentcore_code_interpreter below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreter
{
    /// <summary>ARN of the AgentCore code interpreter resource.</summary>
    [JsonPropertyName("codeInterpreterArn")]
    public string? CodeInterpreterArn { get; set; }

    /// <summary>Reference to a CodeInterpreter in bedrockagentcore to populate codeInterpreterArn.</summary>
    [JsonPropertyName("codeInterpreterArnRef")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnRef? CodeInterpreterArnRef { get; set; }

    /// <summary>Selector for a CodeInterpreter in bedrockagentcore to populate codeInterpreterArn.</summary>
    [JsonPropertyName("codeInterpreterArnSelector")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreterCodeInterpreterArnSelector? CodeInterpreterArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Gateway in bedrockagentcore to populate gatewayArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Gateway in bedrockagentcore to populate gatewayArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnSelector
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
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Oauth2CredentialProvider in bedrockagentcore to populate providerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicyResolveEnum>))]
public enum V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Oauth2CredentialProvider in bedrockagentcore to populate providerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelector
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
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelectorPolicy? Policy { get; set; }
}

/// <summary>OAuth credential provider configuration. See oauth below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauth
{
    /// <summary>Map of custom parameters.</summary>
    [JsonPropertyName("customParameters")]
    public IDictionary<string, string>? CustomParameters { get; set; }

    /// <summary>Default return URL for OAuth flow.</summary>
    [JsonPropertyName("defaultReturnUrl")]
    public string? DefaultReturnUrl { get; set; }

    /// <summary>OAuth grant type.</summary>
    [JsonPropertyName("grantType")]
    public string? GrantType { get; set; }

    /// <summary>ARN of the OAuth credential provider.</summary>
    [JsonPropertyName("providerArn")]
    public string? ProviderArn { get; set; }

    /// <summary>Reference to a Oauth2CredentialProvider in bedrockagentcore to populate providerArn.</summary>
    [JsonPropertyName("providerArnRef")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnRef? ProviderArnRef { get; set; }

    /// <summary>Selector for a Oauth2CredentialProvider in bedrockagentcore to populate providerArn.</summary>
    [JsonPropertyName("providerArnSelector")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauthProviderArnSelector? ProviderArnSelector { get; set; }

    /// <summary>List of OAuth scopes.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Outbound authentication configuration. See outbound_auth below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuth
{
    /// <summary>Set to true to use AWS IAM authentication.</summary>
    [JsonPropertyName("awsIam")]
    public bool? AwsIam { get; set; }

    /// <summary>Set to true to disable authentication.</summary>
    [JsonPropertyName("none")]
    public bool? None { get; set; }

    /// <summary>OAuth credential provider configuration. See oauth below.</summary>
    [JsonPropertyName("oauth")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuthOauth? Oauth { get; set; }
}

/// <summary>AgentCore gateway configuration. See agentcore_gateway below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigAgentcoreGateway
{
    /// <summary>ARN of the AgentCore gateway resource.</summary>
    [JsonPropertyName("gatewayArn")]
    public string? GatewayArn { get; set; }

    /// <summary>Reference to a Gateway in bedrockagentcore to populate gatewayArn.</summary>
    [JsonPropertyName("gatewayArnRef")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnRef? GatewayArnRef { get; set; }

    /// <summary>Selector for a Gateway in bedrockagentcore to populate gatewayArn.</summary>
    [JsonPropertyName("gatewayArnSelector")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayGatewayArnSelector? GatewayArnSelector { get; set; }

    /// <summary>Outbound authentication configuration. See outbound_auth below.</summary>
    [JsonPropertyName("outboundAuth")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGatewayOutboundAuth? OutboundAuth { get; set; }
}

/// <summary>JSON string defining the input schema for the function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigInlineFunctionInputSchemaSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Inline function configuration. See inline_function below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigInlineFunction
{
    /// <summary>Description of the inline function.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON string defining the input schema for the function.</summary>
    [JsonPropertyName("inputSchemaSecretRef")]
    public required V1beta1HarnessSpecInitProviderToolConfigInlineFunctionInputSchemaSecretRef InputSchemaSecretRef { get; set; }
}

/// <summary>URL of the remote MCP server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigRemoteMcpUrlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Remote MCP server configuration. See remote_mcp below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfigRemoteMcp
{
    [JsonPropertyName("headersSecretRef")]
    public IDictionary<string, string>? HeadersSecretRef { get; set; }

    /// <summary>URL of the remote MCP server.</summary>
    [JsonPropertyName("urlSecretRef")]
    public required V1beta1HarnessSpecInitProviderToolConfigRemoteMcpUrlSecretRef UrlSecretRef { get; set; }
}

/// <summary>Tool-specific configuration. See tool config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderToolConfig
{
    /// <summary>AgentCore browser configuration. See agentcore_browser below.</summary>
    [JsonPropertyName("agentcoreBrowser")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreBrowser? AgentcoreBrowser { get; set; }

    /// <summary>AgentCore code interpreter configuration. See agentcore_code_interpreter below.</summary>
    [JsonPropertyName("agentcoreCodeInterpreter")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreCodeInterpreter? AgentcoreCodeInterpreter { get; set; }

    /// <summary>AgentCore gateway configuration. See agentcore_gateway below.</summary>
    [JsonPropertyName("agentcoreGateway")]
    public V1beta1HarnessSpecInitProviderToolConfigAgentcoreGateway? AgentcoreGateway { get; set; }

    /// <summary>Inline function configuration. See inline_function below.</summary>
    [JsonPropertyName("inlineFunction")]
    public V1beta1HarnessSpecInitProviderToolConfigInlineFunction? InlineFunction { get; set; }

    /// <summary>Remote MCP server configuration. See remote_mcp below.</summary>
    [JsonPropertyName("remoteMcp")]
    public V1beta1HarnessSpecInitProviderToolConfigRemoteMcp? RemoteMcp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderTool
{
    /// <summary>Tool-specific configuration. See tool config below.</summary>
    [JsonPropertyName("config")]
    public V1beta1HarnessSpecInitProviderToolConfig? Config { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of tool. Valid values: remote_mcp, agentcore_browser, agentcore_gateway, inline_function, agentcore_code_interpreter.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderTruncationConfigSlidingWindow
{
    /// <summary>Number of recent messages to keep in the conversation window.</summary>
    [JsonPropertyName("messagesCount")]
    public double? MessagesCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderTruncationConfigSummarization
{
    /// <summary>Number of recent messages to preserve without summarization.</summary>
    [JsonPropertyName("preserveRecentMessages")]
    public double? PreserveRecentMessages { get; set; }

    /// <summary>Custom system prompt for the summarization model.</summary>
    [JsonPropertyName("summarizationSystemPrompt")]
    public string? SummarizationSystemPrompt { get; set; }

    /// <summary>Ratio of the conversation to summarize (0 to 1).</summary>
    [JsonPropertyName("summaryRatio")]
    public double? SummaryRatio { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderTruncationConfig
{
    /// <summary>Sliding window truncation configuration. See sliding_window below.</summary>
    [JsonPropertyName("slidingWindow")]
    public IList<V1beta1HarnessSpecInitProviderTruncationConfigSlidingWindow>? SlidingWindow { get; set; }

    /// <summary>Summarization truncation configuration. See summarization below.</summary>
    [JsonPropertyName("summarization")]
    public IList<V1beta1HarnessSpecInitProviderTruncationConfigSummarization>? Summarization { get; set; }
}

/// <summary>Truncation configuration for conversation history. See truncation below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecInitProviderTruncation
{
    /// <summary>Strategy-specific configuration. See truncation config below.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1HarnessSpecInitProviderTruncationConfig>? Config { get; set; }

    /// <summary>Truncation strategy. Valid values: sliding_window, summarization, none.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
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
public partial class V1beta1HarnessSpecInitProvider
{
    /// <summary>List of tool names allowed for the harness. Use [&quot;*&quot;] to allow all tools.</summary>
    [JsonPropertyName("allowedTools")]
    public IList<string>? AllowedTools { get; set; }

    /// <summary>Authorization configuration for authenticating requests. See authorizer_configuration below.</summary>
    [JsonPropertyName("authorizerConfiguration")]
    public V1beta1HarnessSpecInitProviderAuthorizerConfiguration? AuthorizerConfiguration { get; set; }

    /// <summary>Compute environment configuration. See environment below.</summary>
    [JsonPropertyName("environment")]
    public V1beta1HarnessSpecInitProviderEnvironment? Environment { get; set; }

    /// <summary>Environment artifact configuration. See environment_artifact below.</summary>
    [JsonPropertyName("environmentArtifact")]
    public V1beta1HarnessSpecInitProviderEnvironmentArtifact? EnvironmentArtifact { get; set; }

    [JsonPropertyName("environmentVariablesSecretRef")]
    public IDictionary<string, string>? EnvironmentVariablesSecretRef { get; set; }

    /// <summary>ARN of the IAM role that the harness assumes to access AWS services.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1HarnessSpecInitProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1HarnessSpecInitProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>Name of the harness. Must be 1-40 characters, alphanumeric and underscores only.</summary>
    [JsonPropertyName("harnessName")]
    public string? HarnessName { get; set; }

    /// <summary>Maximum number of iterations the agent loop can perform.</summary>
    [JsonPropertyName("maxIterations")]
    public double? MaxIterations { get; set; }

    /// <summary>Maximum number of tokens in the model response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Memory configuration. See memory below.</summary>
    [JsonPropertyName("memory")]
    public V1beta1HarnessSpecInitProviderMemory? Memory { get; set; }

    /// <summary>Model configuration for the harness. See model below.</summary>
    [JsonPropertyName("model")]
    public V1beta1HarnessSpecInitProviderModel? Model { get; set; }

    /// <summary>Skill configurations. See skill below.</summary>
    [JsonPropertyName("skill")]
    public IList<V1beta1HarnessSpecInitProviderSkill>? Skill { get; set; }

    /// <summary>System prompt blocks for the harness. See system_prompt below.</summary>
    [JsonPropertyName("systemPrompt")]
    public IList<V1beta1HarnessSpecInitProviderSystemPrompt>? SystemPrompt { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Timeout in seconds for the harness execution.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>Tool configurations. See tool below.</summary>
    [JsonPropertyName("tool")]
    public IList<V1beta1HarnessSpecInitProviderTool>? Tool { get; set; }

    /// <summary>Truncation configuration for conversation history. See truncation below.</summary>
    [JsonPropertyName("truncation")]
    public V1beta1HarnessSpecInitProviderTruncation? Truncation { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecManagementPoliciesEnum>))]
public enum V1beta1HarnessSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1HarnessSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HarnessSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1HarnessSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1HarnessSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1HarnessSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HarnessSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>HarnessSpec defines the desired state of Harness</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessSpec
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
    public V1beta1HarnessSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1HarnessSpecForProvider ForProvider { get; set; }

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
    public V1beta1HarnessSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1HarnessSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HarnessSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HarnessSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment
{
    /// <summary>ARN of the hosting environment.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>Configuration restricting which workloads may use this authorizer. See allowed_workload_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration
{
    /// <summary>Hosting environments allowed to use the authorizer. Between 1 and 10 entries. See hosting_environment below.</summary>
    [JsonPropertyName("hostingEnvironment")]
    public IList<V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment>? HostingEnvironment { get; set; }

    /// <summary>List of workload identity names allowed to use the authorizer. Between 1 and 10 entries.</summary>
    [JsonPropertyName("workloadIdentities")]
    public IList<string>? WorkloadIdentities { get; set; }
}

/// <summary>Value or values to match for. See claim_match_value below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue
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
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
{
    /// <summary>Relationship between the claim field value and the value or values to match for. Valid values are EQUALS, CONTAINS, and CONTAINS_ANY. EQUALS can be used only when inbound_token_claim_value_type is STRING. CONTAINS or CONTAINS_ANY can be used only when inbound_token_claim_value_type is STRING_ARRAY.</summary>
    [JsonPropertyName("claimMatchOperator")]
    public string? ClaimMatchOperator { get; set; }

    /// <summary>Value or values to match for. See claim_match_value below.</summary>
    [JsonPropertyName("claimMatchValue")]
    public V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue? ClaimMatchValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
{
    /// <summary>Configuration block to define the value or values to match for and the relationship of the match. See authorizing_claim_match_value below.</summary>
    [JsonPropertyName("authorizingClaimMatchValue")]
    public V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue? AuthorizingClaimMatchValue { get; set; }

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
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource
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
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint used to reach the authorization server. See private_endpoint below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint
{
    /// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

/// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointManagedVpcResource
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
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint configuration. See private_endpoint below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpoint
{
    /// <summary>Managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides
{
    /// <summary>Domain the override applies to.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Private endpoint configuration. See private_endpoint below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpoint? PrivateEndpoint { get; set; }
}

/// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizer
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
    public V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration? AllowedWorkloadConfiguration { get; set; }

    /// <summary>Repeatable block to define a custom claim validation name, value, and operation. See custom_claim below.</summary>
    [JsonPropertyName("customClaim")]
    public IList<V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerCustomClaim>? CustomClaim { get; set; }

    /// <summary>URL used to fetch OpenID Connect configuration or authorization server metadata. Must end with .well-known/openid-configuration.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Private endpoint used to reach the authorization server. See private_endpoint below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Overrides for the private endpoints used to reach the authorization server. See private_endpoint_overrides below.</summary>
    [JsonPropertyName("privateEndpointOverrides")]
    public IList<V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides>? PrivateEndpointOverrides { get; set; }
}

/// <summary>Authorization configuration for authenticating requests. See authorizer_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderAuthorizerConfiguration
{
    /// <summary>JWT-based authorization configuration block. See custom_jwt_authorizer below.</summary>
    [JsonPropertyName("customJwtAuthorizer")]
    public V1beta1HarnessStatusAtProviderAuthorizerConfigurationCustomJwtAuthorizer? CustomJwtAuthorizer { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint
{
    /// <summary>ARN of the Amazon S3 Files access point to mount into the agent runtime.</summary>
    [JsonPropertyName("accessPointArn")]
    public string? AccessPointArn { get; set; }

    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPoint
{
    /// <summary>ARN of the Amazon S3 Files access point to mount into the agent runtime.</summary>
    [JsonPropertyName("accessPointArn")]
    public string? AccessPointArn { get; set; }

    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationSessionStorage
{
    /// <summary>Mount path for the S3 Files access point inside the agent runtime. Must be under /mnt with exactly one subdirectory level (for example, /mnt/data).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfiguration
{
    /// <summary>Amazon EFS access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See efs_access_point below.</summary>
    [JsonPropertyName("efsAccessPoint")]
    public IList<V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint>? EfsAccessPoint { get; set; }

    /// <summary>Amazon S3 Files access point to mount as shared file storage. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See s3_files_access_point below.</summary>
    [JsonPropertyName("s3FilesAccessPoint")]
    public IList<V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationS3FilesAccessPoint>? S3FilesAccessPoint { get; set; }

    /// <summary>Session storage filesystem providing persistent storage across agent runtime session invocations. Exactly one of session_storage, s3_files_access_point, or efs_access_point must be specified. See session_storage below.</summary>
    [JsonPropertyName("sessionStorage")]
    public IList<V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationSessionStorage>? SessionStorage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentLifecycleConfiguration
{
    /// <summary>Timeout in seconds for idle sessions.</summary>
    [JsonPropertyName("idleRuntimeSessionTimeout")]
    public double? IdleRuntimeSessionTimeout { get; set; }

    /// <summary>Maximum lifetime of the instance in seconds.</summary>
    [JsonPropertyName("maxLifetime")]
    public double? MaxLifetime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig
{
    /// <summary>Whether to require an S3 endpoint for the service in the VPC.</summary>
    [JsonPropertyName("requireServiceS3Endpoint")]
    public bool? RequireServiceS3Endpoint { get; set; }

    /// <summary>Security groups for the VPC.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Subnets for the VPC.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration
{
    /// <summary>Network mode. Valid values: PUBLIC, VPC.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>VPC configuration. See network_mode_config below.</summary>
    [JsonPropertyName("networkModeConfig")]
    public IList<V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig>? NetworkModeConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironment
{
    /// <summary>ARN of the AgentCore memory resource.</summary>
    [JsonPropertyName("agentRuntimeArn")]
    public string? AgentRuntimeArn { get; set; }

    [JsonPropertyName("agentRuntimeId")]
    public string? AgentRuntimeId { get; set; }

    [JsonPropertyName("agentRuntimeName")]
    public string? AgentRuntimeName { get; set; }

    /// <summary>Filesystem configurations. See filesystem_configuration below.</summary>
    [JsonPropertyName("filesystemConfiguration")]
    public IList<V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfiguration>? FilesystemConfiguration { get; set; }

    /// <summary>Lifecycle configuration. See lifecycle_configuration below.</summary>
    [JsonPropertyName("lifecycleConfiguration")]
    public IList<V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentLifecycleConfiguration>? LifecycleConfiguration { get; set; }

    /// <summary>Network configuration. See network_configuration below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironmentNetworkConfiguration>? NetworkConfiguration { get; set; }
}

/// <summary>Compute environment configuration. See environment below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderEnvironment
{
    /// <summary>AgentCore runtime environment configuration. See agentcore_runtime_environment below.</summary>
    [JsonPropertyName("agentcoreRuntimeEnvironment")]
    public IList<V1beta1HarnessStatusAtProviderEnvironmentAgentcoreRuntimeEnvironment>? AgentcoreRuntimeEnvironment { get; set; }
}

/// <summary>Container configuration. See container_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderEnvironmentArtifactContainerConfiguration
{
    /// <summary>URI of the container image.</summary>
    [JsonPropertyName("containerUri")]
    public string? ContainerUri { get; set; }
}

/// <summary>Environment artifact configuration. See environment_artifact below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderEnvironmentArtifact
{
    /// <summary>Container configuration. See container_configuration below.</summary>
    [JsonPropertyName("containerConfiguration")]
    public V1beta1HarnessStatusAtProviderEnvironmentArtifactContainerConfiguration? ContainerConfiguration { get; set; }
}

/// <summary>Retrieval configuration parameters. See retrieval_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderMemoryAgentcoreMemoryConfigurationRetrievalConfig
{
    /// <summary>Key for the retrieval configuration map block.</summary>
    [JsonPropertyName("mapBlockKey")]
    public string? MapBlockKey { get; set; }

    /// <summary>Relevance score threshold. Valid value is between 0 and 1.</summary>
    [JsonPropertyName("relevanceScore")]
    public double? RelevanceScore { get; set; }

    /// <summary>ID of the memory strategy.</summary>
    [JsonPropertyName("strategyId")]
    public string? StrategyId { get; set; }

    /// <summary>Top-k sampling parameter.</summary>
    [JsonPropertyName("topK")]
    public double? TopK { get; set; }
}

/// <summary>AgentCore memory configuration. See agentcore_memory_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderMemoryAgentcoreMemoryConfiguration
{
    /// <summary>Actor ID for memory sessions.</summary>
    [JsonPropertyName("actorId")]
    public string? ActorId { get; set; }

    /// <summary>ARN of the hosting environment.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Number of recent messages to keep in the conversation window.</summary>
    [JsonPropertyName("messagesCount")]
    public double? MessagesCount { get; set; }

    /// <summary>Retrieval configuration parameters. See retrieval_config below.</summary>
    [JsonPropertyName("retrievalConfig")]
    public V1beta1HarnessStatusAtProviderMemoryAgentcoreMemoryConfigurationRetrievalConfig? RetrievalConfig { get; set; }
}

/// <summary>Memory configuration. See memory below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderMemory
{
    /// <summary>AgentCore memory configuration. See agentcore_memory_configuration below.</summary>
    [JsonPropertyName("agentcoreMemoryConfiguration")]
    public V1beta1HarnessStatusAtProviderMemoryAgentcoreMemoryConfiguration? AgentcoreMemoryConfiguration { get; set; }
}

/// <summary>Amazon Bedrock model configuration. See bedrock_model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderModelBedrockModelConfig
{
    /// <summary>Maximum number of tokens in the model response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Bedrock model ID (e.g., anthropic.claude-sonnet-4-20250514).</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Temperature for sampling. Must be between 0 and 2.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Top-p (nucleus) sampling parameter. Must be between 0 and 1.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Gemini model configuration. See gemini_model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderModelGeminiModelConfig
{
    /// <summary>ARN of the secret containing the API key.</summary>
    [JsonPropertyName("apiKeyArn")]
    public string? ApiKeyArn { get; set; }

    /// <summary>Maximum number of tokens in the model response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Bedrock model ID (e.g., anthropic.claude-sonnet-4-20250514).</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Temperature for sampling. Must be between 0 and 2.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Top-k sampling parameter.</summary>
    [JsonPropertyName("topK")]
    public double? TopK { get; set; }

    /// <summary>Top-p (nucleus) sampling parameter. Must be between 0 and 1.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>OpenAI model configuration. See openai_model_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderModelOpenaiModelConfig
{
    /// <summary>ARN of the secret containing the API key.</summary>
    [JsonPropertyName("apiKeyArn")]
    public string? ApiKeyArn { get; set; }

    /// <summary>Maximum number of tokens in the model response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Bedrock model ID (e.g., anthropic.claude-sonnet-4-20250514).</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>Temperature for sampling. Must be between 0 and 2.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Top-p (nucleus) sampling parameter. Must be between 0 and 1.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Model configuration for the harness. See model below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderModel
{
    /// <summary>Amazon Bedrock model configuration. See bedrock_model_config below.</summary>
    [JsonPropertyName("bedrockModelConfig")]
    public V1beta1HarnessStatusAtProviderModelBedrockModelConfig? BedrockModelConfig { get; set; }

    /// <summary>Gemini model configuration. See gemini_model_config below.</summary>
    [JsonPropertyName("geminiModelConfig")]
    public V1beta1HarnessStatusAtProviderModelGeminiModelConfig? GeminiModelConfig { get; set; }

    /// <summary>OpenAI model configuration. See openai_model_config below.</summary>
    [JsonPropertyName("openaiModelConfig")]
    public V1beta1HarnessStatusAtProviderModelOpenaiModelConfig? OpenaiModelConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderSkill
{
    /// <summary>Path to the skill.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Text content of the system prompt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderSystemPromptTextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderSystemPrompt
{
    /// <summary>Text content of the system prompt.</summary>
    [JsonPropertyName("textSecretRef")]
    public V1beta1HarnessStatusAtProviderSystemPromptTextSecretRef? TextSecretRef { get; set; }
}

/// <summary>AgentCore browser configuration. See agentcore_browser below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderToolConfigAgentcoreBrowser
{
    /// <summary>ARN of the AgentCore browser resource.</summary>
    [JsonPropertyName("browserArn")]
    public string? BrowserArn { get; set; }
}

/// <summary>AgentCore code interpreter configuration. See agentcore_code_interpreter below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderToolConfigAgentcoreCodeInterpreter
{
    /// <summary>ARN of the AgentCore code interpreter resource.</summary>
    [JsonPropertyName("codeInterpreterArn")]
    public string? CodeInterpreterArn { get; set; }
}

/// <summary>OAuth credential provider configuration. See oauth below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderToolConfigAgentcoreGatewayOutboundAuthOauth
{
    /// <summary>Map of custom parameters.</summary>
    [JsonPropertyName("customParameters")]
    public IDictionary<string, string>? CustomParameters { get; set; }

    /// <summary>Default return URL for OAuth flow.</summary>
    [JsonPropertyName("defaultReturnUrl")]
    public string? DefaultReturnUrl { get; set; }

    /// <summary>OAuth grant type.</summary>
    [JsonPropertyName("grantType")]
    public string? GrantType { get; set; }

    /// <summary>ARN of the OAuth credential provider.</summary>
    [JsonPropertyName("providerArn")]
    public string? ProviderArn { get; set; }

    /// <summary>List of OAuth scopes.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Outbound authentication configuration. See outbound_auth below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderToolConfigAgentcoreGatewayOutboundAuth
{
    /// <summary>Set to true to use AWS IAM authentication.</summary>
    [JsonPropertyName("awsIam")]
    public bool? AwsIam { get; set; }

    /// <summary>Set to true to disable authentication.</summary>
    [JsonPropertyName("none")]
    public bool? None { get; set; }

    /// <summary>OAuth credential provider configuration. See oauth below.</summary>
    [JsonPropertyName("oauth")]
    public V1beta1HarnessStatusAtProviderToolConfigAgentcoreGatewayOutboundAuthOauth? Oauth { get; set; }
}

/// <summary>AgentCore gateway configuration. See agentcore_gateway below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderToolConfigAgentcoreGateway
{
    /// <summary>ARN of the AgentCore gateway resource.</summary>
    [JsonPropertyName("gatewayArn")]
    public string? GatewayArn { get; set; }

    /// <summary>Outbound authentication configuration. See outbound_auth below.</summary>
    [JsonPropertyName("outboundAuth")]
    public V1beta1HarnessStatusAtProviderToolConfigAgentcoreGatewayOutboundAuth? OutboundAuth { get; set; }
}

/// <summary>Inline function configuration. See inline_function below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderToolConfigInlineFunction
{
    /// <summary>Description of the inline function.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

/// <summary>Map of HTTP headers to include in requests to the MCP server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderToolConfigRemoteMcpHeadersSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>URL of the remote MCP server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderToolConfigRemoteMcpUrlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Remote MCP server configuration. See remote_mcp below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderToolConfigRemoteMcp
{
    /// <summary>Map of HTTP headers to include in requests to the MCP server.</summary>
    [JsonPropertyName("headersSecretRef")]
    public V1beta1HarnessStatusAtProviderToolConfigRemoteMcpHeadersSecretRef? HeadersSecretRef { get; set; }

    /// <summary>URL of the remote MCP server.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1beta1HarnessStatusAtProviderToolConfigRemoteMcpUrlSecretRef? UrlSecretRef { get; set; }
}

/// <summary>Tool-specific configuration. See tool config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderToolConfig
{
    /// <summary>AgentCore browser configuration. See agentcore_browser below.</summary>
    [JsonPropertyName("agentcoreBrowser")]
    public V1beta1HarnessStatusAtProviderToolConfigAgentcoreBrowser? AgentcoreBrowser { get; set; }

    /// <summary>AgentCore code interpreter configuration. See agentcore_code_interpreter below.</summary>
    [JsonPropertyName("agentcoreCodeInterpreter")]
    public V1beta1HarnessStatusAtProviderToolConfigAgentcoreCodeInterpreter? AgentcoreCodeInterpreter { get; set; }

    /// <summary>AgentCore gateway configuration. See agentcore_gateway below.</summary>
    [JsonPropertyName("agentcoreGateway")]
    public V1beta1HarnessStatusAtProviderToolConfigAgentcoreGateway? AgentcoreGateway { get; set; }

    /// <summary>Inline function configuration. See inline_function below.</summary>
    [JsonPropertyName("inlineFunction")]
    public V1beta1HarnessStatusAtProviderToolConfigInlineFunction? InlineFunction { get; set; }

    /// <summary>Remote MCP server configuration. See remote_mcp below.</summary>
    [JsonPropertyName("remoteMcp")]
    public V1beta1HarnessStatusAtProviderToolConfigRemoteMcp? RemoteMcp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderTool
{
    /// <summary>Tool-specific configuration. See tool config below.</summary>
    [JsonPropertyName("config")]
    public V1beta1HarnessStatusAtProviderToolConfig? Config { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of tool. Valid values: remote_mcp, agentcore_browser, agentcore_gateway, inline_function, agentcore_code_interpreter.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderTruncationConfigSlidingWindow
{
    /// <summary>Number of recent messages to keep in the conversation window.</summary>
    [JsonPropertyName("messagesCount")]
    public double? MessagesCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderTruncationConfigSummarization
{
    /// <summary>Number of recent messages to preserve without summarization.</summary>
    [JsonPropertyName("preserveRecentMessages")]
    public double? PreserveRecentMessages { get; set; }

    /// <summary>Custom system prompt for the summarization model.</summary>
    [JsonPropertyName("summarizationSystemPrompt")]
    public string? SummarizationSystemPrompt { get; set; }

    /// <summary>Ratio of the conversation to summarize (0 to 1).</summary>
    [JsonPropertyName("summaryRatio")]
    public double? SummaryRatio { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderTruncationConfig
{
    /// <summary>Sliding window truncation configuration. See sliding_window below.</summary>
    [JsonPropertyName("slidingWindow")]
    public IList<V1beta1HarnessStatusAtProviderTruncationConfigSlidingWindow>? SlidingWindow { get; set; }

    /// <summary>Summarization truncation configuration. See summarization below.</summary>
    [JsonPropertyName("summarization")]
    public IList<V1beta1HarnessStatusAtProviderTruncationConfigSummarization>? Summarization { get; set; }
}

/// <summary>Truncation configuration for conversation history. See truncation below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProviderTruncation
{
    /// <summary>Strategy-specific configuration. See truncation config below.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1HarnessStatusAtProviderTruncationConfig>? Config { get; set; }

    /// <summary>Truncation strategy. Valid values: sliding_window, summarization, none.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusAtProvider
{
    /// <summary>List of tool names allowed for the harness. Use [&quot;*&quot;] to allow all tools.</summary>
    [JsonPropertyName("allowedTools")]
    public IList<string>? AllowedTools { get; set; }

    /// <summary>ARN of the AgentCore memory resource.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Authorization configuration for authenticating requests. See authorizer_configuration below.</summary>
    [JsonPropertyName("authorizerConfiguration")]
    public V1beta1HarnessStatusAtProviderAuthorizerConfiguration? AuthorizerConfiguration { get; set; }

    /// <summary>Compute environment configuration. See environment below.</summary>
    [JsonPropertyName("environment")]
    public V1beta1HarnessStatusAtProviderEnvironment? Environment { get; set; }

    /// <summary>Environment artifact configuration. See environment_artifact below.</summary>
    [JsonPropertyName("environmentArtifact")]
    public V1beta1HarnessStatusAtProviderEnvironmentArtifact? EnvironmentArtifact { get; set; }

    /// <summary>ARN of the IAM role that the harness assumes to access AWS services.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Unique identifier of the Harness.</summary>
    [JsonPropertyName("harnessId")]
    public string? HarnessId { get; set; }

    /// <summary>Name of the harness. Must be 1-40 characters, alphanumeric and underscores only.</summary>
    [JsonPropertyName("harnessName")]
    public string? HarnessName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Maximum number of iterations the agent loop can perform.</summary>
    [JsonPropertyName("maxIterations")]
    public double? MaxIterations { get; set; }

    /// <summary>Maximum number of tokens in the model response.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Memory configuration. See memory below.</summary>
    [JsonPropertyName("memory")]
    public V1beta1HarnessStatusAtProviderMemory? Memory { get; set; }

    /// <summary>Model configuration for the harness. See model below.</summary>
    [JsonPropertyName("model")]
    public V1beta1HarnessStatusAtProviderModel? Model { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Skill configurations. See skill below.</summary>
    [JsonPropertyName("skill")]
    public IList<V1beta1HarnessStatusAtProviderSkill>? Skill { get; set; }

    /// <summary>System prompt blocks for the harness. See system_prompt below.</summary>
    [JsonPropertyName("systemPrompt")]
    public IList<V1beta1HarnessStatusAtProviderSystemPrompt>? SystemPrompt { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Timeout in seconds for the harness execution.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>Tool configurations. See tool below.</summary>
    [JsonPropertyName("tool")]
    public IList<V1beta1HarnessStatusAtProviderTool>? Tool { get; set; }

    /// <summary>Truncation configuration for conversation history. See truncation below.</summary>
    [JsonPropertyName("truncation")]
    public V1beta1HarnessStatusAtProviderTruncation? Truncation { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatusConditions
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

/// <summary>HarnessStatus defines the observed state of Harness.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HarnessStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1HarnessStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HarnessStatusConditions>? Conditions { get; set; }

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

/// <summary>Harness is the Schema for the Harnesss API. Manages an AWS Bedrock AgentCore Harness.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Harness : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HarnessSpec>, IStatus<V1beta1HarnessStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Harness";
    public const string KubeGroup = "bedrockagentcore.aws.upbound.io";
    public const string KubePluralName = "harnesses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Harness";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HarnessSpec defines the desired state of Harness</summary>
    [JsonPropertyName("spec")]
    public required V1beta1HarnessSpec Spec { get; set; }

    /// <summary>HarnessStatus defines the observed state of Harness.</summary>
    [JsonPropertyName("status")]
    public V1beta1HarnessStatus? Status { get; set; }
}