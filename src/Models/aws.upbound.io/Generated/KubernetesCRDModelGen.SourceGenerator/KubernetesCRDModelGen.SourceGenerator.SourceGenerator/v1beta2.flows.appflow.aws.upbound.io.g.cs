#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appflow.aws.upbound.io;
/// <summary>Flow is the Schema for the Flows API. Provides an AppFlow Flow resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FlowList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Flow>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FlowList";
    public const string KubeGroup = "appflow.aws.upbound.io";
    public const string KubePluralName = "flows";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appflow.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlowList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Flow objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Flow> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecDeletionPolicyEnum>))]
public enum V1beta2FlowSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnector
{
    /// <summary>Custom properties that are specific to the connector when it&apos;s used as a destination in the flow. Maximum of 50 items.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>Entity specified in the custom connector as a destination in the flow.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Properties that are required to query Amazon Connect Customer Profiles. See Customer Profiles Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles
{
    /// <summary>Unique name of the Amazon Connect Customer Profiles domain.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Object specified in the Amazon Connect Customer Profiles flow destination.</summary>
    [JsonPropertyName("objectTypeName")]
    public string? ObjectTypeName { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridgeErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Amazon EventBridge. See Generic Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridge
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridgeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Amazon Honeycode. See Generic Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycode
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics
{
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesMarketoErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesMarketo
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesMarketoErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Amazon Redshift. See Redshift Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesRedshift
{
    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Intermediate bucket that Amazon AppFlow uses when moving data into Amazon Redshift.</summary>
    [JsonPropertyName("intermediateBucketName")]
    public string? IntermediateBucketName { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelector
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
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Aggregation settings that you can use to customize the output format of your flow data. See Aggregation Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig
{
    /// <summary>Whether Amazon AppFlow aggregates the flow records into a single file, or leave them unaggregated. Valid values are None and SingleFile.</summary>
    [JsonPropertyName("aggregationType")]
    public string? AggregationType { get; set; }

    /// <summary>The desired file size, in MB, for each output file that Amazon AppFlow writes to the flow destination. Integer value.</summary>
    [JsonPropertyName("targetFileSize")]
    public double? TargetFileSize { get; set; }
}

/// <summary>Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You can name folders according to the flow frequency and date. See Prefix Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig
{
    /// <summary>Determines the level of granularity that&apos;s included in the prefix. Valid values are YEAR, MONTH, DAY, HOUR, and MINUTE.</summary>
    [JsonPropertyName("prefixFormat")]
    public string? PrefixFormat { get; set; }

    /// <summary>Determines whether the destination file path includes either or both of the selected elements. Valid values are EXECUTION_ID and SCHEMA_VERSION</summary>
    [JsonPropertyName("prefixHierarchy")]
    public IList<string>? PrefixHierarchy { get; set; }

    /// <summary>Determines the format of the prefix, and whether it applies to the file name, file path, or both. Valid values are FILENAME, PATH, and PATH_AND_FILENAME.</summary>
    [JsonPropertyName("prefixType")]
    public string? PrefixType { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow should format the flow output data when Amazon S3 is used as the destination. See S3 Output Format Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig
{
    /// <summary>Aggregation settings that you can use to customize the output format of your flow data. See Aggregation Config for more details.</summary>
    [JsonPropertyName("aggregationConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig? AggregationConfig { get; set; }

    /// <summary>File type that Amazon AppFlow places in the Amazon S3 bucket. Valid values are CSV, JSON, and PARQUET.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You can name folders according to the flow frequency and date. See Prefix Config for more details.</summary>
    [JsonPropertyName("prefixConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig? PrefixConfig { get; set; }

    /// <summary>Whether the data types from the source system need to be preserved (Only valid for Parquet file type)</summary>
    [JsonPropertyName("preserveSourceDataTyping")]
    public bool? PreserveSourceDataTyping { get; set; }
}

/// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow should format the flow output data when Amazon S3 is used as the destination. See S3 Output Format Config for more details.</summary>
    [JsonPropertyName("s3OutputFormatConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig? S3OutputFormatConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforceErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforce
{
    /// <summary>Specifies which Salesforce API is used by Amazon AppFlow when your flow transfers data to Salesforce.</summary>
    [JsonPropertyName("dataTransferApi")]
    public string? DataTransferApi { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforceErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Determines how Amazon AppFlow handles the success response that it gets from the connector after placing data. See Success Response Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }
}

/// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSapoData
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object path specified in the SAPOData flow destination.</summary>
    [JsonPropertyName("objectPath")]
    public string? ObjectPath { get; set; }

    /// <summary>Determines how Amazon AppFlow handles the success response that it gets from the connector after placing data. See Success Response Handling Config for more details.</summary>
    [JsonPropertyName("successResponseHandlingConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig? SuccessResponseHandlingConfig { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflakeErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Snowflake. See Snowflake Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflake
{
    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflakeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Intermediate bucket that Amazon AppFlow uses when moving data into Amazon Redshift.</summary>
    [JsonPropertyName("intermediateBucketName")]
    public string? IntermediateBucketName { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Aggregation settings that you can use to customize the output format of your flow data. See Aggregation Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig
{
    /// <summary>Whether Amazon AppFlow aggregates the flow records into a single file, or leave them unaggregated. Valid values are None and SingleFile.</summary>
    [JsonPropertyName("aggregationType")]
    public string? AggregationType { get; set; }
}

/// <summary>Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You can name folders according to the flow frequency and date. See Prefix Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig
{
    /// <summary>Determines the level of granularity that&apos;s included in the prefix. Valid values are YEAR, MONTH, DAY, HOUR, and MINUTE.</summary>
    [JsonPropertyName("prefixFormat")]
    public string? PrefixFormat { get; set; }

    /// <summary>Determines whether the destination file path includes either or both of the selected elements. Valid values are EXECUTION_ID and SCHEMA_VERSION</summary>
    [JsonPropertyName("prefixHierarchy")]
    public IList<string>? PrefixHierarchy { get; set; }

    /// <summary>Determines the format of the prefix, and whether it applies to the file name, file path, or both. Valid values are FILENAME, PATH, and PATH_AND_FILENAME.</summary>
    [JsonPropertyName("prefixType")]
    public string? PrefixType { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow should format the flow output data when Amazon S3 is used as the destination. See S3 Output Format Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig
{
    /// <summary>Aggregation settings that you can use to customize the output format of your flow data. See Aggregation Config for more details.</summary>
    [JsonPropertyName("aggregationConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig? AggregationConfig { get; set; }

    /// <summary>File type that Amazon AppFlow places in the Amazon S3 bucket. Valid values are CSV, JSON, and PARQUET.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You can name folders according to the flow frequency and date. See Prefix Config for more details.</summary>
    [JsonPropertyName("prefixConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig? PrefixConfig { get; set; }
}

/// <summary>Properties that are required to query Upsolver. See Upsolver Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolver
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow should format the flow output data when Amazon S3 is used as the destination. See S3 Output Format Config for more details.</summary>
    [JsonPropertyName("s3OutputFormatConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig? S3OutputFormatConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesZendesk
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>This stores the information that is required to query a particular connector. See Destination Connector Properties for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorProperties
{
    /// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
    [JsonPropertyName("customConnector")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnector? CustomConnector { get; set; }

    /// <summary>Properties that are required to query Amazon Connect Customer Profiles. See Customer Profiles Destination Properties for more details.</summary>
    [JsonPropertyName("customerProfiles")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles? CustomerProfiles { get; set; }

    /// <summary>Properties that are required to query Amazon EventBridge. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("eventBridge")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridge? EventBridge { get; set; }

    /// <summary>Properties that are required to query Amazon Honeycode. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("honeycode")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycode? Honeycode { get; set; }

    [JsonPropertyName("lookoutMetrics")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics? LookoutMetrics { get; set; }

    /// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("marketo")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesMarketo? Marketo { get; set; }

    /// <summary>Properties that are required to query Amazon Redshift. See Redshift Destination Properties for more details.</summary>
    [JsonPropertyName("redshift")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesRedshift? Redshift { get; set; }

    /// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
    [JsonPropertyName("s3")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesS3? S3 { get; set; }

    /// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
    [JsonPropertyName("salesforce")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforce? Salesforce { get; set; }

    /// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
    [JsonPropertyName("sapoData")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSapoData? SapoData { get; set; }

    /// <summary>Properties that are required to query Snowflake. See Snowflake Destination Properties for more details.</summary>
    [JsonPropertyName("snowflake")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflake? Snowflake { get; set; }

    /// <summary>Properties that are required to query Upsolver. See Upsolver Destination Properties for more details.</summary>
    [JsonPropertyName("upsolver")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolver? Upsolver { get; set; }

    /// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
    [JsonPropertyName("zendesk")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorPropertiesZendesk? Zendesk { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderDestinationFlowConfig
{
    /// <summary>API version that the destination connector uses.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Name of the connector profile. This name must be unique for each connector profile in the AWS account.</summary>
    [JsonPropertyName("connectorProfileName")]
    public string? ConnectorProfileName { get; set; }

    /// <summary>Type of connector, such as Salesforce, Amplitude, and so on. Valid values are Salesforce, Singular, Slack, Redshift, S3, Marketo, Googleanalytics, Zendesk, Servicenow, Datadog, Trendmicro, Snowflake, Dynatrace, Infornexus, Amplitude, Veeva, EventBridge, LookoutMetrics, Upsolver, Honeycode, CustomerProfiles, SAPOData, and CustomConnector.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>This stores the information that is required to query a particular connector. See Destination Connector Properties for more information.</summary>
    [JsonPropertyName("destinationConnectorProperties")]
    public V1beta2FlowSpecForProviderDestinationFlowConfigDestinationConnectorProperties? DestinationConnectorProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderMetadataCatalogConfigGlueDataCatalog
{
    /// <summary>The name of an existing Glue database to store the metadata tables that Amazon AppFlow creates.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The ARN of an IAM role that grants AppFlow the permissions it needs to create Data Catalog tables, databases, and partitions.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A naming prefix for each Data Catalog table that Amazon AppFlow creates</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }
}

/// <summary>A Catalog that determines the configuration that Amazon AppFlow uses when it catalogs the data that’s transferred by the associated flow. When Amazon AppFlow catalogs the data from a flow, it stores metadata in a data catalog.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderMetadataCatalogConfig
{
    [JsonPropertyName("glueDataCatalog")]
    public V1beta2FlowSpecForProviderMetadataCatalogConfigGlueDataCatalog? GlueDataCatalog { get; set; }
}

/// <summary>Defines the configuration for a scheduled incremental data pull. If a valid configuration is provided, the fields specified in the configuration are used when querying for the incremental data pull. See Incremental Pull Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigIncrementalPullConfig
{
    /// <summary>Field that specifies the date time or timestamp field as the criteria to use when importing incremental records from the source.</summary>
    [JsonPropertyName("datetimeTypeFieldName")]
    public string? DatetimeTypeFieldName { get; set; }
}

/// <summary>Information that is required for querying Amplitude. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesAmplitude
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesCustomConnector
{
    /// <summary>Custom properties that are specific to the connector when it&apos;s used as a destination in the flow. Maximum of 50 items.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>Entity specified in the custom connector as a destination in the flow.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }
}

/// <summary>Information that is required for querying Datadog. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesDatadog
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Operation to be performed on the provided Dynatrace source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesDynatrace
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Operation to be performed on the provided Google Analytics source fields. Valid values are PROJECTION and BETWEEN.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required for querying Infor Nexus. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesInforNexus
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesMarketo
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelector
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
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>When you use Amazon S3 as the source, the configuration format that you provide the flow input data. See S3 Input Format Config for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig
{
    /// <summary>File type that Amazon AppFlow gets from your Amazon S3 bucket. Valid values are CSV and JSON.</summary>
    [JsonPropertyName("s3InputFileType")]
    public string? S3InputFileType { get; set; }
}

/// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>When you use Amazon S3 as the source, the configuration format that you provide the flow input data. See S3 Input Format Config for details.</summary>
    [JsonPropertyName("s3InputFormatConfig")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig? S3InputFormatConfig { get; set; }
}

/// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSalesforce
{
    /// <summary>Specifies which Salesforce API is used by Amazon AppFlow when your flow transfers data to Salesforce.</summary>
    [JsonPropertyName("dataTransferApi")]
    public string? DataTransferApi { get; set; }

    /// <summary>Flag that enables dynamic fetching of new (recently added) fields in the Salesforce objects while running a flow.</summary>
    [JsonPropertyName("enableDynamicFieldUpdate")]
    public bool? EnableDynamicFieldUpdate { get; set; }

    /// <summary>Whether Amazon AppFlow includes deleted files in the flow run.</summary>
    [JsonPropertyName("includeDeletedRecords")]
    public bool? IncludeDeletedRecords { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Sets the page size for each concurrent process that transfers OData records from your SAP instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig
{
    /// <summary>he maximum number of records that Amazon AppFlow receives in each page of the response from your SAP application.</summary>
    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }
}

/// <summary>Sets the number of concurrent processes that transfers OData records from your SAP instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig
{
    /// <summary>he maximum number of records that Amazon AppFlow receives in each page of the response from your SAP application.</summary>
    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }
}

/// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSapoData
{
    /// <summary>Object path specified in the SAPOData flow destination.</summary>
    [JsonPropertyName("objectPath")]
    public string? ObjectPath { get; set; }

    /// <summary>Sets the page size for each concurrent process that transfers OData records from your SAP instance.</summary>
    [JsonPropertyName("paginationConfig")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig? PaginationConfig { get; set; }

    /// <summary>Sets the number of concurrent processes that transfers OData records from your SAP instance.</summary>
    [JsonPropertyName("parallelismConfig")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig? ParallelismConfig { get; set; }
}

/// <summary>Information that is required for querying ServiceNow. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesServiceNow
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required for querying Singular. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSingular
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required for querying Slack. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSlack
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Operation to be performed on the provided Trend Micro source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesTrendmicro
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required for querying Veeva. See Veeva Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesVeeva
{
    /// <summary>Document type specified in the Veeva document extract flow.</summary>
    [JsonPropertyName("documentType")]
    public string? DocumentType { get; set; }

    /// <summary>Boolean value to include All Versions of files in Veeva document extract flow.</summary>
    [JsonPropertyName("includeAllVersions")]
    public bool? IncludeAllVersions { get; set; }

    /// <summary>Boolean value to include file renditions in Veeva document extract flow.</summary>
    [JsonPropertyName("includeRenditions")]
    public bool? IncludeRenditions { get; set; }

    /// <summary>Boolean value to include source files in Veeva document extract flow.</summary>
    [JsonPropertyName("includeSourceFiles")]
    public bool? IncludeSourceFiles { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesZendesk
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required to query a particular source connector. See Source Connector Properties for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorProperties
{
    /// <summary>Information that is required for querying Amplitude. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("amplitude")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesAmplitude? Amplitude { get; set; }

    /// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
    [JsonPropertyName("customConnector")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesCustomConnector? CustomConnector { get; set; }

    /// <summary>Information that is required for querying Datadog. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("datadog")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesDatadog? Datadog { get; set; }

    /// <summary>Operation to be performed on the provided Dynatrace source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("dynatrace")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesDynatrace? Dynatrace { get; set; }

    /// <summary>Operation to be performed on the provided Google Analytics source fields. Valid values are PROJECTION and BETWEEN.</summary>
    [JsonPropertyName("googleAnalytics")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics? GoogleAnalytics { get; set; }

    /// <summary>Information that is required for querying Infor Nexus. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("inforNexus")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesInforNexus? InforNexus { get; set; }

    /// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("marketo")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesMarketo? Marketo { get; set; }

    /// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
    [JsonPropertyName("s3")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesS3? S3 { get; set; }

    /// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
    [JsonPropertyName("salesforce")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSalesforce? Salesforce { get; set; }

    /// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
    [JsonPropertyName("sapoData")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSapoData? SapoData { get; set; }

    /// <summary>Information that is required for querying ServiceNow. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("serviceNow")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesServiceNow? ServiceNow { get; set; }

    /// <summary>Information that is required for querying Singular. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("singular")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSingular? Singular { get; set; }

    /// <summary>Information that is required for querying Slack. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("slack")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesSlack? Slack { get; set; }

    /// <summary>Operation to be performed on the provided Trend Micro source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("trendmicro")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesTrendmicro? Trendmicro { get; set; }

    /// <summary>Information that is required for querying Veeva. See Veeva Source Properties for more details.</summary>
    [JsonPropertyName("veeva")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesVeeva? Veeva { get; set; }

    /// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
    [JsonPropertyName("zendesk")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorPropertiesZendesk? Zendesk { get; set; }
}

/// <summary>The Source Flow Config that controls how Amazon AppFlow retrieves data from the source connector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderSourceFlowConfig
{
    /// <summary>API version that the destination connector uses.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Name of the connector profile. This name must be unique for each connector profile in the AWS account.</summary>
    [JsonPropertyName("connectorProfileName")]
    public string? ConnectorProfileName { get; set; }

    /// <summary>Type of connector, such as Salesforce, Amplitude, and so on. Valid values are Salesforce, Singular, Slack, Redshift, S3, Marketo, Googleanalytics, Zendesk, Servicenow, Datadog, Trendmicro, Snowflake, Dynatrace, Infornexus, Amplitude, Veeva, EventBridge, LookoutMetrics, Upsolver, Honeycode, CustomerProfiles, SAPOData, and CustomConnector.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>Defines the configuration for a scheduled incremental data pull. If a valid configuration is provided, the fields specified in the configuration are used when querying for the incremental data pull. See Incremental Pull Config for more details.</summary>
    [JsonPropertyName("incrementalPullConfig")]
    public V1beta2FlowSpecForProviderSourceFlowConfigIncrementalPullConfig? IncrementalPullConfig { get; set; }

    /// <summary>Information that is required to query a particular source connector. See Source Connector Properties for details.</summary>
    [JsonPropertyName("sourceConnectorProperties")]
    public V1beta2FlowSpecForProviderSourceFlowConfigSourceConnectorProperties? SourceConnectorProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTaskConnectorOperator
{
    /// <summary>Information that is required for querying Amplitude. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("amplitude")]
    public string? Amplitude { get; set; }

    /// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
    [JsonPropertyName("customConnector")]
    public string? CustomConnector { get; set; }

    /// <summary>Information that is required for querying Datadog. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("datadog")]
    public string? Datadog { get; set; }

    /// <summary>Operation to be performed on the provided Dynatrace source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("dynatrace")]
    public string? Dynatrace { get; set; }

    /// <summary>Operation to be performed on the provided Google Analytics source fields. Valid values are PROJECTION and BETWEEN.</summary>
    [JsonPropertyName("googleAnalytics")]
    public string? GoogleAnalytics { get; set; }

    /// <summary>Information that is required for querying Infor Nexus. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("inforNexus")]
    public string? InforNexus { get; set; }

    /// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("marketo")]
    public string? Marketo { get; set; }

    /// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
    [JsonPropertyName("s3")]
    public string? S3 { get; set; }

    /// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
    [JsonPropertyName("salesforce")]
    public string? Salesforce { get; set; }

    /// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
    [JsonPropertyName("sapoData")]
    public string? SapoData { get; set; }

    /// <summary>Information that is required for querying ServiceNow. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("serviceNow")]
    public string? ServiceNow { get; set; }

    /// <summary>Information that is required for querying Singular. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("singular")]
    public string? Singular { get; set; }

    /// <summary>Information that is required for querying Slack. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("slack")]
    public string? Slack { get; set; }

    /// <summary>Operation to be performed on the provided Trend Micro source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("trendmicro")]
    public string? Trendmicro { get; set; }

    /// <summary>Information that is required for querying Veeva. See Veeva Source Properties for more details.</summary>
    [JsonPropertyName("veeva")]
    public string? Veeva { get; set; }

    /// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
    [JsonPropertyName("zendesk")]
    public string? Zendesk { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTask
{
    /// <summary>Operation to be performed on the provided source fields. See Connector Operator for details.</summary>
    [JsonPropertyName("connectorOperator")]
    public IList<V1beta2FlowSpecForProviderTaskConnectorOperator>? ConnectorOperator { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTriggerConfigTriggerPropertiesScheduled
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

    /// <summary>Scheduling expression that determines the rate at which the schedule will run, for example rate(5minutes).</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>Optional offset that is added to the time interval for a schedule-triggered flow. Maximum value of 36000.</summary>
    [JsonPropertyName("scheduleOffset")]
    public double? ScheduleOffset { get; set; }

    /// <summary>Scheduled start time for a schedule-triggered flow. Must be a valid RFC3339 timestamp.</summary>
    [JsonPropertyName("scheduleStartTime")]
    public string? ScheduleStartTime { get; set; }

    /// <summary>Time zone used when referring to the date and time of a scheduled-triggered flow, such as America/New_York.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>Configuration details of a schedule-triggered flow as defined by the user. Currently, these settings only apply to the Scheduled trigger type. See Scheduled Trigger Properties for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTriggerConfigTriggerProperties
{
    [JsonPropertyName("scheduled")]
    public V1beta2FlowSpecForProviderTriggerConfigTriggerPropertiesScheduled? Scheduled { get; set; }
}

/// <summary>A Trigger that determine how and when the flow runs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTriggerConfig
{
    /// <summary>Configuration details of a schedule-triggered flow as defined by the user. Currently, these settings only apply to the Scheduled trigger type. See Scheduled Trigger Properties for details.</summary>
    [JsonPropertyName("triggerProperties")]
    public V1beta2FlowSpecForProviderTriggerConfigTriggerProperties? TriggerProperties { get; set; }

    /// <summary>Type of flow trigger. Valid values are Scheduled, Event, and OnDemand.</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProvider
{
    /// <summary>Description of the flow you want to create.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A Destination Flow Config that controls how Amazon AppFlow places data in the destination connector.</summary>
    [JsonPropertyName("destinationFlowConfig")]
    public IList<V1beta2FlowSpecForProviderDestinationFlowConfig>? DestinationFlowConfig { get; set; }

    /// <summary>ARN (Amazon Resource Name) of the Key Management Service (KMS) key you provide for encryption. This is required if you do not want to use the Amazon AppFlow-managed KMS key. If you don&apos;t provide anything here, Amazon AppFlow uses the Amazon AppFlow-managed KMS key.</summary>
    [JsonPropertyName("kmsArn")]
    public string? KmsArn { get; set; }

    /// <summary>A Catalog that determines the configuration that Amazon AppFlow uses when it catalogs the data that’s transferred by the associated flow. When Amazon AppFlow catalogs the data from a flow, it stores metadata in a data catalog.</summary>
    [JsonPropertyName("metadataCatalogConfig")]
    public V1beta2FlowSpecForProviderMetadataCatalogConfig? MetadataCatalogConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The Source Flow Config that controls how Amazon AppFlow retrieves data from the source connector.</summary>
    [JsonPropertyName("sourceFlowConfig")]
    public V1beta2FlowSpecForProviderSourceFlowConfig? SourceFlowConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A Task that Amazon AppFlow performs while transferring the data in the flow run.</summary>
    [JsonPropertyName("task")]
    public IList<V1beta2FlowSpecForProviderTask>? Task { get; set; }

    /// <summary>A Trigger that determine how and when the flow runs.</summary>
    [JsonPropertyName("triggerConfig")]
    public V1beta2FlowSpecForProviderTriggerConfig? TriggerConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnector
{
    /// <summary>Custom properties that are specific to the connector when it&apos;s used as a destination in the flow. Maximum of 50 items.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>Entity specified in the custom connector as a destination in the flow.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Properties that are required to query Amazon Connect Customer Profiles. See Customer Profiles Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles
{
    /// <summary>Unique name of the Amazon Connect Customer Profiles domain.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Object specified in the Amazon Connect Customer Profiles flow destination.</summary>
    [JsonPropertyName("objectTypeName")]
    public string? ObjectTypeName { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridgeErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Amazon EventBridge. See Generic Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridge
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridgeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Amazon Honeycode. See Generic Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycode
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics
{
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesMarketoErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesMarketo
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesMarketoErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Amazon Redshift. See Redshift Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesRedshift
{
    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Intermediate bucket that Amazon AppFlow uses when moving data into Amazon Redshift.</summary>
    [JsonPropertyName("intermediateBucketName")]
    public string? IntermediateBucketName { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelector
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
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Aggregation settings that you can use to customize the output format of your flow data. See Aggregation Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig
{
    /// <summary>Whether Amazon AppFlow aggregates the flow records into a single file, or leave them unaggregated. Valid values are None and SingleFile.</summary>
    [JsonPropertyName("aggregationType")]
    public string? AggregationType { get; set; }

    /// <summary>The desired file size, in MB, for each output file that Amazon AppFlow writes to the flow destination. Integer value.</summary>
    [JsonPropertyName("targetFileSize")]
    public double? TargetFileSize { get; set; }
}

/// <summary>Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You can name folders according to the flow frequency and date. See Prefix Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig
{
    /// <summary>Determines the level of granularity that&apos;s included in the prefix. Valid values are YEAR, MONTH, DAY, HOUR, and MINUTE.</summary>
    [JsonPropertyName("prefixFormat")]
    public string? PrefixFormat { get; set; }

    /// <summary>Determines whether the destination file path includes either or both of the selected elements. Valid values are EXECUTION_ID and SCHEMA_VERSION</summary>
    [JsonPropertyName("prefixHierarchy")]
    public IList<string>? PrefixHierarchy { get; set; }

    /// <summary>Determines the format of the prefix, and whether it applies to the file name, file path, or both. Valid values are FILENAME, PATH, and PATH_AND_FILENAME.</summary>
    [JsonPropertyName("prefixType")]
    public string? PrefixType { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow should format the flow output data when Amazon S3 is used as the destination. See S3 Output Format Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig
{
    /// <summary>Aggregation settings that you can use to customize the output format of your flow data. See Aggregation Config for more details.</summary>
    [JsonPropertyName("aggregationConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig? AggregationConfig { get; set; }

    /// <summary>File type that Amazon AppFlow places in the Amazon S3 bucket. Valid values are CSV, JSON, and PARQUET.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You can name folders according to the flow frequency and date. See Prefix Config for more details.</summary>
    [JsonPropertyName("prefixConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig? PrefixConfig { get; set; }

    /// <summary>Whether the data types from the source system need to be preserved (Only valid for Parquet file type)</summary>
    [JsonPropertyName("preserveSourceDataTyping")]
    public bool? PreserveSourceDataTyping { get; set; }
}

/// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3BucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow should format the flow output data when Amazon S3 is used as the destination. See S3 Output Format Config for more details.</summary>
    [JsonPropertyName("s3OutputFormatConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig? S3OutputFormatConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforceErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforce
{
    /// <summary>Specifies which Salesforce API is used by Amazon AppFlow when your flow transfers data to Salesforce.</summary>
    [JsonPropertyName("dataTransferApi")]
    public string? DataTransferApi { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforceErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Determines how Amazon AppFlow handles the success response that it gets from the connector after placing data. See Success Response Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }
}

/// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSapoData
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object path specified in the SAPOData flow destination.</summary>
    [JsonPropertyName("objectPath")]
    public string? ObjectPath { get; set; }

    /// <summary>Determines how Amazon AppFlow handles the success response that it gets from the connector after placing data. See Success Response Handling Config for more details.</summary>
    [JsonPropertyName("successResponseHandlingConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig? SuccessResponseHandlingConfig { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflakeErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Snowflake. See Snowflake Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflake
{
    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflakeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Intermediate bucket that Amazon AppFlow uses when moving data into Amazon Redshift.</summary>
    [JsonPropertyName("intermediateBucketName")]
    public string? IntermediateBucketName { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Aggregation settings that you can use to customize the output format of your flow data. See Aggregation Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig
{
    /// <summary>Whether Amazon AppFlow aggregates the flow records into a single file, or leave them unaggregated. Valid values are None and SingleFile.</summary>
    [JsonPropertyName("aggregationType")]
    public string? AggregationType { get; set; }
}

/// <summary>Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You can name folders according to the flow frequency and date. See Prefix Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig
{
    /// <summary>Determines the level of granularity that&apos;s included in the prefix. Valid values are YEAR, MONTH, DAY, HOUR, and MINUTE.</summary>
    [JsonPropertyName("prefixFormat")]
    public string? PrefixFormat { get; set; }

    /// <summary>Determines whether the destination file path includes either or both of the selected elements. Valid values are EXECUTION_ID and SCHEMA_VERSION</summary>
    [JsonPropertyName("prefixHierarchy")]
    public IList<string>? PrefixHierarchy { get; set; }

    /// <summary>Determines the format of the prefix, and whether it applies to the file name, file path, or both. Valid values are FILENAME, PATH, and PATH_AND_FILENAME.</summary>
    [JsonPropertyName("prefixType")]
    public string? PrefixType { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow should format the flow output data when Amazon S3 is used as the destination. See S3 Output Format Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig
{
    /// <summary>Aggregation settings that you can use to customize the output format of your flow data. See Aggregation Config for more details.</summary>
    [JsonPropertyName("aggregationConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig? AggregationConfig { get; set; }

    /// <summary>File type that Amazon AppFlow places in the Amazon S3 bucket. Valid values are CSV, JSON, and PARQUET.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You can name folders according to the flow frequency and date. See Prefix Config for more details.</summary>
    [JsonPropertyName("prefixConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig? PrefixConfig { get; set; }
}

/// <summary>Properties that are required to query Upsolver. See Upsolver Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolver
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow should format the flow output data when Amazon S3 is used as the destination. See S3 Output Format Config for more details.</summary>
    [JsonPropertyName("s3OutputFormatConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig? S3OutputFormatConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesZendesk
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>This stores the information that is required to query a particular connector. See Destination Connector Properties for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorProperties
{
    /// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
    [JsonPropertyName("customConnector")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnector? CustomConnector { get; set; }

    /// <summary>Properties that are required to query Amazon Connect Customer Profiles. See Customer Profiles Destination Properties for more details.</summary>
    [JsonPropertyName("customerProfiles")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles? CustomerProfiles { get; set; }

    /// <summary>Properties that are required to query Amazon EventBridge. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("eventBridge")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridge? EventBridge { get; set; }

    /// <summary>Properties that are required to query Amazon Honeycode. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("honeycode")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycode? Honeycode { get; set; }

    [JsonPropertyName("lookoutMetrics")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics? LookoutMetrics { get; set; }

    /// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("marketo")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesMarketo? Marketo { get; set; }

    /// <summary>Properties that are required to query Amazon Redshift. See Redshift Destination Properties for more details.</summary>
    [JsonPropertyName("redshift")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesRedshift? Redshift { get; set; }

    /// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
    [JsonPropertyName("s3")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesS3? S3 { get; set; }

    /// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
    [JsonPropertyName("salesforce")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforce? Salesforce { get; set; }

    /// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
    [JsonPropertyName("sapoData")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSapoData? SapoData { get; set; }

    /// <summary>Properties that are required to query Snowflake. See Snowflake Destination Properties for more details.</summary>
    [JsonPropertyName("snowflake")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflake? Snowflake { get; set; }

    /// <summary>Properties that are required to query Upsolver. See Upsolver Destination Properties for more details.</summary>
    [JsonPropertyName("upsolver")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolver? Upsolver { get; set; }

    /// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
    [JsonPropertyName("zendesk")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorPropertiesZendesk? Zendesk { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderDestinationFlowConfig
{
    /// <summary>API version that the destination connector uses.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Name of the connector profile. This name must be unique for each connector profile in the AWS account.</summary>
    [JsonPropertyName("connectorProfileName")]
    public string? ConnectorProfileName { get; set; }

    /// <summary>Type of connector, such as Salesforce, Amplitude, and so on. Valid values are Salesforce, Singular, Slack, Redshift, S3, Marketo, Googleanalytics, Zendesk, Servicenow, Datadog, Trendmicro, Snowflake, Dynatrace, Infornexus, Amplitude, Veeva, EventBridge, LookoutMetrics, Upsolver, Honeycode, CustomerProfiles, SAPOData, and CustomConnector.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>This stores the information that is required to query a particular connector. See Destination Connector Properties for more information.</summary>
    [JsonPropertyName("destinationConnectorProperties")]
    public V1beta2FlowSpecInitProviderDestinationFlowConfigDestinationConnectorProperties? DestinationConnectorProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderMetadataCatalogConfigGlueDataCatalog
{
    /// <summary>The name of an existing Glue database to store the metadata tables that Amazon AppFlow creates.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The ARN of an IAM role that grants AppFlow the permissions it needs to create Data Catalog tables, databases, and partitions.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A naming prefix for each Data Catalog table that Amazon AppFlow creates</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }
}

/// <summary>A Catalog that determines the configuration that Amazon AppFlow uses when it catalogs the data that’s transferred by the associated flow. When Amazon AppFlow catalogs the data from a flow, it stores metadata in a data catalog.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderMetadataCatalogConfig
{
    [JsonPropertyName("glueDataCatalog")]
    public V1beta2FlowSpecInitProviderMetadataCatalogConfigGlueDataCatalog? GlueDataCatalog { get; set; }
}

/// <summary>Defines the configuration for a scheduled incremental data pull. If a valid configuration is provided, the fields specified in the configuration are used when querying for the incremental data pull. See Incremental Pull Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigIncrementalPullConfig
{
    /// <summary>Field that specifies the date time or timestamp field as the criteria to use when importing incremental records from the source.</summary>
    [JsonPropertyName("datetimeTypeFieldName")]
    public string? DatetimeTypeFieldName { get; set; }
}

/// <summary>Information that is required for querying Amplitude. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesAmplitude
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesCustomConnector
{
    /// <summary>Custom properties that are specific to the connector when it&apos;s used as a destination in the flow. Maximum of 50 items.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>Entity specified in the custom connector as a destination in the flow.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }
}

/// <summary>Information that is required for querying Datadog. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesDatadog
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Operation to be performed on the provided Dynatrace source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesDynatrace
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Operation to be performed on the provided Google Analytics source fields. Valid values are PROJECTION and BETWEEN.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required for querying Infor Nexus. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesInforNexus
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesMarketo
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum>))]
public enum V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelector
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
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>When you use Amazon S3 as the source, the configuration format that you provide the flow input data. See S3 Input Format Config for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig
{
    /// <summary>File type that Amazon AppFlow gets from your Amazon S3 bucket. Valid values are CSV and JSON.</summary>
    [JsonPropertyName("s3InputFileType")]
    public string? S3InputFileType { get; set; }
}

/// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a BucketPolicy in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3BucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>When you use Amazon S3 as the source, the configuration format that you provide the flow input data. See S3 Input Format Config for details.</summary>
    [JsonPropertyName("s3InputFormatConfig")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig? S3InputFormatConfig { get; set; }
}

/// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSalesforce
{
    /// <summary>Specifies which Salesforce API is used by Amazon AppFlow when your flow transfers data to Salesforce.</summary>
    [JsonPropertyName("dataTransferApi")]
    public string? DataTransferApi { get; set; }

    /// <summary>Flag that enables dynamic fetching of new (recently added) fields in the Salesforce objects while running a flow.</summary>
    [JsonPropertyName("enableDynamicFieldUpdate")]
    public bool? EnableDynamicFieldUpdate { get; set; }

    /// <summary>Whether Amazon AppFlow includes deleted files in the flow run.</summary>
    [JsonPropertyName("includeDeletedRecords")]
    public bool? IncludeDeletedRecords { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Sets the page size for each concurrent process that transfers OData records from your SAP instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig
{
    /// <summary>he maximum number of records that Amazon AppFlow receives in each page of the response from your SAP application.</summary>
    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }
}

/// <summary>Sets the number of concurrent processes that transfers OData records from your SAP instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig
{
    /// <summary>he maximum number of records that Amazon AppFlow receives in each page of the response from your SAP application.</summary>
    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }
}

/// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSapoData
{
    /// <summary>Object path specified in the SAPOData flow destination.</summary>
    [JsonPropertyName("objectPath")]
    public string? ObjectPath { get; set; }

    /// <summary>Sets the page size for each concurrent process that transfers OData records from your SAP instance.</summary>
    [JsonPropertyName("paginationConfig")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig? PaginationConfig { get; set; }

    /// <summary>Sets the number of concurrent processes that transfers OData records from your SAP instance.</summary>
    [JsonPropertyName("parallelismConfig")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig? ParallelismConfig { get; set; }
}

/// <summary>Information that is required for querying ServiceNow. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesServiceNow
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required for querying Singular. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSingular
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required for querying Slack. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSlack
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Operation to be performed on the provided Trend Micro source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesTrendmicro
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required for querying Veeva. See Veeva Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesVeeva
{
    /// <summary>Document type specified in the Veeva document extract flow.</summary>
    [JsonPropertyName("documentType")]
    public string? DocumentType { get; set; }

    /// <summary>Boolean value to include All Versions of files in Veeva document extract flow.</summary>
    [JsonPropertyName("includeAllVersions")]
    public bool? IncludeAllVersions { get; set; }

    /// <summary>Boolean value to include file renditions in Veeva document extract flow.</summary>
    [JsonPropertyName("includeRenditions")]
    public bool? IncludeRenditions { get; set; }

    /// <summary>Boolean value to include source files in Veeva document extract flow.</summary>
    [JsonPropertyName("includeSourceFiles")]
    public bool? IncludeSourceFiles { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesZendesk
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required to query a particular source connector. See Source Connector Properties for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorProperties
{
    /// <summary>Information that is required for querying Amplitude. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("amplitude")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesAmplitude? Amplitude { get; set; }

    /// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
    [JsonPropertyName("customConnector")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesCustomConnector? CustomConnector { get; set; }

    /// <summary>Information that is required for querying Datadog. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("datadog")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesDatadog? Datadog { get; set; }

    /// <summary>Operation to be performed on the provided Dynatrace source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("dynatrace")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesDynatrace? Dynatrace { get; set; }

    /// <summary>Operation to be performed on the provided Google Analytics source fields. Valid values are PROJECTION and BETWEEN.</summary>
    [JsonPropertyName("googleAnalytics")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics? GoogleAnalytics { get; set; }

    /// <summary>Information that is required for querying Infor Nexus. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("inforNexus")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesInforNexus? InforNexus { get; set; }

    /// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("marketo")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesMarketo? Marketo { get; set; }

    /// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
    [JsonPropertyName("s3")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesS3? S3 { get; set; }

    /// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
    [JsonPropertyName("salesforce")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSalesforce? Salesforce { get; set; }

    /// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
    [JsonPropertyName("sapoData")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSapoData? SapoData { get; set; }

    /// <summary>Information that is required for querying ServiceNow. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("serviceNow")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesServiceNow? ServiceNow { get; set; }

    /// <summary>Information that is required for querying Singular. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("singular")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSingular? Singular { get; set; }

    /// <summary>Information that is required for querying Slack. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("slack")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesSlack? Slack { get; set; }

    /// <summary>Operation to be performed on the provided Trend Micro source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("trendmicro")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesTrendmicro? Trendmicro { get; set; }

    /// <summary>Information that is required for querying Veeva. See Veeva Source Properties for more details.</summary>
    [JsonPropertyName("veeva")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesVeeva? Veeva { get; set; }

    /// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
    [JsonPropertyName("zendesk")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorPropertiesZendesk? Zendesk { get; set; }
}

/// <summary>The Source Flow Config that controls how Amazon AppFlow retrieves data from the source connector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderSourceFlowConfig
{
    /// <summary>API version that the destination connector uses.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Name of the connector profile. This name must be unique for each connector profile in the AWS account.</summary>
    [JsonPropertyName("connectorProfileName")]
    public string? ConnectorProfileName { get; set; }

    /// <summary>Type of connector, such as Salesforce, Amplitude, and so on. Valid values are Salesforce, Singular, Slack, Redshift, S3, Marketo, Googleanalytics, Zendesk, Servicenow, Datadog, Trendmicro, Snowflake, Dynatrace, Infornexus, Amplitude, Veeva, EventBridge, LookoutMetrics, Upsolver, Honeycode, CustomerProfiles, SAPOData, and CustomConnector.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>Defines the configuration for a scheduled incremental data pull. If a valid configuration is provided, the fields specified in the configuration are used when querying for the incremental data pull. See Incremental Pull Config for more details.</summary>
    [JsonPropertyName("incrementalPullConfig")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigIncrementalPullConfig? IncrementalPullConfig { get; set; }

    /// <summary>Information that is required to query a particular source connector. See Source Connector Properties for details.</summary>
    [JsonPropertyName("sourceConnectorProperties")]
    public V1beta2FlowSpecInitProviderSourceFlowConfigSourceConnectorProperties? SourceConnectorProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTaskConnectorOperator
{
    /// <summary>Information that is required for querying Amplitude. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("amplitude")]
    public string? Amplitude { get; set; }

    /// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
    [JsonPropertyName("customConnector")]
    public string? CustomConnector { get; set; }

    /// <summary>Information that is required for querying Datadog. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("datadog")]
    public string? Datadog { get; set; }

    /// <summary>Operation to be performed on the provided Dynatrace source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("dynatrace")]
    public string? Dynatrace { get; set; }

    /// <summary>Operation to be performed on the provided Google Analytics source fields. Valid values are PROJECTION and BETWEEN.</summary>
    [JsonPropertyName("googleAnalytics")]
    public string? GoogleAnalytics { get; set; }

    /// <summary>Information that is required for querying Infor Nexus. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("inforNexus")]
    public string? InforNexus { get; set; }

    /// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("marketo")]
    public string? Marketo { get; set; }

    /// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
    [JsonPropertyName("s3")]
    public string? S3 { get; set; }

    /// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
    [JsonPropertyName("salesforce")]
    public string? Salesforce { get; set; }

    /// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
    [JsonPropertyName("sapoData")]
    public string? SapoData { get; set; }

    /// <summary>Information that is required for querying ServiceNow. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("serviceNow")]
    public string? ServiceNow { get; set; }

    /// <summary>Information that is required for querying Singular. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("singular")]
    public string? Singular { get; set; }

    /// <summary>Information that is required for querying Slack. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("slack")]
    public string? Slack { get; set; }

    /// <summary>Operation to be performed on the provided Trend Micro source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("trendmicro")]
    public string? Trendmicro { get; set; }

    /// <summary>Information that is required for querying Veeva. See Veeva Source Properties for more details.</summary>
    [JsonPropertyName("veeva")]
    public string? Veeva { get; set; }

    /// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
    [JsonPropertyName("zendesk")]
    public string? Zendesk { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTask
{
    /// <summary>Operation to be performed on the provided source fields. See Connector Operator for details.</summary>
    [JsonPropertyName("connectorOperator")]
    public IList<V1beta2FlowSpecInitProviderTaskConnectorOperator>? ConnectorOperator { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTriggerConfigTriggerPropertiesScheduled
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

    /// <summary>Scheduling expression that determines the rate at which the schedule will run, for example rate(5minutes).</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>Optional offset that is added to the time interval for a schedule-triggered flow. Maximum value of 36000.</summary>
    [JsonPropertyName("scheduleOffset")]
    public double? ScheduleOffset { get; set; }

    /// <summary>Scheduled start time for a schedule-triggered flow. Must be a valid RFC3339 timestamp.</summary>
    [JsonPropertyName("scheduleStartTime")]
    public string? ScheduleStartTime { get; set; }

    /// <summary>Time zone used when referring to the date and time of a scheduled-triggered flow, such as America/New_York.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>Configuration details of a schedule-triggered flow as defined by the user. Currently, these settings only apply to the Scheduled trigger type. See Scheduled Trigger Properties for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTriggerConfigTriggerProperties
{
    [JsonPropertyName("scheduled")]
    public V1beta2FlowSpecInitProviderTriggerConfigTriggerPropertiesScheduled? Scheduled { get; set; }
}

/// <summary>A Trigger that determine how and when the flow runs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTriggerConfig
{
    /// <summary>Configuration details of a schedule-triggered flow as defined by the user. Currently, these settings only apply to the Scheduled trigger type. See Scheduled Trigger Properties for details.</summary>
    [JsonPropertyName("triggerProperties")]
    public V1beta2FlowSpecInitProviderTriggerConfigTriggerProperties? TriggerProperties { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProvider
{
    /// <summary>Description of the flow you want to create.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A Destination Flow Config that controls how Amazon AppFlow places data in the destination connector.</summary>
    [JsonPropertyName("destinationFlowConfig")]
    public IList<V1beta2FlowSpecInitProviderDestinationFlowConfig>? DestinationFlowConfig { get; set; }

    /// <summary>ARN (Amazon Resource Name) of the Key Management Service (KMS) key you provide for encryption. This is required if you do not want to use the Amazon AppFlow-managed KMS key. If you don&apos;t provide anything here, Amazon AppFlow uses the Amazon AppFlow-managed KMS key.</summary>
    [JsonPropertyName("kmsArn")]
    public string? KmsArn { get; set; }

    /// <summary>A Catalog that determines the configuration that Amazon AppFlow uses when it catalogs the data that’s transferred by the associated flow. When Amazon AppFlow catalogs the data from a flow, it stores metadata in a data catalog.</summary>
    [JsonPropertyName("metadataCatalogConfig")]
    public V1beta2FlowSpecInitProviderMetadataCatalogConfig? MetadataCatalogConfig { get; set; }

    /// <summary>The Source Flow Config that controls how Amazon AppFlow retrieves data from the source connector.</summary>
    [JsonPropertyName("sourceFlowConfig")]
    public V1beta2FlowSpecInitProviderSourceFlowConfig? SourceFlowConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A Task that Amazon AppFlow performs while transferring the data in the flow run.</summary>
    [JsonPropertyName("task")]
    public IList<V1beta2FlowSpecInitProviderTask>? Task { get; set; }

    /// <summary>A Trigger that determine how and when the flow runs.</summary>
    [JsonPropertyName("triggerConfig")]
    public V1beta2FlowSpecInitProviderTriggerConfig? TriggerConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecManagementPoliciesEnum>))]
public enum V1beta2FlowSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FlowSpec defines the desired state of Flow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpec
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
    public V1beta2FlowSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FlowSpecForProvider ForProvider { get; set; }

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
    public V1beta2FlowSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FlowSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FlowSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FlowSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnector
{
    /// <summary>Custom properties that are specific to the connector when it&apos;s used as a destination in the flow. Maximum of 50 items.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>Entity specified in the custom connector as a destination in the flow.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Properties that are required to query Amazon Connect Customer Profiles. See Customer Profiles Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles
{
    /// <summary>Unique name of the Amazon Connect Customer Profiles domain.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Object specified in the Amazon Connect Customer Profiles flow destination.</summary>
    [JsonPropertyName("objectTypeName")]
    public string? ObjectTypeName { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridgeErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Amazon EventBridge. See Generic Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridge
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridgeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Amazon Honeycode. See Generic Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycode
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics
{
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesMarketoErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesMarketo
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesMarketoErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Amazon Redshift. See Redshift Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesRedshift
{
    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Intermediate bucket that Amazon AppFlow uses when moving data into Amazon Redshift.</summary>
    [JsonPropertyName("intermediateBucketName")]
    public string? IntermediateBucketName { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Aggregation settings that you can use to customize the output format of your flow data. See Aggregation Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig
{
    /// <summary>Whether Amazon AppFlow aggregates the flow records into a single file, or leave them unaggregated. Valid values are None and SingleFile.</summary>
    [JsonPropertyName("aggregationType")]
    public string? AggregationType { get; set; }

    /// <summary>The desired file size, in MB, for each output file that Amazon AppFlow writes to the flow destination. Integer value.</summary>
    [JsonPropertyName("targetFileSize")]
    public double? TargetFileSize { get; set; }
}

/// <summary>Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You can name folders according to the flow frequency and date. See Prefix Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig
{
    /// <summary>Determines the level of granularity that&apos;s included in the prefix. Valid values are YEAR, MONTH, DAY, HOUR, and MINUTE.</summary>
    [JsonPropertyName("prefixFormat")]
    public string? PrefixFormat { get; set; }

    /// <summary>Determines whether the destination file path includes either or both of the selected elements. Valid values are EXECUTION_ID and SCHEMA_VERSION</summary>
    [JsonPropertyName("prefixHierarchy")]
    public IList<string>? PrefixHierarchy { get; set; }

    /// <summary>Determines the format of the prefix, and whether it applies to the file name, file path, or both. Valid values are FILENAME, PATH, and PATH_AND_FILENAME.</summary>
    [JsonPropertyName("prefixType")]
    public string? PrefixType { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow should format the flow output data when Amazon S3 is used as the destination. See S3 Output Format Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig
{
    /// <summary>Aggregation settings that you can use to customize the output format of your flow data. See Aggregation Config for more details.</summary>
    [JsonPropertyName("aggregationConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig? AggregationConfig { get; set; }

    /// <summary>File type that Amazon AppFlow places in the Amazon S3 bucket. Valid values are CSV, JSON, and PARQUET.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You can name folders according to the flow frequency and date. See Prefix Config for more details.</summary>
    [JsonPropertyName("prefixConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig? PrefixConfig { get; set; }

    /// <summary>Whether the data types from the source system need to be preserved (Only valid for Parquet file type)</summary>
    [JsonPropertyName("preserveSourceDataTyping")]
    public bool? PreserveSourceDataTyping { get; set; }
}

/// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow should format the flow output data when Amazon S3 is used as the destination. See S3 Output Format Config for more details.</summary>
    [JsonPropertyName("s3OutputFormatConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig? S3OutputFormatConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforceErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforce
{
    /// <summary>Specifies which Salesforce API is used by Amazon AppFlow when your flow transfers data to Salesforce.</summary>
    [JsonPropertyName("dataTransferApi")]
    public string? DataTransferApi { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforceErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Determines how Amazon AppFlow handles the success response that it gets from the connector after placing data. See Success Response Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }
}

/// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSapoData
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object path specified in the SAPOData flow destination.</summary>
    [JsonPropertyName("objectPath")]
    public string? ObjectPath { get; set; }

    /// <summary>Determines how Amazon AppFlow handles the success response that it gets from the connector after placing data. See Success Response Handling Config for more details.</summary>
    [JsonPropertyName("successResponseHandlingConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig? SuccessResponseHandlingConfig { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflakeErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Snowflake. See Snowflake Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflake
{
    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflakeErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Intermediate bucket that Amazon AppFlow uses when moving data into Amazon Redshift.</summary>
    [JsonPropertyName("intermediateBucketName")]
    public string? IntermediateBucketName { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Aggregation settings that you can use to customize the output format of your flow data. See Aggregation Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig
{
    /// <summary>Whether Amazon AppFlow aggregates the flow records into a single file, or leave them unaggregated. Valid values are None and SingleFile.</summary>
    [JsonPropertyName("aggregationType")]
    public string? AggregationType { get; set; }
}

/// <summary>Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You can name folders according to the flow frequency and date. See Prefix Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig
{
    /// <summary>Determines the level of granularity that&apos;s included in the prefix. Valid values are YEAR, MONTH, DAY, HOUR, and MINUTE.</summary>
    [JsonPropertyName("prefixFormat")]
    public string? PrefixFormat { get; set; }

    /// <summary>Determines whether the destination file path includes either or both of the selected elements. Valid values are EXECUTION_ID and SCHEMA_VERSION</summary>
    [JsonPropertyName("prefixHierarchy")]
    public IList<string>? PrefixHierarchy { get; set; }

    /// <summary>Determines the format of the prefix, and whether it applies to the file name, file path, or both. Valid values are FILENAME, PATH, and PATH_AND_FILENAME.</summary>
    [JsonPropertyName("prefixType")]
    public string? PrefixType { get; set; }
}

/// <summary>Configuration that determines how Amazon AppFlow should format the flow output data when Amazon S3 is used as the destination. See S3 Output Format Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig
{
    /// <summary>Aggregation settings that you can use to customize the output format of your flow data. See Aggregation Config for more details.</summary>
    [JsonPropertyName("aggregationConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig? AggregationConfig { get; set; }

    /// <summary>File type that Amazon AppFlow places in the Amazon S3 bucket. Valid values are CSV, JSON, and PARQUET.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You can name folders according to the flow frequency and date. See Prefix Config for more details.</summary>
    [JsonPropertyName("prefixConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig? PrefixConfig { get; set; }
}

/// <summary>Properties that are required to query Upsolver. See Upsolver Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolver
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Configuration that determines how Amazon AppFlow should format the flow output data when Amazon S3 is used as the destination. See S3 Output Format Config for more details.</summary>
    [JsonPropertyName("s3OutputFormatConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig? S3OutputFormatConfig { get; set; }
}

/// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>If the flow should fail after the first instance of a failure when attempting to place data in the destination.</summary>
    [JsonPropertyName("failOnFirstDestinationError")]
    public bool? FailOnFirstDestinationError { get; set; }
}

/// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesZendesk
{
    /// <summary>Settings that determine how Amazon AppFlow handles an error when placing data in the destination. See Error Handling Config for more details.</summary>
    [JsonPropertyName("errorHandlingConfig")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesZendeskErrorHandlingConfig? ErrorHandlingConfig { get; set; }

    /// <summary>Name of the field that Amazon AppFlow uses as an ID when performing a write operation such as update, delete, or upsert.</summary>
    [JsonPropertyName("idFieldNames")]
    public IList<string>? IdFieldNames { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Type of write operation to be performed in the custom connector when it&apos;s used as destination. Valid values are INSERT, UPSERT, UPDATE, and DELETE.</summary>
    [JsonPropertyName("writeOperationType")]
    public string? WriteOperationType { get; set; }
}

/// <summary>This stores the information that is required to query a particular connector. See Destination Connector Properties for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorProperties
{
    /// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
    [JsonPropertyName("customConnector")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesCustomConnector? CustomConnector { get; set; }

    /// <summary>Properties that are required to query Amazon Connect Customer Profiles. See Customer Profiles Destination Properties for more details.</summary>
    [JsonPropertyName("customerProfiles")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles? CustomerProfiles { get; set; }

    /// <summary>Properties that are required to query Amazon EventBridge. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("eventBridge")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesEventBridge? EventBridge { get; set; }

    /// <summary>Properties that are required to query Amazon Honeycode. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("honeycode")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesHoneycode? Honeycode { get; set; }

    [JsonPropertyName("lookoutMetrics")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesLookoutMetrics? LookoutMetrics { get; set; }

    /// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("marketo")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesMarketo? Marketo { get; set; }

    /// <summary>Properties that are required to query Amazon Redshift. See Redshift Destination Properties for more details.</summary>
    [JsonPropertyName("redshift")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesRedshift? Redshift { get; set; }

    /// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
    [JsonPropertyName("s3")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesS3? S3 { get; set; }

    /// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
    [JsonPropertyName("salesforce")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSalesforce? Salesforce { get; set; }

    /// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
    [JsonPropertyName("sapoData")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSapoData? SapoData { get; set; }

    /// <summary>Properties that are required to query Snowflake. See Snowflake Destination Properties for more details.</summary>
    [JsonPropertyName("snowflake")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesSnowflake? Snowflake { get; set; }

    /// <summary>Properties that are required to query Upsolver. See Upsolver Destination Properties for more details.</summary>
    [JsonPropertyName("upsolver")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesUpsolver? Upsolver { get; set; }

    /// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
    [JsonPropertyName("zendesk")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorPropertiesZendesk? Zendesk { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderDestinationFlowConfig
{
    /// <summary>API version that the destination connector uses.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Name of the connector profile. This name must be unique for each connector profile in the AWS account.</summary>
    [JsonPropertyName("connectorProfileName")]
    public string? ConnectorProfileName { get; set; }

    /// <summary>Type of connector, such as Salesforce, Amplitude, and so on. Valid values are Salesforce, Singular, Slack, Redshift, S3, Marketo, Googleanalytics, Zendesk, Servicenow, Datadog, Trendmicro, Snowflake, Dynatrace, Infornexus, Amplitude, Veeva, EventBridge, LookoutMetrics, Upsolver, Honeycode, CustomerProfiles, SAPOData, and CustomConnector.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>This stores the information that is required to query a particular connector. See Destination Connector Properties for more information.</summary>
    [JsonPropertyName("destinationConnectorProperties")]
    public V1beta2FlowStatusAtProviderDestinationFlowConfigDestinationConnectorProperties? DestinationConnectorProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderMetadataCatalogConfigGlueDataCatalog
{
    /// <summary>The name of an existing Glue database to store the metadata tables that Amazon AppFlow creates.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The ARN of an IAM role that grants AppFlow the permissions it needs to create Data Catalog tables, databases, and partitions.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A naming prefix for each Data Catalog table that Amazon AppFlow creates</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }
}

/// <summary>A Catalog that determines the configuration that Amazon AppFlow uses when it catalogs the data that’s transferred by the associated flow. When Amazon AppFlow catalogs the data from a flow, it stores metadata in a data catalog.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderMetadataCatalogConfig
{
    [JsonPropertyName("glueDataCatalog")]
    public V1beta2FlowStatusAtProviderMetadataCatalogConfigGlueDataCatalog? GlueDataCatalog { get; set; }
}

/// <summary>Defines the configuration for a scheduled incremental data pull. If a valid configuration is provided, the fields specified in the configuration are used when querying for the incremental data pull. See Incremental Pull Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigIncrementalPullConfig
{
    /// <summary>Field that specifies the date time or timestamp field as the criteria to use when importing incremental records from the source.</summary>
    [JsonPropertyName("datetimeTypeFieldName")]
    public string? DatetimeTypeFieldName { get; set; }
}

/// <summary>Information that is required for querying Amplitude. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesAmplitude
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesCustomConnector
{
    /// <summary>Custom properties that are specific to the connector when it&apos;s used as a destination in the flow. Maximum of 50 items.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>Entity specified in the custom connector as a destination in the flow.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }
}

/// <summary>Information that is required for querying Datadog. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesDatadog
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Operation to be performed on the provided Dynatrace source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesDynatrace
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Operation to be performed on the provided Google Analytics source fields. Valid values are PROJECTION and BETWEEN.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required for querying Infor Nexus. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesInforNexus
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesMarketo
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>When you use Amazon S3 as the source, the configuration format that you provide the flow input data. See S3 Input Format Config for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig
{
    /// <summary>File type that Amazon AppFlow gets from your Amazon S3 bucket. Valid values are CSV and JSON.</summary>
    [JsonPropertyName("s3InputFileType")]
    public string? S3InputFileType { get; set; }
}

/// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesS3
{
    /// <summary>Amazon S3 bucket name in which Amazon AppFlow places the transferred data.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Object key for the bucket in which Amazon AppFlow places the destination files.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>When you use Amazon S3 as the source, the configuration format that you provide the flow input data. See S3 Input Format Config for details.</summary>
    [JsonPropertyName("s3InputFormatConfig")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig? S3InputFormatConfig { get; set; }
}

/// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSalesforce
{
    /// <summary>Specifies which Salesforce API is used by Amazon AppFlow when your flow transfers data to Salesforce.</summary>
    [JsonPropertyName("dataTransferApi")]
    public string? DataTransferApi { get; set; }

    /// <summary>Flag that enables dynamic fetching of new (recently added) fields in the Salesforce objects while running a flow.</summary>
    [JsonPropertyName("enableDynamicFieldUpdate")]
    public bool? EnableDynamicFieldUpdate { get; set; }

    /// <summary>Whether Amazon AppFlow includes deleted files in the flow run.</summary>
    [JsonPropertyName("includeDeletedRecords")]
    public bool? IncludeDeletedRecords { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Sets the page size for each concurrent process that transfers OData records from your SAP instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig
{
    /// <summary>he maximum number of records that Amazon AppFlow receives in each page of the response from your SAP application.</summary>
    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }
}

/// <summary>Sets the number of concurrent processes that transfers OData records from your SAP instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig
{
    /// <summary>he maximum number of records that Amazon AppFlow receives in each page of the response from your SAP application.</summary>
    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }
}

/// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSapoData
{
    /// <summary>Object path specified in the SAPOData flow destination.</summary>
    [JsonPropertyName("objectPath")]
    public string? ObjectPath { get; set; }

    /// <summary>Sets the page size for each concurrent process that transfers OData records from your SAP instance.</summary>
    [JsonPropertyName("paginationConfig")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSapoDataPaginationConfig? PaginationConfig { get; set; }

    /// <summary>Sets the number of concurrent processes that transfers OData records from your SAP instance.</summary>
    [JsonPropertyName("parallelismConfig")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSapoDataParallelismConfig? ParallelismConfig { get; set; }
}

/// <summary>Information that is required for querying ServiceNow. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesServiceNow
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required for querying Singular. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSingular
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required for querying Slack. See Generic Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSlack
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Operation to be performed on the provided Trend Micro source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesTrendmicro
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required for querying Veeva. See Veeva Source Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesVeeva
{
    /// <summary>Document type specified in the Veeva document extract flow.</summary>
    [JsonPropertyName("documentType")]
    public string? DocumentType { get; set; }

    /// <summary>Boolean value to include All Versions of files in Veeva document extract flow.</summary>
    [JsonPropertyName("includeAllVersions")]
    public bool? IncludeAllVersions { get; set; }

    /// <summary>Boolean value to include file renditions in Veeva document extract flow.</summary>
    [JsonPropertyName("includeRenditions")]
    public bool? IncludeRenditions { get; set; }

    /// <summary>Boolean value to include source files in Veeva document extract flow.</summary>
    [JsonPropertyName("includeSourceFiles")]
    public bool? IncludeSourceFiles { get; set; }

    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesZendesk
{
    /// <summary>Object specified in the flow destination.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>Information that is required to query a particular source connector. See Source Connector Properties for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorProperties
{
    /// <summary>Information that is required for querying Amplitude. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("amplitude")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesAmplitude? Amplitude { get; set; }

    /// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
    [JsonPropertyName("customConnector")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesCustomConnector? CustomConnector { get; set; }

    /// <summary>Information that is required for querying Datadog. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("datadog")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesDatadog? Datadog { get; set; }

    /// <summary>Operation to be performed on the provided Dynatrace source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("dynatrace")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesDynatrace? Dynatrace { get; set; }

    /// <summary>Operation to be performed on the provided Google Analytics source fields. Valid values are PROJECTION and BETWEEN.</summary>
    [JsonPropertyName("googleAnalytics")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesGoogleAnalytics? GoogleAnalytics { get; set; }

    /// <summary>Information that is required for querying Infor Nexus. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("inforNexus")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesInforNexus? InforNexus { get; set; }

    /// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("marketo")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesMarketo? Marketo { get; set; }

    /// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
    [JsonPropertyName("s3")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesS3? S3 { get; set; }

    /// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
    [JsonPropertyName("salesforce")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSalesforce? Salesforce { get; set; }

    /// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
    [JsonPropertyName("sapoData")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSapoData? SapoData { get; set; }

    /// <summary>Information that is required for querying ServiceNow. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("serviceNow")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesServiceNow? ServiceNow { get; set; }

    /// <summary>Information that is required for querying Singular. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("singular")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSingular? Singular { get; set; }

    /// <summary>Information that is required for querying Slack. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("slack")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesSlack? Slack { get; set; }

    /// <summary>Operation to be performed on the provided Trend Micro source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("trendmicro")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesTrendmicro? Trendmicro { get; set; }

    /// <summary>Information that is required for querying Veeva. See Veeva Source Properties for more details.</summary>
    [JsonPropertyName("veeva")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesVeeva? Veeva { get; set; }

    /// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
    [JsonPropertyName("zendesk")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorPropertiesZendesk? Zendesk { get; set; }
}

/// <summary>The Source Flow Config that controls how Amazon AppFlow retrieves data from the source connector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderSourceFlowConfig
{
    /// <summary>API version that the destination connector uses.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Name of the connector profile. This name must be unique for each connector profile in the AWS account.</summary>
    [JsonPropertyName("connectorProfileName")]
    public string? ConnectorProfileName { get; set; }

    /// <summary>Type of connector, such as Salesforce, Amplitude, and so on. Valid values are Salesforce, Singular, Slack, Redshift, S3, Marketo, Googleanalytics, Zendesk, Servicenow, Datadog, Trendmicro, Snowflake, Dynatrace, Infornexus, Amplitude, Veeva, EventBridge, LookoutMetrics, Upsolver, Honeycode, CustomerProfiles, SAPOData, and CustomConnector.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>Defines the configuration for a scheduled incremental data pull. If a valid configuration is provided, the fields specified in the configuration are used when querying for the incremental data pull. See Incremental Pull Config for more details.</summary>
    [JsonPropertyName("incrementalPullConfig")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigIncrementalPullConfig? IncrementalPullConfig { get; set; }

    /// <summary>Information that is required to query a particular source connector. See Source Connector Properties for details.</summary>
    [JsonPropertyName("sourceConnectorProperties")]
    public V1beta2FlowStatusAtProviderSourceFlowConfigSourceConnectorProperties? SourceConnectorProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderTaskConnectorOperator
{
    /// <summary>Information that is required for querying Amplitude. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("amplitude")]
    public string? Amplitude { get; set; }

    /// <summary>Properties that are required to query the custom Connector. See Custom Connector Destination Properties for more details.</summary>
    [JsonPropertyName("customConnector")]
    public string? CustomConnector { get; set; }

    /// <summary>Information that is required for querying Datadog. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("datadog")]
    public string? Datadog { get; set; }

    /// <summary>Operation to be performed on the provided Dynatrace source fields. Valid values are PROJECTION, BETWEEN, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("dynatrace")]
    public string? Dynatrace { get; set; }

    /// <summary>Operation to be performed on the provided Google Analytics source fields. Valid values are PROJECTION and BETWEEN.</summary>
    [JsonPropertyName("googleAnalytics")]
    public string? GoogleAnalytics { get; set; }

    /// <summary>Information that is required for querying Infor Nexus. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("inforNexus")]
    public string? InforNexus { get; set; }

    /// <summary>Properties that are required to query Marketo. See Generic Destination Properties for more details.</summary>
    [JsonPropertyName("marketo")]
    public string? Marketo { get; set; }

    /// <summary>Properties that are required to query Amazon S3. See S3 Destination Properties for more details.</summary>
    [JsonPropertyName("s3")]
    public string? S3 { get; set; }

    /// <summary>Properties that are required to query Salesforce. See Salesforce Destination Properties for more details.</summary>
    [JsonPropertyName("salesforce")]
    public string? Salesforce { get; set; }

    /// <summary>Properties that are required to query SAPOData. See SAPOData Destination Properties for more details.</summary>
    [JsonPropertyName("sapoData")]
    public string? SapoData { get; set; }

    /// <summary>Information that is required for querying ServiceNow. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("serviceNow")]
    public string? ServiceNow { get; set; }

    /// <summary>Information that is required for querying Singular. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("singular")]
    public string? Singular { get; set; }

    /// <summary>Information that is required for querying Slack. See Generic Source Properties for more details.</summary>
    [JsonPropertyName("slack")]
    public string? Slack { get; set; }

    /// <summary>Operation to be performed on the provided Trend Micro source fields. Valid values are PROJECTION, EQUAL_TO, ADDITION, MULTIPLICATION, DIVISION, SUBTRACTION, MASK_ALL, MASK_FIRST_N, MASK_LAST_N, VALIDATE_NON_NULL, VALIDATE_NON_ZERO, VALIDATE_NON_NEGATIVE, VALIDATE_NUMERIC, and NO_OP.</summary>
    [JsonPropertyName("trendmicro")]
    public string? Trendmicro { get; set; }

    /// <summary>Information that is required for querying Veeva. See Veeva Source Properties for more details.</summary>
    [JsonPropertyName("veeva")]
    public string? Veeva { get; set; }

    /// <summary>Properties that are required to query Zendesk. See Zendesk Destination Properties for more details.</summary>
    [JsonPropertyName("zendesk")]
    public string? Zendesk { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderTask
{
    /// <summary>Operation to be performed on the provided source fields. See Connector Operator for details.</summary>
    [JsonPropertyName("connectorOperator")]
    public IList<V1beta2FlowStatusAtProviderTaskConnectorOperator>? ConnectorOperator { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderTriggerConfigTriggerPropertiesScheduled
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

    /// <summary>Scheduling expression that determines the rate at which the schedule will run, for example rate(5minutes).</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>Optional offset that is added to the time interval for a schedule-triggered flow. Maximum value of 36000.</summary>
    [JsonPropertyName("scheduleOffset")]
    public double? ScheduleOffset { get; set; }

    /// <summary>Scheduled start time for a schedule-triggered flow. Must be a valid RFC3339 timestamp.</summary>
    [JsonPropertyName("scheduleStartTime")]
    public string? ScheduleStartTime { get; set; }

    /// <summary>Time zone used when referring to the date and time of a scheduled-triggered flow, such as America/New_York.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>Configuration details of a schedule-triggered flow as defined by the user. Currently, these settings only apply to the Scheduled trigger type. See Scheduled Trigger Properties for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderTriggerConfigTriggerProperties
{
    [JsonPropertyName("scheduled")]
    public V1beta2FlowStatusAtProviderTriggerConfigTriggerPropertiesScheduled? Scheduled { get; set; }
}

/// <summary>A Trigger that determine how and when the flow runs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderTriggerConfig
{
    /// <summary>Configuration details of a schedule-triggered flow as defined by the user. Currently, these settings only apply to the Scheduled trigger type. See Scheduled Trigger Properties for details.</summary>
    [JsonPropertyName("triggerProperties")]
    public V1beta2FlowStatusAtProviderTriggerConfigTriggerProperties? TriggerProperties { get; set; }

    /// <summary>Type of flow trigger. Valid values are Scheduled, Event, and OnDemand.</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProvider
{
    /// <summary>Flow&apos;s ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description of the flow you want to create.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A Destination Flow Config that controls how Amazon AppFlow places data in the destination connector.</summary>
    [JsonPropertyName("destinationFlowConfig")]
    public IList<V1beta2FlowStatusAtProviderDestinationFlowConfig>? DestinationFlowConfig { get; set; }

    /// <summary>The current status of the flow.</summary>
    [JsonPropertyName("flowStatus")]
    public string? FlowStatus { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN (Amazon Resource Name) of the Key Management Service (KMS) key you provide for encryption. This is required if you do not want to use the Amazon AppFlow-managed KMS key. If you don&apos;t provide anything here, Amazon AppFlow uses the Amazon AppFlow-managed KMS key.</summary>
    [JsonPropertyName("kmsArn")]
    public string? KmsArn { get; set; }

    /// <summary>A Catalog that determines the configuration that Amazon AppFlow uses when it catalogs the data that’s transferred by the associated flow. When Amazon AppFlow catalogs the data from a flow, it stores metadata in a data catalog.</summary>
    [JsonPropertyName("metadataCatalogConfig")]
    public V1beta2FlowStatusAtProviderMetadataCatalogConfig? MetadataCatalogConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The Source Flow Config that controls how Amazon AppFlow retrieves data from the source connector.</summary>
    [JsonPropertyName("sourceFlowConfig")]
    public V1beta2FlowStatusAtProviderSourceFlowConfig? SourceFlowConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>A Task that Amazon AppFlow performs while transferring the data in the flow run.</summary>
    [JsonPropertyName("task")]
    public IList<V1beta2FlowStatusAtProviderTask>? Task { get; set; }

    /// <summary>A Trigger that determine how and when the flow runs.</summary>
    [JsonPropertyName("triggerConfig")]
    public V1beta2FlowStatusAtProviderTriggerConfig? TriggerConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FlowStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FlowStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Flow is the Schema for the Flows API. Provides an AppFlow Flow resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Flow : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FlowSpec>, IStatus<V1beta2FlowStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Flow";
    public const string KubeGroup = "appflow.aws.upbound.io";
    public const string KubePluralName = "flows";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appflow.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Flow";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FlowSpec defines the desired state of Flow</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FlowSpec Spec { get; set; }

    /// <summary>FlowStatus defines the observed state of Flow.</summary>
    [JsonPropertyName("status")]
    public V1beta2FlowStatus? Status { get; set; }
}