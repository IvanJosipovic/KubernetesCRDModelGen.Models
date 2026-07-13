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
/// <summary>GatewayTarget is the Schema for the GatewayTargets API. Manages an AWS Bedrock AgentCore Gateway Target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GatewayTargetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1GatewayTarget>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GatewayTargetList";
    public const string KubeGroup = "bedrockagentcore.aws.upbound.io";
    public const string KubePluralName = "gatewaytargets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GatewayTargetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1GatewayTarget objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1GatewayTarget> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecDeletionPolicyEnum>))]
public enum V1beta1GatewayTargetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>API key-based authentication configuration. See api_key below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderCredentialProviderConfigurationApiKey
{
    /// <summary>Location where the API key credential is provided. Valid values: HEADER, QUERY_PARAMETER.</summary>
    [JsonPropertyName("credentialLocation")]
    public string? CredentialLocation { get; set; }

    /// <summary>Name of the parameter containing the API key credential.</summary>
    [JsonPropertyName("credentialParameterName")]
    public string? CredentialParameterName { get; set; }

    /// <summary>Prefix to add to the API key credential value.</summary>
    [JsonPropertyName("credentialPrefix")]
    public string? CredentialPrefix { get; set; }

    /// <summary>ARN of the OIDC provider for API key authentication.</summary>
    [JsonPropertyName("providerArn")]
    public string? ProviderArn { get; set; }
}

/// <summary>Use the gateway&apos;s IAM role for authentication. This is an empty configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderCredentialProviderConfigurationGatewayIamRole
{
}

/// <summary>OAuth-based authentication configuration. See oauth below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderCredentialProviderConfigurationOauth
{
    /// <summary>Map of custom parameters to include in OAuth requests.</summary>
    [JsonPropertyName("customParameters")]
    public IDictionary<string, string>? CustomParameters { get; set; }

    /// <summary>
    /// The URL where the end user&apos;s browser is redirected after obtaining the authorization code. Required when grant_type is AUTHORIZATION_CODE.
    /// The URL where the end user&apos;s browser is redirected after obtaining the authorization code. Required when grant_type is AUTHORIZATION_CODE.
    /// </summary>
    [JsonPropertyName("defaultReturnUrl")]
    public string? DefaultReturnUrl { get; set; }

    /// <summary>
    /// The OAuth grant type. Valid values: CLIENT_CREDENTIALS (machine-to-machine authentication), AUTHORIZATION_CODE (user-delegated access).
    /// The OAuth grant type. Valid values are AUTHORIZATION_CODE and CLIENT_CREDENTIALS.
    /// </summary>
    [JsonPropertyName("grantType")]
    public string? GrantType { get; set; }

    /// <summary>ARN of the Oauth credential provider for OAuth authentication.</summary>
    [JsonPropertyName("providerArn")]
    public string? ProviderArn { get; set; }

    /// <summary>Set of OAuth scopes to request.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Configuration for authenticating requests to the target. Required when using lambda, open_api_schema and smithy_model in mcp block. If using mcp_server in mcp block with no authorization, it should not be specified. See credential_provider_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderCredentialProviderConfiguration
{
    /// <summary>API key-based authentication configuration. See api_key below.</summary>
    [JsonPropertyName("apiKey")]
    public V1beta1GatewayTargetSpecForProviderCredentialProviderConfigurationApiKey? ApiKey { get; set; }

    /// <summary>Use the gateway&apos;s IAM role for authentication. This is an empty configuration block.</summary>
    [JsonPropertyName("gatewayIamRole")]
    public V1beta1GatewayTargetSpecForProviderCredentialProviderConfigurationGatewayIamRole? GatewayIamRole { get; set; }

    /// <summary>OAuth-based authentication configuration. See oauth below.</summary>
    [JsonPropertyName("oauth")]
    public V1beta1GatewayTargetSpecForProviderCredentialProviderConfigurationOauth? Oauth { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecForProviderGatewayIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1GatewayTargetSpecForProviderGatewayIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecForProviderGatewayIdentifierRefPolicyResolveEnum>))]
