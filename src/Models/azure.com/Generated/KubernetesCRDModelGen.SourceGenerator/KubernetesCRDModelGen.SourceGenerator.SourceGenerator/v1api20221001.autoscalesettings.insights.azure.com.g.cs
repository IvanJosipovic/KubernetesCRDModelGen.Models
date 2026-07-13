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
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2022-10-01/autoscale_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20221001AutoscaleSettingList : IKubernetesObject<V1ListMeta>, IItems<V1api20221001AutoscaleSetting>
{
    public const string KubeApiVersion = "v1api20221001";
    public const string KubeKind = "AutoscaleSettingList";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "autoscalesettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20221001";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AutoscaleSettingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20221001AutoscaleSetting objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20221001AutoscaleSetting> Items { get; set; }
}

/// <summary>Email: the email notification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecNotificationsEmail
{
    /// <summary>CustomEmails: the custom e-mails list. This value can be null or empty, in which case this attribute will be ignored.</summary>
    [JsonPropertyName("customEmails")]
    public IList<string>? CustomEmails { get; set; }

    /// <summary>SendToSubscriptionAdministrator: a value indicating whether to send email to subscription administrator.</summary>
    [JsonPropertyName("sendToSubscriptionAdministrator")]
    public bool? SendToSubscriptionAdministrator { get; set; }

    /// <summary>SendToSubscriptionCoAdministrators: a value indicating whether to send email to subscription co-administrators.</summary>
    [JsonPropertyName("sendToSubscriptionCoAdministrators")]
    public bool? SendToSubscriptionCoAdministrators { get; set; }
}

/// <summary>Operation: the operation associated with the notification and its value must be &quot;scale&quot;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingSpecNotificationsOperationEnum>))]
public enum V1api20221001AutoscaleSettingSpecNotificationsOperationEnum
{
    [EnumMember(Value = "Scale"), JsonStringEnumMemberName("Scale")]
    Scale
}

/// <summary>ServiceUriFromSecret: the service address to receive the notification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecNotificationsWebhooksServiceUriFromSecret
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

/// <summary>Webhook notification of an autoscale event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecNotificationsWebhooks
{
    /// <summary>Properties: a property bag of settings. This value can be empty.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>ServiceUri: the service address to receive the notification.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>ServiceUriFromSecret: the service address to receive the notification.</summary>
    [JsonPropertyName("serviceUriFromSecret")]
    public V1api20221001AutoscaleSettingSpecNotificationsWebhooksServiceUriFromSecret? ServiceUriFromSecret { get; set; }
}

/// <summary>Autoscale notification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecNotifications
{
    /// <summary>Email: the email notification.</summary>
    [JsonPropertyName("email")]
    public V1api20221001AutoscaleSettingSpecNotificationsEmail? Email { get; set; }

    /// <summary>Operation: the operation associated with the notification and its value must be &quot;scale&quot;</summary>
    [JsonPropertyName("operation")]
    public required V1api20221001AutoscaleSettingSpecNotificationsOperationEnum Operation { get; set; }

    /// <summary>Webhooks: the collection of webhook notifications.</summary>
    [JsonPropertyName("webhooks")]
    public IList<V1api20221001AutoscaleSettingSpecNotificationsWebhooks>? Webhooks { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20221001AutoscaleSettingSpecOperatorSpecSecretExpressions
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
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20221001AutoscaleSettingSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20221001AutoscaleSettingSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ScaleMode: the predictive autoscale mode</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingSpecPredictiveAutoscalePolicyScaleModeEnum>))]
public enum V1api20221001AutoscaleSettingSpecPredictiveAutoscalePolicyScaleModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "ForecastOnly"), JsonStringEnumMemberName("ForecastOnly")]
    ForecastOnly
}

/// <summary>PredictiveAutoscalePolicy: the predictive autoscale policy mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecPredictiveAutoscalePolicy
{
    /// <summary>
    /// ScaleLookAheadTime: the amount of time to specify by which instances are launched in advance. It must be between 1
    /// minute and 60 minutes in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("scaleLookAheadTime")]
    public string? ScaleLookAheadTime { get; set; }

    /// <summary>ScaleMode: the predictive autoscale mode</summary>
    [JsonPropertyName("scaleMode")]
    public required V1api20221001AutoscaleSettingSpecPredictiveAutoscalePolicyScaleModeEnum ScaleMode { get; set; }
}

/// <summary>Capacity: the number of instances that can be used during this profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecProfilesCapacity
{
    /// <summary>
    /// Default: the number of instances that will be set if metrics are not available for evaluation. The default is only used
    /// if the current instance count is lower than the default.
    /// </summary>
    [JsonPropertyName("default")]
    public required string Default { get; set; }

    /// <summary>
    /// Maximum: the maximum number of instances for the resource. The actual maximum number of instances is limited by the
    /// cores that are available in the subscription.
    /// </summary>
    [JsonPropertyName("maximum")]
    public required string Maximum { get; set; }

    /// <summary>Minimum: the minimum number of instances for the resource.</summary>
    [JsonPropertyName("minimum")]
    public required string Minimum { get; set; }
}

