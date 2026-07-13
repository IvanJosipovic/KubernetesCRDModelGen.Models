#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.costmanagement.azure.upbound.io;
/// <summary>SubscriptionCostManagementExport is the Schema for the SubscriptionCostManagementExports API. Manages an Azure Cost Management Export for a Subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SubscriptionCostManagementExportList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SubscriptionCostManagementExport>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SubscriptionCostManagementExportList";
    public const string KubeGroup = "costmanagement.azure.upbound.io";
    public const string KubePluralName = "subscriptioncostmanagementexports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "costmanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SubscriptionCostManagementExportList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SubscriptionCostManagementExport objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SubscriptionCostManagementExport> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecDeletionPolicyEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A export_data_options block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecForProviderExportDataOptions
{
    /// <summary>The time frame for pulling data for the query. If custom, then a specific time period must be provided. Possible values include: WeekToDate, MonthToDate, BillingMonthToDate, TheLast7Days, TheLastMonth, TheLastBillingMonth, Custom.</summary>
    [JsonPropertyName("timeFrame")]
    public string? TimeFrame { get; set; }

    /// <summary>The type of the query. Possible values are ActualCost, AmortizedCost and Usage.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate containerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate containerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelector
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
    public V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A export_data_storage_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocation
{
    /// <summary>The Resource Manager ID of the container where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerId")]
    public string? ContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate containerId.</summary>
    [JsonPropertyName("containerIdRef")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdRef? ContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate containerId.</summary>
    [JsonPropertyName("containerIdSelector")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocationContainerIdSelector? ContainerIdSelector { get; set; }

    /// <summary>The path of the directory where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rootFolderPath")]
    public string? RootFolderPath { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subscription in azure to populate subscriptionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subscription in azure to populate subscriptionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelector
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
    public V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecForProvider
{
    /// <summary>Is the cost management export active? Default is true.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>A export_data_options block as defined below.</summary>
    [JsonPropertyName("exportDataOptions")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderExportDataOptions? ExportDataOptions { get; set; }

    /// <summary>A export_data_storage_location block as defined below.</summary>
    [JsonPropertyName("exportDataStorageLocation")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderExportDataStorageLocation? ExportDataStorageLocation { get; set; }

    /// <summary>Format for export. Valid values are Csv only. Default is Csv.</summary>
    [JsonPropertyName("fileFormat")]
    public string? FileFormat { get; set; }

    /// <summary>Specifies the name of the Cost Management Export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The date the export will stop capturing information.</summary>
    [JsonPropertyName("recurrencePeriodEndDate")]
    public string? RecurrencePeriodEndDate { get; set; }

    /// <summary>The date the export will start capturing information.</summary>
    [JsonPropertyName("recurrencePeriodStartDate")]
    public string? RecurrencePeriodStartDate { get; set; }

    /// <summary>How often the requested information will be exported. Valid values include Annually, Daily, Monthly, Weekly.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>The id of the subscription on which to create an export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>Reference to a Subscription in azure to populate subscriptionId.</summary>
    [JsonPropertyName("subscriptionIdRef")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdRef? SubscriptionIdRef { get; set; }

    /// <summary>Selector for a Subscription in azure to populate subscriptionId.</summary>
    [JsonPropertyName("subscriptionIdSelector")]
    public V1beta2SubscriptionCostManagementExportSpecForProviderSubscriptionIdSelector? SubscriptionIdSelector { get; set; }
}

/// <summary>A export_data_options block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataOptions
{
    /// <summary>The time frame for pulling data for the query. If custom, then a specific time period must be provided. Possible values include: WeekToDate, MonthToDate, BillingMonthToDate, TheLast7Days, TheLastMonth, TheLastBillingMonth, Custom.</summary>
    [JsonPropertyName("timeFrame")]
    public string? TimeFrame { get; set; }

    /// <summary>The type of the query. Possible values are ActualCost, AmortizedCost and Usage.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate containerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate containerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelector
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
    public V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A export_data_storage_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocation
{
    /// <summary>The Resource Manager ID of the container where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerId")]
    public string? ContainerId { get; set; }

    /// <summary>Reference to a Container in storage to populate containerId.</summary>
    [JsonPropertyName("containerIdRef")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdRef? ContainerIdRef { get; set; }

    /// <summary>Selector for a Container in storage to populate containerId.</summary>
    [JsonPropertyName("containerIdSelector")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocationContainerIdSelector? ContainerIdSelector { get; set; }

    /// <summary>The path of the directory where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rootFolderPath")]
    public string? RootFolderPath { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subscription in azure to populate subscriptionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subscription in azure to populate subscriptionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelector
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
    public V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelectorPolicy? Policy { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecInitProvider
{
    /// <summary>Is the cost management export active? Default is true.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>A export_data_options block as defined below.</summary>
    [JsonPropertyName("exportDataOptions")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataOptions? ExportDataOptions { get; set; }

    /// <summary>A export_data_storage_location block as defined below.</summary>
    [JsonPropertyName("exportDataStorageLocation")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderExportDataStorageLocation? ExportDataStorageLocation { get; set; }

    /// <summary>Format for export. Valid values are Csv only. Default is Csv.</summary>
    [JsonPropertyName("fileFormat")]
    public string? FileFormat { get; set; }

    /// <summary>Specifies the name of the Cost Management Export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The date the export will stop capturing information.</summary>
    [JsonPropertyName("recurrencePeriodEndDate")]
    public string? RecurrencePeriodEndDate { get; set; }

    /// <summary>The date the export will start capturing information.</summary>
    [JsonPropertyName("recurrencePeriodStartDate")]
    public string? RecurrencePeriodStartDate { get; set; }

    /// <summary>How often the requested information will be exported. Valid values include Annually, Daily, Monthly, Weekly.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>The id of the subscription on which to create an export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>Reference to a Subscription in azure to populate subscriptionId.</summary>
    [JsonPropertyName("subscriptionIdRef")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdRef? SubscriptionIdRef { get; set; }

    /// <summary>Selector for a Subscription in azure to populate subscriptionId.</summary>
    [JsonPropertyName("subscriptionIdSelector")]
    public V1beta2SubscriptionCostManagementExportSpecInitProviderSubscriptionIdSelector? SubscriptionIdSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecManagementPoliciesEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionCostManagementExportSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionCostManagementExportSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionCostManagementExportSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionCostManagementExportSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionCostManagementExportSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SubscriptionCostManagementExportSpec defines the desired state of SubscriptionCostManagementExport</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportSpec
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
    public V1beta2SubscriptionCostManagementExportSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SubscriptionCostManagementExportSpecForProvider ForProvider { get; set; }

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
    public V1beta2SubscriptionCostManagementExportSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SubscriptionCostManagementExportSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SubscriptionCostManagementExportSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SubscriptionCostManagementExportSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A export_data_options block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportStatusAtProviderExportDataOptions
{
    /// <summary>The time frame for pulling data for the query. If custom, then a specific time period must be provided. Possible values include: WeekToDate, MonthToDate, BillingMonthToDate, TheLast7Days, TheLastMonth, TheLastBillingMonth, Custom.</summary>
    [JsonPropertyName("timeFrame")]
    public string? TimeFrame { get; set; }

    /// <summary>The type of the query. Possible values are ActualCost, AmortizedCost and Usage.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A export_data_storage_location block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportStatusAtProviderExportDataStorageLocation
{
    /// <summary>The Resource Manager ID of the container where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerId")]
    public string? ContainerId { get; set; }

    /// <summary>The path of the directory where exports will be uploaded. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rootFolderPath")]
    public string? RootFolderPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportStatusAtProvider
{
    /// <summary>Is the cost management export active? Default is true.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>A export_data_options block as defined below.</summary>
    [JsonPropertyName("exportDataOptions")]
    public V1beta2SubscriptionCostManagementExportStatusAtProviderExportDataOptions? ExportDataOptions { get; set; }

    /// <summary>A export_data_storage_location block as defined below.</summary>
    [JsonPropertyName("exportDataStorageLocation")]
    public V1beta2SubscriptionCostManagementExportStatusAtProviderExportDataStorageLocation? ExportDataStorageLocation { get; set; }

    /// <summary>Format for export. Valid values are Csv only. Default is Csv.</summary>
    [JsonPropertyName("fileFormat")]
    public string? FileFormat { get; set; }

    /// <summary>The ID of the Cost Management Export for this Subscription.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the name of the Cost Management Export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The date the export will stop capturing information.</summary>
    [JsonPropertyName("recurrencePeriodEndDate")]
    public string? RecurrencePeriodEndDate { get; set; }

    /// <summary>The date the export will start capturing information.</summary>
    [JsonPropertyName("recurrencePeriodStartDate")]
    public string? RecurrencePeriodStartDate { get; set; }

    /// <summary>How often the requested information will be exported. Valid values include Annually, Daily, Monthly, Weekly.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>The id of the subscription on which to create an export. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportStatusConditions
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

/// <summary>SubscriptionCostManagementExportStatus defines the observed state of SubscriptionCostManagementExport.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionCostManagementExportStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SubscriptionCostManagementExportStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SubscriptionCostManagementExportStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SubscriptionCostManagementExport is the Schema for the SubscriptionCostManagementExports API. Manages an Azure Cost Management Export for a Subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SubscriptionCostManagementExport : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SubscriptionCostManagementExportSpec>, IStatus<V1beta2SubscriptionCostManagementExportStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SubscriptionCostManagementExport";
    public const string KubeGroup = "costmanagement.azure.upbound.io";
    public const string KubePluralName = "subscriptioncostmanagementexports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "costmanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SubscriptionCostManagementExport";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubscriptionCostManagementExportSpec defines the desired state of SubscriptionCostManagementExport</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SubscriptionCostManagementExportSpec Spec { get; set; }

    /// <summary>SubscriptionCostManagementExportStatus defines the observed state of SubscriptionCostManagementExport.</summary>
    [JsonPropertyName("status")]
    public V1beta2SubscriptionCostManagementExportStatus? Status { get; set; }
}