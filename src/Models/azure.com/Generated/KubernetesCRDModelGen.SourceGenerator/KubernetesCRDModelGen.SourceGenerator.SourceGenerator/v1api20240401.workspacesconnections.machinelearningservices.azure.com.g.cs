#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.machinelearningservices.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/workspaceRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401WorkspacesConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1api20240401WorkspacesConnection>
{
    public const string KubeApiVersion = "v1api20240401";
    public const string KubeKind = "WorkspacesConnectionList";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspacesconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.com/v1api20240401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspacesConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240401WorkspacesConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240401WorkspacesConnection> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240401WorkspacesConnectionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240401WorkspacesConnectionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a machinelearningservices.azure.com/Workspace resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>AuthType: Authentication type of the connection target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesAadAuthTypeEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesAadAuthTypeEnum
{
    [EnumMember(Value = "AAD"), JsonStringEnumMemberName("AAD")]
    AAD
}

/// <summary>Category: Category of the connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesAadCategoryEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesAadCategoryEnum
{
    [EnumMember(Value = "ADLSGen2"), JsonStringEnumMemberName("ADLSGen2")]
    ADLSGen2,
    [EnumMember(Value = "AIServices"), JsonStringEnumMemberName("AIServices")]
    AIServices,
    [EnumMember(Value = "AmazonMws"), JsonStringEnumMemberName("AmazonMws")]
    AmazonMws,
    [EnumMember(Value = "AmazonRdsForOracle"), JsonStringEnumMemberName("AmazonRdsForOracle")]
    AmazonRdsForOracle,
    [EnumMember(Value = "AmazonRdsForSqlServer"), JsonStringEnumMemberName("AmazonRdsForSqlServer")]
    AmazonRdsForSqlServer,
    [EnumMember(Value = "AmazonRedshift"), JsonStringEnumMemberName("AmazonRedshift")]
    AmazonRedshift,
    [EnumMember(Value = "AmazonS3Compatible"), JsonStringEnumMemberName("AmazonS3Compatible")]
    AmazonS3Compatible,
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey,
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureDataExplorer"), JsonStringEnumMemberName("AzureDataExplorer")]
    AzureDataExplorer,
    [EnumMember(Value = "AzureDatabricksDeltaLake"), JsonStringEnumMemberName("AzureDatabricksDeltaLake")]
    AzureDatabricksDeltaLake,
    [EnumMember(Value = "AzureMariaDb"), JsonStringEnumMemberName("AzureMariaDb")]
    AzureMariaDb,
    [EnumMember(Value = "AzureMySqlDb"), JsonStringEnumMemberName("AzureMySqlDb")]
    AzureMySqlDb,
    [EnumMember(Value = "AzureOneLake"), JsonStringEnumMemberName("AzureOneLake")]
    AzureOneLake,
    [EnumMember(Value = "AzureOpenAI"), JsonStringEnumMemberName("AzureOpenAI")]
    AzureOpenAI,
    [EnumMember(Value = "AzurePostgresDb"), JsonStringEnumMemberName("AzurePostgresDb")]
    AzurePostgresDb,
    [EnumMember(Value = "AzureSqlDb"), JsonStringEnumMemberName("AzureSqlDb")]
    AzureSqlDb,
    [EnumMember(Value = "AzureSqlMi"), JsonStringEnumMemberName("AzureSqlMi")]
    AzureSqlMi,
    [EnumMember(Value = "AzureSynapseAnalytics"), JsonStringEnumMemberName("AzureSynapseAnalytics")]
    AzureSynapseAnalytics,
    [EnumMember(Value = "AzureTableStorage"), JsonStringEnumMemberName("AzureTableStorage")]
    AzureTableStorage,
    [EnumMember(Value = "BingLLMSearch"), JsonStringEnumMemberName("BingLLMSearch")]
    BingLLMSearch,
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "CognitiveSearch"), JsonStringEnumMemberName("CognitiveSearch")]
    CognitiveSearch,
    [EnumMember(Value = "CognitiveService"), JsonStringEnumMemberName("CognitiveService")]
    CognitiveService,
    [EnumMember(Value = "Concur"), JsonStringEnumMemberName("Concur")]
    Concur,
    [EnumMember(Value = "ContainerRegistry"), JsonStringEnumMemberName("ContainerRegistry")]
    ContainerRegistry,
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb,
    [EnumMember(Value = "CosmosDbMongoDbApi"), JsonStringEnumMemberName("CosmosDbMongoDbApi")]
    CosmosDbMongoDbApi,
    [EnumMember(Value = "Couchbase"), JsonStringEnumMemberName("Couchbase")]
    Couchbase,
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys,
    [EnumMember(Value = "Db2"), JsonStringEnumMemberName("Db2")]
    Db2,
    [EnumMember(Value = "Drill"), JsonStringEnumMemberName("Drill")]
    Drill,
    [EnumMember(Value = "Dynamics"), JsonStringEnumMemberName("Dynamics")]
    Dynamics,
    [EnumMember(Value = "DynamicsAx"), JsonStringEnumMemberName("DynamicsAx")]
    DynamicsAx,
    [EnumMember(Value = "DynamicsCrm"), JsonStringEnumMemberName("DynamicsCrm")]
    DynamicsCrm,
    [EnumMember(Value = "Eloqua"), JsonStringEnumMemberName("Eloqua")]
    Eloqua,
    [EnumMember(Value = "FileServer"), JsonStringEnumMemberName("FileServer")]
    FileServer,
    [EnumMember(Value = "FtpServer"), JsonStringEnumMemberName("FtpServer")]
    FtpServer,
    [EnumMember(Value = "GenericContainerRegistry"), JsonStringEnumMemberName("GenericContainerRegistry")]
    GenericContainerRegistry,
    [EnumMember(Value = "GenericHttp"), JsonStringEnumMemberName("GenericHttp")]
    GenericHttp,
    [EnumMember(Value = "GenericRest"), JsonStringEnumMemberName("GenericRest")]
    GenericRest,
    [EnumMember(Value = "Git"), JsonStringEnumMemberName("Git")]
    Git,
    [EnumMember(Value = "GoogleAdWords"), JsonStringEnumMemberName("GoogleAdWords")]
    GoogleAdWords,
    [EnumMember(Value = "GoogleBigQuery"), JsonStringEnumMemberName("GoogleBigQuery")]
    GoogleBigQuery,
    [EnumMember(Value = "GoogleCloudStorage"), JsonStringEnumMemberName("GoogleCloudStorage")]
    GoogleCloudStorage,
    [EnumMember(Value = "Greenplum"), JsonStringEnumMemberName("Greenplum")]
    Greenplum,
    [EnumMember(Value = "Hbase"), JsonStringEnumMemberName("Hbase")]
    Hbase,
    [EnumMember(Value = "Hdfs"), JsonStringEnumMemberName("Hdfs")]
    Hdfs,
    [EnumMember(Value = "Hive"), JsonStringEnumMemberName("Hive")]
    Hive,
    [EnumMember(Value = "Hubspot"), JsonStringEnumMemberName("Hubspot")]
    Hubspot,
    [EnumMember(Value = "Impala"), JsonStringEnumMemberName("Impala")]
    Impala,
    [EnumMember(Value = "Informix"), JsonStringEnumMemberName("Informix")]
    Informix,
    [EnumMember(Value = "Jira"), JsonStringEnumMemberName("Jira")]
    Jira,
    [EnumMember(Value = "Magento"), JsonStringEnumMemberName("Magento")]
    Magento,
    [EnumMember(Value = "MariaDb"), JsonStringEnumMemberName("MariaDb")]
    MariaDb,
    [EnumMember(Value = "Marketo"), JsonStringEnumMemberName("Marketo")]
    Marketo,
    [EnumMember(Value = "MicrosoftAccess"), JsonStringEnumMemberName("MicrosoftAccess")]
    MicrosoftAccess,
    [EnumMember(Value = "MongoDbAtlas"), JsonStringEnumMemberName("MongoDbAtlas")]
    MongoDbAtlas,
    [EnumMember(Value = "MongoDbV2"), JsonStringEnumMemberName("MongoDbV2")]
    MongoDbV2,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "Netezza"), JsonStringEnumMemberName("Netezza")]
    Netezza,
    [EnumMember(Value = "ODataRest"), JsonStringEnumMemberName("ODataRest")]
    ODataRest,
    [EnumMember(Value = "Odbc"), JsonStringEnumMemberName("Odbc")]
    Odbc,
    [EnumMember(Value = "Office365"), JsonStringEnumMemberName("Office365")]
    Office365,
    [EnumMember(Value = "OpenAI"), JsonStringEnumMemberName("OpenAI")]
    OpenAI,
    [EnumMember(Value = "Oracle"), JsonStringEnumMemberName("Oracle")]
    Oracle,
    [EnumMember(Value = "OracleCloudStorage"), JsonStringEnumMemberName("OracleCloudStorage")]
    OracleCloudStorage,
    [EnumMember(Value = "OracleServiceCloud"), JsonStringEnumMemberName("OracleServiceCloud")]
    OracleServiceCloud,
    [EnumMember(Value = "PayPal"), JsonStringEnumMemberName("PayPal")]
    PayPal,
    [EnumMember(Value = "Phoenix"), JsonStringEnumMemberName("Phoenix")]
    Phoenix,
    [EnumMember(Value = "PostgreSql"), JsonStringEnumMemberName("PostgreSql")]
    PostgreSql,
    [EnumMember(Value = "Presto"), JsonStringEnumMemberName("Presto")]
    Presto,
    [EnumMember(Value = "PythonFeed"), JsonStringEnumMemberName("PythonFeed")]
    PythonFeed,
    [EnumMember(Value = "QuickBooks"), JsonStringEnumMemberName("QuickBooks")]
    QuickBooks,
    [EnumMember(Value = "Redis"), JsonStringEnumMemberName("Redis")]
    Redis,
    [EnumMember(Value = "Responsys"), JsonStringEnumMemberName("Responsys")]
    Responsys,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3,
    [EnumMember(Value = "Salesforce"), JsonStringEnumMemberName("Salesforce")]
    Salesforce,
    [EnumMember(Value = "SalesforceMarketingCloud"), JsonStringEnumMemberName("SalesforceMarketingCloud")]
    SalesforceMarketingCloud,
    [EnumMember(Value = "SalesforceServiceCloud"), JsonStringEnumMemberName("SalesforceServiceCloud")]
    SalesforceServiceCloud,
    [EnumMember(Value = "SapBw"), JsonStringEnumMemberName("SapBw")]
    SapBw,
    [EnumMember(Value = "SapCloudForCustomer"), JsonStringEnumMemberName("SapCloudForCustomer")]
    SapCloudForCustomer,
    [EnumMember(Value = "SapEcc"), JsonStringEnumMemberName("SapEcc")]
    SapEcc,
    [EnumMember(Value = "SapHana"), JsonStringEnumMemberName("SapHana")]
    SapHana,
    [EnumMember(Value = "SapOpenHub"), JsonStringEnumMemberName("SapOpenHub")]
    SapOpenHub,
    [EnumMember(Value = "SapTable"), JsonStringEnumMemberName("SapTable")]
    SapTable,
    [EnumMember(Value = "Serp"), JsonStringEnumMemberName("Serp")]
    Serp,
    [EnumMember(Value = "Serverless"), JsonStringEnumMemberName("Serverless")]
    Serverless,
    [EnumMember(Value = "ServiceNow"), JsonStringEnumMemberName("ServiceNow")]
    ServiceNow,
    [EnumMember(Value = "Sftp"), JsonStringEnumMemberName("Sftp")]
    Sftp,
    [EnumMember(Value = "SharePointOnlineList"), JsonStringEnumMemberName("SharePointOnlineList")]
    SharePointOnlineList,
    [EnumMember(Value = "Shopify"), JsonStringEnumMemberName("Shopify")]
    Shopify,
    [EnumMember(Value = "Snowflake"), JsonStringEnumMemberName("Snowflake")]
    Snowflake,
    [EnumMember(Value = "Spark"), JsonStringEnumMemberName("Spark")]
    Spark,
    [EnumMember(Value = "SqlServer"), JsonStringEnumMemberName("SqlServer")]
    SqlServer,
    [EnumMember(Value = "Square"), JsonStringEnumMemberName("Square")]
    Square,
    [EnumMember(Value = "Sybase"), JsonStringEnumMemberName("Sybase")]
    Sybase,
    [EnumMember(Value = "Teradata"), JsonStringEnumMemberName("Teradata")]
    Teradata,
    [EnumMember(Value = "Vertica"), JsonStringEnumMemberName("Vertica")]
    Vertica,
    [EnumMember(Value = "WebTable"), JsonStringEnumMemberName("WebTable")]
    WebTable,
    [EnumMember(Value = "Xero"), JsonStringEnumMemberName("Xero")]
    Xero,
    [EnumMember(Value = "Zoho"), JsonStringEnumMemberName("Zoho")]
    Zoho
}

/// <summary>ValueFormat: format for the workspace connection value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesAadValueFormatEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesAadValueFormatEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>AAD: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesAad
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public required V1api20240401WorkspacesConnectionSpecPropertiesAadAuthTypeEnum AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAadCategoryEnum? Category { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAadValueFormatEnum? ValueFormat { get; set; }
}

/// <summary>AuthType: Authentication type of the connection target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyAuthTypeEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyAuthTypeEnum
{
    [EnumMember(Value = "AccessKey"), JsonStringEnumMemberName("AccessKey")]
    AccessKey
}

/// <summary>Category: Category of the connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyCategoryEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyCategoryEnum
{
    [EnumMember(Value = "ADLSGen2"), JsonStringEnumMemberName("ADLSGen2")]
    ADLSGen2,
    [EnumMember(Value = "AIServices"), JsonStringEnumMemberName("AIServices")]
    AIServices,
    [EnumMember(Value = "AmazonMws"), JsonStringEnumMemberName("AmazonMws")]
    AmazonMws,
    [EnumMember(Value = "AmazonRdsForOracle"), JsonStringEnumMemberName("AmazonRdsForOracle")]
    AmazonRdsForOracle,
    [EnumMember(Value = "AmazonRdsForSqlServer"), JsonStringEnumMemberName("AmazonRdsForSqlServer")]
    AmazonRdsForSqlServer,
    [EnumMember(Value = "AmazonRedshift"), JsonStringEnumMemberName("AmazonRedshift")]
    AmazonRedshift,
    [EnumMember(Value = "AmazonS3Compatible"), JsonStringEnumMemberName("AmazonS3Compatible")]
    AmazonS3Compatible,
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey,
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureDataExplorer"), JsonStringEnumMemberName("AzureDataExplorer")]
    AzureDataExplorer,
    [EnumMember(Value = "AzureDatabricksDeltaLake"), JsonStringEnumMemberName("AzureDatabricksDeltaLake")]
    AzureDatabricksDeltaLake,
    [EnumMember(Value = "AzureMariaDb"), JsonStringEnumMemberName("AzureMariaDb")]
    AzureMariaDb,
    [EnumMember(Value = "AzureMySqlDb"), JsonStringEnumMemberName("AzureMySqlDb")]
    AzureMySqlDb,
    [EnumMember(Value = "AzureOneLake"), JsonStringEnumMemberName("AzureOneLake")]
    AzureOneLake,
    [EnumMember(Value = "AzureOpenAI"), JsonStringEnumMemberName("AzureOpenAI")]
    AzureOpenAI,
    [EnumMember(Value = "AzurePostgresDb"), JsonStringEnumMemberName("AzurePostgresDb")]
    AzurePostgresDb,
    [EnumMember(Value = "AzureSqlDb"), JsonStringEnumMemberName("AzureSqlDb")]
    AzureSqlDb,
    [EnumMember(Value = "AzureSqlMi"), JsonStringEnumMemberName("AzureSqlMi")]
    AzureSqlMi,
    [EnumMember(Value = "AzureSynapseAnalytics"), JsonStringEnumMemberName("AzureSynapseAnalytics")]
    AzureSynapseAnalytics,
    [EnumMember(Value = "AzureTableStorage"), JsonStringEnumMemberName("AzureTableStorage")]
    AzureTableStorage,
    [EnumMember(Value = "BingLLMSearch"), JsonStringEnumMemberName("BingLLMSearch")]
    BingLLMSearch,
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "CognitiveSearch"), JsonStringEnumMemberName("CognitiveSearch")]
    CognitiveSearch,
    [EnumMember(Value = "CognitiveService"), JsonStringEnumMemberName("CognitiveService")]
    CognitiveService,
    [EnumMember(Value = "Concur"), JsonStringEnumMemberName("Concur")]
    Concur,
    [EnumMember(Value = "ContainerRegistry"), JsonStringEnumMemberName("ContainerRegistry")]
    ContainerRegistry,
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb,
    [EnumMember(Value = "CosmosDbMongoDbApi"), JsonStringEnumMemberName("CosmosDbMongoDbApi")]
    CosmosDbMongoDbApi,
    [EnumMember(Value = "Couchbase"), JsonStringEnumMemberName("Couchbase")]
    Couchbase,
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys,
    [EnumMember(Value = "Db2"), JsonStringEnumMemberName("Db2")]
    Db2,
    [EnumMember(Value = "Drill"), JsonStringEnumMemberName("Drill")]
    Drill,
    [EnumMember(Value = "Dynamics"), JsonStringEnumMemberName("Dynamics")]
    Dynamics,
    [EnumMember(Value = "DynamicsAx"), JsonStringEnumMemberName("DynamicsAx")]
    DynamicsAx,
    [EnumMember(Value = "DynamicsCrm"), JsonStringEnumMemberName("DynamicsCrm")]
    DynamicsCrm,
    [EnumMember(Value = "Eloqua"), JsonStringEnumMemberName("Eloqua")]
    Eloqua,
    [EnumMember(Value = "FileServer"), JsonStringEnumMemberName("FileServer")]
    FileServer,
    [EnumMember(Value = "FtpServer"), JsonStringEnumMemberName("FtpServer")]
    FtpServer,
    [EnumMember(Value = "GenericContainerRegistry"), JsonStringEnumMemberName("GenericContainerRegistry")]
    GenericContainerRegistry,
    [EnumMember(Value = "GenericHttp"), JsonStringEnumMemberName("GenericHttp")]
    GenericHttp,
    [EnumMember(Value = "GenericRest"), JsonStringEnumMemberName("GenericRest")]
    GenericRest,
    [EnumMember(Value = "Git"), JsonStringEnumMemberName("Git")]
    Git,
    [EnumMember(Value = "GoogleAdWords"), JsonStringEnumMemberName("GoogleAdWords")]
    GoogleAdWords,
    [EnumMember(Value = "GoogleBigQuery"), JsonStringEnumMemberName("GoogleBigQuery")]
    GoogleBigQuery,
    [EnumMember(Value = "GoogleCloudStorage"), JsonStringEnumMemberName("GoogleCloudStorage")]
    GoogleCloudStorage,
    [EnumMember(Value = "Greenplum"), JsonStringEnumMemberName("Greenplum")]
    Greenplum,
    [EnumMember(Value = "Hbase"), JsonStringEnumMemberName("Hbase")]
    Hbase,
    [EnumMember(Value = "Hdfs"), JsonStringEnumMemberName("Hdfs")]
    Hdfs,
    [EnumMember(Value = "Hive"), JsonStringEnumMemberName("Hive")]
    Hive,
    [EnumMember(Value = "Hubspot"), JsonStringEnumMemberName("Hubspot")]
    Hubspot,
    [EnumMember(Value = "Impala"), JsonStringEnumMemberName("Impala")]
    Impala,
    [EnumMember(Value = "Informix"), JsonStringEnumMemberName("Informix")]
    Informix,
    [EnumMember(Value = "Jira"), JsonStringEnumMemberName("Jira")]
    Jira,
    [EnumMember(Value = "Magento"), JsonStringEnumMemberName("Magento")]
    Magento,
    [EnumMember(Value = "MariaDb"), JsonStringEnumMemberName("MariaDb")]
    MariaDb,
    [EnumMember(Value = "Marketo"), JsonStringEnumMemberName("Marketo")]
    Marketo,
    [EnumMember(Value = "MicrosoftAccess"), JsonStringEnumMemberName("MicrosoftAccess")]
    MicrosoftAccess,
    [EnumMember(Value = "MongoDbAtlas"), JsonStringEnumMemberName("MongoDbAtlas")]
    MongoDbAtlas,
    [EnumMember(Value = "MongoDbV2"), JsonStringEnumMemberName("MongoDbV2")]
    MongoDbV2,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "Netezza"), JsonStringEnumMemberName("Netezza")]
    Netezza,
    [EnumMember(Value = "ODataRest"), JsonStringEnumMemberName("ODataRest")]
    ODataRest,
    [EnumMember(Value = "Odbc"), JsonStringEnumMemberName("Odbc")]
    Odbc,
    [EnumMember(Value = "Office365"), JsonStringEnumMemberName("Office365")]
    Office365,
    [EnumMember(Value = "OpenAI"), JsonStringEnumMemberName("OpenAI")]
    OpenAI,
    [EnumMember(Value = "Oracle"), JsonStringEnumMemberName("Oracle")]
    Oracle,
    [EnumMember(Value = "OracleCloudStorage"), JsonStringEnumMemberName("OracleCloudStorage")]
    OracleCloudStorage,
    [EnumMember(Value = "OracleServiceCloud"), JsonStringEnumMemberName("OracleServiceCloud")]
    OracleServiceCloud,
    [EnumMember(Value = "PayPal"), JsonStringEnumMemberName("PayPal")]
    PayPal,
    [EnumMember(Value = "Phoenix"), JsonStringEnumMemberName("Phoenix")]
    Phoenix,
    [EnumMember(Value = "PostgreSql"), JsonStringEnumMemberName("PostgreSql")]
    PostgreSql,
    [EnumMember(Value = "Presto"), JsonStringEnumMemberName("Presto")]
    Presto,
    [EnumMember(Value = "PythonFeed"), JsonStringEnumMemberName("PythonFeed")]
    PythonFeed,
    [EnumMember(Value = "QuickBooks"), JsonStringEnumMemberName("QuickBooks")]
    QuickBooks,
    [EnumMember(Value = "Redis"), JsonStringEnumMemberName("Redis")]
    Redis,
    [EnumMember(Value = "Responsys"), JsonStringEnumMemberName("Responsys")]
    Responsys,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3,
    [EnumMember(Value = "Salesforce"), JsonStringEnumMemberName("Salesforce")]
    Salesforce,
    [EnumMember(Value = "SalesforceMarketingCloud"), JsonStringEnumMemberName("SalesforceMarketingCloud")]
    SalesforceMarketingCloud,
    [EnumMember(Value = "SalesforceServiceCloud"), JsonStringEnumMemberName("SalesforceServiceCloud")]
    SalesforceServiceCloud,
    [EnumMember(Value = "SapBw"), JsonStringEnumMemberName("SapBw")]
    SapBw,
    [EnumMember(Value = "SapCloudForCustomer"), JsonStringEnumMemberName("SapCloudForCustomer")]
    SapCloudForCustomer,
    [EnumMember(Value = "SapEcc"), JsonStringEnumMemberName("SapEcc")]
    SapEcc,
    [EnumMember(Value = "SapHana"), JsonStringEnumMemberName("SapHana")]
    SapHana,
    [EnumMember(Value = "SapOpenHub"), JsonStringEnumMemberName("SapOpenHub")]
    SapOpenHub,
    [EnumMember(Value = "SapTable"), JsonStringEnumMemberName("SapTable")]
    SapTable,
    [EnumMember(Value = "Serp"), JsonStringEnumMemberName("Serp")]
    Serp,
    [EnumMember(Value = "Serverless"), JsonStringEnumMemberName("Serverless")]
    Serverless,
    [EnumMember(Value = "ServiceNow"), JsonStringEnumMemberName("ServiceNow")]
    ServiceNow,
    [EnumMember(Value = "Sftp"), JsonStringEnumMemberName("Sftp")]
    Sftp,
    [EnumMember(Value = "SharePointOnlineList"), JsonStringEnumMemberName("SharePointOnlineList")]
    SharePointOnlineList,
    [EnumMember(Value = "Shopify"), JsonStringEnumMemberName("Shopify")]
    Shopify,
    [EnumMember(Value = "Snowflake"), JsonStringEnumMemberName("Snowflake")]
    Snowflake,
    [EnumMember(Value = "Spark"), JsonStringEnumMemberName("Spark")]
    Spark,
    [EnumMember(Value = "SqlServer"), JsonStringEnumMemberName("SqlServer")]
    SqlServer,
    [EnumMember(Value = "Square"), JsonStringEnumMemberName("Square")]
    Square,
    [EnumMember(Value = "Sybase"), JsonStringEnumMemberName("Sybase")]
    Sybase,
    [EnumMember(Value = "Teradata"), JsonStringEnumMemberName("Teradata")]
    Teradata,
    [EnumMember(Value = "Vertica"), JsonStringEnumMemberName("Vertica")]
    Vertica,
    [EnumMember(Value = "WebTable"), JsonStringEnumMemberName("WebTable")]
    WebTable,
    [EnumMember(Value = "Xero"), JsonStringEnumMemberName("Xero")]
    Xero,
    [EnumMember(Value = "Zoho"), JsonStringEnumMemberName("Zoho")]
    Zoho
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyCredentialsSecretAccessKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyCredentials
{
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("secretAccessKey")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyCredentialsSecretAccessKey? SecretAccessKey { get; set; }
}

