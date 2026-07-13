#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appsync.aws.upbound.io;
/// <summary>GraphQLAPI is the Schema for the GraphQLAPIs API. Provides an AppSync GraphQL API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2GraphQLAPIList : IKubernetesObject<V1ListMeta>, IItems<V1beta2GraphQLAPI>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "GraphQLAPIList";
    public const string KubeGroup = "appsync.aws.upbound.io";
    public const string KubePluralName = "graphqlapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appsync.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GraphQLAPIList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2GraphQLAPI objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2GraphQLAPI> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecDeletionPolicyEnum>))]
public enum V1beta2GraphQLAPISpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderAdditionalAuthenticationProviderLambdaAuthorizerConfig
{
    /// <summary>Number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The Lambda function can override this by returning a ttlOverride key in its response. A value of 0 disables caching of responses. Minimum value of 0. Maximum value of 3600.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>ARN of the Lambda function to be called for authorization. Note: This Lambda function must have a resource-based policy assigned to it, to allow lambda:InvokeFunction from service principal appsync.amazonaws.com.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Regular expression for validation of tokens before the Lambda function is called.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }
}

/// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderAdditionalAuthenticationProviderOpenidConnectConfig
{
    /// <summary>Number of milliseconds a token is valid after being authenticated.</summary>
    [JsonPropertyName("authTtl")]
    public double? AuthTtl { get; set; }

    /// <summary>Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Number of milliseconds a token is valid after being issued to a user.</summary>
    [JsonPropertyName("iatTtl")]
    public double? IatTtl { get; set; }

    /// <summary>Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderAdditionalAuthenticationProviderUserPoolConfig
{
    /// <summary>Regular expression for validating the incoming Amazon Cognito User Pool app client ID.</summary>
    [JsonPropertyName("appIdClientRegex")]
    public string? AppIdClientRegex { get; set; }

    /// <summary>AWS region in which the user pool was created.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>User pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderAdditionalAuthenticationProvider
{
    /// <summary>Authentication type. Valid values: API_KEY, AWS_IAM, AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, AWS_LAMBDA</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
    [JsonPropertyName("lambdaAuthorizerConfig")]
    public V1beta2GraphQLAPISpecForProviderAdditionalAuthenticationProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig { get; set; }

    /// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
    [JsonPropertyName("openidConnectConfig")]
    public V1beta2GraphQLAPISpecForProviderAdditionalAuthenticationProviderOpenidConnectConfig? OpenidConnectConfig { get; set; }

    /// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
    [JsonPropertyName("userPoolConfig")]
    public V1beta2GraphQLAPISpecForProviderAdditionalAuthenticationProviderUserPoolConfig? UserPoolConfig { get; set; }
}

/// <summary>Enables and controls the enhanced metrics feature. See enhanced_metrics_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderEnhancedMetricsConfig
{
    /// <summary>How data source metrics will be emitted to CloudWatch. Valid values: FULL_REQUEST_DATA_SOURCE_METRICS, PER_DATA_SOURCE_METRICS</summary>
    [JsonPropertyName("dataSourceLevelMetricsBehavior")]
    public string? DataSourceLevelMetricsBehavior { get; set; }

    /// <summary>How operation metrics will be emitted to CloudWatch. Valid values: ENABLED, DISABLED</summary>
    [JsonPropertyName("operationLevelMetricsConfig")]
    public string? OperationLevelMetricsConfig { get; set; }

    /// <summary>How resolver metrics will be emitted to CloudWatch. Valid values: FULL_REQUEST_RESOLVER_METRICS, PER_RESOLVER_METRICS</summary>
    [JsonPropertyName("resolverLevelMetricsBehavior")]
    public string? ResolverLevelMetricsBehavior { get; set; }
}

/// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderLambdaAuthorizerConfig
{
    /// <summary>Number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The Lambda function can override this by returning a ttlOverride key in its response. A value of 0 disables caching of responses. Minimum value of 0. Maximum value of 3600.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>ARN of the Lambda function to be called for authorization. Note: This Lambda function must have a resource-based policy assigned to it, to allow lambda:InvokeFunction from service principal appsync.amazonaws.com.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Regular expression for validation of tokens before the Lambda function is called.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRefPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate cloudwatchLogsRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate cloudwatchLogsRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelector
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
    public V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument containing logging configuration. See log_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderLogConfig
{
    /// <summary>Amazon Resource Name of the service role that AWS AppSync will assume to publish to Amazon CloudWatch logs in your account.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArn")]
    public string? CloudwatchLogsRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate cloudwatchLogsRoleArn.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArnRef")]
    public V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRef? CloudwatchLogsRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate cloudwatchLogsRoleArn.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArnSelector")]
    public V1beta2GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelector? CloudwatchLogsRoleArnSelector { get; set; }

    /// <summary>Set to TRUE to exclude sections that contain information such as headers, context, and evaluated mapping templates, regardless of logging  level. Valid values: true, false. Default value: false</summary>
    [JsonPropertyName("excludeVerboseContent")]
    public bool? ExcludeVerboseContent { get; set; }

    /// <summary>Field logging level. Valid values: ALL, ERROR, NONE.</summary>
    [JsonPropertyName("fieldLogLevel")]
    public string? FieldLogLevel { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate mergedApiExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate mergedApiExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelector
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
    public V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderOpenidConnectConfig
{
    /// <summary>Number of milliseconds a token is valid after being authenticated.</summary>
    [JsonPropertyName("authTtl")]
    public double? AuthTtl { get; set; }

    /// <summary>Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Number of milliseconds a token is valid after being issued to a user.</summary>
    [JsonPropertyName("iatTtl")]
    public double? IatTtl { get; set; }

    /// <summary>Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRefPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRefPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelectorPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelectorPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelector
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
    public V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProviderUserPoolConfig
{
    /// <summary>Regular expression for validating the incoming Amazon Cognito User Pool app client ID.</summary>
    [JsonPropertyName("appIdClientRegex")]
    public string? AppIdClientRegex { get; set; }

    /// <summary>AWS region in which the user pool was created.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>Action that you want your GraphQL API to take when a request that uses Amazon Cognito User Pool authentication doesn&apos;t match the Amazon Cognito User Pool configuration. Valid: ALLOW and DENY</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>User pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdRef")]
    public V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRef? UserPoolIdRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdSelector")]
    public V1beta2GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelector? UserPoolIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecForProvider
{
    /// <summary>One or more additional authentication providers for the GraphQL API. See additional_authentication_provider Block for details.</summary>
    [JsonPropertyName("additionalAuthenticationProvider")]
    public IList<V1beta2GraphQLAPISpecForProviderAdditionalAuthenticationProvider>? AdditionalAuthenticationProvider { get; set; }

    /// <summary>API type. Valid values are GRAPHQL or MERGED. A MERGED type requires merged_api_execution_role_arn to be set.</summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary>Authentication type. Valid values: API_KEY, AWS_IAM, AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, AWS_LAMBDA</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Enables and controls the enhanced metrics feature. See enhanced_metrics_config Block for details.</summary>
    [JsonPropertyName("enhancedMetricsConfig")]
    public V1beta2GraphQLAPISpecForProviderEnhancedMetricsConfig? EnhancedMetricsConfig { get; set; }

    /// <summary>Sets the value of the GraphQL API to enable (ENABLED) or disable (DISABLED) introspection. If no value is provided, the introspection configuration will be set to ENABLED by default. This field will produce an error if the operation attempts to use the introspection feature while this field is disabled. For more information about introspection, see GraphQL introspection.</summary>
    [JsonPropertyName("introspectionConfig")]
    public string? IntrospectionConfig { get; set; }

    /// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
    [JsonPropertyName("lambdaAuthorizerConfig")]
    public V1beta2GraphQLAPISpecForProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig { get; set; }

    /// <summary>Nested argument containing logging configuration. See log_config Block for details.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta2GraphQLAPISpecForProviderLogConfig? LogConfig { get; set; }

    /// <summary>ARN of the execution role when api_type is set to MERGED.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArn")]
    public string? MergedApiExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate mergedApiExecutionRoleArn.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArnRef")]
    public V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnRef? MergedApiExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate mergedApiExecutionRoleArn.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArnSelector")]
    public V1beta2GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelector? MergedApiExecutionRoleArnSelector { get; set; }

    /// <summary>User-supplied name for the GraphQL API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
    [JsonPropertyName("openidConnectConfig")]
    public V1beta2GraphQLAPISpecForProviderOpenidConnectConfig? OpenidConnectConfig { get; set; }

    /// <summary>The maximum depth a query can have in a single request. Depth refers to the amount of nested levels allowed in the body of query. The default value is 0 (or unspecified), which indicates there&apos;s no depth limit. If you set a limit, it can be between 1 and 75 nested levels. This field will produce a limit error if the operation falls out of bounds.</summary>
    [JsonPropertyName("queryDepthLimit")]
    public double? QueryDepthLimit { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The maximum number of resolvers that can be invoked in a single request. The default value is 0 (or unspecified), which will set the limit to 10000. When specified, the limit value can be between 1 and 10000. This field will produce a limit error if the operation falls out of bounds.</summary>
    [JsonPropertyName("resolverCountLimit")]
    public double? ResolverCountLimit { get; set; }

    /// <summary>Schema definition, in GraphQL schema language format.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
    [JsonPropertyName("userPoolConfig")]
    public V1beta2GraphQLAPISpecForProviderUserPoolConfig? UserPoolConfig { get; set; }

    /// <summary>Sets the value of the GraphQL API to public (GLOBAL) or private (PRIVATE). If no value is provided, the visibility will be set to GLOBAL by default. This value cannot be changed once the API has been created.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>Whether tracing with X-ray is enabled. Defaults to false.</summary>
    [JsonPropertyName("xrayEnabled")]
    public bool? XrayEnabled { get; set; }
}

/// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderAdditionalAuthenticationProviderLambdaAuthorizerConfig
{
    /// <summary>Number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The Lambda function can override this by returning a ttlOverride key in its response. A value of 0 disables caching of responses. Minimum value of 0. Maximum value of 3600.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>ARN of the Lambda function to be called for authorization. Note: This Lambda function must have a resource-based policy assigned to it, to allow lambda:InvokeFunction from service principal appsync.amazonaws.com.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Regular expression for validation of tokens before the Lambda function is called.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }
}

/// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderAdditionalAuthenticationProviderOpenidConnectConfig
{
    /// <summary>Number of milliseconds a token is valid after being authenticated.</summary>
    [JsonPropertyName("authTtl")]
    public double? AuthTtl { get; set; }

    /// <summary>Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Number of milliseconds a token is valid after being issued to a user.</summary>
    [JsonPropertyName("iatTtl")]
    public double? IatTtl { get; set; }

    /// <summary>Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderAdditionalAuthenticationProviderUserPoolConfig
{
    /// <summary>Regular expression for validating the incoming Amazon Cognito User Pool app client ID.</summary>
    [JsonPropertyName("appIdClientRegex")]
    public string? AppIdClientRegex { get; set; }

    /// <summary>AWS region in which the user pool was created.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>User pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderAdditionalAuthenticationProvider
{
    /// <summary>Authentication type. Valid values: API_KEY, AWS_IAM, AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, AWS_LAMBDA</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
    [JsonPropertyName("lambdaAuthorizerConfig")]
    public V1beta2GraphQLAPISpecInitProviderAdditionalAuthenticationProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig { get; set; }

    /// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
    [JsonPropertyName("openidConnectConfig")]
    public V1beta2GraphQLAPISpecInitProviderAdditionalAuthenticationProviderOpenidConnectConfig? OpenidConnectConfig { get; set; }

    /// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
    [JsonPropertyName("userPoolConfig")]
    public V1beta2GraphQLAPISpecInitProviderAdditionalAuthenticationProviderUserPoolConfig? UserPoolConfig { get; set; }
}

/// <summary>Enables and controls the enhanced metrics feature. See enhanced_metrics_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderEnhancedMetricsConfig
{
    /// <summary>How data source metrics will be emitted to CloudWatch. Valid values: FULL_REQUEST_DATA_SOURCE_METRICS, PER_DATA_SOURCE_METRICS</summary>
    [JsonPropertyName("dataSourceLevelMetricsBehavior")]
    public string? DataSourceLevelMetricsBehavior { get; set; }

    /// <summary>How operation metrics will be emitted to CloudWatch. Valid values: ENABLED, DISABLED</summary>
    [JsonPropertyName("operationLevelMetricsConfig")]
    public string? OperationLevelMetricsConfig { get; set; }

    /// <summary>How resolver metrics will be emitted to CloudWatch. Valid values: FULL_REQUEST_RESOLVER_METRICS, PER_RESOLVER_METRICS</summary>
    [JsonPropertyName("resolverLevelMetricsBehavior")]
    public string? ResolverLevelMetricsBehavior { get; set; }
}

/// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderLambdaAuthorizerConfig
{
    /// <summary>Number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The Lambda function can override this by returning a ttlOverride key in its response. A value of 0 disables caching of responses. Minimum value of 0. Maximum value of 3600.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>ARN of the Lambda function to be called for authorization. Note: This Lambda function must have a resource-based policy assigned to it, to allow lambda:InvokeFunction from service principal appsync.amazonaws.com.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Regular expression for validation of tokens before the Lambda function is called.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRefPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate cloudwatchLogsRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate cloudwatchLogsRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelector
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
    public V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument containing logging configuration. See log_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderLogConfig
{
    /// <summary>Amazon Resource Name of the service role that AWS AppSync will assume to publish to Amazon CloudWatch logs in your account.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArn")]
    public string? CloudwatchLogsRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate cloudwatchLogsRoleArn.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArnRef")]
    public V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRef? CloudwatchLogsRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate cloudwatchLogsRoleArn.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArnSelector")]
    public V1beta2GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelector? CloudwatchLogsRoleArnSelector { get; set; }

    /// <summary>Set to TRUE to exclude sections that contain information such as headers, context, and evaluated mapping templates, regardless of logging  level. Valid values: true, false. Default value: false</summary>
    [JsonPropertyName("excludeVerboseContent")]
    public bool? ExcludeVerboseContent { get; set; }

    /// <summary>Field logging level. Valid values: ALL, ERROR, NONE.</summary>
    [JsonPropertyName("fieldLogLevel")]
    public string? FieldLogLevel { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate mergedApiExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate mergedApiExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelector
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
    public V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderOpenidConnectConfig
{
    /// <summary>Number of milliseconds a token is valid after being authenticated.</summary>
    [JsonPropertyName("authTtl")]
    public double? AuthTtl { get; set; }

    /// <summary>Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Number of milliseconds a token is valid after being issued to a user.</summary>
    [JsonPropertyName("iatTtl")]
    public double? IatTtl { get; set; }

    /// <summary>Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRefPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRefPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelectorPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelectorPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelector
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
    public V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecInitProviderUserPoolConfig
{
    /// <summary>Regular expression for validating the incoming Amazon Cognito User Pool app client ID.</summary>
    [JsonPropertyName("appIdClientRegex")]
    public string? AppIdClientRegex { get; set; }

    /// <summary>AWS region in which the user pool was created.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>Action that you want your GraphQL API to take when a request that uses Amazon Cognito User Pool authentication doesn&apos;t match the Amazon Cognito User Pool configuration. Valid: ALLOW and DENY</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>User pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdRef")]
    public V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRef? UserPoolIdRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdSelector")]
    public V1beta2GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelector? UserPoolIdSelector { get; set; }
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
public partial class V1beta2GraphQLAPISpecInitProvider
{
    /// <summary>One or more additional authentication providers for the GraphQL API. See additional_authentication_provider Block for details.</summary>
    [JsonPropertyName("additionalAuthenticationProvider")]
    public IList<V1beta2GraphQLAPISpecInitProviderAdditionalAuthenticationProvider>? AdditionalAuthenticationProvider { get; set; }

    /// <summary>API type. Valid values are GRAPHQL or MERGED. A MERGED type requires merged_api_execution_role_arn to be set.</summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary>Authentication type. Valid values: API_KEY, AWS_IAM, AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, AWS_LAMBDA</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Enables and controls the enhanced metrics feature. See enhanced_metrics_config Block for details.</summary>
    [JsonPropertyName("enhancedMetricsConfig")]
    public V1beta2GraphQLAPISpecInitProviderEnhancedMetricsConfig? EnhancedMetricsConfig { get; set; }

    /// <summary>Sets the value of the GraphQL API to enable (ENABLED) or disable (DISABLED) introspection. If no value is provided, the introspection configuration will be set to ENABLED by default. This field will produce an error if the operation attempts to use the introspection feature while this field is disabled. For more information about introspection, see GraphQL introspection.</summary>
    [JsonPropertyName("introspectionConfig")]
    public string? IntrospectionConfig { get; set; }

    /// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
    [JsonPropertyName("lambdaAuthorizerConfig")]
    public V1beta2GraphQLAPISpecInitProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig { get; set; }

    /// <summary>Nested argument containing logging configuration. See log_config Block for details.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta2GraphQLAPISpecInitProviderLogConfig? LogConfig { get; set; }

    /// <summary>ARN of the execution role when api_type is set to MERGED.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArn")]
    public string? MergedApiExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate mergedApiExecutionRoleArn.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArnRef")]
    public V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRef? MergedApiExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate mergedApiExecutionRoleArn.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArnSelector")]
    public V1beta2GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelector? MergedApiExecutionRoleArnSelector { get; set; }

    /// <summary>User-supplied name for the GraphQL API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
    [JsonPropertyName("openidConnectConfig")]
    public V1beta2GraphQLAPISpecInitProviderOpenidConnectConfig? OpenidConnectConfig { get; set; }

    /// <summary>The maximum depth a query can have in a single request. Depth refers to the amount of nested levels allowed in the body of query. The default value is 0 (or unspecified), which indicates there&apos;s no depth limit. If you set a limit, it can be between 1 and 75 nested levels. This field will produce a limit error if the operation falls out of bounds.</summary>
    [JsonPropertyName("queryDepthLimit")]
    public double? QueryDepthLimit { get; set; }

    /// <summary>The maximum number of resolvers that can be invoked in a single request. The default value is 0 (or unspecified), which will set the limit to 10000. When specified, the limit value can be between 1 and 10000. This field will produce a limit error if the operation falls out of bounds.</summary>
    [JsonPropertyName("resolverCountLimit")]
    public double? ResolverCountLimit { get; set; }

    /// <summary>Schema definition, in GraphQL schema language format.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
    [JsonPropertyName("userPoolConfig")]
    public V1beta2GraphQLAPISpecInitProviderUserPoolConfig? UserPoolConfig { get; set; }

    /// <summary>Sets the value of the GraphQL API to public (GLOBAL) or private (PRIVATE). If no value is provided, the visibility will be set to GLOBAL by default. This value cannot be changed once the API has been created.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>Whether tracing with X-ray is enabled. Defaults to false.</summary>
    [JsonPropertyName("xrayEnabled")]
    public bool? XrayEnabled { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecManagementPoliciesEnum>))]
public enum V1beta2GraphQLAPISpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2GraphQLAPISpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GraphQLAPISpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2GraphQLAPISpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GraphQLAPISpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GraphQLAPISpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GraphQLAPISpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>GraphQLAPISpec defines the desired state of GraphQLAPI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPISpec
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
    public V1beta2GraphQLAPISpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2GraphQLAPISpecForProvider ForProvider { get; set; }

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
    public V1beta2GraphQLAPISpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2GraphQLAPISpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2GraphQLAPISpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2GraphQLAPISpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPIStatusAtProviderAdditionalAuthenticationProviderLambdaAuthorizerConfig
{
    /// <summary>Number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The Lambda function can override this by returning a ttlOverride key in its response. A value of 0 disables caching of responses. Minimum value of 0. Maximum value of 3600.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>ARN of the Lambda function to be called for authorization. Note: This Lambda function must have a resource-based policy assigned to it, to allow lambda:InvokeFunction from service principal appsync.amazonaws.com.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Regular expression for validation of tokens before the Lambda function is called.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }
}

/// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPIStatusAtProviderAdditionalAuthenticationProviderOpenidConnectConfig
{
    /// <summary>Number of milliseconds a token is valid after being authenticated.</summary>
    [JsonPropertyName("authTtl")]
    public double? AuthTtl { get; set; }

    /// <summary>Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Number of milliseconds a token is valid after being issued to a user.</summary>
    [JsonPropertyName("iatTtl")]
    public double? IatTtl { get; set; }

    /// <summary>Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPIStatusAtProviderAdditionalAuthenticationProviderUserPoolConfig
{
    /// <summary>Regular expression for validating the incoming Amazon Cognito User Pool app client ID.</summary>
    [JsonPropertyName("appIdClientRegex")]
    public string? AppIdClientRegex { get; set; }

    /// <summary>AWS region in which the user pool was created.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>User pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPIStatusAtProviderAdditionalAuthenticationProvider
{
    /// <summary>Authentication type. Valid values: API_KEY, AWS_IAM, AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, AWS_LAMBDA</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
    [JsonPropertyName("lambdaAuthorizerConfig")]
    public V1beta2GraphQLAPIStatusAtProviderAdditionalAuthenticationProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig { get; set; }

    /// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
    [JsonPropertyName("openidConnectConfig")]
    public V1beta2GraphQLAPIStatusAtProviderAdditionalAuthenticationProviderOpenidConnectConfig? OpenidConnectConfig { get; set; }

    /// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
    [JsonPropertyName("userPoolConfig")]
    public V1beta2GraphQLAPIStatusAtProviderAdditionalAuthenticationProviderUserPoolConfig? UserPoolConfig { get; set; }
}

/// <summary>Enables and controls the enhanced metrics feature. See enhanced_metrics_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPIStatusAtProviderEnhancedMetricsConfig
{
    /// <summary>How data source metrics will be emitted to CloudWatch. Valid values: FULL_REQUEST_DATA_SOURCE_METRICS, PER_DATA_SOURCE_METRICS</summary>
    [JsonPropertyName("dataSourceLevelMetricsBehavior")]
    public string? DataSourceLevelMetricsBehavior { get; set; }

    /// <summary>How operation metrics will be emitted to CloudWatch. Valid values: ENABLED, DISABLED</summary>
    [JsonPropertyName("operationLevelMetricsConfig")]
    public string? OperationLevelMetricsConfig { get; set; }

    /// <summary>How resolver metrics will be emitted to CloudWatch. Valid values: FULL_REQUEST_RESOLVER_METRICS, PER_RESOLVER_METRICS</summary>
    [JsonPropertyName("resolverLevelMetricsBehavior")]
    public string? ResolverLevelMetricsBehavior { get; set; }
}

/// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPIStatusAtProviderLambdaAuthorizerConfig
{
    /// <summary>Number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The Lambda function can override this by returning a ttlOverride key in its response. A value of 0 disables caching of responses. Minimum value of 0. Maximum value of 3600.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>ARN of the Lambda function to be called for authorization. Note: This Lambda function must have a resource-based policy assigned to it, to allow lambda:InvokeFunction from service principal appsync.amazonaws.com.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Regular expression for validation of tokens before the Lambda function is called.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }
}

/// <summary>Nested argument containing logging configuration. See log_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPIStatusAtProviderLogConfig
{
    /// <summary>Amazon Resource Name of the service role that AWS AppSync will assume to publish to Amazon CloudWatch logs in your account.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArn")]
    public string? CloudwatchLogsRoleArn { get; set; }

    /// <summary>Set to TRUE to exclude sections that contain information such as headers, context, and evaluated mapping templates, regardless of logging  level. Valid values: true, false. Default value: false</summary>
    [JsonPropertyName("excludeVerboseContent")]
    public bool? ExcludeVerboseContent { get; set; }

    /// <summary>Field logging level. Valid values: ALL, ERROR, NONE.</summary>
    [JsonPropertyName("fieldLogLevel")]
    public string? FieldLogLevel { get; set; }
}

/// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPIStatusAtProviderOpenidConnectConfig
{
    /// <summary>Number of milliseconds a token is valid after being authenticated.</summary>
    [JsonPropertyName("authTtl")]
    public double? AuthTtl { get; set; }

    /// <summary>Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Number of milliseconds a token is valid after being issued to a user.</summary>
    [JsonPropertyName("iatTtl")]
    public double? IatTtl { get; set; }

    /// <summary>Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPIStatusAtProviderUserPoolConfig
{
    /// <summary>Regular expression for validating the incoming Amazon Cognito User Pool app client ID.</summary>
    [JsonPropertyName("appIdClientRegex")]
    public string? AppIdClientRegex { get; set; }

    /// <summary>AWS region in which the user pool was created.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>Action that you want your GraphQL API to take when a request that uses Amazon Cognito User Pool authentication doesn&apos;t match the Amazon Cognito User Pool configuration. Valid: ALLOW and DENY</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>User pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPIStatusAtProvider
{
    /// <summary>One or more additional authentication providers for the GraphQL API. See additional_authentication_provider Block for details.</summary>
    [JsonPropertyName("additionalAuthenticationProvider")]
    public IList<V1beta2GraphQLAPIStatusAtProviderAdditionalAuthenticationProvider>? AdditionalAuthenticationProvider { get; set; }

    /// <summary>API type. Valid values are GRAPHQL or MERGED. A MERGED type requires merged_api_execution_role_arn to be set.</summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary>ARN</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Authentication type. Valid values: API_KEY, AWS_IAM, AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, AWS_LAMBDA</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Enables and controls the enhanced metrics feature. See enhanced_metrics_config Block for details.</summary>
    [JsonPropertyName("enhancedMetricsConfig")]
    public V1beta2GraphQLAPIStatusAtProviderEnhancedMetricsConfig? EnhancedMetricsConfig { get; set; }

    /// <summary>API ID</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Sets the value of the GraphQL API to enable (ENABLED) or disable (DISABLED) introspection. If no value is provided, the introspection configuration will be set to ENABLED by default. This field will produce an error if the operation attempts to use the introspection feature while this field is disabled. For more information about introspection, see GraphQL introspection.</summary>
    [JsonPropertyName("introspectionConfig")]
    public string? IntrospectionConfig { get; set; }

    /// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
    [JsonPropertyName("lambdaAuthorizerConfig")]
    public V1beta2GraphQLAPIStatusAtProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig { get; set; }

    /// <summary>Nested argument containing logging configuration. See log_config Block for details.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta2GraphQLAPIStatusAtProviderLogConfig? LogConfig { get; set; }

    /// <summary>ARN of the execution role when api_type is set to MERGED.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArn")]
    public string? MergedApiExecutionRoleArn { get; set; }

    /// <summary>User-supplied name for the GraphQL API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
    [JsonPropertyName("openidConnectConfig")]
    public V1beta2GraphQLAPIStatusAtProviderOpenidConnectConfig? OpenidConnectConfig { get; set; }

    /// <summary>The maximum depth a query can have in a single request. Depth refers to the amount of nested levels allowed in the body of query. The default value is 0 (or unspecified), which indicates there&apos;s no depth limit. If you set a limit, it can be between 1 and 75 nested levels. This field will produce a limit error if the operation falls out of bounds.</summary>
    [JsonPropertyName("queryDepthLimit")]
    public double? QueryDepthLimit { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The maximum number of resolvers that can be invoked in a single request. The default value is 0 (or unspecified), which will set the limit to 10000. When specified, the limit value can be between 1 and 10000. This field will produce a limit error if the operation falls out of bounds.</summary>
    [JsonPropertyName("resolverCountLimit")]
    public double? ResolverCountLimit { get; set; }

    /// <summary>Schema definition, in GraphQL schema language format.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Map of URIs associated with the API E.g., uris[&quot;GRAPHQL&quot;] = https://ID.appsync-api.REGION.amazonaws.com/graphql</summary>
    [JsonPropertyName("uris")]
    public IDictionary<string, string>? Uris { get; set; }

    /// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
    [JsonPropertyName("userPoolConfig")]
    public V1beta2GraphQLAPIStatusAtProviderUserPoolConfig? UserPoolConfig { get; set; }

    /// <summary>Sets the value of the GraphQL API to public (GLOBAL) or private (PRIVATE). If no value is provided, the visibility will be set to GLOBAL by default. This value cannot be changed once the API has been created.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>Whether tracing with X-ray is enabled. Defaults to false.</summary>
    [JsonPropertyName("xrayEnabled")]
    public bool? XrayEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPIStatusConditions
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

/// <summary>GraphQLAPIStatus defines the observed state of GraphQLAPI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GraphQLAPIStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2GraphQLAPIStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2GraphQLAPIStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>GraphQLAPI is the Schema for the GraphQLAPIs API. Provides an AppSync GraphQL API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2GraphQLAPI : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2GraphQLAPISpec>, IStatus<V1beta2GraphQLAPIStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "GraphQLAPI";
    public const string KubeGroup = "appsync.aws.upbound.io";
    public const string KubePluralName = "graphqlapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appsync.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GraphQLAPI";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GraphQLAPISpec defines the desired state of GraphQLAPI</summary>
    [JsonPropertyName("spec")]
    public required V1beta2GraphQLAPISpec Spec { get; set; }

    /// <summary>GraphQLAPIStatus defines the observed state of GraphQLAPI.</summary>
    [JsonPropertyName("status")]
    public V1beta2GraphQLAPIStatus? Status { get; set; }
}