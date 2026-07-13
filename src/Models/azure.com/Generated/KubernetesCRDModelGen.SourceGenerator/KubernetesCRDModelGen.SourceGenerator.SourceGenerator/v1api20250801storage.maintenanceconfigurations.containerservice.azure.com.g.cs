#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.com;
/// <summary>
/// Storage version of v1api20250801.MaintenanceConfiguration
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2025-08-01/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/maintenanceConfigurations/{configName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250801storageMaintenanceConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1api20250801storageMaintenanceConfiguration>
{
    public const string KubeApiVersion = "v1api20250801storage";
    public const string KubeKind = "MaintenanceConfigurationList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "maintenanceconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20250801storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MaintenanceConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20250801storageMaintenanceConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20250801storageMaintenanceConfiguration> Items { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.DateSpan
/// A date range. For example, between &apos;2022-12-23&apos; and &apos;2023-01-05&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindowNotAllowedDates
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.AbsoluteMonthlySchedule
/// For schedules like: &apos;recur every month on the 15th&apos; or &apos;recur every 3 months on the 20th&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindowScheduleAbsoluteMonthly
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dayOfMonth")]
    public int? DayOfMonth { get; set; }

    [JsonPropertyName("intervalMonths")]
    public int? IntervalMonths { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.DailySchedule
/// For schedules like: &apos;recur every day&apos; or &apos;recur every 3 days&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindowScheduleDaily
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("intervalDays")]
    public int? IntervalDays { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.RelativeMonthlySchedule
/// For schedules like: &apos;recur every month on the first Monday&apos; or &apos;recur every 3 months on last Friday&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindowScheduleRelativeMonthly
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    [JsonPropertyName("intervalMonths")]
    public int? IntervalMonths { get; set; }

    [JsonPropertyName("weekIndex")]
    public string? WeekIndex { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.WeeklySchedule
/// For schedules like: &apos;recur every Monday&apos; or &apos;recur every 3 weeks on Wednesday&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindowScheduleWeekly
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    [JsonPropertyName("intervalWeeks")]
    public int? IntervalWeeks { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.Schedule
/// One and only one of the schedule types should be specified. Choose either &apos;daily&apos;, &apos;weekly&apos;, &apos;absoluteMonthly&apos; or
/// &apos;relativeMonthly&apos; for your maintenance schedule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindowSchedule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.AbsoluteMonthlySchedule
    /// For schedules like: &apos;recur every month on the 15th&apos; or &apos;recur every 3 months on the 20th&apos;.
    /// </summary>
    [JsonPropertyName("absoluteMonthly")]
    public V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindowScheduleAbsoluteMonthly? AbsoluteMonthly { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.DailySchedule
    /// For schedules like: &apos;recur every day&apos; or &apos;recur every 3 days&apos;.
    /// </summary>
    [JsonPropertyName("daily")]
    public V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindowScheduleDaily? Daily { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.RelativeMonthlySchedule
    /// For schedules like: &apos;recur every month on the first Monday&apos; or &apos;recur every 3 months on last Friday&apos;.
    /// </summary>
    [JsonPropertyName("relativeMonthly")]
    public V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindowScheduleRelativeMonthly? RelativeMonthly { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.WeeklySchedule
    /// For schedules like: &apos;recur every Monday&apos; or &apos;recur every 3 weeks on Wednesday&apos;.
    /// </summary>
    [JsonPropertyName("weekly")]
    public V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindowScheduleWeekly? Weekly { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.MaintenanceWindow
/// Maintenance window used to configure scheduled auto-upgrade for a Managed Cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindow
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("durationHours")]
    public int? DurationHours { get; set; }

    [JsonPropertyName("notAllowedDates")]
    public IList<V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindowNotAllowedDates>? NotAllowedDates { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.Schedule
    /// One and only one of the schedule types should be specified. Choose either &apos;daily&apos;, &apos;weekly&apos;, &apos;absoluteMonthly&apos; or
    /// &apos;relativeMonthly&apos; for your maintenance schedule.
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindowSchedule? Schedule { get; set; }

    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("utcOffset")]
    public string? UtcOffset { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.TimeSpan
/// A time range. For example, between 2021-05-25T13:00:00Z and 2021-05-25T14:00:00Z.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecNotAllowedTime
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.MaintenanceConfigurationOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20250801storageMaintenanceConfigurationSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20250801storageMaintenanceConfigurationSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a containerservice.azure.com/ManagedCluster resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.TimeInWeek
/// Time in a week.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpecTimeInWeek
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("day")]
    public string? Day { get; set; }

    [JsonPropertyName("hourSlots")]
    public IList<int>? HourSlots { get; set; }
}

/// <summary>Storage version of v1api20250801.MaintenanceConfiguration_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.MaintenanceWindow
    /// Maintenance window used to configure scheduled auto-upgrade for a Managed Cluster.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1api20250801storageMaintenanceConfigurationSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    [JsonPropertyName("notAllowedTime")]
    public IList<V1api20250801storageMaintenanceConfigurationSpecNotAllowedTime>? NotAllowedTime { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.MaintenanceConfigurationOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20250801storageMaintenanceConfigurationSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a containerservice.azure.com/ManagedCluster resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20250801storageMaintenanceConfigurationSpecOwner Owner { get; set; }

    [JsonPropertyName("timeInWeek")]
    public IList<V1api20250801storageMaintenanceConfigurationSpecTimeInWeek>? TimeInWeek { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.DateSpan_STATUS
/// A date range. For example, between &apos;2022-12-23&apos; and &apos;2023-01-05&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindowNotAllowedDates
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.AbsoluteMonthlySchedule_STATUS
/// For schedules like: &apos;recur every month on the 15th&apos; or &apos;recur every 3 months on the 20th&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindowScheduleAbsoluteMonthly
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dayOfMonth")]
    public int? DayOfMonth { get; set; }

    [JsonPropertyName("intervalMonths")]
    public int? IntervalMonths { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.DailySchedule_STATUS
/// For schedules like: &apos;recur every day&apos; or &apos;recur every 3 days&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindowScheduleDaily
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("intervalDays")]
    public int? IntervalDays { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.RelativeMonthlySchedule_STATUS
/// For schedules like: &apos;recur every month on the first Monday&apos; or &apos;recur every 3 months on last Friday&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindowScheduleRelativeMonthly
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    [JsonPropertyName("intervalMonths")]
    public int? IntervalMonths { get; set; }

    [JsonPropertyName("weekIndex")]
    public string? WeekIndex { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.WeeklySchedule_STATUS
/// For schedules like: &apos;recur every Monday&apos; or &apos;recur every 3 weeks on Wednesday&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindowScheduleWeekly
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    [JsonPropertyName("intervalWeeks")]
    public int? IntervalWeeks { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.Schedule_STATUS
/// One and only one of the schedule types should be specified. Choose either &apos;daily&apos;, &apos;weekly&apos;, &apos;absoluteMonthly&apos; or
/// &apos;relativeMonthly&apos; for your maintenance schedule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindowSchedule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.AbsoluteMonthlySchedule_STATUS
    /// For schedules like: &apos;recur every month on the 15th&apos; or &apos;recur every 3 months on the 20th&apos;.
    /// </summary>
    [JsonPropertyName("absoluteMonthly")]
    public V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindowScheduleAbsoluteMonthly? AbsoluteMonthly { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.DailySchedule_STATUS
    /// For schedules like: &apos;recur every day&apos; or &apos;recur every 3 days&apos;.
    /// </summary>
    [JsonPropertyName("daily")]
    public V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindowScheduleDaily? Daily { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.RelativeMonthlySchedule_STATUS
    /// For schedules like: &apos;recur every month on the first Monday&apos; or &apos;recur every 3 months on last Friday&apos;.
    /// </summary>
    [JsonPropertyName("relativeMonthly")]
    public V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindowScheduleRelativeMonthly? RelativeMonthly { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.WeeklySchedule_STATUS
    /// For schedules like: &apos;recur every Monday&apos; or &apos;recur every 3 weeks on Wednesday&apos;.
    /// </summary>
    [JsonPropertyName("weekly")]
    public V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindowScheduleWeekly? Weekly { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.MaintenanceWindow_STATUS
/// Maintenance window used to configure scheduled auto-upgrade for a Managed Cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindow
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("durationHours")]
    public int? DurationHours { get; set; }

    [JsonPropertyName("notAllowedDates")]
    public IList<V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindowNotAllowedDates>? NotAllowedDates { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.Schedule_STATUS
    /// One and only one of the schedule types should be specified. Choose either &apos;daily&apos;, &apos;weekly&apos;, &apos;absoluteMonthly&apos; or
    /// &apos;relativeMonthly&apos; for your maintenance schedule.
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindowSchedule? Schedule { get; set; }

    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("utcOffset")]
    public string? UtcOffset { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.TimeSpan_STATUS
/// A time range. For example, between 2021-05-25T13:00:00Z and 2021-05-25T14:00:00Z.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationStatusNotAllowedTime
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.TimeInWeek_STATUS
/// Time in a week.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationStatusTimeInWeek
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("day")]
    public string? Day { get; set; }

    [JsonPropertyName("hourSlots")]
    public IList<int>? HourSlots { get; set; }
}

/// <summary>Storage version of v1api20250801.MaintenanceConfiguration_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801storageMaintenanceConfigurationStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20250801storageMaintenanceConfigurationStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.MaintenanceWindow_STATUS
    /// Maintenance window used to configure scheduled auto-upgrade for a Managed Cluster.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1api20250801storageMaintenanceConfigurationStatusMaintenanceWindow? MaintenanceWindow { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("notAllowedTime")]
    public IList<V1api20250801storageMaintenanceConfigurationStatusNotAllowedTime>? NotAllowedTime { get; set; }

    /// <summary>
    /// Storage version of v1api20250801.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20250801storageMaintenanceConfigurationStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("timeInWeek")]
    public IList<V1api20250801storageMaintenanceConfigurationStatusTimeInWeek>? TimeInWeek { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20250801.MaintenanceConfiguration
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2025-08-01/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/maintenanceConfigurations/{configName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250801storageMaintenanceConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20250801storageMaintenanceConfigurationSpec?>, IStatus<V1api20250801storageMaintenanceConfigurationStatus?>
{
    public const string KubeApiVersion = "v1api20250801storage";
    public const string KubeKind = "MaintenanceConfiguration";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "maintenanceconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20250801storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MaintenanceConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20250801.MaintenanceConfiguration_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20250801storageMaintenanceConfigurationSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20250801.MaintenanceConfiguration_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20250801storageMaintenanceConfigurationStatus? Status { get; set; }
}