/// <summary>ValueFormat: format for the workspace connection value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyValueFormatEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyValueFormatEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>AccessKey: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesAccessKey
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public required V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyAuthTypeEnum AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyCategoryEnum? Category { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAccessKeyValueFormatEnum? ValueFormat { get; set; }
}

/// <summary>AuthType: Authentication type of the connection target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyAuthTypeEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyAuthTypeEnum
{
    [EnumMember(Value = "AccountKey"), JsonStringEnumMemberName("AccountKey")]
    AccountKey
}

/// <summary>Category: Category of the connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyCategoryEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyCategoryEnum
{
    [EnumMember(Value = "ADLSGen2"), JsonStringEnumMemberName("ADLSGen2")]
    ADLSGen2,
    [EnumMember(Value = "AIServices"), JsonStringEnumMemberName("AIServices")]
    AIServices,
    [EnumMember(Value = "AmazonMws"), JsonStringEnumMemberName("AmazonMws")]
    AmazonMws,
    [EnumMember(Value = "AmazonRdsForOracle"), JsonStringEnumMemberName("AmazonRdsForOracle")]
    AmazonRdsForOracle,
    [EnumMember(Value = "AmazonRdsForSqlServer"), JsonStringEnumMemberName("AmazonRdsForSqlServer")]
    AmazonRdsForSqlServer,
    [EnumMember(Value = "AmazonRedshift"), JsonStringEnumMemberName("AmazonRedshift")]
    AmazonRedshift,
    [EnumMember(Value = "AmazonS3Compatible"), JsonStringEnumMemberName("AmazonS3Compatible")]
    AmazonS3Compatible,
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey,
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureDataExplorer"), JsonStringEnumMemberName("AzureDataExplorer")]
    AzureDataExplorer,
    [EnumMember(Value = "AzureDatabricksDeltaLake"), JsonStringEnumMemberName("AzureDatabricksDeltaLake")]
    AzureDatabricksDeltaLake,
    [EnumMember(Value = "AzureMariaDb"), JsonStringEnumMemberName("AzureMariaDb")]
    AzureMariaDb,
    [EnumMember(Value = "AzureMySqlDb"), JsonStringEnumMemberName("AzureMySqlDb")]
    AzureMySqlDb,
    [EnumMember(Value = "AzureOneLake"), JsonStringEnumMemberName("AzureOneLake")]
    AzureOneLake,
    [EnumMember(Value = "AzureOpenAI"), JsonStringEnumMemberName("AzureOpenAI")]
    AzureOpenAI,
    [EnumMember(Value = "AzurePostgresDb"), JsonStringEnumMemberName("AzurePostgresDb")]
    AzurePostgresDb,
    [EnumMember(Value = "AzureSqlDb"), JsonStringEnumMemberName("AzureSqlDb")]
    AzureSqlDb,
    [EnumMember(Value = "AzureSqlMi"), JsonStringEnumMemberName("AzureSqlMi")]
    AzureSqlMi,
    [EnumMember(Value = "AzureSynapseAnalytics"), JsonStringEnumMemberName("AzureSynapseAnalytics")]
    AzureSynapseAnalytics,
    [EnumMember(Value = "AzureTableStorage"), JsonStringEnumMemberName("AzureTableStorage")]
    AzureTableStorage,
    [EnumMember(Value = "BingLLMSearch"), JsonStringEnumMemberName("BingLLMSearch")]
    BingLLMSearch,
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "CognitiveSearch"), JsonStringEnumMemberName("CognitiveSearch")]
    CognitiveSearch,
    [EnumMember(Value = "CognitiveService"), JsonStringEnumMemberName("CognitiveService")]
    CognitiveService,
    [EnumMember(Value = "Concur"), JsonStringEnumMemberName("Concur")]
    Concur,
    [EnumMember(Value = "ContainerRegistry"), JsonStringEnumMemberName("ContainerRegistry")]
    ContainerRegistry,
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb,
    [EnumMember(Value = "CosmosDbMongoDbApi"), JsonStringEnumMemberName("CosmosDbMongoDbApi")]
    CosmosDbMongoDbApi,
    [EnumMember(Value = "Couchbase"), JsonStringEnumMemberName("Couchbase")]
    Couchbase,
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys,
    [EnumMember(Value = "Db2"), JsonStringEnumMemberName("Db2")]
    Db2,
    [EnumMember(Value = "Drill"), JsonStringEnumMemberName("Drill")]
    Drill,
    [EnumMember(Value = "Dynamics"), JsonStringEnumMemberName("Dynamics")]
    Dynamics,
    [EnumMember(Value = "DynamicsAx"), JsonStringEnumMemberName("DynamicsAx")]
    DynamicsAx,
    [EnumMember(Value = "DynamicsCrm"), JsonStringEnumMemberName("DynamicsCrm")]
    DynamicsCrm,
    [EnumMember(Value = "Eloqua"), JsonStringEnumMemberName("Eloqua")]
    Eloqua,
    [EnumMember(Value = "FileServer"), JsonStringEnumMemberName("FileServer")]
    FileServer,
    [EnumMember(Value = "FtpServer"), JsonStringEnumMemberName("FtpServer")]
    FtpServer,
    [EnumMember(Value = "GenericContainerRegistry"), JsonStringEnumMemberName("GenericContainerRegistry")]
    GenericContainerRegistry,
    [EnumMember(Value = "GenericHttp"), JsonStringEnumMemberName("GenericHttp")]
    GenericHttp,
    [EnumMember(Value = "GenericRest"), JsonStringEnumMemberName("GenericRest")]
    GenericRest,
    [EnumMember(Value = "Git"), JsonStringEnumMemberName("Git")]
    Git,
    [EnumMember(Value = "GoogleAdWords"), JsonStringEnumMemberName("GoogleAdWords")]
    GoogleAdWords,
    [EnumMember(Value = "GoogleBigQuery"), JsonStringEnumMemberName("GoogleBigQuery")]
    GoogleBigQuery,
    [EnumMember(Value = "GoogleCloudStorage"), JsonStringEnumMemberName("GoogleCloudStorage")]
    GoogleCloudStorage,
    [EnumMember(Value = "Greenplum"), JsonStringEnumMemberName("Greenplum")]
    Greenplum,
    [EnumMember(Value = "Hbase"), JsonStringEnumMemberName("Hbase")]
    Hbase,
    [EnumMember(Value = "Hdfs"), JsonStringEnumMemberName("Hdfs")]
    Hdfs,
    [EnumMember(Value = "Hive"), JsonStringEnumMemberName("Hive")]
    Hive,
    [EnumMember(Value = "Hubspot"), JsonStringEnumMemberName("Hubspot")]
    Hubspot,
    [EnumMember(Value = "Impala"), JsonStringEnumMemberName("Impala")]
    Impala,
    [EnumMember(Value = "Informix"), JsonStringEnumMemberName("Informix")]
    Informix,
    [EnumMember(Value = "Jira"), JsonStringEnumMemberName("Jira")]
    Jira,
    [EnumMember(Value = "Magento"), JsonStringEnumMemberName("Magento")]
    Magento,
    [EnumMember(Value = "MariaDb"), JsonStringEnumMemberName("MariaDb")]
    MariaDb,
    [EnumMember(Value = "Marketo"), JsonStringEnumMemberName("Marketo")]
    Marketo,
    [EnumMember(Value = "MicrosoftAccess"), JsonStringEnumMemberName("MicrosoftAccess")]
    MicrosoftAccess,
    [EnumMember(Value = "MongoDbAtlas"), JsonStringEnumMemberName("MongoDbAtlas")]
    MongoDbAtlas,
    [EnumMember(Value = "MongoDbV2"), JsonStringEnumMemberName("MongoDbV2")]
    MongoDbV2,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "Netezza"), JsonStringEnumMemberName("Netezza")]
    Netezza,
    [EnumMember(Value = "ODataRest"), JsonStringEnumMemberName("ODataRest")]
    ODataRest,
    [EnumMember(Value = "Odbc"), JsonStringEnumMemberName("Odbc")]
    Odbc,
    [EnumMember(Value = "Office365"), JsonStringEnumMemberName("Office365")]
    Office365,
    [EnumMember(Value = "OpenAI"), JsonStringEnumMemberName("OpenAI")]
    OpenAI,
    [EnumMember(Value = "Oracle"), JsonStringEnumMemberName("Oracle")]
    Oracle,
    [EnumMember(Value = "OracleCloudStorage"), JsonStringEnumMemberName("OracleCloudStorage")]
    OracleCloudStorage,
    [EnumMember(Value = "OracleServiceCloud"), JsonStringEnumMemberName("OracleServiceCloud")]
    OracleServiceCloud,
    [EnumMember(Value = "PayPal"), JsonStringEnumMemberName("PayPal")]
    PayPal,
    [EnumMember(Value = "Phoenix"), JsonStringEnumMemberName("Phoenix")]
    Phoenix,
    [EnumMember(Value = "PostgreSql"), JsonStringEnumMemberName("PostgreSql")]
    PostgreSql,
    [EnumMember(Value = "Presto"), JsonStringEnumMemberName("Presto")]
    Presto,
    [EnumMember(Value = "PythonFeed"), JsonStringEnumMemberName("PythonFeed")]
    PythonFeed,
    [EnumMember(Value = "QuickBooks"), JsonStringEnumMemberName("QuickBooks")]
    QuickBooks,
    [EnumMember(Value = "Redis"), JsonStringEnumMemberName("Redis")]
    Redis,
    [EnumMember(Value = "Responsys"), JsonStringEnumMemberName("Responsys")]
    Responsys,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3,
    [EnumMember(Value = "Salesforce"), JsonStringEnumMemberName("Salesforce")]
    Salesforce,
    [EnumMember(Value = "SalesforceMarketingCloud"), JsonStringEnumMemberName("SalesforceMarketingCloud")]
    SalesforceMarketingCloud,
    [EnumMember(Value = "SalesforceServiceCloud"), JsonStringEnumMemberName("SalesforceServiceCloud")]
    SalesforceServiceCloud,
    [EnumMember(Value = "SapBw"), JsonStringEnumMemberName("SapBw")]
    SapBw,
    [EnumMember(Value = "SapCloudForCustomer"), JsonStringEnumMemberName("SapCloudForCustomer")]
    SapCloudForCustomer,
    [EnumMember(Value = "SapEcc"), JsonStringEnumMemberName("SapEcc")]
    SapEcc,
    [EnumMember(Value = "SapHana"), JsonStringEnumMemberName("SapHana")]
    SapHana,
    [EnumMember(Value = "SapOpenHub"), JsonStringEnumMemberName("SapOpenHub")]
    SapOpenHub,
    [EnumMember(Value = "SapTable"), JsonStringEnumMemberName("SapTable")]
    SapTable,
    [EnumMember(Value = "Serp"), JsonStringEnumMemberName("Serp")]
    Serp,
    [EnumMember(Value = "Serverless"), JsonStringEnumMemberName("Serverless")]
    Serverless,
    [EnumMember(Value = "ServiceNow"), JsonStringEnumMemberName("ServiceNow")]
    ServiceNow,
    [EnumMember(Value = "Sftp"), JsonStringEnumMemberName("Sftp")]
    Sftp,
    [EnumMember(Value = "SharePointOnlineList"), JsonStringEnumMemberName("SharePointOnlineList")]
    SharePointOnlineList,
    [EnumMember(Value = "Shopify"), JsonStringEnumMemberName("Shopify")]
    Shopify,
    [EnumMember(Value = "Snowflake"), JsonStringEnumMemberName("Snowflake")]
    Snowflake,
    [EnumMember(Value = "Spark"), JsonStringEnumMemberName("Spark")]
    Spark,
    [EnumMember(Value = "SqlServer"), JsonStringEnumMemberName("SqlServer")]
    SqlServer,
    [EnumMember(Value = "Square"), JsonStringEnumMemberName("Square")]
    Square,
    [EnumMember(Value = "Sybase"), JsonStringEnumMemberName("Sybase")]
    Sybase,
    [EnumMember(Value = "Teradata"), JsonStringEnumMemberName("Teradata")]
    Teradata,
    [EnumMember(Value = "Vertica"), JsonStringEnumMemberName("Vertica")]
    Vertica,
    [EnumMember(Value = "WebTable"), JsonStringEnumMemberName("WebTable")]
    WebTable,
    [EnumMember(Value = "Xero"), JsonStringEnumMemberName("Xero")]
    Xero,
    [EnumMember(Value = "Zoho"), JsonStringEnumMemberName("Zoho")]
    Zoho
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyCredentialsKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyCredentials
{
    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("key")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyCredentialsKey? Key { get; set; }
}

/// <summary>ValueFormat: format for the workspace connection value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyValueFormatEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyValueFormatEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>AccountKey: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesAccountKey
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public required V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyAuthTypeEnum AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyCategoryEnum? Category { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAccountKeyValueFormatEnum? ValueFormat { get; set; }
}

/// <summary>AuthType: Authentication type of the connection target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesApiKeyAuthTypeEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesApiKeyAuthTypeEnum
{
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey
}

