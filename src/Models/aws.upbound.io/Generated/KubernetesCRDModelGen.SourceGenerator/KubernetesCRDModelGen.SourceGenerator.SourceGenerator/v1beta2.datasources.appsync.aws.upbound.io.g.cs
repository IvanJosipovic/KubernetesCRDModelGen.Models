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
/// <summary>Datasource is the Schema for the Datasources API. Provides an AppSync Data Source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DatasourceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Datasource>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DatasourceList";
    public const string KubeGroup = "appsync.aws.upbound.io";
    public const string KubePluralName = "datasources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appsync.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatasourceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Datasource objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Datasource> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecDeletionPolicyEnum>))]
public enum V1beta2DatasourceSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecForProviderApiIdRefPolicyResolutionEnum>))]
public enum V1beta2DatasourceSpecForProviderApiIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecForProviderApiIdRefPolicyResolveEnum>))]
public enum V1beta2DatasourceSpecForProviderApiIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderApiIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatasourceSpecForProviderApiIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatasourceSpecForProviderApiIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a GraphQLAPI in appsync to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DatasourceSpecForProviderApiIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecForProviderApiIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DatasourceSpecForProviderApiIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecForProviderApiIdSelectorPolicyResolveEnum>))]
public enum V1beta2DatasourceSpecForProviderApiIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderApiIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatasourceSpecForProviderApiIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatasourceSpecForProviderApiIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a GraphQLAPI in appsync to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderApiIdSelector
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
    public V1beta2DatasourceSpecForProviderApiIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The DeltaSyncConfig for a versioned data source. See delta_sync_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderDynamodbConfigDeltaSyncConfig
{
    /// <summary>The number of minutes that an Item is stored in the data source.</summary>
    [JsonPropertyName("baseTableTtl")]
    public double? BaseTableTtl { get; set; }

    /// <summary>The table name.</summary>
    [JsonPropertyName("deltaSyncTableName")]
    public string? DeltaSyncTableName { get; set; }

    /// <summary>The number of minutes that a Delta Sync log entry is stored in the Delta Sync table.</summary>
    [JsonPropertyName("deltaSyncTableTtl")]
    public double? DeltaSyncTableTtl { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecForProviderDynamodbConfigTableNameRefPolicyResolutionEnum>))]
public enum V1beta2DatasourceSpecForProviderDynamodbConfigTableNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecForProviderDynamodbConfigTableNameRefPolicyResolveEnum>))]
public enum V1beta2DatasourceSpecForProviderDynamodbConfigTableNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderDynamodbConfigTableNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatasourceSpecForProviderDynamodbConfigTableNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatasourceSpecForProviderDynamodbConfigTableNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in dynamodb to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderDynamodbConfigTableNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DatasourceSpecForProviderDynamodbConfigTableNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicyResolveEnum>))]
public enum V1beta2DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in dynamodb to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderDynamodbConfigTableNameSelector
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
    public V1beta2DatasourceSpecForProviderDynamodbConfigTableNameSelectorPolicy? Policy { get; set; }
}

/// <summary>DynamoDB settings. See dynamodb_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderDynamodbConfig
{
    /// <summary>The DeltaSyncConfig for a versioned data source. See delta_sync_config Block for details.</summary>
    [JsonPropertyName("deltaSyncConfig")]
    public V1beta2DatasourceSpecForProviderDynamodbConfigDeltaSyncConfig? DeltaSyncConfig { get; set; }

    /// <summary>AWS region of the DynamoDB table. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Reference to a Table in dynamodb to populate tableName.</summary>
    [JsonPropertyName("tableNameRef")]
    public V1beta2DatasourceSpecForProviderDynamodbConfigTableNameRef? TableNameRef { get; set; }

    /// <summary>Selector for a Table in dynamodb to populate tableName.</summary>
    [JsonPropertyName("tableNameSelector")]
    public V1beta2DatasourceSpecForProviderDynamodbConfigTableNameSelector? TableNameSelector { get; set; }

    /// <summary>Set to true to use Amazon Cognito credentials with this data source.</summary>
    [JsonPropertyName("useCallerCredentials")]
    public bool? UseCallerCredentials { get; set; }

    /// <summary>Detects Conflict Detection and Resolution with this data source.</summary>
    [JsonPropertyName("versioned")]
    public bool? Versioned { get; set; }
}

