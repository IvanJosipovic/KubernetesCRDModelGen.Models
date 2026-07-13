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
/// <summary>DataSetBinary is the Schema for the DataSetBinarys API. Manages a Data Factory Binary Dataset inside an Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DataSetBinaryList : IKubernetesObject<V1ListMeta>, IItems<V1beta2DataSetBinary>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DataSetBinaryList";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "datasetbinaries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datafactory.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataSetBinaryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2DataSetBinary objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2DataSetBinary> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecDeletionPolicyEnum>))]
public enum V1beta2DataSetBinarySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A azure_blob_storage_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProviderAzureBlobStorageLocation
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

    /// <summary>The filename of the file in the blob container.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file in the blob container.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A compression block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProviderCompression
{
    /// <summary>The level of compression. Possible values are Fastest and Optimal.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The type of compression used during transport. Possible values are BZip2, Deflate, GZip, Tar, TarGZip and ZipDeflate.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecForProviderDataFactoryIdRefPolicyResolutionEnum>))]
public enum V1beta2DataSetBinarySpecForProviderDataFactoryIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecForProviderDataFactoryIdRefPolicyResolveEnum>))]
public enum V1beta2DataSetBinarySpecForProviderDataFactoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProviderDataFactoryIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetBinarySpecForProviderDataFactoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetBinarySpecForProviderDataFactoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSetBinarySpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecForProviderDataFactoryIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSetBinarySpecForProviderDataFactoryIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecForProviderDataFactoryIdSelectorPolicyResolveEnum>))]
public enum V1beta2DataSetBinarySpecForProviderDataFactoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProviderDataFactoryIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetBinarySpecForProviderDataFactoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetBinarySpecForProviderDataFactoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProviderDataFactoryIdSelector
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
    public V1beta2DataSetBinarySpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A http_server_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProviderHttpServerLocation
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecForProviderLinkedServiceNameRefPolicyResolutionEnum>))]
public enum V1beta2DataSetBinarySpecForProviderLinkedServiceNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecForProviderLinkedServiceNameRefPolicyResolveEnum>))]
public enum V1beta2DataSetBinarySpecForProviderLinkedServiceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProviderLinkedServiceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetBinarySpecForProviderLinkedServiceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetBinarySpecForProviderLinkedServiceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LinkedServiceSFTP in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProviderLinkedServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSetBinarySpecForProviderLinkedServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecForProviderLinkedServiceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSetBinarySpecForProviderLinkedServiceNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecForProviderLinkedServiceNameSelectorPolicyResolveEnum>))]
public enum V1beta2DataSetBinarySpecForProviderLinkedServiceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProviderLinkedServiceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetBinarySpecForProviderLinkedServiceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetBinarySpecForProviderLinkedServiceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LinkedServiceSFTP in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProviderLinkedServiceNameSelector
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
    public V1beta2DataSetBinarySpecForProviderLinkedServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A sftp_server_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProviderSftpServerLocation
{
    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the SFTP server.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the SFTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecForProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Binary Dataset.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Binary Dataset.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>A azure_blob_storage_location block as defined below.</summary>
    [JsonPropertyName("azureBlobStorageLocation")]
    public V1beta2DataSetBinarySpecForProviderAzureBlobStorageLocation? AzureBlobStorageLocation { get; set; }

    /// <summary>A compression block as defined below.</summary>
    [JsonPropertyName("compression")]
    public V1beta2DataSetBinarySpecForProviderCompression? Compression { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta2DataSetBinarySpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta2DataSetBinarySpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>The description for the Data Factory Dataset.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>A http_server_location block as defined below.</summary>
    [JsonPropertyName("httpServerLocation")]
    public V1beta2DataSetBinarySpecForProviderHttpServerLocation? HttpServerLocation { get; set; }

    /// <summary>The Data Factory Linked Service name in which to associate the Binary Dataset with.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Reference to a LinkedServiceSFTP in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameRef")]
    public V1beta2DataSetBinarySpecForProviderLinkedServiceNameRef? LinkedServiceNameRef { get; set; }

    /// <summary>Selector for a LinkedServiceSFTP in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameSelector")]
    public V1beta2DataSetBinarySpecForProviderLinkedServiceNameSelector? LinkedServiceNameSelector { get; set; }

    /// <summary>Specifies a list of parameters to associate with the Data Factory Binary Dataset.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A sftp_server_location block as defined below.</summary>
    [JsonPropertyName("sftpServerLocation")]
    public V1beta2DataSetBinarySpecForProviderSftpServerLocation? SftpServerLocation { get; set; }
}

/// <summary>A azure_blob_storage_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecInitProviderAzureBlobStorageLocation
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

    /// <summary>The filename of the file in the blob container.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file in the blob container.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A compression block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecInitProviderCompression
{
    /// <summary>The level of compression. Possible values are Fastest and Optimal.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The type of compression used during transport. Possible values are BZip2, Deflate, GZip, Tar, TarGZip and ZipDeflate.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A http_server_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecInitProviderHttpServerLocation
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecInitProviderLinkedServiceNameRefPolicyResolutionEnum>))]
public enum V1beta2DataSetBinarySpecInitProviderLinkedServiceNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecInitProviderLinkedServiceNameRefPolicyResolveEnum>))]
public enum V1beta2DataSetBinarySpecInitProviderLinkedServiceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecInitProviderLinkedServiceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetBinarySpecInitProviderLinkedServiceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetBinarySpecInitProviderLinkedServiceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LinkedServiceSFTP in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecInitProviderLinkedServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSetBinarySpecInitProviderLinkedServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecInitProviderLinkedServiceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DataSetBinarySpecInitProviderLinkedServiceNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecInitProviderLinkedServiceNameSelectorPolicyResolveEnum>))]
public enum V1beta2DataSetBinarySpecInitProviderLinkedServiceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecInitProviderLinkedServiceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetBinarySpecInitProviderLinkedServiceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetBinarySpecInitProviderLinkedServiceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LinkedServiceSFTP in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecInitProviderLinkedServiceNameSelector
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
    public V1beta2DataSetBinarySpecInitProviderLinkedServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A sftp_server_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecInitProviderSftpServerLocation
{
    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the SFTP server.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the SFTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
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
public partial class V1beta2DataSetBinarySpecInitProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Binary Dataset.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Binary Dataset.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>A azure_blob_storage_location block as defined below.</summary>
    [JsonPropertyName("azureBlobStorageLocation")]
    public V1beta2DataSetBinarySpecInitProviderAzureBlobStorageLocation? AzureBlobStorageLocation { get; set; }

    /// <summary>A compression block as defined below.</summary>
    [JsonPropertyName("compression")]
    public V1beta2DataSetBinarySpecInitProviderCompression? Compression { get; set; }

    /// <summary>The description for the Data Factory Dataset.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>A http_server_location block as defined below.</summary>
    [JsonPropertyName("httpServerLocation")]
    public V1beta2DataSetBinarySpecInitProviderHttpServerLocation? HttpServerLocation { get; set; }

    /// <summary>The Data Factory Linked Service name in which to associate the Binary Dataset with.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Reference to a LinkedServiceSFTP in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameRef")]
    public V1beta2DataSetBinarySpecInitProviderLinkedServiceNameRef? LinkedServiceNameRef { get; set; }

    /// <summary>Selector for a LinkedServiceSFTP in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameSelector")]
    public V1beta2DataSetBinarySpecInitProviderLinkedServiceNameSelector? LinkedServiceNameSelector { get; set; }

    /// <summary>Specifies a list of parameters to associate with the Data Factory Binary Dataset.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A sftp_server_location block as defined below.</summary>
    [JsonPropertyName("sftpServerLocation")]
    public V1beta2DataSetBinarySpecInitProviderSftpServerLocation? SftpServerLocation { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecManagementPoliciesEnum>))]
