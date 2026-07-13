#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.databricks.m.upbound.io;
/// <summary>Pipeline is the Schema for the Pipelines API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PipelineList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Pipeline>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PipelineList";
    public const string KubeGroup = "compute.databricks.m.upbound.io";
    public const string KubePluralName = "pipelines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.databricks.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PipelineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Pipeline objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Pipeline> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1PipelineSpecForProviderClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1PipelineSpecForProviderClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1PipelineSpecForProviderClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1PipelineSpecForProviderClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1PipelineSpecForProviderClusterInitScriptsDbfs? Dbfs { get; set; }

    [JsonPropertyName("file")]
    public V1beta1PipelineSpecForProviderClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1PipelineSpecForProviderClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1PipelineSpecForProviderClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1PipelineSpecForProviderClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1PipelineSpecForProviderClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1PipelineSpecForProviderClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1PipelineSpecForProviderClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1PipelineSpecForProviderClusterAzureAttributes? AzureAttributes { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1PipelineSpecForProviderClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1PipelineSpecForProviderClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1PipelineSpecForProviderClusterInitScripts>? InitScripts { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }
}

/// <summary>Deployment type of this pipeline. Supports following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderDeployment
{
    /// <summary>The deployment method that manages the pipeline.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The path to the file containing metadata about the deployment.</summary>
    [JsonPropertyName("metadataFilePath")]
    public string? MetadataFilePath { get; set; }
}

/// <summary>Filters on which Pipeline packages to include in the deployed graph.  This block consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderFilters
{
    /// <summary>Paths to exclude.</summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>Paths to include.</summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

/// <summary>The definition of a gateway pipeline to support CDC. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderGatewayDefinition
{
    /// <summary>Immutable. The Unity Catalog connection this gateway pipeline uses to communicate with the source.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Immutable. The Unity Catalog connection this ingestion pipeline uses to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Required, Immutable. The name of the catalog for the gateway pipeline&apos;s storage location.</summary>
    [JsonPropertyName("gatewayStorageCatalog")]
    public string? GatewayStorageCatalog { get; set; }

    /// <summary>Required. The Unity Catalog-compatible naming for the gateway storage location. This is the destination to use for the data that is extracted by the gateway. Delta Live Tables system will automatically create the storage location under the catalog and schema.</summary>
    [JsonPropertyName("gatewayStorageName")]
    public string? GatewayStorageName { get; set; }

    /// <summary>Required, Immutable. The name of the schema for the gateway pipelines&apos;s storage location.</summary>
    [JsonPropertyName("gatewayStorageSchema")]
    public string? GatewayStorageSchema { get; set; }
}

/// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderIngestionDefinitionObjectsReportTableConfiguration
{
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderIngestionDefinitionObjectsReport
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    [JsonPropertyName("destinationTable")]
    public string? DestinationTable { get; set; }

    /// <summary>URL of the DLT pipeline on the given workspace.</summary>
    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public V1beta1PipelineSpecForProviderIngestionDefinitionObjectsReportTableConfiguration? TableConfiguration { get; set; }
}

/// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderIngestionDefinitionObjectsSchemaTableConfiguration
{
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderIngestionDefinitionObjectsSchema
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("sourceCatalog")]
    public string? SourceCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("sourceSchema")]
    public string? SourceSchema { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public V1beta1PipelineSpecForProviderIngestionDefinitionObjectsSchemaTableConfiguration? TableConfiguration { get; set; }
}

/// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderIngestionDefinitionObjectsTableTableConfiguration
{
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderIngestionDefinitionObjectsTable
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    [JsonPropertyName("destinationTable")]
    public string? DestinationTable { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("sourceCatalog")]
    public string? SourceCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("sourceSchema")]
    public string? SourceSchema { get; set; }

    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public V1beta1PipelineSpecForProviderIngestionDefinitionObjectsTableTableConfiguration? TableConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderIngestionDefinitionObjects
{
    [JsonPropertyName("report")]
    public V1beta1PipelineSpecForProviderIngestionDefinitionObjectsReport? Report { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public V1beta1PipelineSpecForProviderIngestionDefinitionObjectsSchema? Schema { get; set; }

    [JsonPropertyName("table")]
    public V1beta1PipelineSpecForProviderIngestionDefinitionObjectsTable? Table { get; set; }
}

/// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderIngestionDefinitionTableConfiguration
{
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderIngestionDefinition
{
    /// <summary>Immutable. The Unity Catalog connection this ingestion pipeline uses to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Immutable. Identifier for the ingestion gateway used by this ingestion pipeline to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("ingestionGatewayId")]
    public string? IngestionGatewayId { get; set; }

    /// <summary>Required. Settings specifying tables to replicate and the destination for the replicated tables.</summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1PipelineSpecForProviderIngestionDefinitionObjects>? Objects { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public V1beta1PipelineSpecForProviderIngestionDefinitionTableConfiguration? TableConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderLatestUpdates
{
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("updateId")]
    public string? UpdateId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderLibraryFile
{
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderLibraryMaven
{
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecForProviderLibraryNotebookPathRefPolicyResolutionEnum>))]
public enum V1beta1PipelineSpecForProviderLibraryNotebookPathRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecForProviderLibraryNotebookPathRefPolicyResolveEnum>))]
public enum V1beta1PipelineSpecForProviderLibraryNotebookPathRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderLibraryNotebookPathRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PipelineSpecForProviderLibraryNotebookPathRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PipelineSpecForProviderLibraryNotebookPathRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Notebook in workspace to populate path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderLibraryNotebookPathRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipelineSpecForProviderLibraryNotebookPathRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecForProviderLibraryNotebookPathSelectorPolicyResolutionEnum>))]
public enum V1beta1PipelineSpecForProviderLibraryNotebookPathSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecForProviderLibraryNotebookPathSelectorPolicyResolveEnum>))]
public enum V1beta1PipelineSpecForProviderLibraryNotebookPathSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderLibraryNotebookPathSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PipelineSpecForProviderLibraryNotebookPathSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PipelineSpecForProviderLibraryNotebookPathSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Notebook in workspace to populate path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderLibraryNotebookPathSelector
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
    public V1beta1PipelineSpecForProviderLibraryNotebookPathSelectorPolicy? Policy { get; set; }
}