/// <summary>Category: Category of the connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesApiKeyCategoryEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesApiKeyCategoryEnum
{
    [EnumMember(Value = "ADLSGen2"), JsonStringEnumMemberName("ADLSGen2")]
    ADLSGen2,
    [EnumMember(Value = "AIServices"), JsonStringEnumMemberName("AIServices")]
    AIServices,
    [EnumMember(Value = "AmazonMws"), JsonStringEnumMemberName("AmazonMws")]
    AmazonMws,
    [EnumMember(Value = "AmazonRdsForOracle"), JsonStringEnumMemberName("AmazonRdsForOracle")]
    AmazonRdsForOracle,
    [EnumMember(Value = "AmazonRdsForSqlServer"), JsonStringEnumMemberName("AmazonRdsForSqlServer")]
    AmazonRdsForSqlServer,
    [EnumMember(Value = "AmazonRedshift"), JsonStringEnumMemberName("AmazonRedshift")]
    AmazonRedshift,
    [EnumMember(Value = "AmazonS3Compatible"), JsonStringEnumMemberName("AmazonS3Compatible")]
    AmazonS3Compatible,
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey,
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureDataExplorer"), JsonStringEnumMemberName("AzureDataExplorer")]
    AzureDataExplorer,
    [EnumMember(Value = "AzureDatabricksDeltaLake"), JsonStringEnumMemberName("AzureDatabricksDeltaLake")]
    AzureDatabricksDeltaLake,
    [EnumMember(Value = "AzureMariaDb"), JsonStringEnumMemberName("AzureMariaDb")]
    AzureMariaDb,
    [EnumMember(Value = "AzureMySqlDb"), JsonStringEnumMemberName("AzureMySqlDb")]
    AzureMySqlDb,
    [EnumMember(Value = "AzureOneLake"), JsonStringEnumMemberName("AzureOneLake")]
    AzureOneLake,
    [EnumMember(Value = "AzureOpenAI"), JsonStringEnumMemberName("AzureOpenAI")]
    AzureOpenAI,
    [EnumMember(Value = "AzurePostgresDb"), JsonStringEnumMemberName("AzurePostgresDb")]
    AzurePostgresDb,
    [EnumMember(Value = "AzureSqlDb"), JsonStringEnumMemberName("AzureSqlDb")]
    AzureSqlDb,
    [EnumMember(Value = "AzureSqlMi"), JsonStringEnumMemberName("AzureSqlMi")]
    AzureSqlMi,
    [EnumMember(Value = "AzureSynapseAnalytics"), JsonStringEnumMemberName("AzureSynapseAnalytics")]
    AzureSynapseAnalytics,
    [EnumMember(Value = "AzureTableStorage"), JsonStringEnumMemberName("AzureTableStorage")]
    AzureTableStorage,
    [EnumMember(Value = "BingLLMSearch"), JsonStringEnumMemberName("BingLLMSearch")]
    BingLLMSearch,
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "CognitiveSearch"), JsonStringEnumMemberName("CognitiveSearch")]
    CognitiveSearch,
    [EnumMember(Value = "CognitiveService"), JsonStringEnumMemberName("CognitiveService")]
    CognitiveService,
    [EnumMember(Value = "Concur"), JsonStringEnumMemberName("Concur")]
    Concur,
    [EnumMember(Value = "ContainerRegistry"), JsonStringEnumMemberName("ContainerRegistry")]
    ContainerRegistry,
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb,
    [EnumMember(Value = "CosmosDbMongoDbApi"), JsonStringEnumMemberName("CosmosDbMongoDbApi")]
    CosmosDbMongoDbApi,
    [EnumMember(Value = "Couchbase"), JsonStringEnumMemberName("Couchbase")]
    Couchbase,
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys,
    [EnumMember(Value = "Db2"), JsonStringEnumMemberName("Db2")]
    Db2,
    [EnumMember(Value = "Drill"), JsonStringEnumMemberName("Drill")]
    Drill,
    [EnumMember(Value = "Dynamics"), JsonStringEnumMemberName("Dynamics")]
    Dynamics,
    [EnumMember(Value = "DynamicsAx"), JsonStringEnumMemberName("DynamicsAx")]
    DynamicsAx,
    [EnumMember(Value = "DynamicsCrm"), JsonStringEnumMemberName("DynamicsCrm")]
    DynamicsCrm,
    [EnumMember(Value = "Eloqua"), JsonStringEnumMemberName("Eloqua")]
    Eloqua,
    [EnumMember(Value = "FileServer"), JsonStringEnumMemberName("FileServer")]
    FileServer,
    [EnumMember(Value = "FtpServer"), JsonStringEnumMemberName("FtpServer")]
    FtpServer,
    [EnumMember(Value = "GenericContainerRegistry"), JsonStringEnumMemberName("GenericContainerRegistry")]
    GenericContainerRegistry,
    [EnumMember(Value = "GenericHttp"), JsonStringEnumMemberName("GenericHttp")]
    GenericHttp,
    [EnumMember(Value = "GenericRest"), JsonStringEnumMemberName("GenericRest")]
    GenericRest,
    [EnumMember(Value = "Git"), JsonStringEnumMemberName("Git")]
    Git,
    [EnumMember(Value = "GoogleAdWords"), JsonStringEnumMemberName("GoogleAdWords")]
    GoogleAdWords,
    [EnumMember(Value = "GoogleBigQuery"), JsonStringEnumMemberName("GoogleBigQuery")]
    GoogleBigQuery,
    [EnumMember(Value = "GoogleCloudStorage"), JsonStringEnumMemberName("GoogleCloudStorage")]
    GoogleCloudStorage,
    [EnumMember(Value = "Greenplum"), JsonStringEnumMemberName("Greenplum")]
    Greenplum,
    [EnumMember(Value = "Hbase"), JsonStringEnumMemberName("Hbase")]
    Hbase,
    [EnumMember(Value = "Hdfs"), JsonStringEnumMemberName("Hdfs")]
    Hdfs,
    [EnumMember(Value = "Hive"), JsonStringEnumMemberName("Hive")]
    Hive,
    [EnumMember(Value = "Hubspot"), JsonStringEnumMemberName("Hubspot")]
    Hubspot,
    [EnumMember(Value = "Impala"), JsonStringEnumMemberName("Impala")]
    Impala,
    [EnumMember(Value = "Informix"), JsonStringEnumMemberName("Informix")]
    Informix,
    [EnumMember(Value = "Jira"), JsonStringEnumMemberName("Jira")]
    Jira,
    [EnumMember(Value = "Magento"), JsonStringEnumMemberName("Magento")]
    Magento,
    [EnumMember(Value = "MariaDb"), JsonStringEnumMemberName("MariaDb")]
    MariaDb,
    [EnumMember(Value = "Marketo"), JsonStringEnumMemberName("Marketo")]
    Marketo,
    [EnumMember(Value = "MicrosoftAccess"), JsonStringEnumMemberName("MicrosoftAccess")]
    MicrosoftAccess,
    [EnumMember(Value = "MongoDbAtlas"), JsonStringEnumMemberName("MongoDbAtlas")]
    MongoDbAtlas,
    [EnumMember(Value = "MongoDbV2"), JsonStringEnumMemberName("MongoDbV2")]
    MongoDbV2,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "Netezza"), JsonStringEnumMemberName("Netezza")]
    Netezza,
    [EnumMember(Value = "ODataRest"), JsonStringEnumMemberName("ODataRest")]
    ODataRest,
    [EnumMember(Value = "Odbc"), JsonStringEnumMemberName("Odbc")]
    Odbc,
    [EnumMember(Value = "Office365"), JsonStringEnumMemberName("Office365")]
    Office365,
    [EnumMember(Value = "OpenAI"), JsonStringEnumMemberName("OpenAI")]
    OpenAI,
    [EnumMember(Value = "Oracle"), JsonStringEnumMemberName("Oracle")]
    Oracle,
    [EnumMember(Value = "OracleCloudStorage"), JsonStringEnumMemberName("OracleCloudStorage")]
    OracleCloudStorage,
    [EnumMember(Value = "OracleServiceCloud"), JsonStringEnumMemberName("OracleServiceCloud")]
    OracleServiceCloud,
    [EnumMember(Value = "PayPal"), JsonStringEnumMemberName("PayPal")]
    PayPal,
    [EnumMember(Value = "Phoenix"), JsonStringEnumMemberName("Phoenix")]
    Phoenix,
    [EnumMember(Value = "PostgreSql"), JsonStringEnumMemberName("PostgreSql")]
    PostgreSql,
    [EnumMember(Value = "Presto"), JsonStringEnumMemberName("Presto")]
    Presto,
    [EnumMember(Value = "PythonFeed"), JsonStringEnumMemberName("PythonFeed")]
    PythonFeed,
    [EnumMember(Value = "QuickBooks"), JsonStringEnumMemberName("QuickBooks")]
    QuickBooks,
    [EnumMember(Value = "Redis"), JsonStringEnumMemberName("Redis")]
    Redis,
    [EnumMember(Value = "Responsys"), JsonStringEnumMemberName("Responsys")]
    Responsys,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3,
    [EnumMember(Value = "Salesforce"), JsonStringEnumMemberName("Salesforce")]
    Salesforce,
    [EnumMember(Value = "SalesforceMarketingCloud"), JsonStringEnumMemberName("SalesforceMarketingCloud")]
    SalesforceMarketingCloud,
    [EnumMember(Value = "SalesforceServiceCloud"), JsonStringEnumMemberName("SalesforceServiceCloud")]
    SalesforceServiceCloud,
    [EnumMember(Value = "SapBw"), JsonStringEnumMemberName("SapBw")]
    SapBw,
    [EnumMember(Value = "SapCloudForCustomer"), JsonStringEnumMemberName("SapCloudForCustomer")]
    SapCloudForCustomer,
    [EnumMember(Value = "SapEcc"), JsonStringEnumMemberName("SapEcc")]
    SapEcc,
    [EnumMember(Value = "SapHana"), JsonStringEnumMemberName("SapHana")]
    SapHana,
    [EnumMember(Value = "SapOpenHub"), JsonStringEnumMemberName("SapOpenHub")]
    SapOpenHub,
    [EnumMember(Value = "SapTable"), JsonStringEnumMemberName("SapTable")]
    SapTable,
    [EnumMember(Value = "Serp"), JsonStringEnumMemberName("Serp")]
    Serp,
    [EnumMember(Value = "Serverless"), JsonStringEnumMemberName("Serverless")]
    Serverless,
    [EnumMember(Value = "ServiceNow"), JsonStringEnumMemberName("ServiceNow")]
    ServiceNow,
    [EnumMember(Value = "Sftp"), JsonStringEnumMemberName("Sftp")]
    Sftp,
    [EnumMember(Value = "SharePointOnlineList"), JsonStringEnumMemberName("SharePointOnlineList")]
    SharePointOnlineList,
    [EnumMember(Value = "Shopify"), JsonStringEnumMemberName("Shopify")]
    Shopify,
    [EnumMember(Value = "Snowflake"), JsonStringEnumMemberName("Snowflake")]
    Snowflake,
    [EnumMember(Value = "Spark"), JsonStringEnumMemberName("Spark")]
    Spark,
    [EnumMember(Value = "SqlServer"), JsonStringEnumMemberName("SqlServer")]
    SqlServer,
    [EnumMember(Value = "Square"), JsonStringEnumMemberName("Square")]
    Square,
    [EnumMember(Value = "Sybase"), JsonStringEnumMemberName("Sybase")]
    Sybase,
    [EnumMember(Value = "Teradata"), JsonStringEnumMemberName("Teradata")]
    Teradata,
    [EnumMember(Value = "Vertica"), JsonStringEnumMemberName("Vertica")]
    Vertica,
    [EnumMember(Value = "WebTable"), JsonStringEnumMemberName("WebTable")]
    WebTable,
    [EnumMember(Value = "Xero"), JsonStringEnumMemberName("Xero")]
    Xero,
    [EnumMember(Value = "Zoho"), JsonStringEnumMemberName("Zoho")]
    Zoho
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesApiKeyCredentialsKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Credentials: Api key object for workspace connection credential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesApiKeyCredentials
{
    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("key")]
    public V1api20240401WorkspacesConnectionSpecPropertiesApiKeyCredentialsKey? Key { get; set; }
}

/// <summary>ValueFormat: format for the workspace connection value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesApiKeyValueFormatEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesApiKeyValueFormatEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>ApiKey: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesApiKey
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public required V1api20240401WorkspacesConnectionSpecPropertiesApiKeyAuthTypeEnum AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspacesConnectionSpecPropertiesApiKeyCategoryEnum? Category { get; set; }

    /// <summary>Credentials: Api key object for workspace connection credential.</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionSpecPropertiesApiKeyCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesApiKeyValueFormatEnum? ValueFormat { get; set; }
}

/// <summary>AuthType: Authentication type of the connection target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysAuthTypeEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysAuthTypeEnum
{
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys
}

/// <summary>Category: Category of the connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysCategoryEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysCategoryEnum
{
    [EnumMember(Value = "ADLSGen2"), JsonStringEnumMemberName("ADLSGen2")]
    ADLSGen2,
    [EnumMember(Value = "AIServices"), JsonStringEnumMemberName("AIServices")]
    AIServices,
    [EnumMember(Value = "AmazonMws"), JsonStringEnumMemberName("AmazonMws")]
    AmazonMws,
    [EnumMember(Value = "AmazonRdsForOracle"), JsonStringEnumMemberName("AmazonRdsForOracle")]
    AmazonRdsForOracle,
    [EnumMember(Value = "AmazonRdsForSqlServer"), JsonStringEnumMemberName("AmazonRdsForSqlServer")]
    AmazonRdsForSqlServer,
    [EnumMember(Value = "AmazonRedshift"), JsonStringEnumMemberName("AmazonRedshift")]
    AmazonRedshift,
    [EnumMember(Value = "AmazonS3Compatible"), JsonStringEnumMemberName("AmazonS3Compatible")]
    AmazonS3Compatible,
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey,
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureDataExplorer"), JsonStringEnumMemberName("AzureDataExplorer")]
    AzureDataExplorer,
    [EnumMember(Value = "AzureDatabricksDeltaLake"), JsonStringEnumMemberName("AzureDatabricksDeltaLake")]
    AzureDatabricksDeltaLake,
    [EnumMember(Value = "AzureMariaDb"), JsonStringEnumMemberName("AzureMariaDb")]
    AzureMariaDb,
    [EnumMember(Value = "AzureMySqlDb"), JsonStringEnumMemberName("AzureMySqlDb")]
    AzureMySqlDb,
    [EnumMember(Value = "AzureOneLake"), JsonStringEnumMemberName("AzureOneLake")]
    AzureOneLake,
    [EnumMember(Value = "AzureOpenAI"), JsonStringEnumMemberName("AzureOpenAI")]
    AzureOpenAI,
    [EnumMember(Value = "AzurePostgresDb"), JsonStringEnumMemberName("AzurePostgresDb")]
    AzurePostgresDb,
    [EnumMember(Value = "AzureSqlDb"), JsonStringEnumMemberName("AzureSqlDb")]
    AzureSqlDb,
    [EnumMember(Value = "AzureSqlMi"), JsonStringEnumMemberName("AzureSqlMi")]
    AzureSqlMi,
    [EnumMember(Value = "AzureSynapseAnalytics"), JsonStringEnumMemberName("AzureSynapseAnalytics")]
    AzureSynapseAnalytics,
    [EnumMember(Value = "AzureTableStorage"), JsonStringEnumMemberName("AzureTableStorage")]
    AzureTableStorage,
    [EnumMember(Value = "BingLLMSearch"), JsonStringEnumMemberName("BingLLMSearch")]
    BingLLMSearch,
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "CognitiveSearch"), JsonStringEnumMemberName("CognitiveSearch")]
    CognitiveSearch,
    [EnumMember(Value = "CognitiveService"), JsonStringEnumMemberName("CognitiveService")]
    CognitiveService,
    [EnumMember(Value = "Concur"), JsonStringEnumMemberName("Concur")]
    Concur,
    [EnumMember(Value = "ContainerRegistry"), JsonStringEnumMemberName("ContainerRegistry")]
    ContainerRegistry,
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb,
    [EnumMember(Value = "CosmosDbMongoDbApi"), JsonStringEnumMemberName("CosmosDbMongoDbApi")]
    CosmosDbMongoDbApi,
    [EnumMember(Value = "Couchbase"), JsonStringEnumMemberName("Couchbase")]
    Couchbase,
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys,
    [EnumMember(Value = "Db2"), JsonStringEnumMemberName("Db2")]
    Db2,
    [EnumMember(Value = "Drill"), JsonStringEnumMemberName("Drill")]
    Drill,
    [EnumMember(Value = "Dynamics"), JsonStringEnumMemberName("Dynamics")]
    Dynamics,
    [EnumMember(Value = "DynamicsAx"), JsonStringEnumMemberName("DynamicsAx")]
    DynamicsAx,
    [EnumMember(Value = "DynamicsCrm"), JsonStringEnumMemberName("DynamicsCrm")]
    DynamicsCrm,
    [EnumMember(Value = "Eloqua"), JsonStringEnumMemberName("Eloqua")]
    Eloqua,
    [EnumMember(Value = "FileServer"), JsonStringEnumMemberName("FileServer")]
    FileServer,
    [EnumMember(Value = "FtpServer"), JsonStringEnumMemberName("FtpServer")]
    FtpServer,
    [EnumMember(Value = "GenericContainerRegistry"), JsonStringEnumMemberName("GenericContainerRegistry")]
    GenericContainerRegistry,
    [EnumMember(Value = "GenericHttp"), JsonStringEnumMemberName("GenericHttp")]
    GenericHttp,
    [EnumMember(Value = "GenericRest"), JsonStringEnumMemberName("GenericRest")]
    GenericRest,
    [EnumMember(Value = "Git"), JsonStringEnumMemberName("Git")]
    Git,
    [EnumMember(Value = "GoogleAdWords"), JsonStringEnumMemberName("GoogleAdWords")]
    GoogleAdWords,
    [EnumMember(Value = "GoogleBigQuery"), JsonStringEnumMemberName("GoogleBigQuery")]
    GoogleBigQuery,
    [EnumMember(Value = "GoogleCloudStorage"), JsonStringEnumMemberName("GoogleCloudStorage")]
    GoogleCloudStorage,
    [EnumMember(Value = "Greenplum"), JsonStringEnumMemberName("Greenplum")]
    Greenplum,
    [EnumMember(Value = "Hbase"), JsonStringEnumMemberName("Hbase")]
    Hbase,
    [EnumMember(Value = "Hdfs"), JsonStringEnumMemberName("Hdfs")]
    Hdfs,
    [EnumMember(Value = "Hive"), JsonStringEnumMemberName("Hive")]
    Hive,
    [EnumMember(Value = "Hubspot"), JsonStringEnumMemberName("Hubspot")]
    Hubspot,
    [EnumMember(Value = "Impala"), JsonStringEnumMemberName("Impala")]
    Impala,
    [EnumMember(Value = "Informix"), JsonStringEnumMemberName("Informix")]
    Informix,
    [EnumMember(Value = "Jira"), JsonStringEnumMemberName("Jira")]
    Jira,
    [EnumMember(Value = "Magento"), JsonStringEnumMemberName("Magento")]
    Magento,
    [EnumMember(Value = "MariaDb"), JsonStringEnumMemberName("MariaDb")]
    MariaDb,
    [EnumMember(Value = "Marketo"), JsonStringEnumMemberName("Marketo")]
    Marketo,
    [EnumMember(Value = "MicrosoftAccess"), JsonStringEnumMemberName("MicrosoftAccess")]
    MicrosoftAccess,
    [EnumMember(Value = "MongoDbAtlas"), JsonStringEnumMemberName("MongoDbAtlas")]
    MongoDbAtlas,
    [EnumMember(Value = "MongoDbV2"), JsonStringEnumMemberName("MongoDbV2")]
    MongoDbV2,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "Netezza"), JsonStringEnumMemberName("Netezza")]
    Netezza,
    [EnumMember(Value = "ODataRest"), JsonStringEnumMemberName("ODataRest")]
    ODataRest,
    [EnumMember(Value = "Odbc"), JsonStringEnumMemberName("Odbc")]
    Odbc,
    [EnumMember(Value = "Office365"), JsonStringEnumMemberName("Office365")]
    Office365,
    [EnumMember(Value = "OpenAI"), JsonStringEnumMemberName("OpenAI")]
    OpenAI,
    [EnumMember(Value = "Oracle"), JsonStringEnumMemberName("Oracle")]
    Oracle,
    [EnumMember(Value = "OracleCloudStorage"), JsonStringEnumMemberName("OracleCloudStorage")]
    OracleCloudStorage,
    [EnumMember(Value = "OracleServiceCloud"), JsonStringEnumMemberName("OracleServiceCloud")]
    OracleServiceCloud,
    [EnumMember(Value = "PayPal"), JsonStringEnumMemberName("PayPal")]
    PayPal,
    [EnumMember(Value = "Phoenix"), JsonStringEnumMemberName("Phoenix")]
    Phoenix,
    [EnumMember(Value = "PostgreSql"), JsonStringEnumMemberName("PostgreSql")]
    PostgreSql,
    [EnumMember(Value = "Presto"), JsonStringEnumMemberName("Presto")]
    Presto,
    [EnumMember(Value = "PythonFeed"), JsonStringEnumMemberName("PythonFeed")]
    PythonFeed,
    [EnumMember(Value = "QuickBooks"), JsonStringEnumMemberName("QuickBooks")]
    QuickBooks,
    [EnumMember(Value = "Redis"), JsonStringEnumMemberName("Redis")]
    Redis,
    [EnumMember(Value = "Responsys"), JsonStringEnumMemberName("Responsys")]
    Responsys,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3,
    [EnumMember(Value = "Salesforce"), JsonStringEnumMemberName("Salesforce")]
    Salesforce,
    [EnumMember(Value = "SalesforceMarketingCloud"), JsonStringEnumMemberName("SalesforceMarketingCloud")]
    SalesforceMarketingCloud,
    [EnumMember(Value = "SalesforceServiceCloud"), JsonStringEnumMemberName("SalesforceServiceCloud")]
    SalesforceServiceCloud,
    [EnumMember(Value = "SapBw"), JsonStringEnumMemberName("SapBw")]
    SapBw,
    [EnumMember(Value = "SapCloudForCustomer"), JsonStringEnumMemberName("SapCloudForCustomer")]
    SapCloudForCustomer,
    [EnumMember(Value = "SapEcc"), JsonStringEnumMemberName("SapEcc")]
    SapEcc,
    [EnumMember(Value = "SapHana"), JsonStringEnumMemberName("SapHana")]
    SapHana,
    [EnumMember(Value = "SapOpenHub"), JsonStringEnumMemberName("SapOpenHub")]
    SapOpenHub,
    [EnumMember(Value = "SapTable"), JsonStringEnumMemberName("SapTable")]
    SapTable,
    [EnumMember(Value = "Serp"), JsonStringEnumMemberName("Serp")]
    Serp,
    [EnumMember(Value = "Serverless"), JsonStringEnumMemberName("Serverless")]
    Serverless,
    [EnumMember(Value = "ServiceNow"), JsonStringEnumMemberName("ServiceNow")]
    ServiceNow,
    [EnumMember(Value = "Sftp"), JsonStringEnumMemberName("Sftp")]
    Sftp,
    [EnumMember(Value = "SharePointOnlineList"), JsonStringEnumMemberName("SharePointOnlineList")]
    SharePointOnlineList,
    [EnumMember(Value = "Shopify"), JsonStringEnumMemberName("Shopify")]
    Shopify,
    [EnumMember(Value = "Snowflake"), JsonStringEnumMemberName("Snowflake")]
    Snowflake,
    [EnumMember(Value = "Spark"), JsonStringEnumMemberName("Spark")]
    Spark,
    [EnumMember(Value = "SqlServer"), JsonStringEnumMemberName("SqlServer")]
    SqlServer,
    [EnumMember(Value = "Square"), JsonStringEnumMemberName("Square")]
    Square,
    [EnumMember(Value = "Sybase"), JsonStringEnumMemberName("Sybase")]
    Sybase,
    [EnumMember(Value = "Teradata"), JsonStringEnumMemberName("Teradata")]
    Teradata,
    [EnumMember(Value = "Vertica"), JsonStringEnumMemberName("Vertica")]
    Vertica,
    [EnumMember(Value = "WebTable"), JsonStringEnumMemberName("WebTable")]
    WebTable,
    [EnumMember(Value = "Xero"), JsonStringEnumMemberName("Xero")]
    Xero,
    [EnumMember(Value = "Zoho"), JsonStringEnumMemberName("Zoho")]
    Zoho
}

