#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.upbound.io;
/// <summary>DataSetParquet is the Schema for the DataSetParquets API. Manages an Azure Parquet Dataset inside an Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DataSetParquetList : IKubernetesObject<V1ListMeta>, IItems<V1beta2DataSetParquet>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DataSetParquetList";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "datasetparquets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datafactory.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataSetParquetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2DataSetParquet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2DataSetParquet> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecDeletionPolicyEnum>))]
public enum V1beta2DataSetParquetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A azure_blob_fs_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProviderAzureBlobFsLocation
{
    /// <summary>Is the file_system using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFileSystemEnabled")]
    public bool? DynamicFileSystemEnabled { get; set; }

    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The container on the Azure Data Lake Storage Account hosting the file.</summary>
    [JsonPropertyName("fileSystem")]
    public string? FileSystem { get; set; }

    /// <summary>The filename of the file on the Azure Data Lake Storage Account.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the Azure Data Lake Storage Account.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A azure_blob_storage_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProviderAzureBlobStorageLocation
{
    /// <summary>The container on the Azure Blob Storage Account hosting the file.</summary>
    [JsonPropertyName("container")]
    public string? Container { get; set; }

    /// <summary>Is the container using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicContainerEnabled")]
    public bool? DynamicContainerEnabled { get; set; }

    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the Azure Blob Storage Account.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the Azure Blob Storage Account.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecForProviderDataFactoryIdRefPolicyResolutionEnum>))]
public enum V1beta2DataSetParquetSpecForProviderDataFactoryIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecForProviderDataFactoryIdRefPolicyResolveEnum>))]
public enum V1beta2DataSetParquetSpecForProviderDataFactoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProviderDataFactoryIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetParquetSpecForProviderDataFactoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetParquetSpecForProviderDataFactoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSetParquetSpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSetParquetSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecForProviderDataFactoryIdSelectorPolicyResolveEnum>))]
public enum V1beta2DataSetParquetSpecForProviderDataFactoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProviderDataFactoryIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetParquetSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetParquetSpecForProviderDataFactoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProviderDataFactoryIdSelector
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
    public V1beta2DataSetParquetSpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A http_server_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProviderHttpServerLocation
{
    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the web server.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the web server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The base URL to the web server hosting the file.</summary>
    [JsonPropertyName("relativeUrl")]
    public string? RelativeUrl { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecForProviderLinkedServiceNameRefPolicyResolutionEnum>))]
