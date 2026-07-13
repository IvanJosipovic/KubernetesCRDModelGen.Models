#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ssm.services.k8s.aws;
/// <summary>ResourceDataSync is the Schema for the ResourceDataSyncs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResourceDataSyncList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ResourceDataSync>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResourceDataSyncList";
    public const string KubeGroup = "ssm.services.k8s.aws";
    public const string KubePluralName = "resourcedatasyncs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ssm.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceDataSyncList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ResourceDataSync objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ResourceDataSync> Items { get; set; }
}

/// <summary>
/// Synchronize Amazon Web Services Systems Manager Inventory data from multiple
/// Amazon Web Services accounts defined in Organizations to a centralized Amazon
/// S3 bucket. Data is synchronized to individual key prefixes in the central
/// bucket. Each key prefix represents a different Amazon Web Services account
/// ID.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourceDataSyncSpecS3DestinationDestinationDataSharing
{
    [JsonPropertyName("destinationDataSharingType")]
    public string? DestinationDataSharingType { get; set; }
}

/// <summary>
/// Amazon S3 configuration details for the sync. This parameter is required
/// if the SyncType value is SyncToDestination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourceDataSyncSpecS3Destination
{
    [JsonPropertyName("awsKMSKeyARN")]
    public string? AwsKMSKeyARN { get; set; }

    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>
    /// Synchronize Amazon Web Services Systems Manager Inventory data from multiple
    /// Amazon Web Services accounts defined in Organizations to a centralized Amazon
    /// S3 bucket. Data is synchronized to individual key prefixes in the central
    /// bucket. Each key prefix represents a different Amazon Web Services account
    /// ID.
    /// </summary>
    [JsonPropertyName("destinationDataSharing")]
    public V1alpha1ResourceDataSyncSpecS3DestinationDestinationDataSharing? DestinationDataSharing { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("syncFormat")]
    public string? SyncFormat { get; set; }
}

/// <summary>The Organizations organizational unit data source for the sync.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourceDataSyncSpecSyncSourceAwsOrganizationsSourceOrganizationalUnits
{
    [JsonPropertyName("organizationalUnitID")]
    public string? OrganizationalUnitID { get; set; }
}

/// <summary>
/// Information about the AwsOrganizationsSource resource data sync source. A
/// sync source of this type can synchronize data from Organizations or, if an
/// Amazon Web Services organization isn&apos;t present, from multiple Amazon Web
/// Services Regions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourceDataSyncSpecSyncSourceAwsOrganizationsSource
{
    [JsonPropertyName("organizationSourceType")]
    public string? OrganizationSourceType { get; set; }

    [JsonPropertyName("organizationalUnits")]
    public IList<V1alpha1ResourceDataSyncSpecSyncSourceAwsOrganizationsSourceOrganizationalUnits>? OrganizationalUnits { get; set; }
}

/// <summary>
/// Specify information about the data sources to synchronize. This parameter
/// is required if the SyncType value is SyncFromSource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourceDataSyncSpecSyncSource
{
    /// <summary>
    /// Information about the AwsOrganizationsSource resource data sync source. A
    /// sync source of this type can synchronize data from Organizations or, if an
    /// Amazon Web Services organization isn&apos;t present, from multiple Amazon Web
    /// Services Regions.
    /// </summary>
    [JsonPropertyName("awsOrganizationsSource")]
    public V1alpha1ResourceDataSyncSpecSyncSourceAwsOrganizationsSource? AwsOrganizationsSource { get; set; }

    [JsonPropertyName("enableAllOpsDataSources")]
    public bool? EnableAllOpsDataSources { get; set; }

    [JsonPropertyName("includeFutureRegions")]
    public bool? IncludeFutureRegions { get; set; }

    [JsonPropertyName("sourceRegions")]
    public IList<string>? SourceRegions { get; set; }

    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>ResourceDataSyncSpec defines the desired state of ResourceDataSync.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourceDataSyncSpec
{
    /// <summary>
    /// Amazon S3 configuration details for the sync. This parameter is required
    /// if the SyncType value is SyncToDestination.
    /// </summary>
    [JsonPropertyName("s3Destination")]
    public V1alpha1ResourceDataSyncSpecS3Destination? S3Destination { get; set; }

    /// <summary>A name for the configuration.</summary>
    [JsonPropertyName("syncName")]
    public required string SyncName { get; set; }

    /// <summary>
    /// Specify information about the data sources to synchronize. This parameter
    /// is required if the SyncType value is SyncFromSource.
    /// </summary>
    [JsonPropertyName("syncSource")]
    public V1alpha1ResourceDataSyncSpecSyncSource? SyncSource { get; set; }

    /// <summary>
    /// Specify SyncToDestination to create a resource data sync that synchronizes
    /// data to an S3 bucket for Inventory. If you specify SyncToDestination, you
    /// must provide a value for S3Destination. Specify SyncFromSource to synchronize
    /// data from a single account and multiple Regions, or multiple Amazon Web Services
    /// accounts and Amazon Web Services Regions, as listed in Organizations for
    /// Explorer. If you specify SyncFromSource, you must provide a value for SyncSource.
    /// The default value is SyncToDestination.
    /// </summary>
    [JsonPropertyName("syncType")]
    public string? SyncType { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourceDataSyncStatusAckResourceMetadata
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
public partial class V1alpha1ResourceDataSyncStatusConditions
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

/// <summary>ResourceDataSyncStatus defines the observed state of ResourceDataSync</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourceDataSyncStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ResourceDataSyncStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ResourceDataSyncStatusConditions>? Conditions { get; set; }
}

/// <summary>ResourceDataSync is the Schema for the ResourceDataSyncs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResourceDataSync : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ResourceDataSyncSpec?>, IStatus<V1alpha1ResourceDataSyncStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResourceDataSync";
    public const string KubeGroup = "ssm.services.k8s.aws";
    public const string KubePluralName = "resourcedatasyncs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ssm.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceDataSync";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourceDataSyncSpec defines the desired state of ResourceDataSync.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ResourceDataSyncSpec? Spec { get; set; }

    /// <summary>ResourceDataSyncStatus defines the observed state of ResourceDataSync</summary>
    [JsonPropertyName("status")]
    public V1alpha1ResourceDataSyncStatus? Status { get; set; }
}