/// <summary>
/// SecretMapReference is a reference to a Kubernetes secret in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysCredentialsKeys
{
    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Credentials: Custom Keys credential object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysCredentials
{
    /// <summary>
    /// SecretMapReference is a reference to a Kubernetes secret in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("keys")]
    public V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysCredentialsKeys? Keys { get; set; }
}

/// <summary>ValueFormat: format for the workspace connection value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysValueFormatEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysValueFormatEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>CustomKeys: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesCustomKeys
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public required V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysAuthTypeEnum AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysCategoryEnum? Category { get; set; }

    /// <summary>Credentials: Custom Keys credential object</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesCustomKeysValueFormatEnum? ValueFormat { get; set; }
}

/// <summary>AuthType: Authentication type of the connection target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityAuthTypeEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityAuthTypeEnum
{
    [EnumMember(Value = "ManagedIdentity"), JsonStringEnumMemberName("ManagedIdentity")]
    ManagedIdentity
}

/// <summary>Category: Category of the connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityCategoryEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityCategoryEnum
{
    [EnumMember(Value = "ADLSGen2"), JsonStringEnumMemberName("ADLSGen2")]
    ADLSGen2,
    [EnumMember(Value = "AIServices"), JsonStringEnumMemberName("AIServices")]
    AIServices,
    [EnumMember(Value = "AmazonMws"), JsonStringEnumMemberName("AmazonMws")]
    AmazonMws,
    [EnumMember(Value = "AmazonRdsForOracle"), JsonStringEnumMemberName("AmazonRdsForOracle")]
    AmazonRdsForOracle,
    [EnumMember(Value = "AmazonRdsForSqlServer"), JsonStringEnumMemberName("AmazonRdsForSqlServer")]
    AmazonRdsForSqlServer,
    [EnumMember(Value = "AmazonRedshift"), JsonStringEnumMemberName("AmazonRedshift")]
    AmazonRedshift,
    [EnumMember(Value = "AmazonS3Compatible"), JsonStringEnumMemberName("AmazonS3Compatible")]
    AmazonS3Compatible,
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey,
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureDataExplorer"), JsonStringEnumMemberName("AzureDataExplorer")]
    AzureDataExplorer,
    [EnumMember(Value = "AzureDatabricksDeltaLake"), JsonStringEnumMemberName("AzureDatabricksDeltaLake")]
    AzureDatabricksDeltaLake,
    [EnumMember(Value = "AzureMariaDb"), JsonStringEnumMemberName("AzureMariaDb")]
    AzureMariaDb,
    [EnumMember(Value = "AzureMySqlDb"), JsonStringEnumMemberName("AzureMySqlDb")]
    AzureMySqlDb,
    [EnumMember(Value = "AzureOneLake"), JsonStringEnumMemberName("AzureOneLake")]
    AzureOneLake,
    [EnumMember(Value = "AzureOpenAI"), JsonStringEnumMemberName("AzureOpenAI")]
    AzureOpenAI,
    [EnumMember(Value = "AzurePostgresDb"), JsonStringEnumMemberName("AzurePostgresDb")]
    AzurePostgresDb,
    [EnumMember(Value = "AzureSqlDb"), JsonStringEnumMemberName("AzureSqlDb")]
    AzureSqlDb,
    [EnumMember(Value = "AzureSqlMi"), JsonStringEnumMemberName("AzureSqlMi")]
    AzureSqlMi,
    [EnumMember(Value = "AzureSynapseAnalytics"), JsonStringEnumMemberName("AzureSynapseAnalytics")]
    AzureSynapseAnalytics,
    [EnumMember(Value = "AzureTableStorage"), JsonStringEnumMemberName("AzureTableStorage")]
    AzureTableStorage,
    [EnumMember(Value = "BingLLMSearch"), JsonStringEnumMemberName("BingLLMSearch")]
    BingLLMSearch,
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "CognitiveSearch"), JsonStringEnumMemberName("CognitiveSearch")]
    CognitiveSearch,
    [EnumMember(Value = "CognitiveService"), JsonStringEnumMemberName("CognitiveService")]
    CognitiveService,
    [EnumMember(Value = "Concur"), JsonStringEnumMemberName("Concur")]
    Concur,
    [EnumMember(Value = "ContainerRegistry"), JsonStringEnumMemberName("ContainerRegistry")]
    ContainerRegistry,
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb,
    [EnumMember(Value = "CosmosDbMongoDbApi"), JsonStringEnumMemberName("CosmosDbMongoDbApi")]
    CosmosDbMongoDbApi,
    [EnumMember(Value = "Couchbase"), JsonStringEnumMemberName("Couchbase")]
    Couchbase,
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys,
    [EnumMember(Value = "Db2"), JsonStringEnumMemberName("Db2")]
    Db2,
    [EnumMember(Value = "Drill"), JsonStringEnumMemberName("Drill")]
    Drill,
    [EnumMember(Value = "Dynamics"), JsonStringEnumMemberName("Dynamics")]
    Dynamics,
    [EnumMember(Value = "DynamicsAx"), JsonStringEnumMemberName("DynamicsAx")]
    DynamicsAx,
    [EnumMember(Value = "DynamicsCrm"), JsonStringEnumMemberName("DynamicsCrm")]
    DynamicsCrm,
    [EnumMember(Value = "Eloqua"), JsonStringEnumMemberName("Eloqua")]
    Eloqua,
    [EnumMember(Value = "FileServer"), JsonStringEnumMemberName("FileServer")]
    FileServer,
    [EnumMember(Value = "FtpServer"), JsonStringEnumMemberName("FtpServer")]
    FtpServer,
    [EnumMember(Value = "GenericContainerRegistry"), JsonStringEnumMemberName("GenericContainerRegistry")]
    GenericContainerRegistry,
    [EnumMember(Value = "GenericHttp"), JsonStringEnumMemberName("GenericHttp")]
    GenericHttp,
    [EnumMember(Value = "GenericRest"), JsonStringEnumMemberName("GenericRest")]
    GenericRest,
    [EnumMember(Value = "Git"), JsonStringEnumMemberName("Git")]
    Git,
    [EnumMember(Value = "GoogleAdWords"), JsonStringEnumMemberName("GoogleAdWords")]
    GoogleAdWords,
    [EnumMember(Value = "GoogleBigQuery"), JsonStringEnumMemberName("GoogleBigQuery")]
    GoogleBigQuery,
    [EnumMember(Value = "GoogleCloudStorage"), JsonStringEnumMemberName("GoogleCloudStorage")]
    GoogleCloudStorage,
    [EnumMember(Value = "Greenplum"), JsonStringEnumMemberName("Greenplum")]
    Greenplum,
    [EnumMember(Value = "Hbase"), JsonStringEnumMemberName("Hbase")]
    Hbase,
    [EnumMember(Value = "Hdfs"), JsonStringEnumMemberName("Hdfs")]
    Hdfs,
    [EnumMember(Value = "Hive"), JsonStringEnumMemberName("Hive")]
    Hive,
    [EnumMember(Value = "Hubspot"), JsonStringEnumMemberName("Hubspot")]
    Hubspot,
    [EnumMember(Value = "Impala"), JsonStringEnumMemberName("Impala")]
    Impala,
    [EnumMember(Value = "Informix"), JsonStringEnumMemberName("Informix")]
    Informix,
    [EnumMember(Value = "Jira"), JsonStringEnumMemberName("Jira")]
    Jira,
    [EnumMember(Value = "Magento"), JsonStringEnumMemberName("Magento")]
    Magento,
    [EnumMember(Value = "MariaDb"), JsonStringEnumMemberName("MariaDb")]
    MariaDb,
    [EnumMember(Value = "Marketo"), JsonStringEnumMemberName("Marketo")]
    Marketo,
    [EnumMember(Value = "MicrosoftAccess"), JsonStringEnumMemberName("MicrosoftAccess")]
    MicrosoftAccess,
    [EnumMember(Value = "MongoDbAtlas"), JsonStringEnumMemberName("MongoDbAtlas")]
    MongoDbAtlas,
    [EnumMember(Value = "MongoDbV2"), JsonStringEnumMemberName("MongoDbV2")]
    MongoDbV2,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "Netezza"), JsonStringEnumMemberName("Netezza")]
    Netezza,
    [EnumMember(Value = "ODataRest"), JsonStringEnumMemberName("ODataRest")]
    ODataRest,
    [EnumMember(Value = "Odbc"), JsonStringEnumMemberName("Odbc")]
    Odbc,
    [EnumMember(Value = "Office365"), JsonStringEnumMemberName("Office365")]
    Office365,
    [EnumMember(Value = "OpenAI"), JsonStringEnumMemberName("OpenAI")]
    OpenAI,
    [EnumMember(Value = "Oracle"), JsonStringEnumMemberName("Oracle")]
    Oracle,
    [EnumMember(Value = "OracleCloudStorage"), JsonStringEnumMemberName("OracleCloudStorage")]
    OracleCloudStorage,
    [EnumMember(Value = "OracleServiceCloud"), JsonStringEnumMemberName("OracleServiceCloud")]
    OracleServiceCloud,
    [EnumMember(Value = "PayPal"), JsonStringEnumMemberName("PayPal")]
    PayPal,
    [EnumMember(Value = "Phoenix"), JsonStringEnumMemberName("Phoenix")]
    Phoenix,
    [EnumMember(Value = "PostgreSql"), JsonStringEnumMemberName("PostgreSql")]
    PostgreSql,
    [EnumMember(Value = "Presto"), JsonStringEnumMemberName("Presto")]
    Presto,
    [EnumMember(Value = "PythonFeed"), JsonStringEnumMemberName("PythonFeed")]
    PythonFeed,
    [EnumMember(Value = "QuickBooks"), JsonStringEnumMemberName("QuickBooks")]
    QuickBooks,
    [EnumMember(Value = "Redis"), JsonStringEnumMemberName("Redis")]
    Redis,
    [EnumMember(Value = "Responsys"), JsonStringEnumMemberName("Responsys")]
    Responsys,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3,
    [EnumMember(Value = "Salesforce"), JsonStringEnumMemberName("Salesforce")]
    Salesforce,
    [EnumMember(Value = "SalesforceMarketingCloud"), JsonStringEnumMemberName("SalesforceMarketingCloud")]
    SalesforceMarketingCloud,
    [EnumMember(Value = "SalesforceServiceCloud"), JsonStringEnumMemberName("SalesforceServiceCloud")]
    SalesforceServiceCloud,
    [EnumMember(Value = "SapBw"), JsonStringEnumMemberName("SapBw")]
    SapBw,
    [EnumMember(Value = "SapCloudForCustomer"), JsonStringEnumMemberName("SapCloudForCustomer")]
    SapCloudForCustomer,
    [EnumMember(Value = "SapEcc"), JsonStringEnumMemberName("SapEcc")]
    SapEcc,
    [EnumMember(Value = "SapHana"), JsonStringEnumMemberName("SapHana")]
    SapHana,
    [EnumMember(Value = "SapOpenHub"), JsonStringEnumMemberName("SapOpenHub")]
    SapOpenHub,
    [EnumMember(Value = "SapTable"), JsonStringEnumMemberName("SapTable")]
    SapTable,
    [EnumMember(Value = "Serp"), JsonStringEnumMemberName("Serp")]
    Serp,
    [EnumMember(Value = "Serverless"), JsonStringEnumMemberName("Serverless")]
    Serverless,
    [EnumMember(Value = "ServiceNow"), JsonStringEnumMemberName("ServiceNow")]
    ServiceNow,
    [EnumMember(Value = "Sftp"), JsonStringEnumMemberName("Sftp")]
    Sftp,
    [EnumMember(Value = "SharePointOnlineList"), JsonStringEnumMemberName("SharePointOnlineList")]
    SharePointOnlineList,
    [EnumMember(Value = "Shopify"), JsonStringEnumMemberName("Shopify")]
    Shopify,
    [EnumMember(Value = "Snowflake"), JsonStringEnumMemberName("Snowflake")]
    Snowflake,
    [EnumMember(Value = "Spark"), JsonStringEnumMemberName("Spark")]
    Spark,
    [EnumMember(Value = "SqlServer"), JsonStringEnumMemberName("SqlServer")]
    SqlServer,
    [EnumMember(Value = "Square"), JsonStringEnumMemberName("Square")]
    Square,
    [EnumMember(Value = "Sybase"), JsonStringEnumMemberName("Sybase")]
    Sybase,
    [EnumMember(Value = "Teradata"), JsonStringEnumMemberName("Teradata")]
    Teradata,
    [EnumMember(Value = "Vertica"), JsonStringEnumMemberName("Vertica")]
    Vertica,
    [EnumMember(Value = "WebTable"), JsonStringEnumMemberName("WebTable")]
    WebTable,
    [EnumMember(Value = "Xero"), JsonStringEnumMemberName("Xero")]
    Xero,
    [EnumMember(Value = "Zoho"), JsonStringEnumMemberName("Zoho")]
    Zoho
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityCredentialsClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityCredentialsResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityCredentials
{
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityCredentialsClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityCredentialsResourceReference? ResourceReference { get; set; }
}

/// <summary>ValueFormat: format for the workspace connection value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityValueFormatEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityValueFormatEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>ManagedIdentity: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentity
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public required V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityAuthTypeEnum AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityCategoryEnum? Category { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentityValueFormatEnum? ValueFormat { get; set; }
}