/// <summary>&amp; file types are supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderLibraryNotebook
{
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Reference to a Notebook in workspace to populate path.</summary>
    [JsonPropertyName("pathRef")]
    public V1beta1PipelineSpecForProviderLibraryNotebookPathRef? PathRef { get; set; }

    /// <summary>Selector for a Notebook in workspace to populate path.</summary>
    [JsonPropertyName("pathSelector")]
    public V1beta1PipelineSpecForProviderLibraryNotebookPathSelector? PathSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderLibrary
{
    [JsonPropertyName("file")]
    public V1beta1PipelineSpecForProviderLibraryFile? File { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1PipelineSpecForProviderLibraryMaven? Maven { get; set; }

    /// <summary>&amp; file types are supported.</summary>
    [JsonPropertyName("notebook")]
    public V1beta1PipelineSpecForProviderLibraryNotebook? Notebook { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderNotification
{
    /// <summary>empty list of alert types. Right now following alert types are supported, consult documentation for actual list</summary>
    [JsonPropertyName("alerts")]
    public IList<string>? Alerts { get; set; }

    /// <summary>empty list of emails to notify.</summary>
    [JsonPropertyName("emailRecipients")]
    public IList<string>? EmailRecipients { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderRestartWindow
{
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    [JsonPropertyName("startHour")]
    public double? StartHour { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("timeZoneId")]
    public string? TimeZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderTriggerCron
{
    [JsonPropertyName("quartzCronSchedule")]
    public string? QuartzCronSchedule { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderTriggerManual
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderTrigger
{
    [JsonPropertyName("cron")]
    public V1beta1PipelineSpecForProviderTriggerCron? Cron { get; set; }

    [JsonPropertyName("manual")]
    public V1beta1PipelineSpecForProviderTriggerManual? Manual { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProvider
{
    /// <summary>Optional boolean flag. If false, deployment will fail if name conflicts with that of another pipeline. default is false.</summary>
    [JsonPropertyName("allowDuplicateNames")]
    public bool? AllowDuplicateNames { get; set; }

    /// <summary>optional string specifying ID of the budget policy for this DLT pipeline.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    /// <summary>optional name of the release channel for Spark version used by DLT pipeline.  Supported values are: CURRENT (default) and PREVIEW.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Clusters to run the pipeline. If none is specified, pipelines will automatically select a default cluster configuration for the pipeline. Please note that DLT pipeline clusters are supporting only subset of attributes as described in   Also, note that autoscale block is extended with the mode parameter that controls the autoscaling algorithm (possible values are ENHANCED for new, enhanced autoscaling algorithm, or LEGACY for old algorithm).</summary>
    [JsonPropertyName("cluster")]
    public IList<V1beta1PipelineSpecForProviderCluster>? Cluster { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>An optional list of values to apply to the entire pipeline. Elements must be formatted as key:value pairs.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A flag indicating whether to run the pipeline continuously. The default value is false.</summary>
    [JsonPropertyName("continuous")]
    public bool? Continuous { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("creatorUserName")]
    public string? CreatorUserName { get; set; }

    /// <summary>Deployment type of this pipeline. Supports following attributes:</summary>
    [JsonPropertyName("deployment")]
    public V1beta1PipelineSpecForProviderDeployment? Deployment { get; set; }

    /// <summary>A flag indicating whether to run the pipeline in development mode. The default value is false.</summary>
    [JsonPropertyName("development")]
    public bool? Development { get; set; }

    /// <summary>optional name of the product edition. Supported values are: CORE, PRO, ADVANCED (default).  Not required when serverless is set to true.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    [JsonPropertyName("expectedLastModified")]
    public double? ExpectedLastModified { get; set; }

    /// <summary>Filters on which Pipeline packages to include in the deployed graph.  This block consists of following attributes:</summary>
    [JsonPropertyName("filters")]
    public V1beta1PipelineSpecForProviderFilters? Filters { get; set; }

    /// <summary>The definition of a gateway pipeline to support CDC. Consists of following attributes:</summary>
    [JsonPropertyName("gatewayDefinition")]
    public V1beta1PipelineSpecForProviderGatewayDefinition? GatewayDefinition { get; set; }

    [JsonPropertyName("health")]
    public string? Health { get; set; }

    [JsonPropertyName("ingestionDefinition")]
    public V1beta1PipelineSpecForProviderIngestionDefinition? IngestionDefinition { get; set; }

    [JsonPropertyName("lastModified")]
    public double? LastModified { get; set; }

    [JsonPropertyName("latestUpdates")]
    public IList<V1beta1PipelineSpecForProviderLatestUpdates>? LatestUpdates { get; set; }

    /// <summary>Specifies pipeline code and required artifacts. Syntax resembles library configuration block with the addition of a special notebook &amp; file library types that should have the path attribute. Right now only the</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1PipelineSpecForProviderLibrary>? Library { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("notification")]
    public IList<V1beta1PipelineSpecForProviderNotification>? Notification { get; set; }

    /// <summary>A flag indicating whether to use Photon engine. The default value is false.</summary>
    [JsonPropertyName("photon")]
    public bool? Photon { get; set; }

    [JsonPropertyName("restartWindow")]
    public V1beta1PipelineSpecForProviderRestartWindow? RestartWindow { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>An optional flag indicating if serverless compute should be used for this DLT pipeline.  Requires catalog to be set, as it could be used only with Unity Catalog.</summary>
    [JsonPropertyName("serverless")]
    public bool? Serverless { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>A location on DBFS or cloud storage where output data and metadata required for pipeline execution are stored. By default, tables are stored in a subdirectory of this location. Change of this parameter forces recreation of the pipeline. (Conflicts with catalog).</summary>
    [JsonPropertyName("storage")]
    public string? Storage { get; set; }

    /// <summary>The name of a database (in either the Hive metastore or in a UC catalog) for persisting pipeline output data. Configuring the target setting allows you to view and query the pipeline output data from the Databricks UI.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    [JsonPropertyName("trigger")]
    public V1beta1PipelineSpecForProviderTrigger? Trigger { get; set; }

    /// <summary>URL of the DLT pipeline on the given workspace.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1PipelineSpecInitProviderClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1PipelineSpecInitProviderClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1PipelineSpecInitProviderClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1PipelineSpecInitProviderClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1PipelineSpecInitProviderClusterInitScriptsDbfs? Dbfs { get; set; }

    [JsonPropertyName("file")]
    public V1beta1PipelineSpecInitProviderClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1PipelineSpecInitProviderClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1PipelineSpecInitProviderClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1PipelineSpecInitProviderClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1PipelineSpecInitProviderClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1PipelineSpecInitProviderClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1PipelineSpecInitProviderClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1PipelineSpecInitProviderClusterAzureAttributes? AzureAttributes { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1PipelineSpecInitProviderClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1PipelineSpecInitProviderClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1PipelineSpecInitProviderClusterInitScripts>? InitScripts { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }
}

/// <summary>Deployment type of this pipeline. Supports following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderDeployment
{
    /// <summary>The deployment method that manages the pipeline.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The path to the file containing metadata about the deployment.</summary>
    [JsonPropertyName("metadataFilePath")]
    public string? MetadataFilePath { get; set; }
}

/// <summary>Filters on which Pipeline packages to include in the deployed graph.  This block consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderFilters
{
    /// <summary>Paths to exclude.</summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>Paths to include.</summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

/// <summary>The definition of a gateway pipeline to support CDC. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderGatewayDefinition
{
    /// <summary>Immutable. The Unity Catalog connection this gateway pipeline uses to communicate with the source.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Immutable. The Unity Catalog connection this ingestion pipeline uses to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Required, Immutable. The name of the catalog for the gateway pipeline&apos;s storage location.</summary>
    [JsonPropertyName("gatewayStorageCatalog")]
    public string? GatewayStorageCatalog { get; set; }

    /// <summary>Required. The Unity Catalog-compatible naming for the gateway storage location. This is the destination to use for the data that is extracted by the gateway. Delta Live Tables system will automatically create the storage location under the catalog and schema.</summary>
    [JsonPropertyName("gatewayStorageName")]
    public string? GatewayStorageName { get; set; }

    /// <summary>Required, Immutable. The name of the schema for the gateway pipelines&apos;s storage location.</summary>
    [JsonPropertyName("gatewayStorageSchema")]
    public string? GatewayStorageSchema { get; set; }
}

/// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderIngestionDefinitionObjectsReportTableConfiguration
{
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderIngestionDefinitionObjectsReport
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    [JsonPropertyName("destinationTable")]
    public string? DestinationTable { get; set; }

    /// <summary>URL of the DLT pipeline on the given workspace.</summary>
    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public V1beta1PipelineSpecInitProviderIngestionDefinitionObjectsReportTableConfiguration? TableConfiguration { get; set; }
}

/// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderIngestionDefinitionObjectsSchemaTableConfiguration
{
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderIngestionDefinitionObjectsSchema
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("sourceCatalog")]
    public string? SourceCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("sourceSchema")]
    public string? SourceSchema { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public V1beta1PipelineSpecInitProviderIngestionDefinitionObjectsSchemaTableConfiguration? TableConfiguration { get; set; }
}

/// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderIngestionDefinitionObjectsTableTableConfiguration
{
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderIngestionDefinitionObjectsTable
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    [JsonPropertyName("destinationTable")]
    public string? DestinationTable { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("sourceCatalog")]
    public string? SourceCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("sourceSchema")]
    public string? SourceSchema { get; set; }

    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public V1beta1PipelineSpecInitProviderIngestionDefinitionObjectsTableTableConfiguration? TableConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderIngestionDefinitionObjects
{
    [JsonPropertyName("report")]
    public V1beta1PipelineSpecInitProviderIngestionDefinitionObjectsReport? Report { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public V1beta1PipelineSpecInitProviderIngestionDefinitionObjectsSchema? Schema { get; set; }

    [JsonPropertyName("table")]
    public V1beta1PipelineSpecInitProviderIngestionDefinitionObjectsTable? Table { get; set; }
}

/// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderIngestionDefinitionTableConfiguration
{
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderIngestionDefinition
{
    /// <summary>Immutable. The Unity Catalog connection this ingestion pipeline uses to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Immutable. Identifier for the ingestion gateway used by this ingestion pipeline to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("ingestionGatewayId")]
    public string? IngestionGatewayId { get; set; }

    /// <summary>Required. Settings specifying tables to replicate and the destination for the replicated tables.</summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1PipelineSpecInitProviderIngestionDefinitionObjects>? Objects { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public V1beta1PipelineSpecInitProviderIngestionDefinitionTableConfiguration? TableConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderLatestUpdates
{
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("updateId")]
    public string? UpdateId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderLibraryFile
{
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderLibraryMaven
{
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecInitProviderLibraryNotebookPathRefPolicyResolutionEnum>))]
public enum V1beta1PipelineSpecInitProviderLibraryNotebookPathRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecInitProviderLibraryNotebookPathRefPolicyResolveEnum>))]
public enum V1beta1PipelineSpecInitProviderLibraryNotebookPathRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderLibraryNotebookPathRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PipelineSpecInitProviderLibraryNotebookPathRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PipelineSpecInitProviderLibraryNotebookPathRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Notebook in workspace to populate path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderLibraryNotebookPathRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipelineSpecInitProviderLibraryNotebookPathRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecInitProviderLibraryNotebookPathSelectorPolicyResolutionEnum>))]
public enum V1beta1PipelineSpecInitProviderLibraryNotebookPathSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecInitProviderLibraryNotebookPathSelectorPolicyResolveEnum>))]
public enum V1beta1PipelineSpecInitProviderLibraryNotebookPathSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderLibraryNotebookPathSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PipelineSpecInitProviderLibraryNotebookPathSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PipelineSpecInitProviderLibraryNotebookPathSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Notebook in workspace to populate path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderLibraryNotebookPathSelector
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
    public V1beta1PipelineSpecInitProviderLibraryNotebookPathSelectorPolicy? Policy { get; set; }
}

/// <summary>&amp; file types are supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderLibraryNotebook
{
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Reference to a Notebook in workspace to populate path.</summary>
    [JsonPropertyName("pathRef")]
    public V1beta1PipelineSpecInitProviderLibraryNotebookPathRef? PathRef { get; set; }

    /// <summary>Selector for a Notebook in workspace to populate path.</summary>
    [JsonPropertyName("pathSelector")]
    public V1beta1PipelineSpecInitProviderLibraryNotebookPathSelector? PathSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderLibrary
{
    [JsonPropertyName("file")]
    public V1beta1PipelineSpecInitProviderLibraryFile? File { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1PipelineSpecInitProviderLibraryMaven? Maven { get; set; }

    /// <summary>&amp; file types are supported.</summary>
    [JsonPropertyName("notebook")]
    public V1beta1PipelineSpecInitProviderLibraryNotebook? Notebook { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderNotification
{
    /// <summary>empty list of alert types. Right now following alert types are supported, consult documentation for actual list</summary>
    [JsonPropertyName("alerts")]
    public IList<string>? Alerts { get; set; }

    /// <summary>empty list of emails to notify.</summary>
    [JsonPropertyName("emailRecipients")]
    public IList<string>? EmailRecipients { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderRestartWindow
{
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    [JsonPropertyName("startHour")]
    public double? StartHour { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("timeZoneId")]
    public string? TimeZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderTriggerCron
{
    [JsonPropertyName("quartzCronSchedule")]
    public string? QuartzCronSchedule { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderTriggerManual
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderTrigger
{
    [JsonPropertyName("cron")]
    public V1beta1PipelineSpecInitProviderTriggerCron? Cron { get; set; }

    [JsonPropertyName("manual")]
    public V1beta1PipelineSpecInitProviderTriggerManual? Manual { get; set; }
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
public partial class V1beta1PipelineSpecInitProvider
{
    /// <summary>Optional boolean flag. If false, deployment will fail if name conflicts with that of another pipeline. default is false.</summary>
    [JsonPropertyName("allowDuplicateNames")]
    public bool? AllowDuplicateNames { get; set; }

    /// <summary>optional string specifying ID of the budget policy for this DLT pipeline.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    /// <summary>optional name of the release channel for Spark version used by DLT pipeline.  Supported values are: CURRENT (default) and PREVIEW.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Clusters to run the pipeline. If none is specified, pipelines will automatically select a default cluster configuration for the pipeline. Please note that DLT pipeline clusters are supporting only subset of attributes as described in   Also, note that autoscale block is extended with the mode parameter that controls the autoscaling algorithm (possible values are ENHANCED for new, enhanced autoscaling algorithm, or LEGACY for old algorithm).</summary>
    [JsonPropertyName("cluster")]
    public IList<V1beta1PipelineSpecInitProviderCluster>? Cluster { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>An optional list of values to apply to the entire pipeline. Elements must be formatted as key:value pairs.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A flag indicating whether to run the pipeline continuously. The default value is false.</summary>
    [JsonPropertyName("continuous")]
    public bool? Continuous { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("creatorUserName")]
    public string? CreatorUserName { get; set; }

    /// <summary>Deployment type of this pipeline. Supports following attributes:</summary>
    [JsonPropertyName("deployment")]
    public V1beta1PipelineSpecInitProviderDeployment? Deployment { get; set; }

    /// <summary>A flag indicating whether to run the pipeline in development mode. The default value is false.</summary>
    [JsonPropertyName("development")]
    public bool? Development { get; set; }

    /// <summary>optional name of the product edition. Supported values are: CORE, PRO, ADVANCED (default).  Not required when serverless is set to true.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    [JsonPropertyName("expectedLastModified")]
    public double? ExpectedLastModified { get; set; }

    /// <summary>Filters on which Pipeline packages to include in the deployed graph.  This block consists of following attributes:</summary>
    [JsonPropertyName("filters")]
    public V1beta1PipelineSpecInitProviderFilters? Filters { get; set; }

    /// <summary>The definition of a gateway pipeline to support CDC. Consists of following attributes:</summary>
    [JsonPropertyName("gatewayDefinition")]
    public V1beta1PipelineSpecInitProviderGatewayDefinition? GatewayDefinition { get; set; }

    [JsonPropertyName("health")]
    public string? Health { get; set; }

    [JsonPropertyName("ingestionDefinition")]
    public V1beta1PipelineSpecInitProviderIngestionDefinition? IngestionDefinition { get; set; }

    [JsonPropertyName("lastModified")]
    public double? LastModified { get; set; }

    [JsonPropertyName("latestUpdates")]
    public IList<V1beta1PipelineSpecInitProviderLatestUpdates>? LatestUpdates { get; set; }

    /// <summary>Specifies pipeline code and required artifacts. Syntax resembles library configuration block with the addition of a special notebook &amp; file library types that should have the path attribute. Right now only the</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1PipelineSpecInitProviderLibrary>? Library { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("notification")]
    public IList<V1beta1PipelineSpecInitProviderNotification>? Notification { get; set; }

    /// <summary>A flag indicating whether to use Photon engine. The default value is false.</summary>
    [JsonPropertyName("photon")]
    public bool? Photon { get; set; }

    [JsonPropertyName("restartWindow")]
    public V1beta1PipelineSpecInitProviderRestartWindow? RestartWindow { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>An optional flag indicating if serverless compute should be used for this DLT pipeline.  Requires catalog to be set, as it could be used only with Unity Catalog.</summary>
    [JsonPropertyName("serverless")]
    public bool? Serverless { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>A location on DBFS or cloud storage where output data and metadata required for pipeline execution are stored. By default, tables are stored in a subdirectory of this location. Change of this parameter forces recreation of the pipeline. (Conflicts with catalog).</summary>
    [JsonPropertyName("storage")]
    public string? Storage { get; set; }

    /// <summary>The name of a database (in either the Hive metastore or in a UC catalog) for persisting pipeline output data. Configuring the target setting allows you to view and query the pipeline output data from the Databricks UI.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    [JsonPropertyName("trigger")]
    public V1beta1PipelineSpecInitProviderTrigger? Trigger { get; set; }

    /// <summary>URL of the DLT pipeline on the given workspace.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecManagementPoliciesEnum>))]
public enum V1beta1PipelineSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>PipelineSpec defines the desired state of Pipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1PipelineSpecForProvider ForProvider { get; set; }

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
    public V1beta1PipelineSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PipelineSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PipelineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PipelineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1PipelineStatusAtProviderClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1PipelineStatusAtProviderClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1PipelineStatusAtProviderClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1PipelineStatusAtProviderClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1PipelineStatusAtProviderClusterInitScriptsDbfs? Dbfs { get; set; }

    [JsonPropertyName("file")]
    public V1beta1PipelineStatusAtProviderClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1PipelineStatusAtProviderClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1PipelineStatusAtProviderClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1PipelineStatusAtProviderClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1PipelineStatusAtProviderClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1PipelineStatusAtProviderClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1PipelineStatusAtProviderClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1PipelineStatusAtProviderClusterAzureAttributes? AzureAttributes { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1PipelineStatusAtProviderClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1PipelineStatusAtProviderClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1PipelineStatusAtProviderClusterInitScripts>? InitScripts { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }
}

/// <summary>Deployment type of this pipeline. Supports following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderDeployment
{
    /// <summary>The deployment method that manages the pipeline.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The path to the file containing metadata about the deployment.</summary>
    [JsonPropertyName("metadataFilePath")]
    public string? MetadataFilePath { get; set; }
}

/// <summary>Filters on which Pipeline packages to include in the deployed graph.  This block consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderFilters
{
    /// <summary>Paths to exclude.</summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>Paths to include.</summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

/// <summary>The definition of a gateway pipeline to support CDC. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderGatewayDefinition
{
    /// <summary>Immutable. The Unity Catalog connection this gateway pipeline uses to communicate with the source.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Immutable. The Unity Catalog connection this ingestion pipeline uses to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Required, Immutable. The name of the catalog for the gateway pipeline&apos;s storage location.</summary>
    [JsonPropertyName("gatewayStorageCatalog")]
    public string? GatewayStorageCatalog { get; set; }

    /// <summary>Required. The Unity Catalog-compatible naming for the gateway storage location. This is the destination to use for the data that is extracted by the gateway. Delta Live Tables system will automatically create the storage location under the catalog and schema.</summary>
    [JsonPropertyName("gatewayStorageName")]
    public string? GatewayStorageName { get; set; }

    /// <summary>Required, Immutable. The name of the schema for the gateway pipelines&apos;s storage location.</summary>
    [JsonPropertyName("gatewayStorageSchema")]
    public string? GatewayStorageSchema { get; set; }
}

/// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderIngestionDefinitionObjectsReportTableConfiguration
{
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderIngestionDefinitionObjectsReport
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    [JsonPropertyName("destinationTable")]
    public string? DestinationTable { get; set; }

    /// <summary>URL of the DLT pipeline on the given workspace.</summary>
    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public V1beta1PipelineStatusAtProviderIngestionDefinitionObjectsReportTableConfiguration? TableConfiguration { get; set; }
}

/// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderIngestionDefinitionObjectsSchemaTableConfiguration
{
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

/// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderIngestionDefinitionObjectsSchema
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("sourceCatalog")]
    public string? SourceCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("sourceSchema")]
    public string? SourceSchema { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public V1beta1PipelineStatusAtProviderIngestionDefinitionObjectsSchemaTableConfiguration? TableConfiguration { get; set; }
}

/// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderIngestionDefinitionObjectsTableTableConfiguration
{
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderIngestionDefinitionObjectsTable
{
    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("destinationCatalog")]
    public string? DestinationCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("destinationSchema")]
    public string? DestinationSchema { get; set; }

    [JsonPropertyName("destinationTable")]
    public string? DestinationTable { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("sourceCatalog")]
    public string? SourceCatalog { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("sourceSchema")]
    public string? SourceSchema { get; set; }

    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public V1beta1PipelineStatusAtProviderIngestionDefinitionObjectsTableTableConfiguration? TableConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderIngestionDefinitionObjects
{
    [JsonPropertyName("report")]
    public V1beta1PipelineStatusAtProviderIngestionDefinitionObjectsReport? Report { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public V1beta1PipelineStatusAtProviderIngestionDefinitionObjectsSchema? Schema { get; set; }

    [JsonPropertyName("table")]
    public V1beta1PipelineStatusAtProviderIngestionDefinitionObjectsTable? Table { get; set; }
}

/// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderIngestionDefinitionTableConfiguration
{
    [JsonPropertyName("primaryKeys")]
    public IList<string>? PrimaryKeys { get; set; }

    [JsonPropertyName("salesforceIncludeFormulaFields")]
    public bool? SalesforceIncludeFormulaFields { get; set; }

    [JsonPropertyName("scdType")]
    public string? ScdType { get; set; }

    [JsonPropertyName("sequenceBy")]
    public IList<string>? SequenceBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderIngestionDefinition
{
    /// <summary>Immutable. The Unity Catalog connection this ingestion pipeline uses to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Immutable. Identifier for the ingestion gateway used by this ingestion pipeline to communicate with the source. Specify either ingestion_gateway_id or connection_name.</summary>
    [JsonPropertyName("ingestionGatewayId")]
    public string? IngestionGatewayId { get; set; }

    /// <summary>Required. Settings specifying tables to replicate and the destination for the replicated tables.</summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1PipelineStatusAtProviderIngestionDefinitionObjects>? Objects { get; set; }

    /// <summary>Configuration settings to control the ingestion of tables. These settings are applied to all tables in the pipeline.</summary>
    [JsonPropertyName("tableConfiguration")]
    public V1beta1PipelineStatusAtProviderIngestionDefinitionTableConfiguration? TableConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderLatestUpdates
{
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("updateId")]
    public string? UpdateId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderLibraryFile
{
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderLibraryMaven
{
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary>&amp; file types are supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderLibraryNotebook
{
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderLibrary
{
    [JsonPropertyName("file")]
    public V1beta1PipelineStatusAtProviderLibraryFile? File { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1PipelineStatusAtProviderLibraryMaven? Maven { get; set; }

    /// <summary>&amp; file types are supported.</summary>
    [JsonPropertyName("notebook")]
    public V1beta1PipelineStatusAtProviderLibraryNotebook? Notebook { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderNotification
{
    /// <summary>empty list of alert types. Right now following alert types are supported, consult documentation for actual list</summary>
    [JsonPropertyName("alerts")]
    public IList<string>? Alerts { get; set; }

    /// <summary>empty list of emails to notify.</summary>
    [JsonPropertyName("emailRecipients")]
    public IList<string>? EmailRecipients { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderRestartWindow
{
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    [JsonPropertyName("startHour")]
    public double? StartHour { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("timeZoneId")]
    public string? TimeZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderTriggerCron
{
    [JsonPropertyName("quartzCronSchedule")]
    public string? QuartzCronSchedule { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderTriggerManual
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderTrigger
{
    [JsonPropertyName("cron")]
    public V1beta1PipelineStatusAtProviderTriggerCron? Cron { get; set; }

    [JsonPropertyName("manual")]
    public V1beta1PipelineStatusAtProviderTriggerManual? Manual { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProvider
{
    /// <summary>Optional boolean flag. If false, deployment will fail if name conflicts with that of another pipeline. default is false.</summary>
    [JsonPropertyName("allowDuplicateNames")]
    public bool? AllowDuplicateNames { get; set; }

    /// <summary>optional string specifying ID of the budget policy for this DLT pipeline.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The name of catalog in Unity Catalog. Change of this parameter forces recreation of the pipeline. (Conflicts with storage).</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    /// <summary>optional name of the release channel for Spark version used by DLT pipeline.  Supported values are: CURRENT (default) and PREVIEW.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Clusters to run the pipeline. If none is specified, pipelines will automatically select a default cluster configuration for the pipeline. Please note that DLT pipeline clusters are supporting only subset of attributes as described in   Also, note that autoscale block is extended with the mode parameter that controls the autoscaling algorithm (possible values are ENHANCED for new, enhanced autoscaling algorithm, or LEGACY for old algorithm).</summary>
    [JsonPropertyName("cluster")]
    public IList<V1beta1PipelineStatusAtProviderCluster>? Cluster { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>An optional list of values to apply to the entire pipeline. Elements must be formatted as key:value pairs.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A flag indicating whether to run the pipeline continuously. The default value is false.</summary>
    [JsonPropertyName("continuous")]
    public bool? Continuous { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("creatorUserName")]
    public string? CreatorUserName { get; set; }

    /// <summary>Deployment type of this pipeline. Supports following attributes:</summary>
    [JsonPropertyName("deployment")]
    public V1beta1PipelineStatusAtProviderDeployment? Deployment { get; set; }

    /// <summary>A flag indicating whether to run the pipeline in development mode. The default value is false.</summary>
    [JsonPropertyName("development")]
    public bool? Development { get; set; }

    /// <summary>optional name of the product edition. Supported values are: CORE, PRO, ADVANCED (default).  Not required when serverless is set to true.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    [JsonPropertyName("expectedLastModified")]
    public double? ExpectedLastModified { get; set; }

    /// <summary>Filters on which Pipeline packages to include in the deployed graph.  This block consists of following attributes:</summary>
    [JsonPropertyName("filters")]
    public V1beta1PipelineStatusAtProviderFilters? Filters { get; set; }

    /// <summary>The definition of a gateway pipeline to support CDC. Consists of following attributes:</summary>
    [JsonPropertyName("gatewayDefinition")]
    public V1beta1PipelineStatusAtProviderGatewayDefinition? GatewayDefinition { get; set; }

    [JsonPropertyName("health")]
    public string? Health { get; set; }

    /// <summary>Canonical unique identifier of the DLT pipeline.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("ingestionDefinition")]
    public V1beta1PipelineStatusAtProviderIngestionDefinition? IngestionDefinition { get; set; }

    [JsonPropertyName("lastModified")]
    public double? LastModified { get; set; }

    [JsonPropertyName("latestUpdates")]
    public IList<V1beta1PipelineStatusAtProviderLatestUpdates>? LatestUpdates { get; set; }

    /// <summary>Specifies pipeline code and required artifacts. Syntax resembles library configuration block with the addition of a special notebook &amp; file library types that should have the path attribute. Right now only the</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1PipelineStatusAtProviderLibrary>? Library { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("notification")]
    public IList<V1beta1PipelineStatusAtProviderNotification>? Notification { get; set; }

    /// <summary>A flag indicating whether to use Photon engine. The default value is false.</summary>
    [JsonPropertyName("photon")]
    public bool? Photon { get; set; }

    [JsonPropertyName("restartWindow")]
    public V1beta1PipelineStatusAtProviderRestartWindow? RestartWindow { get; set; }

    /// <summary>A user-friendly name for this pipeline. The name can be used to identify pipeline jobs in the UI.</summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }

    /// <summary>The default schema (database) where tables are read from or published to. The presence of this attribute implies that the pipeline is in direct publishing mode.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>An optional flag indicating if serverless compute should be used for this DLT pipeline.  Requires catalog to be set, as it could be used only with Unity Catalog.</summary>
    [JsonPropertyName("serverless")]
    public bool? Serverless { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>A location on DBFS or cloud storage where output data and metadata required for pipeline execution are stored. By default, tables are stored in a subdirectory of this location. Change of this parameter forces recreation of the pipeline. (Conflicts with catalog).</summary>
    [JsonPropertyName("storage")]
    public string? Storage { get; set; }

    /// <summary>The name of a database (in either the Hive metastore or in a UC catalog) for persisting pipeline output data. Configuring the target setting allows you to view and query the pipeline output data from the Databricks UI.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    [JsonPropertyName("trigger")]
    public V1beta1PipelineStatusAtProviderTrigger? Trigger { get; set; }

    /// <summary>URL of the DLT pipeline on the given workspace.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusConditions
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

/// <summary>PipelineStatus defines the observed state of Pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1PipelineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PipelineStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Pipeline is the Schema for the Pipelines API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Pipeline : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PipelineSpec>, IStatus<V1beta1PipelineStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Pipeline";
    public const string KubeGroup = "compute.databricks.m.upbound.io";
    public const string KubePluralName = "pipelines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.databricks.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Pipeline";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PipelineSpec defines the desired state of Pipeline</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PipelineSpec Spec { get; set; }

    /// <summary>PipelineStatus defines the observed state of Pipeline.</summary>
    [JsonPropertyName("status")]
    public V1beta1PipelineStatus? Status { get; set; }
}