#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kendra.aws.upbound.io;
/// <summary>DataSource is the Schema for the DataSources API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DataSourceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2DataSource>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DataSourceList";
    public const string KubeGroup = "kendra.aws.upbound.io";
    public const string KubePluralName = "datasources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kendra.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataSourceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2DataSource objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2DataSource> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecDeletionPolicyEnum>))]
public enum V1beta2DataSourceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A block that provides the path to the S3 bucket that contains the user context filtering files for the data source. For the format of the file, see Access control for S3 data sources. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationAccessControlListConfiguration
{
    /// <summary>Path to the AWS S3 bucket that contains the ACL files.</summary>
    [JsonPropertyName("keyPath")]
    public string? KeyPath { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelector
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
    public V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A block that defines the Document metadata files that contain information such as the document access control information, source URI, document author, and custom attributes. Each metadata file contains metadata about a single document. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationDocumentsMetadataConfiguration
{
    /// <summary>A prefix used to filter metadata configuration files in the AWS S3 bucket. The S3 bucket might contain multiple metadata files. Use s3_prefix to include only the desired metadata files.</summary>
    [JsonPropertyName("s3Prefix")]
    public string? S3Prefix { get; set; }
}

/// <summary>(Deprecated, Required if type is set to S3) A block that provides the configuration information to connect to an Amazon S3 bucket as your data source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationS3Configuration
{
    /// <summary>A block that provides the path to the S3 bucket that contains the user context filtering files for the data source. For the format of the file, see Access control for S3 data sources. Detailed below.</summary>
    [JsonPropertyName("accessControlListConfiguration")]
    public V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationAccessControlListConfiguration? AccessControlListConfiguration { get; set; }

    /// <summary>The name of the bucket that contains the documents.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>A block that defines the Document metadata files that contain information such as the document access control information, source URI, document author, and custom attributes. Each metadata file contains metadata about a single document. Detailed below.</summary>
    [JsonPropertyName("documentsMetadataConfiguration")]
    public V1beta2DataSourceSpecForProviderConfigurationS3ConfigurationDocumentsMetadataConfiguration? DocumentsMetadataConfiguration { get; set; }

    /// <summary>A list of glob patterns for documents that should not be indexed. If a document that matches an inclusion prefix or inclusion pattern also matches an exclusion pattern, the document is not indexed. Refer to Exclusion Patterns for more examples.</summary>
    [JsonPropertyName("exclusionPatterns")]
    public IList<string>? ExclusionPatterns { get; set; }

    /// <summary>A list of glob patterns for documents that should be indexed. If a document that matches an inclusion pattern also matches an exclusion pattern, the document is not indexed. Refer to Inclusion Patterns for more examples.</summary>
    [JsonPropertyName("inclusionPatterns")]
    public IList<string>? InclusionPatterns { get; set; }

    /// <summary>A list of S3 prefixes for the documents that should be included in the index.</summary>
    [JsonPropertyName("inclusionPrefixes")]
    public IList<string>? InclusionPrefixes { get; set; }
}

/// <summary>A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationTemplateConfiguration
{
    /// <summary>JSON string containing a data source template schema.</summary>
    [JsonPropertyName("template")]
    public string? Template { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelector
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
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication
{
    /// <summary>Your secret ARN, which you can create in AWS Secrets Manager. The credentials are optional. You use a secret if web proxy credentials are required to connect to a website host. Amazon Kendra currently support basic authentication to connect to a web proxy server. The secret stores your credentials.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsRef")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRef? CredentialsRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsSelector")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelector? CredentialsSelector { get; set; }

    /// <summary>The name of the website host you want to connect to via a web proxy server. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot;.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port number of the website host you want to connect to via a web proxy server. For example, the port for https://a.example.com/page1.html is 443, the standard port for HTTPS.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>A block with the configuration information required to connect to websites using authentication. You can connect to websites using basic authentication of user name and password. You use a secret in AWS Secrets Manager to store your authentication credentials. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot; and the port is 443, the standard port for HTTPS. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfiguration
{
    /// <summary>The list of configuration information that&apos;s required to connect to and crawl a website host using basic authentication credentials. The list includes the name and port number of the website host. Detailed below.</summary>
    [JsonPropertyName("basicAuthentication")]
    public IList<V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication>? BasicAuthentication { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelector
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
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration information required to connect to your internal websites via a web proxy. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot; and the port is 443, the standard port for HTTPS. Web proxy credentials are optional and you can use them to connect to a web proxy server that requires basic authentication. To store web proxy credentials, you use a secret in AWS Secrets Manager. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfiguration
{
    /// <summary>Your secret ARN, which you can create in AWS Secrets Manager. The credentials are optional. You use a secret if web proxy credentials are required to connect to a website host. Amazon Kendra currently support basic authentication to connect to a web proxy server. The secret stores your credentials.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsRef")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRef? CredentialsRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsSelector")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelector? CredentialsSelector { get; set; }

    /// <summary>The name of the website host you want to connect to via a web proxy server. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot;.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port number of the website host you want to connect to via a web proxy server. For example, the port for https://a.example.com/page1.html is 443, the standard port for HTTPS.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>A block that specifies the configuration of the seed or starting point URLs of the websites you want to crawl. You can choose to crawl only the website host names, or the website host names with subdomains, or the website host names with subdomains and other domains that the webpages link to. You can list up to 100 seed URLs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration
{
    /// <summary>The list of seed or starting point URLs of the websites you want to crawl. The list can include a maximum of 100 seed URLs. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("seedUrls")]
    public IList<string>? SeedUrls { get; set; }

    /// <summary>The default mode is set to HOST_ONLY. You can choose one of the following modes:</summary>
    [JsonPropertyName("webCrawlerMode")]
    public string? WebCrawlerMode { get; set; }
}

/// <summary>A block that specifies the configuration of the sitemap URLs of the websites you want to crawl. Only URLs belonging to the same website host names are crawled. You can list up to 3 sitemap URLs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration
{
    /// <summary>The list of sitemap URLs of the websites you want to crawl. The list can include a maximum of 3 sitemap URLs.</summary>
    [JsonPropertyName("siteMaps")]
    public IList<string>? SiteMaps { get; set; }
}

/// <summary>A block that specifies the seed or starting point URLs of the websites or the sitemap URLs of the websites you want to crawl. You can include website subdomains. You can list up to 100 seed URLs and up to 3 sitemap URLs. You can only crawl websites that use the secure communication protocol, Hypertext Transfer Protocol Secure (HTTPS). If you receive an error when crawling a website, it could be that the website is blocked from crawling. When selecting websites to index, you must adhere to the Amazon Acceptable Use Policy and all other Amazon terms. Remember that you must only use Amazon Kendra Web Crawler to index your own webpages, or webpages that you have authorization to index. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationUrls
{
    /// <summary>A block that specifies the configuration of the seed or starting point URLs of the websites you want to crawl. You can choose to crawl only the website host names, or the website host names with subdomains, or the website host names with subdomains and other domains that the webpages link to. You can list up to 100 seed URLs. Detailed below.</summary>
    [JsonPropertyName("seedUrlConfiguration")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration? SeedUrlConfiguration { get; set; }

    /// <summary>A block that specifies the configuration of the sitemap URLs of the websites you want to crawl. Only URLs belonging to the same website host names are crawled. You can list up to 3 sitemap URLs. Detailed below.</summary>
    [JsonPropertyName("siteMapsConfiguration")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration? SiteMapsConfiguration { get; set; }
}

/// <summary>(Deprecated, Required if type is set to WEBCRAWLER) A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfiguration
{
    /// <summary>A block with the configuration information required to connect to websites using authentication. You can connect to websites using basic authentication of user name and password. You use a secret in AWS Secrets Manager to store your authentication credentials. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot; and the port is 443, the standard port for HTTPS. Detailed below.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>Specifies the number of levels in a website that you want to crawl. The first level begins from the website seed or starting point URL. For example, if a website has 3 levels - index level (i.e. seed in this example), sections level, and subsections level - and you are only interested in crawling information up to the sections level (i.e. levels 0-1), you can set your depth to 1. The default crawl depth is set to 2. Minimum value of 0. Maximum value of 10.</summary>
    [JsonPropertyName("crawlDepth")]
    public double? CrawlDepth { get; set; }

    /// <summary>The maximum size (in MB) of a webpage or attachment to crawl. Files larger than this size (in MB) are skipped/not crawled. The default maximum size of a webpage or attachment is set to 50 MB. Minimum value of 1.0e-06. Maximum value of 50.</summary>
    [JsonPropertyName("maxContentSizePerPageInMegaBytes")]
    public double? MaxContentSizePerPageInMegaBytes { get; set; }

    /// <summary>The maximum number of URLs on a webpage to include when crawling a website. This number is per webpage. As a website’s webpages are crawled, any URLs the webpages link to are also crawled. URLs on a webpage are crawled in order of appearance. The default maximum links per page is 100. Minimum value of 1. Maximum value of 1000.</summary>
    [JsonPropertyName("maxLinksPerPage")]
    public double? MaxLinksPerPage { get; set; }

    /// <summary>The maximum number of URLs crawled per website host per minute. The default maximum number of URLs crawled per website host per minute is 300. Minimum value of 1. Maximum value of 300.</summary>
    [JsonPropertyName("maxUrlsPerMinuteCrawlRate")]
    public double? MaxUrlsPerMinuteCrawlRate { get; set; }

    /// <summary>Configuration information required to connect to your internal websites via a web proxy. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot; and the port is 443, the standard port for HTTPS. Web proxy credentials are optional and you can use them to connect to a web proxy server that requires basic authentication. To store web proxy credentials, you use a secret in AWS Secrets Manager. Detailed below.</summary>
    [JsonPropertyName("proxyConfiguration")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationProxyConfiguration? ProxyConfiguration { get; set; }

    /// <summary>A list of regular expression patterns to exclude certain URLs to crawl. URLs that match the patterns are excluded from the index. URLs that don&apos;t match the patterns are included in the index. If a URL matches both an inclusion and exclusion pattern, the exclusion pattern takes precedence and the URL file isn&apos;t included in the index. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 150.</summary>
    [JsonPropertyName("urlExclusionPatterns")]
    public IList<string>? UrlExclusionPatterns { get; set; }

    /// <summary>A list of regular expression patterns to include certain URLs to crawl. URLs that match the patterns are included in the index. URLs that don&apos;t match the patterns are excluded from the index. If a URL matches both an inclusion and exclusion pattern, the exclusion pattern takes precedence and the URL file isn&apos;t included in the index. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 150.</summary>
    [JsonPropertyName("urlInclusionPatterns")]
    public IList<string>? UrlInclusionPatterns { get; set; }

    /// <summary>A block that specifies the seed or starting point URLs of the websites or the sitemap URLs of the websites you want to crawl. You can include website subdomains. You can list up to 100 seed URLs and up to 3 sitemap URLs. You can only crawl websites that use the secure communication protocol, Hypertext Transfer Protocol Secure (HTTPS). If you receive an error when crawling a website, it could be that the website is blocked from crawling. When selecting websites to index, you must adhere to the Amazon Acceptable Use Policy and all other Amazon terms. Remember that you must only use Amazon Kendra Web Crawler to index your own webpages, or webpages that you have authorization to index. Detailed below.</summary>
    [JsonPropertyName("urls")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfigurationUrls? Urls { get; set; }
}

/// <summary>A block with the configuration information to connect to your Data Source repository. You can&apos;t specify the configuration block when the type parameter is set to CUSTOM. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderConfiguration
{
    /// <summary>(Deprecated, Required if type is set to S3) A block that provides the configuration information to connect to an Amazon S3 bucket as your data source. Detailed below.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta2DataSourceSpecForProviderConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
    [JsonPropertyName("templateConfiguration")]
    public V1beta2DataSourceSpecForProviderConfigurationTemplateConfiguration? TemplateConfiguration { get; set; }

    /// <summary>(Deprecated, Required if type is set to WEBCRAWLER) A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
    [JsonPropertyName("webCrawlerConfiguration")]
    public V1beta2DataSourceSpecForProviderConfigurationWebCrawlerConfiguration? WebCrawlerConfiguration { get; set; }
}

/// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Configuration of the condition used for the target document attribute or metadata field when ingesting documents into Amazon Kendra. See condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>The target value you want to create for the target attribute. For example, &apos;Finance&apos; could be the target value for the target attribute key &apos;Department&apos;. See target_document_attribute_value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Configuration of the target document attribute or metadata field when ingesting documents into Amazon Kendra. You can also include a value. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget
{
    /// <summary>The identifier of the target document attribute or metadata field. For example, &apos;Department&apos; could be an identifier for the target attribute or metadata field that includes the department names associated with the documents.</summary>
    [JsonPropertyName("targetDocumentAttributeKey")]
    public string? TargetDocumentAttributeKey { get; set; }

    /// <summary>The target value you want to create for the target attribute. For example, &apos;Finance&apos; could be the target value for the target attribute key &apos;Department&apos;. See target_document_attribute_value.</summary>
    [JsonPropertyName("targetDocumentAttributeValue")]
    public V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue? TargetDocumentAttributeValue { get; set; }

    /// <summary>TRUE to delete the existing target value for your specified target attribute key. You cannot create a target value and set this to TRUE. To create a target value (TargetDocumentAttributeValue), set this to FALSE.</summary>
    [JsonPropertyName("targetDocumentAttributeValueDeletion")]
    public bool? TargetDocumentAttributeValueDeletion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurations
{
    /// <summary>Configuration of the condition used for the target document attribute or metadata field when ingesting documents into Amazon Kendra. See condition.</summary>
    [JsonPropertyName("condition")]
    public V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition? Condition { get; set; }

    /// <summary>TRUE to delete content if the condition used for the target attribute is met.</summary>
    [JsonPropertyName("documentContentDeletion")]
    public bool? DocumentContentDeletion { get; set; }

    /// <summary>Configuration of the target document attribute or metadata field when ingesting documents into Amazon Kendra. You can also include a value. Detailed below.</summary>
    [JsonPropertyName("target")]
    public V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget? Target { get; set; }
}

/// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationConditionConditionOnValue? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>A block that specifies the configuration information for invoking a Lambda function in AWS Lambda on the structured documents with their metadata and text extracted. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration
{
    /// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
    [JsonPropertyName("invocationCondition")]
    public V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition? InvocationCondition { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a Lambda Function that can manipulate your document metadata fields or attributes and content.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Stores the original, raw documents or the structured, parsed documents before and after altering them. For more information, see Data contracts for Lambda functions.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }
}

/// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationConditionConditionOnValue? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>Configuration information for invoking a Lambda function in AWS Lambda on the original or raw documents before extracting their metadata and text. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration
{
    /// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
    [JsonPropertyName("invocationCondition")]
    public V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationCondition? InvocationCondition { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a Lambda Function that can manipulate your document metadata fields or attributes and content.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Stores the original, raw documents or the structured, parsed documents before and after altering them. For more information, see Data contracts for Lambda functions.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }
}

/// <summary>A block with the configuration information for altering document metadata and content during the document ingestion process. For more information on how to create, modify and delete document metadata, or make other content alterations when you ingest documents into Amazon Kendra, see Customizing document metadata during the ingestion process. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfiguration
{
    /// <summary>Configuration information to alter document attributes or metadata fields and content when ingesting documents into Amazon Kendra. Minimum number of 0 items. Maximum number of 100 items. Detailed below.</summary>
    [JsonPropertyName("inlineConfigurations")]
    public IList<V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationInlineConfigurations>? InlineConfigurations { get; set; }

    /// <summary>A block that specifies the configuration information for invoking a Lambda function in AWS Lambda on the structured documents with their metadata and text extracted. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
    [JsonPropertyName("postExtractionHookConfiguration")]
    public V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration? PostExtractionHookConfiguration { get; set; }

    /// <summary>Configuration information for invoking a Lambda function in AWS Lambda on the original or raw documents before extracting their metadata and text. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
    [JsonPropertyName("preExtractionHookConfiguration")]
    public V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration? PreExtractionHookConfiguration { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a role with permission to run pre_extraction_hook_configuration and post_extraction_hook_configuration for altering document metadata and content during the document ingestion process. For more information, see IAM roles for Amazon Kendra.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderIndexIdRefPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecForProviderIndexIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderIndexIdRefPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecForProviderIndexIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderIndexIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecForProviderIndexIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecForProviderIndexIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Index in kendra to populate indexId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderIndexIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSourceSpecForProviderIndexIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderIndexIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecForProviderIndexIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderIndexIdSelectorPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecForProviderIndexIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderIndexIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecForProviderIndexIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecForProviderIndexIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Index in kendra to populate indexId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderIndexIdSelector
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
    public V1beta2DataSourceSpecForProviderIndexIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecForProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecForProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecForProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecForProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSourceSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecForProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecForProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecForProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecForProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecForProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProviderRoleArnSelector
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
    public V1beta2DataSourceSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecForProvider
{
    /// <summary>A block with the configuration information to connect to your Data Source repository. You can&apos;t specify the configuration block when the type parameter is set to CUSTOM. Detailed below.</summary>
    [JsonPropertyName("configuration")]
    public V1beta2DataSourceSpecForProviderConfiguration? Configuration { get; set; }

    /// <summary>A block with the configuration information for altering document metadata and content during the document ingestion process. For more information on how to create, modify and delete document metadata, or make other content alterations when you ingest documents into Amazon Kendra, see Customizing document metadata during the ingestion process. Detailed below.</summary>
    [JsonPropertyName("customDocumentEnrichmentConfiguration")]
    public V1beta2DataSourceSpecForProviderCustomDocumentEnrichmentConfiguration? CustomDocumentEnrichmentConfiguration { get; set; }

    /// <summary>A description for the Data Source connector.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The identifier of the index for your Amazon Kendra data source.</summary>
    [JsonPropertyName("indexId")]
    public string? IndexId { get; set; }

    /// <summary>Reference to a Index in kendra to populate indexId.</summary>
    [JsonPropertyName("indexIdRef")]
    public V1beta2DataSourceSpecForProviderIndexIdRef? IndexIdRef { get; set; }

    /// <summary>Selector for a Index in kendra to populate indexId.</summary>
    [JsonPropertyName("indexIdSelector")]
    public V1beta2DataSourceSpecForProviderIndexIdSelector? IndexIdSelector { get; set; }

    /// <summary>The code for a language. This allows you to support a language for all documents when creating the Data Source connector. English is supported by default. For more information on supported languages, including their codes, see Adding documents in languages other than English.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>A name for your data source connector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a role with permission to access the data source connector. For more information, see IAM roles for Amazon Kendra. You can&apos;t specify the role_arn parameter when the type parameter is set to CUSTOM. The role_arn parameter is required for all other data sources.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2DataSourceSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2DataSourceSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Sets the frequency for Amazon Kendra to check the documents in your Data Source repository and update the index. If you don&apos;t set a schedule Amazon Kendra will not periodically update the index. You can call the StartDataSourceSyncJob API to update the index.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of data source repository. For an updated list of values, refer to Valid Values for Type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A block that provides the path to the S3 bucket that contains the user context filtering files for the data source. For the format of the file, see Access control for S3 data sources. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationAccessControlListConfiguration
{
    /// <summary>Path to the AWS S3 bucket that contains the ACL files.</summary>
    [JsonPropertyName("keyPath")]
    public string? KeyPath { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelector
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
    public V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A block that defines the Document metadata files that contain information such as the document access control information, source URI, document author, and custom attributes. Each metadata file contains metadata about a single document. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationDocumentsMetadataConfiguration
{
    /// <summary>A prefix used to filter metadata configuration files in the AWS S3 bucket. The S3 bucket might contain multiple metadata files. Use s3_prefix to include only the desired metadata files.</summary>
    [JsonPropertyName("s3Prefix")]
    public string? S3Prefix { get; set; }
}

/// <summary>(Deprecated, Required if type is set to S3) A block that provides the configuration information to connect to an Amazon S3 bucket as your data source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationS3Configuration
{
    /// <summary>A block that provides the path to the S3 bucket that contains the user context filtering files for the data source. For the format of the file, see Access control for S3 data sources. Detailed below.</summary>
    [JsonPropertyName("accessControlListConfiguration")]
    public V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationAccessControlListConfiguration? AccessControlListConfiguration { get; set; }

    /// <summary>The name of the bucket that contains the documents.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>A block that defines the Document metadata files that contain information such as the document access control information, source URI, document author, and custom attributes. Each metadata file contains metadata about a single document. Detailed below.</summary>
    [JsonPropertyName("documentsMetadataConfiguration")]
    public V1beta2DataSourceSpecInitProviderConfigurationS3ConfigurationDocumentsMetadataConfiguration? DocumentsMetadataConfiguration { get; set; }

    /// <summary>A list of glob patterns for documents that should not be indexed. If a document that matches an inclusion prefix or inclusion pattern also matches an exclusion pattern, the document is not indexed. Refer to Exclusion Patterns for more examples.</summary>
    [JsonPropertyName("exclusionPatterns")]
    public IList<string>? ExclusionPatterns { get; set; }

    /// <summary>A list of glob patterns for documents that should be indexed. If a document that matches an inclusion pattern also matches an exclusion pattern, the document is not indexed. Refer to Inclusion Patterns for more examples.</summary>
    [JsonPropertyName("inclusionPatterns")]
    public IList<string>? InclusionPatterns { get; set; }

    /// <summary>A list of S3 prefixes for the documents that should be included in the index.</summary>
    [JsonPropertyName("inclusionPrefixes")]
    public IList<string>? InclusionPrefixes { get; set; }
}

/// <summary>A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationTemplateConfiguration
{
    /// <summary>JSON string containing a data source template schema.</summary>
    [JsonPropertyName("template")]
    public string? Template { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelector
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
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication
{
    /// <summary>Your secret ARN, which you can create in AWS Secrets Manager. The credentials are optional. You use a secret if web proxy credentials are required to connect to a website host. Amazon Kendra currently support basic authentication to connect to a web proxy server. The secret stores your credentials.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsRef")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsRef? CredentialsRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsSelector")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthenticationCredentialsSelector? CredentialsSelector { get; set; }

    /// <summary>The name of the website host you want to connect to via a web proxy server. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot;.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port number of the website host you want to connect to via a web proxy server. For example, the port for https://a.example.com/page1.html is 443, the standard port for HTTPS.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>A block with the configuration information required to connect to websites using authentication. You can connect to websites using basic authentication of user name and password. You use a secret in AWS Secrets Manager to store your authentication credentials. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot; and the port is 443, the standard port for HTTPS. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfiguration
{
    /// <summary>The list of configuration information that&apos;s required to connect to and crawl a website host using basic authentication credentials. The list includes the name and port number of the website host. Detailed below.</summary>
    [JsonPropertyName("basicAuthentication")]
    public IList<V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication>? BasicAuthentication { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelector
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
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration information required to connect to your internal websites via a web proxy. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot; and the port is 443, the standard port for HTTPS. Web proxy credentials are optional and you can use them to connect to a web proxy server that requires basic authentication. To store web proxy credentials, you use a secret in AWS Secrets Manager. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfiguration
{
    /// <summary>Your secret ARN, which you can create in AWS Secrets Manager. The credentials are optional. You use a secret if web proxy credentials are required to connect to a website host. Amazon Kendra currently support basic authentication to connect to a web proxy server. The secret stores your credentials.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsRef")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsRef? CredentialsRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate credentials.</summary>
    [JsonPropertyName("credentialsSelector")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfigurationCredentialsSelector? CredentialsSelector { get; set; }

    /// <summary>The name of the website host you want to connect to via a web proxy server. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot;.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port number of the website host you want to connect to via a web proxy server. For example, the port for https://a.example.com/page1.html is 443, the standard port for HTTPS.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>A block that specifies the configuration of the seed or starting point URLs of the websites you want to crawl. You can choose to crawl only the website host names, or the website host names with subdomains, or the website host names with subdomains and other domains that the webpages link to. You can list up to 100 seed URLs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration
{
    /// <summary>The list of seed or starting point URLs of the websites you want to crawl. The list can include a maximum of 100 seed URLs. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("seedUrls")]
    public IList<string>? SeedUrls { get; set; }

    /// <summary>The default mode is set to HOST_ONLY. You can choose one of the following modes:</summary>
    [JsonPropertyName("webCrawlerMode")]
    public string? WebCrawlerMode { get; set; }
}

/// <summary>A block that specifies the configuration of the sitemap URLs of the websites you want to crawl. Only URLs belonging to the same website host names are crawled. You can list up to 3 sitemap URLs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration
{
    /// <summary>The list of sitemap URLs of the websites you want to crawl. The list can include a maximum of 3 sitemap URLs.</summary>
    [JsonPropertyName("siteMaps")]
    public IList<string>? SiteMaps { get; set; }
}

/// <summary>A block that specifies the seed or starting point URLs of the websites or the sitemap URLs of the websites you want to crawl. You can include website subdomains. You can list up to 100 seed URLs and up to 3 sitemap URLs. You can only crawl websites that use the secure communication protocol, Hypertext Transfer Protocol Secure (HTTPS). If you receive an error when crawling a website, it could be that the website is blocked from crawling. When selecting websites to index, you must adhere to the Amazon Acceptable Use Policy and all other Amazon terms. Remember that you must only use Amazon Kendra Web Crawler to index your own webpages, or webpages that you have authorization to index. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationUrls
{
    /// <summary>A block that specifies the configuration of the seed or starting point URLs of the websites you want to crawl. You can choose to crawl only the website host names, or the website host names with subdomains, or the website host names with subdomains and other domains that the webpages link to. You can list up to 100 seed URLs. Detailed below.</summary>
    [JsonPropertyName("seedUrlConfiguration")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration? SeedUrlConfiguration { get; set; }

    /// <summary>A block that specifies the configuration of the sitemap URLs of the websites you want to crawl. Only URLs belonging to the same website host names are crawled. You can list up to 3 sitemap URLs. Detailed below.</summary>
    [JsonPropertyName("siteMapsConfiguration")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration? SiteMapsConfiguration { get; set; }
}

/// <summary>(Deprecated, Required if type is set to WEBCRAWLER) A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfiguration
{
    /// <summary>A block with the configuration information required to connect to websites using authentication. You can connect to websites using basic authentication of user name and password. You use a secret in AWS Secrets Manager to store your authentication credentials. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot; and the port is 443, the standard port for HTTPS. Detailed below.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>Specifies the number of levels in a website that you want to crawl. The first level begins from the website seed or starting point URL. For example, if a website has 3 levels - index level (i.e. seed in this example), sections level, and subsections level - and you are only interested in crawling information up to the sections level (i.e. levels 0-1), you can set your depth to 1. The default crawl depth is set to 2. Minimum value of 0. Maximum value of 10.</summary>
    [JsonPropertyName("crawlDepth")]
    public double? CrawlDepth { get; set; }

    /// <summary>The maximum size (in MB) of a webpage or attachment to crawl. Files larger than this size (in MB) are skipped/not crawled. The default maximum size of a webpage or attachment is set to 50 MB. Minimum value of 1.0e-06. Maximum value of 50.</summary>
    [JsonPropertyName("maxContentSizePerPageInMegaBytes")]
    public double? MaxContentSizePerPageInMegaBytes { get; set; }

    /// <summary>The maximum number of URLs on a webpage to include when crawling a website. This number is per webpage. As a website’s webpages are crawled, any URLs the webpages link to are also crawled. URLs on a webpage are crawled in order of appearance. The default maximum links per page is 100. Minimum value of 1. Maximum value of 1000.</summary>
    [JsonPropertyName("maxLinksPerPage")]
    public double? MaxLinksPerPage { get; set; }

    /// <summary>The maximum number of URLs crawled per website host per minute. The default maximum number of URLs crawled per website host per minute is 300. Minimum value of 1. Maximum value of 300.</summary>
    [JsonPropertyName("maxUrlsPerMinuteCrawlRate")]
    public double? MaxUrlsPerMinuteCrawlRate { get; set; }

    /// <summary>Configuration information required to connect to your internal websites via a web proxy. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot; and the port is 443, the standard port for HTTPS. Web proxy credentials are optional and you can use them to connect to a web proxy server that requires basic authentication. To store web proxy credentials, you use a secret in AWS Secrets Manager. Detailed below.</summary>
    [JsonPropertyName("proxyConfiguration")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationProxyConfiguration? ProxyConfiguration { get; set; }

    /// <summary>A list of regular expression patterns to exclude certain URLs to crawl. URLs that match the patterns are excluded from the index. URLs that don&apos;t match the patterns are included in the index. If a URL matches both an inclusion and exclusion pattern, the exclusion pattern takes precedence and the URL file isn&apos;t included in the index. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 150.</summary>
    [JsonPropertyName("urlExclusionPatterns")]
    public IList<string>? UrlExclusionPatterns { get; set; }

    /// <summary>A list of regular expression patterns to include certain URLs to crawl. URLs that match the patterns are included in the index. URLs that don&apos;t match the patterns are excluded from the index. If a URL matches both an inclusion and exclusion pattern, the exclusion pattern takes precedence and the URL file isn&apos;t included in the index. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 150.</summary>
    [JsonPropertyName("urlInclusionPatterns")]
    public IList<string>? UrlInclusionPatterns { get; set; }

    /// <summary>A block that specifies the seed or starting point URLs of the websites or the sitemap URLs of the websites you want to crawl. You can include website subdomains. You can list up to 100 seed URLs and up to 3 sitemap URLs. You can only crawl websites that use the secure communication protocol, Hypertext Transfer Protocol Secure (HTTPS). If you receive an error when crawling a website, it could be that the website is blocked from crawling. When selecting websites to index, you must adhere to the Amazon Acceptable Use Policy and all other Amazon terms. Remember that you must only use Amazon Kendra Web Crawler to index your own webpages, or webpages that you have authorization to index. Detailed below.</summary>
    [JsonPropertyName("urls")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfigurationUrls? Urls { get; set; }
}

/// <summary>A block with the configuration information to connect to your Data Source repository. You can&apos;t specify the configuration block when the type parameter is set to CUSTOM. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderConfiguration
{
    /// <summary>(Deprecated, Required if type is set to S3) A block that provides the configuration information to connect to an Amazon S3 bucket as your data source. Detailed below.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta2DataSourceSpecInitProviderConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
    [JsonPropertyName("templateConfiguration")]
    public V1beta2DataSourceSpecInitProviderConfigurationTemplateConfiguration? TemplateConfiguration { get; set; }

    /// <summary>(Deprecated, Required if type is set to WEBCRAWLER) A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
    [JsonPropertyName("webCrawlerConfiguration")]
    public V1beta2DataSourceSpecInitProviderConfigurationWebCrawlerConfiguration? WebCrawlerConfiguration { get; set; }
}

/// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Configuration of the condition used for the target document attribute or metadata field when ingesting documents into Amazon Kendra. See condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>The target value you want to create for the target attribute. For example, &apos;Finance&apos; could be the target value for the target attribute key &apos;Department&apos;. See target_document_attribute_value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Configuration of the target document attribute or metadata field when ingesting documents into Amazon Kendra. You can also include a value. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget
{
    /// <summary>The identifier of the target document attribute or metadata field. For example, &apos;Department&apos; could be an identifier for the target attribute or metadata field that includes the department names associated with the documents.</summary>
    [JsonPropertyName("targetDocumentAttributeKey")]
    public string? TargetDocumentAttributeKey { get; set; }

    /// <summary>The target value you want to create for the target attribute. For example, &apos;Finance&apos; could be the target value for the target attribute key &apos;Department&apos;. See target_document_attribute_value.</summary>
    [JsonPropertyName("targetDocumentAttributeValue")]
    public V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue? TargetDocumentAttributeValue { get; set; }

    /// <summary>TRUE to delete the existing target value for your specified target attribute key. You cannot create a target value and set this to TRUE. To create a target value (TargetDocumentAttributeValue), set this to FALSE.</summary>
    [JsonPropertyName("targetDocumentAttributeValueDeletion")]
    public bool? TargetDocumentAttributeValueDeletion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurations
{
    /// <summary>Configuration of the condition used for the target document attribute or metadata field when ingesting documents into Amazon Kendra. See condition.</summary>
    [JsonPropertyName("condition")]
    public V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition? Condition { get; set; }

    /// <summary>TRUE to delete content if the condition used for the target attribute is met.</summary>
    [JsonPropertyName("documentContentDeletion")]
    public bool? DocumentContentDeletion { get; set; }

    /// <summary>Configuration of the target document attribute or metadata field when ingesting documents into Amazon Kendra. You can also include a value. Detailed below.</summary>
    [JsonPropertyName("target")]
    public V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget? Target { get; set; }
}

/// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationConditionConditionOnValue? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>A block that specifies the configuration information for invoking a Lambda function in AWS Lambda on the structured documents with their metadata and text extracted. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration
{
    /// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
    [JsonPropertyName("invocationCondition")]
    public V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition? InvocationCondition { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a Lambda Function that can manipulate your document metadata fields or attributes and content.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Stores the original, raw documents or the structured, parsed documents before and after altering them. For more information, see Data contracts for Lambda functions.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }
}

/// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationConditionConditionOnValue? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>Configuration information for invoking a Lambda function in AWS Lambda on the original or raw documents before extracting their metadata and text. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration
{
    /// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
    [JsonPropertyName("invocationCondition")]
    public V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationCondition? InvocationCondition { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a Lambda Function that can manipulate your document metadata fields or attributes and content.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Stores the original, raw documents or the structured, parsed documents before and after altering them. For more information, see Data contracts for Lambda functions.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }
}

/// <summary>A block with the configuration information for altering document metadata and content during the document ingestion process. For more information on how to create, modify and delete document metadata, or make other content alterations when you ingest documents into Amazon Kendra, see Customizing document metadata during the ingestion process. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfiguration
{
    /// <summary>Configuration information to alter document attributes or metadata fields and content when ingesting documents into Amazon Kendra. Minimum number of 0 items. Maximum number of 100 items. Detailed below.</summary>
    [JsonPropertyName("inlineConfigurations")]
    public IList<V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationInlineConfigurations>? InlineConfigurations { get; set; }

    /// <summary>A block that specifies the configuration information for invoking a Lambda function in AWS Lambda on the structured documents with their metadata and text extracted. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
    [JsonPropertyName("postExtractionHookConfiguration")]
    public V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration? PostExtractionHookConfiguration { get; set; }

    /// <summary>Configuration information for invoking a Lambda function in AWS Lambda on the original or raw documents before extracting their metadata and text. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
    [JsonPropertyName("preExtractionHookConfiguration")]
    public V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration? PreExtractionHookConfiguration { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a role with permission to run pre_extraction_hook_configuration and post_extraction_hook_configuration for altering document metadata and content during the document ingestion process. For more information, see IAM roles for Amazon Kendra.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderIndexIdRefPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecInitProviderIndexIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderIndexIdRefPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecInitProviderIndexIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderIndexIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecInitProviderIndexIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecInitProviderIndexIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Index in kendra to populate indexId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderIndexIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSourceSpecInitProviderIndexIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderIndexIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecInitProviderIndexIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderIndexIdSelectorPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecInitProviderIndexIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderIndexIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecInitProviderIndexIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecInitProviderIndexIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Index in kendra to populate indexId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderIndexIdSelector
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
    public V1beta2DataSourceSpecInitProviderIndexIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecInitProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecInitProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecInitProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecInitProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSourceSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecInitProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecInitProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecInitProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecInitProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecInitProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecInitProviderRoleArnSelector
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
    public V1beta2DataSourceSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2DataSourceSpecInitProvider
{
    /// <summary>A block with the configuration information to connect to your Data Source repository. You can&apos;t specify the configuration block when the type parameter is set to CUSTOM. Detailed below.</summary>
    [JsonPropertyName("configuration")]
    public V1beta2DataSourceSpecInitProviderConfiguration? Configuration { get; set; }

    /// <summary>A block with the configuration information for altering document metadata and content during the document ingestion process. For more information on how to create, modify and delete document metadata, or make other content alterations when you ingest documents into Amazon Kendra, see Customizing document metadata during the ingestion process. Detailed below.</summary>
    [JsonPropertyName("customDocumentEnrichmentConfiguration")]
    public V1beta2DataSourceSpecInitProviderCustomDocumentEnrichmentConfiguration? CustomDocumentEnrichmentConfiguration { get; set; }

    /// <summary>A description for the Data Source connector.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The identifier of the index for your Amazon Kendra data source.</summary>
    [JsonPropertyName("indexId")]
    public string? IndexId { get; set; }

    /// <summary>Reference to a Index in kendra to populate indexId.</summary>
    [JsonPropertyName("indexIdRef")]
    public V1beta2DataSourceSpecInitProviderIndexIdRef? IndexIdRef { get; set; }

    /// <summary>Selector for a Index in kendra to populate indexId.</summary>
    [JsonPropertyName("indexIdSelector")]
    public V1beta2DataSourceSpecInitProviderIndexIdSelector? IndexIdSelector { get; set; }

    /// <summary>The code for a language. This allows you to support a language for all documents when creating the Data Source connector. English is supported by default. For more information on supported languages, including their codes, see Adding documents in languages other than English.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>A name for your data source connector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a role with permission to access the data source connector. For more information, see IAM roles for Amazon Kendra. You can&apos;t specify the role_arn parameter when the type parameter is set to CUSTOM. The role_arn parameter is required for all other data sources.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2DataSourceSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2DataSourceSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Sets the frequency for Amazon Kendra to check the documents in your Data Source repository and update the index. If you don&apos;t set a schedule Amazon Kendra will not periodically update the index. You can call the StartDataSourceSyncJob API to update the index.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of data source repository. For an updated list of values, refer to Valid Values for Type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecManagementPoliciesEnum>))]
public enum V1beta2DataSourceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DataSourceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSourceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DataSourceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSourceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSourceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSourceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DataSourceSpec defines the desired state of DataSource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceSpec
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
    public V1beta2DataSourceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DataSourceSpecForProvider ForProvider { get; set; }

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
    public V1beta2DataSourceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DataSourceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DataSourceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DataSourceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A block that provides the path to the S3 bucket that contains the user context filtering files for the data source. For the format of the file, see Access control for S3 data sources. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderConfigurationS3ConfigurationAccessControlListConfiguration
{
    /// <summary>Path to the AWS S3 bucket that contains the ACL files.</summary>
    [JsonPropertyName("keyPath")]
    public string? KeyPath { get; set; }
}

/// <summary>A block that defines the Document metadata files that contain information such as the document access control information, source URI, document author, and custom attributes. Each metadata file contains metadata about a single document. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderConfigurationS3ConfigurationDocumentsMetadataConfiguration
{
    /// <summary>A prefix used to filter metadata configuration files in the AWS S3 bucket. The S3 bucket might contain multiple metadata files. Use s3_prefix to include only the desired metadata files.</summary>
    [JsonPropertyName("s3Prefix")]
    public string? S3Prefix { get; set; }
}

/// <summary>(Deprecated, Required if type is set to S3) A block that provides the configuration information to connect to an Amazon S3 bucket as your data source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderConfigurationS3Configuration
{
    /// <summary>A block that provides the path to the S3 bucket that contains the user context filtering files for the data source. For the format of the file, see Access control for S3 data sources. Detailed below.</summary>
    [JsonPropertyName("accessControlListConfiguration")]
    public V1beta2DataSourceStatusAtProviderConfigurationS3ConfigurationAccessControlListConfiguration? AccessControlListConfiguration { get; set; }

    /// <summary>The name of the bucket that contains the documents.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>A block that defines the Document metadata files that contain information such as the document access control information, source URI, document author, and custom attributes. Each metadata file contains metadata about a single document. Detailed below.</summary>
    [JsonPropertyName("documentsMetadataConfiguration")]
    public V1beta2DataSourceStatusAtProviderConfigurationS3ConfigurationDocumentsMetadataConfiguration? DocumentsMetadataConfiguration { get; set; }

    /// <summary>A list of glob patterns for documents that should not be indexed. If a document that matches an inclusion prefix or inclusion pattern also matches an exclusion pattern, the document is not indexed. Refer to Exclusion Patterns for more examples.</summary>
    [JsonPropertyName("exclusionPatterns")]
    public IList<string>? ExclusionPatterns { get; set; }

    /// <summary>A list of glob patterns for documents that should be indexed. If a document that matches an inclusion pattern also matches an exclusion pattern, the document is not indexed. Refer to Inclusion Patterns for more examples.</summary>
    [JsonPropertyName("inclusionPatterns")]
    public IList<string>? InclusionPatterns { get; set; }

    /// <summary>A list of S3 prefixes for the documents that should be included in the index.</summary>
    [JsonPropertyName("inclusionPrefixes")]
    public IList<string>? InclusionPrefixes { get; set; }
}

/// <summary>A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderConfigurationTemplateConfiguration
{
    /// <summary>JSON string containing a data source template schema.</summary>
    [JsonPropertyName("template")]
    public string? Template { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication
{
    /// <summary>Your secret ARN, which you can create in AWS Secrets Manager. The credentials are optional. You use a secret if web proxy credentials are required to connect to a website host. Amazon Kendra currently support basic authentication to connect to a web proxy server. The secret stores your credentials.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>The name of the website host you want to connect to via a web proxy server. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot;.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port number of the website host you want to connect to via a web proxy server. For example, the port for https://a.example.com/page1.html is 443, the standard port for HTTPS.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>A block with the configuration information required to connect to websites using authentication. You can connect to websites using basic authentication of user name and password. You use a secret in AWS Secrets Manager to store your authentication credentials. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot; and the port is 443, the standard port for HTTPS. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationAuthenticationConfiguration
{
    /// <summary>The list of configuration information that&apos;s required to connect to and crawl a website host using basic authentication credentials. The list includes the name and port number of the website host. Detailed below.</summary>
    [JsonPropertyName("basicAuthentication")]
    public IList<V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication>? BasicAuthentication { get; set; }
}

/// <summary>Configuration information required to connect to your internal websites via a web proxy. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot; and the port is 443, the standard port for HTTPS. Web proxy credentials are optional and you can use them to connect to a web proxy server that requires basic authentication. To store web proxy credentials, you use a secret in AWS Secrets Manager. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationProxyConfiguration
{
    /// <summary>Your secret ARN, which you can create in AWS Secrets Manager. The credentials are optional. You use a secret if web proxy credentials are required to connect to a website host. Amazon Kendra currently support basic authentication to connect to a web proxy server. The secret stores your credentials.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>The name of the website host you want to connect to via a web proxy server. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot;.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port number of the website host you want to connect to via a web proxy server. For example, the port for https://a.example.com/page1.html is 443, the standard port for HTTPS.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>A block that specifies the configuration of the seed or starting point URLs of the websites you want to crawl. You can choose to crawl only the website host names, or the website host names with subdomains, or the website host names with subdomains and other domains that the webpages link to. You can list up to 100 seed URLs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration
{
    /// <summary>The list of seed or starting point URLs of the websites you want to crawl. The list can include a maximum of 100 seed URLs. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 2048.</summary>
    [JsonPropertyName("seedUrls")]
    public IList<string>? SeedUrls { get; set; }

    /// <summary>The default mode is set to HOST_ONLY. You can choose one of the following modes:</summary>
    [JsonPropertyName("webCrawlerMode")]
    public string? WebCrawlerMode { get; set; }
}

/// <summary>A block that specifies the configuration of the sitemap URLs of the websites you want to crawl. Only URLs belonging to the same website host names are crawled. You can list up to 3 sitemap URLs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration
{
    /// <summary>The list of sitemap URLs of the websites you want to crawl. The list can include a maximum of 3 sitemap URLs.</summary>
    [JsonPropertyName("siteMaps")]
    public IList<string>? SiteMaps { get; set; }
}

/// <summary>A block that specifies the seed or starting point URLs of the websites or the sitemap URLs of the websites you want to crawl. You can include website subdomains. You can list up to 100 seed URLs and up to 3 sitemap URLs. You can only crawl websites that use the secure communication protocol, Hypertext Transfer Protocol Secure (HTTPS). If you receive an error when crawling a website, it could be that the website is blocked from crawling. When selecting websites to index, you must adhere to the Amazon Acceptable Use Policy and all other Amazon terms. Remember that you must only use Amazon Kendra Web Crawler to index your own webpages, or webpages that you have authorization to index. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationUrls
{
    /// <summary>A block that specifies the configuration of the seed or starting point URLs of the websites you want to crawl. You can choose to crawl only the website host names, or the website host names with subdomains, or the website host names with subdomains and other domains that the webpages link to. You can list up to 100 seed URLs. Detailed below.</summary>
    [JsonPropertyName("seedUrlConfiguration")]
    public V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration? SeedUrlConfiguration { get; set; }

    /// <summary>A block that specifies the configuration of the sitemap URLs of the websites you want to crawl. Only URLs belonging to the same website host names are crawled. You can list up to 3 sitemap URLs. Detailed below.</summary>
    [JsonPropertyName("siteMapsConfiguration")]
    public V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration? SiteMapsConfiguration { get; set; }
}

/// <summary>(Deprecated, Required if type is set to WEBCRAWLER) A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfiguration
{
    /// <summary>A block with the configuration information required to connect to websites using authentication. You can connect to websites using basic authentication of user name and password. You use a secret in AWS Secrets Manager to store your authentication credentials. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot; and the port is 443, the standard port for HTTPS. Detailed below.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>Specifies the number of levels in a website that you want to crawl. The first level begins from the website seed or starting point URL. For example, if a website has 3 levels - index level (i.e. seed in this example), sections level, and subsections level - and you are only interested in crawling information up to the sections level (i.e. levels 0-1), you can set your depth to 1. The default crawl depth is set to 2. Minimum value of 0. Maximum value of 10.</summary>
    [JsonPropertyName("crawlDepth")]
    public double? CrawlDepth { get; set; }

    /// <summary>The maximum size (in MB) of a webpage or attachment to crawl. Files larger than this size (in MB) are skipped/not crawled. The default maximum size of a webpage or attachment is set to 50 MB. Minimum value of 1.0e-06. Maximum value of 50.</summary>
    [JsonPropertyName("maxContentSizePerPageInMegaBytes")]
    public double? MaxContentSizePerPageInMegaBytes { get; set; }

    /// <summary>The maximum number of URLs on a webpage to include when crawling a website. This number is per webpage. As a website’s webpages are crawled, any URLs the webpages link to are also crawled. URLs on a webpage are crawled in order of appearance. The default maximum links per page is 100. Minimum value of 1. Maximum value of 1000.</summary>
    [JsonPropertyName("maxLinksPerPage")]
    public double? MaxLinksPerPage { get; set; }

    /// <summary>The maximum number of URLs crawled per website host per minute. The default maximum number of URLs crawled per website host per minute is 300. Minimum value of 1. Maximum value of 300.</summary>
    [JsonPropertyName("maxUrlsPerMinuteCrawlRate")]
    public double? MaxUrlsPerMinuteCrawlRate { get; set; }

    /// <summary>Configuration information required to connect to your internal websites via a web proxy. You must provide the website host name and port number. For example, the host name of https://a.example.com/page1.html is &quot;a.example.com&quot; and the port is 443, the standard port for HTTPS. Web proxy credentials are optional and you can use them to connect to a web proxy server that requires basic authentication. To store web proxy credentials, you use a secret in AWS Secrets Manager. Detailed below.</summary>
    [JsonPropertyName("proxyConfiguration")]
    public V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationProxyConfiguration? ProxyConfiguration { get; set; }

    /// <summary>A list of regular expression patterns to exclude certain URLs to crawl. URLs that match the patterns are excluded from the index. URLs that don&apos;t match the patterns are included in the index. If a URL matches both an inclusion and exclusion pattern, the exclusion pattern takes precedence and the URL file isn&apos;t included in the index. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 150.</summary>
    [JsonPropertyName("urlExclusionPatterns")]
    public IList<string>? UrlExclusionPatterns { get; set; }

    /// <summary>A list of regular expression patterns to include certain URLs to crawl. URLs that match the patterns are included in the index. URLs that don&apos;t match the patterns are excluded from the index. If a URL matches both an inclusion and exclusion pattern, the exclusion pattern takes precedence and the URL file isn&apos;t included in the index. Array Members: Minimum number of 0 items. Maximum number of 100 items. Length Constraints: Minimum length of 1. Maximum length of 150.</summary>
    [JsonPropertyName("urlInclusionPatterns")]
    public IList<string>? UrlInclusionPatterns { get; set; }

    /// <summary>A block that specifies the seed or starting point URLs of the websites or the sitemap URLs of the websites you want to crawl. You can include website subdomains. You can list up to 100 seed URLs and up to 3 sitemap URLs. You can only crawl websites that use the secure communication protocol, Hypertext Transfer Protocol Secure (HTTPS). If you receive an error when crawling a website, it could be that the website is blocked from crawling. When selecting websites to index, you must adhere to the Amazon Acceptable Use Policy and all other Amazon terms. Remember that you must only use Amazon Kendra Web Crawler to index your own webpages, or webpages that you have authorization to index. Detailed below.</summary>
    [JsonPropertyName("urls")]
    public V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfigurationUrls? Urls { get; set; }
}

/// <summary>A block with the configuration information to connect to your Data Source repository. You can&apos;t specify the configuration block when the type parameter is set to CUSTOM. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderConfiguration
{
    /// <summary>(Deprecated, Required if type is set to S3) A block that provides the configuration information to connect to an Amazon S3 bucket as your data source. Detailed below.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta2DataSourceStatusAtProviderConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
    [JsonPropertyName("templateConfiguration")]
    public V1beta2DataSourceStatusAtProviderConfigurationTemplateConfiguration? TemplateConfiguration { get; set; }

    /// <summary>(Deprecated, Required if type is set to WEBCRAWLER) A block that provides the configuration information required for Amazon Kendra Web Crawler. Detailed below.</summary>
    [JsonPropertyName("webCrawlerConfiguration")]
    public V1beta2DataSourceStatusAtProviderConfigurationWebCrawlerConfiguration? WebCrawlerConfiguration { get; set; }
}

/// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Configuration of the condition used for the target document attribute or metadata field when ingesting documents into Amazon Kendra. See condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>The target value you want to create for the target attribute. For example, &apos;Finance&apos; could be the target value for the target attribute key &apos;Department&apos;. See target_document_attribute_value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Configuration of the target document attribute or metadata field when ingesting documents into Amazon Kendra. You can also include a value. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget
{
    /// <summary>The identifier of the target document attribute or metadata field. For example, &apos;Department&apos; could be an identifier for the target attribute or metadata field that includes the department names associated with the documents.</summary>
    [JsonPropertyName("targetDocumentAttributeKey")]
    public string? TargetDocumentAttributeKey { get; set; }

    /// <summary>The target value you want to create for the target attribute. For example, &apos;Finance&apos; could be the target value for the target attribute key &apos;Department&apos;. See target_document_attribute_value.</summary>
    [JsonPropertyName("targetDocumentAttributeValue")]
    public V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue? TargetDocumentAttributeValue { get; set; }

    /// <summary>TRUE to delete the existing target value for your specified target attribute key. You cannot create a target value and set this to TRUE. To create a target value (TargetDocumentAttributeValue), set this to FALSE.</summary>
    [JsonPropertyName("targetDocumentAttributeValueDeletion")]
    public bool? TargetDocumentAttributeValueDeletion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurations
{
    /// <summary>Configuration of the condition used for the target document attribute or metadata field when ingesting documents into Amazon Kendra. See condition.</summary>
    [JsonPropertyName("condition")]
    public V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition? Condition { get; set; }

    /// <summary>TRUE to delete content if the condition used for the target attribute is met.</summary>
    [JsonPropertyName("documentContentDeletion")]
    public bool? DocumentContentDeletion { get; set; }

    /// <summary>Configuration of the target document attribute or metadata field when ingesting documents into Amazon Kendra. You can also include a value. Detailed below.</summary>
    [JsonPropertyName("target")]
    public V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget? Target { get; set; }
}

/// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationConditionConditionOnValue? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>A block that specifies the configuration information for invoking a Lambda function in AWS Lambda on the structured documents with their metadata and text extracted. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration
{
    /// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
    [JsonPropertyName("invocationCondition")]
    public V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition? InvocationCondition { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a Lambda Function that can manipulate your document metadata fields or attributes and content.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Stores the original, raw documents or the structured, parsed documents before and after altering them. For more information, see Data contracts for Lambda functions.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }
}

/// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationConditionConditionOnValue
{
    /// <summary>A date expressed as an ISO 8601 string. It is important for the time zone to be included in the ISO 8601 date-time format. As of this writing only UTC is supported. For example, 2012-03-25T12:30:10+00:00.</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>A long integer value.</summary>
    [JsonPropertyName("longValue")]
    public double? LongValue { get; set; }

    /// <summary>A list of strings.</summary>
    [JsonPropertyName("stringListValue")]
    public IList<string>? StringListValue { get; set; }

    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationCondition
{
    /// <summary>The identifier of the document attribute used for the condition. For example, _source_uri could be an identifier for the attribute or metadata field that contains source URIs associated with the documents. Amazon Kendra currently does not support _document_body as an attribute key used for the condition.</summary>
    [JsonPropertyName("conditionDocumentAttributeKey")]
    public string? ConditionDocumentAttributeKey { get; set; }

    /// <summary>The value used by the operator. For example, you can specify the value &apos;financial&apos; for strings in the _source_uri field that partially match or contain this value. See condition_on_value.</summary>
    [JsonPropertyName("conditionOnValue")]
    public V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationConditionConditionOnValue? ConditionOnValue { get; set; }

    /// <summary>The condition operator. For example, you can use Contains to partially match a string. Valid Values: GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | Equals | NotEquals | Contains | NotContains | Exists | NotExists | BeginsWith.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>Configuration information for invoking a Lambda function in AWS Lambda on the original or raw documents before extracting their metadata and text. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration
{
    /// <summary>A block that specifies the condition used for when a Lambda function should be invoked. For example, you can specify a condition that if there are empty date-time values, then Amazon Kendra should invoke a function that inserts the current date-time. See invocation_condition.</summary>
    [JsonPropertyName("invocationCondition")]
    public V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationInvocationCondition? InvocationCondition { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a Lambda Function that can manipulate your document metadata fields or attributes and content.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Stores the original, raw documents or the structured, parsed documents before and after altering them. For more information, see Data contracts for Lambda functions.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }
}

/// <summary>A block with the configuration information for altering document metadata and content during the document ingestion process. For more information on how to create, modify and delete document metadata, or make other content alterations when you ingest documents into Amazon Kendra, see Customizing document metadata during the ingestion process. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfiguration
{
    /// <summary>Configuration information to alter document attributes or metadata fields and content when ingesting documents into Amazon Kendra. Minimum number of 0 items. Maximum number of 100 items. Detailed below.</summary>
    [JsonPropertyName("inlineConfigurations")]
    public IList<V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationInlineConfigurations>? InlineConfigurations { get; set; }

    /// <summary>A block that specifies the configuration information for invoking a Lambda function in AWS Lambda on the structured documents with their metadata and text extracted. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
    [JsonPropertyName("postExtractionHookConfiguration")]
    public V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration? PostExtractionHookConfiguration { get; set; }

    /// <summary>Configuration information for invoking a Lambda function in AWS Lambda on the original or raw documents before extracting their metadata and text. You can use a Lambda function to apply advanced logic for creating, modifying, or deleting document metadata and content. For more information, see Advanced data manipulation. Detailed below.</summary>
    [JsonPropertyName("preExtractionHookConfiguration")]
    public V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration? PreExtractionHookConfiguration { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a role with permission to run pre_extraction_hook_configuration and post_extraction_hook_configuration for altering document metadata and content during the document ingestion process. For more information, see IAM roles for Amazon Kendra.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusAtProvider
{
    /// <summary>ARN of the Data Source.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A block with the configuration information to connect to your Data Source repository. You can&apos;t specify the configuration block when the type parameter is set to CUSTOM. Detailed below.</summary>
    [JsonPropertyName("configuration")]
    public V1beta2DataSourceStatusAtProviderConfiguration? Configuration { get; set; }

    /// <summary>The Unix time stamp of when the Data Source was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>A block with the configuration information for altering document metadata and content during the document ingestion process. For more information on how to create, modify and delete document metadata, or make other content alterations when you ingest documents into Amazon Kendra, see Customizing document metadata during the ingestion process. Detailed below.</summary>
    [JsonPropertyName("customDocumentEnrichmentConfiguration")]
    public V1beta2DataSourceStatusAtProviderCustomDocumentEnrichmentConfiguration? CustomDocumentEnrichmentConfiguration { get; set; }

    /// <summary>The unique identifiers of the Data Source.</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>A description for the Data Source connector.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>When the Status field value is FAILED, contains a description of the error that caused the Data Source to fail.</summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>The unique identifiers of the Data Source and index separated by a slash (/).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The identifier of the index for your Amazon Kendra data source.</summary>
    [JsonPropertyName("indexId")]
    public string? IndexId { get; set; }

    /// <summary>The code for a language. This allows you to support a language for all documents when creating the Data Source connector. English is supported by default. For more information on supported languages, including their codes, see Adding documents in languages other than English.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>A name for your data source connector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of a role with permission to access the data source connector. For more information, see IAM roles for Amazon Kendra. You can&apos;t specify the role_arn parameter when the type parameter is set to CUSTOM. The role_arn parameter is required for all other data sources.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Sets the frequency for Amazon Kendra to check the documents in your Data Source repository and update the index. If you don&apos;t set a schedule Amazon Kendra will not periodically update the index. You can call the StartDataSourceSyncJob API to update the index.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The current status of the Data Source. When the status is ACTIVE the Data Source is ready to use. When the status is FAILED, the error_message field contains the reason that the Data Source failed.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The type of data source repository. For an updated list of values, refer to Valid Values for Type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The Unix time stamp of when the Data Source was last updated.</summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSourceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DataSourceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DataSourceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DataSource is the Schema for the DataSources API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DataSource : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DataSourceSpec>, IStatus<V1beta2DataSourceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DataSource";
    public const string KubeGroup = "kendra.aws.upbound.io";
    public const string KubePluralName = "datasources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kendra.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataSource";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataSourceSpec defines the desired state of DataSource</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DataSourceSpec Spec { get; set; }

    /// <summary>DataSourceStatus defines the observed state of DataSource.</summary>
    [JsonPropertyName("status")]
    public V1beta2DataSourceStatus? Status { get; set; }
}