/// <summary>AuthType: Authentication type of the connection target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesNoneAuthTypeEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesNoneAuthTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>Category: Category of the connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesNoneCategoryEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesNoneCategoryEnum
{
    [EnumMember(Value = "ADLSGen2"), JsonStringEnumMemberName("ADLSGen2")]
    ADLSGen2,
    [EnumMember(Value = "AIServices"), JsonStringEnumMemberName("AIServices")]
    AIServices,
    [EnumMember(Value = "AmazonMws"), JsonStringEnumMemberName("AmazonMws")]
    AmazonMws,
    [EnumMember(Value = "AmazonRdsForOracle"), JsonStringEnumMemberName("AmazonRdsForOracle")]
    AmazonRdsForOracle,
    [EnumMember(Value = "AmazonRdsForSqlServer"), JsonStringEnumMemberName("AmazonRdsForSqlServer")]
    AmazonRdsForSqlServer,
    [EnumMember(Value = "AmazonRedshift"), JsonStringEnumMemberName("AmazonRedshift")]
    AmazonRedshift,
    [EnumMember(Value = "AmazonS3Compatible"), JsonStringEnumMemberName("AmazonS3Compatible")]
    AmazonS3Compatible,
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey,
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureDataExplorer"), JsonStringEnumMemberName("AzureDataExplorer")]
    AzureDataExplorer,
    [EnumMember(Value = "AzureDatabricksDeltaLake"), JsonStringEnumMemberName("AzureDatabricksDeltaLake")]
    AzureDatabricksDeltaLake,
    [EnumMember(Value = "AzureMariaDb"), JsonStringEnumMemberName("AzureMariaDb")]
    AzureMariaDb,
    [EnumMember(Value = "AzureMySqlDb"), JsonStringEnumMemberName("AzureMySqlDb")]
    AzureMySqlDb,
    [EnumMember(Value = "AzureOneLake"), JsonStringEnumMemberName("AzureOneLake")]
    AzureOneLake,
    [EnumMember(Value = "AzureOpenAI"), JsonStringEnumMemberName("AzureOpenAI")]
    AzureOpenAI,
    [EnumMember(Value = "AzurePostgresDb"), JsonStringEnumMemberName("AzurePostgresDb")]
    AzurePostgresDb,
    [EnumMember(Value = "AzureSqlDb"), JsonStringEnumMemberName("AzureSqlDb")]
    AzureSqlDb,
    [EnumMember(Value = "AzureSqlMi"), JsonStringEnumMemberName("AzureSqlMi")]
    AzureSqlMi,
    [EnumMember(Value = "AzureSynapseAnalytics"), JsonStringEnumMemberName("AzureSynapseAnalytics")]
    AzureSynapseAnalytics,
    [EnumMember(Value = "AzureTableStorage"), JsonStringEnumMemberName("AzureTableStorage")]
    AzureTableStorage,
    [EnumMember(Value = "BingLLMSearch"), JsonStringEnumMemberName("BingLLMSearch")]
    BingLLMSearch,
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "CognitiveSearch"), JsonStringEnumMemberName("CognitiveSearch")]
    CognitiveSearch,
    [EnumMember(Value = "CognitiveService"), JsonStringEnumMemberName("CognitiveService")]
    CognitiveService,
    [EnumMember(Value = "Concur"), JsonStringEnumMemberName("Concur")]
    Concur,
    [EnumMember(Value = "ContainerRegistry"), JsonStringEnumMemberName("ContainerRegistry")]
    ContainerRegistry,
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb,
    [EnumMember(Value = "CosmosDbMongoDbApi"), JsonStringEnumMemberName("CosmosDbMongoDbApi")]
    CosmosDbMongoDbApi,
    [EnumMember(Value = "Couchbase"), JsonStringEnumMemberName("Couchbase")]
    Couchbase,
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys,
    [EnumMember(Value = "Db2"), JsonStringEnumMemberName("Db2")]
    Db2,
    [EnumMember(Value = "Drill"), JsonStringEnumMemberName("Drill")]
    Drill,
    [EnumMember(Value = "Dynamics"), JsonStringEnumMemberName("Dynamics")]
    Dynamics,
    [EnumMember(Value = "DynamicsAx"), JsonStringEnumMemberName("DynamicsAx")]
    DynamicsAx,
    [EnumMember(Value = "DynamicsCrm"), JsonStringEnumMemberName("DynamicsCrm")]
    DynamicsCrm,
    [EnumMember(Value = "Eloqua"), JsonStringEnumMemberName("Eloqua")]
    Eloqua,
    [EnumMember(Value = "FileServer"), JsonStringEnumMemberName("FileServer")]
    FileServer,
    [EnumMember(Value = "FtpServer"), JsonStringEnumMemberName("FtpServer")]
    FtpServer,
    [EnumMember(Value = "GenericContainerRegistry"), JsonStringEnumMemberName("GenericContainerRegistry")]
    GenericContainerRegistry,
    [EnumMember(Value = "GenericHttp"), JsonStringEnumMemberName("GenericHttp")]
    GenericHttp,
    [EnumMember(Value = "GenericRest"), JsonStringEnumMemberName("GenericRest")]
    GenericRest,
    [EnumMember(Value = "Git"), JsonStringEnumMemberName("Git")]
    Git,
    [EnumMember(Value = "GoogleAdWords"), JsonStringEnumMemberName("GoogleAdWords")]
    GoogleAdWords,
    [EnumMember(Value = "GoogleBigQuery"), JsonStringEnumMemberName("GoogleBigQuery")]
    GoogleBigQuery,
    [EnumMember(Value = "GoogleCloudStorage"), JsonStringEnumMemberName("GoogleCloudStorage")]
    GoogleCloudStorage,
    [EnumMember(Value = "Greenplum"), JsonStringEnumMemberName("Greenplum")]
    Greenplum,
    [EnumMember(Value = "Hbase"), JsonStringEnumMemberName("Hbase")]
    Hbase,
    [EnumMember(Value = "Hdfs"), JsonStringEnumMemberName("Hdfs")]
    Hdfs,
    [EnumMember(Value = "Hive"), JsonStringEnumMemberName("Hive")]
    Hive,
    [EnumMember(Value = "Hubspot"), JsonStringEnumMemberName("Hubspot")]
    Hubspot,
    [EnumMember(Value = "Impala"), JsonStringEnumMemberName("Impala")]
    Impala,
    [EnumMember(Value = "Informix"), JsonStringEnumMemberName("Informix")]
    Informix,
    [EnumMember(Value = "Jira"), JsonStringEnumMemberName("Jira")]
    Jira,
    [EnumMember(Value = "Magento"), JsonStringEnumMemberName("Magento")]
    Magento,
    [EnumMember(Value = "MariaDb"), JsonStringEnumMemberName("MariaDb")]
    MariaDb,
    [EnumMember(Value = "Marketo"), JsonStringEnumMemberName("Marketo")]
    Marketo,
    [EnumMember(Value = "MicrosoftAccess"), JsonStringEnumMemberName("MicrosoftAccess")]
    MicrosoftAccess,
    [EnumMember(Value = "MongoDbAtlas"), JsonStringEnumMemberName("MongoDbAtlas")]
    MongoDbAtlas,
    [EnumMember(Value = "MongoDbV2"), JsonStringEnumMemberName("MongoDbV2")]
    MongoDbV2,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "Netezza"), JsonStringEnumMemberName("Netezza")]
    Netezza,
    [EnumMember(Value = "ODataRest"), JsonStringEnumMemberName("ODataRest")]
    ODataRest,
    [EnumMember(Value = "Odbc"), JsonStringEnumMemberName("Odbc")]
    Odbc,
    [EnumMember(Value = "Office365"), JsonStringEnumMemberName("Office365")]
    Office365,
    [EnumMember(Value = "OpenAI"), JsonStringEnumMemberName("OpenAI")]
    OpenAI,
    [EnumMember(Value = "Oracle"), JsonStringEnumMemberName("Oracle")]
    Oracle,
    [EnumMember(Value = "OracleCloudStorage"), JsonStringEnumMemberName("OracleCloudStorage")]
    OracleCloudStorage,
    [EnumMember(Value = "OracleServiceCloud"), JsonStringEnumMemberName("OracleServiceCloud")]
    OracleServiceCloud,
    [EnumMember(Value = "PayPal"), JsonStringEnumMemberName("PayPal")]
    PayPal,
    [EnumMember(Value = "Phoenix"), JsonStringEnumMemberName("Phoenix")]
    Phoenix,
    [EnumMember(Value = "PostgreSql"), JsonStringEnumMemberName("PostgreSql")]
    PostgreSql,
    [EnumMember(Value = "Presto"), JsonStringEnumMemberName("Presto")]
    Presto,
    [EnumMember(Value = "PythonFeed"), JsonStringEnumMemberName("PythonFeed")]
    PythonFeed,
    [EnumMember(Value = "QuickBooks"), JsonStringEnumMemberName("QuickBooks")]
    QuickBooks,
    [EnumMember(Value = "Redis"), JsonStringEnumMemberName("Redis")]
    Redis,
    [EnumMember(Value = "Responsys"), JsonStringEnumMemberName("Responsys")]
    Responsys,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3,
    [EnumMember(Value = "Salesforce"), JsonStringEnumMemberName("Salesforce")]
    Salesforce,
    [EnumMember(Value = "SalesforceMarketingCloud"), JsonStringEnumMemberName("SalesforceMarketingCloud")]
    SalesforceMarketingCloud,
    [EnumMember(Value = "SalesforceServiceCloud"), JsonStringEnumMemberName("SalesforceServiceCloud")]
    SalesforceServiceCloud,
    [EnumMember(Value = "SapBw"), JsonStringEnumMemberName("SapBw")]
    SapBw,
    [EnumMember(Value = "SapCloudForCustomer"), JsonStringEnumMemberName("SapCloudForCustomer")]
    SapCloudForCustomer,
    [EnumMember(Value = "SapEcc"), JsonStringEnumMemberName("SapEcc")]
    SapEcc,
    [EnumMember(Value = "SapHana"), JsonStringEnumMemberName("SapHana")]
    SapHana,
    [EnumMember(Value = "SapOpenHub"), JsonStringEnumMemberName("SapOpenHub")]
    SapOpenHub,
    [EnumMember(Value = "SapTable"), JsonStringEnumMemberName("SapTable")]
    SapTable,
    [EnumMember(Value = "Serp"), JsonStringEnumMemberName("Serp")]
    Serp,
    [EnumMember(Value = "Serverless"), JsonStringEnumMemberName("Serverless")]
    Serverless,
    [EnumMember(Value = "ServiceNow"), JsonStringEnumMemberName("ServiceNow")]
    ServiceNow,
    [EnumMember(Value = "Sftp"), JsonStringEnumMemberName("Sftp")]
    Sftp,
    [EnumMember(Value = "SharePointOnlineList"), JsonStringEnumMemberName("SharePointOnlineList")]
    SharePointOnlineList,
    [EnumMember(Value = "Shopify"), JsonStringEnumMemberName("Shopify")]
    Shopify,
    [EnumMember(Value = "Snowflake"), JsonStringEnumMemberName("Snowflake")]
    Snowflake,
    [EnumMember(Value = "Spark"), JsonStringEnumMemberName("Spark")]
    Spark,
    [EnumMember(Value = "SqlServer"), JsonStringEnumMemberName("SqlServer")]
    SqlServer,
    [EnumMember(Value = "Square"), JsonStringEnumMemberName("Square")]
    Square,
    [EnumMember(Value = "Sybase"), JsonStringEnumMemberName("Sybase")]
    Sybase,
    [EnumMember(Value = "Teradata"), JsonStringEnumMemberName("Teradata")]
    Teradata,
    [EnumMember(Value = "Vertica"), JsonStringEnumMemberName("Vertica")]
    Vertica,
    [EnumMember(Value = "WebTable"), JsonStringEnumMemberName("WebTable")]
    WebTable,
    [EnumMember(Value = "Xero"), JsonStringEnumMemberName("Xero")]
    Xero,
    [EnumMember(Value = "Zoho"), JsonStringEnumMemberName("Zoho")]
    Zoho
}

/// <summary>ValueFormat: format for the workspace connection value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesNoneValueFormatEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesNoneValueFormatEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>None: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesNone
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public required V1api20240401WorkspacesConnectionSpecPropertiesNoneAuthTypeEnum AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspacesConnectionSpecPropertiesNoneCategoryEnum? Category { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesNoneValueFormatEnum? ValueFormat { get; set; }
}

/// <summary>AuthType: Authentication type of the connection target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesOAuth2AuthTypeEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesOAuth2AuthTypeEnum
{
    [EnumMember(Value = "OAuth2"), JsonStringEnumMemberName("OAuth2")]
    OAuth2
}

/// <summary>Category: Category of the connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CategoryEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CategoryEnum
{
    [EnumMember(Value = "ADLSGen2"), JsonStringEnumMemberName("ADLSGen2")]
    ADLSGen2,
    [EnumMember(Value = "AIServices"), JsonStringEnumMemberName("AIServices")]
    AIServices,
    [EnumMember(Value = "AmazonMws"), JsonStringEnumMemberName("AmazonMws")]
    AmazonMws,
    [EnumMember(Value = "AmazonRdsForOracle"), JsonStringEnumMemberName("AmazonRdsForOracle")]
    AmazonRdsForOracle,
    [EnumMember(Value = "AmazonRdsForSqlServer"), JsonStringEnumMemberName("AmazonRdsForSqlServer")]
    AmazonRdsForSqlServer,
    [EnumMember(Value = "AmazonRedshift"), JsonStringEnumMemberName("AmazonRedshift")]
    AmazonRedshift,
    [EnumMember(Value = "AmazonS3Compatible"), JsonStringEnumMemberName("AmazonS3Compatible")]
    AmazonS3Compatible,
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey,
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureDataExplorer"), JsonStringEnumMemberName("AzureDataExplorer")]
    AzureDataExplorer,
    [EnumMember(Value = "AzureDatabricksDeltaLake"), JsonStringEnumMemberName("AzureDatabricksDeltaLake")]
    AzureDatabricksDeltaLake,
    [EnumMember(Value = "AzureMariaDb"), JsonStringEnumMemberName("AzureMariaDb")]
    AzureMariaDb,
    [EnumMember(Value = "AzureMySqlDb"), JsonStringEnumMemberName("AzureMySqlDb")]
    AzureMySqlDb,
    [EnumMember(Value = "AzureOneLake"), JsonStringEnumMemberName("AzureOneLake")]
    AzureOneLake,
    [EnumMember(Value = "AzureOpenAI"), JsonStringEnumMemberName("AzureOpenAI")]
    AzureOpenAI,
    [EnumMember(Value = "AzurePostgresDb"), JsonStringEnumMemberName("AzurePostgresDb")]
    AzurePostgresDb,
    [EnumMember(Value = "AzureSqlDb"), JsonStringEnumMemberName("AzureSqlDb")]
    AzureSqlDb,
    [EnumMember(Value = "AzureSqlMi"), JsonStringEnumMemberName("AzureSqlMi")]
    AzureSqlMi,
    [EnumMember(Value = "AzureSynapseAnalytics"), JsonStringEnumMemberName("AzureSynapseAnalytics")]
    AzureSynapseAnalytics,
    [EnumMember(Value = "AzureTableStorage"), JsonStringEnumMemberName("AzureTableStorage")]
    AzureTableStorage,
    [EnumMember(Value = "BingLLMSearch"), JsonStringEnumMemberName("BingLLMSearch")]
    BingLLMSearch,
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "CognitiveSearch"), JsonStringEnumMemberName("CognitiveSearch")]
    CognitiveSearch,
    [EnumMember(Value = "CognitiveService"), JsonStringEnumMemberName("CognitiveService")]
    CognitiveService,
    [EnumMember(Value = "Concur"), JsonStringEnumMemberName("Concur")]
    Concur,
    [EnumMember(Value = "ContainerRegistry"), JsonStringEnumMemberName("ContainerRegistry")]
    ContainerRegistry,
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb,
    [EnumMember(Value = "CosmosDbMongoDbApi"), JsonStringEnumMemberName("CosmosDbMongoDbApi")]
    CosmosDbMongoDbApi,
    [EnumMember(Value = "Couchbase"), JsonStringEnumMemberName("Couchbase")]
    Couchbase,
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys,
    [EnumMember(Value = "Db2"), JsonStringEnumMemberName("Db2")]
    Db2,
    [EnumMember(Value = "Drill"), JsonStringEnumMemberName("Drill")]
    Drill,
    [EnumMember(Value = "Dynamics"), JsonStringEnumMemberName("Dynamics")]
    Dynamics,
    [EnumMember(Value = "DynamicsAx"), JsonStringEnumMemberName("DynamicsAx")]
    DynamicsAx,
    [EnumMember(Value = "DynamicsCrm"), JsonStringEnumMemberName("DynamicsCrm")]
    DynamicsCrm,
    [EnumMember(Value = "Eloqua"), JsonStringEnumMemberName("Eloqua")]
    Eloqua,
    [EnumMember(Value = "FileServer"), JsonStringEnumMemberName("FileServer")]
    FileServer,
    [EnumMember(Value = "FtpServer"), JsonStringEnumMemberName("FtpServer")]
    FtpServer,
    [EnumMember(Value = "GenericContainerRegistry"), JsonStringEnumMemberName("GenericContainerRegistry")]
    GenericContainerRegistry,
    [EnumMember(Value = "GenericHttp"), JsonStringEnumMemberName("GenericHttp")]
    GenericHttp,
    [EnumMember(Value = "GenericRest"), JsonStringEnumMemberName("GenericRest")]
    GenericRest,
    [EnumMember(Value = "Git"), JsonStringEnumMemberName("Git")]
    Git,
    [EnumMember(Value = "GoogleAdWords"), JsonStringEnumMemberName("GoogleAdWords")]
    GoogleAdWords,
    [EnumMember(Value = "GoogleBigQuery"), JsonStringEnumMemberName("GoogleBigQuery")]
    GoogleBigQuery,
    [EnumMember(Value = "GoogleCloudStorage"), JsonStringEnumMemberName("GoogleCloudStorage")]
    GoogleCloudStorage,
    [EnumMember(Value = "Greenplum"), JsonStringEnumMemberName("Greenplum")]
    Greenplum,
    [EnumMember(Value = "Hbase"), JsonStringEnumMemberName("Hbase")]
    Hbase,
    [EnumMember(Value = "Hdfs"), JsonStringEnumMemberName("Hdfs")]
    Hdfs,
    [EnumMember(Value = "Hive"), JsonStringEnumMemberName("Hive")]
    Hive,
    [EnumMember(Value = "Hubspot"), JsonStringEnumMemberName("Hubspot")]
    Hubspot,
    [EnumMember(Value = "Impala"), JsonStringEnumMemberName("Impala")]
    Impala,
    [EnumMember(Value = "Informix"), JsonStringEnumMemberName("Informix")]
    Informix,
    [EnumMember(Value = "Jira"), JsonStringEnumMemberName("Jira")]
    Jira,
    [EnumMember(Value = "Magento"), JsonStringEnumMemberName("Magento")]
    Magento,
    [EnumMember(Value = "MariaDb"), JsonStringEnumMemberName("MariaDb")]
    MariaDb,
    [EnumMember(Value = "Marketo"), JsonStringEnumMemberName("Marketo")]
    Marketo,
    [EnumMember(Value = "MicrosoftAccess"), JsonStringEnumMemberName("MicrosoftAccess")]
    MicrosoftAccess,
    [EnumMember(Value = "MongoDbAtlas"), JsonStringEnumMemberName("MongoDbAtlas")]
    MongoDbAtlas,
    [EnumMember(Value = "MongoDbV2"), JsonStringEnumMemberName("MongoDbV2")]
    MongoDbV2,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "Netezza"), JsonStringEnumMemberName("Netezza")]
    Netezza,
    [EnumMember(Value = "ODataRest"), JsonStringEnumMemberName("ODataRest")]
    ODataRest,
    [EnumMember(Value = "Odbc"), JsonStringEnumMemberName("Odbc")]
    Odbc,
    [EnumMember(Value = "Office365"), JsonStringEnumMemberName("Office365")]
    Office365,
    [EnumMember(Value = "OpenAI"), JsonStringEnumMemberName("OpenAI")]
    OpenAI,
    [EnumMember(Value = "Oracle"), JsonStringEnumMemberName("Oracle")]
    Oracle,
    [EnumMember(Value = "OracleCloudStorage"), JsonStringEnumMemberName("OracleCloudStorage")]
    OracleCloudStorage,
    [EnumMember(Value = "OracleServiceCloud"), JsonStringEnumMemberName("OracleServiceCloud")]
    OracleServiceCloud,
    [EnumMember(Value = "PayPal"), JsonStringEnumMemberName("PayPal")]
    PayPal,
    [EnumMember(Value = "Phoenix"), JsonStringEnumMemberName("Phoenix")]
    Phoenix,
    [EnumMember(Value = "PostgreSql"), JsonStringEnumMemberName("PostgreSql")]
    PostgreSql,
    [EnumMember(Value = "Presto"), JsonStringEnumMemberName("Presto")]
    Presto,
    [EnumMember(Value = "PythonFeed"), JsonStringEnumMemberName("PythonFeed")]
    PythonFeed,
    [EnumMember(Value = "QuickBooks"), JsonStringEnumMemberName("QuickBooks")]
    QuickBooks,
    [EnumMember(Value = "Redis"), JsonStringEnumMemberName("Redis")]
    Redis,
    [EnumMember(Value = "Responsys"), JsonStringEnumMemberName("Responsys")]
    Responsys,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3,
    [EnumMember(Value = "Salesforce"), JsonStringEnumMemberName("Salesforce")]
    Salesforce,
    [EnumMember(Value = "SalesforceMarketingCloud"), JsonStringEnumMemberName("SalesforceMarketingCloud")]
    SalesforceMarketingCloud,
    [EnumMember(Value = "SalesforceServiceCloud"), JsonStringEnumMemberName("SalesforceServiceCloud")]
    SalesforceServiceCloud,
    [EnumMember(Value = "SapBw"), JsonStringEnumMemberName("SapBw")]
    SapBw,
    [EnumMember(Value = "SapCloudForCustomer"), JsonStringEnumMemberName("SapCloudForCustomer")]
    SapCloudForCustomer,
    [EnumMember(Value = "SapEcc"), JsonStringEnumMemberName("SapEcc")]
    SapEcc,
    [EnumMember(Value = "SapHana"), JsonStringEnumMemberName("SapHana")]
    SapHana,
    [EnumMember(Value = "SapOpenHub"), JsonStringEnumMemberName("SapOpenHub")]
    SapOpenHub,
    [EnumMember(Value = "SapTable"), JsonStringEnumMemberName("SapTable")]
    SapTable,
    [EnumMember(Value = "Serp"), JsonStringEnumMemberName("Serp")]
    Serp,
    [EnumMember(Value = "Serverless"), JsonStringEnumMemberName("Serverless")]
    Serverless,
    [EnumMember(Value = "ServiceNow"), JsonStringEnumMemberName("ServiceNow")]
    ServiceNow,
    [EnumMember(Value = "Sftp"), JsonStringEnumMemberName("Sftp")]
    Sftp,
    [EnumMember(Value = "SharePointOnlineList"), JsonStringEnumMemberName("SharePointOnlineList")]
    SharePointOnlineList,
    [EnumMember(Value = "Shopify"), JsonStringEnumMemberName("Shopify")]
    Shopify,
    [EnumMember(Value = "Snowflake"), JsonStringEnumMemberName("Snowflake")]
    Snowflake,
    [EnumMember(Value = "Spark"), JsonStringEnumMemberName("Spark")]
    Spark,
    [EnumMember(Value = "SqlServer"), JsonStringEnumMemberName("SqlServer")]
    SqlServer,
    [EnumMember(Value = "Square"), JsonStringEnumMemberName("Square")]
    Square,
    [EnumMember(Value = "Sybase"), JsonStringEnumMemberName("Sybase")]
    Sybase,
    [EnumMember(Value = "Teradata"), JsonStringEnumMemberName("Teradata")]
    Teradata,
    [EnumMember(Value = "Vertica"), JsonStringEnumMemberName("Vertica")]
    Vertica,
    [EnumMember(Value = "WebTable"), JsonStringEnumMemberName("WebTable")]
    WebTable,
    [EnumMember(Value = "Xero"), JsonStringEnumMemberName("Xero")]
    Xero,
    [EnumMember(Value = "Zoho"), JsonStringEnumMemberName("Zoho")]
    Zoho
}