/// <summary>FixedDate: the specific date-time for the profile. This element is not used if the Recurrence element is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecProfilesFixedDate
{
    /// <summary>End: the end time for the profile in ISO 8601 format.</summary>
    [JsonPropertyName("end")]
    public required string End { get; set; }

    /// <summary>Start: the start time for the profile in ISO 8601 format.</summary>
    [JsonPropertyName("start")]
    public required string Start { get; set; }

    /// <summary>
    /// TimeZone: the timezone of the start and end times for the profile. Some examples of valid time zones are: Dateline
    /// Standard Time, UTC-11, Hawaiian Standard Time, Alaskan Standard Time, Pacific Standard Time (Mexico), Pacific Standard
    /// Time, US Mountain Standard Time, Mountain Standard Time (Mexico), Mountain Standard Time, Central America Standard Time,
    /// Central Standard Time, Central Standard Time (Mexico), Canada Central Standard Time, SA Pacific Standard Time, Eastern
    /// Standard Time, US Eastern Standard Time, Venezuela Standard Time, Paraguay Standard Time, Atlantic Standard Time,
    /// Central Brazilian Standard Time, SA Western Standard Time, Pacific SA Standard Time, Newfoundland Standard Time, E.
    /// South America Standard Time, Argentina Standard Time, SA Eastern Standard Time, Greenland Standard Time, Montevideo
    /// Standard Time, Bahia Standard Time, UTC-02, Mid-Atlantic Standard Time, Azores Standard Time, Cape Verde Standard Time,
    /// Morocco Standard Time, UTC, GMT Standard Time, Greenwich Standard Time, W. Europe Standard Time, Central Europe Standard
    /// Time, Romance Standard Time, Central European Standard Time, W. Central Africa Standard Time, Namibia Standard Time,
    /// Jordan Standard Time, GTB Standard Time, Middle East Standard Time, Egypt Standard Time, Syria Standard Time, E. Europe
    /// Standard Time, South Africa Standard Time, FLE Standard Time, Turkey Standard Time, Israel Standard Time, Kaliningrad
    /// Standard Time, Libya Standard Time, Arabic Standard Time, Arab Standard Time, Belarus Standard Time, Russian Standard
    /// Time, E. Africa Standard Time, Iran Standard Time, Arabian Standard Time, Azerbaijan Standard Time, Russia Time Zone 3,
    /// Mauritius Standard Time, Georgian Standard Time, Caucasus Standard Time, Afghanistan Standard Time, West Asia Standard
    /// Time, Ekaterinburg Standard Time, Pakistan Standard Time, India Standard Time, Sri Lanka Standard Time, Nepal Standard
    /// Time, Central Asia Standard Time, Bangladesh Standard Time, N. Central Asia Standard Time, Myanmar Standard Time, SE
    /// Asia Standard Time, North Asia Standard Time, China Standard Time, North Asia East Standard Time, Singapore Standard
    /// Time, W. Australia Standard Time, Taipei Standard Time, Ulaanbaatar Standard Time, Tokyo Standard Time, Korea Standard
    /// Time, Yakutsk Standard Time, Cen. Australia Standard Time, AUS Central Standard Time, E. Australia Standard Time, AUS
    /// Eastern Standard Time, West Pacific Standard Time, Tasmania Standard Time, Magadan Standard Time, Vladivostok Standard
    /// Time, Russia Time Zone 10, Central Pacific Standard Time, Russia Time Zone 11, New Zealand Standard Time, UTC+12, Fiji
    /// Standard Time, Kamchatka Standard Time, Tonga Standard Time, Samoa Standard Time, Line Islands Standard Time
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// Frequency: the recurrence frequency. How often the schedule profile should take effect. This value must be Week, meaning
/// each week will have the same set of profiles. For example, to set a daily schedule, set schedule to every day of the
/// week. The frequency property specifies that the schedule is repeated weekly.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingSpecProfilesRecurrenceFrequencyEnum>))]
public enum V1api20221001AutoscaleSettingSpecProfilesRecurrenceFrequencyEnum
{
    [EnumMember(Value = "Day"), JsonStringEnumMemberName("Day")]
    Day,
    [EnumMember(Value = "Hour"), JsonStringEnumMemberName("Hour")]
    Hour,
    [EnumMember(Value = "Minute"), JsonStringEnumMemberName("Minute")]
    Minute,
    [EnumMember(Value = "Month"), JsonStringEnumMemberName("Month")]
    Month,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Second"), JsonStringEnumMemberName("Second")]
    Second,
    [EnumMember(Value = "Week"), JsonStringEnumMemberName("Week")]
    Week,
    [EnumMember(Value = "Year"), JsonStringEnumMemberName("Year")]
    Year
}

/// <summary>Schedule: the scheduling constraints for when the profile begins.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecProfilesRecurrenceSchedule
{
    /// <summary>Days: the collection of days that the profile takes effect on. Possible values are Sunday through Saturday.</summary>
    [JsonPropertyName("days")]
    public required IList<string> Days { get; set; }

    /// <summary>
    /// Hours: A collection of hours that the profile takes effect on. Values supported are 0 to 23 on the 24-hour clock (AM/PM
    /// times are not supported).
    /// </summary>
    [JsonPropertyName("hours")]
    public required IList<int> Hours { get; set; }

    /// <summary>Minutes: A collection of minutes at which the profile takes effect at.</summary>
    [JsonPropertyName("minutes")]
    public required IList<int> Minutes { get; set; }

    /// <summary>
    /// TimeZone: the timezone for the hours of the profile. Some examples of valid time zones are: Dateline Standard Time,
    /// UTC-11, Hawaiian Standard Time, Alaskan Standard Time, Pacific Standard Time (Mexico), Pacific Standard Time, US
    /// Mountain Standard Time, Mountain Standard Time (Mexico), Mountain Standard Time, Central America Standard Time, Central
    /// Standard Time, Central Standard Time (Mexico), Canada Central Standard Time, SA Pacific Standard Time, Eastern Standard
    /// Time, US Eastern Standard Time, Venezuela Standard Time, Paraguay Standard Time, Atlantic Standard Time, Central
    /// Brazilian Standard Time, SA Western Standard Time, Pacific SA Standard Time, Newfoundland Standard Time, E. South
    /// America Standard Time, Argentina Standard Time, SA Eastern Standard Time, Greenland Standard Time, Montevideo Standard
    /// Time, Bahia Standard Time, UTC-02, Mid-Atlantic Standard Time, Azores Standard Time, Cape Verde Standard Time, Morocco
    /// Standard Time, UTC, GMT Standard Time, Greenwich Standard Time, W. Europe Standard Time, Central Europe Standard Time,
    /// Romance Standard Time, Central European Standard Time, W. Central Africa Standard Time, Namibia Standard Time, Jordan
    /// Standard Time, GTB Standard Time, Middle East Standard Time, Egypt Standard Time, Syria Standard Time, E. Europe
    /// Standard Time, South Africa Standard Time, FLE Standard Time, Turkey Standard Time, Israel Standard Time, Kaliningrad
    /// Standard Time, Libya Standard Time, Arabic Standard Time, Arab Standard Time, Belarus Standard Time, Russian Standard
    /// Time, E. Africa Standard Time, Iran Standard Time, Arabian Standard Time, Azerbaijan Standard Time, Russia Time Zone 3,
    /// Mauritius Standard Time, Georgian Standard Time, Caucasus Standard Time, Afghanistan Standard Time, West Asia Standard
    /// Time, Ekaterinburg Standard Time, Pakistan Standard Time, India Standard Time, Sri Lanka Standard Time, Nepal Standard
    /// Time, Central Asia Standard Time, Bangladesh Standard Time, N. Central Asia Standard Time, Myanmar Standard Time, SE
    /// Asia Standard Time, North Asia Standard Time, China Standard Time, North Asia East Standard Time, Singapore Standard
    /// Time, W. Australia Standard Time, Taipei Standard Time, Ulaanbaatar Standard Time, Tokyo Standard Time, Korea Standard
    /// Time, Yakutsk Standard Time, Cen. Australia Standard Time, AUS Central Standard Time, E. Australia Standard Time, AUS
    /// Eastern Standard Time, West Pacific Standard Time, Tasmania Standard Time, Magadan Standard Time, Vladivostok Standard
    /// Time, Russia Time Zone 10, Central Pacific Standard Time, Russia Time Zone 11, New Zealand Standard Time, UTC+12, Fiji
    /// Standard Time, Kamchatka Standard Time, Tonga Standard Time, Samoa Standard Time, Line Islands Standard Time
    /// </summary>
    [JsonPropertyName("timeZone")]
    public required string TimeZone { get; set; }
}

/// <summary>Recurrence: the repeating times at which this profile begins. This element is not used if the FixedDate element is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecProfilesRecurrence
{
    /// <summary>
    /// Frequency: the recurrence frequency. How often the schedule profile should take effect. This value must be Week, meaning
    /// each week will have the same set of profiles. For example, to set a daily schedule, set schedule to every day of the
    /// week. The frequency property specifies that the schedule is repeated weekly.
    /// </summary>
    [JsonPropertyName("frequency")]
    public required V1api20221001AutoscaleSettingSpecProfilesRecurrenceFrequencyEnum Frequency { get; set; }

    /// <summary>Schedule: the scheduling constraints for when the profile begins.</summary>
    [JsonPropertyName("schedule")]
    public required V1api20221001AutoscaleSettingSpecProfilesRecurrenceSchedule Schedule { get; set; }
}

/// <summary>
/// Operator: the dimension operator. Only &apos;Equals&apos; and &apos;NotEquals&apos; are supported. &apos;Equals&apos; being equal to any of the
/// values. &apos;NotEquals&apos; being not equal to all of the values
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerDimensionsOperatorEnum>))]
public enum V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerDimensionsOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "NotEquals"), JsonStringEnumMemberName("NotEquals")]
    NotEquals
}