public enum V1beta2DataSetParquetSpecForProviderLinkedServiceNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecForProviderLinkedServiceNameRefPolicyResolveEnum>))]
public enum V1beta2DataSetParquetSpecForProviderLinkedServiceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProviderLinkedServiceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetParquetSpecForProviderLinkedServiceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetParquetSpecForProviderLinkedServiceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProviderLinkedServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSetParquetSpecForProviderLinkedServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecForProviderLinkedServiceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSetParquetSpecForProviderLinkedServiceNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecForProviderLinkedServiceNameSelectorPolicyResolveEnum>))]
public enum V1beta2DataSetParquetSpecForProviderLinkedServiceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProviderLinkedServiceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetParquetSpecForProviderLinkedServiceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetParquetSpecForProviderLinkedServiceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProviderLinkedServiceNameSelector
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
    public V1beta2DataSetParquetSpecForProviderLinkedServiceNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProviderSchemaColumn
{
    /// <summary>The description of the column.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of the column. Valid values are Byte, Byte[], Boolean, Date, DateTime,DateTimeOffset, Decimal, Double, Guid, Int16, Int32, Int64, Single, String, TimeSpan. Please note these values are case sensitive.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecForProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Dataset.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Dataset.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>A azure_blob_fs_location block as defined below.</summary>
    [JsonPropertyName("azureBlobFsLocation")]
    public V1beta2DataSetParquetSpecForProviderAzureBlobFsLocation? AzureBlobFsLocation { get; set; }

    /// <summary>A azure_blob_storage_location block as defined below.</summary>
    [JsonPropertyName("azureBlobStorageLocation")]
    public V1beta2DataSetParquetSpecForProviderAzureBlobStorageLocation? AzureBlobStorageLocation { get; set; }

    /// <summary>The compression codec used to read/write text files. Valid values are bzip2, gzip, deflate, ZipDeflate, TarGzip, Tar, snappy, or lz4. Please note these values are case-sensitive.</summary>
    [JsonPropertyName("compressionCodec")]
    public string? CompressionCodec { get; set; }

    /// <summary>Specifies the compression level. Possible values are Optimal and Fastest,</summary>
    [JsonPropertyName("compressionLevel")]
    public string? CompressionLevel { get; set; }

    /// <summary>The Data Factory ID in which to associate the Dataset with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta2DataSetParquetSpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta2DataSetParquetSpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>The description for the Data Factory Dataset.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>A http_server_location block as defined below.</summary>
    [JsonPropertyName("httpServerLocation")]
    public V1beta2DataSetParquetSpecForProviderHttpServerLocation? HttpServerLocation { get; set; }

    /// <summary>The Data Factory Linked Service name in which to associate the Dataset with.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Reference to a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameRef")]
    public V1beta2DataSetParquetSpecForProviderLinkedServiceNameRef? LinkedServiceNameRef { get; set; }

    /// <summary>Selector for a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameSelector")]
    public V1beta2DataSetParquetSpecForProviderLinkedServiceNameSelector? LinkedServiceNameSelector { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Dataset.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A schema_column block as defined below.</summary>
    [JsonPropertyName("schemaColumn")]
    public IList<V1beta2DataSetParquetSpecForProviderSchemaColumn>? SchemaColumn { get; set; }
}

/// <summary>A azure_blob_fs_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecInitProviderAzureBlobFsLocation
{
    /// <summary>Is the file_system using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFileSystemEnabled")]
    public bool? DynamicFileSystemEnabled { get; set; }

    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The container on the Azure Data Lake Storage Account hosting the file.</summary>
    [JsonPropertyName("fileSystem")]
    public string? FileSystem { get; set; }

    /// <summary>The filename of the file on the Azure Data Lake Storage Account.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the Azure Data Lake Storage Account.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A azure_blob_storage_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecInitProviderAzureBlobStorageLocation
{
    /// <summary>The container on the Azure Blob Storage Account hosting the file.</summary>
    [JsonPropertyName("container")]
    public string? Container { get; set; }

    /// <summary>Is the container using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicContainerEnabled")]
    public bool? DynamicContainerEnabled { get; set; }

    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the Azure Blob Storage Account.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the Azure Blob Storage Account.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A http_server_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecInitProviderHttpServerLocation
{
    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the web server.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the web server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The base URL to the web server hosting the file.</summary>
    [JsonPropertyName("relativeUrl")]
    public string? RelativeUrl { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecInitProviderLinkedServiceNameRefPolicyResolutionEnum>))]
public enum V1beta2DataSetParquetSpecInitProviderLinkedServiceNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecInitProviderLinkedServiceNameRefPolicyResolveEnum>))]
public enum V1beta2DataSetParquetSpecInitProviderLinkedServiceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecInitProviderLinkedServiceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetParquetSpecInitProviderLinkedServiceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetParquetSpecInitProviderLinkedServiceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecInitProviderLinkedServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSetParquetSpecInitProviderLinkedServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecInitProviderLinkedServiceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSetParquetSpecInitProviderLinkedServiceNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecInitProviderLinkedServiceNameSelectorPolicyResolveEnum>))]
public enum V1beta2DataSetParquetSpecInitProviderLinkedServiceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecInitProviderLinkedServiceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetParquetSpecInitProviderLinkedServiceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetParquetSpecInitProviderLinkedServiceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecInitProviderLinkedServiceNameSelector
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
    public V1beta2DataSetParquetSpecInitProviderLinkedServiceNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecInitProviderSchemaColumn
{
    /// <summary>The description of the column.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of the column. Valid values are Byte, Byte[], Boolean, Date, DateTime,DateTimeOffset, Decimal, Double, Guid, Int16, Int32, Int64, Single, String, TimeSpan. Please note these values are case sensitive.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
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
public partial class V1beta2DataSetParquetSpecInitProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Dataset.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Dataset.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>A azure_blob_fs_location block as defined below.</summary>
    [JsonPropertyName("azureBlobFsLocation")]
    public V1beta2DataSetParquetSpecInitProviderAzureBlobFsLocation? AzureBlobFsLocation { get; set; }

    /// <summary>A azure_blob_storage_location block as defined below.</summary>
    [JsonPropertyName("azureBlobStorageLocation")]
    public V1beta2DataSetParquetSpecInitProviderAzureBlobStorageLocation? AzureBlobStorageLocation { get; set; }

    /// <summary>The compression codec used to read/write text files. Valid values are bzip2, gzip, deflate, ZipDeflate, TarGzip, Tar, snappy, or lz4. Please note these values are case-sensitive.</summary>
    [JsonPropertyName("compressionCodec")]
    public string? CompressionCodec { get; set; }

    /// <summary>Specifies the compression level. Possible values are Optimal and Fastest,</summary>
    [JsonPropertyName("compressionLevel")]
    public string? CompressionLevel { get; set; }

    /// <summary>The description for the Data Factory Dataset.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>A http_server_location block as defined below.</summary>
    [JsonPropertyName("httpServerLocation")]
    public V1beta2DataSetParquetSpecInitProviderHttpServerLocation? HttpServerLocation { get; set; }

    /// <summary>The Data Factory Linked Service name in which to associate the Dataset with.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Reference to a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameRef")]
    public V1beta2DataSetParquetSpecInitProviderLinkedServiceNameRef? LinkedServiceNameRef { get; set; }

    /// <summary>Selector for a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameSelector")]
    public V1beta2DataSetParquetSpecInitProviderLinkedServiceNameSelector? LinkedServiceNameSelector { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Dataset.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A schema_column block as defined below.</summary>
    [JsonPropertyName("schemaColumn")]
    public IList<V1beta2DataSetParquetSpecInitProviderSchemaColumn>? SchemaColumn { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecManagementPoliciesEnum>))]
