#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.com;
/// <summary>
/// Storage version of v1api20221001.AutoscaleSetting
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2022-10-01/autoscale_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20221001storageAutoscaleSettingList : IKubernetesObject<V1ListMeta>, IItems<V1api20221001storageAutoscaleSetting>
{
    public const string KubeApiVersion = "v1api20221001storage";
    public const string KubeKind = "AutoscaleSettingList";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "autoscalesettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20221001storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AutoscaleSettingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20221001storageAutoscaleSetting objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20221001storageAutoscaleSetting> Items { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.EmailNotification
/// Email notification of an autoscale event.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecNotificationsEmail
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("customEmails")]
    public IList<string>? CustomEmails { get; set; }

    [JsonPropertyName("sendToSubscriptionAdministrator")]
    public bool? SendToSubscriptionAdministrator { get; set; }

    [JsonPropertyName("sendToSubscriptionCoAdministrators")]
    public bool? SendToSubscriptionCoAdministrators { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecNotificationsWebhooksServiceUriFromSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.WebhookNotification
/// Webhook notification of an autoscale event.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecNotificationsWebhooks
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("serviceUriFromSecret")]
    public V1api20221001storageAutoscaleSettingSpecNotificationsWebhooksServiceUriFromSecret? ServiceUriFromSecret { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.AutoscaleNotification
/// Autoscale notification.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecNotifications
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.EmailNotification
    /// Email notification of an autoscale event.
    /// </summary>
    [JsonPropertyName("email")]
    public V1api20221001storageAutoscaleSettingSpecNotificationsEmail? Email { get; set; }

    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    [JsonPropertyName("webhooks")]
    public IList<V1api20221001storageAutoscaleSettingSpecNotificationsWebhooks>? Webhooks { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20221001.AutoscaleSettingOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20221001storageAutoscaleSettingSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20221001storageAutoscaleSettingSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.PredictiveAutoscalePolicy
/// The parameters for enabling predictive autoscale.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecPredictiveAutoscalePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scaleLookAheadTime")]
    public string? ScaleLookAheadTime { get; set; }

    [JsonPropertyName("scaleMode")]
    public string? ScaleMode { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.ScaleCapacity
/// The number of instances that can be used during this profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesCapacity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("maximum")]
    public string? Maximum { get; set; }

    [JsonPropertyName("minimum")]
    public string? Minimum { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.TimeWindow
/// A specific date-time for the profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesFixedDate
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

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.RecurrentSchedule
/// The scheduling constraints for when the profile begins.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRecurrenceSchedule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    [JsonPropertyName("hours")]
    public IList<int>? Hours { get; set; }

    [JsonPropertyName("minutes")]
    public IList<int>? Minutes { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.Recurrence
/// The repeating times at which this profile begins. This element is not used if the FixedDate element is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRecurrence
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.RecurrentSchedule
    /// The scheduling constraints for when the profile begins.
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1api20221001storageAutoscaleSettingSpecProfilesRecurrenceSchedule? Schedule { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.ScaleRuleMetricDimension
/// Specifies an auto scale rule metric dimension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRulesMetricTriggerDimensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("DimensionName")]
    public string? DimensionName { get; set; }

    [JsonPropertyName("Operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("Values")]
    public IList<string>? Values { get; set; }
}

/// <summary>MetricResourceUriReference: the resource identifier of the resource the rule monitors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRulesMetricTriggerMetricResourceUriReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.MetricTrigger
/// The trigger that results in a scaling action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRulesMetricTrigger
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dimensions")]
    public IList<V1api20221001storageAutoscaleSettingSpecProfilesRulesMetricTriggerDimensions>? Dimensions { get; set; }

    [JsonPropertyName("dividePerInstance")]
    public bool? DividePerInstance { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    [JsonPropertyName("metricResourceLocation")]
    public string? MetricResourceLocation { get; set; }

    /// <summary>MetricResourceUriReference: the resource identifier of the resource the rule monitors.</summary>
    [JsonPropertyName("metricResourceUriReference")]
    public required V1api20221001storageAutoscaleSettingSpecProfilesRulesMetricTriggerMetricResourceUriReference MetricResourceUriReference { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }

    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    [JsonPropertyName("timeWindow")]
    public string? TimeWindow { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.ScaleAction
/// The parameters for the scaling action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRulesScaleAction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cooldown")]
    public string? Cooldown { get; set; }

    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.ScaleRule
/// A rule that provide the triggers and parameters for the scaling action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.MetricTrigger
    /// The trigger that results in a scaling action.
    /// </summary>
    [JsonPropertyName("metricTrigger")]
    public V1api20221001storageAutoscaleSettingSpecProfilesRulesMetricTrigger? MetricTrigger { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.ScaleAction
    /// The parameters for the scaling action.
    /// </summary>
    [JsonPropertyName("scaleAction")]
    public V1api20221001storageAutoscaleSettingSpecProfilesRulesScaleAction? ScaleAction { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.AutoscaleProfile
/// Autoscale profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfiles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.ScaleCapacity
    /// The number of instances that can be used during this profile.
    /// </summary>
    [JsonPropertyName("capacity")]
    public V1api20221001storageAutoscaleSettingSpecProfilesCapacity? Capacity { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.TimeWindow
    /// A specific date-time for the profile.
    /// </summary>
    [JsonPropertyName("fixedDate")]
    public V1api20221001storageAutoscaleSettingSpecProfilesFixedDate? FixedDate { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.Recurrence
    /// The repeating times at which this profile begins. This element is not used if the FixedDate element is used.
    /// </summary>
    [JsonPropertyName("recurrence")]
    public V1api20221001storageAutoscaleSettingSpecProfilesRecurrence? Recurrence { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20221001storageAutoscaleSettingSpecProfilesRules>? Rules { get; set; }
}

/// <summary>TargetResourceUriReference: the resource identifier of the resource that the autoscale setting should be added to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecTargetResourceUriReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20221001.AutoscaleSetting_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpec
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

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("notifications")]
    public IList<V1api20221001storageAutoscaleSettingSpecNotifications>? Notifications { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.AutoscaleSettingOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20221001storageAutoscaleSettingSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20221001storageAutoscaleSettingSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.PredictiveAutoscalePolicy
    /// The parameters for enabling predictive autoscale.
    /// </summary>
    [JsonPropertyName("predictiveAutoscalePolicy")]
    public V1api20221001storageAutoscaleSettingSpecPredictiveAutoscalePolicy? PredictiveAutoscalePolicy { get; set; }

    [JsonPropertyName("profiles")]
    public IList<V1api20221001storageAutoscaleSettingSpecProfiles>? Profiles { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("targetResourceLocation")]
    public string? TargetResourceLocation { get; set; }

    /// <summary>TargetResourceUriReference: the resource identifier of the resource that the autoscale setting should be added to.</summary>
    [JsonPropertyName("targetResourceUriReference")]
    public V1api20221001storageAutoscaleSettingSpecTargetResourceUriReference? TargetResourceUriReference { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusConditions
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
/// Storage version of v1api20221001.EmailNotification_STATUS
/// Email notification of an autoscale event.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusNotificationsEmail
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("customEmails")]
    public IList<string>? CustomEmails { get; set; }

    [JsonPropertyName("sendToSubscriptionAdministrator")]
    public bool? SendToSubscriptionAdministrator { get; set; }

    [JsonPropertyName("sendToSubscriptionCoAdministrators")]
    public bool? SendToSubscriptionCoAdministrators { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.WebhookNotification_STATUS
/// Webhook notification of an autoscale event.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusNotificationsWebhooks
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.AutoscaleNotification_STATUS
/// Autoscale notification.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusNotifications
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.EmailNotification_STATUS
    /// Email notification of an autoscale event.
    /// </summary>
    [JsonPropertyName("email")]
    public V1api20221001storageAutoscaleSettingStatusNotificationsEmail? Email { get; set; }

    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    [JsonPropertyName("webhooks")]
    public IList<V1api20221001storageAutoscaleSettingStatusNotificationsWebhooks>? Webhooks { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.PredictiveAutoscalePolicy_STATUS
/// The parameters for enabling predictive autoscale.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusPredictiveAutoscalePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scaleLookAheadTime")]
    public string? ScaleLookAheadTime { get; set; }

    [JsonPropertyName("scaleMode")]
    public string? ScaleMode { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.ScaleCapacity_STATUS
/// The number of instances that can be used during this profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesCapacity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("maximum")]
    public string? Maximum { get; set; }

    [JsonPropertyName("minimum")]
    public string? Minimum { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.TimeWindow_STATUS
/// A specific date-time for the profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesFixedDate
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

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.RecurrentSchedule_STATUS
/// The scheduling constraints for when the profile begins.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesRecurrenceSchedule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    [JsonPropertyName("hours")]
    public IList<int>? Hours { get; set; }

    [JsonPropertyName("minutes")]
    public IList<int>? Minutes { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.Recurrence_STATUS
/// The repeating times at which this profile begins. This element is not used if the FixedDate element is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesRecurrence
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.RecurrentSchedule_STATUS
    /// The scheduling constraints for when the profile begins.
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1api20221001storageAutoscaleSettingStatusProfilesRecurrenceSchedule? Schedule { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.ScaleRuleMetricDimension_STATUS
/// Specifies an auto scale rule metric dimension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesRulesMetricTriggerDimensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("DimensionName")]
    public string? DimensionName { get; set; }

    [JsonPropertyName("Operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("Values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.MetricTrigger_STATUS
/// The trigger that results in a scaling action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesRulesMetricTrigger
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dimensions")]
    public IList<V1api20221001storageAutoscaleSettingStatusProfilesRulesMetricTriggerDimensions>? Dimensions { get; set; }

    [JsonPropertyName("dividePerInstance")]
    public bool? DividePerInstance { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    [JsonPropertyName("metricResourceLocation")]
    public string? MetricResourceLocation { get; set; }

    [JsonPropertyName("metricResourceUri")]
    public string? MetricResourceUri { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }

    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    [JsonPropertyName("timeWindow")]
    public string? TimeWindow { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.ScaleAction_STATUS
/// The parameters for the scaling action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesRulesScaleAction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cooldown")]
    public string? Cooldown { get; set; }

    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.ScaleRule_STATUS
/// A rule that provide the triggers and parameters for the scaling action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.MetricTrigger_STATUS
    /// The trigger that results in a scaling action.
    /// </summary>
    [JsonPropertyName("metricTrigger")]
    public V1api20221001storageAutoscaleSettingStatusProfilesRulesMetricTrigger? MetricTrigger { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.ScaleAction_STATUS
    /// The parameters for the scaling action.
    /// </summary>
    [JsonPropertyName("scaleAction")]
    public V1api20221001storageAutoscaleSettingStatusProfilesRulesScaleAction? ScaleAction { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.AutoscaleProfile_STATUS
/// Autoscale profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfiles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.ScaleCapacity_STATUS
    /// The number of instances that can be used during this profile.
    /// </summary>
    [JsonPropertyName("capacity")]
    public V1api20221001storageAutoscaleSettingStatusProfilesCapacity? Capacity { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.TimeWindow_STATUS
    /// A specific date-time for the profile.
    /// </summary>
    [JsonPropertyName("fixedDate")]
    public V1api20221001storageAutoscaleSettingStatusProfilesFixedDate? FixedDate { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.Recurrence_STATUS
    /// The repeating times at which this profile begins. This element is not used if the FixedDate element is used.
    /// </summary>
    [JsonPropertyName("recurrence")]
    public V1api20221001storageAutoscaleSettingStatusProfilesRecurrence? Recurrence { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20221001storageAutoscaleSettingStatusProfilesRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusSystemData
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

/// <summary>Storage version of v1api20221001.Autoscalesetting_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20221001storageAutoscaleSettingStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("notifications")]
    public IList<V1api20221001storageAutoscaleSettingStatusNotifications>? Notifications { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.PredictiveAutoscalePolicy_STATUS
    /// The parameters for enabling predictive autoscale.
    /// </summary>
    [JsonPropertyName("predictiveAutoscalePolicy")]
    public V1api20221001storageAutoscaleSettingStatusPredictiveAutoscalePolicy? PredictiveAutoscalePolicy { get; set; }

    [JsonPropertyName("profiles")]
    public IList<V1api20221001storageAutoscaleSettingStatusProfiles>? Profiles { get; set; }

    [JsonPropertyName("properties_name")]
    public string? PropertiesName { get; set; }

    /// <summary>
    /// Storage version of v1api20221001.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20221001storageAutoscaleSettingStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("targetResourceLocation")]
    public string? TargetResourceLocation { get; set; }

    [JsonPropertyName("targetResourceUri")]
    public string? TargetResourceUri { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20221001.AutoscaleSetting
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2022-10-01/autoscale_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20221001storageAutoscaleSetting : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20221001storageAutoscaleSettingSpec?>, IStatus<V1api20221001storageAutoscaleSettingStatus?>
{
    public const string KubeApiVersion = "v1api20221001storage";
    public const string KubeKind = "AutoscaleSetting";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "autoscalesettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20221001storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AutoscaleSetting";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20221001.AutoscaleSetting_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20221001storageAutoscaleSettingSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20221001.Autoscalesetting_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20221001storageAutoscaleSettingStatus? Status { get; set; }
}