/// <summary>Amazon Elasticsearch settings. See elasticsearch_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderElasticsearchConfig
{
    /// <summary>HTTP endpoint of the Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>AWS region of Elasticsearch domain. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>AWS EventBridge settings. See event_bridge_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderEventBridgeConfig
{
    /// <summary>ARN for the EventBridge bus.</summary>
    [JsonPropertyName("eventBusArn")]
    public string? EventBusArn { get; set; }
}

/// <summary>Identity and Access Management (IAM) settings. See aws_iam_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderHttpConfigAuthorizationConfigAwsIamConfig
{
    /// <summary>Signing Amazon Web Services Region for IAM authorization.</summary>
    [JsonPropertyName("signingRegion")]
    public string? SigningRegion { get; set; }

    /// <summary>Signing service name for IAM authorization.</summary>
    [JsonPropertyName("signingServiceName")]
    public string? SigningServiceName { get; set; }
}

/// <summary>Authorization configuration in case the HTTP endpoint requires authorization. See authorization_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderHttpConfigAuthorizationConfig
{
    /// <summary>Authorization type that the HTTP endpoint requires. Default values is AWS_IAM.</summary>
    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }

    /// <summary>Identity and Access Management (IAM) settings. See aws_iam_config Block for details.</summary>
    [JsonPropertyName("awsIamConfig")]
    public V1beta2DatasourceSpecForProviderHttpConfigAuthorizationConfigAwsIamConfig? AwsIamConfig { get; set; }
}

