#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bedrockagent.aws.upbound.io;
/// <summary>DataSource is the Schema for the DataSources API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataSourceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DataSource>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataSourceList";
    public const string KubeGroup = "bedrockagent.aws.upbound.io";
    public const string KubePluralName = "datasources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagent.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataSourceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DataSource objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DataSource> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecDeletionPolicyEnum>))]
public enum V1beta1DataSourceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters
{
    /// <summary>A list of one or more exclusion regular expression patterns to exclude certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<string>? ExclusionFilters { get; set; }

    /// <summary>List of one or more inclusion regular expression patterns to include certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<string>? InclusionFilters { get; set; }

    /// <summary>The supported object type or content type of the data source.</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter
{
    /// <summary>The configuration of specific filters applied to your data source content. Minimum of 1 filter and maximum of 25 filters.</summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters>? Filters { get; set; }
}

/// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfiguration
{
    /// <summary>The configuration of filtering certain objects or content types of the data source. See pattern_object_filter block for details.</summary>
    [JsonPropertyName("patternObjectFilter")]
    public IList<V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter>? PatternObjectFilter { get; set; }

    /// <summary>Type of storage for the data source. Valid values: S3, WEB, CONFLUENCE, SALESFORCE, SHAREPOINT, CUSTOM, REDSHIFT_METADATA, MANAGED_KNOWLEDGE_BASE_CONNECTOR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfiguration
{
    /// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
    [JsonPropertyName("filterConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfiguration? FilterConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelector
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
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfiguration
{
    /// <summary>The supported authentication type to authenticate and connect to your SharePoint site. Valid values: OAUTH2_CLIENT_CREDENTIALS, OAUTH2_SHAREPOINT_APP_ONLY_CLIENT_CREDENTIALS.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>ARN of an AWS Secrets Manager secret that stores your authentication credentials for your SharePoint site. For more information on the key-value pairs that must be included in your secret, depending on your authentication type, see SharePoint connection configuration. Pattern: ^arn:aws(|-cn|-us-gov):secretsmanager:[a-z0-9-]{1,20}:([0-9]{12}|):secret:[a-zA-Z0-9!/_+=.@-]{1,512}$.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnRef")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRef? CredentialsSecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnSelector")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelector? CredentialsSecretArnSelector { get; set; }

    /// <summary>The supported host type, whether online/cloud or server/on-premises. Valid values: ONLINE.</summary>
    [JsonPropertyName("hostType")]
    public string? HostType { get; set; }

    /// <summary>The Salesforce host URL or instance URL. Pattern: ^https://[A-Za-z0-9][^\s]*$.</summary>
    [JsonPropertyName("hostUrl")]
    public string? HostUrl { get; set; }
}

/// <summary>Details about the configuration of the Confluence data source. See confluence_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfiguration
{
    /// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
    [JsonPropertyName("crawlerConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfiguration? CrawlerConfiguration { get; set; }

    /// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfigurationSourceConfiguration? SourceConfiguration { get; set; }
}

/// <summary>Configuration for deletion protection on the data source. See deletion_protection_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration
{
    /// <summary>Enable or disable deletion protection for the connector. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("deletionProtectionStatus")]
    public string? DeletionProtectionStatus { get; set; }

    /// <summary>Maximum percentage of documents that a sync job can delete from your index.</summary>
    [JsonPropertyName("deletionProtectionThreshold")]
    public double? DeletionProtectionThreshold { get; set; }
}

/// <summary>Configuration for extracting audio content. See audio_extraction_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationAudioExtractionConfiguration
{
    /// <summary>Whether audio extraction is enabled. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("audioExtractionStatus")]
    public string? AudioExtractionStatus { get; set; }
}

/// <summary>Configuration for extracting image content. See image_extraction_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationImageExtractionConfiguration
{
    /// <summary>Whether image extraction is enabled. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("imageExtractionStatus")]
    public string? ImageExtractionStatus { get; set; }
}

/// <summary>Configuration for extracting video content. See video_extraction_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationVideoExtractionConfiguration
{
    /// <summary>Whether video extraction is enabled. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("videoExtractionStatus")]
    public string? VideoExtractionStatus { get; set; }
}

/// <summary>Configuration for extracting media content (images, audio, video) from documents. See media_extraction_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfiguration
{
    /// <summary>Configuration for extracting audio content. See audio_extraction_configuration block for details.</summary>
    [JsonPropertyName("audioExtractionConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationAudioExtractionConfiguration? AudioExtractionConfiguration { get; set; }

    /// <summary>Configuration for extracting image content. See image_extraction_configuration block for details.</summary>
    [JsonPropertyName("imageExtractionConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationImageExtractionConfiguration? ImageExtractionConfiguration { get; set; }

    /// <summary>Configuration for extracting video content. See video_extraction_configuration block for details.</summary>
    [JsonPropertyName("videoExtractionConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationVideoExtractionConfiguration? VideoExtractionConfiguration { get; set; }
}

/// <summary>Details about the configuration of a Managed Knowledge Base connector data source. See managed_knowledge_base_connector_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfiguration
{
    /// <summary>JSON-encoded string containing the connector-specific parameters. The structure depends on the connector type (S3, SharePoint, Google Drive, etc.). See Managed Knowledge Base connector parameters for details on each connector type.</summary>
    [JsonPropertyName("connectorParameters")]
    public string? ConnectorParameters { get; set; }

    /// <summary>Configuration for deletion protection on the data source. See deletion_protection_configuration block for details.</summary>
    [JsonPropertyName("deletionProtectionConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration? DeletionProtectionConfiguration { get; set; }

    /// <summary>Configuration for extracting media content (images, audio, video) from documents. See media_extraction_configuration block for details.</summary>
    [JsonPropertyName("mediaExtractionConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfiguration? MediaExtractionConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about the configuration of the S3 object containing the data source. See s3_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationS3Configuration
{
    /// <summary>ARN of the bucket that contains the data source.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Bucket account owner ID for the S3 bucket.</summary>
    [JsonPropertyName("bucketOwnerAccountId")]
    public string? BucketOwnerAccountId { get; set; }

    /// <summary>List of S3 prefixes that define the object containing the data sources. For more information, see Organizing objects using prefixes.</summary>
    [JsonPropertyName("inclusionPrefixes")]
    public IList<string>? InclusionPrefixes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters
{
    /// <summary>A list of one or more exclusion regular expression patterns to exclude certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<string>? ExclusionFilters { get; set; }

    /// <summary>List of one or more inclusion regular expression patterns to include certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<string>? InclusionFilters { get; set; }

    /// <summary>The supported object type or content type of the data source.</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter
{
    /// <summary>The configuration of specific filters applied to your data source content. Minimum of 1 filter and maximum of 25 filters.</summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters>? Filters { get; set; }
}

/// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfiguration
{
    /// <summary>The configuration of filtering certain objects or content types of the data source. See pattern_object_filter block for details.</summary>
    [JsonPropertyName("patternObjectFilter")]
    public IList<V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter>? PatternObjectFilter { get; set; }

    /// <summary>Type of storage for the data source. Valid values: S3, WEB, CONFLUENCE, SALESFORCE, SHAREPOINT, CUSTOM, REDSHIFT_METADATA, MANAGED_KNOWLEDGE_BASE_CONNECTOR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfiguration
{
    /// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
    [JsonPropertyName("filterConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfiguration? FilterConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelector
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
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfiguration
{
    /// <summary>The supported authentication type to authenticate and connect to your SharePoint site. Valid values: OAUTH2_CLIENT_CREDENTIALS, OAUTH2_SHAREPOINT_APP_ONLY_CLIENT_CREDENTIALS.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>ARN of an AWS Secrets Manager secret that stores your authentication credentials for your SharePoint site. For more information on the key-value pairs that must be included in your secret, depending on your authentication type, see SharePoint connection configuration. Pattern: ^arn:aws(|-cn|-us-gov):secretsmanager:[a-z0-9-]{1,20}:([0-9]{12}|):secret:[a-zA-Z0-9!/_+=.@-]{1,512}$.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnRef")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRef? CredentialsSecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnSelector")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelector? CredentialsSecretArnSelector { get; set; }

    /// <summary>The Salesforce host URL or instance URL. Pattern: ^https://[A-Za-z0-9][^\s]*$.</summary>
    [JsonPropertyName("hostUrl")]
    public string? HostUrl { get; set; }
}

/// <summary>Details about the configuration of the Salesforce data source. See salesforce_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfiguration
{
    /// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
    [JsonPropertyName("crawlerConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfiguration? CrawlerConfiguration { get; set; }

    /// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfigurationSourceConfiguration? SourceConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters
{
    /// <summary>A list of one or more exclusion regular expression patterns to exclude certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<string>? ExclusionFilters { get; set; }

    /// <summary>List of one or more inclusion regular expression patterns to include certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<string>? InclusionFilters { get; set; }

    /// <summary>The supported object type or content type of the data source.</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter
{
    /// <summary>The configuration of specific filters applied to your data source content. Minimum of 1 filter and maximum of 25 filters.</summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters>? Filters { get; set; }
}

/// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfiguration
{
    /// <summary>The configuration of filtering certain objects or content types of the data source. See pattern_object_filter block for details.</summary>
    [JsonPropertyName("patternObjectFilter")]
    public IList<V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter>? PatternObjectFilter { get; set; }

    /// <summary>Type of storage for the data source. Valid values: S3, WEB, CONFLUENCE, SALESFORCE, SHAREPOINT, CUSTOM, REDSHIFT_METADATA, MANAGED_KNOWLEDGE_BASE_CONNECTOR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationCrawlerConfiguration
{
    /// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
    [JsonPropertyName("filterConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfiguration? FilterConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelector
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
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfiguration
{
    /// <summary>The supported authentication type to authenticate and connect to your SharePoint site. Valid values: OAUTH2_CLIENT_CREDENTIALS, OAUTH2_SHAREPOINT_APP_ONLY_CLIENT_CREDENTIALS.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>ARN of an AWS Secrets Manager secret that stores your authentication credentials for your SharePoint site. For more information on the key-value pairs that must be included in your secret, depending on your authentication type, see SharePoint connection configuration. Pattern: ^arn:aws(|-cn|-us-gov):secretsmanager:[a-z0-9-]{1,20}:([0-9]{12}|):secret:[a-zA-Z0-9!/_+=.@-]{1,512}$.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnRef")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRef? CredentialsSecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnSelector")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelector? CredentialsSecretArnSelector { get; set; }

    /// <summary>The domain of your SharePoint instance or site URL/URLs.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The supported host type, whether online/cloud or server/on-premises. Valid values: ONLINE.</summary>
    [JsonPropertyName("hostType")]
    public string? HostType { get; set; }

    /// <summary>A list of one or more SharePoint site URLs.</summary>
    [JsonPropertyName("siteUrls")]
    public IList<string>? SiteUrls { get; set; }

    /// <summary>The identifier of your Microsoft 365 tenant.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Details about the configuration of the SharePoint data source. See share_point_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfiguration
{
    /// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
    [JsonPropertyName("crawlerConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationCrawlerConfiguration? CrawlerConfiguration { get; set; }

    /// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfigurationSourceConfiguration? SourceConfiguration { get; set; }
}

/// <summary>Configuration of crawl limits for the web URLs. See crawler_limits block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationWebConfigurationCrawlerConfigurationCrawlerLimits
{
    /// <summary>Max number of web pages crawled from your source URLs, up to 25,000 pages.</summary>
    [JsonPropertyName("maxPages")]
    public double? MaxPages { get; set; }

    /// <summary>Max rate at which pages are crawled, up to 300 per minute per host.</summary>
    [JsonPropertyName("rateLimit")]
    public double? RateLimit { get; set; }
}

/// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationWebConfigurationCrawlerConfiguration
{
    /// <summary>Configuration of crawl limits for the web URLs. See crawler_limits block for details.</summary>
    [JsonPropertyName("crawlerLimits")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationWebConfigurationCrawlerConfigurationCrawlerLimits? CrawlerLimits { get; set; }

    /// <summary>A list of one or more exclusion regular expression patterns to exclude certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<string>? ExclusionFilters { get; set; }

    /// <summary>List of one or more inclusion regular expression patterns to include certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<string>? InclusionFilters { get; set; }

    /// <summary>Scope of what is crawled for your URLs.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>String used for identifying the crawler or a bot when it accesses a web server. Default value is bedrockbot_UUID.</summary>
    [JsonPropertyName("userAgent")]
    public string? UserAgent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfigurationSeedUrls
{
    /// <summary>Seed or starting point URL. Must match the pattern ^https?://[A-Za-z0-9][^\s]*$.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>The URL configuration of your web data source. See url_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfiguration
{
    /// <summary>List of one or more seed URLs to crawl. See seed_urls block for details.</summary>
    [JsonPropertyName("seedUrls")]
    public IList<V1beta1DataSourceSpecForProviderDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfigurationSeedUrls>? SeedUrls { get; set; }
}

/// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationWebConfigurationSourceConfiguration
{
    /// <summary>The URL configuration of your web data source. See url_configuration block for details.</summary>
    [JsonPropertyName("urlConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfiguration? UrlConfiguration { get; set; }
}

/// <summary>Details about the configuration of the web data source. See web_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfigurationWebConfiguration
{
    /// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
    [JsonPropertyName("crawlerConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationWebConfigurationCrawlerConfiguration? CrawlerConfiguration { get; set; }

    /// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationWebConfigurationSourceConfiguration? SourceConfiguration { get; set; }
}

/// <summary>Details about how the data source is stored. See data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderDataSourceConfiguration
{
    /// <summary>Details about the configuration of the Confluence data source. See confluence_data_source_configuration block for details.</summary>
    [JsonPropertyName("confluenceConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationConfluenceConfiguration? ConfluenceConfiguration { get; set; }

    /// <summary>Details about the configuration of a Managed Knowledge Base connector data source. See managed_knowledge_base_connector_configuration block for details.</summary>
    [JsonPropertyName("managedKnowledgeBaseConnectorConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfiguration? ManagedKnowledgeBaseConnectorConfiguration { get; set; }

    /// <summary>Details about the configuration of the S3 object containing the data source. See s3_data_source_configuration block for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>Details about the configuration of the Salesforce data source. See salesforce_data_source_configuration block for details.</summary>
    [JsonPropertyName("salesforceConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSalesforceConfiguration? SalesforceConfiguration { get; set; }

    /// <summary>Details about the configuration of the SharePoint data source. See share_point_data_source_configuration block for details.</summary>
    [JsonPropertyName("sharePointConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationSharePointConfiguration? SharePointConfiguration { get; set; }

    /// <summary>Type of storage for the data source. Valid values: S3, WEB, CONFLUENCE, SALESFORCE, SHAREPOINT, CUSTOM, REDSHIFT_METADATA, MANAGED_KNOWLEDGE_BASE_CONNECTOR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Details about the configuration of the web data source. See web_data_source_configuration block for details.</summary>
    [JsonPropertyName("webConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfigurationWebConfiguration? WebConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderKnowledgeBaseIdRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderKnowledgeBaseIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderKnowledgeBaseIdRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderKnowledgeBaseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderKnowledgeBaseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderKnowledgeBaseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderKnowledgeBaseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderKnowledgeBaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderKnowledgeBaseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderKnowledgeBaseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderKnowledgeBaseIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderKnowledgeBaseIdSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderKnowledgeBaseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderKnowledgeBaseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderKnowledgeBaseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderKnowledgeBaseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderKnowledgeBaseIdSelector
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
    public V1beta1DataSourceSpecForProviderKnowledgeBaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnSelector
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
    public V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about the configuration of the server-side encryption. See server_side_encryption_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderServerSideEncryptionConfiguration
{
    /// <summary>ARN of the AWS KMS key used to encrypt the resource.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1DataSourceSpecForProviderServerSideEncryptionConfigurationKmsKeyArnSelector? KmsKeyArnSelector { get; set; }
}

/// <summary>Configurations for when you choose fixed-size chunking. Requires chunking_strategy as FIXED_SIZE. See fixed_size_chunking_configuration for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationChunkingConfigurationFixedSizeChunkingConfiguration
{
    /// <summary>Maximum number of tokens to include in a chunk.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Percentage of overlap between adjacent chunks of a data source.</summary>
    [JsonPropertyName("overlapPercentage")]
    public double? OverlapPercentage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationChunkingConfigurationHierarchicalChunkingConfigurationLevelConfiguration
{
    /// <summary>Maximum number of tokens to include in a chunk.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }
}

/// <summary>Configurations for when you choose hierarchical chunking. Requires chunking_strategy as HIERARCHICAL. See hierarchical_chunking_configuration for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationChunkingConfigurationHierarchicalChunkingConfiguration
{
    /// <summary>Maximum number of tokens to include in a chunk. Must contain two level_configurations. See level_configurations for details.</summary>
    [JsonPropertyName("levelConfiguration")]
    public IList<V1beta1DataSourceSpecForProviderVectorIngestionConfigurationChunkingConfigurationHierarchicalChunkingConfigurationLevelConfiguration>? LevelConfiguration { get; set; }

    /// <summary>The number of tokens to repeat across chunks in the same layer.</summary>
    [JsonPropertyName("overlapTokens")]
    public double? OverlapTokens { get; set; }
}

/// <summary>Configurations for when you choose semantic chunking. Requires chunking_strategy as SEMANTIC. See semantic_chunking_configuration for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationChunkingConfigurationSemanticChunkingConfiguration
{
    /// <summary>The dissimilarity threshold for splitting chunks.</summary>
    [JsonPropertyName("breakpointPercentileThreshold")]
    public double? BreakpointPercentileThreshold { get; set; }

    /// <summary>The buffer size.</summary>
    [JsonPropertyName("bufferSize")]
    public double? BufferSize { get; set; }

    /// <summary>The maximum number of tokens a chunk can contain.</summary>
    [JsonPropertyName("maxToken")]
    public double? MaxToken { get; set; }
}

/// <summary>Details about how to chunk the documents in the data source. A chunk refers to an excerpt from a data source that is returned when the knowledge base that it belongs to is queried. See chunking_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationChunkingConfiguration
{
    /// <summary>Option for chunking your source data, either in fixed-sized chunks or as one chunk. Valid values: FIXED_SIZE, HIERARCHICAL, SEMANTIC, NONE.</summary>
    [JsonPropertyName("chunkingStrategy")]
    public string? ChunkingStrategy { get; set; }

    /// <summary>Configurations for when you choose fixed-size chunking. Requires chunking_strategy as FIXED_SIZE. See fixed_size_chunking_configuration for details.</summary>
    [JsonPropertyName("fixedSizeChunkingConfiguration")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationChunkingConfigurationFixedSizeChunkingConfiguration? FixedSizeChunkingConfiguration { get; set; }

    /// <summary>Configurations for when you choose hierarchical chunking. Requires chunking_strategy as HIERARCHICAL. See hierarchical_chunking_configuration for details.</summary>
    [JsonPropertyName("hierarchicalChunkingConfiguration")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationChunkingConfigurationHierarchicalChunkingConfiguration? HierarchicalChunkingConfiguration { get; set; }

    /// <summary>Configurations for when you choose semantic chunking. Requires chunking_strategy as SEMANTIC. See semantic_chunking_configuration for details.</summary>
    [JsonPropertyName("semanticChunkingConfiguration")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationChunkingConfigurationSemanticChunkingConfiguration? SemanticChunkingConfiguration { get; set; }
}

/// <summary>Configuration block for intermedia S3 storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorageS3Location
{
    /// <summary>S3 URI for intermediate storage.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>The intermediate storage for custom transformation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorage
{
    /// <summary>Configuration block for intermedia S3 storage.</summary>
    [JsonPropertyName("s3Location")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorageS3Location? S3Location { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelector
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
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The configuration of the lambda function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfiguration
{
    /// <summary>The ARN of the lambda to use for custom transformation.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelector? LambdaArnSelector { get; set; }
}

/// <summary>The lambda function that processes documents.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunction
{
    /// <summary>The configuration of the lambda function.</summary>
    [JsonPropertyName("transformationLambdaConfiguration")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfiguration? TransformationLambdaConfiguration { get; set; }
}

/// <summary>A custom processing step for documents moving through the data source ingestion pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformation
{
    /// <summary>When the service applies the transformation. Currently only POST_CHUNKING is supported.</summary>
    [JsonPropertyName("stepToApply")]
    public string? StepToApply { get; set; }

    /// <summary>The lambda function that processes documents.</summary>
    [JsonPropertyName("transformationFunction")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunction? TransformationFunction { get; set; }
}

/// <summary>Configuration for custom transformation of data source documents.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfiguration
{
    /// <summary>The intermediate storage for custom transformation.</summary>
    [JsonPropertyName("intermediateStorage")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorage? IntermediateStorage { get; set; }

    /// <summary>A custom processing step for documents moving through the data source ingestion pipeline.</summary>
    [JsonPropertyName("transformation")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformation? Transformation { get; set; }
}

/// <summary>Settings for using Amazon Bedrock Data Automation to parse documents. See bedrock_data_automation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration
{
    /// <summary>Specifies whether to enable parsing of multimodal data, including both text and images. Valid value: MULTIMODAL.</summary>
    [JsonPropertyName("parsingModality")]
    public string? ParsingModality { get; set; }
}

/// <summary>Instructions for interpreting the contents of the document. See parsing_prompt block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationParsingConfigurationBedrockFoundationModelConfigurationParsingPrompt
{
    /// <summary>Instructions for interpreting the contents of the document.</summary>
    [JsonPropertyName("parsingPromptString")]
    public string? ParsingPromptString { get; set; }
}

/// <summary>Settings for a foundation model used to parse documents in a data source. See bedrock_foundation_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationParsingConfigurationBedrockFoundationModelConfiguration
{
    /// <summary>The ARN of the model used to parse documents</summary>
    [JsonPropertyName("modelArn")]
    public string? ModelArn { get; set; }

    /// <summary>Specifies whether to enable parsing of multimodal data, including both text and images. Valid value: MULTIMODAL.</summary>
    [JsonPropertyName("parsingModality")]
    public string? ParsingModality { get; set; }

    /// <summary>Instructions for interpreting the contents of the document. See parsing_prompt block for details.</summary>
    [JsonPropertyName("parsingPrompt")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationParsingConfigurationBedrockFoundationModelConfigurationParsingPrompt? ParsingPrompt { get; set; }
}

/// <summary>Configuration for custom parsing of data source documents. See parsing_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfigurationParsingConfiguration
{
    /// <summary>Settings for using Amazon Bedrock Data Automation to parse documents. See bedrock_data_automation_configuration block for details.</summary>
    [JsonPropertyName("bedrockDataAutomationConfiguration")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration? BedrockDataAutomationConfiguration { get; set; }

    /// <summary>Settings for a foundation model used to parse documents in a data source. See bedrock_foundation_model_configuration block for details.</summary>
    [JsonPropertyName("bedrockFoundationModelConfiguration")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationParsingConfigurationBedrockFoundationModelConfiguration? BedrockFoundationModelConfiguration { get; set; }

    /// <summary>The parsing strategy to use. Valid values: BEDROCK_FOUNDATION_MODEL, BEDROCK_DATA_AUTOMATION.</summary>
    [JsonPropertyName("parsingStrategy")]
    public string? ParsingStrategy { get; set; }
}

/// <summary>Details about the configuration of the server-side encryption. See vector_ingestion_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProviderVectorIngestionConfiguration
{
    /// <summary>Details about how to chunk the documents in the data source. A chunk refers to an excerpt from a data source that is returned when the knowledge base that it belongs to is queried. See chunking_configuration block for details.</summary>
    [JsonPropertyName("chunkingConfiguration")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationChunkingConfiguration? ChunkingConfiguration { get; set; }

    /// <summary>Configuration for custom transformation of data source documents.</summary>
    [JsonPropertyName("customTransformationConfiguration")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationCustomTransformationConfiguration? CustomTransformationConfiguration { get; set; }

    /// <summary>Configuration for custom parsing of data source documents. See parsing_configuration block for details.</summary>
    [JsonPropertyName("parsingConfiguration")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfigurationParsingConfiguration? ParsingConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecForProvider
{
    /// <summary>Data deletion policy for a data source. Valid values: RETAIN, DELETE.</summary>
    [JsonPropertyName("dataDeletionPolicy")]
    public string? DataDeletionPolicy { get; set; }

    /// <summary>Details about how the data source is stored. See data_source_configuration block for details.</summary>
    [JsonPropertyName("dataSourceConfiguration")]
    public V1beta1DataSourceSpecForProviderDataSourceConfiguration? DataSourceConfiguration { get; set; }

    /// <summary>Description of the data source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Unique identifier of the knowledge base to which the data source belongs.</summary>
    [JsonPropertyName("knowledgeBaseId")]
    public string? KnowledgeBaseId { get; set; }

    /// <summary>Reference to a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdRef")]
    public V1beta1DataSourceSpecForProviderKnowledgeBaseIdRef? KnowledgeBaseIdRef { get; set; }

    /// <summary>Selector for a KnowledgeBase in bedrockagent to populate knowledgeBaseId.</summary>
    [JsonPropertyName("knowledgeBaseIdSelector")]
    public V1beta1DataSourceSpecForProviderKnowledgeBaseIdSelector? KnowledgeBaseIdSelector { get; set; }

    /// <summary>Name of the data source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Details about the configuration of the server-side encryption. See server_side_encryption_configuration block for details.</summary>
    [JsonPropertyName("serverSideEncryptionConfiguration")]
    public V1beta1DataSourceSpecForProviderServerSideEncryptionConfiguration? ServerSideEncryptionConfiguration { get; set; }

    /// <summary>Details about the configuration of the server-side encryption. See vector_ingestion_configuration block for details.</summary>
    [JsonPropertyName("vectorIngestionConfiguration")]
    public V1beta1DataSourceSpecForProviderVectorIngestionConfiguration? VectorIngestionConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters
{
    /// <summary>A list of one or more exclusion regular expression patterns to exclude certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<string>? ExclusionFilters { get; set; }

    /// <summary>List of one or more inclusion regular expression patterns to include certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<string>? InclusionFilters { get; set; }

    /// <summary>The supported object type or content type of the data source.</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter
{
    /// <summary>The configuration of specific filters applied to your data source content. Minimum of 1 filter and maximum of 25 filters.</summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters>? Filters { get; set; }
}

/// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfiguration
{
    /// <summary>The configuration of filtering certain objects or content types of the data source. See pattern_object_filter block for details.</summary>
    [JsonPropertyName("patternObjectFilter")]
    public IList<V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter>? PatternObjectFilter { get; set; }

    /// <summary>Type of storage for the data source. Valid values: S3, WEB, CONFLUENCE, SALESFORCE, SHAREPOINT, CUSTOM, REDSHIFT_METADATA, MANAGED_KNOWLEDGE_BASE_CONNECTOR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfiguration
{
    /// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
    [JsonPropertyName("filterConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfiguration? FilterConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelector
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
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfiguration
{
    /// <summary>The supported authentication type to authenticate and connect to your SharePoint site. Valid values: OAUTH2_CLIENT_CREDENTIALS, OAUTH2_SHAREPOINT_APP_ONLY_CLIENT_CREDENTIALS.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>ARN of an AWS Secrets Manager secret that stores your authentication credentials for your SharePoint site. For more information on the key-value pairs that must be included in your secret, depending on your authentication type, see SharePoint connection configuration. Pattern: ^arn:aws(|-cn|-us-gov):secretsmanager:[a-z0-9-]{1,20}:([0-9]{12}|):secret:[a-zA-Z0-9!/_+=.@-]{1,512}$.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnRef")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnRef? CredentialsSecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnSelector")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfigurationCredentialsSecretArnSelector? CredentialsSecretArnSelector { get; set; }

    /// <summary>The supported host type, whether online/cloud or server/on-premises. Valid values: ONLINE.</summary>
    [JsonPropertyName("hostType")]
    public string? HostType { get; set; }

    /// <summary>The Salesforce host URL or instance URL. Pattern: ^https://[A-Za-z0-9][^\s]*$.</summary>
    [JsonPropertyName("hostUrl")]
    public string? HostUrl { get; set; }
}

/// <summary>Details about the configuration of the Confluence data source. See confluence_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfiguration
{
    /// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
    [JsonPropertyName("crawlerConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfiguration? CrawlerConfiguration { get; set; }

    /// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfigurationSourceConfiguration? SourceConfiguration { get; set; }
}

/// <summary>Configuration for deletion protection on the data source. See deletion_protection_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration
{
    /// <summary>Enable or disable deletion protection for the connector. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("deletionProtectionStatus")]
    public string? DeletionProtectionStatus { get; set; }

    /// <summary>Maximum percentage of documents that a sync job can delete from your index.</summary>
    [JsonPropertyName("deletionProtectionThreshold")]
    public double? DeletionProtectionThreshold { get; set; }
}

/// <summary>Configuration for extracting audio content. See audio_extraction_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationAudioExtractionConfiguration
{
    /// <summary>Whether audio extraction is enabled. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("audioExtractionStatus")]
    public string? AudioExtractionStatus { get; set; }
}

/// <summary>Configuration for extracting image content. See image_extraction_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationImageExtractionConfiguration
{
    /// <summary>Whether image extraction is enabled. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("imageExtractionStatus")]
    public string? ImageExtractionStatus { get; set; }
}

/// <summary>Configuration for extracting video content. See video_extraction_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationVideoExtractionConfiguration
{
    /// <summary>Whether video extraction is enabled. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("videoExtractionStatus")]
    public string? VideoExtractionStatus { get; set; }
}

/// <summary>Configuration for extracting media content (images, audio, video) from documents. See media_extraction_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfiguration
{
    /// <summary>Configuration for extracting audio content. See audio_extraction_configuration block for details.</summary>
    [JsonPropertyName("audioExtractionConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationAudioExtractionConfiguration? AudioExtractionConfiguration { get; set; }

    /// <summary>Configuration for extracting image content. See image_extraction_configuration block for details.</summary>
    [JsonPropertyName("imageExtractionConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationImageExtractionConfiguration? ImageExtractionConfiguration { get; set; }

    /// <summary>Configuration for extracting video content. See video_extraction_configuration block for details.</summary>
    [JsonPropertyName("videoExtractionConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationVideoExtractionConfiguration? VideoExtractionConfiguration { get; set; }
}

/// <summary>Details about the configuration of a Managed Knowledge Base connector data source. See managed_knowledge_base_connector_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfiguration
{
    /// <summary>JSON-encoded string containing the connector-specific parameters. The structure depends on the connector type (S3, SharePoint, Google Drive, etc.). See Managed Knowledge Base connector parameters for details on each connector type.</summary>
    [JsonPropertyName("connectorParameters")]
    public string? ConnectorParameters { get; set; }

    /// <summary>Configuration for deletion protection on the data source. See deletion_protection_configuration block for details.</summary>
    [JsonPropertyName("deletionProtectionConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration? DeletionProtectionConfiguration { get; set; }

    /// <summary>Configuration for extracting media content (images, audio, video) from documents. See media_extraction_configuration block for details.</summary>
    [JsonPropertyName("mediaExtractionConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfiguration? MediaExtractionConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about the configuration of the S3 object containing the data source. See s3_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3Configuration
{
    /// <summary>ARN of the bucket that contains the data source.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Bucket account owner ID for the S3 bucket.</summary>
    [JsonPropertyName("bucketOwnerAccountId")]
    public string? BucketOwnerAccountId { get; set; }

    /// <summary>List of S3 prefixes that define the object containing the data sources. For more information, see Organizing objects using prefixes.</summary>
    [JsonPropertyName("inclusionPrefixes")]
    public IList<string>? InclusionPrefixes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters
{
    /// <summary>A list of one or more exclusion regular expression patterns to exclude certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<string>? ExclusionFilters { get; set; }

    /// <summary>List of one or more inclusion regular expression patterns to include certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<string>? InclusionFilters { get; set; }

    /// <summary>The supported object type or content type of the data source.</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter
{
    /// <summary>The configuration of specific filters applied to your data source content. Minimum of 1 filter and maximum of 25 filters.</summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters>? Filters { get; set; }
}

/// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfiguration
{
    /// <summary>The configuration of filtering certain objects or content types of the data source. See pattern_object_filter block for details.</summary>
    [JsonPropertyName("patternObjectFilter")]
    public IList<V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter>? PatternObjectFilter { get; set; }

    /// <summary>Type of storage for the data source. Valid values: S3, WEB, CONFLUENCE, SALESFORCE, SHAREPOINT, CUSTOM, REDSHIFT_METADATA, MANAGED_KNOWLEDGE_BASE_CONNECTOR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfiguration
{
    /// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
    [JsonPropertyName("filterConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfiguration? FilterConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelector
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
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfiguration
{
    /// <summary>The supported authentication type to authenticate and connect to your SharePoint site. Valid values: OAUTH2_CLIENT_CREDENTIALS, OAUTH2_SHAREPOINT_APP_ONLY_CLIENT_CREDENTIALS.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>ARN of an AWS Secrets Manager secret that stores your authentication credentials for your SharePoint site. For more information on the key-value pairs that must be included in your secret, depending on your authentication type, see SharePoint connection configuration. Pattern: ^arn:aws(|-cn|-us-gov):secretsmanager:[a-z0-9-]{1,20}:([0-9]{12}|):secret:[a-zA-Z0-9!/_+=.@-]{1,512}$.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnRef")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnRef? CredentialsSecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnSelector")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfigurationCredentialsSecretArnSelector? CredentialsSecretArnSelector { get; set; }

    /// <summary>The Salesforce host URL or instance URL. Pattern: ^https://[A-Za-z0-9][^\s]*$.</summary>
    [JsonPropertyName("hostUrl")]
    public string? HostUrl { get; set; }
}

/// <summary>Details about the configuration of the Salesforce data source. See salesforce_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfiguration
{
    /// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
    [JsonPropertyName("crawlerConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfiguration? CrawlerConfiguration { get; set; }

    /// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfigurationSourceConfiguration? SourceConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters
{
    /// <summary>A list of one or more exclusion regular expression patterns to exclude certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<string>? ExclusionFilters { get; set; }

    /// <summary>List of one or more inclusion regular expression patterns to include certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<string>? InclusionFilters { get; set; }

    /// <summary>The supported object type or content type of the data source.</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter
{
    /// <summary>The configuration of specific filters applied to your data source content. Minimum of 1 filter and maximum of 25 filters.</summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters>? Filters { get; set; }
}

/// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfiguration
{
    /// <summary>The configuration of filtering certain objects or content types of the data source. See pattern_object_filter block for details.</summary>
    [JsonPropertyName("patternObjectFilter")]
    public IList<V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter>? PatternObjectFilter { get; set; }

    /// <summary>Type of storage for the data source. Valid values: S3, WEB, CONFLUENCE, SALESFORCE, SHAREPOINT, CUSTOM, REDSHIFT_METADATA, MANAGED_KNOWLEDGE_BASE_CONNECTOR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationCrawlerConfiguration
{
    /// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
    [JsonPropertyName("filterConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfiguration? FilterConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelector
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
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfiguration
{
    /// <summary>The supported authentication type to authenticate and connect to your SharePoint site. Valid values: OAUTH2_CLIENT_CREDENTIALS, OAUTH2_SHAREPOINT_APP_ONLY_CLIENT_CREDENTIALS.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>ARN of an AWS Secrets Manager secret that stores your authentication credentials for your SharePoint site. For more information on the key-value pairs that must be included in your secret, depending on your authentication type, see SharePoint connection configuration. Pattern: ^arn:aws(|-cn|-us-gov):secretsmanager:[a-z0-9-]{1,20}:([0-9]{12}|):secret:[a-zA-Z0-9!/_+=.@-]{1,512}$.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnRef")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnRef? CredentialsSecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentialsSecretArn.</summary>
    [JsonPropertyName("credentialsSecretArnSelector")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfigurationCredentialsSecretArnSelector? CredentialsSecretArnSelector { get; set; }

    /// <summary>The domain of your SharePoint instance or site URL/URLs.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The supported host type, whether online/cloud or server/on-premises. Valid values: ONLINE.</summary>
    [JsonPropertyName("hostType")]
    public string? HostType { get; set; }

    /// <summary>A list of one or more SharePoint site URLs.</summary>
    [JsonPropertyName("siteUrls")]
    public IList<string>? SiteUrls { get; set; }

    /// <summary>The identifier of your Microsoft 365 tenant.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Details about the configuration of the SharePoint data source. See share_point_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfiguration
{
    /// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
    [JsonPropertyName("crawlerConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationCrawlerConfiguration? CrawlerConfiguration { get; set; }

    /// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfigurationSourceConfiguration? SourceConfiguration { get; set; }
}

/// <summary>Configuration of crawl limits for the web URLs. See crawler_limits block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationWebConfigurationCrawlerConfigurationCrawlerLimits
{
    /// <summary>Max number of web pages crawled from your source URLs, up to 25,000 pages.</summary>
    [JsonPropertyName("maxPages")]
    public double? MaxPages { get; set; }

    /// <summary>Max rate at which pages are crawled, up to 300 per minute per host.</summary>
    [JsonPropertyName("rateLimit")]
    public double? RateLimit { get; set; }
}

/// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationWebConfigurationCrawlerConfiguration
{
    /// <summary>Configuration of crawl limits for the web URLs. See crawler_limits block for details.</summary>
    [JsonPropertyName("crawlerLimits")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationWebConfigurationCrawlerConfigurationCrawlerLimits? CrawlerLimits { get; set; }

    /// <summary>A list of one or more exclusion regular expression patterns to exclude certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<string>? ExclusionFilters { get; set; }

    /// <summary>List of one or more inclusion regular expression patterns to include certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<string>? InclusionFilters { get; set; }

    /// <summary>Scope of what is crawled for your URLs.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>String used for identifying the crawler or a bot when it accesses a web server. Default value is bedrockbot_UUID.</summary>
    [JsonPropertyName("userAgent")]
    public string? UserAgent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfigurationSeedUrls
{
    /// <summary>Seed or starting point URL. Must match the pattern ^https?://[A-Za-z0-9][^\s]*$.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>The URL configuration of your web data source. See url_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfiguration
{
    /// <summary>List of one or more seed URLs to crawl. See seed_urls block for details.</summary>
    [JsonPropertyName("seedUrls")]
    public IList<V1beta1DataSourceSpecInitProviderDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfigurationSeedUrls>? SeedUrls { get; set; }
}

/// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationWebConfigurationSourceConfiguration
{
    /// <summary>The URL configuration of your web data source. See url_configuration block for details.</summary>
    [JsonPropertyName("urlConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfiguration? UrlConfiguration { get; set; }
}

/// <summary>Details about the configuration of the web data source. See web_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfigurationWebConfiguration
{
    /// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
    [JsonPropertyName("crawlerConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationWebConfigurationCrawlerConfiguration? CrawlerConfiguration { get; set; }

    /// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationWebConfigurationSourceConfiguration? SourceConfiguration { get; set; }
}

/// <summary>Details about how the data source is stored. See data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderDataSourceConfiguration
{
    /// <summary>Details about the configuration of the Confluence data source. See confluence_data_source_configuration block for details.</summary>
    [JsonPropertyName("confluenceConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationConfluenceConfiguration? ConfluenceConfiguration { get; set; }

    /// <summary>Details about the configuration of a Managed Knowledge Base connector data source. See managed_knowledge_base_connector_configuration block for details.</summary>
    [JsonPropertyName("managedKnowledgeBaseConnectorConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfiguration? ManagedKnowledgeBaseConnectorConfiguration { get; set; }

    /// <summary>Details about the configuration of the S3 object containing the data source. See s3_data_source_configuration block for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>Details about the configuration of the Salesforce data source. See salesforce_data_source_configuration block for details.</summary>
    [JsonPropertyName("salesforceConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSalesforceConfiguration? SalesforceConfiguration { get; set; }

    /// <summary>Details about the configuration of the SharePoint data source. See share_point_data_source_configuration block for details.</summary>
    [JsonPropertyName("sharePointConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationSharePointConfiguration? SharePointConfiguration { get; set; }

    /// <summary>Type of storage for the data source. Valid values: S3, WEB, CONFLUENCE, SALESFORCE, SHAREPOINT, CUSTOM, REDSHIFT_METADATA, MANAGED_KNOWLEDGE_BASE_CONNECTOR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Details about the configuration of the web data source. See web_data_source_configuration block for details.</summary>
    [JsonPropertyName("webConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfigurationWebConfiguration? WebConfiguration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnSelector
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
    public V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Details about the configuration of the server-side encryption. See server_side_encryption_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderServerSideEncryptionConfiguration
{
    /// <summary>ARN of the AWS KMS key used to encrypt the resource.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1DataSourceSpecInitProviderServerSideEncryptionConfigurationKmsKeyArnSelector? KmsKeyArnSelector { get; set; }
}

/// <summary>Configurations for when you choose fixed-size chunking. Requires chunking_strategy as FIXED_SIZE. See fixed_size_chunking_configuration for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationChunkingConfigurationFixedSizeChunkingConfiguration
{
    /// <summary>Maximum number of tokens to include in a chunk.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Percentage of overlap between adjacent chunks of a data source.</summary>
    [JsonPropertyName("overlapPercentage")]
    public double? OverlapPercentage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationChunkingConfigurationHierarchicalChunkingConfigurationLevelConfiguration
{
    /// <summary>Maximum number of tokens to include in a chunk.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }
}

/// <summary>Configurations for when you choose hierarchical chunking. Requires chunking_strategy as HIERARCHICAL. See hierarchical_chunking_configuration for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationChunkingConfigurationHierarchicalChunkingConfiguration
{
    /// <summary>Maximum number of tokens to include in a chunk. Must contain two level_configurations. See level_configurations for details.</summary>
    [JsonPropertyName("levelConfiguration")]
    public IList<V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationChunkingConfigurationHierarchicalChunkingConfigurationLevelConfiguration>? LevelConfiguration { get; set; }

    /// <summary>The number of tokens to repeat across chunks in the same layer.</summary>
    [JsonPropertyName("overlapTokens")]
    public double? OverlapTokens { get; set; }
}

/// <summary>Configurations for when you choose semantic chunking. Requires chunking_strategy as SEMANTIC. See semantic_chunking_configuration for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationChunkingConfigurationSemanticChunkingConfiguration
{
    /// <summary>The dissimilarity threshold for splitting chunks.</summary>
    [JsonPropertyName("breakpointPercentileThreshold")]
    public double? BreakpointPercentileThreshold { get; set; }

    /// <summary>The buffer size.</summary>
    [JsonPropertyName("bufferSize")]
    public double? BufferSize { get; set; }

    /// <summary>The maximum number of tokens a chunk can contain.</summary>
    [JsonPropertyName("maxToken")]
    public double? MaxToken { get; set; }
}

/// <summary>Details about how to chunk the documents in the data source. A chunk refers to an excerpt from a data source that is returned when the knowledge base that it belongs to is queried. See chunking_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationChunkingConfiguration
{
    /// <summary>Option for chunking your source data, either in fixed-sized chunks or as one chunk. Valid values: FIXED_SIZE, HIERARCHICAL, SEMANTIC, NONE.</summary>
    [JsonPropertyName("chunkingStrategy")]
    public string? ChunkingStrategy { get; set; }

    /// <summary>Configurations for when you choose fixed-size chunking. Requires chunking_strategy as FIXED_SIZE. See fixed_size_chunking_configuration for details.</summary>
    [JsonPropertyName("fixedSizeChunkingConfiguration")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationChunkingConfigurationFixedSizeChunkingConfiguration? FixedSizeChunkingConfiguration { get; set; }

    /// <summary>Configurations for when you choose hierarchical chunking. Requires chunking_strategy as HIERARCHICAL. See hierarchical_chunking_configuration for details.</summary>
    [JsonPropertyName("hierarchicalChunkingConfiguration")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationChunkingConfigurationHierarchicalChunkingConfiguration? HierarchicalChunkingConfiguration { get; set; }

    /// <summary>Configurations for when you choose semantic chunking. Requires chunking_strategy as SEMANTIC. See semantic_chunking_configuration for details.</summary>
    [JsonPropertyName("semanticChunkingConfiguration")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationChunkingConfigurationSemanticChunkingConfiguration? SemanticChunkingConfiguration { get; set; }
}

/// <summary>Configuration block for intermedia S3 storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorageS3Location
{
    /// <summary>S3 URI for intermediate storage.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>The intermediate storage for custom transformation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorage
{
    /// <summary>Configuration block for intermedia S3 storage.</summary>
    [JsonPropertyName("s3Location")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorageS3Location? S3Location { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelector
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
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The configuration of the lambda function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfiguration
{
    /// <summary>The ARN of the lambda to use for custom transformation.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfigurationLambdaArnSelector? LambdaArnSelector { get; set; }
}

/// <summary>The lambda function that processes documents.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunction
{
    /// <summary>The configuration of the lambda function.</summary>
    [JsonPropertyName("transformationLambdaConfiguration")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfiguration? TransformationLambdaConfiguration { get; set; }
}

/// <summary>A custom processing step for documents moving through the data source ingestion pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformation
{
    /// <summary>When the service applies the transformation. Currently only POST_CHUNKING is supported.</summary>
    [JsonPropertyName("stepToApply")]
    public string? StepToApply { get; set; }

    /// <summary>The lambda function that processes documents.</summary>
    [JsonPropertyName("transformationFunction")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunction? TransformationFunction { get; set; }
}

/// <summary>Configuration for custom transformation of data source documents.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfiguration
{
    /// <summary>The intermediate storage for custom transformation.</summary>
    [JsonPropertyName("intermediateStorage")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorage? IntermediateStorage { get; set; }

    /// <summary>A custom processing step for documents moving through the data source ingestion pipeline.</summary>
    [JsonPropertyName("transformation")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformation? Transformation { get; set; }
}

/// <summary>Settings for using Amazon Bedrock Data Automation to parse documents. See bedrock_data_automation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration
{
    /// <summary>Specifies whether to enable parsing of multimodal data, including both text and images. Valid value: MULTIMODAL.</summary>
    [JsonPropertyName("parsingModality")]
    public string? ParsingModality { get; set; }
}

/// <summary>Instructions for interpreting the contents of the document. See parsing_prompt block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationParsingConfigurationBedrockFoundationModelConfigurationParsingPrompt
{
    /// <summary>Instructions for interpreting the contents of the document.</summary>
    [JsonPropertyName("parsingPromptString")]
    public string? ParsingPromptString { get; set; }
}

/// <summary>Settings for a foundation model used to parse documents in a data source. See bedrock_foundation_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationParsingConfigurationBedrockFoundationModelConfiguration
{
    /// <summary>The ARN of the model used to parse documents</summary>
    [JsonPropertyName("modelArn")]
    public string? ModelArn { get; set; }

    /// <summary>Specifies whether to enable parsing of multimodal data, including both text and images. Valid value: MULTIMODAL.</summary>
    [JsonPropertyName("parsingModality")]
    public string? ParsingModality { get; set; }

    /// <summary>Instructions for interpreting the contents of the document. See parsing_prompt block for details.</summary>
    [JsonPropertyName("parsingPrompt")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationParsingConfigurationBedrockFoundationModelConfigurationParsingPrompt? ParsingPrompt { get; set; }
}

/// <summary>Configuration for custom parsing of data source documents. See parsing_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationParsingConfiguration
{
    /// <summary>Settings for using Amazon Bedrock Data Automation to parse documents. See bedrock_data_automation_configuration block for details.</summary>
    [JsonPropertyName("bedrockDataAutomationConfiguration")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration? BedrockDataAutomationConfiguration { get; set; }

    /// <summary>Settings for a foundation model used to parse documents in a data source. See bedrock_foundation_model_configuration block for details.</summary>
    [JsonPropertyName("bedrockFoundationModelConfiguration")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationParsingConfigurationBedrockFoundationModelConfiguration? BedrockFoundationModelConfiguration { get; set; }

    /// <summary>The parsing strategy to use. Valid values: BEDROCK_FOUNDATION_MODEL, BEDROCK_DATA_AUTOMATION.</summary>
    [JsonPropertyName("parsingStrategy")]
    public string? ParsingStrategy { get; set; }
}

/// <summary>Details about the configuration of the server-side encryption. See vector_ingestion_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecInitProviderVectorIngestionConfiguration
{
    /// <summary>Details about how to chunk the documents in the data source. A chunk refers to an excerpt from a data source that is returned when the knowledge base that it belongs to is queried. See chunking_configuration block for details.</summary>
    [JsonPropertyName("chunkingConfiguration")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationChunkingConfiguration? ChunkingConfiguration { get; set; }

    /// <summary>Configuration for custom transformation of data source documents.</summary>
    [JsonPropertyName("customTransformationConfiguration")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationCustomTransformationConfiguration? CustomTransformationConfiguration { get; set; }

    /// <summary>Configuration for custom parsing of data source documents. See parsing_configuration block for details.</summary>
    [JsonPropertyName("parsingConfiguration")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfigurationParsingConfiguration? ParsingConfiguration { get; set; }
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
public partial class V1beta1DataSourceSpecInitProvider
{
    /// <summary>Data deletion policy for a data source. Valid values: RETAIN, DELETE.</summary>
    [JsonPropertyName("dataDeletionPolicy")]
    public string? DataDeletionPolicy { get; set; }

    /// <summary>Details about how the data source is stored. See data_source_configuration block for details.</summary>
    [JsonPropertyName("dataSourceConfiguration")]
    public V1beta1DataSourceSpecInitProviderDataSourceConfiguration? DataSourceConfiguration { get; set; }

    /// <summary>Description of the data source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the data source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Details about the configuration of the server-side encryption. See server_side_encryption_configuration block for details.</summary>
    [JsonPropertyName("serverSideEncryptionConfiguration")]
    public V1beta1DataSourceSpecInitProviderServerSideEncryptionConfiguration? ServerSideEncryptionConfiguration { get; set; }

    /// <summary>Details about the configuration of the server-side encryption. See vector_ingestion_configuration block for details.</summary>
    [JsonPropertyName("vectorIngestionConfiguration")]
    public V1beta1DataSourceSpecInitProviderVectorIngestionConfiguration? VectorIngestionConfiguration { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecManagementPoliciesEnum>))]
public enum V1beta1DataSourceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1DataSourceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataSourceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1DataSourceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DataSourceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DataSourceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSourceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DataSourceSpec defines the desired state of DataSource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceSpec
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
    public V1beta1DataSourceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1DataSourceSpecForProvider ForProvider { get; set; }

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
    public V1beta1DataSourceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1DataSourceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DataSourceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DataSourceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters
{
    /// <summary>A list of one or more exclusion regular expression patterns to exclude certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<string>? ExclusionFilters { get; set; }

    /// <summary>List of one or more inclusion regular expression patterns to include certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<string>? InclusionFilters { get; set; }

    /// <summary>The supported object type or content type of the data source.</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter
{
    /// <summary>The configuration of specific filters applied to your data source content. Minimum of 1 filter and maximum of 25 filters.</summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1DataSourceStatusAtProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters>? Filters { get; set; }
}

/// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfiguration
{
    /// <summary>The configuration of filtering certain objects or content types of the data source. See pattern_object_filter block for details.</summary>
    [JsonPropertyName("patternObjectFilter")]
    public IList<V1beta1DataSourceStatusAtProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter>? PatternObjectFilter { get; set; }

    /// <summary>Type of storage for the data source. Valid values: S3, WEB, CONFLUENCE, SALESFORCE, SHAREPOINT, CUSTOM, REDSHIFT_METADATA, MANAGED_KNOWLEDGE_BASE_CONNECTOR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfiguration
{
    /// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
    [JsonPropertyName("filterConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfigurationFilterConfiguration? FilterConfiguration { get; set; }
}

/// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationConfluenceConfigurationSourceConfiguration
{
    /// <summary>The supported authentication type to authenticate and connect to your SharePoint site. Valid values: OAUTH2_CLIENT_CREDENTIALS, OAUTH2_SHAREPOINT_APP_ONLY_CLIENT_CREDENTIALS.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>ARN of an AWS Secrets Manager secret that stores your authentication credentials for your SharePoint site. For more information on the key-value pairs that must be included in your secret, depending on your authentication type, see SharePoint connection configuration. Pattern: ^arn:aws(|-cn|-us-gov):secretsmanager:[a-z0-9-]{1,20}:([0-9]{12}|):secret:[a-zA-Z0-9!/_+=.@-]{1,512}$.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>The supported host type, whether online/cloud or server/on-premises. Valid values: ONLINE.</summary>
    [JsonPropertyName("hostType")]
    public string? HostType { get; set; }

    /// <summary>The Salesforce host URL or instance URL. Pattern: ^https://[A-Za-z0-9][^\s]*$.</summary>
    [JsonPropertyName("hostUrl")]
    public string? HostUrl { get; set; }
}

/// <summary>Details about the configuration of the Confluence data source. See confluence_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationConfluenceConfiguration
{
    /// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
    [JsonPropertyName("crawlerConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationConfluenceConfigurationCrawlerConfiguration? CrawlerConfiguration { get; set; }

    /// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationConfluenceConfigurationSourceConfiguration? SourceConfiguration { get; set; }
}

/// <summary>Configuration for deletion protection on the data source. See deletion_protection_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration
{
    /// <summary>Enable or disable deletion protection for the connector. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("deletionProtectionStatus")]
    public string? DeletionProtectionStatus { get; set; }

    /// <summary>Maximum percentage of documents that a sync job can delete from your index.</summary>
    [JsonPropertyName("deletionProtectionThreshold")]
    public double? DeletionProtectionThreshold { get; set; }
}

/// <summary>Configuration for extracting audio content. See audio_extraction_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationAudioExtractionConfiguration
{
    /// <summary>Whether audio extraction is enabled. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("audioExtractionStatus")]
    public string? AudioExtractionStatus { get; set; }
}

/// <summary>Configuration for extracting image content. See image_extraction_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationImageExtractionConfiguration
{
    /// <summary>Whether image extraction is enabled. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("imageExtractionStatus")]
    public string? ImageExtractionStatus { get; set; }
}

/// <summary>Configuration for extracting video content. See video_extraction_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationVideoExtractionConfiguration
{
    /// <summary>Whether video extraction is enabled. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("videoExtractionStatus")]
    public string? VideoExtractionStatus { get; set; }
}

/// <summary>Configuration for extracting media content (images, audio, video) from documents. See media_extraction_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfiguration
{
    /// <summary>Configuration for extracting audio content. See audio_extraction_configuration block for details.</summary>
    [JsonPropertyName("audioExtractionConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationAudioExtractionConfiguration? AudioExtractionConfiguration { get; set; }

    /// <summary>Configuration for extracting image content. See image_extraction_configuration block for details.</summary>
    [JsonPropertyName("imageExtractionConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationImageExtractionConfiguration? ImageExtractionConfiguration { get; set; }

    /// <summary>Configuration for extracting video content. See video_extraction_configuration block for details.</summary>
    [JsonPropertyName("videoExtractionConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfigurationVideoExtractionConfiguration? VideoExtractionConfiguration { get; set; }
}

/// <summary>Details about the configuration of a Managed Knowledge Base connector data source. See managed_knowledge_base_connector_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfiguration
{
    /// <summary>JSON-encoded string containing the connector-specific parameters. The structure depends on the connector type (S3, SharePoint, Google Drive, etc.). See Managed Knowledge Base connector parameters for details on each connector type.</summary>
    [JsonPropertyName("connectorParameters")]
    public string? ConnectorParameters { get; set; }

    /// <summary>Configuration for deletion protection on the data source. See deletion_protection_configuration block for details.</summary>
    [JsonPropertyName("deletionProtectionConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration? DeletionProtectionConfiguration { get; set; }

    /// <summary>Configuration for extracting media content (images, audio, video) from documents. See media_extraction_configuration block for details.</summary>
    [JsonPropertyName("mediaExtractionConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationMediaExtractionConfiguration? MediaExtractionConfiguration { get; set; }
}

/// <summary>Details about the configuration of the S3 object containing the data source. See s3_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationS3Configuration
{
    /// <summary>ARN of the bucket that contains the data source.</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Bucket account owner ID for the S3 bucket.</summary>
    [JsonPropertyName("bucketOwnerAccountId")]
    public string? BucketOwnerAccountId { get; set; }

    /// <summary>List of S3 prefixes that define the object containing the data sources. For more information, see Organizing objects using prefixes.</summary>
    [JsonPropertyName("inclusionPrefixes")]
    public IList<string>? InclusionPrefixes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters
{
    /// <summary>A list of one or more exclusion regular expression patterns to exclude certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<string>? ExclusionFilters { get; set; }

    /// <summary>List of one or more inclusion regular expression patterns to include certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<string>? InclusionFilters { get; set; }

    /// <summary>The supported object type or content type of the data source.</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter
{
    /// <summary>The configuration of specific filters applied to your data source content. Minimum of 1 filter and maximum of 25 filters.</summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1DataSourceStatusAtProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters>? Filters { get; set; }
}

/// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfiguration
{
    /// <summary>The configuration of filtering certain objects or content types of the data source. See pattern_object_filter block for details.</summary>
    [JsonPropertyName("patternObjectFilter")]
    public IList<V1beta1DataSourceStatusAtProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter>? PatternObjectFilter { get; set; }

    /// <summary>Type of storage for the data source. Valid values: S3, WEB, CONFLUENCE, SALESFORCE, SHAREPOINT, CUSTOM, REDSHIFT_METADATA, MANAGED_KNOWLEDGE_BASE_CONNECTOR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfiguration
{
    /// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
    [JsonPropertyName("filterConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfigurationFilterConfiguration? FilterConfiguration { get; set; }
}

/// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationSalesforceConfigurationSourceConfiguration
{
    /// <summary>The supported authentication type to authenticate and connect to your SharePoint site. Valid values: OAUTH2_CLIENT_CREDENTIALS, OAUTH2_SHAREPOINT_APP_ONLY_CLIENT_CREDENTIALS.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>ARN of an AWS Secrets Manager secret that stores your authentication credentials for your SharePoint site. For more information on the key-value pairs that must be included in your secret, depending on your authentication type, see SharePoint connection configuration. Pattern: ^arn:aws(|-cn|-us-gov):secretsmanager:[a-z0-9-]{1,20}:([0-9]{12}|):secret:[a-zA-Z0-9!/_+=.@-]{1,512}$.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>The Salesforce host URL or instance URL. Pattern: ^https://[A-Za-z0-9][^\s]*$.</summary>
    [JsonPropertyName("hostUrl")]
    public string? HostUrl { get; set; }
}

/// <summary>Details about the configuration of the Salesforce data source. See salesforce_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationSalesforceConfiguration
{
    /// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
    [JsonPropertyName("crawlerConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationSalesforceConfigurationCrawlerConfiguration? CrawlerConfiguration { get; set; }

    /// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationSalesforceConfigurationSourceConfiguration? SourceConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters
{
    /// <summary>A list of one or more exclusion regular expression patterns to exclude certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<string>? ExclusionFilters { get; set; }

    /// <summary>List of one or more inclusion regular expression patterns to include certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<string>? InclusionFilters { get; set; }

    /// <summary>The supported object type or content type of the data source.</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter
{
    /// <summary>The configuration of specific filters applied to your data source content. Minimum of 1 filter and maximum of 25 filters.</summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1DataSourceStatusAtProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilterFilters>? Filters { get; set; }
}

/// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfiguration
{
    /// <summary>The configuration of filtering certain objects or content types of the data source. See pattern_object_filter block for details.</summary>
    [JsonPropertyName("patternObjectFilter")]
    public IList<V1beta1DataSourceStatusAtProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfigurationPatternObjectFilter>? PatternObjectFilter { get; set; }

    /// <summary>Type of storage for the data source. Valid values: S3, WEB, CONFLUENCE, SALESFORCE, SHAREPOINT, CUSTOM, REDSHIFT_METADATA, MANAGED_KNOWLEDGE_BASE_CONNECTOR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationSharePointConfigurationCrawlerConfiguration
{
    /// <summary>The Salesforce standard object configuration. See filter_configuration block for details.</summary>
    [JsonPropertyName("filterConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfiguration? FilterConfiguration { get; set; }
}

/// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationSharePointConfigurationSourceConfiguration
{
    /// <summary>The supported authentication type to authenticate and connect to your SharePoint site. Valid values: OAUTH2_CLIENT_CREDENTIALS, OAUTH2_SHAREPOINT_APP_ONLY_CLIENT_CREDENTIALS.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>ARN of an AWS Secrets Manager secret that stores your authentication credentials for your SharePoint site. For more information on the key-value pairs that must be included in your secret, depending on your authentication type, see SharePoint connection configuration. Pattern: ^arn:aws(|-cn|-us-gov):secretsmanager:[a-z0-9-]{1,20}:([0-9]{12}|):secret:[a-zA-Z0-9!/_+=.@-]{1,512}$.</summary>
    [JsonPropertyName("credentialsSecretArn")]
    public string? CredentialsSecretArn { get; set; }

    /// <summary>The domain of your SharePoint instance or site URL/URLs.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The supported host type, whether online/cloud or server/on-premises. Valid values: ONLINE.</summary>
    [JsonPropertyName("hostType")]
    public string? HostType { get; set; }

    /// <summary>A list of one or more SharePoint site URLs.</summary>
    [JsonPropertyName("siteUrls")]
    public IList<string>? SiteUrls { get; set; }

    /// <summary>The identifier of your Microsoft 365 tenant.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Details about the configuration of the SharePoint data source. See share_point_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationSharePointConfiguration
{
    /// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
    [JsonPropertyName("crawlerConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationSharePointConfigurationCrawlerConfiguration? CrawlerConfiguration { get; set; }

    /// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationSharePointConfigurationSourceConfiguration? SourceConfiguration { get; set; }
}

/// <summary>Configuration of crawl limits for the web URLs. See crawler_limits block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationWebConfigurationCrawlerConfigurationCrawlerLimits
{
    /// <summary>Max number of web pages crawled from your source URLs, up to 25,000 pages.</summary>
    [JsonPropertyName("maxPages")]
    public double? MaxPages { get; set; }

    /// <summary>Max rate at which pages are crawled, up to 300 per minute per host.</summary>
    [JsonPropertyName("rateLimit")]
    public double? RateLimit { get; set; }
}

/// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationWebConfigurationCrawlerConfiguration
{
    /// <summary>Configuration of crawl limits for the web URLs. See crawler_limits block for details.</summary>
    [JsonPropertyName("crawlerLimits")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationWebConfigurationCrawlerConfigurationCrawlerLimits? CrawlerLimits { get; set; }

    /// <summary>A list of one or more exclusion regular expression patterns to exclude certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("exclusionFilters")]
    public IList<string>? ExclusionFilters { get; set; }

    /// <summary>List of one or more inclusion regular expression patterns to include certain object types that adhere to the pattern.</summary>
    [JsonPropertyName("inclusionFilters")]
    public IList<string>? InclusionFilters { get; set; }

    /// <summary>Scope of what is crawled for your URLs.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>String used for identifying the crawler or a bot when it accesses a web server. Default value is bedrockbot_UUID.</summary>
    [JsonPropertyName("userAgent")]
    public string? UserAgent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfigurationSeedUrls
{
    /// <summary>Seed or starting point URL. Must match the pattern ^https?://[A-Za-z0-9][^\s]*$.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>The URL configuration of your web data source. See url_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfiguration
{
    /// <summary>List of one or more seed URLs to crawl. See seed_urls block for details.</summary>
    [JsonPropertyName("seedUrls")]
    public IList<V1beta1DataSourceStatusAtProviderDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfigurationSeedUrls>? SeedUrls { get; set; }
}

/// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationWebConfigurationSourceConfiguration
{
    /// <summary>The URL configuration of your web data source. See url_configuration block for details.</summary>
    [JsonPropertyName("urlConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfiguration? UrlConfiguration { get; set; }
}

/// <summary>Details about the configuration of the web data source. See web_data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfigurationWebConfiguration
{
    /// <summary>Configuration for web content. See crawler_configuration block for details.</summary>
    [JsonPropertyName("crawlerConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationWebConfigurationCrawlerConfiguration? CrawlerConfiguration { get; set; }

    /// <summary>Endpoint information to connect to your web data source. See source_configuration block for details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationWebConfigurationSourceConfiguration? SourceConfiguration { get; set; }
}

/// <summary>Details about how the data source is stored. See data_source_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderDataSourceConfiguration
{
    /// <summary>Details about the configuration of the Confluence data source. See confluence_data_source_configuration block for details.</summary>
    [JsonPropertyName("confluenceConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationConfluenceConfiguration? ConfluenceConfiguration { get; set; }

    /// <summary>Details about the configuration of a Managed Knowledge Base connector data source. See managed_knowledge_base_connector_configuration block for details.</summary>
    [JsonPropertyName("managedKnowledgeBaseConnectorConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationManagedKnowledgeBaseConnectorConfiguration? ManagedKnowledgeBaseConnectorConfiguration { get; set; }

    /// <summary>Details about the configuration of the S3 object containing the data source. See s3_data_source_configuration block for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>Details about the configuration of the Salesforce data source. See salesforce_data_source_configuration block for details.</summary>
    [JsonPropertyName("salesforceConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationSalesforceConfiguration? SalesforceConfiguration { get; set; }

    /// <summary>Details about the configuration of the SharePoint data source. See share_point_data_source_configuration block for details.</summary>
    [JsonPropertyName("sharePointConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationSharePointConfiguration? SharePointConfiguration { get; set; }

    /// <summary>Type of storage for the data source. Valid values: S3, WEB, CONFLUENCE, SALESFORCE, SHAREPOINT, CUSTOM, REDSHIFT_METADATA, MANAGED_KNOWLEDGE_BASE_CONNECTOR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Details about the configuration of the web data source. See web_data_source_configuration block for details.</summary>
    [JsonPropertyName("webConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfigurationWebConfiguration? WebConfiguration { get; set; }
}

/// <summary>Details about the configuration of the server-side encryption. See server_side_encryption_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderServerSideEncryptionConfiguration
{
    /// <summary>ARN of the AWS KMS key used to encrypt the resource.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

/// <summary>Configurations for when you choose fixed-size chunking. Requires chunking_strategy as FIXED_SIZE. See fixed_size_chunking_configuration for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationChunkingConfigurationFixedSizeChunkingConfiguration
{
    /// <summary>Maximum number of tokens to include in a chunk.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>Percentage of overlap between adjacent chunks of a data source.</summary>
    [JsonPropertyName("overlapPercentage")]
    public double? OverlapPercentage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationChunkingConfigurationHierarchicalChunkingConfigurationLevelConfiguration
{
    /// <summary>Maximum number of tokens to include in a chunk.</summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }
}

/// <summary>Configurations for when you choose hierarchical chunking. Requires chunking_strategy as HIERARCHICAL. See hierarchical_chunking_configuration for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationChunkingConfigurationHierarchicalChunkingConfiguration
{
    /// <summary>Maximum number of tokens to include in a chunk. Must contain two level_configurations. See level_configurations for details.</summary>
    [JsonPropertyName("levelConfiguration")]
    public IList<V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationChunkingConfigurationHierarchicalChunkingConfigurationLevelConfiguration>? LevelConfiguration { get; set; }

    /// <summary>The number of tokens to repeat across chunks in the same layer.</summary>
    [JsonPropertyName("overlapTokens")]
    public double? OverlapTokens { get; set; }
}

/// <summary>Configurations for when you choose semantic chunking. Requires chunking_strategy as SEMANTIC. See semantic_chunking_configuration for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationChunkingConfigurationSemanticChunkingConfiguration
{
    /// <summary>The dissimilarity threshold for splitting chunks.</summary>
    [JsonPropertyName("breakpointPercentileThreshold")]
    public double? BreakpointPercentileThreshold { get; set; }

    /// <summary>The buffer size.</summary>
    [JsonPropertyName("bufferSize")]
    public double? BufferSize { get; set; }

    /// <summary>The maximum number of tokens a chunk can contain.</summary>
    [JsonPropertyName("maxToken")]
    public double? MaxToken { get; set; }
}

/// <summary>Details about how to chunk the documents in the data source. A chunk refers to an excerpt from a data source that is returned when the knowledge base that it belongs to is queried. See chunking_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationChunkingConfiguration
{
    /// <summary>Option for chunking your source data, either in fixed-sized chunks or as one chunk. Valid values: FIXED_SIZE, HIERARCHICAL, SEMANTIC, NONE.</summary>
    [JsonPropertyName("chunkingStrategy")]
    public string? ChunkingStrategy { get; set; }

    /// <summary>Configurations for when you choose fixed-size chunking. Requires chunking_strategy as FIXED_SIZE. See fixed_size_chunking_configuration for details.</summary>
    [JsonPropertyName("fixedSizeChunkingConfiguration")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationChunkingConfigurationFixedSizeChunkingConfiguration? FixedSizeChunkingConfiguration { get; set; }

    /// <summary>Configurations for when you choose hierarchical chunking. Requires chunking_strategy as HIERARCHICAL. See hierarchical_chunking_configuration for details.</summary>
    [JsonPropertyName("hierarchicalChunkingConfiguration")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationChunkingConfigurationHierarchicalChunkingConfiguration? HierarchicalChunkingConfiguration { get; set; }

    /// <summary>Configurations for when you choose semantic chunking. Requires chunking_strategy as SEMANTIC. See semantic_chunking_configuration for details.</summary>
    [JsonPropertyName("semanticChunkingConfiguration")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationChunkingConfigurationSemanticChunkingConfiguration? SemanticChunkingConfiguration { get; set; }
}

/// <summary>Configuration block for intermedia S3 storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorageS3Location
{
    /// <summary>S3 URI for intermediate storage.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>The intermediate storage for custom transformation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorage
{
    /// <summary>Configuration block for intermedia S3 storage.</summary>
    [JsonPropertyName("s3Location")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorageS3Location? S3Location { get; set; }
}

/// <summary>The configuration of the lambda function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfiguration
{
    /// <summary>The ARN of the lambda to use for custom transformation.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }
}

/// <summary>The lambda function that processes documents.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunction
{
    /// <summary>The configuration of the lambda function.</summary>
    [JsonPropertyName("transformationLambdaConfiguration")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunctionTransformationLambdaConfiguration? TransformationLambdaConfiguration { get; set; }
}

/// <summary>A custom processing step for documents moving through the data source ingestion pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformation
{
    /// <summary>When the service applies the transformation. Currently only POST_CHUNKING is supported.</summary>
    [JsonPropertyName("stepToApply")]
    public string? StepToApply { get; set; }

    /// <summary>The lambda function that processes documents.</summary>
    [JsonPropertyName("transformationFunction")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunction? TransformationFunction { get; set; }
}

/// <summary>Configuration for custom transformation of data source documents.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationCustomTransformationConfiguration
{
    /// <summary>The intermediate storage for custom transformation.</summary>
    [JsonPropertyName("intermediateStorage")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorage? IntermediateStorage { get; set; }

    /// <summary>A custom processing step for documents moving through the data source ingestion pipeline.</summary>
    [JsonPropertyName("transformation")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationCustomTransformationConfigurationTransformation? Transformation { get; set; }
}

/// <summary>Settings for using Amazon Bedrock Data Automation to parse documents. See bedrock_data_automation_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration
{
    /// <summary>Specifies whether to enable parsing of multimodal data, including both text and images. Valid value: MULTIMODAL.</summary>
    [JsonPropertyName("parsingModality")]
    public string? ParsingModality { get; set; }
}

/// <summary>Instructions for interpreting the contents of the document. See parsing_prompt block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationParsingConfigurationBedrockFoundationModelConfigurationParsingPrompt
{
    /// <summary>Instructions for interpreting the contents of the document.</summary>
    [JsonPropertyName("parsingPromptString")]
    public string? ParsingPromptString { get; set; }
}

/// <summary>Settings for a foundation model used to parse documents in a data source. See bedrock_foundation_model_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationParsingConfigurationBedrockFoundationModelConfiguration
{
    /// <summary>The ARN of the model used to parse documents</summary>
    [JsonPropertyName("modelArn")]
    public string? ModelArn { get; set; }

    /// <summary>Specifies whether to enable parsing of multimodal data, including both text and images. Valid value: MULTIMODAL.</summary>
    [JsonPropertyName("parsingModality")]
    public string? ParsingModality { get; set; }

    /// <summary>Instructions for interpreting the contents of the document. See parsing_prompt block for details.</summary>
    [JsonPropertyName("parsingPrompt")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationParsingConfigurationBedrockFoundationModelConfigurationParsingPrompt? ParsingPrompt { get; set; }
}

/// <summary>Configuration for custom parsing of data source documents. See parsing_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationParsingConfiguration
{
    /// <summary>Settings for using Amazon Bedrock Data Automation to parse documents. See bedrock_data_automation_configuration block for details.</summary>
    [JsonPropertyName("bedrockDataAutomationConfiguration")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationParsingConfigurationBedrockDataAutomationConfiguration? BedrockDataAutomationConfiguration { get; set; }

    /// <summary>Settings for a foundation model used to parse documents in a data source. See bedrock_foundation_model_configuration block for details.</summary>
    [JsonPropertyName("bedrockFoundationModelConfiguration")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationParsingConfigurationBedrockFoundationModelConfiguration? BedrockFoundationModelConfiguration { get; set; }

    /// <summary>The parsing strategy to use. Valid values: BEDROCK_FOUNDATION_MODEL, BEDROCK_DATA_AUTOMATION.</summary>
    [JsonPropertyName("parsingStrategy")]
    public string? ParsingStrategy { get; set; }
}

/// <summary>Details about the configuration of the server-side encryption. See vector_ingestion_configuration block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProviderVectorIngestionConfiguration
{
    /// <summary>Details about how to chunk the documents in the data source. A chunk refers to an excerpt from a data source that is returned when the knowledge base that it belongs to is queried. See chunking_configuration block for details.</summary>
    [JsonPropertyName("chunkingConfiguration")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationChunkingConfiguration? ChunkingConfiguration { get; set; }

    /// <summary>Configuration for custom transformation of data source documents.</summary>
    [JsonPropertyName("customTransformationConfiguration")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationCustomTransformationConfiguration? CustomTransformationConfiguration { get; set; }

    /// <summary>Configuration for custom parsing of data source documents. See parsing_configuration block for details.</summary>
    [JsonPropertyName("parsingConfiguration")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfigurationParsingConfiguration? ParsingConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusAtProvider
{
    /// <summary>Data deletion policy for a data source. Valid values: RETAIN, DELETE.</summary>
    [JsonPropertyName("dataDeletionPolicy")]
    public string? DataDeletionPolicy { get; set; }

    /// <summary>Details about how the data source is stored. See data_source_configuration block for details.</summary>
    [JsonPropertyName("dataSourceConfiguration")]
    public V1beta1DataSourceStatusAtProviderDataSourceConfiguration? DataSourceConfiguration { get; set; }

    /// <summary>Unique identifier of the data source.</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>Description of the data source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Identifier of the data source which consists of the data source ID and the knowledge base ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Unique identifier of the knowledge base to which the data source belongs.</summary>
    [JsonPropertyName("knowledgeBaseId")]
    public string? KnowledgeBaseId { get; set; }

    /// <summary>Name of the data source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Details about the configuration of the server-side encryption. See server_side_encryption_configuration block for details.</summary>
    [JsonPropertyName("serverSideEncryptionConfiguration")]
    public V1beta1DataSourceStatusAtProviderServerSideEncryptionConfiguration? ServerSideEncryptionConfiguration { get; set; }

    /// <summary>Details about the configuration of the server-side encryption. See vector_ingestion_configuration block for details.</summary>
    [JsonPropertyName("vectorIngestionConfiguration")]
    public V1beta1DataSourceStatusAtProviderVectorIngestionConfiguration? VectorIngestionConfiguration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatusConditions
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

/// <summary>DataSourceStatus defines the observed state of DataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSourceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1DataSourceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataSourceStatusConditions>? Conditions { get; set; }

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

/// <summary>DataSource is the Schema for the DataSources API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataSource : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataSourceSpec>, IStatus<V1beta1DataSourceStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataSource";
    public const string KubeGroup = "bedrockagent.aws.upbound.io";
    public const string KubePluralName = "datasources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagent.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataSource";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataSourceSpec defines the desired state of DataSource</summary>
    [JsonPropertyName("spec")]
    public required V1beta1DataSourceSpec Spec { get; set; }

    /// <summary>DataSourceStatus defines the observed state of DataSource.</summary>
    [JsonPropertyName("status")]
    public V1beta1DataSourceStatus? Status { get; set; }
}