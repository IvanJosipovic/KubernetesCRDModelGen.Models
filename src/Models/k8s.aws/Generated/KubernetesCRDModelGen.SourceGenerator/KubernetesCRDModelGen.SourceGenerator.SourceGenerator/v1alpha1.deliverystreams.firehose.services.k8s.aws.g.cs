#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.firehose.services.k8s.aws;
/// <summary>DeliveryStream is the Schema for the DeliveryStreams API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DeliveryStreamList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DeliveryStream>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DeliveryStreamList";
    public const string KubeGroup = "firehose.services.k8s.aws";
    public const string KubePluralName = "deliverystreams";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firehose.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DeliveryStreamList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DeliveryStream objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DeliveryStream> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecDeliveryStreamEncryptionConfigurationKeyRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for KeyARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecDeliveryStreamEncryptionConfigurationKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DeliveryStreamSpecDeliveryStreamEncryptionConfigurationKeyRefFrom? From { get; set; }
}

/// <summary>
/// Used to specify the type and Amazon Resource Name (ARN) of the KMS key needed
/// for Server-Side Encryption (SSE).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecDeliveryStreamEncryptionConfiguration
{
    [JsonPropertyName("keyARN")]
    public string? KeyARN { get; set; }

    /// <summary>Reference field for KeyARN</summary>
    [JsonPropertyName("keyRef")]
    public V1alpha1DeliveryStreamSpecDeliveryStreamEncryptionConfigurationKeyRef? KeyRef { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>
/// Describes the buffering options that can be applied before data is delivered
/// to the HTTP endpoint destination. Firehose treats these options as hints,
/// and it might choose to use more optimal values. The SizeInMBs and IntervalInSeconds
/// parameters are optional. However, if specify a value for one of them, you
/// must also provide a value for the other.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationBufferingHints
{
    [JsonPropertyName("intervalInSeconds")]
    public long? IntervalInSeconds { get; set; }

    [JsonPropertyName("sizeInMBs")]
    public long? SizeInMBs { get; set; }
}

/// <summary>Describes the Amazon CloudWatch logging options for your Firehose stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationCloudWatchLoggingOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>
/// SecretKeyReference combines a k8s corev1.SecretReference with a
/// specific key within the referred-to Secret
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationEndpointConfigurationAccessKey
{
    /// <summary>Key is the key within the secret</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>name is unique within a namespace to reference a secret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>namespace defines the space within which the secret name must be unique.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Describes the configuration of the HTTP endpoint to which Kinesis Firehose
/// delivers data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationEndpointConfiguration
{
    /// <summary>
    /// SecretKeyReference combines a k8s corev1.SecretReference with a
    /// specific key within the referred-to Secret
    /// </summary>
    [JsonPropertyName("accessKey")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationEndpointConfigurationAccessKey? AccessKey { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Describes the processor parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationProcessingConfigurationProcessorsParameters
{
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary>
/// Describes a data processor.
/// 
/// If you want to add a new line delimiter between records in objects that are
/// delivered to Amazon S3, choose AppendDelimiterToRecord as a processor type.
/// You don’t have to put a processor parameter when you select AppendDelimiterToRecord.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationProcessingConfigurationProcessors
{
    [JsonPropertyName("parameters")]
    public IList<V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Describes a data processing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationProcessingConfiguration
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("processors")]
    public IList<V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Describes the metadata that&apos;s delivered to the specified HTTP endpoint destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationRequestConfigurationCommonAttributes
{
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }
}

/// <summary>The configuration of the HTTP endpoint request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationRequestConfiguration
{
    [JsonPropertyName("commonAttributes")]
    public IList<V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationRequestConfigurationCommonAttributes>? CommonAttributes { get; set; }

    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }
}

/// <summary>
/// Describes the retry behavior in case Firehose is unable to deliver data to
/// the specified HTTP endpoint destination, or if it doesn&apos;t receive a valid
/// acknowledgment of receipt from the specified HTTP endpoint destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationRetryOptions
{
    [JsonPropertyName("durationInSeconds")]
    public long? DurationInSeconds { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationRoleRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for RoleARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationRoleRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationBucketRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for BucketARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationBucketRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationBucketRefFrom? From { get; set; }
}

/// <summary>
/// Describes hints for the buffering to perform before delivering data to the
/// destination. These options are treated as hints, and therefore Firehose might
/// choose to use different values when it is optimal. The SizeInMBs and IntervalInSeconds
/// parameters are optional. However, if specify a value for one of them, you
/// must also provide a value for the other.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationBufferingHints
{
    [JsonPropertyName("intervalInSeconds")]
    public long? IntervalInSeconds { get; set; }

    [JsonPropertyName("sizeInMBs")]
    public long? SizeInMBs { get; set; }
}

/// <summary>Describes the Amazon CloudWatch logging options for your Firehose stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationCloudWatchLoggingOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationEncryptionConfigurationKmsEncryptionConfigAwsKMSKeyRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for AWSKMSKeyARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationEncryptionConfigurationKmsEncryptionConfigAwsKMSKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationEncryptionConfigurationKmsEncryptionConfigAwsKMSKeyRefFrom? From { get; set; }
}

/// <summary>Describes an encryption key for a destination in Amazon S3.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationEncryptionConfigurationKmsEncryptionConfig
{
    [JsonPropertyName("awsKMSKeyARN")]
    public string? AwsKMSKeyARN { get; set; }

    /// <summary>Reference field for AWSKMSKeyARN</summary>
    [JsonPropertyName("awsKMSKeyRef")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationEncryptionConfigurationKmsEncryptionConfigAwsKMSKeyRef? AwsKMSKeyRef { get; set; }
}

/// <summary>Describes the encryption for a destination in Amazon S3.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationEncryptionConfiguration
{
    /// <summary>Describes an encryption key for a destination in Amazon S3.</summary>
    [JsonPropertyName("kmsEncryptionConfig")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationEncryptionConfigurationKmsEncryptionConfig? KmsEncryptionConfig { get; set; }

    [JsonPropertyName("noEncryptionConfig")]
    public string? NoEncryptionConfig { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationRoleRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for RoleARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationRoleRefFrom? From { get; set; }
}

/// <summary>Describes the configuration of a destination in Amazon S3.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3Configuration
{
    [JsonPropertyName("bucketARN")]
    public string? BucketARN { get; set; }

    /// <summary>Reference field for BucketARN</summary>
    [JsonPropertyName("bucketRef")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationBucketRef? BucketRef { get; set; }

    /// <summary>
    /// Describes hints for the buffering to perform before delivering data to the
    /// destination. These options are treated as hints, and therefore Firehose might
    /// choose to use different values when it is optimal. The SizeInMBs and IntervalInSeconds
    /// parameters are optional. However, if specify a value for one of them, you
    /// must also provide a value for the other.
    /// </summary>
    [JsonPropertyName("bufferingHints")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationBufferingHints? BufferingHints { get; set; }

    /// <summary>Describes the Amazon CloudWatch logging options for your Firehose stream.</summary>
    [JsonPropertyName("cloudWatchLoggingOptions")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationCloudWatchLoggingOptions? CloudWatchLoggingOptions { get; set; }

    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Describes the encryption for a destination in Amazon S3.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }

    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>Reference field for RoleARN</summary>
    [JsonPropertyName("roleRef")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3ConfigurationRoleRef? RoleRef { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationSecretsManagerConfigurationRoleRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for RoleARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationSecretsManagerConfigurationRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationSecretsManagerConfigurationRoleRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationSecretsManagerConfigurationSecretRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for SecretARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationSecretsManagerConfigurationSecretRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationSecretsManagerConfigurationSecretRefFrom? From { get; set; }
}

/// <summary>The structure that defines how Firehose accesses the secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationSecretsManagerConfiguration
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>Reference field for RoleARN</summary>
    [JsonPropertyName("roleRef")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationSecretsManagerConfigurationRoleRef? RoleRef { get; set; }

    [JsonPropertyName("secretARN")]
    public string? SecretARN { get; set; }

    /// <summary>Reference field for SecretARN</summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationSecretsManagerConfigurationSecretRef? SecretRef { get; set; }
}

/// <summary>
/// Enables configuring Kinesis Firehose to deliver data to any HTTP endpoint
/// destination. You can specify only one destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfiguration
{
    /// <summary>
    /// Describes the buffering options that can be applied before data is delivered
    /// to the HTTP endpoint destination. Firehose treats these options as hints,
    /// and it might choose to use more optimal values. The SizeInMBs and IntervalInSeconds
    /// parameters are optional. However, if specify a value for one of them, you
    /// must also provide a value for the other.
    /// </summary>
    [JsonPropertyName("bufferingHints")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationBufferingHints? BufferingHints { get; set; }

    /// <summary>Describes the Amazon CloudWatch logging options for your Firehose stream.</summary>
    [JsonPropertyName("cloudWatchLoggingOptions")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationCloudWatchLoggingOptions? CloudWatchLoggingOptions { get; set; }

    /// <summary>
    /// Describes the configuration of the HTTP endpoint to which Kinesis Firehose
    /// delivers data.
    /// </summary>
    [JsonPropertyName("endpointConfiguration")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationEndpointConfiguration? EndpointConfiguration { get; set; }

    /// <summary>Describes a data processing configuration.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The configuration of the HTTP endpoint request.</summary>
    [JsonPropertyName("requestConfiguration")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationRequestConfiguration? RequestConfiguration { get; set; }

    /// <summary>
    /// Describes the retry behavior in case Firehose is unable to deliver data to
    /// the specified HTTP endpoint destination, or if it doesn&apos;t receive a valid
    /// acknowledgment of receipt from the specified HTTP endpoint destination.
    /// </summary>
    [JsonPropertyName("retryOptions")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationRetryOptions? RetryOptions { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>Reference field for RoleARN</summary>
    [JsonPropertyName("roleRef")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationRoleRef? RoleRef { get; set; }

    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>Describes the configuration of a destination in Amazon S3.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The structure that defines how Firehose accesses the secret.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }
}

/// <summary>
/// Metadata that you can assign to a Firehose stream, consisting of a key-value
/// pair.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DeliveryStreamSpec defines the desired state of DeliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamSpec
{
    /// <summary>
    /// Used to specify the type and Amazon Resource Name (ARN) of the KMS key needed
    /// for Server-Side Encryption (SSE).
    /// </summary>
    [JsonPropertyName("deliveryStreamEncryptionConfiguration")]
    public V1alpha1DeliveryStreamSpecDeliveryStreamEncryptionConfiguration? DeliveryStreamEncryptionConfiguration { get; set; }

    /// <summary>
    /// The name of the Firehose stream. This name must be unique per Amazon Web
    /// Services account in the same Amazon Web Services Region. If the Firehose
    /// streams are in different accounts or different Regions, you can have multiple
    /// Firehose streams with the same name.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9_.-]+$`
    /// </summary>
    [JsonPropertyName("deliveryStreamName")]
    public required string DeliveryStreamName { get; set; }

    /// <summary>
    /// The Firehose stream type. This parameter can be one of the following values:
    /// 
    ///   - DirectPut: Provider applications access the Firehose stream directly.
    /// 
    ///   - KinesisStreamAsSource: The Firehose stream uses a Kinesis data stream
    ///     as a source.
    /// </summary>
    [JsonPropertyName("deliveryStreamType")]
    public string? DeliveryStreamType { get; set; }

    /// <summary>
    /// Enables configuring Kinesis Firehose to deliver data to any HTTP endpoint
    /// destination. You can specify only one destination.
    /// </summary>
    [JsonPropertyName("httpEndpointDestinationConfiguration")]
    public V1alpha1DeliveryStreamSpecHttpEndpointDestinationConfiguration? HttpEndpointDestinationConfiguration { get; set; }

    /// <summary>
    /// A set of tags to assign to the Firehose stream. A tag is a key-value pair
    /// that you can define and assign to Amazon Web Services resources. Tags are
    /// metadata. For example, you can add friendly names and descriptions or other
    /// types of information that can help you distinguish the Firehose stream. For
    /// more information about tags, see Using Cost Allocation Tags (https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html)
    /// in the Amazon Web Services Billing and Cost Management User Guide.
    /// 
    /// You can specify up to 50 tags when creating a Firehose stream.
    /// 
    /// If you specify tags in the CreateDeliveryStream action, Amazon Data Firehose
    /// performs an additional authorization on the firehose:TagDeliveryStream action
    /// to verify if users have permissions to create tags. If you do not provide
    /// this permission, requests to create new Firehose streams with IAM resource
    /// tags will fail with an AccessDeniedException such as following.
    /// 
    /// # AccessDeniedException
    /// 
    /// User: arn:aws:sts::x:assumed-role/x/x is not authorized to perform: firehose:TagDeliveryStream
    /// on resource: arn:aws:firehose:us-east-1:x:deliverystream/x with an explicit
    /// deny in an identity-based policy.
    /// 
    /// For an example IAM policy, see Tag example. (https://docs.aws.amazon.com/firehose/latest/APIReference/API_CreateDeliveryStream.html#API_CreateDeliveryStream_Examples)
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DeliveryStreamSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// Provides details in case one of the following operations fails due to an
/// error related to KMS: CreateDeliveryStream, DeleteDeliveryStream, StartDeliveryStreamEncryption,
/// StopDeliveryStreamEncryption.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamStatusDeliveryStreamEncryptionConfigurationFailureDescription
{
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>DeliveryStreamStatus defines the observed state of DeliveryStream</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeliveryStreamStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DeliveryStreamStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DeliveryStreamStatusConditions>? Conditions { get; set; }

    /// <summary>The date and time that the Firehose stream was created.</summary>
    [JsonPropertyName("createTimestamp")]
    public DateTime? CreateTimestamp { get; set; }

    /// <summary>
    /// Provides details in case one of the following operations fails due to an
    /// error related to KMS: CreateDeliveryStream, DeleteDeliveryStream, StartDeliveryStreamEncryption,
    /// StopDeliveryStreamEncryption.
    /// </summary>
    [JsonPropertyName("deliveryStreamEncryptionConfigurationFailureDescription")]
    public V1alpha1DeliveryStreamStatusDeliveryStreamEncryptionConfigurationFailureDescription? DeliveryStreamEncryptionConfigurationFailureDescription { get; set; }

    /// <summary>
    /// This is the server-side encryption (SSE) status for the Firehose stream.
    /// For a full description of the different values of this status, see StartDeliveryStreamEncryption
    /// and StopDeliveryStreamEncryption. If this status is ENABLING_FAILED or DISABLING_FAILED,
    /// it is the status of the most recent attempt to enable or disable SSE, respectively.
    /// </summary>
    [JsonPropertyName("deliveryStreamEncryptionConfigurationStatus")]
    public string? DeliveryStreamEncryptionConfigurationStatus { get; set; }

    /// <summary>
    /// The status of the Firehose stream. If the status of a Firehose stream is
    /// CREATING_FAILED, this status doesn&apos;t change, and you can&apos;t invoke CreateDeliveryStream
    /// again on it. However, you can invoke the DeleteDeliveryStream operation to
    /// delete it.
    /// </summary>
    [JsonPropertyName("deliveryStreamStatus")]
    public string? DeliveryStreamStatus { get; set; }

    /// <summary>
    /// The ID of the destination.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9-]+$`
    /// </summary>
    [JsonPropertyName("destinationID")]
    public string? DestinationID { get; set; }

    /// <summary>The date and time that the Firehose stream was last updated.</summary>
    [JsonPropertyName("lastUpdateTimestamp")]
    public DateTime? LastUpdateTimestamp { get; set; }

    /// <summary>
    /// Each time the destination is updated for a Firehose stream, the version ID
    /// is changed, and the current version ID is required when updating the destination.
    /// This is so that the service knows it is applying the changes to the correct
    /// version of the delivery stream.
    /// 
    /// Regex Pattern: `^[0-9]+$`
    /// </summary>
    [JsonPropertyName("versionID")]
    public string? VersionID { get; set; }
}

/// <summary>DeliveryStream is the Schema for the DeliveryStreams API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DeliveryStream : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DeliveryStreamSpec?>, IStatus<V1alpha1DeliveryStreamStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DeliveryStream";
    public const string KubeGroup = "firehose.services.k8s.aws";
    public const string KubePluralName = "deliverystreams";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firehose.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DeliveryStream";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeliveryStreamSpec defines the desired state of DeliveryStream.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DeliveryStreamSpec? Spec { get; set; }

    /// <summary>DeliveryStreamStatus defines the observed state of DeliveryStream</summary>
    [JsonPropertyName("status")]
    public V1alpha1DeliveryStreamStatus? Status { get; set; }
}