/// <summary>Specifies an auto scale rule metric dimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerDimensions
{
    /// <summary>DimensionName: Name of the dimension.</summary>
    [JsonPropertyName("DimensionName")]
    public required string DimensionName { get; set; }

    /// <summary>
    /// Operator: the dimension operator. Only &apos;Equals&apos; and &apos;NotEquals&apos; are supported. &apos;Equals&apos; being equal to any of the
    /// values. &apos;NotEquals&apos; being not equal to all of the values
    /// </summary>
    [JsonPropertyName("Operator")]
    public required V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerDimensionsOperatorEnum Operator { get; set; }

    /// <summary>Values: list of dimension values. For example: [&quot;App1&quot;,&quot;App2&quot;].</summary>
    [JsonPropertyName("Values")]
    public required IList<string> Values { get; set; }
}

/// <summary>MetricResourceUriReference: the resource identifier of the resource the rule monitors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerMetricResourceUriReference
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

/// <summary>Operator: the operator that is used to compare the metric data and the threshold.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerOperatorEnum>))]
public enum V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "NotEquals"), JsonStringEnumMemberName("NotEquals")]
    NotEquals
}

/// <summary>Statistic: the metric statistic type. How the metrics from multiple instances are combined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerStatisticEnum>))]
public enum V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerStatisticEnum
{
    [EnumMember(Value = "Average"), JsonStringEnumMemberName("Average")]
    Average,
    [EnumMember(Value = "Count"), JsonStringEnumMemberName("Count")]
    Count,
    [EnumMember(Value = "Max"), JsonStringEnumMemberName("Max")]
    Max,
    [EnumMember(Value = "Min"), JsonStringEnumMemberName("Min")]
    Min,
    [EnumMember(Value = "Sum"), JsonStringEnumMemberName("Sum")]
    Sum
}

/// <summary>
/// TimeAggregation: time aggregation type. How the data that is collected should be combined over time. The default value
/// is Average.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerTimeAggregationEnum>))]
public enum V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerTimeAggregationEnum
{
    [EnumMember(Value = "Average"), JsonStringEnumMemberName("Average")]
    Average,
    [EnumMember(Value = "Count"), JsonStringEnumMemberName("Count")]
    Count,
    [EnumMember(Value = "Last"), JsonStringEnumMemberName("Last")]
    Last,
    [EnumMember(Value = "Maximum"), JsonStringEnumMemberName("Maximum")]
    Maximum,
    [EnumMember(Value = "Minimum"), JsonStringEnumMemberName("Minimum")]
    Minimum,
    [EnumMember(Value = "Total"), JsonStringEnumMemberName("Total")]
    Total
}