public enum V1beta1GatewayTargetSpecForProviderGatewayIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderGatewayIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayTargetSpecForProviderGatewayIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayTargetSpecForProviderGatewayIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderGatewayIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayTargetSpecForProviderGatewayIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecForProviderGatewayIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1GatewayTargetSpecForProviderGatewayIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecForProviderGatewayIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1GatewayTargetSpecForProviderGatewayIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderGatewayIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayTargetSpecForProviderGatewayIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayTargetSpecForProviderGatewayIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderGatewayIdentifierSelector
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
    public V1beta1GatewayTargetSpecForProviderGatewayIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration for HTTP header and query parameter propagation between the gateway and target servers. See metadata_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderMetadataConfiguration
{
    /// <summary>
    /// A set of URL query parameters that are allowed to be propagated from incoming gateway URL to the target. Maximum of 10 parameters.
    /// A list of URL query parameters that are allowed to be propagated from incoming gateway URL to the target.
    /// </summary>
    [JsonPropertyName("allowedQueryParameters")]
    public IList<string>? AllowedQueryParameters { get; set; }

    /// <summary>
    /// A set of HTTP headers that are allowed to be propagated from incoming client requests to the target. Maximum of 10 headers.
    /// A list of HTTP headers that are allowed to be propagated from incoming client requests to the target.
    /// </summary>
    [JsonPropertyName("allowedRequestHeaders")]
    public IList<string>? AllowedRequestHeaders { get; set; }

    /// <summary>
    /// A set of HTTP headers that are allowed to be propagated from the target response back to the client. Maximum of 10 headers.
    /// A list of HTTP headers that are allowed to be propagated from the target response back to the client.
    /// </summary>
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnRefPolicyResolveEnum>))]
public enum V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnSelector
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
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItemsItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItemsProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItemsItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItemsProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItems? Items { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyProperty>? Property { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Schema for the tool&apos;s input. See schema_definition below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchema
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItemsItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItemsProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItemsItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItemsProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItemsItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItemsProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItemsItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItemsProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItems? Items { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyProperty>? Property { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Schema for the tool&apos;s output. See schema_definition below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchema
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayload
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Schema for the tool&apos;s input. See schema_definition below.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchema? InputSchema { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Schema for the tool&apos;s output. See schema_definition below.</summary>
    [JsonPropertyName("outputSchema")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchema? OutputSchema { get; set; }
}

/// <summary>S3-based tool definition. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaS3
{
    /// <summary>Account ID of the S3 bucket owner.</summary>
    [JsonPropertyName("bucketOwnerAccountId")]
    public string? BucketOwnerAccountId { get; set; }

    /// <summary>S3 URI where the tool schema is stored.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Schema definition for the tool. See tool_schema below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchema
{
    /// <summary>Inline tool definition. See inline_payload below.</summary>
    [JsonPropertyName("inlinePayload")]
    public IList<V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaInlinePayload>? InlinePayload { get; set; }

    /// <summary>S3-based tool definition. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchemaS3? S3 { get; set; }
}

/// <summary>Lambda function target configuration. See lambda below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambda
{
    /// <summary>ARN of the Lambda function to invoke.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaLambdaArnSelector? LambdaArnSelector { get; set; }

    /// <summary>Schema definition for the tool. See tool_schema below.</summary>
    [JsonPropertyName("toolSchema")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambdaToolSchema? ToolSchema { get; set; }
}

/// <summary>MCP server target configuration. See mcp_server below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpMcpServer
{
    /// <summary>Endpoint for the MCP server target configuration.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary>Inline tool definition. See inline_payload below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpOpenApiSchemaInlinePayload
{
    /// <summary>The inline schema payload content.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }
}

/// <summary>S3-based tool definition. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpOpenApiSchemaS3
{
    /// <summary>Account ID of the S3 bucket owner.</summary>
    [JsonPropertyName("bucketOwnerAccountId")]
    public string? BucketOwnerAccountId { get; set; }

    /// <summary>S3 URI where the tool schema is stored.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>OpenAPI schema-based target configuration. See api_schema_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpOpenApiSchema
{
    /// <summary>Inline tool definition. See inline_payload below.</summary>
    [JsonPropertyName("inlinePayload")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpOpenApiSchemaInlinePayload? InlinePayload { get; set; }

    /// <summary>S3-based tool definition. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpOpenApiSchemaS3? S3 { get; set; }
}

/// <summary>Inline tool definition. See inline_payload below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpSmithyModelInlinePayload
{
    /// <summary>The inline schema payload content.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }
}

/// <summary>S3-based tool definition. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpSmithyModelS3
{
    /// <summary>Account ID of the S3 bucket owner.</summary>
    [JsonPropertyName("bucketOwnerAccountId")]
    public string? BucketOwnerAccountId { get; set; }

    /// <summary>S3 URI where the tool schema is stored.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Smithy model-based target configuration. See api_schema_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpSmithyModel
{
    /// <summary>Inline tool definition. See inline_payload below.</summary>
    [JsonPropertyName("inlinePayload")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpSmithyModelInlinePayload? InlinePayload { get; set; }

    /// <summary>S3-based tool definition. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpSmithyModelS3? S3 { get; set; }
}

/// <summary>Model Context Protocol (MCP) configuration. See mcp below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfigurationMcp
{
    /// <summary>Lambda function target configuration. See lambda below.</summary>
    [JsonPropertyName("lambda")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpLambda? Lambda { get; set; }

    /// <summary>MCP server target configuration. See mcp_server below.</summary>
    [JsonPropertyName("mcpServer")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpMcpServer? McpServer { get; set; }

    /// <summary>OpenAPI schema-based target configuration. See api_schema_configuration below.</summary>
    [JsonPropertyName("openApiSchema")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpOpenApiSchema? OpenApiSchema { get; set; }

    /// <summary>Smithy model-based target configuration. See api_schema_configuration below.</summary>
    [JsonPropertyName("smithyModel")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcpSmithyModel? SmithyModel { get; set; }
}

/// <summary>Configuration for the target endpoint. See target_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProviderTargetConfiguration
{
    /// <summary>Model Context Protocol (MCP) configuration. See mcp below.</summary>
    [JsonPropertyName("mcp")]
    public V1beta1GatewayTargetSpecForProviderTargetConfigurationMcp? Mcp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecForProvider
{
    /// <summary>Configuration for authenticating requests to the target. Required when using lambda, open_api_schema and smithy_model in mcp block. If using mcp_server in mcp block with no authorization, it should not be specified. See credential_provider_configuration below.</summary>
    [JsonPropertyName("credentialProviderConfiguration")]
    public V1beta1GatewayTargetSpecForProviderCredentialProviderConfiguration? CredentialProviderConfiguration { get; set; }

    /// <summary>Description of the gateway target.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Identifier of the gateway that this target belongs to.</summary>
    [JsonPropertyName("gatewayIdentifier")]
    public string? GatewayIdentifier { get; set; }

    /// <summary>Reference to a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
    [JsonPropertyName("gatewayIdentifierRef")]
    public V1beta1GatewayTargetSpecForProviderGatewayIdentifierRef? GatewayIdentifierRef { get; set; }

    /// <summary>Selector for a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
    [JsonPropertyName("gatewayIdentifierSelector")]
    public V1beta1GatewayTargetSpecForProviderGatewayIdentifierSelector? GatewayIdentifierSelector { get; set; }

    /// <summary>Configuration for HTTP header and query parameter propagation between the gateway and target servers. See metadata_configuration below.</summary>
    [JsonPropertyName("metadataConfiguration")]
    public V1beta1GatewayTargetSpecForProviderMetadataConfiguration? MetadataConfiguration { get; set; }

    /// <summary>Name of the gateway target.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// AWS region where the resource will be created. If not provided, the region from the provider configuration will be used.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration for the target endpoint. See target_configuration below.</summary>
    [JsonPropertyName("targetConfiguration")]
    public V1beta1GatewayTargetSpecForProviderTargetConfiguration? TargetConfiguration { get; set; }
}

/// <summary>API key-based authentication configuration. See api_key below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderCredentialProviderConfigurationApiKey
{
    /// <summary>Location where the API key credential is provided. Valid values: HEADER, QUERY_PARAMETER.</summary>
    [JsonPropertyName("credentialLocation")]
    public string? CredentialLocation { get; set; }

    /// <summary>Name of the parameter containing the API key credential.</summary>
    [JsonPropertyName("credentialParameterName")]
    public string? CredentialParameterName { get; set; }

    /// <summary>Prefix to add to the API key credential value.</summary>
    [JsonPropertyName("credentialPrefix")]
    public string? CredentialPrefix { get; set; }

    /// <summary>ARN of the OIDC provider for API key authentication.</summary>
    [JsonPropertyName("providerArn")]
    public string? ProviderArn { get; set; }
}

/// <summary>Use the gateway&apos;s IAM role for authentication. This is an empty configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderCredentialProviderConfigurationGatewayIamRole
{
}

/// <summary>OAuth-based authentication configuration. See oauth below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderCredentialProviderConfigurationOauth
{
    /// <summary>Map of custom parameters to include in OAuth requests.</summary>
    [JsonPropertyName("customParameters")]
    public IDictionary<string, string>? CustomParameters { get; set; }

    /// <summary>
    /// The URL where the end user&apos;s browser is redirected after obtaining the authorization code. Required when grant_type is AUTHORIZATION_CODE.
    /// The URL where the end user&apos;s browser is redirected after obtaining the authorization code. Required when grant_type is AUTHORIZATION_CODE.
    /// </summary>
    [JsonPropertyName("defaultReturnUrl")]
    public string? DefaultReturnUrl { get; set; }

    /// <summary>
    /// The OAuth grant type. Valid values: CLIENT_CREDENTIALS (machine-to-machine authentication), AUTHORIZATION_CODE (user-delegated access).
    /// The OAuth grant type. Valid values are AUTHORIZATION_CODE and CLIENT_CREDENTIALS.
    /// </summary>
    [JsonPropertyName("grantType")]
    public string? GrantType { get; set; }

    /// <summary>ARN of the Oauth credential provider for OAuth authentication.</summary>
    [JsonPropertyName("providerArn")]
    public string? ProviderArn { get; set; }

    /// <summary>Set of OAuth scopes to request.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Configuration for authenticating requests to the target. Required when using lambda, open_api_schema and smithy_model in mcp block. If using mcp_server in mcp block with no authorization, it should not be specified. See credential_provider_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderCredentialProviderConfiguration
{
    /// <summary>API key-based authentication configuration. See api_key below.</summary>
    [JsonPropertyName("apiKey")]
    public V1beta1GatewayTargetSpecInitProviderCredentialProviderConfigurationApiKey? ApiKey { get; set; }

    /// <summary>Use the gateway&apos;s IAM role for authentication. This is an empty configuration block.</summary>
    [JsonPropertyName("gatewayIamRole")]
    public V1beta1GatewayTargetSpecInitProviderCredentialProviderConfigurationGatewayIamRole? GatewayIamRole { get; set; }

    /// <summary>OAuth-based authentication configuration. See oauth below.</summary>
    [JsonPropertyName("oauth")]
    public V1beta1GatewayTargetSpecInitProviderCredentialProviderConfigurationOauth? Oauth { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecInitProviderGatewayIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1GatewayTargetSpecInitProviderGatewayIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecInitProviderGatewayIdentifierRefPolicyResolveEnum>))]
public enum V1beta1GatewayTargetSpecInitProviderGatewayIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderGatewayIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayTargetSpecInitProviderGatewayIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayTargetSpecInitProviderGatewayIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderGatewayIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayTargetSpecInitProviderGatewayIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecInitProviderGatewayIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1GatewayTargetSpecInitProviderGatewayIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecInitProviderGatewayIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1GatewayTargetSpecInitProviderGatewayIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderGatewayIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayTargetSpecInitProviderGatewayIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayTargetSpecInitProviderGatewayIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderGatewayIdentifierSelector
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
    public V1beta1GatewayTargetSpecInitProviderGatewayIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration for HTTP header and query parameter propagation between the gateway and target servers. See metadata_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderMetadataConfiguration
{
    /// <summary>
    /// A set of URL query parameters that are allowed to be propagated from incoming gateway URL to the target. Maximum of 10 parameters.
    /// A list of URL query parameters that are allowed to be propagated from incoming gateway URL to the target.
    /// </summary>
    [JsonPropertyName("allowedQueryParameters")]
    public IList<string>? AllowedQueryParameters { get; set; }

    /// <summary>
    /// A set of HTTP headers that are allowed to be propagated from incoming client requests to the target. Maximum of 10 headers.
    /// A list of HTTP headers that are allowed to be propagated from incoming client requests to the target.
    /// </summary>
    [JsonPropertyName("allowedRequestHeaders")]
    public IList<string>? AllowedRequestHeaders { get; set; }

    /// <summary>
    /// A set of HTTP headers that are allowed to be propagated from the target response back to the client. Maximum of 10 headers.
    /// A list of HTTP headers that are allowed to be propagated from the target response back to the client.
    /// </summary>
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnRefPolicyResolveEnum>))]
public enum V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnSelector
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
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItemsItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItemsProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItemsItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItemsProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItems? Items { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyProperty>? Property { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Schema for the tool&apos;s input. See schema_definition below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchema
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItemsItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItemsProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItemsItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItemsProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItemsItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItemsProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItemsItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItemsProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItems? Items { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyProperty>? Property { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Schema for the tool&apos;s output. See schema_definition below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchema
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayload
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Schema for the tool&apos;s input. See schema_definition below.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchema? InputSchema { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Schema for the tool&apos;s output. See schema_definition below.</summary>
    [JsonPropertyName("outputSchema")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchema? OutputSchema { get; set; }
}

/// <summary>S3-based tool definition. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaS3
{
    /// <summary>Account ID of the S3 bucket owner.</summary>
    [JsonPropertyName("bucketOwnerAccountId")]
    public string? BucketOwnerAccountId { get; set; }

    /// <summary>S3 URI where the tool schema is stored.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Schema definition for the tool. See tool_schema below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchema
{
    /// <summary>Inline tool definition. See inline_payload below.</summary>
    [JsonPropertyName("inlinePayload")]
    public IList<V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaInlinePayload>? InlinePayload { get; set; }

    /// <summary>S3-based tool definition. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchemaS3? S3 { get; set; }
}

/// <summary>Lambda function target configuration. See lambda below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambda
{
    /// <summary>ARN of the Lambda function to invoke.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaLambdaArnSelector? LambdaArnSelector { get; set; }

    /// <summary>Schema definition for the tool. See tool_schema below.</summary>
    [JsonPropertyName("toolSchema")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambdaToolSchema? ToolSchema { get; set; }
}

/// <summary>MCP server target configuration. See mcp_server below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpMcpServer
{
    /// <summary>Endpoint for the MCP server target configuration.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary>Inline tool definition. See inline_payload below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpOpenApiSchemaInlinePayload
{
    /// <summary>The inline schema payload content.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }
}

/// <summary>S3-based tool definition. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpOpenApiSchemaS3
{
    /// <summary>Account ID of the S3 bucket owner.</summary>
    [JsonPropertyName("bucketOwnerAccountId")]
    public string? BucketOwnerAccountId { get; set; }

    /// <summary>S3 URI where the tool schema is stored.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>OpenAPI schema-based target configuration. See api_schema_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpOpenApiSchema
{
    /// <summary>Inline tool definition. See inline_payload below.</summary>
    [JsonPropertyName("inlinePayload")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpOpenApiSchemaInlinePayload? InlinePayload { get; set; }

    /// <summary>S3-based tool definition. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpOpenApiSchemaS3? S3 { get; set; }
}

/// <summary>Inline tool definition. See inline_payload below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpSmithyModelInlinePayload
{
    /// <summary>The inline schema payload content.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }
}

/// <summary>S3-based tool definition. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpSmithyModelS3
{
    /// <summary>Account ID of the S3 bucket owner.</summary>
    [JsonPropertyName("bucketOwnerAccountId")]
    public string? BucketOwnerAccountId { get; set; }

    /// <summary>S3 URI where the tool schema is stored.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Smithy model-based target configuration. See api_schema_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpSmithyModel
{
    /// <summary>Inline tool definition. See inline_payload below.</summary>
    [JsonPropertyName("inlinePayload")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpSmithyModelInlinePayload? InlinePayload { get; set; }

    /// <summary>S3-based tool definition. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpSmithyModelS3? S3 { get; set; }
}

/// <summary>Model Context Protocol (MCP) configuration. See mcp below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcp
{
    /// <summary>Lambda function target configuration. See lambda below.</summary>
    [JsonPropertyName("lambda")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpLambda? Lambda { get; set; }

    /// <summary>MCP server target configuration. See mcp_server below.</summary>
    [JsonPropertyName("mcpServer")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpMcpServer? McpServer { get; set; }

    /// <summary>OpenAPI schema-based target configuration. See api_schema_configuration below.</summary>
    [JsonPropertyName("openApiSchema")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpOpenApiSchema? OpenApiSchema { get; set; }

    /// <summary>Smithy model-based target configuration. See api_schema_configuration below.</summary>
    [JsonPropertyName("smithyModel")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcpSmithyModel? SmithyModel { get; set; }
}

/// <summary>Configuration for the target endpoint. See target_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecInitProviderTargetConfiguration
{
    /// <summary>Model Context Protocol (MCP) configuration. See mcp below.</summary>
    [JsonPropertyName("mcp")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfigurationMcp? Mcp { get; set; }
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
public partial class V1beta1GatewayTargetSpecInitProvider
{
    /// <summary>Configuration for authenticating requests to the target. Required when using lambda, open_api_schema and smithy_model in mcp block. If using mcp_server in mcp block with no authorization, it should not be specified. See credential_provider_configuration below.</summary>
    [JsonPropertyName("credentialProviderConfiguration")]
    public V1beta1GatewayTargetSpecInitProviderCredentialProviderConfiguration? CredentialProviderConfiguration { get; set; }

    /// <summary>Description of the gateway target.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Identifier of the gateway that this target belongs to.</summary>
    [JsonPropertyName("gatewayIdentifier")]
    public string? GatewayIdentifier { get; set; }

    /// <summary>Reference to a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
    [JsonPropertyName("gatewayIdentifierRef")]
    public V1beta1GatewayTargetSpecInitProviderGatewayIdentifierRef? GatewayIdentifierRef { get; set; }

    /// <summary>Selector for a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
    [JsonPropertyName("gatewayIdentifierSelector")]
    public V1beta1GatewayTargetSpecInitProviderGatewayIdentifierSelector? GatewayIdentifierSelector { get; set; }

    /// <summary>Configuration for HTTP header and query parameter propagation between the gateway and target servers. See metadata_configuration below.</summary>
    [JsonPropertyName("metadataConfiguration")]
    public V1beta1GatewayTargetSpecInitProviderMetadataConfiguration? MetadataConfiguration { get; set; }

    /// <summary>Name of the gateway target.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration for the target endpoint. See target_configuration below.</summary>
    [JsonPropertyName("targetConfiguration")]
    public V1beta1GatewayTargetSpecInitProviderTargetConfiguration? TargetConfiguration { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecManagementPoliciesEnum>))]
public enum V1beta1GatewayTargetSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1GatewayTargetSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayTargetSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1GatewayTargetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayTargetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayTargetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayTargetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>GatewayTargetSpec defines the desired state of GatewayTarget</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetSpec
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
    public V1beta1GatewayTargetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1GatewayTargetSpecForProvider ForProvider { get; set; }

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
    public V1beta1GatewayTargetSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1GatewayTargetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GatewayTargetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GatewayTargetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>API key-based authentication configuration. See api_key below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderCredentialProviderConfigurationApiKey
{
    /// <summary>Location where the API key credential is provided. Valid values: HEADER, QUERY_PARAMETER.</summary>
    [JsonPropertyName("credentialLocation")]
    public string? CredentialLocation { get; set; }

    /// <summary>Name of the parameter containing the API key credential.</summary>
    [JsonPropertyName("credentialParameterName")]
    public string? CredentialParameterName { get; set; }

    /// <summary>Prefix to add to the API key credential value.</summary>
    [JsonPropertyName("credentialPrefix")]
    public string? CredentialPrefix { get; set; }

    /// <summary>ARN of the OIDC provider for API key authentication.</summary>
    [JsonPropertyName("providerArn")]
    public string? ProviderArn { get; set; }
}

/// <summary>Use the gateway&apos;s IAM role for authentication. This is an empty configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderCredentialProviderConfigurationGatewayIamRole
{
}

/// <summary>OAuth-based authentication configuration. See oauth below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderCredentialProviderConfigurationOauth
{
    /// <summary>Map of custom parameters to include in OAuth requests.</summary>
    [JsonPropertyName("customParameters")]
    public IDictionary<string, string>? CustomParameters { get; set; }

    /// <summary>
    /// The URL where the end user&apos;s browser is redirected after obtaining the authorization code. Required when grant_type is AUTHORIZATION_CODE.
    /// The URL where the end user&apos;s browser is redirected after obtaining the authorization code. Required when grant_type is AUTHORIZATION_CODE.
    /// </summary>
    [JsonPropertyName("defaultReturnUrl")]
    public string? DefaultReturnUrl { get; set; }

    /// <summary>
    /// The OAuth grant type. Valid values: CLIENT_CREDENTIALS (machine-to-machine authentication), AUTHORIZATION_CODE (user-delegated access).
    /// The OAuth grant type. Valid values are AUTHORIZATION_CODE and CLIENT_CREDENTIALS.
    /// </summary>
    [JsonPropertyName("grantType")]
    public string? GrantType { get; set; }

    /// <summary>ARN of the Oauth credential provider for OAuth authentication.</summary>
    [JsonPropertyName("providerArn")]
    public string? ProviderArn { get; set; }

    /// <summary>Set of OAuth scopes to request.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Configuration for authenticating requests to the target. Required when using lambda, open_api_schema and smithy_model in mcp block. If using mcp_server in mcp block with no authorization, it should not be specified. See credential_provider_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderCredentialProviderConfiguration
{
    /// <summary>API key-based authentication configuration. See api_key below.</summary>
    [JsonPropertyName("apiKey")]
    public V1beta1GatewayTargetStatusAtProviderCredentialProviderConfigurationApiKey? ApiKey { get; set; }

    /// <summary>Use the gateway&apos;s IAM role for authentication. This is an empty configuration block.</summary>
    [JsonPropertyName("gatewayIamRole")]
    public V1beta1GatewayTargetStatusAtProviderCredentialProviderConfigurationGatewayIamRole? GatewayIamRole { get; set; }

    /// <summary>OAuth-based authentication configuration. See oauth below.</summary>
    [JsonPropertyName("oauth")]
    public V1beta1GatewayTargetStatusAtProviderCredentialProviderConfigurationOauth? Oauth { get; set; }
}

/// <summary>Configuration for HTTP header and query parameter propagation between the gateway and target servers. See metadata_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderMetadataConfiguration
{
    /// <summary>
    /// A set of URL query parameters that are allowed to be propagated from incoming gateway URL to the target. Maximum of 10 parameters.
    /// A list of URL query parameters that are allowed to be propagated from incoming gateway URL to the target.
    /// </summary>
    [JsonPropertyName("allowedQueryParameters")]
    public IList<string>? AllowedQueryParameters { get; set; }

    /// <summary>
    /// A set of HTTP headers that are allowed to be propagated from incoming client requests to the target. Maximum of 10 headers.
    /// A list of HTTP headers that are allowed to be propagated from incoming client requests to the target.
    /// </summary>
    [JsonPropertyName("allowedRequestHeaders")]
    public IList<string>? AllowedRequestHeaders { get; set; }

    /// <summary>
    /// A set of HTTP headers that are allowed to be propagated from the target response back to the client. Maximum of 10 headers.
    /// A list of HTTP headers that are allowed to be propagated from the target response back to the client.
    /// </summary>
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItemsItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItemsProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItemsItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItemsProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItems? Items { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyProperty>? Property { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Schema for the tool&apos;s input. See schema_definition below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchema
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItemsItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItemsProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItemsItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItemsProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItemsItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItemsProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Items definition for array properties. See items above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItems
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItemsItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItemsProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>JSON-encoded schema definition for array items. Used for complex nested structures. Cannot be used with properties_json.</summary>
    [JsonPropertyName("itemsJson")]
    public string? ItemsJson { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>JSON-encoded schema definition for object properties. Used for complex nested structures. Cannot be used with items_json.</summary>
    [JsonPropertyName("propertiesJson")]
    public string? PropertiesJson { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaProperty
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyItems? Items { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaPropertyProperty>? Property { get; set; }

    /// <summary>Whether this property is required. Defaults to false.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Schema for the tool&apos;s output. See schema_definition below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchema
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Items definition for array properties. See items above.</summary>
    [JsonPropertyName("items")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaItems? Items { get; set; }

    /// <summary>Set of property definitions for object types. Can only be used when type is object. See property below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchemaProperty>? Property { get; set; }

    /// <summary>Data type of the schema. Valid values: string, number, integer, boolean, array, object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayload
{
    /// <summary>Description of what the tool does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Schema for the tool&apos;s input. See schema_definition below.</summary>
    [JsonPropertyName("inputSchema")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchema? InputSchema { get; set; }

    /// <summary>Name of the tool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Schema for the tool&apos;s output. See schema_definition below.</summary>
    [JsonPropertyName("outputSchema")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayloadOutputSchema? OutputSchema { get; set; }
}

/// <summary>S3-based tool definition. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaS3
{
    /// <summary>Account ID of the S3 bucket owner.</summary>
    [JsonPropertyName("bucketOwnerAccountId")]
    public string? BucketOwnerAccountId { get; set; }

    /// <summary>S3 URI where the tool schema is stored.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Schema definition for the tool. See tool_schema below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchema
{
    /// <summary>Inline tool definition. See inline_payload below.</summary>
    [JsonPropertyName("inlinePayload")]
    public IList<V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaInlinePayload>? InlinePayload { get; set; }

    /// <summary>S3-based tool definition. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchemaS3? S3 { get; set; }
}

/// <summary>Lambda function target configuration. See lambda below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambda
{
    /// <summary>ARN of the Lambda function to invoke.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Schema definition for the tool. See tool_schema below.</summary>
    [JsonPropertyName("toolSchema")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambdaToolSchema? ToolSchema { get; set; }
}

/// <summary>MCP server target configuration. See mcp_server below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpMcpServer
{
    /// <summary>Endpoint for the MCP server target configuration.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary>Inline tool definition. See inline_payload below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpOpenApiSchemaInlinePayload
{
    /// <summary>The inline schema payload content.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }
}

/// <summary>S3-based tool definition. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpOpenApiSchemaS3
{
    /// <summary>Account ID of the S3 bucket owner.</summary>
    [JsonPropertyName("bucketOwnerAccountId")]
    public string? BucketOwnerAccountId { get; set; }

    /// <summary>S3 URI where the tool schema is stored.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>OpenAPI schema-based target configuration. See api_schema_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpOpenApiSchema
{
    /// <summary>Inline tool definition. See inline_payload below.</summary>
    [JsonPropertyName("inlinePayload")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpOpenApiSchemaInlinePayload? InlinePayload { get; set; }

    /// <summary>S3-based tool definition. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpOpenApiSchemaS3? S3 { get; set; }
}

/// <summary>Inline tool definition. See inline_payload below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpSmithyModelInlinePayload
{
    /// <summary>The inline schema payload content.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }
}

/// <summary>S3-based tool definition. See s3 below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpSmithyModelS3
{
    /// <summary>Account ID of the S3 bucket owner.</summary>
    [JsonPropertyName("bucketOwnerAccountId")]
    public string? BucketOwnerAccountId { get; set; }

    /// <summary>S3 URI where the tool schema is stored.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Smithy model-based target configuration. See api_schema_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpSmithyModel
{
    /// <summary>Inline tool definition. See inline_payload below.</summary>
    [JsonPropertyName("inlinePayload")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpSmithyModelInlinePayload? InlinePayload { get; set; }

    /// <summary>S3-based tool definition. See s3 below.</summary>
    [JsonPropertyName("s3")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpSmithyModelS3? S3 { get; set; }
}

/// <summary>Model Context Protocol (MCP) configuration. See mcp below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcp
{
    /// <summary>Lambda function target configuration. See lambda below.</summary>
    [JsonPropertyName("lambda")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpLambda? Lambda { get; set; }

    /// <summary>MCP server target configuration. See mcp_server below.</summary>
    [JsonPropertyName("mcpServer")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpMcpServer? McpServer { get; set; }

    /// <summary>OpenAPI schema-based target configuration. See api_schema_configuration below.</summary>
    [JsonPropertyName("openApiSchema")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpOpenApiSchema? OpenApiSchema { get; set; }

    /// <summary>Smithy model-based target configuration. See api_schema_configuration below.</summary>
    [JsonPropertyName("smithyModel")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcpSmithyModel? SmithyModel { get; set; }
}

/// <summary>Configuration for the target endpoint. See target_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProviderTargetConfiguration
{
    /// <summary>Model Context Protocol (MCP) configuration. See mcp below.</summary>
    [JsonPropertyName("mcp")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfigurationMcp? Mcp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusAtProvider
{
    /// <summary>Configuration for authenticating requests to the target. Required when using lambda, open_api_schema and smithy_model in mcp block. If using mcp_server in mcp block with no authorization, it should not be specified. See credential_provider_configuration below.</summary>
    [JsonPropertyName("credentialProviderConfiguration")]
    public V1beta1GatewayTargetStatusAtProviderCredentialProviderConfiguration? CredentialProviderConfiguration { get; set; }

    /// <summary>Description of the gateway target.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Identifier of the gateway that this target belongs to.</summary>
    [JsonPropertyName("gatewayIdentifier")]
    public string? GatewayIdentifier { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration for HTTP header and query parameter propagation between the gateway and target servers. See metadata_configuration below.</summary>
    [JsonPropertyName("metadataConfiguration")]
    public V1beta1GatewayTargetStatusAtProviderMetadataConfiguration? MetadataConfiguration { get; set; }

    /// <summary>Name of the gateway target.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// AWS region where the resource will be created. If not provided, the region from the provider configuration will be used.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration for the target endpoint. See target_configuration below.</summary>
    [JsonPropertyName("targetConfiguration")]
    public V1beta1GatewayTargetStatusAtProviderTargetConfiguration? TargetConfiguration { get; set; }

    /// <summary>Unique identifier of the gateway target.</summary>
    [JsonPropertyName("targetId")]
    public string? TargetId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatusConditions
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

/// <summary>GatewayTargetStatus defines the observed state of GatewayTarget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayTargetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1GatewayTargetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GatewayTargetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>GatewayTarget is the Schema for the GatewayTargets API. Manages an AWS Bedrock AgentCore Gateway Target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GatewayTarget : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GatewayTargetSpec>, IStatus<V1beta1GatewayTargetStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GatewayTarget";
    public const string KubeGroup = "bedrockagentcore.aws.upbound.io";
    public const string KubePluralName = "gatewaytargets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GatewayTarget";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GatewayTargetSpec defines the desired state of GatewayTarget</summary>
    [JsonPropertyName("spec")]
    public required V1beta1GatewayTargetSpec Spec { get; set; }

    /// <summary>GatewayTargetStatus defines the observed state of GatewayTarget.</summary>
    [JsonPropertyName("status")]
    public V1beta1GatewayTargetStatus? Status { get; set; }
}