/// <summary>HTTP settings. See http_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderHttpConfig
{
    /// <summary>Authorization configuration in case the HTTP endpoint requires authorization. See authorization_config Block for details.</summary>
    [JsonPropertyName("authorizationConfig")]
    public V1beta2DatasourceSpecForProviderHttpConfigAuthorizationConfig? AuthorizationConfig { get; set; }

    /// <summary>HTTP URL.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary>AWS Lambda settings. See lambda_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderLambdaConfig
{
    /// <summary>ARN for the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary>Amazon OpenSearch Service settings. See opensearchservice_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderOpensearchserviceConfig
{
    /// <summary>HTTP endpoint of the OpenSearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>AWS region of the OpenSearch domain. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>Amazon RDS HTTP endpoint configuration. See http_endpoint_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderRelationalDatabaseConfigHttpEndpointConfig
{
    /// <summary>AWS secret store ARN for database credentials.</summary>
    [JsonPropertyName("awsSecretStoreArn")]
    public string? AwsSecretStoreArn { get; set; }

    /// <summary>Logical database name.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Amazon RDS cluster identifier.</summary>
    [JsonPropertyName("dbClusterIdentifier")]
    public string? DbClusterIdentifier { get; set; }

    /// <summary>AWS Region for RDS HTTP endpoint. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Logical schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>AWS RDS settings. See relational_database_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderRelationalDatabaseConfig
{
    /// <summary>Amazon RDS HTTP endpoint configuration. See http_endpoint_config Block for details.</summary>
    [JsonPropertyName("httpEndpointConfig")]
    public V1beta2DatasourceSpecForProviderRelationalDatabaseConfigHttpEndpointConfig? HttpEndpointConfig { get; set; }

    /// <summary>Source type for the relational database. Valid values: RDS_HTTP_ENDPOINT.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecForProviderServiceRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2DatasourceSpecForProviderServiceRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecForProviderServiceRoleArnRefPolicyResolveEnum>))]
public enum V1beta2DatasourceSpecForProviderServiceRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderServiceRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatasourceSpecForProviderServiceRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatasourceSpecForProviderServiceRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DatasourceSpecForProviderServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecForProviderServiceRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DatasourceSpecForProviderServiceRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecForProviderServiceRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2DatasourceSpecForProviderServiceRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderServiceRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatasourceSpecForProviderServiceRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatasourceSpecForProviderServiceRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProviderServiceRoleArnSelector
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
    public V1beta2DatasourceSpecForProviderServiceRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecForProvider
{
    /// <summary>API ID for the GraphQL API for the data source.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>Reference to a GraphQLAPI in appsync to populate apiId.</summary>
    [JsonPropertyName("apiIdRef")]
    public V1beta2DatasourceSpecForProviderApiIdRef? ApiIdRef { get; set; }

    /// <summary>Selector for a GraphQLAPI in appsync to populate apiId.</summary>
    [JsonPropertyName("apiIdSelector")]
    public V1beta2DatasourceSpecForProviderApiIdSelector? ApiIdSelector { get; set; }

    /// <summary>Description of the data source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DynamoDB settings. See dynamodb_config Block for details.</summary>
    [JsonPropertyName("dynamodbConfig")]
    public V1beta2DatasourceSpecForProviderDynamodbConfig? DynamodbConfig { get; set; }

    /// <summary>Amazon Elasticsearch settings. See elasticsearch_config Block for details.</summary>
    [JsonPropertyName("elasticsearchConfig")]
    public V1beta2DatasourceSpecForProviderElasticsearchConfig? ElasticsearchConfig { get; set; }

    /// <summary>AWS EventBridge settings. See event_bridge_config Block for details.</summary>
    [JsonPropertyName("eventBridgeConfig")]
    public V1beta2DatasourceSpecForProviderEventBridgeConfig? EventBridgeConfig { get; set; }

    /// <summary>HTTP settings. See http_config Block for details.</summary>
    [JsonPropertyName("httpConfig")]
    public V1beta2DatasourceSpecForProviderHttpConfig? HttpConfig { get; set; }

    /// <summary>AWS Lambda settings. See lambda_config Block for details.</summary>
    [JsonPropertyName("lambdaConfig")]
    public V1beta2DatasourceSpecForProviderLambdaConfig? LambdaConfig { get; set; }

    /// <summary>Amazon OpenSearch Service settings. See opensearchservice_config Block for details.</summary>
    [JsonPropertyName("opensearchserviceConfig")]
    public V1beta2DatasourceSpecForProviderOpensearchserviceConfig? OpensearchserviceConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>AWS RDS settings. See relational_database_config Block for details.</summary>
    [JsonPropertyName("relationalDatabaseConfig")]
    public V1beta2DatasourceSpecForProviderRelationalDatabaseConfig? RelationalDatabaseConfig { get; set; }

    /// <summary>IAM service role ARN for the data source. Required if type is specified as AWS_LAMBDA, AMAZON_DYNAMODB, AMAZON_ELASTICSEARCH, AMAZON_EVENTBRIDGE, or AMAZON_OPENSEARCH_SERVICE.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta2DatasourceSpecForProviderServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta2DatasourceSpecForProviderServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>Type of the Data Source. Valid values: AWS_LAMBDA, AMAZON_DYNAMODB, AMAZON_ELASTICSEARCH, HTTP, NONE, RELATIONAL_DATABASE, AMAZON_EVENTBRIDGE, AMAZON_OPENSEARCH_SERVICE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The DeltaSyncConfig for a versioned data source. See delta_sync_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderDynamodbConfigDeltaSyncConfig
{
    /// <summary>The number of minutes that an Item is stored in the data source.</summary>
    [JsonPropertyName("baseTableTtl")]
    public double? BaseTableTtl { get; set; }

    /// <summary>The table name.</summary>
    [JsonPropertyName("deltaSyncTableName")]
    public string? DeltaSyncTableName { get; set; }

    /// <summary>The number of minutes that a Delta Sync log entry is stored in the Delta Sync table.</summary>
    [JsonPropertyName("deltaSyncTableTtl")]
    public double? DeltaSyncTableTtl { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicyResolutionEnum>))]
public enum V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicyResolveEnum>))]
public enum V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in dynamodb to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicyResolveEnum>))]
public enum V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in dynamodb to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameSelector
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
    public V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameSelectorPolicy? Policy { get; set; }
}

