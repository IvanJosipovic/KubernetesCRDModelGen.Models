#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appflow.aws.m.upbound.io;
/// <summary>Flow is the Schema for the Flows API. Provides an AppFlow Flow resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FlowList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Flow>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FlowList";
    public const string KubeGroup = "appflow.aws.m.upbound.io";
    public const string KubePluralName = "flows";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appflow.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlowList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Flow objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Flow> Items { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the custom connector as destination. See the destination_flow_config.destination_connector_properties.custom_connector.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query the custom connector. See the destination_flow_config.destination_connector_properties.custom_connector Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnector
{
    /// <summary>Custom properties specific to the connector when it&apos;s used as a destination in the flow. Maximum of 50 items.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>Entity specified in the custom connector as a destination in the flow.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the custom connector as destination. See the destination_flow_config.destination_connector_properties.custom_connector.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Properties required to query Amazon Connect Customer Profiles. See the destination_flow_config.destination_connector_properties.customer_profiles Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles
{
    /// <summary>Unique name of the Amazon Connect Customer Profiles domain.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Object specified in the Amazon Connect Customer Profiles flow destination.</summary>
    [JsonPropertyName("objectTypeName")]
    public string? ObjectTypeName { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.event_bridge.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridgeErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Amazon EventBridge. See the destination_flow_config.destination_connector_properties.event_bridge Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridge
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.event_bridge.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridgeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.honeycode.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Amazon Honeycode. See the destination_flow_config.destination_connector_properties.honeycode Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycode
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.honeycode.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics
{
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.marketo.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesMarketoErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Marketo. See the destination_flow_config.destination_connector_properties.marketo Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesMarketo
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.marketo.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesMarketoErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.redshift.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Amazon Redshift. See the destination_flow_config.destination_connector_properties.redshift Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesRedshift
{
    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.redshift.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Intermediate bucket that Amazon AppFlow uses when moving data into Amazon Redshift.</summary>
    [JsonPropertyName("intermediateBucketName")]
    public string? IntermediateBucketName { get; set; }

    /// <summary>Object specified in the Amazon Redshift flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelector
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
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Aggregation settings that you can use to customize the output format of your flow data. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config.aggregation_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig
{
    /// <summary>Whether Amazon AppFlow aggregates the flow records into a single file, or leaves them unaggregated. Valid values are None and SingleFile.</summary>
    [JsonPropertyName("aggregationType")]
    public string? AggregationType { get; set; }

    /// <summary>Desired file size, in MB, for each output file that Amazon AppFlow writes to the flow destination.</summary>
    [JsonPropertyName("targetFileSize")]
    public double? TargetFileSize { get; set; }
}

/// <summary>Prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config.prefix_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig
{
    /// <summary>Level of granularity included in the prefix. Valid values are YEAR, MONTH, DAY, HOUR, and MINUTE.</summary>
    [JsonPropertyName("prefixFormat")]
    public string? PrefixFormat { get; set; }

    /// <summary>Whether the destination file path includes either or both of the selected elements. Valid values are EXECUTION_ID and SCHEMA_VERSION.</summary>
    [JsonPropertyName("prefixHierarchy")]
    public IList<string>? PrefixHierarchy { get; set; }

    /// <summary>Format of the prefix, and whether it applies to the file name, file path, or both. Valid values are FILENAME, PATH, and PATH_AND_FILENAME.</summary>
    [JsonPropertyName("prefixType")]
    public string? PrefixType { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow formats the flow output data when Amazon S3 is used as the destination. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig
{
    /// <summary>Aggregation settings that you can use to customize the output format of your flow data. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config.aggregation_config Block for details.</summary>
    [JsonPropertyName("aggregationConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig? AggregationConfig { get; set; }

    /// <summary>File type that Amazon AppFlow places in the Amazon S3 bucket. Valid values are CSV, JSON, and PARQUET.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>Prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config.prefix_config Block for details.</summary>
    [JsonPropertyName("prefixConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig? PrefixConfig { get; set; }

    /// <summary>Whether to preserve the data types from the source system. Only valid for the PARQUET file type.</summary>
    [JsonPropertyName("preserveSourceDataTyping")]
    public bool? PreserveSourceDataTyping { get; set; }
}

/// <summary>Properties required to query Amazon S3. See the destination_flow_config.destination_connector_properties.s3 Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow formats the flow output data when Amazon S3 is used as the destination. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config Block for details.</summary>
    [JsonPropertyName("s3OutputFormatConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig? S3OutputFormatConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.salesforce.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforceErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Salesforce. See the destination_flow_config.destination_connector_properties.salesforce Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforce
{
    /// <summary>Salesforce API used by Amazon AppFlow when the flow transfers data to Salesforce.</summary>
    [JsonPropertyName("dataTransferApi")]
    public string? DataTransferApi { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.salesforce.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforceErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update or delete.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Type of write operation to be performed in Salesforce. When the value is UPSERT, id_field_names is required. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.sapo_data.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles the success response it gets from the connector after placing data. See the destination_flow_config.destination_connector_properties.sapo_data.success_response_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }
}

/// <summary>Properties required to query SAPOData. See the destination_flow_config.destination_connector_properties.sapo_data Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSapoData
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.sapo_data.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update or delete.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object path specified in the SAPOData flow destination.</summary>
    [JsonPropertyName("objectPath")]
    public string? ObjectPath { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles the success response it gets from the connector after placing data. See the destination_flow_config.destination_connector_properties.sapo_data.success_response_handling_config Block for details.</summary>
    [JsonPropertyName("successResponseHandlingConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig? SuccessResponseHandlingConfig { get; set; }

    /// <summary>Possible write operations in the destination connector. Defaults to INSERT when not provided. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.snowflake.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflakeErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Snowflake. See the destination_flow_config.destination_connector_properties.snowflake Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflake
{
    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.snowflake.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflakeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Intermediate bucket that Amazon AppFlow uses when moving data into Amazon Snowflake.</summary>
    [JsonPropertyName("intermediateBucketName")]
    public string? IntermediateBucketName { get; set; }

    /// <summary>Object specified in the Amazon Snowflake flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Aggregation settings that you can use to customize the output format of your flow data. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config.aggregation_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig
{
    /// <summary>Whether Amazon AppFlow aggregates the flow records into a single file, or leaves them unaggregated. Valid values are None and SingleFile.</summary>
    [JsonPropertyName("aggregationType")]
    public string? AggregationType { get; set; }
}

/// <summary>Prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config.prefix_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig
{
    /// <summary>Level of granularity included in the prefix. Valid values are YEAR, MONTH, DAY, HOUR, and MINUTE.</summary>
    [JsonPropertyName("prefixFormat")]
    public string? PrefixFormat { get; set; }

    /// <summary>Whether the destination file path includes either or both of the selected elements. Valid values are EXECUTION_ID and SCHEMA_VERSION.</summary>
    [JsonPropertyName("prefixHierarchy")]
    public IList<string>? PrefixHierarchy { get; set; }

    /// <summary>Format of the prefix, and whether it applies to the file name, file path, or both. Valid values are FILENAME, PATH, and PATH_AND_FILENAME.</summary>
    [JsonPropertyName("prefixType")]
    public string? PrefixType { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow formats the flow output data when Upsolver is used as the destination. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig
{
    /// <summary>Aggregation settings that you can use to customize the output format of your flow data. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config.aggregation_config Block for details.</summary>
    [JsonPropertyName("aggregationConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig? AggregationConfig { get; set; }

    /// <summary>File type that Amazon AppFlow places in the Upsolver Amazon S3 bucket. Valid values are CSV, JSON, and PARQUET.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>Prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config.prefix_config Block for details.</summary>
    [JsonPropertyName("prefixConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig? PrefixConfig { get; set; }
}

/// <summary>Properties required to query Upsolver. See the destination_flow_config.destination_connector_properties.upsolver Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolver
{
    /// <summary>Upsolver Amazon S3 bucket name in which Amazon AppFlow places the transferred data. Must begin with upsolver-appflow.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the Upsolver Amazon S3 bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow formats the flow output data when Upsolver is used as the destination. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config Block for details.</summary>
    [JsonPropertyName("s3OutputFormatConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig? S3OutputFormatConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.zendesk.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Zendesk. See the destination_flow_config.destination_connector_properties.zendesk Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesZendesk
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.zendesk.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update or delete.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Type of write operation to be performed in Zendesk. When the value is UPSERT, id_field_names is required. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Information required to query a particular connector. See the destination_flow_config.destination_connector_properties Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorProperties
{
    /// <summary>Properties required to query the custom connector. See the destination_flow_config.destination_connector_properties.custom_connector Block for details.</summary>
    [JsonPropertyName("customConnector")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnector? CustomConnector { get; set; }

    /// <summary>Properties required to query Amazon Connect Customer Profiles. See the destination_flow_config.destination_connector_properties.customer_profiles Block for details.</summary>
    [JsonPropertyName("customerProfiles")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles? CustomerProfiles { get; set; }

    /// <summary>Properties required to query Amazon EventBridge. See the destination_flow_config.destination_connector_properties.event_bridge Block for details.</summary>
    [JsonPropertyName("eventBridge")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridge? EventBridge { get; set; }

    /// <summary>Properties required to query Amazon Honeycode. See the destination_flow_config.destination_connector_properties.honeycode Block for details.</summary>
    [JsonPropertyName("honeycode")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycode? Honeycode { get; set; }

    [JsonPropertyName("lookoutMetrics")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics? LookoutMetrics { get; set; }

    /// <summary>Properties required to query Marketo. See the destination_flow_config.destination_connector_properties.marketo Block for details.</summary>
    [JsonPropertyName("marketo")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesMarketo? Marketo { get; set; }

    /// <summary>Properties required to query Amazon Redshift. See the destination_flow_config.destination_connector_properties.redshift Block for details.</summary>
    [JsonPropertyName("redshift")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesRedshift? Redshift { get; set; }

    /// <summary>Properties required to query Amazon S3. See the destination_flow_config.destination_connector_properties.s3 Block for details.</summary>
    [JsonPropertyName("s3")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3? S3 { get; set; }

    /// <summary>Properties required to query Salesforce. See the destination_flow_config.destination_connector_properties.salesforce Block for details.</summary>
    [JsonPropertyName("salesforce")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforce? Salesforce { get; set; }

    /// <summary>Properties required to query SAPOData. See the destination_flow_config.destination_connector_properties.sapo_data Block for details.</summary>
    [JsonPropertyName("sapoData")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSapoData? SapoData { get; set; }

    /// <summary>Properties required to query Snowflake. See the destination_flow_config.destination_connector_properties.snowflake Block for details.</summary>
    [JsonPropertyName("snowflake")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflake? Snowflake { get; set; }

    /// <summary>Properties required to query Upsolver. See the destination_flow_config.destination_connector_properties.upsolver Block for details.</summary>
    [JsonPropertyName("upsolver")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolver? Upsolver { get; set; }

    /// <summary>Properties required to query Zendesk. See the destination_flow_config.destination_connector_properties.zendesk Block for details.</summary>
    [JsonPropertyName("zendesk")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesZendesk? Zendesk { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderDestinationFlowConfig
{
    /// <summary>API version that the destination connector uses.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Name of the connector profile. Must be unique for each connector profile in the AWS account.</summary>
    [JsonPropertyName("connectorProfileName")]
    public string? ConnectorProfileName { get; set; }

    /// <summary>Type of connector, such as Salesforce, Amplitude, and so on. Valid values are Salesforce, Singular, Slack, Redshift, S3, Marketo, Googleanalytics, Zendesk, Servicenow, Datadog, Trendmicro, Snowflake, Dynatrace, Infornexus, Amplitude, Veeva, EventBridge, LookoutMetrics, Upsolver, Honeycode, CustomerProfiles, SAPOData, and CustomConnector.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>Information required to query a particular connector. See the destination_flow_config.destination_connector_properties Block for details.</summary>
    [JsonPropertyName("destinationConnectorProperties")]
    public V1beta1FlowSpecForProviderDestinationFlowConfigDestinationConnectorProperties? DestinationConnectorProperties { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow catalogs data with the AWS Glue Data Catalog. See the metadata_catalog_config.glue_data_catalog Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderMetadataCatalogConfigGlueDataCatalog
{
    /// <summary>Name of an existing Glue database to store the metadata tables that Amazon AppFlow creates.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>ARN of the IAM role that grants Amazon AppFlow the permissions it needs to create Data Catalog tables, databases, and partitions.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Naming prefix for each Data Catalog table that Amazon AppFlow creates.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow catalogs the data that the flow transfers. See the metadata_catalog_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderMetadataCatalogConfig
{
    /// <summary>Configuration that determines how Amazon AppFlow catalogs data with the AWS Glue Data Catalog. See the metadata_catalog_config.glue_data_catalog Block for details.</summary>
    [JsonPropertyName("glueDataCatalog")]
    public V1beta1FlowSpecForProviderMetadataCatalogConfigGlueDataCatalog? GlueDataCatalog { get; set; }
}

/// <summary>Configuration for a scheduled incremental data pull. When a valid configuration is provided, the specified fields are used when querying for the incremental data pull. See the source_flow_config.incremental_pull_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigIncrementalPullConfig
{
    /// <summary>Field that specifies the date time or timestamp field as the criteria to use when importing incremental records from the source.</summary>
    [JsonPropertyName("datetimeTypeFieldName")]
    public string? DatetimeTypeFieldName { get; set; }
}

/// <summary>Information required to query Amplitude. See the source_flow_config.source_connector_properties.amplitude Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesAmplitude
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Properties applied when the custom connector is used as a source. See the source_flow_config.source_connector_properties.custom_connector Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesCustomConnector
{
    /// <summary>Custom properties specific to the connector when it&apos;s used as a source in the flow. Maximum of 50 items.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>Entity specified in the custom connector as a source in the flow.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }
}

/// <summary>Information required to query Datadog. See the source_flow_config.source_connector_properties.datadog Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesDatadog
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Dynatrace. See the source_flow_config.source_connector_properties.dynatrace Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesDynatrace
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Google Analytics. See the source_flow_config.source_connector_properties.google_analytics Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Infor Nexus. See the source_flow_config.source_connector_properties.infor_nexus Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesInforNexus
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Marketo. See the source_flow_config.source_connector_properties.marketo Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesMarketo
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelector
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
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>When you use Amazon S3 as the source, configuration format that you provide for the flow input data. See the source_flow_config.source_connector_properties.s3.s3_input_format_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig
{
    /// <summary>File type that Amazon AppFlow gets from your Amazon S3 bucket. Valid values are CSV and JSON.</summary>
    [JsonPropertyName("s3InputFileType")]
    public string? S3InputFileType { get; set; }
}

/// <summary>Information required to query Amazon S3. See the source_flow_config.source_connector_properties.s3 Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3
{
    /// <summary>Amazon S3 bucket name where the source files are stored.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Object key for the Amazon S3 bucket in which the source files are stored.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>When you use Amazon S3 as the source, configuration format that you provide for the flow input data. See the source_flow_config.source_connector_properties.s3.s3_input_format_config Block for details.</summary>
    [JsonPropertyName("s3InputFormatConfig")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig? S3InputFormatConfig { get; set; }
}

/// <summary>Information required to query Salesforce. See the source_flow_config.source_connector_properties.salesforce Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSalesforce
{
    /// <summary>Salesforce API used by Amazon AppFlow when the flow transfers data from Salesforce.</summary>
    [JsonPropertyName("dataTransferApi")]
    public string? DataTransferApi { get; set; }

    /// <summary>Whether to enable dynamic fetching of new (recently added) fields in the Salesforce objects while running a flow.</summary>
    [JsonPropertyName("enableDynamicFieldUpdate")]
    public bool? EnableDynamicFieldUpdate { get; set; }

    /// <summary>Whether to include deleted files in the flow run.</summary>
    [JsonPropertyName("includeDeletedRecords")]
    public bool? IncludeDeletedRecords { get; set; }

    /// <summary>Object specified in the Salesforce flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Page size for each concurrent process that transfers OData records from your SAP instance. See the source_flow_config.source_connector_properties.sapo_data.pagination_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig
{
    /// <summary>Maximum number of records that Amazon AppFlow receives in each page of the response from your SAP application.</summary>
    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }
}

/// <summary>Number of concurrent processes that transfer OData records from your SAP instance. See the source_flow_config.source_connector_properties.sapo_data.parallelism_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig
{
    /// <summary>Maximum number of processes that Amazon AppFlow runs at the same time when it retrieves your data from your SAP application.</summary>
    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }
}

/// <summary>Information required to query SAPOData as a flow source. See the source_flow_config.source_connector_properties.sapo_data Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSapoData
{
    /// <summary>Object path specified in the SAPOData flow source.</summary>
    [JsonPropertyName("objectPath")]
    public string? ObjectPath { get; set; }

    /// <summary>Page size for each concurrent process that transfers OData records from your SAP instance. See the source_flow_config.source_connector_properties.sapo_data.pagination_config Block for details.</summary>
    [JsonPropertyName("paginationConfig")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig? PaginationConfig { get; set; }

    /// <summary>Number of concurrent processes that transfer OData records from your SAP instance. See the source_flow_config.source_connector_properties.sapo_data.parallelism_config Block for details.</summary>
    [JsonPropertyName("parallelismConfig")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig? ParallelismConfig { get; set; }
}

/// <summary>Information required to query ServiceNow. See the source_flow_config.source_connector_properties.service_now Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesServiceNow
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Singular. See the source_flow_config.source_connector_properties.singular Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSingular
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Slack. See the source_flow_config.source_connector_properties.slack Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSlack
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Trend Micro. See the source_flow_config.source_connector_properties.trendmicro Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesTrendmicro
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Veeva. See the source_flow_config.source_connector_properties.veeva Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesVeeva
{
    /// <summary>Document type specified in the Veeva document extract flow.</summary>
    [JsonPropertyName("documentType")]
    public string? DocumentType { get; set; }

    /// <summary>Whether to include all versions of files in the Veeva document extract flow.</summary>
    [JsonPropertyName("includeAllVersions")]
    public bool? IncludeAllVersions { get; set; }

    /// <summary>Whether to include file renditions in the Veeva document extract flow.</summary>
    [JsonPropertyName("includeRenditions")]
    public bool? IncludeRenditions { get; set; }

    /// <summary>Whether to include source files in the Veeva document extract flow.</summary>
    [JsonPropertyName("includeSourceFiles")]
    public bool? IncludeSourceFiles { get; set; }

    /// <summary>Object specified in the Veeva flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Zendesk. See the source_flow_config.source_connector_properties.zendesk Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesZendesk
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query a particular source connector. See the source_flow_config.source_connector_properties Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorProperties
{
    /// <summary>Information required to query Amplitude. See the source_flow_config.source_connector_properties.amplitude Block for details.</summary>
    [JsonPropertyName("amplitude")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesAmplitude? Amplitude { get; set; }

    /// <summary>Properties applied when the custom connector is used as a source. See the source_flow_config.source_connector_properties.custom_connector Block for details.</summary>
    [JsonPropertyName("customConnector")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesCustomConnector? CustomConnector { get; set; }

    /// <summary>Information required to query Datadog. See the source_flow_config.source_connector_properties.datadog Block for details.</summary>
    [JsonPropertyName("datadog")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesDatadog? Datadog { get; set; }

    /// <summary>Information required to query Dynatrace. See the source_flow_config.source_connector_properties.dynatrace Block for details.</summary>
    [JsonPropertyName("dynatrace")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesDynatrace? Dynatrace { get; set; }

    /// <summary>Information required to query Google Analytics. See the source_flow_config.source_connector_properties.google_analytics Block for details.</summary>
    [JsonPropertyName("googleAnalytics")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics? GoogleAnalytics { get; set; }

    /// <summary>Information required to query Infor Nexus. See the source_flow_config.source_connector_properties.infor_nexus Block for details.</summary>
    [JsonPropertyName("inforNexus")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesInforNexus? InforNexus { get; set; }

    /// <summary>Information required to query Marketo. See the source_flow_config.source_connector_properties.marketo Block for details.</summary>
    [JsonPropertyName("marketo")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesMarketo? Marketo { get; set; }

    /// <summary>Information required to query Amazon S3. See the source_flow_config.source_connector_properties.s3 Block for details.</summary>
    [JsonPropertyName("s3")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3? S3 { get; set; }

    /// <summary>Information required to query Salesforce. See the source_flow_config.source_connector_properties.salesforce Block for details.</summary>
    [JsonPropertyName("salesforce")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSalesforce? Salesforce { get; set; }

    /// <summary>Information required to query SAPOData as a flow source. See the source_flow_config.source_connector_properties.sapo_data Block for details.</summary>
    [JsonPropertyName("sapoData")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSapoData? SapoData { get; set; }

    /// <summary>Information required to query ServiceNow. See the source_flow_config.source_connector_properties.service_now Block for details.</summary>
    [JsonPropertyName("serviceNow")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesServiceNow? ServiceNow { get; set; }

    /// <summary>Information required to query Singular. See the source_flow_config.source_connector_properties.singular Block for details.</summary>
    [JsonPropertyName("singular")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSingular? Singular { get; set; }

    /// <summary>Information required to query Slack. See the source_flow_config.source_connector_properties.slack Block for details.</summary>
    [JsonPropertyName("slack")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSlack? Slack { get; set; }

    /// <summary>Information required to query Trend Micro. See the source_flow_config.source_connector_properties.trendmicro Block for details.</summary>
    [JsonPropertyName("trendmicro")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesTrendmicro? Trendmicro { get; set; }

    /// <summary>Information required to query Veeva. See the source_flow_config.source_connector_properties.veeva Block for details.</summary>
    [JsonPropertyName("veeva")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesVeeva? Veeva { get; set; }

    /// <summary>Information required to query Zendesk. See the source_flow_config.source_connector_properties.zendesk Block for details.</summary>
    [JsonPropertyName("zendesk")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesZendesk? Zendesk { get; set; }
}

/// <summary>Configuration that controls how Amazon AppFlow retrieves data from the source connector. See the source_flow_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderSourceFlowConfig
{
    /// <summary>API version that the source connector uses.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Name of the connector profile. Must be unique for each connector profile in the AWS account.</summary>
    [JsonPropertyName("connectorProfileName")]
    public string? ConnectorProfileName { get; set; }

    /// <summary>Type of connector, such as Salesforce, Amplitude, and so on. Valid values are Salesforce, Singular, Slack, Redshift, S3, Marketo, Googleanalytics, Zendesk, Servicenow, Datadog, Trendmicro, Snowflake, Dynatrace, Infornexus, Amplitude, Veeva, EventBridge, LookoutMetrics, Upsolver, Honeycode, CustomerProfiles, SAPOData, and CustomConnector.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>Configuration for a scheduled incremental data pull. When a valid configuration is provided, the specified fields are used when querying for the incremental data pull. See the source_flow_config.incremental_pull_config Block for details.</summary>
    [JsonPropertyName("incrementalPullConfig")]
    public V1beta1FlowSpecForProviderSourceFlowConfigIncrementalPullConfig? IncrementalPullConfig { get; set; }

    /// <summary>Information required to query a particular source connector. See the source_flow_config.source_connector_properties Block for details.</summary>
    [JsonPropertyName("sourceConnectorProperties")]
    public V1beta1FlowSpecForProviderSourceFlowConfigSourceConnectorProperties? SourceConnectorProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderTaskConnectorOperator
{
    /// <summary>Operation to be performed on the provided Amplitude source fields. The only valid value is BETWEEN.</summary>
    [JsonPropertyName("amplitude")]
    public string? Amplitude { get; set; }

    /// <summary>Operators supported by the custom connector. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("customConnector")]
    public string? CustomConnector { get; set; }

    /// <summary>Operation to be performed on the provided Datadog source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("datadog")]
    public string? Datadog { get; set; }

    /// <summary>Operation to be performed on the provided Dynatrace source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("dynatrace")]
    public string? Dynatrace { get; set; }

    /// <summary>Operation to be performed on the provided Google Analytics source fields. Valid values are PROJECTION and BETWEEN.</summary>
    [JsonPropertyName("googleAnalytics")]
    public string? GoogleAnalytics { get; set; }

    /// <summary>Operation to be performed on the provided Infor Nexus source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("inforNexus")]
    public string? InforNexus { get; set; }

    /// <summary>Operation to be performed on the provided Marketo source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("marketo")]
    public string? Marketo { get; set; }

    /// <summary>Operation to be performed on the provided Amazon S3 source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("s3")]
    public string? S3 { get; set; }

    /// <summary>Operation to be performed on the provided Salesforce source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("salesforce")]
    public string? Salesforce { get; set; }

    /// <summary>Operation to be performed on the provided SAPOData source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("sapoData")]
    public string? SapoData { get; set; }

    /// <summary>Operation to be performed on the provided ServiceNow source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("serviceNow")]
    public string? ServiceNow { get; set; }

    /// <summary>Operation to be performed on the provided Singular source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("singular")]
    public string? Singular { get; set; }

    /// <summary>Operation to be performed on the provided Slack source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("slack")]
    public string? Slack { get; set; }

    /// <summary>Operation to be performed on the provided Trend Micro source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("trendmicro")]
    public string? Trendmicro { get; set; }

    /// <summary>Operation to be performed on the provided Veeva source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("veeva")]
    public string? Veeva { get; set; }

    /// <summary>Operation to be performed on the provided Zendesk source fields. Valid values are PROJECTION, GREATER_THAN, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("zendesk")]
    public string? Zendesk { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderTask
{
    /// <summary>Operation to be performed on the provided source fields. See the task.connector_operator Block for details.</summary>
    [JsonPropertyName("connectorOperator")]
    public IList<V1beta1FlowSpecForProviderTaskConnectorOperator>? ConnectorOperator { get; set; }

    /// <summary>Field in a destination connector, or a field value against which Amazon AppFlow validates a source field.</summary>
    [JsonPropertyName("destinationField")]
    public string? DestinationField { get; set; }

    /// <summary>Source fields to which a particular task is applied.</summary>
    [JsonPropertyName("sourceFields")]
    public IList<string>? SourceFields { get; set; }

    /// <summary>Map used to store task-related information. The execution service looks for particular information based on the TaskType. Valid keys are VALUE, VALUES, DATA_TYPE, UPPER_BOUND, LOWER_BOUND, SOURCE_DATA_TYPE, DESTINATION_DATA_TYPE, VALIDATION_ACTION, MASK_VALUE, MASK_LENGTH, TRUNCATE_LENGTH, MATH_OPERATION_FIELDS_ORDER, CONCAT_FORMAT, SUBFIELD_CATEGORY_MAP, and EXCLUDE_SOURCE_FIELDS_LIST.</summary>
    [JsonPropertyName("taskProperties")]
    public IDictionary<string, string>? TaskProperties { get; set; }

    /// <summary>Particular task implementation that Amazon AppFlow performs. Valid values are Arithmetic, Filter, Map, Map_all, Mask, Merge, Passthrough, Truncate, and Validate.</summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }
}

/// <summary>Configuration details of a schedule-triggered flow. See the trigger_config.trigger_properties.scheduled Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderTriggerConfigTriggerPropertiesScheduled
{
    /// <summary>Whether a scheduled flow has an incremental data transfer or a complete data transfer for each flow run. Valid values are Incremental and Complete.</summary>
    [JsonPropertyName("dataPullMode")]
    public string? DataPullMode { get; set; }

    /// <summary>Date range for the records to import from the connector in the first flow run. Must be a valid RFC3339 timestamp.</summary>
    [JsonPropertyName("firstExecutionFrom")]
    public string? FirstExecutionFrom { get; set; }

    /// <summary>Scheduled end time for a schedule-triggered flow. Must be a valid RFC3339 timestamp.</summary>
    [JsonPropertyName("scheduleEndTime")]
    public string? ScheduleEndTime { get; set; }

    /// <summary>Scheduling expression that determines the rate at which the schedule runs, for example rate(5minutes).</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>Offset that is added to the time interval for a schedule-triggered flow. Maximum value of 36000.</summary>
    [JsonPropertyName("scheduleOffset")]
    public double? ScheduleOffset { get; set; }

    /// <summary>Scheduled start time for a schedule-triggered flow. Must be a valid RFC3339 timestamp.</summary>
    [JsonPropertyName("scheduleStartTime")]
    public string? ScheduleStartTime { get; set; }

    /// <summary>Time zone used when referring to the date and time of a scheduled-triggered flow, such as America/New_York.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>Configuration details of a schedule-triggered flow as defined by the user. Currently, these settings only apply to the Scheduled trigger type. See the trigger_config.trigger_properties Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderTriggerConfigTriggerProperties
{
    /// <summary>Configuration details of a schedule-triggered flow. See the trigger_config.trigger_properties.scheduled Block for details.</summary>
    [JsonPropertyName("scheduled")]
    public V1beta1FlowSpecForProviderTriggerConfigTriggerPropertiesScheduled? Scheduled { get; set; }
}

/// <summary>Configuration that determines how and when the flow runs. See the trigger_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProviderTriggerConfig
{
    /// <summary>Configuration details of a schedule-triggered flow as defined by the user. Currently, these settings only apply to the Scheduled trigger type. See the trigger_config.trigger_properties Block for details.</summary>
    [JsonPropertyName("triggerProperties")]
    public V1beta1FlowSpecForProviderTriggerConfigTriggerProperties? TriggerProperties { get; set; }

    /// <summary>Type of flow trigger. Valid values are Scheduled, Event, and OnDemand.</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecForProvider
{
    /// <summary>Description of the flow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration that controls how Amazon AppFlow places data in the destination connector. See the destination_flow_config Block for details.</summary>
    [JsonPropertyName("destinationFlowConfig")]
    public IList<V1beta1FlowSpecForProviderDestinationFlowConfig>? DestinationFlowConfig { get; set; }

    /// <summary>ARN of the KMS key you provide for encryption. Required if you do not want to use the Amazon AppFlow-managed KMS key. Uses the Amazon AppFlow-managed KMS key when not provided.</summary>
    [JsonPropertyName("kmsArn")]
    public string? KmsArn { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow catalogs the data that the flow transfers. See the metadata_catalog_config Block for details.</summary>
    [JsonPropertyName("metadataCatalogConfig")]
    public V1beta1FlowSpecForProviderMetadataCatalogConfig? MetadataCatalogConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration that controls how Amazon AppFlow retrieves data from the source connector. See the source_flow_config Block for details.</summary>
    [JsonPropertyName("sourceFlowConfig")]
    public V1beta1FlowSpecForProviderSourceFlowConfig? SourceFlowConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Tasks that Amazon AppFlow performs while transferring the data in the flow run. See the task Block for details.</summary>
    [JsonPropertyName("task")]
    public IList<V1beta1FlowSpecForProviderTask>? Task { get; set; }

    /// <summary>Configuration that determines how and when the flow runs. See the trigger_config Block for details.</summary>
    [JsonPropertyName("triggerConfig")]
    public V1beta1FlowSpecForProviderTriggerConfig? TriggerConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the custom connector as destination. See the destination_flow_config.destination_connector_properties.custom_connector.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query the custom connector. See the destination_flow_config.destination_connector_properties.custom_connector Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnector
{
    /// <summary>Custom properties specific to the connector when it&apos;s used as a destination in the flow. Maximum of 50 items.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>Entity specified in the custom connector as a destination in the flow.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the custom connector as destination. See the destination_flow_config.destination_connector_properties.custom_connector.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Properties required to query Amazon Connect Customer Profiles. See the destination_flow_config.destination_connector_properties.customer_profiles Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles
{
    /// <summary>Unique name of the Amazon Connect Customer Profiles domain.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Object specified in the Amazon Connect Customer Profiles flow destination.</summary>
    [JsonPropertyName("objectTypeName")]
    public string? ObjectTypeName { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.event_bridge.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridgeErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Amazon EventBridge. See the destination_flow_config.destination_connector_properties.event_bridge Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridge
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.event_bridge.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridgeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.honeycode.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Amazon Honeycode. See the destination_flow_config.destination_connector_properties.honeycode Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycode
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.honeycode.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics
{
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.marketo.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesMarketoErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Marketo. See the destination_flow_config.destination_connector_properties.marketo Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesMarketo
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.marketo.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesMarketoErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.redshift.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Amazon Redshift. See the destination_flow_config.destination_connector_properties.redshift Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesRedshift
{
    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.redshift.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Intermediate bucket that Amazon AppFlow uses when moving data into Amazon Redshift.</summary>
    [JsonPropertyName("intermediateBucketName")]
    public string? IntermediateBucketName { get; set; }

    /// <summary>Object specified in the Amazon Redshift flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelector
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
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Aggregation settings that you can use to customize the output format of your flow data. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config.aggregation_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig
{
    /// <summary>Whether Amazon AppFlow aggregates the flow records into a single file, or leaves them unaggregated. Valid values are None and SingleFile.</summary>
    [JsonPropertyName("aggregationType")]
    public string? AggregationType { get; set; }

    /// <summary>Desired file size, in MB, for each output file that Amazon AppFlow writes to the flow destination.</summary>
    [JsonPropertyName("targetFileSize")]
    public double? TargetFileSize { get; set; }
}

/// <summary>Prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config.prefix_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig
{
    /// <summary>Level of granularity included in the prefix. Valid values are YEAR, MONTH, DAY, HOUR, and MINUTE.</summary>
    [JsonPropertyName("prefixFormat")]
    public string? PrefixFormat { get; set; }

    /// <summary>Whether the destination file path includes either or both of the selected elements. Valid values are EXECUTION_ID and SCHEMA_VERSION.</summary>
    [JsonPropertyName("prefixHierarchy")]
    public IList<string>? PrefixHierarchy { get; set; }

    /// <summary>Format of the prefix, and whether it applies to the file name, file path, or both. Valid values are FILENAME, PATH, and PATH_AND_FILENAME.</summary>
    [JsonPropertyName("prefixType")]
    public string? PrefixType { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow formats the flow output data when Amazon S3 is used as the destination. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig
{
    /// <summary>Aggregation settings that you can use to customize the output format of your flow data. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config.aggregation_config Block for details.</summary>
    [JsonPropertyName("aggregationConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig? AggregationConfig { get; set; }

    /// <summary>File type that Amazon AppFlow places in the Amazon S3 bucket. Valid values are CSV, JSON, and PARQUET.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>Prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config.prefix_config Block for details.</summary>
    [JsonPropertyName("prefixConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig? PrefixConfig { get; set; }

    /// <summary>Whether to preserve the data types from the source system. Only valid for the PARQUET file type.</summary>
    [JsonPropertyName("preserveSourceDataTyping")]
    public bool? PreserveSourceDataTyping { get; set; }
}

/// <summary>Properties required to query Amazon S3. See the destination_flow_config.destination_connector_properties.s3 Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow formats the flow output data when Amazon S3 is used as the destination. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config Block for details.</summary>
    [JsonPropertyName("s3OutputFormatConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig? S3OutputFormatConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.salesforce.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforceErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Salesforce. See the destination_flow_config.destination_connector_properties.salesforce Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforce
{
    /// <summary>Salesforce API used by Amazon AppFlow when the flow transfers data to Salesforce.</summary>
    [JsonPropertyName("dataTransferApi")]
    public string? DataTransferApi { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.salesforce.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforceErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update or delete.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Type of write operation to be performed in Salesforce. When the value is UPSERT, id_field_names is required. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.sapo_data.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles the success response it gets from the connector after placing data. See the destination_flow_config.destination_connector_properties.sapo_data.success_response_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }
}

/// <summary>Properties required to query SAPOData. See the destination_flow_config.destination_connector_properties.sapo_data Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSapoData
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.sapo_data.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update or delete.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object path specified in the SAPOData flow destination.</summary>
    [JsonPropertyName("objectPath")]
    public string? ObjectPath { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles the success response it gets from the connector after placing data. See the destination_flow_config.destination_connector_properties.sapo_data.success_response_handling_config Block for details.</summary>
    [JsonPropertyName("successResponseHandlingConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig? SuccessResponseHandlingConfig { get; set; }

    /// <summary>Possible write operations in the destination connector. Defaults to INSERT when not provided. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.snowflake.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflakeErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Snowflake. See the destination_flow_config.destination_connector_properties.snowflake Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflake
{
    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.snowflake.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflakeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Intermediate bucket that Amazon AppFlow uses when moving data into Amazon Snowflake.</summary>
    [JsonPropertyName("intermediateBucketName")]
    public string? IntermediateBucketName { get; set; }

    /// <summary>Object specified in the Amazon Snowflake flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Aggregation settings that you can use to customize the output format of your flow data. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config.aggregation_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig
{
    /// <summary>Whether Amazon AppFlow aggregates the flow records into a single file, or leaves them unaggregated. Valid values are None and SingleFile.</summary>
    [JsonPropertyName("aggregationType")]
    public string? AggregationType { get; set; }
}

/// <summary>Prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config.prefix_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig
{
    /// <summary>Level of granularity included in the prefix. Valid values are YEAR, MONTH, DAY, HOUR, and MINUTE.</summary>
    [JsonPropertyName("prefixFormat")]
    public string? PrefixFormat { get; set; }

    /// <summary>Whether the destination file path includes either or both of the selected elements. Valid values are EXECUTION_ID and SCHEMA_VERSION.</summary>
    [JsonPropertyName("prefixHierarchy")]
    public IList<string>? PrefixHierarchy { get; set; }

    /// <summary>Format of the prefix, and whether it applies to the file name, file path, or both. Valid values are FILENAME, PATH, and PATH_AND_FILENAME.</summary>
    [JsonPropertyName("prefixType")]
    public string? PrefixType { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow formats the flow output data when Upsolver is used as the destination. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig
{
    /// <summary>Aggregation settings that you can use to customize the output format of your flow data. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config.aggregation_config Block for details.</summary>
    [JsonPropertyName("aggregationConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig? AggregationConfig { get; set; }

    /// <summary>File type that Amazon AppFlow places in the Upsolver Amazon S3 bucket. Valid values are CSV, JSON, and PARQUET.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>Prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config.prefix_config Block for details.</summary>
    [JsonPropertyName("prefixConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig? PrefixConfig { get; set; }
}

/// <summary>Properties required to query Upsolver. See the destination_flow_config.destination_connector_properties.upsolver Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolver
{
    /// <summary>Upsolver Amazon S3 bucket name in which Amazon AppFlow places the transferred data. Must begin with upsolver-appflow.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the Upsolver Amazon S3 bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow formats the flow output data when Upsolver is used as the destination. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config Block for details.</summary>
    [JsonPropertyName("s3OutputFormatConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig? S3OutputFormatConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.zendesk.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Zendesk. See the destination_flow_config.destination_connector_properties.zendesk Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesZendesk
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.zendesk.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update or delete.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Type of write operation to be performed in Zendesk. When the value is UPSERT, id_field_names is required. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Information required to query a particular connector. See the destination_flow_config.destination_connector_properties Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorProperties
{
    /// <summary>Properties required to query the custom connector. See the destination_flow_config.destination_connector_properties.custom_connector Block for details.</summary>
    [JsonPropertyName("customConnector")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnector? CustomConnector { get; set; }

    /// <summary>Properties required to query Amazon Connect Customer Profiles. See the destination_flow_config.destination_connector_properties.customer_profiles Block for details.</summary>
    [JsonPropertyName("customerProfiles")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles? CustomerProfiles { get; set; }

    /// <summary>Properties required to query Amazon EventBridge. See the destination_flow_config.destination_connector_properties.event_bridge Block for details.</summary>
    [JsonPropertyName("eventBridge")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridge? EventBridge { get; set; }

    /// <summary>Properties required to query Amazon Honeycode. See the destination_flow_config.destination_connector_properties.honeycode Block for details.</summary>
    [JsonPropertyName("honeycode")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycode? Honeycode { get; set; }

    [JsonPropertyName("lookoutMetrics")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics? LookoutMetrics { get; set; }

    /// <summary>Properties required to query Marketo. See the destination_flow_config.destination_connector_properties.marketo Block for details.</summary>
    [JsonPropertyName("marketo")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesMarketo? Marketo { get; set; }

    /// <summary>Properties required to query Amazon Redshift. See the destination_flow_config.destination_connector_properties.redshift Block for details.</summary>
    [JsonPropertyName("redshift")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesRedshift? Redshift { get; set; }

    /// <summary>Properties required to query Amazon S3. See the destination_flow_config.destination_connector_properties.s3 Block for details.</summary>
    [JsonPropertyName("s3")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3? S3 { get; set; }

    /// <summary>Properties required to query Salesforce. See the destination_flow_config.destination_connector_properties.salesforce Block for details.</summary>
    [JsonPropertyName("salesforce")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforce? Salesforce { get; set; }

    /// <summary>Properties required to query SAPOData. See the destination_flow_config.destination_connector_properties.sapo_data Block for details.</summary>
    [JsonPropertyName("sapoData")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSapoData? SapoData { get; set; }

    /// <summary>Properties required to query Snowflake. See the destination_flow_config.destination_connector_properties.snowflake Block for details.</summary>
    [JsonPropertyName("snowflake")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflake? Snowflake { get; set; }

    /// <summary>Properties required to query Upsolver. See the destination_flow_config.destination_connector_properties.upsolver Block for details.</summary>
    [JsonPropertyName("upsolver")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolver? Upsolver { get; set; }

    /// <summary>Properties required to query Zendesk. See the destination_flow_config.destination_connector_properties.zendesk Block for details.</summary>
    [JsonPropertyName("zendesk")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesZendesk? Zendesk { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderDestinationFlowConfig
{
    /// <summary>API version that the destination connector uses.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Name of the connector profile. Must be unique for each connector profile in the AWS account.</summary>
    [JsonPropertyName("connectorProfileName")]
    public string? ConnectorProfileName { get; set; }

    /// <summary>Type of connector, such as Salesforce, Amplitude, and so on. Valid values are Salesforce, Singular, Slack, Redshift, S3, Marketo, Googleanalytics, Zendesk, Servicenow, Datadog, Trendmicro, Snowflake, Dynatrace, Infornexus, Amplitude, Veeva, EventBridge, LookoutMetrics, Upsolver, Honeycode, CustomerProfiles, SAPOData, and CustomConnector.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>Information required to query a particular connector. See the destination_flow_config.destination_connector_properties Block for details.</summary>
    [JsonPropertyName("destinationConnectorProperties")]
    public V1beta1FlowSpecInitProviderDestinationFlowConfigDestinationConnectorProperties? DestinationConnectorProperties { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow catalogs data with the AWS Glue Data Catalog. See the metadata_catalog_config.glue_data_catalog Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderMetadataCatalogConfigGlueDataCatalog
{
    /// <summary>Name of an existing Glue database to store the metadata tables that Amazon AppFlow creates.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>ARN of the IAM role that grants Amazon AppFlow the permissions it needs to create Data Catalog tables, databases, and partitions.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Naming prefix for each Data Catalog table that Amazon AppFlow creates.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow catalogs the data that the flow transfers. See the metadata_catalog_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderMetadataCatalogConfig
{
    /// <summary>Configuration that determines how Amazon AppFlow catalogs data with the AWS Glue Data Catalog. See the metadata_catalog_config.glue_data_catalog Block for details.</summary>
    [JsonPropertyName("glueDataCatalog")]
    public V1beta1FlowSpecInitProviderMetadataCatalogConfigGlueDataCatalog? GlueDataCatalog { get; set; }
}

/// <summary>Configuration for a scheduled incremental data pull. When a valid configuration is provided, the specified fields are used when querying for the incremental data pull. See the source_flow_config.incremental_pull_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigIncrementalPullConfig
{
    /// <summary>Field that specifies the date time or timestamp field as the criteria to use when importing incremental records from the source.</summary>
    [JsonPropertyName("datetimeTypeFieldName")]
    public string? DatetimeTypeFieldName { get; set; }
}

/// <summary>Information required to query Amplitude. See the source_flow_config.source_connector_properties.amplitude Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesAmplitude
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Properties applied when the custom connector is used as a source. See the source_flow_config.source_connector_properties.custom_connector Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesCustomConnector
{
    /// <summary>Custom properties specific to the connector when it&apos;s used as a source in the flow. Maximum of 50 items.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>Entity specified in the custom connector as a source in the flow.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }
}

/// <summary>Information required to query Datadog. See the source_flow_config.source_connector_properties.datadog Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesDatadog
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Dynatrace. See the source_flow_config.source_connector_properties.dynatrace Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesDynatrace
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Google Analytics. See the source_flow_config.source_connector_properties.google_analytics Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Infor Nexus. See the source_flow_config.source_connector_properties.infor_nexus Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesInforNexus
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Marketo. See the source_flow_config.source_connector_properties.marketo Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesMarketo
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelector
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
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>When you use Amazon S3 as the source, configuration format that you provide for the flow input data. See the source_flow_config.source_connector_properties.s3.s3_input_format_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig
{
    /// <summary>File type that Amazon AppFlow gets from your Amazon S3 bucket. Valid values are CSV and JSON.</summary>
    [JsonPropertyName("s3InputFileType")]
    public string? S3InputFileType { get; set; }
}

/// <summary>Information required to query Amazon S3. See the source_flow_config.source_connector_properties.s3 Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3
{
    /// <summary>Amazon S3 bucket name where the source files are stored.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Object key for the Amazon S3 bucket in which the source files are stored.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>When you use Amazon S3 as the source, configuration format that you provide for the flow input data. See the source_flow_config.source_connector_properties.s3.s3_input_format_config Block for details.</summary>
    [JsonPropertyName("s3InputFormatConfig")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig? S3InputFormatConfig { get; set; }
}

/// <summary>Information required to query Salesforce. See the source_flow_config.source_connector_properties.salesforce Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSalesforce
{
    /// <summary>Salesforce API used by Amazon AppFlow when the flow transfers data from Salesforce.</summary>
    [JsonPropertyName("dataTransferApi")]
    public string? DataTransferApi { get; set; }

    /// <summary>Whether to enable dynamic fetching of new (recently added) fields in the Salesforce objects while running a flow.</summary>
    [JsonPropertyName("enableDynamicFieldUpdate")]
    public bool? EnableDynamicFieldUpdate { get; set; }

    /// <summary>Whether to include deleted files in the flow run.</summary>
    [JsonPropertyName("includeDeletedRecords")]
    public bool? IncludeDeletedRecords { get; set; }

    /// <summary>Object specified in the Salesforce flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Page size for each concurrent process that transfers OData records from your SAP instance. See the source_flow_config.source_connector_properties.sapo_data.pagination_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig
{
    /// <summary>Maximum number of records that Amazon AppFlow receives in each page of the response from your SAP application.</summary>
    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }
}

/// <summary>Number of concurrent processes that transfer OData records from your SAP instance. See the source_flow_config.source_connector_properties.sapo_data.parallelism_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig
{
    /// <summary>Maximum number of processes that Amazon AppFlow runs at the same time when it retrieves your data from your SAP application.</summary>
    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }
}

/// <summary>Information required to query SAPOData as a flow source. See the source_flow_config.source_connector_properties.sapo_data Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSapoData
{
    /// <summary>Object path specified in the SAPOData flow source.</summary>
    [JsonPropertyName("objectPath")]
    public string? ObjectPath { get; set; }

    /// <summary>Page size for each concurrent process that transfers OData records from your SAP instance. See the source_flow_config.source_connector_properties.sapo_data.pagination_config Block for details.</summary>
    [JsonPropertyName("paginationConfig")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig? PaginationConfig { get; set; }

    /// <summary>Number of concurrent processes that transfer OData records from your SAP instance. See the source_flow_config.source_connector_properties.sapo_data.parallelism_config Block for details.</summary>
    [JsonPropertyName("parallelismConfig")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig? ParallelismConfig { get; set; }
}

/// <summary>Information required to query ServiceNow. See the source_flow_config.source_connector_properties.service_now Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesServiceNow
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Singular. See the source_flow_config.source_connector_properties.singular Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSingular
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Slack. See the source_flow_config.source_connector_properties.slack Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSlack
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Trend Micro. See the source_flow_config.source_connector_properties.trendmicro Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesTrendmicro
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Veeva. See the source_flow_config.source_connector_properties.veeva Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesVeeva
{
    /// <summary>Document type specified in the Veeva document extract flow.</summary>
    [JsonPropertyName("documentType")]
    public string? DocumentType { get; set; }

    /// <summary>Whether to include all versions of files in the Veeva document extract flow.</summary>
    [JsonPropertyName("includeAllVersions")]
    public bool? IncludeAllVersions { get; set; }

    /// <summary>Whether to include file renditions in the Veeva document extract flow.</summary>
    [JsonPropertyName("includeRenditions")]
    public bool? IncludeRenditions { get; set; }

    /// <summary>Whether to include source files in the Veeva document extract flow.</summary>
    [JsonPropertyName("includeSourceFiles")]
    public bool? IncludeSourceFiles { get; set; }

    /// <summary>Object specified in the Veeva flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Zendesk. See the source_flow_config.source_connector_properties.zendesk Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesZendesk
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query a particular source connector. See the source_flow_config.source_connector_properties Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorProperties
{
    /// <summary>Information required to query Amplitude. See the source_flow_config.source_connector_properties.amplitude Block for details.</summary>
    [JsonPropertyName("amplitude")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesAmplitude? Amplitude { get; set; }

    /// <summary>Properties applied when the custom connector is used as a source. See the source_flow_config.source_connector_properties.custom_connector Block for details.</summary>
    [JsonPropertyName("customConnector")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesCustomConnector? CustomConnector { get; set; }

    /// <summary>Information required to query Datadog. See the source_flow_config.source_connector_properties.datadog Block for details.</summary>
    [JsonPropertyName("datadog")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesDatadog? Datadog { get; set; }

    /// <summary>Information required to query Dynatrace. See the source_flow_config.source_connector_properties.dynatrace Block for details.</summary>
    [JsonPropertyName("dynatrace")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesDynatrace? Dynatrace { get; set; }

    /// <summary>Information required to query Google Analytics. See the source_flow_config.source_connector_properties.google_analytics Block for details.</summary>
    [JsonPropertyName("googleAnalytics")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics? GoogleAnalytics { get; set; }

    /// <summary>Information required to query Infor Nexus. See the source_flow_config.source_connector_properties.infor_nexus Block for details.</summary>
    [JsonPropertyName("inforNexus")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesInforNexus? InforNexus { get; set; }

    /// <summary>Information required to query Marketo. See the source_flow_config.source_connector_properties.marketo Block for details.</summary>
    [JsonPropertyName("marketo")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesMarketo? Marketo { get; set; }

    /// <summary>Information required to query Amazon S3. See the source_flow_config.source_connector_properties.s3 Block for details.</summary>
    [JsonPropertyName("s3")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3? S3 { get; set; }

    /// <summary>Information required to query Salesforce. See the source_flow_config.source_connector_properties.salesforce Block for details.</summary>
    [JsonPropertyName("salesforce")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSalesforce? Salesforce { get; set; }

    /// <summary>Information required to query SAPOData as a flow source. See the source_flow_config.source_connector_properties.sapo_data Block for details.</summary>
    [JsonPropertyName("sapoData")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSapoData? SapoData { get; set; }

    /// <summary>Information required to query ServiceNow. See the source_flow_config.source_connector_properties.service_now Block for details.</summary>
    [JsonPropertyName("serviceNow")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesServiceNow? ServiceNow { get; set; }

    /// <summary>Information required to query Singular. See the source_flow_config.source_connector_properties.singular Block for details.</summary>
    [JsonPropertyName("singular")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSingular? Singular { get; set; }

    /// <summary>Information required to query Slack. See the source_flow_config.source_connector_properties.slack Block for details.</summary>
    [JsonPropertyName("slack")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSlack? Slack { get; set; }

    /// <summary>Information required to query Trend Micro. See the source_flow_config.source_connector_properties.trendmicro Block for details.</summary>
    [JsonPropertyName("trendmicro")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesTrendmicro? Trendmicro { get; set; }

    /// <summary>Information required to query Veeva. See the source_flow_config.source_connector_properties.veeva Block for details.</summary>
    [JsonPropertyName("veeva")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesVeeva? Veeva { get; set; }

    /// <summary>Information required to query Zendesk. See the source_flow_config.source_connector_properties.zendesk Block for details.</summary>
    [JsonPropertyName("zendesk")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesZendesk? Zendesk { get; set; }
}

/// <summary>Configuration that controls how Amazon AppFlow retrieves data from the source connector. See the source_flow_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderSourceFlowConfig
{
    /// <summary>API version that the source connector uses.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Name of the connector profile. Must be unique for each connector profile in the AWS account.</summary>
    [JsonPropertyName("connectorProfileName")]
    public string? ConnectorProfileName { get; set; }

    /// <summary>Type of connector, such as Salesforce, Amplitude, and so on. Valid values are Salesforce, Singular, Slack, Redshift, S3, Marketo, Googleanalytics, Zendesk, Servicenow, Datadog, Trendmicro, Snowflake, Dynatrace, Infornexus, Amplitude, Veeva, EventBridge, LookoutMetrics, Upsolver, Honeycode, CustomerProfiles, SAPOData, and CustomConnector.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>Configuration for a scheduled incremental data pull. When a valid configuration is provided, the specified fields are used when querying for the incremental data pull. See the source_flow_config.incremental_pull_config Block for details.</summary>
    [JsonPropertyName("incrementalPullConfig")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigIncrementalPullConfig? IncrementalPullConfig { get; set; }

    /// <summary>Information required to query a particular source connector. See the source_flow_config.source_connector_properties Block for details.</summary>
    [JsonPropertyName("sourceConnectorProperties")]
    public V1beta1FlowSpecInitProviderSourceFlowConfigSourceConnectorProperties? SourceConnectorProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderTaskConnectorOperator
{
    /// <summary>Operation to be performed on the provided Amplitude source fields. The only valid value is BETWEEN.</summary>
    [JsonPropertyName("amplitude")]
    public string? Amplitude { get; set; }

    /// <summary>Operators supported by the custom connector. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("customConnector")]
    public string? CustomConnector { get; set; }

    /// <summary>Operation to be performed on the provided Datadog source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("datadog")]
    public string? Datadog { get; set; }

    /// <summary>Operation to be performed on the provided Dynatrace source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("dynatrace")]
    public string? Dynatrace { get; set; }

    /// <summary>Operation to be performed on the provided Google Analytics source fields. Valid values are PROJECTION and BETWEEN.</summary>
    [JsonPropertyName("googleAnalytics")]
    public string? GoogleAnalytics { get; set; }

    /// <summary>Operation to be performed on the provided Infor Nexus source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("inforNexus")]
    public string? InforNexus { get; set; }

    /// <summary>Operation to be performed on the provided Marketo source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("marketo")]
    public string? Marketo { get; set; }

    /// <summary>Operation to be performed on the provided Amazon S3 source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("s3")]
    public string? S3 { get; set; }

    /// <summary>Operation to be performed on the provided Salesforce source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("salesforce")]
    public string? Salesforce { get; set; }

    /// <summary>Operation to be performed on the provided SAPOData source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("sapoData")]
    public string? SapoData { get; set; }

    /// <summary>Operation to be performed on the provided ServiceNow source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("serviceNow")]
    public string? ServiceNow { get; set; }

    /// <summary>Operation to be performed on the provided Singular source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("singular")]
    public string? Singular { get; set; }

    /// <summary>Operation to be performed on the provided Slack source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("slack")]
    public string? Slack { get; set; }

    /// <summary>Operation to be performed on the provided Trend Micro source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("trendmicro")]
    public string? Trendmicro { get; set; }

    /// <summary>Operation to be performed on the provided Veeva source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("veeva")]
    public string? Veeva { get; set; }

    /// <summary>Operation to be performed on the provided Zendesk source fields. Valid values are PROJECTION, GREATER_THAN, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("zendesk")]
    public string? Zendesk { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderTask
{
    /// <summary>Operation to be performed on the provided source fields. See the task.connector_operator Block for details.</summary>
    [JsonPropertyName("connectorOperator")]
    public IList<V1beta1FlowSpecInitProviderTaskConnectorOperator>? ConnectorOperator { get; set; }

    /// <summary>Field in a destination connector, or a field value against which Amazon AppFlow validates a source field.</summary>
    [JsonPropertyName("destinationField")]
    public string? DestinationField { get; set; }

    /// <summary>Source fields to which a particular task is applied.</summary>
    [JsonPropertyName("sourceFields")]
    public IList<string>? SourceFields { get; set; }

    /// <summary>Map used to store task-related information. The execution service looks for particular information based on the TaskType. Valid keys are VALUE, VALUES, DATA_TYPE, UPPER_BOUND, LOWER_BOUND, SOURCE_DATA_TYPE, DESTINATION_DATA_TYPE, VALIDATION_ACTION, MASK_VALUE, MASK_LENGTH, TRUNCATE_LENGTH, MATH_OPERATION_FIELDS_ORDER, CONCAT_FORMAT, SUBFIELD_CATEGORY_MAP, and EXCLUDE_SOURCE_FIELDS_LIST.</summary>
    [JsonPropertyName("taskProperties")]
    public IDictionary<string, string>? TaskProperties { get; set; }

    /// <summary>Particular task implementation that Amazon AppFlow performs. Valid values are Arithmetic, Filter, Map, Map_all, Mask, Merge, Passthrough, Truncate, and Validate.</summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }
}

/// <summary>Configuration details of a schedule-triggered flow. See the trigger_config.trigger_properties.scheduled Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderTriggerConfigTriggerPropertiesScheduled
{
    /// <summary>Whether a scheduled flow has an incremental data transfer or a complete data transfer for each flow run. Valid values are Incremental and Complete.</summary>
    [JsonPropertyName("dataPullMode")]
    public string? DataPullMode { get; set; }

    /// <summary>Date range for the records to import from the connector in the first flow run. Must be a valid RFC3339 timestamp.</summary>
    [JsonPropertyName("firstExecutionFrom")]
    public string? FirstExecutionFrom { get; set; }

    /// <summary>Scheduled end time for a schedule-triggered flow. Must be a valid RFC3339 timestamp.</summary>
    [JsonPropertyName("scheduleEndTime")]
    public string? ScheduleEndTime { get; set; }

    /// <summary>Scheduling expression that determines the rate at which the schedule runs, for example rate(5minutes).</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>Offset that is added to the time interval for a schedule-triggered flow. Maximum value of 36000.</summary>
    [JsonPropertyName("scheduleOffset")]
    public double? ScheduleOffset { get; set; }

    /// <summary>Scheduled start time for a schedule-triggered flow. Must be a valid RFC3339 timestamp.</summary>
    [JsonPropertyName("scheduleStartTime")]
    public string? ScheduleStartTime { get; set; }

    /// <summary>Time zone used when referring to the date and time of a scheduled-triggered flow, such as America/New_York.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>Configuration details of a schedule-triggered flow as defined by the user. Currently, these settings only apply to the Scheduled trigger type. See the trigger_config.trigger_properties Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderTriggerConfigTriggerProperties
{
    /// <summary>Configuration details of a schedule-triggered flow. See the trigger_config.trigger_properties.scheduled Block for details.</summary>
    [JsonPropertyName("scheduled")]
    public V1beta1FlowSpecInitProviderTriggerConfigTriggerPropertiesScheduled? Scheduled { get; set; }
}

/// <summary>Configuration that determines how and when the flow runs. See the trigger_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpecInitProviderTriggerConfig
{
    /// <summary>Configuration details of a schedule-triggered flow as defined by the user. Currently, these settings only apply to the Scheduled trigger type. See the trigger_config.trigger_properties Block for details.</summary>
    [JsonPropertyName("triggerProperties")]
    public V1beta1FlowSpecInitProviderTriggerConfigTriggerProperties? TriggerProperties { get; set; }

    /// <summary>Type of flow trigger. Valid values are Scheduled, Event, and OnDemand.</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
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
public partial class V1beta1FlowSpecInitProvider
{
    /// <summary>Description of the flow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration that controls how Amazon AppFlow places data in the destination connector. See the destination_flow_config Block for details.</summary>
    [JsonPropertyName("destinationFlowConfig")]
    public IList<V1beta1FlowSpecInitProviderDestinationFlowConfig>? DestinationFlowConfig { get; set; }

    /// <summary>ARN of the KMS key you provide for encryption. Required if you do not want to use the Amazon AppFlow-managed KMS key. Uses the Amazon AppFlow-managed KMS key when not provided.</summary>
    [JsonPropertyName("kmsArn")]
    public string? KmsArn { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow catalogs the data that the flow transfers. See the metadata_catalog_config Block for details.</summary>
    [JsonPropertyName("metadataCatalogConfig")]
    public V1beta1FlowSpecInitProviderMetadataCatalogConfig? MetadataCatalogConfig { get; set; }

    /// <summary>Configuration that controls how Amazon AppFlow retrieves data from the source connector. See the source_flow_config Block for details.</summary>
    [JsonPropertyName("sourceFlowConfig")]
    public V1beta1FlowSpecInitProviderSourceFlowConfig? SourceFlowConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Tasks that Amazon AppFlow performs while transferring the data in the flow run. See the task Block for details.</summary>
    [JsonPropertyName("task")]
    public IList<V1beta1FlowSpecInitProviderTask>? Task { get; set; }

    /// <summary>Configuration that determines how and when the flow runs. See the trigger_config Block for details.</summary>
    [JsonPropertyName("triggerConfig")]
    public V1beta1FlowSpecInitProviderTriggerConfig? TriggerConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecManagementPoliciesEnum>))]
public enum V1beta1FlowSpecManagementPoliciesEnum
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
public partial class V1beta1FlowSpecProviderConfigRef
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
public partial class V1beta1FlowSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>FlowSpec defines the desired state of Flow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1FlowSpecForProvider ForProvider { get; set; }

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
    public V1beta1FlowSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FlowSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FlowSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FlowSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the custom connector as destination. See the destination_flow_config.destination_connector_properties.custom_connector.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query the custom connector. See the destination_flow_config.destination_connector_properties.custom_connector Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnector
{
    /// <summary>Custom properties specific to the connector when it&apos;s used as a destination in the flow. Maximum of 50 items.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>Entity specified in the custom connector as a destination in the flow.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the custom connector as destination. See the destination_flow_config.destination_connector_properties.custom_connector.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Properties required to query Amazon Connect Customer Profiles. See the destination_flow_config.destination_connector_properties.customer_profiles Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles
{
    /// <summary>Unique name of the Amazon Connect Customer Profiles domain.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Object specified in the Amazon Connect Customer Profiles flow destination.</summary>
    [JsonPropertyName("objectTypeName")]
    public string? ObjectTypeName { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.event_bridge.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridgeErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Amazon EventBridge. See the destination_flow_config.destination_connector_properties.event_bridge Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridge
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.event_bridge.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridgeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.honeycode.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Amazon Honeycode. See the destination_flow_config.destination_connector_properties.honeycode Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycode
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.honeycode.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics
{
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.marketo.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesMarketoErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Marketo. See the destination_flow_config.destination_connector_properties.marketo Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesMarketo
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.marketo.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesMarketoErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.redshift.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Amazon Redshift. See the destination_flow_config.destination_connector_properties.redshift Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesRedshift
{
    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.redshift.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Intermediate bucket that Amazon AppFlow uses when moving data into Amazon Redshift.</summary>
    [JsonPropertyName("intermediateBucketName")]
    public string? IntermediateBucketName { get; set; }

    /// <summary>Object specified in the Amazon Redshift flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Aggregation settings that you can use to customize the output format of your flow data. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config.aggregation_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig
{
    /// <summary>Whether Amazon AppFlow aggregates the flow records into a single file, or leaves them unaggregated. Valid values are None and SingleFile.</summary>
    [JsonPropertyName("aggregationType")]
    public string? AggregationType { get; set; }

    /// <summary>Desired file size, in MB, for each output file that Amazon AppFlow writes to the flow destination.</summary>
    [JsonPropertyName("targetFileSize")]
    public double? TargetFileSize { get; set; }
}

/// <summary>Prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config.prefix_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig
{
    /// <summary>Level of granularity included in the prefix. Valid values are YEAR, MONTH, DAY, HOUR, and MINUTE.</summary>
    [JsonPropertyName("prefixFormat")]
    public string? PrefixFormat { get; set; }

    /// <summary>Whether the destination file path includes either or both of the selected elements. Valid values are EXECUTION_ID and SCHEMA_VERSION.</summary>
    [JsonPropertyName("prefixHierarchy")]
    public IList<string>? PrefixHierarchy { get; set; }

    /// <summary>Format of the prefix, and whether it applies to the file name, file path, or both. Valid values are FILENAME, PATH, and PATH_AND_FILENAME.</summary>
    [JsonPropertyName("prefixType")]
    public string? PrefixType { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow formats the flow output data when Amazon S3 is used as the destination. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig
{
    /// <summary>Aggregation settings that you can use to customize the output format of your flow data. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config.aggregation_config Block for details.</summary>
    [JsonPropertyName("aggregationConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig? AggregationConfig { get; set; }

    /// <summary>File type that Amazon AppFlow places in the Amazon S3 bucket. Valid values are CSV, JSON, and PARQUET.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>Prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config.prefix_config Block for details.</summary>
    [JsonPropertyName("prefixConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig? PrefixConfig { get; set; }

    /// <summary>Whether to preserve the data types from the source system. Only valid for the PARQUET file type.</summary>
    [JsonPropertyName("preserveSourceDataTyping")]
    public bool? PreserveSourceDataTyping { get; set; }
}

/// <summary>Properties required to query Amazon S3. See the destination_flow_config.destination_connector_properties.s3 Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow formats the flow output data when Amazon S3 is used as the destination. See the destination_flow_config.destination_connector_properties.s3.s3_output_format_config Block for details.</summary>
    [JsonPropertyName("s3OutputFormatConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig? S3OutputFormatConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.salesforce.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforceErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Salesforce. See the destination_flow_config.destination_connector_properties.salesforce Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforce
{
    /// <summary>Salesforce API used by Amazon AppFlow when the flow transfers data to Salesforce.</summary>
    [JsonPropertyName("dataTransferApi")]
    public string? DataTransferApi { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.salesforce.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforceErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update or delete.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Type of write operation to be performed in Salesforce. When the value is UPSERT, id_field_names is required. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.sapo_data.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles the success response it gets from the connector after placing data. See the destination_flow_config.destination_connector_properties.sapo_data.success_response_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }
}

/// <summary>Properties required to query SAPOData. See the destination_flow_config.destination_connector_properties.sapo_data Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSapoData
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.sapo_data.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update or delete.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object path specified in the SAPOData flow destination.</summary>
    [JsonPropertyName("objectPath")]
    public string? ObjectPath { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles the success response it gets from the connector after placing data. See the destination_flow_config.destination_connector_properties.sapo_data.success_response_handling_config Block for details.</summary>
    [JsonPropertyName("successResponseHandlingConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig? SuccessResponseHandlingConfig { get; set; }

    /// <summary>Possible write operations in the destination connector. Defaults to INSERT when not provided. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.snowflake.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflakeErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Snowflake. See the destination_flow_config.destination_connector_properties.snowflake Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflake
{
    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.snowflake.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflakeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Intermediate bucket that Amazon AppFlow uses when moving data into Amazon Snowflake.</summary>
    [JsonPropertyName("intermediateBucketName")]
    public string? IntermediateBucketName { get; set; }

    /// <summary>Object specified in the Amazon Snowflake flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Aggregation settings that you can use to customize the output format of your flow data. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config.aggregation_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig
{
    /// <summary>Whether Amazon AppFlow aggregates the flow records into a single file, or leaves them unaggregated. Valid values are None and SingleFile.</summary>
    [JsonPropertyName("aggregationType")]
    public string? AggregationType { get; set; }
}

/// <summary>Prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config.prefix_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig
{
    /// <summary>Level of granularity included in the prefix. Valid values are YEAR, MONTH, DAY, HOUR, and MINUTE.</summary>
    [JsonPropertyName("prefixFormat")]
    public string? PrefixFormat { get; set; }

    /// <summary>Whether the destination file path includes either or both of the selected elements. Valid values are EXECUTION_ID and SCHEMA_VERSION.</summary>
    [JsonPropertyName("prefixHierarchy")]
    public IList<string>? PrefixHierarchy { get; set; }

    /// <summary>Format of the prefix, and whether it applies to the file name, file path, or both. Valid values are FILENAME, PATH, and PATH_AND_FILENAME.</summary>
    [JsonPropertyName("prefixType")]
    public string? PrefixType { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow formats the flow output data when Upsolver is used as the destination. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig
{
    /// <summary>Aggregation settings that you can use to customize the output format of your flow data. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config.aggregation_config Block for details.</summary>
    [JsonPropertyName("aggregationConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig? AggregationConfig { get; set; }

    /// <summary>File type that Amazon AppFlow places in the Upsolver Amazon S3 bucket. Valid values are CSV, JSON, and PARQUET.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>Prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config.prefix_config Block for details.</summary>
    [JsonPropertyName("prefixConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig? PrefixConfig { get; set; }
}

/// <summary>Properties required to query Upsolver. See the destination_flow_config.destination_connector_properties.upsolver Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolver
{
    /// <summary>Upsolver Amazon S3 bucket name in which Amazon AppFlow places the transferred data. Must begin with upsolver-appflow.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the Upsolver Amazon S3 bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow formats the flow output data when Upsolver is used as the destination. See the destination_flow_config.destination_connector_properties.upsolver.s3_output_format_config Block for details.</summary>
    [JsonPropertyName("s3OutputFormatConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig? S3OutputFormatConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.zendesk.error_handling_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig
{
    /// <summary>Name of the Amazon S3 bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Whether to fail the flow after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties required to query Zendesk. See the destination_flow_config.destination_connector_properties.zendesk Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesZendesk
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See the destination_flow_config.destination_connector_properties.zendesk.error_handling_config Block for details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update or delete.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Type of write operation to be performed in Zendesk. When the value is UPSERT, id_field_names is required. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Information required to query a particular connector. See the destination_flow_config.destination_connector_properties Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorProperties
{
    /// <summary>Properties required to query the custom connector. See the destination_flow_config.destination_connector_properties.custom_connector Block for details.</summary>
    [JsonPropertyName("customConnector")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnector? CustomConnector { get; set; }

    /// <summary>Properties required to query Amazon Connect Customer Profiles. See the destination_flow_config.destination_connector_properties.customer_profiles Block for details.</summary>
    [JsonPropertyName("customerProfiles")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles? CustomerProfiles { get; set; }

    /// <summary>Properties required to query Amazon EventBridge. See the destination_flow_config.destination_connector_properties.event_bridge Block for details.</summary>
    [JsonPropertyName("eventBridge")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridge? EventBridge { get; set; }

    /// <summary>Properties required to query Amazon Honeycode. See the destination_flow_config.destination_connector_properties.honeycode Block for details.</summary>
    [JsonPropertyName("honeycode")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycode? Honeycode { get; set; }

    [JsonPropertyName("lookoutMetrics")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics? LookoutMetrics { get; set; }

    /// <summary>Properties required to query Marketo. See the destination_flow_config.destination_connector_properties.marketo Block for details.</summary>
    [JsonPropertyName("marketo")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesMarketo? Marketo { get; set; }

    /// <summary>Properties required to query Amazon Redshift. See the destination_flow_config.destination_connector_properties.redshift Block for details.</summary>
    [JsonPropertyName("redshift")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesRedshift? Redshift { get; set; }

    /// <summary>Properties required to query Amazon S3. See the destination_flow_config.destination_connector_properties.s3 Block for details.</summary>
    [JsonPropertyName("s3")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3? S3 { get; set; }

    /// <summary>Properties required to query Salesforce. See the destination_flow_config.destination_connector_properties.salesforce Block for details.</summary>
    [JsonPropertyName("salesforce")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforce? Salesforce { get; set; }

    /// <summary>Properties required to query SAPOData. See the destination_flow_config.destination_connector_properties.sapo_data Block for details.</summary>
    [JsonPropertyName("sapoData")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSapoData? SapoData { get; set; }

    /// <summary>Properties required to query Snowflake. See the destination_flow_config.destination_connector_properties.snowflake Block for details.</summary>
    [JsonPropertyName("snowflake")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflake? Snowflake { get; set; }

    /// <summary>Properties required to query Upsolver. See the destination_flow_config.destination_connector_properties.upsolver Block for details.</summary>
    [JsonPropertyName("upsolver")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolver? Upsolver { get; set; }

    /// <summary>Properties required to query Zendesk. See the destination_flow_config.destination_connector_properties.zendesk Block for details.</summary>
    [JsonPropertyName("zendesk")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesZendesk? Zendesk { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderDestinationFlowConfig
{
    /// <summary>API version that the destination connector uses.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Name of the connector profile. Must be unique for each connector profile in the AWS account.</summary>
    [JsonPropertyName("connectorProfileName")]
    public string? ConnectorProfileName { get; set; }

    /// <summary>Type of connector, such as Salesforce, Amplitude, and so on. Valid values are Salesforce, Singular, Slack, Redshift, S3, Marketo, Googleanalytics, Zendesk, Servicenow, Datadog, Trendmicro, Snowflake, Dynatrace, Infornexus, Amplitude, Veeva, EventBridge, LookoutMetrics, Upsolver, Honeycode, CustomerProfiles, SAPOData, and CustomConnector.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>Information required to query a particular connector. See the destination_flow_config.destination_connector_properties Block for details.</summary>
    [JsonPropertyName("destinationConnectorProperties")]
    public V1beta1FlowStatusAtProviderDestinationFlowConfigDestinationConnectorProperties? DestinationConnectorProperties { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow catalogs data with the AWS Glue Data Catalog. See the metadata_catalog_config.glue_data_catalog Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderMetadataCatalogConfigGlueDataCatalog
{
    /// <summary>Name of an existing Glue database to store the metadata tables that Amazon AppFlow creates.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>ARN of the IAM role that grants Amazon AppFlow the permissions it needs to create Data Catalog tables, databases, and partitions.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Naming prefix for each Data Catalog table that Amazon AppFlow creates.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow catalogs the data that the flow transfers. See the metadata_catalog_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderMetadataCatalogConfig
{
    /// <summary>Configuration that determines how Amazon AppFlow catalogs data with the AWS Glue Data Catalog. See the metadata_catalog_config.glue_data_catalog Block for details.</summary>
    [JsonPropertyName("glueDataCatalog")]
    public V1beta1FlowStatusAtProviderMetadataCatalogConfigGlueDataCatalog? GlueDataCatalog { get; set; }
}

/// <summary>Configuration for a scheduled incremental data pull. When a valid configuration is provided, the specified fields are used when querying for the incremental data pull. See the source_flow_config.incremental_pull_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigIncrementalPullConfig
{
    /// <summary>Field that specifies the date time or timestamp field as the criteria to use when importing incremental records from the source.</summary>
    [JsonPropertyName("datetimeTypeFieldName")]
    public string? DatetimeTypeFieldName { get; set; }
}

/// <summary>Information required to query Amplitude. See the source_flow_config.source_connector_properties.amplitude Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesAmplitude
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Properties applied when the custom connector is used as a source. See the source_flow_config.source_connector_properties.custom_connector Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesCustomConnector
{
    /// <summary>Custom properties specific to the connector when it&apos;s used as a source in the flow. Maximum of 50 items.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>Entity specified in the custom connector as a source in the flow.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }
}

/// <summary>Information required to query Datadog. See the source_flow_config.source_connector_properties.datadog Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesDatadog
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Dynatrace. See the source_flow_config.source_connector_properties.dynatrace Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesDynatrace
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Google Analytics. See the source_flow_config.source_connector_properties.google_analytics Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Infor Nexus. See the source_flow_config.source_connector_properties.infor_nexus Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesInforNexus
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Marketo. See the source_flow_config.source_connector_properties.marketo Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesMarketo
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>When you use Amazon S3 as the source, configuration format that you provide for the flow input data. See the source_flow_config.source_connector_properties.s3.s3_input_format_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig
{
    /// <summary>File type that Amazon AppFlow gets from your Amazon S3 bucket. Valid values are CSV and JSON.</summary>
    [JsonPropertyName("s3InputFileType")]
    public string? S3InputFileType { get; set; }
}

/// <summary>Information required to query Amazon S3. See the source_flow_config.source_connector_properties.s3 Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesS3
{
    /// <summary>Amazon S3 bucket name where the source files are stored.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the Amazon S3 bucket in which the source files are stored.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>When you use Amazon S3 as the source, configuration format that you provide for the flow input data. See the source_flow_config.source_connector_properties.s3.s3_input_format_config Block for details.</summary>
    [JsonPropertyName("s3InputFormatConfig")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig? S3InputFormatConfig { get; set; }
}

/// <summary>Information required to query Salesforce. See the source_flow_config.source_connector_properties.salesforce Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSalesforce
{
    /// <summary>Salesforce API used by Amazon AppFlow when the flow transfers data from Salesforce.</summary>
    [JsonPropertyName("dataTransferApi")]
    public string? DataTransferApi { get; set; }

    /// <summary>Whether to enable dynamic fetching of new (recently added) fields in the Salesforce objects while running a flow.</summary>
    [JsonPropertyName("enableDynamicFieldUpdate")]
    public bool? EnableDynamicFieldUpdate { get; set; }

    /// <summary>Whether to include deleted files in the flow run.</summary>
    [JsonPropertyName("includeDeletedRecords")]
    public bool? IncludeDeletedRecords { get; set; }

    /// <summary>Object specified in the Salesforce flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Page size for each concurrent process that transfers OData records from your SAP instance. See the source_flow_config.source_connector_properties.sapo_data.pagination_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig
{
    /// <summary>Maximum number of records that Amazon AppFlow receives in each page of the response from your SAP application.</summary>
    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }
}

/// <summary>Number of concurrent processes that transfer OData records from your SAP instance. See the source_flow_config.source_connector_properties.sapo_data.parallelism_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig
{
    /// <summary>Maximum number of processes that Amazon AppFlow runs at the same time when it retrieves your data from your SAP application.</summary>
    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }
}

/// <summary>Information required to query SAPOData as a flow source. See the source_flow_config.source_connector_properties.sapo_data Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSapoData
{
    /// <summary>Object path specified in the SAPOData flow source.</summary>
    [JsonPropertyName("objectPath")]
    public string? ObjectPath { get; set; }

    /// <summary>Page size for each concurrent process that transfers OData records from your SAP instance. See the source_flow_config.source_connector_properties.sapo_data.pagination_config Block for details.</summary>
    [JsonPropertyName("paginationConfig")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig? PaginationConfig { get; set; }

    /// <summary>Number of concurrent processes that transfer OData records from your SAP instance. See the source_flow_config.source_connector_properties.sapo_data.parallelism_config Block for details.</summary>
    [JsonPropertyName("parallelismConfig")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig? ParallelismConfig { get; set; }
}

/// <summary>Information required to query ServiceNow. See the source_flow_config.source_connector_properties.service_now Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesServiceNow
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Singular. See the source_flow_config.source_connector_properties.singular Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSingular
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Slack. See the source_flow_config.source_connector_properties.slack Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSlack
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Trend Micro. See the source_flow_config.source_connector_properties.trendmicro Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesTrendmicro
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Veeva. See the source_flow_config.source_connector_properties.veeva Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesVeeva
{
    /// <summary>Document type specified in the Veeva document extract flow.</summary>
    [JsonPropertyName("documentType")]
    public string? DocumentType { get; set; }

    /// <summary>Whether to include all versions of files in the Veeva document extract flow.</summary>
    [JsonPropertyName("includeAllVersions")]
    public bool? IncludeAllVersions { get; set; }

    /// <summary>Whether to include file renditions in the Veeva document extract flow.</summary>
    [JsonPropertyName("includeRenditions")]
    public bool? IncludeRenditions { get; set; }

    /// <summary>Whether to include source files in the Veeva document extract flow.</summary>
    [JsonPropertyName("includeSourceFiles")]
    public bool? IncludeSourceFiles { get; set; }

    /// <summary>Object specified in the Veeva flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query Zendesk. See the source_flow_config.source_connector_properties.zendesk Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesZendesk
{
    /// <summary>Object specified in the flow source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information required to query a particular source connector. See the source_flow_config.source_connector_properties Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorProperties
{
    /// <summary>Information required to query Amplitude. See the source_flow_config.source_connector_properties.amplitude Block for details.</summary>
    [JsonPropertyName("amplitude")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesAmplitude? Amplitude { get; set; }

    /// <summary>Properties applied when the custom connector is used as a source. See the source_flow_config.source_connector_properties.custom_connector Block for details.</summary>
    [JsonPropertyName("customConnector")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesCustomConnector? CustomConnector { get; set; }

    /// <summary>Information required to query Datadog. See the source_flow_config.source_connector_properties.datadog Block for details.</summary>
    [JsonPropertyName("datadog")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesDatadog? Datadog { get; set; }

    /// <summary>Information required to query Dynatrace. See the source_flow_config.source_connector_properties.dynatrace Block for details.</summary>
    [JsonPropertyName("dynatrace")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesDynatrace? Dynatrace { get; set; }

    /// <summary>Information required to query Google Analytics. See the source_flow_config.source_connector_properties.google_analytics Block for details.</summary>
    [JsonPropertyName("googleAnalytics")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics? GoogleAnalytics { get; set; }

    /// <summary>Information required to query Infor Nexus. See the source_flow_config.source_connector_properties.infor_nexus Block for details.</summary>
    [JsonPropertyName("inforNexus")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesInforNexus? InforNexus { get; set; }

    /// <summary>Information required to query Marketo. See the source_flow_config.source_connector_properties.marketo Block for details.</summary>
    [JsonPropertyName("marketo")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesMarketo? Marketo { get; set; }

    /// <summary>Information required to query Amazon S3. See the source_flow_config.source_connector_properties.s3 Block for details.</summary>
    [JsonPropertyName("s3")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesS3? S3 { get; set; }

    /// <summary>Information required to query Salesforce. See the source_flow_config.source_connector_properties.salesforce Block for details.</summary>
    [JsonPropertyName("salesforce")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSalesforce? Salesforce { get; set; }

    /// <summary>Information required to query SAPOData as a flow source. See the source_flow_config.source_connector_properties.sapo_data Block for details.</summary>
    [JsonPropertyName("sapoData")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSapoData? SapoData { get; set; }

    /// <summary>Information required to query ServiceNow. See the source_flow_config.source_connector_properties.service_now Block for details.</summary>
    [JsonPropertyName("serviceNow")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesServiceNow? ServiceNow { get; set; }

    /// <summary>Information required to query Singular. See the source_flow_config.source_connector_properties.singular Block for details.</summary>
    [JsonPropertyName("singular")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSingular? Singular { get; set; }

    /// <summary>Information required to query Slack. See the source_flow_config.source_connector_properties.slack Block for details.</summary>
    [JsonPropertyName("slack")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSlack? Slack { get; set; }

    /// <summary>Information required to query Trend Micro. See the source_flow_config.source_connector_properties.trendmicro Block for details.</summary>
    [JsonPropertyName("trendmicro")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesTrendmicro? Trendmicro { get; set; }

    /// <summary>Information required to query Veeva. See the source_flow_config.source_connector_properties.veeva Block for details.</summary>
    [JsonPropertyName("veeva")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesVeeva? Veeva { get; set; }

    /// <summary>Information required to query Zendesk. See the source_flow_config.source_connector_properties.zendesk Block for details.</summary>
    [JsonPropertyName("zendesk")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesZendesk? Zendesk { get; set; }
}

/// <summary>Configuration that controls how Amazon AppFlow retrieves data from the source connector. See the source_flow_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderSourceFlowConfig
{
    /// <summary>API version that the source connector uses.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Name of the connector profile. Must be unique for each connector profile in the AWS account.</summary>
    [JsonPropertyName("connectorProfileName")]
    public string? ConnectorProfileName { get; set; }

    /// <summary>Type of connector, such as Salesforce, Amplitude, and so on. Valid values are Salesforce, Singular, Slack, Redshift, S3, Marketo, Googleanalytics, Zendesk, Servicenow, Datadog, Trendmicro, Snowflake, Dynatrace, Infornexus, Amplitude, Veeva, EventBridge, LookoutMetrics, Upsolver, Honeycode, CustomerProfiles, SAPOData, and CustomConnector.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>Configuration for a scheduled incremental data pull. When a valid configuration is provided, the specified fields are used when querying for the incremental data pull. See the source_flow_config.incremental_pull_config Block for details.</summary>
    [JsonPropertyName("incrementalPullConfig")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigIncrementalPullConfig? IncrementalPullConfig { get; set; }

    /// <summary>Information required to query a particular source connector. See the source_flow_config.source_connector_properties Block for details.</summary>
    [JsonPropertyName("sourceConnectorProperties")]
    public V1beta1FlowStatusAtProviderSourceFlowConfigSourceConnectorProperties? SourceConnectorProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderTaskConnectorOperator
{
    /// <summary>Operation to be performed on the provided Amplitude source fields. The only valid value is BETWEEN.</summary>
    [JsonPropertyName("amplitude")]
    public string? Amplitude { get; set; }

    /// <summary>Operators supported by the custom connector. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("customConnector")]
    public string? CustomConnector { get; set; }

    /// <summary>Operation to be performed on the provided Datadog source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("datadog")]
    public string? Datadog { get; set; }

    /// <summary>Operation to be performed on the provided Dynatrace source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("dynatrace")]
    public string? Dynatrace { get; set; }

    /// <summary>Operation to be performed on the provided Google Analytics source fields. Valid values are PROJECTION and BETWEEN.</summary>
    [JsonPropertyName("googleAnalytics")]
    public string? GoogleAnalytics { get; set; }

    /// <summary>Operation to be performed on the provided Infor Nexus source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("inforNexus")]
    public string? InforNexus { get; set; }

    /// <summary>Operation to be performed on the provided Marketo source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("marketo")]
    public string? Marketo { get; set; }

    /// <summary>Operation to be performed on the provided Amazon S3 source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("s3")]
    public string? S3 { get; set; }

    /// <summary>Operation to be performed on the provided Salesforce source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("salesforce")]
    public string? Salesforce { get; set; }

    /// <summary>Operation to be performed on the provided SAPOData source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("sapoData")]
    public string? SapoData { get; set; }

    /// <summary>Operation to be performed on the provided ServiceNow source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("serviceNow")]
    public string? ServiceNow { get; set; }

    /// <summary>Operation to be performed on the provided Singular source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("singular")]
    public string? Singular { get; set; }

    /// <summary>Operation to be performed on the provided Slack source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("slack")]
    public string? Slack { get; set; }

    /// <summary>Operation to be performed on the provided Trend Micro source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("trendmicro")]
    public string? Trendmicro { get; set; }

    /// <summary>Operation to be performed on the provided Veeva source fields. Valid values are PROJECTION, LESS_THAN, GREATER_THAN, CONTAINS, BETWEEN, LESS_THAN_OR_EQUAL_TO, GREATER_THAN_OR_EQUAL_TO, EQUAL_TO, NOT_EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("veeva")]
    public string? Veeva { get; set; }

    /// <summary>Operation to be performed on the provided Zendesk source fields. Valid values are PROJECTION, GREATER_THAN, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("zendesk")]
    public string? Zendesk { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderTask
{
    /// <summary>Operation to be performed on the provided source fields. See the task.connector_operator Block for details.</summary>
    [JsonPropertyName("connectorOperator")]
    public IList<V1beta1FlowStatusAtProviderTaskConnectorOperator>? ConnectorOperator { get; set; }

    /// <summary>Field in a destination connector, or a field value against which Amazon AppFlow validates a source field.</summary>
    [JsonPropertyName("destinationField")]
    public string? DestinationField { get; set; }

    /// <summary>Source fields to which a particular task is applied.</summary>
    [JsonPropertyName("sourceFields")]
    public IList<string>? SourceFields { get; set; }

    /// <summary>Map used to store task-related information. The execution service looks for particular information based on the TaskType. Valid keys are VALUE, VALUES, DATA_TYPE, UPPER_BOUND, LOWER_BOUND, SOURCE_DATA_TYPE, DESTINATION_DATA_TYPE, VALIDATION_ACTION, MASK_VALUE, MASK_LENGTH, TRUNCATE_LENGTH, MATH_OPERATION_FIELDS_ORDER, CONCAT_FORMAT, SUBFIELD_CATEGORY_MAP, and EXCLUDE_SOURCE_FIELDS_LIST.</summary>
    [JsonPropertyName("taskProperties")]
    public IDictionary<string, string>? TaskProperties { get; set; }

    /// <summary>Particular task implementation that Amazon AppFlow performs. Valid values are Arithmetic, Filter, Map, Map_all, Mask, Merge, Passthrough, Truncate, and Validate.</summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }
}

/// <summary>Configuration details of a schedule-triggered flow. See the trigger_config.trigger_properties.scheduled Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderTriggerConfigTriggerPropertiesScheduled
{
    /// <summary>Whether a scheduled flow has an incremental data transfer or a complete data transfer for each flow run. Valid values are Incremental and Complete.</summary>
    [JsonPropertyName("dataPullMode")]
    public string? DataPullMode { get; set; }

    /// <summary>Date range for the records to import from the connector in the first flow run. Must be a valid RFC3339 timestamp.</summary>
    [JsonPropertyName("firstExecutionFrom")]
    public string? FirstExecutionFrom { get; set; }

    /// <summary>Scheduled end time for a schedule-triggered flow. Must be a valid RFC3339 timestamp.</summary>
    [JsonPropertyName("scheduleEndTime")]
    public string? ScheduleEndTime { get; set; }

    /// <summary>Scheduling expression that determines the rate at which the schedule runs, for example rate(5minutes).</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>Offset that is added to the time interval for a schedule-triggered flow. Maximum value of 36000.</summary>
    [JsonPropertyName("scheduleOffset")]
    public double? ScheduleOffset { get; set; }

    /// <summary>Scheduled start time for a schedule-triggered flow. Must be a valid RFC3339 timestamp.</summary>
    [JsonPropertyName("scheduleStartTime")]
    public string? ScheduleStartTime { get; set; }

    /// <summary>Time zone used when referring to the date and time of a scheduled-triggered flow, such as America/New_York.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>Configuration details of a schedule-triggered flow as defined by the user. Currently, these settings only apply to the Scheduled trigger type. See the trigger_config.trigger_properties Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderTriggerConfigTriggerProperties
{
    /// <summary>Configuration details of a schedule-triggered flow. See the trigger_config.trigger_properties.scheduled Block for details.</summary>
    [JsonPropertyName("scheduled")]
    public V1beta1FlowStatusAtProviderTriggerConfigTriggerPropertiesScheduled? Scheduled { get; set; }
}

/// <summary>Configuration that determines how and when the flow runs. See the trigger_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProviderTriggerConfig
{
    /// <summary>Configuration details of a schedule-triggered flow as defined by the user. Currently, these settings only apply to the Scheduled trigger type. See the trigger_config.trigger_properties Block for details.</summary>
    [JsonPropertyName("triggerProperties")]
    public V1beta1FlowStatusAtProviderTriggerConfigTriggerProperties? TriggerProperties { get; set; }

    /// <summary>Type of flow trigger. Valid values are Scheduled, Event, and OnDemand.</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusAtProvider
{
    /// <summary>Flow&apos;s ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description of the flow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration that controls how Amazon AppFlow places data in the destination connector. See the destination_flow_config Block for details.</summary>
    [JsonPropertyName("destinationFlowConfig")]
    public IList<V1beta1FlowStatusAtProviderDestinationFlowConfig>? DestinationFlowConfig { get; set; }

    /// <summary>Current status of the flow.</summary>
    [JsonPropertyName("flowStatus")]
    public string? FlowStatus { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of the KMS key you provide for encryption. Required if you do not want to use the Amazon AppFlow-managed KMS key. Uses the Amazon AppFlow-managed KMS key when not provided.</summary>
    [JsonPropertyName("kmsArn")]
    public string? KmsArn { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow catalogs the data that the flow transfers. See the metadata_catalog_config Block for details.</summary>
    [JsonPropertyName("metadataCatalogConfig")]
    public V1beta1FlowStatusAtProviderMetadataCatalogConfig? MetadataCatalogConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration that controls how Amazon AppFlow retrieves data from the source connector. See the source_flow_config Block for details.</summary>
    [JsonPropertyName("sourceFlowConfig")]
    public V1beta1FlowStatusAtProviderSourceFlowConfig? SourceFlowConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Tasks that Amazon AppFlow performs while transferring the data in the flow run. See the task Block for details.</summary>
    [JsonPropertyName("task")]
    public IList<V1beta1FlowStatusAtProviderTask>? Task { get; set; }

    /// <summary>Configuration that determines how and when the flow runs. See the trigger_config Block for details.</summary>
    [JsonPropertyName("triggerConfig")]
    public V1beta1FlowStatusAtProviderTriggerConfig? TriggerConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatusConditions
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

/// <summary>FlowStatus defines the observed state of Flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlowStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1FlowStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FlowStatusConditions>? Conditions { get; set; }

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

/// <summary>Flow is the Schema for the Flows API. Provides an AppFlow Flow resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Flow : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FlowSpec>, IStatus<V1beta1FlowStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Flow";
    public const string KubeGroup = "appflow.aws.m.upbound.io";
    public const string KubePluralName = "flows";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appflow.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Flow";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FlowSpec defines the desired state of Flow</summary>
    [JsonPropertyName("spec")]
    public required V1beta1FlowSpec Spec { get; set; }

    /// <summary>FlowStatus defines the observed state of Flow.</summary>
    [JsonPropertyName("status")]
    public V1beta1FlowStatus? Status { get; set; }
}