public enum V1beta2DataSetParquetSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DataSetParquetSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetParquetSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DataSetParquetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetParquetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetParquetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSetParquetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DataSetParquetSpec defines the desired state of DataSetParquet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetSpec
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
    public V1beta2DataSetParquetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DataSetParquetSpecForProvider ForProvider { get; set; }

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
    public V1beta2DataSetParquetSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DataSetParquetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DataSetParquetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DataSetParquetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A azure_blob_fs_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetStatusAtProviderAzureBlobFsLocation
{
    /// <summary>Is the file_system using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFileSystemEnabled")]
    public bool? DynamicFileSystemEnabled { get; set; }

    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The container on the Azure Data Lake Storage Account hosting the file.</summary>
    [JsonPropertyName("fileSystem")]
    public string? FileSystem { get; set; }

    /// <summary>The filename of the file on the Azure Data Lake Storage Account.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the Azure Data Lake Storage Account.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A azure_blob_storage_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetStatusAtProviderAzureBlobStorageLocation
{
    /// <summary>The container on the Azure Blob Storage Account hosting the file.</summary>
    [JsonPropertyName("container")]
    public string? Container { get; set; }

    /// <summary>Is the container using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicContainerEnabled")]
    public bool? DynamicContainerEnabled { get; set; }

    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the Azure Blob Storage Account.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the Azure Blob Storage Account.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A http_server_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetStatusAtProviderHttpServerLocation
{
    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the web server.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the web server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The base URL to the web server hosting the file.</summary>
    [JsonPropertyName("relativeUrl")]
    public string? RelativeUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetStatusAtProviderSchemaColumn
{
    /// <summary>The description of the column.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of the column. Valid values are Byte, Byte[], Boolean, Date, DateTime,DateTimeOffset, Decimal, Double, Guid, Int16, Int32, Int64, Single, String, TimeSpan. Please note these values are case sensitive.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetStatusAtProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Dataset.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Dataset.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>A azure_blob_fs_location block as defined below.</summary>
    [JsonPropertyName("azureBlobFsLocation")]
    public V1beta2DataSetParquetStatusAtProviderAzureBlobFsLocation? AzureBlobFsLocation { get; set; }

    /// <summary>A azure_blob_storage_location block as defined below.</summary>
    [JsonPropertyName("azureBlobStorageLocation")]
    public V1beta2DataSetParquetStatusAtProviderAzureBlobStorageLocation? AzureBlobStorageLocation { get; set; }

    /// <summary>The compression codec used to read/write text files. Valid values are bzip2, gzip, deflate, ZipDeflate, TarGzip, Tar, snappy, or lz4. Please note these values are case-sensitive.</summary>
    [JsonPropertyName("compressionCodec")]
    public string? CompressionCodec { get; set; }

    /// <summary>Specifies the compression level. Possible values are Optimal and Fastest,</summary>
    [JsonPropertyName("compressionLevel")]
    public string? CompressionLevel { get; set; }

    /// <summary>The Data Factory ID in which to associate the Dataset with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>The description for the Data Factory Dataset.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>A http_server_location block as defined below.</summary>
    [JsonPropertyName("httpServerLocation")]
    public V1beta2DataSetParquetStatusAtProviderHttpServerLocation? HttpServerLocation { get; set; }

    /// <summary>The ID of the Data Factory Dataset.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Data Factory Linked Service name in which to associate the Dataset with.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Dataset.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A schema_column block as defined below.</summary>
    [JsonPropertyName("schemaColumn")]
    public IList<V1beta2DataSetParquetStatusAtProviderSchemaColumn>? SchemaColumn { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetStatusConditions
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

/// <summary>DataSetParquetStatus defines the observed state of DataSetParquet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetParquetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DataSetParquetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DataSetParquetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DataSetParquet is the Schema for the DataSetParquets API. Manages an Azure Parquet Dataset inside an Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DataSetParquet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DataSetParquetSpec>, IStatus<V1beta2DataSetParquetStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DataSetParquet";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "datasetparquets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datafactory.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataSetParquet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataSetParquetSpec defines the desired state of DataSetParquet</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DataSetParquetSpec Spec { get; set; }

    /// <summary>DataSetParquetStatus defines the observed state of DataSetParquet.</summary>
    [JsonPropertyName("status")]
    public V1beta2DataSetParquetStatus? Status { get; set; }
}