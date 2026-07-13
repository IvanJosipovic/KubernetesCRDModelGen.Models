#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventgrid.azure.upbound.io;
/// <summary>EventSubscription is the Schema for the EventSubscriptions API. Manages an EventGrid Event Subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EventSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2EventSubscription>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EventSubscriptionList";
    public const string KubeGroup = "eventgrid.azure.upbound.io";
    public const string KubePluralName = "eventsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2EventSubscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2EventSubscription> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecDeletionPolicyEnum>))]
public enum V1beta2EventSubscriptionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterBoolEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterIsNotNull
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterIsNullOrUndefined
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberGreaterThan
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberGreaterThanOrEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberInRange
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberLessThan
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberLessThanOrEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberNotIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberNotInRange
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringBeginsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringContains
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringEndsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringNotBeginsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringNotContains
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringNotEndsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringNotIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A advanced_filter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAdvancedFilter
{
    /// <summary>Compares a value of an event using a single boolean value.</summary>
    [JsonPropertyName("boolEquals")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterBoolEquals>? BoolEquals { get; set; }

    /// <summary>Evaluates if a value of an event isn&apos;t NULL or undefined.</summary>
    [JsonPropertyName("isNotNull")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterIsNotNull>? IsNotNull { get; set; }

    /// <summary>Evaluates if a value of an event is NULL or undefined.</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterIsNullOrUndefined>? IsNullOrUndefined { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThan")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberGreaterThan>? NumberGreaterThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberGreaterThanOrEquals>? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberIn")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberIn>? NumberIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberInRange")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberInRange>? NumberInRange { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThan")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberLessThan>? NumberLessThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberLessThanOrEquals>? NumberLessThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberNotIn")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberNotIn>? NumberNotIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberNotInRange")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterNumberNotInRange>? NumberNotInRange { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringBeginsWith")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringBeginsWith>? StringBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringContains")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringContains>? StringContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringEndsWith")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringEndsWith>? StringEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringIn")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringIn>? StringIn { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringNotBeginsWith>? StringNotBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotContains")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringNotContains>? StringNotContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringNotEndsWith>? StringNotEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotIn")]
    public IList<V1beta2EventSubscriptionSpecForProviderAdvancedFilterStringNotIn>? StringNotIn { get; set; }
}

/// <summary>An azure_function_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderAzureFunctionEndpoint
{
    /// <summary>Specifies the ID of the Function where the Event Subscription will receive events. This must be the functions ID in format {function_app.id}/functions/{name}.</summary>
    [JsonPropertyName("functionId")]
    public string? FunctionId { get; set; }

    /// <summary>Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public double? MaxEventsPerBatch { get; set; }

    /// <summary>Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public double? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>A dead_letter_identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderDeadLetterIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for dead lettering. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>A delivery_identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderDeliveryIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for event delivery. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>If the type is Static, then provide the value to use</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderDeliveryPropertyValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderDeliveryProperty
{
    /// <summary>The name of the header to send on to the destination</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>True if the value is a secret and should be protected, otherwise false. If True, then this value won&apos;t be returned from Azure API calls</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>If the type is Dynamic, then provide the payload field to be used as the value. Valid source fields differ by subscription type.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Either Static or Dynamic</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>If the type is Static, then provide the value to use</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta2EventSubscriptionSpecForProviderDeliveryPropertyValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>A retry_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderRetryPolicy
{
    /// <summary>Specifies the time to live (in minutes) for events. Supported range is 1 to 1440. See official documentation for more details.</summary>
    [JsonPropertyName("eventTimeToLive")]
    public double? EventTimeToLive { get; set; }

    /// <summary>Specifies the maximum number of delivery retry attempts for events.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public double? MaxDeliveryAttempts { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecForProviderScopeRefPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecForProviderScopeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecForProviderScopeRefPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecForProviderScopeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderScopeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecForProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecForProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EventSubscriptionSpecForProviderScopeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecForProviderScopeSelectorPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecForProviderScopeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecForProviderScopeSelectorPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecForProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderScopeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecForProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecForProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderScopeSelector
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
    public V1beta2EventSubscriptionSpecForProviderScopeSelectorPolicy? Policy { get; set; }
}

/// <summary>A storage_blob_dead_letter_destination block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderStorageBlobDeadLetterDestination
{
    /// <summary>Specifies the id of the storage account id where the storage blob is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Specifies the name of the Storage blob container that is the destination of the deadletter events.</summary>
    [JsonPropertyName("storageBlobContainerName")]
    public string? StorageBlobContainerName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in storage to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in storage to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelector
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
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelector
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
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A storage_queue_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderStorageQueueEndpoint
{
    /// <summary>Storage queue message time to live in seconds.</summary>
    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public double? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>Specifies the name of the storage queue where the Event Subscription will receive events.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>Reference to a Queue in storage to populate queueName.</summary>
    [JsonPropertyName("queueNameRef")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRef? QueueNameRef { get; set; }

    /// <summary>Selector for a Queue in storage to populate queueName.</summary>
    [JsonPropertyName("queueNameSelector")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelector? QueueNameSelector { get; set; }

    /// <summary>Specifies the id of the storage account id where the storage queue is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary>A subject_filter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderSubjectFilter
{
    /// <summary>Specifies if subject_begins_with and subject_ends_with case sensitive. This value</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>A string to filter events for an event subscription based on a resource path prefix.</summary>
    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    /// <summary>A string to filter events for an event subscription based on a resource path suffix.</summary>
    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

/// <summary>A webhook_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProviderWebhookEndpoint
{
    /// <summary>The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in delivery requests.</summary>
    [JsonPropertyName("activeDirectoryAppIdOrUri")]
    public string? ActiveDirectoryAppIdOrUri { get; set; }

    /// <summary>The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests.</summary>
    [JsonPropertyName("activeDirectoryTenantId")]
    public string? ActiveDirectoryTenantId { get; set; }

    /// <summary>Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public double? MaxEventsPerBatch { get; set; }

    /// <summary>Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public double? PreferredBatchSizeInKilobytes { get; set; }

    /// <summary>Specifies the url of the webhook where the Event Subscription will receive events.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecForProvider
{
    /// <summary>A advanced_filter block as defined below.</summary>
    [JsonPropertyName("advancedFilter")]
    public V1beta2EventSubscriptionSpecForProviderAdvancedFilter? AdvancedFilter { get; set; }

    /// <summary>Specifies whether advanced filters should be evaluated against an array of values instead of expecting a singular value. Defaults to false.</summary>
    [JsonPropertyName("advancedFilteringOnArraysEnabled")]
    public bool? AdvancedFilteringOnArraysEnabled { get; set; }

    /// <summary>An azure_function_endpoint block as defined below.</summary>
    [JsonPropertyName("azureFunctionEndpoint")]
    public V1beta2EventSubscriptionSpecForProviderAzureFunctionEndpoint? AzureFunctionEndpoint { get; set; }

    /// <summary>A dead_letter_identity block as defined below.</summary>
    [JsonPropertyName("deadLetterIdentity")]
    public V1beta2EventSubscriptionSpecForProviderDeadLetterIdentity? DeadLetterIdentity { get; set; }

    /// <summary>A delivery_identity block as defined below.</summary>
    [JsonPropertyName("deliveryIdentity")]
    public V1beta2EventSubscriptionSpecForProviderDeliveryIdentity? DeliveryIdentity { get; set; }

    /// <summary>One or more delivery_property blocks as defined below.</summary>
    [JsonPropertyName("deliveryProperty")]
    public IList<V1beta2EventSubscriptionSpecForProviderDeliveryProperty>? DeliveryProperty { get; set; }

    /// <summary>Specifies the event delivery schema for the event subscription. Possible values include: EventGridSchema, CloudEventSchemaV1_0, CustomInputSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventDeliverySchema")]
    public string? EventDeliverySchema { get; set; }

    /// <summary>Specifies the id where the Event Hub is located.</summary>
    [JsonPropertyName("eventhubEndpointId")]
    public string? EventhubEndpointId { get; set; }

    /// <summary>Specifies the expiration time of the event subscription (Datetime Format RFC 3339).</summary>
    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>Specifies the id where the Hybrid Connection is located.</summary>
    [JsonPropertyName("hybridConnectionEndpointId")]
    public string? HybridConnectionEndpointId { get; set; }

    /// <summary>A list of applicable event types that need to be part of the event subscription.</summary>
    [JsonPropertyName("includedEventTypes")]
    public IList<string>? IncludedEventTypes { get; set; }

    /// <summary>A list of labels to assign to the event subscription.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>Specifies the name of the EventGrid Event Subscription resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A retry_policy block as defined below.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2EventSubscriptionSpecForProviderRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Specifies the scope at which the EventGrid Event Subscription should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta2EventSubscriptionSpecForProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta2EventSubscriptionSpecForProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>Specifies the id where the Service Bus Queue is located.</summary>
    [JsonPropertyName("serviceBusQueueEndpointId")]
    public string? ServiceBusQueueEndpointId { get; set; }

    /// <summary>Specifies the id where the Service Bus Topic is located.</summary>
    [JsonPropertyName("serviceBusTopicEndpointId")]
    public string? ServiceBusTopicEndpointId { get; set; }

    /// <summary>A storage_blob_dead_letter_destination block as defined below.</summary>
    [JsonPropertyName("storageBlobDeadLetterDestination")]
    public V1beta2EventSubscriptionSpecForProviderStorageBlobDeadLetterDestination? StorageBlobDeadLetterDestination { get; set; }

    /// <summary>A storage_queue_endpoint block as defined below.</summary>
    [JsonPropertyName("storageQueueEndpoint")]
    public V1beta2EventSubscriptionSpecForProviderStorageQueueEndpoint? StorageQueueEndpoint { get; set; }

    /// <summary>A subject_filter block as defined below.</summary>
    [JsonPropertyName("subjectFilter")]
    public V1beta2EventSubscriptionSpecForProviderSubjectFilter? SubjectFilter { get; set; }

    /// <summary>A webhook_endpoint block as defined below.</summary>
    [JsonPropertyName("webhookEndpoint")]
    public V1beta2EventSubscriptionSpecForProviderWebhookEndpoint? WebhookEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterBoolEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterIsNotNull
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterIsNullOrUndefined
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberGreaterThan
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberGreaterThanOrEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberInRange
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberLessThan
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberLessThanOrEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberNotIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberNotInRange
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringBeginsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringContains
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringEndsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringNotBeginsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringNotContains
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringNotEndsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringNotIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A advanced_filter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAdvancedFilter
{
    /// <summary>Compares a value of an event using a single boolean value.</summary>
    [JsonPropertyName("boolEquals")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterBoolEquals>? BoolEquals { get; set; }

    /// <summary>Evaluates if a value of an event isn&apos;t NULL or undefined.</summary>
    [JsonPropertyName("isNotNull")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterIsNotNull>? IsNotNull { get; set; }

    /// <summary>Evaluates if a value of an event is NULL or undefined.</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterIsNullOrUndefined>? IsNullOrUndefined { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThan")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberGreaterThan>? NumberGreaterThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberGreaterThanOrEquals>? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberIn")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberIn>? NumberIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberInRange")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberInRange>? NumberInRange { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThan")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberLessThan>? NumberLessThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberLessThanOrEquals>? NumberLessThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberNotIn")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberNotIn>? NumberNotIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberNotInRange")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterNumberNotInRange>? NumberNotInRange { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringBeginsWith")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringBeginsWith>? StringBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringContains")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringContains>? StringContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringEndsWith")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringEndsWith>? StringEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringIn")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringIn>? StringIn { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringNotBeginsWith>? StringNotBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotContains")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringNotContains>? StringNotContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringNotEndsWith>? StringNotEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotIn")]
    public IList<V1beta2EventSubscriptionSpecInitProviderAdvancedFilterStringNotIn>? StringNotIn { get; set; }
}

/// <summary>An azure_function_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderAzureFunctionEndpoint
{
    /// <summary>Specifies the ID of the Function where the Event Subscription will receive events. This must be the functions ID in format {function_app.id}/functions/{name}.</summary>
    [JsonPropertyName("functionId")]
    public string? FunctionId { get; set; }

    /// <summary>Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public double? MaxEventsPerBatch { get; set; }

    /// <summary>Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public double? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>A dead_letter_identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderDeadLetterIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for dead lettering. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>A delivery_identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderDeliveryIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for event delivery. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>If the type is Static, then provide the value to use</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderDeliveryPropertyValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderDeliveryProperty
{
    /// <summary>The name of the header to send on to the destination</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>True if the value is a secret and should be protected, otherwise false. If True, then this value won&apos;t be returned from Azure API calls</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>If the type is Dynamic, then provide the payload field to be used as the value. Valid source fields differ by subscription type.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Either Static or Dynamic</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>If the type is Static, then provide the value to use</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta2EventSubscriptionSpecInitProviderDeliveryPropertyValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>A retry_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderRetryPolicy
{
    /// <summary>Specifies the time to live (in minutes) for events. Supported range is 1 to 1440. See official documentation for more details.</summary>
    [JsonPropertyName("eventTimeToLive")]
    public double? EventTimeToLive { get; set; }

    /// <summary>Specifies the maximum number of delivery retry attempts for events.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public double? MaxDeliveryAttempts { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecInitProviderScopeRefPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecInitProviderScopeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecInitProviderScopeRefPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecInitProviderScopeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderScopeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecInitProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecInitProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EventSubscriptionSpecInitProviderScopeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecInitProviderScopeSelectorPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecInitProviderScopeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecInitProviderScopeSelectorPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecInitProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderScopeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecInitProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecInitProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderScopeSelector
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
    public V1beta2EventSubscriptionSpecInitProviderScopeSelectorPolicy? Policy { get; set; }
}

/// <summary>A storage_blob_dead_letter_destination block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderStorageBlobDeadLetterDestination
{
    /// <summary>Specifies the id of the storage account id where the storage blob is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Specifies the name of the Storage blob container that is the destination of the deadletter events.</summary>
    [JsonPropertyName("storageBlobContainerName")]
    public string? StorageBlobContainerName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in storage to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in storage to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelector
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
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelector
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
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A storage_queue_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpoint
{
    /// <summary>Storage queue message time to live in seconds.</summary>
    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public double? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>Specifies the name of the storage queue where the Event Subscription will receive events.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>Reference to a Queue in storage to populate queueName.</summary>
    [JsonPropertyName("queueNameRef")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRef? QueueNameRef { get; set; }

    /// <summary>Selector for a Queue in storage to populate queueName.</summary>
    [JsonPropertyName("queueNameSelector")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelector? QueueNameSelector { get; set; }

    /// <summary>Specifies the id of the storage account id where the storage queue is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary>A subject_filter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderSubjectFilter
{
    /// <summary>Specifies if subject_begins_with and subject_ends_with case sensitive. This value</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>A string to filter events for an event subscription based on a resource path prefix.</summary>
    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    /// <summary>A string to filter events for an event subscription based on a resource path suffix.</summary>
    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

/// <summary>A webhook_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecInitProviderWebhookEndpoint
{
    /// <summary>The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in delivery requests.</summary>
    [JsonPropertyName("activeDirectoryAppIdOrUri")]
    public string? ActiveDirectoryAppIdOrUri { get; set; }

    /// <summary>The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests.</summary>
    [JsonPropertyName("activeDirectoryTenantId")]
    public string? ActiveDirectoryTenantId { get; set; }

    /// <summary>Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public double? MaxEventsPerBatch { get; set; }

    /// <summary>Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public double? PreferredBatchSizeInKilobytes { get; set; }

    /// <summary>Specifies the url of the webhook where the Event Subscription will receive events.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
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
public partial class V1beta2EventSubscriptionSpecInitProvider
{
    /// <summary>A advanced_filter block as defined below.</summary>
    [JsonPropertyName("advancedFilter")]
    public V1beta2EventSubscriptionSpecInitProviderAdvancedFilter? AdvancedFilter { get; set; }

    /// <summary>Specifies whether advanced filters should be evaluated against an array of values instead of expecting a singular value. Defaults to false.</summary>
    [JsonPropertyName("advancedFilteringOnArraysEnabled")]
    public bool? AdvancedFilteringOnArraysEnabled { get; set; }

    /// <summary>An azure_function_endpoint block as defined below.</summary>
    [JsonPropertyName("azureFunctionEndpoint")]
    public V1beta2EventSubscriptionSpecInitProviderAzureFunctionEndpoint? AzureFunctionEndpoint { get; set; }

    /// <summary>A dead_letter_identity block as defined below.</summary>
    [JsonPropertyName("deadLetterIdentity")]
    public V1beta2EventSubscriptionSpecInitProviderDeadLetterIdentity? DeadLetterIdentity { get; set; }

    /// <summary>A delivery_identity block as defined below.</summary>
    [JsonPropertyName("deliveryIdentity")]
    public V1beta2EventSubscriptionSpecInitProviderDeliveryIdentity? DeliveryIdentity { get; set; }

    /// <summary>One or more delivery_property blocks as defined below.</summary>
    [JsonPropertyName("deliveryProperty")]
    public IList<V1beta2EventSubscriptionSpecInitProviderDeliveryProperty>? DeliveryProperty { get; set; }

    /// <summary>Specifies the event delivery schema for the event subscription. Possible values include: EventGridSchema, CloudEventSchemaV1_0, CustomInputSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventDeliverySchema")]
    public string? EventDeliverySchema { get; set; }

    /// <summary>Specifies the id where the Event Hub is located.</summary>
    [JsonPropertyName("eventhubEndpointId")]
    public string? EventhubEndpointId { get; set; }

    /// <summary>Specifies the expiration time of the event subscription (Datetime Format RFC 3339).</summary>
    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>Specifies the id where the Hybrid Connection is located.</summary>
    [JsonPropertyName("hybridConnectionEndpointId")]
    public string? HybridConnectionEndpointId { get; set; }

    /// <summary>A list of applicable event types that need to be part of the event subscription.</summary>
    [JsonPropertyName("includedEventTypes")]
    public IList<string>? IncludedEventTypes { get; set; }

    /// <summary>A list of labels to assign to the event subscription.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>Specifies the name of the EventGrid Event Subscription resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A retry_policy block as defined below.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2EventSubscriptionSpecInitProviderRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Specifies the scope at which the EventGrid Event Subscription should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta2EventSubscriptionSpecInitProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta2EventSubscriptionSpecInitProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>Specifies the id where the Service Bus Queue is located.</summary>
    [JsonPropertyName("serviceBusQueueEndpointId")]
    public string? ServiceBusQueueEndpointId { get; set; }

    /// <summary>Specifies the id where the Service Bus Topic is located.</summary>
    [JsonPropertyName("serviceBusTopicEndpointId")]
    public string? ServiceBusTopicEndpointId { get; set; }

    /// <summary>A storage_blob_dead_letter_destination block as defined below.</summary>
    [JsonPropertyName("storageBlobDeadLetterDestination")]
    public V1beta2EventSubscriptionSpecInitProviderStorageBlobDeadLetterDestination? StorageBlobDeadLetterDestination { get; set; }

    /// <summary>A storage_queue_endpoint block as defined below.</summary>
    [JsonPropertyName("storageQueueEndpoint")]
    public V1beta2EventSubscriptionSpecInitProviderStorageQueueEndpoint? StorageQueueEndpoint { get; set; }

    /// <summary>A subject_filter block as defined below.</summary>
    [JsonPropertyName("subjectFilter")]
    public V1beta2EventSubscriptionSpecInitProviderSubjectFilter? SubjectFilter { get; set; }

    /// <summary>A webhook_endpoint block as defined below.</summary>
    [JsonPropertyName("webhookEndpoint")]
    public V1beta2EventSubscriptionSpecInitProviderWebhookEndpoint? WebhookEndpoint { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecManagementPoliciesEnum>))]
public enum V1beta2EventSubscriptionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2EventSubscriptionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EventSubscriptionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2EventSubscriptionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EventSubscriptionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EventSubscriptionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EventSubscriptionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>EventSubscriptionSpec defines the desired state of EventSubscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionSpec
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
    public V1beta2EventSubscriptionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2EventSubscriptionSpecForProvider ForProvider { get; set; }

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
    public V1beta2EventSubscriptionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2EventSubscriptionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2EventSubscriptionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2EventSubscriptionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterBoolEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterIsNotNull
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterIsNullOrUndefined
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberGreaterThan
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberGreaterThanOrEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberInRange
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberLessThan
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberLessThanOrEquals
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies a single value to compare to when using a single value operator.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberNotIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberNotInRange
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringBeginsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringContains
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringEndsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringNotBeginsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringNotContains
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringNotEndsWith
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringNotIn
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies an array of values to compare to when using a multiple values operator.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A advanced_filter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAdvancedFilter
{
    /// <summary>Compares a value of an event using a single boolean value.</summary>
    [JsonPropertyName("boolEquals")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterBoolEquals>? BoolEquals { get; set; }

    /// <summary>Evaluates if a value of an event isn&apos;t NULL or undefined.</summary>
    [JsonPropertyName("isNotNull")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterIsNotNull>? IsNotNull { get; set; }

    /// <summary>Evaluates if a value of an event is NULL or undefined.</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterIsNullOrUndefined>? IsNullOrUndefined { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThan")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberGreaterThan>? NumberGreaterThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberGreaterThanOrEquals>? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberIn")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberIn>? NumberIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberInRange")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberInRange>? NumberInRange { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThan")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberLessThan>? NumberLessThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberLessThanOrEquals>? NumberLessThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberNotIn")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberNotIn>? NumberNotIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberNotInRange")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterNumberNotInRange>? NumberNotInRange { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringBeginsWith")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringBeginsWith>? StringBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringContains")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringContains>? StringContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringEndsWith")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringEndsWith>? StringEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringIn")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringIn>? StringIn { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringNotBeginsWith>? StringNotBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotContains")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringNotContains>? StringNotContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringNotEndsWith>? StringNotEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotIn")]
    public IList<V1beta2EventSubscriptionStatusAtProviderAdvancedFilterStringNotIn>? StringNotIn { get; set; }
}

/// <summary>An azure_function_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderAzureFunctionEndpoint
{
    /// <summary>Specifies the ID of the Function where the Event Subscription will receive events. This must be the functions ID in format {function_app.id}/functions/{name}.</summary>
    [JsonPropertyName("functionId")]
    public string? FunctionId { get; set; }

    /// <summary>Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public double? MaxEventsPerBatch { get; set; }

    /// <summary>Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public double? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>A dead_letter_identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderDeadLetterIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for dead lettering. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>A delivery_identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderDeliveryIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for event delivery. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderDeliveryProperty
{
    /// <summary>The name of the header to send on to the destination</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>True if the value is a secret and should be protected, otherwise false. If True, then this value won&apos;t be returned from Azure API calls</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>If the type is Dynamic, then provide the payload field to be used as the value. Valid source fields differ by subscription type.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Either Static or Dynamic</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A retry_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderRetryPolicy
{
    /// <summary>Specifies the time to live (in minutes) for events. Supported range is 1 to 1440. See official documentation for more details.</summary>
    [JsonPropertyName("eventTimeToLive")]
    public double? EventTimeToLive { get; set; }

    /// <summary>Specifies the maximum number of delivery retry attempts for events.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public double? MaxDeliveryAttempts { get; set; }
}

/// <summary>A storage_blob_dead_letter_destination block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderStorageBlobDeadLetterDestination
{
    /// <summary>Specifies the id of the storage account id where the storage blob is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Specifies the name of the Storage blob container that is the destination of the deadletter events.</summary>
    [JsonPropertyName("storageBlobContainerName")]
    public string? StorageBlobContainerName { get; set; }
}

/// <summary>A storage_queue_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderStorageQueueEndpoint
{
    /// <summary>Storage queue message time to live in seconds.</summary>
    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public double? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>Specifies the name of the storage queue where the Event Subscription will receive events.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>Specifies the id of the storage account id where the storage queue is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary>A subject_filter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderSubjectFilter
{
    /// <summary>Specifies if subject_begins_with and subject_ends_with case sensitive. This value</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>A string to filter events for an event subscription based on a resource path prefix.</summary>
    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    /// <summary>A string to filter events for an event subscription based on a resource path suffix.</summary>
    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

/// <summary>A webhook_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProviderWebhookEndpoint
{
    /// <summary>The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in delivery requests.</summary>
    [JsonPropertyName("activeDirectoryAppIdOrUri")]
    public string? ActiveDirectoryAppIdOrUri { get; set; }

    /// <summary>The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests.</summary>
    [JsonPropertyName("activeDirectoryTenantId")]
    public string? ActiveDirectoryTenantId { get; set; }

    /// <summary>(Computed) The base url of the webhook where the Event Subscription will receive events.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public double? MaxEventsPerBatch { get; set; }

    /// <summary>Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public double? PreferredBatchSizeInKilobytes { get; set; }

    /// <summary>Specifies the url of the webhook where the Event Subscription will receive events.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusAtProvider
{
    /// <summary>A advanced_filter block as defined below.</summary>
    [JsonPropertyName("advancedFilter")]
    public V1beta2EventSubscriptionStatusAtProviderAdvancedFilter? AdvancedFilter { get; set; }

    /// <summary>Specifies whether advanced filters should be evaluated against an array of values instead of expecting a singular value. Defaults to false.</summary>
    [JsonPropertyName("advancedFilteringOnArraysEnabled")]
    public bool? AdvancedFilteringOnArraysEnabled { get; set; }

    /// <summary>An azure_function_endpoint block as defined below.</summary>
    [JsonPropertyName("azureFunctionEndpoint")]
    public V1beta2EventSubscriptionStatusAtProviderAzureFunctionEndpoint? AzureFunctionEndpoint { get; set; }

    /// <summary>A dead_letter_identity block as defined below.</summary>
    [JsonPropertyName("deadLetterIdentity")]
    public V1beta2EventSubscriptionStatusAtProviderDeadLetterIdentity? DeadLetterIdentity { get; set; }

    /// <summary>A delivery_identity block as defined below.</summary>
    [JsonPropertyName("deliveryIdentity")]
    public V1beta2EventSubscriptionStatusAtProviderDeliveryIdentity? DeliveryIdentity { get; set; }

    /// <summary>One or more delivery_property blocks as defined below.</summary>
    [JsonPropertyName("deliveryProperty")]
    public IList<V1beta2EventSubscriptionStatusAtProviderDeliveryProperty>? DeliveryProperty { get; set; }

    /// <summary>Specifies the event delivery schema for the event subscription. Possible values include: EventGridSchema, CloudEventSchemaV1_0, CustomInputSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventDeliverySchema")]
    public string? EventDeliverySchema { get; set; }

    /// <summary>Specifies the id where the Event Hub is located.</summary>
    [JsonPropertyName("eventhubEndpointId")]
    public string? EventhubEndpointId { get; set; }

    /// <summary>Specifies the expiration time of the event subscription (Datetime Format RFC 3339).</summary>
    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>Specifies the id where the Hybrid Connection is located.</summary>
    [JsonPropertyName("hybridConnectionEndpointId")]
    public string? HybridConnectionEndpointId { get; set; }

    /// <summary>The ID of the EventGrid Event Subscription.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of applicable event types that need to be part of the event subscription.</summary>
    [JsonPropertyName("includedEventTypes")]
    public IList<string>? IncludedEventTypes { get; set; }

    /// <summary>A list of labels to assign to the event subscription.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>Specifies the name of the EventGrid Event Subscription resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A retry_policy block as defined below.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2EventSubscriptionStatusAtProviderRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Specifies the scope at which the EventGrid Event Subscription should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Specifies the id where the Service Bus Queue is located.</summary>
    [JsonPropertyName("serviceBusQueueEndpointId")]
    public string? ServiceBusQueueEndpointId { get; set; }

    /// <summary>Specifies the id where the Service Bus Topic is located.</summary>
    [JsonPropertyName("serviceBusTopicEndpointId")]
    public string? ServiceBusTopicEndpointId { get; set; }

    /// <summary>A storage_blob_dead_letter_destination block as defined below.</summary>
    [JsonPropertyName("storageBlobDeadLetterDestination")]
    public V1beta2EventSubscriptionStatusAtProviderStorageBlobDeadLetterDestination? StorageBlobDeadLetterDestination { get; set; }

    /// <summary>A storage_queue_endpoint block as defined below.</summary>
    [JsonPropertyName("storageQueueEndpoint")]
    public V1beta2EventSubscriptionStatusAtProviderStorageQueueEndpoint? StorageQueueEndpoint { get; set; }

    /// <summary>A subject_filter block as defined below.</summary>
    [JsonPropertyName("subjectFilter")]
    public V1beta2EventSubscriptionStatusAtProviderSubjectFilter? SubjectFilter { get; set; }

    /// <summary>A webhook_endpoint block as defined below.</summary>
    [JsonPropertyName("webhookEndpoint")]
    public V1beta2EventSubscriptionStatusAtProviderWebhookEndpoint? WebhookEndpoint { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatusConditions
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

/// <summary>EventSubscriptionStatus defines the observed state of EventSubscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EventSubscriptionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2EventSubscriptionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2EventSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>EventSubscription is the Schema for the EventSubscriptions API. Manages an EventGrid Event Subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EventSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2EventSubscriptionSpec>, IStatus<V1beta2EventSubscriptionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EventSubscription";
    public const string KubeGroup = "eventgrid.azure.upbound.io";
    public const string KubePluralName = "eventsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSubscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EventSubscriptionSpec defines the desired state of EventSubscription</summary>
    [JsonPropertyName("spec")]
    public required V1beta2EventSubscriptionSpec Spec { get; set; }

    /// <summary>EventSubscriptionStatus defines the observed state of EventSubscription.</summary>
    [JsonPropertyName("status")]
    public V1beta2EventSubscriptionStatus? Status { get; set; }
}