/// <summary>ClientIdFromConfig: Client id in the format of UUID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CredentialsClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CredentialsClientSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DeveloperToken: Required by GoogleAdWords connection category</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CredentialsDeveloperToken
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CredentialsPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// RefreshToken: Required by GoogleBigQuery, GoogleAdWords, Hubspot, QuickBooks, Square, Xero, Zoho
/// where user needs to get RefreshToken offline
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CredentialsRefreshToken
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>TenantIdFromConfig: Required by QuickBooks and Xero connection categories</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CredentialsTenantIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Credentials: ClientId and ClientSecret are required. Other properties are optional
/// depending on each OAuth2 provider&apos;s  implementation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesOAuth2Credentials
{
    /// <summary>AuthUrl: Required by Concur connection category</summary>
    [JsonPropertyName("authUrl")]
    public string? AuthUrl { get; set; }

    /// <summary>ClientId: Client id in the format of UUID</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientIdFromConfig: Client id in the format of UUID</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CredentialsClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CredentialsClientSecret? ClientSecret { get; set; }

    /// <summary>DeveloperToken: Required by GoogleAdWords connection category</summary>
    [JsonPropertyName("developerToken")]
    public V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CredentialsDeveloperToken? DeveloperToken { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("password")]
    public V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CredentialsPassword? Password { get; set; }

    /// <summary>
    /// RefreshToken: Required by GoogleBigQuery, GoogleAdWords, Hubspot, QuickBooks, Square, Xero, Zoho
    /// where user needs to get RefreshToken offline
    /// </summary>
    [JsonPropertyName("refreshToken")]
    public V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CredentialsRefreshToken? RefreshToken { get; set; }

    /// <summary>TenantId: Required by QuickBooks and Xero connection categories</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>TenantIdFromConfig: Required by QuickBooks and Xero connection categories</summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CredentialsTenantIdFromConfig? TenantIdFromConfig { get; set; }

    /// <summary>
    /// Username: Concur, ServiceNow auth server AccessToken grant type is &apos;Password&apos;
    /// which requires UsernamePassword
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>ValueFormat: format for the workspace connection value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesOAuth2ValueFormatEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesOAuth2ValueFormatEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>OAuth2: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesOAuth2
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public required V1api20240401WorkspacesConnectionSpecPropertiesOAuth2AuthTypeEnum AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspacesConnectionSpecPropertiesOAuth2CategoryEnum? Category { get; set; }

    /// <summary>
    /// Credentials: ClientId and ClientSecret are required. Other properties are optional
    /// depending on each OAuth2 provider&apos;s  implementation.
    /// </summary>
    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionSpecPropertiesOAuth2Credentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesOAuth2ValueFormatEnum? ValueFormat { get; set; }
}

/// <summary>AuthType: Authentication type of the connection target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesPatAuthTypeEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesPatAuthTypeEnum
{
    [EnumMember(Value = "PAT"), JsonStringEnumMemberName("PAT")]
    PAT
}

/// <summary>Category: Category of the connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesPatCategoryEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesPatCategoryEnum
{
    [EnumMember(Value = "ADLSGen2"), JsonStringEnumMemberName("ADLSGen2")]
    ADLSGen2,
    [EnumMember(Value = "AIServices"), JsonStringEnumMemberName("AIServices")]
    AIServices,
    [EnumMember(Value = "AmazonMws"), JsonStringEnumMemberName("AmazonMws")]
    AmazonMws,
    [EnumMember(Value = "AmazonRdsForOracle"), JsonStringEnumMemberName("AmazonRdsForOracle")]
    AmazonRdsForOracle,
    [EnumMember(Value = "AmazonRdsForSqlServer"), JsonStringEnumMemberName("AmazonRdsForSqlServer")]
    AmazonRdsForSqlServer,
    [EnumMember(Value = "AmazonRedshift"), JsonStringEnumMemberName("AmazonRedshift")]
    AmazonRedshift,
    [EnumMember(Value = "AmazonS3Compatible"), JsonStringEnumMemberName("AmazonS3Compatible")]
    AmazonS3Compatible,
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey,
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureDataExplorer"), JsonStringEnumMemberName("AzureDataExplorer")]
    AzureDataExplorer,
    [EnumMember(Value = "AzureDatabricksDeltaLake"), JsonStringEnumMemberName("AzureDatabricksDeltaLake")]
    AzureDatabricksDeltaLake,
    [EnumMember(Value = "AzureMariaDb"), JsonStringEnumMemberName("AzureMariaDb")]
    AzureMariaDb,
    [EnumMember(Value = "AzureMySqlDb"), JsonStringEnumMemberName("AzureMySqlDb")]
    AzureMySqlDb,
    [EnumMember(Value = "AzureOneLake"), JsonStringEnumMemberName("AzureOneLake")]
    AzureOneLake,
    [EnumMember(Value = "AzureOpenAI"), JsonStringEnumMemberName("AzureOpenAI")]
    AzureOpenAI,
    [EnumMember(Value = "AzurePostgresDb"), JsonStringEnumMemberName("AzurePostgresDb")]
    AzurePostgresDb,
    [EnumMember(Value = "AzureSqlDb"), JsonStringEnumMemberName("AzureSqlDb")]
    AzureSqlDb,
    [EnumMember(Value = "AzureSqlMi"), JsonStringEnumMemberName("AzureSqlMi")]
    AzureSqlMi,
    [EnumMember(Value = "AzureSynapseAnalytics"), JsonStringEnumMemberName("AzureSynapseAnalytics")]
    AzureSynapseAnalytics,
    [EnumMember(Value = "AzureTableStorage"), JsonStringEnumMemberName("AzureTableStorage")]
    AzureTableStorage,
    [EnumMember(Value = "BingLLMSearch"), JsonStringEnumMemberName("BingLLMSearch")]
    BingLLMSearch,
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "CognitiveSearch"), JsonStringEnumMemberName("CognitiveSearch")]
    CognitiveSearch,
    [EnumMember(Value = "CognitiveService"), JsonStringEnumMemberName("CognitiveService")]
    CognitiveService,
    [EnumMember(Value = "Concur"), JsonStringEnumMemberName("Concur")]
    Concur,
    [EnumMember(Value = "ContainerRegistry"), JsonStringEnumMemberName("ContainerRegistry")]
    ContainerRegistry,
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb,
    [EnumMember(Value = "CosmosDbMongoDbApi"), JsonStringEnumMemberName("CosmosDbMongoDbApi")]
    CosmosDbMongoDbApi,
    [EnumMember(Value = "Couchbase"), JsonStringEnumMemberName("Couchbase")]
    Couchbase,
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys,
    [EnumMember(Value = "Db2"), JsonStringEnumMemberName("Db2")]
    Db2,
    [EnumMember(Value = "Drill"), JsonStringEnumMemberName("Drill")]
    Drill,
    [EnumMember(Value = "Dynamics"), JsonStringEnumMemberName("Dynamics")]
    Dynamics,
    [EnumMember(Value = "DynamicsAx"), JsonStringEnumMemberName("DynamicsAx")]
    DynamicsAx,
    [EnumMember(Value = "DynamicsCrm"), JsonStringEnumMemberName("DynamicsCrm")]
    DynamicsCrm,
    [EnumMember(Value = "Eloqua"), JsonStringEnumMemberName("Eloqua")]
    Eloqua,
    [EnumMember(Value = "FileServer"), JsonStringEnumMemberName("FileServer")]
    FileServer,
    [EnumMember(Value = "FtpServer"), JsonStringEnumMemberName("FtpServer")]
    FtpServer,
    [EnumMember(Value = "GenericContainerRegistry"), JsonStringEnumMemberName("GenericContainerRegistry")]
    GenericContainerRegistry,
    [EnumMember(Value = "GenericHttp"), JsonStringEnumMemberName("GenericHttp")]
    GenericHttp,
    [EnumMember(Value = "GenericRest"), JsonStringEnumMemberName("GenericRest")]
    GenericRest,
    [EnumMember(Value = "Git"), JsonStringEnumMemberName("Git")]
    Git,
    [EnumMember(Value = "GoogleAdWords"), JsonStringEnumMemberName("GoogleAdWords")]
    GoogleAdWords,
    [EnumMember(Value = "GoogleBigQuery"), JsonStringEnumMemberName("GoogleBigQuery")]
    GoogleBigQuery,
    [EnumMember(Value = "GoogleCloudStorage"), JsonStringEnumMemberName("GoogleCloudStorage")]
    GoogleCloudStorage,
    [EnumMember(Value = "Greenplum"), JsonStringEnumMemberName("Greenplum")]
    Greenplum,
    [EnumMember(Value = "Hbase"), JsonStringEnumMemberName("Hbase")]
    Hbase,
    [EnumMember(Value = "Hdfs"), JsonStringEnumMemberName("Hdfs")]
    Hdfs,
    [EnumMember(Value = "Hive"), JsonStringEnumMemberName("Hive")]
    Hive,
    [EnumMember(Value = "Hubspot"), JsonStringEnumMemberName("Hubspot")]
    Hubspot,
    [EnumMember(Value = "Impala"), JsonStringEnumMemberName("Impala")]
    Impala,
    [EnumMember(Value = "Informix"), JsonStringEnumMemberName("Informix")]
    Informix,
    [EnumMember(Value = "Jira"), JsonStringEnumMemberName("Jira")]
    Jira,
    [EnumMember(Value = "Magento"), JsonStringEnumMemberName("Magento")]
    Magento,
    [EnumMember(Value = "MariaDb"), JsonStringEnumMemberName("MariaDb")]
    MariaDb,
    [EnumMember(Value = "Marketo"), JsonStringEnumMemberName("Marketo")]
    Marketo,
    [EnumMember(Value = "MicrosoftAccess"), JsonStringEnumMemberName("MicrosoftAccess")]
    MicrosoftAccess,
    [EnumMember(Value = "MongoDbAtlas"), JsonStringEnumMemberName("MongoDbAtlas")]
    MongoDbAtlas,
    [EnumMember(Value = "MongoDbV2"), JsonStringEnumMemberName("MongoDbV2")]
    MongoDbV2,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "Netezza"), JsonStringEnumMemberName("Netezza")]
    Netezza,
    [EnumMember(Value = "ODataRest"), JsonStringEnumMemberName("ODataRest")]
    ODataRest,
    [EnumMember(Value = "Odbc"), JsonStringEnumMemberName("Odbc")]
    Odbc,
    [EnumMember(Value = "Office365"), JsonStringEnumMemberName("Office365")]
    Office365,
    [EnumMember(Value = "OpenAI"), JsonStringEnumMemberName("OpenAI")]
    OpenAI,
    [EnumMember(Value = "Oracle"), JsonStringEnumMemberName("Oracle")]
    Oracle,
    [EnumMember(Value = "OracleCloudStorage"), JsonStringEnumMemberName("OracleCloudStorage")]
    OracleCloudStorage,
    [EnumMember(Value = "OracleServiceCloud"), JsonStringEnumMemberName("OracleServiceCloud")]
    OracleServiceCloud,
    [EnumMember(Value = "PayPal"), JsonStringEnumMemberName("PayPal")]
    PayPal,
    [EnumMember(Value = "Phoenix"), JsonStringEnumMemberName("Phoenix")]
    Phoenix,
    [EnumMember(Value = "PostgreSql"), JsonStringEnumMemberName("PostgreSql")]
    PostgreSql,
    [EnumMember(Value = "Presto"), JsonStringEnumMemberName("Presto")]
    Presto,
    [EnumMember(Value = "PythonFeed"), JsonStringEnumMemberName("PythonFeed")]
    PythonFeed,
    [EnumMember(Value = "QuickBooks"), JsonStringEnumMemberName("QuickBooks")]
    QuickBooks,
    [EnumMember(Value = "Redis"), JsonStringEnumMemberName("Redis")]
    Redis,
    [EnumMember(Value = "Responsys"), JsonStringEnumMemberName("Responsys")]
    Responsys,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3,
    [EnumMember(Value = "Salesforce"), JsonStringEnumMemberName("Salesforce")]
    Salesforce,
    [EnumMember(Value = "SalesforceMarketingCloud"), JsonStringEnumMemberName("SalesforceMarketingCloud")]
    SalesforceMarketingCloud,
    [EnumMember(Value = "SalesforceServiceCloud"), JsonStringEnumMemberName("SalesforceServiceCloud")]
    SalesforceServiceCloud,
    [EnumMember(Value = "SapBw"), JsonStringEnumMemberName("SapBw")]
    SapBw,
    [EnumMember(Value = "SapCloudForCustomer"), JsonStringEnumMemberName("SapCloudForCustomer")]
    SapCloudForCustomer,
    [EnumMember(Value = "SapEcc"), JsonStringEnumMemberName("SapEcc")]
    SapEcc,
    [EnumMember(Value = "SapHana"), JsonStringEnumMemberName("SapHana")]
    SapHana,
    [EnumMember(Value = "SapOpenHub"), JsonStringEnumMemberName("SapOpenHub")]
    SapOpenHub,
    [EnumMember(Value = "SapTable"), JsonStringEnumMemberName("SapTable")]
    SapTable,
    [EnumMember(Value = "Serp"), JsonStringEnumMemberName("Serp")]
    Serp,
    [EnumMember(Value = "Serverless"), JsonStringEnumMemberName("Serverless")]
    Serverless,
    [EnumMember(Value = "ServiceNow"), JsonStringEnumMemberName("ServiceNow")]
    ServiceNow,
    [EnumMember(Value = "Sftp"), JsonStringEnumMemberName("Sftp")]
    Sftp,
    [EnumMember(Value = "SharePointOnlineList"), JsonStringEnumMemberName("SharePointOnlineList")]
    SharePointOnlineList,
    [EnumMember(Value = "Shopify"), JsonStringEnumMemberName("Shopify")]
    Shopify,
    [EnumMember(Value = "Snowflake"), JsonStringEnumMemberName("Snowflake")]
    Snowflake,
    [EnumMember(Value = "Spark"), JsonStringEnumMemberName("Spark")]
    Spark,
    [EnumMember(Value = "SqlServer"), JsonStringEnumMemberName("SqlServer")]
    SqlServer,
    [EnumMember(Value = "Square"), JsonStringEnumMemberName("Square")]
    Square,
    [EnumMember(Value = "Sybase"), JsonStringEnumMemberName("Sybase")]
    Sybase,
    [EnumMember(Value = "Teradata"), JsonStringEnumMemberName("Teradata")]
    Teradata,
    [EnumMember(Value = "Vertica"), JsonStringEnumMemberName("Vertica")]
    Vertica,
    [EnumMember(Value = "WebTable"), JsonStringEnumMemberName("WebTable")]
    WebTable,
    [EnumMember(Value = "Xero"), JsonStringEnumMemberName("Xero")]
    Xero,
    [EnumMember(Value = "Zoho"), JsonStringEnumMemberName("Zoho")]
    Zoho
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesPatCredentialsPat
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesPatCredentials
{
    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("pat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesPatCredentialsPat? Pat { get; set; }
}

/// <summary>ValueFormat: format for the workspace connection value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesPatValueFormatEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesPatValueFormatEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>PAT: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesPat
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public required V1api20240401WorkspacesConnectionSpecPropertiesPatAuthTypeEnum AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspacesConnectionSpecPropertiesPatCategoryEnum? Category { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionSpecPropertiesPatCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesPatValueFormatEnum? ValueFormat { get; set; }
}

/// <summary>AuthType: Authentication type of the connection target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesSasAuthTypeEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesSasAuthTypeEnum
{
    [EnumMember(Value = "SAS"), JsonStringEnumMemberName("SAS")]
    SAS
}

/// <summary>Category: Category of the connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesSasCategoryEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesSasCategoryEnum
{
    [EnumMember(Value = "ADLSGen2"), JsonStringEnumMemberName("ADLSGen2")]
    ADLSGen2,
    [EnumMember(Value = "AIServices"), JsonStringEnumMemberName("AIServices")]
    AIServices,
    [EnumMember(Value = "AmazonMws"), JsonStringEnumMemberName("AmazonMws")]
    AmazonMws,
    [EnumMember(Value = "AmazonRdsForOracle"), JsonStringEnumMemberName("AmazonRdsForOracle")]
    AmazonRdsForOracle,
    [EnumMember(Value = "AmazonRdsForSqlServer"), JsonStringEnumMemberName("AmazonRdsForSqlServer")]
    AmazonRdsForSqlServer,
    [EnumMember(Value = "AmazonRedshift"), JsonStringEnumMemberName("AmazonRedshift")]
    AmazonRedshift,
    [EnumMember(Value = "AmazonS3Compatible"), JsonStringEnumMemberName("AmazonS3Compatible")]
    AmazonS3Compatible,
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey,
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureDataExplorer"), JsonStringEnumMemberName("AzureDataExplorer")]
    AzureDataExplorer,
    [EnumMember(Value = "AzureDatabricksDeltaLake"), JsonStringEnumMemberName("AzureDatabricksDeltaLake")]
    AzureDatabricksDeltaLake,
    [EnumMember(Value = "AzureMariaDb"), JsonStringEnumMemberName("AzureMariaDb")]
    AzureMariaDb,
    [EnumMember(Value = "AzureMySqlDb"), JsonStringEnumMemberName("AzureMySqlDb")]
    AzureMySqlDb,
    [EnumMember(Value = "AzureOneLake"), JsonStringEnumMemberName("AzureOneLake")]
    AzureOneLake,
    [EnumMember(Value = "AzureOpenAI"), JsonStringEnumMemberName("AzureOpenAI")]
    AzureOpenAI,
    [EnumMember(Value = "AzurePostgresDb"), JsonStringEnumMemberName("AzurePostgresDb")]
    AzurePostgresDb,
    [EnumMember(Value = "AzureSqlDb"), JsonStringEnumMemberName("AzureSqlDb")]
    AzureSqlDb,
    [EnumMember(Value = "AzureSqlMi"), JsonStringEnumMemberName("AzureSqlMi")]
    AzureSqlMi,
    [EnumMember(Value = "AzureSynapseAnalytics"), JsonStringEnumMemberName("AzureSynapseAnalytics")]
    AzureSynapseAnalytics,
    [EnumMember(Value = "AzureTableStorage"), JsonStringEnumMemberName("AzureTableStorage")]
    AzureTableStorage,
    [EnumMember(Value = "BingLLMSearch"), JsonStringEnumMemberName("BingLLMSearch")]
    BingLLMSearch,
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "CognitiveSearch"), JsonStringEnumMemberName("CognitiveSearch")]
    CognitiveSearch,
    [EnumMember(Value = "CognitiveService"), JsonStringEnumMemberName("CognitiveService")]
    CognitiveService,
    [EnumMember(Value = "Concur"), JsonStringEnumMemberName("Concur")]
    Concur,
    [EnumMember(Value = "ContainerRegistry"), JsonStringEnumMemberName("ContainerRegistry")]
    ContainerRegistry,
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb,
    [EnumMember(Value = "CosmosDbMongoDbApi"), JsonStringEnumMemberName("CosmosDbMongoDbApi")]
    CosmosDbMongoDbApi,
    [EnumMember(Value = "Couchbase"), JsonStringEnumMemberName("Couchbase")]
    Couchbase,
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys,
    [EnumMember(Value = "Db2"), JsonStringEnumMemberName("Db2")]
    Db2,
    [EnumMember(Value = "Drill"), JsonStringEnumMemberName("Drill")]
    Drill,
    [EnumMember(Value = "Dynamics"), JsonStringEnumMemberName("Dynamics")]
    Dynamics,
    [EnumMember(Value = "DynamicsAx"), JsonStringEnumMemberName("DynamicsAx")]
    DynamicsAx,
    [EnumMember(Value = "DynamicsCrm"), JsonStringEnumMemberName("DynamicsCrm")]
    DynamicsCrm,
    [EnumMember(Value = "Eloqua"), JsonStringEnumMemberName("Eloqua")]
    Eloqua,
    [EnumMember(Value = "FileServer"), JsonStringEnumMemberName("FileServer")]
    FileServer,
    [EnumMember(Value = "FtpServer"), JsonStringEnumMemberName("FtpServer")]
    FtpServer,
    [EnumMember(Value = "GenericContainerRegistry"), JsonStringEnumMemberName("GenericContainerRegistry")]
    GenericContainerRegistry,
    [EnumMember(Value = "GenericHttp"), JsonStringEnumMemberName("GenericHttp")]
    GenericHttp,
    [EnumMember(Value = "GenericRest"), JsonStringEnumMemberName("GenericRest")]
    GenericRest,
    [EnumMember(Value = "Git"), JsonStringEnumMemberName("Git")]
    Git,
    [EnumMember(Value = "GoogleAdWords"), JsonStringEnumMemberName("GoogleAdWords")]
    GoogleAdWords,
    [EnumMember(Value = "GoogleBigQuery"), JsonStringEnumMemberName("GoogleBigQuery")]
    GoogleBigQuery,
    [EnumMember(Value = "GoogleCloudStorage"), JsonStringEnumMemberName("GoogleCloudStorage")]
    GoogleCloudStorage,
    [EnumMember(Value = "Greenplum"), JsonStringEnumMemberName("Greenplum")]
    Greenplum,
    [EnumMember(Value = "Hbase"), JsonStringEnumMemberName("Hbase")]
    Hbase,
    [EnumMember(Value = "Hdfs"), JsonStringEnumMemberName("Hdfs")]
    Hdfs,
    [EnumMember(Value = "Hive"), JsonStringEnumMemberName("Hive")]
    Hive,
    [EnumMember(Value = "Hubspot"), JsonStringEnumMemberName("Hubspot")]
    Hubspot,
    [EnumMember(Value = "Impala"), JsonStringEnumMemberName("Impala")]
    Impala,
    [EnumMember(Value = "Informix"), JsonStringEnumMemberName("Informix")]
    Informix,
    [EnumMember(Value = "Jira"), JsonStringEnumMemberName("Jira")]
    Jira,
    [EnumMember(Value = "Magento"), JsonStringEnumMemberName("Magento")]
    Magento,
    [EnumMember(Value = "MariaDb"), JsonStringEnumMemberName("MariaDb")]
    MariaDb,
    [EnumMember(Value = "Marketo"), JsonStringEnumMemberName("Marketo")]
    Marketo,
    [EnumMember(Value = "MicrosoftAccess"), JsonStringEnumMemberName("MicrosoftAccess")]
    MicrosoftAccess,
    [EnumMember(Value = "MongoDbAtlas"), JsonStringEnumMemberName("MongoDbAtlas")]
    MongoDbAtlas,
    [EnumMember(Value = "MongoDbV2"), JsonStringEnumMemberName("MongoDbV2")]
    MongoDbV2,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "Netezza"), JsonStringEnumMemberName("Netezza")]
    Netezza,
    [EnumMember(Value = "ODataRest"), JsonStringEnumMemberName("ODataRest")]
    ODataRest,
    [EnumMember(Value = "Odbc"), JsonStringEnumMemberName("Odbc")]
    Odbc,
    [EnumMember(Value = "Office365"), JsonStringEnumMemberName("Office365")]
    Office365,
    [EnumMember(Value = "OpenAI"), JsonStringEnumMemberName("OpenAI")]
    OpenAI,
    [EnumMember(Value = "Oracle"), JsonStringEnumMemberName("Oracle")]
    Oracle,
    [EnumMember(Value = "OracleCloudStorage"), JsonStringEnumMemberName("OracleCloudStorage")]
    OracleCloudStorage,
    [EnumMember(Value = "OracleServiceCloud"), JsonStringEnumMemberName("OracleServiceCloud")]
    OracleServiceCloud,
    [EnumMember(Value = "PayPal"), JsonStringEnumMemberName("PayPal")]
    PayPal,
    [EnumMember(Value = "Phoenix"), JsonStringEnumMemberName("Phoenix")]
    Phoenix,
    [EnumMember(Value = "PostgreSql"), JsonStringEnumMemberName("PostgreSql")]
    PostgreSql,
    [EnumMember(Value = "Presto"), JsonStringEnumMemberName("Presto")]
    Presto,
    [EnumMember(Value = "PythonFeed"), JsonStringEnumMemberName("PythonFeed")]
    PythonFeed,
    [EnumMember(Value = "QuickBooks"), JsonStringEnumMemberName("QuickBooks")]
    QuickBooks,
    [EnumMember(Value = "Redis"), JsonStringEnumMemberName("Redis")]
    Redis,
    [EnumMember(Value = "Responsys"), JsonStringEnumMemberName("Responsys")]
    Responsys,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3,
    [EnumMember(Value = "Salesforce"), JsonStringEnumMemberName("Salesforce")]
    Salesforce,
    [EnumMember(Value = "SalesforceMarketingCloud"), JsonStringEnumMemberName("SalesforceMarketingCloud")]
    SalesforceMarketingCloud,
    [EnumMember(Value = "SalesforceServiceCloud"), JsonStringEnumMemberName("SalesforceServiceCloud")]
    SalesforceServiceCloud,
    [EnumMember(Value = "SapBw"), JsonStringEnumMemberName("SapBw")]
    SapBw,
    [EnumMember(Value = "SapCloudForCustomer"), JsonStringEnumMemberName("SapCloudForCustomer")]
    SapCloudForCustomer,
    [EnumMember(Value = "SapEcc"), JsonStringEnumMemberName("SapEcc")]
    SapEcc,
    [EnumMember(Value = "SapHana"), JsonStringEnumMemberName("SapHana")]
    SapHana,
    [EnumMember(Value = "SapOpenHub"), JsonStringEnumMemberName("SapOpenHub")]
    SapOpenHub,
    [EnumMember(Value = "SapTable"), JsonStringEnumMemberName("SapTable")]
    SapTable,
    [EnumMember(Value = "Serp"), JsonStringEnumMemberName("Serp")]
    Serp,
    [EnumMember(Value = "Serverless"), JsonStringEnumMemberName("Serverless")]
    Serverless,
    [EnumMember(Value = "ServiceNow"), JsonStringEnumMemberName("ServiceNow")]
    ServiceNow,
    [EnumMember(Value = "Sftp"), JsonStringEnumMemberName("Sftp")]
    Sftp,
    [EnumMember(Value = "SharePointOnlineList"), JsonStringEnumMemberName("SharePointOnlineList")]
    SharePointOnlineList,
    [EnumMember(Value = "Shopify"), JsonStringEnumMemberName("Shopify")]
    Shopify,
    [EnumMember(Value = "Snowflake"), JsonStringEnumMemberName("Snowflake")]
    Snowflake,
    [EnumMember(Value = "Spark"), JsonStringEnumMemberName("Spark")]
    Spark,
    [EnumMember(Value = "SqlServer"), JsonStringEnumMemberName("SqlServer")]
    SqlServer,
    [EnumMember(Value = "Square"), JsonStringEnumMemberName("Square")]
    Square,
    [EnumMember(Value = "Sybase"), JsonStringEnumMemberName("Sybase")]
    Sybase,
    [EnumMember(Value = "Teradata"), JsonStringEnumMemberName("Teradata")]
    Teradata,
    [EnumMember(Value = "Vertica"), JsonStringEnumMemberName("Vertica")]
    Vertica,
    [EnumMember(Value = "WebTable"), JsonStringEnumMemberName("WebTable")]
    WebTable,
    [EnumMember(Value = "Xero"), JsonStringEnumMemberName("Xero")]
    Xero,
    [EnumMember(Value = "Zoho"), JsonStringEnumMemberName("Zoho")]
    Zoho
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesSasCredentialsSas
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesSasCredentials
{
    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("sas")]
    public V1api20240401WorkspacesConnectionSpecPropertiesSasCredentialsSas? Sas { get; set; }
}

