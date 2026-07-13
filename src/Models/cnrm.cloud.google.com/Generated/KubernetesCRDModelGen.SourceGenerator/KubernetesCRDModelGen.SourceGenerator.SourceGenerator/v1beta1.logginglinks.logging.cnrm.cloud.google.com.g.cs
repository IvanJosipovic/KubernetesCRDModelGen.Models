#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logging.cnrm.cloud.google.com;
/// <summary>LoggingLink is the Schema for the LoggingLink API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoggingLinkList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LoggingLink>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoggingLinkList";
    public const string KubeGroup = "logging.cnrm.cloud.google.com";
    public const string KubePluralName = "logginglinks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "logging.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoggingLinkList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1LoggingLink objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1LoggingLink> Items { get; set; }
}

/// <summary>Required. The LoggingLogBucket that this Link is associated with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLinkSpecLoggingLogBucketRef
{
    /// <summary>A reference to an externally managed LoggingLogBucket resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/buckets/{{bucketID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a LoggingLogBucket resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a LoggingLogBucket resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>LoggingLinkSpec defines the desired state of LoggingLink</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLinkSpec
{
    /// <summary>
    /// Describes this link.
    /// 
    ///  The maximum length of the description is 8000 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The LoggingLogBucket that this Link is associated with.</summary>
    [JsonPropertyName("loggingLogBucketRef")]
    public V1beta1LoggingLinkSpecLoggingLogBucketRef? LoggingLogBucketRef { get; set; }

    /// <summary>Immutable. The LoggingLink name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLinkStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The information of a BigQuery Dataset. When a link is created, a BigQuery dataset is created along with it, in the same project as the LogBucket it&apos;s linked to. This dataset will also have BigQuery Views corresponding to the LogViews in the bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLinkStatusObservedStateBigQueryDataset
{
    /// <summary>
    /// Output only. The full resource name of the BigQuery dataset. The DATASET_ID
    ///  will match the ID of the link, so the link must match the naming
    ///  restrictions of BigQuery datasets (alphanumeric characters and underscores
    ///  only).
    /// 
    ///  The dataset will have a resource path of
    ///    &quot;bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET_ID]&quot;
    /// </summary>
    [JsonPropertyName("datasetID")]
    public string? DatasetID { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLinkStatusObservedState
{
    /// <summary>The information of a BigQuery Dataset. When a link is created, a BigQuery dataset is created along with it, in the same project as the LogBucket it&apos;s linked to. This dataset will also have BigQuery Views corresponding to the LogViews in the bucket.</summary>
    [JsonPropertyName("bigQueryDataset")]
    public V1beta1LoggingLinkStatusObservedStateBigQueryDataset? BigQueryDataset { get; set; }

    /// <summary>Output only. The creation timestamp of the link.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The resource lifecycle state.</summary>
    [JsonPropertyName("lifecycleState")]
    public string? LifecycleState { get; set; }
}

/// <summary>LoggingLinkStatus defines the config connector machine state of LoggingLink</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLinkStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LoggingLinkStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the LoggingLink resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1LoggingLinkStatusObservedState? ObservedState { get; set; }
}

/// <summary>LoggingLink is the Schema for the LoggingLink API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoggingLink : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LoggingLinkSpec>, IStatus<V1beta1LoggingLinkStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoggingLink";
    public const string KubeGroup = "logging.cnrm.cloud.google.com";
    public const string KubePluralName = "logginglinks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "logging.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoggingLink";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LoggingLinkSpec defines the desired state of LoggingLink</summary>
    [JsonPropertyName("spec")]
    public required V1beta1LoggingLinkSpec Spec { get; set; }

    /// <summary>LoggingLinkStatus defines the config connector machine state of LoggingLink</summary>
    [JsonPropertyName("status")]
    public V1beta1LoggingLinkStatus? Status { get; set; }
}