/// <summary>MetricTrigger: the trigger that results in a scaling action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecProfilesRulesMetricTrigger
{
    /// <summary>
    /// Dimensions: List of dimension conditions. For example:
    /// [{&quot;DimensionName&quot;:&quot;AppName&quot;,&quot;Operator&quot;:&quot;Equals&quot;,&quot;Values&quot;:[&quot;App1&quot;]},{&quot;DimensionName&quot;:&quot;Deployment&quot;,&quot;Operator&quot;:&quot;Equals&quot;,&quot;Values&quot;:[&quot;default&quot;]}].
    /// </summary>
    [JsonPropertyName("dimensions")]
    public IList<V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerDimensions>? Dimensions { get; set; }

    /// <summary>DividePerInstance: a value indicating whether metric should divide per instance.</summary>
    [JsonPropertyName("dividePerInstance")]
    public bool? DividePerInstance { get; set; }

    /// <summary>MetricName: the name of the metric that defines what the rule monitors.</summary>
    [JsonPropertyName("metricName")]
    public required string MetricName { get; set; }

    /// <summary>MetricNamespace: the namespace of the metric that defines what the rule monitors.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>MetricResourceLocation: the location of the resource the rule monitors.</summary>
    [JsonPropertyName("metricResourceLocation")]
    public string? MetricResourceLocation { get; set; }

    /// <summary>MetricResourceUriReference: the resource identifier of the resource the rule monitors.</summary>
    [JsonPropertyName("metricResourceUriReference")]
    public required V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerMetricResourceUriReference MetricResourceUriReference { get; set; }

    /// <summary>Operator: the operator that is used to compare the metric data and the threshold.</summary>
    [JsonPropertyName("operator")]
    public required V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerOperatorEnum Operator { get; set; }

    /// <summary>Statistic: the metric statistic type. How the metrics from multiple instances are combined.</summary>
    [JsonPropertyName("statistic")]
    public required V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerStatisticEnum Statistic { get; set; }

    /// <summary>Threshold: the threshold of the metric that triggers the scale action.</summary>
    [JsonPropertyName("threshold")]
    public required double Threshold { get; set; }

    /// <summary>
    /// TimeAggregation: time aggregation type. How the data that is collected should be combined over time. The default value
    /// is Average.
    /// </summary>
    [JsonPropertyName("timeAggregation")]
    public required V1api20221001AutoscaleSettingSpecProfilesRulesMetricTriggerTimeAggregationEnum TimeAggregation { get; set; }

    /// <summary>
    /// TimeGrain: the granularity of metrics the rule monitors. Must be one of the predefined values returned from metric
    /// definitions for the metric. Must be between 12 hours and 1 minute.
    /// </summary>
    [JsonPropertyName("timeGrain")]
    public required string TimeGrain { get; set; }

    /// <summary>
    /// TimeWindow: the range of time in which instance data is collected. This value must be greater than the delay in metric
    /// collection, which can vary from resource-to-resource. Must be between 12 hours and 5 minutes.
    /// </summary>
    [JsonPropertyName("timeWindow")]
    public required string TimeWindow { get; set; }
}

/// <summary>Direction: the scale direction. Whether the scaling action increases or decreases the number of instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingSpecProfilesRulesScaleActionDirectionEnum>))]
public enum V1api20221001AutoscaleSettingSpecProfilesRulesScaleActionDirectionEnum
{
    [EnumMember(Value = "Decrease"), JsonStringEnumMemberName("Decrease")]
    Decrease,
    [EnumMember(Value = "Increase"), JsonStringEnumMemberName("Increase")]
    Increase,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>Type: the type of action that should occur when the scale rule fires.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingSpecProfilesRulesScaleActionTypeEnum>))]
public enum V1api20221001AutoscaleSettingSpecProfilesRulesScaleActionTypeEnum
{
    [EnumMember(Value = "ChangeCount"), JsonStringEnumMemberName("ChangeCount")]
    ChangeCount,
    [EnumMember(Value = "ExactCount"), JsonStringEnumMemberName("ExactCount")]
    ExactCount,
    [EnumMember(Value = "PercentChangeCount"), JsonStringEnumMemberName("PercentChangeCount")]
    PercentChangeCount,
    [EnumMember(Value = "ServiceAllowedNextValue"), JsonStringEnumMemberName("ServiceAllowedNextValue")]
    ServiceAllowedNextValue
}