/// <summary>ValueFormat: format for the workspace connection value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesSasValueFormatEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesSasValueFormatEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>SAS: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesSas
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public required V1api20240401WorkspacesConnectionSpecPropertiesSasAuthTypeEnum AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspacesConnectionSpecPropertiesSasCategoryEnum? Category { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionSpecPropertiesSasCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesSasValueFormatEnum? ValueFormat { get; set; }
}

/// <summary>AuthType: Authentication type of the connection target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalAuthTypeEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalAuthTypeEnum
{
    [EnumMember(Value = "ServicePrincipal"), JsonStringEnumMemberName("ServicePrincipal")]
    ServicePrincipal
}

/// <summary>Category: Category of the connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalCategoryEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalCategoryEnum
{
    [EnumMember(Value = "ADLSGen2"), JsonStringEnumMemberName("ADLSGen2")]
    ADLSGen2,
    [EnumMember(Value = "AIServices"), JsonStringEnumMemberName("AIServices")]
    AIServices,
    [EnumMember(Value = "AmazonMws"), JsonStringEnumMemberName("AmazonMws")]
    AmazonMws,
    [EnumMember(Value = "AmazonRdsForOracle"), JsonStringEnumMemberName("AmazonRdsForOracle")]
    AmazonRdsForOracle,
    [EnumMember(Value = "AmazonRdsForSqlServer"), JsonStringEnumMemberName("AmazonRdsForSqlServer")]
    AmazonRdsForSqlServer,
    [EnumMember(Value = "AmazonRedshift"), JsonStringEnumMemberName("AmazonRedshift")]
    AmazonRedshift,
    [EnumMember(Value = "AmazonS3Compatible"), JsonStringEnumMemberName("AmazonS3Compatible")]
    AmazonS3Compatible,
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey,
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureDataExplorer"), JsonStringEnumMemberName("AzureDataExplorer")]
    AzureDataExplorer,
    [EnumMember(Value = "AzureDatabricksDeltaLake"), JsonStringEnumMemberName("AzureDatabricksDeltaLake")]
    AzureDatabricksDeltaLake,
    [EnumMember(Value = "AzureMariaDb"), JsonStringEnumMemberName("AzureMariaDb")]
    AzureMariaDb,
    [EnumMember(Value = "AzureMySqlDb"), JsonStringEnumMemberName("AzureMySqlDb")]
    AzureMySqlDb,
    [EnumMember(Value = "AzureOneLake"), JsonStringEnumMemberName("AzureOneLake")]
    AzureOneLake,
    [EnumMember(Value = "AzureOpenAI"), JsonStringEnumMemberName("AzureOpenAI")]
    AzureOpenAI,
    [EnumMember(Value = "AzurePostgresDb"), JsonStringEnumMemberName("AzurePostgresDb")]
    AzurePostgresDb,
    [EnumMember(Value = "AzureSqlDb"), JsonStringEnumMemberName("AzureSqlDb")]
    AzureSqlDb,
    [EnumMember(Value = "AzureSqlMi"), JsonStringEnumMemberName("AzureSqlMi")]
    AzureSqlMi,
    [EnumMember(Value = "AzureSynapseAnalytics"), JsonStringEnumMemberName("AzureSynapseAnalytics")]
    AzureSynapseAnalytics,
    [EnumMember(Value = "AzureTableStorage"), JsonStringEnumMemberName("AzureTableStorage")]
    AzureTableStorage,
    [EnumMember(Value = "BingLLMSearch"), JsonStringEnumMemberName("BingLLMSearch")]
    BingLLMSearch,
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "CognitiveSearch"), JsonStringEnumMemberName("CognitiveSearch")]
    CognitiveSearch,
    [EnumMember(Value = "CognitiveService"), JsonStringEnumMemberName("CognitiveService")]
    CognitiveService,
    [EnumMember(Value = "Concur"), JsonStringEnumMemberName("Concur")]
    Concur,
    [EnumMember(Value = "ContainerRegistry"), JsonStringEnumMemberName("ContainerRegistry")]
    ContainerRegistry,
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb,
    [EnumMember(Value = "CosmosDbMongoDbApi"), JsonStringEnumMemberName("CosmosDbMongoDbApi")]
    CosmosDbMongoDbApi,
    [EnumMember(Value = "Couchbase"), JsonStringEnumMemberName("Couchbase")]
    Couchbase,
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys,
    [EnumMember(Value = "Db2"), JsonStringEnumMemberName("Db2")]
    Db2,
    [EnumMember(Value = "Drill"), JsonStringEnumMemberName("Drill")]
    Drill,
    [EnumMember(Value = "Dynamics"), JsonStringEnumMemberName("Dynamics")]
    Dynamics,
    [EnumMember(Value = "DynamicsAx"), JsonStringEnumMemberName("DynamicsAx")]
    DynamicsAx,
    [EnumMember(Value = "DynamicsCrm"), JsonStringEnumMemberName("DynamicsCrm")]
    DynamicsCrm,
    [EnumMember(Value = "Eloqua"), JsonStringEnumMemberName("Eloqua")]
    Eloqua,
    [EnumMember(Value = "FileServer"), JsonStringEnumMemberName("FileServer")]
    FileServer,
    [EnumMember(Value = "FtpServer"), JsonStringEnumMemberName("FtpServer")]
    FtpServer,
    [EnumMember(Value = "GenericContainerRegistry"), JsonStringEnumMemberName("GenericContainerRegistry")]
    GenericContainerRegistry,
    [EnumMember(Value = "GenericHttp"), JsonStringEnumMemberName("GenericHttp")]
    GenericHttp,
    [EnumMember(Value = "GenericRest"), JsonStringEnumMemberName("GenericRest")]
    GenericRest,
    [EnumMember(Value = "Git"), JsonStringEnumMemberName("Git")]
    Git,
    [EnumMember(Value = "GoogleAdWords"), JsonStringEnumMemberName("GoogleAdWords")]
    GoogleAdWords,
    [EnumMember(Value = "GoogleBigQuery"), JsonStringEnumMemberName("GoogleBigQuery")]
    GoogleBigQuery,
    [EnumMember(Value = "GoogleCloudStorage"), JsonStringEnumMemberName("GoogleCloudStorage")]
    GoogleCloudStorage,
    [EnumMember(Value = "Greenplum"), JsonStringEnumMemberName("Greenplum")]
    Greenplum,
    [EnumMember(Value = "Hbase"), JsonStringEnumMemberName("Hbase")]
    Hbase,
    [EnumMember(Value = "Hdfs"), JsonStringEnumMemberName("Hdfs")]
    Hdfs,
    [EnumMember(Value = "Hive"), JsonStringEnumMemberName("Hive")]
    Hive,
    [EnumMember(Value = "Hubspot"), JsonStringEnumMemberName("Hubspot")]
    Hubspot,
    [EnumMember(Value = "Impala"), JsonStringEnumMemberName("Impala")]
    Impala,
    [EnumMember(Value = "Informix"), JsonStringEnumMemberName("Informix")]
    Informix,
    [EnumMember(Value = "Jira"), JsonStringEnumMemberName("Jira")]
    Jira,
    [EnumMember(Value = "Magento"), JsonStringEnumMemberName("Magento")]
    Magento,
    [EnumMember(Value = "MariaDb"), JsonStringEnumMemberName("MariaDb")]
    MariaDb,
    [EnumMember(Value = "Marketo"), JsonStringEnumMemberName("Marketo")]
    Marketo,
    [EnumMember(Value = "MicrosoftAccess"), JsonStringEnumMemberName("MicrosoftAccess")]
    MicrosoftAccess,
    [EnumMember(Value = "MongoDbAtlas"), JsonStringEnumMemberName("MongoDbAtlas")]
    MongoDbAtlas,
    [EnumMember(Value = "MongoDbV2"), JsonStringEnumMemberName("MongoDbV2")]
    MongoDbV2,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "Netezza"), JsonStringEnumMemberName("Netezza")]
    Netezza,
    [EnumMember(Value = "ODataRest"), JsonStringEnumMemberName("ODataRest")]
    ODataRest,
    [EnumMember(Value = "Odbc"), JsonStringEnumMemberName("Odbc")]
    Odbc,
    [EnumMember(Value = "Office365"), JsonStringEnumMemberName("Office365")]
    Office365,
    [EnumMember(Value = "OpenAI"), JsonStringEnumMemberName("OpenAI")]
    OpenAI,
    [EnumMember(Value = "Oracle"), JsonStringEnumMemberName("Oracle")]
    Oracle,
    [EnumMember(Value = "OracleCloudStorage"), JsonStringEnumMemberName("OracleCloudStorage")]
    OracleCloudStorage,
    [EnumMember(Value = "OracleServiceCloud"), JsonStringEnumMemberName("OracleServiceCloud")]
    OracleServiceCloud,
    [EnumMember(Value = "PayPal"), JsonStringEnumMemberName("PayPal")]
    PayPal,
    [EnumMember(Value = "Phoenix"), JsonStringEnumMemberName("Phoenix")]
    Phoenix,
    [EnumMember(Value = "PostgreSql"), JsonStringEnumMemberName("PostgreSql")]
    PostgreSql,
    [EnumMember(Value = "Presto"), JsonStringEnumMemberName("Presto")]
    Presto,
    [EnumMember(Value = "PythonFeed"), JsonStringEnumMemberName("PythonFeed")]
    PythonFeed,
    [EnumMember(Value = "QuickBooks"), JsonStringEnumMemberName("QuickBooks")]
    QuickBooks,
    [EnumMember(Value = "Redis"), JsonStringEnumMemberName("Redis")]
    Redis,
    [EnumMember(Value = "Responsys"), JsonStringEnumMemberName("Responsys")]
    Responsys,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3,
    [EnumMember(Value = "Salesforce"), JsonStringEnumMemberName("Salesforce")]
    Salesforce,
    [EnumMember(Value = "SalesforceMarketingCloud"), JsonStringEnumMemberName("SalesforceMarketingCloud")]
    SalesforceMarketingCloud,
    [EnumMember(Value = "SalesforceServiceCloud"), JsonStringEnumMemberName("SalesforceServiceCloud")]
    SalesforceServiceCloud,
    [EnumMember(Value = "SapBw"), JsonStringEnumMemberName("SapBw")]
    SapBw,
    [EnumMember(Value = "SapCloudForCustomer"), JsonStringEnumMemberName("SapCloudForCustomer")]
    SapCloudForCustomer,
    [EnumMember(Value = "SapEcc"), JsonStringEnumMemberName("SapEcc")]
    SapEcc,
    [EnumMember(Value = "SapHana"), JsonStringEnumMemberName("SapHana")]
    SapHana,
    [EnumMember(Value = "SapOpenHub"), JsonStringEnumMemberName("SapOpenHub")]
    SapOpenHub,
    [EnumMember(Value = "SapTable"), JsonStringEnumMemberName("SapTable")]
    SapTable,
    [EnumMember(Value = "Serp"), JsonStringEnumMemberName("Serp")]
    Serp,
    [EnumMember(Value = "Serverless"), JsonStringEnumMemberName("Serverless")]
    Serverless,
    [EnumMember(Value = "ServiceNow"), JsonStringEnumMemberName("ServiceNow")]
    ServiceNow,
    [EnumMember(Value = "Sftp"), JsonStringEnumMemberName("Sftp")]
    Sftp,
    [EnumMember(Value = "SharePointOnlineList"), JsonStringEnumMemberName("SharePointOnlineList")]
    SharePointOnlineList,
    [EnumMember(Value = "Shopify"), JsonStringEnumMemberName("Shopify")]
    Shopify,
    [EnumMember(Value = "Snowflake"), JsonStringEnumMemberName("Snowflake")]
    Snowflake,
    [EnumMember(Value = "Spark"), JsonStringEnumMemberName("Spark")]
    Spark,
    [EnumMember(Value = "SqlServer"), JsonStringEnumMemberName("SqlServer")]
    SqlServer,
    [EnumMember(Value = "Square"), JsonStringEnumMemberName("Square")]
    Square,
    [EnumMember(Value = "Sybase"), JsonStringEnumMemberName("Sybase")]
    Sybase,
    [EnumMember(Value = "Teradata"), JsonStringEnumMemberName("Teradata")]
    Teradata,
    [EnumMember(Value = "Vertica"), JsonStringEnumMemberName("Vertica")]
    Vertica,
    [EnumMember(Value = "WebTable"), JsonStringEnumMemberName("WebTable")]
    WebTable,
    [EnumMember(Value = "Xero"), JsonStringEnumMemberName("Xero")]
    Xero,
    [EnumMember(Value = "Zoho"), JsonStringEnumMemberName("Zoho")]
    Zoho
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalCredentialsClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalCredentialsClientSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalCredentialsTenantIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalCredentials
{
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalCredentialsClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalCredentialsClientSecret? ClientSecret { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalCredentialsTenantIdFromConfig? TenantIdFromConfig { get; set; }
}

/// <summary>ValueFormat: format for the workspace connection value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalValueFormatEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalValueFormatEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>ServicePrincipal: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipal
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public required V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalAuthTypeEnum AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalCategoryEnum? Category { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipalValueFormatEnum? ValueFormat { get; set; }
}

/// <summary>AuthType: Authentication type of the connection target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordAuthTypeEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordAuthTypeEnum
{
    [EnumMember(Value = "UsernamePassword"), JsonStringEnumMemberName("UsernamePassword")]
    UsernamePassword
}

/// <summary>Category: Category of the connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordCategoryEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordCategoryEnum
{
    [EnumMember(Value = "ADLSGen2"), JsonStringEnumMemberName("ADLSGen2")]
    ADLSGen2,
    [EnumMember(Value = "AIServices"), JsonStringEnumMemberName("AIServices")]
    AIServices,
    [EnumMember(Value = "AmazonMws"), JsonStringEnumMemberName("AmazonMws")]
    AmazonMws,
    [EnumMember(Value = "AmazonRdsForOracle"), JsonStringEnumMemberName("AmazonRdsForOracle")]
    AmazonRdsForOracle,
    [EnumMember(Value = "AmazonRdsForSqlServer"), JsonStringEnumMemberName("AmazonRdsForSqlServer")]
    AmazonRdsForSqlServer,
    [EnumMember(Value = "AmazonRedshift"), JsonStringEnumMemberName("AmazonRedshift")]
    AmazonRedshift,
    [EnumMember(Value = "AmazonS3Compatible"), JsonStringEnumMemberName("AmazonS3Compatible")]
    AmazonS3Compatible,
    [EnumMember(Value = "ApiKey"), JsonStringEnumMemberName("ApiKey")]
    ApiKey,
    [EnumMember(Value = "AzureBlob"), JsonStringEnumMemberName("AzureBlob")]
    AzureBlob,
    [EnumMember(Value = "AzureDataExplorer"), JsonStringEnumMemberName("AzureDataExplorer")]
    AzureDataExplorer,
    [EnumMember(Value = "AzureDatabricksDeltaLake"), JsonStringEnumMemberName("AzureDatabricksDeltaLake")]
    AzureDatabricksDeltaLake,
    [EnumMember(Value = "AzureMariaDb"), JsonStringEnumMemberName("AzureMariaDb")]
    AzureMariaDb,
    [EnumMember(Value = "AzureMySqlDb"), JsonStringEnumMemberName("AzureMySqlDb")]
    AzureMySqlDb,
    [EnumMember(Value = "AzureOneLake"), JsonStringEnumMemberName("AzureOneLake")]
    AzureOneLake,
    [EnumMember(Value = "AzureOpenAI"), JsonStringEnumMemberName("AzureOpenAI")]
    AzureOpenAI,
    [EnumMember(Value = "AzurePostgresDb"), JsonStringEnumMemberName("AzurePostgresDb")]
    AzurePostgresDb,
    [EnumMember(Value = "AzureSqlDb"), JsonStringEnumMemberName("AzureSqlDb")]
    AzureSqlDb,
    [EnumMember(Value = "AzureSqlMi"), JsonStringEnumMemberName("AzureSqlMi")]
    AzureSqlMi,
    [EnumMember(Value = "AzureSynapseAnalytics"), JsonStringEnumMemberName("AzureSynapseAnalytics")]
    AzureSynapseAnalytics,
    [EnumMember(Value = "AzureTableStorage"), JsonStringEnumMemberName("AzureTableStorage")]
    AzureTableStorage,
    [EnumMember(Value = "BingLLMSearch"), JsonStringEnumMemberName("BingLLMSearch")]
    BingLLMSearch,
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "CognitiveSearch"), JsonStringEnumMemberName("CognitiveSearch")]
    CognitiveSearch,
    [EnumMember(Value = "CognitiveService"), JsonStringEnumMemberName("CognitiveService")]
    CognitiveService,
    [EnumMember(Value = "Concur"), JsonStringEnumMemberName("Concur")]
    Concur,
    [EnumMember(Value = "ContainerRegistry"), JsonStringEnumMemberName("ContainerRegistry")]
    ContainerRegistry,
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb,
    [EnumMember(Value = "CosmosDbMongoDbApi"), JsonStringEnumMemberName("CosmosDbMongoDbApi")]
    CosmosDbMongoDbApi,
    [EnumMember(Value = "Couchbase"), JsonStringEnumMemberName("Couchbase")]
    Couchbase,
    [EnumMember(Value = "CustomKeys"), JsonStringEnumMemberName("CustomKeys")]
    CustomKeys,
    [EnumMember(Value = "Db2"), JsonStringEnumMemberName("Db2")]
    Db2,
    [EnumMember(Value = "Drill"), JsonStringEnumMemberName("Drill")]
    Drill,
    [EnumMember(Value = "Dynamics"), JsonStringEnumMemberName("Dynamics")]
    Dynamics,
    [EnumMember(Value = "DynamicsAx"), JsonStringEnumMemberName("DynamicsAx")]
    DynamicsAx,
    [EnumMember(Value = "DynamicsCrm"), JsonStringEnumMemberName("DynamicsCrm")]
    DynamicsCrm,
    [EnumMember(Value = "Eloqua"), JsonStringEnumMemberName("Eloqua")]
    Eloqua,
    [EnumMember(Value = "FileServer"), JsonStringEnumMemberName("FileServer")]
    FileServer,
    [EnumMember(Value = "FtpServer"), JsonStringEnumMemberName("FtpServer")]
    FtpServer,
    [EnumMember(Value = "GenericContainerRegistry"), JsonStringEnumMemberName("GenericContainerRegistry")]
    GenericContainerRegistry,
    [EnumMember(Value = "GenericHttp"), JsonStringEnumMemberName("GenericHttp")]
    GenericHttp,
    [EnumMember(Value = "GenericRest"), JsonStringEnumMemberName("GenericRest")]
    GenericRest,
    [EnumMember(Value = "Git"), JsonStringEnumMemberName("Git")]
    Git,
    [EnumMember(Value = "GoogleAdWords"), JsonStringEnumMemberName("GoogleAdWords")]
    GoogleAdWords,
    [EnumMember(Value = "GoogleBigQuery"), JsonStringEnumMemberName("GoogleBigQuery")]
    GoogleBigQuery,
    [EnumMember(Value = "GoogleCloudStorage"), JsonStringEnumMemberName("GoogleCloudStorage")]
    GoogleCloudStorage,
    [EnumMember(Value = "Greenplum"), JsonStringEnumMemberName("Greenplum")]
    Greenplum,
    [EnumMember(Value = "Hbase"), JsonStringEnumMemberName("Hbase")]
    Hbase,
    [EnumMember(Value = "Hdfs"), JsonStringEnumMemberName("Hdfs")]
    Hdfs,
    [EnumMember(Value = "Hive"), JsonStringEnumMemberName("Hive")]
    Hive,
    [EnumMember(Value = "Hubspot"), JsonStringEnumMemberName("Hubspot")]
    Hubspot,
    [EnumMember(Value = "Impala"), JsonStringEnumMemberName("Impala")]
    Impala,
    [EnumMember(Value = "Informix"), JsonStringEnumMemberName("Informix")]
    Informix,
    [EnumMember(Value = "Jira"), JsonStringEnumMemberName("Jira")]
    Jira,
    [EnumMember(Value = "Magento"), JsonStringEnumMemberName("Magento")]
    Magento,
    [EnumMember(Value = "MariaDb"), JsonStringEnumMemberName("MariaDb")]
    MariaDb,
    [EnumMember(Value = "Marketo"), JsonStringEnumMemberName("Marketo")]
    Marketo,
    [EnumMember(Value = "MicrosoftAccess"), JsonStringEnumMemberName("MicrosoftAccess")]
    MicrosoftAccess,
    [EnumMember(Value = "MongoDbAtlas"), JsonStringEnumMemberName("MongoDbAtlas")]
    MongoDbAtlas,
    [EnumMember(Value = "MongoDbV2"), JsonStringEnumMemberName("MongoDbV2")]
    MongoDbV2,
    [EnumMember(Value = "MySql"), JsonStringEnumMemberName("MySql")]
    MySql,
    [EnumMember(Value = "Netezza"), JsonStringEnumMemberName("Netezza")]
    Netezza,
    [EnumMember(Value = "ODataRest"), JsonStringEnumMemberName("ODataRest")]
    ODataRest,
    [EnumMember(Value = "Odbc"), JsonStringEnumMemberName("Odbc")]
    Odbc,
    [EnumMember(Value = "Office365"), JsonStringEnumMemberName("Office365")]
    Office365,
    [EnumMember(Value = "OpenAI"), JsonStringEnumMemberName("OpenAI")]
    OpenAI,
    [EnumMember(Value = "Oracle"), JsonStringEnumMemberName("Oracle")]
    Oracle,
    [EnumMember(Value = "OracleCloudStorage"), JsonStringEnumMemberName("OracleCloudStorage")]
    OracleCloudStorage,
    [EnumMember(Value = "OracleServiceCloud"), JsonStringEnumMemberName("OracleServiceCloud")]
    OracleServiceCloud,
    [EnumMember(Value = "PayPal"), JsonStringEnumMemberName("PayPal")]
    PayPal,
    [EnumMember(Value = "Phoenix"), JsonStringEnumMemberName("Phoenix")]
    Phoenix,
    [EnumMember(Value = "PostgreSql"), JsonStringEnumMemberName("PostgreSql")]
    PostgreSql,
    [EnumMember(Value = "Presto"), JsonStringEnumMemberName("Presto")]
    Presto,
    [EnumMember(Value = "PythonFeed"), JsonStringEnumMemberName("PythonFeed")]
    PythonFeed,
    [EnumMember(Value = "QuickBooks"), JsonStringEnumMemberName("QuickBooks")]
    QuickBooks,
    [EnumMember(Value = "Redis"), JsonStringEnumMemberName("Redis")]
    Redis,
    [EnumMember(Value = "Responsys"), JsonStringEnumMemberName("Responsys")]
    Responsys,
    [EnumMember(Value = "S3"), JsonStringEnumMemberName("S3")]
    S3,
    [EnumMember(Value = "Salesforce"), JsonStringEnumMemberName("Salesforce")]
    Salesforce,
    [EnumMember(Value = "SalesforceMarketingCloud"), JsonStringEnumMemberName("SalesforceMarketingCloud")]
    SalesforceMarketingCloud,
    [EnumMember(Value = "SalesforceServiceCloud"), JsonStringEnumMemberName("SalesforceServiceCloud")]
    SalesforceServiceCloud,
    [EnumMember(Value = "SapBw"), JsonStringEnumMemberName("SapBw")]
    SapBw,
    [EnumMember(Value = "SapCloudForCustomer"), JsonStringEnumMemberName("SapCloudForCustomer")]
    SapCloudForCustomer,
    [EnumMember(Value = "SapEcc"), JsonStringEnumMemberName("SapEcc")]
    SapEcc,
    [EnumMember(Value = "SapHana"), JsonStringEnumMemberName("SapHana")]
    SapHana,
    [EnumMember(Value = "SapOpenHub"), JsonStringEnumMemberName("SapOpenHub")]
    SapOpenHub,
    [EnumMember(Value = "SapTable"), JsonStringEnumMemberName("SapTable")]
    SapTable,
    [EnumMember(Value = "Serp"), JsonStringEnumMemberName("Serp")]
    Serp,
    [EnumMember(Value = "Serverless"), JsonStringEnumMemberName("Serverless")]
    Serverless,
    [EnumMember(Value = "ServiceNow"), JsonStringEnumMemberName("ServiceNow")]
    ServiceNow,
    [EnumMember(Value = "Sftp"), JsonStringEnumMemberName("Sftp")]
    Sftp,
    [EnumMember(Value = "SharePointOnlineList"), JsonStringEnumMemberName("SharePointOnlineList")]
    SharePointOnlineList,
    [EnumMember(Value = "Shopify"), JsonStringEnumMemberName("Shopify")]
    Shopify,
    [EnumMember(Value = "Snowflake"), JsonStringEnumMemberName("Snowflake")]
    Snowflake,
    [EnumMember(Value = "Spark"), JsonStringEnumMemberName("Spark")]
    Spark,
    [EnumMember(Value = "SqlServer"), JsonStringEnumMemberName("SqlServer")]
    SqlServer,
    [EnumMember(Value = "Square"), JsonStringEnumMemberName("Square")]
    Square,
    [EnumMember(Value = "Sybase"), JsonStringEnumMemberName("Sybase")]
    Sybase,
    [EnumMember(Value = "Teradata"), JsonStringEnumMemberName("Teradata")]
    Teradata,
    [EnumMember(Value = "Vertica"), JsonStringEnumMemberName("Vertica")]
    Vertica,
    [EnumMember(Value = "WebTable"), JsonStringEnumMemberName("WebTable")]
    WebTable,
    [EnumMember(Value = "Xero"), JsonStringEnumMemberName("Xero")]
    Xero,
    [EnumMember(Value = "Zoho"), JsonStringEnumMemberName("Zoho")]
    Zoho
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordCredentialsPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SecurityToken: Optional, required by connections like SalesForce for extra security in addition to UsernamePassword</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordCredentialsSecurityToken
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordCredentials
{
    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("password")]
    public V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordCredentialsPassword? Password { get; set; }

    /// <summary>SecurityToken: Optional, required by connections like SalesForce for extra security in addition to UsernamePassword</summary>
    [JsonPropertyName("securityToken")]
    public V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordCredentialsSecurityToken? SecurityToken { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>ValueFormat: format for the workspace connection value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordValueFormatEnum>))]