public enum V1beta2DataSetBinarySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DataSetBinarySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DataSetBinarySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DataSetBinarySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DataSetBinarySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DataSetBinarySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DataSetBinarySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DataSetBinarySpec defines the desired state of DataSetBinary</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinarySpec
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
    public V1beta2DataSetBinarySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DataSetBinarySpecForProvider ForProvider { get; set; }

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
    public V1beta2DataSetBinarySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DataSetBinarySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DataSetBinarySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DataSetBinarySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A azure_blob_storage_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinaryStatusAtProviderAzureBlobStorageLocation
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

    /// <summary>The filename of the file in the blob container.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file in the blob container.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A compression block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinaryStatusAtProviderCompression
{
    /// <summary>The level of compression. Possible values are Fastest and Optimal.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The type of compression used during transport. Possible values are BZip2, Deflate, GZip, Tar, TarGZip and ZipDeflate.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A http_server_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinaryStatusAtProviderHttpServerLocation
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

/// <summary>A sftp_server_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinaryStatusAtProviderSftpServerLocation
{
    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the SFTP server.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the SFTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinaryStatusAtProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Binary Dataset.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Binary Dataset.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>A azure_blob_storage_location block as defined below.</summary>
    [JsonPropertyName("azureBlobStorageLocation")]
    public V1beta2DataSetBinaryStatusAtProviderAzureBlobStorageLocation? AzureBlobStorageLocation { get; set; }

    /// <summary>A compression block as defined below.</summary>
    [JsonPropertyName("compression")]
    public V1beta2DataSetBinaryStatusAtProviderCompression? Compression { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
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
    public V1beta2DataSetBinaryStatusAtProviderHttpServerLocation? HttpServerLocation { get; set; }

    /// <summary>The ID of the Data Factory Dataset.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Data Factory Linked Service name in which to associate the Binary Dataset with.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies a list of parameters to associate with the Data Factory Binary Dataset.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A sftp_server_location block as defined below.</summary>
    [JsonPropertyName("sftpServerLocation")]
    public V1beta2DataSetBinaryStatusAtProviderSftpServerLocation? SftpServerLocation { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinaryStatusConditions
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

/// <summary>DataSetBinaryStatus defines the observed state of DataSetBinary.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DataSetBinaryStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DataSetBinaryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DataSetBinaryStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DataSetBinary is the Schema for the DataSetBinarys API. Manages a Data Factory Binary Dataset inside an Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DataSetBinary : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DataSetBinarySpec>, IStatus<V1beta2DataSetBinaryStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DataSetBinary";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "datasetbinaries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datafactory.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataSetBinary";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataSetBinarySpec defines the desired state of DataSetBinary</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DataSetBinarySpec Spec { get; set; }

    /// <summary>DataSetBinaryStatus defines the observed state of DataSetBinary.</summary>
    [JsonPropertyName("status")]
    public V1beta2DataSetBinaryStatus? Status { get; set; }
}