/// <summary>ScaleAction: the parameters for the scaling action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecProfilesRulesScaleAction
{
    /// <summary>
    /// Cooldown: the amount of time to wait since the last scaling action before this action occurs. It must be between 1 week
    /// and 1 minute in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("cooldown")]
    public required string Cooldown { get; set; }

    /// <summary>Direction: the scale direction. Whether the scaling action increases or decreases the number of instances.</summary>
    [JsonPropertyName("direction")]
    public required V1api20221001AutoscaleSettingSpecProfilesRulesScaleActionDirectionEnum Direction { get; set; }

    /// <summary>Type: the type of action that should occur when the scale rule fires.</summary>
    [JsonPropertyName("type")]
    public required V1api20221001AutoscaleSettingSpecProfilesRulesScaleActionTypeEnum Type { get; set; }

    /// <summary>
    /// Value: the number of instances that are involved in the scaling action. This value must be 1 or greater. The default
    /// value is 1.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A rule that provide the triggers and parameters for the scaling action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecProfilesRules
{
    /// <summary>MetricTrigger: the trigger that results in a scaling action.</summary>
    [JsonPropertyName("metricTrigger")]
    public required V1api20221001AutoscaleSettingSpecProfilesRulesMetricTrigger MetricTrigger { get; set; }

    /// <summary>ScaleAction: the parameters for the scaling action.</summary>
    [JsonPropertyName("scaleAction")]
    public required V1api20221001AutoscaleSettingSpecProfilesRulesScaleAction ScaleAction { get; set; }
}

/// <summary>Autoscale profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecProfiles
{
    /// <summary>Capacity: the number of instances that can be used during this profile.</summary>
    [JsonPropertyName("capacity")]
    public required V1api20221001AutoscaleSettingSpecProfilesCapacity Capacity { get; set; }

    /// <summary>FixedDate: the specific date-time for the profile. This element is not used if the Recurrence element is used.</summary>
    [JsonPropertyName("fixedDate")]
    public V1api20221001AutoscaleSettingSpecProfilesFixedDate? FixedDate { get; set; }

    /// <summary>Name: the name of the profile.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Recurrence: the repeating times at which this profile begins. This element is not used if the FixedDate element is used.</summary>
    [JsonPropertyName("recurrence")]
    public V1api20221001AutoscaleSettingSpecProfilesRecurrence? Recurrence { get; set; }

    /// <summary>
    /// Rules: the collection of rules that provide the triggers and parameters for the scaling action. A maximum of 10 rules
    /// can be specified.
    /// </summary>
    [JsonPropertyName("rules")]
    public required IList<V1api20221001AutoscaleSettingSpecProfilesRules> Rules { get; set; }
}

/// <summary>TargetResourceUriReference: the resource identifier of the resource that the autoscale setting should be added to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpecTargetResourceUriReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Enabled: the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is &apos;false&apos;.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Name: the name of the autoscale setting.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Notifications: the collection of notifications.</summary>
    [JsonPropertyName("notifications")]
    public IList<V1api20221001AutoscaleSettingSpecNotifications>? Notifications { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20221001AutoscaleSettingSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20221001AutoscaleSettingSpecOwner Owner { get; set; }

    /// <summary>PredictiveAutoscalePolicy: the predictive autoscale policy mode.</summary>
    [JsonPropertyName("predictiveAutoscalePolicy")]
    public V1api20221001AutoscaleSettingSpecPredictiveAutoscalePolicy? PredictiveAutoscalePolicy { get; set; }

    /// <summary>
    /// Profiles: the collection of automatic scaling profiles that specify different scaling parameters for different time
    /// periods. A maximum of 20 profiles can be specified.
    /// </summary>
    [JsonPropertyName("profiles")]
    public required IList<V1api20221001AutoscaleSettingSpecProfiles> Profiles { get; set; }

    /// <summary>
    /// Tags: Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping
    /// this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no
    /// greater in length than 128 characters and a value no greater in length than 256 characters.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TargetResourceLocation: the location of the resource that the autoscale setting should be added to.</summary>
    [JsonPropertyName("targetResourceLocation")]
    public string? TargetResourceLocation { get; set; }

    /// <summary>TargetResourceUriReference: the resource identifier of the resource that the autoscale setting should be added to.</summary>
    [JsonPropertyName("targetResourceUriReference")]
    public V1api20221001AutoscaleSettingSpecTargetResourceUriReference? TargetResourceUriReference { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusConditions
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

/// <summary>Email: the email notification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusNotificationsEmail
{
    /// <summary>CustomEmails: the custom e-mails list. This value can be null or empty, in which case this attribute will be ignored.</summary>
    [JsonPropertyName("customEmails")]
    public IList<string>? CustomEmails { get; set; }

    /// <summary>SendToSubscriptionAdministrator: a value indicating whether to send email to subscription administrator.</summary>
    [JsonPropertyName("sendToSubscriptionAdministrator")]
    public bool? SendToSubscriptionAdministrator { get; set; }

    /// <summary>SendToSubscriptionCoAdministrators: a value indicating whether to send email to subscription co-administrators.</summary>
    [JsonPropertyName("sendToSubscriptionCoAdministrators")]
    public bool? SendToSubscriptionCoAdministrators { get; set; }
}

/// <summary>Webhook notification of an autoscale event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusNotificationsWebhooks
{
    /// <summary>Properties: a property bag of settings. This value can be empty.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>Autoscale notification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusNotifications
{
    /// <summary>Email: the email notification.</summary>
    [JsonPropertyName("email")]
    public V1api20221001AutoscaleSettingStatusNotificationsEmail? Email { get; set; }

    /// <summary>Operation: the operation associated with the notification and its value must be &quot;scale&quot;</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>Webhooks: the collection of webhook notifications.</summary>
    [JsonPropertyName("webhooks")]
    public IList<V1api20221001AutoscaleSettingStatusNotificationsWebhooks>? Webhooks { get; set; }
}

/// <summary>PredictiveAutoscalePolicy: the predictive autoscale policy mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusPredictiveAutoscalePolicy
{
    /// <summary>
    /// ScaleLookAheadTime: the amount of time to specify by which instances are launched in advance. It must be between 1
    /// minute and 60 minutes in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("scaleLookAheadTime")]
    public string? ScaleLookAheadTime { get; set; }

    /// <summary>ScaleMode: the predictive autoscale mode</summary>
    [JsonPropertyName("scaleMode")]
    public string? ScaleMode { get; set; }
}

/// <summary>Capacity: the number of instances that can be used during this profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusProfilesCapacity
{
    /// <summary>
    /// Default: the number of instances that will be set if metrics are not available for evaluation. The default is only used
    /// if the current instance count is lower than the default.
    /// </summary>
    [JsonPropertyName("default")]
    public required string Default { get; set; }

    /// <summary>
    /// Maximum: the maximum number of instances for the resource. The actual maximum number of instances is limited by the
    /// cores that are available in the subscription.
    /// </summary>
    [JsonPropertyName("maximum")]
    public required string Maximum { get; set; }

    /// <summary>Minimum: the minimum number of instances for the resource.</summary>
    [JsonPropertyName("minimum")]
    public required string Minimum { get; set; }
}

/// <summary>FixedDate: the specific date-time for the profile. This element is not used if the Recurrence element is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusProfilesFixedDate
{
    /// <summary>End: the end time for the profile in ISO 8601 format.</summary>
    [JsonPropertyName("end")]
    public required string End { get; set; }

    /// <summary>Start: the start time for the profile in ISO 8601 format.</summary>
    [JsonPropertyName("start")]
    public required string Start { get; set; }

    /// <summary>
    /// TimeZone: the timezone of the start and end times for the profile. Some examples of valid time zones are: Dateline
    /// Standard Time, UTC-11, Hawaiian Standard Time, Alaskan Standard Time, Pacific Standard Time (Mexico), Pacific Standard
    /// Time, US Mountain Standard Time, Mountain Standard Time (Mexico), Mountain Standard Time, Central America Standard Time,
    /// Central Standard Time, Central Standard Time (Mexico), Canada Central Standard Time, SA Pacific Standard Time, Eastern
    /// Standard Time, US Eastern Standard Time, Venezuela Standard Time, Paraguay Standard Time, Atlantic Standard Time,
    /// Central Brazilian Standard Time, SA Western Standard Time, Pacific SA Standard Time, Newfoundland Standard Time, E.
    /// South America Standard Time, Argentina Standard Time, SA Eastern Standard Time, Greenland Standard Time, Montevideo
    /// Standard Time, Bahia Standard Time, UTC-02, Mid-Atlantic Standard Time, Azores Standard Time, Cape Verde Standard Time,
    /// Morocco Standard Time, UTC, GMT Standard Time, Greenwich Standard Time, W. Europe Standard Time, Central Europe Standard
    /// Time, Romance Standard Time, Central European Standard Time, W. Central Africa Standard Time, Namibia Standard Time,
    /// Jordan Standard Time, GTB Standard Time, Middle East Standard Time, Egypt Standard Time, Syria Standard Time, E. Europe
    /// Standard Time, South Africa Standard Time, FLE Standard Time, Turkey Standard Time, Israel Standard Time, Kaliningrad
    /// Standard Time, Libya Standard Time, Arabic Standard Time, Arab Standard Time, Belarus Standard Time, Russian Standard
    /// Time, E. Africa Standard Time, Iran Standard Time, Arabian Standard Time, Azerbaijan Standard Time, Russia Time Zone 3,
    /// Mauritius Standard Time, Georgian Standard Time, Caucasus Standard Time, Afghanistan Standard Time, West Asia Standard
    /// Time, Ekaterinburg Standard Time, Pakistan Standard Time, India Standard Time, Sri Lanka Standard Time, Nepal Standard
    /// Time, Central Asia Standard Time, Bangladesh Standard Time, N. Central Asia Standard Time, Myanmar Standard Time, SE
    /// Asia Standard Time, North Asia Standard Time, China Standard Time, North Asia East Standard Time, Singapore Standard
    /// Time, W. Australia Standard Time, Taipei Standard Time, Ulaanbaatar Standard Time, Tokyo Standard Time, Korea Standard
    /// Time, Yakutsk Standard Time, Cen. Australia Standard Time, AUS Central Standard Time, E. Australia Standard Time, AUS
    /// Eastern Standard Time, West Pacific Standard Time, Tasmania Standard Time, Magadan Standard Time, Vladivostok Standard
    /// Time, Russia Time Zone 10, Central Pacific Standard Time, Russia Time Zone 11, New Zealand Standard Time, UTC+12, Fiji
    /// Standard Time, Kamchatka Standard Time, Tonga Standard Time, Samoa Standard Time, Line Islands Standard Time
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// Frequency: the recurrence frequency. How often the schedule profile should take effect. This value must be Week, meaning
/// each week will have the same set of profiles. For example, to set a daily schedule, set schedule to every day of the
/// week. The frequency property specifies that the schedule is repeated weekly.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingStatusProfilesRecurrenceFrequencyEnum>))]
public enum V1api20221001AutoscaleSettingStatusProfilesRecurrenceFrequencyEnum
{
    [EnumMember(Value = "Day"), JsonStringEnumMemberName("Day")]
    Day,
    [EnumMember(Value = "Hour"), JsonStringEnumMemberName("Hour")]
    Hour,
    [EnumMember(Value = "Minute"), JsonStringEnumMemberName("Minute")]
    Minute,
    [EnumMember(Value = "Month"), JsonStringEnumMemberName("Month")]
    Month,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Second"), JsonStringEnumMemberName("Second")]
    Second,
    [EnumMember(Value = "Week"), JsonStringEnumMemberName("Week")]
    Week,
    [EnumMember(Value = "Year"), JsonStringEnumMemberName("Year")]
    Year
}

/// <summary>Schedule: the scheduling constraints for when the profile begins.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusProfilesRecurrenceSchedule
{
    /// <summary>Days: the collection of days that the profile takes effect on. Possible values are Sunday through Saturday.</summary>
    [JsonPropertyName("days")]
    public required IList<string> Days { get; set; }

    /// <summary>
    /// Hours: A collection of hours that the profile takes effect on. Values supported are 0 to 23 on the 24-hour clock (AM/PM
    /// times are not supported).
    /// </summary>
    [JsonPropertyName("hours")]
    public required IList<int> Hours { get; set; }

    /// <summary>Minutes: A collection of minutes at which the profile takes effect at.</summary>
    [JsonPropertyName("minutes")]
    public required IList<int> Minutes { get; set; }

    /// <summary>
    /// TimeZone: the timezone for the hours of the profile. Some examples of valid time zones are: Dateline Standard Time,
    /// UTC-11, Hawaiian Standard Time, Alaskan Standard Time, Pacific Standard Time (Mexico), Pacific Standard Time, US
    /// Mountain Standard Time, Mountain Standard Time (Mexico), Mountain Standard Time, Central America Standard Time, Central
    /// Standard Time, Central Standard Time (Mexico), Canada Central Standard Time, SA Pacific Standard Time, Eastern Standard
    /// Time, US Eastern Standard Time, Venezuela Standard Time, Paraguay Standard Time, Atlantic Standard Time, Central
    /// Brazilian Standard Time, SA Western Standard Time, Pacific SA Standard Time, Newfoundland Standard Time, E. South
    /// America Standard Time, Argentina Standard Time, SA Eastern Standard Time, Greenland Standard Time, Montevideo Standard
    /// Time, Bahia Standard Time, UTC-02, Mid-Atlantic Standard Time, Azores Standard Time, Cape Verde Standard Time, Morocco
    /// Standard Time, UTC, GMT Standard Time, Greenwich Standard Time, W. Europe Standard Time, Central Europe Standard Time,
    /// Romance Standard Time, Central European Standard Time, W. Central Africa Standard Time, Namibia Standard Time, Jordan
    /// Standard Time, GTB Standard Time, Middle East Standard Time, Egypt Standard Time, Syria Standard Time, E. Europe
    /// Standard Time, South Africa Standard Time, FLE Standard Time, Turkey Standard Time, Israel Standard Time, Kaliningrad
    /// Standard Time, Libya Standard Time, Arabic Standard Time, Arab Standard Time, Belarus Standard Time, Russian Standard
    /// Time, E. Africa Standard Time, Iran Standard Time, Arabian Standard Time, Azerbaijan Standard Time, Russia Time Zone 3,
    /// Mauritius Standard Time, Georgian Standard Time, Caucasus Standard Time, Afghanistan Standard Time, West Asia Standard
    /// Time, Ekaterinburg Standard Time, Pakistan Standard Time, India Standard Time, Sri Lanka Standard Time, Nepal Standard
    /// Time, Central Asia Standard Time, Bangladesh Standard Time, N. Central Asia Standard Time, Myanmar Standard Time, SE
    /// Asia Standard Time, North Asia Standard Time, China Standard Time, North Asia East Standard Time, Singapore Standard
    /// Time, W. Australia Standard Time, Taipei Standard Time, Ulaanbaatar Standard Time, Tokyo Standard Time, Korea Standard
    /// Time, Yakutsk Standard Time, Cen. Australia Standard Time, AUS Central Standard Time, E. Australia Standard Time, AUS
    /// Eastern Standard Time, West Pacific Standard Time, Tasmania Standard Time, Magadan Standard Time, Vladivostok Standard
    /// Time, Russia Time Zone 10, Central Pacific Standard Time, Russia Time Zone 11, New Zealand Standard Time, UTC+12, Fiji
    /// Standard Time, Kamchatka Standard Time, Tonga Standard Time, Samoa Standard Time, Line Islands Standard Time
    /// </summary>
    [JsonPropertyName("timeZone")]
    public required string TimeZone { get; set; }
}

/// <summary>Recurrence: the repeating times at which this profile begins. This element is not used if the FixedDate element is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusProfilesRecurrence
{
    /// <summary>
    /// Frequency: the recurrence frequency. How often the schedule profile should take effect. This value must be Week, meaning
    /// each week will have the same set of profiles. For example, to set a daily schedule, set schedule to every day of the
    /// week. The frequency property specifies that the schedule is repeated weekly.
    /// </summary>
    [JsonPropertyName("frequency")]
    public required V1api20221001AutoscaleSettingStatusProfilesRecurrenceFrequencyEnum Frequency { get; set; }

    /// <summary>Schedule: the scheduling constraints for when the profile begins.</summary>
    [JsonPropertyName("schedule")]
    public required V1api20221001AutoscaleSettingStatusProfilesRecurrenceSchedule Schedule { get; set; }
}

/// <summary>
/// Operator: the dimension operator. Only &apos;Equals&apos; and &apos;NotEquals&apos; are supported. &apos;Equals&apos; being equal to any of the
/// values. &apos;NotEquals&apos; being not equal to all of the values
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerDimensionsOperatorEnum>))]
public enum V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerDimensionsOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "NotEquals"), JsonStringEnumMemberName("NotEquals")]
    NotEquals
}