public enum V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordValueFormatEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>UsernamePassword: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecPropertiesUsernamePassword
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public required V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordAuthTypeEnum AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordCategoryEnum? Category { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesUsernamePasswordValueFormatEnum? ValueFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpecProperties
{
    /// <summary>AAD: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("aad")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAad? Aad { get; set; }

    /// <summary>AccessKey: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("accessKey")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAccessKey? AccessKey { get; set; }

    /// <summary>AccountKey: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("accountKey")]
    public V1api20240401WorkspacesConnectionSpecPropertiesAccountKey? AccountKey { get; set; }

    /// <summary>ApiKey: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("apiKey")]
    public V1api20240401WorkspacesConnectionSpecPropertiesApiKey? ApiKey { get; set; }

    /// <summary>CustomKeys: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("customKeys")]
    public V1api20240401WorkspacesConnectionSpecPropertiesCustomKeys? CustomKeys { get; set; }

    /// <summary>ManagedIdentity: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20240401WorkspacesConnectionSpecPropertiesManagedIdentity? ManagedIdentity { get; set; }

    /// <summary>None: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("none")]
    public V1api20240401WorkspacesConnectionSpecPropertiesNone? None { get; set; }

    /// <summary>OAuth2: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("oAuth2")]
    public V1api20240401WorkspacesConnectionSpecPropertiesOAuth2? OAuth2 { get; set; }

    /// <summary>PAT: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("pat")]
    public V1api20240401WorkspacesConnectionSpecPropertiesPat? Pat { get; set; }

    /// <summary>SAS: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sas")]
    public V1api20240401WorkspacesConnectionSpecPropertiesSas? Sas { get; set; }

    /// <summary>ServicePrincipal: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("servicePrincipal")]
    public V1api20240401WorkspacesConnectionSpecPropertiesServicePrincipal? ServicePrincipal { get; set; }

    /// <summary>UsernamePassword: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("usernamePassword")]
    public V1api20240401WorkspacesConnectionSpecPropertiesUsernamePassword? UsernamePassword { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240401WorkspacesConnectionSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a machinelearningservices.azure.com/Workspace resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240401WorkspacesConnectionSpecOwner Owner { get; set; }

    [JsonPropertyName("properties")]
    public required V1api20240401WorkspacesConnectionSpecProperties Properties { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>AAD: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesAad
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Group: Group based on connection category</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesAccessKeyCredentials
{
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }
}

/// <summary>AccessKey: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesAccessKey
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionStatusPropertiesAccessKeyCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Group: Group based on connection category</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesAccountKeyCredentials
{
}

/// <summary>AccountKey: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesAccountKey
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionStatusPropertiesAccountKeyCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Group: Group based on connection category</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Credentials: Api key object for workspace connection credential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesApiKeyCredentials
{
}

/// <summary>ApiKey: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesApiKey
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>Credentials: Api key object for workspace connection credential.</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionStatusPropertiesApiKeyCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Group: Group based on connection category</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>Credentials: Custom Keys credential object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesCustomKeysCredentials
{
    [JsonPropertyName("keys")]
    public IDictionary<string, string>? Keys { get; set; }
}

/// <summary>CustomKeys: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesCustomKeys
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>Credentials: Custom Keys credential object</summary>
    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionStatusPropertiesCustomKeysCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Group: Group based on connection category</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesManagedIdentityCredentials
{
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>ManagedIdentity: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesManagedIdentity
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionStatusPropertiesManagedIdentityCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Group: Group based on connection category</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>None: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesNone
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Group: Group based on connection category</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

/// <summary>
/// Credentials: ClientId and ClientSecret are required. Other properties are optional
/// depending on each OAuth2 provider&apos;s  implementation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesOAuth2Credentials
{
    /// <summary>AuthUrl: Required by Concur connection category</summary>
    [JsonPropertyName("authUrl")]
    public string? AuthUrl { get; set; }

    /// <summary>ClientId: Client id in the format of UUID</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>TenantId: Required by QuickBooks and Xero connection categories</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Username: Concur, ServiceNow auth server AccessToken grant type is &apos;Password&apos;
    /// which requires UsernamePassword
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>OAuth2: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesOAuth2
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    /// <summary>
    /// Credentials: ClientId and ClientSecret are required. Other properties are optional
    /// depending on each OAuth2 provider&apos;s  implementation.
    /// </summary>
    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionStatusPropertiesOAuth2Credentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Group: Group based on connection category</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesPatCredentials
{
}

/// <summary>PAT: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesPat
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionStatusPropertiesPatCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Group: Group based on connection category</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesSasCredentials
{
}

/// <summary>SAS: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesSas
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionStatusPropertiesSasCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Group: Group based on connection category</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesServicePrincipalCredentials
{
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>ServicePrincipal: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesServicePrincipal
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionStatusPropertiesServicePrincipalCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Group: Group based on connection category</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesUsernamePasswordCredentials
{
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>UsernamePassword: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusPropertiesUsernamePassword
{
    /// <summary>AuthType: Authentication type of the connection target</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Category: Category of the connection</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("createdByWorkspaceArmId")]
    public string? CreatedByWorkspaceArmId { get; set; }

    [JsonPropertyName("credentials")]
    public V1api20240401WorkspacesConnectionStatusPropertiesUsernamePasswordCredentials? Credentials { get; set; }

    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Group: Group based on connection category</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("isSharedToAll")]
    public bool? IsSharedToAll { get; set; }

    /// <summary>Metadata: Store user metadata for this connection</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("sharedUserList")]
    public IList<string>? SharedUserList { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Value: Value details of the workspace connection.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFormat: format for the workspace connection value</summary>
    [JsonPropertyName("valueFormat")]
    public string? ValueFormat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusProperties
{
    /// <summary>AAD: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("aad")]
    public V1api20240401WorkspacesConnectionStatusPropertiesAad? Aad { get; set; }

    /// <summary>AccessKey: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("accessKey")]
    public V1api20240401WorkspacesConnectionStatusPropertiesAccessKey? AccessKey { get; set; }

    /// <summary>AccountKey: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("accountKey")]
    public V1api20240401WorkspacesConnectionStatusPropertiesAccountKey? AccountKey { get; set; }

    /// <summary>ApiKey: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("apiKey")]
    public V1api20240401WorkspacesConnectionStatusPropertiesApiKey? ApiKey { get; set; }

    /// <summary>CustomKeys: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("customKeys")]
    public V1api20240401WorkspacesConnectionStatusPropertiesCustomKeys? CustomKeys { get; set; }

    /// <summary>ManagedIdentity: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20240401WorkspacesConnectionStatusPropertiesManagedIdentity? ManagedIdentity { get; set; }

    /// <summary>None: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("none")]
    public V1api20240401WorkspacesConnectionStatusPropertiesNone? None { get; set; }

    /// <summary>OAuth2: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("oAuth2")]
    public V1api20240401WorkspacesConnectionStatusPropertiesOAuth2? OAuth2 { get; set; }

    /// <summary>PAT: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("pat")]
    public V1api20240401WorkspacesConnectionStatusPropertiesPat? Pat { get; set; }

    /// <summary>SAS: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sas")]
    public V1api20240401WorkspacesConnectionStatusPropertiesSas? Sas { get; set; }

    /// <summary>ServicePrincipal: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("servicePrincipal")]
    public V1api20240401WorkspacesConnectionStatusPropertiesServicePrincipal? ServicePrincipal { get; set; }

    /// <summary>UsernamePassword: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("usernamePassword")]
    public V1api20240401WorkspacesConnectionStatusPropertiesUsernamePassword? UsernamePassword { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesConnectionStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240401WorkspacesConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesConnectionStatusProperties? Properties { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240401WorkspacesConnectionStatusSystemData? SystemData { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/workspaceRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401WorkspacesConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240401WorkspacesConnectionSpec?>, IStatus<V1api20240401WorkspacesConnectionStatus?>
{
    public const string KubeApiVersion = "v1api20240401";
    public const string KubeKind = "WorkspacesConnection";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspacesconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.com/v1api20240401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspacesConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240401WorkspacesConnectionSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20240401WorkspacesConnectionStatus? Status { get; set; }
}