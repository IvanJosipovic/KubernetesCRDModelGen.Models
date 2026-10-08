#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.agentregistry.aws.m.upbound.io;
/// <summary>Registry is the Schema for the Registrys API. Manages an AWS Agent Registry registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegistryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Registry>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegistryList";
    public const string KubeGroup = "agentregistry.aws.m.upbound.io";
    public const string KubePluralName = "registries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "agentregistry.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegistryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Registry objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Registry> Items { get; set; }
}

/// <summary>Approval configuration for registry records. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderApprovalConfiguration
{
    /// <summary>Set of rules that determine which registry records are automatically approved on submission. Valid values: APPROVE_ALL. When omitted or empty, submitted records require manual review.</summary>
    [JsonPropertyName("autoApprovalRules")]
    public IList<string>? AutoApprovalRules { get; set; }
}

/// <summary>Auto-detection configuration for the registry. When provided, the registry is automatically populated with resources discovered according to the configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderAutoDetectionConfiguration
{
    /// <summary>Whether auto-detection is requested for the registry.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Source from which resources are detected. Valid values: ORGANIZATION.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Value to match against. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue
{
    /// <summary>Single string value to match. Must contain only letters, numbers, and the characters _, ., -, :.</summary>
    [JsonPropertyName("matchValueString")]
    public string? MatchValueString { get; set; }

    /// <summary>Set of string values to match. Each value must contain only letters, numbers, and the characters _, ., -, :.</summary>
    [JsonPropertyName("matchValueStringList")]
    public IList<string>? MatchValueStringList { get; set; }
}

/// <summary>Claim match criteria. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
{
    /// <summary>Operator used to match claim values. Valid values: EQUALS, CONTAINS, CONTAINS_ANY.</summary>
    [JsonPropertyName("claimMatchOperator")]
    public string? ClaimMatchOperator { get; set; }

    /// <summary>Value to match against. See below.</summary>
    [JsonPropertyName("claimMatchValue")]
    public V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue? ClaimMatchValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
{
    /// <summary>Claim match criteria. See below.</summary>
    [JsonPropertyName("authorizingClaimMatchValue")]
    public V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue? AuthorizingClaimMatchValue { get; set; }

    /// <summary>Name of the claim to validate in the inbound JWT token. Must contain only letters, numbers, and the characters _, ., -, :.</summary>
    [JsonPropertyName("inboundTokenClaimName")]
    public string? InboundTokenClaimName { get; set; }

    /// <summary>Type of the claim value. Valid values: STRING, STRING_ARRAY.</summary>
    [JsonPropertyName("inboundTokenClaimValueType")]
    public string? InboundTokenClaimValueType { get; set; }
}

/// <summary>Private endpoint backed by a service-managed VPC resource. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource
{
    /// <summary>IP address type used by the private endpoint, either IPV4 or IPV6.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain used to resolve traffic through the private endpoint.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>IDs of the security groups associated with the private endpoint network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>IDs of the subnets in which the private endpoint network interfaces are placed.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ID of the VPC in which the private endpoint is provisioned.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Private endpoint backed by a self-managed VPC Lattice resource configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration, specified as a resource configuration ID or ARN.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint used to reach the identity provider&apos;s discovery URL over a private network path. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint
{
    /// <summary>Private endpoint backed by a service-managed VPC resource. See below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Private endpoint backed by a self-managed VPC Lattice resource configuration. See below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

/// <summary>Private endpoint backed by a service-managed VPC resource. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpointManagedVpcResource
{
    /// <summary>IP address type used by the private endpoint, either IPV4 or IPV6.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain used to resolve traffic through the private endpoint.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>IDs of the security groups associated with the private endpoint network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>IDs of the subnets in which the private endpoint network interfaces are placed.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ID of the VPC in which the private endpoint is provisioned.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Private endpoint backed by a self-managed VPC Lattice resource configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration, specified as a resource configuration ID or ARN.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint used to reach the specified domain. See above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpoint
{
    /// <summary>Private endpoint backed by a service-managed VPC resource. See below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Private endpoint backed by a self-managed VPC Lattice resource configuration. See below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverride
{
    /// <summary>Domain name to which this private endpoint override applies.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Private endpoint used to reach the specified domain. See above.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpoint? PrivateEndpoint { get; set; }
}

/// <summary>Configuration for a custom JWT authorizer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizer
{
    /// <summary>Audience values accepted during JWT validation. A token is rejected if none of its audience claims match.</summary>
    [JsonPropertyName("allowedAudience")]
    public IList<string>? AllowedAudience { get; set; }

    /// <summary>Client identifiers accepted during JWT validation. A token is rejected if it was not issued to one of these clients.</summary>
    [JsonPropertyName("allowedClients")]
    public IList<string>? AllowedClients { get; set; }

    /// <summary>Scopes accepted during JWT validation. A token is rejected if it does not carry one of these scopes.</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }

    /// <summary>Custom claims for additional JWT validation beyond standard OIDC claims. See below.</summary>
    [JsonPropertyName("customClaim")]
    public IList<V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaim>? CustomClaim { get; set; }

    /// <summary>OpenID Connect discovery URL used to retrieve the identity provider&apos;s metadata and signing keys.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Private endpoint used to reach the identity provider&apos;s discovery URL over a private network path. See below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Per-domain private endpoint overrides that route specific identity provider domains through distinct private endpoints. See below.</summary>
    [JsonPropertyName("privateEndpointOverride")]
    public IList<V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverride>? PrivateEndpointOverride { get; set; }
}

/// <summary>Authorizer configuration for the registry. Required when authorizer_type is CUSTOM_JWT. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfiguration
{
    /// <summary>Configuration for a custom JWT authorizer.</summary>
    [JsonPropertyName("customJwtAuthorizer")]
    public V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizer? CustomJwtAuthorizer { get; set; }
}

/// <summary>Discovery configuration for the registry. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderDiscoveryConfiguration
{
    /// <summary>Authorizer configuration for the registry. Required when authorizer_type is CUSTOM_JWT. See below.</summary>
    [JsonPropertyName("authorizerConfiguration")]
    public V1beta1RegistrySpecForProviderDiscoveryConfigurationAuthorizerConfiguration? AuthorizerConfiguration { get; set; }

    /// <summary>Type of authorizer that controls how consumers access the registry&apos;s search and MCP invoke operations. Valid values: AWS_IAM, CUSTOM_JWT.</summary>
    [JsonPropertyName("authorizerType")]
    public string? AuthorizerType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Server-side encryption configuration for the registry. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProviderEncryptionConfiguration
{
    /// <summary>ARN of the customer-managed AWS KMS key used to encrypt the registry&apos;s content.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1RegistrySpecForProviderEncryptionConfigurationKmsKeyArnSelector? KmsKeyArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecForProvider
{
    /// <summary>Approval configuration for registry records. See below.</summary>
    [JsonPropertyName("approvalConfiguration")]
    public V1beta1RegistrySpecForProviderApprovalConfiguration? ApprovalConfiguration { get; set; }

    /// <summary>Auto-detection configuration for the registry. When provided, the registry is automatically populated with resources discovered according to the configuration. See below.</summary>
    [JsonPropertyName("autoDetectionConfiguration")]
    public V1beta1RegistrySpecForProviderAutoDetectionConfiguration? AutoDetectionConfiguration { get; set; }

    /// <summary>Description of the registry. Maximum length of 4096 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Discovery configuration for the registry. See below.</summary>
    [JsonPropertyName("discoveryConfiguration")]
    public V1beta1RegistrySpecForProviderDiscoveryConfiguration? DiscoveryConfiguration { get; set; }

    /// <summary>Server-side encryption configuration for the registry. See below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1RegistrySpecForProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Name of the registry. Must start with a letter or digit. Valid characters are a-z, A-Z, 0-9, _ (underscore), - (hyphen), . (dot), and / (forward slash). The name can have up to 64 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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

/// <summary>Approval configuration for registry records. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderApprovalConfiguration
{
    /// <summary>Set of rules that determine which registry records are automatically approved on submission. Valid values: APPROVE_ALL. When omitted or empty, submitted records require manual review.</summary>
    [JsonPropertyName("autoApprovalRules")]
    public IList<string>? AutoApprovalRules { get; set; }
}

/// <summary>Auto-detection configuration for the registry. When provided, the registry is automatically populated with resources discovered according to the configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderAutoDetectionConfiguration
{
    /// <summary>Whether auto-detection is requested for the registry.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Source from which resources are detected. Valid values: ORGANIZATION.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Value to match against. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue
{
    /// <summary>Single string value to match. Must contain only letters, numbers, and the characters _, ., -, :.</summary>
    [JsonPropertyName("matchValueString")]
    public string? MatchValueString { get; set; }

    /// <summary>Set of string values to match. Each value must contain only letters, numbers, and the characters _, ., -, :.</summary>
    [JsonPropertyName("matchValueStringList")]
    public IList<string>? MatchValueStringList { get; set; }
}

/// <summary>Claim match criteria. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
{
    /// <summary>Operator used to match claim values. Valid values: EQUALS, CONTAINS, CONTAINS_ANY.</summary>
    [JsonPropertyName("claimMatchOperator")]
    public string? ClaimMatchOperator { get; set; }

    /// <summary>Value to match against. See below.</summary>
    [JsonPropertyName("claimMatchValue")]
    public V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue? ClaimMatchValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
{
    /// <summary>Claim match criteria. See below.</summary>
    [JsonPropertyName("authorizingClaimMatchValue")]
    public V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue? AuthorizingClaimMatchValue { get; set; }

    /// <summary>Name of the claim to validate in the inbound JWT token. Must contain only letters, numbers, and the characters _, ., -, :.</summary>
    [JsonPropertyName("inboundTokenClaimName")]
    public string? InboundTokenClaimName { get; set; }

    /// <summary>Type of the claim value. Valid values: STRING, STRING_ARRAY.</summary>
    [JsonPropertyName("inboundTokenClaimValueType")]
    public string? InboundTokenClaimValueType { get; set; }
}

/// <summary>Private endpoint backed by a service-managed VPC resource. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource
{
    /// <summary>IP address type used by the private endpoint, either IPV4 or IPV6.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain used to resolve traffic through the private endpoint.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>IDs of the security groups associated with the private endpoint network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>IDs of the subnets in which the private endpoint network interfaces are placed.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ID of the VPC in which the private endpoint is provisioned.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Private endpoint backed by a self-managed VPC Lattice resource configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration, specified as a resource configuration ID or ARN.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint used to reach the identity provider&apos;s discovery URL over a private network path. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint
{
    /// <summary>Private endpoint backed by a service-managed VPC resource. See below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Private endpoint backed by a self-managed VPC Lattice resource configuration. See below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

/// <summary>Private endpoint backed by a service-managed VPC resource. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpointManagedVpcResource
{
    /// <summary>IP address type used by the private endpoint, either IPV4 or IPV6.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain used to resolve traffic through the private endpoint.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>IDs of the security groups associated with the private endpoint network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>IDs of the subnets in which the private endpoint network interfaces are placed.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ID of the VPC in which the private endpoint is provisioned.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Private endpoint backed by a self-managed VPC Lattice resource configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration, specified as a resource configuration ID or ARN.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint used to reach the specified domain. See above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpoint
{
    /// <summary>Private endpoint backed by a service-managed VPC resource. See below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Private endpoint backed by a self-managed VPC Lattice resource configuration. See below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverride
{
    /// <summary>Domain name to which this private endpoint override applies.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Private endpoint used to reach the specified domain. See above.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpoint? PrivateEndpoint { get; set; }
}

/// <summary>Configuration for a custom JWT authorizer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizer
{
    /// <summary>Audience values accepted during JWT validation. A token is rejected if none of its audience claims match.</summary>
    [JsonPropertyName("allowedAudience")]
    public IList<string>? AllowedAudience { get; set; }

    /// <summary>Client identifiers accepted during JWT validation. A token is rejected if it was not issued to one of these clients.</summary>
    [JsonPropertyName("allowedClients")]
    public IList<string>? AllowedClients { get; set; }

    /// <summary>Scopes accepted during JWT validation. A token is rejected if it does not carry one of these scopes.</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }

    /// <summary>Custom claims for additional JWT validation beyond standard OIDC claims. See below.</summary>
    [JsonPropertyName("customClaim")]
    public IList<V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaim>? CustomClaim { get; set; }

    /// <summary>OpenID Connect discovery URL used to retrieve the identity provider&apos;s metadata and signing keys.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Private endpoint used to reach the identity provider&apos;s discovery URL over a private network path. See below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Per-domain private endpoint overrides that route specific identity provider domains through distinct private endpoints. See below.</summary>
    [JsonPropertyName("privateEndpointOverride")]
    public IList<V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverride>? PrivateEndpointOverride { get; set; }
}

/// <summary>Authorizer configuration for the registry. Required when authorizer_type is CUSTOM_JWT. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfiguration
{
    /// <summary>Configuration for a custom JWT authorizer.</summary>
    [JsonPropertyName("customJwtAuthorizer")]
    public V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizer? CustomJwtAuthorizer { get; set; }
}

/// <summary>Discovery configuration for the registry. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderDiscoveryConfiguration
{
    /// <summary>Authorizer configuration for the registry. Required when authorizer_type is CUSTOM_JWT. See below.</summary>
    [JsonPropertyName("authorizerConfiguration")]
    public V1beta1RegistrySpecInitProviderDiscoveryConfigurationAuthorizerConfiguration? AuthorizerConfiguration { get; set; }

    /// <summary>Type of authorizer that controls how consumers access the registry&apos;s search and MCP invoke operations. Valid values: AWS_IAM, CUSTOM_JWT.</summary>
    [JsonPropertyName("authorizerType")]
    public string? AuthorizerType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Server-side encryption configuration for the registry. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecInitProviderEncryptionConfiguration
{
    /// <summary>ARN of the customer-managed AWS KMS key used to encrypt the registry&apos;s content.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1RegistrySpecInitProviderEncryptionConfigurationKmsKeyArnSelector? KmsKeyArnSelector { get; set; }
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
public partial class V1beta1RegistrySpecInitProvider
{
    /// <summary>Approval configuration for registry records. See below.</summary>
    [JsonPropertyName("approvalConfiguration")]
    public V1beta1RegistrySpecInitProviderApprovalConfiguration? ApprovalConfiguration { get; set; }

    /// <summary>Auto-detection configuration for the registry. When provided, the registry is automatically populated with resources discovered according to the configuration. See below.</summary>
    [JsonPropertyName("autoDetectionConfiguration")]
    public V1beta1RegistrySpecInitProviderAutoDetectionConfiguration? AutoDetectionConfiguration { get; set; }

    /// <summary>Description of the registry. Maximum length of 4096 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Discovery configuration for the registry. See below.</summary>
    [JsonPropertyName("discoveryConfiguration")]
    public V1beta1RegistrySpecInitProviderDiscoveryConfiguration? DiscoveryConfiguration { get; set; }

    /// <summary>Server-side encryption configuration for the registry. See below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1RegistrySpecInitProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Name of the registry. Must start with a letter or digit. Valid characters are a-z, A-Z, 0-9, _ (underscore), - (hyphen), . (dot), and / (forward slash). The name can have up to 64 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistrySpecManagementPoliciesEnum>))]
public enum V1beta1RegistrySpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RegistrySpec defines the desired state of Registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistrySpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1RegistrySpecForProvider ForProvider { get; set; }

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
    public V1beta1RegistrySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RegistrySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegistrySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegistrySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Approval configuration for registry records. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderApprovalConfiguration
{
    /// <summary>Set of rules that determine which registry records are automatically approved on submission. Valid values: APPROVE_ALL. When omitted or empty, submitted records require manual review.</summary>
    [JsonPropertyName("autoApprovalRules")]
    public IList<string>? AutoApprovalRules { get; set; }
}

/// <summary>Auto-detection configuration for the registry. When provided, the registry is automatically populated with resources discovered according to the configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderAutoDetectionConfiguration
{
    /// <summary>Whether auto-detection is requested for the registry.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Source from which resources are detected. Valid values: ORGANIZATION.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Value to match against. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue
{
    /// <summary>Single string value to match. Must contain only letters, numbers, and the characters _, ., -, :.</summary>
    [JsonPropertyName("matchValueString")]
    public string? MatchValueString { get; set; }

    /// <summary>Set of string values to match. Each value must contain only letters, numbers, and the characters _, ., -, :.</summary>
    [JsonPropertyName("matchValueStringList")]
    public IList<string>? MatchValueStringList { get; set; }
}

/// <summary>Claim match criteria. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue
{
    /// <summary>Operator used to match claim values. Valid values: EQUALS, CONTAINS, CONTAINS_ANY.</summary>
    [JsonPropertyName("claimMatchOperator")]
    public string? ClaimMatchOperator { get; set; }

    /// <summary>Value to match against. See below.</summary>
    [JsonPropertyName("claimMatchValue")]
    public V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValueClaimMatchValue? ClaimMatchValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaim
{
    /// <summary>Claim match criteria. See below.</summary>
    [JsonPropertyName("authorizingClaimMatchValue")]
    public V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaimAuthorizingClaimMatchValue? AuthorizingClaimMatchValue { get; set; }

    /// <summary>Name of the claim to validate in the inbound JWT token. Must contain only letters, numbers, and the characters _, ., -, :.</summary>
    [JsonPropertyName("inboundTokenClaimName")]
    public string? InboundTokenClaimName { get; set; }

    /// <summary>Type of the claim value. Valid values: STRING, STRING_ARRAY.</summary>
    [JsonPropertyName("inboundTokenClaimValueType")]
    public string? InboundTokenClaimValueType { get; set; }
}

/// <summary>Private endpoint backed by a service-managed VPC resource. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource
{
    /// <summary>IP address type used by the private endpoint, either IPV4 or IPV6.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain used to resolve traffic through the private endpoint.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>IDs of the security groups associated with the private endpoint network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>IDs of the subnets in which the private endpoint network interfaces are placed.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ID of the VPC in which the private endpoint is provisioned.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Private endpoint backed by a self-managed VPC Lattice resource configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration, specified as a resource configuration ID or ARN.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint used to reach the identity provider&apos;s discovery URL over a private network path. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint
{
    /// <summary>Private endpoint backed by a service-managed VPC resource. See below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Private endpoint backed by a self-managed VPC Lattice resource configuration. See below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

/// <summary>Private endpoint backed by a service-managed VPC resource. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpointManagedVpcResource
{
    /// <summary>IP address type used by the private endpoint, either IPV4 or IPV6.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain used to resolve traffic through the private endpoint.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>IDs of the security groups associated with the private endpoint network interfaces.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>IDs of the subnets in which the private endpoint network interfaces are placed.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ID of the VPC in which the private endpoint is provisioned.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Private endpoint backed by a self-managed VPC Lattice resource configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration, specified as a resource configuration ID or ARN.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint used to reach the specified domain. See above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpoint
{
    /// <summary>Private endpoint backed by a service-managed VPC resource. See below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Private endpoint backed by a self-managed VPC Lattice resource configuration. See below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverride
{
    /// <summary>Domain name to which this private endpoint override applies.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Private endpoint used to reach the specified domain. See above.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridePrivateEndpoint? PrivateEndpoint { get; set; }
}

/// <summary>Configuration for a custom JWT authorizer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizer
{
    /// <summary>Audience values accepted during JWT validation. A token is rejected if none of its audience claims match.</summary>
    [JsonPropertyName("allowedAudience")]
    public IList<string>? AllowedAudience { get; set; }

    /// <summary>Client identifiers accepted during JWT validation. A token is rejected if it was not issued to one of these clients.</summary>
    [JsonPropertyName("allowedClients")]
    public IList<string>? AllowedClients { get; set; }

    /// <summary>Scopes accepted during JWT validation. A token is rejected if it does not carry one of these scopes.</summary>
    [JsonPropertyName("allowedScopes")]
    public IList<string>? AllowedScopes { get; set; }

    /// <summary>Custom claims for additional JWT validation beyond standard OIDC claims. See below.</summary>
    [JsonPropertyName("customClaim")]
    public IList<V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerCustomClaim>? CustomClaim { get; set; }

    /// <summary>OpenID Connect discovery URL used to retrieve the identity provider&apos;s metadata and signing keys.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Private endpoint used to reach the identity provider&apos;s discovery URL over a private network path. See below.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Per-domain private endpoint overrides that route specific identity provider domains through distinct private endpoints. See below.</summary>
    [JsonPropertyName("privateEndpointOverride")]
    public IList<V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverride>? PrivateEndpointOverride { get; set; }
}

/// <summary>Authorizer configuration for the registry. Required when authorizer_type is CUSTOM_JWT. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfiguration
{
    /// <summary>Configuration for a custom JWT authorizer.</summary>
    [JsonPropertyName("customJwtAuthorizer")]
    public V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfigurationCustomJwtAuthorizer? CustomJwtAuthorizer { get; set; }
}

/// <summary>Discovery configuration for the registry. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderDiscoveryConfiguration
{
    /// <summary>Authorizer configuration for the registry. Required when authorizer_type is CUSTOM_JWT. See below.</summary>
    [JsonPropertyName("authorizerConfiguration")]
    public V1beta1RegistryStatusAtProviderDiscoveryConfigurationAuthorizerConfiguration? AuthorizerConfiguration { get; set; }

    /// <summary>Type of authorizer that controls how consumers access the registry&apos;s search and MCP invoke operations. Valid values: AWS_IAM, CUSTOM_JWT.</summary>
    [JsonPropertyName("authorizerType")]
    public string? AuthorizerType { get; set; }
}

/// <summary>Server-side encryption configuration for the registry. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProviderEncryptionConfiguration
{
    /// <summary>ARN of the customer-managed AWS KMS key used to encrypt the registry&apos;s content.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusAtProvider
{
    /// <summary>Approval configuration for registry records. See below.</summary>
    [JsonPropertyName("approvalConfiguration")]
    public V1beta1RegistryStatusAtProviderApprovalConfiguration? ApprovalConfiguration { get; set; }

    /// <summary>Auto-detection configuration for the registry. When provided, the registry is automatically populated with resources discovered according to the configuration. See below.</summary>
    [JsonPropertyName("autoDetectionConfiguration")]
    public V1beta1RegistryStatusAtProviderAutoDetectionConfiguration? AutoDetectionConfiguration { get; set; }

    /// <summary>Description of the registry. Maximum length of 4096 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Discovery configuration for the registry. See below.</summary>
    [JsonPropertyName("discoveryConfiguration")]
    public V1beta1RegistryStatusAtProviderDiscoveryConfiguration? DiscoveryConfiguration { get; set; }

    /// <summary>Server-side encryption configuration for the registry. See below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1RegistryStatusAtProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the registry. Must start with a letter or digit. Valid characters are a-z, A-Z, 0-9, _ (underscore), - (hyphen), . (dot), and / (forward slash). The name can have up to 64 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ARN of the registry.</summary>
    [JsonPropertyName("registryArn")]
    public string? RegistryArn { get; set; }

    /// <summary>Unique identifier of the registry.</summary>
    [JsonPropertyName("registryId")]
    public string? RegistryId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatusConditions
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

/// <summary>RegistryStatus defines the observed state of Registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegistryStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1RegistryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegistryStatusConditions>? Conditions { get; set; }

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

/// <summary>Registry is the Schema for the Registrys API. Manages an AWS Agent Registry registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Registry : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegistrySpec>, IStatus<V1beta1RegistryStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Registry";
    public const string KubeGroup = "agentregistry.aws.m.upbound.io";
    public const string KubePluralName = "registries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "agentregistry.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Registry";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegistrySpec defines the desired state of Registry</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RegistrySpec Spec { get; set; }

    /// <summary>RegistryStatus defines the observed state of Registry.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegistryStatus? Status { get; set; }
}