/// <summary>Specifies an auto scale rule metric dimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerDimensions
{
    /// <summary>DimensionName: Name of the dimension.</summary>
    [JsonPropertyName("DimensionName")]
    public required string DimensionName { get; set; }

    /// <summary>
    /// Operator: the dimension operator. Only &apos;Equals&apos; and &apos;NotEquals&apos; are supported. &apos;Equals&apos; being equal to any of the
    /// values. &apos;NotEquals&apos; being not equal to all of the values
    /// </summary>
    [JsonPropertyName("Operator")]
    public required V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerDimensionsOperatorEnum Operator { get; set; }

    /// <summary>Values: list of dimension values. For example: [&quot;App1&quot;,&quot;App2&quot;].</summary>
    [JsonPropertyName("Values")]
    public required IList<string> Values { get; set; }
}

/// <summary>Operator: the operator that is used to compare the metric data and the threshold.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerOperatorEnum>))]
public enum V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "NotEquals"), JsonStringEnumMemberName("NotEquals")]
    NotEquals
}

/// <summary>Statistic: the metric statistic type. How the metrics from multiple instances are combined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerStatisticEnum>))]
public enum V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerStatisticEnum
{
    [EnumMember(Value = "Average"), JsonStringEnumMemberName("Average")]
    Average,
    [EnumMember(Value = "Count"), JsonStringEnumMemberName("Count")]
    Count,
    [EnumMember(Value = "Max"), JsonStringEnumMemberName("Max")]
    Max,
    [EnumMember(Value = "Min"), JsonStringEnumMemberName("Min")]
    Min,
    [EnumMember(Value = "Sum"), JsonStringEnumMemberName("Sum")]
    Sum
}

