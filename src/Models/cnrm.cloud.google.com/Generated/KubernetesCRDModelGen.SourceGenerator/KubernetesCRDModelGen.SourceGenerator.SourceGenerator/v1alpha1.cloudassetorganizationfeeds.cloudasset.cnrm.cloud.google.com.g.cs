#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudasset.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudAssetOrganizationFeedList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudAssetOrganizationFeed>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudAssetOrganizationFeedList";
    public const string KubeGroup = "cloudasset.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudassetorganizationfeeds";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudasset.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudAssetOrganizationFeedList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudAssetOrganizationFeed objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudAssetOrganizationFeed> Items { get; set; }
}

/// <summary>
/// A condition which determines whether an asset update should be published. If specified, an asset
/// will be returned only when the expression evaluates to true. When set, expression field
/// must be a valid CEL expression on a TemporalAsset with name temporal_asset. Example: a Feed with
/// expression &quot;temporal_asset.deleted == true&quot; will only publish Asset deletions. Other fields of
/// condition are optional.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudAssetOrganizationFeedSpecCondition
{
    /// <summary>
    /// Description of the expression. This is a longer text which describes the expression,
    /// e.g. when hovered over it in a UI.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file
    /// name and a position in the file.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>Destination on Cloud Pubsub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudAssetOrganizationFeedSpecFeedOutputConfigPubsubDestination
{
    /// <summary>Destination on Cloud Pubsub topic.</summary>
    [JsonPropertyName("topic")]
    public required string Topic { get; set; }
}

/// <summary>Output configuration for asset feed destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudAssetOrganizationFeedSpecFeedOutputConfig
{
    /// <summary>Destination on Cloud Pubsub.</summary>
    [JsonPropertyName("pubsubDestination")]
    public required V1alpha1CloudAssetOrganizationFeedSpecFeedOutputConfigPubsubDestination PubsubDestination { get; set; }
}

/// <summary>The organization that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudAssetOrganizationFeedSpecOrganizationRef
{
    /// <summary>Allowed value: The `name` field of an `Organization` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudAssetOrganizationFeedSpec
{
    /// <summary>
    /// A list of the full names of the assets to receive updates. You must specify either or both of
    /// assetNames and assetTypes. Only asset updates matching specified assetNames and assetTypes are
    /// exported to the feed. For example: //compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1.
    /// See https://cloud.google.com/apis/design/resourceNames#fullResourceName for more info.
    /// </summary>
    [JsonPropertyName("assetNames")]
    public IList<string>? AssetNames { get; set; }

    /// <summary>
    /// A list of types of the assets to receive updates. You must specify either or both of assetNames
    /// and assetTypes. Only asset updates matching specified assetNames and assetTypes are exported to
    /// the feed. For example: &quot;compute.googleapis.com/Disk&quot;
    /// See https://cloud.google.com/asset-inventory/docs/supported-asset-types for a list of all
    /// supported asset types.
    /// </summary>
    [JsonPropertyName("assetTypes")]
    public IList<string>? AssetTypes { get; set; }

    /// <summary>
    /// Immutable. The project whose identity will be used when sending messages to the
    /// destination pubsub topic. It also specifies the project for API
    /// enablement check, quota, and billing.
    /// </summary>
    [JsonPropertyName("billingProject")]
    public required string BillingProject { get; set; }

    /// <summary>
    /// A condition which determines whether an asset update should be published. If specified, an asset
    /// will be returned only when the expression evaluates to true. When set, expression field
    /// must be a valid CEL expression on a TemporalAsset with name temporal_asset. Example: a Feed with
    /// expression &quot;temporal_asset.deleted == true&quot; will only publish Asset deletions. Other fields of
    /// condition are optional.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1alpha1CloudAssetOrganizationFeedSpecCondition? Condition { get; set; }

    /// <summary>Asset content type. If not specified, no content but the asset name and type will be returned. Possible values: [&quot;CONTENT_TYPE_UNSPECIFIED&quot;, &quot;RESOURCE&quot;, &quot;IAM_POLICY&quot;, &quot;ORG_POLICY&quot;, &quot;OS_INVENTORY&quot;, &quot;ACCESS_POLICY&quot;].</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Immutable. This is the client-assigned asset feed identifier and it needs to be unique under a specific parent.</summary>
    [JsonPropertyName("feedId")]
    public required string FeedId { get; set; }

    /// <summary>Output configuration for asset feed destination.</summary>
    [JsonPropertyName("feedOutputConfig")]
    public required V1alpha1CloudAssetOrganizationFeedSpecFeedOutputConfig FeedOutputConfig { get; set; }

    /// <summary>The organization that this resource belongs to.</summary>
    [JsonPropertyName("organizationRef")]
    public required V1alpha1CloudAssetOrganizationFeedSpecOrganizationRef OrganizationRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudAssetOrganizationFeedStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudAssetOrganizationFeedStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudAssetOrganizationFeedStatusConditions>? Conditions { get; set; }

    /// <summary>The format will be organizations/{organization_number}/feeds/{client-assigned_feed_identifier}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudAssetOrganizationFeed : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudAssetOrganizationFeedSpec>, IStatus<V1alpha1CloudAssetOrganizationFeedStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudAssetOrganizationFeed";
    public const string KubeGroup = "cloudasset.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudassetorganizationfeeds";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudasset.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudAssetOrganizationFeed";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1CloudAssetOrganizationFeedSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1CloudAssetOrganizationFeedStatus? Status { get; set; }
}