#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.athena.services.k8s.aws;
/// <summary>DataCatalog is the Schema for the DataCatalogs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataCatalogList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataCatalog>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataCatalogList";
    public const string KubeGroup = "athena.services.k8s.aws";
    public const string KubePluralName = "datacatalogs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "athena.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataCatalogList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DataCatalog objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DataCatalog> Items { get; set; }
}

/// <summary>
/// A label that you assign to a resource. Athena resources include workgroups,
/// data catalogs, and capacity reservations. Each tag consists of a key and
/// an optional value, both of which you define. For example, you can use tags
/// to categorize Athena resources by purpose, owner, or environment. Use a consistent
/// set of tag keys to make it easier to search and filter the resources in your
/// account. For best practices, see Tagging Best Practices (https://docs.aws.amazon.com/whitepapers/latest/tagging-best-practices/tagging-best-practices.html).
/// Tag keys can be from 1 to 128 UTF-8 Unicode characters, and tag values can
/// be from 0 to 256 UTF-8 Unicode characters. Tags can use letters and numbers
/// representable in UTF-8, and the following characters: + - = . _ : / @. Tag
/// keys and values are case-sensitive. Tag keys must be unique per resource.
/// If you specify more than one tag, separate them by commas.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// DataCatalogSpec defines the desired state of DataCatalog.
/// 
/// Contains information about a data catalog in an Amazon Web Services account.
/// 
/// In the Athena console, data catalogs are listed as &quot;data sources&quot; on the
/// Data sources page under the Data source name column.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogSpec
{
    /// <summary>A description of the data catalog to be created.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The name of the data catalog to create. The catalog name must be unique for
    /// the Amazon Web Services account and can use a maximum of 127 alphanumeric,
    /// underscore, at sign, or hyphen characters. The remainder of the length constraint
    /// of 256 is reserved for use by Athena.
    /// 
    /// Regex Pattern: `^[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Specifies the Lambda function or functions to use for creating the data catalog.
    /// This is a mapping whose values depend on the catalog type.
    /// 
    ///   - For the HIVE data catalog type, use the following syntax. The metadata-function
    ///     parameter is required. The sdk-version parameter is optional and defaults
    ///     to the currently supported version. metadata-function=lambda_arn, sdk-version=version_number
    /// 
    ///   - For the LAMBDA data catalog type, use one of the following sets of required
    ///     parameters, but not both. If you have one Lambda function that processes
    ///     metadata and another for reading the actual data, use the following syntax.
    ///     Both parameters are required. metadata-function=lambda_arn, record-function=lambda_arn
    ///     If you have a composite Lambda function that processes both metadata and
    ///     data, use the following syntax to specify your Lambda function. function=lambda_arn
    /// 
    ///   - The GLUE type takes a catalog ID parameter and is required. The catalog_id
    ///     is the account ID of the Amazon Web Services account to which the Glue
    ///     Data Catalog belongs. catalog-id=catalog_id The GLUE data catalog type
    ///     also applies to the default AwsDataCatalog that already exists in your
    ///     account, of which you can have only one and cannot modify.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A list of comma separated tags to add to the data catalog that is created.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DataCatalogSpecTags>? Tags { get; set; }

    /// <summary>
    /// The type of data catalog to create: LAMBDA for a federated catalog, HIVE
    /// for an external hive metastore, or GLUE for an Glue Data Catalog.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogStatusConditions
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

/// <summary>DataCatalogStatus defines the observed state of DataCatalog</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DataCatalogStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataCatalogStatusConditions>? Conditions { get; set; }
}

/// <summary>DataCatalog is the Schema for the DataCatalogs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataCatalog : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataCatalogSpec?>, IStatus<V1alpha1DataCatalogStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataCatalog";
    public const string KubeGroup = "athena.services.k8s.aws";
    public const string KubePluralName = "datacatalogs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "athena.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataCatalog";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DataCatalogSpec defines the desired state of DataCatalog.
    /// 
    /// Contains information about a data catalog in an Amazon Web Services account.
    /// 
    /// In the Athena console, data catalogs are listed as &quot;data sources&quot; on the
    /// Data sources page under the Data source name column.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DataCatalogSpec? Spec { get; set; }

    /// <summary>DataCatalogStatus defines the observed state of DataCatalog</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataCatalogStatus? Status { get; set; }
}