/// <summary>
/// TimeAggregation: time aggregation type. How the data that is collected should be combined over time. The default value
/// is Average.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerTimeAggregationEnum>))]
public enum V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerTimeAggregationEnum
{
    [EnumMember(Value = "Average"), JsonStringEnumMemberName("Average")]
    Average,
    [EnumMember(Value = "Count"), JsonStringEnumMemberName("Count")]
    Count,
    [EnumMember(Value = "Last"), JsonStringEnumMemberName("Last")]
    Last,
    [EnumMember(Value = "Maximum"), JsonStringEnumMemberName("Maximum")]
    Maximum,
    [EnumMember(Value = "Minimum"), JsonStringEnumMemberName("Minimum")]
    Minimum,
    [EnumMember(Value = "Total"), JsonStringEnumMemberName("Total")]
    Total
}

/// <summary>MetricTrigger: the trigger that results in a scaling action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusProfilesRulesMetricTrigger
{
    /// <summary>
    /// Dimensions: List of dimension conditions. For example:
    /// [{&quot;DimensionName&quot;:&quot;AppName&quot;,&quot;Operator&quot;:&quot;Equals&quot;,&quot;Values&quot;:[&quot;App1&quot;]},{&quot;DimensionName&quot;:&quot;Deployment&quot;,&quot;Operator&quot;:&quot;Equals&quot;,&quot;Values&quot;:[&quot;default&quot;]}].
    /// </summary>
    [JsonPropertyName("dimensions")]
    public IList<V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerDimensions>? Dimensions { get; set; }

    /// <summary>DividePerInstance: a value indicating whether metric should divide per instance.</summary>
    [JsonPropertyName("dividePerInstance")]
    public bool? DividePerInstance { get; set; }

    /// <summary>MetricName: the name of the metric that defines what the rule monitors.</summary>
    [JsonPropertyName("metricName")]
    public required string MetricName { get; set; }

    /// <summary>MetricNamespace: the namespace of the metric that defines what the rule monitors.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>MetricResourceLocation: the location of the resource the rule monitors.</summary>
    [JsonPropertyName("metricResourceLocation")]
    public string? MetricResourceLocation { get; set; }

    /// <summary>MetricResourceUri: the resource identifier of the resource the rule monitors.</summary>
    [JsonPropertyName("metricResourceUri")]
    public required string MetricResourceUri { get; set; }

    /// <summary>Operator: the operator that is used to compare the metric data and the threshold.</summary>
    [JsonPropertyName("operator")]
    public required V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerOperatorEnum Operator { get; set; }

    /// <summary>Statistic: the metric statistic type. How the metrics from multiple instances are combined.</summary>
    [JsonPropertyName("statistic")]
    public required V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerStatisticEnum Statistic { get; set; }

    /// <summary>Threshold: the threshold of the metric that triggers the scale action.</summary>
    [JsonPropertyName("threshold")]
    public required double Threshold { get; set; }

    /// <summary>
    /// TimeAggregation: time aggregation type. How the data that is collected should be combined over time. The default value
    /// is Average.
    /// </summary>
    [JsonPropertyName("timeAggregation")]
    public required V1api20221001AutoscaleSettingStatusProfilesRulesMetricTriggerTimeAggregationEnum TimeAggregation { get; set; }

    /// <summary>
    /// TimeGrain: the granularity of metrics the rule monitors. Must be one of the predefined values returned from metric
    /// definitions for the metric. Must be between 12 hours and 1 minute.
    /// </summary>
    [JsonPropertyName("timeGrain")]
    public required string TimeGrain { get; set; }

    /// <summary>
    /// TimeWindow: the range of time in which instance data is collected. This value must be greater than the delay in metric
    /// collection, which can vary from resource-to-resource. Must be between 12 hours and 5 minutes.
    /// </summary>
    [JsonPropertyName("timeWindow")]
    public required string TimeWindow { get; set; }
}