/// <summary>DynamoDB settings. See dynamodb_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderDynamodbConfig
{
    /// <summary>The DeltaSyncConfig for a versioned data source. See delta_sync_config Block for details.</summary>
    [JsonPropertyName("deltaSyncConfig")]
    public V1beta2DatasourceSpecInitProviderDynamodbConfigDeltaSyncConfig? DeltaSyncConfig { get; set; }

    /// <summary>Name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Reference to a Table in dynamodb to populate tableName.</summary>
    [JsonPropertyName("tableNameRef")]
    public V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameRef? TableNameRef { get; set; }

    /// <summary>Selector for a Table in dynamodb to populate tableName.</summary>
    [JsonPropertyName("tableNameSelector")]
    public V1beta2DatasourceSpecInitProviderDynamodbConfigTableNameSelector? TableNameSelector { get; set; }

    /// <summary>Set to true to use Amazon Cognito credentials with this data source.</summary>
    [JsonPropertyName("useCallerCredentials")]
    public bool? UseCallerCredentials { get; set; }

    /// <summary>Detects Conflict Detection and Resolution with this data source.</summary>
    [JsonPropertyName("versioned")]
    public bool? Versioned { get; set; }
}

/// <summary>Amazon Elasticsearch settings. See elasticsearch_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderElasticsearchConfig
{
    /// <summary>HTTP endpoint of the Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary>AWS EventBridge settings. See event_bridge_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderEventBridgeConfig
{
    /// <summary>ARN for the EventBridge bus.</summary>
    [JsonPropertyName("eventBusArn")]
    public string? EventBusArn { get; set; }
}

/// <summary>Identity and Access Management (IAM) settings. See aws_iam_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderHttpConfigAuthorizationConfigAwsIamConfig
{
    /// <summary>Signing Amazon Web Services Region for IAM authorization.</summary>
    [JsonPropertyName("signingRegion")]
    public string? SigningRegion { get; set; }

    /// <summary>Signing service name for IAM authorization.</summary>
    [JsonPropertyName("signingServiceName")]
    public string? SigningServiceName { get; set; }
}

/// <summary>Authorization configuration in case the HTTP endpoint requires authorization. See authorization_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderHttpConfigAuthorizationConfig
{
    /// <summary>Authorization type that the HTTP endpoint requires. Default values is AWS_IAM.</summary>
    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }

    /// <summary>Identity and Access Management (IAM) settings. See aws_iam_config Block for details.</summary>
    [JsonPropertyName("awsIamConfig")]
    public V1beta2DatasourceSpecInitProviderHttpConfigAuthorizationConfigAwsIamConfig? AwsIamConfig { get; set; }
}

