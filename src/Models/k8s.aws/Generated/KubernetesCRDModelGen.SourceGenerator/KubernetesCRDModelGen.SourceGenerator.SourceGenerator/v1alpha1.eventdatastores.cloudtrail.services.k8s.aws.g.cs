#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudtrail.services.k8s.aws;
/// <summary>EventDataStore is the Schema for the EventDataStores API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EventDataStoreList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1EventDataStore>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EventDataStoreList";
    public const string KubeGroup = "cloudtrail.services.k8s.aws";
    public const string KubePluralName = "eventdatastores";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudtrail.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventDataStoreList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1EventDataStore objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1EventDataStore> Items { get; set; }
}

/// <summary>A single selector statement in an advanced event selector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventDataStoreSpecAdvancedEventSelectorsFieldSelectors
{
    [JsonPropertyName("endsWith")]
    public IList<string>? EndsWith { get; set; }

    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    [JsonPropertyName("field")]
    public string? Field { get; set; }

    [JsonPropertyName("notEndsWith")]
    public IList<string>? NotEndsWith { get; set; }

    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }

    [JsonPropertyName("notStartsWith")]
    public IList<string>? NotStartsWith { get; set; }

    [JsonPropertyName("startsWith")]
    public IList<string>? StartsWith { get; set; }
}