/// <summary>Direction: the scale direction. Whether the scaling action increases or decreases the number of instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingStatusProfilesRulesScaleActionDirectionEnum>))]
public enum V1api20221001AutoscaleSettingStatusProfilesRulesScaleActionDirectionEnum
{
    [EnumMember(Value = "Decrease"), JsonStringEnumMemberName("Decrease")]
    Decrease,
    [EnumMember(Value = "Increase"), JsonStringEnumMemberName("Increase")]
    Increase,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>Type: the type of action that should occur when the scale rule fires.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20221001AutoscaleSettingStatusProfilesRulesScaleActionTypeEnum>))]
public enum V1api20221001AutoscaleSettingStatusProfilesRulesScaleActionTypeEnum
{
    [EnumMember(Value = "ChangeCount"), JsonStringEnumMemberName("ChangeCount")]
    ChangeCount,
    [EnumMember(Value = "ExactCount"), JsonStringEnumMemberName("ExactCount")]
    ExactCount,
    [EnumMember(Value = "PercentChangeCount"), JsonStringEnumMemberName("PercentChangeCount")]
    PercentChangeCount,
    [EnumMember(Value = "ServiceAllowedNextValue"), JsonStringEnumMemberName("ServiceAllowedNextValue")]
    ServiceAllowedNextValue
}

/// <summary>ScaleAction: the parameters for the scaling action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusProfilesRulesScaleAction
{
    /// <summary>
    /// Cooldown: the amount of time to wait since the last scaling action before this action occurs. It must be between 1 week
    /// and 1 minute in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("cooldown")]
    public required string Cooldown { get; set; }

    /// <summary>Direction: the scale direction. Whether the scaling action increases or decreases the number of instances.</summary>
    [JsonPropertyName("direction")]
    public required V1api20221001AutoscaleSettingStatusProfilesRulesScaleActionDirectionEnum Direction { get; set; }

    /// <summary>Type: the type of action that should occur when the scale rule fires.</summary>
    [JsonPropertyName("type")]
    public required V1api20221001AutoscaleSettingStatusProfilesRulesScaleActionTypeEnum Type { get; set; }

    /// <summary>
    /// Value: the number of instances that are involved in the scaling action. This value must be 1 or greater. The default
    /// value is 1.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A rule that provide the triggers and parameters for the scaling action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusProfilesRules
{
    /// <summary>MetricTrigger: the trigger that results in a scaling action.</summary>
    [JsonPropertyName("metricTrigger")]
    public required V1api20221001AutoscaleSettingStatusProfilesRulesMetricTrigger MetricTrigger { get; set; }

    /// <summary>ScaleAction: the parameters for the scaling action.</summary>
    [JsonPropertyName("scaleAction")]
    public required V1api20221001AutoscaleSettingStatusProfilesRulesScaleAction ScaleAction { get; set; }
}

/// <summary>Autoscale profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusProfiles
{
    /// <summary>Capacity: the number of instances that can be used during this profile.</summary>
    [JsonPropertyName("capacity")]
    public required V1api20221001AutoscaleSettingStatusProfilesCapacity Capacity { get; set; }

    /// <summary>FixedDate: the specific date-time for the profile. This element is not used if the Recurrence element is used.</summary>
    [JsonPropertyName("fixedDate")]
    public V1api20221001AutoscaleSettingStatusProfilesFixedDate? FixedDate { get; set; }

    /// <summary>Name: the name of the profile.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Recurrence: the repeating times at which this profile begins. This element is not used if the FixedDate element is used.</summary>
    [JsonPropertyName("recurrence")]
    public V1api20221001AutoscaleSettingStatusProfilesRecurrence? Recurrence { get; set; }

    /// <summary>
    /// Rules: the collection of rules that provide the triggers and parameters for the scaling action. A maximum of 10 rules
    /// can be specified.
    /// </summary>
    [JsonPropertyName("rules")]
    public required IList<V1api20221001AutoscaleSettingStatusProfilesRules> Rules { get; set; }
}

/// <summary>SystemData: The system metadata related to the response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001AutoscaleSettingStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20221001AutoscaleSettingStatusConditions>? Conditions { get; set; }

    /// <summary>Enabled: the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is &apos;false&apos;.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Id: Azure resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Azure resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Notifications: the collection of notifications.</summary>
    [JsonPropertyName("notifications")]
    public IList<V1api20221001AutoscaleSettingStatusNotifications>? Notifications { get; set; }

    /// <summary>PredictiveAutoscalePolicy: the predictive autoscale policy mode.</summary>
    [JsonPropertyName("predictiveAutoscalePolicy")]
    public V1api20221001AutoscaleSettingStatusPredictiveAutoscalePolicy? PredictiveAutoscalePolicy { get; set; }

    /// <summary>
    /// Profiles: the collection of automatic scaling profiles that specify different scaling parameters for different time
    /// periods. A maximum of 20 profiles can be specified.
    /// </summary>
    [JsonPropertyName("profiles")]
    public IList<V1api20221001AutoscaleSettingStatusProfiles>? Profiles { get; set; }

    /// <summary>PropertiesName: the name of the autoscale setting.</summary>
    [JsonPropertyName("properties_name")]
    public string? PropertiesName { get; set; }

    /// <summary>SystemData: The system metadata related to the response.</summary>
    [JsonPropertyName("systemData")]
    public V1api20221001AutoscaleSettingStatusSystemData? SystemData { get; set; }

    /// <summary>
    /// Tags: Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping
    /// this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no
    /// greater in length than 128 characters and a value no greater in length than 256 characters.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TargetResourceLocation: the location of the resource that the autoscale setting should be added to.</summary>
    [JsonPropertyName("targetResourceLocation")]
    public string? TargetResourceLocation { get; set; }

    /// <summary>TargetResourceUri: the resource identifier of the resource that the autoscale setting should be added to.</summary>
    [JsonPropertyName("targetResourceUri")]
    public string? TargetResourceUri { get; set; }

    /// <summary>Type: Azure resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2022-10-01/autoscale_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20221001AutoscaleSetting : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20221001AutoscaleSettingSpec?>, IStatus<V1api20221001AutoscaleSettingStatus?>
{
    public const string KubeApiVersion = "v1api20221001";
    public const string KubeKind = "AutoscaleSetting";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "autoscalesettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20221001";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AutoscaleSetting";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20221001AutoscaleSettingSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20221001AutoscaleSettingStatus? Status { get; set; }
}