#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.batch.cnrm.cloud.google.com;
/// <summary>CloudBatchResourceAllowance is the Schema for the CloudBatchResourceAllowance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudBatchResourceAllowanceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudBatchResourceAllowance>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudBatchResourceAllowanceList";
    public const string KubeGroup = "batch.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudbatchresourceallowances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "batch.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudBatchResourceAllowanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudBatchResourceAllowance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudBatchResourceAllowance> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceSpecNotifications
{
    /// <summary>Required. The Pub/Sub topic where notifications like the resource allowance state changes will be published.</summary>
    [JsonPropertyName("pubsubTopic")]
    public string? PubsubTopic { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Threshold of a UsageResourceAllowance limiting how many resources can be consumed for each type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceSpecUsageResourceAllowanceSpecLimit
{
    /// <summary>Optional. A CalendarPeriod represents the abstract concept of a time period that has a canonical start.</summary>
    [JsonPropertyName("calendarPeriod")]
    public string? CalendarPeriod { get; set; }

    /// <summary>Required. Limit value of a UsageResourceAllowance within its one duration.</summary>
    [JsonPropertyName("limit")]
    public double? Limit { get; set; }
}

/// <summary>Required. Spec of a usage ResourceAllowance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceSpecUsageResourceAllowanceSpec
{
    /// <summary>Required. Threshold of a UsageResourceAllowance limiting how many resources can be consumed for each type.</summary>
    [JsonPropertyName("limit")]
    public V1alpha1CloudBatchResourceAllowanceSpecUsageResourceAllowanceSpecLimit? Limit { get; set; }

    /// <summary>Required. Spec type is unique for each usage ResourceAllowance. Batch now only supports type as &quot;cpu-core-hours&quot; for CPU usage consumption tracking.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The detail of usage resource allowance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceSpecUsageResourceAllowance
{
    /// <summary>Required. Spec of a usage ResourceAllowance.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1CloudBatchResourceAllowanceSpecUsageResourceAllowanceSpec? Spec { get; set; }
}

/// <summary>CloudBatchResourceAllowanceSpec defines the desired state of CloudBatchResourceAllowance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceSpec
{
    /// <summary>Optional. Labels are attributes that can be set and used by both the user and by Batch.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. Notification configurations.</summary>
    [JsonPropertyName("notifications")]
    public IList<V1alpha1CloudBatchResourceAllowanceSpecNotifications>? Notifications { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CloudBatchResourceAllowanceSpecProjectRef ProjectRef { get; set; }

    /// <summary>The CloudBatchResourceAllowance name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The detail of usage resource allowance.</summary>
    [JsonPropertyName("usageResourceAllowance")]
    public V1alpha1CloudBatchResourceAllowanceSpecUsageResourceAllowance? UsageResourceAllowance { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceStatusConditions
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

/// <summary>Output only. The consumption interval.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowanceStatusLimitStatusConsumptionInterval
{
    /// <summary>Optional. Exclusive end of the interval.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Optional. Inclusive start of the interval.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>Output only. ResourceAllowance consumption status for usage resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowanceStatusLimitStatus
{
    /// <summary>Output only. Accumulated consumption during `consumption_interval`.</summary>
    [JsonPropertyName("consumed")]
    public double? Consumed { get; set; }

    /// <summary>Output only. The consumption interval.</summary>
    [JsonPropertyName("consumptionInterval")]
    public V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowanceStatusLimitStatusConsumptionInterval? ConsumptionInterval { get; set; }

    /// <summary>Output only. Limit value of a UsageResourceAllowance within its one duration.</summary>
    [JsonPropertyName("limit")]
    public double? Limit { get; set; }
}

/// <summary>Output only. The consumption interval.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowanceStatusReportLatestPeriodConsumptionsConsumptionInterval
{
    /// <summary>Optional. Exclusive end of the interval.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Optional. Inclusive start of the interval.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowanceStatusReportLatestPeriodConsumptions
{
    /// <summary>Output only. Accumulated consumption during `consumption_interval`.</summary>
    [JsonPropertyName("consumed")]
    public double? Consumed { get; set; }

    /// <summary>Output only. The consumption interval.</summary>
    [JsonPropertyName("consumptionInterval")]
    public V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowanceStatusReportLatestPeriodConsumptionsConsumptionInterval? ConsumptionInterval { get; set; }
}

/// <summary>Output only. The report of ResourceAllowance consumptions in a time period.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowanceStatusReport
{
    /// <summary>Output only. ResourceAllowance consumptions in the latest calendar period. Key is the calendar period in string format. Batch currently supports HOUR, DAY, MONTH and YEAR.</summary>
    [JsonPropertyName("latestPeriodConsumptions")]
    public IDictionary<string, V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowanceStatusReportLatestPeriodConsumptions>? LatestPeriodConsumptions { get; set; }
}

/// <summary>Output only. Status of a usage ResourceAllowance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowanceStatus
{
    /// <summary>Output only. ResourceAllowance consumption status for usage resources.</summary>
    [JsonPropertyName("limitStatus")]
    public V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowanceStatusLimitStatus? LimitStatus { get; set; }

    /// <summary>Output only. The report of ResourceAllowance consumptions in a time period.</summary>
    [JsonPropertyName("report")]
    public V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowanceStatusReport? Report { get; set; }

    /// <summary>Output only. ResourceAllowance state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>The detail of usage resource allowance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowance
{
    /// <summary>Output only. Status of a usage ResourceAllowance.</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowanceStatus? Status { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceStatusObservedState
{
    /// <summary>Output only. Time when the ResourceAllowance was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. A system generated unique ID (in UUID4 format) for the ResourceAllowance.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>The detail of usage resource allowance.</summary>
    [JsonPropertyName("usageResourceAllowance")]
    public V1alpha1CloudBatchResourceAllowanceStatusObservedStateUsageResourceAllowance? UsageResourceAllowance { get; set; }
}

/// <summary>CloudBatchResourceAllowanceStatus defines the config connector machine state of CloudBatchResourceAllowance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBatchResourceAllowanceStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudBatchResourceAllowanceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CloudBatchResourceAllowance resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudBatchResourceAllowanceStatusObservedState? ObservedState { get; set; }
}

/// <summary>CloudBatchResourceAllowance is the Schema for the CloudBatchResourceAllowance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudBatchResourceAllowance : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudBatchResourceAllowanceSpec>, IStatus<V1alpha1CloudBatchResourceAllowanceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudBatchResourceAllowance";
    public const string KubeGroup = "batch.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudbatchresourceallowances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "batch.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudBatchResourceAllowance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudBatchResourceAllowanceSpec defines the desired state of CloudBatchResourceAllowance</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CloudBatchResourceAllowanceSpec Spec { get; set; }

    /// <summary>CloudBatchResourceAllowanceStatus defines the config connector machine state of CloudBatchResourceAllowance</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudBatchResourceAllowanceStatus? Status { get; set; }
}