/// <summary>
/// Advanced event selectors let you create fine-grained selectors for CloudTrail
/// management, data, and network activity events. They help you control costs
/// by logging only those events that are important to you. For more information
/// about configuring advanced event selectors, see the Logging data events (https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html),
/// Logging network activity events (https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-network-events-with-cloudtrail.html),
/// and Logging management events (https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html)
/// topics in the CloudTrail User Guide.
/// 
/// You cannot apply both event selectors and advanced event selectors to a trail.
/// 
/// Supported CloudTrail event record fields for management events
/// 
///   - eventCategory (required)
/// 
///   - eventSource
/// 
///   - readOnly
/// 
/// The following additional fields are available for event data stores:
/// 
///   - eventName
/// 
///   - eventType
/// 
///   - sessionCredentialFromConsole
/// 
///   - userIdentity.arn
/// 
/// Supported CloudTrail event record fields for data events
/// 
///   - eventCategory (required)
/// 
///   - resources.type (required)
/// 
///   - readOnly
/// 
///   - eventName
/// 
///   - resources.ARN
/// 
/// The following additional fields are available for event data stores:
/// 
///   - eventSource
/// 
///   - eventType
/// 
///   - sessionCredentialFromConsole
/// 
///   - userIdentity.arn
/// 
/// # Supported CloudTrail event record fields for network activity events
/// 
/// Network activity events is in preview release for CloudTrail and is subject
/// to change.
/// 
///   - eventCategory (required)
/// 
///   - eventSource (required)
/// 
///   - eventName
/// 
///   - errorCode - The only valid value for errorCode is VpceAccessDenied.
/// 
///   - vpcEndpointId
/// 
/// For event data stores for CloudTrail Insights events, Config configuration
/// items, Audit Manager evidence, or events outside of Amazon Web Services,
/// the only supported field is eventCategory.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventDataStoreSpecAdvancedEventSelectors
{
    [JsonPropertyName("fieldSelectors")]
    public IList<V1alpha1EventDataStoreSpecAdvancedEventSelectorsFieldSelectors>? FieldSelectors { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A custom key-value pair associated with a resource such as a CloudTrail trail,
/// event data store, dashboard, or channel.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventDataStoreSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// EventDataStoreSpec defines the desired state of EventDataStore.
/// 
/// A storage lake of event data against which you can run complex SQL-based
/// queries. An event data store can include events that you have logged on your
/// account. To select events for an event data store, use advanced event selectors
/// (https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-concepts.html#adv-event-selectors).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventDataStoreSpec
{
    /// <summary>
    /// The advanced event selectors to use to select the events for the data store.
    /// You can configure up to five advanced event selectors for each event data
    /// store.
    /// 
    /// For more information about how to use advanced event selectors to log CloudTrail
    /// events, see Log events by using advanced event selectors (https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html#creating-data-event-selectors-advanced)
    /// in the CloudTrail User Guide.
    /// 
    /// For more information about how to use advanced event selectors to include
    /// Config configuration items in your event data store, see Create an event
    /// data store for Config configuration items (https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-eds-cli.html#lake-cli-create-eds-config)
    /// in the CloudTrail User Guide.
    /// 
    /// For more information about how to use advanced event selectors to include
    /// events outside of Amazon Web Services events in your event data store, see
    /// Create an integration to log events from outside Amazon Web Services (https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-integrations-cli.html#lake-cli-create-integration)
    /// in the CloudTrail User Guide.
    /// </summary>
    [JsonPropertyName("advancedEventSelectors")]
    public IList<V1alpha1EventDataStoreSpecAdvancedEventSelectors>? AdvancedEventSelectors { get; set; }

    /// <summary>
    /// Specifies whether the event data store includes events from all Regions,
    /// or only from the Region in which the event data store is created.
    /// </summary>
    [JsonPropertyName("multiRegionEnabled")]
    public bool? MultiRegionEnabled { get; set; }

    /// <summary>
    /// The name of the event data store.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9._\-]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Specifies whether an event data store collects events logged for an organization
    /// in Organizations.
    /// </summary>
    [JsonPropertyName("organizationEnabled")]
    public bool? OrganizationEnabled { get; set; }

    /// <summary>
    /// The retention period of the event data store, in days. If BillingMode is
    /// set to EXTENDABLE_RETENTION_PRICING, you can set a retention period of up
    /// to 3653 days, the equivalent of 10 years. If BillingMode is set to FIXED_RETENTION_PRICING,
    /// you can set a retention period of up to 2557 days, the equivalent of seven
    /// years.
    /// 
    /// CloudTrail Lake determines whether to retain an event by checking if the
    /// eventTime of the event is within the specified retention period. For example,
    /// if you set a retention period of 90 days, CloudTrail will remove events when
    /// the eventTime is older than 90 days.
    /// 
    /// If you plan to copy trail events to this event data store, we recommend that
    /// you consider both the age of the events that you want to copy as well as
    /// how long you want to keep the copied events in your event data store. For
    /// example, if you copy trail events that are 5 years old and specify a retention
    /// period of 7 years, the event data store will retain those events for two
    /// years.
    /// </summary>
    [JsonPropertyName("retentionPeriod")]
    public long? RetentionPeriod { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1EventDataStoreSpecTags>? Tags { get; set; }

    /// <summary>
    /// Specifies whether termination protection is enabled for the event data store.
    /// If termination protection is enabled, you cannot delete the event data store
    /// until termination protection is disabled.
    /// </summary>
    [JsonPropertyName("terminationProtectionEnabled")]
    public bool? TerminationProtectionEnabled { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventDataStoreStatusAckResourceMetadata
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
public partial class V1alpha1EventDataStoreStatusConditions
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

/// <summary>EventDataStoreStatus defines the observed state of EventDataStore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EventDataStoreStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1EventDataStoreStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EventDataStoreStatusConditions>? Conditions { get; set; }

    /// <summary>The timestamp that shows when the event data store was created.</summary>
    [JsonPropertyName("createdTimestamp")]
    public DateTime? CreatedTimestamp { get; set; }

    /// <summary>The status of event data store creation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The timestamp that shows when an event data store was updated, if applicable.
    /// UpdatedTimestamp is always either the same or newer than the time shown in
    /// CreatedTimestamp.
    /// </summary>
    [JsonPropertyName("updatedTimestamp")]
    public DateTime? UpdatedTimestamp { get; set; }
}

/// <summary>EventDataStore is the Schema for the EventDataStores API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EventDataStore : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EventDataStoreSpec?>, IStatus<V1alpha1EventDataStoreStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EventDataStore";
    public const string KubeGroup = "cloudtrail.services.k8s.aws";
    public const string KubePluralName = "eventdatastores";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudtrail.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventDataStore";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// EventDataStoreSpec defines the desired state of EventDataStore.
    /// 
    /// A storage lake of event data against which you can run complex SQL-based
    /// queries. An event data store can include events that you have logged on your
    /// account. To select events for an event data store, use advanced event selectors
    /// (https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-concepts.html#adv-event-selectors).
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1EventDataStoreSpec? Spec { get; set; }

    /// <summary>EventDataStoreStatus defines the observed state of EventDataStore</summary>
    [JsonPropertyName("status")]
    public V1alpha1EventDataStoreStatus? Status { get; set; }
}