/// <summary>HTTP settings. See http_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderHttpConfig
{
    /// <summary>Authorization configuration in case the HTTP endpoint requires authorization. See authorization_config Block for details.</summary>
    [JsonPropertyName("authorizationConfig")]
    public V1beta2DatasourceSpecInitProviderHttpConfigAuthorizationConfig? AuthorizationConfig { get; set; }

    /// <summary>HTTP URL.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary>AWS Lambda settings. See lambda_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderLambdaConfig
{
    /// <summary>ARN for the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary>Amazon OpenSearch Service settings. See opensearchservice_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderOpensearchserviceConfig
{
    /// <summary>HTTP endpoint of the OpenSearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary>Amazon RDS HTTP endpoint configuration. See http_endpoint_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderRelationalDatabaseConfigHttpEndpointConfig
{
    /// <summary>AWS secret store ARN for database credentials.</summary>
    [JsonPropertyName("awsSecretStoreArn")]
    public string? AwsSecretStoreArn { get; set; }

    /// <summary>Logical database name.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Amazon RDS cluster identifier.</summary>
    [JsonPropertyName("dbClusterIdentifier")]
    public string? DbClusterIdentifier { get; set; }

    /// <summary>Logical schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>AWS RDS settings. See relational_database_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderRelationalDatabaseConfig
{
    /// <summary>Amazon RDS HTTP endpoint configuration. See http_endpoint_config Block for details.</summary>
    [JsonPropertyName("httpEndpointConfig")]
    public V1beta2DatasourceSpecInitProviderRelationalDatabaseConfigHttpEndpointConfig? HttpEndpointConfig { get; set; }

    /// <summary>Source type for the relational database. Valid values: RDS_HTTP_ENDPOINT.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecInitProviderServiceRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2DatasourceSpecInitProviderServiceRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecInitProviderServiceRoleArnRefPolicyResolveEnum>))]
public enum V1beta2DatasourceSpecInitProviderServiceRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderServiceRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatasourceSpecInitProviderServiceRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatasourceSpecInitProviderServiceRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DatasourceSpecInitProviderServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecInitProviderServiceRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DatasourceSpecInitProviderServiceRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecInitProviderServiceRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2DatasourceSpecInitProviderServiceRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderServiceRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatasourceSpecInitProviderServiceRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatasourceSpecInitProviderServiceRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecInitProviderServiceRoleArnSelector
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
    public V1beta2DatasourceSpecInitProviderServiceRoleArnSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2DatasourceSpecInitProvider
{
    /// <summary>Description of the data source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DynamoDB settings. See dynamodb_config Block for details.</summary>
    [JsonPropertyName("dynamodbConfig")]
    public V1beta2DatasourceSpecInitProviderDynamodbConfig? DynamodbConfig { get; set; }

    /// <summary>Amazon Elasticsearch settings. See elasticsearch_config Block for details.</summary>
    [JsonPropertyName("elasticsearchConfig")]
    public V1beta2DatasourceSpecInitProviderElasticsearchConfig? ElasticsearchConfig { get; set; }

    /// <summary>AWS EventBridge settings. See event_bridge_config Block for details.</summary>
    [JsonPropertyName("eventBridgeConfig")]
    public V1beta2DatasourceSpecInitProviderEventBridgeConfig? EventBridgeConfig { get; set; }

    /// <summary>HTTP settings. See http_config Block for details.</summary>
    [JsonPropertyName("httpConfig")]
    public V1beta2DatasourceSpecInitProviderHttpConfig? HttpConfig { get; set; }

    /// <summary>AWS Lambda settings. See lambda_config Block for details.</summary>
    [JsonPropertyName("lambdaConfig")]
    public V1beta2DatasourceSpecInitProviderLambdaConfig? LambdaConfig { get; set; }

    /// <summary>Amazon OpenSearch Service settings. See opensearchservice_config Block for details.</summary>
    [JsonPropertyName("opensearchserviceConfig")]
    public V1beta2DatasourceSpecInitProviderOpensearchserviceConfig? OpensearchserviceConfig { get; set; }

    /// <summary>AWS RDS settings. See relational_database_config Block for details.</summary>
    [JsonPropertyName("relationalDatabaseConfig")]
    public V1beta2DatasourceSpecInitProviderRelationalDatabaseConfig? RelationalDatabaseConfig { get; set; }

    /// <summary>IAM service role ARN for the data source. Required if type is specified as AWS_LAMBDA, AMAZON_DYNAMODB, AMAZON_ELASTICSEARCH, AMAZON_EVENTBRIDGE, or AMAZON_OPENSEARCH_SERVICE.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta2DatasourceSpecInitProviderServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta2DatasourceSpecInitProviderServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>Type of the Data Source. Valid values: AWS_LAMBDA, AMAZON_DYNAMODB, AMAZON_ELASTICSEARCH, HTTP, NONE, RELATIONAL_DATABASE, AMAZON_EVENTBRIDGE, AMAZON_OPENSEARCH_SERVICE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecManagementPoliciesEnum>))]
public enum V1beta2DatasourceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DatasourceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatasourceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DatasourceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatasourceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatasourceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DatasourceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DatasourceSpec defines the desired state of Datasource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceSpec
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
    public V1beta2DatasourceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DatasourceSpecForProvider ForProvider { get; set; }

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
    public V1beta2DatasourceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DatasourceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DatasourceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DatasourceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The DeltaSyncConfig for a versioned data source. See delta_sync_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusAtProviderDynamodbConfigDeltaSyncConfig
{
    /// <summary>The number of minutes that an Item is stored in the data source.</summary>
    [JsonPropertyName("baseTableTtl")]
    public double? BaseTableTtl { get; set; }

    /// <summary>The table name.</summary>
    [JsonPropertyName("deltaSyncTableName")]
    public string? DeltaSyncTableName { get; set; }

    /// <summary>The number of minutes that a Delta Sync log entry is stored in the Delta Sync table.</summary>
    [JsonPropertyName("deltaSyncTableTtl")]
    public double? DeltaSyncTableTtl { get; set; }
}

/// <summary>DynamoDB settings. See dynamodb_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusAtProviderDynamodbConfig
{
    /// <summary>The DeltaSyncConfig for a versioned data source. See delta_sync_config Block for details.</summary>
    [JsonPropertyName("deltaSyncConfig")]
    public V1beta2DatasourceStatusAtProviderDynamodbConfigDeltaSyncConfig? DeltaSyncConfig { get; set; }

    /// <summary>AWS region of the DynamoDB table. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Set to true to use Amazon Cognito credentials with this data source.</summary>
    [JsonPropertyName("useCallerCredentials")]
    public bool? UseCallerCredentials { get; set; }

    /// <summary>Detects Conflict Detection and Resolution with this data source.</summary>
    [JsonPropertyName("versioned")]
    public bool? Versioned { get; set; }
}

/// <summary>Amazon Elasticsearch settings. See elasticsearch_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusAtProviderElasticsearchConfig
{
    /// <summary>HTTP endpoint of the Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>AWS region of Elasticsearch domain. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>AWS EventBridge settings. See event_bridge_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusAtProviderEventBridgeConfig
{
    /// <summary>ARN for the EventBridge bus.</summary>
    [JsonPropertyName("eventBusArn")]
    public string? EventBusArn { get; set; }
}

/// <summary>Identity and Access Management (IAM) settings. See aws_iam_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusAtProviderHttpConfigAuthorizationConfigAwsIamConfig
{
    /// <summary>Signing Amazon Web Services Region for IAM authorization.</summary>
    [JsonPropertyName("signingRegion")]
    public string? SigningRegion { get; set; }

    /// <summary>Signing service name for IAM authorization.</summary>
    [JsonPropertyName("signingServiceName")]
    public string? SigningServiceName { get; set; }
}

/// <summary>Authorization configuration in case the HTTP endpoint requires authorization. See authorization_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusAtProviderHttpConfigAuthorizationConfig
{
    /// <summary>Authorization type that the HTTP endpoint requires. Default values is AWS_IAM.</summary>
    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }

    /// <summary>Identity and Access Management (IAM) settings. See aws_iam_config Block for details.</summary>
    [JsonPropertyName("awsIamConfig")]
    public V1beta2DatasourceStatusAtProviderHttpConfigAuthorizationConfigAwsIamConfig? AwsIamConfig { get; set; }
}

/// <summary>HTTP settings. See http_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusAtProviderHttpConfig
{
    /// <summary>Authorization configuration in case the HTTP endpoint requires authorization. See authorization_config Block for details.</summary>
    [JsonPropertyName("authorizationConfig")]
    public V1beta2DatasourceStatusAtProviderHttpConfigAuthorizationConfig? AuthorizationConfig { get; set; }

    /// <summary>HTTP URL.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}

/// <summary>AWS Lambda settings. See lambda_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusAtProviderLambdaConfig
{
    /// <summary>ARN for the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary>Amazon OpenSearch Service settings. See opensearchservice_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusAtProviderOpensearchserviceConfig
{
    /// <summary>HTTP endpoint of the OpenSearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>AWS region of the OpenSearch domain. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>Amazon RDS HTTP endpoint configuration. See http_endpoint_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusAtProviderRelationalDatabaseConfigHttpEndpointConfig
{
    /// <summary>AWS secret store ARN for database credentials.</summary>
    [JsonPropertyName("awsSecretStoreArn")]
    public string? AwsSecretStoreArn { get; set; }

    /// <summary>Logical database name.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Amazon RDS cluster identifier.</summary>
    [JsonPropertyName("dbClusterIdentifier")]
    public string? DbClusterIdentifier { get; set; }

    /// <summary>AWS Region for RDS HTTP endpoint. Defaults to current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Logical schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>AWS RDS settings. See relational_database_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusAtProviderRelationalDatabaseConfig
{
    /// <summary>Amazon RDS HTTP endpoint configuration. See http_endpoint_config Block for details.</summary>
    [JsonPropertyName("httpEndpointConfig")]
    public V1beta2DatasourceStatusAtProviderRelationalDatabaseConfigHttpEndpointConfig? HttpEndpointConfig { get; set; }

    /// <summary>Source type for the relational database. Valid values: RDS_HTTP_ENDPOINT.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusAtProvider
{
    /// <summary>API ID for the GraphQL API for the data source.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>ARN</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description of the data source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DynamoDB settings. See dynamodb_config Block for details.</summary>
    [JsonPropertyName("dynamodbConfig")]
    public V1beta2DatasourceStatusAtProviderDynamodbConfig? DynamodbConfig { get; set; }

    /// <summary>Amazon Elasticsearch settings. See elasticsearch_config Block for details.</summary>
    [JsonPropertyName("elasticsearchConfig")]
    public V1beta2DatasourceStatusAtProviderElasticsearchConfig? ElasticsearchConfig { get; set; }

    /// <summary>AWS EventBridge settings. See event_bridge_config Block for details.</summary>
    [JsonPropertyName("eventBridgeConfig")]
    public V1beta2DatasourceStatusAtProviderEventBridgeConfig? EventBridgeConfig { get; set; }

    /// <summary>HTTP settings. See http_config Block for details.</summary>
    [JsonPropertyName("httpConfig")]
    public V1beta2DatasourceStatusAtProviderHttpConfig? HttpConfig { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>AWS Lambda settings. See lambda_config Block for details.</summary>
    [JsonPropertyName("lambdaConfig")]
    public V1beta2DatasourceStatusAtProviderLambdaConfig? LambdaConfig { get; set; }

    /// <summary>Amazon OpenSearch Service settings. See opensearchservice_config Block for details.</summary>
    [JsonPropertyName("opensearchserviceConfig")]
    public V1beta2DatasourceStatusAtProviderOpensearchserviceConfig? OpensearchserviceConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>AWS RDS settings. See relational_database_config Block for details.</summary>
    [JsonPropertyName("relationalDatabaseConfig")]
    public V1beta2DatasourceStatusAtProviderRelationalDatabaseConfig? RelationalDatabaseConfig { get; set; }

    /// <summary>IAM service role ARN for the data source. Required if type is specified as AWS_LAMBDA, AMAZON_DYNAMODB, AMAZON_ELASTICSEARCH, AMAZON_EVENTBRIDGE, or AMAZON_OPENSEARCH_SERVICE.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Type of the Data Source. Valid values: AWS_LAMBDA, AMAZON_DYNAMODB, AMAZON_ELASTICSEARCH, HTTP, NONE, RELATIONAL_DATABASE, AMAZON_EVENTBRIDGE, AMAZON_OPENSEARCH_SERVICE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatusConditions
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

/// <summary>DatasourceStatus defines the observed state of Datasource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatasourceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DatasourceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DatasourceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Datasource is the Schema for the Datasources API. Provides an AppSync Data Source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Datasource : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DatasourceSpec>, IStatus<V1beta2DatasourceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Datasource";
    public const string KubeGroup = "appsync.aws.upbound.io";
    public const string KubePluralName = "datasources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appsync.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Datasource";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DatasourceSpec defines the desired state of Datasource</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DatasourceSpec Spec { get; set; }

    /// <summary>DatasourceStatus defines the observed state of Datasource.</summary>
    [JsonPropertyName("status")]
    public V1beta2DatasourceStatus? Status { get; set; }
}