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
/// <summary>SystemTopicEventSubscription is the Schema for the SystemTopicEventSubscriptions API. Manages an EventGrid System Topic Event Subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SystemTopicEventSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SystemTopicEventSubscription>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SystemTopicEventSubscriptionList";
    public const string KubeGroup = "eventgrid.azure.upbound.io";
    public const string KubePluralName = "systemtopiceventsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SystemTopicEventSubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1SystemTopicEventSubscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1SystemTopicEventSubscription> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecDeletionPolicyEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterBoolEquals
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterIsNotNull
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterIsNullOrUndefined
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberGreaterThan
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberGreaterThanOrEquals
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberIn
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberInRange
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberLessThan
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberLessThanOrEquals
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberNotIn
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberNotInRange
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringBeginsWith
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringContains
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringEndsWith
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringIn
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringNotBeginsWith
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringNotContains
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringNotEndsWith
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringNotIn
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilter
{
    /// <summary>Compares a value of an event using a single boolean value.</summary>
    [JsonPropertyName("boolEquals")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterBoolEquals>? BoolEquals { get; set; }

    /// <summary>Evaluates if a value of an event isn&apos;t NULL or undefined.</summary>
    [JsonPropertyName("isNotNull")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterIsNotNull>? IsNotNull { get; set; }

    /// <summary>Evaluates if a value of an event is NULL or undefined.</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterIsNullOrUndefined>? IsNullOrUndefined { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThan")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberGreaterThan>? NumberGreaterThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberGreaterThanOrEquals>? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberIn")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberIn>? NumberIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberInRange")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberInRange>? NumberInRange { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThan")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberLessThan>? NumberLessThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberLessThanOrEquals>? NumberLessThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberNotIn")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberNotIn>? NumberNotIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberNotInRange")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterNumberNotInRange>? NumberNotInRange { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringBeginsWith")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringBeginsWith>? StringBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringContains")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringContains>? StringContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringEndsWith")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringEndsWith>? StringEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringIn")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringIn>? StringIn { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringNotBeginsWith>? StringNotBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotContains")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringNotContains>? StringNotContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringNotEndsWith>? StringNotEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotIn")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilterStringNotIn>? StringNotIn { get; set; }
}

/// <summary>An azure_function_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderAzureFunctionEndpoint
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderDeadLetterIdentity
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderDeliveryIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for event delivery. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>If the type is Static, then provide the value to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderDeliveryPropertyValueSecretRef
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderDeliveryProperty
{
    /// <summary>The name of the header to send on to the destination.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Set to true if the value is a secret and should be protected, otherwise false. If true then this value won&apos;t be returned from Azure API calls.</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>If the type is Dynamic, then provide the payload field to be used as the value. Valid source fields differ by subscription type.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Either Static or Dynamic.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>If the type is Static, then provide the value to use.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderDeliveryPropertyValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameSelector
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
    public V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A retry_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderRetryPolicy
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderStorageBlobDeadLetterDestination
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in storage to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in storage to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelector
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
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelector
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
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A storage_queue_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpoint
{
    /// <summary>Storage queue message time to live in seconds.</summary>
    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public double? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>Specifies the name of the storage queue where the Event Subscription will receive events.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>Reference to a Queue in storage to populate queueName.</summary>
    [JsonPropertyName("queueNameRef")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameRef? QueueNameRef { get; set; }

    /// <summary>Selector for a Queue in storage to populate queueName.</summary>
    [JsonPropertyName("queueNameSelector")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointQueueNameSelector? QueueNameSelector { get; set; }

    /// <summary>Specifies the id of the storage account id where the storage queue is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpointStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary>A subject_filter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderSubjectFilter
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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicRefPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicRefPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SystemTopic in eventgrid to populate systemTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicSelectorPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicSelectorPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SystemTopic in eventgrid to populate systemTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicSelector
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
    public V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>A webhook_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecForProviderWebhookEndpoint
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
public partial class V1beta1SystemTopicEventSubscriptionSpecForProvider
{
    /// <summary>A advanced_filter block as defined below.</summary>
    [JsonPropertyName("advancedFilter")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderAdvancedFilter? AdvancedFilter { get; set; }

    /// <summary>Specifies whether advanced filters should be evaluated against an array of values instead of expecting a singular value. Defaults to false.</summary>
    [JsonPropertyName("advancedFilteringOnArraysEnabled")]
    public bool? AdvancedFilteringOnArraysEnabled { get; set; }

    /// <summary>An azure_function_endpoint block as defined below.</summary>
    [JsonPropertyName("azureFunctionEndpoint")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderAzureFunctionEndpoint? AzureFunctionEndpoint { get; set; }

    /// <summary>A dead_letter_identity block as defined below.</summary>
    [JsonPropertyName("deadLetterIdentity")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderDeadLetterIdentity? DeadLetterIdentity { get; set; }

    /// <summary>A delivery_identity block as defined below.</summary>
    [JsonPropertyName("deliveryIdentity")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderDeliveryIdentity? DeliveryIdentity { get; set; }

    /// <summary>One or more delivery_property blocks as defined below.</summary>
    [JsonPropertyName("deliveryProperty")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecForProviderDeliveryProperty>? DeliveryProperty { get; set; }

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

    /// <summary>The name of the Resource Group where the System Topic exists. Changing this forces a new Event Subscription to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A retry_policy block as defined below.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Specifies the id where the Service Bus Queue is located.</summary>
    [JsonPropertyName("serviceBusQueueEndpointId")]
    public string? ServiceBusQueueEndpointId { get; set; }

    /// <summary>Specifies the id where the Service Bus Topic is located.</summary>
    [JsonPropertyName("serviceBusTopicEndpointId")]
    public string? ServiceBusTopicEndpointId { get; set; }

    /// <summary>A storage_blob_dead_letter_destination block as defined below.</summary>
    [JsonPropertyName("storageBlobDeadLetterDestination")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageBlobDeadLetterDestination? StorageBlobDeadLetterDestination { get; set; }

    /// <summary>A storage_queue_endpoint block as defined below.</summary>
    [JsonPropertyName("storageQueueEndpoint")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderStorageQueueEndpoint? StorageQueueEndpoint { get; set; }

    /// <summary>A subject_filter block as defined below.</summary>
    [JsonPropertyName("subjectFilter")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderSubjectFilter? SubjectFilter { get; set; }

    /// <summary>The System Topic where the Event Subscription should be created in. Changing this forces a new Event Subscription to be created.</summary>
    [JsonPropertyName("systemTopic")]
    public string? SystemTopic { get; set; }

    /// <summary>Reference to a SystemTopic in eventgrid to populate systemTopic.</summary>
    [JsonPropertyName("systemTopicRef")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicRef? SystemTopicRef { get; set; }

    /// <summary>Selector for a SystemTopic in eventgrid to populate systemTopic.</summary>
    [JsonPropertyName("systemTopicSelector")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderSystemTopicSelector? SystemTopicSelector { get; set; }

    /// <summary>A webhook_endpoint block as defined below.</summary>
    [JsonPropertyName("webhookEndpoint")]
    public V1beta1SystemTopicEventSubscriptionSpecForProviderWebhookEndpoint? WebhookEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterBoolEquals
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterIsNotNull
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterIsNullOrUndefined
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberGreaterThan
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberGreaterThanOrEquals
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberIn
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberInRange
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberLessThan
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberLessThanOrEquals
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberNotIn
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberNotInRange
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringBeginsWith
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringContains
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringEndsWith
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringIn
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringNotBeginsWith
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringNotContains
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringNotEndsWith
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringNotIn
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilter
{
    /// <summary>Compares a value of an event using a single boolean value.</summary>
    [JsonPropertyName("boolEquals")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterBoolEquals>? BoolEquals { get; set; }

    /// <summary>Evaluates if a value of an event isn&apos;t NULL or undefined.</summary>
    [JsonPropertyName("isNotNull")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterIsNotNull>? IsNotNull { get; set; }

    /// <summary>Evaluates if a value of an event is NULL or undefined.</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterIsNullOrUndefined>? IsNullOrUndefined { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThan")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberGreaterThan>? NumberGreaterThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberGreaterThanOrEquals>? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberIn")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberIn>? NumberIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberInRange")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberInRange>? NumberInRange { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThan")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberLessThan>? NumberLessThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberLessThanOrEquals>? NumberLessThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberNotIn")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberNotIn>? NumberNotIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberNotInRange")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterNumberNotInRange>? NumberNotInRange { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringBeginsWith")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringBeginsWith>? StringBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringContains")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringContains>? StringContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringEndsWith")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringEndsWith>? StringEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringIn")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringIn>? StringIn { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringNotBeginsWith>? StringNotBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotContains")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringNotContains>? StringNotContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringNotEndsWith>? StringNotEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotIn")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilterStringNotIn>? StringNotIn { get; set; }
}

/// <summary>An azure_function_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderAzureFunctionEndpoint
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderDeadLetterIdentity
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderDeliveryIdentity
{
    /// <summary>Specifies the type of Managed Service Identity that is used for event delivery. Allowed value is SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>If the type is Static, then provide the value to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderDeliveryPropertyValueSecretRef
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderDeliveryProperty
{
    /// <summary>The name of the header to send on to the destination.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Set to true if the value is a secret and should be protected, otherwise false. If true then this value won&apos;t be returned from Azure API calls.</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>If the type is Dynamic, then provide the payload field to be used as the value. Valid source fields differ by subscription type.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Either Static or Dynamic.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>If the type is Static, then provide the value to use.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderDeliveryPropertyValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>A retry_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderRetryPolicy
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageBlobDeadLetterDestination
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in storage to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in storage to populate queueName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelector
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
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelector
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
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A storage_queue_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpoint
{
    /// <summary>Storage queue message time to live in seconds.</summary>
    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public double? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>Specifies the name of the storage queue where the Event Subscription will receive events.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>Reference to a Queue in storage to populate queueName.</summary>
    [JsonPropertyName("queueNameRef")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameRef? QueueNameRef { get; set; }

    /// <summary>Selector for a Queue in storage to populate queueName.</summary>
    [JsonPropertyName("queueNameSelector")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointQueueNameSelector? QueueNameSelector { get; set; }

    /// <summary>Specifies the id of the storage account id where the storage queue is located.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpointStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary>A subject_filter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderSubjectFilter
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProviderWebhookEndpoint
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
public partial class V1beta1SystemTopicEventSubscriptionSpecInitProvider
{
    /// <summary>A advanced_filter block as defined below.</summary>
    [JsonPropertyName("advancedFilter")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderAdvancedFilter? AdvancedFilter { get; set; }

    /// <summary>Specifies whether advanced filters should be evaluated against an array of values instead of expecting a singular value. Defaults to false.</summary>
    [JsonPropertyName("advancedFilteringOnArraysEnabled")]
    public bool? AdvancedFilteringOnArraysEnabled { get; set; }

    /// <summary>An azure_function_endpoint block as defined below.</summary>
    [JsonPropertyName("azureFunctionEndpoint")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderAzureFunctionEndpoint? AzureFunctionEndpoint { get; set; }

    /// <summary>A dead_letter_identity block as defined below.</summary>
    [JsonPropertyName("deadLetterIdentity")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderDeadLetterIdentity? DeadLetterIdentity { get; set; }

    /// <summary>A delivery_identity block as defined below.</summary>
    [JsonPropertyName("deliveryIdentity")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderDeliveryIdentity? DeliveryIdentity { get; set; }

    /// <summary>One or more delivery_property blocks as defined below.</summary>
    [JsonPropertyName("deliveryProperty")]
    public IList<V1beta1SystemTopicEventSubscriptionSpecInitProviderDeliveryProperty>? DeliveryProperty { get; set; }

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

    /// <summary>A retry_policy block as defined below.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Specifies the id where the Service Bus Queue is located.</summary>
    [JsonPropertyName("serviceBusQueueEndpointId")]
    public string? ServiceBusQueueEndpointId { get; set; }

    /// <summary>Specifies the id where the Service Bus Topic is located.</summary>
    [JsonPropertyName("serviceBusTopicEndpointId")]
    public string? ServiceBusTopicEndpointId { get; set; }

    /// <summary>A storage_blob_dead_letter_destination block as defined below.</summary>
    [JsonPropertyName("storageBlobDeadLetterDestination")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageBlobDeadLetterDestination? StorageBlobDeadLetterDestination { get; set; }

    /// <summary>A storage_queue_endpoint block as defined below.</summary>
    [JsonPropertyName("storageQueueEndpoint")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderStorageQueueEndpoint? StorageQueueEndpoint { get; set; }

    /// <summary>A subject_filter block as defined below.</summary>
    [JsonPropertyName("subjectFilter")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderSubjectFilter? SubjectFilter { get; set; }

    /// <summary>A webhook_endpoint block as defined below.</summary>
    [JsonPropertyName("webhookEndpoint")]
    public V1beta1SystemTopicEventSubscriptionSpecInitProviderWebhookEndpoint? WebhookEndpoint { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecManagementPoliciesEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SystemTopicEventSubscriptionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1SystemTopicEventSubscriptionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SystemTopicEventSubscriptionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SystemTopicEventSubscriptionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SystemTopicEventSubscriptionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SystemTopicEventSubscriptionSpec defines the desired state of SystemTopicEventSubscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionSpec
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
    public V1beta1SystemTopicEventSubscriptionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1SystemTopicEventSubscriptionSpecForProvider ForProvider { get; set; }

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
    public V1beta1SystemTopicEventSubscriptionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1SystemTopicEventSubscriptionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SystemTopicEventSubscriptionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SystemTopicEventSubscriptionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterBoolEquals
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterIsNotNull
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterIsNullOrUndefined
{
    /// <summary>Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberGreaterThan
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberGreaterThanOrEquals
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberIn
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberInRange
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberLessThan
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberLessThanOrEquals
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberNotIn
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberNotInRange
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringBeginsWith
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringContains
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringEndsWith
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringIn
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringNotBeginsWith
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringNotContains
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringNotEndsWith
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringNotIn
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilter
{
    /// <summary>Compares a value of an event using a single boolean value.</summary>
    [JsonPropertyName("boolEquals")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterBoolEquals>? BoolEquals { get; set; }

    /// <summary>Evaluates if a value of an event isn&apos;t NULL or undefined.</summary>
    [JsonPropertyName("isNotNull")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterIsNotNull>? IsNotNull { get; set; }

    /// <summary>Evaluates if a value of an event is NULL or undefined.</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterIsNullOrUndefined>? IsNullOrUndefined { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThan")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberGreaterThan>? NumberGreaterThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberGreaterThanOrEquals>? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberIn")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberIn>? NumberIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberInRange")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberInRange>? NumberInRange { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThan")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberLessThan>? NumberLessThan { get; set; }

    /// <summary>Compares a value of an event using a single floating point number.</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberLessThanOrEquals>? NumberLessThanOrEquals { get; set; }

    /// <summary>Compares a value of an event using multiple floating point numbers.</summary>
    [JsonPropertyName("numberNotIn")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberNotIn>? NumberNotIn { get; set; }

    /// <summary>Compares a value of an event using multiple floating point number ranges.</summary>
    [JsonPropertyName("numberNotInRange")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterNumberNotInRange>? NumberNotInRange { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringBeginsWith")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringBeginsWith>? StringBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringContains")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringContains>? StringContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringEndsWith")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringEndsWith>? StringEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringIn")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringIn>? StringIn { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringNotBeginsWith>? StringNotBeginsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotContains")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringNotContains>? StringNotContains { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringNotEndsWith>? StringNotEndsWith { get; set; }

    /// <summary>Compares a value of an event using multiple string values.</summary>
    [JsonPropertyName("stringNotIn")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilterStringNotIn>? StringNotIn { get; set; }
}

/// <summary>An azure_function_endpoint block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderAzureFunctionEndpoint
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderDeadLetterIdentity
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderDeliveryIdentity
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderDeliveryProperty
{
    /// <summary>The name of the header to send on to the destination.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Set to true if the value is a secret and should be protected, otherwise false. If true then this value won&apos;t be returned from Azure API calls.</summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    /// <summary>If the type is Dynamic, then provide the payload field to be used as the value. Valid source fields differ by subscription type.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Either Static or Dynamic.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A retry_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderRetryPolicy
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderStorageBlobDeadLetterDestination
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderStorageQueueEndpoint
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderSubjectFilter
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProviderWebhookEndpoint
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
public partial class V1beta1SystemTopicEventSubscriptionStatusAtProvider
{
    /// <summary>A advanced_filter block as defined below.</summary>
    [JsonPropertyName("advancedFilter")]
    public V1beta1SystemTopicEventSubscriptionStatusAtProviderAdvancedFilter? AdvancedFilter { get; set; }

    /// <summary>Specifies whether advanced filters should be evaluated against an array of values instead of expecting a singular value. Defaults to false.</summary>
    [JsonPropertyName("advancedFilteringOnArraysEnabled")]
    public bool? AdvancedFilteringOnArraysEnabled { get; set; }

    /// <summary>An azure_function_endpoint block as defined below.</summary>
    [JsonPropertyName("azureFunctionEndpoint")]
    public V1beta1SystemTopicEventSubscriptionStatusAtProviderAzureFunctionEndpoint? AzureFunctionEndpoint { get; set; }

    /// <summary>A dead_letter_identity block as defined below.</summary>
    [JsonPropertyName("deadLetterIdentity")]
    public V1beta1SystemTopicEventSubscriptionStatusAtProviderDeadLetterIdentity? DeadLetterIdentity { get; set; }

    /// <summary>A delivery_identity block as defined below.</summary>
    [JsonPropertyName("deliveryIdentity")]
    public V1beta1SystemTopicEventSubscriptionStatusAtProviderDeliveryIdentity? DeliveryIdentity { get; set; }

    /// <summary>One or more delivery_property blocks as defined below.</summary>
    [JsonPropertyName("deliveryProperty")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusAtProviderDeliveryProperty>? DeliveryProperty { get; set; }

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

    /// <summary>The ID of the EventGrid System Topic.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of applicable event types that need to be part of the event subscription.</summary>
    [JsonPropertyName("includedEventTypes")]
    public IList<string>? IncludedEventTypes { get; set; }

    /// <summary>A list of labels to assign to the event subscription.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>The name of the Resource Group where the System Topic exists. Changing this forces a new Event Subscription to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A retry_policy block as defined below.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1SystemTopicEventSubscriptionStatusAtProviderRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Specifies the id where the Service Bus Queue is located.</summary>
    [JsonPropertyName("serviceBusQueueEndpointId")]
    public string? ServiceBusQueueEndpointId { get; set; }

    /// <summary>Specifies the id where the Service Bus Topic is located.</summary>
    [JsonPropertyName("serviceBusTopicEndpointId")]
    public string? ServiceBusTopicEndpointId { get; set; }

    /// <summary>A storage_blob_dead_letter_destination block as defined below.</summary>
    [JsonPropertyName("storageBlobDeadLetterDestination")]
    public V1beta1SystemTopicEventSubscriptionStatusAtProviderStorageBlobDeadLetterDestination? StorageBlobDeadLetterDestination { get; set; }

    /// <summary>A storage_queue_endpoint block as defined below.</summary>
    [JsonPropertyName("storageQueueEndpoint")]
    public V1beta1SystemTopicEventSubscriptionStatusAtProviderStorageQueueEndpoint? StorageQueueEndpoint { get; set; }

    /// <summary>A subject_filter block as defined below.</summary>
    [JsonPropertyName("subjectFilter")]
    public V1beta1SystemTopicEventSubscriptionStatusAtProviderSubjectFilter? SubjectFilter { get; set; }

    /// <summary>The System Topic where the Event Subscription should be created in. Changing this forces a new Event Subscription to be created.</summary>
    [JsonPropertyName("systemTopic")]
    public string? SystemTopic { get; set; }

    /// <summary>A webhook_endpoint block as defined below.</summary>
    [JsonPropertyName("webhookEndpoint")]
    public V1beta1SystemTopicEventSubscriptionStatusAtProviderWebhookEndpoint? WebhookEndpoint { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionStatusConditions
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

/// <summary>SystemTopicEventSubscriptionStatus defines the observed state of SystemTopicEventSubscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SystemTopicEventSubscriptionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1SystemTopicEventSubscriptionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SystemTopicEventSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SystemTopicEventSubscription is the Schema for the SystemTopicEventSubscriptions API. Manages an EventGrid System Topic Event Subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SystemTopicEventSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SystemTopicEventSubscriptionSpec>, IStatus<V1beta1SystemTopicEventSubscriptionStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SystemTopicEventSubscription";
    public const string KubeGroup = "eventgrid.azure.upbound.io";
    public const string KubePluralName = "systemtopiceventsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SystemTopicEventSubscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SystemTopicEventSubscriptionSpec defines the desired state of SystemTopicEventSubscription</summary>
    [JsonPropertyName("spec")]
    public required V1beta1SystemTopicEventSubscriptionSpec Spec { get; set; }

    /// <summary>SystemTopicEventSubscriptionStatus defines the observed state of SystemTopicEventSubscription.</summary>
    [JsonPropertyName("status")]
    public V1beta1SystemTopicEventSubscriptionStatus? Status { get; set; }
}